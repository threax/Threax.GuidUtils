using System;
using Xunit;

namespace Threax.GuidUtils.Tests
{
    public class DeterminsticGuidTests
    {
        [Fact]
        public void CreateGuid()
        {
            var guidFactory = new DeterministicGuidFactory<DeterminsticGuidTests>(Guid.Parse("7b342cc4-0a8b-4625-9399-5d9d728b38b9"));
            var guid = guidFactory.CreateGuid("Test Name");
            Assert.Equal(Guid.Parse("a379121f-631c-5878-b8b4-aa7a4e5b73c1"), guid);
        }
    }
}
