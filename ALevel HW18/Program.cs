using ALevel_HW18;

internal class Program
{
    internal static async Task Main(string[] a1rgs)
    {
        await ReqresApi.ReqresGetExampleAsync();

        await ReqresApi.ReqresGetTwoExampleAsync();

        await ReqresApi.ReqresGetThreeExampleAsync();

        await ReqresApi.ReqresGetFourExampleAsync();

        await ReqresApi.ReqresGetFiveExampleAsync();

        await ReqresApi.ReqresGetSixExampleAsync();

        await ReqresApi.ReqresPostExampleAsync();

        await ReqresApi.ReqresPutExampleAsync();

        await ReqresApi.ReqresPatchExampleAsync();

        await ReqresApi.ReqresDeleteExampleAsync();

        await ReqresApi.ReqresPostRegExampleAsync();

        await ReqresApi.ReqresPostUnRegExampleAsync();

        await ReqresApi.ReqresPostLoginExampleAsync();

        await ReqresApi.ReqresPostUnLoginExampleAsync();

        await ReqresApi.ReqresGetSevenExampleAsync();
    }
}