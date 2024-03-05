namespace DataTriggerTest
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel _viewModel;

        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            _viewModel = mainViewModel;
            BindingContext = _viewModel;
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            _viewModel.IsPortrait = height > width;
        }
    }
}
