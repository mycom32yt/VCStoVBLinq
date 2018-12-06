using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqsortTest
{

    class Data
    {
        public int gakuseibangou;
        public string sei;
        public string name;

        public Data(int bangou, string isei, string iname)
        {
            gakuseibangou = bangou;
            sei = isei;
            name = iname;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var gakuseimeibo = new Data[] {
  new Data(14, "風浦", "可符香"),
  new Data(20, "小森", "霧"    ),
  new Data(22, "常月", "まとい"),
  new Data(19, "小節", "あびる"),
  new Data(18, "木村", "カエレ"),
  new Data(16, "音無", "芽留"  ),
  new Data(17, "木津", "千里"  ),
  new Data( 8, "関内", "マリア"),
  new Data(28, "日塔", "奈美"  ),
};

            var syussekibnagouname =
              from p in gakuseimeibo
              where p.gakuseibangou <= 15
              orderby p.gakuseibangou
              select p.name;

            foreach (var name in syussekibnagouname)
            {
                Console.Write("{0}\n", name);
            }
        }
    }
}
