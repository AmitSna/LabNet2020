using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO
{
    public abstract class Transporte
    {
        public int Pasajeros;
        public abstract string Avanzar();
        public abstract string Detenerse();
    }
}