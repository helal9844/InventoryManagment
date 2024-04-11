using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<StoreItem> StoreItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Store>().HasKey(s => s.Id);
            var stores = new List<Store>();
            for (int i = 1; i <= 5; i++)
            {
                stores.Add(new Store
                {
                    Id = i,
                    StoreName = $"Store {i}",
                    StoreLocation = $"Location {i}",
                    ContactInformation = $"Contact Info {i}",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    DeletedDate = DateTime.Now,
                    IsDeleted = false
                });
            }
            modelBuilder.Entity<Store>().HasData(stores);

            modelBuilder.Entity<Item>().HasKey(i => i.Id);
            var items = new List<Item>();
            for (int i = 1; i <= 10; i++)
            {
                items.Add(new Item
                {
                    Id = i,
                    ItemName = $"Item {i}",
                    Description = $"Description {i}",
                    Catagory = $"Category {i}",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    DeletedDate = DateTime.Now,
                    IsDeleted = false
                });
            }
            modelBuilder.Entity<Item>().HasData(items);

            modelBuilder.Entity<StoreItem>().HasKey(si => new {si.StoreId,si.ItemId});
            modelBuilder.Entity<StoreItem>().HasOne<Store>(si => si.Store).WithMany(s => s.StoreItems);
            modelBuilder.Entity<StoreItem>().HasOne<Item>(si => si.Item).WithMany(i => i.StoreItems);
            var storeItems = new List<StoreItem>();
            foreach (var store in stores)
            {
                foreach (var item in items)
                {
                    storeItems.Add(new StoreItem
                    {
                        StoreId = store.Id,
                        ItemId = item.Id,
                        Quantity = new Random().Next(1, 100),
                        Price = Math.Round((decimal)new Random().NextDouble() * 100, 2),
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                        DeletedDate = DateTime.Now,
                        IsDeleted = false
                    });
                }
            }
            modelBuilder.Entity<StoreItem>().HasData(storeItems);

            base.OnModelCreating(modelBuilder);
        }
    }
}
