using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

public class EnvironmentBase : EnvironmentObject
{
	public enum EnvironmentBaseType
	{
		Tracks,
		Empty
	}

	private EnvironmentBaseType _type;

	private int _numTracks;

	private int _blockCount;

	public EnvironmentBaseType Type => (EnvironmentBaseType)_numTracks;

	public int NumTracks => (int)_type;

	public int BlockCount => _numTracks;

	private void OnValidate()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public EnvironmentBase()
	{
		//IL_00b5: Expected I, but got Obj
		//IL_00cb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v14 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int blockCount = ((_blockCount < 2) ? 2 : ((_blockCount <= int.MaxValue) ? _blockCount : int.MaxValue));
		_blockCount = blockCount;
		int num3 = _blockCount / 2;
		int blockCount2 = num3 << 1;
		_blockCount = blockCount2;
	}
}
