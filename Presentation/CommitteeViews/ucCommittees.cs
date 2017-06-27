using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Presentation.CommitteeViews
{
    public partial class ucCommittees : UserControl
    {
        private static ucCommittees _instance;
        public static ucCommittees Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucCommittees();
                return _instance;
            }
        }
        public ucCommittees()
        {
            InitializeComponent();
        }

        private void ShowCommittees()
        {
            committeeBindingSource.DataSource = null;
            committeeBindingSource.DataSource = CommitteeLogic.Get();
        }

        private void ucCommittees_Load(object sender, EventArgs e)
        {
            ShowCommittees();
        }
    }
}
