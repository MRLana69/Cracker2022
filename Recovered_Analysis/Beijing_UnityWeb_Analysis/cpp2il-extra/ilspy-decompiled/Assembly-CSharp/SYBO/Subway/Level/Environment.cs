using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

public class Environment : EnvironmentObject
{
	private EnvironmentKind _environmentKind;

	private int _blockCount;

	public EnvironmentKind EnvironmentKind
	{
		get
		{
			//IL_0007: Expected Obj, but got I
			return (EnvironmentKind)(nint)((Object)this).m_CachedPtr;
		}
	}

	public int BlockCount
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)_environmentKind;
		}
	}

	private void OnValidate()
	{
		//IL_000b: Expected Obj, but got I4
		_environmentKind = (EnvironmentKind)int.MaxValue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	private void OnDrawGizmos()
	{
		//IL_01d6: Expected I, but got Obj
		//IL_01ec: Expected Obj, but got I
		//IL_02bb: Expected I, but got Obj
		//IL_02d1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0169: Expected Obj, but got I4
		EnvironmentKind environmentKind = _environmentKind;
		nint num = (nint)typeof(EnvironmentInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v3 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EnvironmentInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v23 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EnvironmentType type = _environmentKind.Type;
		nint num3 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v15 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v24 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num5 = ((environmentKind._type != EnvironmentType.Epic) ? 2 : 12);
		int blockCount;
		if (_blockCount < num5)
		{
			blockCount = num5;
		}
		else
		{
			blockCount = ((_blockCount <= int.MaxValue) ? _blockCount : int.MaxValue);
		}
		_blockCount = blockCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v10 (SYBO.Subway.Level.EnvironmentType)+14]");
		if ((nint)0 <= (nint)0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v10 (SYBO.Subway.Level.EnvironmentType)+14]");
		int num6;
		if ((nint)0 != 0)
		{
			bool flag = _blockCount == int.MinValue;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v10 (SYBO.Subway.Level.EnvironmentType)+14]");
			bool flag2 = (nint)0 == -1;
			object obj3 = flag & flag2;
			if (obj3 != null)
			{
				num6 = 0;
			}
			else
			{
				int blockCount2 = _blockCount;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v10 (SYBO.Subway.Level.EnvironmentType)+14]");
				num6 = (int)((nint)blockCount2 / (nint)0);
			}
		}
		else
		{
			num6 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v10 (SYBO.Subway.Level.EnvironmentType)+14]");
		int blockCount3 = (int)((nint)0 * (nint)num6);
		_blockCount = blockCount3;
	}

	public unsafe Environment()
	{
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02c2: Expected Obj, but got I4
		//IL_02e0: Expected I, but got Obj
		//IL_02f6: Expected Obj, but got I
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Ref, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected VT, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00d5: Expected VT, but got Obj
		//IL_00e8: Expected I, but got Obj
		//IL_00fe: Expected Obj, but got I
		//IL_0362: Expected VT, but got Ref
		//IL_018b: Expected VT, but got Ref
		//IL_019c: Expected F4, but got Obj
		//IL_0197: Expected native int or pointer, but got VT
		//IL_01b1: Expected F4, but got I
		//IL_01ac: Expected native int or pointer, but got VT
		//IL_01d3: Expected VT, but got Ref
		//IL_0129: Expected I, but got Obj
		//IL_01ff: Expected VT, but got Ref
		//IL_0210: Expected F4, but got Obj
		//IL_020b: Expected native int or pointer, but got VT
		//IL_0222: Expected F4, but got I
		//IL_021d: Expected native int or pointer, but got VT
		//IL_0244: Expected VT, but got Ref
		//IL_0256: Expected Obj, but got F4
		//IL_026e: Expected F4, but got Obj
		//IL_0269: Expected native int or pointer, but got VT
		//IL_0283: Expected F4, but got I
		//IL_027e: Expected native int or pointer, but got VT
		//IL_02a5: Expected VT, but got Ref
		object obj2 = default;
		object obj = obj2 + 112;
		obj = 0;
		_ = 0;
		EnvironmentKind environmentKind = _environmentKind;
		nint num = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v96 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref Color reference = ref *(Color*)(obj2 + 136);
		Vector3 vector = (Vector3)(obj2 + 124);
		object obj4 = obj2 + 96;
		Transform transform = (Transform)(obj2 + 84);
		object obj5 = obj2 + 72;
		object obj6 = obj2 + 60;
		object obj7 = obj2 + 48;
		object obj8 = obj2 + 36;
		object obj9 = obj2 + 24;
		object obj10 = obj2 + 12;
		GamePositionRoot instance = GamePositionRoot.Instance;
		EnvironmentType type = environmentKind._type;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v39 (SYBO.Subway.Level.GamePositionRoot)+8]");
		bool flag;
		if ((nint)type == (nint)0)
		{
			EnvironmentDensity density = environmentKind._density;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v39 (SYBO.Subway.Level.GamePositionRoot)+C]");
			flag = (nint)density == (nint)0;
		}
		else
		{
			flag = false;
		}
		if (flag)
		{
			return;
		}
		float angle = 90f * (float)_blockCount;
		Color white = Color.white;
		reference = ref *(Color*)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23+8]");
		_ = 0;
		Gizmos.set_color_Injected(ref reference);
		GameObject gameObject = base.gameObject;
		transform.position = (Vector3)gameObject;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v55 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v88 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 back = Vector3.back;
		reference = ref *(Color*)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v27+8]");
		_ = 0;
		Quaternion quaternion = Quaternion.AngleAxis(angle, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
		Vector3 down = Vector3.down;
		reference = ref *(Color*)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v31+8]");
		_ = 0;
		Quaternion quaternion2 = Quaternion.AngleAxis(80f, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
		((Vector3*)(nint)vector)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v29+8]");
		((Vector3*)(nint)vector)->z = 0f;
		reference = ref *(Color*)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v33+8]");
		_ = 0;
		Vector3 vector2 = vector - (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		reference = ref *(Color*)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v35+8]");
		_ = 0;
		Quaternion quaternion3 = Quaternion.AngleAxis(0.5f, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((Object)transform).m_CachedPtr;
		reference = ref *(Color*)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v37+8]");
		_ = 0;
		Vector3 vector3 = vector - (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		obj = 60f;
		_ = 80f;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		reference = ref *(Color*)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Gizmos.DrawRay(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
	}
}
