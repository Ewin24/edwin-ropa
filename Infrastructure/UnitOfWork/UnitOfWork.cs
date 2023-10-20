
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Infrastructure.Repository;

namespace Infrastructure.UnityOfWork;

public class UnityOfWork : IUnityOfWork, IDisposable
{
    private readonly RopaContext _context;
    private CargoRepository _Cargos;
    private ClienteRepository _Clientes;
    private ColorRepository _Color;
    private DepartamentoRepository _Departamento;
    private DetalleOrdenRepository _DetalleOrden;
    private DetalleVentaRepository _DetalleVenta;
    private EmpleadoRepository _maestrosvssubmodulos;
    private EmpresaRepository _Empresa;
    private EstadoRepository _Estado;


    public IEstadoRepository Estado
    {
        get
        {
            if (_Estado == null)
            {
                _Estado = new EstadoRepository(_context);
            }
            return _Estado;
        }
    }
    public ICargoRepository Cargos
    {
        get
        {
            if (_Cargos == null)
            {
                _Cargos = new CargoRepository(_context);
            }
            return _Cargos;
        }
    }

    public IClienteRepository Clientes
    {
        get
        {
            if (_Clientes == null)
            {
                _Clientes = new ClienteRepository(_context);
            }
            return _Clientes;
        }
    }

    public IColorRepository Color
    {
        get
        {
            if (_Color == null)
            {
                _Color = new ColorRepository(_context);
            }
            return _Color;
        }
    }

    public IDepartamentoRepository Departamento
    {
        get
        {
            if (_Departamento == null)
            {
                _Departamento = new DepartamentoRepository(_context);
            }
            return _Departamento;
        }
    }

    public IDetalleOrdenRepository DetalleOrden
    {
        get
        {
            if (_DetalleOrden == null)
            {
                _DetalleOrden = new DetalleOrdenRepository(_context);
            }
            return (IDetalleOrdenRepository)_DetalleOrden;
        }
    }

    public IDetalleVentaRepository HiloRespuestasNotificaciones
    {
        get
        {
            if (_DetalleVenta == null)
            {
                _DetalleVenta = new DetalleVentaRepository(_context);
            }
            return (IDetalleVentaRepository)_DetalleVenta;
        }
    }

    public IEmpleadoRepository Empleado
    {
        get
        {
            if (_maestrosvssubmodulos == null)
            {
                _maestrosvssubmodulos = new EmpleadoRepository(_context);
            }
            return (IEmpleadoRepository)_maestrosvssubmodulos;
        }
    }

    public IEmpresaRepository ModulosNotificaciones
    {
        get
        {
            if (_Empresa == null)
            {
                _Empresa = new EmpresaRepository(_context);
            }
            return _Empresa;
        }
    }

    public ICargoRepository Cargo => throw new NotImplementedException();

    public IPaisRepository Pais => throw new NotImplementedException();

    public IInsumoRepository Insumo => throw new NotImplementedException();

    public IInsumoPrendaRepository InsumoPrenda => throw new NotImplementedException();

    public IInventarioRepository Inventario => throw new NotImplementedException();

    public IInventarioTallaRepository InventarioTalla => throw new NotImplementedException();

    public ITallaRepository Talla => throw new NotImplementedException();

    public IDetalleVentaRepository DetalleVenta => throw new NotImplementedException();

    public IPrendaRepository Prenda => throw new NotImplementedException();

    public IProveedorRepository Proveedor => throw new NotImplementedException();

    public IVentaRepository Venta => throw new NotImplementedException();

    public IMunicipioRepository Municipio => throw new NotImplementedException();

    public IEmpresaRepository Empresa => throw new NotImplementedException();

    public ITipoProteccionRepository TipoProteccion => throw new NotImplementedException();

    public IGeneroRepository Genero => throw new NotImplementedException();

    public ITipoEstadoRepository TipoEstado => throw new NotImplementedException();

    public ITipoPersonaRepository TipoPersona => throw new NotImplementedException();

    public IFormaPagoRepository FormaPago => throw new NotImplementedException();

    public IClienteRepository Cliente => throw new NotImplementedException();

    public IOrdenRepository Orden => throw new NotImplementedException();

    public UnityOfWork(RopaContext context)
    {
        _context = context;
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
