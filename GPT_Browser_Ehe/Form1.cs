using Microsoft.Web.WebView2.Core;
using System;
using System.Windows.Forms;

namespace GPT_Browser_Ehe
{
    public partial class ChatGPT : Form
    {
        private string urlText = "https://chatgpt.com";
        public ChatGPT()
        {
            InitializeComponent();
            InitializeBrowser();
        }

        private async void InitializeBrowser()
        {
            await webView2.EnsureCoreWebView2Async(null);
            webView2.Source = new Uri(urlText);
        }

        private void webView2_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            if (e.Uri != urlText)
            {
                e.Cancel = true;
            }
        }
    }
}
// Bu yazılım, kişisel ve ticari olmayan projelerde özgürce kullanılabilir, değiştirilebilir ve dağıtılabilir. Ancak, bu yazılımın ticari olarak kullanılması, dağıtılması veya satış amaçlı türevlerinin oluşturulması durumunda, izin almak için [myusufaksu2001@hotmail.com] ile iletişime geçilmelidir.