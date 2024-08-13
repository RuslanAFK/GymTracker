using GymTracker.Backend.Data.DataModels;
using GymTracker.Backend.Data.Repositories.Abstract;

namespace GymTracker.Backend.Data.Repositories.Concrete;

public class RecordRepository(TrackerDbContext context) : BaseRepository<Record>(context), IRecordRepository
{
    
}