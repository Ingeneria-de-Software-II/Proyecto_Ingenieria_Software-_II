using Sistema_Facturacion_Restaurantes.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sistema_Facturacion_Restaurantes.Controller
{
    public class CEmpleado
    {
        DEmpleado de;
        public CEmpleado()
        {
            
        }

        public CEmpleado(DEmpleado de)
        {
            this.de = de;
        }
        public static string Insertar(string Cedula, string Nombres, string Apellidos, string Cargo, string Telefono, string Direccion, int SucursalID)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.cedula = Cedula;
            Obj.nombres = Nombres;
            Obj.apellidos = Apellidos;
            Obj.cargo = Cargo;
            Obj.telefono = Telefono;
            Obj.direccion = Direccion;
            Obj.sucursalID = SucursalID;
            return Obj.Insertar(Obj);
        }

        public virtual string InsertarE(DEmpleado empleadoM)
        {
            return empleadoM.Insertar(empleadoM);
        }

        public static DataTable MostrarEmpleadoPorSucursal(int SucursalID)
        {
            return new DEmpleado().MostrarEmpleadoPorSucursal(SucursalID);
        }

        public static DataTable showallEmploye()
        {
            return new DEmpleado().showAllEmploye();
        }

        public static string Actualizar(int EmpleadoID, string Cedula, string Nombres, string Apellidos, string Cargo, string Telefono, string Direccion, int SucursalID)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.empleadoID = EmpleadoID;
            Obj.cedula = Cedula;
            Obj.nombres = Nombres;
            Obj.apellidos = Apellidos;
            Obj.cargo = Cargo;
            Obj.telefono = Telefono;
            Obj.direccion = Direccion;
            Obj.sucursalID = SucursalID;
            return Obj.Actualizar(Obj);
        }

        public static string Eliminar(int EmpleadoID)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.empleadoID = EmpleadoID;
            return Obj.Eliminar(Obj);
        }
    }
}
