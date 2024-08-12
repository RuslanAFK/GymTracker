﻿namespace GymTracker.Backend.Data.DataModels;

public class Record
{
    public Guid Id { get; set; }
    public DateTime DateTime { get; set; }
    public string Description { get; set; }

    public Guid ExerciseId { get; set; }
    public Exercise Exercise { get; set; }

    public Weight Weight { get; set; }
    public Weight AdditionalWeight { get; set; }
}