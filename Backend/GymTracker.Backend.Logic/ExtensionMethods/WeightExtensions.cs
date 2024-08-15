using GymTracker.Backend.Data.DataModels.ComplexTypes;
using GymTracker.Backend.Data.Enums;

namespace GymTracker.Backend.Logic.ExtensionMethods;

public static class WeightExtensions
{
    const double PoundsToKilograms = 0.45359237;
    
    public static double CovertTo(this Weight weight, WeightUnit unit)
    {
        if (weight.Unit == unit)
            return weight.Value;

        switch (unit)
        {
            case WeightUnit.Kg:
                return weight.Value * PoundsToKilograms;
            case WeightUnit.Lb:
                return weight.Value / PoundsToKilograms;
            default:
                throw new ArgumentOutOfRangeException(nameof(unit), unit, null);
        }
    }
}