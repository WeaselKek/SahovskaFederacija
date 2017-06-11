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
    public partial class FormDodajPartija : Form
    {
        bool updaterino = false;
        bool closenow = false;
        public FormDodajPartija()
        {
            InitializeComponent();
        }

        public Turnir Turn
        {
            set;
            get;
        }

        private void FormDodajPartija_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closenow)
            {
                return;
            }
            DialogResult r = MessageBox.Show("Da li ste sigurni", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDodajPartija_Load(object sender, EventArgs e)
        {
            label2.Text = Turn.Naziv + "  " + Turn.Godina.ToString() + "  " + Turn.Grad;
        }
    }
}
