using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CommunityPulse.Features.Events
{
    public class CommunityEventsQuery: IRequest<List<CommunityEvent>>
    {
        private readonly Guid _userId;

        public CommunityEventsQuery(Guid userId)
        {
            this._userId = userId;
        }
    }
}
