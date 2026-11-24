using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Routes.Log;

[Serializable]
public class RoutesLogData
{
	private float _timeStamp;

	private RoutesLogType _routesLogType;

	private object[] _args;

	protected string _message;

	public float TimeStamp
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Log.RoutesLogData)+70]");
			return 0f;
		}
	}

	public RoutesLogType RoutesLogType
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0368: Expected Obj, but got I
			//IL_0378: Expected Obj, but got I
			//IL_0388: Expected Obj, but got I
			//IL_0391: Unknown result type (might be due to invalid IL or missing references)
			//IL_0396: Expected Obj, but got Unknown
			//IL_039f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a4: Expected Obj, but got Unknown
			//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ca: Expected Obj, but got Unknown
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d8: Expected Obj, but got Unknown
			//IL_0404: Expected Obj, but got I4
			//IL_004d: Expected I, but got Obj
			//IL_0063: Expected Obj, but got I
			//IL_027f: Expected Obj, but got I
			//IL_008e: Expected I, but got Obj
			//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ba: Expected Obj, but got Unknown
			//IL_00fa: Expected Obj, but got I
			//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Expected Obj, but got Unknown
			//IL_013b: Expected I, but got Obj
			//IL_0151: Expected Obj, but got I
			//IL_017c: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v7 (Il2CppMethodInfo)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v8+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v9+C]");
			object obj5 = 0;
			object obj6 = obj5 & 0x3FFF;
			object obj7 = obj6 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S2_v4 (should have been resolved before IL gen)");
			RoutesLogType routesLogType = (RoutesLogType)int.MaxValue;
			object obj8 = default;
			object obj10 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj8 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v78 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v110 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj10 == null)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v72+10]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v87+20]");
				RoutesLogType routesLogType2 = (RoutesLogType)((nint)0 * (nint)90);
				if (routesLogType != RoutesLogType.NONE)
				{
					nint num4 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v94 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num5 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v103 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					if (routesLogType < routesLogType2)
					{
						routesLogType2 = routesLogType;
					}
				}
				routesLogType = routesLogType2;
			}
			object obj13 = obj2 + 4;
			object obj14 = obj13 + 1;
			obj13 = obj14;
			object obj15 = obj14 << 2;
			object obj16 = obj2 + obj15;
			obj16 = 90;
			object obj17 = default;
			if (obj17 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj18 = (nint)0 << 2;
				object obj19 = obj2 + obj18;
				if ((nint)obj19 == 90)
				{
					object obj20 = obj2 + 4;
					if ((nint)obj20 > -1)
					{
						object obj21 = obj20 + -1;
						obj20 = obj21;
					}
					goto IL_0487;
				}
			}
			object obj22 = default;
			if (obj22 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_0487;
			IL_0487:
			if (routesLogType == (RoutesLogType)int.MaxValue)
			{
				return RoutesLogType.NONE;
			}
			return routesLogType;
		}
	}

	public object[] Args
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (object[])_routesLogType;
		}
	}

	public string Message => (string)(object)_args;

	public RoutesLogData(RoutesLogType pickupLogType, object[] args)
	{
		((WeightRandomizedPrefabContainter<, >)this).set_Item((int)pickupLogType, (TWeighted)(object)args);
	}

	public override string ToString()
	{
		return _message;
	}
}
