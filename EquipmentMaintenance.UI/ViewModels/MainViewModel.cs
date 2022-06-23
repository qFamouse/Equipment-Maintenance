using EquipmentMaintenance.Core.Entities;
using EquipmentMaintenance.Core.Interfaces.Services;
using EquipmentMaintenance.Core.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentMaintenance.UI.ViewModels
{

    public class MainViewModel
    {
        IEquipmentService equipmentService;
        IMaintenanceService maintenanceService;
        IMaintenanceTypeService maintenanceTypeService;
        public ObservableCollection<Equipment> Equipments { get; set; }
        public ObservableCollection<Maintenance> Maintenances { get; set; }
        public ObservableCollection<MaintenanceType> MaintenanceTypes { get; set; }

        public MainViewModel
            (
            IEquipmentService equipmentService,
            IMaintenanceService maintenanceService,
            IMaintenanceTypeService maintenanceTypeService
            )
        {
            this.equipmentService = equipmentService;
            this.maintenanceService = maintenanceService;
            this.maintenanceTypeService = maintenanceTypeService;

            Equipments = new ObservableCollection<Equipment>(equipmentService.GetAll());
            Maintenances = new ObservableCollection<Maintenance>(maintenanceService.GetAll());
            MaintenanceTypes = new ObservableCollection<MaintenanceType>(maintenanceTypeService.GetAll());

            Equipments.CollectionChanged += Equipments_CollectionChanged;
            Maintenances.CollectionChanged += Maintenances_CollectionChanged;
            MaintenanceTypes.CollectionChanged += MaintenanceTypes_CollectionChanged;
        }

        private void MaintenanceTypes_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    if (e.NewItems?[0] is MaintenanceType newEntity)
                    {
                        maintenanceTypeService.Add(newEntity);
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    if (e.OldItems?[0] is MaintenanceType oldEntity)
                    {
                        maintenanceTypeService.Remove(oldEntity);
                    }
                    break;
            }
        }

        private void Maintenances_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    if (e.NewItems?[0] is Maintenance newEntity)
                    {
                        maintenanceService.Add(newEntity);
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    if (e.OldItems?[0] is Maintenance oldEntity)
                    {
                        maintenanceService.Remove(oldEntity);
                    }
                    break;
            }
        }

        private void Equipments_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    if (e.NewItems?[0] is Equipment newEntity)
                    {
                        equipmentService.Add(newEntity);
                    } 
                    break;
                case NotifyCollectionChangedAction.Remove:
                    if (e.OldItems?[0] is Equipment oldEntity)
                    {
                        equipmentService.Remove(oldEntity);
                    }
                    break;
            }
        }

        public void Update()
        {
            equipmentService.Update();
        }
    }
}
