using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace UI.Screens.CoinScreenInternal;

public class CoinContainer : MonoBehaviour
{
	private const float SPECIAL_SALE_ELEMENTS_OFFSET = -150f;

	private const float DEFAULT_OFFSET_FOR_ELEMENTS_ON_DISPLAY_VALUE = -59.5f;

	[NonSerialized]
	public float offsetForElementsOnDisplay;

	private UITable _table;

	private int counterForElementsOnDisplay__BackingField;

	private Action m_onTableRepostioned;

	public int counterForElementsOnDisplay
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CoinScreenInternal.CoinContainer)+20]");
			if ((nint)0 == 1 && OnboardingSave.shouldShowMissionIntroPopup && !OnboardingSave.hasShownMissionIntroPopup)
			{
				return 1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CoinScreenInternal.CoinContainer)+20]");
			if ((nint)0 == 0)
			{
				string args = tag;
				SDebug.LogFormat("A guideline button wiggler is not set properly.", (object[])(object)args);
			}
			return 0;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0ffd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1002: Expected Obj, but got Unknown
			//IL_100b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1010: Expected Obj, but got Unknown
			//IL_1019: Unknown result type (might be due to invalid IL or missing references)
			//IL_101e: Expected Obj, but got Unknown
			//IL_1027: Unknown result type (might be due to invalid IL or missing references)
			//IL_102c: Expected Obj, but got Unknown
			//IL_1035: Unknown result type (might be due to invalid IL or missing references)
			//IL_103a: Expected I, but got Unknown
			//IL_1043: Unknown result type (might be due to invalid IL or missing references)
			//IL_1048: Expected Obj, but got Unknown
			//IL_1051: Unknown result type (might be due to invalid IL or missing references)
			//IL_1056: Expected Obj, but got Unknown
			//IL_105f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1064: Expected Obj, but got Unknown
			//IL_106d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1072: Expected Obj, but got Unknown
			//IL_107b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1080: Expected Obj, but got Unknown
			//IL_1089: Unknown result type (might be due to invalid IL or missing references)
			//IL_108e: Expected Obj, but got Unknown
			//IL_10ba: Expected Obj, but got I4
			//IL_10c3: Expected Obj, but got I4
			//IL_10d0: Expected Obj, but got I4
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected Obj, but got Unknown
			//IL_005a: Expected I, but got Obj
			//IL_0070: Expected Obj, but got I
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected Obj, but got Unknown
			//IL_013f: Expected I, but got Obj
			//IL_0155: Expected Obj, but got I
			//IL_009b: Expected I, but got Obj
			//IL_0180: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 - -64;
			object obj3 = obj2 + 48;
			object obj4 = obj2 + 44;
			object obj5 = obj2 + 40;
			object obj6 = obj2 + 36;
			nint num = (nint)(obj2 + 32);
			object obj7 = obj2 + 28;
			object obj8 = obj2 + 24;
			object obj9 = obj2 + 20;
			object obj10 = obj2 + 16;
			object obj11 = obj2 + 4;
			object obj12 = obj2 + 8;
			obj12 = obj;
			_ = -1;
			((CelebrationReward)(object)this)._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int num2 = default;
			object obj13 = num2 + 16;
			obj13 = 44;
			string text = ((string)value).Substring(num2);
			object obj14 = text + 12;
			if ((nint)obj14 < 9)
			{
				return;
			}
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v49 (Il2CppClass<System.Type>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v758 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj4 = typeof(CelebrationRewardOrigin);
			obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj16 = text + 16;
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v105 (Il2CppClass<System.Enum>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num6 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v745 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj19 = default;
			object obj18 = obj19;
			object obj21 = default;
			object obj20 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj22 = default;
			if (obj20 == obj22)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj24 = default;
				object obj23 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj26 = default;
				object obj25 = obj26;
			}
			else
			{
				object obj25 = obj18;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
	}

	public event Action onTableRepostioned
	{
		add
		{
			//IL_000a: Expected I4, but got Obj
			counterForElementsOnDisplay__BackingField = (int)value;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onTableRepostioned;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 24;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	private void Start()
	{
		CancelInvoke();
	}

	private unsafe void OnTableReposition()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		UITable table = _table;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj = default;
		obj.method_ptr = method_ptr;
		obj.method = (nint)__ldftn(CoinContainer.OnTableReposition);
		object obj2 = obj + 16;
		obj2 = this;
		object obj3 = _table + 44;
		Delegate obj4 = ((Delegate)table.onReposition).CombineImpl(obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj5 = default;
		obj3 = obj5;
	}

	public void Reset()
	{
		if (this.m_onTableRepostioned != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	public void ActivateSpecialSale()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01d5: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_00ac: Expected I, but got Obj
		//IL_0108: Expected I, but got Obj
		//IL_011e: Expected Obj, but got I
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_0149: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		counterForElementsOnDisplay__BackingField = 0;
		GameObject gameObject = _table.gameObject;
		object current = ((Transform.Enumerator)(object)gameObject).Current;
		object obj3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj3 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v86 (Il2CppClass<NGUITools>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v116 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v100 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v109 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj6 = obj2 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj2 + obj8;
		obj9 = 86;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj10 = default;
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj2 + obj11;
			if ((nint)obj12 == 86)
			{
				object obj13 = obj2 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				return;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public void UseDefaultOffsetForElementsOnDisplay()
	{
		offsetForElementsOnDisplay = -150f;
	}

	public void RepositionTable()
	{
		offsetForElementsOnDisplay = -59.5f;
	}

	public void RepositionTableNow()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	public GameObject AddChildPrefab(GameObject prefab)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		((UnityEngine.Object)gameObject).m_CachedPtr = (IntPtr)0;
		object obj = gameObject + 16;
		obj = this;
		object obj2 = prefab & 1;
		return gameObject;
	}

	public GameObject AddChildGo(GameObject go)
	{
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_00af: Expected I4, but got Obj
		//IL_00b3: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		string go2 = _table.tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v9 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (GameObject)NGUITools.CalculateNextDepth((GameObject)(object)go2, (byte)(int)go != 0);
	}

	public CoinContainer()
	{
		//IL_0010: Expected Obj, but got I4
		_table.Sort((List<Transform>)1);
	}
}
