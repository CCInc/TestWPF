namespace CCWpf
{
    public class UrlDummy : UnifiedViewModelBase
    {
        private string _url;
        public string Url
        {
            get { return _url; }
            set
            {
                _url = value;
                OnPropertyChanged("Url");
            }
        }

        private Browser _browser;
        public Browser Browser
        {
            get { return _browser; }
            set
            {
                _browser = value;
                OnPropertyChanged("Browser");
            }
        }
    }
}