using System;

namespace Synnduit.Events
{
    /// <summary>
    /// Used to denote classes that represent event receivers.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class,
        Inherited = false,
        AllowMultiple = false)]
    public sealed class EventReceiverAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EventReceiverAttribute()
        { }
    }
}
