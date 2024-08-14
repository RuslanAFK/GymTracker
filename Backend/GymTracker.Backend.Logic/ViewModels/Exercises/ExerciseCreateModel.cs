using GymTracker.Backend.Data.DataModels;

namespace GymTracker.Backend.Logic.ViewModels.Exercises;

public class ExerciseCreateModel
{
    public string Name { get; set; }
    public string? Description { get; set; }

    public Exercise ToEntity()
    {
        return new Exercise()
        {
            Description = Description, Name = Name
        };
    }
}