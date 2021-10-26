using Ph.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ph.Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
    }
}
