namespace UnityEngine.UI;

public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier
{
	private Graphic m_Graphic; //Field offset: 0xC

	protected Graphic graphic
	{
		 get { } //Length: 63
	}

	protected BaseMeshEffect() { }

	protected Graphic get_graphic() { }

	public virtual void ModifyMesh(Mesh mesh) { }

	public abstract void ModifyMesh(VertexHelper vh) { }

	protected override void OnDidApplyAnimationProperties() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

}

