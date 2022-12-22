using System.Globalization;


namespace CursoUdemy.Entities
{

    internal class UsedProduct : Product
    {

        public DateTime ManufacturedDate { get; set; }

        
        
        public UsedProduct() { }
        
        public UsedProduct(string nome, double price, DateTime manufacturedDate) : base (nome, price)
        {
            ManufacturedDate = manufacturedDate;
        }


        public override string PriceTag()
        {
            return base.PriceTag();
        }


        public override string ToString()
        {
            return Name + " (used) R$" + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufactured Date: " + ManufacturedDate.ToString("dd/MM/yyyy") + ")";
        }


    }
}
