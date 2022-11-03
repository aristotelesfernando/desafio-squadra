using API.Services.Notifications;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace API.Services.Events
{
    public class LogEventHandler : INotificationHandler<Gerenciamento_LeadActionNotification>, INotificationHandler<ErrorNotification>
    {
        private readonly ILogger _logger;

        public LogEventHandler(ILogger logger)
        {
            _logger = logger;
        }

        public Task Handle(Gerenciamento_LeadActionNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                _logger.LogInformation($"Lead {notification.Id} - {notification.Contact_Full_Name} foi {notification.Action.ToString().ToLower()} com sucesso");
            });
        }

        public Task Handle(ErrorNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                _logger.LogInformation($"ERROR : '{notification.Error} \n {notification.Stack}'");
            });
        }
    }
}
