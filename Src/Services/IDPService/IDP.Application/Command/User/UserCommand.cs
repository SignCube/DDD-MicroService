using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Application.Command.User
{
	public record UserCommand : IRequest<bool>
	{
		public required string FullName { get; set; }
		public required string CodeNumber { get; set; }

		public required string UserName { get; set; }

		public required string Email { get; set; }

		public required string Salt { get; set; }

	}
}
