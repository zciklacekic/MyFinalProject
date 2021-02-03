using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Genetic Contraint
    //class: Referans tip olabilir where T:class
    //IEntity olabilir veya IEntity i implemet eden bir class olabilir where T:class:IEntity
    //new() new lenebilir olmalı --Yani Interface in kendisi değil onu implement eden bir class olabilir.--  where T:class,IEntity,new()
    //Boylece T nin newlenemez ve IEntity i implement eden bir class olmasını saglayarak kısıtladık
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
