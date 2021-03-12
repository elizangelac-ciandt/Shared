using System;

namespace SharedIngest
{
    public static class Pessoa
    {
        public static string CalcularIdade(DateTime dataNascimento)
        {
            var idade = DateTime.Now.Year - dataNascimento.Year;
            if(DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
                idade = idade - 1;

            return idade.ToString();
        }
    }
}
