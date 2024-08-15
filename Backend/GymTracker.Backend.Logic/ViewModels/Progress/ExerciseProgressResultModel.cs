namespace GymTracker.Backend.Logic.ViewModels.Progress;

public class ExerciseProgressResultModel
{
    public Guid RecordId { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }
    public double WeightConverted { get; set; }
}