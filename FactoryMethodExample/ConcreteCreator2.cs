namespace FactoryMethodExample
{
    class ConcreteCreator2 : Creator
    {
        protected override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
