namespace SYBO.Subway.Utilities;

public class DebugSettings
{
	public bool _active; //Field offset: 0xF
	private bool _unlockedSceneCamera; //Field offset: 0x10
	private bool _characterInvincible; //Field offset: 0x11
	private bool _dontUseAssetBundlesInEditor; //Field offset: 0x12
	private bool _useManifestsForAssetBundlesInEditor; //Field offset: 0x13
	private bool _dontUseIdles; //Field offset: 0x14
	private bool _forceHighResCharacterTextures; //Field offset: 0x15
	private bool _editorDevicePerformanceLevelOverride; //Field offset: 0x16
	private PerformanceLevel _editorDevicePerformanceLevel; //Field offset: 0x18
	private bool _useDebugZDistanceTargetPosition; //Field offset: 0x1C
	private bool _useQueuedEnvironmentKinds; //Field offset: 0x1D
	private EnvironmentKind[] _queuedEnvironmentKinds; //Field offset: 0x20

	public static bool CharacterInvincible
	{
		 get { } //Length: 59
		 set { } //Length: 44
	}

	public static bool DontUseBaseBundleInEditor
	{
		 get { } //Length: 59
		 set { } //Length: 61
	}

	public static bool DontUseIdles
	{
		 get { } //Length: 59
		 set { } //Length: 61
	}

	public static PerformanceLevel EditorDevicePerformanceLevel
	{
		 get { } //Length: 59
	}

	public static bool ForceHighResCharacterTextures
	{
		 get { } //Length: 59
	}

	public static bool IsAllowed
	{
		 get { } //Length: 56
	}

	public static bool OverrideEditorDevicePerformanceLevel
	{
		 get { } //Length: 59
	}

	public static EnvironmentKind[] QueuedEnvironmentKinds
	{
		 get { } //Length: 59
		 set { } //Length: 61
	}

	public static bool UnlockedSceneCamera
	{
		 get { } //Length: 92
	}

	public static bool UseDebugZDistanceTargetPosition
	{
		 get { } //Length: 56
		 set { } //Length: 61
	}

	public static bool UseManifestsForAssetBundlesInEditor
	{
		 get { } //Length: 59
	}

	public static bool UseQueuedEnvironmentKinds
	{
		 get { } //Length: 59
		 set { } //Length: 61
	}

	public DebugSettings() { }

	private static void CheckIsAllowed() { }

	public static bool get_CharacterInvincible() { }

	public static bool get_DontUseBaseBundleInEditor() { }

	public static bool get_DontUseIdles() { }

	public static PerformanceLevel get_EditorDevicePerformanceLevel() { }

	public static bool get_ForceHighResCharacterTextures() { }

	public static bool get_IsAllowed() { }

	public static bool get_OverrideEditorDevicePerformanceLevel() { }

	public static EnvironmentKind[] get_QueuedEnvironmentKinds() { }

	public static bool get_UnlockedSceneCamera() { }

	public static bool get_UseDebugZDistanceTargetPosition() { }

	public static bool get_UseManifestsForAssetBundlesInEditor() { }

	public static bool get_UseQueuedEnvironmentKinds() { }

	public static void set_CharacterInvincible(bool value) { }

	public static void set_DontUseBaseBundleInEditor(bool value) { }

	public static void set_DontUseIdles(bool value) { }

	public static void set_QueuedEnvironmentKinds(EnvironmentKind[] value) { }

	public static void set_UseDebugZDistanceTargetPosition(bool value) { }

	public static void set_UseQueuedEnvironmentKinds(bool value) { }

	protected override void SubclassInitialize() { }

	private void ValidateEnvironmentKinds() { }

}

