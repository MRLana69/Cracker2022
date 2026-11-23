using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public static class PrizePositionData
{
	public struct TransformValues
	{
		public Vector3 PositionOffset;

		public Vector3 Rotation;

		public Vector3 Scale;

		public TransformValues(Vector3 positionOffset, Vector3 rotation, Vector3 scale)
		{
			//IL_000f: Expected VT, but got F4
			//IL_0028: Expected VT, but got F4
			//IL_0041: Expected VT, but got F4
			PositionOffset = (Vector3)positionOffset.x;
			_ = positionOffset.z;
			Rotation = (Vector3)rotation.x;
			_ = rotation.z;
			Scale = (Vector3)scale.x;
			_ = scale.z;
		}
	}

	public static Vector3 HOVERBOARD_POSITION;

	public static Vector3 HOVERBOARD_SCALE;

	public static Vector3 HOVERBOARD_ROTATION;

	public static Vector3 KEY_POSITION;

	public static Vector3 KEY_SCALE;

	public static Vector3 KEY_ROTATION;

	public static Vector3 SCORE_BOOSTER_POSITION;

	public static Vector3 SCORE_BOOSTER_SCALE;

	public static Vector3 SCORE_BOOSTER_ROTATION;

	public static Vector3 HEADSTART_POSITION;

	public static Vector3 HEADSTART_SCALE;

	public static Vector3 HEADSTART_ROTATION;

	public static Vector3 MYSTERY_BOX_POSITION;

	public static Vector3 MYSTERY_BOX_SCALE;

	public static Vector3 MYSTERY_BOX_ROTATION;

	public static Vector3 SUPER_MYSTERY_BOX_POSITION;

	public static Vector3 SUPER_MYSTERY_BOX_SCALE;

	public static Vector3 SUPER_MYSTERY_BOX_ROTATION;

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

	public static Vector3 PRESENT_POSITION_OFFSET;

	public static Vector3 PRESENT_ROTATION;

	public static Vector3 PRESENT_SCALE;

	private static Dictionary<WeeklyHuntManager.WeeklyHuntPrize, TransformValues?> _cachedPositionData;

	public unsafe static TransformValues? GetPrizePositioningData(WeeklyHuntManager.PrizeData prize)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1113: Unknown result type (might be due to invalid IL or missing references)
		//IL_1118: Expected Obj, but got Unknown
		//IL_1153: Unknown result type (might be due to invalid IL or missing references)
		//IL_1158: Expected VT, but got Unknown
		//IL_0034: Expected Obj, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got I4
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_01fd: Expected I, but got Obj
		//IL_021d: Expected Obj, but got I
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_023f: Expected I, but got Obj
		//IL_025f: Expected Obj, but got I
		//IL_0273: Expected I, but got Obj
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected VT, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected VT, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected VT, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected VT, but got Unknown
		//IL_031f: Expected native int or pointer, but got VT
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected Obj, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_0396: Expected I, but got Obj
		//IL_03b6: Expected Obj, but got I
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_03d8: Expected I, but got Obj
		//IL_03f8: Expected Obj, but got I
		//IL_040c: Expected I, but got Obj
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected Obj, but got Unknown
		//IL_0fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdb: Expected Obj, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected VT, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected VT, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected VT, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected VT, but got Unknown
		//IL_04b8: Expected native int or pointer, but got VT
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected Obj, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected Obj, but got Unknown
		//IL_1092: Unknown result type (might be due to invalid IL or missing references)
		//IL_1097: Expected Obj, but got Unknown
		//IL_10b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b9: Expected Obj, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected Obj, but got Unknown
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected Obj, but got Unknown
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_052f: Expected I, but got Obj
		//IL_054f: Expected Obj, but got I
		//IL_0563: Expected I, but got Obj
		//IL_0594: Expected I, but got Obj
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected Obj, but got Unknown
		//IL_10eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f0: Expected Obj, but got Unknown
		//IL_1001: Unknown result type (might be due to invalid IL or missing references)
		//IL_1006: Expected Obj, but got Unknown
		//IL_100f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1014: Expected Obj, but got Unknown
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected VT, but got Unknown
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected VT, but got Unknown
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected VT, but got Unknown
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected VT, but got Unknown
		//IL_0648: Expected native int or pointer, but got VT
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Expected Obj, but got Unknown
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected Obj, but got Unknown
		//IL_102c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1031: Expected Obj, but got Unknown
		//IL_103a: Unknown result type (might be due to invalid IL or missing references)
		//IL_103f: Expected Obj, but got Unknown
		//IL_1048: Unknown result type (might be due to invalid IL or missing references)
		//IL_104d: Expected Obj, but got Unknown
		//IL_1060: Unknown result type (might be due to invalid IL or missing references)
		//IL_1065: Expected VT, but got Unknown
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected Obj, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected Obj, but got Unknown
		//IL_06b1: Expected I, but got Obj
		//IL_06e2: Expected I, but got Obj
		//IL_0713: Expected I, but got Obj
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected Obj, but got Unknown
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected VT, but got Unknown
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected VT, but got Unknown
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected VT, but got Unknown
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Expected VT, but got Unknown
		//IL_07cf: Expected native int or pointer, but got VT
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected Obj, but got Unknown
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected Obj, but got Unknown
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Expected Obj, but got Unknown
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Expected Obj, but got Unknown
		//IL_0838: Expected I, but got Obj
		//IL_0869: Expected I, but got Obj
		//IL_089a: Expected I, but got Obj
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected Obj, but got Unknown
		//IL_0917: Unknown result type (might be due to invalid IL or missing references)
		//IL_091c: Expected VT, but got Unknown
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Expected VT, but got Unknown
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected VT, but got Unknown
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected VT, but got Unknown
		//IL_0956: Expected native int or pointer, but got VT
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Expected Obj, but got Unknown
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_0977: Expected Obj, but got Unknown
		//IL_098f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0994: Expected Obj, but got Unknown
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected Obj, but got Unknown
		//IL_09bf: Expected I, but got Obj
		//IL_09f0: Expected I, but got Obj
		//IL_0a21: Expected I, but got Obj
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Expected Obj, but got Unknown
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa3: Expected VT, but got Unknown
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Expected VT, but got Unknown
		//IL_0aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abf: Expected VT, but got Unknown
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acd: Expected VT, but got Unknown
		//IL_0add: Expected native int or pointer, but got VT
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af0: Expected Obj, but got Unknown
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afe: Expected Obj, but got Unknown
		//IL_0b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1b: Expected Obj, but got Unknown
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Expected Obj, but got Unknown
		//IL_0b46: Expected I, but got Obj
		//IL_0b77: Expected I, but got Obj
		//IL_0ba8: Expected I, but got Obj
		//IL_0bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc6: Expected Obj, but got Unknown
		//IL_0c25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Expected VT, but got Unknown
		//IL_0c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c38: Expected VT, but got Unknown
		//IL_0c41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c46: Expected VT, but got Unknown
		//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c54: Expected VT, but got Unknown
		//IL_0c64: Expected native int or pointer, but got VT
		//IL_0c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c77: Expected Obj, but got Unknown
		//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c85: Expected Obj, but got Unknown
		//IL_0c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca2: Expected Obj, but got Unknown
		//IL_0cab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb0: Expected Obj, but got Unknown
		//IL_0ccd: Expected I, but got Obj
		//IL_0cfe: Expected I, but got Obj
		//IL_0d2f: Expected I, but got Obj
		//IL_0d48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4d: Expected Obj, but got Unknown
		//IL_0dac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db1: Expected VT, but got Unknown
		//IL_0dba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbf: Expected VT, but got Unknown
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcd: Expected VT, but got Unknown
		//IL_0dd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddb: Expected VT, but got Unknown
		//IL_0deb: Expected native int or pointer, but got VT
		//IL_0df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfe: Expected Obj, but got Unknown
		//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0c: Expected Obj, but got Unknown
		//IL_0e24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e29: Expected Obj, but got Unknown
		//IL_0e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e37: Expected Obj, but got Unknown
		//IL_0e54: Expected I, but got Obj
		//IL_0e85: Expected I, but got Obj
		//IL_0eb6: Expected I, but got Obj
		//IL_0ecf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed4: Expected Obj, but got Unknown
		//IL_0f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f38: Expected VT, but got Unknown
		//IL_0f41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f46: Expected VT, but got Unknown
		//IL_0f4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f54: Expected VT, but got Unknown
		//IL_0f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f62: Expected VT, but got Unknown
		//IL_0f72: Expected native int or pointer, but got VT
		//IL_0f80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f85: Expected Obj, but got Unknown
		//IL_0f8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f93: Expected Obj, but got Unknown
		//IL_0fab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb0: Expected Obj, but got Unknown
		//IL_0fb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbe: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 1184;
		_ = 0;
		object obj3 = obj + 1136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
		_ = prize.trophyType;
		_ = prize.characterType;
		_ = prize.rewardType;
		_ = prize.amount;
		WeeklyHuntManager.PrizeData prizeData = (WeeklyHuntManager.PrizeData)(obj + 776);
		WeeklyHuntManager.WeeklyHuntPrize weeklyHuntPrize = WeeklyHuntManager.DeterminePrize(prizeData);
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<WeeklyHuntManager+WeeklyHuntPrize, System.Nullable`1<PrizePositionData+TransformValues>>>)+54]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v65 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj6 = default;
		object obj5 = obj6 ^ -1;
		object obj7 = obj5 >> 31;
		if (obj7 != null)
		{
			object obj8 = obj + 1096;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB3C");
			object obj9 = obj + 1096;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
		}
		else
		{
			object obj10 = obj + 1136;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			object obj11 = weeklyHuntPrize - 1;
			if (weeklyHuntPrize != WeeklyHuntManager.WeeklyHuntPrize.Key)
			{
				if ((nint)obj11 != 1)
				{
					if ((nint)obj11 != 2)
					{
						if ((nint)obj11 != 3)
						{
							if ((nint)obj11 != 4)
							{
								if ((nint)obj11 != 5)
								{
									if ((nint)obj11 != 6)
									{
										if ((nint)obj11 != 7)
										{
											if ((nint)obj11 == 8)
											{
												nint num3 = (nint)typeof(PrizePositionData);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ S1_v333 (Il2CppClass<PrizePositionData>)+5C]");
												nint num4 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ S1_v334 (Il2CppStaticFields<PrizePositionData>)+170]");
												_ = 0;
												_ = CHERRY2017_BOARD_POSITION;
												nint num5 = (nint)typeof(PrizePositionData);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ S1_v339 (Il2CppClass<PrizePositionData>)+5C]");
												nint num6 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ S1_v340 (Il2CppStaticFields<PrizePositionData>)+17C]");
												_ = 0;
												_ = CHERRY2017_BOARD_ROTATION;
												nint num7 = (nint)typeof(PrizePositionData);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ S0_v303 (Il2CppClass<PrizePositionData>)+5C]");
												nint num8 = 0;
												object obj12 = obj + 1096;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+340]");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+330]");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+328]");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+338]");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ S0_v304 (Il2CppStaticFields<PrizePositionData>)+188]");
												_ = 0;
												_ = CHERRY2017_BOARD_SCALE;
												TransformValues transformValues = (TransformValues)(obj + 1096);
												Vector3 positionOffset = (Vector3)(obj + 760);
												Vector3 rotation = (Vector3)(obj + 744);
												Vector3 scale = (Vector3)(obj + 728);
												*(TransformValues*)(nint)transformValues = new TransformValues(positionOffset, rotation, scale);
												object obj13 = obj + 692;
												object obj14 = obj + 1096;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
												object obj15 = obj + 1136;
												object obj16 = obj + 692;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1070");
											}
										}
										else
										{
											nint num9 = (nint)typeof(PrizePositionData);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ S1_v298 (Il2CppClass<PrizePositionData>)+5C]");
											nint num10 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ S1_v299 (Il2CppStaticFields<PrizePositionData>)+194]");
											_ = 0;
											_ = NORTHPOLE2016_HUNT_BOARD_POSITION;
											nint num11 = (nint)typeof(PrizePositionData);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ S1_v304 (Il2CppClass<PrizePositionData>)+5C]");
											nint num12 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ S1_v305 (Il2CppStaticFields<PrizePositionData>)+1AC]");
											_ = 0;
											_ = NORTHPOLE2016_HUNT_BOARD_ROTATION;
											nint num13 = (nint)typeof(PrizePositionData);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ S0_v276 (Il2CppClass<PrizePositionData>)+5C]");
											nint num14 = 0;
											object obj17 = obj + 1096;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+360]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+350]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+348]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ S0_v277 (Il2CppStaticFields<PrizePositionData>)+1A0]");
											_ = 0;
											_ = NORTHPOLE2016_HUNT_BOARD_SCALE;
											TransformValues transformValues2 = (TransformValues)(obj + 1096);
											Vector3 positionOffset2 = (Vector3)(obj + 680);
											Vector3 rotation2 = (Vector3)(obj + 664);
											Vector3 scale2 = (Vector3)(obj + 648);
											*(TransformValues*)(nint)transformValues2 = new TransformValues(positionOffset2, rotation2, scale2);
											object obj18 = obj + 612;
											object obj19 = obj + 1096;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
											object obj20 = obj + 1136;
											object obj21 = obj + 612;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1070");
										}
									}
									else
									{
										nint num15 = (nint)typeof(PrizePositionData);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ S1_v263 (Il2CppClass<PrizePositionData>)+5C]");
										nint num16 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ S1_v264 (Il2CppStaticFields<PrizePositionData>)+14C]");
										_ = 0;
										_ = RIO_HUNT_BOARD_POSITION;
										nint num17 = (nint)typeof(PrizePositionData);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ S1_v269 (Il2CppClass<PrizePositionData>)+5C]");
										nint num18 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ S1_v270 (Il2CppStaticFields<PrizePositionData>)+164]");
										_ = 0;
										_ = RIO_HUNT_BOARD_ROTATION;
										nint num19 = (nint)typeof(PrizePositionData);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ S0_v249 (Il2CppClass<PrizePositionData>)+5C]");
										nint num20 = 0;
										object obj22 = obj + 1096;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+380]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+370]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+368]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+378]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ S0_v250 (Il2CppStaticFields<PrizePositionData>)+158]");
										_ = 0;
										_ = RIO_HUNT_BOARD_SCALE;
										TransformValues transformValues3 = (TransformValues)(obj + 1096);
										Vector3 positionOffset3 = (Vector3)(obj + 600);
										Vector3 rotation3 = (Vector3)(obj + 584);
										Vector3 scale3 = (Vector3)(obj + 568);
										*(TransformValues*)(nint)transformValues3 = new TransformValues(positionOffset3, rotation3, scale3);
										object obj23 = obj + 532;
										object obj24 = obj + 1096;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
										object obj25 = obj + 1136;
										object obj26 = obj + 532;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1070");
									}
								}
								else
								{
									nint num21 = (nint)typeof(PrizePositionData);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S1_v228 (Il2CppClass<PrizePositionData>)+5C]");
									nint num22 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ S1_v229 (Il2CppStaticFields<PrizePositionData>)+128]");
									_ = 0;
									_ = CHRISTMAS2014_BOARD_POSITION;
									nint num23 = (nint)typeof(PrizePositionData);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S1_v234 (Il2CppClass<PrizePositionData>)+5C]");
									nint num24 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S1_v235 (Il2CppStaticFields<PrizePositionData>)+140]");
									_ = 0;
									_ = CHRISTMAS2014_BOARD_ROTATION;
									nint num25 = (nint)typeof(PrizePositionData);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ S0_v222 (Il2CppClass<PrizePositionData>)+5C]");
									nint num26 = 0;
									object obj27 = obj + 1096;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3A0]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+390]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+388]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+398]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S0_v223 (Il2CppStaticFields<PrizePositionData>)+134]");
									_ = 0;
									_ = CHRISTMAS2014_BOARD_SCALE;
									TransformValues transformValues4 = (TransformValues)(obj + 1096);
									Vector3 positionOffset4 = (Vector3)(obj + 520);
									Vector3 rotation4 = (Vector3)(obj + 504);
									Vector3 scale4 = (Vector3)(obj + 488);
									*(TransformValues*)(nint)transformValues4 = new TransformValues(positionOffset4, rotation4, scale4);
									object obj28 = obj + 452;
									object obj29 = obj + 1096;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
									object obj30 = obj + 1136;
									object obj31 = obj + 452;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1070");
								}
							}
							else
							{
								nint num27 = (nint)typeof(PrizePositionData);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ S1_v193 (Il2CppClass<PrizePositionData>)+5C]");
								nint num28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ S1_v194 (Il2CppStaticFields<PrizePositionData>)+74]");
								_ = 0;
								_ = HEADSTART_POSITION;
								nint num29 = (nint)typeof(PrizePositionData);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S1_v199 (Il2CppClass<PrizePositionData>)+5C]");
								nint num30 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ S1_v200 (Il2CppStaticFields<PrizePositionData>)+8C]");
								_ = 0;
								_ = HEADSTART_ROTATION;
								nint num31 = (nint)typeof(PrizePositionData);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S0_v195 (Il2CppClass<PrizePositionData>)+5C]");
								nint num32 = 0;
								object obj32 = obj + 1096;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C0]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3B0]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3A8]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3B8]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S0_v196 (Il2CppStaticFields<PrizePositionData>)+80]");
								_ = 0;
								_ = HEADSTART_SCALE;
								TransformValues transformValues5 = (TransformValues)(obj + 1096);
								Vector3 positionOffset5 = (Vector3)(obj + 440);
								Vector3 rotation5 = (Vector3)(obj + 424);
								Vector3 scale5 = (Vector3)(obj + 408);
								*(TransformValues*)(nint)transformValues5 = new TransformValues(positionOffset5, rotation5, scale5);
								object obj33 = obj + 372;
								object obj34 = obj + 1096;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
								object obj35 = obj + 1136;
								object obj36 = obj + 372;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1070");
							}
						}
						else
						{
							nint num33 = (nint)typeof(PrizePositionData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S1_v158 (Il2CppClass<PrizePositionData>)+5C]");
							nint num34 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S1_v159 (Il2CppStaticFields<PrizePositionData>)+50]");
							_ = 0;
							_ = SCORE_BOOSTER_POSITION;
							nint num35 = (nint)typeof(PrizePositionData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S1_v164 (Il2CppClass<PrizePositionData>)+5C]");
							nint num36 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S1_v165 (Il2CppStaticFields<PrizePositionData>)+68]");
							_ = 0;
							_ = SCORE_BOOSTER_ROTATION;
							nint num37 = (nint)typeof(PrizePositionData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S0_v168 (Il2CppClass<PrizePositionData>)+5C]");
							nint num38 = 0;
							object obj37 = obj + 1096;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3E0]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3D0]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3D8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ S0_v169 (Il2CppStaticFields<PrizePositionData>)+5C]");
							_ = 0;
							_ = SCORE_BOOSTER_SCALE;
							TransformValues transformValues6 = (TransformValues)(obj + 1096);
							Vector3 positionOffset6 = (Vector3)(obj + 360);
							Vector3 rotation6 = (Vector3)(obj + 344);
							Vector3 scale6 = (Vector3)(obj + 328);
							*(TransformValues*)(nint)transformValues6 = new TransformValues(positionOffset6, rotation6, scale6);
							object obj38 = obj + 292;
							object obj39 = obj + 1096;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
							object obj40 = obj + 1136;
							object obj41 = obj + 292;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1070");
						}
					}
					else
					{
						object obj42 = obj + 1024;
						nint num39 = (nint)typeof(PrizePositionData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S1_v123 (Il2CppClass<PrizePositionData>)+5C]");
						nint num40 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S1_v124 (Il2CppStaticFields<PrizePositionData>)+8]");
						obj42 = 0;
						_ = HOVERBOARD_POSITION;
						nint num41 = (nint)typeof(PrizePositionData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S1_v129 (Il2CppClass<PrizePositionData>)+5C]");
						nint num42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S1_v130 (Il2CppStaticFields<PrizePositionData>)+20]");
						_ = 0;
						_ = HOVERBOARD_ROTATION;
						nint num43 = (nint)typeof(PrizePositionData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v141 (Il2CppClass<PrizePositionData>)+5C]");
						nint num44 = 0;
						object obj43 = obj + 1096;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3F0]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3E8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3F8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v142 (Il2CppStaticFields<PrizePositionData>)+14]");
						_ = 0;
						_ = HOVERBOARD_SCALE;
						TransformValues transformValues7 = (TransformValues)(obj + 1096);
						Vector3 positionOffset7 = (Vector3)(obj + 280);
						Vector3 rotation7 = (Vector3)(obj + 264);
						Vector3 scale7 = (Vector3)(obj + 248);
						*(TransformValues*)(nint)transformValues7 = new TransformValues(positionOffset7, rotation7, scale7);
						object obj44 = obj + 212;
						object obj45 = obj + 1096;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
						object obj46 = obj + 1136;
						object obj47 = obj + 212;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1070");
					}
				}
				else
				{
					object obj48 = obj + 1056;
					nint num45 = (nint)typeof(PrizePositionData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v86 (Il2CppClass<PrizePositionData>)+5C]");
					nint num46 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S1_v87 (Il2CppStaticFields<PrizePositionData>)+BC]");
					obj48 = 0;
					_ = SUPER_MYSTERY_BOX_POSITION;
					object obj49 = obj + 1040;
					nint num47 = (nint)typeof(PrizePositionData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S1_v93 (Il2CppClass<PrizePositionData>)+5C]");
					nint num48 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S1_v94 (Il2CppStaticFields<PrizePositionData>)+D4]");
					obj49 = 0;
					_ = SUPER_MYSTERY_BOX_ROTATION;
					nint num49 = (nint)typeof(PrizePositionData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v113 (Il2CppClass<PrizePositionData>)+5C]");
					nint num50 = 0;
					object obj50 = obj + 1096;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+408]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+418]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v114 (Il2CppStaticFields<PrizePositionData>)+C8]");
					_ = 0;
					_ = SUPER_MYSTERY_BOX_SCALE;
					TransformValues transformValues8 = (TransformValues)(obj + 1096);
					Vector3 positionOffset8 = (Vector3)(obj + 200);
					Vector3 rotation8 = (Vector3)(obj + 184);
					Vector3 scale8 = (Vector3)(obj + 168);
					*(TransformValues*)(nint)transformValues8 = new TransformValues(positionOffset8, rotation8, scale8);
					object obj51 = obj + 132;
					object obj52 = obj + 1096;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
					object obj53 = obj + 1136;
					object obj54 = obj + 132;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1070");
				}
			}
			else
			{
				object obj55 = obj + 1088;
				nint num51 = (nint)typeof(PrizePositionData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v49 (Il2CppClass<PrizePositionData>)+5C]");
				nint num52 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v50 (Il2CppStaticFields<PrizePositionData>)+2C]");
				obj55 = 0;
				_ = KEY_POSITION;
				object obj56 = obj + 1072;
				nint num53 = (nint)typeof(PrizePositionData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v56 (Il2CppClass<PrizePositionData>)+5C]");
				nint num54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v57 (Il2CppStaticFields<PrizePositionData>)+44]");
				obj56 = 0;
				_ = KEY_ROTATION;
				nint num55 = (nint)typeof(PrizePositionData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v84 (Il2CppClass<PrizePositionData>)+5C]");
				nint num56 = 0;
				object obj57 = obj + 1096;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+428]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+438]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v85 (Il2CppStaticFields<PrizePositionData>)+38]");
				_ = 0;
				_ = KEY_SCALE;
				TransformValues transformValues9 = (TransformValues)(obj + 1096);
				Vector3 positionOffset9 = (Vector3)(obj + 120);
				Vector3 rotation9 = (Vector3)(obj + 104);
				Vector3 scale9 = (Vector3)(obj + 88);
				*(TransformValues*)(nint)transformValues9 = new TransformValues(positionOffset9, rotation9, scale9);
				object obj58 = obj + 52;
				object obj59 = obj + 1096;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
				object obj60 = obj + 1136;
				object obj61 = obj + 52;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1070");
			}
			object obj62 = obj + 1136;
			if (obj62 != null)
			{
				object obj63 = obj + 12;
				object obj64 = obj + 1136;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
				object obj65 = obj - 48;
				object obj66 = obj65 + 8;
				object obj67 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
				TransformValues? value = (TransformValues?)(object)(obj65 + 8);
				Dictionary<WeeklyHuntManager.WeeklyHuntPrize, TransformValues?> cachedPositionData = _cachedPositionData;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+49C]");
				cachedPositionData.Add(WeeklyHuntManager.WeeklyHuntPrize.NotAvailable, value);
			}
			else
			{
				Enum obj68 = (Enum)(obj + 1096);
				_ = -1;
				obj68 = (Enum)(object)typeof(WeeklyHuntManager.WeeklyHuntPrize);
				object obj69 = obj + 1180;
				string text = obj68.ToString();
				string text2 = "Unable to find prize position data for type: " + text;
			}
			object obj70 = obj + 1136;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
		}
		TransformValues? result = default;
		return result;
	}

	static PrizePositionData()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0033: Expected VT, but got I4
		//IL_0041: Expected I, but got Obj
		//IL_0065: Expected VT, but got I8
		//IL_0073: Expected I, but got Obj
		//IL_0097: Expected VT, but got I8
		//IL_00a5: Expected I, but got Obj
		//IL_00c9: Expected VT, but got I8
		//IL_00d7: Expected I, but got Obj
		//IL_00fb: Expected VT, but got I8
		//IL_0109: Expected I, but got Obj
		//IL_012d: Expected VT, but got I8
		//IL_013b: Expected I, but got Obj
		//IL_015b: Expected VT, but got I4
		//IL_0169: Expected I, but got Obj
		//IL_018d: Expected VT, but got I8
		//IL_019b: Expected I, but got Obj
		//IL_01bf: Expected VT, but got I8
		//IL_01cd: Expected I, but got Obj
		//IL_01ed: Expected VT, but got I4
		//IL_01fb: Expected I, but got Obj
		//IL_021f: Expected VT, but got I8
		//IL_022d: Expected I, but got Obj
		//IL_0251: Expected VT, but got I8
		//IL_025f: Expected I, but got Obj
		//IL_027f: Expected VT, but got I4
		//IL_028d: Expected I, but got Obj
		//IL_02ad: Expected VT, but got I4
		//IL_02bb: Expected I, but got Obj
		//IL_02db: Expected VT, but got I4
		//IL_02e9: Expected I, but got Obj
		//IL_030d: Expected VT, but got I8
		//IL_031b: Expected I, but got Obj
		//IL_033f: Expected VT, but got I8
		//IL_034d: Expected I, but got Obj
		//IL_0371: Expected VT, but got I8
		//IL_037f: Expected I, but got Obj
		//IL_039f: Expected VT, but got I4
		//IL_03ad: Expected I, but got Obj
		//IL_03d1: Expected VT, but got I8
		//IL_03df: Expected I, but got Obj
		//IL_0403: Expected VT, but got I8
		//IL_0411: Expected I, but got Obj
		//IL_0435: Expected VT, but got I8
		//IL_0443: Expected I, but got Obj
		//IL_0467: Expected VT, but got I8
		//IL_0475: Expected I, but got Obj
		//IL_0499: Expected VT, but got I8
		//IL_04a7: Expected I, but got Obj
		//IL_04cb: Expected VT, but got I8
		//IL_04d9: Expected I, but got Obj
		//IL_04fd: Expected VT, but got I8
		//IL_050b: Expected I, but got Obj
		//IL_052f: Expected VT, but got I8
		//IL_053d: Expected I, but got Obj
		//IL_0561: Expected VT, but got I8
		//IL_056f: Expected I, but got Obj
		//IL_0593: Expected VT, but got I8
		//IL_05a1: Expected I, but got Obj
		//IL_05c5: Expected VT, but got I8
		//IL_05d3: Expected I, but got Obj
		//IL_05f7: Expected VT, but got I8
		//IL_0605: Expected I, but got Obj
		//IL_0629: Expected VT, but got I8
		//IL_0637: Expected I, but got Obj
		//IL_065b: Expected VT, but got I8
		//IL_0669: Expected I, but got Obj
		//IL_068d: Expected VT, but got I8
		//IL_069b: Expected I, but got Obj
		//IL_06bf: Expected VT, but got I8
		//IL_06cd: Expected I, but got Obj
		//IL_06f1: Expected VT, but got I8
		//IL_06ff: Expected I, but got Obj
		//IL_071f: Expected VT, but got I4
		//IL_072d: Expected I, but got Obj
		//IL_0751: Expected VT, but got I8
		//IL_075f: Expected I, but got Obj
		//IL_0783: Expected VT, but got I8
		nint num = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<PrizePositionData>)+5C]");
		nint num2 = 0;
		_ = 0;
		HOVERBOARD_POSITION = (Vector3)0;
		nint num3 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<PrizePositionData>)+5C]");
		nint num4 = 0;
		_ = 1093664768;
		HOVERBOARD_SCALE = (Vector3)4697254412441092096L;
		nint num5 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v14 (Il2CppClass<PrizePositionData>)+5C]");
		nint num6 = 0;
		_ = 1115973222;
		HOVERBOARD_ROTATION = (Vector3)4872092592547833446L;
		nint num7 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v18 (Il2CppClass<PrizePositionData>)+5C]");
		nint num8 = 0;
		_ = 0;
		KEY_POSITION = (Vector3)4611686018427387904L;
		nint num9 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v22 (Il2CppClass<PrizePositionData>)+5C]");
		nint num10 = 0;
		_ = 1092616192;
		KEY_SCALE = (Vector3)4692750812812673024L;
		nint num11 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v26 (Il2CppClass<PrizePositionData>)+5C]");
		nint num12 = 0;
		_ = 1085276160;
		KEY_ROTATION = (Vector3)4715268810950574080L;
		nint num13 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v30 (Il2CppClass<PrizePositionData>)+5C]");
		nint num14 = 0;
		_ = 0;
		SCORE_BOOSTER_POSITION = (Vector3)1073741824;
		nint num15 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v34 (Il2CppClass<PrizePositionData>)+5C]");
		nint num16 = 0;
		_ = 1095761920;
		SCORE_BOOSTER_SCALE = (Vector3)4706261611697930240L;
		nint num17 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v38 (Il2CppClass<PrizePositionData>)+5C]");
		nint num18 = 0;
		_ = 1134782054;
		SCORE_BOOSTER_ROTATION = (Vector3)4733283209463201792L;
		nint num19 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v42 (Il2CppClass<PrizePositionData>)+5C]");
		nint num20 = 0;
		_ = 0;
		HEADSTART_POSITION = (Vector3)0;
		nint num21 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v46 (Il2CppClass<PrizePositionData>)+5C]");
		nint num22 = 0;
		_ = 1096810496;
		HEADSTART_SCALE = (Vector3)4710765211326349312L;
		nint num23 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v50 (Il2CppClass<PrizePositionData>)+5C]");
		nint num24 = 0;
		_ = 1134526464;
		HEADSTART_ROTATION = (Vector3)4737786809089523712L;
		nint num25 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v54 (Il2CppClass<PrizePositionData>)+5C]");
		nint num26 = 0;
		_ = 0;
		MYSTERY_BOX_POSITION = (Vector3)0;
		nint num27 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v58 (Il2CppClass<PrizePositionData>)+5C]");
		nint num28 = 0;
		_ = 0;
		MYSTERY_BOX_SCALE = (Vector3)0;
		nint num29 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v62 (Il2CppClass<PrizePositionData>)+5C]");
		nint num30 = 0;
		_ = 0;
		MYSTERY_BOX_ROTATION = (Vector3)0;
		nint num31 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v66 (Il2CppClass<PrizePositionData>)+5C]");
		nint num32 = 0;
		_ = 0;
		SUPER_MYSTERY_BOX_POSITION = (Vector3)3222483763L;
		nint num33 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v70 (Il2CppClass<PrizePositionData>)+5C]");
		nint num34 = 0;
		_ = 1088421888;
		SUPER_MYSTERY_BOX_SCALE = (Vector3)4674736414298996736L;
		nint num35 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v74 (Il2CppClass<PrizePositionData>)+5C]");
		nint num36 = 0;
		_ = 1135378432;
		SUPER_MYSTERY_BOX_ROTATION = (Vector3)4776067405961723904L;
		nint num37 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v78 (Il2CppClass<PrizePositionData>)+5C]");
		nint num38 = 0;
		_ = 0;
		DRAGON_BOARD_POSITION = (Vector3)1082130432;
		nint num39 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v82 (Il2CppClass<PrizePositionData>)+5C]");
		nint num40 = 0;
		_ = 1094713344;
		DRAGON_BOARD_SCALE = (Vector3)4701758012069511168L;
		nint num41 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v86 (Il2CppClass<PrizePositionData>)+5C]");
		nint num42 = 0;
		_ = 1116059730;
		DRAGON_BOARD_ROTATION = (Vector3)4870666925398710682L;
		nint num43 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v90 (Il2CppClass<PrizePositionData>)+5C]");
		nint num44 = 0;
		_ = 0;
		SLEIGH_BOARD_POSITION = (Vector3)4656722015789514752L;
		nint num45 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v94 (Il2CppClass<PrizePositionData>)+5C]");
		nint num46 = 0;
		_ = 1096810496;
		SLEIGH_BOARD_SCALE = (Vector3)4710765211326349312L;
		nint num47 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v98 (Il2CppClass<PrizePositionData>)+5C]");
		nint num48 = 0;
		_ = 1087583027;
		SLEIGH_BOARD_ROTATION = (Vector3)4871994078793616589L;
		nint num49 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v102 (Il2CppClass<PrizePositionData>)+5C]");
		nint num50 = 0;
		_ = 0;
		CHRISTMAS2014_BOARD_POSITION = (Vector3)4656722015789514752L;
		nint num51 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v106 (Il2CppClass<PrizePositionData>)+5C]");
		nint num52 = 0;
		_ = 1096810496;
		CHRISTMAS2014_BOARD_SCALE = (Vector3)4710765211326349312L;
		nint num53 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v110 (Il2CppClass<PrizePositionData>)+5C]");
		nint num54 = 0;
		_ = 1087583027;
		CHRISTMAS2014_BOARD_ROTATION = (Vector3)4871994078793616589L;
		nint num55 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v114 (Il2CppClass<PrizePositionData>)+5C]");
		nint num56 = 0;
		_ = 0;
		RIO_HUNT_BOARD_POSITION = (Vector3)4701758012048539648L;
		nint num57 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v118 (Il2CppClass<PrizePositionData>)+5C]");
		nint num58 = 0;
		_ = 1096810496;
		RIO_HUNT_BOARD_SCALE = (Vector3)4710765211326349312L;
		nint num59 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v122 (Il2CppClass<PrizePositionData>)+5C]");
		nint num60 = 0;
		_ = -1034682368;
		RIO_HUNT_BOARD_ROTATION = (Vector3)4829547651500867584L;
		nint num61 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v126 (Il2CppClass<PrizePositionData>)+5C]");
		nint num62 = 0;
		_ = 0;
		CHERRY2017_BOARD_POSITION = (Vector3)4611686019492741120L;
		nint num63 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v130 (Il2CppClass<PrizePositionData>)+5C]");
		nint num64 = 0;
		_ = 1113325568;
		CHERRY2017_BOARD_ROTATION = (Vector3)4872191112614248448L;
		nint num65 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v134 (Il2CppClass<PrizePositionData>)+5C]");
		nint num66 = 0;
		_ = 1093664768;
		CHERRY2017_BOARD_SCALE = (Vector3)4697254412441092096L;
		nint num67 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v138 (Il2CppClass<PrizePositionData>)+5C]");
		nint num68 = 0;
		_ = 0;
		NORTHPOLE2016_HUNT_BOARD_POSITION = (Vector3)4656722015774834688L;
		nint num69 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v142 (Il2CppClass<PrizePositionData>)+5C]");
		nint num70 = 0;
		_ = 1096810496;
		NORTHPOLE2016_HUNT_BOARD_SCALE = (Vector3)4710765211326349312L;
		nint num71 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v146 (Il2CppClass<PrizePositionData>)+5C]");
		nint num72 = 0;
		_ = 1108344832;
		NORTHPOLE2016_HUNT_BOARD_ROTATION = (Vector3)4870080050294161408L;
		nint num73 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v150 (Il2CppClass<PrizePositionData>)+5C]");
		nint num74 = 0;
		_ = 0;
		PRESENT_POSITION_OFFSET = (Vector3)0;
		nint num75 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v154 (Il2CppClass<PrizePositionData>)+5C]");
		nint num76 = 0;
		_ = 1101529088;
		PRESENT_ROTATION = (Vector3)(-4392698485444968448L);
		nint num77 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v158 (Il2CppClass<PrizePositionData>)+5C]");
		nint num78 = 0;
		_ = 1137180672;
		PRESENT_SCALE = (Vector3)4884153797020483584L;
		nint num79 = 0;
		nint num80 = 0;
		IntPtr intPtr = num80;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v299 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<WeeklyHuntManager+WeeklyHuntPrize, System.Nullable`1<PrizePositionData+TransformValues>>>>)+4] (should have been resolved before IL gen)");
		Dictionary<WeeklyHuntManager.WeeklyHuntPrize, TransformValues?> cachedPositionData = default;
		_cachedPositionData = cachedPositionData;
	}
}
