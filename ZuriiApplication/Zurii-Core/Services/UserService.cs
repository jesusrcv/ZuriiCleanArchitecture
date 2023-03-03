using Zurii_Core.Interfaces;

namespace Zurii_Core.Services;

public class UserService : IUserService
{
    public IUnitOfWork _unitOfWork;

    public UserService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
}