namespace DesignPatterns.FactoryMethod.Conceptual
{
    public class ConcreteProduct2 : IProduct
    {
        // Concrete Products provide various implementations of the Product
        // interface.
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
