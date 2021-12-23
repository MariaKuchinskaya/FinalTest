namespace Task4
{
    class SomeClass
    {
        public delegate void SomeMethodHandler(string message);
        public event SomeMethodHandler Notify;

        public SomeClass()
        {
            Counter = 0;
        }

        public int Counter { get; private set; }

        public void SomePublicMethod()
        {
            Counter++;

            if (Counter == 10)
            {
                Notify?.Invoke($"Метод был запущен 10 раз");
                Counter = 0;
            }
        }
    }
}
