using Domain.Entidades;
using Domain.Interfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class Gerenciamento_LeadRepository : IGerenciamento_LeadRepository
    {
        protected readonly AppDbContext db;

        public Gerenciamento_LeadRepository(AppDbContext context)
        {
            db = context;
        }

        public void Add(Gerenciamento_Lead gerenciamento_lead)
        {
            db.Gerenciamento_Leads.Add(gerenciamento_lead);
            db.SaveChanges();
        }

        public async Task<IEnumerable<Gerenciamento_Lead>> GetAll()
        {
            return await db.Gerenciamento_Leads.ToListAsync();
        }

        public async Task<Gerenciamento_Lead> GetByEmail(string email)
        {
            return await db.Gerenciamento_Leads.AsNoTracking().FirstOrDefaultAsync(g => g.Contact_Email == email);
        }   

        public async Task<Gerenciamento_Lead> GetByFirstName(string firstName)
        {
            return await db.Gerenciamento_Leads.AsNoTracking().FirstOrDefaultAsync(g => g.Contact_First_Name == firstName);
        }

        public async Task<Gerenciamento_Lead> GetById(Guid id)
        {
            return await db.Gerenciamento_Leads.AsNoTracking().FirstOrDefaultAsync(g => g.Id == id);
        }

        public void Remove(Gerenciamento_Lead gerenciamento_Lead)
        {
            db.Gerenciamento_Leads.Remove(gerenciamento_Lead);
            db.SaveChanges();
        }

        public void Update(Gerenciamento_Lead gerenciamento_lead)
        {
            db.Gerenciamento_Leads.Update(gerenciamento_lead);
            db.SaveChanges();
        }
    }
}
