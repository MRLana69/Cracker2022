using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UnityEngine;

public class CodeVoucherPopup : CharacterPopup
{
	private const string COUNTRY_CODE_INDONESIA = "ID";

	private const string MAXIMUM_ALLOWED_BUNDLEVERSION = "1.58.0";

	private UILabel firstLabel;

	private UILabel secondLabel;

	private UILabel thirdLabel;

	private UILabel messageTitleLabel;

	private UILabel messageContentLabel;

	private UILabel messageContentLabel2;

	private void Awake()
	{
		if (firstLabel != null && secondLabel != null && thirdLabel != null && (bool)messageContentLabel && messageContentLabel2 != null && messageTitleLabel != null)
		{
			firstLabel.text = "Kode";
			secondLabel.text = "Voucher";
			thirdLabel.text = "sedia!";
			messageTitleLabel.text = "Sekarang Bisa Bayar Pakai Kode Voucher Lho!";
			messageContentLabel.text = "Beli Subway Surfers dengan kode voucher Google Play.";
			messageContentLabel2.text = "Dapatkan di toko-toko Indomaret terdekat sekarang juga!";
		}
	}

	public override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_00b2: Expected VT, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected VT, but got Unknown
		object obj = default;
		Vector3? vector = (Vector3?)(object)(obj - 80);
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
	}

	private void CloseClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups(screenName);
	}

	private void OkClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups(screenName);
	}

	private static bool IsIndonesian()
	{
		CountryManager instance = CountryManager.instance;
		string defaultCountryCodeFromDevice = instance.GetDefaultCountryCodeFromDevice();
		CountryManager instance2 = CountryManager.instance;
		Country currentTournamentCountry = instance2.GetCurrentTournamentCountry();
		string text = currentTournamentCountry.countryCode__BackingField.ToUpper();
		if (defaultCountryCodeFromDevice == "ID")
		{
			return true;
		}
		return text == "ID";
	}

	private static bool IsAllowedInBundleVersion()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected Obj, but got Unknown
		//IL_0268: Expected Obj, but got I
		//IL_0293: Expected Obj, but got I
		//IL_02b8: Expected Obj, but got I
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected Obj, but got Unknown
		//IL_04c7: Expected Obj, but got I
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool result;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj4 = default;
							object obj5 = default;
							bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
							result = flag;
							goto IL_048b;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj6 = default;
		object obj7 = default;
		bool flag2 = obj6 != obj7;
		bool flag3 = default;
		result = flag3;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj9 = default;
				object obj8 = obj9;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj10 = default;
					if (obj10 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj11 = (nint)0 << 2;
						object obj12 = obj3 + obj11;
						obj12 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj13 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj14 = (nint)0 << 2;
						object obj15 = obj14 + obj3;
						object obj16 = obj15 - 4;
						object obj17 = obj16;
						bool flag4 = obj16 == null;
						string text = "CodeVoucherPopup: Failed at parsing bundleversion! Probably due to incorrect formatting of bundleversion. Error: ";
						if (!flag4)
						{
							object obj18 = obj17;
							object obj19 = obj17 + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v303 @ S1_v53+D4] (should have been resolved before IL gen)");
							text = "CodeVoucherPopup: Failed at parsing bundleversion! Probably due to incorrect formatting of bundleversion. Error: ";
						}
						string text3 = default;
						string text2 = text + text3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj20 = -1;
						result = false;
						goto IL_048b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj21 = obj9;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag5 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					result = false;
					if (flag5)
					{
						goto IL_0490;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag6 = (nint)0 != 1;
			bool flag7 = default;
			result = flag7;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				result = flag7;
			}
		}
		goto IL_0490;
		IL_0490:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_048b;
		IL_048b:
		return result;
	}

	private static bool IsAndroidDevice()
	{
		RuntimePlatform platform = Application.platform;
		return platform == RuntimePlatform.Android;
	}

	public static void ShowOnFrontScreenIfNeeded()
	{
		if (!IsAndroidDevice() || !IsIndonesian() || !IsAllowedInBundleVersion())
		{
			return;
		}
		PlayerInfo instance = PlayerInfo.Instance;
		if (instance._hasShownVoucherPopupOnFrontScreen)
		{
			return;
		}
		UIScreenController instance2 = UIScreenController.Instance;
		string currentPopupName = instance2.GetCurrentPopupName();
		if (currentPopupName != "EventsPopup")
		{
			UIScreenController instance3 = UIScreenController.Instance;
			instance3.QueuePopup("CodeVoucherPopup");
			PlayerInfo instance4 = PlayerInfo.Instance;
			if (!instance4._hasShownVoucherPopupOnFrontScreen)
			{
				instance4._dirty = true;
				instance4._hasShownVoucherPopupOnFrontScreen = true;
			}
		}
	}

	public static void ShowInShopScreenIfNeeded()
	{
		if (!IsAndroidDevice() || !IsIndonesian() || !IsAllowedInBundleVersion())
		{
			return;
		}
		PlayerInfo instance = PlayerInfo.Instance;
		if (instance._hasShownVoucherPopupInShop)
		{
			return;
		}
		UIScreenController instance2 = UIScreenController.Instance;
		string currentPopupName = instance2.GetCurrentPopupName();
		if (currentPopupName != "EventsPopup")
		{
			UIScreenController instance3 = UIScreenController.Instance;
			instance3.QueuePopup("CodeVoucherPopup");
			PlayerInfo instance4 = PlayerInfo.Instance;
			if (!instance4._hasShownVoucherPopupInShop)
			{
				instance4._dirty = true;
				instance4._hasShownVoucherPopupInShop = true;
			}
		}
	}
}
