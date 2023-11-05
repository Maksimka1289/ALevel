using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_HW5
{
    public class Actions
    {
        private Logger logger = Logger.Instance;

        public Result Method1()
        {
            logger.Log("Info", "Start method: Method1");
            return new Result { Status = true };
        }

        public Result Method2()
        {
            logger.Log("Warning", "Skipped logic in method: Method2");
            return new Result { Status = true };
        }

        public Result Method3()
        {
            logger.Log("Error", "I broke a logic");
            return new Result { Status = false, ErrorMessage = "I broke a logic" };
        }
    }
}
