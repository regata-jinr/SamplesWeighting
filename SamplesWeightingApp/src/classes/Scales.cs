/***************************************************************************
 *                                                                         *
 *                                                                         *
 * Copyright(c) 2017-2020, REGATA Experiment at FLNP|JINR                  *
 * Author: [Boris Rumyantsev](mailto:bdrum@jinr.ru)                        *
 * All rights reserved                                                     *
 *                                                                         *
 *                                                                         *
 ***************************************************************************/

using System;
using System.Globalization;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Linq;


namespace SamplesWeighting
{
    public static class Scales 
    {
        private static SerialPort port;
        //double weight;

        static Scales()
        {
            try
            {
                Debug.WriteLine($"Trying to connect to the scales:");
                string com = FindScales();
                Debug.WriteLine($"The port number is '{com}'");
                if (string.IsNullOrEmpty(com))
                {
                    MessageBox.Show("The scales are not found! Please Check the list of available devices.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                port = new SerialPort(com, 9600, Parity.None, 8, StopBits.One);
                //port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            }
            catch (UnauthorizedAccessException)
            { MessageBox.Show("The scales in the sleep mode or we be not able to connect to it. Try to enable it.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex)
            { MessageBox.Show($"Exception has occurred in process of getting the data from scales:\n {ex.ToString()}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    Match match = Regex.Match(port.ReadLine(), "^.*([0-9]+\\.[0-9]+).*$");
        //    if (match.Success)
        //        weight = Convert.ToDouble(match.Groups[1].Value, CultureInfo.InvariantCulture);
        //    Debug.WriteLine($"Reading weight is {weight.ToString()}");
        //    return;
        //}

        public static float GetWeight()
        {
            try
            {
                if (port == null) throw new InvalidOperationException("Can't get data from the scales!");
                port.Open();
                float weight = -1.0f;
                Match match = Regex.Match(port.ReadLine(), "^.*([0-9]+\\.[0-9]+).*$");
                if (match.Success)
                {
                    weight = Convert.ToSingle(match.Groups[1].Value, CultureInfo.InvariantCulture);
                    Debug.WriteLine($"Reading weight is {weight}");
                }
                else
                {
                    throw new InvalidOperationException("Can't get data from the scales!");
                }
                return weight;
            }
            finally 
            {
                if (port != null && port.IsOpen) port.Close();
            }
        }

        private static string FindScales()
        {
            foreach (var portName in SerialPort.GetPortNames())
            {
                if (portName.Contains("DN02GDZ6A"))
                    return Regex.Match(portName, @"\(([^)]*)\)").Groups[1].Value;
            }
            return "";
        }

    } // public class Scales : IDisposable
} // namespace SamplesWeighting

