using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGestion_Contactos
{
    internal class clsContacto
    {
        public Int32 Codigo { get; set; }
        public String Nombre {  get; set; }
        public String Apellido { get; set;}
        public String Numero { get; set; }
        public String Mail { get; set;}
        public Int32 Categoria { get; set;}
    }
}
