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
    internal class MaintenanceService : IMaintenanceService
    {
        private readonly IMaintenanceService maintenanceService;

        public MaintenanceService(IMaintenanceService maintenanceService)
        {
            this.maintenanceService = maintenanceService;
        }

        public void Add(Maintenance item)
        {
            throw new NotImplementedException();
        }

        public List<Maintenance> Find(Predicate<Maintenance> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Maintenance> GetAll()
        {
            throw new NotImplementedException();
        }

        public Maintenance GetById()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
