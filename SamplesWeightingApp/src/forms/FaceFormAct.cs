﻿/***************************************************************************
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
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

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
            SetUpColumns(ref dataGridView_Samples, typeof(SamplesSet));
            ColorizeAndSelect(dataGridView_Samples);
            dataGridView_Samples.Focus();
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
            SetUpColumns(ref dataGridView_Monitors, typeof(MonitorsSet));
            ColorizeAndSelect(dataGridView_Monitors);
            dataGridView_Monitors.Focus();
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
            SetUpColumns(ref dataGridView_Standarts, typeof(SRMsSet));
            ColorizeAndSelect(dataGridView_Standarts);
            dataGridView_Standarts.Focus();
        }

        private void DataGridView_Journals_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_Irradiations.DataSource = null;
            if (dataGridView_Journals.SelectedRows.Count <= 0) return;

            var selectedRow = dataGridView_Journals.SelectedRows[0];

            var ln = (int)selectedRow.Cells[1].Value;

            _irads = _wc.Irradiations.FromSqlInterpolated($"exec reweighting_data {ln}").ToList();

            dataGridView_Irradiations.DataSource = _irads;

            SetLanguageToObject(dataGridView_Irradiations);
            SetUpColumns(ref dataGridView_Irradiations, typeof(Irradiation), true);
            ColorizeAndSelect(dataGridView_Irradiations);
            dataGridView_Irradiations.Focus();
        }

        private void SetUpColumns(ref DataGridView dgv, Type sets, bool visible = false)
        {
            foreach (var sampSetProp in sets.GetProperties())
                dgv.Columns[sampSetProp.Name].Visible = visible;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (!col.Name.Contains("Weight"))
                    col.ReadOnly = true;
            }
        }

        private bool m_isExiting = false; // BUG: without this FaceForm_FormClosing will call twice
        private void FaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!m_isExiting)
            {
                DialogResult d = MessageBox.Show(ConfigurationManager.config[$"formClosing:{lang}:msg"], ConfigurationManager.config[$"formClosing:{lang}:cpt"], MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (d == DialogResult.Yes)
                {
                    m_isExiting = true;
                    Application.Exit();
                }
                else e.Cancel = true;
            }
        }

        private void ButtonReadWeight_Click(object sender, EventArgs e)
        {
            var unitDgv = tabDgvs[tabs.SelectedTab.Name];

            try
            {
                buttonReadWeight.Enabled = false;
                currRowIndex = unitDgv.CurrentCellAddress.Y;
                currColIndex = unitDgv.CurrentCellAddress.X;
                if (unitDgv.DataSource == null)
                {
                    MessageBox.Show("Please choose one of the lines from the top table.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //unitDgv.Rows[currRowIndex].Cells[currColIndex].Value = Weighting();

                if (radioButtonTypeBoth.Checked)
                {
                    if (unitDgv.Columns[currColIndex].Name.Contains("LLI"))
                    {
                        if ((currRowIndex + 1) == unitDgv.RowCount) return;
                        unitDgv.CurrentCell = unitDgv.Rows[currRowIndex + 1].Cells[currColIndex - 1];
                        unitDgv.Rows[currRowIndex + 1].Cells[currColIndex - 1].Selected = true;
                    }
                    else if (unitDgv.Columns[currColIndex].Name.Contains("SLI"))
                    {
                        unitDgv.CurrentCell = unitDgv.Rows[currRowIndex].Cells[currColIndex + 1];
                        unitDgv.Rows[currRowIndex].Cells[currColIndex + 1].Selected = true;
                    }
                }
                else
                {
                    if ((currRowIndex + 1) == unitDgv.RowCount) return;
                    unitDgv.CurrentCell = unitDgv.Rows[currRowIndex + 1].Cells[currColIndex];
                    unitDgv.Rows[currRowIndex + 1].Cells[currColIndex].Selected = true;
                }
            }
            finally
            {
                //PrepareForSavingFile(false);
                buttonReadWeight.Enabled = true;
                unitDgv.Focus();
            }
        }

        private void RadioButtonsCheckedChanges(object sender, EventArgs e)
        {
            var dgv = tabDgvs[tabs.SelectedTab.Name];
            if (dgv.RowCount == 0) return;
            int sliColIndex = 0, lliColIndex = 0;
            currRowIndex = dgv.CurrentCell.RowIndex;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Name.Contains("SLI")) sliColIndex = col.Index;
                if (col.Name.Contains("LLI")) lliColIndex = col.Index;
            }

            if (radioButtonTypeBoth.Checked || radioButtonTypeSLI.Checked)
            {
                dgv.CurrentCell = dgv.Rows[currRowIndex].Cells[sliColIndex];
                dgv.Rows[currRowIndex].Cells[sliColIndex].Selected = true;
            }
            else
            {
                dgv.CurrentCell = dgv.Rows[currRowIndex].Cells[sliColIndex];
                dgv.Rows[currRowIndex].Cells[lliColIndex].Selected = true;
            }
        }

        private void CommonSelectionMechanics(object sender, EventArgs e)
        {
            var dgv = tabDgvs[tabs.SelectedTab.Name];
            if (dgv.CurrentCell == null) return;
            Debug.WriteLine($"Start selection mech:");
            currRowIndex = dgv.CurrentCellAddress.Y;
            currColIndex = dgv.CurrentCellAddress.X;
            Debug.WriteLine($"Initial position: row-{currRowIndex}, col-{currColIndex}");
            int sliColIndex = 0, lliColIndex = 0;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Name.Contains("SLI")) sliColIndex = col.Index;
                if (col.Name.Contains("LLI")) lliColIndex = col.Index;
            }

            if (radioButtonTypeBoth.Checked && !dgv.Columns[currColIndex].Name.Contains("LLI") && !dgv.Columns[currColIndex].Name.Contains("SLI"))
            {
                Debug.WriteLine($"See that both types checked and non weight cell chosen:");
                Debug.WriteLine($"Current position: row-{currRowIndex}, col-{sliColIndex}");
                dgv.CurrentCell = dgv.Rows[currRowIndex].Cells[sliColIndex];
                dgv.Rows[currRowIndex].Cells[sliColIndex].Selected = true;
            }
            else if (radioButtonTypeSLI.Checked && !dgv.Columns[currColIndex].Name.Contains("SLI"))
            {
                Debug.WriteLine($"See that SLI types checked and non sli-weight cell chosen:");
                Debug.WriteLine($"Current position: row-{currRowIndex}, col-{sliColIndex}");
                dgv.CurrentCell = dgv.Rows[currRowIndex].Cells[sliColIndex];
                dgv.Rows[currRowIndex].Cells[sliColIndex].Selected = true;
            }
            else if (radioButtonTypeLLI.Checked && !dgv.Columns[currColIndex].Name.Contains("LLI"))
            {
                Debug.WriteLine($"See that LLI types checked and non lli-weight cell chosen:");
                Debug.WriteLine($"Current position: row-{currRowIndex}, col-{lliColIndex}");
                dgv.CurrentCell = dgv.Rows[currRowIndex].Cells[lliColIndex];
                dgv.Rows[currRowIndex].Cells[lliColIndex].Selected = true;
            }

            DataGridViewCellStyle styleWhite = new DataGridViewCellStyle();
            styleWhite.BackColor = Color.White;
            DataGridViewCellStyle styleGray = new DataGridViewCellStyle();
            styleGray.BackColor = Color.LightGray;

            if (dgv.SelectedCells.Count != 1) return;

            for (int r = 0; r < dgv.RowCount; ++r)
            {
                if (r == dgv.SelectedCells[0].RowIndex)
                {
                    dgv.Rows[dgv.SelectedCells[0].RowIndex].Cells[0].Style = styleGray;
                    continue;
                }
                dgv.Rows[r].Cells[0].Style = styleWhite;
            }
        }

        private void FaceForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                if (buttonReadWeight.Enabled) buttonReadWeight.PerformClick();
        }

        private void ColorizeAndSelect(DataGridView dgv)
        {
            var isFirst = true;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Name.Contains("Weight"))
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        dgv.Rows[row.Index].Cells[col.Index].Style.BackColor = Color.PaleTurquoise;
                        var currValue = dgv.Rows[row.Index].Cells[col.Index].Value;

                        var isCurrValueNullorZero = (currValue is null);
                        if (!isCurrValueNullorZero) isCurrValueNullorZero = (currValue.ToString() == "0");

                        if (isCurrValueNullorZero && isFirst)
                        {
                            if (radioButtonTypeBoth.Checked) dgv.CurrentCell = dgv.Rows[row.Index].Cells[col.Index];
                            if (radioButtonTypeSLI.Checked) dgv.CurrentCell = dgv.Rows[row.Index].Cells[dgv.ColumnCount - 2];
                            if (radioButtonTypeLLI.Checked) dgv.CurrentCell = dgv.Rows[row.Index].Cells[dgv.ColumnCount - 1];
                            isFirst = false;
                        }
                    }
                }
                if (isFirst && !dgv.Name.Contains("Set") && dgv.RowCount != 0) dgv.ClearSelection();
            }
        }

        private void DataGridView_Irradiations_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Irradiations.SelectedCells.Count <= 0)
                return;

            var selectedRow = dataGridView_Irradiations.SelectedRows[0];
            labelNameSampl.Text = $"{selectedRow.Cells[3].Value}-{selectedRow.Cells[4].Value}-{selectedRow.Cells[5].Value}";
        }

    } // public partial class FaceForm : Form
} // namespace SamplesWeighting