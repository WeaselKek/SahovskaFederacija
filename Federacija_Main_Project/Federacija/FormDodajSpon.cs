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
    public partial class FormDodajSpon : Form
    {
        FormVezaOrgSpon CaleForma;
        public FormDodajSpon()
        {
            InitializeComponent();
        }
        public FormDodajSpon(FormVezaOrgSpon c)
        {
            InitializeComponent();
            this.CaleForma = c;
        }
    }
}
