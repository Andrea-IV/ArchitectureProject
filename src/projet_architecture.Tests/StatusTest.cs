using System;
using Xunit;
using projet_architecture.Core;

namespace projet_architecture.Tests
{
    public class StatusTest
    {
        [Fact]
        public void test_created_status_is_to_do()
        {
            Status status = new Status();
            Assert.Equal("To Do", status.getState());
        }

        [Fact]
        public void test_change_status_done()
        {
            Status status = new Status();
            var returned = status.isDone();
            Assert.Equal("Done", status.getState());
        }
        
    }
}
