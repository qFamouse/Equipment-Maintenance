using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentMaintenance.Core.Interfaces.Repositories
{
    public interface IBaseRepository<T>
    {
        List<T> GetAll();
        bool Insert(T entity);
    }
}
