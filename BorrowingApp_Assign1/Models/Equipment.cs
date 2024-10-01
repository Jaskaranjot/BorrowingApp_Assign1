namespace BorrowingApp_Assign1.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public EquipmentType Type { get; set; }  // Use the already defined EquipmentType
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
    }
}
