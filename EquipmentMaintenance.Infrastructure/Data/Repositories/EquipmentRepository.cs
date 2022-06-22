using EquipmentMaintenance.Core.Entities;
using EquipmentMaintenance.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentMaintenance.Infrastructure.Data.Repositories
{
    public class EquipmentRepository : BaseRepository<Equipment>, IEquipmentRepository 
    {
        public EquipmentRepository(EquipmentMaintenanceContext context) : base(context, context.Equipments) { }
    }
}
