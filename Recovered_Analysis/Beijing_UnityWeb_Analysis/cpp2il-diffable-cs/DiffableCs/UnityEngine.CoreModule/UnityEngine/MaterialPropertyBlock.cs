namespace UnityEngine;

public sealed class MaterialPropertyBlock
{
	internal nint m_Ptr; //Field offset: 0x8

	public MaterialPropertyBlock() { }

	private static nint CreateImpl() { }

	private static void DestroyImpl(nint mpb) { }

	private void Dispose() { }

	protected override void Finalize() { }

	public void SetFloat(string name, float value) { }

	private void SetFloatImpl(int name, float value) { }

	public void SetTexture(string name, Texture value) { }

	private void SetTextureImpl(int name, Texture value) { }

}

