namespace SimpleFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe a pizza (C)alabresa (M)ussarela ");
            var pizzaEscolhida = Console.ReadLine();
            try
            {
                var tipoPizza = pizzaEscolhida.ToEnum<TipoPizza>();
                
                Pizza pizza = PizzaSimpleFactory.CriaPizza(pizzaEscolhida);
                pizza.Preparar();
                pizza.Assar(30);
                pizza.Embalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}