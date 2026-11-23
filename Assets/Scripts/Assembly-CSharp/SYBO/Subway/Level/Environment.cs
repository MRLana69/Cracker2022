using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

public class Environment : EnvironmentObject
{
	private EnvironmentKind _environmentKind;

	private int _blockCount;

	public EnvironmentKind EnvironmentKind => _environmentKind;

	public int BlockCount => _blockCount;

	private void OnValidate()
	{
		EnvironmentKind environmentKind = _environmentKind;
		EnvironmentInfo byKind = EnvironmentInfo.GetByKind(_environmentKind);
		bool flag = environmentKind._type == EnvironmentType.Epic;
		int num = 12;
		if (!flag)
		{
			num = 2;
		}
		if (num <= _blockCount)
		{
			num = _blockCount;
		}
		_blockCount = num;
		if (byKind.MidPieceLengthInBlocks >= 1)
		{
			int num2 = num / byKind.MidPieceLengthInBlocks;
			int blockCount = byKind.MidPieceLengthInBlocks * num2;
			_blockCount = blockCount;
		}
	}

	private unsafe void OnDrawGizmos()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected VT, but got Unknown
		//IL_011f: Expected I, but got Obj
		//IL_0169: Expected I, but got Obj
		//IL_029f: Expected F4, but got I
		//IL_029a: Expected native int or pointer, but got VT
		//IL_02bc: Expected native int or pointer, but got VT
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 112);
		EnvironmentKind environmentKind = _environmentKind;
		EnvironmentKind none = EnvironmentKind.None;
		if (environmentKind._type != none._type || environmentKind._density != none._density)
		{
			float num = (float)_blockCount * 90f;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 0;
			_ = 0;
			Color color = (Color)(vector + 32);
			Gizmos.color = color;
			Transform transform = base.transform;
			Vector3 position = transform.position;
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v43 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num3 = 0;
			float num4 = (float)Vector3.forwardVector * num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v44 (Il2CppStaticFields<UnityEngine.Vector3>)+4C]");
			float num5 = 0f * num;
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v57 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num7 = 0;
			float num8 = (float)Vector3.upVector * 80f;
			float num9 = num4 + num8;
			float num10 = num9 * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			float num11 = 0f + num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v58 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
			float num12 = 0f * 80f;
			float num13 = num5 + num12;
			float num14 = num13 * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
			float num15 = 0f + num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v44 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
			float num16 = 0f * num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v58 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
			float num17 = 0f * 80f;
			float num18 = num16 + num17;
			float num19 = num18 * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			float num20 = 0f + num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			((Vector3*)(nint)vector)->z = 0f;
			_ = 4800837203891585024L;
			((Vector3*)(nint)vector)->x = 60f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Vector3 center = vector + 16;
			Gizmos.DrawWireCube(center, vector);
		}
	}
}
