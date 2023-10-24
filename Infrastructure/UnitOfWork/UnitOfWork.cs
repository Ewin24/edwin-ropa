
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Infrastructure.Repository;

namespace Infrastructure.UnityOfWork;

public class UnityOfWork : IUnityOfWork, IDisposable
{
    private readonly RopaContext _context;
    private CargoRepository _Cargo;
    private ClienteRepository _Cliente;
    private ColorRepository _Color;
    private DepartamentoRepository _Departamento;
    private DetalleOrdenRepository _DetalleOrden;
    private DetalleVentaRepository _DetalleVenta;
    private EmpleadoRepository _maestrosvssubmodulos;
    private EmpresaRepository _Empresa;
    private EmpleadoRepository _Empelado;
    private EstadoRepository _Estado;
    private FormaPagoRepository _FormaPago;
    private GeneroRepository _Genero;
    private InsumoRepository _Insumo;
    private InsumoPrendaRepository _InsumoPrenda;
    private InventarioRepository _Inventario;
    private InventarioTallaRepository _InventarioTalla;
    private TipoPersonaRepository _TipoPersona;
    private TipoProteccionRepository _TipoProteccion;
    private MunicipioRepository _Municipio;
    private OrdenRepository _Orden;
    private PaisRepository _Pais;
    private PrendaRepository _Prenda;
    private ProveedorRepository _Proveedor;
    private TallaRepository _Talla;
    private TipoEstadoRepository _TipoEstado;


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
            if (_Cargo == null)
            {
                _Cargo = new CargoRepository(_context);
            }
            return _Cargo;
        }
    }

    public IClienteRepository Clientes
    {
        get
        {
            if (_Cliente == null)
            {
                _Cliente = new ClienteRepository(_context);
            }
            return _Cliente;
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

    public ICargoRepository Cargo
    {
        get
        {
            if (_Cargo == null)
            {
                _Cargo = new EstadoRepository(_context);
            }
            return _Cargo;
        }
    }

    public IPaisRepository Pais
    {
        get
        {
            if (_Pais == null)
            {
                _Pais = new EstadoRepository(_context);
            }
            return _Pais;
        }
    }

    public IInsumoRepository Insumo
    {
        get
        {
            if (_Insumo == null)
            {
                _Insumo = new InsumoRepository(_context);
            }
            return _Insumo;
        }
    }

    public IInsumoPrendaRepository InsumoPrenda
    {
        get
        {
            if (_InsumoPrenda == null)
            {
                _InsumoPrenda = new InsumoPrendaRepository(_context);
            }
            return _InsumoPrenda;
        }
    }

    public IInventarioRepository Inventario
    {
        get
        {
            if (_Inventario == null)
            {
                _Inventario = new InventarioRepository(_context);
            }
            return _Inventario;
        }
    }

    public IInventarioTallaRepository InventarioTalla
    {
        get
        {
            if (_InventarioTalla == null)
            {
                _InventarioTalla = new InventarioRepository(_context);
            }
            return _InventarioTalla;
        }
    }

    public ITallaRepository Talla
    {
        get
        {
            if (_Talla == null)
            {
                _Talla = new TallaRepository(_context);
            }
            return _Talla;
        }
    }

    public IDetalleVentaRepository DetalleVenta
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

    public IPrendaRepository Prenda
    {
        get
        {
            if (_Prenda == null)
            {
                _Prenda = new PrendaRepository(_context);
            }
            return _Prenda;
        }
    }

    public IProveedorRepository Proveedor
    {
        get
        {
            if (_Proveedor == null)
            {
                _Proveedor = new ProveedorRepository(_context);
            }
            return _Proveedor;
        }
    }

    public IMunicipioRepository Municipio
    {
        get
        {
            if (_Municipio == null)
            {
                _Municipio = new MunicipioRepository(_context);
            }
            return _Municipio;
        }
    }

    public IEmpresaRepository Empresa
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

    public ITipoProteccionRepository TipoProteccion
    {
        get
        {
            if (_TipoProteccion == null)
            {
                _TipoProteccion = new TipoProteccionRepository(_context);
            }
            return _TipoProteccion;
        }
    }

    public IGeneroRepository Genero
    {
        get
        {
            if (_Genero == null)
            {
                _Genero = new GeneroRepository(_context);
            }
            return _Genero;
        }
    }

    public ITipoEstadoRepository TipoEstado
    {
        get
        {
            if (_TipoEstado == null)
            {
                _TipoEstado = new TipoEstadoRepository(_context);
            }
            return _TipoEstado;
        }
    }

    public ITipoPersonaRepository TipoPersona
    {
        get
        {
            if (_TipoPersona == null)
            {
                _TipoPersona = new TipoPersonaRepository(_context);
            }
            return _TipoPersona;
        }
    }

    public IFormaPagoRepository FormaPago
    {
        get
        {
            if (_FormaPago == null)
            {
                _FormaPago = new FormaPagoRepository(_context);
            }
            return _FormaPago;
        }
    }

    public IClienteRepository Cliente
    {
        get
        {
            if (_Cliente == null)
            {
                _Cliente = new ClienteRepository(_context);
            }
            return _Cliente;
        }
    }

    public IOrdenRepository Orden
    {
        get
        {
            if (_Orden == null)
            {
                _Orden = new OrdenRepository(_context);
            }
            return _Orden;
        }
    }

    public IVentaRepository Venta => throw new NotImplementedException();

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
