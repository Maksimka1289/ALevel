namespace ALevel_HW9
{
    public class Actions
    {
        public static void StartMethod()
        {
            Logger.Log("Info", "Start method: StartMethod");
        }

        public static void ThrowBusinessException()
        {
            try
            {
                throw new BusinessException("Skipped logic in method");
            }
            catch (BusinessException ex)
            {
                Logger.Log("Warning", $"Action got this custom Exception: {ex.Message}");
            }
        }

        public static void ThrowException()
        {
            try
            {
                throw new Exception("I broke a logic");
            }
            catch (Exception ex)
            {
                Logger.Log("Error", $"Action failed by reason: {ex}");
            }
        }
    }
}

