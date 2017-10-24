using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Pomelo.Data.MySql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        public static IConfigurationRoot Configuration { get; set; }

        static void Main(string[] args)
        {
            //TestDateTimeJson();
            TestHttpModule();
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

            string connStr = Configuration["settings:MySqlConnString"];
            string queryStr = Configuration["settings:QueryString"];
            //var settings = Configuration.GetSection("settings");
            int count = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine($"Count:{++count}");
                    Console.WriteLine($"ConnString:{connStr}");
                    Console.WriteLine($"QueryString:{queryStr}");
                    using (var conn = new MySqlConnection(connStr))
                    {
                        conn.Open();
                        using (var cmd = new MySqlCommand(queryStr, conn))
                        {
                            var dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                            while (dr.Read())
                            {
                                for (int i = 0; i < dr.FieldCount; i++)
                                {
                                    Console.Write(dr.GetName(i) + ":" + dr.GetValue(i) + " | ");
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error-Message:{ex.Message}{Environment.NewLine}Error-StackTrace:{ex.StackTrace}");
                }
                finally
                {
                    Console.WriteLine($"{Environment.NewLine}****************************************************************************{Environment.NewLine}");
                }
                var c = Console.ReadKey();
                if (c.KeyChar == '\r')
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }

        private static void TestDateTimeJson()
        {
            var today = new DateTimeToJson { Today = DateTime.Now };
            var ts = JsonConvert.SerializeObject(today);
            var ttday = JsonConvert.DeserializeObject<DateTimeToJson>(ts);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 测试通过HttpClient请求webapi接口
        /// </summary>
        private static void TestHttpModule()
        {
            IList<AutoAnlysis> jsonList = new List<AutoAnlysis>();
            for (int i = 0; i < 100000; i++)
            {
                jsonList.Add(new AutoAnlysis
                {
                    id = i,
                    bigType = "LH",
                    smaType = "自动",
                    cellName = "test-" + i,
                    dateTime = DateTime.Now.ToString("yyyy-MM-dd"),
                    result = "",
                    suggest = ""
                });
            }
            HttpClient httpClient = new HttpClient();
            //HttpContent postContent = new FormUrlEncodedContent(new Dictionary<string, string>()
            //   {
            //      {"jsonString", JsonConvert.SerializeObject(jsonList)}
            //   });
            HttpContent postContent1 = new StringContent(JsonConvert.SerializeObject(jsonList), Encoding.UTF8, "text/json");
            // 创建一个异步GET请求，当请求返回时继续处理
            httpClient.PostAsync("http://localhost:4595/api/CellIssueInformation/GetCellIssueInformationAsync", postContent1).ContinueWith(
                (requestTask) =>
                {
                    HttpResponseMessage response = requestTask.Result;
                    // 确认响应成功，否则抛出异常
                    response.EnsureSuccessStatusCode();
                    // 异步读取响应为字符串
                    response.Content.ReadAsStringAsync().ContinueWith(
                         (readTask) => Console.WriteLine(readTask.Result));
                });
            Console.WriteLine("Hit enter to exit...");
            Console.ReadLine();
            throw new NotImplementedException();
        }
    }
    class DateTimeToJson
    {
        public DateTime Today { get; set; }
    }

    public class AutoAnlysis
    {
        public long id { get; set; }
        public string bigType { get; set; }
        public string smaType { get; set; }
        public string cellName { get; set; }
        public string dateTime { get; set; }
        public string result { get; set; }
        public string suggest { get; set; }

    }
}
