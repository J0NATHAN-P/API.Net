using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploAPI.Domain.Entities;

namespace EjemploAPI.Domain.Repositories
{
    public interface IProductoRepository
    {
        //Obtener todos los productos
        Task<Producto> GetProductosAsync();
        //Obtener un producto por su id
        Task<Producto> GetProductoByIdAsync(int id);
        //Agregar un nuevo producto
        Task<Producto> AddProductoAsync(Producto producto);
        //Actualizar un producto existente
        Task<Producto> UpdateProductoAsync(Producto producto);
        //Eliminar un producto por su id
        Task<Producto> DeleteProductoAsync(int id);
    }
}
