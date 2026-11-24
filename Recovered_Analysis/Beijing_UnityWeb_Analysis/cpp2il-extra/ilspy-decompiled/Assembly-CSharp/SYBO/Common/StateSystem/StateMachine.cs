using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Components.Analytics;
using SYBO.Components.Logging;
using UnityEngine;

namespace SYBO.Common.StateSystem;

public class StateMachine
{
	private class Trigger(int id)
	{
		public readonly int Id = id;

		public Action<Trigger> OnTriggered;

		public void Set()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private class Transition
	{
		public readonly State From;

		public readonly State To;

		public readonly Trigger Trigger;

		public Transition(State from, State to, Trigger trigger)
		{
			//IL_059d: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a2: Expected Obj, but got Unknown
			//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b0: Expected Obj, but got Unknown
			//IL_008c: Expected I, but got Obj
			//IL_00a2: Expected Obj, but got I
			//IL_060b: Expected Obj, but got I
			//IL_05e2: Expected Obj, but got I
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Expected Obj, but got Unknown
			//IL_00cd: Expected I, but got Obj
			//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b3: Expected Obj, but got Unknown
			//IL_01cd: Expected Obj, but got I
			//IL_0407: Expected I, but got Obj
			//IL_041d: Expected Obj, but got I
			//IL_0219: Expected I, but got Obj
			//IL_022f: Expected Obj, but got I
			//IL_067d: Expected Obj, but got I
			//IL_03f4: Expected Obj, but got I
			//IL_0644: Expected Obj, but got I
			//IL_0448: Expected I, but got Obj
			//IL_025a: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 8;
			object obj3 = obj2 + 4;
			if (from != null)
			{
				if ((nint)from == 200)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.StateSystem.StateMachine+Transition)+14]");
					((Action<ProcessAnalyticsEventsResponse>)0)(ProcessAnalyticsEventsResponse.AcceptedByServer);
					return;
				}
				object obj4 = from + -400;
				if ((nint)obj4 <= 99)
				{
					nint num = (nint)typeof(Log);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v66 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num2 = (nint)typeof(Log);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v75 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					State state = From;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S2_v70 (SYBO.Common.StateSystem.State)+C]");
					obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					throw new ArrayTypeMismatchException();
				}
				object obj6 = from + -500;
				if ((nint)obj6 <= 99)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.StateSystem.StateMachine+Transition)+14]");
					((Action<ProcessAnalyticsEventsResponse>)0)(ProcessAnalyticsEventsResponse.BackendUnavailable);
					return;
				}
				nint num3 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v48 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num4 = (nint)typeof(Log);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v57 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				State state2 = From;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S2_v33 (SYBO.Common.StateSystem.State)+C]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				throw new ArrayTypeMismatchException();
			}
			ProcessAnalyticsEventsResponse obj8;
			if ((string)(object)trigger != string.Empty)
			{
				obj8 = ProcessAnalyticsEventsResponse.BackendUnavailable;
			}
			else
			{
				if (!((string)(object)trigger).EndsWith("SSL"))
				{
					nint num5 = (nint)typeof(Log);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v21 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num6 = (nint)typeof(Log);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v29 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					State state3 = From;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S2_v8 (SYBO.Common.StateSystem.State)+C]");
					obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					throw new ArrayTypeMismatchException();
				}
				obj8 = ProcessAnalyticsEventsResponse.BackendUnavailable;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.StateSystem.StateMachine+Transition)+14]");
			((Action<ProcessAnalyticsEventsResponse>)0)(obj8);
		}
	}

	private State _currentState;

	private bool _initialStateEntered;

	private Dictionary<int, State> _states;

	private List<Transition> _transitions;

	private Dictionary<int, Trigger> _triggers;

	public StateMachine(IScheduler scheduler)
	{
	}

	public void EnterInitialState(int id)
	{
		//IL_013b: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I
		//IL_0048: Expected Obj, but got I
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 16;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj8 = this + 20;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S3_v7 (Il2CppMethodInfo)+C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S3_v8+60]");
		object obj11 = 0;
		object obj12 = obj11;
		object obj13 = obj12 & 0x1FFF;
		object obj14 = obj13 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v62 @ S4_v8 (should have been resolved before IL gen)");
		object obj15 = this + 24;
		object obj16 = default;
		obj15 = obj16;
		if (id != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			object obj18 = default;
			object obj17 = obj18 + 16;
			obj17 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num4 = 0;
			_ = 0;
			object obj20 = default;
			object obj19 = obj20 + 16;
			obj19 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		}
	}

	public void AddState(State state)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		if (~(_initialStateEntered ? 1u : 0u) != 0)
		{
			object obj = this + 8;
			ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
			obj = ex;
			if (_currentState != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				_initialStateEntered = true;
			}
		}
	}

	public T GetState<T>(int id) where T : State
	{
		//IL_0006: Expected Obj, but got I4
		return (T)1;
	}

	public bool IsCurrentState<T>() where T : State
	{
		//IL_0058: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00b7: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_01a4: Expected Obj, but got I
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0235: Expected Obj, but got I
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0276: Expected Obj, but got I4
		//IL_0288: Expected Obj, but got I4
		//IL_0187: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I4
		Dictionary<int, State> states = _states;
		object obj;
		if (_currentState != null)
		{
			if ((nint)_currentState == 1)
			{
				_currentState = (State)(-1);
				obj = 6;
			}
			else
			{
				obj = 8;
			}
		}
		else
		{
			_currentState = (State)(-1);
			_transitions = null;
			obj = 7;
		}
		object obj2 = obj;
		nint num = default;
		object obj8 = default;
		bool result = default;
		object obj13 = default;
		object obj20 = default;
		while (true)
		{
			if ((nint)obj2 == 6)
			{
				List<Transition> transitions = (List<Transition>)(_transitions + 1);
				_transitions = transitions;
				obj2 = 7;
				List<Transition> list = (List<Transition>)1;
			}
			else if ((nint)obj2 == 7)
			{
				object obj3 = num + 12;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S2_v5+60]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S2_v6+8]");
				List<Transition> list = (List<Transition>)0;
				object obj6 = list & 0x3FFF;
				object obj7 = obj6 + 6161;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S3_v6 (should have been resolved before IL gen)");
				List<Transition> transitions2 = _transitions;
				if (System.Runtime.CompilerServices.Unsafe.As<List<Transition>, UIntPtr>(ref transitions2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
				{
					result = false;
					obj2 = 8;
					continue;
				}
				object obj9 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S2_v9+60]");
				object obj10 = 0;
				list = (List<Transition>)obj10;
				object obj11 = list & 0x1FFF;
				object obj12 = obj11 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41 @ S3_v10 (should have been resolved before IL gen)");
				if (obj13 == null)
				{
					obj2 = 6;
					continue;
				}
				object obj14 = this + 12;
				list = _transitions;
				object obj15 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S3_v12+60]");
				object obj16 = 0;
				object obj17 = obj16;
				object obj18 = obj17 & 0x1FFF;
				object obj19 = obj18 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S4_v9 (should have been resolved before IL gen)");
				obj14 = obj20;
				_currentState = (State)1;
				result = true;
				obj2 = 8;
			}
			else if ((nint)obj2 == 8)
			{
				break;
			}
		}
		return result;
	}

	public T TryGetCurrentState<T>() where T : State
	{
		//IL_0010: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj2 = default;
		bool flag = obj2 != null;
		return (T)flag;
	}

	public void ActivateTrigger(int id)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S4_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S4_v4+48]");
		object obj3 = 0;
		object obj4 = obj3 & 0x7FF;
		object obj5 = obj4 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v30 @ S5_v4 (should have been resolved before IL gen)");
	}

	private Trigger GetOrAddTrigger(int id)
	{
		_0021_00210[] componentsInParent = (_0021_00210[])(object)((GameObject)this).GetComponentsInParent<T>((byte)id != 0);
		return (Trigger)(object)MeshUtil.CombineMeshes((GameObject)(object)this, (IList<ObjectModelInfo>)(object)componentsInParent);
	}

	private void AddTransition(State from, State to, Trigger trigger)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_001d: Expected I4, but got Obj
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = from;
		_initialStateEntered = (byte)(int)to != 0;
		object obj2 = this + 16;
		obj2 = trigger;
	}

	public unsafe void AddTransition(int fromId, int toId, int triggerId)
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_012f: Expected Obj, but got I4
		//IL_014f: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00ae: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = fromId;
		object obj3 = obj2 + 12;
		obj3 = toId;
		object obj4 = obj2 + 16;
		obj4 = triggerId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S2_v10 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v11+60]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v12+44]");
		object obj7 = 0;
		object obj8 = obj7 & 0x1FFF;
		object obj9 = obj8 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51 @ S3_v4 (should have been resolved before IL gen)");
		object obj10 = default;
		if ((nint)obj10 <= -1)
		{
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S4_v5 (Il2CppMethodInfo)+C]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S4_v6+60]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S4_v7+48]");
			object obj13 = 0;
			object obj14 = obj13 & 0x7FF;
			object obj15 = obj14 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v73 @ S5_v5 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Delegate obj16 = default;
			obj16.method_ptr = method_ptr;
			obj16.method = (nint)__ldftn(StateMachine.Trigger_OnTriggered);
			object obj17 = obj16 + 16;
			obj17 = this;
			object obj18 = triggerId + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [triggerId @ L3 (System.Int32)+C]");
			Delegate obj19 = ((Delegate)0).CombineImpl(obj16);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj20 = default;
			obj18 = obj20;
		}
	}

	private void Trigger_OnTriggered(Trigger trigger)
	{
		//IL_0092: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_0014: Expected I4, but got Obj
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			Trigger trigger2 = _triggers.get_Item((int)trigger);
			((IDisposable)trigger2).Dispose();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}

	private void OnUpdate()
	{
	}

	private void OnLateUpdate()
	{
		if (~(_initialStateEntered ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}
}
