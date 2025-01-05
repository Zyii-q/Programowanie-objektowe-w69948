namespace BankSystem
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(string login, string password, string firstName, string lastName)
        {
            Login = login;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }

        public void ChangePassword(string newPassword)
        {
            Password = newPassword;
        }

        public bool CheckPassword(string password)
        {
            return Password == password;
        }
    }
}
