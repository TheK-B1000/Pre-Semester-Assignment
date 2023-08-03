namespace Volunteer_Management_System.Services
{
    public interface IAccountService
    {
        bool ValidateCredentials(string username, string password);
    }
}
