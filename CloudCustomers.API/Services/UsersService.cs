using System.Net;
using CloudCustomers.API.Config;
using CloudCustomers.API.Models;
using Microsoft.Extensions.Options;

namespace CloudCustomers.API.Services;

public interface IUsersService
{
    Task<List<User>> GetAllUsers();
}

public class UsersService : IUsersService
{
    private readonly UsersApiOptions _apiConfig;
    private readonly HttpClient _httpClient;

    public UsersService(HttpClient httpClient,
        IOptions<UsersApiOptions> apiConfig)
    {
        _httpClient = httpClient;
        _apiConfig = apiConfig.Value;
    }

    public async Task<List<User>> GetAllUsers()
    {
        var usersResponse = await _httpClient.GetAsync(_apiConfig.Endpoint);
        if (usersResponse.StatusCode == HttpStatusCode.NotFound) return new List<User>();

        var responseContent = usersResponse.Content;
        var allUsers = await responseContent.ReadFromJsonAsync<List<User>>();
        return allUsers.ToList();
    }
}