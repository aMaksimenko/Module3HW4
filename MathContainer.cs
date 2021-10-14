namespace HomeWork
{
    public class MathContainer
    {
        private const int Limit = 200;
        private int _counter;

        public MathContainer()
        {
            _counter = 1;
        }

        public event MathMethods.SumDelegate CounterIsTooBig;

        public void Multiply(int multiplier)
        {
            _counter *= multiplier;
            if (_counter > Limit)
            {
                CounterIsTooBig?.Invoke(_counter / 5, _counter % 7);
            }
        }
    }
}