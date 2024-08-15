using GymTracker.Backend.Data.Enums;

namespace GymTracker.Backend.Logic.ViewModels.Progress;

public class ExerciseProgressModel
{
    public Guid ExerciseId { get; set; }
    public WeightUnit Unit { get; set; }
}