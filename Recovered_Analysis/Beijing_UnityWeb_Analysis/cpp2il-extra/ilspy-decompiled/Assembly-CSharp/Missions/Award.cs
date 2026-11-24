using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo;
using Kiloo.Common.Extensions;
using Onboarding;
using UI.Screens.BoardScreenInternal;
using UnityEngine;

namespace Missions;

public abstract class Award
{
	protected readonly AwardStaticData _awardData;

	private AwardTier _awardActiveTier;

	private DateTime _previewDateTime;

	protected AwardTier _awardProgressTier;

	protected readonly PersistentAwardProgress savedProgress;

	private bool isInPreview__BackingField;

	public AwardTierType tierAnimationPlayed;

	private const char SEPERATOR_CHAR = ';';

	private Action<Award> m_onStateChangedHandler;

	public AwardStaticData awardsData
	{
		get
		{
			//IL_00f5: Expected I, but got Obj
			//IL_010b: Expected Obj, but got I
			//IL_0169: Expected Obj, but got I4
			//IL_00a8: Expected I, but got Obj
			//IL_0037: Expected I, but got Obj
			nint num = (nint)typeof(OnboardingTracking);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			bool flag = obj == null;
			List<string> list;
			if (this != null)
			{
				if (!flag)
				{
					nint num2 = (nint)typeof(OnboardingTracking);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v32 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				list = OnboardingTracking.listOfScreensAfterFrontscreen;
			}
			else
			{
				if (!flag)
				{
					nint num3 = (nint)typeof(OnboardingTracking);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v20 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				list = OnboardingTracking.listOfScreensAfterGameover;
			}
			bool flag2 = list._size > 5;
			return (AwardStaticData)flag2;
		}
	}

	public AwardGoal[] goals => (AwardGoal[])(object)_awardData;

	public DateTime lastStateChangeDateTime
	{
		get
		{
			//IL_000d: Expected VT, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.Award)+38]");
			return (DateTime)0;
		}
	}

	public AwardState awardState
	{
		get
		{
			//IL_0036: Expected I4, but got Obj
			if (_awardActiveTier != null)
			{
				AwardTier awardActiveTier = _awardActiveTier;
				return (AwardState)awardActiveTier.listGoals__BackingField;
			}
			return AwardState.NotSet;
		}
		set
		{
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected Obj, but got Unknown
			//IL_007d: Expected Obj, but got I4
			//IL_0090: Expected Obj, but got I4
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 4;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			obj2 = 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Enum obj3 = default;
			IFormatProvider provider = default;
			if (obj3.System_002EIConvertible_002EToBoolean(provider))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				_ = 0;
				Action<RefreshType> action = default;
				object obj4 = action + 16;
				obj4 = this;
				AppRefreshHandler.refresh += action;
			}
		}
	}

	public bool isNew
	{
		get
		{
			PersistentAwardProgress persistentAwardProgress = savedProgress;
			return (byte)persistentAwardProgress.currentActiveAwardState != 0;
		}
		set
		{
			PersistentAwardProgress persistentAwardProgress = savedProgress;
			persistentAwardProgress.currentActiveAwardState = (value ? AwardState.InProgress : AwardState.NotSet);
		}
	}

	public unsafe AwardTierType activeTierType
	{
		get
		{
			//IL_0060: Expected Obj, but got I4
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected I4, but got Unknown
			ref bool reference = ref *(bool*)null;
			Dictionary<AwardId, bool> awardHasPayedOut = PlayerSave.awardHasPayedOut;
			AwardStaticData awardData = _awardData;
			bool flag = awardHasPayedOut.TryGetValue(awardData.id__BackingField, out reference);
			bool flag2 = reference;
			object obj = (flag ? 1 : 0) ^ 1;
			return (flag2 | obj) ? AwardTierType.Bronze : AwardTierType.None;
		}
	}

	public bool isInPreview
	{
		get
		{
			AwardTier awardActiveTier = _awardActiveTier;
			return (byte)awardActiveTier.tierType__BackingField != 0;
		}
		set
		{
			Dictionary<AwardId, bool> awardHasPayedOut = PlayerSave.awardHasPayedOut;
			AwardStaticData awardData = _awardData;
			Kiloo.Common.Extensions.CollectionExtensions.AddOrSet(awardHasPayedOut, awardData.id__BackingField, value);
		}
	}

	public int reward => isInPreview__BackingField ? 1 : 0;

	private event Action<Award> onStateChangedHandler
	{
		add
		{
			//IL_0556: Unknown result type (might be due to invalid IL or missing references)
			//IL_055b: Expected Obj, but got Unknown
			//IL_0564: Unknown result type (might be due to invalid IL or missing references)
			//IL_0569: Expected Obj, but got Unknown
			//IL_0572: Unknown result type (might be due to invalid IL or missing references)
			//IL_0577: Expected Obj, but got Unknown
			//IL_0580: Unknown result type (might be due to invalid IL or missing references)
			//IL_0585: Expected Obj, but got Unknown
			//IL_058e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0593: Expected Obj, but got Unknown
			//IL_059c: Expected Obj, but got I4
			//IL_05b3: Expected I4, but got Obj
			//IL_022f: Expected I, but got Obj
			//IL_0245: Expected Obj, but got I
			//IL_03e2: Expected Obj, but got I4
			//IL_0270: Expected I, but got Obj
			//IL_003a: Expected Obj, but got I
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected Obj, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected Obj, but got Unknown
			//IL_02bd: Expected I, but got Obj
			//IL_02d3: Expected Obj, but got I
			//IL_0611: Expected Obj, but got I4
			//IL_034b: Expected I, but got Obj
			//IL_0361: Expected Obj, but got I
			//IL_02fe: Expected I, but got Obj
			//IL_010b: Expected Obj, but got I
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Expected Obj, but got Unknown
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Expected Obj, but got Unknown
			//IL_0703: Unknown result type (might be due to invalid IL or missing references)
			//IL_0708: Expected Obj, but got Unknown
			//IL_071d: Expected Obj, but got I4
			//IL_038c: Expected I, but got Obj
			object obj = default;
			Action<Award> action = (Action<Award>)(obj + 32);
			object obj2 = obj + 24;
			object obj3 = obj + 16;
			object obj4 = obj + 8;
			object obj5 = obj + 40;
			obj5 = 0;
			PersistentAwardProgress persistentAwardProgress = savedProgress;
			persistentAwardProgress.currentProgressAwardState = (AwardState)value;
			PersistentAwardProgress persistentAwardProgress2 = savedProgress;
			if (persistentAwardProgress2.currentProgressAwardState == AwardState.InProgress)
			{
				if (this.m_onStateChangedHandler != null)
				{
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S2_v29 (Il2CppMethodInfo)+18]");
					object obj6 = 0;
					object obj7 = obj6;
					object obj8 = obj7 & 0x3FFF;
					object obj9 = obj8 + 97173;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v73 @ S3_v12 (should have been resolved before IL gen)");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				return;
			}
			PersistentAwardProgress persistentAwardProgress3 = savedProgress;
			if (persistentAwardProgress3.currentProgressAwardState != AwardState.Collectible)
			{
				PersistentAwardProgress persistentAwardProgress4 = savedProgress;
				if (persistentAwardProgress4.currentProgressAwardState == AwardState.Finished)
				{
					if (this.m_onStateChangedHandler != null)
					{
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S2_v25 (Il2CppMethodInfo)+18]");
						object obj10 = 0;
						object obj11 = obj10;
						object obj12 = obj11 & 0x3FFF;
						object obj13 = obj12 + 97173;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v161 @ S3_v7 (should have been resolved before IL gen)");
					}
					AwardStaticData awardData = _awardData;
					obj5 = awardData.id__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					throw new NullReferenceException();
				}
				return;
			}
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v31 (Il2CppClass<UIScreenController>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v99 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIScreenController instance = UIScreenController.Instance;
			if ((object)instance != null)
			{
				nint num5 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v76 (Il2CppClass<Strings>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num6 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v95 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string format = Strings.GetDefault("AWARD_SLIDEIN_LINE2");
				AwardStaticData awardData2 = _awardData;
				string args = Strings.GetDefault(awardData2.title__BackingField);
				string text = string.Format(format, (object[])(object)args);
				nint num7 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v85 (Il2CppClass<UIScreenController>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num8 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v91 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = UIScreenController.ShouldShowOnlineScreen();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				string text2 = default;
				text2.m_stringLength = 12;
				AwardTier awardProgressTier = _awardProgressTier;
				_ = awardProgressTier.tierType__BackingField;
				object obj17 = text2 + 12;
				obj17 = text;
				((UIScreenController)flag)._QueueMessage(text2);
			}
			AwardStaticData awardData3 = _awardData;
			obj5 = awardData3.id__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onStateChangedHandler;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 40;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	protected unsafe Award(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler)
	{
		//IL_0182: Expected I, but got Obj
		//IL_0198: Expected Obj, but got I
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02bf: Expected Obj, but got I
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02e3: Expected Obj, but got I
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0078: Invalid comparison between VT and I4
		//IL_008a: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00a7: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01cc: Expected Obj, but got VT
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected VT, but got Unknown
		//IL_01fd: Expected F4, but got Obj
		//IL_01f8: Expected native int or pointer, but got VT
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0225: Expected F4, but got Obj
		//IL_0220: Expected native int or pointer, but got VT
		//IL_023a: Expected F4, but got I
		//IL_0235: Expected native int or pointer, but got VT
		//IL_024f: Expected I4, but got VT
		//IL_024f: Expected Obj, but got I
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_0266: Expected Obj, but got VT
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_0289: Expected F4, but got Obj
		//IL_0284: Expected native int or pointer, but got VT
		//IL_0134: Expected F4, but got Obj
		//IL_012f: Expected native int or pointer, but got VT
		//IL_0149: Expected F4, but got I
		//IL_0144: Expected native int or pointer, but got VT
		//IL_015e: Expected I4, but got VT
		//IL_015e: Expected Obj, but got I
		//IL_00e8: Expected I, but got Obj
		_ = 1;
		_awardActiveTier = (AwardTier)(object)savedProgress;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v31 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 28;
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v9 (System.Boolean)+38]");
		obj2 = 0;
		object obj3 = this + 32;
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v13 (System.Boolean)+24]");
		obj3 = 0;
		object obj4 = this + 36;
		GameObject gameObject = ((Component)this).gameObject;
		obj4 = gameObject;
		object obj5 = this + 24;
		obj5 = handler;
		bool flag3 = _previewDateTime != (DateTime)(object)0;
		Boards.BoardId? boardId = ((HoverboardOverlayHelper)flag3).EventBoard();
		((HoverboardOverlayHelper)this).LateUpdate();
		nint num3 = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v25 (Il2CppClass<GlobalColorsGenerated>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v49 (Il2CppClass<GlobalColorsGenerated>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = default;
		object obj7 = obj8 + 40;
		obj7 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR;
		object obj9 = obj8 + 44;
		obj9 = obj7;
		Matrix4x4 matrix4x = (Matrix4x4)(obj8 + 48);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
		object obj10 = obj8 + 24;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v36+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.Award)+48]");
		((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
		object obj11 = obj8 + 16;
		obj11 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
		object obj12 = obj8 + 20;
		obj12 = obj11;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.Award)+4C]");
		((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
	}

	private unsafe void AppWillRefresh(RefreshType refreshType)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = ((RefreshType*)(int)refreshType)->value__;
		object obj2 = obj + 8;
		obj2 = obj;
	}

	public void Activate()
	{
		//IL_0211: Expected I, but got Obj
		//IL_0227: Expected Obj, but got I
		//IL_00a8: Expected I, but got Obj
		//IL_0037: Expected I, but got Obj
		//IL_00f5: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_0272: Expected I4, but got Obj
		//IL_0183: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_0136: Expected I, but got Obj
		//IL_01c4: Expected I, but got Obj
		nint num = (nint)typeof(OnboardingTracking);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		List<string> list;
		if (this != null)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(OnboardingTracking);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v56 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			list = OnboardingTracking.listOfScreensAfterFrontscreen;
		}
		else
		{
			if (!flag)
			{
				nint num3 = (nint)typeof(OnboardingTracking);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v44 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			list = OnboardingTracking.listOfScreensAfterGameover;
		}
		if (list._size <= 1)
		{
			return;
		}
		nint num4 = (nint)typeof(OnboardingTracking);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v16 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(OnboardingTracking);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v34 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnboardingTracking.EnableOnboardingTracking((OnboardingTracking.ScreenType)this);
		string[] separator = list.ToArray();
		StringSplitOptions options = (StringSplitOptions)(list._size - 1);
		string[] array = ",".Split((char[])(object)separator, 1, options);
		nint num6 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v27 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num7 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v30 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private unsafe void CheckTierValues()
	{
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected I, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected Ref, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected Ref, but got Unknown
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected Ref, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected Ref, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0656: Expected I, but got Obj
		//IL_066c: Expected Obj, but got I
		//IL_0510: Expected I, but got Obj
		//IL_052b: Expected I, but got Obj
		//IL_0541: Expected Obj, but got I
		//IL_05cc: Expected I, but got Obj
		//IL_05e7: Expected I, but got Obj
		//IL_05fd: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_028b: Expected I, but got Obj
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_02d8: Expected I, but got Obj
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected Obj, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		object obj = default;
		nint num = (nint)(obj + 24);
		object obj2 = obj + 8;
		ref AwardTier reference = ref *(AwardTier*)(obj + 20);
		reference = ref *(AwardTier*)null;
		ref AwardTier reference2 = ref *(AwardTier*)(obj + 16);
		reference2 = ref *(AwardTier*)null;
		ref AwardTier reference3 = ref *(AwardTier*)(obj + 12);
		reference3 = ref *(AwardTier*)null;
		ref AwardTier reference4 = ref *(AwardTier*)(obj + 4);
		reference4 = ref *(AwardTier*)null;
		PersistentAwardProgress persistentAwardProgress = savedProgress;
		if (persistentAwardProgress.currentActiveAwardState == AwardState.Finished)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v104 (Il2CppClass<System.Type>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v127 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = typeof(AwardTierType);
			((IntPtr*)num)->m_value = (void*)(nint)obj;
			Type enumType = Type.internal_from_handle((IntPtr)num);
			nint num4 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v60 (Il2CppClass<System.Enum>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v75 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string[] array = Enum.InternalGetNames((System.RuntimeType)enumType);
			AwardTierType awardTierType = (AwardTierType)array.Length;
			while (true)
			{
				AwardTierType awardTierType2 = awardTierType - 1;
				if (awardTierType2 >= AwardTierType.Bronze)
				{
					AwardStaticData awardData = _awardData;
					bool flag = awardData.missionTiers__BackingField.TryGetValue(awardTierType2, out reference4);
					bool flag2 = !flag;
					awardTierType = awardTierType2;
					if (!flag2)
					{
						object obj5 = this + 12;
						obj5 = reference4;
						object obj6 = this + 24;
						obj6 = reference4;
						break;
					}
					continue;
				}
				break;
			}
			return;
		}
		PersistentAwardProgress persistentAwardProgress2 = savedProgress;
		if (persistentAwardProgress2.progressTierType != AwardTierType.None)
		{
			AwardStaticData awardData2 = _awardData;
			PersistentAwardProgress persistentAwardProgress3 = savedProgress;
			if (awardData2.missionTiers__BackingField.TryGetValue(persistentAwardProgress3.progressTierType, out reference))
			{
				object obj7 = this + 24;
				obj7 = reference;
				PersistentAwardProgress persistentAwardProgress4 = savedProgress;
				if (persistentAwardProgress4.activeTierType != AwardTierType.None)
				{
					AwardStaticData awardData3 = _awardData;
					PersistentAwardProgress persistentAwardProgress5 = savedProgress;
					if (awardData3.missionTiers__BackingField.TryGetValue(persistentAwardProgress5.activeTierType, out reference2))
					{
						object obj8 = this + 12;
						obj8 = reference2;
					}
				}
				CheckAndUpdateProgress();
				goto IL_03e1;
			}
		}
		AwardTierType awardTierType3 = AwardTierType.None;
		while (true)
		{
			nint num6 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v44 (Il2CppClass<System.Type>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num7 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v79 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = typeof(AwardTierType);
			((IntPtr*)num)->m_value = (void*)(nint)obj2;
			Type enumType2 = Type.internal_from_handle((IntPtr)num);
			nint num8 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v53 (Il2CppClass<System.Enum>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num9 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v75 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string[] array2 = Enum.InternalGetNames((System.RuntimeType)enumType2);
			if ((int)awardTierType3 >= array2.Length)
			{
				break;
			}
			AwardStaticData awardData4 = _awardData;
			if (!awardData4.missionTiers__BackingField.TryGetValue(awardTierType3, out reference3))
			{
				AwardTierType awardTierType4 = awardTierType3 + 1;
				awardTierType3 = awardTierType4;
				continue;
			}
			object obj11 = this + 24;
			obj11 = reference3;
			object obj12 = this + 12;
			obj12 = reference3;
			PersistentAwardProgress persistentAwardProgress6 = savedProgress;
			persistentAwardProgress6.currentActiveAwardState = AwardState.InProgress;
			PersistentAwardProgress persistentAwardProgress7 = savedProgress;
			persistentAwardProgress7.currentProgressAwardState = AwardState.InProgress;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			break;
		}
		goto IL_03e1;
		IL_03e1:
		if (_awardProgressTier != null)
		{
			PersistentAwardProgress persistentAwardProgress8 = savedProgress;
			if (persistentAwardProgress8.currentProgressAwardState == AwardState.InProgress)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public bool BelongsToState(AwardState state)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_001e: Expected Obj, but got I4
		//IL_0030: Expected I4, but got Obj
		object obj = _previewDateTime + 16;
		object obj2 = (int)state << 3;
		object obj3 = obj + obj2;
		return (byte)(int)obj3 != 0;
	}

	public int GetProgressAsPercentage()
	{
		if (_awardActiveTier != null)
		{
			AwardTier awardActiveTier = _awardActiveTier;
			return awardActiveTier.reward__BackingField;
		}
		return 0;
	}

	protected void CheckAndUpdateProgress()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		AwardTier awardActiveTier = _awardActiveTier;
		AwardTier awardProgressTier = _awardProgressTier;
		if (awardActiveTier.tierType__BackingField > awardProgressTier.tierType__BackingField)
		{
			object obj = this + 12;
			AwardStaticData awardData = _awardData;
			AwardTier awardProgressTier2 = _awardProgressTier;
			AwardTier awardTier = awardData.missionTiers__BackingField.get_Item(awardProgressTier2.tierType__BackingField);
			obj = awardTier;
			PersistentAwardProgress persistentAwardProgress = savedProgress;
			PersistentAwardProgress persistentAwardProgress2 = savedProgress;
			persistentAwardProgress.currentActiveAwardState = persistentAwardProgress2.currentProgressAwardState;
		}
	}

	private void GoToState(AwardState state)
	{
		bool flag = (byte)(state & AwardState.InProgress) != 0;
		isInPreview__BackingField = flag;
	}

	private void FlurryLogAwardCollectibleInformation(string throphyDataID, int activeTierTypeID, DateTime dateTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public void RewardPayedOut()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_0178: Expected Obj, but got I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		AwardStaticData awardData = _awardData;
		if (~(awardData.useFacebook__BackingField ? 1u : 0u) == 0)
		{
			nint num = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v30 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v37 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (AgeRestriction.waitForAgeRestriction)
			{
				return;
			}
		}
		PersistentAwardProgress persistentAwardProgress = savedProgress;
		if (persistentAwardProgress.currentProgressAwardState == AwardState.Finished)
		{
			return;
		}
		AwardTier awardProgressTier = _awardProgressTier;
		object obj2 = awardProgressTier.listGoals__BackingField + 12;
		object obj3 = 0;
		object obj7 = default;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				object obj4 = awardProgressTier.listGoals__BackingField + 16;
				object obj5 = obj3 << 2;
				object obj6 = obj4 + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				if (obj7 != null)
				{
					object obj8 = obj3 + 1;
					obj3 = obj8;
					continue;
				}
				break;
			}
			onStateChangedHandler += (Action<Award>)2;
			break;
		}
	}

	protected void CalculateNextActiveTier()
	{
		//IL_002f: Expected Obj, but got I4
		PersistentAwardProgress persistentAwardProgress = savedProgress;
		if (persistentAwardProgress.currentActiveAwardState == AwardState.Collectible)
		{
			bool awardsFirstLoaded = PlayerSave.awardsFirstLoaded;
			AwardStaticData awardData = _awardData;
			Kiloo.Common.Extensions.CollectionExtensions.AddOrSet((Dictionary<AwardId, bool>)awardsFirstLoaded, awardData.id__BackingField, value: true);
			MoveToNextTierOrFinishIfLast();
		}
	}

	protected unsafe void MoveToNextTierOrFinishIfLast()
	{
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Ref, but got Unknown
		//IL_01c3: Expected Obj, but got VT
		//IL_01d8: Expected VT, but got Obj
		//IL_020b: Expected Obj, but got I
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_015a: Expected Obj, but got VT
		//IL_016c: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		ref AwardTier reference = ref *(AwardTier*)(obj2 + 24);
		reference = ref *(AwardTier*)null;
		AwardTier awardActiveTier = _awardActiveTier;
		AwardTier awardProgressTier = _awardProgressTier;
		if (awardActiveTier.tierType__BackingField < awardProgressTier.tierType__BackingField)
		{
			AwardStaticData awardData = _awardData;
			AwardTier awardActiveTier2 = _awardActiveTier;
			AwardTierType key = awardActiveTier2.tierType__BackingField + 1;
			if (awardData.missionTiers__BackingField.TryGetValue(key, out reference))
			{
				object obj4 = this + 12;
				obj4 = reference;
				AwardTier awardActiveTier3 = _awardActiveTier;
				AwardTier awardProgressTier2 = _awardProgressTier;
				if (awardActiveTier3.tierType__BackingField == awardProgressTier2.tierType__BackingField)
				{
					PersistentAwardProgress persistentAwardProgress = savedProgress;
					if (persistentAwardProgress.currentProgressAwardState != AwardState.Collectible)
					{
						PersistentAwardProgress persistentAwardProgress2 = savedProgress;
						if (persistentAwardProgress2.currentProgressAwardState != AwardState.Finished)
						{
							PersistentAwardProgress persistentAwardProgress3 = savedProgress;
							persistentAwardProgress3.currentActiveAwardState = AwardState.InProgress;
							goto IL_02f5;
						}
					}
					PersistentAwardProgress persistentAwardProgress4 = savedProgress;
					if (persistentAwardProgress4.currentActiveAwardState != AwardState.Collectible)
					{
						DateTime today = CDateTime.Today;
						obj3 = today;
						obj = obj3;
						_previewDateTime = (DateTime)obj;
					}
					PersistentAwardProgress persistentAwardProgress5 = savedProgress;
					persistentAwardProgress5.currentActiveAwardState = AwardState.Collectible;
				}
			}
		}
		else
		{
			PersistentAwardProgress persistentAwardProgress6 = savedProgress;
			if (persistentAwardProgress6.currentProgressAwardState == AwardState.Finished)
			{
				PersistentAwardProgress persistentAwardProgress7 = savedProgress;
				DateTime today2 = CDateTime.Today;
				obj2 = today2;
				obj = obj2;
				persistentAwardProgress7.lastActiveStateChangeDateTime = (DateTime)obj;
				PersistentAwardProgress persistentAwardProgress8 = savedProgress;
				persistentAwardProgress8.currentActiveAwardState = AwardState.Finished;
			}
		}
		goto IL_02f5;
		IL_02f5:
		if (this.m_onStateChangedHandler != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S2_v3 (Il2CppMethodInfo)+18]");
			object obj5 = 0;
			object obj6 = obj5;
			object obj7 = obj6 & 0x3FFF;
			object obj8 = obj7 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v118 @ S3_v6 (should have been resolved before IL gen)");
		}
	}

	public unsafe void CompleteCurrentTierIfDebug()
	{
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected I, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Ref, but got Unknown
		//IL_01b6: Expected I, but got Obj
		//IL_01cc: Expected Obj, but got I
		//IL_0204: Expected I, but got Obj
		//IL_021f: Expected I, but got Obj
		//IL_0235: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00f7: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_01a3: Expected Obj, but got I4
		object obj = default;
		nint num = (nint)(obj + 8);
		ref AwardTier reference = ref *(AwardTier*)(obj + 4);
		reference = ref *(AwardTier*)null;
		AwardTier awardProgressTier = _awardProgressTier;
		AwardTierType awardTierType = awardProgressTier.tierType__BackingField + 1;
		AwardTierType awardTierType2 = awardTierType;
		while (true)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v20 (Il2CppClass<System.Type>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v52 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = typeof(AwardTierType);
			((IntPtr*)num)->m_value = (void*)(nint)obj;
			Type enumType = Type.internal_from_handle((IntPtr)num);
			nint num4 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v29 (Il2CppClass<System.Enum>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v48 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string[] array = Enum.InternalGetNames((System.RuntimeType)enumType);
			if ((int)awardTierType2 < array.Length)
			{
				AwardStaticData awardData = _awardData;
				if (awardData.missionTiers__BackingField.TryGetValue(awardTierType2, out reference))
				{
					break;
				}
				AwardTierType awardTierType3 = awardTierType2 + 1;
				awardTierType2 = awardTierType3;
				continue;
			}
			onStateChangedHandler += (Action<Award>)3;
			return;
		}
		object obj4 = this + 24;
		obj4 = reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		onStateChangedHandler += (Action<Award>)1;
	}

	public bool HasCompletedTierExact(AwardTierType tier)
	{
		if (~(isInPreview__BackingField ? 1u : 0u) == 0)
		{
			if (tier == AwardTierType.Silver)
			{
				goto IL_006c;
			}
		}
		else
		{
			PersistentAwardProgress persistentAwardProgress = savedProgress;
			if (persistentAwardProgress.currentActiveAwardState == (AwardState)tier)
			{
				goto IL_006c;
			}
		}
		return false;
		IL_006c:
		return true;
	}

	public void SetBackToInProgress()
	{
		//IL_006c: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_POPUP ? 1u : 0u) == 0)
		{
			CompleteCurrentTierIfDebug();
		}
	}

	public PersistentAwardProgress GetPersistentProgress()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_010e: Expected I, but got Obj
		//IL_0124: Expected Obj, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_014f: Expected I, but got Obj
		//IL_01db: Expected Obj, but got I4
		//IL_025a: Expected Obj, but got F4
		//IL_0214: Expected Obj, but got I4
		//IL_024d: Expected Obj, but got I4
		PersistentAwardProgress persistentAwardProgress = savedProgress;
		if (persistentAwardProgress.currentActiveAwardState == AwardState.Collectible)
		{
			return (PersistentAwardProgress)100;
		}
		PersistentAwardProgress persistentAwardProgress2 = savedProgress;
		if (persistentAwardProgress2.currentActiveAwardState == AwardState.Finished)
		{
			return (PersistentAwardProgress)100;
		}
		AwardTier awardActiveTier = _awardActiveTier;
		object obj = awardActiveTier.listGoals__BackingField + 12;
		object obj2 = 0;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = awardActiveTier.listGoals__BackingField + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			obj7 = obj8 + obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S2_v6+8]");
			obj10 = 0 + obj11;
			object obj12 = obj2 + 1;
			obj2 = obj12;
		}
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v23 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v46 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = (float)obj7 * 100f;
		float num4 = num3 / (float)obj10;
		if (num4 < 0f)
		{
			num4 = 0f;
		}
		else if (num4 > 100f)
		{
			num4 = 100f;
		}
		if (num4 != num4)
		{
			return (PersistentAwardProgress)int.MinValue;
		}
		if (!(num4 < 2.1474836E+09f))
		{
			return (PersistentAwardProgress)int.MinValue;
		}
		if (!(num4 > -2.1474836E+09f))
		{
			return (PersistentAwardProgress)int.MinValue;
		}
		return (PersistentAwardProgress)num4;
	}

	public void SetAwardTierToAlmostComplete()
	{
		//IL_0043: Expected Obj, but got I
		PersistentAwardProgress persistentAwardProgress = savedProgress;
		if (persistentAwardProgress.currentActiveAwardState == AwardState.Finished)
		{
			PersistentAwardProgress persistentAwardProgress2 = savedProgress;
			AwardStaticData awardData = _awardData;
			Dictionary<AwardTierType, AwardTier> dictionary = awardData.missionTiers__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6 (System.Collections.Generic.Dictionary`2<Missions.AwardTierType, Missions.AwardTier>)+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6 (System.Collections.Generic.Dictionary`2<Missions.AwardTierType, Missions.AwardTier>)+1C]");
			object obj = num - 0;
			if ((nint)persistentAwardProgress2.activeTierType != (nint)obj)
			{
				PersistentAwardProgress persistentAwardProgress3 = savedProgress;
				AwardTierType awardTierType = persistentAwardProgress3.activeTierType + 1;
				persistentAwardProgress3.activeTierType = awardTierType;
				PersistentAwardProgress persistentAwardProgress4 = savedProgress;
				persistentAwardProgress4.currentActiveAwardState = AwardState.InProgress;
				PersistentAwardProgress persistentAwardProgress5 = savedProgress;
				AwardTierType progressTierType = persistentAwardProgress5.progressTierType + 1;
				persistentAwardProgress5.progressTierType = progressTierType;
				PersistentAwardProgress persistentAwardProgress6 = savedProgress;
				persistentAwardProgress6.currentProgressAwardState = AwardState.InProgress;
				CheckTierValues();
			}
		}
	}

	public abstract bool IsGoalAccomplished(AwardGoal goal);

	protected abstract int GetProgressForGoal(AwardGoal goal);

	protected abstract void ActivateCurrentAwardTier();

	protected virtual void DeactivateCurrentAwardTier()
	{
		//IL_0133: Expected I, but got Obj
		//IL_0149: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG ? 1u : 0u) != 0)
		{
			return;
		}
		AwardTier awardActiveTier = _awardActiveTier;
		object obj2 = awardActiveTier.listGoals__BackingField + 12;
		object obj3 = 0;
		object obj8 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj4 = awardActiveTier.listGoals__BackingField + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v25+8]");
				int value = (int)(-1);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v26+14]");
				StatTools.AddValue(Stat.NotSet, value);
			}
			object obj9 = obj3 + 1;
			obj3 = obj9;
		}
	}

	protected abstract void RecordNewOffsets();
}
