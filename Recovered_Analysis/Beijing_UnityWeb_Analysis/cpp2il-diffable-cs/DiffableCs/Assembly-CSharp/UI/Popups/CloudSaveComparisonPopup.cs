namespace UI.Popups;

public class CloudSaveComparisonPopup : UIScreen
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CloudSaveComparisonRow, bool> <>9__9_0; //Field offset: 0x4
		public static Action <>9__9_3; //Field offset: 0x8
		public static Action <>9__9_7; //Field offset: 0xC
		public static Action <>9__9_6; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <SetupConflict>b__9_0(CloudSaveComparisonRow r) { }

		internal void <SetupConflict>b__9_3() { }

		internal void <SetupConflict>b__9_6() { }

		internal void <SetupConflict>b__9_7() { }

	}

	private sealed class <>c__DisplayClass9_0
	{
		public CloudSaveConflictResolver resolver; //Field offset: 0x8
		public string source; //Field offset: 0xC
		public Action <>9__2; //Field offset: 0x10
		public Action <>9__5; //Field offset: 0x14

		public <>c__DisplayClass9_0() { }

		internal void <SetupConflict>b__1() { }

		internal void <SetupConflict>b__2() { }

		internal void <SetupConflict>b__4() { }

		internal void <SetupConflict>b__5() { }

	}

	private const float SLIDEIN_DELAY = 0.5; //Field offset: 0x0
	private UILabel _headline; //Field offset: 0x28
	private UILabel _subline; //Field offset: 0x2C
	private UILabel _subtext; //Field offset: 0x30
	private CloudSaveConflictBlock _conflictPrefab; //Field offset: 0x34
	private Layout _conflictLayout; //Field offset: 0x38

	public CloudSaveComparisonPopup() { }

	public override void Init() { }

	public void MoreInformationClicked() { }

	private void SetupBasic() { }

	private void SetupConflict() { }

	public override void Show() { }

}

