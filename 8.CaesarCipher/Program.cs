using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    { 
      Console.WriteLine("Do you want to Encrypt or Decrypt your message?\nChoose:\n1. Encrypt\n2. Decrypt\n ");
      Console.WriteLine("Enter '1' or '2'");
      int val = Convert.ToInt32(Console.ReadLine());

      switch (val)
      {
        case 1:
          Console.WriteLine("Please enter message to encrypt: "); 
          string msgString = Console.ReadLine();
          msgString = msgString.ToLower();
          char[] secretMessage = msgString.ToCharArray();
          Encrypt(secretMessage,3);
          string secret = Encrypt(secretMessage,3);
          Console.WriteLine(secret);
          break;
        
        case 2:
          Console.WriteLine("Please enter message to decrypt: "); 
          string messageString = Console.ReadLine();
          messageString = messageString.ToLower();
          char[] secretMsg = messageString.ToCharArray();      
          Decrypt(secretMsg,3);
          string secret2 = Decrypt(secretMsg,3);
          Console.WriteLine(secret2);
          break;
      }     
    }
    static string Encrypt(char[] secretMessage, int key)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      int length = secretMessage.Length;
      char[] encryptedMessage = new char [length];

      for (int i=0;i<secretMessage.Length; i++)
      {
        var letter = secretMessage[i];
        int index = Array.IndexOf(alphabet,letter);
        int newIndex = (key + index)%26;
        char newLetter = alphabet[newIndex];
        encryptedMessage[i] = newLetter;
      }
      string enMessage = String.Join("",encryptedMessage); 
      return enMessage;
    }
    
 static string Decrypt(char[] secretMessage, int key)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      int length = secretMessage.Length;
      char[] encryptedMessage = new char [length];

      for (int i=0;i<secretMessage.Length; i++)
      {
        var letter = secretMessage[i];
        int index = Array.IndexOf(alphabet,letter);
        int newIndex = (index-key)%26;
        char newLetter = alphabet[newIndex];
        encryptedMessage[i] = newLetter;
      }
      string enMessage = String.Join("",encryptedMessage); 
      return enMessage;
    }
  }
}
