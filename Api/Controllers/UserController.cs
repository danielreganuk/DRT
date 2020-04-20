using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DRT.Application.CQRS.Users.Queries.GetUserDetail;
using DRT.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("GetUser/{id}")]

        public async Task<UserDetailModel> GetUser([FromRoute] int id, CancellationToken ct)
        {
            return await _mediator.Send(new GetUserDetailQuery(id), ct);
        }
    }
}