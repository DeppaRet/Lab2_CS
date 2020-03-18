
namespace Lab2
{
  public class Caesar : ICipher
  {
    public string Decode(string text, decimal shift, string key)
    {
      string words = text;
      string result;
      int i = 0;
      char[] letter = words.ToCharArray();
      foreach (char c in words)
      {
        if ((c > 1071) && (c < 1104)) 
        {
          if (c - shift <= 1071)
            letter[i] = (char)(c - shift + 32);
          else
            letter[i] = (char)(c - shift);
          i++;
        }
        else if ((c > 1039) && (c < 1072))
        {
          if (c - shift <= 1039)
            letter[i] = (char)(c - shift + 32);
          else
            letter[i] = (char)(c - shift);
          i++;
        }
        else
        {
          letter[i] = c;
          i++;
        }
      }
      result = new string(letter);
      return result;
    }

    public string Encode(string text, decimal shift, string key)
    {
      string words = text;
      string result;
      int i = 0;
      char[] letter = words.ToCharArray();
      foreach (char c in words)
      {
        if ((c > 1071) && (c < 1104))  //трабл тут надо разбираться
        {
          if (c + shift >= 1104)
            letter[i] = (char)(c + shift - 32);
          else
            letter[i] = (char)(c + shift);
        }
        else if ((c > 1039) && (c < 1072))
        {
          if (c + shift >= 1072)
            letter[i] = (char)(c + shift - 32);
          else
            letter[i] = (char)(c + shift);
        }
        else
          letter[i] = c;
        i++;
      }
      result = new string(letter);
      return result;
    }
  }
}
