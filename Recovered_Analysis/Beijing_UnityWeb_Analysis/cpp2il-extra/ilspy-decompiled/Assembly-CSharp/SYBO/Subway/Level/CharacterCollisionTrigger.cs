using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

public class CharacterCollisionTrigger : MonoBehaviour
{
	private EventHandler m_OnCharacterEnter;

	public unsafe event EventHandler OnCharacterEnter
	{
		add
		{
			//IL_0041: Expected Obj, but got I
			ref MovingTrainUpdater.TrainAudioWrapper reference = ref *(MovingTrainUpdater.TrainAudioWrapper*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.CharacterCollisionTrigger)+14]");
			if (((Dictionary<MovingTrain, MovingTrainUpdater.TrainAudioWrapper>)0).TryGetValue((MovingTrain)(object)value, out reference))
			{
				reference.Mute();
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCharacterEnter;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_OnCharacterEnter;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)other);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 12;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	public CharacterCollisionTrigger()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 28;
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj3 = this + 32;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Material> list = default;
		list._002Ector();
		object obj5 = this + 36;
		obj5 = list;
		CancelInvoke();
	}
}
