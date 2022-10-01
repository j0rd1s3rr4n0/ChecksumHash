using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ChecksumHash
{
    public partial class Form1 : Form
    {
        public string path = "";
        public string filename = "";
        Boolean isSavedFileHash = false;
        string hash = "";
        int maxValueProgressbar = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void carregarHashdarxiu()
        {
            timer1.Enabled = true;
            progressBar1.Value = 0;
            timer1.Start();
            timer1.Interval = maxValueProgressbar-1;
            progressBar1.Maximum = maxValueProgressbar;

            
            timer1.Tick += new EventHandler(timer1_Tick_1!);
        }
        private void creararchivo() 
        {
            using (StreamWriter stream = new FileInfo(path.Replace(filename,(filename + ".checksum".ToString()))).AppendText())
            {
                stream.WriteLine("HASHTYPE: "+cb_hastype.Text+"\nHASH: "+hash+"\n");
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            isSavedFileHash = false;
            if (!path.Equals("") && !(cb_hastype.ToString().Equals("")))
            {
                tb_error.Text = "ARCHIVO SELECCIONADO";

                    if (cb_hastype.Text.ToString().Equals("MD5"))
                    {
                        using (var md5 = MD5.Create())
                        {
                            try
                            {
                                using (var stream = File.OpenRead(path))
                                {
                                    tb_hash.Text = "";
                                    carregarHashdarxiu();
                                    hash = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                                    //return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                                }
                            }
                            catch (Exception)
                            {
                                notifyIcon1.BalloonTipTitle = "ERROR 404";
                                notifyIcon1.BalloonTipText = "Archivo NO encontrado";
                                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                                notifyIcon1.ShowBalloonTip(1000);
                                tb_error.Text = "ERROR OCURRED";
                                
                            }
                            
                        }
                    }else if (cb_hastype.Text.ToString().Equals("SHA512"))
                    {
                        using (SHA512 sha512 = new SHA512Managed())
                        {
                            try { 
                                using (var stream = File.OpenRead(path))
                                {
                                    tb_hash.Text = "";
                                    carregarHashdarxiu();
                                tb_hash.Text = BitConverter.ToString(sha512.ComputeHash(stream)).Replace("-", string.Empty);
                                    
                                //return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                            }
                            }
                            catch (Exception)
                            {
                                notifyIcon1.BalloonTipTitle = "ERROR 404";
                                notifyIcon1.BalloonTipText = "Archivo NO encontrado";
                                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                                notifyIcon1.ShowBalloonTip(1000);
                                tb_error.Text = "ERROR OCURRED";

                            }
                        }

                    }
                    else if (cb_hastype.Text.ToString().Equals("SHA256"))
                    {
                        using (SHA256 sha256 = new SHA256Managed())
                        {
                            try{
                                using (var stream = File.OpenRead(path))
                                {
                                    tb_hash.Text = "";
                                    carregarHashdarxiu();
                                tb_hash.Text = BitConverter.ToString(sha256.ComputeHash(stream)).Replace("-", string.Empty);
                                    //return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                                }
                            }
                            catch (Exception)
                            {
                                notifyIcon1.BalloonTipTitle = "ERROR 404";
                                notifyIcon1.BalloonTipText = "Archivo NO encontrado";
                                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                                notifyIcon1.ShowBalloonTip(1000);
                                tb_error.Text = "ERROR OCURRED";

                             }
                        }
                    }
                    else if (cb_hastype.Text.ToString().Equals("SHA384"))
                    {
                        using (SHA384 sha1 = new SHA384Managed())
                        {
                            try{
                                using (var stream = File.OpenRead(path))
                                {
                                    tb_hash.Text = "";
                                    carregarHashdarxiu();
                                tb_hash.Text = BitConverter.ToString(sha1.ComputeHash(stream)).Replace("-", string.Empty);
                                    //return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                                }
                            }
                            catch (Exception)
                            {
                                notifyIcon1.BalloonTipTitle = "ERROR 404";
                                notifyIcon1.BalloonTipText = "Archivo NO encontrado";
                                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                                notifyIcon1.ShowBalloonTip(1000);
                                tb_error.Text = "ERROR OCURRED";

                            }
                    }
                    }
                    else if (cb_hastype.Text.ToString().Equals("SHA1"))
                    {
                        using (SHA1Managed sha1 = new SHA1Managed())
                        {
                            try{
                                using (var stream = File.OpenRead(path))
                                {
                                    tb_hash.Text = "";
                                    carregarHashdarxiu();
                                    tb_hash.Text = BitConverter.ToString(sha1.ComputeHash(stream)).Replace("-", string.Empty);
                                    //return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                                }
                            }
                            catch (Exception)
                            {
                                notifyIcon1.BalloonTipTitle = "ERROR FILE";
                                notifyIcon1.BalloonTipText = "Archivo NO encontrado";
                                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                                notifyIcon1.ShowBalloonTip(1000);
                                tb_error.Text = "ERROR OCURRED";

                            }
                        }
                    }
                    else
                    {
                        notifyIcon1.BalloonTipTitle = "ERROR CONFIG";
                        notifyIcon1.BalloonTipText = "Falta SELECCIONAR HashType Valido";
                        notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                        notifyIcon1.ShowBalloonTip(2000);
                        tb_error.Text = "ERROR OCURRED";
                    }

            }
            else
            {
                notifyIcon1.BalloonTipTitle = "ERROR FILE";
                notifyIcon1.BalloonTipText = "NO SE SELECCIONO NINGUN ARCHIVO";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.ShowBalloonTip(1000);
                tb_error.Text = "ERROR OCURRED";
                //tb_error.Text = "NO SE SELECCIONO ARCHIVO";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int size = -1;
            string file = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Muestra el dialog de Seleccionar Archivo.
            if (result == DialogResult.OK) // Test result.
            {
                file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            //tb_error.Text = size + " " + result+" "+file; // debugging Tama�o, resultado(OK,ERROR) , path archivo
            
            // SI EL ESTADO DEL ARCHIVO ES OK ALMACENA PARA SEGUIR ADELANTE
            if (result.ToString().Equals("OK")){
                path = file; // Guarda el Path del Archivo en una variable Global
                string [] dd = path.Split('\\');
                filename = dd[dd.Length-1];
                  
                //tb_hash.Text = file+ " " + filename;  // Muestra EL path DEBUGGING
            }
            else{ path = ""; }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (progressBar1.Value != maxValueProgressbar)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
            }

            if (progressBar1.Value > maxValueProgressbar-1)
            {
                System.Threading.Thread.Sleep(1000);
                tb_hash.Text = hash; //Muestra el hash en Pantalla
                if (!isSavedFileHash)
                {
                    creararchivo(); //Crea el Archivo file.extension.checksum con sus resultados dentro
                    isSavedFileHash = true;
                }
                
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}