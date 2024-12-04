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
        private Button botonSeleccionado1 = null;
        private Button botonSeleccionado2 = null;
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
            ////////////////////////////////// MOSTRAR LAS PALABRAS
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

            ////////////////////////////// EVENTO DE CLICKS

            btnWord1.Click += Boton_Click;
            btnWord2.Click += Boton_Click;
            btnWord3.Click += Boton_Click;
            btnWord4.Click += Boton_Click;
            btnWord5.Click += Boton_Click;

            btnTranslate1.Click += Boton_Click;
            btnTranslate2.Click += Boton_Click;
            btnTranslate3.Click += Boton_Click;
            btnTranslate4.Click += Boton_Click;
            btnTranslate5.Click += Boton_Click;

            
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            
            Button botonSeleccionado2 = null;    
            
            Button botonSeleccionado1 = null;
            

            if (botonSeleccionado1 == null)
            {
                Button botonActual1 = sender as Button;
                botonActual1 = botonSeleccionado1;
                botonActual1.BackColor = Color.LightBlue;
              
            }
            if(botonSeleccionado2 == null)
            {
                botonSeleccionado2.BackColor = Color.LightBlue;
            }
            if(botonActual1.Tag == botonSeleccionado2.Tag)
            {
                botonActual1.BackColor = Color.Green;
                botonSeleccionado2.BackColor = Color.Green;
            }
        }
        
        private void btnWord1_Click(object sender, EventArgs e)
        {

        }

        
    } 
    }

