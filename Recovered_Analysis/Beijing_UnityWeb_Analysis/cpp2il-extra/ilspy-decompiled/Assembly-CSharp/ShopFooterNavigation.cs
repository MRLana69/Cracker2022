using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.MessageCenter;
using UnityEngine;

public class ShopFooterNavigation : MonoBehaviour
{
	public List<UIButtonOverlayOff> buttons;

	private List<UITexture> _buttonHighlight;

	public static int _selectedTab;

	private void OnEnable()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UITexture> list = default;
		list._002Ector();
		object obj = this + 16;
		obj = list;
		_ = 1;
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
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_029e: Expected Obj, but got I4
		//IL_00c7: Expected I, but got Obj
		//IL_0045: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I4
		//IL_0191: Expected I, but got Obj
		//IL_01a7: Expected Obj, but got I
		//IL_01d2: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UITexture> list = default;
		list._002Ector();
		object obj = this + 16;
		obj = list;
		int num = 0;
		while (num <= 2)
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v45 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag2).DelayHideMainCamera();
		bool flag3 = (string)(object)enumerator != "UpgradesUI_shop";
		UITexture uITexture = _buttonHighlight.get_Item(0);
		uITexture.tag = null;
		UITexture uITexture2 = _buttonHighlight.get_Item(1);
		uITexture2.tag = (string)flag3;
		UITexture uITexture3 = _buttonHighlight.get_Item(2);
		string text = (string)((flag3 ? 1 : 0) ^ 1);
		uITexture3.tag = text;
		nint num5 = (nint)typeof(ShopFooterNavigation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v33 (Il2CppClass<ShopFooterNavigation>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(ShopFooterNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v39 (Il2CppClass<ShopFooterNavigation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int selectedTab = ((!flag3) ? 3 : 2);
		_selectedTab = selectedTab;
	}

	public ShopFooterNavigation()
	{
		//IL_009d: Expected Obj, but got I4
		//IL_08b3: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_091b: Expected Obj, but got I4
		//IL_00c8: Expected I, but got Obj
		//IL_00de: Expected Obj, but got I
		//IL_05dd: Expected I, but got Obj
		//IL_05f3: Expected Obj, but got I
		//IL_0342: Expected I, but got Obj
		//IL_0358: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_05b8: Expected Obj, but got I4
		//IL_0109: Expected I, but got Obj
		//IL_061e: Expected I, but got Obj
		//IL_0383: Expected I, but got Obj
		//IL_0876: Expected I, but got Obj
		//IL_088c: Expected Obj, but got I
		//IL_0156: Expected I, but got Obj
		//IL_016c: Expected Obj, but got I
		//IL_08de: Expected I, but got Obj
		//IL_08f4: Expected Obj, but got I
		//IL_03d0: Expected I, but got Obj
		//IL_03e6: Expected Obj, but got I
		//IL_01f2: Expected I, but got Obj
		//IL_0197: Expected I, but got Obj
		//IL_046c: Expected I, but got Obj
		//IL_0411: Expected I, but got Obj
		//IL_023f: Expected I, but got Obj
		//IL_0255: Expected Obj, but got I
		//IL_04b9: Expected I, but got Obj
		//IL_04cf: Expected Obj, but got I
		//IL_0719: Expected Obj, but got I4
		//IL_07d3: Expected Obj, but got I4
		//IL_0280: Expected I, but got Obj
		//IL_04fa: Expected I, but got Obj
		//IL_02cd: Expected Obj, but got I4
		//IL_0547: Expected Obj, but got I4
		if (Input.GetMouseButtonUp(0))
		{
			nint num = (nint)typeof(ShopFooterNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v67 (Il2CppClass<ShopFooterNavigation>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(ShopFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v76 (Il2CppClass<ShopFooterNavigation>)+74]");
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
			nint num3 = (nint)typeof(ShopFooterNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v106 (Il2CppClass<ShopFooterNavigation>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(ShopFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v170 (Il2CppClass<ShopFooterNavigation>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int selectedTab;
			if (_selectedTab > 1)
			{
				nint num5 = (nint)typeof(ShopFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v156 (Il2CppClass<ShopFooterNavigation>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(ShopFooterNavigation);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v164 (Il2CppClass<ShopFooterNavigation>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				selectedTab = _selectedTab - 1;
			}
			else
			{
				selectedTab = 3;
			}
			nint num7 = (nint)typeof(ShopFooterNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v116 (Il2CppClass<ShopFooterNavigation>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(ShopFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v148 (Il2CppClass<ShopFooterNavigation>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_selectedTab = selectedTab;
			int num9 = 0;
			while (num9 <= 2)
			{
				nint num10 = (nint)typeof(ShopFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v127 (Il2CppClass<ShopFooterNavigation>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num11 = (nint)typeof(ShopFooterNavigation);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v142 (Il2CppClass<ShopFooterNavigation>)+74]");
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
			nint num13 = (nint)typeof(ShopFooterNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v35 (Il2CppClass<ShopFooterNavigation>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num14 = (nint)typeof(ShopFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v99 (Il2CppClass<ShopFooterNavigation>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int selectedTab2;
			if (_selectedTab < 3)
			{
				nint num15 = (nint)typeof(ShopFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v85 (Il2CppClass<ShopFooterNavigation>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num16 = (nint)typeof(ShopFooterNavigation);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v93 (Il2CppClass<ShopFooterNavigation>)+74]");
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
			nint num17 = (nint)typeof(ShopFooterNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v45 (Il2CppClass<ShopFooterNavigation>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num18 = (nint)typeof(ShopFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v77 (Il2CppClass<ShopFooterNavigation>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_selectedTab = selectedTab2;
			int num19 = 0;
			while (num19 <= 2)
			{
				nint num20 = (nint)typeof(ShopFooterNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S0_v56 (Il2CppClass<ShopFooterNavigation>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num21 = (nint)typeof(ShopFooterNavigation);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S0_v71 (Il2CppClass<ShopFooterNavigation>)+74]");
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
		if (!Input.GetKeyDown((string)13) && !Input.GetKeyDown((string)32))
		{
			return;
		}
		nint num23 = (nint)typeof(ShopFooterNavigation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v21 (Il2CppClass<ShopFooterNavigation>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num24 = (nint)typeof(ShopFooterNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v26 (Il2CppClass<ShopFooterNavigation>)+74]");
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

	static ShopFooterNavigation()
	{
		MyTourNavigation._selectedTab = 1;
	}
}
