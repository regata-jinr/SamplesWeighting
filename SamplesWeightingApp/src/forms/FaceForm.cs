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
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

// TODO: Changing in the table should be automatically upload to db?
// TODO: Changing in the table should be automatically upload to file, Year/Month/SamplesSet.ves
// TODO: Use csvhelper for ORM
// TODO: keep the functional from previous version
// TODO: add mechnism of weighting for selected cell
// TODO: hit the space should be event for weighting independent from button focus - accept button?
// TODO: after weighting at least one sample preparation phase should be closed
// TODO: chosen language should be save into config file

namespace SamplesWeighting
{
    public partial class FaceForm : Form
    {
        private readonly WeightingContext  _wc;
        private readonly List<MonitorsSet> _monitorSets;
        private readonly List<SRMsSet>     _srmSets;
        private readonly List<SamplesSet>  _sampleSets;

        private string lang = ConfigurationManager.config["language"];

        private List<SRM>     _srms;
        private List<Monitor> _monitors;
        private List<Sample>  _samples;
        
        private int currRowIndex = 0, currColIndex = 0;

        private Dictionary<string, DataGridView> tabDgvs = new Dictionary<string, DataGridView>();


        private void Binding()
        {
            dataGridView_SamplesSet.DataSource   = _sampleSets;
            dataGridView_MonitorsSet.DataSource  = _monitorSets;
            dataGridView_StandartsSet.DataSource = _srmSets;
            dataGridView_Monitors.DataSource     = _monitors;
            dataGridView_Samples.DataSource      = _samples;
            dataGridView_Standarts.DataSource    = _srms;

            dataGridView_SamplesSet.CurrentCell  = dataGridView_SamplesSet[0, dataGridView_SamplesSet.RowCount - 1];

            tabDgvs.Add("tabSamples",   dataGridView_Samples);
            tabDgvs.Add("tabStandarts", dataGridView_Standarts);
            tabDgvs.Add("tabMonitors",  dataGridView_Monitors);

        }

        public FaceForm()
        {
            InitializeComponent();

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

            _samples  = new List<Sample>();
            _srms     = new List<SRM>();
            _monitors = new List<Monitor>();

            Binding();

            SetLanguageToControls(Controls);

            dataGridView_SamplesSet.SelectionChanged   += DataGridView_SamplesSet_SelectionChanged;
            dataGridView_MonitorsSet.SelectionChanged  += DataGridView_MonitorsSet_SelectionChanged;
            dataGridView_StandartsSet.SelectionChanged += DataGridView_StandartsSet_SelectionChanged;
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
                    ToolStripMenuItemMenu.Text = ConfigurationManager.config[$"{ToolStripMenuItemMenu.Name}:{lang}"];
                    ToolStripMenuItemLang.Text = ConfigurationManager.config[$"{ToolStripMenuItemLang.Name}:{lang}"];
                    foreach (ToolStripItem tsi in ToolStripMenuItemLang.DropDownItems)
                        tsi.Text = ConfigurationManager.config[$"{tsi.Name}:{lang}"];
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

