using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DMS_Main
{
    public class DMSContext : DbContext
    {
        public DMSContext()
        {
        }

        public DMSContext(DbContextOptions<DMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EvictionOrder> EvictionOrders { get; set; }
        public virtual DbSet<RatingChangeCategory> RatingChangeCategories { get; set; }
        public virtual DbSet<RatingOperation> RatingOperations { get; set; }
        public virtual DbSet<Resident> Residents { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<SettlementOrder> SettlementOrders { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EvictionOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("eviction_order_pkey");

                entity.ToTable("eviction_order");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ResidentId).HasColumnName("resident_id");

                entity.HasOne(d => d.Resident)
                    .WithMany(p => p.EvictionOrders)
                    .HasForeignKey(d => d.ResidentId)
                    .HasConstraintName("eviction_order_resident_id_fkey");
            });

            modelBuilder.Entity<RatingChangeCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("rating_change_category_pkey");

                entity.ToTable("rating_change_category");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<RatingOperation>(entity =>
            {
                entity.HasKey(e => e.OperationId)
                    .HasName("rating_operations_pkey");

                entity.ToTable("rating_operations");

                entity.Property(e => e.OperationId).HasColumnName("operation_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.ChangeValue).HasColumnName("change_value");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.OrderDate).HasColumnName("order_date");

                entity.Property(e => e.ResidentId).HasColumnName("resident_id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.RatingOperations)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rating_operations_category_id_fkey");

                entity.HasOne(d => d.Resident)
                    .WithMany(p => p.RatingOperations)
                    .HasForeignKey(d => d.ResidentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rating_operations_resident_id_fkey");
            });

            modelBuilder.Entity<Resident>(entity =>
            {
                entity.ToTable("residents");

                entity.Property(e => e.ResidentId).HasColumnName("resident_id");

                entity.Property(e => e.BirthDate).HasColumnName("birth_date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("first_name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("gender");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.PassportInformation)
                    .HasMaxLength(10)
                    .HasColumnName("passport_information");

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(30)
                    .HasColumnName("patronymic");

                entity.Property(e => e.RoomNumber)
                    .HasMaxLength(10)
                    .HasColumnName("room_number");

                entity.Property(e => e.Tin)
                    .HasMaxLength(12)
                    .HasColumnName("tin");

                entity.HasOne(d => d.RoomNumberNavigation)
                    .WithMany(p => p.Residents)
                    .HasForeignKey(d => d.RoomNumber)
                    .HasConstraintName("residents_room_number_fkey");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => e.RoomNumber)
                    .HasName("rooms_pkey");

                entity.ToTable("rooms");

                entity.Property(e => e.RoomNumber)
                    .HasMaxLength(10)
                    .HasColumnName("room_number");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.FloorNumber)
                    .HasMaxLength(1)
                    .HasColumnName("floor_number")
                    .HasComputedColumnSql("\"left\"((room_number)::text, 1)", true);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("gender");
            });

            modelBuilder.Entity<SettlementOrder>(entity =>
            {
                entity.HasKey(e => e.OperationId)
                    .HasName("settlement_order_pkey");

                entity.ToTable("settlement_order");

                entity.Property(e => e.OperationId).HasColumnName("operation_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.OrderDate).HasColumnName("order_date");

                entity.Property(e => e.ResidentId).HasColumnName("resident_id");

                entity.Property(e => e.RoomNumber)
                    .HasMaxLength(10)
                    .HasColumnName("room_number");

                entity.HasOne(d => d.Resident)
                    .WithMany(p => p.SettlementOrders)
                    .HasForeignKey(d => d.ResidentId)
                    .HasConstraintName("settlement_order_resident_id_fkey");

                entity.HasOne(d => d.RoomNumberNavigation)
                    .WithMany(p => p.SettlementOrders)
                    .HasForeignKey(d => d.RoomNumber)
                    .HasConstraintName("settlement_order_room_number_fkey");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.OperationId)
                    .HasName("transactions_pkey");

                entity.ToTable("transactions");

                entity.Property(e => e.OperationId).HasColumnName("operation_id");

                entity.Property(e => e.ResidentId).HasColumnName("resident_id");

                entity.Property(e => e.Sum).HasColumnName("sum");

                entity.HasOne(d => d.Resident)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.ResidentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("transactions_resident_id_fkey");
            });
        }
    }
}
