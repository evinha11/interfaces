

namespace ConsoleApp3
{
    public class Superman : IVoador, IPairador, IServivo
    {
        public void Decolar() => Console.WriteLine("Superman decolou.");
        public void Planar() => Console.WriteLine("Superman está planando.");
        public void Pousar() => Console.WriteLine("Superman pousou.");
        public void Cair() => Console.WriteLine("Superman caiu.");
        public void Pairar() => Console.WriteLine("Superman está pairando.");

        public void Comer() => Console.WriteLine("Superman está comendo.");
        public void Dormir() => Console.WriteLine("Superman está dormindo.");
        public void Respirar() => Console.WriteLine("Superman está respirando.");
        public void Morrer() => Console.WriteLine("Superman é imortal.");
    }
}