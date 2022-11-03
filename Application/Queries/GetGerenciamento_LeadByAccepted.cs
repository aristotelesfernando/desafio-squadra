using Domain.Entidades;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class GetGerenciamento_LeadByAccepted : IRequest<IEnumerable<Gerenciamento_Lead>>
    {
        public char Accepted { get; set; }

        public class GetGerenciamento_LeadByAcceptedHandler : IRequestHandler<GetGerenciamento_LeadByAccepted, IEnumerable<Gerenciamento_Lead>>
        {
            private readonly IGerenciamento_LeadRepository _context;
            private readonly IMediator _mediator;

            public GetGerenciamento_LeadByAcceptedHandler(IGerenciamento_LeadRepository context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<IEnumerable<Gerenciamento_Lead>> Handle(GetGerenciamento_LeadByAccepted query, CancellationToken cancellationToken)
            {
                var gerenciamento_Lead_List = await _context.GetAllByAccepted(query.Accepted);

                if (gerenciamento_Lead_List == null) return default;

                return gerenciamento_Lead_List;

            }
        }

    }
}
