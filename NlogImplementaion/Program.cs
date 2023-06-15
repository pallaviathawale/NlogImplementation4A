using NLog;

namespace NlogImplementaion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            try
            {
                logger.Info("Program started.");

                // Your program logic here

                logger.Info("Program completed successfully.");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "An error occurred in the program.");
            }
            finally
            {
                LogManager.Shutdown();
            }

            Console.ReadLine();
        }
    }
    
}