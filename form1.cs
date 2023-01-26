using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace Dosya_Şişirici
{
    
        private void Button1_Click(object sender, EventArgs e)
        {
            this.OpenFileDialog1.Filter = "Tüm Dosyalar(*.*)|*.*";
            this.OpenFileDialog1.FileName = "";
            this.OpenFileDialog1.ShowDialog();
        }

        // Token: 0x06000056 RID: 86 RVA: 0x0000D724 File Offset: 0x0000BB24
        private void Button2_Click(object sender, EventArgs e)
        {
            bool flag = Operators.CompareString(this.TextBox1.Text, "", false) == 0;
            if (flag)
                MessageBox.Show("Lütfen Şişirmek İstediğiniz Bir Dosya Seçiniz!", MsgBoxStyle.Exclamation, "Hata!");
            else
            {
                flag = (decimal.Compare(this.NumericUpDown1.Value, 0M) == 0);
                if (flag)
                    MessageBox.Show("Lütfen Dosyayı Kaç Mb Şişirmek İstediğinizi Yazınız!", MsgBoxStyle.Exclamation, "Hata!");
                else
                    try
                    {
                        FileStream fileStream = File.OpenWrite(this.TextBox1.Text);
                        long num = fileStream.Seek(0L, SeekOrigin.End);
                        int num2 = Convert.ToInt32(this.NumericUpDown1.Value);
                        decimal d = new decimal(System.Convert.ToInt64((num2 * 1048576)) + fileStream.Length);
                        while (decimal.Compare(new decimal(num), d) < 0)
                        {
                            num += 1L;
                            fileStream.WriteByte(0);
                        }
                        fileStream.Close();
                        MessageBox.Show("Dosya Başarıyla Şişirildi!", MsgBoxStyle.Information, "Başarılı!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, MsgBoxStyle.Exclamation, "Hata!");
                    }
            }
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.TextBox1.Text = string.Empty;
            this.TextBox1.Text = this.OpenFileDialog1.FileName;
        }
}
