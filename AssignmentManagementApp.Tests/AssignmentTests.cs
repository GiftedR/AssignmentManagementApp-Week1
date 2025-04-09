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
            Assignment t = new Assignment
            {
                Title = "Testing Assignment"
            };
            Assert.NotNull(t.Title);
        }
    }
}
