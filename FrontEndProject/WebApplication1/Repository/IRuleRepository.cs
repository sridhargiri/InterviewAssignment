using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Repository
{
    public interface IRuleRepository
    {
        List<RuleItem> GetRules();
        string GetRuleByPaymentType(int id);
    }
}
