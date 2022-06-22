﻿using EquipmentMaintenance.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentMaintenance.Core.Interfaces.Services
{
    public interface IEquipmentService
    {
        List<Equipment> GetAll();
    }
}