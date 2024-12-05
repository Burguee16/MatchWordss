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
        Datos datos = new Datos();
        List<Word> listaPalabras = new List<Word>();
        private Button botonSeleccionado1 = null;
        private Button botonSeleccionado2 = null;
        private Timer timer;
        private Button botonParaOcultar1;
        private Button botonParaOcultar2;
        private Random random;
        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
            Button botonActual = sender as Button;
            
            if(botonActual == null)
            {
                MessageBox.Show("ERROR");
                return;
            }
            if(botonSeleccionado1 == null)
            {
                botonSeleccionado1 = botonActual;
                botonSeleccionado1.BackColor = Color.LightBlue;
                return;
            }
            if(botonSeleccionado2 == null)
            {
                botonSeleccionado2 = botonActual;
                botonSeleccionado2.BackColor = Color.LightBlue;

                if(botonSeleccionado1.Tag != null && botonSeleccionado2.Tag != null &&
                    botonSeleccionado1.Tag.ToString() ==  botonSeleccionado2.Tag.ToString())
                {
                    botonSeleccionado1.BackColor = Color.Green;
                    botonSeleccionado2.BackColor = Color.Green;

                    botonParaOcultar1 = botonSeleccionado1;
                    botonParaOcultar2 = botonSeleccionado2;

                    timer.Start();
                }
                else
                {
                    botonSeleccionado1.BackColor = Color.Red;
                    botonSeleccionado2.BackColor = Color.Red;
                }
                botonSeleccionado1 = null;
                botonSeleccionado2 = null;
                return;
            }
        }
        private void Timer_Tick(object sender,EventArgs e)
        {
            if(botonParaOcultar1 != null)
            {
                botonParaOcultar1.Visible = false;

            }
            if(botonParaOcultar2 != null)
            {
                botonParaOcultar2.Visible = false;
            }

            timer.Stop();
            botonSeleccionado1 = null;
            botonSeleccionado2 = null;
            botonParaOcultar1 = null;
            botonParaOcultar2 = null;

        }
        
        private void btnWord1_Click(object sender, EventArgs e)
        {

        }

        
    } 
    }

