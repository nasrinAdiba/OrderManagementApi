using Microsoft.EntityFrameworkCore;
using OrderManagementApi.Model;

namespace OrderManagementApi.Model
{

}




namespace rderManagementApi.Model
{
    public partial class DbOrderManagementContext : DbContext
    {

        public DbOrderManagementContext(DbContextOptions<DbOrderManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OrderInfo> OrderInfos { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderInfo>(entity =>
            {
                entity.ToTable("OrderInfo");

                entity.Property(e => e.Id)
                .HasColumnName("id");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(250)
                    .HasColumnName("itemName");

                entity.Property(e => e.UnitPrice)
                    .HasMaxLength(250)
                    .HasColumnName("unitPrice");

                entity.Property(e => e.Quantity)
                    .HasMaxLength(200)
                    .HasColumnName("quantity");

                entity.Property(e => e.Discount)
                    .HasMaxLength(200)
                    .HasColumnName("discount");

                entity.Property(e => e.OrderInvoiceNo)
                    .HasMaxLength(200)
                    .HasColumnName("orderInvoiceNo");

                entity.Property(e => e.OrderDateTime)
                    .HasMaxLength(200)
                    .HasColumnName("orderDateTime");

                entity.Property(e => e.TotalPrice)
                    .HasMaxLength(250)
                    .HasColumnName("totalPrice");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(200)
                    .HasColumnName("customerName");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(200)
                    .HasColumnName("customerAddress");

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(200)
                    .HasColumnName("shippingAddress");

                entity.Property(e => e.ShippingDate)
                    .HasMaxLength(200)
                    .HasColumnName("shippingDate");

            });




            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
