using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChecksumHash
{
    public partial class Form1 : Form
    {
        public string path = "";
        public string filename = "";
        string hash = "";
        public string file = "";
        public int size = 2;
        public string text = "";
        public string s_checksum = "";
        public string text_checksum = "";
        public Boolean seguarda = true;
        bool isfinished_calchash = false;
        public string hashtype_parsed = "";
        public bool verificantIntegritatArxiu = false;

        Boolean isSavedFileHash = false;
        
        int maxValueProgressbar = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void fun_calcularHash()
        {
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
                }
                else if (cb_hastype.Text.ToString().Equals("SHA512"))
                {
                    using (SHA512 sha512 = new SHA512Managed())
                    {
                        try
                        {
                            using (var stream = File.OpenRead(path))
                            {
                                tb_hash.Text = "";
                                carregarHashdarxiu();
                                hash = BitConverter.ToString(sha512.ComputeHash(stream)).Replace("-", string.Empty);

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
                        try
                        {
                            using (var stream = File.OpenRead(path))
                            {
                                tb_hash.Text = "";
                                carregarHashdarxiu();
                                hash = BitConverter.ToString(sha256.ComputeHash(stream)).Replace("-", string.Empty);
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
                        try
                        {
                            using (var stream = File.OpenRead(path))
                            {
                                tb_hash.Text = "";
                                carregarHashdarxiu();
                                hash = BitConverter.ToString(sha1.ComputeHash(stream)).Replace("-", string.Empty);
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
                        try
                        {
                            using (var stream = File.OpenRead(path))
                            {
                                tb_hash.Text = "";
                                carregarHashdarxiu();
                                hash = BitConverter.ToString(sha1.ComputeHash(stream)).Replace("-", string.Empty);
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
            isfinished_calchash = true;
        }
        public void carregarHashdarxiu()
        {
            pictureBox1.Image = ChecksumHash.Properties.Resources.grey;
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
                stream.WriteLine(cb_hastype.Text+":"+hash+"\n");
                stream.Close();
                
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ChecksumHash.Properties.Resources.grey;
            hash = "";
            isSavedFileHash = false;
            fun_calcularHash();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            contenidoarchivo(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e){}
        private void Form1_Load(object sender, EventArgs e) {}
        private void progressBar1_Click(object sender, EventArgs e){}

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (progressBar1.Value != maxValueProgressbar)
            {
                progressBar1.Visible = true;
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
                    if (seguarda == true)
                    {
                        creararchivo(); //Crea el Archivo file.extension.checksum con sus resultados dentro
                    }
                    isSavedFileHash = true;
                }
                progressBar1.Visible = false;
               
            }
            if(progressBar1.Value > maxValueProgressbar - 1)
            {
                if (verificantIntegritatArxiu)
                {
                    haveSameHash(hash);
                }
            }
        }
        private void contenidoarchivo(Boolean isread)
        {
            file = "";
            size = -1;
            if (isread)
            {
                string file_s_checksum = path.Replace(filename, s_checksum);
                try
                {
                    text_checksum = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (Exception)
                {
                }
            }
            else
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                DialogResult result = openFileDialog1.ShowDialog(); // Muestra el dialog de Seleccionar Archivo.
                if (result == DialogResult.OK) // Test result.
                {
                    file = openFileDialog1.FileName;
                    try
                    {
                        text = File.ReadAllText(file);
                        size = text.Length;
                    }
                    catch (Exception)
                    {
                    }
                }
                //tb_error.Text = size + " " + result+" "+file; // debugging Tamaño, resultado(OK,ERROR) , path archivo

                // SI EL ESTADO DEL ARCHIVO ES OK ALMACENA PARA SEGUIR ADELANTE
                if (result.ToString().Equals("OK"))
                {
                    path = file; // Guarda el Path del Archivo en una variable Global
                    string[] dd = path.Split('\\');
                    filename = dd[dd.Length - 1];
                    s_checksum = dd[dd.Length - 1] + ".checksum";


                    //tb_hash.Text = file+ " " + filename;  // Muestra EL path DEBUGGING
                }
                else { path = ""; }
            }

        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void haveSameHash(string hash_new)
        {

            string hash_file = hash;
            //hash_file = hash_new;
            /* contenidoarchivo(true);      // Obtiene el hash.checksum del archivo viejo*/
            string hash_checksum_pased = "";
            try {
                System.IO.StreamReader file = new System.IO.StreamReader(path.Replace(filename, s_checksum));
                int counter = 0;
                tb_error.Text = path.Replace(filename, s_checksum);
                string hash_parsed = "";
                string line = "";
                try
                {
                    hashtype_parsed = "";
                    line = "";
                    while ((line = file.ReadLine()) != null)
                    {

                        string file_s_checksum = path.Replace(filename, s_checksum);
                        //AQUI COMPARAR EL HASH con la variable --> line
                        string hashtype = cb_hastype.Text.ToString();
                        hashtype_parsed = line.Split(':')[0].ToString();
                        hash_parsed = line.Split(':')[1].ToString();
                        tb_error.Text = line;

                        if (hashtype_parsed.Equals(cb_hastype.Text))
                        {
                            if (hash_parsed.Equals(hash_new))
                            {
                                hash_checksum_pased = hash_parsed;
                                tb_error.Text = hash_parsed + "\n" + line;
                                break;
                            }
                            else
                            {
                                hash_checksum_pased = "";
                            }
                        }
                        counter++;
                    }

                }
                catch (Exception)
                {
                    //  tb_error.Text = "ERROR READ FILE";
                }
                file.Close();


                if (hash_checksum_pased != "")
                {
                    notifyIcon1.BalloonTipTitle = "Archivo No Modificado";
                    notifyIcon1.BalloonTipText = "Hash Identico";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.ShowBalloonTip(1000);
                    // tb_error.Text = "Hash Identico";
                    pictureBox1.Image = ChecksumHash.Properties.Resources.green;
                    modified_text.Text = filename + " Integro!";
                }
                else
                {
                    notifyIcon1.BalloonTipTitle = "Archivo Modificado";
                    notifyIcon1.BalloonTipText = "Hash Diferente";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                    notifyIcon1.ShowBalloonTip(1000);
                    //tb_error.Text = "Hash Diferente";
                    pictureBox1.Image = ChecksumHash.Properties.Resources.red;
                    modified_text.Text = filename + " Corrupto o Modificado!";
                }
            }
            catch (Exception)
            {
                notifyIcon1.BalloonTipTitle = "ERROR NO SE PUDO VERIFICAR";
                notifyIcon1.BalloonTipText = "No dispone de Checksum Calculado";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.ShowBalloonTip(1000);
                //tb_error.Text = "Hash Diferente";
                pictureBox1.Image = ChecksumHash.Properties.Resources.grey;
                modified_text.Text = "ERROR el archivo " + filename + " no contiene .checksum correspondiente";
            }
            verificantIntegritatArxiu = false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {            
            pictureBox1.Image = ChecksumHash.Properties.Resources.grey;

            if (filename != "")
            {

                try
                {
                    verificantIntegritatArxiu = true;
                    modified_text.Text = "Verificando Integridad de " + filename;
                    /*isSavedFileHash = false;
                    isfinished_calchash = false;
                    */
                    fun_calcularHash(); // Calcula el hash del archivo NUEVO
                }
                catch (Exception)
                {
                    notifyIcon1.BalloonTipTitle = "ERROR NO SE PUDO VERIFICAR";
                    notifyIcon1.BalloonTipText = "No dispone de Checksum Calculado";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                    notifyIcon1.ShowBalloonTip(1000);
                    //tb_error.Text = "Hash Diferente";
                    pictureBox1.Image = ChecksumHash.Properties.Resources.grey;
                    modified_text.Text = "ERROR el archivo "+filename + " no contiene .checksum correspondiente";
                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}