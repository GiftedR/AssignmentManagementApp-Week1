using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp.Tests
{
    public class TaskTests
    {
        [Fact]
        public void Should_Have_A_Title()
        {
            Task t = new Task(); // Task does already exisit, It is used for async tasks using Task.Run();
            Assert.NotNull(t.Title);

        }
    }
}
