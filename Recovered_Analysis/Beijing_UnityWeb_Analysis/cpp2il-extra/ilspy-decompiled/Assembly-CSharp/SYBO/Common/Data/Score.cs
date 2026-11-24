using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using SYBO.Common.Benchmarking;
using SYBO.Common.Utilities;
using SYBO.Subway.Visuals;
using UnityEngine;

namespace SYBO.Common.Data;

public class Score
{
	public class ValueChangedEventArgs : EventArgs
	{
		private float _newValue;

		private float _oldValue;

		private float _deltaValue;

		public float NewValue
		{
			get
			{
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0014: Expected Obj, but got Unknown
				float unscaledDeltaTime = Time.unscaledDeltaTime;
				object obj = this - -64;
				return unscaledDeltaTime - (float)obj;
			}
		}

		public float OldValue => _newValue;

		public float DeltaValue => _oldValue;

		public ValueChangedEventArgs(float newValue, float oldValue, float deltaValue)
		{
			((UIRect)(object)this).SetRect(0f, 0.5f, 1f, newValue);
		}
	}

	private EventHandler<ValueChangedEventArgs> m_OnValueChanged;

	private float _value;

	private float _originalValue;

	private ScoreMultiplier _scoreMultiplier;

	public float Value
	{
		get
		{
			//IL_0007: Expected F4, but got Obj
			return (float)_scoreMultiplier;
		}
		private set
		{
			//IL_00e3: Expected Obj, but got F4
			//IL_00f1: Expected I, but got Obj
			//IL_0107: Expected Obj, but got I
			//IL_019d: Invalid comparison between Obj and F4
			//IL_0013: Expected I, but got Obj
			//IL_012e: Expected Obj, but got F4
			//IL_013a: Invalid comparison between Obj and F4
			//IL_005c: Expected F4, but got Obj
			//IL_0163: Expected Obj, but got F4
			//IL_007a: Expected F4, but got Obj
			//IL_00c4: Expected F4, but got Obj
			//IL_00c4: Expected F4, but got Obj
			_scoreMultiplier = (ScoreMultiplier)value;
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v31 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num3 = ((System.Runtime.CompilerServices.Unsafe.As<ScoreMultiplier, UIntPtr>(ref _scoreMultiplier) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)_originalValue)) ? _originalValue : ((float)_scoreMultiplier));
			_scoreMultiplier = (ScoreMultiplier)num3;
			float num4 = ((System.Runtime.CompilerServices.Unsafe.As<ScoreMultiplier, UIntPtr>(ref _scoreMultiplier) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)_value)) ? _value : ((float)_scoreMultiplier));
			_scoreMultiplier = (ScoreMultiplier)num4;
			if (_scoreMultiplier != _scoreMultiplier)
			{
				float maxFrameTime = (float)_scoreMultiplier - (float)_scoreMultiplier;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				FPSReportEntry fPSReportEntry = default;
				fPSReportEntry._002Ector((float)_scoreMultiplier, (float)_scoreMultiplier, maxFrameTime);
				OnValueChanged += (EventHandler<ValueChangedEventArgs>)(object)fPSReportEntry;
			}
		}
	}

	public ScoreMultiplier ScoreMultiplier
	{
		get
		{
			//IL_00ef: Invalid comparison between Obj and F4
			//IL_001b: Invalid comparison between Obj and F4
			//IL_0126: Expected Obj, but got I
			//IL_0148: Expected Obj, but got I4
			//IL_0046: Expected Obj, but got I4
			//IL_006f: Expected Obj, but got I
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected Obj, but got Unknown
			//IL_00de: Expected Obj, but got I4
			ScoreMultiplier result;
			if (System.Runtime.CompilerServices.Unsafe.As<ScoreMultiplier, UIntPtr>(ref _scoreMultiplier) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)_value))
			{
				result = null;
			}
			else if (System.Runtime.CompilerServices.Unsafe.As<ScoreMultiplier, UIntPtr>(ref _scoreMultiplier) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)_originalValue))
			{
				result = (ScoreMultiplier)4;
			}
			else
			{
				int num = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.Score)+18]");
					object obj = 0;
					int num2 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S2_v4+C]");
					bool flag = (nint)num2 >= (nint)0;
					result = (ScoreMultiplier)3;
					if (flag)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.Score)+18]");
					object obj2 = (nint)0 + (nint)16;
					int num3 = num << 2;
					object obj3 = obj2 + num3;
					ScoreMultiplier scoreMultiplier = _scoreMultiplier;
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<ScoreMultiplier, UIntPtr>(ref scoreMultiplier) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
					int num4 = num + 1;
					bool flag3 = !flag2;
					num = num4;
					if (!flag3)
					{
						Gate gate = EnumUtility.ConvertIndexToEnumValue<Gate>(num4);
						result = (ScoreMultiplier)gate;
						break;
					}
				}
			}
			return result;
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

	public unsafe Score(float originalValue)
	{
		//IL_003d: Expected native int or pointer, but got VT
		//IL_004c: Expected Obj, but got VT
		_value = originalValue;
		float b = _value - originalValue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Color color = default;
		*(Color*)(nint)color = new Color(_value, originalValue, b);
		((ScoreMultiplier)this).OnValueChanged += (EventHandler<ScoreMultiplier.ValueChangedEventArgs>)color;
	}

	public Score(float originalValue, ScoreMultiplier scoreMultiplier)
	{
		//IL_000e: Expected I4, but got Obj
		RoofedCulling.CullingBlock routine = ((RoofedCulling)null).GenerateCullingBlock(originalValue, (byte)(int)scoreMultiplier != 0);
		Coroutine coroutine = ((MonoBehaviour)this).StartCoroutine_Auto((IEnumerator)routine);
	}

	public void Reset()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public unsafe float ValueChangeBy(float baseScoreDelta)
	{
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_0166: Expected Obj, but got I4
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01a0: Expected Obj, but got I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected VT, but got Unknown
		//IL_01f3: Expected F4, but got Obj
		//IL_01ee: Expected native int or pointer, but got VT
		//IL_0202: Expected F4, but got Obj
		//IL_01fd: Expected native int or pointer, but got VT
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00cf: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected VT, but got Unknown
		//IL_0241: Expected F4, but got Obj
		//IL_023c: Expected native int or pointer, but got VT
		//IL_0256: Expected F4, but got I
		//IL_0251: Expected native int or pointer, but got VT
		//IL_0263: Expected F4, but got Obj
		//IL_025e: Expected native int or pointer, but got VT
		//IL_0278: Expected F4, but got I
		//IL_0273: Expected native int or pointer, but got VT
		//IL_0110: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 108;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 96;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 84;
		obj4 = 0;
		_ = 0;
		Camera current = Camera.current;
		object obj5 = obj2 + 72;
		Vector2 mouseScrollDelta = Input.mouseScrollDelta;
		obj = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+8]");
		_ = 0;
		Vector3 vector = (Vector3)(obj2 + 132);
		((Vector3*)(nint)vector)->x = (float)this;
		((Vector3*)(nint)vector)->z = (float)this.m_OnValueChanged;
		object obj6 = obj2 + 60;
		Vector3 vector2 = current.WorldToViewportPoint(vector);
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v27+8]");
		_ = 0;
		object obj7 = obj2 + 48;
		obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v27+8]");
		_ = 0;
		object obj8 = obj2 + 36;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v36+4]");
		_ = 0;
		_ = 0f;
		object obj9 = obj2 + 24;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj10 = obj2 + 12;
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v50 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v65 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector3 = (Vector3)(obj2 + 120);
		((Vector3*)(nint)vector3)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v44+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v47+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Quaternion quaternion = Quaternion.FromToRotation(vector3, vector);
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
		object obj12 = default;
		return (float)obj12 - baseScoreDelta;
	}

	private float ValueChangeTo(float newBaseScore)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		ScoreMultiplier scoreMultiplier = _scoreMultiplier;
		object obj = scoreMultiplier._multiplierArray + 16;
		int num = scoreMultiplier._multiplierArrayIndex << 2;
		object obj2 = obj + num;
		float value = ((OnlineSettings)(object)_scoreMultiplier).GetValue((string)null, newBaseScore);
		float num2 = newBaseScore * (float)obj2;
		float originalValue = _value + num2;
		this._002Ector(originalValue);
		return _value;
	}

	private void RaiseOnValueChanged(ValueChangedEventArgs valueChangedEventArgs)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_OnValueChanged;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)valueChangedEventArgs);
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
