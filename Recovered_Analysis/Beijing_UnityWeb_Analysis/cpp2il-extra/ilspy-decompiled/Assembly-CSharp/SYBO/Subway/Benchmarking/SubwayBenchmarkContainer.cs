using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Common.Benchmarking;
using SYBO.Subway.Cameras;
using SYBO.Subway.Pickups.Pickers;
using SYBO.Subway.Routes;
using UnityEngine;
using UnityEngine.Networking;

namespace SYBO.Subway.Benchmarking;

public static class SubwayBenchmarkContainer
{
	private class BenchmarkWrapper
	{
		public string BenchmarkName;

		public SubwayBenchmark Benchmark;

		public string ProcessorSheetNamePostfix;

		public BenchmarkWrapper()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BenchmarkWrapper, string> _003C_003E9__6_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			PickerCollection._003C_003Ec obj = default;
			PickerCollection._003C_003Ec._003C_003E9 = obj;
		}

		internal string _003Cget_BenchmarkNames_003Eb__6_0(BenchmarkWrapper bw)
		{
			//IL_0018: Expected I4, but got Obj
			int index = UnityEngine.Random.RandomRangeInt(0, (int)bw.Benchmark);
			return ((List<string>)(object)bw).get_Item(index);
		}
	}

	private static readonly List<BenchmarkWrapper> Benchmarks;

	private static int SelectedBenchmarkIndex__BackingField;

	public unsafe static int SelectedBenchmarkIndex
	{
		get
		{
			//IL_0188: Expected I, but got Obj
			//IL_019e: Expected Obj, but got I
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ad: Expected I, but got Unknown
			//IL_02d1: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_01d6: Expected I, but got Obj
			//IL_01f1: Expected I, but got Obj
			//IL_0207: Expected Obj, but got I
			//IL_0249: Expected I, but got Obj
			//IL_025f: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_029a: Expected I4, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_013b: Expected I, but got Obj
			nint num = (nint)typeof(CharacterCamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterCamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v55 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			nint num3 = (nint)(obj2 + 4);
			bool flag = (object)CharacterCamera.instance == null;
			bool flag2 = !flag;
			int result = (int)CharacterCamera.instance;
			if (!flag2)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v25 (Il2CppClass<System.Type>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num5 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v51 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = typeof(CharacterCamera);
				((IntPtr*)num3)->m_value = (void*)(nint)obj2;
				Type type = Type.internal_from_handle((IntPtr)num3);
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = ((UnityEngine.Object)(object)type).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				nint num8 = (nint)typeof(CharacterCamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v36 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num9 = (nint)typeof(CharacterCamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v45 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CharacterCamera characterCamera = default;
				CharacterCamera.instance = characterCamera;
				IEnumerator enumerator = characterCamera.FOVTarget_Coroutine();
				result = (int)characterCamera;
			}
			return result;
		}
		private set
		{
			//IL_015d: Expected Obj, but got I4
			//IL_016b: Expected I, but got Obj
			//IL_0181: Expected Obj, but got I
			//IL_01b5: Expected Obj, but got I4
			//IL_01c3: Expected I, but got Obj
			//IL_01d9: Expected Obj, but got I
			//IL_020e: Expected I, but got Obj
			//IL_0224: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0271: Expected Obj, but got I
			//IL_0271: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_0121: Expected Obj, but got I
			//IL_0121: Expected Obj, but got I
			//IL_0132: Expected VT, but got I
			Benchmark.Processor = (IBenchmarkProcessor)value;
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v43 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).SwitchScreen("PauseUI");
			nint num3 = (nint)typeof(RouteManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v14 (Il2CppClass<SYBO.Subway.Routes.RouteManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(RouteManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v39 (Il2CppClass<SYBO.Subway.Routes.RouteManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @810D");
			nint num5 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v20 (Il2CppClass<Layers>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Layers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v35 (Il2CppClass<Layers>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool startupFinished = LoadLevelCtrl.StartupFinished;
			bool startupFinished2 = LoadLevelCtrl.StartupFinished;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v25 (System.Boolean)+14]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v10 (System.Boolean)+C]");
			((UnityWebRequest)num7)._002Ector((string)0, null);
			bool startupFinished3 = LoadLevelCtrl.StartupFinished;
			bool startupFinished4 = LoadLevelCtrl.StartupFinished;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (System.Boolean)+14]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v13 (System.Boolean)+1C]");
			((UnityWebRequest)num8)._002Ector((string)0, null);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Int32)+20]");
			GL.Color((Color)0);
			IBenchmarkProcessor list = ((SubwayBenchmark)null).CreateProcessor();
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
		}
	}

	public static List<string> BenchmarkNames
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SubwayBenchmarkContainer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SubwayBenchmarkContainer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (List<string>)SelectedBenchmarkIndex__BackingField;
		}
	}

	public static string SelectedBenchmarkName
	{
		get
		{
			//IL_013b: Expected I, but got Obj
			//IL_0151: Expected Obj, but got I
			//IL_01e4: Expected I, but got Obj
			//IL_01fa: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0229: Expected Obj, but got I4
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			//IL_01ab: Expected I, but got Obj
			//IL_01c1: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			nint num = (nint)typeof(SubwayBenchmarkContainer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SubwayBenchmarkContainer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v41 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = _003C_003Ec._003C_003E9__6_0 == null;
			bool flag2 = !flag;
			Predicate<_00210> match = (Predicate<_00210>)(object)_003C_003Ec._003C_003E9__6_0;
			if (!flag2)
			{
				nint num5 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v15 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer+<>c>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v35 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num7 = 0;
				_ = 0;
				Predicate<_00210> predicate = default;
				object obj4 = predicate + 16;
				obj4 = _003C_003Ec._003C_003E9;
				nint num8 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v32 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer+<>c>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				obj5 = predicate;
				match = predicate;
			}
			return (string)((List<T>)(object)Benchmarks).Exists((Predicate<T>)(object)match);
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009c: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SubwayBenchmarkContainer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SubwayBenchmarkContainer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SelectedBenchmarkIndex__BackingField = (int)value;
		}
	}

	public static SubwayBenchmark SelectedBenchmark
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SubwayBenchmarkContainer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SubwayBenchmarkContainer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @868D");
			int index = default;
			BenchmarkWrapper benchmarkWrapper = Benchmarks.get_Item(index);
			return (SubwayBenchmark)(object)benchmarkWrapper.BenchmarkName;
		}
	}

	public static string SelectedBencharmProcessorPostfix
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SubwayBenchmarkContainer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SubwayBenchmarkContainer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @868D");
			int index = default;
			BenchmarkWrapper benchmarkWrapper = Benchmarks.get_Item(index);
			return (string)(object)benchmarkWrapper.Benchmark;
		}
	}
}
