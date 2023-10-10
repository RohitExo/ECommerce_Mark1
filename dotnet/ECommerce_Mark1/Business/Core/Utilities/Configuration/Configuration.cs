namespace ECommerce_Mark1.Business.Core.Utilities.Configuration
{
    public static class Configuration
    {
        #region Properties

        private static IConfigurationBuilder _builder;
        private static IConfigurationRoot _configurationRoot;
        private static string _connectionString;
        private static string _readableConnectionString;

        public static IConfigurationBuilder Builder
        {
            get
            {
                if(_builder == null)
                {
                    _builder = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                        .AddEnvironmentVariables();
                }
                return _builder;
            }
        }

        #endregion Properties

        #region Public Methods

        public static IConfigurationRoot GetConfiguration() => _configurationRoot ?? (_configurationRoot = Builder.Build());

        public static string GetConnectionString(string name  = "ECommerce")
        {
            if (!string.IsNullOrWhiteSpace(_connectionString))
            {
                return _connectionString;
            }

            return GetConfiguration().GetConnectionString(name);
        }

        #endregion Public Methods

    }
}
