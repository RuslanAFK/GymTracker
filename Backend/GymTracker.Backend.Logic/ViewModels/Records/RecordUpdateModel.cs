using GymTracker.Backend.Data.DataModels.ComplexTypes;

namespace GymTracker.Backend.Logic.ViewModels.Records;

public class RecordUpdateModel
{
    public Guid Id { get; set; }
    public string? Description { get; set; }
    
    public Weight Weight { get; set; }
    public Weight? AdditionalWeight { get; set; }
}