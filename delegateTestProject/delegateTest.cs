using Program;
using System.Reflection.PortableExecutable;
using static Program.displayClass;

namespace delegateTestProject
{
    public class delegateTest
    {
        ConsoleReader reader = new ConsoleReader();
        [Fact]
        public void test_for_alphabet_string()
        {
            Assert.Equal("Inside onWord", reader.onWord());
        }

        [Fact]
        public void test_for_number_string()
        {
            Assert.Equal("Inside onNumber", reader.onNumber());
        }

        [Fact]
        public void test_for_junk_string()
        {
            Assert.Equal("Inside onJunk", reader.onJunk());
        }

        [Fact]
        public void test_for_alphanumeric_string()
        {
            Assert.Equal("Inside onWord", reader.onWord());
        }

    }
}