using HackatonCashBack.Bussines.Notifications;
using System.Collections.Generic;

namespace HackatonCashBack.Bussines.Interfaces
{
    public interface INotificator
    {
        bool AnyNotification();

        List<Notification> GetNotifications();

        void Handle(Notification notification);
    }
}
