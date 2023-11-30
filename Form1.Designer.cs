
namespace LAB3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.cbxDataformat = new System.Windows.Forms.ComboBox();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.chkMD5 = new System.Windows.Forms.CheckBox();
            this.txtSHA_1 = new System.Windows.Forms.TextBox();
            this.chkSHA_1 = new System.Windows.Forms.CheckBox();
            this.txtSHA_256 = new System.Windows.Forms.TextBox();
            this.chkSHA_256 = new System.Windows.Forms.CheckBox();
            this.txtSHA_384 = new System.Windows.Forms.TextBox();
            this.chkSHA_384 = new System.Windows.Forms.CheckBox();
            this.txtSHA_512 = new System.Windows.Forms.TextBox();
            this.chkSHA_512 = new System.Windows.Forms.CheckBox();
            this.txtRIPEMD160 = new System.Windows.Forms.TextBox();
            this.chkRIPEMD160 = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.White;
            this.txtData.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtData.Location = new System.Drawing.Point(137, 55);
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtData.Size = new System.Drawing.Size(629, 20);
            this.txtData.TabIndex = 1;
            this.txtData.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbxDataformat
            // 
            this.cbxDataformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDataformat.FormattingEnabled = true;
            this.cbxDataformat.Items.AddRange(new object[] {
            "Text string",
            "Hex string",
            "File"});
            this.cbxDataformat.Location = new System.Drawing.Point(38, 54);
            this.cbxDataformat.Name = "cbxDataformat";
            this.cbxDataformat.Size = new System.Drawing.Size(86, 21);
            this.cbxDataformat.TabIndex = 2;
            // 
            // txtMD5
            // 
            this.txtMD5.BackColor = System.Drawing.Color.White;
            this.txtMD5.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMD5.Location = new System.Drawing.Point(137, 111);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.ReadOnly = true;
            this.txtMD5.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtMD5.Size = new System.Drawing.Size(629, 20);
            this.txtMD5.TabIndex = 1;
            this.txtMD5.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chkMD5
            // 
            this.chkMD5.AutoSize = true;
            this.chkMD5.Location = new System.Drawing.Point(38, 111);
            this.chkMD5.Name = "chkMD5";
            this.chkMD5.Size = new System.Drawing.Size(49, 17);
            this.chkMD5.TabIndex = 3;
            this.chkMD5.Text = "MD5";
            this.chkMD5.UseVisualStyleBackColor = true;
            // 
            // txtSHA_1
            // 
            this.txtSHA_1.BackColor = System.Drawing.Color.White;
            this.txtSHA_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSHA_1.Location = new System.Drawing.Point(137, 149);
            this.txtSHA_1.Name = "txtSHA_1";
            this.txtSHA_1.ReadOnly = true;
            this.txtSHA_1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSHA_1.Size = new System.Drawing.Size(629, 20);
            this.txtSHA_1.TabIndex = 1;
            this.txtSHA_1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chkSHA_1
            // 
            this.chkSHA_1.AutoSize = true;
            this.chkSHA_1.Location = new System.Drawing.Point(38, 150);
            this.chkSHA_1.Name = "chkSHA_1";
            this.chkSHA_1.Size = new System.Drawing.Size(60, 17);
            this.chkSHA_1.TabIndex = 3;
            this.chkSHA_1.Text = "SHA_1";
            this.chkSHA_1.UseVisualStyleBackColor = true;
            // 
            // txtSHA_256
            // 
            this.txtSHA_256.BackColor = System.Drawing.Color.White;
            this.txtSHA_256.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSHA_256.Location = new System.Drawing.Point(137, 187);
            this.txtSHA_256.Name = "txtSHA_256";
            this.txtSHA_256.ReadOnly = true;
            this.txtSHA_256.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSHA_256.Size = new System.Drawing.Size(629, 20);
            this.txtSHA_256.TabIndex = 1;
            this.txtSHA_256.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chkSHA_256
            // 
            this.chkSHA_256.AutoSize = true;
            this.chkSHA_256.Location = new System.Drawing.Point(38, 189);
            this.chkSHA_256.Name = "chkSHA_256";
            this.chkSHA_256.Size = new System.Drawing.Size(69, 17);
            this.chkSHA_256.TabIndex = 3;
            this.chkSHA_256.Text = "SHA-256";
            this.chkSHA_256.UseVisualStyleBackColor = true;
            // 
            // txtSHA_384
            // 
            this.txtSHA_384.BackColor = System.Drawing.Color.White;
            this.txtSHA_384.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSHA_384.Location = new System.Drawing.Point(137, 225);
            this.txtSHA_384.Name = "txtSHA_384";
            this.txtSHA_384.ReadOnly = true;
            this.txtSHA_384.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSHA_384.Size = new System.Drawing.Size(629, 20);
            this.txtSHA_384.TabIndex = 1;
            this.txtSHA_384.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chkSHA_384
            // 
            this.chkSHA_384.AutoSize = true;
            this.chkSHA_384.Location = new System.Drawing.Point(38, 228);
            this.chkSHA_384.Name = "chkSHA_384";
            this.chkSHA_384.Size = new System.Drawing.Size(69, 17);
            this.chkSHA_384.TabIndex = 3;
            this.chkSHA_384.Text = "SHA-384";
            this.chkSHA_384.UseVisualStyleBackColor = true;
            // 
            // txtSHA_512
            // 
            this.txtSHA_512.BackColor = System.Drawing.Color.White;
            this.txtSHA_512.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSHA_512.Location = new System.Drawing.Point(137, 263);
            this.txtSHA_512.Name = "txtSHA_512";
            this.txtSHA_512.ReadOnly = true;
            this.txtSHA_512.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSHA_512.Size = new System.Drawing.Size(629, 20);
            this.txtSHA_512.TabIndex = 1;
            this.txtSHA_512.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chkSHA_512
            // 
            this.chkSHA_512.AutoSize = true;
            this.chkSHA_512.Location = new System.Drawing.Point(38, 267);
            this.chkSHA_512.Name = "chkSHA_512";
            this.chkSHA_512.Size = new System.Drawing.Size(69, 17);
            this.chkSHA_512.TabIndex = 3;
            this.chkSHA_512.Text = "SHA-512";
            this.chkSHA_512.UseVisualStyleBackColor = true;
            // 
            // txtRIPEMD160
            // 
            this.txtRIPEMD160.BackColor = System.Drawing.Color.White;
            this.txtRIPEMD160.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtRIPEMD160.Location = new System.Drawing.Point(137, 301);
            this.txtRIPEMD160.Name = "txtRIPEMD160";
            this.txtRIPEMD160.ReadOnly = true;
            this.txtRIPEMD160.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtRIPEMD160.Size = new System.Drawing.Size(629, 20);
            this.txtRIPEMD160.TabIndex = 1;
            this.txtRIPEMD160.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chkRIPEMD160
            // 
            this.chkRIPEMD160.AutoSize = true;
            this.chkRIPEMD160.Location = new System.Drawing.Point(38, 306);
            this.chkRIPEMD160.Name = "chkRIPEMD160";
            this.chkRIPEMD160.Size = new System.Drawing.Size(86, 17);
            this.chkRIPEMD160.TabIndex = 3;
            this.chkRIPEMD160.Text = "RIPEMD160";
            this.chkRIPEMD160.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(524, 368);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(609, 368);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(694, 368);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 403);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkRIPEMD160);
            this.Controls.Add(this.chkSHA_512);
            this.Controls.Add(this.chkSHA_384);
            this.Controls.Add(this.chkSHA_256);
            this.Controls.Add(this.chkSHA_1);
            this.Controls.Add(this.chkMD5);
            this.Controls.Add(this.cbxDataformat);
            this.Controls.Add(this.txtRIPEMD160);
            this.Controls.Add(this.txtSHA_512);
            this.Controls.Add(this.txtSHA_384);
            this.Controls.Add(this.txtSHA_256);
            this.Controls.Add(this.txtSHA_1);
            this.Controls.Add(this.txtMD5);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Hash Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.ComboBox cbxDataformat;
        private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.CheckBox chkMD5;
        private System.Windows.Forms.TextBox txtSHA_1;
        private System.Windows.Forms.CheckBox chkSHA_1;
        private System.Windows.Forms.TextBox txtSHA_256;
        private System.Windows.Forms.CheckBox chkSHA_256;
        private System.Windows.Forms.TextBox txtSHA_384;
        private System.Windows.Forms.CheckBox chkSHA_384;
        private System.Windows.Forms.TextBox txtSHA_512;
        private System.Windows.Forms.CheckBox chkSHA_512;
        private System.Windows.Forms.TextBox txtRIPEMD160;
        private System.Windows.Forms.CheckBox chkRIPEMD160;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

