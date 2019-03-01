using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers;
using AuthorizeNet.Api.Controllers.Bases;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace BlogPostCMS.Models
{
    public class Payment
    {
        private IConfiguration _configuration;
        public Payment(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Run()
        {
            // declare that we are using the Sandbox account. 

            ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.SANDBOX;

            // define the merchant information (authentication/transactionID)
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.MerchantAuthentication = new merchantAuthenticationType()
            {
                name = "28mJ9dEu",
                ItemElementName = ItemChoiceType.transactionKey,
                Item = "7mH28243jP3wN8w7"
            };

            // WE need a CC, let's create it.
            // In your app...bring it in as a parameter 
            var creditCard = new creditCardType
            {
                cardNumber = "4111111111111111",
                expirationDate = "1020"
            };

            // Make a call out to our external method. possibly send it the userid as an argument. 
            customerAddressType billingAddress = GetAddress();

            // We want to use Credit cards...so tell the program that is the only payment type we are accepting. 
            paymentType paymentType = new paymentType { Item = creditCard };

            // transaction request type consolidates all of the information about our transaction before sending it to AUth.NET. 
            // possible Paramaters that you need:
            //1. Amount of Order

            transactionRequestType transactionRequest = new transactionRequestType
            {
                transactionType = transactionTypeEnum.authCaptureTransaction.ToString(),
                amount = 102.5m,
                payment = paymentType,
                billTo = billingAddress,
                //lineItems =
            };

            createTransactionRequest request = new createTransactionRequest
            {
                transactionRequest = transactionRequest
            };

            // make a call out to AUth.NET with the requset we just created
            var controller = new createTransactionController(request);
            // execute the call
            controller.Execute();

            // this is the reseponse from the call we made above. 
            var response = controller.GetApiResponse();

            if (response != null)
            {
                if (response.messages.resultCode == messageTypeEnum.Ok)
                {
                    if (response.transactionResponse != null)
                    {
                        return "OK";
                    }
                }
                else
                {
                    return "NotOK";
                }
            }

            return "NotOK";
        }

        /// <summary>
        /// Get the address from the user's profile. 
        /// SUGGESTION: Bring in the user as a parameter
        /// Bring in the UserID possibly?
        /// </summary>
        /// <returns></returns>
        private customerAddressType GetAddress()
        {
            // If you brought in the userid, make a call to the user's profile information to fill out the customer address type.

            customerAddressType address = new customerAddressType()
            {
                firstName = "Josie",
                lastName = "Cat",
                address = "123 catnip lane",
                city = "the palace",
                zip = "98119"
            };

            return address;
        }

        private lineItemType[] GetLineItems(List<Post> products)
        {
            lineItemType[] lineitems = new lineItemType[products.Count];

            int count = 0;

            foreach (var prod in products)
            {
                lineitems[count] = new lineItemType
                {
                    // this should be prod id
                    itemId = "1",
                    name = "productNAmeHere",
                    quantity = 2,
                    unitPrice = new Decimal(5.00)
                };
                count++;


            }

            return lineitems;

        }
    }
}
