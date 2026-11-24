using Cpp2ILInjected;
using Data.Managers;
using SYBO.Subway.Info;
using UI.Screens;
using UnityEngine;

public class SecretPopupTabHelper : MonoBehaviour
{
	public enum Tabs
	{
		Tab1,
		Tab2,
		Tab3,
		Tab4
	}

	private GameObject _tab1ActiveBG;

	private GameObject _tab1InactiveBG;

	private UILabel _tab1Label;

	private GameObject _tab2ActiveBG;

	private GameObject _tab2InactiveBG;

	private UILabel _tab2Label;

	private GameObject _tab3ActiveBG;

	private GameObject _tab3InactiveBG;

	private UILabel _tab3Label;

	private GameObject _tab4ActiveBG;

	private GameObject _tab4InactiveBG;

	private UILabel _tab4Label;

	private void Awake()
	{
		((UpgradeScreen)this).Start();
	}

	public void Tab1Tapped()
	{
		Tab2Tapped();
	}

	public void Tab2Tapped()
	{
		((RenderTextureManager)this).ReleaseTexture((RenderTexture)null);
	}

	public void Tab3Tapped()
	{
		//IL_000b: Expected Obj, but got I4
		((RenderTextureManager)this).ReleaseTexture((RenderTexture)1);
	}

	public void Tab4Tapped()
	{
		//IL_000b: Expected Obj, but got I4
		((RenderTextureManager)this).ReleaseTexture((RenderTexture)2);
	}

	private unsafe void SetTabActivation(Tabs tab)
	{
		//IL_0187: Expected Obj, but got I4
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_01b7: Expected Obj, but got I
		//IL_01c5: Expected I, but got Obj
		//IL_01db: Expected Obj, but got I
		//IL_02ce: Expected Obj, but got I
		//IL_02e1: Expected I4, but got Obj
		//IL_02f1: Expected Obj, but got I
		//IL_0302: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ac: Expected I4, but got Obj
		//IL_022e: Expected I, but got Obj
		//IL_0244: Expected Obj, but got I
		//IL_009f: Expected I4, but got Obj
		//IL_027d: Expected Obj, but got I4
		//IL_028d: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I4
		//IL_00bf: Expected I, but got Obj
		object obj = ((Tabs*)(int)tab)->value__;
		object obj2 = obj + 8;
		obj2 = obj;
		_tab2Label = (UILabel)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tab @ L1 (SecretPopupTabHelper+Tabs)+4]");
		object obj3 = 0;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S2_v2 (Il2CppClass<Strings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S2_v19 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v13+8]");
		string text = Strings.GetDefault((string)0);
		((UILabel)(object)_tab1ActiveBG).fontSize = (int)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tab @ L1 (SecretPopupTabHelper+Tabs)+4]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v17+24]");
		string text2 = Strings.GetDefault((string)0);
		bool flag = text2 == null || text2.m_stringLength == 0;
		int fontSize = ((!flag) ? ((int)text2) : ((int)"Default"));
		((UILabel)(object)_tab1InactiveBG).fontSize = fontSize;
		nint num3 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v29 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v48 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = CharacterManager.IsCollectionComplete((Characters.CharacterId)((Tabs*)(int)tab)->value__);
		_tab2InactiveBG = (GameObject)flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tab @ L1 (SecretPopupTabHelper+Tabs)+4]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v37+14]");
		if ((nint)0 == 0)
		{
			((GameObject)(object)_tab1Label).tag = null;
			_tab2ActiveBG.tag = null;
			return;
		}
		bool flag3 = (object)_tab2InactiveBG != null;
		string text3 = (string)((flag3 ? 1 : 0) ^ 1);
		((GameObject)(object)_tab1Label).tag = text3;
		bool flag4 = (object)_tab2InactiveBG != null;
		_tab2ActiveBG.tag = (string)flag4;
	}

	private void SetLabelActive(UILabel label, bool isActive)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_03df: Expected Obj, but got I4
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected Obj, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got I4
		//IL_004d: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_0217: Expected Obj, but got I
		//IL_0496: Expected I, but got Obj
		//IL_04ac: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got I
		//IL_008e: Expected I, but got Obj
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_0388: Expected I, but got Obj
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0142: Expected Obj, but got I4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v103 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num2 = (nint)typeof(Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v122 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v97+C]");
					obj2 = 0;
					object obj8 = obj4 + 4;
					object obj9 = obj8 + 1;
					obj8 = obj9;
					object obj10 = obj9 << 2;
					object obj11 = obj4 + obj10;
					obj11 = 76;
					break;
				}
				continue;
			}
			object obj12 = obj4 + 4;
			object obj13 = obj12 + 1;
			obj12 = obj13;
			object obj14 = obj13 << 2;
			object obj15 = obj4 + obj14;
			obj15 = 70;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj16 = (nint)0 << 2;
			object obj17 = obj4 + obj16;
			if ((nint)obj17 == 76)
			{
				object obj18 = obj4 + 4;
				if ((nint)obj18 > -1)
				{
					object obj19 = obj18 + -1;
					obj18 = obj19;
				}
				SecretPopupTabHelper secretPopupTabHelper = (SecretPopupTabHelper)obj2;
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj20 = (nint)0 << 2;
			object obj21 = obj4 + obj20;
			if ((nint)obj21 == 70)
			{
				object obj22 = obj4 + 4;
				if ((nint)obj22 > -1)
				{
					object obj23 = obj22 + -1;
					obj22 = obj23;
				}
				goto IL_0488;
			}
		}
		object obj24 = default;
		if (obj24 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0488;
		IL_0488:
		nint num3 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v40 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num4 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v45 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 one = Vector2.one;
	}

	public SecretPopupTabHelper()
	{
		//IL_000b: Expected Obj, but got I4
		((RenderTextureManager)this).ReleaseTexture((RenderTexture)3);
	}
}
