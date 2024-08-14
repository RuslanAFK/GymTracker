﻿using System.ComponentModel.DataAnnotations.Schema;
using GymTracker.Backend.Data.Enums;

namespace GymTracker.Backend.Data.DataModels.ComplexTypes;

public struct Weight
{
    public long Value { get; set; }
    public WeightUnit Unit { get; set; }
    public bool IsDoubled { get; set; }
}