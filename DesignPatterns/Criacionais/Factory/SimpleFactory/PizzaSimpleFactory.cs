namespace SimpleFactory
{
    public class PizzaSimpleFactory
    {
        private static readonly IReadOnlyDictionary<TipoPizza, Pizza> menuDePizzas =
            new Dictionary<TipoPizza, Pizza>
            {
                { TipoPizza.Calabresa, new PizzaCalabresa() },
                { TipoPizza.Mussarela, new PizzaMussarela() }
            };

        public static Pizza CriaPizza(string pizzaEscolhida)
        {
            if (!pizzaEscolhida.IsEnum<TipoPizza>())
                throw new ApplicationException($"A pizza {pizzaEscolhida} não foi criada.");

            return menuDePizzas.GetValueOrDefault(pizzaEscolhida.ToEnum<TipoPizza>());
        }
        
    }

    public enum TipoPizza
    {
        Calabresa,
        Mussarela        
    }
}