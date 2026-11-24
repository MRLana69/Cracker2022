using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Kiloo.Common.JsonUtil;
using Kiloo.Common.Utility;
using UI.Screens;
using UnityEngine;
using WeeklyHunt;

public static class PrizePositionData
{
	[StructLayout((LayoutKind)0, Size = 36)]
	public struct TransformValues
	{
		public Vector3 PositionOffset;

		public Vector3 RotationOffset;

		public Vector3 ScaleOffset;

		public unsafe TransformValues(Vector3 positionOffset, Vector3 rotation, Vector3 scale)
		{
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected Obj, but got Unknown
			//IL_0064: Expected Obj, but got Ref
			//IL_006c: Expected Obj, but got VT
			//IL_0077: Expected Obj, but got Ref
			//IL_007f: Expected Obj, but got VT
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v3+60]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S3_v4 (should have been resolved before IL gen)");
			object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
			obj6 = rotation;
			object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 20));
			obj7 = scale;
		}
	}

	public static Vector3 HOVERBOARD_POSITION_OFFSET;

	public static Vector3 HOVERBOARD_SCALE_OFFSET;

	public static Vector3 HOVERBOARD_ROTATION_OFFSET;

	public static Vector3 KEY_POSITION_OFFSET;

	public static Vector3 KEY_SCALE_OFFSET;

	public static Vector3 KEY_ROTATION_OFFSET;

	public static Vector3 SCORE_BOOSTER_POSITION_OFFSET;

	public static Vector3 SCORE_BOOSTER_SCALE_OFFSET;

	public static Vector3 SCORE_BOOSTER_ROTATION_OFFSET;

	public static Vector3 HEADSTART_POSITION_OFFSET;

	public static Vector3 HEADSTART_SCALE_OFFSET;

	public static Vector3 HEADSTART_ROTATION_OFFSET;

	public static Vector3 MYSTERY_BOX_POSITION;

	public static Vector3 MYSTERY_BOX_SCALE;

	public static Vector3 MYSTERY_BOX_ROTATION;

	public static Vector3 SUPER_MYSTERY_BOX_POSITION_OFFSET;

	public static Vector3 SUPER_MYSTERY_BOX_SCALE_OFFSET;

	public static Vector3 SUPER_MYSTERY_BOX_ROTATION_OFFSET;

	public static Vector3 UNKNOWN_REWARD_POSITION_OFFSET;

	public static Vector3 UNKNOWN_REWARD_SCALE_OFFSET;

	public static Vector3 UNKNOWN_REWARD_ROTATION_OFFSET;

	public static Vector3 PRESENT_POSITION_OFFSET;

	public static Vector3 PRESENT_SCALE_OFFSET;

	public static Vector3 PRESENT_ROTATION_OFFSET;

	public static Vector3 DRAGON_BOARD_POSITION;

	public static Vector3 DRAGON_BOARD_SCALE;

	public static Vector3 DRAGON_BOARD_ROTATION;

	public static Vector3 SLEIGH_BOARD_POSITION;

	public static Vector3 SLEIGH_BOARD_SCALE;

	public static Vector3 SLEIGH_BOARD_ROTATION;

	public static Vector3 CHRISTMAS2014_BOARD_POSITION;

	public static Vector3 CHRISTMAS2014_BOARD_SCALE;

	public static Vector3 CHRISTMAS2014_BOARD_ROTATION;

	public static Vector3 RIO_HUNT_BOARD_POSITION;

	public static Vector3 RIO_HUNT_BOARD_SCALE;

	public static Vector3 RIO_HUNT_BOARD_ROTATION;

	public static Vector3 CHERRY2017_BOARD_POSITION;

	public static Vector3 CHERRY2017_BOARD_ROTATION;

	public static Vector3 CHERRY2017_BOARD_SCALE;

	public static Vector3 NORTHPOLE2016_HUNT_BOARD_POSITION;

	public static Vector3 NORTHPOLE2016_HUNT_BOARD_SCALE;

	public static Vector3 NORTHPOLE2016_HUNT_BOARD_ROTATION;

	private static Dictionary<WeeklyHuntData.WeeklyHuntPrize, TransformValues?> _cachedPositionData;

	public static Vector3 rewardRotationOffsetFrom;

	public static Vector3 rewardRotationOffsetTo;

	public static float rewardRotationDuration;

	public static TransformValues? GetPositioningDataForUnknownReward()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		TransformValues? transformValues = default;
		object obj = (Nullable)transformValues + 76;
		object obj2 = default;
		obj = obj2;
		((UpgradeScreen)transformValues).Start();
		return transformValues;
	}

	public static TransformValues? GetPrizePositioningData(WeeklyHuntData.PrizeData prize)
	{
		TransformValues? result = default;
		return result;
	}

	public static void PositionModel(TransformValues? positionData, Transform rewardTransform, UIWidget prizeGuideWidget = null, bool hidePrize = false)
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		object obj = (object)rewardTransform & (object)prizeGuideWidget;
		object obj2 = obj & hidePrize;
		if (obj2 == null)
		{
			return;
		}
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<AdLocations>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AdTrackingSystemLogger.LogVideoAdButtonClick(AdLocations.DOUBLE_UP_VIDEOS);
	}

	public static void FitAndApplyOffsets(Transform rewardTransform, Vector3 newPosition, TransformValues? offsetValues, UIWidget targetWidget = null, bool isPresent = false)
	{
		//IL_0009: Invalid comparison between VT and I4
		//IL_004a: Invalid comparison between VT and I4
		//IL_003c: Expected I4, but got Obj
		//IL_003c: Expected Obj, but got VT
		//IL_00d0: Invalid comparison between VT and I4
		//IL_00ed: Invalid comparison between VT and I4
		//IL_0115: Invalid comparison between VT and I4
		if ((TransformValues)offsetValues != (TransformValues)(object)2)
		{
			((IngameScreen)(object)rewardTransform).SpeedometerPauseHandle((UIPanel)offsetValues, (IngameScreen.PowerUpType)targetWidget);
		}
		if (newPosition == (Vector3)(object)1)
		{
			float num = 1f;
		}
		else
		{
			float num = 0f;
		}
		if (newPosition == (Vector3)(object)0)
		{
			float num = 0.35f;
		}
		if ((TransformValues)offsetValues == (TransformValues)(object)1)
		{
			float num2 = 1f;
		}
		else
		{
			float num2 = 0f;
		}
		if ((TransformValues)offsetValues == (TransformValues)(object)0)
		{
			float num2 = 0.35f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8A61");
		YieldInstruction[] list = default;
		Coroutine coroutine = CoroutineUtil.WaitForAll(list);
	}
}
