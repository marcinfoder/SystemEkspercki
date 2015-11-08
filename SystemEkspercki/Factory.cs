namespace SystemEkspercki
{
    /// <summary>
    /// Factory
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// Creates main window
        /// </summary>
        /// <returns>Main window</returns>
        public static MainWindow GetMainWindow()
        {
            IDataAccessLayer dataAccessLayer = new DataAccessLayer();
            IMapper mapper = new Mapper();
            IDataProvider dataProvider = new DataProvider(dataAccessLayer, mapper);
            IInferenceLogger inferenceLogger = new InferenceLogger();
            IInferenceModule inferenceModule = new InferenceModule(dataProvider, inferenceLogger);
            IPresenter presenter = new Presenter(inferenceModule, dataAccessLayer);

            MainWindow mainWindow = new MainWindow(presenter);
            return mainWindow;
        }
    }
}