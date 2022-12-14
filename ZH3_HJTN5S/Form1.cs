using ZH3_HJTN5S.Models;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace ZH3_HJTN5S
{
    public partial class Form1 : Form
    {
        Models.NorthWindHjtn5sContext context = new Models.NorthWindHjtn5sContext();
        Excel.Application xlApp;
        Excel.Workbook xlWorkbook;
        Excel.Worksheet xlSheet;
        public Form1()
        {
            InitializeComponent();

            productsBindingSource.DataSource = context.Products.ToList();

            listBoxCustomers.DisplayMember = "ContactName";
            listBoxCustomers.ValueMember = "CustomerId";

            listBoxOrders.DisplayMember = "OrderId";
            listBoxOrders.ValueMember = "OrderId";


            CustomerListazas();
            OrderListazas();
            OrderDetailListazas();
        }
        private void CustomerListazas()
        {
            var c = from x in context.Customers
                    where x.ContactName.Contains(textBoxCustomers.Text)
                    select x;
            listBoxCustomers.DataSource = c.ToList();
        }
        private void OrderListazas()
        {
            Customers c = (Customers)listBoxCustomers.SelectedItem;
            var o = from x in context.Orders
                    where x.CustomerId == c.CustomerId && x.OrderId.ToString().Contains(textBoxOrders.Text)
                    select x;
            listBoxOrders.DataSource = o.ToList();
        }
        private void OrderDetailListazas()
        {
            Orders o = (Orders)listBoxOrders.SelectedItem;
            var od = from x in context.OrderDetails
                     where x.OrderId == o.OrderId
                     select new Gridbe
                     {
                         OrderId = x.OrderId,
                         ProductId = x.ProductId,
                         Quantity = x.Quantity,
                         ProductPerUnit = x.Product.QuantityPerUnit,
                         Price = (int)(x.UnitPrice * x.Quantity)
                     };
            gridbeBindingSource.DataSource = od.ToList();
        }

        private void textBoxCustomers_TextChanged(object sender, EventArgs e)
        {
            CustomerListazas();
        }

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderListazas();
        }

        private void textBoxOrders_TextChanged(object sender, EventArgs e)
        {
            OrderListazas();
        }

        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderDetailListazas();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Hozzaadas hf = new Hozzaadas();
            if (hf.ShowDialog() == DialogResult.OK)
            {
                //Orders o = (Orders)listBoxOrders.SelectedItem;
                //OrderDetails plusz = new OrderDetails();
                //Products seged = new Products();
                //seged.ProductId = (from x in context.Products select x.ProductId).Max() + 1;
                //seged.ProductName = hf.textBoxProductName.Text;
                //seged.QuantityPerUnit = hf.textBoxProductPerUnit.Text;
                //context.Add(seged);
                //plusz.OrderId = o.OrderId;
                //plusz.ProductId = seged.ProductId;
                ////plusz.ProductId = (from x in context.Products select x.ProductId).Max() + 1;
                //plusz.Quantity = short.Parse(hf.textBoxQuantity.Text);
                //plusz.UnitPrice = int.Parse(hf.textBoxPrice.Text);
                //context.Add(plusz);
                //context.SaveChanges();
                //OrderDetailListazas();
                MessageBox.Show("hozzáadás");
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            TorlesForm tf = new TorlesForm();
            if (tf.ShowDialog() == DialogResult.OK)
            {
                var OrderID = ((Gridbe)gridbeBindingSource.Current).OrderId;
                var ProductID = ((Gridbe)gridbeBindingSource.Current).ProductId;

                var torlendo = (from x in context.OrderDetails where x.OrderId == OrderID && x.ProductId == ProductID select x).FirstOrDefault();

                context.OrderDetails.Remove(torlendo);
                context.SaveChanges();
                OrderDetailListazas();
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            try
            {
                xlApp = new Excel.Application();
                xlWorkbook = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWorkbook.ActiveSheet;

                CreateTable();

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

                xlWorkbook.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlApp = null;
                xlWorkbook = null;
            }
        }
        private void CreateTable()
        {
            string[] fejlecek = new string[]
            {
                "OrderId",
                "ProductId",
                "Quantity",
                "ProductPerUnit",
                "Price"
            };
            for (int i = 0; i < fejlecek.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = fejlecek[i];
            }

            Orders o = (Orders)listBoxOrders.SelectedItem;
            var szurt = (from x in context.OrderDetails
                         where x.OrderId == o.OrderId
                         select new Gridbe
                         {
                             OrderId = x.OrderId,
                             ProductId = x.ProductId,
                             Quantity = x.Quantity,
                             ProductPerUnit = x.Product.QuantityPerUnit,
                             Price = (int)(x.UnitPrice * x.Quantity)
                         }).ToList();
            object[,] adat = new object[szurt.Count, fejlecek.Count()];

            for (int i = 0; i < szurt.Count; i++)
            {
                adat[i, 0] = szurt[i].OrderId;
                adat[i, 1] = szurt[i].ProductId;
                adat[i, 2] = szurt[i].Quantity;
                adat[i, 3] = szurt[i].ProductPerUnit;
                adat[i, 4] = szurt[i].Price;
            }

            int sorok = adat.GetLength(0);
            int oszlopok = adat.GetLength(1);

            Excel.Range range = xlSheet.get_Range("A2", Type.Missing).get_Resize(sorok, oszlopok);
            range.Value2 = adat;

            Excel.Range fejlec = xlSheet.get_Range("A1", Type.Missing).get_Resize(1, 5);

            fejlec.Columns.AutoFit();
            fejlec.Font.Bold = true;
            fejlec.Interior.Color = Color.Blue;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingForm cf = new ClosingForm();
            if (cf.ShowDialog() == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void buttonSuppliers_Click(object sender, EventArgs e)
        {
            SupplierForm sf = new SupplierForm();
            sf.ShowDialog();
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            EmployeesForm ef = new EmployeesForm();
            ef.ShowDialog();
        }
    }
}