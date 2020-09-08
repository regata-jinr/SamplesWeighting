/***************************************************************************
 *                                                                         *
 *                                                                         *
 * Copyright(c) 2017-2020, REGATA Experiment at FLNP|JINR                  *
 * Author: [Boris Rumyantsev](mailto:bdrum@jinr.ru)                        *
 * All rights reserved                                                     *
 *                                                                         *
 *                                                                         *
 ***************************************************************************/

// This file aims to initializations of the application main window and contains initialisations of instances, bindings and subscriptions to different events, that using during the work process.

// FaceForm class divided by few files:
// ├──FaceForm.cs     --> opened
// └──FaceFormAct.cs  --> Contains methods that handle events from the main file

using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

// TODO: Changing in the table should be automatically upload to db?
// TODO: Changing in the table should be automatically upload to file, Year/SamplesSetKey.ves
// TODO: Use csvhelper for ORM
// TODO: keep the functional from previous version
// TODO: after weighting at least one sample preparation phase should be closed
// TODO: chosen language should be save into config file
// TODO: add new auto update process
// TODO: add github actions for ci/cd
// TODO: add tests via winappdriver

namespace SamplesWeighting
{
    public partial class FaceForm : Form
    {
        private readonly WeightingContext  _wc;
        private readonly List<MonitorsSet> _monitorSets;
        private readonly List<SRMsSet>     _srmSets;
        private readonly List<SamplesSet>  _sampleSets;
        private readonly List<Register> _registers;

        private string lang = ConfigurationManager.config["language"];

        private List<Irradiation>     _irads;
        private List<SRM>             _srms;
        private List<Monitor>         _monitors;
        private List<Sample>          _samples;
        
        private int currRowIndex = 0, currColIndex = 0;

        private Dictionary<string, DataGridView> tabDgvs = new Dictionary<string, DataGridView>();


        private void Binding()
        {
            //dataGridView_SamplesSet.DataSource   = _sampleSets;
            //dataGridView_MonitorsSet.DataSource  = _monitorSets;
            //dataGridView_StandartsSet.DataSource = _srmSets;
            //dataGridView_Monitors.DataSource     = _monitors;
            //dataGridView_Samples.DataSource      = _samples;
            //dataGridView_Standarts.DataSource    = _srms;
            dataGridView_Journals.DataSource       = _registers;

            //dataGridView_SamplesSet.CurrentCell  = dataGridView_SamplesSet[0, dataGridView_SamplesSet.RowCount - 1];
            //dataGridView_Journals.CurrentCell  = dataGridView_Journals[0, dataGridView_SamplesSet.RowCount - 1];

            tabDgvs.Add("tabSamples", dataGridView_Samples);
            tabDgvs.Add("tabStandarts", dataGridView_Standarts);
            tabDgvs.Add("tabMonitors", dataGridView_Monitors);
            tabDgvs.Add("tabIrradiations", dataGridView_Irradiations);

        }

