using Tyuiu.GluhovaUA.Sprint0.Task6.V0.Lib;

using Tyuiu.GluhovaUA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.GluhovaUA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckedSubtractionValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.Subtraction(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.Multiplication(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckedDivisionValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.Division(numbers);
            Assert.AreEqual(15, res);
        }
    }
}
