using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private Random random = new Random();
        int indicePalabras = 0;
        int indiceTraducciones = 0;
        Button botonPalabra = new Button();
        Button botonTranslate = new Button();
        public Form1()
        {
            InitializeComponent();

            //timer = new Timer();
            //timer.Interval = 400;
            //timer.Tick += Timer_Tick;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            

            listaPalabras = datos.listar();
            btnContador.Text = listaPalabras.Count().ToString();
            try
            {
                GenerarBotonesAleatorios(listaPalabras, out botonPalabra);
                GenerarTraduccion(listaPalabras, out botonTranslate);
                
                
                if (botonSeleccionado2 != null) { CompararBotones(botonPalabra, botonTranslate); }
                



            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            //GenerarBotonesPrueba();
            ////////////////////////////////// MOSTRAR LAS PALABRAS
            //btnWord1.Text = listaPalabras.First().palabra.ToString();
            //btnTranslate1.Text = listaPalabras.First().translate.ToString();
            //btnWord2.Text = listaPalabras.ElementAt(1).palabra.ToString();
            //btnTranslate2.Text = listaPalabras.ElementAt(1).translate.ToString();
            //btnWord3.Text = listaPalabras.ElementAt(2).palabra.ToString();
            //btnTranslate3.Text = listaPalabras.ElementAt(2).translate.ToString();
            //btnWord4.Text = listaPalabras.ElementAt(3).palabra.ToString();
            //btnTranslate4.Text = listaPalabras.ElementAt(3).translate.ToString();
            //btnWord5.Text = listaPalabras.ElementAt(4).palabra.ToString();
            //btnTranslate5.Text = listaPalabras.ElementAt(4).translate.ToString();

            ////////////////////////////// EVENTO DE CLICKS

            //btnWord1.Click += Boton_Click;
            //btnWord2.Click += Boton_Click;
            //btnWord3.Click += Boton_Click;
            //btnWord4.Click += Boton_Click;
            //btnWord5.Click += Boton_Click;

            //btnTranslate1.Click += Boton_Click;
            //btnTranslate2.Click += Boton_Click;
            //btnTranslate3.Click += Boton_Click;
            //btnTranslate4.Click += Boton_Click;
            //btnTranslate5.Click += Boton_Click;

            
        }
        private void CompararBotones(Button botonPalabra, Button botonTraduccion)
        {
            

            if(botonPalabra.Name == botonTraduccion.Name)
            {
                botonPalabra.BackColor = Color.Green;
                botonTraduccion.BackColor = Color.Green;
                return;
            }
 
            else
            {
                MessageBox.Show("No ");
                return;
            }
            
        }
        private void Boton_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            if(boton != null) {
                Debug.WriteLine($"Se hizo clic en el botón: {boton.Name}");
                Debug.WriteLine($"Texto del botón clicado: {boton.Text}");
                if (botonSeleccionado1 == null)
                {
                    botonSeleccionado1 = boton;
                    boton.BackColor = Color.LightBlue;
                }
                else if(botonSeleccionado2 == null)
                {
                    botonSeleccionado2 = boton;
                    boton.BackColor = Color.LightBlue;

                    CompararBotones(botonSeleccionado1, botonSeleccionado2);
                    botonSeleccionado1 = null;
                    botonSeleccionado2 = null;
                }
            }
            
            
        }
        private void Timer_Tick(object sender,EventArgs e)
        {

            
            if(botonParaOcultar1 != null)
            {
                
                try
                {
                    //GenerarPalabra(botonParaOcultar1,listaPalabras,ref indicePalabras);
                    
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
                    //GenerarTraduccion(botonParaOcultar2, listaPalabras, ref indiceTraducciones);
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
        
        public void GenerarTraduccion(List<Word> translates, out Button botonTranslate)
        {
            botonTranslate = null;
            translates = datos.listar();
            
            List<Point> posicionesTranslates = new List<Point>
            {
                new Point (294,27),
                new Point (294,99),
                new Point (294,178),
                new Point (294,262),
                new Point (294,343),
            };

            if (translates == null || translates.Count == 0) {
                MessageBox.Show("La lista de traducciones está vacía o no se ha inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            List<int> indicesUsados = new List<int>();

            foreach(var posicion in posicionesTranslates)
            {
                if (posicionesTranslates.Count == 0) break;
                int indice;
                do
                {
                    indice= random.Next(translates.Count);

                } while (indicesUsados.Contains(indice));
                indicesUsados.Add(indice);
                
                

                 botonTranslate = new Button
                {
                    Text = translates[indice].translate,
                    Size = new Size(135, 55),
                    Location = posicion,
                    Name = translates[indice].Id.ToString()

                 };
                botonTranslate.Click += Boton_Click;
                

                this.Controls.Add(botonTranslate);
            }
        }
        public void GenerarBotonesAleatorios(List<Word> palabras, out Button botonPalabra)
        {
            botonPalabra = null;
            palabras = datos.listar();
            
            List<Point> posicionesPalabras = new List<Point>
            {
                new Point (48,27),
                new Point (48,99),
                new Point (48,178),
                new Point (48,262),
                new Point (48,343),
            };

            //string nuevaPalabra = listaPalabras[indicePalabras].palabra;
            if (palabras == null || palabras.Count == 0)
            {
                
                return;
            }
            List<int> indicesUsados = new List<int>();

            foreach (var posicion in posicionesPalabras)
            {
                if (posicionesPalabras.Count == 0) break;

                int indice;
                do
                {
                    indice = random.Next(palabras.Count);
                } while (indicesUsados.Contains(indice));
                indicesUsados.Add(indice);



                botonPalabra = new Button
                {
                    Text = palabras[indice].palabra,
                    Size = new Size(135, 55),
                    Location = posicion,
                    Name = palabras[indice].Id.ToString(),
                    
                };
                
                botonPalabra.Click += Boton_Click;
                Debug.WriteLine($"Se asignó evento a botón con texto: {botonPalabra.Text} y nombre: {botonPalabra.Name}");

                this.Controls.Add(botonPalabra);
            }
        }
        
        private void btnWord1_Click(object sender, EventArgs e)
        {

        }

        
    } 
    }

