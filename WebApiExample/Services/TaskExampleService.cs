namespace WebApiExample.Services;

public class TaskExampleService : ITaskExampleService
{
    private readonly Dictionary<int, string> _cache = new()
    {
        { 1, "value id 1 from cache" }
    };
    
    #region Примеры с ValueTask
    // Пример Асинхронного метода с использованием ValueTask
    public async Task<string> GetValueWithValueTaskFromCacheAsync(int id)
    {
        //var syncValueTask =  GetValue(id); //Так делать НЕЛЬЗЯ
        var syncValue =  await GetValue(id); // ValueTask ВСЕГДА АВЕЙТИТСЯ, повторный АВЕЙТ не допустим, хранить ValueTask в переменных НЕЛЬЗЯ, передавать параметром НЕЛЬЗЯ
        var valueTaskToTask = GetValue(id).AsTask();// если ValueTask нужно сохранить или передать - преобразуем в Task
       
        Console.WriteLine(await valueTaskToTask); // После преобразования в Task Можно авейтить повторно
        Console.WriteLine(await valueTaskToTask); // После преобразования в Task Можно авейтить повторно
        
        var asyncValue = await GetValueAsync(id);
        return asyncValue;
    }
    
    //Напрямую использовать new ValueTask<T>() можно только в СИНХРОННЫХ методах!
    private ValueTask<string> GetValue(int id)
    {
        if (_cache.TryGetValue(id, out var value))
            return new ValueTask<string>(value);

        return new ValueTask<string>(SlowOperationAsync(id));
    }

    private async Task<string> SlowOperationAsync(int id)
    {
        await Task.Delay(1000);
        return $"value id {id} NOT from cache";
    }

    //Если метод async, то возвращаем значение без ValueTask<T>()
    private async ValueTask<string> GetValueAsync(int id)
    {
        if (_cache.TryGetValue(id, out var value))
            return value;

        await Task.Delay(3000);
        return $"value id {id} NOT from cache";
    }
    #endregion
    
    #region Примеры с Task
    // Пример Асинхронного метода с использованием Task
    public Task<string> GetStringValueWithTaskExampleAsync(int id)
    {
        throw new NotImplementedException();
    }
    #endregion
}