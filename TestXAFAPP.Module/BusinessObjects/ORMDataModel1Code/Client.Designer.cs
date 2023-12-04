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

    public partial class Client : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fSecondName;
        public string SecondName
        {
            get { return fSecondName; }
            set { SetPropertyValue<string>(nameof(SecondName), ref fSecondName, value); }
        }
        string fPtronomy;
        public string Ptronomy
        {
            get { return fPtronomy; }
            set { SetPropertyValue<string>(nameof(Ptronomy), ref fPtronomy, value); }
        }
        [PersistentAlias("[SecondName] + ' ' + [Name] + ' ' + [Ptronomy]")]
        public string FullName
        {
            get { return (string)(EvaluateAlias(nameof(FullName))); }
        }
        [Association(@"OrderReferencesClient")]
        public XPCollection<Order> Orders { get { return GetCollection<Order>(nameof(Orders)); } }
    }

}