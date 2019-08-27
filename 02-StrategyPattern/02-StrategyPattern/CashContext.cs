using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StrategyPattern
{
    class CashContext
    {
        private CashSuper cs;
        public CashContext(string cashType)
        {
            //CashSuper csuper
            //this.cs = csuper;
            switch (cashType)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "打八折":
                    cs = new CashRebate("0.8");
                    break;
                case "打七折":
                    cs = new CashRebate("0.7");
                    break;
                case "打五折":
                    cs = new CashRebate("0.5");
                    break;
                case "满300减100":
                    cs = new CashReturn("300", "100");
                    break;
            }
        }
        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
}
