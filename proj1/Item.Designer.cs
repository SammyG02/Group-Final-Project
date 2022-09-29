
namespace proj1
{
    partial class Item
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.statchk = new System.Windows.Forms.CheckBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.ousbtn = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.errorhandler = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorhandler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(34, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(304, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(599, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(68, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "ITEMS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(446, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nametxt.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(38, 124);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(246, 22);
            this.nametxt.TabIndex = 6;
            // 
            // idtxt
            // 
            this.idtxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.idtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idtxt.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(308, 125);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(104, 22);
            this.idtxt.TabIndex = 7;
            // 
            // quantitytxt
            // 
            this.quantitytxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quantitytxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantitytxt.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitytxt.Location = new System.Drawing.Point(438, 124);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(111, 22);
            this.quantitytxt.TabIndex = 8;
            // 
            // statchk
            // 
            this.statchk.Appearance = System.Windows.Forms.Appearance.Button;
            this.statchk.AutoSize = true;
            this.statchk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.statchk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statchk.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statchk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.statchk.Location = new System.Drawing.Point(594, 124);
            this.statchk.Name = "statchk";
            this.statchk.Size = new System.Drawing.Size(72, 26);
            this.statchk.TabIndex = 9;
            this.statchk.Text = "In Stock";
            this.statchk.UseVisualStyleBackColor = false;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbtn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.addbtn.Location = new System.Drawing.Point(23, 546);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(95, 34);
            this.addbtn.TabIndex = 10;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updatebtn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.updatebtn.Location = new System.Drawing.Point(284, 546);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(111, 33);
            this.updatebtn.TabIndex = 11;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // removebtn
            // 
            this.removebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.removebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removebtn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.removebtn.Location = new System.Drawing.Point(421, 547);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(99, 33);
            this.removebtn.TabIndex = 12;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = false;
            this.removebtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // ousbtn
            // 
            this.ousbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ousbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ousbtn.Font = new System.Drawing.Font("Arial Narrow", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ousbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ousbtn.Location = new System.Drawing.Point(561, 555);
            this.ousbtn.Name = "ousbtn";
            this.ousbtn.Size = new System.Drawing.Size(72, 24);
            this.ousbtn.TabIndex = 13;
            this.ousbtn.Text = "Out Of Stock";
            this.ousbtn.UseVisualStyleBackColor = false;
            this.ousbtn.Click += new System.EventHandler(this.ousbtn_Click);
            // 
            // datagrid
            // 
            this.datagrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(23, 189);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersWidth = 51;
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(643, 301);
            this.datagrid.TabIndex = 14;
            // 
            // errorhandler
            // 
            this.errorhandler.ContainerControl = this;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(686, 638);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.ousbtn);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.statchk);
            this.Controls.Add(this.quantitytxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item";
            this.Text = "Item";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorhandler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.CheckBox statchk;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button ousbtn;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.ErrorProvider errorhandler;
    }
}