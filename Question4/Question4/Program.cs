using System;

namespace DistanciaEntreVeiculos
{

    class Program
    {

        public static void Main(string[] args)
        {

            //distância entre as cidades
            const int distancia = 100;

            //velocidade do carro em km/h
            const int velocidadeCarro = 110;

            //velocidade do caminhão em km/h
            const int velocidadeCaminhao = 80;

            //quantidade de pedágios no trajeto
            const double pedagios = 2;

            //tempo extra em minutos que o caminhão leva para passar em cada pedágio
            const double tempoExtraPedagio = 5;


            //tempo que levará para os veículos se encontrarem
            double tempoParaEncontro = distancia / (double)(velocidadeCarro + velocidadeCaminhao);

            //tempo que o carro levará para chegar até o primeiro pedágio
            double horaPraChegarPedagios = (distancia / 2) / (double)velocidadeCarro;


            //tempo total que o caminhão levará para se encontrar com o carro
            double timeForTruck = tempoParaEncontro + (tempoExtraPedagio / 60.0) * pedagios;

            //distância que o carro terá percorrido quando os veículos se encontrarem
            double distanciaParaCarro = velocidadeCarro * (horaPraChegarPedagios + tempoParaEncontro);

            //distância que o caminhão terá percorrido quando os veículos se encontrarem
            double distanciaParaCaminhao = velocidadeCaminhao * timeForTruck;

            //distância que o carro estará de Ribeirão Preto quando os veículos se encontrarem
            double distanciaParaRibeiraoPretoParaCarro = distancia - distanciaParaCarro;

            //distância que o caminhão estará de Ribeirão Preto quando os veículos se encontrarem
            double distanciaParaRibeiraoPretoParaCaminhao = distanciaParaCaminhao;


            if (distanciaParaRibeiraoPretoParaCarro < distanciaParaRibeiraoPretoParaCaminhao)
            {
                Console.WriteLine("O carro estará mais próximo de Ribeirão Preto quando os veículos se encontrarem.");
            }
            else
            {
                Console.WriteLine("O caminhão estará mais próximo de Ribeirão Preto quando os veículos se encontrarem.");
            }

        }
    }
}

