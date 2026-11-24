namespace System.Runtime.Remoting.Lifetime;

public interface ILease
{

	public TimeSpan CurrentLeaseTime
	{
		 get { } //Length: 0
	}

	public LeaseState CurrentState
	{
		 get { } //Length: 0
	}

	public TimeSpan InitialLeaseTime
	{
		 set { } //Length: 0
	}

	public TimeSpan RenewOnCallTime
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public TimeSpan SponsorshipTimeout
	{
		 set { } //Length: 0
	}

	public TimeSpan get_CurrentLeaseTime() { }

	public LeaseState get_CurrentState() { }

	public TimeSpan get_RenewOnCallTime() { }

	public TimeSpan Renew(TimeSpan renewalTime) { }

	public void set_InitialLeaseTime(TimeSpan value) { }

	public void set_RenewOnCallTime(TimeSpan value) { }

	public void set_SponsorshipTimeout(TimeSpan value) { }

}

