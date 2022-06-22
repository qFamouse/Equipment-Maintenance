using EquipmentMaintenance.Core.Entities;
using EquipmentMaintenance.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentMaintenance.Infrastructure.Data.Repositories
{
    public class MaintenanceRepository : BaseRepository<Maintenance>, IMaintenanceRepository
    {
        public MaintenanceRepository(EquipmentMaintenanceContext dbContext) : base(dbContext, dbContext.Maintenances) { }
    }
}
