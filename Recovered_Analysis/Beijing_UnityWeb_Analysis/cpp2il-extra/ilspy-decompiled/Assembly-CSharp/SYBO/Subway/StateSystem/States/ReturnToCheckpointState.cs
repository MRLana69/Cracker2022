using Cpp2ILInjected;
using SYBO.Common.StateSystem;
using SYBO.Subway.Characters;
using SYBO.Subway.Inputs;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.StateSystem.States;

public class ReturnToCheckpointState : InGameState
{
	private const float ReturnToCheckpointDelay = 0.5f;

	private const float ReturnToCheckpointDuration = 1f;

	private float _returnTime;

	private bool _startedMovingBack;

	private Vector3 _initialPosition;

	private Vector3 _targetPosition;

	public ReturnToCheckpointState(int id)
	{
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0061: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got VT
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)_initialPosition).FindKernel(null) != 0)
		{
			((GameObject)_initialPosition).tag = (string)id;
		}
	}

	public override void Enter(State fromState)
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0136: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v29 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 12;
		Vector3 one = Vector3.one;
		object obj4 = obj3 + 24;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		_ = 0;
		object obj5 = this + 32;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+8]");
		_ = 0;
		Vector3 one2 = Vector3.one;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = this + 44;
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+8]");
		_ = 0;
		base.HandleSwipe((SwipeDir)fromState);
	}

	public override void OnUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_0146: Expected Obj, but got F4
		//IL_01ae: Expected F4, but got I
		//IL_01ae: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 + 24;
		object obj3 = obj2 + 12;
		object obj4 = obj2 + 36;
		obj4 = 0;
		_ = 0;
		float returnTime = _returnTime;
		float returnTime2 = _returnTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (System.Single)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v8 (System.Single)+1C]");
		object obj5 = num / 0;
		object obj7 = default;
		object obj12 = default;
		while (true)
		{
			float returnTime3 = _returnTime;
			object obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v12 (System.Single)+24]");
			if ((nint)obj6 < 0)
			{
				float returnTime4 = _returnTime;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v15 (System.Single)+20]");
				if ((nint)obj8 > 0)
				{
					float returnTime5 = _returnTime;
					float returnTime6 = _returnTime;
					float num2 = (float)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S2_v4 (System.Single)+1C]");
					float defaultValue = num2 / 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v25 (System.Single)+2C]");
					float num3 = PlayerPrefs.GetFloat((string)0, defaultValue);
					float returnTime7 = _returnTime;
					object obj9 = _character + 248;
					obj = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v23+8]");
					_ = 0;
					object obj10 = obj7 * obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
					object obj11 = 0 + obj10;
					obj4 = 0f;
					float num4 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v29 (System.Single)+C]");
					float num5 = num4 * 0f;
					obj3 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
					_ = 0;
					obj2 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					Vector3 position = Route.GetPosition(num6, 0f);
				}
				obj7 = obj12 + 1;
				continue;
			}
			break;
		}
	}

	public override void Leave(State toState)
	{
		Character character = _character;
		character._killSwitchEnabled = false;
		_returnTime = 0f;
		_startedMovingBack = false;
		Character character2 = _character;
		Character character3 = _character;
		Character character4 = _character;
		character4._trackIndexTarget = 1;
		if (character3.__trackIndex != 1)
		{
			character3.__trackIndexPrevious = character3.__trackIndex;
			character3.__trackIndex = 1;
		}
		character2._trackIndexPosition = 1f;
		Character character5 = _character;
		character5._trackMovement = 0;
		Character character6 = _character;
		character6._trackMovementNext = 0;
		Character character7 = _character;
		character7._ignoredMovement = 0;
	}
}
