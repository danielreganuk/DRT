using MediatR;

namespace DRT.Application.CQRS.Users.Queries.GetUserDetail
{
    public class GetUserDetailQuery : IRequest<UserDetailModel>
    {
        public int Id { get; set; }

        public GetUserDetailQuery(int id)
        {
            Id = id;
        }
    }
}