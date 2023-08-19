using System;
using System.Net.Http;
using System.Threading.Tasks;

class Sample{
    static async Task Main(){
        await GetDataAsync();
    }

    static async Task GetDataAsync(){
        using(HttpClient client = new HttpClient()){
            string url = "https://jsonplaceholder.typicode.com/posts/1";
            HttpResponseMessage responseMessage = await client.GetAsync(url);

            if(responseMessage.IsSuccessStatusCode){
                string content = await responseMessage.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }else{
                Console.WriteLine("Error: Unable to retriece data");
            }
        }
    }
}