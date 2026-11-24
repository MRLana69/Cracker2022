using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Ionic.Zlib;
using SYBO.Components.Analytics;
using UnityEngine;

namespace Kiloo.Common.HTTP.Internal;

internal static class Hosts
{
	private class HostData
	{
		public DateTime backOffUntil;

		public double lastBackOffDuration;

		public HostData()
		{
			//IL_0016: Expected Obj, but got I
			//IL_0030: Expected Obj, but got I
			//IL_004a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.HTTP.Internal.Hosts+HostData)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.HTTP.Internal.Hosts+HostData)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.HTTP.Internal.Hosts+HostData)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		}
	}

	private static readonly Dictionary<string, HostData> _hostData;

	public static void BackOff(string host, double minTime, double maxTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public static void BackOff(string host, double seconds)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public static void BackOff(string host, DateTime until)
	{
		//IL_0027: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector();
		((ZlibStream)(object)ex).SetLength(0L);
	}

	public static void DontBackOff(string host)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string message = string.ConcatArray((string[])(object)"[Connection] ", (int)host);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(message);
	}

	public static double GetBackOffSeconds(string host)
	{
		bool flag = ((SyboRandom)(object)host).Bool();
		return (double)(flag ? 1 : 0) / 4294967295.0;
	}

	private static void Log(string msg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		//IL_0344: Expected Obj, but got I4
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_035b: Expected Obj, but got I4
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got Unknown
		//IL_0385: Expected I, but got Obj
		//IL_039b: Expected Obj, but got I
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected Obj, but got Unknown
		//IL_047c: Expected Obj, but got I4
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_0440: Expected Obj, but got I4
		//IL_0152: Expected I, but got Obj
		//IL_0168: Expected Obj, but got I
		//IL_044e: Expected Obj, but got VT
		//IL_0193: Expected I, but got Obj
		//IL_0283: Expected Obj, but got I
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 28;
		obj3 = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(Hosts);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Hosts);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v106 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj2 + 8;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		nint num3 = (nint)typeof(Hosts);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v70 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(Hosts);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v97 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj9 = default;
		if (obj9 != null)
		{
			object obj10 = obj4;
			_ = 0.0;
			object obj11 = obj4;
			nint num5 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v48 (Il2CppClass<System.DateTime>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num6 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S1_v56 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj2 = DateTime.MinValue;
			obj7 = obj2;
		}
		object obj13 = obj5 + 4;
		object obj14 = obj13 + 1;
		obj13 = obj14;
		object obj15 = obj14 << 2;
		object obj16 = obj5 + obj15;
		obj16 = 69;
		if (obj3 != null)
		{
			throw new ArgumentNullException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj5 + obj17;
			if ((nint)obj18 == 69)
			{
				object obj19 = obj5 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				return;
			}
		}
		object obj21 = default;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	static Hosts()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		List<Connection> idleConnections = default;
		Connection._idleConnections = idleConnections;
	}
}
