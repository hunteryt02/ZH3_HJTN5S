using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH3_HJTN5S
{
    public partial class SupplierForm : Form
    {
        Models.NorthWindHjtn5sContext context = new Models.NorthWindHjtn5sContext();
        public SupplierForm()
        {
            InitializeComponent();

            var s = from x in context.Suppliers
                    select x;
            suppliersBindingSource.DataSource = s.ToList();
        }
    }
}
