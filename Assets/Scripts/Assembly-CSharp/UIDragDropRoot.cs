using UnityEngine;

public class UIDragDropRoot : MonoBehaviour
{
	public static Transform root;

	private void OnEnable()
	{
		Transform transform = base.transform;
		root = transform;
	}

	private void OnDisable()
	{
		Transform transform = base.transform;
		if (root == transform)
		{
			root = null;
		}
	}
}
