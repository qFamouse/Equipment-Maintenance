using EquipmentMaintenance.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentMaintenance.Core.Interfaces.Services
{
    public interface IBaseService<T>
    {
        List<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
        List<T> Find(Predicate<T> predicate);
        void Update();
    }
}
