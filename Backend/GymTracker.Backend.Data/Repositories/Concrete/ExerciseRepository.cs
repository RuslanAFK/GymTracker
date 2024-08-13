using GymTracker.Backend.Data.DataModels;
using GymTracker.Backend.Data.Repositories.Abstract;

namespace GymTracker.Backend.Data.Repositories.Concrete;

public class ExerciseRepository(TrackerDbContext context) : BaseRepository<Exercise>(context), IExerciseRepository
{
    
}