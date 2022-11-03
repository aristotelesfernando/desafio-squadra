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
    public class GetAllGerenciamento_LeadQuery : IRequest<IEnumerable<Gerenciamento_Lead>>
    {
        public class GetAllGerenciamento_LeadQueryHandler : IRequestHandler<GetAllGerenciamento_LeadQuery, IEnumerable<Gerenciamento_Lead>>
        {
            private readonly IGerenciamento_LeadRepository _context;
            private readonly IMediator _mediator;

            public GetAllGerenciamento_LeadQueryHandler(IGerenciamento_LeadRepository context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<IEnumerable<Gerenciamento_Lead>> Handle(GetAllGerenciamento_LeadQuery query, CancellationToken cancellationToken)
            {
                var gerenciamento_Lead_List = await _context.GetAll();

                if (gerenciamento_Lead_List == null) return default;

                return gerenciamento_Lead_List;
            }
        }
    }
}
