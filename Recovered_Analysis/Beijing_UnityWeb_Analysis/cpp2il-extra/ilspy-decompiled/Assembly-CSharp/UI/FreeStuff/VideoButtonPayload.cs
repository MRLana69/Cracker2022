using System;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Ads;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace UI.FreeStuff;

public class VideoButtonPayload
{
	private string iconBackgroundName__BackingField;

	private string iconName__BackingField;

	private Action onVideoWatched__BackingField;

	private Func<bool> isAvailable__BackingField;

	private Func<int> getRewardAmount__BackingField;

	private string title__BackingField;

	private string description__BackingField;

	private AdLocationInfo adLocation__BackingField;

	private CelebrationRewardType rewardType__BackingField;

	private UpgradeType upgradeType__BackingField;

	private UnlockItemSource unlockItemSource__BackingField;

	private Color32 secondColorDark__BackingField;

	private Color32 descriptionColor__BackingField;

	public string iconBackgroundName
	{
		get
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = default;
			text.m_stringLength = 0;
			object obj = text + 16;
			obj = this;
			return text;
		}
		set
		{
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Expected Obj, but got Unknown
			//IL_017b: Expected Obj, but got I4
			//IL_0184: Expected Obj, but got I4
			//IL_0059: Expected Obj, but got I
			//IL_0015: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 + 4;
			obj = 0;
			obj2 = 0;
			Color32 color = secondColorDark__BackingField;
			Color32 color2 = secondColorDark__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (UnityEngine.Color32)+28]");
			if ((nint)0 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (UnityEngine.Color32)+2C]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (UnityEngine.Color32)+28]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
	}

	public string iconName
	{
		get
		{
			return iconBackgroundName__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = value;
		}
	}

	public Action onVideoWatched
	{
		get
		{
			return (Action)(object)iconName__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 12;
			obj = value;
		}
	}

	public Func<bool> isAvailable
	{
		get
		{
			return (Func<bool>)(object)onVideoWatched__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
		}
	}

	public Func<int> getRewardAmount
	{
		get
		{
			return (Func<int>)(object)isAvailable__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 20;
			obj = value;
		}
	}

	public string title
	{
		get
		{
			return (string)(object)getRewardAmount__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 24;
			obj = value;
		}
	}

	public string description
	{
		get
		{
			return title__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 28;
			obj = value;
		}
	}

	public AdLocationInfo adLocation
	{
		get
		{
			return (AdLocationInfo)(object)description__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 32;
			obj = value;
		}
	}

	public CelebrationRewardType rewardType
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (CelebrationRewardType)adLocation__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 36;
			obj = value;
		}
	}

	public UpgradeType upgradeType
	{
		get
		{
			return (UpgradeType)rewardType__BackingField;
		}
		set
		{
			rewardType__BackingField = (CelebrationRewardType)value;
		}
	}

	public UnlockItemSource unlockItemSource
	{
		get
		{
			return (UnlockItemSource)upgradeType__BackingField;
		}
		set
		{
			upgradeType__BackingField = (UpgradeType)value;
		}
	}

	public Color32 firstColor
	{
		get
		{
			Color32 result = default;
			return result;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color32)+34]");
			VideoButtonPayload videoButtonPayload = (VideoButtonPayload)0;
		}
	}

	public Color32 firstColorDark
	{
		get
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			object obj = this + 4;
			obj = this;
			Color32 result = default;
			return result;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color32)+38]");
			VideoButtonPayload videoButtonPayload = (VideoButtonPayload)0;
		}
	}

	public Color32 firstHighlightColor
	{
		get
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			object obj = this + 4;
			obj = this;
			Color32 result = default;
			return result;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color32)+3C]");
			VideoButtonPayload videoButtonPayload = (VideoButtonPayload)0;
		}
	}

	public Color32 secondColor
	{
		get
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			object obj = this + 4;
			obj = this;
			Color32 result = default;
			return result;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value - -64;
			VideoButtonPayload videoButtonPayload = (VideoButtonPayload)obj;
		}
	}

	public Color32 secondColorDark
	{
		get
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			object obj = this + 4;
			obj = this;
			Color32 color = default;
			object obj2 = color - -64;
			obj2 = obj;
			return color;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color32)+44]");
			VideoButtonPayload videoButtonPayload = (VideoButtonPayload)0;
		}
	}

	public Color32 secondHighlightColor
	{
		get
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			object obj = this + 4;
			obj = this;
			Color32 result = default;
			return result;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color32)+48]");
			VideoButtonPayload videoButtonPayload = (VideoButtonPayload)0;
		}
	}

	public Color32 titleColor
	{
		get
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			object obj = this + 4;
			obj = this;
			Color32 result = default;
			return result;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color32)+4C]");
			VideoButtonPayload videoButtonPayload = (VideoButtonPayload)0;
		}
	}

	public Color32 descriptionColor
	{
		get
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			object obj = this + 4;
			obj = this;
			Color32 result = default;
			return result;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color32)+50]");
			VideoButtonPayload videoButtonPayload = (VideoButtonPayload)0;
		}
	}

	public string flurryName
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)unlockItemSource__BackingField;
		}
		set
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected Obj, but got Unknown
			//IL_0028: Expected VT, but got Obj
			object obj = value + 4;
			obj = value;
			descriptionColor__BackingField = (Color32)obj;
		}
	}

	public unsafe VideoButtonPayload()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00cf: Expected Obj, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected VT, but got Unknown
		//IL_00ff: Expected I4, but got Obj
		//IL_00fa: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<UI.ColorData>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v26 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 8;
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj5 = (flag ? 1 : 0) + 268;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v9+8]");
		_ = 0;
		Color32 color = (Color32)(obj2 + 32);
		((Color32*)(nint)color)->rgba = (int)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v16+8]");
		_ = 0;
		Color color2 = color;
		obj = obj2;
		_ = 102;
		VideoButtonPayload videoButtonPayload = (VideoButtonPayload)obj;
	}
}
