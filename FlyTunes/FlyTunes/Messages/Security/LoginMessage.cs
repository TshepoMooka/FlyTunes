using Prism.Events;
using FlyTunes.Model.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyTunes.Messages.Security
{
    public class LoginMessage : PubSubEvent<UserProfile>
    {
    }
}
