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
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.SqlServer;

// TODO: Changing in the table should be automatically upload to db?
// TODO: Changing in the table should be automatically upload to file, Year/Month/SamplesSet.ves
// TODO: Use Ef Core for ORM
// TODO: Use csvhelper for ORM
// TODO: keep the functional from previous version
// TODO: add mechnism of weighting for selected cell
// TODO: hit the space should be event for weighting independent from button focus - accept button?
// TODO: after weighting at least one sample preparation phase should be closed

namespace SamplesWeighting
{
    public partial class FaceForm : Form
    {
        private readonly WeightingContext _wc;
        private readonly List<Monitor> _monitors;
        private readonly List<MonitorsSet> _monitorSets;
        private readonly List<SRM> _srms;
        private readonly List<SRMsSet> _srmSets;
        private readonly List<Sample> _sample;
        private readonly List<SamplesSet> _sampleSets;

        private void Binding()
        {
            dataGridView_SamplesSet.DataSource = _sampleSets;
            dataGridView_SamplesSet.CurrentCell = dataGridView_SamplesSet[0, dataGridView_SamplesSet.RowCount - 1];
            dataGridView_MonitorsSet.DataSource = _monitorSets;
            dataGridView_StandartsSet.DataSource = _srmSets;

        }

        public FaceForm()
        {
            InitializeComponent();
            _wc = new WeightingContext();
            _sampleSets = _wc.SamplesSets.OrderBy(ss => ss.Year).ThenBy(ss => ss.Sample_Set_ID).ThenBy(ss => ss.Sample_Set_Index).ToList();
            _monitorSets = _wc.MonitorsSets.OrderBy(ms => ms.Monitor_Set_Name).ThenBy(ms => ms.Monitor_Set_Number).ToList();
            _srmSets = _wc.SRMsSets.OrderBy(ss => ss.SRM_Set_Name).ThenBy(ss => ss.SRM_Set_Number).ToList();

            Binding();

        }

    } // public partial class FaceForm : Form
} // namespace SamplesWeighting

