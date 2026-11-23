using UnityEngine;

public class CurvePointTangent : MonoBehaviour
{
	public void OnDrawGizmosSelected()
	{
		Transform transform = base.transform;
		Transform parent = transform.parent;
		if (parent != null)
		{
			Transform transform2 = base.transform;
			Transform parent2 = transform2.parent;
			CurvePoint component = parent2.GetComponent<CurvePoint>();
			component.OnDrawGizmosSelected();
		}
	}
}
