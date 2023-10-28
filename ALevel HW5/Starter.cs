using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_HW5
{
    public class Starter
    {
        public void Run()
        {
            Actions actions = new Actions();
            Logger logger = Logger.Instance;

            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int randomNumber = random.Next(1, 4);
                Result result;
                switch (randomNumber)
                {
                    case 1:
                        result = actions.Method1();
                        if (!result.Status)
                        {
                            logger.Log("Error", "Action failed by a reason: " + result.ErrorMessage);
                        }
                        break;
                    case 2:
                        result = actions.Method2();
                        if (!result.Status)
                        {
                            logger.Log("Error", "Action failed by a reason: " + result.ErrorMessage);
                        }
                        break;
                    case 3:
                        result = actions.Method3();
                        if (!result.Status)
                        {
                            logger.Log("Error", "Action failed by a reason: " + result.ErrorMessage);
                        }
                        break;
                }
            }

            string logContent = logger.GetLogs();
            File.WriteAllText("log.txt", logContent);
        }
    }
}
