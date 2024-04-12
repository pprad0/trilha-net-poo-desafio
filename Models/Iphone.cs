namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

        public string FoneBluetooth { get; set; }
        public string ContaAppleMusic { get; set; }


        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"\n\nInstalando aplicativo {nomeApp} pela App Store...\nConfigurando conta {ContaAppleMusic} da Apple Music...\nPareando fone de ouvido {FoneBluetooth} para uma melhor experiência...");
        }
    }
}