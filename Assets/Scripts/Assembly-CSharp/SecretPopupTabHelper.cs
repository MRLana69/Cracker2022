using Cpp2ILInjected;
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
		Tab1Tapped();
	}

	public void Tab1Tapped()
	{
		SetTabActivation(Tabs.Tab1);
	}

	public void Tab2Tapped()
	{
		SetTabActivation(Tabs.Tab2);
	}

	public void Tab3Tapped()
	{
		SetTabActivation(Tabs.Tab3);
	}

	public void Tab4Tapped()
	{
		SetTabActivation(Tabs.Tab4);
	}

	private void SetTabActivation(Tabs tab)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		_tab1ActiveBG.SetActive(value: false);
		_tab1InactiveBG.SetActive(value: true);
		SetLabelActive(_tab1Label, isActive: false);
		_tab2ActiveBG.SetActive(value: false);
		_tab2InactiveBG.SetActive(value: true);
		SetLabelActive(_tab2Label, isActive: false);
		_tab3ActiveBG.SetActive(value: false);
		_tab3InactiveBG.SetActive(value: true);
		SetLabelActive(_tab3Label, isActive: false);
		_tab4ActiveBG.SetActive(value: false);
		_tab4InactiveBG.SetActive(value: true);
		SetLabelActive(_tab4Label, isActive: false);
		object obj = this + 20;
		object obj2 = this + 16;
		object obj3 = this + 12;
		bool flag = tab == Tabs.Tab1;
		object obj4 = obj3;
		object obj5 = obj2;
		object label = obj;
		if (!flag)
		{
			switch (tab)
			{
			default:
				return;
			case Tabs.Tab2:
			{
				object obj12 = this + 32;
				object obj13 = this + 28;
				object obj14 = this + 24;
				obj4 = obj14;
				obj5 = obj13;
				label = obj12;
				break;
			}
			case Tabs.Tab3:
			{
				object obj9 = this + 44;
				object obj10 = this + 40;
				object obj11 = this + 36;
				obj4 = obj11;
				obj5 = obj10;
				label = obj9;
				break;
			}
			case Tabs.Tab4:
			{
				object obj6 = this + 56;
				object obj7 = this + 52;
				object obj8 = this + 48;
				obj4 = obj8;
				obj5 = obj7;
				label = obj6;
				break;
			}
			}
		}
		((GameObject)obj4).SetActive(true);
		((GameObject)obj5).SetActive(false);
		SetLabelActive((UILabel)label, isActive: true);
	}

	private unsafe void SetLabelActive(UILabel label, bool isActive)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected VT, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_00fc: Expected Obj, but got F4
		//IL_0117: Expected F4, but got I
		//IL_0112: Expected native int or pointer, but got VT
		//IL_0124: Expected F4, but got Obj
		//IL_011f: Expected native int or pointer, but got VT
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected VT, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 112);
		object obj2;
		if (isActive)
		{
			_ = 4575657222467263645L;
			_ = 4575657222467263645L;
			_ = 4525782065045627105L;
			_ = 4525782065045627105L;
			Color color2 = color + 16;
			label.color = color2;
			_ = 1065353216;
			obj2 = color + 80;
		}
		else
		{
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			Color color3 = color + 32;
			label.color = color3;
			_ = 0;
			obj2 = color + 48;
		}
		_ = 1065353216;
		object obj3 = obj2 + 8;
		obj3 = 1f;
		_ = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v4+8]");
		((Color*)(nint)color)->b = 0f;
		((Color*)(nint)color)->r = (float)obj2;
		label.effectColor = color;
	}
}
