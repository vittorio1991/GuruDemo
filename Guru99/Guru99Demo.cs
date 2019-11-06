using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Guru99
{
	class Guru99Demo
	{
		IWebDriver driver;
		IWebDriver m_driver;

		[SetUp]
		public void startBrowser()
		{
			driver = new ChromeDriver();
		}

		[Test]
		public void test()
		{
			driver.Url = "http://www.google.co.in";
		}

		[TearDown]
		public void closeBrowser()
		{
			driver.Close();
		}


		[Test]
		public void cssDemo_01()
		{
			m_driver = new ChromeDriver();
			m_driver.Url = "http://demo.guru99.com/test/guru99home/";
			m_driver.Manage().Window.Maximize();
			IWebElement link = m_driver.FindElement(By.XPath(".//*[@id='rt-header']//div[2]/div/ul/li[2]/a"));
			link.Click();
			m_driver.Close();
		}


		[Test]
		public void cssDemo_02()
		{
			m_driver = new ChromeDriver();
			m_driver.Url = "http://demo.guru99.com/test/guru99home/";
			m_driver.Manage().Window.Maximize();

			// Store locator values of email text box and sign up button				
			IWebElement emailTextBox = m_driver.FindElement(By.XPath(".//*[@id='philadelphia-field-email']"));
			IWebElement signUpButton = m_driver.FindElement(By.XPath(".//*[@id='philadelphia-field-submit']"));

			emailTextBox.SendKeys("test123@gmail.com");
			signUpButton.Click();
		}

		[Test]
		public void cssDemo_03()
		{
			m_driver = new ChromeDriver();
			m_driver.Url = "http://demo.guru99.com/test/guru99home/";
			m_driver.Manage().Window.Maximize();

			// Store locator values of email text box and sign up button				
			IWebElement emailTextBox = m_driver.FindElement(By.CssSelector("input[id=philadelphia-field-email]"));
			IWebElement signUpButton = m_driver.FindElement(By.CssSelector("input[id=philadelphia-field-submit]"));

			emailTextBox.SendKeys("test123@gmail.com");
			signUpButton.Click();
		}

		[Test]
		public void selectDemo()
		{
			m_driver = new ChromeDriver();
			m_driver.Url = "http://demo.guru99.com/test/guru99home/";
			m_driver.Manage().Window.Maximize();

			IWebElement course = m_driver.FindElement(By.XPath(".//*[@id='awf_field-91977689']"));

			var selectTest = new SelectElement(course);
			// Select a value from the dropdown				
			selectTest.SelectByValue("sap-abap");

		}











	}
}
