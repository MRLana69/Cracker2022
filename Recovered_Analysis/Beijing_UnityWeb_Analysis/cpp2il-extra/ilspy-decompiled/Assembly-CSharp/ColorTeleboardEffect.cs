using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColorTeleboardEffect : BatTeleboardEffect
{
	private int colorNumber;

	public override void StartTeleBoardEffect()
	{
		//IL_001c: Expected I4, but got F4
		_ = 0.2f;
		base._reappearDelay = -1f;
		base._overrideEnd = false;
		base.StartTeleBoardEffect();
	}

	private List<Material> CollectMaterials()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Material> list = default;
		list._items = null;
		object obj = list + 16;
		obj = this;
		return list;
	}

	public ColorTeleboardEffect()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected Obj, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_037e: Expected Obj, but got I4
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected Obj, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002c: Expected I4, but got Obj
		//IL_004d: Expected Obj, but got I4
		//IL_0063: Expected VT, but got Obj
		//IL_0071: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_03fd: Expected F4, but got Obj
		//IL_00b2: Expected I, but got Obj
		//IL_00ff: Expected I, but got Obj
		//IL_0115: Expected Obj, but got I
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_022e: Expected Obj, but got I4
		//IL_0140: Expected I, but got Obj
		//IL_01b4: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got F4
		//IL_02b6: Expected Obj, but got I
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		Material material = (Material)(obj2 + 40);
		object obj3 = obj2 + 8;
		object obj4 = obj2 + 24;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		Update();
		object obj6 = this - -64;
		float num = 1f / (float)obj6;
		playThruster.JumpStyle jumpStyle = ((playThruster)(object)this).jumpStyle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v25 (playThruster+JumpStyle)+C]");
		if ((nint)0 == 0)
		{
			return;
		}
		object obj7 = this - -64;
		int num2 = Random.RandomRangeInt(0, (int)obj7);
		float num3 = (float)num2 * num;
		Material material2 = ((List<Material>)jumpStyle).get_Item(0);
		material.mainTextureOffset = (Vector2)material2;
		nint num4 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v36 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v119 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MoveDirection moveDirection = BaseInputModule.DetermineMoveDirection(num3, (float)material);
		bool flag = moveDirection == MoveDirection.Left;
		float num6 = num3;
		if (!flag)
		{
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v108 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v115 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float t = num3 + num;
			float length = 1f - num;
			float num9 = Mathf.PingPong(t, length);
			num6 = num9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj4 = material;
		_ = ((Object)material).m_CachedPtr;
		object obj10 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj10 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj2 = 0;
			obj2 = num6;
			_ = 0f;
			obj3 = obj2;
			material = (Material)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj11 = obj5 + 4;
		object obj12 = obj11 + 1;
		obj11 = obj12;
		object obj13 = obj12 << 2;
		object obj14 = obj5 + obj13;
		obj14 = 154;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj5 + obj15;
			if ((nint)obj16 == 154)
			{
				object obj17 = obj5 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				return;
			}
		}
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}
}
