using System;
using System.Windows.Forms;

namespace CampusCafeKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string flavor = txtFlavor.Text;

            string orderTicket = (name.Trim().Replace(" ", "") + flavor.Trim().Replace(" ", "")).ToUpper();

            double basePrice = 20.0;

            DrinkOrder order;

            if (chkPremium.Checked)
            {
                PremiumDrink premium = new PremiumDrink();
                premium.CustomerName = name;
                premium.BasePrice = basePrice;
                premium.SyrupFlavor = flavor;
                order = premium;
            }
            else
            {
                order = new DrinkOrder();
                order.CustomerName = name;
                order.BasePrice = basePrice;
            }

            double total = order.CalculateTotal();

            lblTicket.Text = "Ticket: " + orderTicket;
            lblPrice.Text = "Price: R" + total;

            MessageBox.Show("Thank you, " + name + "!");
        }
    }
}
