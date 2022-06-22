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

        public bool Insert(T equipment)
        {
            CurrentDbSet.Add(equipment);

            return true;
        }

        public void SaveChanges() => CurrentDbSet.SaveChanges();

        public async Task SaveChangesAcync() => await CurrentDbSet.SaveChangesAcync();
    }
}
