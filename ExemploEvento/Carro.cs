using System.Threading;

namespace ExemploEvento {
    public class Carro {
        int qtdTanque = 0;

        public Carro (int qtdTanque) {
            this.qtdTanque = qtdTanque;
        }

        public void Ligar () {
            while (true) {
                Thread.Sleep (1000); // usado para o laço esperar por um segundo antes de repetir
                this.qtdTanque--;

                System.Console.WriteLine (qtdTanque);

                if (this.qtdTanque.Equals (3)) {
                    this.Ligacao ("119353164");
                    
                }

                if (this.qtdTanque.Equals (0)) {
                    this.TanqueVazio ();
                    break;
                }

            }
        }
        public delegate void EventoCarro ();
        public event EventoCarro TanqueVazio; // Eventos apenas iniciam delegates, para isso é necessario criar um delegate que chame o metodo desejado~

        public delegate void Chamar (string texto);
        public event Chamar Ligacao;
    }
}