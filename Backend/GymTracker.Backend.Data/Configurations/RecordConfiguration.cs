using GymTracker.Backend.Data.DataModels;
using GymTracker.Backend.Data.DataModels.ComplexTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Newtonsoft.Json;

namespace GymTracker.Backend.Data.Configurations;

public class RecordConfiguration : IEntityTypeConfiguration<Record>
{
    public void Configure(EntityTypeBuilder<Record> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasValueGenerator<GuidValueGenerator>();

        builder.Property(x => x.Description).HasMaxLength(256);

        builder.Property(x => x.Weight).HasConversion(
            x => JsonConvert.SerializeObject(x),
            x => JsonConvert.DeserializeObject<Weight>(x));
        
        builder.Property(x => x.AdditionalWeight).HasConversion(
            x => x == null ? null : JsonConvert.SerializeObject(x),
            x => x == null ? null : JsonConvert.DeserializeObject<Weight>(x));

        builder.HasOne(x => x.Exercise).WithMany().HasForeignKey(x => x.ExerciseId);
    }
}