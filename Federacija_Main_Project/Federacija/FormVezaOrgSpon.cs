using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Linq;
using Federacija.Entiteti;
using Federacija.Mapiranja;
using Federacija.BindList;

namespace Federacija
{
    public partial class FormVezaOrgSpon : Form
    {
        bool updaterino = false;
        bool closenow = false;
        public FormVezaOrgSpon()
        {
            InitializeComponent();
        }

        public IList<Organizuje> ListaOrg
        {
            get;
            set;
        }
        public IList<Sponzorise> ListaSpon
        {
            get;
            set;
        }
        public Turnir Turn
        {
            get;
            set;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVezaOrgSpon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closenow)
                return;
            DialogResult r = MessageBox.Show("Da li ste sigurni", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnDodajOrg_Click(object sender, EventArgs e)
        {
            FormDodajOrg f = new FormDodajOrg(this);
            f.ShowDialog();
        }

        private void btnDodajSpon_Click(object sender, EventArgs e)
        {
            FormDodajSpon f = new FormDodajSpon(this);
            f.ShowDialog();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {

        }
    }
}
