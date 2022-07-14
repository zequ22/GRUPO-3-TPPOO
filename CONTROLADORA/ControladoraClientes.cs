using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class ControladoraClientes
    {
        private static ControladoraClientes _instancia;

        private ControladoraClientes() { }

        public static ControladoraClientes obtener_instancia()
        {
            if(_instancia == null)
            {
                _instancia = new ControladoraClientes();
            }
            return _instancia;
        }

        public List<MODELO.Cliente> Listar_Clientes()
        {
            return MODELO.SingletonContexto.obtener_intancia().Contexto.Clientes.ToList();
        }

        public void Agregar_Cliente(MODELO.Cliente cliente)
        {
            MODELO.SingletonContexto.obtener_intancia().Contexto.Clientes.Add(cliente);
            MODELO.SingletonContexto.obtener_intancia().Contexto.SaveChanges();
        }

        public void Eliminar_Cliente(MODELO.Cliente cliente)
        {
            MODELO.SingletonContexto.obtener_intancia().Contexto.Clientes.Remove(cliente);
            MODELO.SingletonContexto.obtener_intancia().Contexto.SaveChanges();
        }

        public MODELO.Cliente Obtener_Cliente(int CODIGO)
        {
            return MODELO.SingletonContexto.obtener_intancia().Contexto.Clientes.Find(CODIGO)
        }
    }
}
