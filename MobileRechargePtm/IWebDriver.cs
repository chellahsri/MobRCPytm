namespace MobileRechargePtm
{
    internal interface IWebDriver
    {
        object Navigate();
        object FindElement(object p);
        object Manage();
        void Close();
    }
}