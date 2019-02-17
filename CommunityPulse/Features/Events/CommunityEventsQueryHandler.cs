using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace CommunityPulse.Features.Events
{
    public class CommunityEventsQueryHandler: IRequestHandler<CommunityEventsQuery, List<CommunityEvent>>
    {
        public Task<List<CommunityEvent>> Handle(CommunityEventsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
