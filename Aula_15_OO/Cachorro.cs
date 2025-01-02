namespace Name
{
    class Cachorro
    {
        public string nome;

        public string raca;

        public int idade;

        public void escrevaSaida(){
            System.Console.WriteLine($"Nome: {nome}");
            System.Console.WriteLine($"Raça: {raca}");
            System.Console.WriteLine($"Idade: {idade}");
            System.Console.WriteLine($"Idade em humanos: {getIdadeHumanos()}");
        }

        public int getIdadeHumanos(){
            int idadeHumano = 0;
            if (idade <= 2)
            {
                idadeHumano = idade * 11;
            } else
            {
                idadeHumano = 22 + (idade - 2) * 5;
           }
           return idadeHumano;
        }
    }
}