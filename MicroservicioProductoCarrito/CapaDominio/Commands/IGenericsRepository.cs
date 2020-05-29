using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDominio.Commands
{
   public interface IGenericsRepository
    {
        void Add<T>(T entity) where T : class; //puedo recibir cualq objeto y hago lo que tengo que hacer

        //List<T> Traer<T>() where T : class;

        T Agregar<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        //IEnumerable<T> GetAll<T>() where T : class;
        //T GetBy<T>(int id) where T : class;
    }
}
