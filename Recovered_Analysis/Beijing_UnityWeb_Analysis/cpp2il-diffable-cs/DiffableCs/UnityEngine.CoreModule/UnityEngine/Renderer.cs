namespace UnityEngine;

public class Renderer : Component
{

	public Bounds bounds
	{
		 get { } //Length: 53
	}

	public bool enabled
	{
		 get { } //Length: 49
		 set { } //Length: 11
	}

	public Material material
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public Material[] materials
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public bool receiveShadows
	{
		 set { } //Length: 53
	}

	public ShadowCastingMode shadowCastingMode
	{
		 set { } //Length: 53
	}

	public Material sharedMaterial
	{
		 get { } //Length: 9
	}

	public Material[] sharedMaterials
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public int sortingLayerID
	{
		 get { } //Length: 49
	}

	public string sortingLayerName
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public int sortingOrder
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public Bounds get_bounds() { }

	private void get_bounds_Injected(out Bounds ret) { }

	public bool get_enabled() { }

	public Material get_material() { }

	public Material[] get_materials() { }

	public Material get_sharedMaterial() { }

	public Material[] get_sharedMaterials() { }

	public int get_sortingLayerID() { }

	public string get_sortingLayerName() { }

	public int get_sortingOrder() { }

	private Material GetMaterial() { }

	private Material[] GetMaterialArray() { }

	private Material GetSharedMaterial() { }

	private Material[] GetSharedMaterialArray() { }

	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	public void set_enabled(bool value) { }

	public void set_material(Material value) { }

	public void set_materials(Material[] value) { }

	public void set_receiveShadows(bool value) { }

	public void set_shadowCastingMode(ShadowCastingMode value) { }

	public void set_sharedMaterials(Material[] value) { }

	public void set_sortingLayerName(string value) { }

	public void set_sortingOrder(int value) { }

	private void SetMaterial(Material m) { }

	private void SetMaterialArray(Material[] m) { }

	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

}

