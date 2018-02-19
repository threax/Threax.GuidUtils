using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Threax.GuidUtils.Logos.Utility;

namespace Threax.GuidUtils
{
    /// <summary>
    /// A single DeterministicGuidFactory instance, can be linked strongly to a type, which can be
    /// used to vary the GuidNamespace for different factories if needed.
    /// </summary>
    /// <typeparam name="T">The type to link this factory to, not used by the factory at all, useful for dependency injection.</typeparam>
    public class DeterministicGuidFactory<T> : IDeterministicGuidFactory<T>
    {
        private Guid guidNamespace;

        public DeterministicGuidFactory(Guid guidNamespace)
        {
            this.guidNamespace = guidNamespace;
        }

        public Guid CreateGuid(String name)
        {
            return GuidUtility.Create(guidNamespace, name);
        }
    }
}
