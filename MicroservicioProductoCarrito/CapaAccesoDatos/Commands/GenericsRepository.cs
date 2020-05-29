using CapaDominio.Commands;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CapaAccesoDatos.Commands
{
   public class GenericsRepository : IGenericsRepository
    {
        private readonly ClassContexto _contexto;
        public GenericsRepository(ClassContexto DbContext)
        {
            _contexto = DbContext;
        }
        public void Add<T>(T entity) where T : class
        {
            _contexto.Add(entity); //guardar el tipo de entidad que me esta llegando y paso la pelota 
            _contexto.SaveChanges();
        }

        //public List<T> Traer<T>() where T : class
        //{
        //    DbSet<T> table = null;
        //    table = _contexto.Set<T>();
        //    List<T> lista = table.ToList();
        //    return lista;
        //}

        T IGenericsRepository.Agregar<T>(T entity)
        {
            _contexto.Add(entity);
            _contexto.SaveChanges();
            return entity;
        }


        public void Update<T>(T entity) where T : class
        {
            _contexto.Set<T>().Update(entity);
            _contexto.SaveChanges();
        }
        public void Delete<T>(T entity) where T : class
        {
            _contexto.Set<T>().Remove(entity);
            _contexto.SaveChanges();
        }
        //public IEnumerable<T> GetAll<T>() where T : class
        //{
        //    DbSet<T> table = null;
        //    table = _contexto.Set<T>();
        //    return table.ToList();
        //}
        //public T GetBy<T>(int id) where T : class { }

    }

}
