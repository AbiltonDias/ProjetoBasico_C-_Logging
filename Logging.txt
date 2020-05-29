using System;
using System.IO;

namespace Program
{
    public class Logging
    {
        // Variáveis da Classe
        // ===================
        public string Filename {get; set;}
        
        // Construtor Padrão
        // =================
        public Logging()
        {
            this.Filename = "Log.txt";
        }
        
        // Construtor Customizado
        // ======================
        public Logging(string Filename)
        {
            this.Filename = Filename;
        }
        
        // Métodos da Classe
        // =================
        
        // Métodos Públicos
        // --------------
        
        // Escrevendo a mensagem no arquivo de log
        // ---------------------------------------
        public void WriteLog(string Message)
        {
            try
            {
                using(StreamWriter Log = new StreamWriter(this.Filename, true))
                {
                    Log.WriteLine("[{0}] {1}", DateTime.Now, Message);
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Erro! Arquivo de Logging não pôde ser acessado!");
            }
        }
        
        // Lendo as mensagens do arquivo de log
        // ------------------------------------
        public void ReadLog()
        {
            string LogText = "";
            try
            {
                using(StreamReader Log = new StreamReader(this.Filename))
                {
                    LogText = Log.ReadToEnd();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Erro! Arquivo de Logging não encontrado!");
            }
            
            Console.WriteLine(LogText);
        }
    }
}