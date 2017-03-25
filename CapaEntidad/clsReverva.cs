using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurante.CapaEntidad {
    public class clsReserva {
        private String Nombre;
        private String Cedula;
        private String TipoReserva;
        private String Fecha;

        //constructor
        public clsReserva() {
        }
        public clsReserva(String Nombre, String Cedula, String TipoReserva, String Fecha) {
            this.Nombre = Nombre;
            this.Cedula = Cedula;
            this.TipoReserva = TipoReserva;
            this.Fecha = Fecha;
        }

        //PROPERTIES
        public string propNombre { get { return this.Nombre; } set { this.Nombre = value; } }
        public string propCedula { get { return this.Cedula; } set { this.Cedula = value; } }
        public string propTipoReserva { get { return this.TipoReserva; } set { this.TipoReserva = value; } }
        public string propFecha { get { return this.Fecha; } set { this.Fecha = value; } }


    }//fin clsReserva
}//fin Restaurante.CapaEntidad