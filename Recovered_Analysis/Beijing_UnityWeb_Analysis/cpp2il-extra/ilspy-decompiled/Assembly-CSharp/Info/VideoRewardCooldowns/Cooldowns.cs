using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using InApp;
using Kiloo;
using SYBO.Subway.Info;

namespace Info.VideoRewardCooldowns;

public class Cooldowns
{
	public const string HOVERBOARD_ID = "hoverboard";

	public const string COINS_ID = "coins";

	public const string SCORE_BOOSTER_ID = "score_booster";

	public const string HEADSTART_ID = "headstart";

	public const string DOUBLE_COINS_VIDEO_ID = "doublecoinsvideo";

	private Dictionary<string, Cooldown> _defaultCooldowns;

	public Dictionary<string, Cooldown> activeCooldowns;

	public void Add(Cooldown cooldown)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = cooldown + 8;
		obj = cooldown;
	}

	public unsafe Cooldown Get(string id)
	{
		//IL_009b: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 58;
		string text = id.Substring(num);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cooldown cooldown = default;
		object obj2 = cooldown + 8;
		object obj3 = text + 16;
		obj2 = obj3;
		object obj4 = text + 20;
		TypeCode typeCode = ((int*)obj4)->GetTypeCode();
		cooldown.totalCharges__BackingField = (int)typeCode;
		object obj5 = text + 24;
		TypeCode typeCode2 = ((int*)obj5)->GetTypeCode();
		cooldown.seconds__BackingField = (int)typeCode2;
		return cooldown;
	}

	public unsafe string AsString()
	{
		//IL_0015: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I
		string[] inAppBundleTiers = InAppData.GetInAppBundleTiers();
		bool flag = InAppData.TryConvertDynamicPurchaseIdToCharacterType((string)inAppBundleTiers.Length, out *(Characters.CharacterId*)this);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v4 (System.Boolean)+10]");
		return (string)0;
	}

	public unsafe Cooldowns()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0023: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got VT
		//IL_00c1: Expected Obj, but got I4
		object obj = default;
		Cooldown cooldown = (Cooldown)(obj + 8);
		string[] inAppBundleTiers = InAppData.GetInAppBundleTiers();
		bool flag = InAppData.TryConvertDynamicPurchaseIdToCharacterType((string)inAppBundleTiers.Length, out *(Characters.CharacterId*)this);
		if (flag && CooldownManager.HasCharge((string)flag))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (System.Boolean)+10]");
			if ((nint)0 == 0)
			{
				DateTime today = CDateTime.Today;
				obj = today;
				cooldown = (Cooldown)obj;
				((Cooldowns)flag).Add(cooldown);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (System.Boolean)+10]");
			object obj2 = (nint)0 + (nint)1;
		}
	}
}
