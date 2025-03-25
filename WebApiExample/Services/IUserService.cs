namespace WebApiExample.Services;

public interface IUserService
{
    string GetUserName(int id);
    IEnumerable<string> GetUserNames(IEnumerable<int> ids);
    Task<string> GetUserNameAsync(int id);
    Task<IEnumerable<string>> GetUserNamesAsync(IEnumerable<int> ids);

    Task<string> GetFirstStringFromFileAsync();
}