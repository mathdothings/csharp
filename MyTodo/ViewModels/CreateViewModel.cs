using Flunt.Notifications;
using Flunt.Validations;
using MyTodo.Models;

namespace MyTodo.ViewModels;

public class CreateTodoViewModel : Notifiable<Notification>
{
  public string Title { get; set; }

  public Todo MapTo()
  {

    var contract = new Contract<Notification>()
      .Requires()
      .IsNotNull(Title, "Set task's title")
      .IsGreaterThan(Title, 5, "The title need's to be greather than 5 letters!");

    AddNotifications(contract);

    return new Todo(Guid.NewGuid(), Title, false);
  }
}