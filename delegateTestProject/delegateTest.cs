using Program;
using System.Reflection.PortableExecutable;
using static Program.firstClass;
using Xunit;
using Moq;

namespace delegateTestProject
{
    public class delegateTest 
    {
        
       
        [Fact]
        public void test_for_alphabet_string()
        {
            string str = "ascsdf";
            ConsoleReader reader = new ConsoleReader();
            IconsoleReader display = new displayClass();
            //displayClass display = new displayClass();
            delegateConsoleReader dOnWord = new delegateConsoleReader(display.onWord);
            delegateConsoleReader dOnNumber = new delegateConsoleReader(display.onNumber);
            delegateConsoleReader dOnJunk = new delegateConsoleReader(display.onJunk);
            //Assert.Equal("Inside onWord", reader.run(str, dOnWord, dOnNumber, dOnJunk));

            reader.run(str, dOnWord, dOnNumber, dOnJunk);
            var mockCookieManager = new Mock<IconsoleReader>();
            mockCookieManager.Setup(m => m.onWord(It.IsAny<string>()) );
            mockCookieManager.Verify(m => m.onWord(It.IsAny<string>()), Times.AtLeastOnce());
        }

        //[Fact]
        //public void test_for_number_string()
        //{
        //    Assert.Equal("Inside onNumber", display.onNumber());
        //}

        //[Fact]
        //public void test_for_junk_string()
        //{
        //    Assert.Equal("Inside onJunk", display.onJunk());
        //}

        //[Fact]
        //public void test_for_alphanumeric_string()
        //{
        //    Assert.Equal("Inside onWord", display.onWord();
        //}

    }
}