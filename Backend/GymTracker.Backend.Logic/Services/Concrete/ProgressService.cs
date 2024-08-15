using GymTracker.Backend.Data.Repositories.Abstract;
using GymTracker.Backend.Logic.ExtensionMethods;
using GymTracker.Backend.Logic.Services.Abstract;
using GymTracker.Backend.Logic.ViewModels.Progress;
using Microsoft.EntityFrameworkCore;

namespace GymTracker.Backend.Logic.Services.Concrete;

public class ProgressService(IRecordRepository recordRepository) : IProgressService
{
    public async Task<List<ExerciseProgressResultModel>> GetExerciseProgress(ExerciseProgressModel model)
    {
        var records = await recordRepository.GetAll()
            .Where(x => x.ExerciseId == model.ExerciseId)
            .Select(x => new
            {
                x.Description, x.Date, x.Weight, x.AdditionalWeight, x.Id
            }).ToListAsync();

        var progressModels = records
            .Select(x => new ExerciseProgressResultModel()
            {
                RecordId = x.Id,
                Description = x.Description,
                Date = x.Date,
                WeightConverted = x.Weight.CovertTo(model.Unit) + (x.AdditionalWeight?.CovertTo(model.Unit) ?? 0)
            }).ToList();
        return progressModels;
    }
}