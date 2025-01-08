namespace Aula21_OO_Enumerate
{
    public enum Estado
    {
        Sp,
        RJ,
        MG,
        BA,
    }

    public class ExtencaoEstado
    {
        public static string GetDescricao(Estado estado)
        {
            switch (estado)
            {
                case Estado.Sp:
                    return "São Paulo";
                case Estado.RJ:
                    return "Rio de Janeiro";
                case Estado.MG:
                    return "Minas Gerais";
                case Estado.BA:
                    return "Bahia";
                default:
                    return "Estado não encontrado";
            }
        }
    }

    public class Regiao
    {
        public string[] Regioes = new string[] { "Sul", "Sudeste", "Centro-Oeste", "Norte", "Nordeste" };

        public string GetRegiao(Estado estado)
        {
            return estado switch
            {
                Estado.Sp => Regioes[1],
                Estado.RJ => Regioes[1],
                Estado.MG => Regioes[1],
                Estado.BA => Regioes[4],
                _ => "Região não encontrada",
            };
        }
    }
}