namespace CursoUdemy.Entities
{
    internal class OutsourcedEmployee : Employee
    {

        public double AdditionalCharge { get; private set; }



        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string nome, int hours, double valuePerHour, double additionalCharge) : base(nome, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }



        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.10);
        }

    }
}
