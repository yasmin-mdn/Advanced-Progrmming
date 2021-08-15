using System.Collections.Generic;
using System.Linq;
using LambdaDelegateDemo;
using NUnit.Framework;

namespace LambdaDemo.Tests
{
    public class Tests
    {
        private IToolBox _toolBox;
        private ICalculator _calculator;

        private List<int> _vector1;
        private List<int> _vector1Exp;
        
        private List<List<int>> _matrix1;
        private List<int> _matrix1OddsVector;
        private int _matrix1OddsVectorExpSum;

        [SetUp]
        public void Setup()
        {
            _toolBox = new MyToolBox();
            _calculator = new Calculator(_toolBox);

            _vector1 = new[] {5, 1, 0, -1, 4}.ToList();
            _vector1Exp = new[] {148, 2, 1, 0, 54}.ToList();
            
            _matrix1 = new[]
            {
                new[] { 1, 5, 8 }.ToList(),
                new[] { -3, 10, 2 }.ToList(),
                new[] { 9, -6, 0 }.ToList(),
            }.ToList();

            _matrix1OddsVector = new[] {1, 5, 9}.ToList();
            _matrix1OddsVectorExpSum = 8253;
        }
        
        [Test]
        public void GetExpVectorTest()
        {
            var exp = _calculator.Exp(_vector1);
            Assert.That(exp, Is.EquivalentTo(_vector1Exp));
        }

        [Test]
        public void GetOddNumbersFromMatrixTest()
        {
            var odds = _calculator.GetOdds(_matrix1);
            Assert.That(odds, Is.EquivalentTo(_matrix1OddsVector));
        }

        [Test]
        public void GetSumOfExpOfOddNumbersOfMatrixTest()
        {
            var sum = _calculator.SumOfExpOdds(_matrix1);
            Assert.AreEqual(_matrix1OddsVectorExpSum, sum);
        }
        [Test]
        public void MapTest(){
            
        }
    }
}