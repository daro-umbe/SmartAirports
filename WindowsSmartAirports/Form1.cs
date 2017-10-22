using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsSmartAirports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = 0;
            int.TryParse(textBox2.Text, out price);
            if (price != 0)
            {
                //DatabaseAdapter.GearboxEntities.Payments.Add(new Payments() { id_pass = 1, shop = textBox1.Text, value = price});
                //DatabaseAdapter.GearboxEntities.SaveChanges();

                geartestEntities geartestEntities = new geartestEntities();
                geartestEntities.Payments.SqlQuery("insert into Payments (shop, id_pass, value) values ('Apple', 1,142)", new object[0]);
                geartestEntities.SaveChanges();

                textBox1.Text = "";
                textBox2.Text = "";
            }
         }
    }
}
