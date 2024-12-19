
namespace Palindrome.Services
{
    class Program{
        public static void Main(){
            List<string> allPalindromes= Palindrome.GetAllPalindromes("mkTacoocatm95");
            foreach (string palindrome in allPalindromes){
                Console.WriteLine(palindrome);
            }
        }
    }
}