using System.Reflection;

namespace WindowsTabbedPageIcons
{
    public partial class MainPage : TabbedPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            var assembly = Assembly.GetExecutingAssembly();
            Stream? stream = assembly.GetManifestResourceStream($"WindowsTabbedPageIcons.Resources.Images.dotnet_bot_embedded.png");
            ImageSource = ImageSource.FromStream(() => stream);
        }

        private ImageSource _imageSource;
        public ImageSource ImageSource 
        {
            get => _imageSource;
            set
            {
                _imageSource = value;
                OnPropertyChanged(nameof(ImageSource));
            }
        }
    }

}
