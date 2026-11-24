using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.MessageCenter;
using UnityEngine;

public class MeFooterNavigation : MonoBehaviour
{
	public List<UIButtonOverlayOff> buttons;

	private List<UITexture> _buttonHighlight;

	public static int _selectedTab;

	private void OnEnable()
	{
		CancelInvoke();
	}

	private void Start()
	{
		List<UITexture> buttonHighlight = _buttonHighlight;
		if (buttonHighlight._size > 0)
		{
			Update();
		}
	}

	private void Init()
	{
		Update();
	}

	private void Update()
	{
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_042e: Expected Obj, but got I4
		//IL_0118: Expected Obj, but got I4
		//IL_00c7: Expected I, but got Obj
		//IL_0045: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I4
		//IL_01f5: Expected Obj, but got I4
		//IL_0221: Expected I, but got Obj
		//IL_0237: Expected Obj, but got I
		//IL_02af: Expected I, but got Obj
		//IL_02c5: Expected Obj, but got I
		//IL_033d: Expected I, but got Obj
		//IL_0353: Expected Obj, but got I
		//IL_0262: Expected I, but got Obj
		//IL_02f0: Expected I, but got Obj
		//IL_037e: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UITexture> list = default;
		list._002Ector();
		object obj = this + 16;
		obj = list;
		int num = 0;
		while (num <= 3)
		{
			UIButtonOverlayOff uIButtonOverlayOff = buttons.get_Item(num);
			GameObject gameObject = uIButtonOverlayOff.gameObject;
			bool flag = ((Transform)(object)gameObject).IsChildOf((Transform)(object)"High");
			UITexture component = ((Component)flag).GetComponent<UITexture>();
			_buttonHighlight.Add(component);
			int num2 = num + 1;
			num = num2;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v88 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag2).DelayHideMainCamera();
		bool flag3 = (string)(object)enumerator != "CharacterScreen";
		bool flag4 = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator2 = ((UIScreenController)flag4).DelayHideMainCamera();
		bool flag5 = (string)(object)enumerator2 != "BoardScreen";
		bool flag6 = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator3 = ((UIScreenController)flag6).DelayHideMainCamera();
		bool flag7 = (string)(object)enumerator3 != "AwardsScreen";
		UITexture uITexture = _buttonHighlight.get_Item(0);
		uITexture.tag = null;
		UITexture uITexture2 = _buttonHighlight.get_Item(1);
		uITexture2.tag = (string)flag3;
		UITexture uITexture3 = _buttonHighlight.get_Item(2);
		uITexture3.tag = (string)flag5;
		UITexture uITexture4 = _buttonHighlight.get_Item(3);
		uITexture4.tag = (string)flag7;
		if (flag3)
		{
			nint num5 = (nint)typeof(MeFooterNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v76 (Il2CppClass<MeFooterNavigation>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(MeFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v82 (Il2CppClass<MeFooterNavigation>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_selectedTab = 2;
		}
		if (flag5)
		{
			nint num7 = (nint)typeof(MeFooterNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v63 (Il2CppClass<MeFooterNavigation>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(MeFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v69 (Il2CppClass<MeFooterNavigation>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_selectedTab = 3;
		}
		if (!flag7)
		{
			return;
		}
		nint num9 = (nint)typeof(MeFooterNavigation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v50 (Il2CppClass<MeFooterNavigation>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(MeFooterNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v56 (Il2CppClass<MeFooterNavigation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_selectedTab = 4;
	}

	public void OnClickButton(Transform who)
	{
		if (((HashSet<object>)(object)_buttonHighlight).Contains((object)who))
		{
			bool flag = ((HashSet<object>)(object)_buttonHighlight).Remove((object)who);
		}
		((AwardsScreenNavigation)this).OnEnable();
	}

	public MeFooterNavigation()
	{
		//IL_009d: Expected Obj, but got I4
		//IL_0bae: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0c16: Expected Obj, but got I4
		//IL_00c8: Expected I, but got Obj
		//IL_00de: Expected Obj, but got I
		//IL_0810: Expected Obj, but got I4
		//IL_0342: Expected I, but got Obj
		//IL_0358: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0851: Expected I, but got Obj
		//IL_0867: Expected Obj, but got I
		//IL_05bc: Expected I, but got Obj
		//IL_05d2: Expected Obj, but got I
		//IL_0109: Expected I, but got Obj
		//IL_082c: Expected Obj, but got I4
		//IL_0ab0: Expected Obj, but got I4
		//IL_0383: Expected I, but got Obj
		//IL_0b71: Expected I, but got Obj
		//IL_0b87: Expected Obj, but got I
		//IL_0156: Expected I, but got Obj
		//IL_016c: Expected Obj, but got I
		//IL_0892: Expected I, but got Obj
		//IL_05fd: Expected I, but got Obj
		//IL_0bd9: Expected I, but got Obj
		//IL_0bef: Expected Obj, but got I
		//IL_03d0: Expected I, but got Obj
		//IL_03e6: Expected Obj, but got I
		//IL_0680: Expected I, but got Obj
		//IL_0696: Expected Obj, but got I
		//IL_01f2: Expected I, but got Obj
		//IL_0197: Expected I, but got Obj
		//IL_0add: Expected Obj, but got I4
		//IL_066d: Expected Obj, but got I4
		//IL_046c: Expected I, but got Obj
		//IL_0411: Expected I, but got Obj
		//IL_06c1: Expected I, but got Obj
		//IL_023f: Expected I, but got Obj
		//IL_0255: Expected Obj, but got I
		//IL_0744: Expected I, but got Obj
		//IL_075a: Expected Obj, but got I
		//IL_04b9: Expected I, but got Obj
		//IL_04cf: Expected Obj, but got I
		//IL_098d: Expected Obj, but got I4
		//IL_0b0a: Expected Obj, but got I4
		//IL_0731: Expected Obj, but got I4
		//IL_0a47: Expected Obj, but got I4
		//IL_0280: Expected I, but got Obj
		//IL_0785: Expected I, but got Obj
		//IL_04fa: Expected I, but got Obj
		//IL_02cd: Expected Obj, but got I4
		//IL_0547: Expected Obj, but got I4
		//IL_07f5: Expected Obj, but got I4
		if (Input.GetMouseButtonUp(0))
		{
			nint num = (nint)typeof(MeFooterNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v94 (Il2CppClass<MeFooterNavigation>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(MeFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v103 (Il2CppClass<MeFooterNavigation>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int index = _selectedTab - 1;
			UITexture uITexture = _buttonHighlight.get_Item(index);
			uITexture.tag = null;
		}
		if (Input.GetKeyDown((string)276))
		{
			nint num3 = (nint)typeof(MeFooterNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v158 (Il2CppClass<MeFooterNavigation>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(MeFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v222 (Il2CppClass<MeFooterNavigation>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int selectedTab;
			if (_selectedTab > 1)
			{
				nint num5 = (nint)typeof(MeFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v208 (Il2CppClass<MeFooterNavigation>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(MeFooterNavigation);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v216 (Il2CppClass<MeFooterNavigation>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				selectedTab = _selectedTab - 1;
			}
			else
			{
				selectedTab = 4;
			}
			nint num7 = (nint)typeof(MeFooterNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v168 (Il2CppClass<MeFooterNavigation>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(MeFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v200 (Il2CppClass<MeFooterNavigation>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_selectedTab = selectedTab;
			int num9 = 0;
			while (num9 <= 3)
			{
				nint num10 = (nint)typeof(MeFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v179 (Il2CppClass<MeFooterNavigation>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num11 = (nint)typeof(MeFooterNavigation);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v194 (Il2CppClass<MeFooterNavigation>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj6 = _selectedTab - 1;
				bool flag = num9 == (nint)obj6;
				UITexture uITexture2 = _buttonHighlight.get_Item(num9);
				if (flag)
				{
					uITexture2.tag = (string)1;
					UIButtonOverlayOff uIButtonOverlayOff = buttons.get_Item(num9);
					BoxCollider component = uIButtonOverlayOff.GetComponent<BoxCollider>();
					component.isTrigger = true;
				}
				else
				{
					uITexture2.tag = null;
				}
				int num12 = num9 + 1;
				num9 = num12;
			}
		}
		if (Input.GetKeyDown((string)275))
		{
			nint num13 = (nint)typeof(MeFooterNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v87 (Il2CppClass<MeFooterNavigation>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num14 = (nint)typeof(MeFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v151 (Il2CppClass<MeFooterNavigation>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int selectedTab2;
			if (_selectedTab < 4)
			{
				nint num15 = (nint)typeof(MeFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v137 (Il2CppClass<MeFooterNavigation>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num16 = (nint)typeof(MeFooterNavigation);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v145 (Il2CppClass<MeFooterNavigation>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				selectedTab2 = _selectedTab + 1;
			}
			else
			{
				selectedTab2 = 1;
			}
			nint num17 = (nint)typeof(MeFooterNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v97 (Il2CppClass<MeFooterNavigation>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num18 = (nint)typeof(MeFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v129 (Il2CppClass<MeFooterNavigation>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_selectedTab = selectedTab2;
			int num19 = 0;
			while (num19 <= 3)
			{
				nint num20 = (nint)typeof(MeFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S0_v108 (Il2CppClass<MeFooterNavigation>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num21 = (nint)typeof(MeFooterNavigation);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v123 (Il2CppClass<MeFooterNavigation>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj11 = _selectedTab - 1;
				bool flag2 = num19 == (nint)obj11;
				UITexture uITexture3 = _buttonHighlight.get_Item(num19);
				if (flag2)
				{
					uITexture3.tag = (string)1;
					UIButtonOverlayOff uIButtonOverlayOff2 = buttons.get_Item(num19);
					BoxCollider component2 = uIButtonOverlayOff2.GetComponent<BoxCollider>();
					component2.isTrigger = true;
				}
				else
				{
					uITexture3.tag = null;
				}
				int num22 = num19 + 1;
				num19 = num22;
			}
		}
		if (Input.GetKeyDown((string)273))
		{
			nint num23 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v38 (Il2CppClass<UIScreenController>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num24 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v82 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = UIScreenController.ShouldShowOnlineScreen();
			IEnumerator enumerator = ((UIScreenController)flag3).DelayHideMainCamera();
			if ((string)(object)enumerator != "CharacterScreen")
			{
				_0021_00210[] componentsInParent = (_0021_00210[])(object)((Component)this).GetComponentsInParent<T>();
				((Component)(object)componentsInParent).tag = (string)1;
			}
			nint num25 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S0_v48 (Il2CppClass<UIScreenController>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num26 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ S0_v76 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag4 = UIScreenController.ShouldShowOnlineScreen();
			IEnumerator enumerator2 = ((UIScreenController)flag4).DelayHideMainCamera();
			if ((string)(object)enumerator2 != "BoardScreen")
			{
				_0021_00210[] componentsInParent2 = (_0021_00210[])(object)((Component)this).GetComponentsInParent<T>();
				((Component)(object)componentsInParent2).tag = (string)1;
			}
			nint num27 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ S0_v58 (Il2CppClass<UIScreenController>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num28 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S0_v70 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag5 = UIScreenController.ShouldShowOnlineScreen();
			IEnumerator enumerator3 = ((UIScreenController)flag5).DelayHideMainCamera();
			if ((string)(object)enumerator3 != "AwardsScreen")
			{
				_0021_00210[] componentsInParent3 = (_0021_00210[])(object)((Component)this).GetComponentsInParent<T>();
				((Component)(object)componentsInParent3).tag = (string)1;
			}
			tag = null;
		}
		if (!Input.GetKeyDown((string)13) && !Input.GetKeyDown((string)32))
		{
			return;
		}
		nint num29 = (nint)typeof(MeFooterNavigation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v24 (Il2CppClass<MeFooterNavigation>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num30 = (nint)typeof(MeFooterNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v29 (Il2CppClass<MeFooterNavigation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int index2 = _selectedTab - 1;
		UIButtonOverlayOff uIButtonOverlayOff3 = buttons.get_Item(index2);
		UIButtonChangeScreen component3 = uIButtonOverlayOff3.GetComponent<UIButtonChangeScreen>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	static MeFooterNavigation()
	{
		Utils.randomNumber = -1;
	}
}
