namespace Infrastructure.Interfaces
{
    public interface IAuthenticationService
    {
        Task<Authentication> RegisterAsync(Registering registering);
        Task<Authentication> SignUpAsync(SigningUp signingUp);
        Task<string> AddToRoleAsync(AddRole role);
    }
}
