using GymTracker.Backend.Data.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace GymTracker.Backend.Data.Configurations;

public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
{
    public void Configure(EntityTypeBuilder<Exercise> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasValueGenerator<GuidValueGenerator>();
        
        builder.Property(x => x.Description).HasMaxLength(256);
        builder.Property(x => x.Name).HasMaxLength(64);

        builder.HasIndex(x => x.Name).IsUnique();
    }
}