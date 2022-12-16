using CQRS.İEA.CQRS.Commands.MemberCommands;
using CQRS.İEA.DAL.Context;
using CQRS.İEA.DAL.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.İEA.CQRS.Handlers.MemberHandlers
{
    public class CreateMemberCommandHandler : IRequestHandler<CreateMemberCommand>
    {
        private readonly ProductContext _context;

        public CreateMemberCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateMemberCommand request, CancellationToken cancellationToken)
        {
            _context.Members.Add(new Member
            {
                Name = request.Name,
                Surname = request.Surname,
                City = request.City,
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
