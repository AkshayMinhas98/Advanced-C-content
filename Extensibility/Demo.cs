namespace Extensibility
{
    public class Demo
    {
        private readonly Ilogger _logger;
        public Demo(Ilogger logger)
        {
            _logger = logger;
        }


        public void Display()
        {
            _logger.LogError("log error");
            _logger.LogInfo("log Info");
            
        }

    }
}
