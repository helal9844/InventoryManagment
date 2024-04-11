namespace DAL
{
    public class BaseModel
    {
        
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
