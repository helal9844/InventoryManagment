namespace DAL
{
    public class Store:BaseModel
    {
        public int Id { get; set; }
        public string StoreName { get; set; }
        public string StoreLocation { get; set; }
        public string ContactInformation { get; set; }

        public ICollection<StoreItem> StoreItems { get; set; }

    }
}
