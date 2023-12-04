﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace TestXAFAPP.Module.BusinessObjects.TestXAFAPP
{

    public partial class Order : DevExpress.Persistent.BaseImpl.BaseObject
    {
        int fNumber;
        public int Number
        {
            get { return fNumber; }
            set { SetPropertyValue<int>(nameof(Number), ref fNumber, value); }
        }
        decimal fCost;
        [ColumnDefaultValue(0)]
        public decimal Cost
        {
            get { return fCost; }
            set { SetPropertyValue<decimal>(nameof(Cost), ref fCost, value); }
        }
        string fLink;
        public string Link
        {
            get { return fLink; }
            set { SetPropertyValue<string>(nameof(Link), ref fLink, value); }
        }
        Client fClient;
        [Association(@"OrderReferencesClient")]
        public Client Client
        {
            get { return fClient; }
            set { SetPropertyValue<Client>(nameof(Client), ref fClient, value); }
        }
    }

}