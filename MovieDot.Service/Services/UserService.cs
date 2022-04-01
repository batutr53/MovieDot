using AutoMapper;
using MovieDot.Core.DTOs.DtoUser;
using MovieDot.Core.Models;
using MovieDot.Core.Repositories;
using MovieDot.Core.Services;
using MovieDot.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Service.Services
{
    public class UserService : Service<User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork, IGenericRepository<User> repository, IMapper mapper, IUserRepository userRepository) : base(unitOfWork, repository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public User Authenticate(string mail, string password)
        {
            var user = _userRepository.Authenticate(mail, password);
            return user;
        }

        public bool IsUniqueUser(string mail)
        {
           return _userRepository.IsUniqueUser(mail);
        }

        public User Register(string userName,string mail, string password)
        {
            var user = _userRepository.Register(userName,mail,password);
            _unitOfWork.Commit();
            return user;
        }
    }
}
