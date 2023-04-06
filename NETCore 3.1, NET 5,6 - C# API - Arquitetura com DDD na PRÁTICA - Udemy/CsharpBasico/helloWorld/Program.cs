using System;

namespace HelloWolrd
{
    class Program
    {
        static void Main(string[] args)
        {
            int varialTeste;
            bool VariavelBooleana = false;
            varialTeste = 123;  

            if(VariavelBooleana == false) {
                varialTeste = 765; 
            }

            var TesteInteger = 111;
            var TesteBool = true;
            var TesteString = "Aula";

            Console.WriteLine("O Valor da variável é {0}", varialTeste);
            Console.WriteLine("O Valor da variável é {0}", TesteInteger);
            Console.WriteLine("O Valor da variável é {0}", TesteBool);
            Console.WriteLine("O Valor da variável é {0}", TesteString);

        }
    }
}
