using GymTracker.Backend.Logic.ViewModels.Progress;

namespace GymTracker.Backend.Logic.Services.Abstract;

public interface IProgressService
{
    Task<List<ExerciseProgressResultModel>> GetExerciseProgress(ExerciseProgressModel model);
}