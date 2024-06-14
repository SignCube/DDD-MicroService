﻿using IDP.Application.Command.User;
using IDP.Domain.IRepository.Command;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Application.Handler.Command.User
{
    public class UserHandler : IRequestHandler<UserCommand, bool>
    {
       private IUserRepository _userRepository;
        public UserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> Handle(UserCommand request, CancellationToken cancellationToken)
        {
            var res = _userRepository.Insert(new Domain.Entities.User()
            {
                CodeNumber = request.CodeNumber,
                FullName = request.FullName

            });
            return true;
        }
    }
}
