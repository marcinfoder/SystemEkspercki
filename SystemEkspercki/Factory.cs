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
            IDataAccessLayer dataAccessLayer = new DataAccessLayerFake();
            IMapper mapper = new Mapper();
            IDataProvider dataProvider = new DataProvider(dataAccessLayer, mapper);
            IInferenceLogger inferenceLogger = new InferenceLogger();
            IInferenceModule inferenceModule = new InferenceModule(dataProvider, inferenceLogger);
            IPresenter presenter = new Presenter(inferenceModule);

            MainWindow mainWindow = new MainWindow(presenter);
            return mainWindow;
        }
    }
}
