using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace LAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát ?", " Confirm "
            , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtData.Text = "";
            txtMD5.Text = "";
            txtSHA_1.Text = "";
            txtSHA_256.Text = "";
            txtSHA_384.Text = "";
            txtSHA_512.Text = "";
            txtRIPEMD160.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxDataformat.SelectedItem = "Text string";
            txtData.Text = null;
        }
        private void EnableFormInteraction(bool enable)
        {
            // Duyệt qua tất cả các điều khiển trên form và vô hiệu hóa hoặc kích hoạt tùy thuộc vào giá trị của 'enable'
            foreach (Control control in Controls)
            {
                control.Enabled = enable;
            }
        }
        private string ComputeMD5Hash(string filePath)
        {
            if (chkMD5.Checked)
            {
                using (var stream = new BufferedStream(File.OpenRead(filePath), 1200000))
                {
                    MD5 md5 = MD5.Create();
                    byte[] check_md5 = md5.ComputeHash(stream);
                    return BitConverter.ToString(check_md5).Replace("-", String.Empty).ToLower();
                }
            }
            else
                return null;
        }
        private string ComputeSHA1Hash(string filePath)
        {
            if (chkSHA_1.Checked)
            {
                using (var stream = new BufferedStream(File.OpenRead(filePath), 1200000))
                {
                    SHA1 sha1 = SHA1.Create();
                    byte[] check_sha1 = sha1.ComputeHash(stream);
                    return BitConverter.ToString(check_sha1).Replace("-", String.Empty).ToLower();
                }
            }
            else
                return null;
        }
        private string ComputeSHA256Hash(string filePath)
        {
            if (chkSHA_256.Checked)
            {
                using (var stream = new BufferedStream(File.OpenRead(filePath), 1200000))
                {
                    SHA256 sha256 = SHA256.Create();
                    byte[] check_sha256 = sha256.ComputeHash(stream);
                    return BitConverter.ToString(check_sha256).Replace("-", String.Empty).ToLower();
                }
            }
            else
                return null;
        }
        private string ComputeSHA384Hash(string filePath)
        {
            if (chkSHA_384.Checked)
            {
                using (var stream = new BufferedStream(File.OpenRead(filePath), 1200000))
                {
                    SHA384 sha384 = SHA384.Create();
                    byte[] check_sha384 = sha384.ComputeHash(stream);
                    return BitConverter.ToString(check_sha384).Replace("-", String.Empty).ToLower();
                }
            }
            else
                return null;
        }
        private string ComputeSHA512Hash(string filePath)
        {
            if (chkSHA_512.Checked)
            {
                using (var stream = new BufferedStream(File.OpenRead(filePath), 1200000))
                {
                    SHA512 sha512 = SHA512.Create();
                    byte[] check_sha512 = sha512.ComputeHash(stream);
                    return BitConverter.ToString(check_sha512).Replace("-", String.Empty).ToLower();
                }
            }
            else
                return null;
        }
        private string ComputeRIPEMD160Hash(string filePath)
        {
            if (chkRIPEMD160.Checked)
            {
                using (var stream = new BufferedStream(File.OpenRead(filePath), 1200000))
                {
                    RIPEMD160 ripemd160 = RIPEMD160.Create();
                    byte[] check_ripemd160 = ripemd160.ComputeHash(stream);
                    return BitConverter.ToString(check_ripemd160).Replace("-", String.Empty).ToLower();
                }
            }
            else
                return null;
        }
        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            txtMD5.Text = "";
            txtSHA_1.Text = "";
            txtSHA_256.Text = "";
            txtSHA_384.Text = "";
            txtSHA_512.Text = "";
            txtRIPEMD160.Text = "";
            byte[] temp_text = null;
            if (cbxDataformat.SelectedItem != "File")
            {

                if (cbxDataformat.SelectedItem == "Text string")
                {
                    temp_text = Encoding.UTF8.GetBytes(txtData.Text);
                }
                else if (cbxDataformat.SelectedItem == "Hex string")
                {
                    try
                    {
                        // Chuyển đổi chuỗi HEX thành mảng byte
                        temp_text = HexStringToByteArray(txtData.Text);
                    }
                    catch (ArgumentException ex)
                    {
                        // Hiển thị hộp thoại cảnh báo nếu có lỗi
                        MessageBox.Show(ex.Message, "Chuỗi HEX phải có độ dài chẵn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (temp_text == null)
                    return;
                if (chkMD5.Checked)
                {
                    MD5 md5 = MD5.Create();
                    byte[] check_md5 = md5.ComputeHash(temp_text);
                    txtMD5.Text = BitConverter.ToString(check_md5).Replace("-", String.Empty).ToLower();
                }
                if (chkSHA_1.Checked)
                {
                    SHA1 sha1 = SHA1.Create();
                    byte[] check_sha1 = sha1.ComputeHash(temp_text);
                    txtSHA_1.Text = BitConverter.ToString(check_sha1).Replace("-", String.Empty).ToLower();
                }
                if (chkSHA_256.Checked)
                {
                    SHA256 sha256 = SHA256.Create();
                    byte[] check_sha256 = sha256.ComputeHash(temp_text);
                    txtSHA_256.Text = BitConverter.ToString(check_sha256).Replace("-", String.Empty).ToLower();
                }
                if (chkSHA_384.Checked)
                {
                    SHA384 sha384 = SHA384.Create();
                    byte[] check_sha384 = sha384.ComputeHash(temp_text);
                    txtSHA_384.Text = BitConverter.ToString(check_sha384).Replace("-", String.Empty).ToLower();
                }
                if (chkSHA_512.Checked)
                {
                    SHA512 sha512 = SHA512.Create();
                    byte[] check_sha512 = sha512.ComputeHash(temp_text);
                    txtSHA_512.Text = BitConverter.ToString(check_sha512).Replace("-", String.Empty).ToLower();
                }
                if (chkRIPEMD160.Checked)
                {
                    RIPEMD160 ripemd160 = RIPEMD160.Create();
                    byte[] check_ripemd160 = ripemd160.ComputeHash(temp_text);
                    txtRIPEMD160.Text = BitConverter.ToString(check_ripemd160).Replace("-", String.Empty).ToLower();
                }

            }
            else if (cbxDataformat.SelectedItem == "File")
            {
                OpenFileDialog inputpath = new OpenFileDialog();
                if (inputpath.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Bạn phải chọn 1 file", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                FormprocessingScreen processingScreen = new FormprocessingScreen();
                processingScreen.Show();
                EnableFormInteraction(false);
                //txtMD5.Text = await Task.Run(() => ComputeMD5Hash(inputpath.FileName));
                //txtSHA_1.Text = await Task.Run(() => ComputeSHA1Hash(inputpath.FileName));
                //txtSHA_256.Text = await Task.Run(() => ComputeSHA256Hash(inputpath.FileName));
                //txtSHA_384.Text = await Task.Run(() => ComputeSHA384Hash(inputpath.FileName));
                //txtSHA_512.Text = await Task.Run(() => ComputeSHA512Hash(inputpath.FileName));
                //txtRIPEMD160.Text = await Task.Run(() => ComputeRIPEMD160Hash(inputpath.FileName));


                //Task<string> md5Task = Task.Run(() => ComputeMD5Hash(inputpath.FileName));
                //Task<string> sha1Task = Task.Run(() => ComputeSHA1Hash(inputpath.FileName));
                //Task<string> sha256Task = Task.Run(() => ComputeSHA256Hash(inputpath.FileName));
                //Task<string> sha384Task = Task.Run(() => ComputeSHA384Hash(inputpath.FileName));
                //Task<string> sha512Task = Task.Run(() => ComputeSHA512Hash(inputpath.FileName));
                //Task<string> ripemd160Task = Task.Run(() => ComputeRIPEMD160Hash(inputpath.FileName));

                //await Task.WhenAll(md5Task, sha1Task, sha256Task, sha384Task, sha512Task, ripemd160Task);

                //txtMD5.Text = md5Task.Result;
                //txtSHA_1.Text = sha1Task.Result;
                //txtSHA_256.Text = sha256Task.Result;
                //txtSHA_384.Text = sha384Task.Result;
                //txtSHA_512.Text = sha512Task.Result;
                //txtRIPEMD160.Text = ripemd160Task.Result;
                string fileName = inputpath.FileName;

                Task md5Task = Task.Run(() =>
                {
                    string md5Result = ComputeMD5Hash(fileName);
                    txtMD5.Invoke((MethodInvoker)delegate { txtMD5.Text = md5Result; });
                });

                Task sha1Task = Task.Run(() =>
                {
                    string sha1Result = ComputeSHA1Hash(fileName);
                    txtSHA_1.Invoke((MethodInvoker)delegate { txtSHA_1.Text = sha1Result; });
                });

                Task sha256Task = Task.Run(() =>
                {
                    string sha256Result = ComputeSHA256Hash(fileName);
                    txtSHA_256.Invoke((MethodInvoker)delegate { txtSHA_256.Text = sha256Result; });
                });

                Task sha384Task = Task.Run(() =>
                {
                    string sha384Result = ComputeSHA384Hash(fileName);
                    txtSHA_384.Invoke((MethodInvoker)delegate { txtSHA_384.Text = sha384Result; });
                });

                Task sha512Task = Task.Run(() =>
                {
                    string sha512Result = ComputeSHA512Hash(fileName);
                    txtSHA_512.Invoke((MethodInvoker)delegate { txtSHA_512.Text = sha512Result; });
                });

                Task ripemd160Task = Task.Run(() =>
                {
                    string ripemd160Result = ComputeRIPEMD160Hash(fileName);
                    txtRIPEMD160.Invoke((MethodInvoker)delegate { txtRIPEMD160.Text = ripemd160Result; });
                });

                // Wait for all tasks to complete
                await Task.WhenAll(md5Task, sha1Task, sha256Task, sha384Task, sha512Task, ripemd160Task);

                processingScreen.Close();
                EnableFormInteraction(true);

            }
        }
        static byte[] HexStringToByteArray(string hex)
        {
            // Kiểm tra xem độ dài chuỗi có phải là số chẵn không
            if (hex.Length % 2 != 0)
                throw new ArgumentException("Độ dài của chuỗi HEX phải là số chẵn.");

            // Tạo mảng byte có độ dài bằng một nửa độ dài chuỗi HEX
            byte[] byteArray = new byte[hex.Length / 2];

            // Chuyển đổi từng cặp ký tự HEX thành byte và lưu vào mảng
            try
            {
                for (int i = 0; i < byteArray.Length; i++)
                {
                    byteArray[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
                }
            }
            catch (Exception exept)
            {
                MessageBox.Show(exept.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return byteArray;
        }
    }
}
