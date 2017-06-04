using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Team
{
    public partial class ucTeams : UserControl
    {
        private static ucTeams _instance;
        public static ucTeams Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucTeams();
                return _instance;
            }
        }
        public ucTeams()
        {
            InitializeComponent();
        }
    }
}
