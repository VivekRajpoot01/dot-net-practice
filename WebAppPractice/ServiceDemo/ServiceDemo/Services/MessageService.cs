namespace ServiceDemo.Services
{
    public class MessageService
    {
        public string GetMessage()
        {
            return "Hello from Message Service";
        }

        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
