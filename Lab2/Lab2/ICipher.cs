
namespace Lab2
{
  public interface ICipher
  {
    string Encode(string text, decimal shift = 0, string key = "");
    string Decode(string text, decimal shift = 0, string key = "");
  }
}
