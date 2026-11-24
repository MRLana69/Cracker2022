namespace SYBO.Common.StateSystem;

public interface IScheduler
{

	public void RegisterLateUpdateHandler(Action handler) { }

	public void RegisterUpdateHandler(Action handler) { }

}

