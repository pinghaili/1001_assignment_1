// TASK 5:
// Encoding: Encrypt your name
// Decoding: Decrypt your name

namespace Assignment_1_DataSecurity_Encoding_Encryption
{
	public class EncryptDecrypt
    {
        public void DisplayHeading()
        {
            Console.WriteLine("\n============================== TASK 5: EncryptDecrypt ==============================\n");
        }

        // Encoding
        public string Encrypt(string text, string key)
        {
            string res = "";
            for(int i = 0; i < text.Length; i++){
                int cNum = (int)text[i];
                int kNum = (int)key[i % key.Length]; // use dynamic num to change letters frecuency
                res += (char)((cNum + kNum) % 255); // in case over 255
            }
            return res;
        }


        // Decoding
        public string Decrypt(string cryptedData, string key)
        {
            string res = "";
            for(int i = 0; i < cryptedData.Length; i++){
                int cNum = (int)cryptedData[i];
                int kNum = (int)key[i % key.Length];
                if(cNum < kNum){
                    cNum += 255; // in case less than 0
                }
                res += (char)(cNum - kNum);  
            }
            return res;
        }
    }
}

