using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MailKit.Security;
using MimeKit;
using MailKit.Net.Smtp;

namespace ValidadorDuplicidade
{
    public partial class Report : Form
    {
        string[] caminhosImagens;
        public Report()
        {
            InitializeComponent();
        }

        private void aloneButton1_Click(object sender, EventArgs e)
        {
            string senha = "rflf knnr tmib xaqj\r\n";
            string descricao = Descricao.Text;
            try
            {
                var email = new MimeMessage();

                email.From.Add(MailboxAddress.Parse("matheusaparecido779944@gmail.com"));
                email.To.Add(MailboxAddress.Parse("ti2@masterpumps.com.br"));

                email.Subject = "Problemas no software 'xDuplicidade'";

                var builder = new BodyBuilder();
                builder.TextBody = descricao;


                if (caminhosImagens != null)
                {
                    foreach (var imagem in caminhosImagens)
                    {
                        builder.Attachments.Add(imagem);
                    }
                }

                email.Body = builder.ToMessageBody();

                using var smtp = new SmtpClient();

                smtp.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);

                smtp.Authenticate("matheusaparecido779944@gmail.com", senha);

                smtp.Send(email);

                smtp.Disconnect(true);
                MessageBox.Show("Email enviado com sucesso ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao enviar email: " + ex.Message);

            }
        }


        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivo = new OpenFileDialog();

            arquivo.Filter = "Imagens (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            arquivo.Title = "Escolha uma imagem";
            arquivo.Multiselect = true;
            try
            {
                if (arquivo.ShowDialog() == DialogResult.OK)
                {
                    foreach (string imagem in arquivo.FileNames)
                    {
                        PictureBox pb = new PictureBox();

                        pb.Width = 120;
                        pb.Height = 120;
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Image = new Bitmap(imagem);

                        flowLayoutPanel1.Controls.Add(pb);
                    }

                    caminhosImagens = arquivo.FileNames;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }
    }
}