        public FaceForm()
        {
            InitializeComponent();

            tabs.TabPages.Remove(tabSamples);
            tabs.TabPages.Remove(tabMonitors);
            tabs.TabPages.Remove(tabStandarts);
            if (lang == "eng")
                englishToolStripMenuItem.Checked = true;
            else
                russianToolStripMenuItem.Checked = true;

            _wc = new WeightingContext();

            _sampleSets  = _wc.SamplesSets.AsNoTracking().
                                           OrderBy(ss => ss.Year).
                                           ThenBy(ss => ss.Sample_Set_Id).
                                           ThenBy(ss => ss.Sample_Set_Index).
                                           ToList();

            _monitorSets = _wc.MonitorsSets.AsNoTracking().
                                            OrderBy(ms => ms.Monitor_Set_Name).
                                            ThenBy(ms => ms.Monitor_Set_Number).
                                            ToList();

            _srmSets     = _wc.SRMsSets.AsNoTracking().
                                        OrderBy(ss => ss.SRM_Set_Name).
                                        ThenBy(ss => ss.SRM_Set_Number).
                                        ToList();

            _registers = _wc.Registers.Where(i => i.loadNumber != null).
                                    Distinct().
                                    OrderByDescending(i=>i.loadNumber).
                                    ToList();

            _samples  = new List<Sample>();
            _srms     = new List<SRM>();
            _monitors = new List<Monitor>();
            _irads    = new List<Irradiation>();

            Binding();

            SetLanguageToControls(Controls);

            dataGridView_SamplesSet.SelectionChanged   += DataGridView_SamplesSet_SelectionChanged;
            dataGridView_MonitorsSet.SelectionChanged  += DataGridView_MonitorsSet_SelectionChanged;
            dataGridView_StandartsSet.SelectionChanged += DataGridView_StandartsSet_SelectionChanged;
            dataGridView_Journals.SelectionChanged     += DataGridView_Journals_SelectionChanged;
            englishToolStripMenuItem.CheckedChanged    += LangStripMenuItem_CheckedChanged;
            russianToolStripMenuItem.CheckedChanged    += LangStripMenuItem_CheckedChanged;
            buttonReadWeight.Click                     += ButtonReadWeight_Click;
            FormClosing                                += FaceForm_FormClosing;
            KeyPress                                   += FaceForm_KeyPress;
            radioButtonTypeBoth.CheckedChanged         += RadioButtonsCheckedChanges;
            radioButtonTypeSLI.CheckedChanged          += RadioButtonsCheckedChanges;
            radioButtonTypeLLI.CheckedChanged          += RadioButtonsCheckedChanges;
            dataGridView_Samples.SelectionChanged      += CommonSelectionMechanics;
            dataGridView_Monitors.SelectionChanged     += CommonSelectionMechanics;
            dataGridView_Standarts.SelectionChanged    += CommonSelectionMechanics;
            dataGridView_Samples.KeyPress              += FaceForm_KeyPress;
            dataGridView_Monitors.KeyPress             += FaceForm_KeyPress;
            dataGridView_Standarts.KeyPress            += FaceForm_KeyPress;
            dataGridView_Irradiations.SelectionChanged += DataGridView_Irradiations_SelectionChanged;
        }

        private void SetLanguageToControls(Control.ControlCollection controls)
        {
            var vers = GetType().Assembly.GetName().Version;
            Text = $"{ConfigurationManager.config[$"{this.Name}:{lang}"]} - {vers.Major.ToString()}.{vers.Minor.ToString()}.{vers.Build.ToString()}";
            foreach (var cont in controls)
                SetLanguageToObject(cont);
        }

        private void SetLanguageToObject(object cont)
        {
            switch (cont)
            {
                case GroupBox grpb:
                    grpb.Text = ConfigurationManager.config[$"{grpb.Name}:{lang}"];
                    SetLanguageToControls(grpb.Controls);
                    break;

                case TableLayoutPanel tblp:
                    SetLanguageToControls(tableLayoutPanelWeight.Controls);
                    break;

                case TabControl tbcont:
                    foreach (TabPage page in tbcont.TabPages)
                    {
                        page.Text = ConfigurationManager.config[$"{page.Name}:{lang}"];
                        SetLanguageToControls( page.Controls);
                    }
                    break;

                case DataGridView dgv:
                    foreach (DataGridViewColumn col in dgv.Columns)
                        col.HeaderText = ConfigurationManager.config[$"{col.Name}:{lang}"];
                    break;

                case MenuStrip ms:
                    foreach (ToolStripMenuItem item in ms.Items)
                        SetLanguageToObject(item);
                    break;

                case ToolStripMenuItem tsi:
                    tsi.Text = ConfigurationManager.config[$"{tsi.Name}:{lang}"];
                    foreach (ToolStripMenuItem innerTsi in tsi.DropDownItems)
                        SetLanguageToObject(innerTsi);
                    break;

                default:
                    var getName = cont.GetType().GetProperty("Name").GetGetMethod();
                    var setText = cont.GetType().GetProperty("Text").GetSetMethod();

                    setText.Invoke(cont, new object[] { ConfigurationManager.config[$"{getName.Invoke(cont, null)}:{lang}"] });
                    break;

                case null:
                    throw new ArgumentNullException("Have trying to set language for null control");
            }
        }

    } // public partial class FaceForm : Form
} // namespace SamplesWeighting

