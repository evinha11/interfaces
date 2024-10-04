namespace ConsoleApp3
{
    public class BeijaFlor : IMaquina
    {
        public void Ligar() => Console.WriteLine("Beija-flor voando.");
        public void Desligar() => Console.WriteLine("Beija-flor parou.");
        public void Abastecer() => Console.WriteLine("Beija-flor se alimentando.");
        public void Alerta() => Console.WriteLine("Beija-flor emitiu um som.");
    }
}
