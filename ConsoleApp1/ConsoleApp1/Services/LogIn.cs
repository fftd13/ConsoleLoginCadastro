
namespace ConsoleApp1.Services
{
    class LogIn: ILogIn
    {
        string path = @"C:\Users\felli\Dev\bancodedados.txt";
        string uEmail, uName, uPassword;
        public LogIn()
        {
        }

        public void Cadastrar(string email, string username, string password)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine($"{email}|{username}|{password}");
                }
            }
            catch
            {

            }
        }

        public bool Verificar(string email, string password)
        {
            
            
            using (StreamReader sr = File.OpenText(path))
            {
                while (!(sr.EndOfStream))
                {
                    string[] vect = sr.ReadLine().Split("|");
                    uEmail = vect[0];
                    uName = vect[1];
                    uPassword = vect[2];
                    
                }
                
            }
            if (email.GetHashCode().Equals(uEmail.GetHashCode()) && password.GetHashCode().Equals(uPassword.GetHashCode()))
            {
                return true;

            }
            else
            {
                return false;

            }

        }
    }
}
