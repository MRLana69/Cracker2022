using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

public class CheckpointTrigger : MonoBehaviour
{
	private CharacterCollisionTrigger _trigger;

	private void Awake()
	{
		CancelInvoke();
	}

	private void Handler_OnCharacterEnter(object sender, EventArgs e)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sender @ L1 (System.Object)+C]");
		if ((nint)0 == 0)
		{
			string text = ((Component)sender).tag;
			((GameObject)(object)text).tag = (string)(object)e;
		}
	}

	public unsafe CheckpointTrigger()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		object obj = this + 12;
		CharacterCollisionTrigger component = GetComponent<CharacterCollisionTrigger>();
		obj = component;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventHandler eventHandler = default;
		((Delegate)eventHandler).method_ptr = method_ptr;
		((Delegate)eventHandler).method = (nint)__ldftn(CheckpointTrigger.Handler_OnCharacterEnter);
		object obj2 = eventHandler + 16;
		obj2 = this;
		_trigger.OnCharacterEnter -= eventHandler;
	}
}
