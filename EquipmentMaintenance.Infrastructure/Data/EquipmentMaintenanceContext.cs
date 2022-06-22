using EquipmentMaintenance.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentMaintenance.Infrastructure.Data
{
    public class EquipmentMaintenanceContext
    {
        public CsvDbSet<Equipment> Equipments { get; set; }
        public CsvDbSet<Maintenance> Maintenances { get; set; }
        public CsvDbSet<MaintenanceType> MaintenanceTypes { get; set; }

        public EquipmentMaintenanceContext()
        {
            Equipments = new CsvDbSet<Equipment>("equipments.csv");
            Maintenances = new CsvDbSet<Maintenance>("maintenances.csv");
            MaintenanceTypes = new CsvDbSet<MaintenanceType>("maintenance_types.csv");
        }
    }
}
