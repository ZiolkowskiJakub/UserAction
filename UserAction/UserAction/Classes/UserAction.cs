namespace UserAction
{
    public abstract class UserAction : IUserAction
    {
        private UserActionResult userActionResult = UserActionResult.Undefined;

        public event UserActionComplitedEventHandler UserActionComplited;

        public UserActionResult UserActionResult
        {
            get
            {
                return userActionResult;
            }

            set
            {
                userActionResult = value;
                UserActionComplited?.Invoke(this, new UserActionComplitedEventArgs(value));
            }
        }
    }
}
