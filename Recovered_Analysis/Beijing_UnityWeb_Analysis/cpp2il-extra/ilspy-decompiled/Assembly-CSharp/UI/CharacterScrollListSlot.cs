using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UI.Screens.CharacterScreenInternal;
using UnityEngine;

namespace UI;

public class CharacterScrollListSlot : MonoBehaviour
{
	public int index;

	public Characters.CharacterId characterId;

	public int themeIndex;

	public GameObject model;

	public ScrollListCharacterUI ui;

	public CharacterModelRequest request;

	public bool modelReady
	{
		get
		{
			//IL_03b5: Expected I, but got Obj
			//IL_03cb: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0327: Expected I, but got Obj
			//IL_033d: Expected Obj, but got I
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected Obj, but got Unknown
			//IL_03f5: Expected I4, but got Obj
			//IL_0368: Expected I, but got Obj
			//IL_00f4: Expected I, but got Obj
			//IL_010a: Expected Obj, but got I
			//IL_013e: Expected I, but got Obj
			//IL_0183: Expected I, but got Obj
			//IL_0199: Expected Obj, but got I
			//IL_01cd: Expected I, but got Obj
			//IL_0212: Expected I, but got Obj
			//IL_0228: Expected Obj, but got I
			//IL_025c: Expected I, but got Obj
			//IL_02a1: Expected I, but got Obj
			//IL_02b7: Expected Obj, but got I
			//IL_02eb: Expected I, but got Obj
			nint num = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string flurryUserId = Flurry.flurryUserId;
			bool flag = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			CharacterNameEventManager characterNameEventManager = default;
			object key;
			if (characterNameEventManager != null)
			{
				Characters.CharacterId?[][] currentCharacterCollection = characterNameEventManager.GetCurrentCharacterCollection();
				object obj2 = currentCharacterCollection - 1;
				if ((nint)currentCharacterCollection != 1)
				{
					if ((nint)obj2 != 1)
					{
						if ((nint)obj2 == 2)
						{
							nint num3 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v27 (Il2CppClass<Strings>)+BA]");
							object obj3 = (nint)0 & (nint)0x200;
							bool flag2 = obj3 == null;
							key = "CELEBRATION_LABEL_TEMPLATE_CHARACTEREVENT_PART1_CATEGORY3";
							if (!flag2)
							{
								nint num4 = (nint)typeof(Strings);
								key = "CELEBRATION_LABEL_TEMPLATE_CHARACTEREVENT_PART1_CATEGORY3";
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v31 (Il2CppClass<Strings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									key = "CELEBRATION_LABEL_TEMPLATE_CHARACTEREVENT_PART1_CATEGORY3";
								}
							}
						}
						else
						{
							nint num5 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v34 (Il2CppClass<Strings>)+BA]");
							object obj4 = (nint)0 & (nint)0x200;
							bool flag3 = obj4 == null;
							key = "CELEBRATION_LABEL_TEMPLATE_CHARACTEREVENT_PART1";
							if (!flag3)
							{
								nint num6 = (nint)typeof(Strings);
								key = "CELEBRATION_LABEL_TEMPLATE_CHARACTEREVENT_PART1";
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v38 (Il2CppClass<Strings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									goto IL_03fa;
								}
							}
						}
					}
					else
					{
						nint num7 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v20 (Il2CppClass<Strings>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						bool flag4 = obj5 == null;
						key = "CELEBRATION_LABEL_TEMPLATE_CHARACTEREVENT_PART1_CATEGORY2";
						if (!flag4)
						{
							nint num8 = (nint)typeof(Strings);
							key = "CELEBRATION_LABEL_TEMPLATE_CHARACTEREVENT_PART1_CATEGORY2";
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v24 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								key = "CELEBRATION_LABEL_TEMPLATE_CHARACTEREVENT_PART1_CATEGORY2";
							}
						}
					}
				}
				else
				{
					nint num9 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v13 (Il2CppClass<Strings>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					bool flag5 = obj6 == null;
					key = "CELEBRATION_LABEL_TEMPLATE_CHARACTEREVENT_PART1_CATEGORY1";
					if (!flag5)
					{
						nint num10 = (nint)typeof(Strings);
						key = "CELEBRATION_LABEL_TEMPLATE_CHARACTEREVENT_PART1_CATEGORY1";
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v17 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							key = "CELEBRATION_LABEL_TEMPLATE_CHARACTEREVENT_PART1_CATEGORY1";
						}
					}
				}
				goto IL_03e8;
			}
			nint num11 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v20 (Il2CppClass<Strings>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num12 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v23 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			goto IL_03fa;
			IL_03e8:
			return (byte)(int)Strings.GetDefault((string)key) != 0;
			IL_03fa:
			key = "CELEBRATION_LABEL_TEMPLATE_CHARACTEREVENT_PART1";
			goto IL_03e8;
		}
	}

	public void SetEnabledState(bool modelEnabled, bool uiEnabled)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0028: Expected Obj, but got I
		//IL_0038: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0068: Expected I4, but got Obj
		//IL_00a9: Invalid comparison between Obj and F4
		//IL_00e2: Invalid comparison between Obj and F4
		//IL_01af: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got I
		//IL_0131: Invalid comparison between I and F4
		//IL_0172: Invalid comparison between I and F4
		//IL_011b: Expected Obj, but got I4
		//IL_021e: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [modelEnabled @ L1 (System.Boolean)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [modelEnabled @ L1 (System.Boolean)+10]");
		object obj4 = 0;
		((UILabel)modelEnabled).effectStyle = (uiEnabled ? UILabel.Effect.Shadow : UILabel.Effect.None);
		object obj5 = obj2 + 8;
		obj5 = obj;
		int height = (int)obj5;
		if (obj5 != obj5)
		{
			height = int.MinValue;
		}
		else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)2.1474836E+09f))
		{
			height = int.MinValue;
		}
		else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)(-2.1474836E+09f)))
		{
			height = int.MinValue;
		}
		((UIWidget)modelEnabled).height = height;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		UIWidget uIWidget = (UIWidget)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if (num != 0)
		{
			uIWidget = (UIWidget)int.MinValue;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if (!(0f < 2.1474836E+09f))
			{
				uIWidget = (UIWidget)int.MinValue;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				if (!(0f > -2.1474836E+09f))
				{
					uIWidget = (UIWidget)int.MinValue;
				}
			}
		}
		Color color = uIWidget.color;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [modelEnabled @ L1 (System.Boolean)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [modelEnabled @ L1 (System.Boolean)+10]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12+10]");
		_ = 0;
	}

	public void DestroyModel()
	{
		CancelInvoke();
	}

	public CharacterScrollListSlot()
	{
		//IL_015b: Expected I, but got Obj
		//IL_0171: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00cd: Expected I, but got Obj
		//IL_00e3: Expected Obj, but got I
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01ae: Expected Obj, but got I4
		//IL_010e: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)ui).FindKernel((string)null) != 0)
		{
			ui.OnEnable();
		}
		else
		{
			object obj2 = characterId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string msg = "CharacterScrollListSlot: Missing reference to UI on character " + text;
			SDebug.LogFormat(msg, null);
		}
		if (!((CharacterSelectButton)this).CurrentlyShownCharacterMatchesEventItem())
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate(model);
		object obj4 = this + 24;
		obj4 = 0;
	}
}
