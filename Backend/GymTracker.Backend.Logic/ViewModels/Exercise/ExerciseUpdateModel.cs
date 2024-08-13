namespace GymTracker.Backend.Logic.ViewModels.Exercise;

public class ExerciseUpdateModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}