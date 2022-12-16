using CQRS.İEA.CQRS.Results.MemberResults;
using MediatR;
using System.Collections.Generic;

namespace CQRS.İEA.CQRS.Queries.MemberQueries
{
    public class GetAllMemberQuery:IRequest<List<GetAllMemberResult>>
    {
    }
}
