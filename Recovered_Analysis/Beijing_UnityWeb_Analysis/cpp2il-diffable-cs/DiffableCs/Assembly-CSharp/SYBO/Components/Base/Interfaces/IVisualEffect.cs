namespace SYBO.Components.Base.Interfaces;

public interface IVisualEffect
{

	public bool IsAutoPlay
	{
		 get { } //Length: 0
	}

	public bool IsPlaying
	{
		 get { } //Length: 0
	}

	public VisualEffectEvent OnLoop
	{
		 get { } //Length: 0
	}

	public VisualEffectEvent OnPlay
	{
		 get { } //Length: 0
	}

	public VisualEffectEvent OnStop
	{
		 get { } //Length: 0
	}

	public bool get_IsAutoPlay() { }

	public bool get_IsPlaying() { }

	public VisualEffectEvent get_OnLoop() { }

	public VisualEffectEvent get_OnPlay() { }

	public VisualEffectEvent get_OnStop() { }

	public void Play() { }

	public void Stop() { }

}

