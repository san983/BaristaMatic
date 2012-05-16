using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BaristaMatic.Specflow.Steps
{
    [Binding]
    public class InventoryAndMenuDisplaySteps
    {
        [Then("the console output should read like this")]
        public void ThenTheConsoleOutputShouldBe(Table table)
        {
            var stringWriter = new StringWriter();
            
            System.Console.SetOut(stringWriter);
            Console.Program.Main();

            var expected = ParseInventoryTable(table);
            Assert.AreEqual(expected, stringWriter.ToString());
        }

        private static string ParseInventoryTable(Table table)
        {
            return table.Rows.Select(row => row["OutputLine"]).Aggregate("", (current, line) => current + line + Environment.NewLine).Replace("_"," ");
        }
    }
}
