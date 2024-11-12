﻿using System;
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
            try
            {
                Datos datos = new Datos();
                datos.setearConsulta("select palabra, translatee from words");
                DataTable tabla = new DataTable();
                dgvWords.DataSource = datos;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
