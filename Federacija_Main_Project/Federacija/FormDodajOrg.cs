using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Federacija
{
    public partial class FormDodajOrg : Form
    {
        FormVezaOrgSpon CaleForma;
        public FormDodajOrg(FormVezaOrgSpon c)
        {
            InitializeComponent();
            this.CaleForma = c;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            
        }
      
    }
}
