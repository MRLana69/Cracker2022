//Type is in global namespace

public static class PrizePositionData
{
	public struct TransformValues
	{
		public Vector3 PositionOffset; //Field offset: 0x0
		public Vector3 RotationOffset; //Field offset: 0xC
		public Vector3 ScaleOffset; //Field offset: 0x18

		public TransformValues(Vector3 positionOffset, Vector3 rotation, Vector3 scale) { }

	}

	public static Vector3 HOVERBOARD_POSITION_OFFSET; //Field offset: 0x0
	public static Vector3 HOVERBOARD_SCALE_OFFSET; //Field offset: 0xC
	public static Vector3 HOVERBOARD_ROTATION_OFFSET; //Field offset: 0x18
	public static Vector3 KEY_POSITION_OFFSET; //Field offset: 0x24
	public static Vector3 KEY_SCALE_OFFSET; //Field offset: 0x30
	public static Vector3 KEY_ROTATION_OFFSET; //Field offset: 0x3C
	public static Vector3 SCORE_BOOSTER_POSITION_OFFSET; //Field offset: 0x48
	public static Vector3 SCORE_BOOSTER_SCALE_OFFSET; //Field offset: 0x54
	public static Vector3 SCORE_BOOSTER_ROTATION_OFFSET; //Field offset: 0x60
	public static Vector3 HEADSTART_POSITION_OFFSET; //Field offset: 0x6C
	public static Vector3 HEADSTART_SCALE_OFFSET; //Field offset: 0x78
	public static Vector3 HEADSTART_ROTATION_OFFSET; //Field offset: 0x84
	public static Vector3 MYSTERY_BOX_POSITION; //Field offset: 0x90
	public static Vector3 MYSTERY_BOX_SCALE; //Field offset: 0x9C
	public static Vector3 MYSTERY_BOX_ROTATION; //Field offset: 0xA8
	public static Vector3 SUPER_MYSTERY_BOX_POSITION_OFFSET; //Field offset: 0xB4
	public static Vector3 SUPER_MYSTERY_BOX_SCALE_OFFSET; //Field offset: 0xC0
	public static Vector3 SUPER_MYSTERY_BOX_ROTATION_OFFSET; //Field offset: 0xCC
	public static Vector3 UNKNOWN_REWARD_POSITION_OFFSET; //Field offset: 0xD8
	public static Vector3 UNKNOWN_REWARD_SCALE_OFFSET; //Field offset: 0xE4
	public static Vector3 UNKNOWN_REWARD_ROTATION_OFFSET; //Field offset: 0xF0
	public static Vector3 PRESENT_POSITION_OFFSET; //Field offset: 0xFC
	public static Vector3 PRESENT_SCALE_OFFSET; //Field offset: 0x108
	public static Vector3 PRESENT_ROTATION_OFFSET; //Field offset: 0x114
	public static Vector3 DRAGON_BOARD_POSITION; //Field offset: 0x120
	public static Vector3 DRAGON_BOARD_SCALE; //Field offset: 0x12C
	public static Vector3 DRAGON_BOARD_ROTATION; //Field offset: 0x138
	public static Vector3 SLEIGH_BOARD_POSITION; //Field offset: 0x144
	public static Vector3 SLEIGH_BOARD_SCALE; //Field offset: 0x150
	public static Vector3 SLEIGH_BOARD_ROTATION; //Field offset: 0x15C
	public static Vector3 CHRISTMAS2014_BOARD_POSITION; //Field offset: 0x168
	public static Vector3 CHRISTMAS2014_BOARD_SCALE; //Field offset: 0x174
	public static Vector3 CHRISTMAS2014_BOARD_ROTATION; //Field offset: 0x180
	public static Vector3 RIO_HUNT_BOARD_POSITION; //Field offset: 0x18C
	public static Vector3 RIO_HUNT_BOARD_SCALE; //Field offset: 0x198
	public static Vector3 RIO_HUNT_BOARD_ROTATION; //Field offset: 0x1A4
	public static Vector3 CHERRY2017_BOARD_POSITION; //Field offset: 0x1B0
	public static Vector3 CHERRY2017_BOARD_ROTATION; //Field offset: 0x1BC
	public static Vector3 CHERRY2017_BOARD_SCALE; //Field offset: 0x1C8
	public static Vector3 NORTHPOLE2016_HUNT_BOARD_POSITION; //Field offset: 0x1D4
	public static Vector3 NORTHPOLE2016_HUNT_BOARD_SCALE; //Field offset: 0x1E0
	public static Vector3 NORTHPOLE2016_HUNT_BOARD_ROTATION; //Field offset: 0x1EC
	private static Dictionary<WeeklyHuntPrize, Nullable<TransformValues>> _cachedPositionData; //Field offset: 0x1F8
	public static Vector3 rewardRotationOffsetFrom; //Field offset: 0x1FC
	public static Vector3 rewardRotationOffsetTo; //Field offset: 0x208
	public static float rewardRotationDuration; //Field offset: 0x214

	private static PrizePositionData() { }

	public static void FitAndApplyOffsets(Transform rewardTransform, Vector3 newPosition, Nullable<TransformValues> offsetValues, UIWidget targetWidget = null, bool isPresent = false) { }

	public static Nullable<TransformValues> GetPositioningDataForUnknownReward() { }

	public static Nullable<TransformValues> GetPrizePositioningData(PrizeData prize) { }

	public static void PositionModel(Nullable<TransformValues> positionData, Transform rewardTransform, UIWidget prizeGuideWidget = null, bool hidePrize = false) { }

}

