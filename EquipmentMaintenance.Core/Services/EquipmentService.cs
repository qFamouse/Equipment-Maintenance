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
    public class EquipmentService : IEquipmentService
    {
        private readonly IEquipmentRepository equipmentRepository;

        public EquipmentService(IEquipmentRepository equipmentRepository)
        {
            this.equipmentRepository = equipmentRepository;
        }

        public List<Equipment> GetAll()
        {
            return equipmentRepository.GetAll();
        }
    }
}
