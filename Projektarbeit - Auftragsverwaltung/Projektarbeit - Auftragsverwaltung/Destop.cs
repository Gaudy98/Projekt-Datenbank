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
    public partial class Destop : Form
    {
        public Destop()
        {
            InitializeComponent();
        }

        private void Cmd_Order_Click(object sender, EventArgs e)
        {
            Aufträge frmOrder = new Aufträge();
            frmOrder.Show();
            this.Hide();
        }

        private void Cmd_Customer_Click(object sender, EventArgs e)
        {
            Kunden frmCustomer = new Kunden();
            frmCustomer.Show();
            this.Hide();
        }

        private void Cmd_Artikelgruppen_Click(object sender, EventArgs e)
        {
            Artikerlgruppen frmArtikerlgrupp = new Artikerlgruppen();
            frmArtikerlgrupp.Show();
            this.Hide();
        }

        private void Cmd_Artikel_Click(object sender, EventArgs e)
        {
            Artikel frmArticel = new Artikel();
            frmArticel.Show();
            this.Hide();
        }
    }
}
