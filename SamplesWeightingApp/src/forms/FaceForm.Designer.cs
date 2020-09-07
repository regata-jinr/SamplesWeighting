/***************************************************************************
 *                                                                         *
 *                                                                         *
 * Copyright(c) 2017-2020, REGATA Experiment at FLNP|JINR                  *
 * Author: [Boris Rumyantsev](mailto:bdrum@jinr.ru)                        *
 * All rights reserved                                                     *
 *                                                                         *
 *                                                                         *
 ***************************************************************************/

namespace SamplesWeighting
{
    partial class FaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            _wc.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.radioButtonTypeLLI = new System.Windows.Forms.RadioButton();
            this.radioButtonTypeSLI = new System.Windows.Forms.RadioButton();
            this.radioButtonTypeBoth = new System.Windows.Forms.RadioButton();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabSamples = new System.Windows.Forms.TabPage();
            this.groupBoxSamples = new System.Windows.Forms.GroupBox();
            this.dataGridView_Samples = new System.Windows.Forms.DataGridView();
            this.groupBoxSamplesSets = new System.Windows.Forms.GroupBox();
            this.dataGridView_SamplesSet = new System.Windows.Forms.DataGridView();
            this.tabStandarts = new System.Windows.Forms.TabPage();
            this.groupBoxStandarts = new System.Windows.Forms.GroupBox();
            this.dataGridView_Standarts = new System.Windows.Forms.DataGridView();
            this.groupBoxStandartsSets = new System.Windows.Forms.GroupBox();
            this.dataGridView_StandartsSet = new System.Windows.Forms.DataGridView();
            this.tabMonitors = new System.Windows.Forms.TabPage();
            this.groupBoxMonitors = new System.Windows.Forms.GroupBox();
            this.dataGridView_Monitors = new System.Windows.Forms.DataGridView();
            this.groupBoxMonitorsSets = new System.Windows.Forms.GroupBox();
            this.dataGridView_MonitorsSet = new System.Windows.Forms.DataGridView();
            this.tabReweight = new System.Windows.Forms.TabPage();
            this.groupBoxJournals = new System.Windows.Forms.GroupBox();
            this.dataGridView_Journals = new System.Windows.Forms.DataGridView();
            this.groupBoxIrradiations = new System.Windows.Forms.GroupBox();
            this.dataGridView_Irradiations = new System.Windows.Forms.DataGridView();
            this.buttonReadFromFile = new System.Windows.Forms.Button();
            this.buttonSave2File = new System.Windows.Forms.Button();
            this.buttonAddRow = new System.Windows.Forms.Button();
            this.buttonSave2DB = new System.Windows.Forms.Button();
            this.buttonReadWeight = new System.Windows.Forms.Button();
            this.openFileDialog_ReadFromFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLang = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxType.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabSamples.SuspendLayout();
            this.groupBoxSamples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Samples)).BeginInit();
            this.groupBoxSamplesSets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SamplesSet)).BeginInit();
            this.tabStandarts.SuspendLayout();
            this.groupBoxStandarts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Standarts)).BeginInit();
            this.groupBoxStandartsSets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StandartsSet)).BeginInit();
            this.tabMonitors.SuspendLayout();
            this.groupBoxMonitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Monitors)).BeginInit();
            this.groupBoxMonitorsSets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MonitorsSet)).BeginInit();
            this.tabReweight.SuspendLayout();
            this.groupBoxJournals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Journals)).BeginInit();
            this.groupBoxIrradiations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Irradiations)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxType
            // 
            this.groupBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxType.Controls.Add(this.radioButtonTypeLLI);
            this.groupBoxType.Controls.Add(this.radioButtonTypeSLI);
            this.groupBoxType.Controls.Add(this.radioButtonTypeBoth);
            this.groupBoxType.Location = new System.Drawing.Point(972, 2);
            this.groupBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxType.Size = new System.Drawing.Size(165, 103);
            this.groupBoxType.TabIndex = 3;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип";
            // 
            // radioButtonTypeLLI
            // 
            this.radioButtonTypeLLI.AutoSize = true;
            this.radioButtonTypeLLI.Location = new System.Drawing.Point(16, 74);
            this.radioButtonTypeLLI.Name = "radioButtonTypeLLI";
            this.radioButtonTypeLLI.Size = new System.Drawing.Size(57, 20);
            this.radioButtonTypeLLI.TabIndex = 13;
            this.radioButtonTypeLLI.Text = "ДЖИ";
            this.radioButtonTypeLLI.UseVisualStyleBackColor = true;
            // 
            // radioButtonTypeSLI
            // 
            this.radioButtonTypeSLI.AutoSize = true;
            this.radioButtonTypeSLI.Location = new System.Drawing.Point(16, 48);
            this.radioButtonTypeSLI.Name = "radioButtonTypeSLI";
            this.radioButtonTypeSLI.Size = new System.Drawing.Size(56, 20);
            this.radioButtonTypeSLI.TabIndex = 12;
            this.radioButtonTypeSLI.Text = "КЖИ";
            this.radioButtonTypeSLI.UseVisualStyleBackColor = true;
            // 
            // radioButtonTypeBoth
            // 
            this.radioButtonTypeBoth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonTypeBoth.AutoSize = true;
            this.radioButtonTypeBoth.Checked = true;
            this.radioButtonTypeBoth.Location = new System.Drawing.Point(17, 22);
            this.radioButtonTypeBoth.Name = "radioButtonTypeBoth";
            this.radioButtonTypeBoth.Size = new System.Drawing.Size(102, 20);
            this.radioButtonTypeBoth.TabIndex = 11;
            this.radioButtonTypeBoth.TabStop = true;
            this.radioButtonTypeBoth.Text = "КЖИ и ДЖИ";
            this.radioButtonTypeBoth.UseVisualStyleBackColor = true;
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabSamples);
            this.tabs.Controls.Add(this.tabStandarts);
            this.tabs.Controls.Add(this.tabMonitors);
            this.tabs.Controls.Add(this.tabReweight);
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabs.Location = new System.Drawing.Point(2, 24);
            this.tabs.Margin = new System.Windows.Forms.Padding(4);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 3;
            this.tabs.Size = new System.Drawing.Size(962, 680);
            this.tabs.TabIndex = 4;
            // 
            // tabSamples
            // 
            this.tabSamples.Controls.Add(this.groupBoxSamples);
            this.tabSamples.Controls.Add(this.groupBoxSamplesSets);
            this.tabSamples.Location = new System.Drawing.Point(4, 24);
            this.tabSamples.Margin = new System.Windows.Forms.Padding(4);
            this.tabSamples.Name = "tabSamples";
            this.tabSamples.Padding = new System.Windows.Forms.Padding(4);
            this.tabSamples.Size = new System.Drawing.Size(954, 652);
            this.tabSamples.TabIndex = 0;
            this.tabSamples.Text = "Образцы";
            this.tabSamples.UseVisualStyleBackColor = true;
            // 
            // groupBoxSamples
            // 
            this.groupBoxSamples.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSamples.Controls.Add(this.dataGridView_Samples);
            this.groupBoxSamples.Location = new System.Drawing.Point(8, 353);
            this.groupBoxSamples.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSamples.Name = "groupBoxSamples";
            this.groupBoxSamples.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSamples.Size = new System.Drawing.Size(946, 312);
            this.groupBoxSamples.TabIndex = 2;
            this.groupBoxSamples.TabStop = false;
            this.groupBoxSamples.Text = "Список образцов";
            // 
            // dataGridView_Samples
            // 
            this.dataGridView_Samples.AllowUserToAddRows = false;
            this.dataGridView_Samples.AllowUserToDeleteRows = false;
            this.dataGridView_Samples.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Samples.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Samples.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Samples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Samples.Location = new System.Drawing.Point(8, 22);
            this.dataGridView_Samples.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Samples.Name = "dataGridView_Samples";
            this.dataGridView_Samples.RowHeadersVisible = false;
            this.dataGridView_Samples.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Samples.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_Samples.Size = new System.Drawing.Size(930, 282);
            this.dataGridView_Samples.TabIndex = 0;
            // 
            // groupBoxSamplesSets
            // 
            this.groupBoxSamplesSets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSamplesSets.Controls.Add(this.dataGridView_SamplesSet);
            this.groupBoxSamplesSets.Location = new System.Drawing.Point(8, 7);
            this.groupBoxSamplesSets.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSamplesSets.Name = "groupBoxSamplesSets";
            this.groupBoxSamplesSets.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSamplesSets.Size = new System.Drawing.Size(946, 338);
            this.groupBoxSamplesSets.TabIndex = 1;
            this.groupBoxSamplesSets.TabStop = false;
            this.groupBoxSamplesSets.Text = "Партии образцов";
            // 
            // dataGridView_SamplesSet
            // 
            this.dataGridView_SamplesSet.AllowUserToAddRows = false;
            this.dataGridView_SamplesSet.AllowUserToDeleteRows = false;
            this.dataGridView_SamplesSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_SamplesSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SamplesSet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_SamplesSet.CausesValidation = false;
            this.dataGridView_SamplesSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SamplesSet.Location = new System.Drawing.Point(8, 15);
            this.dataGridView_SamplesSet.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_SamplesSet.MultiSelect = false;
            this.dataGridView_SamplesSet.Name = "dataGridView_SamplesSet";
            this.dataGridView_SamplesSet.ReadOnly = true;
            this.dataGridView_SamplesSet.RowHeadersVisible = false;
            this.dataGridView_SamplesSet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_SamplesSet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_SamplesSet.Size = new System.Drawing.Size(930, 315);
            this.dataGridView_SamplesSet.TabIndex = 0;
            // 
            // tabStandarts
            // 
            this.tabStandarts.Controls.Add(this.groupBoxStandarts);
            this.tabStandarts.Controls.Add(this.groupBoxStandartsSets);
            this.tabStandarts.Location = new System.Drawing.Point(4, 24);
            this.tabStandarts.Margin = new System.Windows.Forms.Padding(4);
            this.tabStandarts.Name = "tabStandarts";
            this.tabStandarts.Padding = new System.Windows.Forms.Padding(4);
            this.tabStandarts.Size = new System.Drawing.Size(954, 652);
            this.tabStandarts.TabIndex = 1;
            this.tabStandarts.Text = "Стандарты";
            this.tabStandarts.UseVisualStyleBackColor = true;
            // 
            // groupBoxStandarts
            // 
            this.groupBoxStandarts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStandarts.Controls.Add(this.dataGridView_Standarts);
            this.groupBoxStandarts.Location = new System.Drawing.Point(8, 353);
            this.groupBoxStandarts.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStandarts.Name = "groupBoxStandarts";
            this.groupBoxStandarts.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStandarts.Size = new System.Drawing.Size(946, 312);
            this.groupBoxStandarts.TabIndex = 4;
            this.groupBoxStandarts.TabStop = false;
            this.groupBoxStandarts.Text = "Список стандартов";
            // 
            // dataGridView_Standarts
            // 
            this.dataGridView_Standarts.AllowUserToAddRows = false;
            this.dataGridView_Standarts.AllowUserToDeleteRows = false;
            this.dataGridView_Standarts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Standarts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Standarts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Standarts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Standarts.Location = new System.Drawing.Point(8, 22);
            this.dataGridView_Standarts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Standarts.Name = "dataGridView_Standarts";
            this.dataGridView_Standarts.RowHeadersVisible = false;
            this.dataGridView_Standarts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Standarts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_Standarts.Size = new System.Drawing.Size(930, 282);
            this.dataGridView_Standarts.TabIndex = 1;
            // 
            // groupBoxStandartsSets
            // 
            this.groupBoxStandartsSets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStandartsSets.Controls.Add(this.dataGridView_StandartsSet);
            this.groupBoxStandartsSets.Location = new System.Drawing.Point(8, 7);
            this.groupBoxStandartsSets.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStandartsSets.Name = "groupBoxStandartsSets";
            this.groupBoxStandartsSets.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStandartsSets.Size = new System.Drawing.Size(946, 338);
            this.groupBoxStandartsSets.TabIndex = 3;
            this.groupBoxStandartsSets.TabStop = false;
            this.groupBoxStandartsSets.Text = "Партии стандартов";
            // 
            // dataGridView_StandartsSet
            // 
            this.dataGridView_StandartsSet.AllowUserToAddRows = false;
            this.dataGridView_StandartsSet.AllowUserToDeleteRows = false;
            this.dataGridView_StandartsSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_StandartsSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_StandartsSet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_StandartsSet.CausesValidation = false;
            this.dataGridView_StandartsSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StandartsSet.Location = new System.Drawing.Point(8, 15);
            this.dataGridView_StandartsSet.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_StandartsSet.MultiSelect = false;
            this.dataGridView_StandartsSet.Name = "dataGridView_StandartsSet";
            this.dataGridView_StandartsSet.ReadOnly = true;
            this.dataGridView_StandartsSet.RowHeadersVisible = false;
            this.dataGridView_StandartsSet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_StandartsSet.Size = new System.Drawing.Size(930, 315);
            this.dataGridView_StandartsSet.TabIndex = 1;
            // 
            // tabMonitors
            // 
            this.tabMonitors.Controls.Add(this.groupBoxMonitors);
            this.tabMonitors.Controls.Add(this.groupBoxMonitorsSets);
            this.tabMonitors.Location = new System.Drawing.Point(4, 24);
            this.tabMonitors.Margin = new System.Windows.Forms.Padding(4);
            this.tabMonitors.Name = "tabMonitors";
            this.tabMonitors.Padding = new System.Windows.Forms.Padding(4);
            this.tabMonitors.Size = new System.Drawing.Size(954, 652);
            this.tabMonitors.TabIndex = 2;
            this.tabMonitors.Text = "Мониторы";
            this.tabMonitors.UseVisualStyleBackColor = true;
            // 
            // groupBoxMonitors
            // 
            this.groupBoxMonitors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMonitors.Controls.Add(this.dataGridView_Monitors);
            this.groupBoxMonitors.Location = new System.Drawing.Point(8, 353);
            this.groupBoxMonitors.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMonitors.Name = "groupBoxMonitors";
            this.groupBoxMonitors.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMonitors.Size = new System.Drawing.Size(946, 312);
            this.groupBoxMonitors.TabIndex = 4;
            this.groupBoxMonitors.TabStop = false;
            this.groupBoxMonitors.Text = "Список мониторов";
            // 
            // dataGridView_Monitors
            // 
            this.dataGridView_Monitors.AllowUserToAddRows = false;
            this.dataGridView_Monitors.AllowUserToDeleteRows = false;
            this.dataGridView_Monitors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Monitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Monitors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Monitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Monitors.Location = new System.Drawing.Point(8, 22);
            this.dataGridView_Monitors.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Monitors.Name = "dataGridView_Monitors";
            this.dataGridView_Monitors.RowHeadersVisible = false;
            this.dataGridView_Monitors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Monitors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_Monitors.Size = new System.Drawing.Size(930, 282);
            this.dataGridView_Monitors.TabIndex = 1;
            // 
            // groupBoxMonitorsSets
            // 
            this.groupBoxMonitorsSets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMonitorsSets.Controls.Add(this.dataGridView_MonitorsSet);
            this.groupBoxMonitorsSets.Location = new System.Drawing.Point(8, 7);
            this.groupBoxMonitorsSets.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMonitorsSets.Name = "groupBoxMonitorsSets";
            this.groupBoxMonitorsSets.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMonitorsSets.Size = new System.Drawing.Size(946, 338);
            this.groupBoxMonitorsSets.TabIndex = 3;
            this.groupBoxMonitorsSets.TabStop = false;
            this.groupBoxMonitorsSets.Text = "Партии мониторов";
            // 
            // dataGridView_MonitorsSet
            // 
            this.dataGridView_MonitorsSet.AllowUserToAddRows = false;
            this.dataGridView_MonitorsSet.AllowUserToDeleteRows = false;
            this.dataGridView_MonitorsSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_MonitorsSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_MonitorsSet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_MonitorsSet.CausesValidation = false;
            this.dataGridView_MonitorsSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MonitorsSet.Location = new System.Drawing.Point(8, 15);
            this.dataGridView_MonitorsSet.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_MonitorsSet.MultiSelect = false;
            this.dataGridView_MonitorsSet.Name = "dataGridView_MonitorsSet";
            this.dataGridView_MonitorsSet.ReadOnly = true;
            this.dataGridView_MonitorsSet.RowHeadersVisible = false;
            this.dataGridView_MonitorsSet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_MonitorsSet.Size = new System.Drawing.Size(930, 315);
            this.dataGridView_MonitorsSet.TabIndex = 1;
            // 
            // tabReweight
            // 
            this.tabReweight.Controls.Add(this.groupBoxJournals);
            this.tabReweight.Controls.Add(this.groupBoxIrradiations);
            this.tabReweight.Location = new System.Drawing.Point(4, 24);
            this.tabReweight.Name = "tabReweight";
            this.tabReweight.Padding = new System.Windows.Forms.Padding(3);
            this.tabReweight.Size = new System.Drawing.Size(954, 652);
            this.tabReweight.TabIndex = 3;
            this.tabReweight.Text = "Перепаковка";
            this.tabReweight.UseVisualStyleBackColor = true;
            // 
            // groupBoxJournals
            // 
            this.groupBoxJournals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxJournals.Controls.Add(this.dataGridView_Journals);
            this.groupBoxJournals.Location = new System.Drawing.Point(4, 8);
            this.groupBoxJournals.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxJournals.Name = "groupBoxJournals";
            this.groupBoxJournals.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxJournals.Size = new System.Drawing.Size(946, 338);
            this.groupBoxJournals.TabIndex = 1;
            this.groupBoxJournals.TabStop = false;
            this.groupBoxJournals.Text = "Журналы облучений ДЖИ";
            // 
            // dataGridView_Journals
            // 
            this.dataGridView_Journals.AllowUserToAddRows = false;
            this.dataGridView_Journals.AllowUserToDeleteRows = false;
            this.dataGridView_Journals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Journals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Journals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Journals.CausesValidation = false;
            this.dataGridView_Journals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Journals.Location = new System.Drawing.Point(8, 15);
            this.dataGridView_Journals.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Journals.MultiSelect = false;
            this.dataGridView_Journals.Name = "dataGridView_Journals";
            this.dataGridView_Journals.ReadOnly = true;
            this.dataGridView_Journals.RowHeadersVisible = false;
            this.dataGridView_Journals.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Journals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Journals.Size = new System.Drawing.Size(930, 315);
            this.dataGridView_Journals.TabIndex = 0;
            // 
            // groupBoxIrradiations
            // 
            this.groupBoxIrradiations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIrradiations.Controls.Add(this.dataGridView_Irradiations);
            this.groupBoxIrradiations.Location = new System.Drawing.Point(4, 354);
            this.groupBoxIrradiations.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIrradiations.Name = "groupBoxIrradiations";
            this.groupBoxIrradiations.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIrradiations.Size = new System.Drawing.Size(946, 312);
            this.groupBoxIrradiations.TabIndex = 2;
            this.groupBoxIrradiations.TabStop = false;
            this.groupBoxIrradiations.Text = "Облучения";
            // 
            // dataGridView_Irradiations
            // 
            this.dataGridView_Irradiations.AllowUserToAddRows = false;
            this.dataGridView_Irradiations.AllowUserToDeleteRows = false;
            this.dataGridView_Irradiations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Irradiations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Irradiations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Irradiations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Irradiations.Location = new System.Drawing.Point(8, 22);
            this.dataGridView_Irradiations.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Irradiations.Name = "dataGridView_Irradiations";
            this.dataGridView_Irradiations.RowHeadersVisible = false;
            this.dataGridView_Irradiations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Irradiations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_Irradiations.Size = new System.Drawing.Size(930, 282);
            this.dataGridView_Irradiations.TabIndex = 0;
            // 
            // buttonReadFromFile
            // 
            this.buttonReadFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReadFromFile.Enabled = false;
            this.buttonReadFromFile.Location = new System.Drawing.Point(972, 113);
            this.buttonReadFromFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReadFromFile.Name = "buttonReadFromFile";
            this.buttonReadFromFile.Size = new System.Drawing.Size(165, 73);
            this.buttonReadFromFile.TabIndex = 5;
            this.buttonReadFromFile.Text = "Считать из файла";
            this.buttonReadFromFile.UseVisualStyleBackColor = true;
            // 
            // buttonSave2File
            // 
            this.buttonSave2File.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSave2File.Location = new System.Drawing.Point(972, 212);
            this.buttonSave2File.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave2File.Name = "buttonSave2File";
            this.buttonSave2File.Size = new System.Drawing.Size(165, 71);
            this.buttonSave2File.TabIndex = 6;
            this.buttonSave2File.Text = "Сохранить данные в файл";
            this.buttonSave2File.UseVisualStyleBackColor = true;
            // 
            // buttonAddRow
            // 
            this.buttonAddRow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAddRow.Enabled = false;
            this.buttonAddRow.Location = new System.Drawing.Point(972, 313);
            this.buttonAddRow.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddRow.Name = "buttonAddRow";
            this.buttonAddRow.Size = new System.Drawing.Size(165, 71);
            this.buttonAddRow.TabIndex = 7;
            this.buttonAddRow.Text = "Добавить строку";
            this.buttonAddRow.UseVisualStyleBackColor = true;
            // 
            // buttonSave2DB
            // 
            this.buttonSave2DB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave2DB.Location = new System.Drawing.Point(972, 392);
            this.buttonSave2DB.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave2DB.Name = "buttonSave2DB";
            this.buttonSave2DB.Size = new System.Drawing.Size(165, 71);
            this.buttonSave2DB.TabIndex = 8;
            this.buttonSave2DB.Text = "Сохранить данные в БД";
            this.buttonSave2DB.UseVisualStyleBackColor = true;
            // 
            // buttonReadWeight
            // 
            this.buttonReadWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReadWeight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonReadWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReadWeight.Location = new System.Drawing.Point(972, 471);
            this.buttonReadWeight.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReadWeight.Name = "buttonReadWeight";
            this.buttonReadWeight.Size = new System.Drawing.Size(165, 229);
            this.buttonReadWeight.TabIndex = 9;
            this.buttonReadWeight.Text = "Считать вес";
            this.buttonReadWeight.UseVisualStyleBackColor = false;
            // 
            // openFileDialog_ReadFromFile
            // 
            this.openFileDialog_ReadFromFile.Filter = "ves files (*.ves)|*.ves|All files (*.*)|*.*";
            this.openFileDialog_ReadFromFile.RestoreDirectory = true;
            this.openFileDialog_ReadFromFile.Title = "Выберите весовой файл";
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemMenu});
            this.menuStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripMain.Size = new System.Drawing.Size(1140, 24);
            this.menuStripMain.TabIndex = 11;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // ToolStripMenuItemMenu
            // 
            this.ToolStripMenuItemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLang});
            this.ToolStripMenuItemMenu.Name = "ToolStripMenuItemMenu";
            this.ToolStripMenuItemMenu.Size = new System.Drawing.Size(53, 20);
            this.ToolStripMenuItemMenu.Text = "Меню";
            // 
            // ToolStripMenuItemLang
            // 
            this.ToolStripMenuItemLang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.russianToolStripMenuItem});
            this.ToolStripMenuItemLang.Name = "ToolStripMenuItemLang";
            this.ToolStripMenuItemLang.Size = new System.Drawing.Size(101, 22);
            this.ToolStripMenuItemLang.Text = "Язык";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.CheckOnClick = true;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.CheckOnClick = true;
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            this.russianToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.russianToolStripMenuItem.Text = "Russian";
            // 
            // FaceForm
            // 
            this.AcceptButton = this.buttonReadWeight;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 705);
            this.Controls.Add(this.buttonReadWeight);
            this.Controls.Add(this.buttonSave2DB);
            this.Controls.Add(this.buttonAddRow);
            this.Controls.Add(this.buttonSave2File);
            this.Controls.Add(this.buttonReadFromFile);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FaceForm";
            this.ShowIcon = false;
            this.Text = "Взвешивание образцов    ";
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabSamples.ResumeLayout(false);
            this.groupBoxSamples.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Samples)).EndInit();
            this.groupBoxSamplesSets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SamplesSet)).EndInit();
            this.tabStandarts.ResumeLayout(false);
            this.groupBoxStandarts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Standarts)).EndInit();
            this.groupBoxStandartsSets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StandartsSet)).EndInit();
            this.tabMonitors.ResumeLayout(false);
            this.groupBoxMonitors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Monitors)).EndInit();
            this.groupBoxMonitorsSets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MonitorsSet)).EndInit();
            this.tabReweight.ResumeLayout(false);
            this.groupBoxJournals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Journals)).EndInit();
            this.groupBoxIrradiations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Irradiations)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabSamples;
        private System.Windows.Forms.TabPage tabStandarts;
        private System.Windows.Forms.TabPage tabMonitors;
        private System.Windows.Forms.GroupBox groupBoxSamples;
        private System.Windows.Forms.DataGridView dataGridView_Samples;
        private System.Windows.Forms.GroupBox groupBoxSamplesSets;
        private System.Windows.Forms.DataGridView dataGridView_SamplesSet;
        private System.Windows.Forms.GroupBox groupBoxStandarts;
        private System.Windows.Forms.GroupBox groupBoxStandartsSets;
        private System.Windows.Forms.GroupBox groupBoxMonitors;
        private System.Windows.Forms.GroupBox groupBoxMonitorsSets;
        private System.Windows.Forms.Button buttonReadFromFile;
        private System.Windows.Forms.Button buttonSave2File;
        private System.Windows.Forms.Button buttonAddRow;
        private System.Windows.Forms.Button buttonSave2DB;
        private System.Windows.Forms.Button buttonReadWeight;
        private System.Windows.Forms.DataGridView dataGridView_StandartsSet;
        private System.Windows.Forms.DataGridView dataGridView_MonitorsSet;
        private System.Windows.Forms.DataGridView dataGridView_Standarts;
        private System.Windows.Forms.DataGridView dataGridView_Monitors;
        private System.Windows.Forms.OpenFileDialog openFileDialog_ReadFromFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Save2File;
        private System.Windows.Forms.RadioButton radioButtonTypeLLI;
        private System.Windows.Forms.RadioButton radioButtonTypeSLI;
        private System.Windows.Forms.RadioButton radioButtonTypeBoth;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLang;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.TabPage tabReweight;
        private System.Windows.Forms.GroupBox groupBoxJournals;
        private System.Windows.Forms.DataGridView dataGridView_Journals;
        private System.Windows.Forms.GroupBox groupBoxIrradiations;
        private System.Windows.Forms.DataGridView dataGridView_Irradiations;
    }
}

