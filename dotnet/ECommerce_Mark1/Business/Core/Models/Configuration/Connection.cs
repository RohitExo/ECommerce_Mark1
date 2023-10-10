using ECommerce_Mark1.Business.Core.Interfaces.Data;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ECommerce_Mark1.Business.Core.Models.Configuration
{
    public class Connection : IConnection
    {
        #region Properties
        public string AdditionalParameters { get; set; }
        public string Database             { get; set; }
        public string Datasource           { get; set; }
        public string Password             { get; set; }
        public string UserId               { get; set; }

        #endregion Properties

        #region Public Methods
        public virtual string ToString(string delimiter = ";")
        {
            var results = new List<string>
            {
                Datasource,
                Database,
                Password,
                UserId,
                AdditionalParameters
            };
            //string joinString = string.Join(delimiter, results).Where(ValidParameter);
            return results.Where(ValidParameter).Join(delimiter);
        }

        #endregion Public Methods

        #region Protected Methods

        protected bool ValidParameter(string value)
        {
            return !string.IsNullOrEmpty(value);
        }
          
        #endregion Protected Methods
    }
}
