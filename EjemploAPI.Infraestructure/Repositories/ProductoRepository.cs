using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referencias
using EjemploAPI.Domain.Entities;
using EjemploAPI.Domain.Repositories;
using EjemploAPI.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EjemploAPI.Infraestructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly AppDBContext _context;
        public ProductoRepository(AppDBContext context)
        {
            _context = context;
        }
        public async Task<Producto> GetProductosAsync()
        {
            return _context.Productos.FirstOrDefault();
        }
        public async Task<Producto> GetProductoByIdAsync(int id)
        {
            return await _context.Productos.FindAsync(id);
        }
        public async Task<Producto> AddProductoAsync(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
            return producto;
        }
        public async Task<Producto> UpdateProductoAsync(Producto producto)
        {
            _context.Entry(producto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return producto;
        }
        public async Task<Producto> DeleteProductoAsync(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return null;
            }
            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
            return producto;
        }
    }
}
