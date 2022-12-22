using System.Globalization;


namespace CursoUdemy.Entities

{
    internal class Product
    {

        public string Name { get; private set; }
        public double Price { get; private set; }


        public Product () { }

        public Product (string nome, double price)
        {
            Name = nome;
            Price = price;
        }


        public virtual string PriceTag()
        {
            return Price.ToString();
        }

        public override string ToString()
        {
            return Name + " R$" + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
