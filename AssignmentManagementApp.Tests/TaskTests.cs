using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentManagementApp.Tests
{
    public class AssignmentTests
    {
        [Fact]
        public void Should_Have_A_Title()
        {
            Assignment t = new Assignment(); // Task does already exisit, It is used for async tasks using Task.Run();
            Assert.NotNull(t.Title);

        }
    }
}
