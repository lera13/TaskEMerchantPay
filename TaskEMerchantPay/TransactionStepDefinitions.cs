using RestSharp;
using RestSharp.Serializers.Newtonsoft.Json;
using System;
using System.Net;
using System.Web.Helpers;
using System.Xml.Linq;
using TechTalk.SpecFlow;

namespace TaskEMerchantPay
{
    [Binding]
    public class TransactionStepDefinitions
    {

        public TransactionInputs transactionInputs = new TransactionInputs();
        public RestResponse restResponse = new RestResponse();
        public RestSharp.RestRequest restRequest = new RestSharp.RestRequest();

        [When(@"I send POST request")]
        public void WhenISendPOSTRequest(long cardNumber, int cvv, string expDate, int amount, string usage, string trnType, string cardHolder, string email, string address)
        {
            transactionInputs = new TransactionInputs()
            {
                CardNumer = cardNumber,
                Cvv = cvv,
                ExpDate = expDate,
                Amount = amount,
                Usage = usage,
                TransactionType = trnType,
                CardHolder = cardHolder,
                Email = email,
                Address = address
            };
            string url = ($"http://localhost:3001/payment_transactions");
            var restClient = new RestClient(url);

            restRequest.Method = Method.Post; // 
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddHeader("Authorization", "Basic Y29kZW1vbnN0ZXI6bXk1ZWNyZXQta2V5Mm8ybw==");
                        
           // restRequest.AddJsonBody(transactionInputs);

            /* "{
                "payment_transaction": {
                  "card_number": "4200000000000000",
                  "cvv": "123",
                  "expiration_date": "06/2019",
                  "amount": "500",
                  "usage": "Coffeemaker",
                  "transaction_type": "sale",
                  "card_holder": "Panda Panda",
                  "email": "panda@example.com",
                  "address": "Panda Street, China"
                }
            }";*/

            restRequest.AddJsonBody(transactionInputs);
            

            restResponse = restClient.Post(restRequest);

        }

        [Then(@"the system should return (.*)")]
        public int ThenTheSystemShouldReturn()
        {
           
            var statusCode = (int)restResponse.StatusCode;
            return statusCode;
        }

        [Then(@"I will check transaction status")]
        public void ThenIWillCheckTransactionStatus()
        {
            throw new PendingStepException();
        }
    }
}
