using UnityEngine;

public class UISnapshotPoint : MonoBehaviour
{
	public bool isOrthographic = true;

	public float nearClip = -100f;

	public float farClip;

	public int fieldOfView = 35;

	public float orthoSize;

	public Texture2D thumbnail;

	private void Start()
	{
		string text = tag;
		if (text != "EditorOnly")
		{
			tag = "EditorOnly";
		}
	}

	public UISnapshotPoint()
	{
		//IL_000f: Expected I4, but got I8
	}
}
