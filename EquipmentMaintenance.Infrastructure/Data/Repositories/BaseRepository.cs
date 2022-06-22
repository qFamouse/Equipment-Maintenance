using EquipmentMaintenance.Core.Interfaces.Entities;
using EquipmentMaintenance.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentMaintenance.Infrastructure.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class, IEntity
    {
        protected EquipmentMaintenanceContext DbContext { get; }
        protected CsvDbSet<T> CurrentDbSet { get; }

        public BaseRepository(EquipmentMaintenanceContext dbContext, CsvDbSet<T> dbSet)
        {
            DbContext = dbContext;
            CurrentDbSet = dbSet;
        }

        public List<T> GetAll()
        {
            return CurrentDbSet.ToList();
        }

        public void Add(T equipment)
        {
            CurrentDbSet.Add(equipment);
        }

        public void SaveChanges() => CurrentDbSet.SaveChanges();

        public async Task SaveChangesAcync() => await CurrentDbSet.SaveChangesAcync();

        public T GetById(int id)
        {
            return CurrentDbSet.ToList().Find(i => i.Id == id);
        }

        public void Remove(T entity)
        {
            CurrentDbSet.Remove(entity);
        }
    }
}
