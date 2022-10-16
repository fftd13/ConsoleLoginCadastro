using ConsoleApp1.Services;
using ConsoleApp1.Entities;

Console.Write("Logar ou cadastrar( l/ c)");
char logoucad = char.Parse(Console.ReadLine().ToLower());
LogIn login = new LogIn();
if (logoucad == 'l')
{
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Senha: ");
    string senha = Console.ReadLine();

    if (login.Verificar(email, senha))
    {
        Usuario usuario = new Usuario();

        Console.WriteLine("Bem-vindo");
    }
    else
    {
        Console.WriteLine("Email ou senha incorretos");
    }
}
else
{
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Username: ");
    string username = Console.ReadLine();
    Console.Write("Senha: ");
    string senha = Console.ReadLine();


    login.Cadastrar(email, username, senha);
}
