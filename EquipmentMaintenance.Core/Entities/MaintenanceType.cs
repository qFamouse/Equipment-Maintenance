using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentMaintenance.Core.Entities
{
    public class MaintenanceType
    {
        int Id { get; set; }
        int EquipmentId { get; set; }
        int MaintenanceId { get; set; }
        DateTime Date { get; set; }
    }
}
