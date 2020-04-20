
using System.Threading;
using System.Threading.Tasks;
using DRT.Application.Exceptions;
using DRT.Application.Interfaces;
using DRT.Domain.Entities;
using MediatR;

namespace DRT.Application.CQRS.Users.Queries.GetUserDetail
{
    public class GetUserDetailQueryHandler : IRequestHandler<GetUserDetailQuery, UserDetailModel>
    {
        private readonly IFnzDbContext _context;

        public GetUserDetailQueryHandler(IFnzDbContext context)
        {
            _context = context;
        }

        public async Task<UserDetailModel> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Set<User>()
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(User), request.Id);
            }

            return UserDetailModel.Create(entity);
        }
    }
}
