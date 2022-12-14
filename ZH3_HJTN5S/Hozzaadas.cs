using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH3_HJTN5S
{
    public partial class Hozzaadas : Form
    {
        public Hozzaadas()
        {
            InitializeComponent();
        }
        private bool CheckUres(string s)
        {
            return !string.IsNullOrEmpty(s);
        }
        private bool CheckSzam(string s)
        {
            Regex r = new Regex("^.*[0-9].*$");
            return r.IsMatch(s);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBoxProductName_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckUres(textBoxProductName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxProductName, "Nem lehet üres!");
            }
        }

        private void textBoxProductName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxProductName, "");
        }

        private void textBoxProductPerUnit_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckSzam(textBoxProductPerUnit.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxProductPerUnit, "Tartalmaznia kell számot!");
            }
        }

        private void textBoxProductPerUnit_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxProductPerUnit, "");
        }

        private void textBoxQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckUres(textBoxQuantity.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxQuantity, "Nem lehet üres!");
            }
        }

        private void textBoxQuantity_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxQuantity, "");
        }

        private void textBoxPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckUres(textBoxPrice.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxPrice, "Nem lehet üres!");
            }
        }

        private void textBoxPrice_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxPrice, "");
        }
    }
}
