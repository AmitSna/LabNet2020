using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO
{
    class Avión : Transporte
    {
        public override string Avanzar()
        {
            return $"El Avión ha arrancado y tiene {Pasajeros} pasajeros.";
        }

        public override string Detenerse()
        {
            return $"El Avión se ha detenido y tiene {Pasajeros} pasajeros.";
        }
        public Avión(int pasajeros)
        {
            this.Pasajeros = pasajeros;
        }
    }
}