using System.Globalization;

namespace CursoUdemy.Entities

{
    internal class ImportedProducts : Product
    {

        public double CustomFee { get; set; }



        public ImportedProducts() { }

        public ImportedProducts(string nome, double price, double customFee) : base(nome, price)
        {
            CustomFee = customFee;
        }



        public override string PriceTag()
        {
            return base.PriceTag();
        }


        public double TotalPrice()
        {
            double preco = double.Parse(PriceTag());

            return preco + CustomFee;
        }

        public override string ToString()
        {
            return Name + " R$" + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: R$" + CustomFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

    }
}
