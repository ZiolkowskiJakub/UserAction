using System;

namespace UserAction
{
    public class UserActionComplitedEventArgs : EventArgs
    {
        public UserActionResult UserActionResult { get; }

        public UserActionComplitedEventArgs(UserActionResult userActionResult)
        {
            UserActionResult = userActionResult;
        }
    }
}
