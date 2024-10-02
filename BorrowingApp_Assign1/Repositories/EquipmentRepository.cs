using System.Collections.Generic;
using BorrowingApp_Assign1.Models;

namespace BorrowingApp_Assign1.Repositories
{
    public static class EquipmentRepository
    {
        private static List<Equipment> equipmentList = new List<Equipment>
        {
            new Equipment { Id = 1, Type = EquipmentType.Laptop, Description = "Dell XPS 13", IsAvailable = true },
            new Equipment { Id = 2, Type = EquipmentType.Phone, Description = "iPhone 12", IsAvailable = false },
            new Equipment { Id = 3, Type = EquipmentType.Tablet, Description = "iPad Pro", IsAvailable = true },
            new Equipment { Id = 4, Type = EquipmentType.Laptop, Description = "MacBook Pro", IsAvailable = true },
            new Equipment { Id = 5, Type = EquipmentType.Laptop, Description = "Lenovo ThinkPad X1 Carbon", IsAvailable = false },
            new Equipment { Id = 6, Type = EquipmentType.Tablet, Description = "Samsung Galaxy Tab S7", IsAvailable = true },
            new Equipment { Id = 7, Type = EquipmentType.Phone, Description = "Samsung Galaxy S21", IsAvailable = true },
            new Equipment { Id = 8, Type = EquipmentType.Laptop, Description = "HP Spectre x360", IsAvailable = false }
        };

        public static List<Equipment> GetAllEquipment()
        {
            return equipmentList;
        }

        public static List<Equipment> GetAvailableEquipment()
        {
            return equipmentList.FindAll(e => e.IsAvailable);
        }
    }
}
