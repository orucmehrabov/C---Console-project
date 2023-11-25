
public class UserRegistration
{
    private readonly IUserRepository _userRepository;

    public UserRegistration(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public void RegisterUser(User user)
    {
        _userRepository.AddUser(user);
    }
}
