using GymTracker.Backend.Data.Enums;

namespace GymTracker.Backend.Data.DataModels;

public class Weight
{
    public long Value { get; set; }
    public WeightUnit Unit { get; set; }
    public bool IsDoubled { get; set; }
}