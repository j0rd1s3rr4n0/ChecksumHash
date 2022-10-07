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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnCalculasHash = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_hash = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cb_hastype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_error = new System.Windows.Forms.TextBox();
            this.modified_text = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(491, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Como Calcular un Hash?";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 179);
            this.label4.TabIndex = 1;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.btnCalculasHash.Location = new System.Drawing.Point(195, 221);
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
            this.button2.Location = new System.Drawing.Point(12, 221);
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
            this.tb_hash.Size = new System.Drawing.Size(441, 104);
            this.tb_hash.TabIndex = 4;
            this.tb_hash.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 277);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(743, 14);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
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
            this.cb_hastype.Size = new System.Drawing.Size(230, 28);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ChecksumHash.Properties.Resources.integrity;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(388, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 80);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(819, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 226);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "¿Como Verificar la Integridad de un Archivo?";
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoEllipsis = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 179);
            this.label5.TabIndex = 1;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChecksumHash.Properties.Resources.grey;
            this.pictureBox1.Location = new System.Drawing.Point(478, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // tb_error
            // 
            this.tb_error.Location = new System.Drawing.Point(1155, 12);
            this.tb_error.Multiline = true;
            this.tb_error.Name = "tb_error";
            this.tb_error.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_error.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_error.Size = new System.Drawing.Size(121, 56);
            this.tb_error.TabIndex = 11;
            this.tb_error.Text = "No errors Found";
            this.tb_error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_error.UseWaitCursor = true;
            this.tb_error.Visible = false;
            // 
            // modified_text
            // 
            this.modified_text.AutoSize = true;
            this.modified_text.Location = new System.Drawing.Point(513, 247);
            this.modified_text.Name = "modified_text";
            this.modified_text.Size = new System.Drawing.Size(0, 20);
            this.modified_text.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1288, 294);
            this.Controls.Add(this.modified_text);
            this.Controls.Add(this.tb_error);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
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
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private GroupBox groupBox3;
        private Label label5;
        private PictureBox pictureBox1;
        private TextBox tb_error;
        private Label modified_text;
    }
}