

using System;

class Program {
  public static void Main (string[] args) {
    string inputStream = Console.ReadLine();
   Console.WriteLine(uncompressRLE2(inputStream));
   
  }
  //Basic Compress
  public static string compressRLE1(string data){
    string compressedData = "";
    int amount = 0;
    for (int i = 0; i < data.Length; i++){
      amount +=1;
    }
   char letter = data[0];
    compressedData = Convert.ToString(amount) + letter;
    return compressedData;
  }
public static string uncompressRLE1(string compressedData){
    string uncompressedData = "";
    char repeat = compressedData[0];
    char letter = compressedData[1];
   
    for (int i =0; i<char.GetNumericValue(repeat); i++){
        uncompressedData+=letter;
    }
       
    return uncompressedData;
  }

  public static string uncompressRLE2(string compressedData2){
    string uncompressedData = "";
    double repeatA1 = char.GetNumericValue(compressedData2[0]) * 10;
    char repeatA2 = compressedData2[1];
    char letter1= compressedData2[2];
    double repeatB1 = char.GetNumericValue(compressedData2[3]) * 10;
    char repeatB2 = compressedData2[4];
    char letter2 = compressedData2[5];

    for (int i = 0; i< (repeatA1 + char.GetNumericValue(repeatA2)); i++){
      uncompressedData +=  letter1;
    }

    for (int i = 0; i< (repeatB1 + char.GetNumericValue(repeatB2)); i++){
      uncompressedData +=  letter2;
    }

    return uncompressedData;
  }
 
}
