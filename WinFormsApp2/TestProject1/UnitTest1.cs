using NUnit.Framework;
namespace WinFormsApp2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int price = 1234;
            string message = task1.Logic.Mainlogic(price);
            Assert.AreEqual("12 ������ 34 ������� ", message);
        }
        [Test]
        public void Test2()
        {
            int price = 0;
            string message = task1.Logic.Mainlogic(price);
            Assert.AreEqual("������ 1 �������", message);
        }
        [Test]
        public void Test3()
        {
            int price = 100;
            string message = task1.Logic.Mainlogic(price);
            Assert.AreEqual("1 ����� ����� ", message);
        }
        [Test]
        public void Test4()
        {
            int price = 10000;
            string message = task1.Logic.Mainlogic(price);

            Assert.AreEqual("> 99 ������ 99 ������", message);
        }
        [Test]
        public void Test5()
        {
            string text1 = "papa mama misha";
            string text2 = "misha papa mama";
            string message = Form1.Logic.MainLogic(text1, text2);
            Assert.AreEqual("papa\r\nmama\r\nmisha\r\n", message);
        }
        [Test]
        public void Test6()
        {
            string text1 = "��� ���� �� ����� � ������ �����";
            string text2 = "����� ���� ��� �����";
            string message = Form1.Logic.MainLogic(text1, text2);
            Assert.AreEqual("���\r\n����\r\n�����\r\n�����\r\n", message);
        }
        [Test]
        public void Test7()
        {
            string text1 = "mama kappa lal";
            string text2 = "babakappa lalalala mamamia";
            string message = Form1.Logic.MainLogic(text1, text2);
            Assert.AreEqual("mama\r\nkappa\r\nlal\r\n", message);
        }
    }
}