// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TPP.Core.Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlayerMedicalMeasurement : EntityBase
    {
        public Nullable<int> PlayerMeasurementTypeId { get; set; }
        public string PlayerName { get; set; }
        public Nullable<int> PlayerId { get; set; }
        public Nullable<System.DateTime> MeasurementDate { get; set; }
        public Nullable<double> Value { get; set; }
        public string Notes { get; set; }
    }
}
