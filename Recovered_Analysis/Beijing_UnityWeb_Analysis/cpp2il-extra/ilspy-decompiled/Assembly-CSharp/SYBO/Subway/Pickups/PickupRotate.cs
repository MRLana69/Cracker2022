using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Pickups;

public class PickupRotate : MonoBehaviour
{
	private Transform _target;

	private float _speed;

	private float _rotatePhase;

	private float _worldPosZ;

	private Vector3 _localEuler;

	private bool _willRotate = false;

	public bool WillRotate
	{
		get
		{
			//IL_0155: Expected I, but got Obj
			//IL_016b: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0091: Expected I, but got Obj
			//IL_00a7: Expected Obj, but got I
			//IL_00d2: Expected I, but got Obj
			nint num = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_USE_ENABLE_SS_EVENT_TYPE___LETTER_HUNT_CHARACTER ? 1u : 0u) == 0)
			{
				return true;
			}
			if (((PickupManagerController)null).IsCharacterLetterPickupSpawnable())
			{
				nint num3 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v18 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v29 (Il2CppClass<SSEventsManagerController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string flurryUserId = Flurry.flurryUserId;
				return (byte)(((SSEventsManagerController)(object)flurryUserId).GetTypeOfActiveEventManager<CharacterNameEventManager>()?.GetAmountOfCollectedLetters() ?? 0) != 0;
			}
			return false;
		}
	}

	public void Awake()
	{
		//IL_00d7: Expected Obj, but got I
		//IL_00e9: Expected I, but got Obj
		//IL_00ff: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		bool flag = ((PickupManager)(nint)((UnityEngine.Object)this).m_CachedPtr).HasPickupDataForPickupType(PickupType.LetterHuntCharacter);
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v26 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_USE_ENABLE_SS_EVENT_TYPE___LETTER_HUNT_CHARACTER ? 1u : 0u) == 0)
		{
			_ = 0;
		}
		else if (flag)
		{
			if (((PickupManagerController)null).IsCharacterLetterPickupSpawnable() && ((PickupRotate)null).WillRotate)
			{
				_ = 0;
			}
			else
			{
				_ = 1;
			}
		}
	}

	protected unsafe void OnDestroy()
	{
		//IL_0125: Expected I, but got Obj
		//IL_013b: Expected Obj, but got I
		//IL_0162: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009e: Expected Obj, but got VT
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got VT
		string text = tag;
		_0021_00210 componentInChildren = (_0021_00210)((GameObject)(object)text).GetComponentInChildren<T>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)componentInChildren).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(PickupRotate.TrackObject_OnActivate);
			object obj2 = action + 16;
			obj2 = this;
			((TrackObject)componentInChildren).OnActivate -= action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			Action action2 = default;
			((Delegate)action2).method_ptr = method_ptr2;
			((Delegate)action2).method = (nint)__ldftn(PickupRotate.TrackObject_OnDeactivate);
			object obj3 = action2 + 16;
			obj3 = this;
			((TrackObject)componentInChildren).OnDeactivate -= action2;
		}
		_willRotate = false;
	}

	public void PhasedRotate(float time)
	{
	}

	private void Activate()
	{
		_willRotate = false;
	}

	private void StopRotating()
	{
		//IL_0017: Expected VT, but got Obj
		//IL_002b: Expected F4, but got I
		GameObject gameObject = base.gameObject;
		Transform transform = default;
		transform.position = (Vector3)gameObject;
		_worldPosZ = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		_willRotate = true;
	}

	private void PickupController_OnActivate()
	{
		_willRotate = false;
	}

	private void TrackObject_OnActivate()
	{
		StopRotating();
	}

	private void TrackObject_OnDeactivate()
	{
		StopRotating();
	}
}
