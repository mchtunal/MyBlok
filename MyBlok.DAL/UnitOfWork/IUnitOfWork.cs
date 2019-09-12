using Microsoft.EntityFrameworkCore;
using MyBlok.DAL.Repositories;
using MyBlok.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlok.DAL.UnitOfWork
{
     public interface IUnitOfWork<TContext> : IDisposable where TContext :DbContext
    {
        TContext DbContext { get; }
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity;
        int SaveChanges();
    }
}
