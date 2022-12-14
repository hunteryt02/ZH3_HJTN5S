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
    public partial class EmployeesForm : Form
    {
        Models.NorthWindHjtn5sContext context = new Models.NorthWindHjtn5sContext();
        public EmployeesForm()
        {
            InitializeComponent();

            var e = from x in context.Employees
                    select x;
            employeesBindingSource.DataSource = e.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var em = from x in context.Employees
                     where x.FirstName.Contains(textBoxFirstName.Text)
                    select x;
            employeesBindingSource.DataSource = em.ToList();
        }
    }
}
