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
    public class GetGerenciamento_LeadByIdQuery : IRequest<Gerenciamento_Lead>
    {
        public Guid Id { get; set; }

        public class GetGerenciamento_LeadByIdQueryHandler : IRequestHandler<GetGerenciamento_LeadByIdQuery, Gerenciamento_Lead>
        {
            private readonly IGerenciamento_LeadRepository _context;
            private readonly IMediator _mediator;

            public GetGerenciamento_LeadByIdQueryHandler(IGerenciamento_LeadRepository context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }
            public async Task<Gerenciamento_Lead> Handle(GetGerenciamento_LeadByIdQuery query, CancellationToken cancellationToken)
            {
                var gerenciamento_Lead = await _context.GetById(query.Id);

                if (gerenciamento_Lead == null) return default;

                return gerenciamento_Lead;
            }
        }
    }
}
