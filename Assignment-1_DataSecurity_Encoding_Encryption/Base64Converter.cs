// TASK 4:
// Encoding: Convert your name to Base64
// Decoding: Convert Base64 to Origin

namespace Assignment_1_DataSecurity_Encoding_Encryption
{
	public class Base64Converter
    {
        public void DisplayHeading()
        {
            Console.WriteLine("\n============================= TASK 4: Base64 Converter =============================\n");
        }

        // Encoding
        public string TextToBase64(string text)
        {
            string base64Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
            string res = "";
            string binText = "";

            // trans to binary
            for (int i = 0; i < text.Length; i++) {
                 binText += Convert.ToString(text[i], 2).PadLeft(8, '0');
            }

            // padding right with 0 to 6 multiples digits
            if(binText.Length % 6 == 2){
                binText = binText.PadRight(binText.Length + 4, '0');
            }else if(binText.Length % 6 == 4){
                binText = binText.PadRight(binText.Length + 2, '0');
            }

            // each 6 digits convert to 1 char
            for (int j = 0; j < binText.Length; j += 6 ){
                string bin = binText.Substring(j, 6);
                res += base64Char[Convert.ToInt32(bin, 2)];
            }

            // padding right with =
            if(res.Length % 3 == 1){
                res += "==";
            }else if(res.Length % 3 == 2){
                res += "=";
            }

            return res;
        }


        // Decoding
        public string Base64ToText(string base64Data)
        {
            string base64Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

            string binText = "";
            
            // remove = mark at the end
            base64Data = base64Data.Trim('=');

            for(int i = 0; i < base64Data.Length; i++){
                int index = base64Char.IndexOf(base64Data[i]);
                string bin = Convert.ToString(index, 2).PadLeft(8, '0');
                // Take only the last 6 bits
                binText += bin.Substring(2);
            }

            string res = "";
            // each 8 digits convert to 1 ascii char
            for(int j = 0; j < binText.Length - 8; j += 8){
                int decimalValue = Convert.ToInt32(binText.Substring(j, 8), 2);
                res += Convert.ToChar(decimalValue);
            }

            return res;
        }
    }
}

