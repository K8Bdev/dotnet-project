﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Globalization;
using System.Linq;

[Serializable]
public partial class POInvoiceResponse {
    
    public string StoreID { get; set; }

    public string PONumber { get; set; }

    [XmlElementAttribute("POInvoice")]
    public List<POInvoiceResponsePOInvoice> POInvoice { get; set; }

    //[XmlIgnore]
    //public List<POInvoiceResponsePOInvoice> POInvoiceAsList { get { return POInvoice?.ToList(); } }
   
    
    [XmlAttributeAttribute()]
    public int StatusCode { get; set; }

    [XmlAttributeAttribute()]
    public string StatusMessage { get; set; }

}

[Serializable]
public partial class POInvoiceResponsePOInvoice
{    
    public string InvoiceNumber { get; set; }    
    public decimal InvoiceTotal { get; set; }
    public string InvoiceDate { get; set; }
    public string InvoiceTime { get; set; }

    [XmlIgnore]
    public DateTime InvoiceDateTime
    {
        get
        {
            DateTime.TryParseExact($"{InvoiceDate} {InvoiceTime}", "MMddyy HHmm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime invoiceDateTime);
            return invoiceDateTime;
        }
    }
}