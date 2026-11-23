using System;
using System.Collections;
using Cpp2ILInjected;
using UnityEngine;

namespace UI;

public class DoubleCoinUpgradeHelper : DiscountButton
{
	private Vector3 _shownDiscStickerPos = (Vector3)4746794008372314112L;

	private Vector3 _shownDiscLabelPos;

	private Vector3 _shownDiscLabelSingleLinePos = (Vector3)4749045808186130432L;

	private string doubleCoinVersion;

	private bool _inited;

	public bool OnSale
	{
		get
		{
			if (InAppManager.IsDoubleCoinsDiscountActive)
			{
				string inAppOnlineSettingsId = InAppData.GetInAppOnlineSettingsId("com.kiloo.subways.doublecoins");
				int discountValue = InAppManager.GetDiscountValue(inAppOnlineSettingsId, 0);
				if (discountValue < 0)
				{
					return true;
				}
			}
			return false;
		}
	}

	private void ForceEndDiscount()
	{
		_Setup(forceEndDiscount: true);
	}

	private void _DefaultSetup(string data, bool wasRestored)
	{
		_Setup();
	}

	private void _Setup(bool forceEndDiscount = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_067c: Expected I, but got Obj
		//IL_0023: Expected I, but got Obj
		//IL_0219: Expected I, but got Obj
		//IL_0127: Expected I4, but got F8
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_087c: Expected I4, but got F4
		//IL_00c4: Expected I4, but got F8
		//IL_00df: Expected I4, but got F4
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Expected VT, but got Unknown
		//IL_0193: Expected I4, but got F8
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Expected Obj, but got Unknown
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected Obj, but got Unknown
		//IL_051f: Expected Obj, but got I8
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		_ = 0;
		PlayerInfo instance = PlayerInfo.Instance;
		int num6;
		UISprite uISprite;
		UISprite uISprite2;
		int num7;
		if (~(instance._hasDoubleCoinsUpgrade ? 1u : 0u) == 0)
		{
			doubleCoinVersion = "com.kiloo.subways.doublecoins";
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S3_v19 (Il2CppClass<UI.DoubleCoinUpgradeHelper>)+F4] (should have been resolved before IL gen)");
			fillColorSprite.spriteName = "button_check_grey";
			fillColorSprite.pivot = UIWidget.Pivot.Center;
			DeviceInfo instance2 = DeviceInfo.Instance;
			UISpriteData atlasSprite = fillColorSprite.GetAtlasSprite();
			if (~(instance2.isHighres__BackingField ? 1u : 0u) == 0)
			{
				float num2 = (float)atlasSprite.width * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num4 = default;
				double num3 = Math.Abs(num4);
				int width = ((!(num3 < 2147483648.0)) ? int.MinValue : ((int)num4));
				fillColorSprite.width = width;
				UISpriteData atlasSprite2 = fillColorSprite.GetAtlasSprite();
				float num5 = (float)atlasSprite2.height * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [53458A]");
				bool flag = (nint)0 == 0;
				num6 = (int)num5;
				uISprite = fillColorSprite;
				if (flag)
				{
					goto IL_013a;
				}
				num7 = (int)num5;
				uISprite2 = fillColorSprite;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num9 = default;
				double num8 = Math.Abs(num9);
				int width2 = ((!(num8 < 2147483648.0)) ? int.MinValue : ((int)num9));
				fillColorSprite.width = width2;
				UISpriteData atlasSprite3 = fillColorSprite.GetAtlasSprite();
				num6 = atlasSprite3.height;
				uISprite = fillColorSprite;
				num7 = atlasSprite3.height;
				uISprite2 = fillColorSprite;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [53458A]");
				if ((nint)0 == 0)
				{
					goto IL_013a;
				}
			}
			goto IL_0894;
		}
		if (OnSale && !forceEndDiscount)
		{
			doubleCoinVersion = "com.kiloo.subways.doublecoinsdiscount";
			nint num10 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v125 @ S3_v7 (Il2CppClass<UI.DoubleCoinUpgradeHelper>)+EC] (should have been resolved before IL gen)");
			Transform transform = base.transform;
			Transform parent = transform.parent;
			string text = parent.name;
			if (!(text != "000"))
			{
				return;
			}
			Transform transform2 = base.transform;
			Transform parent2 = transform2.parent;
			IEnumerator enumerator = parent2.GetEnumerator();
			object obj3 = obj + 88;
			object obj4 = obj + 92;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			_ = 0;
			object obj5 = default;
			object obj7 = default;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					break;
				}
				if (obj5 == null)
				{
					object obj6 = obj + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
					return;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj7 != null)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										break;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										break;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										break;
									}
									_ = 0;
									_ = 0;
									_ = -4425349583844933632L;
									_ = 0;
									obj = -4425349583844933632L;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										break;
									}
								}
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj8 = default;
			object obj9 = default;
			bool flag2 = obj8 != obj9;
			object obj11 = default;
			object obj10 = obj11;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj12 = obj + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
					goto IL_066c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj13 = default;
				obj10 = obj13;
			}
			_ = 0;
			object obj14 = obj + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
		}
		goto IL_066c;
		IL_066c:
		doubleCoinVersion = "com.kiloo.subways.doublecoins";
		nint num11 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S3_v4 (Il2CppClass<UI.DoubleCoinUpgradeHelper>)+F4] (should have been resolved before IL gen)");
		Transform transform3 = base.transform;
		Transform parent3 = transform3.parent;
		string text2 = parent3.name;
		if (text2 == "000")
		{
			Transform transform4 = base.transform;
			Transform transform5 = base.transform;
			Transform parent4 = transform5.parent;
			Transform parent5 = parent4.parent;
			transform4.parent = parent5;
		}
		return;
		IL_0894:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num13 = default;
		double num12 = Math.Abs(num13);
		int height = ((!(num12 < 2147483648.0)) ? int.MinValue : ((int)num13));
		uISprite2.height = height;
		Transform cachedTransform = fillColorSprite.cachedTransform;
		_ = 0;
		_ = 0;
		_ = 4611686019547398144L;
		_ = 4611686019547398144L;
		Vector3 localPosition = (Vector3)(obj + 16);
		cachedTransform.localPosition = localPosition;
		price.enabled = false;
		BoxCollider component = GetComponent<BoxCollider>();
		component.enabled = false;
		return;
		IL_013a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_codegen_initialize_runtime_metadata\"");
		_ = 1;
		num7 = num6;
		uISprite2 = uISprite;
		goto IL_0894;
	}

	public void Init()
	{
		_inited = true;
		_Setup();
	}

	private unsafe void OnEnable()
	{
		InAppManager instance = InAppManager.instance;
		if (instance != null)
		{
			InAppManager instance2 = InAppManager.instance;
			InAppManager.OnPurchaseSuccess onPurchaseSuccess = default;
			onPurchaseSuccess._002Ector(this, (nint)__ldftn(DoubleCoinUpgradeHelper._DefaultSetup));
			instance2.onPurchaseSuccess += onPurchaseSuccess;
		}
		if (~(_inited ? 1u : 0u) == 0)
		{
			_Setup();
		}
	}

	private unsafe void OnDisable()
	{
		InAppManager instance = InAppManager.instance;
		if (instance != null)
		{
			InAppManager instance2 = InAppManager.instance;
			InAppManager.OnPurchaseSuccess onPurchaseSuccess = default;
			onPurchaseSuccess._002Ector(this, (nint)__ldftn(DoubleCoinUpgradeHelper._DefaultSetup));
			instance2.onPurchaseSuccess -= onPurchaseSuccess;
		}
	}

	private void UpdatePrice()
	{
		InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(doubleCoinVersion);
		string localizedPrice = inAppItemModel.LocalizedPrice;
		price.text = localizedPrice;
	}

	private void OnClick()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		if (~(instance._hasDoubleCoinsUpgrade ? 1u : 0u) != 0)
		{
			InAppManager instance2 = InAppManager.instance;
			instance2.StartPurchase(doubleCoinVersion);
		}
	}

	protected override void ShowOnPromotion(string productString, string sendDescription, string sendDescription2)
	{
		base.ShowOnPromotion(productString, sendDescription, sendDescription2);
		EnableDiscount();
	}

	protected override void ShowOnSale(string productString, string sendDescription = "")
	{
		base.ShowOnSale(productString, sendDescription);
		EnableDiscount();
	}

	protected override void ShowNoDiscount(string productString, string backupDescription = "")
	{
		base.ShowNoDiscount(productString, backupDescription);
		DisableDiscount();
	}

	private unsafe void EnableDiscount()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected VT, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected VT, but got Unknown
		//IL_00b8: Expected F4, but got I
		//IL_00b3: Expected native int or pointer, but got VT
		//IL_00c7: Expected F4, but got VT
		//IL_00c2: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		Transform cachedTransform = discountSticker.cachedTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DoubleCoinUpgradeHelper)+108]");
		_ = 0;
		_ = _shownDiscStickerPos;
		Vector3 localPosition = vector + 32;
		cachedTransform.localPosition = localPosition;
		Transform cachedTransform2 = discountLabel.cachedTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DoubleCoinUpgradeHelper)+114]");
		_ = 0;
		_ = _shownDiscLabelPos;
		Vector3 localPosition2 = vector + 16;
		cachedTransform2.localPosition = localPosition2;
		Transform cachedTransform3 = discountLabelSingleLine.cachedTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DoubleCoinUpgradeHelper)+120]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)_shownDiscLabelSingleLinePos;
		cachedTransform3.localPosition = vector;
	}

	private unsafe void DisableDiscount()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_007a: Expected I, but got Obj
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected VT, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected VT, but got Unknown
		//IL_0040: Expected native int or pointer, but got VT
		//IL_0054: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 96);
		Transform cachedTransform = discountSticker.cachedTransform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_ = 0;
		Vector3 localPosition = vector + 32;
		cachedTransform.localPosition = localPosition;
		Transform cachedTransform2 = discountLabel.cachedTransform;
		_ = -1082130432;
		_ = -1082130432;
		_ = 0;
		_ = 0;
		Vector3 localPosition2 = vector + 16;
		cachedTransform2.localPosition = localPosition2;
		Transform cachedTransform3 = discountLabelSingleLine.cachedTransform;
		_ = -1082130432;
		((Vector3*)(nint)vector)->z = -1f;
		_ = 0;
		((Vector3*)(nint)vector)->x = 0f;
		cachedTransform3.localPosition = vector;
	}

	public static void LogError(string msg, UnityEngine.Object context = null)
	{
	}

	public static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	public static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public DoubleCoinUpgradeHelper()
	{
		//IL_000f: Expected VT, but got I8
		//IL_001e: Expected VT, but got I8
		_ = 0;
		_ = 1105461248;
		_ = 4826169950680907776L;
		base._002Ector();
	}
}
