using Lab2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCipher
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      string text = "Тест";
      int shift = 2;
      string expectedText = "Фзуф";
      ICipher cipher = new Caesar();
      Assert.AreEqual(cipher.Encode(text, shift), expectedText);
    }
    [TestMethod]
    public void TestMethod2()
    {
      string text = "Фзуф";
      int shift = 2;
      string expectedText = "Тест";
      ICipher cipher = new Caesar();
      Assert.AreEqual(cipher.Decode(text, shift), expectedText);
    }

    [TestMethod]
    public void TestMethod3()
    {
      string text = "МОСКВА";
      int shift = 0;
      string key = "фывфв";
      string expectedText = "ꋢ㣚䄫ⷶՁ츎倿";
      ICipher cipher = new Des();
      Assert.AreEqual(cipher.Encode(text, shift, key), expectedText);
    }

    [TestMethod]
    public void TestMethod4()
    {
      string text = "䅼騚늷㷱偿沾";
      int shift = 0;
      string key = "ႄၨၰၸ";
      string expectedText = "тест";
      ICipher cipher = new Des();
      Assert.AreEqual(cipher.Encode(text, shift, key), expectedText);
    }
  }
}
