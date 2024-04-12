namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {}

        public string ProtecaoGorillaGlass { get; set; }
        public string ContaPlayStore { get; set; }

        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"\n\nInstalando aplicativo {nomeApp} pela Play Store...\nConfigurando conta {ContaPlayStore} da Play Store...\nTornando dispositivo resistene à quedas com o GorillaGlass versão {ProtecaoGorillaGlass}...");
        }
    }
}