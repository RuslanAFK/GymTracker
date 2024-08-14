using GymTracker.Backend.Data.Repositories.Abstract;
using GymTracker.Backend.Logic.ViewModels.Records;

namespace GymTracker.Backend.Logic.Services.Concrete;

public class RecordService(IRecordRepository recordRepository)
{
    public Task CreateRecord(RecordCreateModel model)
    {
        var record = model.ToEntity();
        record.Date = DateTime.UtcNow;
        
        recordRepository.Add(record);
        return recordRepository.SaveChangesAsync();
    }
    
    public async Task UpdateRecord(RecordUpdateModel model)
    {
        var record = await recordRepository.GetByIdAsync(model.Id);
        if (record is null)
            throw new Exception("Record not found");

        record.Description = model.Description;
        record.Weight = model.Weight;
        record.AdditionalWeight = model.AdditionalWeight;
        await recordRepository.SaveChangesAsync();
    }
    
    public async Task DeleteRecord(Guid id)
    {
        var record = await recordRepository.GetByIdAsync(id);
        if (record is null)
            throw new Exception("Record not found");
        
        recordRepository.Remove(record);
        await recordRepository.SaveChangesAsync();
    }
}