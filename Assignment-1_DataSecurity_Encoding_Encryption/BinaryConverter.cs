// TASK 2:
// Encoding: Convert your name to Binary
// Decoding: Convert Binary to Origin

namespace Assignment_1_DataSecurity_Encoding_Encryption
{
	public class BinaryConverter
	{
		public void DisplayHeading() {
			Console.WriteLine("\n============================= TASK 2: Binary Converter =============================\n");
		}

		// Encoding
		public string TextToBinary (string text)
		{
            // 8 bits, from (2 power to 8) to (2 power to 0)
            int[] twoPowerlist = { 128, 64, 32, 16, 8, 4, 2, 1 };

			string res = "";

			foreach (char c in text) {
				int cNum = (int)c; // take ASCII value
				string cBinary = ""; // binary data for one character

				for (int i = 0; i < twoPowerlist.Length; i++) {
                    // the xth digit means 2 power x, add it up.
                    // for example, A => 65, 65 is conbined from 64(2 power to 8) and 1(2 power to 0)
                    if (cNum >= twoPowerlist[i])
					{
						cBinary += "1";
						cNum -= twoPowerlist[i]; // minus the value aready used
                    }
					else {
						cBinary += "0";
					}
				}

				Console.WriteLine($"ASCII for {c} = {cBinary}");

				res += cBinary; // add up one character
            }
			return res;
		}

        // Decoding
        public string BinaryToText(string binaryData)
        {
            // 8 bits, from (2 power to 8) to (2 power to 0)
            int[] twoPowerlist = { 128, 64, 32, 16, 8, 4, 2, 1 };

			string res = "";

			// split with 8bits
			// use variable here to easy to change to 7bits or other
			for (int i = 0; i < binaryData.Length; i += twoPowerlist.Length) {
				int cNum = 0;
				string cBinary = binaryData.Substring(i, twoPowerlist.Length); 

                // inverse operation to TextToBinary's comment ↑
                // the xth digit means 2 power x, add it up.
                for (int j = 0; j < twoPowerlist.Length; j++) {
					// convert Char to Int then can product with 2 powers x
					// add up become ASCII value  
					cNum += Int32.Parse(cBinary[j].ToString()) * twoPowerlist[j];
                }

				char c = (char)cNum; // convert ASCII value to char
				res += c; // join char to string
            }

            return res;

        }
    }
}

