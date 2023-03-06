namespace TaskEMerchantPay
{
    public class Program
    {
        static void Main(string[] args)
        {
            TransactionStepDefinitions transactionStepDefinitions = new TransactionStepDefinitions();

            transactionStepDefinitions.WhenISendPOSTRequest(4200000000000000,123,"06/2019",500, "Coffeemaker", "sale", "Panda Panda", "panda@example.com", "Panda Street, China");

            Console.WriteLine(transactionStepDefinitions.ThenTheSystemShouldReturn());

        }
    }
} 