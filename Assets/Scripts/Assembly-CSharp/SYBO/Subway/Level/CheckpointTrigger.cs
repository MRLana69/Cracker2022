using System;
using Cpp2ILInjected;
using SYBO.Subway.Characters;
using UnityEngine;

namespace SYBO.Subway.Level;

public class CheckpointTrigger : MonoBehaviour
{
	private CharacterCollisionTrigger _trigger;

	private unsafe void Awake()
	{
		CharacterCollisionTrigger component = GetComponent<CharacterCollisionTrigger>();
		_trigger = component;
		EventHandler eventHandler = default;
		eventHandler._002Ector(this, (nint)__ldftn(CheckpointTrigger.Handler_OnCharacterEnter));
		_trigger.OnCharacterEnter += eventHandler;
	}

	private void Handler_OnCharacterEnter(object sender, EventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0048: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		Character instance = Character.Instance;
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		instance._lastCheckpointTime = 0f;
	}
}
