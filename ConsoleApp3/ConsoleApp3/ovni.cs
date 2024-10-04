
namespace ConsoleApp3
{
    public class OVNI : IVoador, IMaquina
    {
        public void Decolar() => Console.WriteLine("O OVNI decolou, zummm.");
        public void Planar() => Console.WriteLine("O OVNI está planando, pi pi.");
        public void Pousar() => Console.WriteLine("O OVNI pousou.");
        public void Cair() => Console.WriteLine("O OVNI caiu.");

        public void Ligar() => Console.WriteLine("O OVNI está ligado.");
        public void Desligar() => Console.WriteLine("O OVNI está desligado.");
        public void Abastecer() => Console.WriteLine("O OVNI está sendo abastecido.");
        public void Alerta() => Console.WriteLine("Alerta do OVNI acionado.");
    }
}
