namespace SYBO.Subway.Routes;

public abstract class Route : MonoBehaviour
{
	public class CharacterEnteredEventArgs : EventArgs
	{
		public readonly Route FromRoute; //Field offset: 0x8

		public CharacterEnteredEventArgs(Route fromRoute) { }

	}

	public class CharacterEntrySkippedEventArgs : EventArgs
	{
		public readonly bool HasCharacterStartedEntryTransition; //Field offset: 0x8

		public CharacterEntrySkippedEventArgs(bool hasCharacterStartedEntryTransition) { }

	}

	public class CharacterEntryStartedEventArgs : EventArgs
	{
		public readonly Route FromRoute; //Field offset: 0x8
		public readonly Route ToRoute; //Field offset: 0xC

		public CharacterEntryStartedEventArgs(Route fromRoute, Route toRoute) { }

	}

	public class CharacterExitedEventArgs : EventArgs
	{
		public readonly Route ToRoute; //Field offset: 0x8

		public CharacterExitedEventArgs(Route toRoute) { }

	}

	private EventHandler<CharacterEntryStartedEventArgs> OnCharacterEntryStarted; //Field offset: 0xC
	private EventHandler<CharacterEntrySkippedEventArgs> OnCharacterEntrySkipped; //Field offset: 0x10
	private EventHandler<CharacterEnteredEventArgs> OnCharacterEntered; //Field offset: 0x14
	private EventHandler OnCharacterEnteredLanded; //Field offset: 0x18
	private EventHandler<CharacterExitedEventArgs> OnCharacterExited; //Field offset: 0x1C
	private EventHandler OnDestructing; //Field offset: 0x20
	protected RouteManager _routeManager; //Field offset: 0x24
	protected Transform _transform; //Field offset: 0x28
	private Character _character; //Field offset: 0x2C
	private bool _characterEnteredAndLanded; //Field offset: 0x30
	private float _characterEnterTimeStamp; //Field offset: 0x34
	private float _characterExitedTimeStamp; //Field offset: 0x38
	private Vector3 <OriginGamePosition>k__BackingField; //Field offset: 0x3C
	private bool <CharacterSkippedEntry>k__BackingField; //Field offset: 0x48
	private bool <CharacterEntered>k__BackingField; //Field offset: 0x49
	private bool <HasCharacterStartedEntryTransition>k__BackingField; //Field offset: 0x4A

	public event EventHandler<CharacterEnteredEventArgs> OnCharacterEntered
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event EventHandler OnCharacterEnteredLanded
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event EventHandler<CharacterEntrySkippedEventArgs> OnCharacterEntrySkipped
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event EventHandler<CharacterEntryStartedEventArgs> OnCharacterEntryStarted
	{
		 add { } //Length: 27
		 remove { } //Length: 111
	}

	public event EventHandler<CharacterExitedEventArgs> OnCharacterExited
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event EventHandler OnDestructing
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public abstract RouteBuilder Builder
	{
		 get { } //Length: 0
	}

	public bool CharacterEntered
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	public bool CharacterSkippedEntry
	{
		 get { } //Length: 6
		private set { } //Length: 61
	}

	public bool HasCharacterStartedEntryTransition
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	public bool IsCharacterInThisRoute
	{
		 get { } //Length: 9
	}

	public Vector3 OriginGamePosition
	{
		 get { } //Length: 111
		private set { } //Length: 26
	}

	public float TimeCharacterEnterTimeStamp
	{
		 get { } //Length: 12
	}

	public float TimeCharacterInRoute
	{
		 get { } //Length: 9
	}

	public abstract RouteType Type
	{
		 get { } //Length: 0
	}

	protected Route() { }

	public void add_OnCharacterEntered(EventHandler<CharacterEnteredEventArgs> value) { }

	public void add_OnCharacterEnteredLanded(EventHandler value) { }

	public void add_OnCharacterEntrySkipped(EventHandler<CharacterEntrySkippedEventArgs> value) { }

	public void add_OnCharacterEntryStarted(EventHandler<CharacterEntryStartedEventArgs> value) { }

	public void add_OnCharacterExited(EventHandler<CharacterExitedEventArgs> value) { }

	public void add_OnDestructing(EventHandler value) { }

	private void Character_OnLanding(Character character) { }

	public virtual void CharacterEnteredLanded() { }

	public virtual void CharacterStartEntryTransition(Route fromRoute, Route toRoute) { }

	public virtual void CharacterStartExitTransition(Route nextRoute) { }

	public abstract RouteBuilder get_Builder() { }

	public bool get_CharacterEntered() { }

	public bool get_CharacterSkippedEntry() { }

	public bool get_HasCharacterStartedEntryTransition() { }

	public bool get_IsCharacterInThisRoute() { }

	public Vector3 get_OriginGamePosition() { }

	public float get_TimeCharacterEnterTimeStamp() { }

	public float get_TimeCharacterInRoute() { }

	public abstract RouteType get_Type() { }

	public static Vector3 GetPosition(float x, float z) { }

	public Vector3 GetRelativePosition(Vector3 gamePosition) { }

	public static int GetTrackX(int trackIndex) { }

	public virtual void Initialize(RouteManager routeManager, Vector3 originGamePosition, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, RouteType previousRouteType, SyboRandom randomGenerator) { }

	public void NotifyCharacterEntered(Character character, Route previousRoute) { }

	public virtual void NotifyCharacterEntrySkipped() { }

	public virtual void NotifyCharacterExited(Route nextRoute) { }

	protected virtual void OnDestroy() { }

	protected void OnEnable() { }

	protected void OnValidate() { }

	protected virtual void RaiseOnCharacterEntered(CharacterEnteredEventArgs args) { }

	protected virtual void RaiseOnCharacterExited(CharacterExitedEventArgs args) { }

	public void remove_OnCharacterEntered(EventHandler<CharacterEnteredEventArgs> value) { }

	public void remove_OnCharacterEnteredLanded(EventHandler value) { }

	public void remove_OnCharacterEntrySkipped(EventHandler<CharacterEntrySkippedEventArgs> value) { }

	public void remove_OnCharacterEntryStarted(EventHandler<CharacterEntryStartedEventArgs> value) { }

	public void remove_OnCharacterExited(EventHandler<CharacterExitedEventArgs> value) { }

	public void remove_OnDestructing(EventHandler value) { }

	private void set_CharacterEntered(bool value) { }

	private void set_CharacterSkippedEntry(bool value) { }

	private void set_HasCharacterStartedEntryTransition(bool value) { }

	private void set_OriginGamePosition(Vector3 value) { }

	public override string ToString() { }

	public void UpdateRoute(float characterGamePositionZ, SyboRandom random) { }

}

