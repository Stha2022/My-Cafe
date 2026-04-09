namespace CampusCafeKiosk
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFlavor;
        private System.Windows.Forms.CheckBox chkPremium;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Label lblPrice;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFlavor = new System.Windows.Forms.TextBox();
            this.chkPremium = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();

            this.SuspendLayout();

            txtName.Top = 20; txtName.Left = 20;
            txtFlavor.Top = 60; txtFlavor.Left = 20;

            chkPremium.Text = "Upgrade to Premium Drink";
            chkPremium.Top = 100; chkPremium.Left = 20;

            btnOrder.Text = "Place Order";
            btnOrder.Top = 140; btnOrder.Left = 20;
            btnOrder.Click += new System.EventHandler(this.btnOrder_Click);

            lblTicket.Top = 180; lblTicket.Left = 20;
            lblPrice.Top = 210; lblPrice.Left = 20;

            this.Controls.Add(txtName);
            this.Controls.Add(txtFlavor);
            this.Controls.Add(chkPremium);
            this.Controls.Add(btnOrder);
            this.Controls.Add(lblTicket);
            this.Controls.Add(lblPrice);

            this.Text = "Campus Cafe Kiosk";
            this.ResumeLayout(false);
        }
    }
}
