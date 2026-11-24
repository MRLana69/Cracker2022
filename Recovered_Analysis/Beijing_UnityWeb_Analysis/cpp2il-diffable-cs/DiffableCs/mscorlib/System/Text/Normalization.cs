namespace System.Text;

internal class Normalization
{
	private static byte* props; //Field offset: 0x0
	private static int* mappedChars; //Field offset: 0x4
	private static short* charMapIndex; //Field offset: 0x8
	private static short* helperIndex; //Field offset: 0xC
	private static ushort* mapIdxToComposite; //Field offset: 0x10
	private static byte* combiningClass; //Field offset: 0x14
	private static object forLock; //Field offset: 0x18
	public static readonly bool isReady; //Field offset: 0x1C

	private static Normalization() { }

	private static int CharMapIdx(int cp) { }

	private static void Combine(StringBuilder sb, int i, int checkType) { }

	private static StringBuilder Combine(string source, int start, int checkType) { }

	private static int CombineHangul(StringBuilder sb, string s, int current) { }

	private static string Compose(string source, int checkType) { }

	private static string Decompose(string source, int checkType) { }

	private static void Decompose(string source, ref StringBuilder sb, int checkType) { }

	private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start) { }

	private static int Fetch(StringBuilder sb, string s, int i) { }

	private static int GetCanonical(int c, int[] buf, int bufIdx, int checkType) { }

	private static int GetCanonicalHangul(int s, int[] buf, int bufIdx) { }

	private static byte GetCombiningClass(int c) { }

	private static int GetPrimaryCompositeFromMapIndex(int src) { }

	private static int GetPrimaryCompositeHelperIndex(int cp) { }

	private static void load_normalization_resource(out nint props, out nint mappedChars, out nint charMapIndex, out nint helperIndex, out nint mapIdxToComposite, out nint combiningClass) { }

	public static string Normalize(string source, int type) { }

	public static string Normalize(string source, NormalizationForm normalizationForm) { }

	private static uint PropValue(int cp) { }

	public static NormalizationCheck QuickCheck(char c, int type) { }

	private static void ReorderCanonical(string src, ref StringBuilder sb, int start) { }

	private static int TryCompose(int i, int starter, int candidate) { }

	private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current) { }

}

