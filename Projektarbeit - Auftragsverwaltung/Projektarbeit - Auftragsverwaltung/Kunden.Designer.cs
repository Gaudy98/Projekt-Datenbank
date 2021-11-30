
namespace Projektarbeit___Auftragsverwaltung
{
    partial class Kunden
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
            this.GrdCustomer = new System.Windows.Forms.DataGridView();
            this.LblDashboard = new System.Windows.Forms.Label();
            this.CmdDeleteCustomer = new System.Windows.Forms.Button();
            this.CmdModifyCustomer = new System.Windows.Forms.Button();
            this.CmdCreateCustomer = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtSearchDB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdCustomer
            // 
            this.GrdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdCustomer.Location = new System.Drawing.Point(43, 443);
            this.GrdCustomer.Name = "GrdCustomer";
            this.GrdCustomer.RowHeadersWidth = 102;
            this.GrdCustomer.Size = new System.Drawing.Size(1984, 498);
            this.GrdCustomer.TabIndex = 34;
            // 
            // LblDashboard
            // 
            this.LblDashboard.AutoSize = true;
            this.LblDashboard.BackColor = System.Drawing.Color.Transparent;
            this.LblDashboard.Font = new System.Drawing.Font("Rage Italic", 20.25F);
            this.LblDashboard.ForeColor = System.Drawing.Color.White;
            this.LblDashboard.Location = new System.Drawing.Point(41, 59);
            this.LblDashboard.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblDashboard.Name = "LblDashboard";
            this.LblDashboard.Size = new System.Drawing.Size(291, 86);
            this.LblDashboard.TabIndex = 36;
            this.LblDashboard.Text = "Dashboard";
            this.LblDashboard.UseMnemonic = false;
            this.LblDashboard.Click += new System.EventHandler(this.LblDashboard_Click);
            // 
            // CmdDeleteCustomer
            // 
            this.CmdDeleteCustomer.Location = new System.Drawing.Point(741, 353);
            this.CmdDeleteCustomer.Name = "CmdDeleteCustomer";
            this.CmdDeleteCustomer.Size = new System.Drawing.Size(236, 48);
            this.CmdDeleteCustomer.TabIndex = 39;
            this.CmdDeleteCustomer.Text = "Delete Selected";
            this.CmdDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // CmdModifyCustomer
            // 
            this.CmdModifyCustomer.Location = new System.Drawing.Point(437, 353);
            this.CmdModifyCustomer.Name = "CmdModifyCustomer";
            this.CmdModifyCustomer.Size = new System.Drawing.Size(239, 48);
            this.CmdModifyCustomer.TabIndex = 38;
            this.CmdModifyCustomer.Text = "Modify Selected";
            this.CmdModifyCustomer.UseVisualStyleBackColor = true;
            // 
            // CmdCreateCustomer
            // 
            this.CmdCreateCustomer.Location = new System.Drawing.Point(86, 353);
            this.CmdCreateCustomer.Name = "CmdCreateCustomer";
            this.CmdCreateCustomer.Size = new System.Drawing.Size(246, 48);
            this.CmdCreateCustomer.TabIndex = 37;
            this.CmdCreateCustomer.Text = "Add New Customer";
            this.CmdCreateCustomer.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(565, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // TxtSearchDB
            // 
            this.TxtSearchDB.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtSearchDB.Location = new System.Drawing.Point(657, 118);
            this.TxtSearchDB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TxtSearchDB.Name = "TxtSearchDB";
            this.TxtSearchDB.Size = new System.Drawing.Size(862, 71);
            this.TxtSearchDB.TabIndex = 45;
            // 
            // Kunden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2108, 989);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TxtSearchDB);
            this.Controls.Add(this.CmdDeleteCustomer);
            this.Controls.Add(this.CmdModifyCustomer);
            this.Controls.Add(this.CmdCreateCustomer);
            this.Controls.Add(this.LblDashboard);
            this.Controls.Add(this.GrdCustomer);
            this.Name = "Kunden";
            this.Text = "Kunden";
            ((System.ComponentModel.ISupportInitialize)(this.GrdCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdCustomer;
        private System.Windows.Forms.Label LblDashboard;
        private System.Windows.Forms.Button CmdDeleteCustomer;
        private System.Windows.Forms.Button CmdModifyCustomer;
        private System.Windows.Forms.Button CmdCreateCustomer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtSearchDB;
    }
}