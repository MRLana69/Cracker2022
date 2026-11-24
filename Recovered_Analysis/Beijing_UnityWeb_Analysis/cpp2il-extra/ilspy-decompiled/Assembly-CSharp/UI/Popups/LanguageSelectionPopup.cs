using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using Kiloo.Common.LocalizationManager;
using Kiloo.Common.UI;
using SYBO.Components.Logging.Ftp;
using UI.Pages;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class LanguageSelectionPopup : UIScreen
{
	private class LanguageListAdapter : ListAdapter<Locale>
	{
		private GameObject _languageCell;

		private LanguageSelectionPopup _languagePopup;

		public LanguageListAdapter(List<Locale> list, GameObject cell, LanguageSelectionPopup popup)
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Expected Obj, but got Unknown
			//IL_0149: Expected Obj, but got I4
			//IL_0621: Expected Obj, but got I
			//IL_062a: Unknown result type (might be due to invalid IL or missing references)
			//IL_062f: Expected Obj, but got Unknown
			//IL_01d1: Expected Obj, but got I
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Expected Obj, but got Unknown
			//IL_0674: Unknown result type (might be due to invalid IL or missing references)
			//IL_0679: Expected Obj, but got Unknown
			//IL_05bc: Expected Obj, but got I
			//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ca: Expected Obj, but got Unknown
			//IL_05dd: Expected Obj, but got I4
			//IL_0195: Expected Obj, but got I
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected Obj, but got Unknown
			//IL_01b6: Expected Obj, but got I4
			//IL_03ff: Expected Obj, but got I
			//IL_028e: Expected Obj, but got I
			//IL_04cb: Expected Obj, but got I
			//IL_02ee: Expected Obj, but got I
			//IL_048f: Expected Obj, but got I
			//IL_0498: Unknown result type (might be due to invalid IL or missing references)
			//IL_049d: Expected Obj, but got Unknown
			//IL_04b0: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.LanguageSelectionPopup+LanguageListAdapter)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.LanguageSelectionPopup+LanguageListAdapter)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.LanguageSelectionPopup+LanguageListAdapter)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj25 = default;
			object obj17 = default;
			object obj23 = default;
			for (; obj5 != obj3; obj5 = obj25 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+14]");
				LanguageSelectionPopup languageSelectionPopup = (LanguageSelectionPopup)0;
				if ((nint)languageSelectionPopup._adapter == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (UI.Popups.LanguageSelectionPopup)+2A]");
				bool flag = (nint)0 == 3;
				object obj10 = ((UIScreen)languageSelectionPopup).parentScreen__BackingField & 0x10;
				bool flag2 = obj10 == null;
				object obj11 = (flag2 ? 1 : 0) ^ 1;
				LanguageSelectionPopup languageSelectionPopup3;
				LanguageSelectionPopup languageSelectionPopup2;
				if (obj11 != null)
				{
					if (flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
						object obj12 = (nint)0 & (nint)0x1FFF;
						languageSelectionPopup2 = (LanguageSelectionPopup)(obj12 + 113696);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v197 @ S4_v16 (UI.Popups.LanguageSelectionPopup) (should have been resolved before IL gen)");
						languageSelectionPopup3 = (LanguageSelectionPopup)113696;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x7FF;
						languageSelectionPopup3 = (LanguageSelectionPopup)(obj13 + 121922);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v195 @ S5_v6 (UI.Popups.LanguageSelectionPopup) (should have been resolved before IL gen)");
						languageSelectionPopup2 = languageSelectionPopup;
					}
					continue;
				}
				bool flag3 = (nint)languageSelectionPopup._adapter != -1;
				if (!flag)
				{
					if (flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+10]");
						bool flag4;
						if ((nint)0 != 0)
						{
							object obj14 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v94+9C]");
							object obj15 = (nint)0 & (nint)0x100;
							flag4 = obj15 != null;
						}
						else
						{
							flag4 = false;
						}
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.LanguageSelectionPopup+LanguageListAdapter)+C]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (UI.Popups.LanguageSelectionPopup)+2B]");
								object obj16 = (nint)0 & (nint)3;
								bool flag5 = (nint)obj16 == 2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
								if (flag5)
								{
									if (obj17 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A77");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A78");
									}
								}
								else if (obj17 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
									languageSelectionPopup2 = popup;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
								}
								continue;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
					object obj18 = (nint)0 & (nint)0x1FFF;
					languageSelectionPopup2 = (LanguageSelectionPopup)(obj18 + 113696);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v197 @ S4_v16 (UI.Popups.LanguageSelectionPopup) (should have been resolved before IL gen)");
					languageSelectionPopup3 = (LanguageSelectionPopup)113696;
					continue;
				}
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+10]");
					bool flag6;
					if ((nint)0 != 0)
					{
						object obj19 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v66+9C]");
						object obj20 = (nint)0 & (nint)0x100;
						flag6 = obj20 != null;
					}
					else
					{
						flag6 = false;
					}
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.LanguageSelectionPopup+LanguageListAdapter)+C]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+10]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
								object obj21 = (nint)0 & (nint)0x1FFF;
								languageSelectionPopup2 = (LanguageSelectionPopup)(obj21 + 113696);
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v197 @ S4_v16 (UI.Popups.LanguageSelectionPopup) (should have been resolved before IL gen)");
								languageSelectionPopup3 = (LanguageSelectionPopup)113696;
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (UI.Popups.LanguageSelectionPopup)+2B]");
							object obj22 = (nint)0 & (nint)3;
							bool flag7 = (nint)obj22 == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
							if (flag7)
							{
								if (obj23 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8961");
									languageSelectionPopup2 = popup;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8962");
									languageSelectionPopup2 = popup;
								}
							}
							else if (obj23 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77FE");
								languageSelectionPopup3 = popup;
								languageSelectionPopup2 = (LanguageSelectionPopup)(object)cell;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
								languageSelectionPopup2 = popup;
							}
							continue;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
				object obj24 = (nint)0 & (nint)0x7FF;
				languageSelectionPopup3 = (LanguageSelectionPopup)(obj24 + 121922);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v195 @ S5_v6 (UI.Popups.LanguageSelectionPopup) (should have been resolved before IL gen)");
				languageSelectionPopup2 = languageSelectionPopup;
			}
		}

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false)
		{
			//IL_001e: Expected I4, but got Obj
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_004b: Expected Obj, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Container container2 = default;
			Container container3 = default;
			if (container2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				container3.Measure((byte)(int)_languageCell != 0);
				object obj = container3 + 84;
				_0021_00210 componentInChildren = (_0021_00210)container3.model.GetComponentInChildren<T>();
				obj = componentInChildren;
			}
			if (!isMeasurePass)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
				DailyChallengePage dailyChallengePage = default;
				UIWidget pageGuideWidget = default;
				dailyChallengePage.Init(pageGuideWidget);
			}
			return container3;
		}
	}

	private LanguageListAdapter _adapter;

	private GameObject _languageCell;

	private ScrollView _languageListView;

	private UILabel _popupSubtitle;

	private UILabel _popupTitle;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void Show()
	{
		//IL_007c: Expected Obj, but got I
		//IL_0032: Expected I4, but got Obj
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_005b: Expected I4, but got Obj
		ShowIfInactive();
		X509Certificate2Collection x509Certificate2Collection = TrustedRoots.LoadTrusted();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (System.Security.Cryptography.X509Certificates.X509Certificate2Collection)+C]");
		IEnumerable<_0021_00210> message = (IEnumerable<_0021_00210>)Enumerable.OfType<TResult>((IEnumerable)0);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Collections.Generic.IEnumerable`1<TResult>)+C]");
			if ((nint)0 > (nint)6)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		FtpClient.FtpException ex = default;
		ex._002Ector((string)(object)message, (Exception)(object)_languageCell, (int)this);
		object obj = this + 40;
		obj = ex;
		_languageListView.CalculateVirtualRelativeWidgetBounds((ScrollView.BoundsCalculationMode)_adapter);
	}

	public override void GainFocus()
	{
		base.Hide();
		this._002Ector();
	}

	private void SetBackButtonEnabledState(bool state)
	{
		//IL_0017: Expected Obj, but got I4
		//IL_002a: Expected Obj, but got I4
		//IL_01f8: Expected Obj, but got I4
		//IL_01f8: Expected Obj, but got I
		//IL_0213: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).DeactivateModelScreen(UIModelController.ModelScreen.TutorialPopup);
		object obj = (state ? 1 : 0) - 1;
		if (!state)
		{
			if ((nint)obj == 1)
			{
				return;
			}
			if ((nint)obj != 2)
			{
				if ((nint)obj != 3 && (nint)obj != 4 && (nint)obj != 5 && (nint)obj != 6 && (nint)obj != 7 && (nint)obj != 8 && (nint)obj != 9 && (nint)obj != 10 && (nint)obj != 11 && (nint)obj != 12 && (nint)obj != 13 && (nint)obj == 14)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.LanguageSelectionPopup)+80]");
					((GameObject)0).tag = (string)1;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.LanguageSelectionPopup)+7C]");
				((GameObject)0).tag = (string)1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.LanguageSelectionPopup)+78]");
			((GameObject)0).tag = (string)1;
		}
	}

	public override void LoseFocus()
	{
		//IL_000b: Expected Obj, but got I4
		OnClickContainer((GameObject)1);
	}

	private void UpdateLabels()
	{
		OnClickContainer(null);
	}

	private void OnClickContainer(GameObject go)
	{
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected Obj, but got VT
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)componentInChildren))
		{
			((Component)componentInChildren).tag = (string)(object)go;
		}
	}

	public LanguageSelectionPopup()
	{
		//IL_0088: Expected I, but got Obj
		//IL_009e: Expected Obj, but got I
		//IL_00d8: Expected I4, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v14 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("SETTINGS_POPUP_LANGUAGE_TITLE");
		_popupTitle.fontSize = (int)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B5E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v11+8]");
		object obj2 = 0;
		UILabel popupSubtitle = _popupSubtitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v12+1C]");
		popupSubtitle.fontSize = 0;
	}
}
