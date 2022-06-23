using EquipmentMaintenance.Core.Entities;
using EquipmentMaintenance.Core.Interfaces.Repositories;
using EquipmentMaintenance.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentMaintenance.Core.Services
{
    public class MaintenanceService : IMaintenanceService
    {
        private readonly IMaintenanceRepository maintenanceRepository;

        public MaintenanceService(IMaintenanceRepository maintenanceRepository)
        {
            this.maintenanceRepository = maintenanceRepository;
        }

        public void Add(Maintenance item)
        {
            maintenanceRepository.Add(item);
            maintenanceRepository.SaveChanges();
        }

        public List<Maintenance> Find(Predicate<Maintenance> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Maintenance> GetAll()
        {
            return maintenanceRepository.GetAll();
        }

        public void Remove(Maintenance entity)
        {
            maintenanceRepository.Remove(entity);
            maintenanceRepository.SaveChanges();
        }

        public void Update()
        {
            maintenanceRepository.SaveChanges();
        }
    }
}
