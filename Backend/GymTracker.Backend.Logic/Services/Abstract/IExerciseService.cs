using GymTracker.Backend.Logic.ViewModels.Exercise;

namespace GymTracker.Backend.Logic.Services.Abstract;

public interface IExerciseService
{
    Task CreateExercise(ExerciseCreateModel model);
    Task UpdateExercise(ExerciseUpdateModel model);
    Task ArchiveExercise(Guid id);
    Task<List<ExerciseViewModel>> GetExercises();
}