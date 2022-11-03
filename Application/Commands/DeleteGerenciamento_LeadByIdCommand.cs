using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class DeleteGerenciamento_LeadByIdCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }

        public class DeleteGerenciamento_LeadByIdCommandHandler : IRequestHandler<DeleteGerenciamento_LeadByIdCommand, Guid>
        {
            private readonly IGerenciamento_LeadRepository _context;
            private readonly IMediator _mediator;

            public DeleteGerenciamento_LeadByIdCommandHandler(IGerenciamento_LeadRepository context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<Guid> Handle(DeleteGerenciamento_LeadByIdCommand command, CancellationToken cancellationToken)
            {
                var gerenciamento_Lead = await _context.GetById(command.Id);

                if (gerenciamento_Lead == null) return default;

                _context.Remove(gerenciamento_Lead);

                return gerenciamento_Lead.Id;

            }
        }
    }
}
