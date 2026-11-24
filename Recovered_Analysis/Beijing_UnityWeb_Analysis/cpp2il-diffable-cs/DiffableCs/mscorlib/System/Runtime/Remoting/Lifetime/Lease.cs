namespace System.Runtime.Remoting.Lifetime;

internal class Lease : MarshalByRefObject, ILease
{
	private delegate RenewalDelegate
	{

		public RenewalDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(ILease lease, AsyncCallback callback, object object) { }

		public virtual TimeSpan EndInvoke(IAsyncResult result) { }

		public virtual TimeSpan Invoke(ILease lease) { }

	}

	private DateTime _leaseExpireTime; //Field offset: 0x10
	private LeaseState _currentState; //Field offset: 0x18
	private TimeSpan _initialLeaseTime; //Field offset: 0x20
	private TimeSpan _renewOnCallTime; //Field offset: 0x28
	private TimeSpan _sponsorshipTimeout; //Field offset: 0x30
	private ArrayList _sponsors; //Field offset: 0x38
	private Queue _renewingSponsors; //Field offset: 0x3C
	private RenewalDelegate _renewalDelegate; //Field offset: 0x40

	public TimeSpan CurrentLeaseTime
	{
		 get { } //Length: 12
	}

	public LeaseState CurrentState
	{
		 get { } //Length: 127
	}

	public TimeSpan InitialLeaseTime
	{
		 set { } //Length: 6
	}

	public TimeSpan RenewOnCallTime
	{
		 get { } //Length: 160
		 set { } //Length: 6
	}

	public TimeSpan SponsorshipTimeout
	{
		 set { } //Length: 6
	}

	public Lease() { }

	public void Activate() { }

	private void CheckNextSponsor() { }

	public TimeSpan get_CurrentLeaseTime() { }

	public LeaseState get_CurrentState() { }

	public TimeSpan get_RenewOnCallTime() { }

	private void ProcessSponsorResponse(object state, bool timedOut) { }

	public TimeSpan Renew(TimeSpan renewalTime) { }

	public void set_InitialLeaseTime(TimeSpan value) { }

	public void set_RenewOnCallTime(TimeSpan value) { }

	public void set_SponsorshipTimeout(TimeSpan value) { }

	public void Unregister(ISponsor obj) { }

	internal void UpdateState() { }

}

