namespace SecretUI
{
    partial class Quick
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.textJumlah = new System.Windows.Forms.TextBox();
            this.labelNoid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_location = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioTake = new System.Windows.Forms.RadioButton();
            this.radioPut = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textNoid = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(172, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 47);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(21, 271);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(128, 47);
            this.btnAccept.TabIndex = 41;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // textJumlah
            // 
            this.textJumlah.BackColor = System.Drawing.Color.White;
            this.textJumlah.Font = new System.Drawing.Font("Cooper Black", 9.75F);
            this.textJumlah.ForeColor = System.Drawing.Color.Black;
            this.textJumlah.Location = new System.Drawing.Point(147, 215);
            this.textJumlah.Name = "textJumlah";
            this.textJumlah.Size = new System.Drawing.Size(160, 22);
            this.textJumlah.TabIndex = 40;
            this.textJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textJumlah.TextChanged += new System.EventHandler(this.textJumlah_TextChanged);
            // 
            // labelNoid
            // 
            this.labelNoid.AutoSize = true;
            this.labelNoid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.labelNoid.Location = new System.Drawing.Point(98, 54);
            this.labelNoid.Name = "labelNoid";
            this.labelNoid.Size = new System.Drawing.Size(94, 19);
            this.labelNoid.TabIndex = 0;
            this.labelNoid.Text = "No Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label7.Location = new System.Drawing.Point(16, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 28);
            this.label7.TabIndex = 39;
            this.label7.Text = "Jumlah   :";
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label_location.Location = new System.Drawing.Point(142, 148);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(74, 28);
            this.label_location.TabIndex = 38;
            this.label_location.Text = "None";
            this.label_location.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label9.Location = new System.Drawing.Point(16, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 28);
            this.label9.TabIndex = 37;
            this.label9.Text = "Location :";
            // 
            // radioTake
            // 
            this.radioTake.AutoSize = true;
            this.radioTake.BackColor = System.Drawing.Color.Transparent;
            this.radioTake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioTake.FlatAppearance.BorderSize = 0;
            this.radioTake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioTake.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.radioTake.Location = new System.Drawing.Point(172, 97);
            this.radioTake.Name = "radioTake";
            this.radioTake.Size = new System.Drawing.Size(84, 32);
            this.radioTake.TabIndex = 31;
            this.radioTake.TabStop = true;
            this.radioTake.Text = "Take";
            this.radioTake.UseVisualStyleBackColor = false;
            this.radioTake.CheckedChanged += new System.EventHandler(this.radioTake_CheckedChanged);
            // 
            // radioPut
            // 
            this.radioPut.AutoSize = true;
            this.radioPut.BackColor = System.Drawing.Color.Transparent;
            this.radioPut.FlatAppearance.BorderSize = 0;
            this.radioPut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioPut.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.radioPut.Location = new System.Drawing.Point(78, 97);
            this.radioPut.Name = "radioPut";
            this.radioPut.Size = new System.Drawing.Size(63, 32);
            this.radioPut.TabIndex = 30;
            this.radioPut.TabStop = true;
            this.radioPut.Text = "Put";
            this.radioPut.UseVisualStyleBackColor = false;
            this.radioPut.CheckedChanged += new System.EventHandler(this.radioPut_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label6.Location = new System.Drawing.Point(132, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 28);
            this.label6.TabIndex = 29;
            this.label6.Text = "SET";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(57)))));
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(321, 30);
            this.panel6.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Right;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(282, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 28);
            this.label11.TabIndex = 23;
            this.label11.Text = "#2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(101, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "What you wanna do?";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.labelDescription.Location = new System.Drawing.Point(97, 130);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(98, 19);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description ";
            // 
            // textDescription
            // 
            this.textDescription.BackColor = System.Drawing.Color.White;
            this.textDescription.Enabled = false;
            this.textDescription.Font = new System.Drawing.Font("Cooper Black", 9.75F);
            this.textDescription.ForeColor = System.Drawing.Color.Black;
            this.textDescription.Location = new System.Drawing.Point(31, 156);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(212, 66);
            this.textDescription.TabIndex = 3;
            // 
            // textNoid
            // 
            this.textNoid.BackColor = System.Drawing.Color.White;
            this.textNoid.Font = new System.Drawing.Font("Cooper Black", 9.75F);
            this.textNoid.ForeColor = System.Drawing.Color.Black;
            this.textNoid.Location = new System.Drawing.Point(31, 84);
            this.textNoid.Name = "textNoid";
            this.textNoid.Size = new System.Drawing.Size(212, 22);
            this.textNoid.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(31, 279);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(212, 39);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label5.Location = new System.Drawing.Point(27, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Stock :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.labelNoid);
            this.panel3.Controls.Add(this.textNoid);
            this.panel3.Controls.Add(this.labelDescription);
            this.panel3.Controls.Add(this.textDescription);
            this.panel3.Controls.Add(this.btnCheck);
            this.panel3.Controls.Add(this.labelStock);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(23, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 348);
            this.panel3.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(57)))));
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 30);
            this.panel4.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(248, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 28);
            this.label10.TabIndex = 23;
            this.label10.Text = "#1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(95, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Check It Out!";
            // 
            // labelStock
            // 
            this.labelStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.labelStock.Location = new System.Drawing.Point(98, 239);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(51, 19);
            this.labelStock.TabIndex = 36;
            this.labelStock.Text = "None";
            this.labelStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Controls.Add(this.btnAccept);
            this.panel5.Controls.Add(this.textJumlah);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label_location);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.radioTake);
            this.panel5.Controls.Add(this.radioPut);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(331, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(321, 348);
            this.panel5.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(26, 32);
            this.dataGridView1.TabIndex = 43;
            // 
            // Quick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Name = "Quick";
            this.Size = new System.Drawing.Size(675, 380);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox textJumlah;
        private System.Windows.Forms.Label labelNoid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioTake;
        private System.Windows.Forms.RadioButton radioPut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textNoid;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Panel panel5;
        private System.IO.Ports.SerialPort serialPort1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
