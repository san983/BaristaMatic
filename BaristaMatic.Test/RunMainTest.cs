using System;
using System.IO;
using NUnit.Framework;

namespace BaristaMatic.Test
{
    [TestFixture]
    public class RunMainTest
    {
        [Test]
        [Ignore]
        public void RunMain()
        {
            using (var stringWriter = new StringWriter())
            {
                System.Console.SetOut(stringWriter);

                Console.Program.Main();

                var expected = string.Format("{0}", Environment.NewLine);

                Assert.AreEqual(expected, stringWriter.ToString());    
            }
        }
    }
}
