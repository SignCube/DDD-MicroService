using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Application.Command.User
{
    public record UserCommand:IRequest<bool>
    {
        public required string? Name { get; set; }

    }
}
