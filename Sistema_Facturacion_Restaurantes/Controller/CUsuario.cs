﻿using Sistema_Facturacion_Restaurantes.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sistema_Facturacion_Restaurantes.Controller
{
    public class CUsuario
    {
        public static DataTable Validar_acceso(string usuario, string contraseña)
        {
            return new DUsuario().Validar_acceso(usuario, contraseña);
        }
    }
}
