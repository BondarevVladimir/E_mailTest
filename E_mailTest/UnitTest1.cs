using NUnit.Framework;
using OpenQA.Selenium;

namespace E_mailTest
{
    public class Tests
    {
        private IWebDriver driver;// переменная

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();//запускаем Chrome
            driver.Navigate().GoToUrl("https://ya.ru/"); // запускаем сайт, метод-Navigate()
            //driver.Manage().Window.Maximize();//метод открывает браузер в полноэкранном режиме
        }

        [Test]
        public void Test1()
        {
            IWebElement elementButtonEnterInE_mail = driver.FindElement(By.XPath("//div[@class='b-inline']"));// обращаемся к кнопке "Войти в почту"
            elementButtonEnterInE_mail.Click(); //нажимаем кнопку "Войти в почту"

            IWebElement elementButtonEnter = driver.FindElement(By.XPath("//a[@class ='control button2 button2_view_classic button2_size_mail-big button2_theme_mail-white button2_type_link HeadBanner-Button HeadBanner-Button-Enter with-shadow']"));// обращаемся к кнопке "Войти"
            elementButtonEnter.Click(); //нажимаем кнопку "Войти"

            IWebElement elementEmail = driver.FindElement(By.Id("passp-field-login"));// обращаемся к полю Телефон или почта
            elementEmail.SendKeys("volodiyb"); //вводим почту e-mail

            IWebElement elementButtonEnterE_mail = driver.FindElement(By.XPath("//div[@class='passp-button passp-sign-in-button']"));// обращаемся к кнопке "Войти"
            elementButtonEnterE_mail.Click(); //нажимаем кнопку "Войти"



            //IWebElement elementPassword = driver.FindElement(By.Id("passp-field-passwd"));// обращаемся к полю Пароль
            //elementPassword.SendKeys("fdsfds"); //вводим Пароль


            //IWebElement elementEye = driver.FindElement(By.XPath("//button[@class='Textinput-Icon Textinput-Icon_side_right Password-toggler Password-toggler_view_big-input']/.."));// обращаемся к кнопке Глазик
            //elementEye.Click(); //нажимаем кнопку "Глазик"


            //IWebElement elementButtonEnterE_mail = driver.FindElement(By.XPath("//div[@class='passp-button passp-sign-in-button']"));// обращаемся к кнопке "Войти"
            //elementButtonEnterE_mail.Click(); //нажимаем кнопку "Войти"


            //gdgdf
            //234234234cf
            //45

        }
    }
}