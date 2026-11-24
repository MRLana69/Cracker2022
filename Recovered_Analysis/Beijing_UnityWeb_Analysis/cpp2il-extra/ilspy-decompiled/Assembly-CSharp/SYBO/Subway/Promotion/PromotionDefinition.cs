using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Kiloo;
using Kiloo.Common.Utility;
using SYBO.Subway.Info;
using SYBO.Subway.Placeholders;
using UnityEngine;

namespace SYBO.Subway.Promotion;

public abstract class PromotionDefinition : ScriptableObject
{
	private bool _isEnabled;

	private string _promotionId;

	private Texture2D _stickerTexture;

	private GameObject _buttonPrefab;

	public bool IsActive
	{
		get
		{
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_00a6: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			AnimationClip[] characterAnimations = ((CharacterPromotion)this).CharacterAnimations;
			nint num = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v10 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = CharacterManager.IsCollectionComplete((SYBO.Subway.Info.Characters.CharacterId)characterAnimations);
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
	}

	protected virtual bool IsActiveCheck
	{
		get
		{
			//IL_00ea: Expected I, but got Obj
			//IL_0100: Expected Obj, but got I
			//IL_0125: Expected Obj, but got VT
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Expected Obj, but got Unknown
			//IL_0072: Invalid comparison between I8 and VT
			//IL_0099: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			DateTime utcNow = CDateTime.UtcNow;
			nint num = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(TimeUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v31 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = utcNow;
			string text = (string)(obj2 + 8);
			text = (string)obj2;
			long num3 = TimeUtility.RFC1123StringToUnixTime(text);
			long expireTimeUnix = ExpireTimeUnix;
			if (num3 < expireTimeUnix)
			{
				return false;
			}
			TimeSpan timeLeft = TimeLeft;
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3) < System.Runtime.CompilerServices.Unsafe.As<TimeSpan, UIntPtr>(ref timeLeft);
			bool isEnabled = _isEnabled;
			object obj3 = flag & isEnabled;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				bool result = default;
				return result;
			}
			return false;
		}
	}

	public bool IsEnabled => true;

	public abstract string PopupId { get; }

	public abstract string TitleId { get; }

	public abstract string SubtitleId { get; }

	public abstract DateTime StartTime { get; }

	public abstract DateTime ExpireTime { get; }

	public string PromotionId
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool isEnabled = _isEnabled;
			return (string)isEnabled;
		}
	}

	public Texture2D StickerTexture => (Texture2D)(object)_promotionId;

	public GameObject ButtonPrefab => (GameObject)(object)_stickerTexture;

	public long StartTimeUnix
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ab: Expected I4, but got Obj
			//IL_00b9: Expected I8, but got VT
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SYBO.Subway.Info.Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SYBO.Subway.Info.Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			AnimationClip[] characterAnimations = ((CharacterPromotion)this).CharacterAnimations;
			SYBO.Subway.Info.Characters.Model model = SYBO.Subway.Info.Characters.characterData.get_Item((SYBO.Subway.Info.Characters.CharacterId)characterAnimations);
			return (long)model.defaultExpirationDate;
		}
	}

	public long ExpireTimeUnix
	{
		get
		{
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
			nint num = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(TimeUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v20 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = default;
			object obj2 = obj3;
			string text = (string)(obj2 + 8);
			text = (string)obj2;
			return TimeUtility.RFC1123StringToUnixTime(text);
		}
	}

	public TimeSpan TimeLeft
	{
		get
		{
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected Obj, but got Unknown
			//IL_00c8: Expected VT, but got I8
			//IL_0013: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
			nint num = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(TimeUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v20 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = default;
			object obj2 = obj3;
			string text = (string)(obj2 + 8);
			text = (string)obj2;
			return (TimeSpan)TimeUtility.RFC1123StringToUnixTime(text);
		}
	}

	public abstract string GetPurchaseSuccessFlurryEventValue();

	public abstract string GetPurchaseFailureFlurryEventValue();

	public abstract bool ShouldTrackPopupCloseFlurryEvent();

	protected PromotionDefinition()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got F4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00b7: Expected I, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		obj = 92f;
		_ = -3f;
		object obj3 = obj2 + 8;
		obj3 = obj;
		object obj4 = obj2 + 24;
		obj4 = obj3;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v27 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 up = Vector2.up;
		obj4 = obj2;
		((SelectionPlaceholderLifecycle)(object)this).Initialize();
	}
}
