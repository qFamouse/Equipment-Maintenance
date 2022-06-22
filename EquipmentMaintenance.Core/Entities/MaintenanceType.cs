using EquipmentMaintenance.Core.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentMaintenance.Core.Entities
{
    public class MaintenanceType : IEntity, ICloneable
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public int MaintenanceId { get; set; }
        public DateTime Date { get; set; }

        public object Clone() => MemberwiseClone();
    }
}
