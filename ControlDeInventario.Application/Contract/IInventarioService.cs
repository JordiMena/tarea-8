using ControlDelInventario.Domain.Entities;
using System.Collections.Generic;

namespace ControlDelInventario.Application.Contract
{
    public interface IInventarioService
    {
        IEnumerable<Producto> ListarProductos();
        Producto ObtenerProducto(int id);
        void AgregarProducto(Producto producto);
        void ActualizarProducto(Producto producto);
        void EliminarProducto(int id);
    }
}
