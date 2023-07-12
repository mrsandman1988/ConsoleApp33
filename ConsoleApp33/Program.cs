namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var visa = new Visa
            {
                ExpireDate = DateTime.Now.AddYears(2),
                CVV = 124,
                Number = "42565888748"
            };
            PaymentGetway.AddMoney(visa,1000);
        }
    }
}