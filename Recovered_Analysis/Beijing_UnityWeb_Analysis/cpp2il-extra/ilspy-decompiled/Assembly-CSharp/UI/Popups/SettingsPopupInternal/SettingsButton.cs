using System;
using Cpp2ILInjected;
using Data.Save;
using Kiloo.Analytics;
using Kiloo.Common.Extensions;
using SYBO.Subway.Info;
using UI.Breadcrumbs;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Popups.LimitedCharacterPopupInternal;
using UI.Screens;
using UnityEngine;

namespace UI.Popups.SettingsPopupInternal;

public class SettingsButton : MonoBehaviour
{
	public class SettingsButtonPayload
	{
		public Action<UILabel> setTitle;

		public Action<UILabel> setDescription;

		public string descriptionID;

		public Action onClick;

		public Action<GameObject> setOfflineIndicator;

		public string iconName;

		public Vector3 iconOffset;

		public Breadcrumb.BreadcrumbEvent[] breadcrumbEvents;

		public Func<bool> shouldDisable;

		public Action<UISprite> setIcon;

		public SettingsButtonPayload()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private UISprite _icon;

	private UISprite _offIndicatorIcon;

	private UILabel _title;

	private UILabel _description;

	private Layout _layout;

	private Breadcrumb _breadcrumb;

	private UISprite _disableOverlay;

	private Collider _buttonCollider;

	private SettingsButtonPayload _payload;

