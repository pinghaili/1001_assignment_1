// TASK 3:
// Encoding: Convert your name to Hexademical
// Decoding: Convert Hexademical to Origin

namespace Assignment_1_DataSecurity_Encoding_Encryption
{
	public class HexademicalConverter
    {
        public void DisplayHeading()
        {
            Console.WriteLine("\n=========================== TASK 3: Hexademical Converter ==========================\n");
        }

        // Encoding
        public string TextToHexademical(string text)
		{
            string hexaChar = "0123456789ACBDEF";
            string res = "";
            for (int i = 0; i < text.Length; i++) {
                int cNum = (int)text[i];
                // first digit means 16 mutiples, second digit is the remainder
                string hexaValue = hexaChar[(int)(cNum / 16)].ToString() + hexaChar[(int)(cNum % 16)].ToString();
                res += hexaValue;
            }

            return res;
		}


        // Decoding
        public string HexademicalToText(string HexademicalData)
        {
            string hexaChar = "0123456789ACBDEF";

            string res = "";

            for (int i = 0; i < HexademicalData.Length; i += 2) {
                // each 2 chars for 1 original letter
                int ASCIIValue = hexaChar.IndexOf(HexademicalData[i]) * 16 + hexaChar.IndexOf(HexademicalData[i + 1]);

                res += (char)ASCIIValue;
            }


            return res;
        }
    }
}

