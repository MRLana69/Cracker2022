using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Common.Visuals;
using SYBO.Subway;
using SYBO.Subway.Level;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Common.Data;

public class ScoreMultiplier
{
	public class ValueChangedEventArgs : EventArgs
	{
		private float _newValue;

		private float _oldValue;

		public float NewValue
		{
			get
			{
				//IL_000d: Expected F4, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.ScoreMultiplier+ValueChangedEventArgs)+10]");
				return 0f;
			}
		}

		public float OldValue => _newValue;

		public ValueChangedEventArgs(float newValue, float oldValue)
		{
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			_oldValue = newValue;
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v7 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float f = oldValue + 0.5f;
			int num3 = Mathf.RoundToInt(f);
		}
	}

	private sealed class _003CCoolDownCoroutine_003Ed__29(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public ScoreMultiplier _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c4: Expected Obj, but got Unknown
				//IL_00e0: Expected Obj, but got I4
				//IL_0079: Expected Obj, but got I4
				ScoreMultiplier scoreMultiplier = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
					if (scoreMultiplier._multiplierArray != null)
					{
						ValueChangedEventArgs valueChangedEventArgs = (ValueChangedEventArgs)(scoreMultiplier._multiplierArrayIndex - 1);
						scoreMultiplier.RaiseOnValueChanged(valueChangedEventArgs);
					}
				}
				else
				{
					_003C_003E1__state = -1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				float num = scoreMultiplier._coolDownDurationMS / 1000f;
				object obj = this + 12;
				object obj2 = default;
				obj = obj2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_001b: Expected Obj, but got I
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected Obj, but got Unknown
			if (_003C_003E2__current != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S2_v2 (Il2CppMethodInfo)+18]");
				object obj = 0;
				object obj2 = obj;
				object obj3 = obj2 & 0x3FFF;
				object obj4 = obj3 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v30 @ S3_v5 (should have been resolved before IL gen)");
			}
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

	private EventHandler<ValueChangedEventArgs> m_OnValueChanged;

	private float[] _multiplierArray;

	private int _multiplierArrayIndex;

	private float _coolDownDurationMS;

	private float _minimumPositiveScoreDeltaToIncreaseMultiplier;

	private int _originalMultiplierArrayIndex;

	private float _scoreDeltaSinceLastIncreaseToMultiplier;

	private IEnumerator _coolDownCoroutine;

	public float[] MultiplierArray
	{
		get
		{
			//IL_0007: Expected Obj, but got F4
			return (float[])_coolDownDurationMS;
		}
	}

