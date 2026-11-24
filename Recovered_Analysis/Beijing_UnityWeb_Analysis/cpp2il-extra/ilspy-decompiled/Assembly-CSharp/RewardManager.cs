using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cpp2ILInjected;
using Data.Save;
using Info;
using SYBO.Subway.Info;
using UI.Screens.CharacterScreenInternal;
using UI.Screens.RewardManagement;
using UnityEngine;
using WeeklyHunt;

public static class RewardManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CelebrationReward, bool> _003C_003E9__15_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			QuickVideoButtonHelper._003C_003Ec obj = default;
			QuickVideoButtonHelper._003C_003Ec._003C_003E9 = obj;
		}

		internal bool _003CPayoutNonMysteryBoxRewards_003Eb__15_0(CelebrationReward celebrationReward)
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RewardManager+<>c)+8]");
			object obj = 0;
			long uid = celebrationReward.Uid;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+30]");
			return uid == 0;
		}
	}

	private const int UnusedInt = -1;

	private static Action<CelebrationReward> m_OnMysteryBoxAddedForUnlock;

	private static Action<CelebrationReward> m_OnRewardPaidOut;

	public static bool canShowMultipleQueuedCelebrations;

	private static long _nextRewardUid;

	private static readonly Dictionary<CelebrationRewardOrigin, int> PENDING_REWARD_PRIORITY;

	public static int rewardsToUnlockCount
	{
		get
		{
			//IL_0083: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<CelebrationReward> list = default;
			list._002Ector();
			int num = 0;
			while (true)
			{
				Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> boardThemeData = InventorySave.boardThemeData;
				int num2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v11 (System.Collections.Generic.Dictionary`2<Info.Boards+BoardId, System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, Info.BoardThemeData>>)+C]");
				if ((nint)num2 >= (nint)0)
				{
					break;
				}
				Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> boardThemeData2 = InventorySave.boardThemeData;
				CelebrationReward celebrationReward = ((List<CelebrationReward>)(object)boardThemeData2).get_Item(num);
				if (celebrationReward.CelebrationRewardOrigin == CelebrationRewardOrigin.WeeklyChallengeNormal)
				{
					list.Add(celebrationReward);
				}
				int num3 = num + 1;
				num = num3;
			}
			return (int)list;
		}
	}

	public static event Action<CelebrationReward> OnMysteryBoxAddedForUnlock
	{
		add
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
		}
		remove
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<RewardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate onMysteryBoxAddedForUnlock = RewardManager.m_OnMysteryBoxAddedForUnlock;
			Action<CelebrationReward> onMysteryBoxAddedForUnlock2 = default;
			while (true)
			{
				Delegate obj2 = onMysteryBoxAddedForUnlock.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<RewardManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(RewardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<RewardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)RewardManager.m_OnMysteryBoxAddedForUnlock == onMysteryBoxAddedForUnlock)
				{
					RewardManager.m_OnMysteryBoxAddedForUnlock = onMysteryBoxAddedForUnlock2;
				}
				if ((object)RewardManager.m_OnMysteryBoxAddedForUnlock != onMysteryBoxAddedForUnlock)
				{
					onMysteryBoxAddedForUnlock = RewardManager.m_OnMysteryBoxAddedForUnlock;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<CelebrationReward> OnRewardPaidOut
	{
		add
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<RewardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate onMysteryBoxAddedForUnlock = RewardManager.m_OnMysteryBoxAddedForUnlock;
			Action<CelebrationReward> onMysteryBoxAddedForUnlock2 = default;
			while (true)
			{
				Delegate obj2 = onMysteryBoxAddedForUnlock.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<RewardManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(RewardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<RewardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)RewardManager.m_OnMysteryBoxAddedForUnlock == onMysteryBoxAddedForUnlock)
				{
					RewardManager.m_OnMysteryBoxAddedForUnlock = onMysteryBoxAddedForUnlock2;
				}
				if ((object)RewardManager.m_OnMysteryBoxAddedForUnlock != onMysteryBoxAddedForUnlock)
				{
					onMysteryBoxAddedForUnlock = RewardManager.m_OnMysteryBoxAddedForUnlock;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<RewardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = RewardManager.m_OnRewardPaidOut;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<RewardManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(RewardManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(RewardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<RewardManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(RewardManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(RewardManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<RewardManager>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public unsafe static void AddRewardToUnlock(CelebrationRewardOrigin origin, ObtainableItemSource syboAnalyticsSource, string kilooAnalyticsSourceId = null, string syboAnalyticsSourceMeta = null)
	{
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_0198: Expected Obj, but got I4
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01b5: Expected Obj, but got I4
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01d2: Expected Obj, but got I4
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_0200: Expected VT, but got Obj
		//IL_0220: Expected I, but got Obj
		//IL_0236: Expected Obj, but got I
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected VT, but got Unknown
		//IL_0277: Expected F4, but got Obj
		//IL_0272: Expected native int or pointer, but got VT
		//IL_028c: Expected F4, but got I
		//IL_0287: Expected native int or pointer, but got VT
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_02af: Expected Obj, but got I
		//IL_02d5: Expected F4, but got Obj
		//IL_02d0: Expected native int or pointer, but got VT
		//IL_02ea: Expected F4, but got I
		//IL_02e5: Expected native int or pointer, but got VT
		//IL_030c: Expected Obj, but got F4
		//IL_032d: Expected I, but got Obj
		//IL_0343: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0482: Expected Obj, but got I
		//IL_039a: Expected F4, but got Obj
		//IL_0395: Expected native int or pointer, but got VT
		//IL_03af: Expected F4, but got I
		//IL_03aa: Expected native int or pointer, but got VT
		//IL_03f4: Expected Obj, but got I4
		//IL_0436: Expected I, but got Obj
		//IL_044c: Expected Obj, but got I
		//IL_00f5: Expected I, but got Obj
		//IL_0388: Expected Obj, but got I
		//IL_04b1: Expected F4, but got Obj
		//IL_04ac: Expected native int or pointer, but got VT
		//IL_04c6: Expected F4, but got I
		//IL_04c1: Expected native int or pointer, but got VT
		//IL_0506: Expected I4, but got Obj
		//IL_0506: Expected I4, but got Obj
		//IL_0506: Expected Obj, but got VT
		//IL_0506: Expected Obj, but got I4
		//IL_0084: Expected I, but got Obj
		//IL_0142: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 76;
		obj = 0;
		_ = 0;
		object obj3 = obj2 - -64;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 52;
		obj4 = 0;
		_ = 0;
		Transform transform = (Transform)(obj2 + 88);
		GameObject gameObject = ((Component)(object)kilooAnalyticsSourceId).gameObject;
		transform.position = (Vector3)gameObject;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v22 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v104 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Vector3 vector = (Vector3)(obj2 + 104);
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj6 = obj2 + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v27 (System.Boolean)+30]");
		Vector3 vector3 = ((Camera)0).WorldToViewportPoint(vector);
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v33+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj6;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v33+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj3 = vector.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		_ = 0;
		_ = 3f;
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v48 (Il2CppClass<UIScreenController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		bool flag2 = obj7 == null;
		Camera camera;
		if (syboAnalyticsSourceMeta != null)
		{
			if (!flag2)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v100 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v98 (System.Boolean)+38]");
			camera = (Camera)0;
		}
		else
		{
			if (!flag2)
			{
				nint num5 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v90 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag4 = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v88 (System.Boolean)+20]");
			camera = (Camera)0;
		}
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		Vector3 vector6 = camera.ScreenToViewportPoint(vector);
		obj4 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		obj2 = ((CelebrationRewardOrigin*)(int)origin)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ L0 (UI.Screens.RewardManagement.CelebrationRewardOrigin)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ L0 (UI.Screens.RewardManagement.CelebrationRewardOrigin)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ L0 (UI.Screens.RewardManagement.CelebrationRewardOrigin)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ L0 (UI.Screens.RewardManagement.CelebrationRewardOrigin)+20]");
		_ = 0;
		nint num6 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v67 (Il2CppClass<PrizePositionData>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num7 = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v80 (Il2CppClass<PrizePositionData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform = (Transform)obj6;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v33+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector7 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
		_ = 0;
		((UICharacterThemeShifter)syboAnalyticsSource).SetActiveBubbles((CharacterThemeButton)(object)transform, (Outfit)vector, (Characters.CharacterId)kilooAnalyticsSourceId, (int)syboAnalyticsSourceMeta);
	}

	public static void AddRewardToUnlock(CelebrationReward reward)
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_01b0: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<RewardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = RewardManager.m_OnRewardPaidOut;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)reward);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<RewardManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(RewardManager);
			if (!flag)
			{
				nint num5 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<RewardManager>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(RewardManager);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(RewardManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<RewardManager>)+5C]");
			object obj5 = (nint)0 + (nint)4;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	public static long GenerateRewardUid()
	{
		//IL_005b: Expected Obj, but got I4
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<System.DateTime>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime defaultLocalFileTime = File.DefaultLocalFileTime;
		obj = defaultLocalFileTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC9B");
		long result = default;
		return result;
	}

	private static void AddMysteryBoxToUnlock(CelebrationReward reward)
	{
		//IL_0035: Expected I, but got Obj
		//IL_004b: Expected Obj, but got I
		//IL_0076: Expected I, but got Obj
		if (reward.CelebrationRewardOrigin == CelebrationRewardOrigin.Notset || reward.rewardType == CelebrationRewardType._notset)
		{
			return;
		}
		nint num = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11 (Il2CppClass<RewardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RewardPaidOut(reward);
	}

	public static CelebrationReward[] GetRewardsToUnlockForCelebration()
	{
		return (CelebrationReward[])(object)IngameScreen.instance__BackingField;
	}

	public static void RewardPaidOut(CelebrationReward celebrationReward)
	{
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_003f: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0104: Expected I, but got Obj
		//IL_011a: Expected Obj, but got I
		//IL_028c: Expected Obj, but got I4
		//IL_0295: Expected Obj, but got I4
		//IL_0447: Expected Obj, but got I
		//IL_0455: Expected I, but got Obj
		//IL_046b: Expected Obj, but got I
		//IL_02bd: Expected I, but got Obj
		//IL_02d3: Expected Obj, but got I
		//IL_0145: Expected I, but got Obj
		//IL_04b6: Expected I8, but got I4
		//IL_02fe: Expected I, but got Obj
		//IL_0227: Expected I, but got Obj
		//IL_034b: Expected I, but got Obj
		//IL_0361: Expected Obj, but got I
		//IL_01b6: Expected I, but got Obj
		//IL_04ef: Expected Obj, but got I
		//IL_038c: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = celebrationReward;
		Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> boardThemeData = InventorySave.boardThemeData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = obj2;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S2_v8 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v9+60]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v10+68]");
		object obj7 = 0;
		object obj8 = obj7 & 0x1FFF;
		object obj9 = obj8 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51 @ S3_v4 (should have been resolved before IL gen)");
		object obj10 = default;
		bool flag = (nint)obj10 != -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v14+30]");
		bool flag2 = (nint)0 < (nint)1;
		object obj12 = (flag ? 1 : 0) ^ 1;
		object obj13 = flag2 | obj12;
		if (obj13 != null)
		{
			nint num3 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v53 (Il2CppClass<RewardManager>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num4 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v82 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = _nextRewardUid == -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			object obj15 = 0;
			nint num5 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v39 (Il2CppClass<RewardManager>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			bool flag4 = obj16 == null;
			if (flag3)
			{
				if (!flag4)
				{
					nint num6 = (nint)typeof(RewardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v78 (Il2CppClass<RewardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				DateTime startChallengeDateTime = WeeklyHuntData.startChallengeDateTime;
			}
			else
			{
				if (!flag4)
				{
					nint num7 = (nint)typeof(RewardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v68 (Il2CppClass<RewardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				_ = _nextRewardUid;
				_nextRewardUid = -1L;
			}
		}
		if (flag)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		bool flag5 = default;
		object obj17 = (flag5 ? 1 : 0) + 16;
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		PlayerSave.SetSkipMission(0, flag5);
		nint num9 = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v25 (Il2CppClass<RewardManager>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num10 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v46 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (RewardManager.m_OnMysteryBoxAddedForUnlock == null)
		{
			return;
		}
		nint num11 = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v33 (Il2CppClass<RewardManager>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num12 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v40 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Action<CelebrationReward> onMysteryBoxAddedForUnlock = RewardManager.m_OnMysteryBoxAddedForUnlock;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		onMysteryBoxAddedForUnlock((CelebrationReward)0);
	}

	public static List<CelebrationReward> GetWeeklyHuntRewardsToUnlock()
	{
		//IL_012c: Expected I, but got Obj
		//IL_0142: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<RewardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(canShowMultipleQueuedCelebrations ? 1u : 0u) == 0)
		{
			Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> boardThemeData = InventorySave.boardThemeData;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BBA9");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DB3");
			object obj2 = default;
			if (obj2 != null)
			{
				Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> boardThemeData2 = InventorySave.boardThemeData;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v23 (System.Collections.Generic.Dictionary`2<Info.Boards+BoardId, System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, Info.BoardThemeData>>)+C]");
				if ((nint)0 > (nint)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DB3");
					throw new ArrayTypeMismatchException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		}
		List<CelebrationReward> result = default;
		return result;
	}

	public static void PayoutNonMysteryBoxRewards()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got F4
		//IL_0045: Expected I, but got Obj
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0081: Expected VT, but got Obj
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got F4
		//IL_00ce: Expected I, but got Obj
		//IL_00f9: Expected Obj, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got F4
		//IL_014e: Expected I, but got Obj
		//IL_0179: Expected Obj, but got I
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01a5: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got F4
		//IL_01ce: Expected I, but got Obj
		//IL_01f9: Expected Obj, but got I
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0225: Expected Obj, but got I4
		//IL_0234: Expected Obj, but got F4
		//IL_024e: Expected I, but got Obj
		//IL_0279: Expected Obj, but got I
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02a5: Expected Obj, but got I4
		//IL_02b4: Expected Obj, but got F4
		//IL_02ce: Expected I, but got Obj
		//IL_02f9: Expected Obj, but got I
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_0325: Expected Obj, but got I4
		//IL_0334: Expected Obj, but got F4
		//IL_034e: Expected I, but got Obj
		//IL_0379: Expected Obj, but got I
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_03a5: Expected Obj, but got I4
		//IL_03b4: Expected Obj, but got F4
		//IL_03ce: Expected I, but got Obj
		//IL_03f9: Expected Obj, but got I
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_0425: Expected Obj, but got I4
		//IL_0434: Expected Obj, but got F4
		//IL_044e: Expected I, but got Obj
		//IL_0479: Expected Obj, but got I
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_04a5: Expected Obj, but got I4
		//IL_04b4: Expected Obj, but got F4
		//IL_04ce: Expected I, but got Obj
		//IL_04f9: Expected Obj, but got I
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_0525: Expected Obj, but got I4
		//IL_0534: Expected Obj, but got F4
		//IL_054e: Expected I, but got Obj
		//IL_0579: Expected Obj, but got I
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected Obj, but got Unknown
		//IL_05a5: Expected Obj, but got I4
		//IL_05b4: Expected Obj, but got F4
		//IL_05ce: Expected I, but got Obj
		//IL_05f9: Expected Obj, but got I
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected Obj, but got Unknown
		//IL_0625: Expected Obj, but got I4
		//IL_0634: Expected Obj, but got F4
		//IL_064e: Expected I, but got Obj
		//IL_0679: Expected Obj, but got I
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected Obj, but got Unknown
		//IL_06a5: Expected Obj, but got I4
		//IL_06b4: Expected Obj, but got F4
		//IL_06ce: Expected I, but got Obj
		//IL_06f9: Expected Obj, but got I
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Expected Obj, but got Unknown
		//IL_0725: Expected Obj, but got I4
		//IL_0734: Expected Obj, but got F4
		//IL_074e: Expected I, but got Obj
		//IL_0779: Expected Obj, but got I
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected Obj, but got Unknown
		//IL_07a5: Expected Obj, but got I4
		//IL_07b4: Expected Obj, but got F4
		//IL_07ce: Expected I, but got Obj
		//IL_07f9: Expected Obj, but got I
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Expected Obj, but got Unknown
		//IL_0825: Expected Obj, but got I4
		//IL_0834: Expected Obj, but got F4
		//IL_084e: Expected I, but got Obj
		//IL_0879: Expected Obj, but got I
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Expected Obj, but got Unknown
		//IL_08a5: Expected Obj, but got I4
		//IL_08b4: Expected Obj, but got F4
		//IL_08ce: Expected I, but got Obj
		//IL_08f9: Expected Obj, but got I
		//IL_0917: Unknown result type (might be due to invalid IL or missing references)
		//IL_091c: Expected Obj, but got Unknown
		//IL_0925: Expected Obj, but got I4
		//IL_0934: Expected Obj, but got F4
		//IL_094e: Expected I, but got Obj
		//IL_0979: Expected Obj, but got I
		//IL_0997: Unknown result type (might be due to invalid IL or missing references)
		//IL_099c: Expected Obj, but got Unknown
		//IL_09a5: Expected Obj, but got I4
		//IL_09b4: Expected Obj, but got F4
		//IL_09ce: Expected I, but got Obj
		//IL_09f9: Expected Obj, but got I
		//IL_0a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1c: Expected Obj, but got Unknown
		//IL_0a25: Expected Obj, but got I4
		//IL_0a34: Expected Obj, but got F4
		//IL_0a4e: Expected I, but got Obj
		//IL_0a79: Expected Obj, but got I
		//IL_0a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Expected Obj, but got Unknown
		//IL_0aa5: Expected Obj, but got I4
		//IL_0ab4: Expected Obj, but got F4
		//IL_0ace: Expected I, but got Obj
		//IL_0af9: Expected Obj, but got I
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1c: Expected Obj, but got Unknown
		//IL_0b25: Expected Obj, but got I4
		//IL_0b34: Expected Obj, but got F4
		//IL_0b4e: Expected I, but got Obj
		//IL_0b79: Expected Obj, but got I
		//IL_0b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9c: Expected Obj, but got Unknown
		//IL_0ba5: Expected Obj, but got I4
		//IL_0bb4: Expected Obj, but got F4
		//IL_0bce: Expected I, but got Obj
		//IL_0bf9: Expected Obj, but got I
		//IL_0c17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1c: Expected Obj, but got Unknown
		//IL_0c25: Expected Obj, but got I4
		//IL_0c34: Expected Obj, but got F4
		//IL_0c4e: Expected I, but got Obj
		//IL_0c79: Expected Obj, but got I
		//IL_0c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9c: Expected Obj, but got Unknown
		//IL_0ca5: Expected Obj, but got I4
		//IL_0cb4: Expected Obj, but got F4
		//IL_0cce: Expected I, but got Obj
		//IL_0cf9: Expected Obj, but got I
		//IL_0d17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1c: Expected Obj, but got Unknown
		//IL_0d25: Expected Obj, but got I4
		//IL_0d34: Expected Obj, but got F4
		//IL_0d4e: Expected I, but got Obj
		//IL_0d79: Expected Obj, but got I
		//IL_0d97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9c: Expected Obj, but got Unknown
		//IL_0da5: Expected Obj, but got I4
		//IL_0db4: Expected Obj, but got F4
		//IL_0dce: Expected I, but got Obj
		//IL_0df9: Expected Obj, but got I
		//IL_0e17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1c: Expected Obj, but got Unknown
		//IL_0e25: Expected Obj, but got I4
		//IL_0e34: Expected Obj, but got F4
		//IL_0e4e: Expected I, but got Obj
		//IL_0e79: Expected Obj, but got I
		//IL_0e97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9c: Expected Obj, but got Unknown
		//IL_0ea5: Expected Obj, but got I4
		//IL_0eb4: Expected Obj, but got F4
		//IL_0ece: Expected I, but got Obj
		//IL_0ef9: Expected Obj, but got I
		//IL_0f17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1c: Expected Obj, but got Unknown
		//IL_0f25: Expected Obj, but got I4
		//IL_0f34: Expected Obj, but got F4
		//IL_0f4e: Expected I, but got Obj
		//IL_0f79: Expected Obj, but got I
		//IL_0f97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9c: Expected Obj, but got Unknown
		//IL_0fa5: Expected Obj, but got I4
		//IL_0fb4: Expected Obj, but got F4
		//IL_0fce: Expected I, but got Obj
		//IL_0ff9: Expected Obj, but got I
		//IL_1017: Unknown result type (might be due to invalid IL or missing references)
		//IL_101c: Expected Obj, but got Unknown
		//IL_1025: Expected Obj, but got I4
		//IL_1034: Expected Obj, but got F4
		//IL_104e: Expected I, but got Obj
		//IL_1079: Expected Obj, but got I
		//IL_1097: Unknown result type (might be due to invalid IL or missing references)
		//IL_109c: Expected Obj, but got Unknown
		//IL_10a5: Expected Obj, but got I4
		//IL_10b4: Expected Obj, but got F4
		//IL_10ce: Expected I, but got Obj
		//IL_10f9: Expected Obj, but got I
		//IL_1117: Unknown result type (might be due to invalid IL or missing references)
		//IL_111c: Expected Obj, but got Unknown
		//IL_1125: Expected Obj, but got I4
		//IL_1134: Expected Obj, but got F4
		//IL_114e: Expected I, but got Obj
		//IL_1179: Expected Obj, but got I
		//IL_1197: Unknown result type (might be due to invalid IL or missing references)
		//IL_119c: Expected Obj, but got Unknown
		//IL_11a5: Expected Obj, but got I4
		//IL_11b4: Expected Obj, but got F4
		//IL_11ce: Expected I, but got Obj
		//IL_11f9: Expected Obj, but got I
		//IL_1217: Unknown result type (might be due to invalid IL or missing references)
		//IL_121c: Expected Obj, but got Unknown
		//IL_1225: Expected Obj, but got I4
		//IL_1234: Expected Obj, but got F4
		//IL_124e: Expected I, but got Obj
		//IL_1279: Expected Obj, but got I
		//IL_1297: Unknown result type (might be due to invalid IL or missing references)
		//IL_129c: Expected Obj, but got Unknown
		//IL_12a5: Expected Obj, but got I4
		//IL_12b4: Expected Obj, but got F4
		//IL_12ce: Expected I, but got Obj
		//IL_12f9: Expected Obj, but got I
		//IL_1317: Unknown result type (might be due to invalid IL or missing references)
		//IL_131c: Expected Obj, but got Unknown
		//IL_1325: Expected Obj, but got I4
		//IL_1334: Expected Obj, but got F4
		//IL_134e: Expected I, but got Obj
		//IL_1379: Expected Obj, but got I
		//IL_1397: Unknown result type (might be due to invalid IL or missing references)
		//IL_139c: Expected Obj, but got Unknown
		//IL_13a5: Expected Obj, but got I4
		//IL_13b4: Expected Obj, but got F4
		//IL_13ce: Expected I, but got Obj
		//IL_13f9: Expected Obj, but got I
		//IL_1417: Unknown result type (might be due to invalid IL or missing references)
		//IL_141c: Expected Obj, but got Unknown
		//IL_1425: Expected Obj, but got I4
		//IL_1434: Expected Obj, but got F4
		//IL_144e: Expected I, but got Obj
		//IL_1479: Expected Obj, but got I
		//IL_1497: Unknown result type (might be due to invalid IL or missing references)
		//IL_149c: Expected Obj, but got Unknown
		//IL_14a5: Expected Obj, but got I4
		//IL_14b4: Expected Obj, but got F4
		//IL_14ce: Expected I, but got Obj
		//IL_14f9: Expected Obj, but got I
		//IL_152e: Expected Obj, but got I
		//IL_153e: Expected Obj, but got I
		//IL_154f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1554: Expected Obj, but got Unknown
		//IL_155d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1562: Expected Obj, but got Unknown
		//IL_157a: Expected I, but got Obj
		//IL_1590: Expected Obj, but got I
		//IL_15a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a6: Expected Obj, but got Unknown
		//IL_15af: Expected Obj, but got I4
		//IL_15be: Expected Obj, but got F4
		//IL_15d8: Expected I, but got Obj
		//IL_1603: Expected Obj, but got I
		//IL_1621: Expected Obj, but got I4
		//IL_1630: Expected Obj, but got F4
		//IL_164a: Expected I, but got Obj
		//IL_1675: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 516;
		obj = 0;
		_ = 0;
		obj = 0f;
		_ = 0f;
		_ = 0f;
		nint num = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<PrizePositionData>)+5C]");
		nint num2 = 0;
		object obj3 = obj2 + 528;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		PrizePositionData.HOVERBOARD_POSITION_OFFSET = (Vector3)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj4 = obj2 + 504;
		obj4 = 0;
		_ = 0;
		obj4 = 1f;
		_ = 1f;
		_ = 1f;
		nint num3 = (nint)typeof(PrizePositionData);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v29 (Il2CppClass<PrizePositionData>)+5C]");
		object obj5 = (nint)0 + (nint)12;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj6 = obj2 + 492;
		obj6 = 0;
		_ = 0;
		obj6 = 336f;
		_ = 152f;
		_ = 27f;
		nint num4 = (nint)typeof(PrizePositionData);
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v34+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v40 (Il2CppClass<PrizePositionData>)+5C]");
		object obj7 = (nint)0 + (nint)24;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj8 = obj2 + 480;
		obj8 = 0;
		_ = 0;
		obj8 = 0f;
		_ = 0f;
		_ = 0f;
		nint num5 = (nint)typeof(PrizePositionData);
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v45+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v51 (Il2CppClass<PrizePositionData>)+5C]");
		object obj9 = (nint)0 + (nint)36;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj10 = obj2 + 468;
		obj10 = 0;
		_ = 0;
		obj10 = 1f;
		_ = 1f;
		_ = 1f;
		nint num6 = (nint)typeof(PrizePositionData);
		obj3 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v56+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v62 (Il2CppClass<PrizePositionData>)+5C]");
		object obj11 = (nint)0 + (nint)48;
		obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj12 = obj2 + 456;
		obj12 = 0;
		_ = 0;
		obj12 = 13f;
		_ = 204f;
		_ = 319f;
		nint num7 = (nint)typeof(PrizePositionData);
		obj3 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v67+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v73 (Il2CppClass<PrizePositionData>)+5C]");
		object obj13 = (nint)0 + (nint)60;
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj14 = obj2 + 444;
		obj14 = 0;
		_ = 0;
		obj14 = 0f;
		_ = 0f;
		_ = 0f;
		nint num8 = (nint)typeof(PrizePositionData);
		obj3 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v78+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v84 (Il2CppClass<PrizePositionData>)+5C]");
		object obj15 = (nint)0 + (nint)72;
		obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj16 = obj2 + 432;
		obj16 = 0;
		_ = 0;
		obj16 = 1f;
		_ = 1f;
		_ = 1f;
		nint num9 = (nint)typeof(PrizePositionData);
		obj3 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v89+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v95 (Il2CppClass<PrizePositionData>)+5C]");
		object obj17 = (nint)0 + (nint)84;
		obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj18 = obj2 + 420;
		obj18 = 0;
		_ = 0;
		obj18 = 14f;
		_ = 202f;
		_ = 326.8f;
		nint num10 = (nint)typeof(PrizePositionData);
		obj3 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v100+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v106 (Il2CppClass<PrizePositionData>)+5C]");
		object obj19 = (nint)0 + (nint)96;
		obj19 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj20 = obj2 + 408;
		obj20 = 0;
		_ = 0;
		obj20 = 0f;
		_ = 0f;
		_ = 0f;
		nint num11 = (nint)typeof(PrizePositionData);
		obj3 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v111+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v117 (Il2CppClass<PrizePositionData>)+5C]");
		object obj21 = (nint)0 + (nint)108;
		obj21 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj22 = obj2 + 396;
		obj22 = 0;
		_ = 0;
		obj22 = 1f;
		_ = 1f;
		_ = 1f;
		nint num12 = (nint)typeof(PrizePositionData);
		obj3 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v122+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v128 (Il2CppClass<PrizePositionData>)+5C]");
		object obj23 = (nint)0 + (nint)120;
		obj23 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj24 = obj2 + 384;
		obj24 = 0;
		_ = 0;
		obj24 = 13f;
		_ = 204f;
		_ = 319f;
		nint num13 = (nint)typeof(PrizePositionData);
		obj3 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v133+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S0_v139 (Il2CppClass<PrizePositionData>)+5C]");
		object obj25 = (nint)0 + (nint)132;
		obj25 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj26 = obj2 + 372;
		obj26 = 0;
		_ = 0;
		obj26 = 0f;
		_ = 0f;
		_ = 0f;
		nint num14 = (nint)typeof(PrizePositionData);
		obj3 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S0_v144+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S0_v150 (Il2CppClass<PrizePositionData>)+5C]");
		object obj27 = (nint)0 + (nint)144;
		obj27 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj28 = obj2 + 360;
		obj28 = 0;
		_ = 0;
		obj28 = 0.9f;
		_ = 0.9f;
		_ = 0.9f;
		nint num15 = (nint)typeof(PrizePositionData);
		obj3 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v155+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ S0_v161 (Il2CppClass<PrizePositionData>)+5C]");
		object obj29 = (nint)0 + (nint)156;
		obj29 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj30 = obj2 + 348;
		obj30 = 0;
		_ = 0;
		obj30 = -5f;
		_ = -135f;
		_ = -5f;
		nint num16 = (nint)typeof(PrizePositionData);
		obj3 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ S0_v166+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ S0_v172 (Il2CppClass<PrizePositionData>)+5C]");
		object obj31 = (nint)0 + (nint)168;
		obj31 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj32 = obj2 + 336;
		obj32 = 0;
		_ = 0;
		obj32 = 0f;
		_ = 0f;
		_ = 0f;
		nint num17 = (nint)typeof(PrizePositionData);
		obj3 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S0_v177+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ S0_v183 (Il2CppClass<PrizePositionData>)+5C]");
		object obj33 = (nint)0 + (nint)180;
		obj33 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj34 = obj2 + 324;
		obj34 = 0;
		_ = 0;
		obj34 = 0.9f;
		_ = 0.9f;
		_ = 0.9f;
		nint num18 = (nint)typeof(PrizePositionData);
		obj3 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S0_v188+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ S0_v194 (Il2CppClass<PrizePositionData>)+5C]");
		object obj35 = (nint)0 + (nint)192;
		obj35 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj36 = obj2 + 312;
		obj36 = 0;
		_ = 0;
		obj36 = -7.5f;
		_ = -135f;
		_ = -7.5f;
		nint num19 = (nint)typeof(PrizePositionData);
		obj3 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ S0_v199+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ S0_v205 (Il2CppClass<PrizePositionData>)+5C]");
		object obj37 = (nint)0 + (nint)204;
		obj37 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj38 = obj2 + 300;
		obj38 = 0;
		_ = 0;
		obj38 = 0f;
		_ = 0f;
		_ = 0f;
		nint num20 = (nint)typeof(PrizePositionData);
		obj3 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ S0_v210+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ S0_v216 (Il2CppClass<PrizePositionData>)+5C]");
		object obj39 = (nint)0 + (nint)216;
		obj39 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj40 = obj2 + 288;
		obj40 = 0;
		_ = 0;
		obj40 = 1f;
		_ = 1f;
		_ = 1f;
		nint num21 = (nint)typeof(PrizePositionData);
		obj3 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ S0_v221+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ S0_v227 (Il2CppClass<PrizePositionData>)+5C]");
		object obj41 = (nint)0 + (nint)228;
		obj41 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj42 = obj2 + 276;
		obj42 = 0;
		_ = 0;
		obj42 = 0f;
		_ = 20f;
		_ = 0f;
		nint num22 = (nint)typeof(PrizePositionData);
		obj3 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ S0_v232+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ S0_v238 (Il2CppClass<PrizePositionData>)+5C]");
		object obj43 = (nint)0 + (nint)240;
		obj43 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj44 = obj2 + 264;
		obj44 = 0;
		_ = 0;
		obj44 = 0f;
		_ = 0f;
		_ = 0f;
		nint num23 = (nint)typeof(PrizePositionData);
		obj3 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S0_v243+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ S0_v249 (Il2CppClass<PrizePositionData>)+5C]");
		object obj45 = (nint)0 + (nint)252;
		obj45 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj46 = obj2 + 252;
		obj46 = 0;
		_ = 0;
		obj46 = 0.9f;
		_ = 0.9f;
		_ = 0.9f;
		nint num24 = (nint)typeof(PrizePositionData);
		obj3 = obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ S0_v254+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ S0_v260 (Il2CppClass<PrizePositionData>)+5C]");
		object obj47 = (nint)0 + (nint)264;
		obj47 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj48 = obj2 + 240;
		obj48 = 0;
		_ = 0;
		obj48 = 347f;
		_ = 225f;
		_ = 347f;
		nint num25 = (nint)typeof(PrizePositionData);
		obj3 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ S0_v265+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ S0_v271 (Il2CppClass<PrizePositionData>)+5C]");
		object obj49 = (nint)0 + (nint)276;
		obj49 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj50 = obj2 + 228;
		obj50 = 0;
		_ = 0;
		obj50 = 4f;
		_ = 0f;
		_ = 0f;
		nint num26 = (nint)typeof(PrizePositionData);
		obj3 = obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ S0_v276+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ S0_v282 (Il2CppClass<PrizePositionData>)+5C]");
		object obj51 = (nint)0 + (nint)288;
		obj51 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj52 = obj2 + 216;
		obj52 = 0;
		_ = 0;
		obj52 = 12f;
		_ = 12f;
		_ = 12f;
		nint num27 = (nint)typeof(PrizePositionData);
		obj3 = obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ S0_v287+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ S0_v293 (Il2CppClass<PrizePositionData>)+5C]");
		object obj53 = (nint)0 + (nint)300;
		obj53 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj54 = obj2 + 204;
		obj54 = 0;
		_ = 0;
		obj54 = 324.7f;
		_ = 304.17f;
		_ = 66.86f;
		nint num28 = (nint)typeof(PrizePositionData);
		obj3 = obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ S0_v298+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ S0_v304 (Il2CppClass<PrizePositionData>)+5C]");
		object obj55 = (nint)0 + (nint)312;
		obj55 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj56 = obj2 + 192;
		obj56 = 0;
		_ = 0;
		obj56 = 7f;
		_ = 5f;
		_ = 0f;
		nint num29 = (nint)typeof(PrizePositionData);
		obj3 = obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ S0_v309+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v843 @ S0_v315 (Il2CppClass<PrizePositionData>)+5C]");
		object obj57 = (nint)0 + (nint)324;
		obj57 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj58 = obj2 + 180;
		obj58 = 0;
		_ = 0;
		obj58 = 14f;
		_ = 14f;
		_ = 14f;
		nint num30 = (nint)typeof(PrizePositionData);
		obj3 = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v861 @ S0_v320+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ S0_v326 (Il2CppClass<PrizePositionData>)+5C]");
		object obj59 = (nint)0 + (nint)336;
		obj59 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj60 = obj2 + 168;
		obj60 = 0;
		_ = 0;
		obj60 = 0.2f;
		_ = 313.6f;
		_ = 6.6f;
		nint num31 = (nint)typeof(PrizePositionData);
		obj3 = obj60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ S0_v331+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ S0_v337 (Il2CppClass<PrizePositionData>)+5C]");
		object obj61 = (nint)0 + (nint)348;
		obj61 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj62 = obj2 + 156;
		obj62 = 0;
		_ = 0;
		obj62 = 7f;
		_ = 9f;
		_ = 0f;
		nint num32 = (nint)typeof(PrizePositionData);
		obj3 = obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ S0_v342+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ S0_v348 (Il2CppClass<PrizePositionData>)+5C]");
		object obj63 = (nint)0 + (nint)360;
		obj63 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj64 = obj2 + 144;
		obj64 = 0;
		_ = 0;
		obj64 = 14f;
		_ = 14f;
		_ = 14f;
		nint num33 = (nint)typeof(PrizePositionData);
		obj3 = obj64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ S0_v353+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ S0_v359 (Il2CppClass<PrizePositionData>)+5C]");
		object obj65 = (nint)0 + (nint)372;
		obj65 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj66 = obj2 + 132;
		obj66 = 0;
		_ = 0;
		obj66 = -15f;
		_ = 300.6f;
		_ = 28f;
		nint num34 = (nint)typeof(PrizePositionData);
		obj3 = obj66;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ S0_v364+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ S0_v370 (Il2CppClass<PrizePositionData>)+5C]");
		object obj67 = (nint)0 + (nint)384;
		obj67 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj68 = obj2 + 120;
		obj68 = 0;
		_ = 0;
		obj68 = 2f;
		_ = 12f;
		_ = 0f;
		nint num35 = (nint)typeof(PrizePositionData);
		obj3 = obj68;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ S0_v375+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ S0_v381 (Il2CppClass<PrizePositionData>)+5C]");
		object obj69 = (nint)0 + (nint)396;
		obj69 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj70 = obj2 + 108;
		obj70 = 0;
		_ = 0;
		obj70 = 14f;
		_ = 14f;
		_ = 14f;
		nint num36 = (nint)typeof(PrizePositionData);
		obj3 = obj70;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1041 @ S0_v386+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ S0_v392 (Il2CppClass<PrizePositionData>)+5C]");
		object obj71 = (nint)0 + (nint)408;
		obj71 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj72 = obj2 + 96;
		obj72 = 0;
		_ = 0;
		obj72 = 17f;
		_ = 134f;
		_ = -53f;
		nint num37 = (nint)typeof(PrizePositionData);
		obj3 = obj72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ S0_v397+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1083 @ S0_v403 (Il2CppClass<PrizePositionData>)+5C]");
		object obj73 = (nint)0 + (nint)420;
		obj73 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj74 = obj2 + 84;
		obj74 = 0;
		_ = 0;
		obj74 = 1f;
		_ = 2f;
		_ = 0f;
		nint num38 = (nint)typeof(PrizePositionData);
		obj3 = obj74;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1101 @ S0_v408+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ S0_v414 (Il2CppClass<PrizePositionData>)+5C]");
		object obj75 = (nint)0 + (nint)432;
		obj75 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj76 = obj2 + 72;
		obj76 = 0;
		_ = 0;
		obj76 = -11f;
		_ = 315f;
		_ = 55f;
		nint num39 = (nint)typeof(PrizePositionData);
		obj3 = obj76;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ S0_v419+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1143 @ S0_v425 (Il2CppClass<PrizePositionData>)+5C]");
		object obj77 = (nint)0 + (nint)444;
		obj77 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj78 = obj2 + 60;
		obj78 = 0;
		_ = 0;
		obj78 = 11f;
		_ = 11f;
		_ = 11f;
		nint num40 = (nint)typeof(PrizePositionData);
		obj3 = obj78;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ S0_v430+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1173 @ S0_v436 (Il2CppClass<PrizePositionData>)+5C]");
		object obj79 = (nint)0 + (nint)456;
		obj79 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj80 = obj2 + 48;
		obj80 = 0;
		_ = 0;
		obj80 = 2f;
		_ = 5f;
		_ = 0f;
		nint num41 = (nint)typeof(PrizePositionData);
		obj3 = obj80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1191 @ S0_v441+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1203 @ S0_v447 (Il2CppClass<PrizePositionData>)+5C]");
		object obj81 = (nint)0 + (nint)468;
		obj81 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj82 = obj2 + 36;
		obj82 = 0;
		_ = 0;
		obj82 = 14f;
		_ = 14f;
		_ = 14f;
		nint num42 = (nint)typeof(PrizePositionData);
		obj3 = obj82;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ S0_v452+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1233 @ S0_v458 (Il2CppClass<PrizePositionData>)+5C]");
		object obj83 = (nint)0 + (nint)480;
		obj83 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj84 = obj2 + 24;
		obj84 = 0;
		_ = 0;
		obj84 = -16f;
		_ = 300f;
		_ = 36f;
		nint num43 = (nint)typeof(PrizePositionData);
		obj3 = obj84;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1251 @ S0_v463+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1263 @ S0_v469 (Il2CppClass<PrizePositionData>)+5C]");
		object obj85 = (nint)0 + (nint)492;
		obj85 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1286 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1287 @ S3_v3+60]");
		object obj87 = 0;
		object obj88 = obj87;
		object obj89 = obj88 & 0x1FFF;
		object obj90 = obj89 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1296 @ S4_v4 (should have been resolved before IL gen)");
		nint num45 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1299 @ S0_v477 (Il2CppClass<PrizePositionData>)+5C]");
		object obj91 = (nint)0 + (nint)504;
		object obj92 = default;
		obj91 = obj92;
		object obj93 = obj2 + 12;
		obj93 = 0;
		_ = 0;
		obj93 = 0f;
		_ = -25f;
		_ = 0f;
		nint num46 = (nint)typeof(PrizePositionData);
		obj3 = obj93;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1306 @ S0_v481+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1318 @ S0_v487 (Il2CppClass<PrizePositionData>)+5C]");
		object obj94 = (nint)0 + (nint)508;
		obj94 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = 0f;
		_ = 5f;
		_ = 0f;
		nint num47 = (nint)typeof(PrizePositionData);
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1345 @ S0_v497 (Il2CppClass<PrizePositionData>)+5C]");
		object obj95 = (nint)0 + (nint)520;
		obj95 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		PrizePositionData.rewardRotationDuration = 10f;
	}

	private static bool IsRewardMysteryBox(CelebrationReward reward)
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = reward;
		return flag;
	}

	public static void SetNextRewardUid(long rewardUid)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public static MysteryBox.Type ConvertRewardOriginToBoxType(CelebrationRewardOrigin origin)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ L0 (UI.Screens.RewardManagement.CelebrationRewardOrigin)+8]");
		if ((nint)0 == 1)
		{
			return MysteryBox.Type.Super;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ L0 (UI.Screens.RewardManagement.CelebrationRewardOrigin)+8]");
		if ((nint)0 == 2)
		{
			return MysteryBox.Type.Super;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ L0 (UI.Screens.RewardManagement.CelebrationRewardOrigin)+8]");
		if ((nint)0 == 4)
		{
			return MysteryBox.Type.Super;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ L0 (UI.Screens.RewardManagement.CelebrationRewardOrigin)+8]");
		if ((nint)0 == 5)
		{
			return MysteryBox.Type.Super;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ L0 (UI.Screens.RewardManagement.CelebrationRewardOrigin)+8]");
		return ((nint)0 == 13) ? MysteryBox.Type.Super : MysteryBox.Type.Normal;
	}

	private static int GetPendingRewardPriority(CelebrationRewardOrigin origin)
	{
		//IL_01eb: Expected Obj, but got I4
		//IL_0124: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		object obj = origin - 1;
		if (origin == CelebrationRewardOrigin.MysteryBox)
		{
			goto IL_007e;
		}
		if ((nint)obj != 1)
		{
			if ((nint)obj != 2)
			{
				if ((nint)obj == 3)
				{
					goto IL_007e;
				}
				if ((nint)obj == 4)
				{
					goto IL_008c;
				}
				object obj2 = origin - 12;
				if (origin == CelebrationRewardOrigin.MysteryBoxMini)
				{
					return 2;
				}
				if ((nint)obj2 == 1)
				{
					return 1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj3 = origin;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
		}
		goto IL_008c;
		IL_008c:
		return 1;
		IL_007e:
		return 0;
	}

	static RewardManager()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03a8: Expected Obj, but got I4
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected Obj, but got Unknown
		//IL_03ea: Expected VT, but got Obj
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected Obj, but got Unknown
		//IL_045e: Expected I, but got Obj
		//IL_0474: Expected Obj, but got I
		//IL_00f0: Expected I, but got Obj
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_025f: Expected Obj, but got I4
		//IL_0183: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_02e7: Expected Obj, but got I
		//IL_01c4: Expected I, but got Obj
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> boardThemeData = InventorySave.boardThemeData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<> list = default;
		((List<T>)(object)list).Add((T)boardThemeData);
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v23 (Il2CppClass<RewardManager+<>c>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v137 (Il2CppClass<RewardManager+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__15_0 == null;
		bool flag2 = !flag;
		Func<_0021_00210, _0021_00211> selector = (Func<_0021_00210, _0021_00211>)(object)_003C_003Ec._003C_003E9__15_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v111 (Il2CppClass<RewardManager+<>c>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v131 (Il2CppClass<RewardManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Func<_0021_00210, _0021_00211> func = default;
			object obj7 = func + 16;
			obj7 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v128 (Il2CppClass<RewardManager+<>c>)+5C]");
			object obj8 = (nint)0 + (nint)4;
			obj8 = func;
			selector = func;
		}
		IEnumerable<_0021_00211> source = (IEnumerable<_0021_00211>)Enumerable.Select<TSource, TResult>((IEnumerable<TSource>)list, (Func<TSource, TResult>)(object)selector);
		IEnumerable<_0021_00210> enumerable = (IEnumerable<_0021_00210>)Enumerable.OfType<TResult>((IEnumerable)source);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj9 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj9 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v89 (Il2CppClass<UIScreenController>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num8 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v103 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj11 = obj4 + 4;
		object obj12 = obj11 + 1;
		obj11 = obj12;
		object obj13 = obj12 << 2;
		object obj14 = obj4 + obj13;
		obj14 = 103;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj4 + obj15;
			if ((nint)obj16 == 103)
			{
				object obj17 = obj4 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				return;
			}
		}
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}
}
