using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO
{
    class Automóvil : Transporte
    {
        public override string Avanzar()
        {
            return $"El Automóvil ha arrancado y tiene {Pasajeros} pasajeros.";
        }

        public override string Detenerse()
        {
            return $"El Automóvil se ha detenido y tiene {Pasajeros} pasajeros.";
        }

        public Automóvil(int pasajeros)
        {
            this.Pasajeros = pasajeros;
        }
    }
}