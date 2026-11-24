namespace SYBO.Subway.Visuals;

public abstract class ThemeEffect : ScriptableObject
{

	protected ThemeEffect() { }

	public abstract void Initialize(Transform root) { }

	public abstract void UpdateEffect() { }

}

