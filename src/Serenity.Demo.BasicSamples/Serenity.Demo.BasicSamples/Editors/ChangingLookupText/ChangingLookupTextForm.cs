﻿using Serenity.ComponentModel;
using System;

namespace Serenity.Demo.BasicSamples.Forms
{
    [FormScript("BasicSamples.ChangingLookupText")]
    [BasedOnRow(typeof(Northwind.OrderDetailRow), CheckNames = true)]
    public class ChangingLookupTextForm
    {
        [ChangingLookupTextEditor]
        public Int32 ProductID { get; set; }
        public Decimal UnitPrice { get; set; }
        public Int32 Quantity { get; set; }
        public Double Discount { get; set; }
    }
}