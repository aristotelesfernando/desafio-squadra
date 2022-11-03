using MediatR;

namespace API.Services.Notifications
{
    public class Gerenciamento_LeadActionNotification : INotification
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
        public ActionNotification Action { get; set; }
    }
}
