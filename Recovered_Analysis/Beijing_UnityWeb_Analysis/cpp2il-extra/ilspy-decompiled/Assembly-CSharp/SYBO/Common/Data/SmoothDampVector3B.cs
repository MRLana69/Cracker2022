using System;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Common.Managers;
using UnityEngine;

namespace SYBO.Common.Data;

[Serializable]
public class SmoothDampVector3B
{
	private Vector3 _target;

	private Vector3 _smoothTime;

	private Vector3 _value;

	private Vector3 _velocity;

	public Vector3 Target
	{
		get
		{
			//IL_0027: Invalid comparison between F4 and I4
			Vector3 result = default;
			if (result.z != 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
			}
			return result;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0028: Expected VT, but got I
			object obj = value + 8;
			SmoothDampVector3B smoothDampVector3B = (SmoothDampVector3B)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			_target = (Vector3)0;
		}
	}

	public float TargetX
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.SmoothDampVector3B)+18]");
			return 0f;
		}
		set
		{
			if (value < 0f)
			{
			}
		}
	}

	public float TargetY
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0010: Expected F4, but got Obj
			object obj = this + 8;
			return (float)obj;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected Obj, but got Unknown
			//IL_001f: Expected Obj, but got I4
			//IL_002d: Expected Obj, but got F4
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected Obj, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected Obj, but got Unknown
			object obj = this + 8;
			object obj2 = this + 8;
			object obj3 = 0;
			_ = 0;
			obj3 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ S0_v5+4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8+8]");
			_ = 0;
			object obj4 = obj3 + 12;
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = this + 8;
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v16+8]");
			_ = 0;
		}
	}

	public float TargetZ
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0018: Expected F4, but got I
			object obj = this + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			return 0f;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected Obj, but got Unknown
			//IL_001f: Expected Obj, but got I4
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected Obj, but got Unknown
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected Obj, but got Unknown
			object obj = this + 8;
			object obj2 = this + 8;
			object obj3 = 0;
			_ = 0;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8+8]");
			_ = 0;
			object obj4 = obj3 + 12;
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = this + 8;
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v16+8]");
			_ = 0;
		}
	}

	public unsafe Vector3 SmoothTime
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected VT, but got Unknown
			//IL_0027: Expected F4, but got Obj
			//IL_0022: Expected native int or pointer, but got VT
			//IL_003c: Expected F4, but got I
			//IL_0037: Expected native int or pointer, but got VT
			_ = _target;
			object obj = default;
			Vector3 vector = (Vector3)(obj + 8);
			((Vector3*)(nint)vector)->x = (float)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0028: Expected VT, but got I
			object obj = value + 20;
			SmoothDampVector3B smoothDampVector3B = (SmoothDampVector3B)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			_target = (Vector3)0;
		}
	}

	public unsafe Vector3 Value
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected VT, but got Unknown
			//IL_0027: Expected F4, but got Obj
			//IL_0022: Expected native int or pointer, but got VT
			//IL_003c: Expected F4, but got I
			//IL_0037: Expected native int or pointer, but got VT
			_ = _target;
			object obj = default;
			Vector3 vector = (Vector3)(obj + 20);
			((Vector3*)(nint)vector)->x = (float)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0028: Expected VT, but got I
			object obj = value + 32;
			SmoothDampVector3B smoothDampVector3B = (SmoothDampVector3B)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			_target = (Vector3)0;
		}
	}

	public unsafe Vector3 Velocity
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected VT, but got Unknown
			//IL_0027: Expected F4, but got Obj
			//IL_0022: Expected native int or pointer, but got VT
			//IL_003c: Expected F4, but got I
			//IL_0037: Expected native int or pointer, but got VT
			_ = _target;
			object obj = default;
			Vector3 vector = (Vector3)(obj + 32);
			((Vector3*)(nint)vector)->x = (float)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
	}

	public SmoothDampVector3B(Vector3 value, Vector3 smoothTime)
	{
		//IL_0341: Invalid comparison between F4 and I4
		//IL_001b: Expected Obj, but got I
		//IL_011a: Expected I, but got Obj
		//IL_0130: Expected Obj, but got I
		//IL_015b: Expected I, but got Obj
		//IL_0232: Expected I, but got Obj
		//IL_0248: Expected Obj, but got I
		//IL_0273: Expected I, but got Obj
		if (smoothTime.z != 7f)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [smoothTime @ L2 (UnityEngine.Vector3)+10]");
		object obj = -49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [smoothTime @ L2 (UnityEngine.Vector3)+10]");
		if ((nint)0 != 49)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						if ((nint)obj != 4)
						{
							if ((nint)obj != 5)
							{
								if ((nint)obj == 6)
								{
									((TimeScaleManager)null).TimeScaleInMenuDefault = 20f;
								}
							}
							else
							{
								float realtimeSinceStartup = Time.realtimeSinceStartup;
								float timeScaleInMenuDefault = realtimeSinceStartup / 0.9f;
								((TimeScaleManager)null).TimeScaleInMenuDefault = timeScaleInMenuDefault;
							}
							return;
						}
						float realtimeSinceStartup2 = Time.realtimeSinceStartup;
						nint num = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v30 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num2 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v35 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float num3 = realtimeSinceStartup2 * 0.9f;
						if (num3 < 0f)
						{
							num3 = 0f;
						}
						else if (num3 > 1f)
						{
							num3 = 1f;
						}
						((TimeScaleManager)null).TimeScaleInMenuDefault = num3;
					}
					else
					{
						((TimeScaleManager)null).TimeScaleInMenuDefault = 1f;
					}
				}
				else
				{
					float realtimeSinceStartup3 = Time.realtimeSinceStartup;
					float timeScaleInMenuDefault2 = realtimeSinceStartup3 + 0.1f;
					((TimeScaleManager)null).TimeScaleInMenuDefault = timeScaleInMenuDefault2;
				}
				return;
			}
			float realtimeSinceStartup4 = Time.realtimeSinceStartup;
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v16 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v21 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num6 = realtimeSinceStartup4 - 0.1f;
			if (num6 < 0f)
			{
				num6 = 0f;
			}
			else if (num6 > 1f)
			{
				num6 = 1f;
			}
			((TimeScaleManager)null).TimeScaleInMenuDefault = num6;
		}
		else
		{
			((TimeScaleManager)null).TimeScaleInMenuDefault = 0f;
		}
	}

	public void Update()
	{
		//IL_0011: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.SmoothDampVector3B)+24]");
		CoroutineUtil.StopCoroutine((Coroutine)0);
	}

	public override string ToString()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 0;
		object obj = text + 16;
		obj = this;
		return text;
	}
}
