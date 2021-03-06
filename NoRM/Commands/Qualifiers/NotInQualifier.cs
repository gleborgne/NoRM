﻿using Norm.BSON;

namespace Norm.Commands.Qualifiers
{
    /// <summary>
    /// The not in qualifier.
    /// </summary>
    /// <typeparam name="T">No in type to qualify </typeparam>
    public class NotInQualifier<T> : QualifierCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotInQualifier{T}"/> class.
        /// </summary>
        /// <param name="notInSet">
        /// The not in set.
        /// </param>
        public NotInQualifier(params T[] notInSet) : base("$nin", notInSet)
        {
        }
    }
}