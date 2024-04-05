using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_2024.Soporte
{
    internal class TablaNumerosRandom
    {
        public int iteracion { get; }
        public double RND { get; set; }
        public double numero { get; set; }

        public TablaNumerosRandom(int iteracion, double RND, double numero)
        {
            this.iteracion = iteracion;
            this.RND = RND;
            this.numero = numero;
        }


    }
}
