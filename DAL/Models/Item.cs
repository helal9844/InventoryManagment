namespace DAL
{
    public class Item:BaseModel 
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string Catagory { get; set; }

        public ICollection<StoreItem> StoreItems { get; set; }
    }
}
