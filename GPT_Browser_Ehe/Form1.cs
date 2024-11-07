using Microsoft.Web.WebView2.Core;
using System;
using System.Windows.Forms;

namespace GPT_Browser_Ehe
{
    public partial class ChatGPT : Form
    {
        public ChatGPT()
        {
            InitializeComponent();
            InitializeBrowser();
        }

        private async void InitializeBrowser()
        {
            await webView2.EnsureCoreWebView2Async(null);
            webView2.Source = new Uri("https://chatgpt.com");
        }

        private void webView2_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            if (e.Uri != "https://chatgpt.com")
            {
                e.Cancel = true;
            }
        }
    }
}
// Bu yazılım, kişisel ve ticari olmayan projelerde özgürce kullanılabilir, değiştirilebilir ve dağıtılabilir. Ancak, bu yazılımın ticari olarak kullanılması, dağıtılması veya satış amaçlı türevlerinin oluşturulması durumunda, izin almak için [myusufaksu2001@hotmail.com] ile iletişime geçilmelidir.