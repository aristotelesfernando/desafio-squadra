using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entidades;

namespace Domain.Interfaces
{
    public interface IGerenciamento_LeadRepository
    {
        Task<Gerenciamento_Lead> GetById(Guid id);
        Task<Gerenciamento_Lead> GetByEmail(string email);
        Task<Gerenciamento_Lead> GetByFirstName(string firstName);
        Task<IEnumerable<Gerenciamento_Lead>> GetAll();

        void Add(Gerenciamento_Lead gerenciamento_lead);
        void Update(Gerenciamento_Lead gerenciamento_lead);
        void Remove(Gerenciamento_Lead gerenciamento_Lead);
    }
}
