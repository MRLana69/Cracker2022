using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using UnityEngine;

namespace Kiloo.Common.Utility;

public static class Easings
{
	public enum Functions
	{
		Linear,
		QuadraticEaseIn,
		QuadraticEaseOut,
		QuadraticEaseInOut,
		CubicEaseIn,
		CubicEaseOut,
		CubicEaseInOut,
		QuarticEaseIn,
		QuarticEaseOut,
		QuarticEaseInOut,
		QuinticEaseIn,
		QuinticEaseOut,
		QuinticEaseInOut,
		SineEaseIn,
		SineEaseOut,
		SineEaseInOut,
		CircularEaseIn,
		CircularEaseOut,
		CircularEaseInOut,
		ExponentialEaseIn,
		ExponentialEaseOut,
		ExponentialEaseInOut,
		ElasticEaseIn,
		ElasticEaseOut,
		ElasticEaseInOut,
		BackEaseIn,
		BackEaseOut,
		BackEaseInOut,
		BounceEaseIn,
		BounceEaseOut,
		BounceEaseInOut
	}

	private const float PI = (float)Math.PI;

	private const float HALFPI = (float)Math.PI / 2f;

	public unsafe static float Interpolate(float p, Functions function)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Invalid comparison between Obj and F4
		//IL_0041: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I4
		object obj = ((Functions*)(int)function)->value__;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)p))
		{
			obj = ((Functions*)(int)function)->value__;
			float analyticsSamplingKey = AnalyticsSave.analyticsSamplingKey;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			float num = 0f + analyticsSamplingKey;
			float num2 = num + 100f;
			if (num2 > p)
			{
				obj = ((Functions*)(int)function)->value__;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				float num3 = 0f + 100f;
				if (num3 > p)
				{
					obj = ((Functions*)(int)function)->value__;
					float num4 = p - (float)obj;
					float analyticsSamplingKey2 = AnalyticsSave.analyticsSamplingKey;
					return num4 / analyticsSamplingKey2;
				}
				obj = ((Functions*)(int)function)->value__;
				float num5 = p;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				float num6 = num5 - 0f;
				float analyticsSamplingKey3 = AnalyticsSave.analyticsSamplingKey;
				float num7 = num6 - analyticsSamplingKey3;
				float num8 = num7 - 100f;
				float analyticsSamplingKey4 = AnalyticsSave.analyticsSamplingKey;
				float num9 = num8 / analyticsSamplingKey4;
				return 0f - num9;
			}
			return 0f;
		}
		return 0f;
	}

	public static float Linear(float p)
	{
		return p * 8f;
	}

	public static float QuadraticEaseIn(float p)
	{
		return p;
	}

	public static float QuadraticEaseOut(float p)
	{
		return p * p;
	}

	public static float QuadraticEaseInOut(float p)
	{
		float num = p - 2f;
		float num2 = p * num;
		return 0f - num2;
	}

	public static float CubicEaseIn(float p)
	{
		if (p < 0.5f)
		{
			float num = 2f * p;
			return num * p;
		}
		float num2 = -2f * p;
		float num3 = num2 * p;
		float num4 = 4f * p;
		float num5 = num3 + num4;
		return num5 - 1f;
	}

	public static float CubicEaseOut(float p)
	{
		float num = p * p;
		return num * p;
	}

	public static float CubicEaseInOut(float p)
	{
		float num = p - 1f;
		float num2 = num * num;
		float num3 = num2 * num;
		return num3 + 1f;
	}

	public static float QuarticEaseIn(float p)
	{
		if (p < 0.5f)
		{
			float num = 4f * p;
			float num2 = num * p;
			return num2 * p;
		}
		float num3 = 2f * p;
		float num4 = num3 - 2f;
		float num5 = 0.5f * num4;
		float num6 = num5 * num4;
		float num7 = num6 * num4;
		return num7 + 1f;
	}

	public static float QuarticEaseOut(float p)
	{
		float num = p * p;
		float num2 = num * p;
		return num2 * p;
	}

	public static float QuarticEaseInOut(float p)
	{
		float num = p - 1f;
		float num2 = num * num;
		float num3 = num2 * num;
		float num4 = 1f - p;
		float num5 = num3 * num4;
		return num5 + 1f;
	}

	public static float QuinticEaseIn(float p)
	{
		if (p < 0.5f)
		{
			float num = 8f * p;
			float num2 = num * p;
			float num3 = num2 * p;
			return num3 * p;
		}
		float num4 = p - 1f;
		float num5 = -8f * num4;
		float num6 = num5 * num4;
		float num7 = num6 * num4;
		float num8 = num7 * num4;
		return num8 + 1f;
	}

	public static float QuinticEaseOut(float p)
	{
		float num = p * p;
		float num2 = num * p;
		float num3 = num2 * p;
		return num3 * p;
	}

	public static float QuinticEaseInOut(float p)
	{
		float num = p - 1f;
		float num2 = num * num;
		float num3 = num2 * num;
		float num4 = num3 * num;
		float num5 = num4 * num;
		return num5 + 1f;
	}

	public static float SineEaseIn(float p)
	{
		if (p < 0.5f)
		{
			float num = 16f * p;
			float num2 = num * p;
			float num3 = num2 * p;
			float num4 = num3 * p;
			return num4 * p;
		}
		float num5 = 2f * p;
		float num6 = num5 - 2f;
		float num7 = 0.5f * num6;
		float num8 = num7 * num6;
		float num9 = num8 * num6;
		float num10 = num9 * num6;
		float num11 = num10 * num6;
		return num11 + 1f;
	}

	public static float SineEaseOut(float p)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = p - 1f;
		float num4 = num3 * ((float)Math.PI / 2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
		object obj2 = default;
		return (float)obj2 + 1f;
	}

	public static float SineEaseInOut(float p)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = p * ((float)Math.PI / 2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
		float result = default;
		return result;
	}

	public static float CircularEaseIn(float p)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = p * (float)Math.PI;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E5");
		object obj2 = default;
		float num4 = 1f - (float)obj2;
		return 0.5f * num4;
	}

	public static float CircularEaseOut(float p)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = p * p;
		float num4 = 1f - num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		return 1f - num4;
	}

	public static float CircularEaseInOut(float p)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = 2f - p;
		float result = num3 * p;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		return result;
	}

	public static float ExponentialEaseIn(float p)
	{
		//IL_00f5: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got F4
		//IL_00a8: Expected I, but got Obj
		//IL_0037: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		float num6;
		if (p < 0.5f)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v24 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num3 = p * p;
			float num4 = 4f * num3;
			float num5 = 1f - num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			num6 = 1f - num5;
		}
		else
		{
			if (!flag)
			{
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v15 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num8 = 2f * p;
			float num9 = num8 - 3f;
			object obj2 = 0f - num9;
			float num10 = 2f * p;
			float num11 = num10 - 1f;
			float num12 = (float)obj2 * num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			num6 = num12 + 1f;
		}
		return 0.5f * num6;
	}

	public static float ExponentialEaseOut(float p)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		float num = default;
		if (num != 0f)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num3 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num4 = num - 1f;
			float num5 = 10f * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AE");
		}
		float result = default;
		return result;
	}

	public static float ExponentialEaseInOut(float p)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (p != 1f)
		{
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v16 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num3 = -10f * p;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AE");
			object obj2 = default;
			return 1f - (float)obj2;
		}
		return 1f;
	}

	public static float ElasticEaseIn(float p)
	{
		//IL_016d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0103: Expected I, but got Obj
		//IL_0092: Expected I, but got Obj
		float num = default;
		bool flag = num == 0f;
		bool flag2 = num == 1f;
		object obj = flag | flag2;
		if (obj == null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag3 = obj2 == null;
			if (num < 0.5f)
			{
				if (!flag3)
				{
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v34 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num4 = 20f * num;
				float num5 = num4 - 10f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AE");
				object obj3 = default;
				return 0.5f * (float)obj3;
			}
			if (!flag3)
			{
				nint num6 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v25 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num7 = -20f * num;
			float num8 = num7 + 10f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AE");
			object obj4 = default;
			float num9 = -0.5f * (float)obj4;
			return num9 + 1f;
		}
		float result = default;
		return result;
	}

	public static float ElasticEaseOut(float p)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = 20.420353f * p;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
		float num4 = p - 1f;
		float num5 = 10f * num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AE");
		object obj2 = default;
		object obj3 = default;
		return (float)obj2 * (float)obj3;
	}

	public static float ElasticEaseInOut(float p)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = p + 1f;
		float num4 = -20.420353f * num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
		float num5 = -10f * p;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AE");
		object obj3 = default;
		object obj4 = default;
		object obj2 = obj3 * obj4;
		return (float)obj2 + 1f;
	}

	public static float BackEaseIn(float p)
	{
		//IL_00f5: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_00a8: Expected I, but got Obj
		//IL_0037: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		if (p < 0.5f)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v28 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num3 = 2f * p;
			float num4 = 20.420353f * num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
			object obj2 = default;
			float num5 = 0.5f * (float)obj2;
			float num6 = 2f * p;
			float num7 = num6 - 1f;
			float num8 = 10f * num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AE");
			object obj3 = default;
			return num5 * (float)obj3;
		}
		if (!flag)
		{
			nint num9 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num10 = 2f * p;
		float num11 = num10 - 1f;
		float num12 = num11 + 1f;
		float num13 = -20.420353f * num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
		float num14 = 2f * p;
		float num15 = num14 - 1f;
		float num16 = -10f * num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AE");
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 * obj6;
		float num17 = (float)obj4 + 2f;
		return 0.5f * num17;
	}

	public static float BackEaseOut(float p)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = p * p;
		float num4 = num3 * p;
		float num5 = p * (float)Math.PI;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
		object obj2 = default;
		float num6 = p * (float)obj2;
		return num4 - num6;
	}

	public static float BackEaseInOut(float p)
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		float num = 1f - p;
		nint num2 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v14 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num4 = num * num;
		float num5 = num4 * num;
		float num6 = num * (float)Math.PI;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
		object obj2 = default;
		float num7 = num * (float)obj2;
		float num8 = num5 - num7;
		return 1f - num8;
	}

	public static float BounceEaseIn(float p)
	{
		//IL_00c1: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0102: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		float num = 2f * p;
		if (p < 0.5f)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v25 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num3 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v31 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num4 = num * num;
			float num5 = num4 * num;
			float num6 = num * (float)Math.PI;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
			object obj2 = default;
			float num7 = num * (float)obj2;
			float num8 = num5 - num7;
			return 0.5f * num8;
		}
		float num9 = num - 1f;
		float num10 = 1f - num9;
		nint num11 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v13 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num12 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v20 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num13 = num10 * num10;
		float num14 = num13 * num10;
		float num15 = num10 * (float)Math.PI;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
		object obj4 = default;
		float num16 = num10 * (float)obj4;
		float num17 = num14 - num16;
		float num18 = 1f - num17;
		float num19 = 0.5f * num18;
		return num19 + 0.5f;
	}

	public static float BounceEaseOut(float p)
	{
		float p2 = 1f - p;
		float num = BounceEaseInOut(p2);
		return 1f - num;
	}

	public static float BounceEaseInOut(float p)
	{
		float result;
		if (p < 372f / 1023f)
		{
			float num = 121f * p;
			float num2 = num * p;
			result = num2 * 0.0625f;
		}
		else
		{
			float num3 = 9.075f * p;
			float num4 = num3 * p;
			float num5 = 9.9f * p;
			float num6 = num4 - num5;
			result = num6 + 3.4f;
			if (!(p < 744f / 1023f))
			{
				if (p < 0.9f)
				{
					float num7 = 12.066482f * p;
					float num8 = num7 * p;
					float num9 = 19.635458f * p;
					float num10 = num8 - num9;
					result = num10 + 8.898061f;
				}
				else
				{
					float num11 = 10.8f * p;
					float num12 = num11 * p;
					float num13 = 20.52f * p;
					float num14 = num12 - num13;
					result = num14 + 10.72f;
				}
			}
		}
		return result;
	}
}
