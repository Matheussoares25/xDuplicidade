using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ValidadorDuplicidade
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void lostAcceptButton1_Click(object sender, EventArgs e)
        {
            string nome =  celnome.Text;
            string valor = celvalor.Text;

           

            Properties.Settings.Default.cel_nome = nome;
            Properties.Settings.Default.cel_valor = valor;
            Properties.Settings.Default.Save();

        }
    }
}
