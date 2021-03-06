﻿using System;

namespace Tulpep.PayULibrary.Models.Request.Request_PayUPayments.Bank
{
    public class Request_Bank_Payer
    {
        //Format: Alphanumeric Size: Max: 150
        //Description: Buyer’s full names.
        private string FullName;
        public string fullName
        {
            get
            {
                return FullName;
            }
            set
            {
                if (value.Length > 0 && value.Length < 151)
                {
                    FullName = value;
                }
                else
                {
                    throw new Exception("The MAX length of fullName is 150 MIN 1");
                }
            }
        }
        public string billingAddress { get; set; }
    }
}
