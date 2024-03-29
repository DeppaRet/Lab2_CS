﻿using System;

namespace Lab2
{
  public class Des : ICipher
  {
    private const int sizeOfBlock = 128; //в DES размер блока 64 бит, но поскольку в unicode символ в два раза длинее, то увеличим блок тоже в два раза
    private const int sizeOfChar = 16; //размер одного символа (in Unicode 16 bit)
    private const int shiftKey = 2; //сдвиг ключа 
    private const int quantityOfRounds = 16; //количество раундов
    static string[] Blocks; //сами блоки в двоичном формате
    public string Encode(string text, decimal shift, string key)
    {

      string s = text, tmp = "";
      s = StringToRightLength(s);
      CutStringIntoBlocks(s);

      key = CorrectKeyWord(key, s.Length / (2 * Blocks.Length));
      tmp = key;
      key = StringToBinaryFormat(key);

      for (int j = 0; j < quantityOfRounds; j++)
      {
        for (int i = 0; i < Blocks.Length; i++)
          Blocks[i] = EncodeDESOneRound(Blocks[i], key);

        key = KeyToNextRound(key);
      }

      key = KeyToPrevRound(key);

      tmp = StringFromBinaryToNormalFormat(key);

      string result = "";

      for (int i = 0; i < Blocks.Length; i++)
        result += Blocks[i];
      //return (StringFromBinaryToNormalFormat(result) + "Ключ:" + StringFromBinaryToNormalFormat(key));
      return (StringFromBinaryToNormalFormat(result));
    }

    public string Decode(string text, decimal shift, string key)
    {

      string s = text, tmp;
      key = StringToBinaryFormat(key);
      s = StringToBinaryFormat(s);
      CutBinaryStringIntoBlocks(s);
      for (int j = 0; j < quantityOfRounds; j++)
      {
        for (int i = 0; i < Blocks.Length; i++)
          Blocks[i] = DecodeDESOneRound(Blocks[i], key);
        key = KeyToPrevRound(key);
      }
      key = KeyToNextRound(key);
      tmp = StringFromBinaryToNormalFormat(key);
      string result = "";
      for (int i = 0; i < Blocks.Length; i++)
        result += Blocks[i];
      return (StringFromBinaryToNormalFormat(result));
    }

    //доводим строку до размера, чтобы делилась на sizeOfBlock
    private static string StringToRightLength(string input)
    {
      while (((input.Length * sizeOfChar) % sizeOfBlock) != 0)
        input += "#";
      return input;
    }

    //разбиение обычной строки на блоки
    private static void CutStringIntoBlocks(string input)
    {
      Blocks = new string[(input.Length * sizeOfChar) / sizeOfBlock];
      int lengthOfBlock = input.Length / Blocks.Length;
      for (int i = 0; i < Blocks.Length; i++)
      {
        Blocks[i] = input.Substring(i * lengthOfBlock, lengthOfBlock);
        Blocks[i] = StringToBinaryFormat(Blocks[i]);
      }
    }

    //разбиение двоичной строки на блоки
    private static void CutBinaryStringIntoBlocks(string input)
    {
      Blocks = new string[input.Length / sizeOfBlock]; // тут
      int lengthOfBlock = input.Length / Blocks.Length;
      for (int i = 0; i < Blocks.Length; i++)
        Blocks[i] = input.Substring(i * lengthOfBlock, lengthOfBlock);
    }

    //перевод строки в двоичный формат
    private static string StringToBinaryFormat(string input)
    {
      string output = "";
      for (int i = 0; i < input.Length; i++)
      {
        string char_binary = Convert.ToString(input[i], 2); // походу тут
        while (char_binary.Length < sizeOfChar)
          char_binary = "0" + char_binary;
        output += char_binary;
      }
      return output;
    }

    //доводим длину ключа до нужной
    private static string CorrectKeyWord(string input, int lengthKey)
    {
      if (input.Length > lengthKey)
        input = input.Substring(0, lengthKey);
      else
        while (input.Length < lengthKey)
          input = "0" + input;
      return input;
    }

    //шифрование DES один раунд
    private static string EncodeDESOneRound(string input, string key)
    {
      string L = input.Substring(0, input.Length / 2);
      string R = input.Substring(input.Length / 2, input.Length / 2);
      return (R + XOR(L, f(R, key)));
    }

    //расшифровка DES один раунд
    private static string DecodeDESOneRound(string input, string key)
    {
      string L = input.Substring(0, input.Length / 2);
      string R = input.Substring(input.Length / 2, input.Length / 2);
      return (XOR(f(L, key), R) + L);
    }

    //XOR двух строк с двоичными данными
    private static string XOR(string s1, string s2)
    {
      string result = "";
      for (int i = 0; i < s1.Length; i++)
      {
        bool a = Convert.ToBoolean(Convert.ToInt32(s1[i].ToString()));
        bool b = Convert.ToBoolean(Convert.ToInt32(s2[i].ToString()));
        if (a ^ b)
          result += "1";
        else
          result += "0";
      }
      return result;
    }

    //шифрующая функция f. в данном случае это XOR
    private static string f(string s1, string s2)
    {
      return XOR(s1, s2);
    }

    //вычисление ключа для следующего раунда шифрования. циклический сдвиг >> 2
    private static string KeyToNextRound(string key)
    {
      for (int i = 0; i < shiftKey; i++)
      {
        key = key[key.Length - 1] + key;
        key = key.Remove(key.Length - 1);
      }
      return key;
    }

    //вычисление ключа для следующего раунда расшифровки. циклический сдвиг << 2
    private static string KeyToPrevRound(string key)
    {
      for (int i = 0; i < shiftKey; i++)
      {
        key = key + key[0];
        key = key.Remove(0, 1);
      }
      return key;
    }

    //переводим строку с двоичными данными в символьный формат
    private static string StringFromBinaryToNormalFormat(string input)
    {
      string output = "";
      while (input.Length > 0)
      {
        string char_binary = input.Substring(0, sizeOfChar);
        input = input.Remove(0, sizeOfChar);
        int a = 0;
        int degree = char_binary.Length - 1;
        foreach (char c in char_binary)
          a += Convert.ToInt32(c.ToString()) * (int)Math.Pow(2, degree--);
        output += ((char)a).ToString();
      }
      return output;
    }

    
  }
}
