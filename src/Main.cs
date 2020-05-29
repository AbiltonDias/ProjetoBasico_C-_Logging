using System;

namespace Logging___Projeto_Github
{
    class MainClass
    {
        //Objetivo é Logging utilizando um arquivo diferente
        static Logging log = new Logging("LoggingFile.txt");

        //Método ruim, catalogando a mensagem de IndexOutOfRangeException

        static void BadMethod(){
            string[] Fruits = {"Maçãs","Bananas","Laranjas"};

            try{
                for( int i = 0; i < 4; i++){
                    Console.WriteLine("Eu gosto de {0}!", Fruits[i]);
                }
            }catch(IndexOutOfRangeException e){
                Console.WriteLine("Oops! Algo deu errado! Verifique o log!");
                log.WriteLog(e.ToString());
            }
        }

        //Metodos simples para testes

        static void Multiply(int i, int j){
            Console.WriteLine("O resultado de {0} * {1}: {2}", i, j, i*j);
            log.WriteLog(string.Format("Método: {0} - Resultado: {1}", "Multiply(int i, int j)", i * j));
        }

        static void Subtract(int i, int j){
            Console.WriteLine("O resultado de {0} - {1}: {2}", i, j, i - j);
            log.WriteLog(string.Format("Método: {0} - Resultado: {1}", "Subtract(int i, int j)", i - j));
        }

        static void Add(int i, int j){
            Console.WriteLine("O resultado de {0} + {1} : {2}", i,j, i + j);
            log.WriteLog(string.Format("Metodo: {0} - Resultado: {1}", "Add(int i, int j)", i + j));
        }

        static void Main()
        {
            Console.WriteLine("Basic Logging Program: ");
            Console.WriteLine("========================\n");

            Add(10,20);
            Subtract(50,10);
            Multiply(12,12);

            BadMethod();

            Console.WriteLine("\nLendo Log:");
            Console.WriteLine("---------------");
            log.ReadLog();
        }
    }
}
