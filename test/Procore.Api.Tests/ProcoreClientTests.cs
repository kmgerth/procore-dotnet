using System;
using Xunit;

namespace Procore.Api.Tests
{
    public class ProcoreClientTests
    {
        //---------------------------------------------------------------------
        // Constructor
        //---------------------------------------------------------------------

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Constructor_InvalidToken_ThrowArgumentNullException(string token)
        {
            Assert.Throws<ArgumentNullException>(() => new ProcoreClient(token));
        }
    }
}
