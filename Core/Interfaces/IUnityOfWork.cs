using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnityOfWork
    {
        ICargoRepository Cargo { get; }
        IPaisRepository Pais { get; }
        IInsumoRepository Insumo { get; }
        IInsumoPrendaRepository InsumoPrenda { get; }
        IDepartamentoRepository Departamento { get; }
        IInventarioRepository Inventario { get; }
        IEmpleadoRepository Empleado { get; }
        IInventarioTallaRepository InventarioTalla { get; }
        ITallaRepository Talla { get; }
        IDetalleVentaRepository DetalleVenta { get; }
        IPrendaRepository Prenda { get; }
        IProveedorRepository Proveedor { get; }
        IVentaRepository Venta { get; }
        IMunicipioRepository Municipio { get; }
        IEmpresaRepository Empresa { get; }
        ITipoProteccionRepository TipoProteccion { get; }
        IGeneroRepository Genero { get; }
        IEstadoRepository Estado { get; }
        ITipoEstadoRepository TipoEstado { get; }
        ITipoPersonaRepository TipoPersona { get; }
        IDetalleOrdenRepository DetalleOrden { get; }
        IFormaPagoRepository FormaPago { get; }
        IClienteRepository Cliente { get; }
        IColorRepository Color { get; }
        IOrdenRepository Orden { get; }

        Task<int> SaveAsync();
    }
}