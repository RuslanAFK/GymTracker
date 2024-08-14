using GymTracker.Backend.Data.DataModels;
using GymTracker.Backend.Data.DataModels.ComplexTypes;

namespace GymTracker.Backend.Logic.ViewModels.Records;

public class RecordCreateModel
{
    public string? Description { get; set; }

    public Guid ExerciseId { get; set; }

    public Weight Weight { get; set; }
    public Weight? AdditionalWeight { get; set; }

    public Record ToEntity()
    {
        return new Record()
        {
            AdditionalWeight = AdditionalWeight,
            Weight = Weight,
            Description = Description,
            ExerciseId = ExerciseId
        };
    }
}