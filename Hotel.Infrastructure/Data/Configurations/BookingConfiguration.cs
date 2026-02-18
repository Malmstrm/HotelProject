using Hotel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Infrastructure.Data.Configurations;

public class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.GuestId)
            .IsRequired();

        builder.Property(b => b.RoomId)
            .IsRequired();

        builder.Property(b => b.CheckInDate)
            .IsRequired()
            .HasColumnType("datetime2");

        builder.Property(b => b.CheckOutDate)
            .IsRequired()
            .HasColumnType("datetime2");

        builder.Property(b => b.TotalPrice)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(b => b.Status)
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(50);

        builder.Property(b => b.CreatedAt)
            .IsRequired();

        builder.Property(b => b.UpdatedAt)
            .IsRequired(false);
    }
}