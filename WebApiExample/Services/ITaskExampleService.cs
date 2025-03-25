namespace WebApiExample.Services;

public interface ITaskExampleService
{
    Task<string> GetValueWithValueTaskFromCacheAsync(int id);
    
    Task<string> GetStringValueWithTaskExampleAsync(int id);
    
}