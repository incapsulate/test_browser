using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skybound;
using Skybound.Gecko;
using Awesomium.Core;
using System.Net;
using System.IO;
//using Awesomium.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Awesomium.Core.JSValue x;
        private WebView webView;
        private WebBrowser browser = new WebBrowser();

        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        public void HElloMEs()
        {
            MessageBox.Show("asd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webControl1.Source = new Uri("C:\\Users\\asdfghj\\Desktop\\test_browser\\index.html");            //      Рабочий Код

            //timer1.Enabled = true;
            //x = webControl1.ExecuteJavascriptWithResult("alert(msg)");
            //label1.Text = x.ToString();
            //richTextBox1.Text = webControl1.IsDocumentReady.ToString();
            if (webControl1.IsDocumentReady)
            {
                //x = webControl1.ExecuteJavascriptWithResult("test();");
                //label1.Text = x.ToString();
                //x = webControl1.ExecuteJavascriptWithResult("ask_js");
                //we
                //richTextBox1.Text = x.ToString();
                //x = webControl1.ExecuteJavascriptWithResult("document.getElementById('response')");
                //label1.Text = x.ToString();
                //browser.Document.InvokeScript("HElloMEs", new String[] { "called from client code" });
            }
            
            //x = webControl1.ExecuteJavascriptWithResult("data.message", "100");
            //textBox1.Text = x.ToString();
              //x = webControl1.ExecuteJavascriptWithResult("channel");

            //webControl1.ExecuteJavascript("channel");
            
            //textBox1.Text = x.ToString();
            //richTextBox1.Text = webControl1.HTML;
            //WebRequest request = WebRequest.Create("http://app.pusherapp.com/apps/102936");
            //WebRequest request = WebRequest.Create("http://api.pusherapp.com/apps/102936/events?name=myevent&channel=test_channel&body_md5=8a3501faef6636ca9a5ebbe6f31b5409&auth_version=1.0&auth_key=838aaf1cb859e6951945&auth_timestamp=1421243531&auth_signature=bdeeb80fff229203e421c19a5bbafc2666dbdba72c85712ab3f4bd19638d5e3e");
        
            /*WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string res = reader.ReadToEnd();*/
            //textBox1.Text = res;
            //richTextBox1.Text = res;

            //WebView asd = new WebView();
            //webView.LoadFile("C:\\Users\\asdfghj\\Desktop\\test_browser\\index.html");
            //WebView wtf = new WebView(500,500);
            
            /*WebView wtf = WebCore.CreateWebView(500, 500);
            if (wtf.IsDocumentReady)
            {
                //wtf.LoadingFrameComplete += wtf.ExecuteJavascript;
                wtf.Source = new Uri("C:\\Users\\asdfghj\\Desktop\\test_browser\\index.html");
                //JSValue param1 = new JSValue("my_event");
                JSValue res = wtf.ExecuteJavascriptWithResult("my_event");
                richTextBox1.Text = res.ToString();
            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text = webControl1.IsDocumentReady.ToString();
            //x = webControl1.ExecuteJavascriptWithResult("test();");               //      Рабочий код
            //label1.Text = x.ToString();
            
            
            
            
            
            //richTextBox1.Text = webControl1.HTML;
            //label1.Text = x;
            //label1.Text = webControl1.ExecuteJavascriptWithResult("data.message", "100");
            //webControl1.
            //ResourceRequest pf = new ResourceRequest();
            //pf.
            //WebView webView;
            //timer1.Enabled = true;

            //webView.Source = new Uri("C:\\Users\\asdfghj\\Desktop\\test_browser\\index.html");

            
            

            /*webView.DocumentReady += WebViewOnDocumentReady;

            webView.Source = new Uri("C:\\Users\\asdfghj\\Desktop\\test_browser\\index.html");*/

        }

        
        /*private void WebViewOnDocumentReady(object sender, UrlEventArgs urlEventArgs)
        {
            webView.DocumentReady -= WebViewOnDocumentReady;

            JSObject jsobject = webView.CreateGlobalJavascriptObject("jsobject");

            //jsobject.Bind("callNETNoReturn", false, JSHandler);
            //jsobject.Bind("callNETWithReturn", true, JSHandler);
            jsobject.Bind();

            webView.ExecuteJavascript("myMethod()");
            webView.ExecuteJavascript("myMethodExpectingReturn()");
            var result = webView.ExecuteJavascriptWithResult("myMethodProvidingReturn('foo')");
            Console.WriteLine(result.ToString());
        }

        private void JSHandler(object sender, JavascriptMethodEventArgs args)
        {
            if (args.MustReturnValue)
            {
                Console.WriteLine("Got method call with return request");
                args.Result = "Returning " + args.Arguments[0];
            }
            else
            {
                Console.WriteLine("Got method call with no return request");
            }
        }*/

        private void Awesomium_Windows_Forms_WebControl_ShowCreatedWebView(object sender, ShowCreatedWebViewEventArgs e)
        {

        }

        private void Awesomium_Windows_Forms_WebControl_JavascriptRequest(object sender, JavascriptRequestEventArgs e)
        {

        }

        private void Awesomium_Windows_Forms_WebControl_DocumentReady(object sender, DocumentReadyEventArgs e)
        {
            //x = webControl1.ExecuteJavascriptWithResult("document.getElementById('response').textContent");
            //x = webControl1.ExecuteJavascriptWithResult("test();");
            //label1.Text = x.ToString();
            timer1.Enabled = true;
        }

        private void Awesomium_Windows_Forms_WebControl_JavascriptMessage(object sender, JavascriptMessageEventArgs e)
        {
            //x = webControl1.ExecuteJavascriptWithResult("alert(message)");
            //label1.Text = x.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //x = webControl1.ExecuteJavascriptWithResult("test();");
            //label1.Text = x.ToString();
            
            richTextBox1.Text = webControl1.IsDocumentReady.ToString();
            if (webControl1.IsDocumentReady)
            {

                x = webControl1.ExecuteJavascriptWithResult("test();");
                label1.Text = x.ToString();
            }
        }


       

    }
}
