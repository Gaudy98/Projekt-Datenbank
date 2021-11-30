using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektarbeit___Auftragsverwaltung
{
    public partial class Kunden : Form
    {
        private Destop form_Destop;

        public Kunden()
        {
            InitializeComponent();
            this.form_Destop = frm_Destop;
        }

        private void LblDashboard_Click(object sender, EventArgs e)
        {
            Destop.Show();
            this.Close();
        }
    }
}
