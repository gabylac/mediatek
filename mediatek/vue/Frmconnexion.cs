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
    public partial class Frmconnexion : Form
    {
        public Frmconnexion()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Frmpersonnel frmpersonnel = new Frmpersonnel();
            frmpersonnel.ShowDialog();
        }
        
    }
}
