using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class UpdateGerenciamento_LeadCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
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

        public class UpdateGerenciamento_LeadCommandHandler : IRequestHandler<UpdateGerenciamento_LeadCommand, Guid>
        {
            private readonly IGerenciamento_LeadRepository _context;
            private readonly IMediator _mediator;

            public UpdateGerenciamento_LeadCommandHandler(IGerenciamento_LeadRepository context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<Guid> Handle(UpdateGerenciamento_LeadCommand command, CancellationToken cancellationToken)
            {
                var gerenciamento_Lead = await _context.GetById(command.Id);

                if (gerenciamento_Lead == null) return default;

                gerenciamento_Lead.Contact_First_Name = command.Contact_First_Name;
                gerenciamento_Lead.Contact_Full_Name = command.Contact_Full_Name;
                gerenciamento_Lead.Contact_Email = command.Contact_Email;
                gerenciamento_Lead.Contact_Phone_Number = command.Contact_Phone_Number;
                gerenciamento_Lead.Category = command.Category;
                gerenciamento_Lead.Date_Created = command.Date_Created;
                gerenciamento_Lead.Description = command.Description;
                gerenciamento_Lead.Price = command.Price;
                gerenciamento_Lead.Suburb = command.Suburb;
                gerenciamento_Lead.Accepted = command.Accepted;

                _context.Update(gerenciamento_Lead);

                return gerenciamento_Lead.Id;
            }
        }
    }
}
