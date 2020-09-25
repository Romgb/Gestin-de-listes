using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestin_de_listes_Winforms
{
    public partial class FrmListes : Form
    {
        public FrmListes()
        {
            InitializeComponent();
        }

        private void btnAjouter1_Click(object sender, EventArgs e)
        {

            lbCible.Items.Add(cbSource.SelectedItem);
        }
    }
}
