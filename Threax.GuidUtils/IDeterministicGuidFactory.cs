using System;

namespace Threax.GuidUtils
{
    /// <summary>
    /// An interface to create deterministic guids that are always the same if the same name is passed in.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDeterministicGuidFactory<T>
    {
        /// <summary>
        /// Create a deterministic guid. The result will always be the same for the same value for name.
        /// </summary>
        /// <param name="name">The name to base the guid on.</param>
        /// <returns>A new deterministic guid based on name.</returns>
        Guid CreateGuid(string name);
    }
}