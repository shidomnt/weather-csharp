using Weather.Classes;
using Weather.Exceptions;

namespace Weather.Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            try
            {
                AppConfiguration.InitAsync().Wait();
                var controller = new WeatherController();
                var formWeather = new FormWeather(controller);
                Application.Run(formWeather);
            }
            catch (ApiKeyNotFoundException)
            {
                AppConfiguration.Remove();
            }
            catch (BaseApiUrlNotFoundException)
            {
                AppConfiguration.Remove();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                        ex.Message,
                        ex.GetType().Name,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            finally
            {
                Application.Exit();
            }
        }

        public static void Restart()
        {
            Application.Restart();
        }
    }
}