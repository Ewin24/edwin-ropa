
using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class RopaContext : DbContext
{
    public RopaContext(DbContextOptions options) : base(options)
    {
    }

    protected RopaContext()
    {
    }


    DbSet<Pais> Paises { get; set; }
    DbSet<Cargo> Cargos { get; set; }
    DbSet<Cliente> Clientes { get; set; }
    DbSet<Color> Colores { get; set; }
    DbSet<Departamento> Departamentos { get; set; }
    DbSet<DetalleOrden> DetalleOrdenes { get; set; }
    DbSet<DetalleVenta> DetalleVenta { get; set; }
    DbSet<Empleado> Empleados { get; set; }
    DbSet<Empresa> Empresas { get; set; }
    DbSet<Estado> Estados { get; set; }
    DbSet<FormaPago> FormasPago { get; set; }
    DbSet<Genero> Generos { get; set; }
    DbSet<Insumo> Insumos { get; set; }
    DbSet<InsumoPrenda> InsumoPrendas { get; set; }
    DbSet<InsumoProveedor> InsumoProveedores { get; set; }
    DbSet<Inventario> Inventarios { get; set; }
    DbSet<InventarioTalla> InventarioTallas { get; set; }
    DbSet<Municipio> Municipios { get; set; }
    DbSet<Orden> Ordenes { get; set; }
    DbSet<Prenda> Prendas { get; set; }
    DbSet<Proveedor> Proveedores { get; set; }
    DbSet<Talla> Tallas { get; set; }
    DbSet<TipoEstado> TipoEstados { get; set; }
    DbSet<TipoPersona> TipoPersonas { get; set; }
    DbSet<TipoProteccion> TipoProtecciones { get; set; }
    DbSet<Venta> Ventas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
