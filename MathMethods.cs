using System;
using System.Collections.Generic;

namespace HomeWork
{
    public class MathMethods
    {
        private int _sumCallCount;
        private List<int> _listResults;

        public MathMethods()
        {
            _listResults = new List<int>();
        }

        public delegate int SumDelegate(int val1, int val2);

        public int SafeSum(int val1, int val2)
        {
            return SafeDelegateCall(InternalSum, val1, val2);
        }

        private int InternalSum(int val1, int val2)
        {
            return val1 + val2;
        }

        private int SafeDelegateCall(SumDelegate sumDelegate, int val1, int val2)
        {
            try
            {
                var res = sumDelegate.Invoke(val1, val2);
                _sumCallCount++;
                _listResults.Add(res);
                return res;
            }
            catch (Exception e)
            {
                throw new AggregateException(e);
            }
        }
    }
}