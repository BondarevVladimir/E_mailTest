using NUnit.Framework;
using OpenQA.Selenium;

namespace E_mailTest
{
    public class Tests
    {
        private IWebDriver driver;// ����������

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();//��������� Chrome
            driver.Navigate().GoToUrl("https://ya.ru/"); // ��������� ����, �����-Navigate()
            //driver.Manage().Window.Maximize();//����� ��������� ������� � ������������� ������
        }

        [Test]
        public void Test1()
        {
            IWebElement elementButtonEnterInE_mail = driver.FindElement(By.XPath("//div[@class='b-inline']"));// ���������� � ������ "����� � �����"
            elementButtonEnterInE_mail.Click(); //�������� ������ "����� � �����"

            IWebElement elementButtonEnter = driver.FindElement(By.XPath("//a[@class ='control button2 button2_view_classic button2_size_mail-big button2_theme_mail-white button2_type_link HeadBanner-Button HeadBanner-Button-Enter with-shadow']"));// ���������� � ������ "�����"
            elementButtonEnter.Click(); //�������� ������ "�����"

            IWebElement elementEmail = driver.FindElement(By.Id("passp-field-login"));// ���������� � ���� ������� ��� �����
            elementEmail.SendKeys("volodiyb"); //������ ����� e-mail

            IWebElement elementButtonEnterE_mail = driver.FindElement(By.XPath("//div[@class='passp-button passp-sign-in-button']"));// ���������� � ������ "�����"
            elementButtonEnterE_mail.Click(); //�������� ������ "�����"



            //IWebElement elementPassword = driver.FindElement(By.Id("passp-field-passwd"));// ���������� � ���� ������
            //elementPassword.SendKeys("fdsfds"); //������ ������


            //IWebElement elementEye = driver.FindElement(By.XPath("//button[@class='Textinput-Icon Textinput-Icon_side_right Password-toggler Password-toggler_view_big-input']/.."));// ���������� � ������ ������
            //elementEye.Click(); //�������� ������ "������"


            //IWebElement elementButtonEnterE_mail = driver.FindElement(By.XPath("//div[@class='passp-button passp-sign-in-button']"));// ���������� � ������ "�����"
            //elementButtonEnterE_mail.Click(); //�������� ������ "�����"


            //gdgdf
            //234234234cf
            //45

        }
    }
}