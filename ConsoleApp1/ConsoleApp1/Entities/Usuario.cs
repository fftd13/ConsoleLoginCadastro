using ConsoleApp1.Services;
namespace ConsoleApp1.Entities
{
    class Usuario
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime Moment { get; set; }

        private LogIn _login;

        public Usuario()
        {
        }

        public Usuario(string email, string userName, string password, DateTime moment)
        {
            Email = email;
            UserName = userName;
            Password = password;
            Moment = moment;
        }



    }
}
