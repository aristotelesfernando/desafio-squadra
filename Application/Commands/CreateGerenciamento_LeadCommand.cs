using Domain.Entidades;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class CreateGerenciamento_LeadCommand: IRequest<Guid>
    {
        public string Contact_First_Name { get; set; }
        public string Contact_Full_Name { get; set; }
        public string Contact_Phone_Number { get; set; }
        public string Contact_Email { get; set; }
        public DateTime Date_Created { get; set; }
        public string Suburb { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public char Accepted { get; set; }

        public class CreateGerenciamento_LeadCommandHandler : IRequestHandler<CreateGerenciamento_LeadCommand, Guid>
        {
            private readonly IGerenciamento_LeadRepository _context;
            private readonly IMediator _mediator;

            public CreateGerenciamento_LeadCommandHandler(IGerenciamento_LeadRepository context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<Guid> Handle(CreateGerenciamento_LeadCommand command, CancellationToken cancellationToken)
            {
                var g_Lead = new Gerenciamento_Lead()
                {
                    Contact_First_Name = command.Contact_First_Name,
                    Contact_Full_Name = command.Contact_Full_Name,
                    Contact_Email = command.Contact_Email,
                    Contact_Phone_Number = command.Contact_Phone_Number,
                    Category = command.Category,
                    Date_Created = command.Date_Created,
                    Description = command.Description,
                    Price = command.Price,
                    Suburb = command.Suburb,
                    Accepted = command.Accepted
                };

                _context.Add(g_Lead);
                return g_Lead.Id;

            }
        }
    }
}
