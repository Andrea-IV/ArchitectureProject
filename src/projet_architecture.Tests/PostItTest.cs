using System;
using Xunit;
using projet_architecture.Core;

namespace projet_architecture.Tests
{
    public class PostItTest
    {
        [Fact]
        public void test_get_post_it()
        {
            Post_It task1 = new Post_It("Do this", new FakeClock("12/03/2020 17:00:00"), new FakeStatus("To Do"));
            Assert.Equal("TASK: Do this, CREATION DATE: 12/03/2020 17:00:00, Status: To Do", task1.getPost_It());
        }

        [Fact]
        public void test_change_post_it_done()
        {
            Post_It task1 = new Post_It("Do this", new FakeClock("12/03/2020 17:00:00"), new FakeStatus("To Do"));
            var returned = task1.isDone();
            Assert.Equal("TASK: Do this, CREATION DATE: 12/03/2020 17:00:00, Status: Done", task1.getPost_It());
        }

        class FakeClock : IClock
        {
            private DateTime createdAT;

            public FakeClock(string date){
                this.createdAT = DateTime.Parse(date);
            }

            DateTime IClock.createdAT { get => this.createdAT;}
        }

        class FakeStatus : IStatus
        {
            private string status_name;

            public FakeStatus(string status_name){
                this.status_name = status_name;
            }

            public string getState()
            {
                return this.status_name;
            }

            public int isDone()
            {
                this.status_name = "Done";
                return 1;
            }
        }
    }
}
