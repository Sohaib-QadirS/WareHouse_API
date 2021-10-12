namespace WareHouse_API.Models
{
    public class WarehouseItem
    {   /*At this stage the model only uses strings to keep it simple otherwise currency can be decimal*/
        public string TotalBins { get; set; } = "37608";
        public string TotalVarities { get; set; } = "4";
        public string TotalStaff { get; set; } = "157";
        public string TotalWorkingHours { get; set; } = "5887090";
        public string AverageRate { get; set; } = "23.50";
        public string TotalLaborCost { get; set; } = "7829309";
    }
}
