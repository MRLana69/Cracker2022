using UnityEngine;

public class UIDragDropContainer : MonoBehaviour
{
	public Transform reparentTarget;

	protected virtual void Start()
	{
		if (reparentTarget == null)
		{
			Transform transform = base.transform;
			reparentTarget = transform;
		}
	}
}
