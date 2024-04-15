using CommunityToolkit.Mvvm.Messaging.Messages;
using EnterpriseDirectory.Models;

namespace EnterpriseDirectory.Messages;

public class ModifyEmployeeMessage : ValueChangedMessage<EmployeeDto>
{
    public ModifyEmployeeMessage(EmployeeDto message): base(message) { }
}
