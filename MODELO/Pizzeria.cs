using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Pizzeria
    {
        private static Pizzeria instancia;

        public static Pizzeria OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new Pizzeria();

            return instancia;
        }
        private Pizzeria()
        {
            Miembros = new List<Miembro>();
        }
        public List<Miembro> Miembros { get; set; }
    }
}
