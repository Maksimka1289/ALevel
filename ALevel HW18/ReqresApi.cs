using Newtonsoft.Json;
using System.Net;
using System.Text;
using ALevel_HW18.Models;
using Newtonsoft.Json.Serialization;
using ALevel_HW18.Models.FirstGet;
using ALevel_HW18.Models.SecondGetResponse;

namespace ALevel_HW18;

internal static class ReqresApi
{
    private const string RequesURL = "https://reqres.in/";

    public static async Task ReqresGetExampleAsync()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        HttpResponseMessage result = await client.GetAsync("api/users?page=2"); // https://reqres.in/api/users?page=2

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("Ok Code from reqres site.");
            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            var pageRequest = JsonConvert.DeserializeObject<ReqresPageGetResponse>(content);

            if (pageRequest is not null)
            {
                Console.WriteLine(pageRequest.ToString());
            }
        }
    }
    public static async Task ReqresGetTwoExampleAsync()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        HttpResponseMessage result = await client.GetAsync("api/users/2"); // https://reqres.in/api/users/2

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("Ok Code from reqres site.");
            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            var pageRequest = JsonConvert.DeserializeObject<ReqresPageGetTwoRequest>(content);

            if (pageRequest is not null)
            {
                Console.WriteLine(pageRequest.ToString());
            }
        }
    }
    public static async Task ReqresGetThreeExampleAsync()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        HttpResponseMessage result = await client.GetAsync("api/users/23"); // https://reqres.in/api/users/23

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("Ok Code from reqres site.");
        }
        else
        {
           Console.WriteLine($"GetUser Response: {result.StatusCode}");
        }
    }
    public static async Task ReqresGetFourExampleAsync()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        HttpResponseMessage result = await client.GetAsync("/api/unknown"); // https://reqres.in/api/unknown

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("Ok Code from reqres site.");
            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            var pageRequest = JsonConvert.DeserializeObject<ReqresPageGetFourResponse>(content);

            if (pageRequest is not null)
            {
                Console.WriteLine(pageRequest.ToString());
            }
        }
    }
    public static async Task ReqresGetFiveExampleAsync()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        HttpResponseMessage result = await client.GetAsync("/api/unknown/2"); // https://reqres.in/api/unknown/2

        if(result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("Ok Code from reqres site.");
            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            var pageRequest = JsonConvert.DeserializeObject<ReqresPageGetTwoRequest>(content);

            if(pageRequest is not null)
            {
                Console.WriteLine(pageRequest.ToString());
            }
        }
    }
    public static async Task ReqresGetSixExampleAsync()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        HttpResponseMessage result = await client.GetAsync("api/unknown/23"); // https://reqres.in/api/unknown/23

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("Ok Code from reqres site.");
        }
        else
        {
            Console.WriteLine($"GetUser Response: {result.StatusCode}");
        }
    }
    public static async Task ReqresPostExampleAsync()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        var userParametersRequest = new CreateUserParametersRequest
        {
            Name = "Miksim",
            Job = "Teacher"
        };

        string serializedUser = JsonConvert.SerializeObject(userParametersRequest, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        });

        var stringContent = new StringContent(serializedUser, Encoding.Unicode, "application/json"); // application/json - required.

        HttpResponseMessage result = await client.PostAsync("api/users", stringContent);

        if (result.StatusCode == HttpStatusCode.Created)
        {
            Console.WriteLine("StatusCode Created");

            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            var userCreatedResponse = JsonConvert.DeserializeObject<UserCreatedResponse>(content);
            Console.WriteLine(userCreatedResponse!.Name);
        }
    }
    public static async Task ReqresPutExampleAsync()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        var userParametersRequest = new CreateUserParametersRequest
        {
            Name = "Miksim",
            Job = "Student"
        };

        string serializedUser = JsonConvert.SerializeObject(userParametersRequest, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        });

        var stringContent = new StringContent(serializedUser, Encoding.Unicode, "application/json"); // application/json - required.

        HttpResponseMessage result = await client.PutAsync("api/users/2", stringContent);

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("StatusCode Ok");

            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            var userCreatedResponse = JsonConvert.DeserializeObject<UserCreatedResponse>(content);
            Console.WriteLine(userCreatedResponse!.Name);
        }
    }
    public static async Task ReqresPatchExampleAsync()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        var userParametersRequest = new CreateUserParametersRequest
        {
            Name = "Miksim",
            Job = "Student"
        };

        string serializedUser = JsonConvert.SerializeObject(userParametersRequest, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        });

        var stringContent = new StringContent(serializedUser, Encoding.Unicode, "application/json"); // application/json - required.

        HttpResponseMessage result = await client.PatchAsync("api/users/2", stringContent);

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("StatusCode Ok");

            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            var userCreatedResponse = JsonConvert.DeserializeObject<UserCreatedResponse>(content);
            Console.WriteLine(userCreatedResponse!.Name);
        }
    }
    public static async Task ReqresDeleteExampleAsync()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        HttpResponseMessage result = await client.DeleteAsync("api/users/2");

        if (result.StatusCode == HttpStatusCode.NoContent)
        {
            Console.WriteLine("StatusCode Ok");
        }
    }
    public static async Task ReqresPostRegExampleAsync()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        var userParametersRequest = new RegisterAndLoginUserRequest
        {
            Email = "eve.holt@reqres.in",
            Password = "pistol"
        };

        string serializedUser = JsonConvert.SerializeObject(userParametersRequest, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        });

        var stringContent = new StringContent(serializedUser, Encoding.Unicode, "application/json"); // application/json - required.

        HttpResponseMessage result = await client.PostAsync("api/register", stringContent);

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("StatusCode Ok");

            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            var userCreatedResponse = JsonConvert.DeserializeObject<UserCreatedResponse>(content);
            Console.WriteLine(userCreatedResponse!.Name);
        }
    }
    public static async Task ReqresPostUnRegExampleAsync()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        var userParametersRequest = new RegisterAndLoginUserRequest
        {
            Email = "sydney@fife"
        };

        string serializedUser = JsonConvert.SerializeObject(userParametersRequest, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        });

        var stringContent = new StringContent(serializedUser, Encoding.Unicode, "application/json"); // application/json - required.

        HttpResponseMessage result = await client.PostAsync("api/register", stringContent);

        if (result.StatusCode == HttpStatusCode.BadRequest)
        {
            Console.WriteLine("StatusCode BadRequest");

            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            var userCreatedResponse = JsonConvert.DeserializeObject<UserCreatedResponse>(content);
            Console.WriteLine(userCreatedResponse!.Name);
        }
    }
    public static async Task ReqresPostLoginExampleAsync()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        var userParametersRequest = new RegisterAndLoginUserRequest
        {
            Email = "eve.holt@reqres.in",
            Password = "cityslicka"
        };

        string serializedUser = JsonConvert.SerializeObject(userParametersRequest, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        });

        var stringContent = new StringContent(serializedUser, Encoding.Unicode, "application/json"); // application/json - required.

        HttpResponseMessage result = await client.PostAsync("api/login", stringContent);

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("StatusCode Ok");

            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            var userCreatedResponse = JsonConvert.DeserializeObject<UserCreatedResponse>(content);
            Console.WriteLine(userCreatedResponse!.Name);
        }
    }
    public static async Task ReqresPostUnLoginExampleAsync()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        var userParametersRequest = new RegisterAndLoginUserRequest
        {
            Email = "eve.holt@reqres.in"
        };

        string serializedUser = JsonConvert.SerializeObject(userParametersRequest, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        });

        var stringContent = new StringContent(serializedUser, Encoding.Unicode, "application/json"); // application/json - required.

        HttpResponseMessage result = await client.PostAsync("api/login", stringContent);

        if (result.StatusCode == HttpStatusCode.BadRequest)
        {
            Console.WriteLine("StatusCode BadRequest");

            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            var userCreatedResponse = JsonConvert.DeserializeObject<UserCreatedResponse>(content);
            Console.WriteLine(userCreatedResponse!.Name);
        }
    }
    public static async Task ReqresGetSevenExampleAsync()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        HttpResponseMessage result = await client.GetAsync("api/users?delay=3"); // https://reqres.in/api/users?delay=3

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("Ok Code from reqres site.");
            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            var pageRequest = JsonConvert.DeserializeObject<ReqresPageGetResponse>(content);

            if (pageRequest is not null)
            {
                Console.WriteLine(pageRequest.ToString());
            }
        }
    }
}
