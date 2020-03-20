using System.Windows.Forms;
using System.Collections.Generic;
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
        private readonly BindingList<Monitor> _monitors;
        private readonly BindingList<MonitorsSet> _monitorSets;
        private readonly BindingList<SRM> _srms;
        private readonly BindingList<SRMsSet> _srmSets;
        private readonly BindingList<Sample> _sample;
        private readonly BindingList<SamplesSet> _sampleSets;

        private void Binding()
        {
            
        }

        public FaceForm()
        {
            InitializeComponent();
        }

    } // public partial class FaceForm : Form
} // namespace SamplesWeighting

