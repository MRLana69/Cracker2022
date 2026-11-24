namespace UnityEngine.UI;

public abstract class BaseVertexEffect
{

	protected BaseVertexEffect() { }

	public abstract void ModifyVertices(List<UIVertex> vertices) { }

}

