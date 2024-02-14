using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void StringTest1()
        {
            Program program = new Program();
              Assert.Contains("no",program.RetNo());
        }

        [Fact]
        public void intTest1()
        {
            Program program = new Program();
            Assert.Equal(1, program.RetOne());
        }
    }
}