using System;
using System.Collections;
using System.Collections.Generic;
using AppRefresh;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Subway.Info;
using UnityEngine;

public class CharacterLetterPickup : LetterPickup
{
	private sealed class _003CRewardCoroutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterLetterPickup _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Expected Obj, but got Unknown
				//IL_006d: Expected Obj, but got I4
				//IL_0081: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				_003C_003E4__this.OnActivate();
				object obj = this + 12;
				obj = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CRewardCoroutine_003Ed__14(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
		}

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public char Letter
	{
		set
		{
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected Obj, but got Unknown
			//IL_00c4: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			//IL_00a0: Expected I4, but got Obj
			CharacterNameEventManager characterNameEventManager = default;
			object obj = characterNameEventManager + 4;
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			DailyLetterPickupManager instance = DailyLetterPickupManager.Instance;
			if ((object)instance != null)
			{
				nint num = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v17 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v26 (Il2CppClass<SSEventsManagerController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string flurryUserId = Flurry.flurryUserId;
				CharacterNameEventManager typeOfActiveEventManager = ((SSEventsManagerController)(object)flurryUserId).GetTypeOfActiveEventManager<CharacterNameEventManager>();
				if (typeOfActiveEventManager != null)
				{
					characterNameEventManager.NotifyLetterCollected((char)(int)typeOfActiveEventManager);
					obj = characterNameEventManager;
				}
			}
			CharacterLetterPickup characterLetterPickup = (CharacterLetterPickup)obj;
		}
	}

	private bool HasDailyLetter
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)Letters != 0;
		}
	}

	public static bool IsCharacterNameEventActive()
	{
		//IL_01f3: Expected I, but got Obj
		//IL_0209: Expected Obj, but got I
		//IL_0248: Expected I, but got Obj
		//IL_025e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0165: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_023a: Expected I4, but got Obj
		//IL_00b7: Expected I4, but got Obj
		//IL_01a6: Expected I, but got Obj
		//IL_00d7: Expected I, but got Obj
		//IL_00ed: Expected Obj, but got I
		//IL_0118: Expected I, but got Obj
		nint num = (nint)typeof(NotificationsObserver);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NotificationsObserver>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NotificationsObserver);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v44 (Il2CppClass<NotificationsObserver>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (NotificationsObserver._instance != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			gameObject.layer = (int)"NotificationsObserver";
			NotificationsObserver notificationsObserver = gameObject.AddComponent<NotificationsObserver>();
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((UnityEngine.UnitySynchronizationContext)(object)gameObject).Exec();
		}
		nint num7 = (nint)typeof(NotificationsObserver);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v16 (Il2CppClass<NotificationsObserver>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(NotificationsObserver);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v23 (Il2CppClass<NotificationsObserver>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)(int)NotificationsObserver._instance != 0;
	}

	public static bool IsCharacterLetterPickupSpawnable()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		return ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.lucy);
	}

	private void ReportLetterWasPickedup()
	{
	}

	private char? GetNextCharacterLetterToSpawn()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		char? c = default;
		object obj = (Nullable)c + 16;
		obj = this;
		return c;
	}

	protected override void OnActivate()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (!IsCharacterLetterPickupSpawnable())
		{
			return;
		}
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v9 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		((SSEventsManagerController)(object)((SSEventsManagerController)(object)flurryUserId).GetTypeOfActiveEventManager<CharacterNameEventManager>())?.OnHasRefreshed((RefreshType)_letterChar);
	}

	protected unsafe override void OnDeactivate()
	{
		//IL_0164: Expected Obj, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_008d: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_00ce: Expected I, but got Obj
		//IL_011b: Expected I, but got Obj
		CharacterLetterPickup characterLetterPickup = (CharacterLetterPickup)0;
		DailyLetterPickupManager instance = DailyLetterPickupManager.Instance;
		if ((object)instance == null)
		{
			return;
		}
		characterLetterPickup.Letter = '\0';
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (CharacterLetterPickup)+2]");
		if ((nint)0 != 0)
		{
			char value = ((char?*)characterLetterPickup)->Value;
			((DailyLetterPickup)this).Letter = value;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		EventHandler<CharacterNameEventManager.LetterCollectedEventArgs> eventHandler = default;
		object obj = eventHandler + 16;
		obj = this;
		nint num2 = (nint)typeof(CharacterNameEventManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v29 (Il2CppClass<CharacterNameEventManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(CharacterNameEventManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v50 (Il2CppClass<CharacterNameEventManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterNameEventManager.OnLetterCollected -= eventHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(CharacterLetterPickup.SSEventsManagerController_OnSSEventChangedHandler);
		object obj3 = action + 16;
		obj3 = this;
		nint num4 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v41 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v46 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventChangedHandler -= action;
	}

	private void DeactivatePickupIfEventHasCompleted()
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00d8: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0155: Expected I, but got Obj
		//IL_016b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<Characters.CharacterId, int> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(CharacterNameEventManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<CharacterNameEventManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(CharacterNameEventManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v36 (Il2CppClass<CharacterNameEventManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterNameEventManager.OnCharacterSkippedWithKeys += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		SSEventsManagerController sSEventsManagerController = default;
		sSEventsManagerController._currentEventManager = (IEventManager)num4;
		_ = 0;
		object obj3 = sSEventsManagerController + 16;
		obj3 = this;
		nint num5 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v27 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v32 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		sSEventsManagerController.Initialize();
	}

	private void CharacterNameEventManager_OnLetterCollected(object sender, CharacterNameEventManager.LetterCollectedEventArgs letterCollectedEventArgs)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = sender;
	}

	private void SSEventsManagerController_OnSSEventChangedHandler()
	{
		//IL_0090: Expected I, but got Obj
		//IL_00a6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		CharacterNameEventManager typeOfActiveEventManager = ((SSEventsManagerController)(object)flurryUserId).GetTypeOfActiveEventManager<CharacterNameEventManager>();
		if (typeOfActiveEventManager == null || typeOfActiveEventManager.IsFirstCharacterSelected())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	public void Reward()
	{
		SSEventsManagerController_OnSSEventChangedHandler();
	}

	private IEnumerator RewardCoroutine()
	{
		//IL_0019: Expected Obj, but got I4
		bool flag = _letterChar != '\0';
		return (IEnumerator)flag;
	}

	public CharacterLetterPickup()
	{
		//IL_001f: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I4
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ S0_v2 (System.String)+F8]");
		object obj = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ S0_v2 (System.String)+FC]");
		object obj2 = (nint)0 + (nint)1;
		char letter = ((DailyLetterPickupManager)(object)this).Letter;
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])letter);
	}
}
