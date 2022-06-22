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
    public class MaintenanceTypeService : IMaintenanceTypeService
    {
        private readonly IMaintenanceTypeRepository maintenanceTypeRepository;

        public MaintenanceTypeService(IMaintenanceTypeRepository maintenanceTypeRepository)
        {
            this.maintenanceTypeRepository = maintenanceTypeRepository;
        }

        public void Add(MaintenanceType item)
        {
            throw new NotImplementedException();
        }

        public List<MaintenanceType> Find(Predicate<MaintenanceType> predicate)
        {
            throw new NotImplementedException();
        }

        public List<MaintenanceType> GetAll()
        {
            throw new NotImplementedException();
        }

        public MaintenanceType GetById()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
