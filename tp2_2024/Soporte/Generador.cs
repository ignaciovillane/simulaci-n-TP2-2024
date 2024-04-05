using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace tp2_2024.Soporte
{
     class Generador
    {
        private static Random random = new Random();//atributo para generar los números random

        //método para truncar
        public double Truncar(double valor, int decimales)
        {
            double factor = Math.Pow(10, decimales);
            return Math.Truncate(valor * factor) / factor;
        }
        // método generar exponencial
        public List<TablaNumerosRandom> generarExponencial(int n, double lambda)
        {
            List<TablaNumerosRandom> rndNumbers = new List<TablaNumerosRandom>();
            for (int i = 0; i < n; i++)
            {
                int iteracion = i;
                double RND = random.NextDouble();
                double numero = (-1/lambda) * Math.Log(1 - RND);
                rndNumbers.Add(new TablaNumerosRandom(iteracion, Truncar(RND,4), Truncar(numero,4)));
            }
            return rndNumbers;
        }

        //metodo generar uniforme

        public List<TablaNumerosRandom> generarUniforme(int n, double a, double b)
        {
            List<TablaNumerosRandom> rndNumbers = new List<TablaNumerosRandom>();
            for (int i = 0; i < n; i++)
            {
                int iteracion = i;
                double RND = random.NextDouble();
                double numero = a + RND * (b - a);
                rndNumbers.Add(new TablaNumerosRandom(iteracion, Truncar(RND,4), Truncar(numero,4)));
            }
            return rndNumbers;
        }


        //Metodo de la tabla de frecuencias

        public List<TablaDeFrecuencias> generarTablaDeFrecuencias(int intervalos, List<TablaNumerosRandom> list)
        {
            List<TablaDeFrecuencias> tablaDeFrecuencias = new List<TablaDeFrecuencias>();
            var filteredList = list.Where(x => !double.IsInfinity(x.numero));//filtro si hay algun infinito o -infinito, si el RND es muy chico al hacer Ln del RND toma el valor infinito
            double minimo = filteredList.Min(x => x.numero);
            double maximo = filteredList.Max(x => x.numero);
            double diferencia = maximo - minimo;

            double ancho = (diferencia / intervalos);

            for (int i = 0; i <=intervalos; i++)
            {
                //cuando i ==0 Desde toma el valor min,cuando i > 0 tomar el valor Hasta 
                double Desde = (i > 0 ? Truncar(tablaDeFrecuencias.Last().Hasta, 4) : minimo);
                double Hasta = Truncar((Desde + ancho) - 0.001, 4);
                double MarcaDeClase = Truncar(((Desde + Hasta) / 2), 4);
                int FrecuenciaObservada = list.Count(x => x.numero >= Desde && x.numero < Hasta);
                tablaDeFrecuencias.Add(new TablaDeFrecuencias(Desde, Hasta, MarcaDeClase, FrecuenciaObservada));

            }
            return tablaDeFrecuencias;
        }

        //método para realizar el gráfico
        public void graficar(Chart grafico, List<TablaDeFrecuencias> tablaDeFrecuencias)
        {
            // Limpia el gráfico antes de añadir nuevos datos
            grafico.Series.Clear();
            grafico.ChartAreas.Clear();
            grafico.ChartAreas.Add(new ChartArea());
            grafico.Titles.Clear();

            // Crea una nueva serie para el histograma
            Series serie = new Series("Histograma");
            serie.ChartType = SeriesChartType.Column;
            grafico.Titles.Add("Histograma de frecuencias");
            grafico.ChartAreas[0].AxisX.Title = "Valores";
            grafico.ChartAreas[0].AxisY.Title = "Frecuencia";

            // Itera sobre los datos de la tabla de frecuencias y agrega barras al histograma
            foreach (TablaDeFrecuencias dato in tablaDeFrecuencias)
            {
                double anchoBarra = dato.Hasta - dato.Desde;
                double centroBarra = dato.Desde + (anchoBarra / 2.0);

                // Agrega punto de datos para la barra
                serie.Points.AddXY(centroBarra, dato.FrecuenciaObservada);

                // Añade los límites de las barras como marcadores de división
                grafico.ChartAreas[0].AxisX.CustomLabels.Add(
                    centroBarra - (anchoBarra / 2.0),
                    centroBarra + (anchoBarra / 2.0),
                    $"{dato.Desde}-{dato.Hasta}");
            }

            // Agrega la serie al gráfico
            grafico.Series.Add(serie);

            // Actualiza el gráfico
            grafico.Update();
        }

    }
}
