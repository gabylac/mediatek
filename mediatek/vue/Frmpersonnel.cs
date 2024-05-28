using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediatek
{
    public partial class Frmpersonnel : Form
    {
        public Frmpersonnel()
        {
            InitializeComponent();
            init();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

        }
        private void init()
        {
            btnModifier.Enabled = false;
            btnSupp.Enabled = false;
            btnAfficher.Enabled = false;
            grpPersonnel.Enabled = false;
            grpAbsence.Enabled = false;
        }
        private void remplirListPersonnel()
        {

        }
        private void remplirListAbsence()
        {

        }
    }
}
