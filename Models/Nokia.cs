namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nome){
            Console.Write($"Instalando aplicativo {nome}");
            for (int i = 0; i < 3 ; i++)
            {
                Console.Write(".");
                Task.Delay(1000).Wait();
            }
        }
    }
}
