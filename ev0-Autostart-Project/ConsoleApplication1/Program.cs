using System.Diagnostics;
using System.Threading;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var steam = Process.GetProcessesByName("Steam");
            if (steam.Length == 0)
            {
            }
            else
            {
                Process.Start("cmd", "/C taskkill /F /IM Steam.exe /T");
            }

            var csgo = Process.GetProcessesByName("csgo");
            if (csgo.Length == 0)
            {
            }
            else
            {
                Process.Start("cmd", "/C taskkill /F /IM csgo.exe /T");
            }

            Thread.Sleep(2000);

            Process.Start("cmd", "/C start ev0.exe");

            Thread.Sleep(1000);

            var application1 = Application.Attach("ev0");
            var window1 = application1.GetWindow("", InitializeOption.NoCache);

            var Login = window1.Get<Button>("Login");
            Login.Click();

            Thread.Sleep(2000);

            var application = Application.Attach("ev0");
            var window = application.GetWindow("", InitializeOption.NoCache);

            var Load = window.Get<Button>("Load");
            Load.Click();

            Process.Start("cmd", "/C start steam://rungameid/730");

            var modalWindow = window.ModalWindow("");
            var OK = modalWindow.Get<Button>(SearchCriteria.ByText("OK"));
            OK.Click();
        }
    }
}