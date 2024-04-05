using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp2_2024.Soporte;

namespace tp2_2024
{
    public partial class Form1 : Form
    {
        private Generador generador;
        private List<TablaNumerosRandom> listaNro = new List<TablaNumerosRandom>();
        private List<TablaDeFrecuencias> listaFrecuencias = new List<TablaDeFrecuencias>();

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;//inicio el form para que ocupe toda la pantalla
            //al iniciar deshabilito los parámetros de las distribuciones
            numericUpDownCantidad.Enabled = false;
            numericUpDownA.Enabled = false;
            numericUpDownB.Enabled = false;
            numericUpDownMedia.Enabled = false;
            numericUpDownDesviacion.Enabled = false;
            numericUpDownLambda.Enabled = false;
            generador = new Generador();//instancio el generador
        }

        //método que habilita y deshabilita los parámetros según la distribución
        private void cmbDistribucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbDistribucion.SelectedIndex) 
            {
                case 0:
                    numericUpDownCantidad.Enabled = true;
                    numericUpDownLambda.Enabled = true;
                    numericUpDownA.Enabled = false;
                    numericUpDownB.Enabled = false;
                    numericUpDownMedia.Enabled = false;
                    numericUpDownDesviacion.Enabled=false;
                      
                    break;
                case 1:
                    numericUpDownCantidad.Enabled=true;
                    numericUpDownA.Enabled = true;
                    numericUpDownB.Enabled = true;
                    numericUpDownMedia.Enabled = false;
                    numericUpDownDesviacion.Enabled = false;
                    numericUpDownLambda.Enabled = false;

                    break;
                case 2:
                    numericUpDownCantidad.Enabled = true;
                    numericUpDownMedia.Enabled = true;
                    numericUpDownDesviacion.Enabled = true;
                    numericUpDownA.Enabled = false;
                    numericUpDownB.Enabled = false;
                    numericUpDownLambda.Enabled = false;

                    break;  
            }
        }
        
        //método que al clickear el botón inicia la generación de los números
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            generar();
        }

        //método que realiza la generación de los números 
        private void generar()
        {
            switch(cmbDistribucion.Text) 
            {
                case "Exponencial":
                    listaNro.Clear();
                    listaNro = generador.generarExponencial((int)numericUpDownCantidad.Value, (double)numericUpDownLambda.Value);
                    dgvNumerosRandom.DataSource= listaNro;
                    listaFrecuencias.Clear();
                    listaFrecuencias = generador.generarTablaDeFrecuencias(int.Parse(cmbIntervalos.Text), listaNro); 
                    dgvTablaDeFrecuencias.DataSource=listaFrecuencias; 
                    generador.graficar(chart1, listaFrecuencias);
                    break;
                case "Uniforme":
                    if((int)numericUpDownA.Value >= (int)numericUpDownB.Value)
                     {
                        MessageBox.Show("El valor de A debe ser menor al valor de B, ingrese los valores nuevamente");
                        return;
                     }
                    else {
                        listaNro.Clear();
                        listaNro=generador.generarUniforme((int)numericUpDownCantidad.Value,(double)numericUpDownA.Value, (double)numericUpDownB.Value);
                        dgvNumerosRandom.DataSource = listaNro;
                        listaFrecuencias.Clear();
                        listaFrecuencias = generador.generarTablaDeFrecuencias(int.Parse(cmbIntervalos.Text), listaNro); 
                        dgvTablaDeFrecuencias.DataSource = listaFrecuencias;
                        generador.graficar(chart1, listaFrecuencias);

                    }
                    break;

            }
        }
    }
}
