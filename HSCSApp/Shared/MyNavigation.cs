namespace HSCSApp.Shared
{
    public class MyNavigation
    {
        private string _display;

        public string Display
        {
            get { return _display; }
            set { _display = value; }
        }

        public string GetDisplay()
        {
            return _display;
        }
    }
}