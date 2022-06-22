using EquipmentMaintenance.Core.Entities;
using EquipmentMaintenance.Core.Interfaces.Repositories;
using EquipmentMaintenance.Core.Interfaces.Services;
using EquipmentMaintenance.Core.Requests;
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
            
        public void Add(Equipment item)
        {
            equipmentRepository.Add(item);
            equipmentRepository.SaveChanges();
        }

        public void EditById(int id, EquipmentEditRequest request)
        {
            var equipment = equipmentRepository.GetById(id);
            equipment.Name = request.Name;
            equipment.Department = request.Department;

            equipmentRepository.SaveChanges();
        }

        public List<Equipment> Find(Predicate<Equipment> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Equipment> GetAll()
        {
            return equipmentRepository.GetAll();
        }

        public void Remove(Equipment equipment)
        {
            equipmentRepository.Remove(equipment);
            equipmentRepository.SaveChanges();
        }

        public void Update()
        {
            equipmentRepository.SaveChanges();
        }
    }
}
