using System;
using Synnduit.Properties;

namespace Synnduit.Deduplication
{
    /// <summary>
    /// Represents a match found in the deduplication process.
    /// </summary>
    public class Duplicate
    {
        private readonly EntityIdentifier destinationSystemEntityId;

        private readonly MatchWeight weight;

        /// <summary>
        /// Initializes a new instance of the class and sets the values of its properties.
        /// </summary>
        /// <param name="destinationSystemEntityId">
        /// The ID that uniquely identifies the entity in the destination system.
        /// </param>
        /// <param name="weight">The weight of the duplicate.</param>
        public Duplicate(
            EntityIdentifier destinationSystemEntityId,
            MatchWeight weight)
        {
            ArgumentValidator.EnsureArgumentNotNull(
                destinationSystemEntityId, nameof(destinationSystemEntityId));
            this.ValidateWeight(weight);
            this.destinationSystemEntityId = destinationSystemEntityId;
            this.weight = weight;
        }

        /// <summary>
        /// Gets or sets the ID that uniquely identifies the entity in the destination
        /// system.
        /// </summary>
        public EntityIdentifier DestinationSystemEntityId
        {
            get { return this.destinationSystemEntityId; }
        }

        /// <summary>
        /// Gets the weight of the duplicate.
        /// </summary>
        public MatchWeight Weight
        {
            get { return this.weight; }
        }

        private void ValidateWeight(MatchWeight weight)
        {
            switch (weight)
            {
                case MatchWeight.Candidate:
                case MatchWeight.Positive:
                case MatchWeight.Inconsistent:
                    break;

                default:
                    throw new ArgumentException(string.Format(
                        Resources.InvalidMatchWeight, weight),
                        "weight");
            }
        }
    }
}
