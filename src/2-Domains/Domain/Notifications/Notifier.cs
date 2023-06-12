using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Notifications
{
  public class Notifier
  {
    public Notifier()
    {
      Notification = new List<Notifier>();
    }
    [NotMapped]
    public string PropertyName { get; set; }

    [NotMapped]
    public string Messages { get; set; }

    [NotMapped]
    public List<Notifier> Notification;

    public bool PropertyStringValidation(string value, string propertyName)
    {
      if ((string.IsNullOrWhiteSpace(value)) || (string.IsNullOrWhiteSpace(propertyName)))
      {
        Notification.Add(new Notifier
        {
          Messages = "Campo obrigatório",
          PropertyName = propertyName
        });
        return false;
      }
      return true;
    }

    public bool PropertyIntValidation(int value, string propertyName)
    {
      if ((value < 1) || (string.IsNullOrWhiteSpace(propertyName)))
      {
        Notification.Add(new Notifier
        {
          Messages = "Campo obrigatório",
          PropertyName = propertyName
        });
        return false;
      }
      return true;
    }

    public bool PropertyDecimaValidation(decimal value, string propertyName)
    {
      if ((value < 1) || (string.IsNullOrWhiteSpace(propertyName)))
      {
        Notification.Add(new Notifier
        {
          Messages = "Campo obrigatório",
          PropertyName = propertyName
        });
        return false;
      }
      return true;
    }

  }
}