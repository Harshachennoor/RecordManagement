namespace RecordsManagement.Models
{
    public class Filters
    {
        public Filters(string filterString)
        {
            FilterString = filterString ?? "all-all-all";
            string[] filters = FilterString.Split("-");
            CategoryId = filters[0];
            WarehouseId = filters[1];
        }

        public string CategoryId { get; }

        public string WarehouseId { get; }

        public string FilterString { get; }

        public bool HasCategory => CategoryId.ToLower() != "all";

        public bool HasWarehouse => WarehouseId.ToLower() != "all";

    }
}