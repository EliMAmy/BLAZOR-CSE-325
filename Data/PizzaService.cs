namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<Pizza[]> GetPizzasAsync()
    {
        Pizza[] pizzas =
        {
            new Pizza
            {
                PizzaId = 1,
                Name = "Margherita",
                Description = "Tomato and cheese",
                Price = 9.99M,
                Vegetarian = true,
                Vegan = false
            },
            new Pizza
            {
                PizzaId = 2,
                Name = "Pepperoni",
                Description = "Pepperoni and cheese",
                Price = 12.50M,
                Vegetarian = false,
                Vegan = false
            }
        };

        return Task.FromResult(pizzas);
    }
}