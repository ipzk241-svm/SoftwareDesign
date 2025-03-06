using Singleton.classes;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Тест 1: Один потік");
Authenticator auth1 = Authenticator.GetInstance();
Authenticator auth2 = Authenticator.GetInstance();
Console.WriteLine($"auth1 == auth2: {ReferenceEquals(auth1, auth2)}"); 
auth1.Authenticate("Олександр");

Console.WriteLine("\nТест 2: Кілька потоків");
Parallel.Invoke(
	() => TestAuthenticator("Марія"),
	() => TestAuthenticator("Іван"),
	() => TestAuthenticator("Олена")
);

Console.WriteLine("\nТест 3: Повторний запит");
Authenticator auth3 = Authenticator.GetInstance();
Console.WriteLine($"auth1 == auth3: {ReferenceEquals(auth1, auth3)}");
auth3.Authenticate("Софія");

static void TestAuthenticator(string username)
{
	Authenticator auth = Authenticator.GetInstance();
	auth.Authenticate(username);
}