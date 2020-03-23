/***************************************************************************
 *                                                                         *
 *                                                                         *
 * Copyright(c) 2017-2020, REGATA Experiment at FLNP|JINR                  *
 * Author: [Boris Rumyantsev](mailto:bdrum@jinr.ru)                        *
 * All rights reserved                                                     *
 *                                                                         *
 *                                                                         *
 ***************************************************************************/

// This files contains methods that handle events from the main file and control the behaviour of application.

// FaceForm class divided by few files:
// ├──FaceForm.cs     --> Contains initialisation of basic types and parameters.
// └──FaceFormAct.cs  --> opened

using System.Windows.Forms;
using System;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Linq;
using System.Diagnostics;

namespace SamplesWeighting
{
    public partial class FaceForm : Form
    {
        private void LangStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            var langStrip = sender as ToolStripMenuItem;

            if (langStrip.Checked && langStrip.Name == englishToolStripMenuItem.Name)
            {
                lang = "eng";
                russianToolStripMenuItem.Checked = false;
            }

            if (langStrip.Checked && langStrip.Name == russianToolStripMenuItem.Name)
            {
                lang = "rus";
                englishToolStripMenuItem.Checked = false;
            }

            SetLanguageToControls(Controls);
        }

        private void DataGridView_SamplesSet_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_Samples.DataSource = null;
            if (dataGridView_SamplesSet.SelectedRows.Count <= 0) return;

            var selectedRow = dataGridView_SamplesSet.SelectedRows[0];

            _samples = _wc.Samples.Where(s =>
                                    s.Country_Code     == selectedRow.Cells["Country_Code"].Value.ToString() &&
                                    s.Client_Id        == selectedRow.Cells["Client_Id"].Value.ToString() &&
                                    s.Year             == selectedRow.Cells["Year"].Value.ToString() &&
                                    s.Sample_Set_Id    == selectedRow.Cells["Sample_Set_Id"].Value.ToString() &&
                                    s.Sample_Set_Index == selectedRow.Cells["Sample_Set_Index"].Value.ToString()
                                ).ToList();

            dataGridView_Samples.DataSource = _samples;

            SetLanguageToObject(dataGridView_Samples);
            HideColumns(ref dataGridView_Samples, typeof(SamplesSet));
        }

        private void DataGridView_MonitorsSet_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_Monitors.DataSource = null;
            if (dataGridView_MonitorsSet.SelectedRows.Count <= 0) return;

            var selectedRow = dataGridView_MonitorsSet.SelectedRows[0];

            _monitors = _wc.Monitors.Where(m =>
                                    m.Monitor_Set_Name== selectedRow.Cells["Monitor_Set_Name"].Value.ToString() &&
                                    m.Monitor_Set_Number == selectedRow.Cells["Monitor_Set_Number"].Value.ToString()
                                ).ToList();

            dataGridView_Monitors.DataSource = _monitors;

            SetLanguageToObject(dataGridView_Monitors);
            HideColumns(ref dataGridView_Monitors, typeof(MonitorsSet));
        }

        private void DataGridView_StandartsSet_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_Standarts.DataSource = null;
            if (dataGridView_StandartsSet.SelectedRows.Count <= 0) return;

            var selectedRow = dataGridView_StandartsSet.SelectedRows[0];

            _srms = _wc.SRMs.Where(s =>
                                    s.SRM_Set_Name == selectedRow.Cells["SRM_Set_Name"].Value.ToString() &&
                                    s.SRM_Set_Number== selectedRow.Cells["SRM_Set_Number"].Value.ToString()
                                ).ToList();

            dataGridView_Standarts.DataSource = _srms;

            SetLanguageToObject(dataGridView_Standarts);
            HideColumns(ref dataGridView_Standarts, typeof(SRMsSet));
        }

        private void HideColumns(ref DataGridView dgv, Type sets)
        {
            foreach (var sampSetProp in sets.GetProperties())
                dgv.Columns[sampSetProp.Name].Visible = false;

        }
    } // public partial class FaceForm : Form
} // namespace SamplesWeighting