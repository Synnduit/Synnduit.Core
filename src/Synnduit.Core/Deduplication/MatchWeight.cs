namespace Synnduit.Deduplication
{
    /// <summary>
    /// Represents possible "weights" of duplication matches.
    /// </summary>
    public enum MatchWeight
    {
        /// <summary>
        /// The match is a candidate match; i.e., the entities might represent the same
        /// real-world entity.
        /// </summary>
        Candidate = 1,

        /// <summary>
        /// The match is a positive match; i.e., the entities represent the same real-world
        /// entity.
        /// </summary>
        Positive = 2,

        /// <summary>
        /// The match represents an inconsistency; i.e., there is conflicting data that may
        /// require cleansing in the source system, and manual intervention is required.
        /// </summary>
        Inconsistent = 3
    }
}
