using GymTracker.Backend.Data.DataModels;
using GymTracker.Backend.Data.DataModels.ComplexTypes;

namespace GymTracker.Backend.Logic.ViewModels.Records;

public class RecordDetailsModel
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public string? Description { get; set; }

    public Guid ExerciseId { get; set; }

    public Weight Weight { get; set; }
    public Weight? AdditionalWeight { get; set; }

    public static RecordDetailsModel CreateFromEntity(Record record)
    {
        return new RecordDetailsModel()
        {
            Id = record.Id,
            AdditionalWeight = record.AdditionalWeight,
            Description = record.Description,
            Weight = record.Weight,
            ExerciseId = record.ExerciseId
        };
    }
}