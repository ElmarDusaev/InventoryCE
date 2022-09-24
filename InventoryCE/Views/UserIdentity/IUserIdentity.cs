using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryCE.Views.UserIdentity
{
    public interface IUserIdentity
    {
        string AppVersion { set; }
        event EventHandler<EventArgs> OnEnterClick;
    }
}
