using Cpp2ILInjected;
using WordHunt;

namespace Ionic.Zlib;

internal sealed class InflateCodes
{
	private const int START = 0;

	private const int LEN = 1;

	private const int LENEXT = 2;

	private const int DIST = 3;

	private const int DISTEXT = 4;

	private const int COPY = 5;

	private const int LIT = 6;

	private const int WASH = 7;

	private const int END = 8;

	private const int BADCODE = 9;

	internal int mode;

	internal int len;

	internal int[] tree;

	internal int tree_index;

	internal int need;

	internal int lit;

	internal int bitsToGet;

	internal int dist;

	internal byte lbits;

	internal byte dbits;

	internal int[] ltree;

	internal int ltree_index;

	internal int[] dtree;

	internal int dtree_index;

	internal InflateCodes()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_001e: Expected Obj, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I4
		int num = ((InflateBlocks)this).SyncPoint();
		object obj = this + 60;
		obj = 0;
		object obj2 = this + 56;
		obj2 = 0;
	}

	internal void Init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004c: Expected Obj, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		object obj = this + 12;
		obj = bl;
		object obj2 = this + 16;
		obj2 = bd;
		object obj3 = this + 20;
		obj3 = tl;
		object obj4 = this + 24;
		obj4 = tl_index;
		object obj5 = this + 28;
		obj5 = td;
		object obj6 = this + 32;
		obj6 = td_index;
	}

	internal int Process(InflateBlocks blocks, int r)
	{
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01b5: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateCodes)+7C]");
		if (0 == (nint)blocks)
		{
			return 0;
		}
		nint num = (nint)typeof(DeflateManager.Config);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v12 (Il2CppClass<Ionic.Zlib.DeflateManager+Config>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeflateManager.Config);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v34 (Il2CppClass<Ionic.Zlib.DeflateManager+Config>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ((WordHuntManager._003CDownloadDailyCoroutine_003Ed__10)(object)blocks).MoveNext();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.InflateCodes)+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v17 (System.Boolean)+18]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v8+18]");
		int result;
		if (num3 == 0)
		{
			result = 0;
		}
		else
		{
			int num4 = len;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v26 (System.Int32)+18]");
			result = (((nint)0 != 0) ? ((ZlibCodec)len).SetDictionary((byte[])1) : 0);
		}
		object obj3 = this + 92;
		obj3 = flag;
		((DeflateStream)this).Flush();
		return result;
	}

	internal int InflateFast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, InflateBlocks s, ZlibCodec z)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0024: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 28;
		obj = td;
		obj2 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		obj2 = bl;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
		int result = default;
		return result;
	}
}
