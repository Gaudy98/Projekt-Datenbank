
namespace Projektarbeit___Auftragsverwaltung
{
    partial class Aufträge
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtSearchDB = new System.Windows.Forms.TextBox();
            this.CmdDeleteCustomer = new System.Windows.Forms.Button();
            this.CmdModifyCustomer = new System.Windows.Forms.Button();
            this.CmdCreateCustomer = new System.Windows.Forms.Button();
            this.LblDashboard = new System.Windows.Forms.Label();
            this.GrdCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(582, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // TxtSearchDB
            // 
            this.TxtSearchDB.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtSearchDB.Location = new System.Drawing.Point(674, 150);
            this.TxtSearchDB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TxtSearchDB.Name = "TxtSearchDB";
            this.TxtSearchDB.Size = new System.Drawing.Size(862, 71);
            this.TxtSearchDB.TabIndex = 52;
            // 
            // CmdDeleteCustomer
            // 
            this.CmdDeleteCustomer.Location = new System.Drawing.Point(758, 385);
            this.CmdDeleteCustomer.Name = "CmdDeleteCustomer";
            this.CmdDeleteCustomer.Size = new System.Drawing.Size(236, 48);
            this.CmdDeleteCustomer.TabIndex = 51;
            this.CmdDeleteCustomer.Text = "Delete Selected";
            this.CmdDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // CmdModifyCustomer
            // 
            this.CmdModifyCustomer.Location = new System.Drawing.Point(454, 385);
            this.CmdModifyCustomer.Name = "CmdModifyCustomer";
            this.CmdModifyCustomer.Size = new System.Drawing.Size(239, 48);
            this.CmdModifyCustomer.TabIndex = 50;
            this.CmdModifyCustomer.Text = "Modify Selected";
            this.CmdModifyCustomer.UseVisualStyleBackColor = true;
            // 
            // CmdCreateCustomer
            // 
            this.CmdCreateCustomer.Location = new System.Drawing.Point(103, 385);
            this.CmdCreateCustomer.Name = "CmdCreateCustomer";
            this.CmdCreateCustomer.Size = new System.Drawing.Size(246, 48);
            this.CmdCreateCustomer.TabIndex = 49;
            this.CmdCreateCustomer.Text = "Add New Customer";
            this.CmdCreateCustomer.UseVisualStyleBackColor = true;
            // 
            // LblDashboard
            // 
            this.LblDashboard.AutoSize = true;
            this.LblDashboard.BackColor = System.Drawing.Color.Transparent;
            this.LblDashboard.Font = new System.Drawing.Font("Rage Italic", 20.25F);
            this.LblDashboard.ForeColor = System.Drawing.Color.White;
            this.LblDashboard.Location = new System.Drawing.Point(58, 91);
            this.LblDashboard.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblDashboard.Name = "LblDashboard";
            this.LblDashboard.Size = new System.Drawing.Size(291, 86);
            this.LblDashboard.TabIndex = 48;
            this.LblDashboard.Text = "Dashboard";
            this.LblDashboard.UseMnemonic = false;
            // 
            // GrdCustomer
            // 
            this.GrdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdCustomer.Location = new System.Drawing.Point(60, 475);
            this.GrdCustomer.Name = "GrdCustomer";
            this.GrdCustomer.RowHeadersWidth = 102;
            this.GrdCustomer.Size = new System.Drawing.Size(1984, 498);
            this.GrdCustomer.TabIndex = 47;
            // 
            // Aufträge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2103, 1064);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TxtSearchDB);
            this.Controls.Add(this.CmdDeleteCustomer);
            this.Controls.Add(this.CmdModifyCustomer);
            this.Controls.Add(this.CmdCreateCustomer);
            this.Controls.Add(this.LblDashboard);
            this.Controls.Add(this.GrdCustomer);
            this.Name = "Aufträge";
            this.Text = "Aufträge";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtSearchDB;
        private System.Windows.Forms.Button CmdDeleteCustomer;
        private System.Windows.Forms.Button CmdModifyCustomer;
        private System.Windows.Forms.Button CmdCreateCustomer;
        private System.Windows.Forms.Label LblDashboard;
        private System.Windows.Forms.DataGridView GrdCustomer;
    }
}