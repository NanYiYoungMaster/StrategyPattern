using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StrategyPattern
{
    abstract class CashSuper
    {
        //算法接口
        public abstract double acceptCash(double money);
    }

    class CashNormal: CashSuper
    {
        //正常收费
        public override double acceptCash(double money)
        {
            return money;
        }
    }

    class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;
        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = Convert.ToDouble(moneyRebate);
        }
        //打折
        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }

    class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;
        public CashReturn(string moneyCondition,string moneyReturn)
        {
            this.moneyCondition = Convert.ToDouble(moneyCondition);
            this.moneyReturn = Convert.ToDouble(moneyReturn);
        }
        //返利
        public override double acceptCash(double money)
        {
            return money - (int)(money / moneyCondition) * moneyReturn;
        }
    }
}
