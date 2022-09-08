using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Escola.View
{
    public partial class CadastroAluno : Form
    {

        private Image image;

        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(ofd.FileName);
                pic.Image = image;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ValidaCampos())
            {
                Db.db.
            }
            
        }

        private bool ValidaCampos()
        {
            if (!ValidaCamposSemValor())
            {
                return false;
            }
            if (!ValidaCaractesCorretos()) {
                return false; 
            }

            return false;
        }

        private bool ValidaCamposSemValor()
        {
            if (nomeTB.Text != String.Empty && cpfTB.Text != String.Empty &&
                generoCB.SelectedIndex > 0 && image != null)
            {
                return true;
            }
            return false;
        }

        private bool ValidaCaractesCorretos()
        {
            if (!Regex.IsMatch(nomeTB.Text, "[0-9]*"))
            {
                return true;
            }
            MessageBox.Show("Verifique a integridade dos campos.");
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
