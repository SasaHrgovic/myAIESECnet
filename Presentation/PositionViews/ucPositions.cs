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
using Data;

namespace Presentation.PositionViews
{
    public partial class ucPositions : UserControl
    {
        private static ucPositions _instance;
        public static ucPositions Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucPositions();
                return _instance;
            }
        }

        public ucPositions()
        {
            InitializeComponent();
        }

        private void ShowPositions()
        {
            positionBindingSource.DataSource = null;
            positionBindingSource.DataSource = PositionLogic.Get();
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            frmAddPosition fa = new frmAddPosition();
            fa.ShowDialog();
            ShowPositions();
        }

        private void ucPositions_Load(object sender, EventArgs e)
        {
            ShowPositions();
        }

        private void btnUpdatePosition_Click(object sender, EventArgs e)
        {
            frmAddPosition fu = new frmAddPosition(positionBindingSource.Current as Position);
            fu.ShowDialog();
            ShowPositions();
        }
    }
}
