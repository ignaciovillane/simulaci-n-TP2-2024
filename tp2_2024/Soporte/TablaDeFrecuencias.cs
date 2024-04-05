using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_2024.Soporte
{
     class TablaDeFrecuencias
    {
        public double Desde { get; set; }
        public double Hasta { get; set; }
        public double MarcaDeClase { get; set; }
        public int FrecuenciaObservada { get; set; }

        public TablaDeFrecuencias(double Desde, double Hasta, double MarcaDeClase, int FrecuenciaObservada)
        {
            this.Desde = Desde;
            this.Hasta = Hasta;
            this.MarcaDeClase = MarcaDeClase;
            this.FrecuenciaObservada = FrecuenciaObservada;

        }
    }
}

