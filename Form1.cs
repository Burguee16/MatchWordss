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
        int indicePalabras = 0;
        int indiceTraducciones = 0;
        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 400;
            timer.Tick += Timer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //NO APARECEN LOS BOTONES, listaPalabras esta vacia, hay que ver por que y llenarla
            GenerarBotonesAleatorios();
            GenerarBotonesPrueba();
            
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
                
                try
                {
                    GenerarPalabra(botonParaOcultar1,listaPalabras,ref indicePalabras);
                    
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                timer.Stop();
                

            }
            if(botonParaOcultar2 != null)
            {
                
                try
                {
                    GenerarTraduccion(botonParaOcultar2, listaPalabras, ref indiceTraducciones);
                }
                catch (Exception ex)
                {

                    throw ex;

                }
                
            }

            timer.Stop();
            botonSeleccionado1 = null;
            botonSeleccionado2 = null;
            botonParaOcultar1 = null;
            botonParaOcultar2 = null;

        }
        private void GenerarPalabra(Button botonParaOcultar,List<Word> listaPalabras, ref int indicePalabras)
        {
            
            if(indicePalabras >= listaPalabras.Count)
            {
                MessageBox.Show("No hay mas palabras");
                return;
            }

            Size sizeBoton = botonParaOcultar.Size;
            Point positionBoton = botonParaOcultar.Location;

            this.Controls.Remove(botonParaOcultar);

            string nuevaPalabra = listaPalabras[indicePalabras].palabra;
            Button nuevoBoton = new Button
            {
                Location = positionBoton,
                Size = sizeBoton,
                Tag = listaPalabras[indicePalabras],
                Text = nuevaPalabra
            };
            nuevoBoton.Click += Boton_Click;

            this.Controls.Add(nuevoBoton);
            indicePalabras++;

        }
        private void GenerarTraduccion(Button botonParaOcultar, List<Word> listaPalabras, ref int indiceTraducciones)
        {
            if (indiceTraducciones >= listaPalabras.Count)
            {
                MessageBox.Show("No hay mas palabras");
                return;
            }

            Size sizeBoton = botonParaOcultar.Size;
            Point positionBoton = botonParaOcultar.Location;

            this.Controls.Remove(botonParaOcultar);

            string nuevaPalabra = listaPalabras[indiceTraducciones].translate;
            Button nuevoBoton = new Button
            {
                Location = positionBoton,
                Size = sizeBoton,
                Tag = listaPalabras[indiceTraducciones],
                Text = nuevaPalabra
            };
            nuevoBoton.Click += Boton_Click;

            this.Controls.Add(nuevoBoton);
            indiceTraducciones++;

        }
        private void GenerarBotonesAleatorios()
        {
            List<Point> posicionesPalabras = new List<Point>
            {
                new Point (48,27),
                new Point (48,99),
                new Point (48,178),
                new Point (48,262),
                new Point (48,343),
            };

            List<Point> posicionesTraducciones = new List<Point>
            {
                new Point (294,27),
                new Point (294,99),
                new Point (294,178),
                new Point (294,262),
                new Point (294,343),
            };

            //string nuevaPalabra = listaPalabras[indicePalabras].palabra;
            if (listaPalabras == null || listaPalabras.Count == 0)
            {
                MessageBox.Show("La lista de palabras está vacía o no se ha inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (var palabra in listaPalabras)
            {
                if (posicionesPalabras.Count == 0) break;

                int indice = random.Next(posicionesPalabras.Count);
                Point posicion = posicionesPalabras[indice];
                posicionesPalabras.RemoveAt(indice);

                Button botonPalabra = new Button
                {
                    Text = listaPalabras[indice].palabra,
                    Size = new Size(135,55),
                    Location = posicion
                };
                botonPalabra.Click += Boton_Click;
                this.Controls.Add(botonPalabra);
            }
        }
        private void GenerarBotonesPrueba()
        {
            Button testButton = new Button
            {
                Text = "Prueba",
                Size = new Size(135, 55),
                Location = new Point(50, 50) // Posición fija de prueba
            };
            this.Controls.Add(testButton);
        }
        private void btnWord1_Click(object sender, EventArgs e)
        {

        }

        
    } 
    }

