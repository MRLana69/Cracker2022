using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class ParticleSystemSizeScaler : MonoBehaviour
{
	private void Start()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<GameObject> list = default;
		list._002Ector();
		object obj = this + 12;
		obj = list;
		_ = -1;
		_ = -1;
		CancelInvoke();
	}

	public ParticleSystemSizeScaler()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0082: Expected I4, but got Obj
		Transform transform = default;
		object obj = transform + 16;
		ParticleSystem component = GetComponent<ParticleSystem>();
		obj = 0;
		obj = component;
		object obj2 = transform + 12;
		obj2 = obj;
		GameObject gameObject = base.gameObject;
		transform.hasChanged = (byte)(int)gameObject != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11757");
		component.Clear();
		component.Stop(withChildren: true);
	}
}
