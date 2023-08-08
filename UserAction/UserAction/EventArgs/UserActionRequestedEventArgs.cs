using System;

namespace UserAction
{
    public class UserActionRequestedEventArgs : EventArgs
    {
        public IUserAction UserAction { get; }

        public UserActionRequestedEventArgs(IUserAction userAction)
        {
            UserAction = userAction;
        }
    }
}