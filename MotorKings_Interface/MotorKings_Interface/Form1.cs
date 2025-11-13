using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
namespace MotorKings_Interface;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
            WebRequest request = WebRequest.Create("https://www.cbr-xml-daily.ru/daily_json.js");
            WebResponse response = request.GetResponse();
            
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                string responseText = reader.ReadToEnd();
                JObject rates = JObject.Parse(responseText);
                JObject valutes = (JObject)rates["Valute"];
                
                foreach (var valute in valutes.Properties())
                {
                    JToken v = valute.Value;
                    listBox1.Items.Add($"{v["CharCode"]}: {v["Value"]} руб.");
                }
            }
    }
    
}