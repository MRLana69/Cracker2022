namespace SYBO.Subway.Routes.Builders;

public abstract class ConstrainingRouteBuilder : RouteBuilder, IConstrainingRouteBuilder
{
	public const int MinConstraintLength = 180; //Field offset: 0x0
	private EventHandler OnReachedLengthVisibleFromEntry; //Field offset: 0xE8
	private List<RouteBuilder> _constrainedRouteBuilders; //Field offset: 0xEC

	public event EventHandler OnReachedLengthVisibleFromEntry
	{
		 add { } //Length: 11
		 remove { } //Length: 113
	}

	public ICollection<RouteBuilder> ConstrainedBuilders
	{
		 get { } //Length: 49
	}

	public abstract ICollection<RouteType> ConstrainedRouteTypes
	{
		 get { } //Length: 0
	}

	public int ConstraintEndZ
	{
		 get { } //Length: 64
	}

	public int ConstraintStartZ
	{
		 get { } //Length: 15
	}

	public bool HasReachedLengthVisibleFromEntry
	{
		 get { } //Length: 6
	}

	protected ConstrainingRouteBuilder() { }

	public void add_OnReachedLengthVisibleFromEntry(EventHandler value) { }

	private void AddFromListIfConstrained(ICollection<RouteBuilder> builders) { }

	private void AddIfConstrained(RouteBuilder builder) { }

	public void CollectConstrained() { }

	public override void ConnectBuilder(RouteBuilder builderToConnect) { }

	public override void DisconnectBuilder(RouteBuilder builderToDisconnect) { }

	public ICollection<RouteBuilder> get_ConstrainedBuilders() { }

	public abstract ICollection<RouteType> get_ConstrainedRouteTypes() { }

	public int get_ConstraintEndZ() { }

	public int get_ConstraintStartZ() { }

	public bool get_HasReachedLengthVisibleFromEntry() { }

	public abstract RouteConstraint GetConstraint(RouteType routeType) { }

	public bool IsConstrainingEndAt(int rangeEndZ) { }

	public bool IsConstrainingRange(int startZ, int endZ) { }

	public bool IsConstrainingStartAt(int rangeStartZ) { }

	private void OnDrawGizmos() { }

	public void remove_OnReachedLengthVisibleFromEntry(EventHandler value) { }

	public override void UpdateBuilder(float characterWorldZ) { }

}

