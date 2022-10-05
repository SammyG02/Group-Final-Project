namespace proj1
{
    partial class SellingPlace
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
            this.label3 = new System.Windows.Forms.Label();
            this.UserCO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVCO = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.BalanceCO = new System.Windows.Forms.Label();
            this.IdCO = new System.Windows.Forms.TextBox();
            this.ClearCO = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddCart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.QuantityCO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.spTemplate1 = new proj1.SPTemplate();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1235, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UserCO
            // 
            this.UserCO.AutoSize = true;
            this.UserCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCO.ForeColor = System.Drawing.Color.White;
            this.UserCO.Location = new System.Drawing.Point(21, 165);
            this.UserCO.Name = "UserCO";
            this.UserCO.Size = new System.Drawing.Size(119, 25);
            this.UserCO.TabIndex = 5;
            this.UserCO.Text = "User Name";
            this.UserCO.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(154, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "LogOut";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(512, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Buying Place";
            // 
            // DGVCO
            // 
            this.DGVCO.AllowUserToOrderColumns = true;
            this.DGVCO.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVCO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCO.Location = new System.Drawing.Point(450, 156);
            this.DGVCO.Name = "DGVCO";
            this.DGVCO.RowHeadersWidth = 51;
            this.DGVCO.RowTemplate.Height = 24;
            this.DGVCO.Size = new System.Drawing.Size(818, 263);
            this.DGVCO.TabIndex = 15;
            this.DGVCO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCO_CellClick);
            this.DGVCO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCO_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BalanceCO
            // 
            this.BalanceCO.AutoSize = true;
            this.BalanceCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceCO.ForeColor = System.Drawing.Color.White;
            this.BalanceCO.Location = new System.Drawing.Point(21, 239);
            this.BalanceCO.Name = "BalanceCO";
            this.BalanceCO.Size = new System.Drawing.Size(30, 25);
            this.BalanceCO.TabIndex = 17;
            this.BalanceCO.Text = " 0";
            // 
            // IdCO
            // 
            this.IdCO.Enabled = false;
            this.IdCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdCO.Location = new System.Drawing.Point(26, 399);
            this.IdCO.Multiline = true;
            this.IdCO.Name = "IdCO";
            this.IdCO.Size = new System.Drawing.Size(262, 48);
            this.IdCO.TabIndex = 18;
            this.IdCO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClearCO
            // 
            this.ClearCO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClearCO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearCO.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.ClearCO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ClearCO.Location = new System.Drawing.Point(26, 724);
            this.ClearCO.Name = "ClearCO";
            this.ClearCO.Size = new System.Drawing.Size(151, 51);
            this.ClearCO.TabIndex = 21;
            this.ClearCO.Text = "clear";
            this.ClearCO.UseVisualStyleBackColor = false;
            this.ClearCO.Click += new System.EventHandler(this.ClearCO_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button2.Location = new System.Drawing.Point(699, 831);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 51);
            this.button2.TabIndex = 22;
            this.button2.Text = "Check Out";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // AddCart
            // 
            this.AddCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCart.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.AddCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AddCart.Location = new System.Drawing.Point(26, 638);
            this.AddCart.Name = "AddCart";
            this.AddCart.Size = new System.Drawing.Size(221, 67);
            this.AddCart.TabIndex = 23;
            this.AddCart.Text = "Add To Cart";
            this.AddCart.UseVisualStyleBackColor = false;
            this.AddCart.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Quantity";
            // 
            // QuantityCO
            // 
            this.QuantityCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityCO.Location = new System.Drawing.Point(26, 503);
            this.QuantityCO.Multiline = true;
            this.QuantityCO.Name = "QuantityCO";
            this.QuantityCO.Size = new System.Drawing.Size(262, 48);
            this.QuantityCO.TabIndex = 25;
            this.QuantityCO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(955, 850);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 32);
            this.label8.TabIndex = 26;
            this.label8.Text = "Total :$0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(23, 568);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 32);
            this.label9.TabIndex = 27;
            this.label9.Text = "Price: $0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proj1.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.spTemplate1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(450, 449);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(818, 376);
            this.flowLayoutPanel1.TabIndex = 28;
            // 
            // spTemplate1
            // 
            this.spTemplate1.Location = new System.Drawing.Point(3, 3);
            this.spTemplate1.Name = "spTemplate1";
            this.spTemplate1.sCategory = null;
            this.spTemplate1.sId = null;
            this.spTemplate1.Size = new System.Drawing.Size(279, 292);
            this.spTemplate1.sName = null;
            this.spTemplate1.sPrice = null;
            this.spTemplate1.sQuantity = null;
            this.spTemplate1.sTotal = null;
            this.spTemplate1.TabIndex = 0;
            // 
            // SellingPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1280, 904);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.QuantityCO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddCart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ClearCO);
            this.Controls.Add(this.IdCO);
            this.Controls.Add(this.BalanceCO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGVCO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserCO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingPlace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingPlace";
            this.Load += new System.EventHandler(this.SellingPlace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UserCO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVCO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BalanceCO;
        private System.Windows.Forms.TextBox IdCO;
        private System.Windows.Forms.Button ClearCO;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddCart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox QuantityCO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private SPTemplate spTemplate1;
    }
}