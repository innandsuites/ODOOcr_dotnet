﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPosProject.TipoElemento
{
    public class EmisorType
    {
        public string Nombre { get; set; }
        public IdentificacionType Identificacion { get; set; }
        public string NombreComercial { get; set; }
        public UbicacionType Ubicacion { get; set; }
        public TelefonoType Telefono { get; set; }
        public FaxType Fax { get; set; }
        public string CorreoElectronico { get; set; }
        

    }
}