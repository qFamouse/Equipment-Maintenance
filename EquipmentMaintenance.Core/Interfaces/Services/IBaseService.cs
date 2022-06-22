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
        T GetById();
        void Add(T item);
        void Remove(int id);
        List<T> Find(Predicate<T> predicate);
    }
}
