using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaDelegateDemo
{
    public class Calculator : ICalculator
    {
        private readonly IToolBox _toolBox;
        
        public Calculator(IToolBox toolBox)
        {
            _toolBox = toolBox;
        }
        
        public List<int> Exp(List<int> numbers)
        {
        return _toolBox.Map<int,int>(numbers, (x) => (int)Math.Exp(x)).ToList(); 
        }

        public List<int> GetOdds(List<List<int>> matrix)
        {
            IEnumerable<int> tmp = _toolBox.FlatMap<int, int>(matrix, (i) => i);
            return _toolBox.Filter<int>(tmp, (i) => i%2 == 0).ToList();
        }

        public int SumOfExpOdds(List<List<int>> matrix)
        {
            List<int> tmp = Exp(GetOdds(matrix));
            int total = 0;
            foreach(var v in tmp)
                total += v;
            return total;
        }
    }
}