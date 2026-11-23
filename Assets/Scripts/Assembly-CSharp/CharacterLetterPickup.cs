using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using UnityEngine;

public class CharacterLetterPickup : LetterPickup
{
	private sealed class _003CRewardCoroutine_003Ed__14(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterLetterPickup _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num;
			if (_003C_003E1__state != 0)
			{
				bool flag = _003C_003E1__state == 1;
				num = -1;
				if (!flag)
				{
					goto IL_0086;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				_003C_003E4__this.ReportLetterWasPickedup();
				_003C_003E2__current = null;
				num = 1;
			}
			_003C_003E1__state = num;
			goto IL_0086;
			IL_0086:
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public char Letter
	{
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			_letterChar = value;
			if (_letterChar != '\0')
			{
				List<Mesh> letters = Letters;
				int num = value - 65;
				if (num >= 0 && num < letters._size)
				{
					object obj3 = obj + 14;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					object message = default;
					Debug.Log(message);
					Mesh mesh = Letters.get_Item(num);
					LetterMesh.mesh = mesh;
				}
			}
		}
	}

	private bool HasDailyLetter => _letterChar != '\0';

	public static bool IsCharacterNameEventActive()
	{
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager(SSEventType.CharacterName);
		return activeEventManager != null;
	}

	public static bool IsCharacterLetterPickupSpawnable()
	{
		Debug.Log("IsCharacterLetterPickupSpawnable");
		return true;
	}

	private void ReportLetterWasPickedup()
	{
		if (IsCharacterNameEventActive())
		{
			SSEventsManagerController instance = SSEventsManagerController.instance;
			instance.GetTypeOfActiveEventManager<CharacterNameEventManager>()?.NotifyLetterCollected(_letterChar);
		}
	}

	private char? GetNextCharacterLetterToSpawn()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I
		//IL_00bc: Expected VT, but got Obj
		//IL_0058: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		bool flag = IsCharacterLetterPickupSpawnable();
		SSEventsManagerController instance = SSEventsManagerController.instance;
		CharacterNameEventManager typeOfActiveEventManager = instance.GetTypeOfActiveEventManager<CharacterNameEventManager>();
		object obj4;
		if (typeOfActiveEventManager == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			obj4 = 0;
		}
		else
		{
			char? c = typeOfActiveEventManager.NextLetterToSpawn();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			obj4 = 0;
		}
		return (char?)obj4;
	}

	protected unsafe override void OnActivate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected VT, but got Unknown
		//IL_002a: Expected Ref, but got VT
		object obj = default;
		CharacterLetterPickup characterLetterPickup = (CharacterLetterPickup)(obj - 16);
		characterLetterPickup.LetterMesh = null;
		bool flag = IsCharacterLetterPickupSpawnable();
		char? nextCharacterLetterToSpawn = characterLetterPickup.GetNextCharacterLetterToSpawn();
		if ((object)characterLetterPickup.LetterMesh != null)
		{
			char? c = (char?)(object)(characterLetterPickup + 12);
			char value = ((char?*)c)->Value;
			Letter = value;
		}
		throw new ArgumentException();
	}

	protected override void OnDeactivate()
	{
		throw new ArgumentException();
	}

	private void DeactivatePickupIfEventHasCompleted()
	{
		//IL_0030: Expected I, but got Obj
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		SSEventsManagerController instance = SSEventsManagerController.instance;
		CharacterNameEventManager typeOfActiveEventManager = instance.GetTypeOfActiveEventManager<CharacterNameEventManager>();
		if (typeOfActiveEventManager == null || typeOfActiveEventManager.HasCompletedCollectionForSelectedCharacter())
		{
			nint num = (nint)this;
			object obj = this + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S1_v7 (Il2CppClass<CharacterLetterPickup>)+E4] (should have been resolved before IL gen)");
		}
	}

	private void CharacterNameEventManager_OnLetterCollected(object sender, CharacterNameEventManager.LetterCollectedEventArgs letterCollectedEventArgs)
	{
		DeactivatePickupIfEventHasCompleted();
	}

	private void SSEventsManagerController_OnSSEventChangedHandler()
	{
		DeactivatePickupIfEventHasCompleted();
	}

	public void Reward()
	{
		GameStats instance = GameStats.Instance;
		int characterLetterPickupsCollected = instance._characterLetterPickupsCollected + 1;
		instance._characterLetterPickupsCollected = characterLetterPickupsCollected;
		int characterLetterPickupsCollectedRun = instance._characterLetterPickupsCollectedRun + 1;
		instance._characterLetterPickupsCollectedRun = characterLetterPickupsCollectedRun;
		IEnumerator coroutine = RewardCoroutine();
		Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
	}

	private IEnumerator RewardCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}
}
