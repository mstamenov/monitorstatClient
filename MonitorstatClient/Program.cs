using MonitorstatTest.MonitorstatService;
using System;
using System.Linq;

namespace Monitorstat.Client.App
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int yearOfInterest = 2022;

            MonitorstatServiceClient monitorstatService = new MonitorstatServiceClient();
            monitorstatService.ClientCredentials.UserName.UserName = "";
            monitorstatService.ClientCredentials.UserName.Password = "";

            // Test certificate may be invalid
            System.Net.ServicePointManager.ServerCertificateValidationCallback += (se, cert, chain, sslError) => true;

            var surveys = monitorstatService.GetSurveys(
                new GetSurveysRequest
                {
                    Language = Language.Bg,
                    Year = yearOfInterest,
                });

            surveys
                .ToList()
                .ForEach(s => Console.WriteLine(s.Key + " -> " + s.Value));

            // Get some survey, year 2022 has 10 surveys in NSI test environment
            var currentSurvey = surveys
                .Skip(3)
                .First();

            Console.WriteLine(Environment.NewLine);
            var currentSurveyReports = monitorstatService.GetReports(
                new GetReportsRequest
                {
                    Year = yearOfInterest,
                    Language = Language.Bg,
                    SurveyIdentifier = currentSurvey.Key,
                });

            currentSurveyReports
                .ToList()
                .ForEach(r => Console.WriteLine(r.Key + " -> " + r.Value));

            monitorstatService.Close();
            Console.ReadLine();
        }
    }
}
