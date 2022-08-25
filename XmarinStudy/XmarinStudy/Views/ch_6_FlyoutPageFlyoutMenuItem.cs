using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmarinStudy.Views
{
    public class ch_6_FlyoutPageFlyoutMenuItem
    {
        public ch_6_FlyoutPageFlyoutMenuItem()
        {
            TargetType = typeof(ch_6_FlyoutPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}