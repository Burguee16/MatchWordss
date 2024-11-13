using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MatchWords
{
    public partial class Vocabulary : Form
    {
        public Vocabulary()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            InitialScreen initialScreen = new InitialScreen();
            initialScreen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewWord newword = new NewWord();
            newword.Show();
        }

        private void Vocabulary_Load(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            List<Word> listaPalabras = new List<Word>();
            listaPalabras = datos.listar();
            dgvWords.DataSource = listaPalabras;



        }
    }
}
