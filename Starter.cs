namespace HomeWork
{
    public class Starter
    {
        public void Run()
        {
            var mathContainer = new MathContainer();
            var mathMethods = new MathMethods();

            mathContainer.CounterIsTooBig += mathMethods.SafeSum;
            mathContainer.CounterIsTooBig += mathMethods.SafeSum;

            mathContainer.Multiply(10);
            mathContainer.Multiply(10);
            mathContainer.Multiply(10);
            mathContainer.Multiply(10);
            mathContainer.Multiply(10);
            mathContainer.Multiply(10);
            mathContainer.Multiply(10);
            mathContainer.Multiply(10);
            mathContainer.Multiply(10);
        }
    }
}