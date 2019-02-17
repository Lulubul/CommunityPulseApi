using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CommunityPulse.Features.Events
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunityEventsController: ControllerBase
    {
        private readonly IMediator _mediator;

        public CommunityEventsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<List<CommunityEvent>> GetCommunityEvents(Guid userId)
        {
            var response = await _mediator.Send(new CommunityEventsQuery(userId));
            return response;
        }
    }
}