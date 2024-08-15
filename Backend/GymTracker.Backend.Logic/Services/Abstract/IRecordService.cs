using GymTracker.Backend.Logic.ViewModels.Records;

namespace GymTracker.Backend.Logic.Services.Abstract;

public interface IRecordService
{
    Task CreateRecord(RecordCreateModel model);
    Task UpdateRecord(RecordUpdateModel model);
    Task DeleteRecord(Guid id);
    Task<RecordDetailsModel> GetRecordDetails(Guid id);
}