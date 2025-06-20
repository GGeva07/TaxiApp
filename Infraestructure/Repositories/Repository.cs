using Domain.Interfaces;
using Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public AppDbContext context;

        public Repository(AppDbContext context)
        {
            this.context = context;
        }

            public async Task AddAsync(T entity)
            {
                try
                {
                    await context.Set<T>().AddAsync(entity);
                }
                catch (Exception ex)
                {

                    throw new Exception($"Error al agregar la entidad: {ex.Message}", ex);
                }
            }

            public void Delete(T entity)
            {
                try
                {
                    context.Set<T>().Remove(entity);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al eliminar la entidad: {ex.Message}", ex);
                }
            }

            public async Task<IEnumerable<T>> GetAllAsync()
            {
                try
                {
                    return await Task.FromResult(context.Set<T>().ToList());
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al obtener todas las entidades: {ex.Message}", ex);
                }
            }

            public async Task<T> GetByIdAsync(int id)
            {
                try
                {
                    return await context.Set<T>().FindAsync(id);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al obtener la entidad por ID: {ex.Message}", ex);
                }
            }

            public async Task SaveChangesAsync()
            {
                try
                {
                    await context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al guardar los cambios: {ex.Message}", ex);
                }
            }

            public void Update(T entity)
            {
                try
                {
                    context.Set<T>().Update(entity);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al actualizar la entidad: {ex.Message}", ex);
                }
            }
    }
}
