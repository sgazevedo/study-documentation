namespace SimpleFactory
{
    public abstract class Pizza
    {
        public string Nome { get; set; }

        public abstract void Preparar();
        public abstract void Assar(int tempo);
        public abstract void Embalar();
    }

    public class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa()
        {
            Nome = nameof(PizzaCalabresa);
        }

        public override void Assar(int tempo)
        {
            Console.WriteLine($"{Nome} assando por {tempo} minutos.");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando {Nome}.");
        }

        public override void Preparar()
        {
            Console.WriteLine($"Preparando {Nome}.");
        }
    }

    public class PizzaMussarela : Pizza
    {
        public PizzaMussarela()
        {
            Nome = nameof(PizzaMussarela);
        }

        public override void Assar(int tempo)
        {
            Console.WriteLine($"{Nome} assando por {tempo} minutos.");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando {Nome}.");
        }

        public override void Preparar()
        {
            Console.WriteLine($"Preparando {Nome}.");
        }
    }
}