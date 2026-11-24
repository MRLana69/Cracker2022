using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class LetterPickup : MonoBehaviour
{
	public MeshFilter LetterMesh;

	public List<Mesh> Letters;

	public bool shouldSpawnParticles;

	protected char _letterChar;

	public const char NO_LETTER = '\0';

	private void Awake()
	{
		CancelInvoke();
	}

	protected virtual void OnActivate()
	{
		//IL_00db: Expected I, but got Obj
		//IL_00e8: Expected I, but got Obj
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0053: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		TrackObject component = GetComponent<TrackObject>();
		bool flag = (object)component == null;
		bool flag2 = !flag;
		TrackObject trackObject = component;
		if (!flag2)
		{
			string text = tag;
			TrackObject trackObject2 = ((GameObject)(object)text).AddComponent<TrackObject>();
			trackObject = trackObject2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = new NullReferenceException();
		Action action = default;
		((Delegate)action).method_ptr = (IntPtr)ex;
		((Delegate)action).method = (IntPtr)ex;
		object obj = action + 16;
		obj = this;
		trackObject.OnActivate -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex2 = new NullReferenceException();
		Action action2 = default;
		((Delegate)action2).method_ptr = (IntPtr)ex2;
		((Delegate)action2).method = (IntPtr)ex2;
		object obj2 = action2 + 16;
		obj2 = this;
		trackObject.OnDeactivate -= action2;
	}

	protected virtual void OnDeactivate()
	{
	}
}
