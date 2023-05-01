namespace Dapper
{
    /// <summary>
    /// Array handling strategy.
    /// </summary>
    public enum ArrayHandling
    {
        /// <summary>
        /// Detect using FeatureSupport.Detect.
        /// </summary>
        Detect = 0,

        /// <summary>
        /// Pass array as parameter.
        /// </summary>
        Parameter = 1,

        /// <summary>
        /// Expand array.
        /// </summary>
        Expand = 2
    }
}
