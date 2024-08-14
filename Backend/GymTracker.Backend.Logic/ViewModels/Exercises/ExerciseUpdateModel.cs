namespace GymTracker.Backend.Logic.ViewModels.Exercises;

public class ExerciseUpdateModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}