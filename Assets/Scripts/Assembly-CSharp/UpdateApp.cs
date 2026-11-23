using System;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
using SYBO.Subway.Info;
using UnityEngine;

public class UpdateApp : CharacterPopup
{
	private const string ONLINESETTINGS_LATESTVERSION_KEY = "latestversion";

	private const string ONLINESETTINGS_LATESTVERSION_CHANGELIST_KEY = "latestversion_changelist";

	private static bool isUpdateNowOnScreen;

	private static bool _hasShownThisSession;

	private UILabel updateLabel;

	private UILabel theLabel;

	private UILabel appLabel;

	private UILabel changeListLabel;

	private void Awake()
	{
		if (updateLabel != null && theLabel != null && appLabel != null)
		{
			string text = Strings.Get(StringID.UPDATE_APP_POPUP_UPDATE);
			updateLabel.text = text;
			string text2 = Strings.Get(StringID.UPDATE_APP_POPUP_THE);
			theLabel.text = text2;
			string text3 = Strings.Get(StringID.UPDATE_APP_POPUP_APP);
			appLabel.text = text3;
		}
	}

	public unsafe override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_004a: Expected VT, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected VT, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Ref, but got Unknown
		//IL_00dc: Expected Obj, but got I
		object obj = default;
		Vector3? vector = (Vector3?)(object)(obj - 80);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		base.Show();
		object obj2 = (Nullable)vector - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+40]");
		_ = 0;
		object obj3 = (Nullable)vector + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+30]");
		vector = (Vector3?)(object)0;
		Vector2? offsetFromAnchor = (Vector2?)(object)((Nullable)vector + 16);
		SetCharacter(Characters.CharacterType.slick, offsetFromAnchor, vector);
		OnlineSettings instance = OnlineSettings.instance;
		if (instance.TryGetValue("latestversion_changelist", out *(string*)((Nullable)vector + 76)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+4C]");
			string text = (string)0 + "\n";
			changeListLabel.text = text;
		}
		else
		{
			changeListLabel.text = "New Content\n";
		}
	}

	private void CloseClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups(screenName);
		isUpdateNowOnScreen = false;
		GameObject gameObject = base.gameObject;
		string goName = gameObject.name;
		string flurryPopUpWithOkAndCloseName = UIScreens.GetFlurryPopUpWithOkAndCloseName(goName);
		Flurry.LogClosePressedOnPopup(flurryPopUpWithOkAndCloseName);
	}

	private void OkClicked()
	{
		string appStoreURL = Globals.AppStoreURL;
		Application.OpenURL(appStoreURL);
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups(screenName);
		isUpdateNowOnScreen = false;
		GameObject gameObject = base.gameObject;
		string goName = gameObject.name;
		string flurryPopUpWithOkAndCloseName = UIScreens.GetFlurryPopUpWithOkAndCloseName(goName);
		Flurry.LogOkPressedOnPopup(flurryPopUpWithOkAndCloseName);
	}

	public static void AllowAgainThisSession()
	{
		_hasShownThisSession = false;
	}

	public unsafe static void ShowIfNeeded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ae: Expected Obj, but got I4
		//IL_0092: Expected Obj, but got I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Ref, but got Unknown
		//IL_0284: Expected Obj, but got I
		//IL_02af: Expected Obj, but got I
		//IL_02d4: Expected Obj, but got I
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		if (isUpdateNowOnScreen)
		{
			return;
		}
		UIScreenController instance = UIScreenController.Instance;
		string currentPopupName = instance.GetCurrentPopupName();
		if (!(currentPopupName != "EventsPopup"))
		{
			return;
		}
		string appStoreURL = Globals.AppStoreURL;
		object obj3;
		if (appStoreURL != null)
		{
			obj3 = 0;
			if (appStoreURL._stringLength != 0)
			{
				goto IL_0549;
			}
		}
		obj3 = 1;
		goto IL_0549;
		IL_0549:
		if (obj3 != null)
		{
			return;
		}
		OnlineSettings instance2 = OnlineSettings.instance;
		if (!instance2.TryGetValue("latestversion", out *(string*)(obj + 12)))
		{
			return;
		}
		string bundleVersion = DeviceUtility.GetBundleVersion();
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag = (nint)0 == 1;
		bool flag2 = !flag;
		object obj5 = default;
		object obj4 = obj5;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj6 = default;
			object obj7 = default;
			bool flag3 = obj6 == obj7;
			bool flag4 = !flag3;
			obj4 = obj5;
			object obj9 = default;
			object obj8 = obj9;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 == 1;
				object obj10 = default;
				obj4 = obj10;
				if (!flag5)
				{
					object obj12 = default;
					object obj11 = obj12;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 == 1;
					object obj13 = default;
					obj4 = obj13;
					if (!flag6)
					{
						if (obj13 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
							object obj14 = (nint)0 << 2;
							object obj15 = obj + obj14;
							obj15 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
							object obj16 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
							object obj17 = (nint)0 << 2;
							object obj18 = obj17 + obj;
							object obj19 = obj18 - 4;
							object obj20 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
							throw new ArrayTypeMismatchException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
						object obj21 = obj12;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag7 = (nint)0 != 1;
						obj4 = obj13;
						if (flag7)
						{
							return;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag8 = (nint)0 == 1;
				object obj22 = default;
				obj8 = obj22;
				if (flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		if ((nint)obj4 <= -1 && !_hasShownThisSession)
		{
			UIScreenController instance3 = UIScreenController.Instance;
			instance3.QueuePopup("UpdateAppPopup");
			isUpdateNowOnScreen = true;
			_hasShownThisSession = true;
		}
	}
}
