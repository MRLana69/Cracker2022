namespace System.Globalization;

internal class TokenHashValue
{
	internal string tokenString; //Field offset: 0x8
	internal TokenType tokenType; //Field offset: 0xC
	internal int tokenValue; //Field offset: 0x10

	internal TokenHashValue(string tokenString, TokenType tokenType, int tokenValue) { }

}

