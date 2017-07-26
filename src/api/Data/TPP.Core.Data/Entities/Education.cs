// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPP.Core.Data.Entities
{
    [Table("Education")]
    public class Education : EntityBase
    {
        [Column(TypeName = "text")]
        [Required]
        public string Name { get; set; }
    }
}