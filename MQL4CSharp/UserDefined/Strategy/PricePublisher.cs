using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using MQL4CSharp.Base;
using MQL4CSharp.Base.Common;
using MQL4CSharp.Base.Enums;
using MQL4CSharp.Base.MQL;

namespace MQL4CSharp.UserDefined.Strategy
{
    class PricePublisher: MQLExpert
    {
        public static readonly ILog LOG = LogManager.GetLogger(typeof(PricePublisher));
        public PricePublisher(long ix) : base(ix)
        {
            LOG.Info("Price publisher Ctor = " + ix);
        }

        public override void OnInit()
        {
            LOG.Info("Price publisher Init.");
        }

        public override void OnDeinit()
        {
            LOG.Info("Price publisher DeInit");
        }

        public override void OnTick()
        {
            LOG.Info("Price publisher Tick");
        }

        public override void OnTimer()
        {
            LOG.Info("Price publisher Timer");
        }
    }
}
