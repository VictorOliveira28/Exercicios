using System.Globalization;

namespace ContaBancaria {
    internal class AddConta {
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public AddConta(int conta, string nome) {

            Titular = nome;
            Conta = conta;
        }
        public AddConta(int conta, string nome, double depositoInicial) : this(conta, nome) {
            ValorDeposito(depositoInicial);
        }

        public void ValorDeposito(double valor) {
            Saldo += valor;
        }

        public void Saque(double valor) {
            Saldo -= valor + 5.00;
        }

        public override string ToString() {
            return "Conta: " + Conta + ", Titular: " + Titular + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
