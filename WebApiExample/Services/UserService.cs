namespace WebApiExample.Services;

public class UserService : IUserService
{
    public string GetUserName(int id)
    {
        return "User id: " + id + " name: ";
    }

    public IEnumerable<string> GetUserNames(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetUserNameAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<string>> GetUserNamesAsync(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public async Task<string> GetFirstStringFromFileAsync()
    {
        await using var fileStream = File.OpenRead("Files\\File.txt");
        using var reader = new StreamReader(fileStream);
        return await reader.ReadLineAsync() ?? string.Empty;
    }
}