	private unsafe bool buttonDisabled
	{
		get
		{
			//IL_005b: Expected Obj, but got I4
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_00ad: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			object obj = 0;
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool hasPurchasedOrRestored = UserSave.hasPurchasedOrRestored;
			obj = hasPurchasedOrRestored;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			bool result = default;
			return result;
		}
		set
		{
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Expected Obj, but got Unknown
			//IL_01c8: Expected Obj, but got I4
			//IL_01e6: Expected I4, but got Obj
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Expected Obj, but got Unknown
			//IL_0012: Expected VT, but got Obj
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected Obj, but got Unknown
			//IL_0053: Expected I, but got Obj
			//IL_0069: Expected Obj, but got I
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Expected VT, but got Unknown
			//IL_022d: Expected F4, but got Obj
			//IL_0228: Expected native int or pointer, but got VT
			//IL_023f: Expected F4, but got I
			//IL_023a: Expected native int or pointer, but got VT
			//IL_0248: Unknown result type (might be due to invalid IL or missing references)
			//IL_024d: Expected VT, but got Unknown
			//IL_025a: Expected F4, but got Obj
			//IL_0255: Expected native int or pointer, but got VT
			//IL_026f: Expected F4, but got I
			//IL_026a: Expected native int or pointer, but got VT
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Expected Obj, but got Unknown
			//IL_029b: Expected F4, but got Obj
			//IL_0296: Expected native int or pointer, but got VT
			//IL_02b0: Expected F4, but got I
			//IL_02ab: Expected native int or pointer, but got VT
			//IL_02b9: Expected Obj, but got VT
			//IL_02d5: Expected I, but got Obj
			//IL_02eb: Expected Obj, but got I
			//IL_0329: Expected I4, but got Obj
			//IL_0347: Expected I4, but got Obj
			//IL_0094: Expected I, but got Obj
			//IL_012e: Expected I, but got Obj
			//IL_0144: Expected Obj, but got I
			//IL_00e1: Expected I, but got Obj
			//IL_0363: Expected Obj, but got I4
			//IL_0370: Expected F4, but got Obj
			//IL_036b: Expected native int or pointer, but got VT
			//IL_0385: Expected F4, but got I
			//IL_0380: Expected native int or pointer, but got VT
			//IL_0392: Expected native int or pointer, but got VT
			//IL_03a4: Expected native int or pointer, but got VT
			//IL_03b8: Expected I4, but got VT
			//IL_03c6: Expected Obj, but got I4
			//IL_03e8: Expected F4, but got Obj
			//IL_03e3: Expected native int or pointer, but got VT
			//IL_03fd: Expected F4, but got I
			//IL_03f8: Expected native int or pointer, but got VT
			//IL_040c: Expected I4, but got VT
			//IL_016f: Expected I, but got Obj
			object obj = this + 44;
			obj = value;
			SettingsButtonPayload payload = _payload;
			_icon.fillCenter = (byte)(int)payload.iconName != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			object obj2 = default;
			Transform transform = (Transform)(obj2 + 40);
			GameObject gameObject = _icon.gameObject;
			transform.localPosition = (Vector3)gameObject;
			object obj3 = obj2 + 28;
			object obj4 = _payload + 32;
			obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v17+8]");
			_ = 0;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v19 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v55 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector = (Vector3)(obj2 + 56);
			((Vector3*)(nint)vector)->x = (float)transform;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			Vector3 vector2 = (Vector3)(obj2 + 72);
			((Vector3*)(nint)vector2)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v16+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			object obj6 = obj2 + 16;
			Vector3 vector3 = vector - vector2;
			((Vector3*)(nint)vector2)->x = (float)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v30+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			Vector3 eulerAngles = ((Transform)vector2).eulerAngles;
			SettingsButtonPayload payload2 = _payload;
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S2_v8 (Il2CppClass<Strings>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S2_v35 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault(payload2.descriptionID);
			_description.fontSize = (int)text;
			SettingsButtonPayload payload3 = _payload;
			_breadcrumb.SetupNormalBreadcrumb((int)payload3.breadcrumbEvents);
			nint num5 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v39 (Il2CppClass<UI.ColorData>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num6 = (nint)typeof(ColorData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v51 (Il2CppClass<UI.ColorData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
			object obj9 = (flag ? 1 : 0) + 124;
			((Vector3*)(nint)vector)->x = (float)obj9;
			Vector3 vector4 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S2_v16+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			((Vector3*)(nint)vector2)->x = vector.x;
			((Vector3*)(nint)vector2)->z = vector.z;
			_title.rawPivot = (UIWidget.Pivot)vector2;
			object obj10 = (flag ? 1 : 0) + 60;
			obj2 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S2_v26+8]");
			_ = 0;
			((Vector3*)(nint)vector2)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			_description.rawPivot = (UIWidget.Pivot)vector2;
			OnEnable();
		}
	}

	public void InitButton(SettingsButtonPayload payload)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v20 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Tracker.CreateEvent(Kiloo.Analytics.EventType.ConsentWithdrawn, null, (string)(object)payload);
	}

	public void OnClick()
	{
		((UpgradeScreen)this).Start();
	}

	private void SetupButton()
	{
		if (((LimitedCharacterPopupManager)(object)this).currentCharacter == Characters.CharacterId.slick)
		{
			SettingsButtonPayload payload = _payload;
			TransformExtensions.Reset((Transform)(object)payload.onClick);
			OnEnable();
		}
	}

	private void OnEnable()
	{
		//IL_001b: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0064: Expected Obj, but got I
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_021b: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00f6: Expected Obj, but got I
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		SettingsButtonPayload payload = _payload;
		string text = _offIndicatorIcon.tag;
		if (payload.setOfflineIndicator != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S2_v18 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x3FFF;
			object obj4 = obj3 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v37 @ S3_v20 (should have been resolved before IL gen)");
		}
		SettingsButtonPayload payload2 = _payload;
		if (payload2.setTitle != null)
		{
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S2_v15 (Il2CppMethodInfo)+18]");
			object obj5 = 0;
			object obj6 = obj5;
			object obj7 = obj6 & 0x3FFF;
			object obj8 = obj7 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v72 @ S3_v16 (should have been resolved before IL gen)");
		}
		SettingsButtonPayload payload3 = _payload;
		if (payload3.setDescription != null)
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S2_v12 (Il2CppMethodInfo)+18]");
			object obj9 = 0;
			object obj10 = obj9;
			object obj11 = obj10 & 0x3FFF;
			object obj12 = obj11 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v103 @ S3_v12 (should have been resolved before IL gen)");
		}
		SettingsButtonPayload payload4 = _payload;
		if (payload4.setIcon != null)
		{
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S2_v9 (Il2CppMethodInfo)+18]");
			object obj13 = 0;
			object obj14 = obj13;
			object obj15 = obj14 & 0x3FFF;
			object obj16 = obj15 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v134 @ S3_v8 (should have been resolved before IL gen)");
		}
		((RewardForVideoButton)(object)_layout).Init((VideoButtonPayload)null);
		SettingsButtonPayload payload5 = _payload;
		bool flag = MiscExtensions.SafeInvoke(payload5.shouldDisable);
		((SettingsLogInFacebookButton)this).InitButton((SettingsPopup)flag);
	}

	public SettingsButton()
	{
		if (_payload != null)
		{
			OnEnable();
		}
	}
}
