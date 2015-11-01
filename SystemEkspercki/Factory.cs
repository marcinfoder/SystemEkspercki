namespace SystemEkspercki
{
    public static class Factory
    {
        public static MainWindow GetMainWindow()
        {
            IDataAccessLayer dataAccessLayer = new DataAccessLayerFake();
            IMapper mapper = new Mapper();
            IDataProvider dataProvider = new DataProvider(dataAccessLayer, mapper);
            IInferenceModule inferenceModule = new InferenceModule(dataProvider);
            IPresenter presenter = new Presenter(inferenceModule);

            MainWindow mainWindow = new MainWindow(presenter);
            return mainWindow;
        }
    }
}
