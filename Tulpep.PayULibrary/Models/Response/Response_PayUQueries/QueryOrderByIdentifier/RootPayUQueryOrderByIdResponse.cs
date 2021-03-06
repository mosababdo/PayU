﻿namespace Tulpep.PayULibrary.Models.Response.Response_PayUQueries.QueryOrderByIdentifier
{
    public class RootPayUQueryOrderByIdResponse
    {
        //Format: Alphanumeric Size: 
        //Description: The overall response code. ERROR, SUCCESS.
        public string code { get; set; }
        //Format: Alphanumeric Size: Max: 2048
        //Description: The message associated with the error when code is ERROR.
        public string error { get; set; }
        public Response_QueryOrderByIdentifier_Result result { get; set; }
    }
}
