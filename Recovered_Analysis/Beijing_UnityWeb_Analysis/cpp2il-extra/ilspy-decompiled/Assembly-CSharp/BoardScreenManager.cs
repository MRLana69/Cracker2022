using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using UnityEngine;

public class BoardScreenManager
{
	private static BoardScreenManager _instance;

	private bool forceRefreshOnBoardScreen__BackingField;

	private bool forceCenterOnSpecificBoard__BackingField;

	private bool comingFromHoverboardCustomizationPopup__BackingField;

	private bool willResetBoardAnimation__BackingField;

	private bool shouldResetThemeSelection__BackingField = false;

	private bool refreshBoardsWhenNotShowingPopup__BackingField;

	private Boards.BoardId currentlyShownBoardId__BackingField;

	private int currentlyShownThemeIndex__BackingField;

	public unsafe static BoardScreenManager Instance
	{
		get
		{
			//IL_0188: Expected I, but got Obj
			//IL_019e: Expected Obj, but got I
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Expected I, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_01d6: Expected I, but got Obj
			//IL_01f1: Expected I, but got Obj
			//IL_0207: Expected Obj, but got I
			//IL_0249: Expected I, but got Obj
			//IL_025f: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_013b: Expected I, but got Obj
			nint num = (nint)typeof(CharacterModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<CharacterModelPreviewFactory>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterModelPreviewFactory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v53 (Il2CppClass<CharacterModelPreviewFactory>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			nint num3 = (nint)(obj2 + 4);
			bool flag = (object)CharacterModelPreviewFactory.instance == null;
			bool flag2 = !flag;
			BoardScreenManager result = (BoardScreenManager)(object)CharacterModelPreviewFactory.instance;
			if (!flag2)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v25 (Il2CppClass<System.Type>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num5 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v49 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = typeof(CharacterModelPreviewFactory);
				((IntPtr*)num3)->m_value = (void*)(nint)obj2;
				Type type = Type.internal_from_handle((IntPtr)num3);
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = ((UnityEngine.Object)(object)type).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				nint num8 = (nint)typeof(CharacterModelPreviewFactory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v36 (Il2CppClass<CharacterModelPreviewFactory>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num9 = (nint)typeof(CharacterModelPreviewFactory);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v43 (Il2CppClass<CharacterModelPreviewFactory>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BoardScreenManager boardScreenManager = default;
				CharacterModelPreviewFactory.instance = (CharacterModelPreviewFactory)(object)boardScreenManager;
				result = boardScreenManager;
			}
			return result;
		}
	}

	public unsafe bool forceRefreshOnBoardScreen
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BoardScreenManager)+20]");
			return false;
		}
		set
		{
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Expected VT, but got Unknown
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Expected I4, but got Unknown
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Expected Obj, but got Unknown
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Expected Obj, but got Unknown
			//IL_001a: Expected Obj, but got I
			//IL_00fb: Expected Obj, but got I4
			//IL_01c4: Expected VT, but got Obj
			//IL_01c4: Expected Obj, but got I
			//IL_01ec: Expected Obj, but got I
			//IL_0229: Expected I4, but got Obj
			//IL_0243: Expected F4, but got Obj
			//IL_023e: Expected native int or pointer, but got VT
			//IL_0258: Expected F4, but got I
			//IL_0253: Expected native int or pointer, but got VT
			//IL_0052: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_017e: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			object obj = default;
			Color color = (Color)(obj - -64);
			int num = obj + 48;
			Material material = (Material)(obj + 32);
			object obj2 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BoardScreenManager)+34]");
			if ((nint)0 >= (nint)(value ? 1 : 0))
			{
				return;
			}
			bool flag = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BoardScreenManager)+34]");
			object obj3 = (nint)(flag ? 1 : 0) - (nint)0;
			object obj6;
			if ((nint)obj3 > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BoardScreenManager)+30]");
				object obj4 = 0;
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v36 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v42 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v37+C]");
				obj6 = -1;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
				{
					obj6 = obj3;
				}
			}
			else
			{
				obj6 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BoardScreenManager)+28]");
			material.SetTextureOffset((string)0, (Vector2)"_MainColor");
			obj = material;
			_ = ((UnityEngine.Object)material).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BoardScreenManager)+30]");
			object obj7 = (nint)0 + (nint)16;
			object obj8 = obj6 << 4;
			object obj9 = obj7 + obj8;
			obj2 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v22+8]");
			_ = 0;
			((int*)num)->m_value = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			((Color*)(nint)color)->r = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			((Color*)(nint)color)->b = 0f;
			Utils.Bar((string)(object)this, 0.4f, num, color);
		}
	}

	public bool forceCenterOnSpecificBoard
	{
		get
		{
			return forceRefreshOnBoardScreen__BackingField;
		}
		set
		{
			forceRefreshOnBoardScreen__BackingField = value;
		}
	}

	public bool comingFromHoverboardCustomizationPopup
	{
		get
		{
			return forceCenterOnSpecificBoard__BackingField;
		}
		set
		{
			forceCenterOnSpecificBoard__BackingField = value;
		}
	}

	public bool willResetBoardAnimation
	{
		get
		{
			return comingFromHoverboardCustomizationPopup__BackingField;
		}
		set
		{
			comingFromHoverboardCustomizationPopup__BackingField = value;
		}
	}

	public bool shouldResetThemeSelection
	{
		get
		{
			return willResetBoardAnimation__BackingField;
		}
		set
		{
			willResetBoardAnimation__BackingField = value;
		}
	}

	public bool refreshBoardsWhenNotShowingPopup
	{
		get
		{
			return shouldResetThemeSelection__BackingField;
		}
		set
		{
			shouldResetThemeSelection__BackingField = value;
		}
	}

	public Boards.BoardId currentlyShownBoardId
	{
		get
		{
			return refreshBoardsWhenNotShowingPopup__BackingField ? Boards.BoardId.bouncer : Boards.BoardId.normal;
		}
		set
		{
			bool flag = (byte)(value & Boards.BoardId.bouncer) != 0;
			refreshBoardsWhenNotShowingPopup__BackingField = flag;
		}
	}

	public int currentlyShownThemeIndex
	{
		get
		{
			return (int)currentlyShownBoardId__BackingField;
		}
		set
		{
			currentlyShownBoardId__BackingField = (Boards.BoardId)value;
		}
	}

	private BoardScreenManager()
	{
		//IL_005d: Expected I4, but got F4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0098: Expected I, but got Obj
		//IL_00ae: Expected Obj, but got I
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		_ = 1;
		_ = 4;
		object obj = this - -64;
		string name = ((AnimatorControllerParameter)(object)"Active").name;
		obj = name;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v27 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 forward = Vector3.forward;
		object obj4 = default;
		object obj3 = obj4 + 12;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = this + 72;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v20+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public void ChangedDisplayedHoverboard(Boards.BoardId newBoard)
	{
		currentlyShownThemeIndex__BackingField = (int)newBoard;
	}

	unsafe static BoardScreenManager()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected VT, but got Unknown
		//IL_00c5: Expected F4, but got Obj
		//IL_00c0: Expected native int or pointer, but got VT
		//IL_00da: Expected F4, but got I
		//IL_00d5: Expected native int or pointer, but got VT
		//IL_00fa: Expected I, but got Obj
		//IL_0117: Expected F4, but got Obj
		//IL_0112: Expected native int or pointer, but got VT
		//IL_012c: Expected F4, but got I
		//IL_0127: Expected native int or pointer, but got VT
		//IL_013a: Expected VT, but got F4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v27 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 12;
		Vector3 back = Vector3.back;
		Vector3 vector = (Vector3)(obj3 + 24);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Quaternion quaternion = Quaternion.AngleAxis(1.2f, vector);
		nint num3 = (nint)typeof(CharacterPickupParticles);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v20 (Il2CppClass<CharacterPickupParticles>)+5C]");
		nint num4 = 0;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		CharacterPickupParticles.coinEfxOffset = (Vector3)vector.x;
		_ = vector.z;
	}
}
