namespace UnityEngine;

public struct ContactFilter2D
{
	public bool useTriggers; //Field offset: 0x0
	public bool useLayerMask; //Field offset: 0x1
	public bool useDepth; //Field offset: 0x2
	public bool useOutsideDepth; //Field offset: 0x3
	public bool useNormalAngle; //Field offset: 0x4
	public bool useOutsideNormalAngle; //Field offset: 0x5
	public LayerMask layerMask; //Field offset: 0x8
	public float minDepth; //Field offset: 0xC
	public float maxDepth; //Field offset: 0x10
	public float minNormalAngle; //Field offset: 0x14
	public float maxNormalAngle; //Field offset: 0x18

	private void CheckConsistency() { }

	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }

	public void SetDepth(float minDepth, float maxDepth) { }

	public void SetLayerMask(LayerMask layerMask) { }

}

