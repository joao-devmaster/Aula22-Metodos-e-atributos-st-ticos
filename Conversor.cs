
namespace Aula22POO
{
    public static class Conversor
    {
        private static float CotacaoDolar = 5.23f;
        private static float CotacaoEuro = 5.93f;

        public static float RealParaDolar(float valorRS){
            return valorRS / CotacaoDolar;
        }

        public static float DolarParaReais(float valorUS){
            return CotacaoDolar * valorUS;
        }

         public static float RealParaEuro(float valorRS){
            return valorRS / CotacaoEuro;
        }

         public static float EuroParaReal(float valorEuro){
            return CotacaoEuro * valorEuro;
        }

        

        
        
    }
}