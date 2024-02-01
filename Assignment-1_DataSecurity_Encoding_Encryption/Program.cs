
// TASK 1 Add code that would receive a string from the user through the console.

using Assignment_1_DataSecurity_Encoding_Encryption;

Console.WriteLine("\n================================ TASK 1: User Inpit ================================\n");
Console.Write("Enter Your Full Name Here => ");
string fullName = Console.ReadLine();

// TASK 2: Binary Converter
BinaryConverter base2 = new BinaryConverter();

base2.DisplayHeading();

string binaryName = base2.TextToBinary(fullName);
string originName = base2.BinaryToText(binaryName);

Console.WriteLine($"Your fullname in binary is: {binaryName}");
Console.WriteLine($"Let's convert binary to origin fullname: {originName}");


// TASK 3: Hexademical Converter
HexademicalConverter base16 = new HexademicalConverter();

base16.DisplayHeading();

string hexaName = base16.TextToHexademical(fullName);

string originName2 = base16.HexademicalToText(hexaName);

Console.WriteLine($"Your fullname in Hexademical is: {hexaName}");
Console.WriteLine($"Let's convert HexaName to origin fullname: {originName2}");


//// TASK 4: Base64 Converter
Base64Converter base64 = new Base64Converter();

base64.DisplayHeading();

string base64Name = base64.TextToBase64(fullName);
string originName3 = base64.Base64ToText(base64Name);

Console.WriteLine($"Your fullname in Base64 is: {base64Name}");
Console.WriteLine($"Let's convert Base64 to origin fullname: {originName3}");


//// TASK 5: EncryptDecrypt
EncryptDecrypt crypt = new EncryptDecrypt();

crypt.DisplayHeading();

string key = "BDAT";
string encryptedName = crypt.Encrypt(fullName, key);
string decryptedName = crypt.Decrypt(encryptedName, key);

Console.WriteLine($"Your fullname in encrypted is: {encryptedName}");
Console.WriteLine($"Let's convert encryptedName to origin fullname: {decryptedName}");

Console.Read(); // prevent exit in Mac terminal