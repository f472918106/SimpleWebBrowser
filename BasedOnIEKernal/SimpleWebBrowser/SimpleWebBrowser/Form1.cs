using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1(string url)
        {
            InitializeComponent();
            if(url==string.Empty)
            {
                this.webBrowser1.Navigate("http://www.cnblogs.com");
                AddressFiled.Text = "http://www.cnblogs.com";
                this.AddItem_AddressFiled();
                this.AddItem_SearchFiled();
            }
            else
            {
                this.webBrowser1.Navigate(url);
            }
        }

        private void AddItem_AddressFiled()
        {
            int AddressIndex = AddressFiled.FindStringExact(AddressFiled.Text);
            if(AddressIndex<0)
            {
                AddressFiled.Items.Add(AddressFiled.Text);
            }
        }

        private void AddItem_SearchFiled()
        {
            int SearchIndex = SearchFiled.FindStringExact(SearchFiled.Text);
            if(SearchIndex<0)
            {
                SearchFiled.Items.Add(SearchFiled.Text);
            }
        }

        private void PageSave_Click(object sender, EventArgs e)
        {
            WebBrowser CurrentWebBrowser = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            CurrentWebBrowser.ShowSaveAsDialog();
        }

        private void PageExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PageBack_Click(object sender, EventArgs e)
        {
            WebBrowser CurrentWebBrowser = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            CurrentWebBrowser.GoBack();
        }

        private void PageForward_Click(object sender, EventArgs e)
        {
            WebBrowser CurrentWebBrowser = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            CurrentWebBrowser.GoForward();
        }

        private void PageHome_Click(object sender, EventArgs e)
        {
            WebBrowser CurrentWebBrowser = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            CurrentWebBrowser.GoHome();
        }

        private void PageRefresh_Click(object sender, EventArgs e)
        {
            WebBrowser CurrentWebBrowser = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            CurrentWebBrowser.Refresh();
        }


        private void GB2312Code_Click(object sender, EventArgs e)
        {

        }

        private void UTF8Code_Click(object sender, EventArgs e)
        {

        }

        private void PageAbout_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            WebBrowser CurrentWebBrowser = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            switch (toolStrip1.Items.IndexOf(e.ClickedItem))
            {
                case 0:
                    PageSave.PerformClick();
                    break;
                case 1:
                    PageBack.PerformClick();
                    break;
                case 2:
                    PageForward.PerformClick();
                    break;
                case 3:
                    PageRefresh.PerformClick();
                    break;
                case 4:
                    PageHome.PerformClick();
                    break;
                case 6:
                    CurrentWebBrowser.Navigate(AddressFiled.Text);
                    AddItem_AddressFiled();
                    break;
                case 8:
                    break;
                default:
                    PageStatus.Text = "正在打开网页" + AddressFiled.Text+"...";
                    CurrentWebBrowser.Navigate(AddressFiled.Text);
                    AddItem_AddressFiled();
                    break;
            }
        }
    }
}
