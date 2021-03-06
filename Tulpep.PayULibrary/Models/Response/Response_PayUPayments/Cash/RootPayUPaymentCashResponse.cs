﻿using System;

namespace Tulpep.PayULibrary.Models.Response.Response_PayUPayments.Cash
{
    public class RootPayUPaymentCashResponse
    {
        //Format: Alphanumeric Size:
        //Description: The overall response code. ERROR, SUCCESS.
        public string code { get; set; }
        //Format: Alphanumeric Size: Max: 2048
        //Description: The message associated with the error when code is ERROR.
        private string Error;
        public string error
        {
            get
            {
                return Error;
            }
            set
            {
                if (value != null)
                {
                    if (value.Length > 0 && value.Length < 2049)
                    {
                        Error = value;
                    }
                    else
                        throw new Exception("The MAX length of error is 2048");
                }
                else
                {
                    Error = value;
                }
            }
        }
        //The response’s data.
        public Response_Cash_TransactionResponse transactionResponse { get; set; }
    }
}
