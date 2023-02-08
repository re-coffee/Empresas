using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApTask.Function
{
    public class SendMail : Base
    {
        public SendMail() { }
        public override void Go()
        {
            foreach(var task in TaskList.Where())
        }

    }
}
