using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Repository
{
    public class RuleRepository : IRuleRepository
    {

        private readonly IOptions<List<RuleItem>> _settings;
        public RuleRepository(IOptions<List<RuleItem>> settings)
        {
            _settings = settings;
        }

        public string GetRuleByPaymentType(int id)
        {
            var found = _settings.Value.Find(t => t.Id == id);
            if (found == null)
            {
                return null;
            }
            string rule = found.Rule;
            if (found.IsCommission || found.IsEmail)
            {
                rule += "and " + found.Message;
            }
            return rule;
        }

        public List<RuleItem> GetRules()
        {
            return _settings.Value;
        }
    }
}
