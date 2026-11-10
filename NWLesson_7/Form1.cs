using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace NWLesson_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUkrNet_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            byte[] urlData = client.DownloadData("https://www.ukr.net");
            string page = Encoding.Default.GetString(urlData);
            textBox2.Text = page;
        }

        private async void btnHTTPClientRec_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpRequestMessage message = new HttpRequestMessage())
                {
                    message.Method = HttpMethod.Get;
                    message.RequestUri = new Uri("https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=5");
                    HttpResponseMessage resp = await client.SendAsync(message);
                    textBox1.AppendText($"Status code: {resp.StatusCode}" + Environment.NewLine);
                    textBox1.AppendText($"Headers:");
                    foreach (var header in resp.Headers)
                    {
                        textBox1.AppendText($"{header.Key}: {header.Value}" + Environment.NewLine);
                    }
                    string body = await resp.Content.ReadAsStringAsync();
                    textBox2.Text = body;
                    List<CurrencyItem> items = JsonSerializer.Deserialize<List<CurrencyItem>>(body);
                    listBox1.DataSource = null;
                    listBox1.DisplayMember = nameof(CurrencyItem.Description);
                    listBox1.DataSource = items;
                    //2
                    JArray arr = JArray.Parse(body);
                    foreach (var child in arr.Children<JObject>())
                    {
                        foreach (var property in child.Properties())
                        {
                            string name = property.Name;
                            string value = (string)property.Value;
                            textBox3.AppendText($"{name}: {value}" + Environment.NewLine);
                        }
                    }

                }
            }
        }

        private void btnWebClientRec_Click(object sender, EventArgs e)
        {
            string path = "https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=5";
            WebRequest request = WebRequest.Create(path);
            WebResponse response = request.GetResponse();
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                string line = "";
                while ((line = stream.ReadLine()) != null)
                {
                    textBox2.Text += line + "\n";
                }
                string mess = $"URL:{request.RequestUri}\t Method:{request.Method}\t Content-Type:{request.ContentType}\t Headers:";
                WebHeaderCollection whc = response.Headers;
                var headers = Enumerable.Range(0, whc.Count).Select(h =>
                {
                    return new
                    {
                        Key = whc.GetKey(h),
                        Names = whc.GetValues(h)
                    };
                });
                foreach (var header in headers)
                {
                    mess += $"\t{header}";
                }
                textBox1.Text = mess;
            }
            using (WebClient client = new WebClient())
            {
                string str_json = client.DownloadString(path);
                JArray arr = JArray.Parse(str_json);
                foreach (var child in arr.Children<JObject>())
                {
                    foreach (var property in child.Properties())
                    {
                        string name = property.Name;
                        string value = (string)property.Value;
                        textBox3.AppendText($"{name}: {value}" + Environment.NewLine);
                    }
                }
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            string path = "https://api.exmo.com/v1.1/trades/?pair=ETH_USD";
            using (WebClient client = new WebClient())
            {
                string str_json = client.DownloadString(path);
                JObject keyValues = JObject.Parse(str_json);
                textBox3.Text = keyValues.ToString();
                textBox1.AppendText(keyValues.GetValue("ETH_USD").ToString() + Environment.NewLine);
              
            }
        }
    }
}
