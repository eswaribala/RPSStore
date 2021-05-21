using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RPSStore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RPSStore.Services
{
    public class APIAccess
    {
        private HttpClient httpClient;
        private WebClient webClient;
        public ObservableCollection<Photo> Photos { get; set; }
        public int ProgressValue { get; set; }
        private String WebUrl { get; set; }
        private DateTime BeforeAccess { get; set; }
        private DateTime AfterAccess { get; set; }
        public long InternetSpeed { get; set; }
        public long KBData { get; set; }


        public APIAccess()
        {
            this.httpClient = new HttpClient();
            

        }

        public async Task<ObservableCollection<Photo>> GetPhotos()
        {
            using (webClient = new WebClient())
            {
                WebUrl = "https://jsonplaceholder.typicode.com/photos";
                var uri = new Uri(WebUrl);
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                try
                {
                    BeforeAccess = DateTime.Now;
                    webClient.DownloadDataAsync(uri);
                    var response = await httpClient.GetAsync(uri);
                    byte[] Data = await httpClient.GetByteArrayAsync(uri);
                    AfterAccess = DateTime.Now;
                    //calculate the speed in kb
                    KBData = Data.Length / 1024;
                    Console.WriteLine("Data in KB" + KBData);
                    var ElapsedTime = (AfterAccess - BeforeAccess).TotalSeconds;
                    Console.WriteLine("Elapsed Time" + ElapsedTime);
                    InternetSpeed = Convert.ToInt64((KBData / ElapsedTime));
                    var content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(content);
                    // JObject jObject = JObject.Parse(content);
                    Photos = JsonConvert.DeserializeObject<ObservableCollection<Photo>>(content);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } 
            return Photos;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
           ProgressValue=  e.ProgressPercentage;
            Console.WriteLine("Progress Value" + ProgressValue); 
        }
    }
}
