using Hotel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Infrastructure.Data.Configurations;

public class GuestConfiguration : IEntityTypeConfiguration<Guest>
{
    public void Configure(EntityTypeBuilder<Guest> builder)
    {
        builder.HasKey(g => g.Id);

        builder.Property(g => g.FirstName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(g => g.LastName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(g => g.Email)
            .IsRequired()
            .HasMaxLength(255);

        builder.HasIndex(g => g.Email)
            .IsUnique();

        builder.Property(g => g.PhoneNumber)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(g => g.CreatedAt)
            .IsRequired();

        builder.Property(g => g.UpdatedAt)
            .IsRequired(false);

        // One-to-Many: Guest -> Bookings
        builder.HasMany(g => g.Bookings)
            .WithOne(b => b.Guest)
            .HasForeignKey(b => b.GuestId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}