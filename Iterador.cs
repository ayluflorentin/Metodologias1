using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public interface Iterador
    {
        bool fin();             // ¿Ya terminó de recorrer?
        Comparable actual();    // Devuelve el elemento actual
        void siguiente();       // Avanza al siguiente
    }
}
