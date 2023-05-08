
namespace ConversorMoedaPOO {
    internal class ConversorDeMoeda {
        
        public static double Iof = 6.0;
        public static double DolarHoje(double quantia, double cotacao) {
            double Total = quantia * cotacao;
            return Total + Total * Iof / 100.0;
        }
    }
}
