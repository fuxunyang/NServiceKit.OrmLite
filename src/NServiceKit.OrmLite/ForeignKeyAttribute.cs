﻿using System;
using NServiceKit.DataAnnotations;

namespace NServiceKit.OrmLite
{
    /// <summary>Attribute for foreign key.</summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ForeignKeyAttribute : ReferencesAttribute
    {
        /// <summary>
        /// Initializes a new instance of the NServiceKit.OrmLite.ForeignKeyAttribute class.
        /// </summary>
        /// <param name="type">The type.</param>
        public ForeignKeyAttribute(Type type) : base(type)
        {
        }

        /// <summary>Gets or sets the on delete.</summary>
        /// <value>The on delete.</value>
        public string OnDelete { get; set; }

        /// <summary>Gets or sets the on update.</summary>
        /// <value>The on update.</value>
        public string OnUpdate { get; set; }

        /// <summary>
        /// Explicit foreign key name. If it's null, or empty, the FK name will be autogenerated as
        /// before.
        /// </summary>
        /// <value>The name of the foreign key.</value>
        public string ForeignKeyName { get; set; }
    }
}