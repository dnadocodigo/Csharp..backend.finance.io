using Domain.Notifications;

namespace Domain.Entities
{
    public class Base : Notifier
    {

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
