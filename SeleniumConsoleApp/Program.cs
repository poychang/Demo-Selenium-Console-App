using OpenQA.Selenium.Chrome;

namespace SeleniumConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 前置作業
            // 1. 安裝套件
            //    * Selenium.WebDriver
            //    * Selenium.WebDriver.ChromeDriver
            // 2. 下載 Chrome Driver
            //    * http://chromedriver.chromium.org/downloads
            //    * 複製至專案資料夾內

            var chromeOptions = new ChromeOptions();
            //chromeOptions.AddArgument("--window-size=1300,1000"); // 控制 Chrome 視窗大小的參數

            using (var driver = new ChromeDriver("./", chromeOptions))
            {
                // 視窗最大化，要注意 RWD 的版面布局
                driver.Manage().Window.Maximize();

                // 開啟網頁
                driver.Url = "https://poychang.github.io/";

                // 移至 About 頁面
                //    * 使用 XPath 來定位頁面上的元素
                //    * 推薦在 Chrome 上使用 XPath Helper 擴充套件，快速取得元素的 XPath
                //      https://chrome.google.com/webstore/detail/xpath-helper/hgimnogjllphhhkhlmebbmlgjoejdpjl?hl=zh-TW
                driver.FindElementByXPath("/html/body/div[@class='col-sm-4 sidebar hidden-xs hidden-sm not-mobile']/div[@class='sidebar-content']/nav[@id='page-nav']/ul[@class='main-navigation list-unstyled list-inline']/li[1]/a").Click();

            }
        }
    }
}
