namespace ChecksumHash
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnCalculasHash = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_hash = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cb_hastype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_error = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(465, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 156);
            this.label4.TabIndex = 1;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "¿Como se usa?";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Heyy";
            this.notifyIcon1.BalloonTipTitle = "DDD";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnCalculasHash
            // 
            this.btnCalculasHash.Location = new System.Drawing.Point(255, 221);
            this.btnCalculasHash.Name = "btnCalculasHash";
            this.btnCalculasHash.Size = new System.Drawing.Size(177, 46);
            this.btnCalculasHash.TabIndex = 1;
            this.btnCalculasHash.Text = "Calcular Hash";
            this.btnCalculasHash.UseVisualStyleBackColor = true;
            this.btnCalculasHash.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Seleccionar Archivo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Checksum File";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_hash
            // 
            this.tb_hash.Location = new System.Drawing.Point(31, 66);
            this.tb_hash.Multiline = true;
            this.tb_hash.Name = "tb_hash";
            this.tb_hash.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_hash.Size = new System.Drawing.Size(401, 104);
            this.tb_hash.TabIndex = 4;
            this.tb_hash.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(31, 277);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(401, 10);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // cb_hastype
            // 
            this.cb_hastype.AllowDrop = true;
            this.cb_hastype.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cb_hastype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hastype.FormattingEnabled = true;
            this.cb_hastype.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cb_hastype.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.cb_hastype.Location = new System.Drawing.Point(142, 187);
            this.cb_hastype.Name = "cb_hastype";
            this.cb_hastype.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_hastype.Size = new System.Drawing.Size(290, 28);
            this.cb_hastype.Sorted = true;
            this.cb_hastype.TabIndex = 6;
            this.cb_hastype.TabStop = false;
            this.cb_hastype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hash Type:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_error);
            this.groupBox2.Location = new System.Drawing.Point(463, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 59);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debugging";
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tb_error
            // 
            this.tb_error.Location = new System.Drawing.Point(6, 23);
            this.tb_error.Name = "tb_error";
            this.tb_error.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_error.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_error.Size = new System.Drawing.Size(403, 27);
            this.tb_error.TabIndex = 0;
            this.tb_error.Text = "No errors Found";
            this.tb_error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_error.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(898, 294);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_hastype);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tb_hash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCalculasHash);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File CheckSum - By @j0rd1s3rr4n0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private NotifyIcon notifyIcon1;
        private Button btnCalculasHash;
        private OpenFileDialog openFileDialog1;
        private Button button2;
        private Label label1;
        private TextBox tb_hash;
        private ProgressBar progressBar1;
        private ComboBox cb_hastype;
        private Label label2;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox tb_error;
        private System.Windows.Forms.Timer timer1;
    }
}