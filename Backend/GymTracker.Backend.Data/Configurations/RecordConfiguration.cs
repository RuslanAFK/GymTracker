using GymTracker.Backend.Data.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace GymTracker.Backend.Data.Configurations;

public class RecordConfiguration : IEntityTypeConfiguration<Record>
{
    public void Configure(EntityTypeBuilder<Record> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasValueGenerator<GuidValueGenerator>();

        builder.ComplexProperty(x => x.Weight);
        builder.ComplexProperty(x => x.AdditionalWeight);

        builder.HasOne(x => x.Exercise).WithMany().HasForeignKey(x => x.ExerciseId);
    }
}