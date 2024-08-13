using GymTracker.Backend.Data.Repositories.Abstract;
using GymTracker.Backend.Logic.Services.Abstract;
using GymTracker.Backend.Logic.ViewModels.Exercise;
using Microsoft.EntityFrameworkCore;

namespace GymTracker.Backend.Logic.Services.Concrete;

public class ExerciseService(IExerciseRepository exerciseRepository) : IExerciseService
{
    public Task CreateExercise(ExerciseCreateModel model)
    {
        var exercise = model.ToEntity();
        exerciseRepository.Add(exercise);
        return exerciseRepository.SaveChangesAsync();
    }
    
    public async Task UpdateExercise(ExerciseUpdateModel model)
    {
        var exercise = await exerciseRepository.GetByIdAsync(model.Id);
        if (exercise is null || exercise.Archived)
            throw new Exception("Exercise not found");

        exercise.Name = model.Name;
        exercise.Description = model.Description;
        await exerciseRepository.SaveChangesAsync();
    }
    
    public async Task ArchiveExercise(Guid id)
    {
        var exercise = await exerciseRepository.GetByIdAsync(id);
        if (exercise is null || exercise.Archived)
            throw new Exception("Exercise not found");

        exercise.Archived = true;
        await exerciseRepository.SaveChangesAsync();
    }
    
    public async Task<List<ExerciseViewModel>> GetExercises()
    {
        var exercises = await exerciseRepository.GetAll().Where(x => !x.Archived)
            .Select(x => new ExerciseViewModel()
            {
                Description = x.Description, Name = x.Name, Id = x.Id
            })
            .ToListAsync();
        
        return exercises;
    }
}