using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Municipio : BaseEntity
    {
        public string Nombre;
        public int IdDep;
        public Departamento Departamento;
        public ICollection<Empleado> Empleados;
        public ICollection<Empresa> Empresas;
        public ICollection<Cliente> Clientes;
    }
}