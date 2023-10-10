using ECommerce_Mark1.Business.Core.Models.Configuration;

namespace ECommerce_Mark1.Infrastructure
{
    public class DBConnection:Connection
    {
        #region Overrides of Connection

        public override string ToString(string delimiter = ";")
        {
            return $"Data Source={Datasource}; Database={Database}; User Id={UserId}; Password={Password}; {AdditionalParameters}";
        }

        #endregion
    }
}
