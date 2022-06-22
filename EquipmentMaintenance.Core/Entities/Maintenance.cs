using EquipmentMaintenance.Core.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentMaintenance.Core.Entities
{
    public class Maintenance : IEntity, ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Cost { get; set; }

        public object Clone() => MemberwiseClone();
    }
}
