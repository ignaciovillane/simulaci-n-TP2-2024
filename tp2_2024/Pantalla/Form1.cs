using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp2_2024.Soporte;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics.Eventing.Reader;

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
            btnGenerarExcel.Visible = false;//oculto el botón para generar el excel al iniciar el programa
            cargarCombox(cmbDistribucion, cmbIntervalos);//cargo los combobox al iniciar el programa
           
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

            validar(cmbDistribucion);//realiza las validaciones y genera la simulación
        }
        //cargo con datos los combobox
        public void cargarCombox(ComboBox distribuciones,ComboBox intervalos)
        {
            string[] vectorDistribuciones = new string[] { "Exponencial", "Uniforme", "Normal"};
            int[] vectorIntervalos = new int[] { 5, 10, 15 };
            cmbDistribucion.DataSource = vectorDistribuciones;
            cmbIntervalos.DataSource = vectorIntervalos;
            // Establece el estilo del ComboBox para que no permita la edición directa de texto
            cmbDistribucion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIntervalos.DropDownStyle = ComboBoxStyle.DropDownList;
            // Configura el ComboBox para iniciar en blanco
            cmbDistribucion.SelectedIndex = -1;
            cmbIntervalos.SelectedIndex = -1;
        }
        //método que realiza la generación de los números 
        private void generar()
        {
            switch(cmbDistribucion.Text) 
            {
                case "Exponencial":
       
                        listaNro.Clear();
                        listaNro = generador.generarExponencial((int)numericUpDownCantidad.Value, (double)numericUpDownLambda.Value);
                        dgvNumerosRandom.DataSource = listaNro;
                        listaFrecuencias.Clear();
                        listaFrecuencias = generador.generarTablaDeFrecuencias(int.Parse(cmbIntervalos.Text), listaNro);
                        dgvTablaDeFrecuencias.DataSource = listaFrecuencias;
                        generador.graficar(chart1, listaFrecuencias);
                        btnGenerarExcel.Visible = true;//habilito el botón para generar el excel de la tabla de frecuencias
                    
                    break;
                case "Uniforme":
                
                        listaNro.Clear();
                        listaNro=generador.generarUniforme((int)numericUpDownCantidad.Value,(double)numericUpDownA.Value, (double)numericUpDownB.Value);
                        dgvNumerosRandom.DataSource = listaNro;
                        listaFrecuencias.Clear();
                        listaFrecuencias = generador.generarTablaDeFrecuencias(int.Parse(cmbIntervalos.Text), listaNro); 
                        dgvTablaDeFrecuencias.DataSource = listaFrecuencias;
                        generador.graficar(chart1, listaFrecuencias);
                        btnGenerarExcel.Visible = true;//habilito el botón para generar el excel de la tabla de frecuencias

                    
                    break;
                case "Normal":
                    listaNro.Clear();
                    listaNro=generador.generarNormal((int)numericUpDownCantidad.Value,(double)numericUpDownMedia.Value,(double)numericUpDownDesviacion.Value);
                    dgvNumerosRandom.DataSource= listaNro;
                    listaFrecuencias.Clear();
                    listaFrecuencias = generador.generarTablaDeFrecuencias(int.Parse(cmbIntervalos.Text), listaNro);
                    dgvTablaDeFrecuencias.DataSource = listaFrecuencias;
                    generador.graficar(chart1, listaFrecuencias);
                    btnGenerarExcel.Visible = true;//habilito el botón para generar el excel de la tabla de frecuencias
                    break;
            }
            
        }
        public void validar(ComboBox cmb)
        {
            switch(cmb.Text) 
            {
                case "Exponencial":
                    if ((int)numericUpDownCantidad.Value <= 0)
                    {
                        MessageBox.Show("El tamaño de la simulación debe ser mayor a cero");

                    }
                    else if ((double)numericUpDownLambda.Value <= 0)
                    {
                        MessageBox.Show("El lambda debe ser mayor a cero");
                    }
                    else
                    {
                        generar();
       
                    }
                    break;
                case "Uniforme":
                    if ((int)numericUpDownCantidad.Value <= 0)
                    {
                        MessageBox.Show("El tamaño de la simulación debe ser mayor a cero");

                    }
                    else
                   if ((int)numericUpDownA.Value >= (int)numericUpDownB.Value)
                    {
                        MessageBox.Show("El valor de A debe ser menor al valor de B, ingrese los valores nuevamente");

                    }
                    else { generar(); };
                    break;
                case "Normal":
                    if ((int)numericUpDownCantidad.Value <= 0)
                    {
                        MessageBox.Show("El tamaño de la simulación debe ser mayor a cero");

                    }
                    else if((double)numericUpDownDesviacion.Value <= 0)
                    {
                        MessageBox.Show("El valor de la desviación debe ser mayor a cero");
                    }
                    else
                    {
                        generar();
                    }
                    break;
            }

        }
        
        private void btnGenerarExcel_Click(object sender, EventArgs e)
        {
            generarExcel(dgvTablaDeFrecuencias);
        }
       
        //método para generar el excel
         private void generarExcel(DataGridView dataGridView)
         {
             // Crear una instancia de Excel y crear un nuevo libro
             Excel.Application excelApp = new Excel.Application();
             Excel.Workbook workbook = excelApp.Workbooks.Add();
             Excel.Worksheet worksheet = workbook.ActiveSheet;

             try
             {
                 // Encabezados
                 for (int i = 1; i <= dataGridView.Columns.Count; i++)
                 {
                     worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                 }

                 // Datos
                 for (int i = 0; i < dataGridView.Rows.Count; i++)
                 {
                     for (int j = 0; j < dataGridView.Columns.Count; j++)
                     {
                         worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                     }
                 }

                 // Guardar el archivo
                 SaveFileDialog saveFileDialog = new SaveFileDialog();
                 saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                 saveFileDialog.Title = "Guardar como";
                 saveFileDialog.FileName = "datos";
                 if (saveFileDialog.ShowDialog() == DialogResult.OK)
                 {
                     workbook.SaveAs(saveFileDialog.FileName);
                     MessageBox.Show("Excel creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al exportar a Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             finally
             {
                 // Cerrar Excel
                 excelApp.Quit();
                 ReleaseObject(worksheet);
                 ReleaseObject(workbook);
                 ReleaseObject(excelApp);
             }
         }
 
         private void ReleaseObject(object obj)
         {
             try
             {
                 System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                 obj = null;
             }
             catch (Exception ex)
             {
                 obj = null;
                 MessageBox.Show("Error al liberar el objeto: " + ex.ToString());
             }
             finally
             {
                 GC.Collect();
             }
         }
    }
}