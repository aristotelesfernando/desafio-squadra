using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class UpdateGerenciamento_LeadAcceptedCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public char Accepted { get; set; }

        public class UpdateGerenciamento_LeadCommandHandler : IRequestHandler<UpdateGerenciamento_LeadAcceptedCommand, Guid>
        {
            private readonly IGerenciamento_LeadRepository _context;
            private readonly IMediator _mediator;

            public UpdateGerenciamento_LeadCommandHandler(IGerenciamento_LeadRepository context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<Guid> Handle(UpdateGerenciamento_LeadAcceptedCommand command, CancellationToken cancellationToken)
            {
                var gerenciamento_Lead = await _context.GetById(command.Id);

                if (gerenciamento_Lead == null) return default;

                gerenciamento_Lead.Accepted = command.Accepted;
                
                if(command.Price > 500)
                {
                    gerenciamento_Lead.Price = command.Price * (decimal)0.9;
                } else
                {
                    gerenciamento_Lead.Price = command.Price;
                }

                _context.Update(gerenciamento_Lead);

                return gerenciamento_Lead.Id;
            }
        }
    }
}
