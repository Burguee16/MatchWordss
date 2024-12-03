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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            List<Word> listaPalabras = new List<Word>();
            listaPalabras = datos.listar();
            btnContador.Text = listaPalabras.Count().ToString();
            //////////////////////////////////
            btnWord1.Text = listaPalabras.First().palabra.ToString();
            btnTranslate1.Text = listaPalabras.First().translate.ToString();
            btnWord2.Text = listaPalabras.ElementAt(1).palabra.ToString();
            btnTranslate2.Text = listaPalabras.ElementAt(1).translate.ToString();
            btnWord3.Text = listaPalabras.ElementAt(2).palabra.ToString();
            btnTranslate3.Text = listaPalabras.ElementAt(2).translate.ToString();
            btnWord4.Text = listaPalabras.ElementAt(3).palabra.ToString();
            btnTranslate4.Text = listaPalabras.ElementAt(3).translate.ToString();
            btnWord5.Text = listaPalabras.ElementAt(4).palabra.ToString();
            btnTranslate5.Text = listaPalabras.ElementAt(4).translate.ToString();
        }

        private void btnWord1_Click(object sender, EventArgs e)
        {

        }
    } 
    }

