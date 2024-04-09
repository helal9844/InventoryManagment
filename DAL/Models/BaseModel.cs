namespace DAL
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; } = DateTime.Now;
        public bool? IsDeleted { get; set; }
    }
}
