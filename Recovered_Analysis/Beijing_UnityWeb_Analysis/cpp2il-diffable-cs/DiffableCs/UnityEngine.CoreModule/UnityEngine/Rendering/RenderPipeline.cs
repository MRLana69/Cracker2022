namespace UnityEngine.Rendering;

public abstract class RenderPipeline
{
	private bool <disposed>k__BackingField; //Field offset: 0x8

	public bool disposed
	{
		 get { } //Length: 12
		private set { } //Length: 65
	}

	internal void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public bool get_disposed() { }

	internal void InternalRender(ScriptableRenderContext context, Camera[] cameras) { }

	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras) { }

	private void set_disposed(bool value) { }

}

