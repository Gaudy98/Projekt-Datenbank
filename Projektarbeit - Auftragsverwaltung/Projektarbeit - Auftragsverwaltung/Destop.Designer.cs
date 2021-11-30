
namespace Projektarbeit___Auftragsverwaltung
{
    partial class Destop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cmd_Customer = new System.Windows.Forms.Button();
            this.Cmd_Artikelgruppen = new System.Windows.Forms.Button();
            this.Cmd_Artikel = new System.Windows.Forms.Button();
            this.Cmd_Order = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cmd_Customer
            // 
            this.Cmd_Customer.Location = new System.Drawing.Point(364, 324);
            this.Cmd_Customer.Name = "Cmd_Customer";
            this.Cmd_Customer.Size = new System.Drawing.Size(401, 123);
            this.Cmd_Customer.TabIndex = 0;
            this.Cmd_Customer.Text = "Kunden";
            this.Cmd_Customer.UseVisualStyleBackColor = true;
            this.Cmd_Customer.Click += new System.EventHandler(this.Cmd_Customer_Click);
            // 
            // Cmd_Artikelgruppen
            // 
            this.Cmd_Artikelgruppen.Location = new System.Drawing.Point(1098, 324);
            this.Cmd_Artikelgruppen.Name = "Cmd_Artikelgruppen";
            this.Cmd_Artikelgruppen.Size = new System.Drawing.Size(389, 123);
            this.Cmd_Artikelgruppen.TabIndex = 1;
            this.Cmd_Artikelgruppen.Text = "Artikelgruppen";
            this.Cmd_Artikelgruppen.UseVisualStyleBackColor = true;
            this.Cmd_Artikelgruppen.Click += new System.EventHandler(this.Cmd_Artikelgruppen_Click);
            // 
            // Cmd_Artikel
            // 
            this.Cmd_Artikel.Location = new System.Drawing.Point(364, 600);
            this.Cmd_Artikel.Name = "Cmd_Artikel";
            this.Cmd_Artikel.Size = new System.Drawing.Size(389, 127);
            this.Cmd_Artikel.TabIndex = 2;
            this.Cmd_Artikel.Text = "Artikel";
            this.Cmd_Artikel.UseVisualStyleBackColor = true;
            this.Cmd_Artikel.Click += new System.EventHandler(this.Cmd_Artikel_Click);
            // 
            // Cmd_Order
            // 
            this.Cmd_Order.Location = new System.Drawing.Point(1098, 600);
            this.Cmd_Order.Name = "Cmd_Order";
            this.Cmd_Order.Size = new System.Drawing.Size(401, 127);
            this.Cmd_Order.TabIndex = 3;
            this.Cmd_Order.Text = "Auftrag";
            this.Cmd_Order.UseVisualStyleBackColor = true;
            this.Cmd_Order.Click += new System.EventHandler(this.Cmd_Order_Click);
            // 
            // Destop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2112, 1037);
            this.Controls.Add(this.Cmd_Order);
            this.Controls.Add(this.Cmd_Artikel);
            this.Controls.Add(this.Cmd_Artikelgruppen);
            this.Controls.Add(this.Cmd_Customer);
            this.Name = "Destop";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cmd_Customer;
        private System.Windows.Forms.Button Cmd_Artikelgruppen;
        private System.Windows.Forms.Button Cmd_Artikel;
        private System.Windows.Forms.Button Cmd_Order;
    }
}

