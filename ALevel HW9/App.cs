namespace ALevel_HW9
{
    public class App
    {
        public static void Run()
        {
            Random random = new Random();

            for (int counter = 0; counter < 100; counter++)
            {
                int randomAction = random.Next(1, 4);

                try
                {
                    switch (randomAction)
                    {
                        case 1:
                            Actions.StartMethod();
                            break;
                        case 2:
                            Actions.ThrowBusinessException();
                            break;
                        case 3:
                            Actions.ThrowException();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log("Error", $"Action failed by reason: {ex}");
                }
            }
        }
    }
}
