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
        private readonly IMaintenanceRepository maintenanceRepository;
        private readonly IEquipmentRepository equipmentRepository;

        public MaintenanceTypeService
            (
            IMaintenanceTypeRepository maintenanceTypeRepository,
            IMaintenanceRepository maintenanceRepository,
            IEquipmentRepository equipmentRepository
            )
        {
            this.maintenanceTypeRepository = maintenanceTypeRepository;
            this.maintenanceRepository = maintenanceRepository;
            this.equipmentRepository = equipmentRepository;
        }

        public void Add(MaintenanceType item)
        {
            if (maintenanceRepository.GetById(item.MaintenanceId) != null &&
                equipmentRepository.GetById(item.EquipmentId) != null)
            {
                maintenanceTypeRepository.Add(item);
            }
            else
            {
                item.MaintenanceId = maintenanceRepository.GetAll()[0].Id;
                item.EquipmentId = equipmentRepository.GetAll()[0].Id;
                maintenanceTypeRepository.Add(item);
            }

            maintenanceTypeRepository.SaveChanges();
        }

        public List<MaintenanceType> Find(Predicate<MaintenanceType> predicate)
        {
            throw new NotImplementedException();
        }

        public List<MaintenanceType> GetAll()
        {
            return maintenanceTypeRepository.GetAll();
        }

        public void Remove(MaintenanceType entity)
        {
            maintenanceTypeRepository.Remove(entity);
            maintenanceTypeRepository.SaveChanges();
        }

        public void Update()
        {
            maintenanceTypeRepository.SaveChanges();
        }
    }
}
