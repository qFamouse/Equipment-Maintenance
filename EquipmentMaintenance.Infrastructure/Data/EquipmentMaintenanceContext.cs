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

        public EquipmentMaintenanceContext(string equipmentsPath, string maintenancesPath, string MaintenanceTypesPath)
        {
            Equipments = new CsvDbSet<Equipment>(equipmentsPath);
            Maintenances = new CsvDbSet<Maintenance>(maintenancesPath);
            MaintenanceTypes = new CsvDbSet<MaintenanceType>(MaintenanceTypesPath);
        }
    }
}
