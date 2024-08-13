namespace GymTracker.Backend.Logic.ViewModels.Exercise;

public class ExerciseCreateModel
{
    public string Name { get; set; }
    public string? Description { get; set; }

    public Data.DataModels.Exercise ToEntity()
    {
        return new Data.DataModels.Exercise()
        {
            Description = Description, Name = Name
        };
    }
}