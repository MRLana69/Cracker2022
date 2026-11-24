using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Common.UI;
using Kiloo.Common.Utility;
using TopRun;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Screens;
using UnityEngine;

public class CountryPopup : UIScreen
{
	private class CountryListAdapter : ListAdapter<Country>
	{
		private GameObject _countryCell;

		private CountryPopup _countryPopup;

		public CountryListAdapter(List<Country> countryList, GameObject cell, CountryPopup popup)
		{
			//IL_0049: Expected Obj, but got I
			//IL_005a: Expected Obj, but got VT
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountryPopup+CountryListAdapter)+8]");
			object obj = 0;
			DateTime utcNow = CDateTime.UtcNow;
			object obj2 = utcNow;
			object obj3 = obj2 + 8;
			obj3 = obj2;
			if ((object)popup == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountryPopup+CountryListAdapter)+C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
				}
			}
		}

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false)
		{
			//IL_0009: Expected Obj, but got I4
			object obj = 0;
			obj = container;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
			Container result = default;
			return result;
		}
	}

	private sealed class _003CDelayedSelect_003Ed__11(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CountryPopup _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Expected Obj, but got Unknown
				//IL_0062: Expected Obj, but got I4
				//IL_0076: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						_003C_003E4__this.Hide();
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj = this + 12;
				obj = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private ScrollView countryListView;

	private GameObject countryCell;

	private UILabel popupTitle;

	private UISprite currentCountryFlag;

	private UILabel currentCountryName;

	private UILabel infoText;

	private HorizontalLayout currentCountryLayout;

	private CountryListAdapter _adapter;

	private bool _firstShow;

	public override void Init()
	{
	}

	public unsafe override void Show()
	{
		//IL_0023: Expected VT, but got Obj
		//IL_0023: Expected VT, but got Obj
		//IL_0023: Expected VT, but got Obj
		//IL_001e: Expected native int or pointer, but got VT
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_003b: Expected Obj, but got VT
		//IL_004c: Expected I4, but got Obj
		//IL_005a: Expected I, but got Obj
		//IL_0070: Expected Obj, but got I
		//IL_0260: Expected I4, but got Obj
		//IL_00e9: Expected I4, but got Obj
		//IL_00f7: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I
		//IL_009b: Expected I, but got Obj
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_028a: Expected Obj, but got VT
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected VT, but got Unknown
		//IL_02bb: Expected F4, but got Obj
		//IL_02b6: Expected native int or pointer, but got VT
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_02e3: Expected F4, but got Obj
		//IL_02de: Expected native int or pointer, but got VT
		//IL_02f8: Expected F4, but got I
		//IL_02f3: Expected native int or pointer, but got VT
		//IL_0307: Expected I4, but got VT
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_031e: Expected Obj, but got VT
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_0341: Expected F4, but got Obj
		//IL_033c: Expected native int or pointer, but got VT
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0184: Expected F4, but got Obj
		//IL_017f: Expected native int or pointer, but got VT
		//IL_0199: Expected F4, but got I
		//IL_0194: Expected native int or pointer, but got VT
		//IL_01a8: Expected I4, but got VT
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01bf: Expected Obj, but got VT
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_01e2: Expected F4, but got Obj
		//IL_01dd: Expected native int or pointer, but got VT
		//IL_0138: Expected I, but got Obj
		//IL_0201: Expected F4, but got Obj
		//IL_01fc: Expected native int or pointer, but got VT
		//IL_0216: Expected F4, but got I
		//IL_0211: Expected native int or pointer, but got VT
		//IL_0225: Expected I4, but got VT
		ShowIfInactive();
		TopRunEventsHandler instance = TopRunEventsHandler.instance;
		CountryManager instance2 = CountryManager.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PrizePositionData.TransformValues transformValues = default;
		*(PrizePositionData.TransformValues*)(nint)transformValues = new PrizePositionData.TransformValues((Vector3)instance2, (Vector3)countryCell, (Vector3)this);
		object obj = this + 68;
		obj = transformValues;
		countryListView.CalculateVirtualRelativeWidgetBounds((ScrollView.BoundsCalculationMode)_adapter);
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v10 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v61 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("SETTINGS_POPUP_COUNTRY_TITLE");
		popupTitle.fontSize = (int)text;
		string text2 = Strings.GetDefault("SETTINGS_POPUP_COUNTRY_DESCRIPTION");
		infoText.fontSize = (int)text2;
		nint num3 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v21 (Il2CppClass<GlobalColors>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v55 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		object obj4 = obj5 + 68;
		obj4 = GlobalColors.COUNTRY_POPUP_TITLE_COLOUR;
		object obj6 = obj5 + 72;
		obj6 = obj4;
		Matrix4x4 matrix4x = (Matrix4x4)(obj5 + 80);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		object obj7 = obj5 + 48;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v32+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		popupTitle.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj8 = obj5 + 44;
		obj8 = GlobalColors.COUNTRY_POPUP_SUBTITLE_COLOUR;
		object obj9 = obj5 - -64;
		obj9 = obj8;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
		object obj10 = obj5 + 24;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S1_v42+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		currentCountryName.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj11 = obj5 + 16;
		obj11 = GlobalColors.COUNTRY_POPUP_INFO_TEXT_COLOUR;
		object obj12 = obj5 + 40;
		obj12 = obj11;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
		Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		infoText.rawPivot = (UIWidget.Pivot)matrix4x;
	}

	private IEnumerator DelayedSelect()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj2 = default;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			}
			CountryManager countryManager = default;
			string defaultCountryCodeFromDevice = countryManager.GetDefaultCountryCodeFromDevice();
			if (defaultCountryCodeFromDevice != null)
			{
				return (IEnumerator)(object)defaultCountryCodeFromDevice;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		IEnumerator enumerator = default;
		object obj3 = enumerator + 8;
		obj3 = "";
		object obj4 = enumerator + 12;
		obj4 = "";
		object obj5 = enumerator + 16;
		obj5 = "";
		return enumerator;
	}

	private void SelectCurrentCountry()
	{
		base.Hide();
		this._002Ector();
		if (~(_firstShow ? 1u : 0u) == 0)
		{
			TopRunPlayerCell playerScriptFromList = ((TopRunOnlineGameOverScreen)(object)this).GetPlayerScriptFromList();
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)playerScriptFromList);
			_firstShow = false;
		}
		else
		{
			Hide();
		}
	}

	public override void Hide()
	{
		//IL_002d: Expected VT, but got Obj
		TopRunEventsHandler instance = TopRunEventsHandler.instance;
		string countryCodeFromLocale = CountryManager.GetCountryCodeFromLocale((string)null);
		countryListView.SmoothScrollToOffset((Vector3)countryCodeFromLocale, (Action)null, 0f);
	}

	private unsafe void TournamentChanged(object sender, TournamentChangedEventArgs eventArg)
	{
		//IL_05d8: Expected Obj, but got I4
		//IL_05e6: Expected I, but got Obj
		//IL_05fc: Expected Obj, but got I
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Expected I, but got Unknown
		//IL_0088: Expected I, but got Obj
		//IL_009e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01ba: Expected Obj, but got I4
		//IL_01ba: Expected I4, but got Obj
		//IL_00c9: Expected I, but got Obj
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_0116: Expected I, but got Obj
		//IL_012c: Expected Obj, but got I
		//IL_0219: Expected I4, but got Obj
		//IL_022e: Expected Obj, but got I4
		//IL_023a: Expected I4, but got Obj
		//IL_0157: Expected I, but got Obj
		//IL_0290: Expected Obj, but got I4
		//IL_07d3: Expected I, but got Obj
		//IL_07e9: Expected Obj, but got I
		//IL_0282: Expected Obj, but got I4
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Expected Obj, but got Unknown
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected Obj, but got Unknown
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected Obj, but got Unknown
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected Obj, but got Unknown
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected Obj, but got Unknown
		//IL_02d5: Expected I, but got Obj
		TournamentChangedEventArgs e = (TournamentChangedEventArgs)0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v130 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = default;
		nint num3 = (nint)(transform + 48);
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)(object)_adapter) || (_firstShow ? 1 : 0) != (nint)_footerPrefab)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v107 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v136 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)(object)_adapter))
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v127 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v132 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object)(object)_adapter);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Logger logger = default;
			logger.Log((LogType)_footerPrefab, _footerPrefab, (UnityEngine.Object)16);
			object obj4 = this + 68;
			obj4 = logger;
			int hashCode = base.GetHashCode();
			((IntPtr*)num3)->m_value = (void*)hashCode;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text2 = default;
			string text = "__SurfaceReflection" + text2;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)_adapter, (byte)(int)text != 0);
			UnityEngine.Object.CheckNullArgument((object)_adapter, (string)52);
			_firstShow = (byte)(int)_footerPrefab != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object obj5 = default;
		object obj6;
		if (obj5 == null)
		{
			obj6 = 0;
		}
		else
		{
			obj6 = ((obj5 != typeof(Camera)) ? ((object)0) : obj5);
		}
		e = (TournamentChangedEventArgs)obj6;
		if (obj5 == null || obj5 == typeof(Camera))
		{
		}
		nint num8 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S1_v93 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = transform + 32;
		object obj9 = transform + 28;
		object obj10 = transform + 40;
		object obj11 = transform + 36;
		Transform transform2 = (Transform)(transform + 16);
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)(object)eventArg))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
	}

	private void OnClickContainer(GameObject go)
	{
	}

	private void UpdatePopupUI()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		base.LoseFocus();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			object obj3 = default;
			object obj2 = obj3 + 16;
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
	}

	public CountryPopup()
	{
		//IL_002b: Expected I, but got Obj
		//IL_0041: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_00ff: Expected I4, but got Obj
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_006c: Expected I, but got Obj
		TopRunEventsHandler instance = TopRunEventsHandler.instance;
		IEnumerator enumerator = ((CountryPopup)null).DelayedSelect();
		UISprite uISprite = currentCountryFlag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v5 (System.Collections.IEnumerator)+C]");
		uISprite.fillCenter = false;
		TopRunEventsHandler instance2 = TopRunEventsHandler.instance;
		IEnumerator enumerator2 = ((CountryPopup)null).DelayedSelect();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S2_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v12 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v10 (System.Collections.IEnumerator)+8]");
		string text = Strings.GetDefault((string)0);
		currentCountryName.fontSize = (int)text;
		object obj2 = this - -64;
		((RewardForVideoButton)obj2).Init((VideoButtonPayload)null);
	}
}
