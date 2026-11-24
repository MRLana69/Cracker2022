namespace UnityEngine.Rendering;

public abstract class RenderPipelineAsset : ScriptableObject
{

	public virtual Shader autodeskInteractiveMaskedShader
	{
		 get { } //Length: 3
	}

	public virtual Shader autodeskInteractiveShader
	{
		 get { } //Length: 3
	}

	public virtual Shader autodeskInteractiveTransparentShader
	{
		 get { } //Length: 3
	}

	public virtual Material default2DMaterial
	{
		 get { } //Length: 3
	}

	public virtual Material defaultLineMaterial
	{
		 get { } //Length: 3
	}

	public virtual Material defaultMaterial
	{
		 get { } //Length: 3
	}

	public virtual Material defaultParticleMaterial
	{
		 get { } //Length: 3
	}

	public virtual Shader defaultShader
	{
		 get { } //Length: 3
	}

	public virtual Shader defaultSpeedTree7Shader
	{
		 get { } //Length: 3
	}

	public virtual Shader defaultSpeedTree8Shader
	{
		 get { } //Length: 3
	}

	public virtual Material defaultTerrainMaterial
	{
		 get { } //Length: 3
	}

	public virtual Material defaultUIETC1SupportedMaterial
	{
		 get { } //Length: 3
	}

	public virtual Material defaultUIMaterial
	{
		 get { } //Length: 3
	}

	public virtual Material defaultUIOverdrawMaterial
	{
		 get { } //Length: 3
	}

	public virtual string[] renderingLayerMaskNames
	{
		 get { } //Length: 9
	}

	public virtual Shader terrainDetailGrassBillboardShader
	{
		 get { } //Length: 3
	}

	public virtual Shader terrainDetailGrassShader
	{
		 get { } //Length: 3
	}

	public virtual Shader terrainDetailLitShader
	{
		 get { } //Length: 3
	}

	protected RenderPipelineAsset() { }

	protected abstract RenderPipeline CreatePipeline() { }

	public virtual Shader get_autodeskInteractiveMaskedShader() { }

	public virtual Shader get_autodeskInteractiveShader() { }

	public virtual Shader get_autodeskInteractiveTransparentShader() { }

	public virtual Material get_default2DMaterial() { }

	public virtual Material get_defaultLineMaterial() { }

	public virtual Material get_defaultMaterial() { }

	public virtual Material get_defaultParticleMaterial() { }

	public virtual Shader get_defaultShader() { }

	public virtual Shader get_defaultSpeedTree7Shader() { }

	public virtual Shader get_defaultSpeedTree8Shader() { }

	public virtual Material get_defaultTerrainMaterial() { }

	public virtual Material get_defaultUIETC1SupportedMaterial() { }

	public virtual Material get_defaultUIMaterial() { }

	public virtual Material get_defaultUIOverdrawMaterial() { }

	public virtual string[] get_renderingLayerMaskNames() { }

	public virtual Shader get_terrainDetailGrassBillboardShader() { }

	public virtual Shader get_terrainDetailGrassShader() { }

	public virtual Shader get_terrainDetailLitShader() { }

	internal RenderPipeline InternalCreatePipeline() { }

	protected virtual void OnDisable() { }

	protected virtual void OnValidate() { }

}

