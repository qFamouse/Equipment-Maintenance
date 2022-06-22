using EquipmentMaintenance.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentMaintenance.UI.ViewModels
{
    public class MainViewModel
    {
        IEquipmentService equipmentService;


        public string Text { get; set; }

        public MainViewModel(IEquipmentService equipmentService)
        {
            this.equipmentService = equipmentService;
        }


    }
}
