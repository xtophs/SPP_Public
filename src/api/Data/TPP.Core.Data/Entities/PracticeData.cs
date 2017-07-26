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

using System.ComponentModel.DataAnnotations.Schema;

namespace TPP.Core.Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PracticeData : EntityBase
    {
        [ForeignKey("Session")]
        public int SessionId { get; set; }
        public Nullable<int> EstimatedTrainingLoad { get; set; }
        public Nullable<int> RecommendedTrainingLoad { get; set; }
        public string Side { get; set; }
        public bool isModified { get; set; }
        [ForeignKey("Coach")]
        public Nullable<int> CoachId { get; set; }
        [ForeignKey("Note")]
        public Nullable<int> NoteId { get; set; }
        public Nullable<decimal> Duration { get; set; }

        //Navigation properties
        public Session Session { get; set; }
        public User Coach { get; set; }
        public Note Note { get; set; }
    }
}
