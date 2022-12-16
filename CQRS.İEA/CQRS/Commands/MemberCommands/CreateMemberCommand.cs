using MediatR;

namespace CQRS.İEA.CQRS.Commands.MemberCommands
{
    public class CreateMemberCommand:IRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }
}
