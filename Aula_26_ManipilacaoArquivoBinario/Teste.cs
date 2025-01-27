using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Aula_26_ManipilacaoArquivoBinario
{
    public class Teste
    {
        static void Main(string[] args)
        {
            string password = "a";
            SalvarVotosEncriptados(password);
        }

        static void SalvarVotosEncriptados(string password, Eleicao eleicao)
        {
            List<Guid> guidsAleatorios = new List<Guid>();

                for (int i = 0; i < 10; i++)
                {
                    guidsAleatorios.Add(Guid.NewGuid());
                }

            string VotosEncriptados = "VotosEncriptados.csv";
            string VotosEncriptadosTemp = "VotosEncriptadosTemp.csv";

            try
            {
                 using (StreamWriter writer = new StreamWriter(VotosEncriptados))
            {
                foreach (var guid in guidsAleatorios)
                {
                    writer.WriteLine(guid.ToString());    
                    writer.WriteLine(eleicao.Votos)
                }
            }


                byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32));
                byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16));

                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;

                    using (FileStream inputFileStream = new FileStream(VotosEncriptados, FileMode.Open))
                    using (FileStream outputFileStream = new FileStream(VotosEncriptadosTemp, FileMode.Create))
                    using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        inputFileStream.CopyTo(cryptoStream);
                    }
                }

                File.Delete(VotosEncriptados);
                File.Move(VotosEncriptadosTemp, VotosEncriptados);

                Console.WriteLine("Votos encriptados com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar o arquivo: {ex.Message}");
            }
        }

        static void DecryptFile(string password)
        {

            string VotosEncriptados = "VotosEncriptados.csv";
            string VotosDesencriptados = "VotosDesencriptados.csv";

            byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32)); 
            byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16));

            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;

                    using (FileStream inputFileStream = new FileStream(VotosEncriptados, FileMode.Open))
                    using (FileStream outputFileStream = new FileStream(VotosDesencriptados, FileMode.Create))
                    using (CryptoStream cryptoStream = new CryptoStream(inputFileStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        cryptoStream.CopyTo(outputFileStream);
                    }
                }

                Console.WriteLine("Votos desencriptados com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao desencriptar o arquivo: {ex.Message}");
            }
        }
    }
}