	public int MultiplierArrayIndex
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)_multiplierArray;
		}
		private set
		{
			//IL_0066: Expected Obj, but got I4
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnValueChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
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

	public float CoolDownDurationMS
	{
		get
		{
			//IL_0007: Expected F4, but got Obj
			return (float)_multiplierArray;
		}
		set
		{
			//IL_0029: Expected I4, but got F4
			//IL_0041: Expected Obj, but got I4
			//IL_004a: Expected Obj, but got F4
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			_multiplierArrayIndex = (int)value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			EnvironmentSequence environmentSequence = default;
			object obj = environmentSequence + 16;
			obj = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			RouteChunk routeChunk = default;
			routeChunk.CreateEnvironmentLogic(EnvironmentType.None, environmentSequence, 1f);
			object obj2 = this + 20;
			obj2 = routeChunk;
			Reset();
		}
	}

	public float Value => _coolDownDurationMS;

	public float MinimumPositiveScoreDeltaToIncreaseMultiplier
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected Obj, but got Unknown
			//IL_0032: Expected F4, but got Obj
			object obj = _multiplierArray + 16;
			int num = _multiplierArrayIndex << 2;
			object obj2 = obj + num;
			return (float)obj2;
		}
		set
		{
			if (!(value < 0f))
			{
				_coolDownDurationMS = value;
			}
		}
	}

	public event EventHandler<ValueChangedEventArgs> OnValueChanged
	{
		add
		{
			if (this.m_OnValueChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnValueChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
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

	public unsafe ScoreMultiplier(int multiplierArrayIndex, float[] multiplierArray, float minimumPositiveScoreDeltaToIncreaseMultiplier = 1f)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected VT, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected VT, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_005e: Expected Obj, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I4
		//IL_02fe: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0142: Expected I, but got Obj
		//IL_0158: Expected Obj, but got I
		//IL_021d: Expected F4, but got Obj
		//IL_0218: Expected native int or pointer, but got VT
		//IL_0232: Expected F4, but got I
		//IL_022d: Expected native int or pointer, but got VT
		//IL_023f: Expected F4, but got Obj
		//IL_023a: Expected native int or pointer, but got VT
		//IL_0254: Expected F4, but got I
		//IL_024f: Expected native int or pointer, but got VT
		//IL_0276: Expected F4, but got Obj
		//IL_0271: Expected native int or pointer, but got VT
		//IL_028b: Expected F4, but got I
		//IL_0286: Expected native int or pointer, but got VT
		//IL_02a1: Expected Obj, but got I
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02c9: Expected Obj, but got F4
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_0183: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.ScoreMultiplier)+34]");
		if ((nint)0 == 0)
		{
			((MeshMorpher)this).OnDestroy();
		}
		object obj = default;
		Vector3 vector = (Vector3)(obj + 48);
		Vector3 vector2 = (Vector3)(obj + 36);
		object obj2 = obj + 24;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.ScoreMultiplier)+34]");
		object obj4 = (nint)0 + (nint)16;
		int num = multiplierArrayIndex << 2;
		object obj5 = obj4 + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.ScoreMultiplier)+34]");
		object obj6 = (nint)0 + (nint)16;
		object obj7 = (object)multiplierArray << 2;
		object obj8 = obj6 + obj7;
		object obj9 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.ScoreMultiplier)+30]");
			object obj10 = 0;
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v16+C]");
			if ((nint)obj11 >= 0)
			{
				break;
			}
			object obj12 = obj5 + 16;
			object obj13 = obj9 * 12;
			object obj14 = obj12 + obj13;
			obj2 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S2_v7+8]");
			_ = 0;
			object obj15 = obj8 + 16;
			object obj16 = obj9 * 12;
			object obj17 = obj15 + obj16;
			obj3 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S2_v13+8]");
			_ = 0;
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v25 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num3 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v44 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj3;
			Vector3 vector3 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			Vector3 vector4 = Vector3.LerpUnclamped(vector2, vector, minimumPositiveScoreDeltaToIncreaseMultiplier);
			((Vector3*)(nint)vector)->x = (float)obj;
			Vector3 vector5 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.ScoreMultiplier)+30]");
			object obj19 = (nint)0 + (nint)16;
			object obj20 = obj9 * 12;
			object obj21 = obj19 + obj20;
			obj21 = vector.x;
			_ = vector.z;
			object obj22 = obj9 + 1;
			obj9 = obj22;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.ScoreMultiplier)+2C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.ScoreMultiplier)+30]");
		((Mesh)num4).normals = (Vector3[])0;
	}

	public void Reset()
	{
		//IL_000b: Expected Obj, but got F4
		//IL_0017: Expected F4, but got I4
		((ScoreMultiplier)_coolDownDurationMS).RestartCoolDownCoroutine();
		float num = ((Game)this).EvaluatePlayerDistanceTravelTime((float)_multiplierArrayIndex);
	}

	public float NotifyScoreWasChanged(Score score, float delta)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0212: Expected I4, but got Obj
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_00c8: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		object obj3 = ((List<object>)this).get_Item((int)score);
		object obj4;
		if (obj3 == null)
		{
			obj4 = null;
		}
		else
		{
			obj4 = (((object)obj3.GetType() != typeof(float)) ? null : obj3);
		}
		if (obj4 != null)
		{
			throw new NullReferenceException();
		}
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v23 (Il2CppClass<System.Convert>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v73 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj7 = default;
		object obj6 = obj7;
		object obj9 = default;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj10 = default;
		if (obj8 == obj10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj12 = default;
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj14 = default;
			object obj13 = obj14;
		}
		else
		{
			object obj13 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		float result = default;
		return result;
	}

	private void RestartCoolDownCoroutine()
	{
		//IL_000c: Expected Obj, but got I4
		RaiseOnValueChanged((ValueChangedEventArgs)_originalMultiplierArrayIndex);
		_scoreDeltaSinceLastIncreaseToMultiplier = 0f;
		StopCoolDownCoroutine();
	}

	private void StopCoolDownCoroutine()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		((SmoothDampVector3B)this).Update();
		object obj = this + 36;
		string text = ((SmoothDampVector3B)this).ToString();
		obj = text;
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)_coolDownCoroutine);
	}

	private IEnumerator CoolDownCoroutine()
	{
		//IL_0007: Expected Obj, but got I4
		return (IEnumerator)_multiplierArrayIndex;
	}

	private void RaiseOnValueChanged(ValueChangedEventArgs valueChangedEventArgs)
	{
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_0143: Expected I, but got Obj
		//IL_0159: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0180: Expected I4, but got Obj
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		object obj = _multiplierArray + 16;
		int num = _multiplierArrayIndex << 2;
		object obj2 = obj + num;
		object obj3 = obj2;
		float[] multiplierArray = _multiplierArray;
		nint num2 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v9 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v34 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ValueChangedEventArgs e = (ValueChangedEventArgs)(multiplierArray.Length - 1);
		ValueChangedEventArgs e2;
		if ((nint)valueChangedEventArgs < 0)
		{
			e2 = null;
		}
		else
		{
			e2 = ((System.Runtime.CompilerServices.Unsafe.As<ValueChangedEventArgs, UIntPtr>(ref valueChangedEventArgs) <= System.Runtime.CompilerServices.Unsafe.As<ValueChangedEventArgs, UIntPtr>(ref e)) ? valueChangedEventArgs : e);
		}
		_multiplierArrayIndex = (int)e2;
		object obj5 = _multiplierArray + 16;
		int num4 = _multiplierArrayIndex << 2;
		object obj6 = obj5 + num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D9D0");
		object obj7 = default;
		if (obj7 == null)
		{
			object obj8 = _multiplierArray + 16;
			int num5 = _multiplierArrayIndex << 2;
			object obj9 = obj8 + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94DA");
			SmoothDampVector3B smoothDampVector3B = default;
			Vector3 target = smoothDampVector3B.Target;
		}
	}
}
