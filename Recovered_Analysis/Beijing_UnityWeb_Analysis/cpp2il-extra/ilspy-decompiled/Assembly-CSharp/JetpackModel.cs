using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class JetpackModel : MonoBehaviour
{
	private MeshRenderer mesh;

	private Transform jetpackCloudPositionL;

	private Transform jetpackCloudPositionR;

	private Transform[] jetpackThrusters;

	public MeshRenderer Mesh
	{
		get
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			MeshRenderer meshRenderer = default;
			((UnityEngine.Object)meshRenderer).m_CachedPtr = (IntPtr)0;
			object obj = meshRenderer + 16;
			obj = this;
			return meshRenderer;
		}
	}

	public Transform JetpackCloudPositionL => (Transform)(object)mesh;

	public Transform JetpackCloudPositionR => jetpackCloudPositionL;

	public Transform[] JetpackThrusters => (Transform[])(object)jetpackCloudPositionR;

	public JetpackModel()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<AnimationClip> list = default;
		list._002Ector();
		object obj = this + 32;
		obj = list;
		CancelInvoke();
	}
}
