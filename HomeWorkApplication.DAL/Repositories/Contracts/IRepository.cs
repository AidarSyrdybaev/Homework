using HomeWorkApplication.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkApplication.DAL.Repositories.Contracts
{
    interface IRepository<T> where T: Entity
    {
        T Create(T entity);


        T GetById(int id);

        IEnumerable<T> GetAll();

        T Update(T entity);

        void Remove(T entity);


    }
}
