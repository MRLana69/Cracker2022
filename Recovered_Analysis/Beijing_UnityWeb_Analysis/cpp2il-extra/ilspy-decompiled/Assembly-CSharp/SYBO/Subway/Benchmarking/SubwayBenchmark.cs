using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Automation;
using SYBO.Common.Benchmarking;
using SYBO.Components.Utilities;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using SYBO.Subway.Inputs;
using SYBO.Subway.Routes;
using UnityEngine;
using UnityEngine.Networking;

namespace SYBO.Subway.Benchmarking;

public abstract class SubwayBenchmark : Benchmark
{
	private sealed class _003CReturnToHomeScreen_003Ed__7(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0048: Expected Obj, but got I4
				//IL_005c: Expected Obj, but got I4
				//IL_007a: Expected I, but got Obj
				//IL_0090: Expected Obj, but got I
				//IL_014e: Expected Obj, but got I4
				//IL_0103: Expected Obj, but got I4
				//IL_00bb: Expected I, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						nint num = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v24 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag = UIScreenController.ShouldShowOnlineScreen();
						((UIScreenController)flag).PayoutCelebrationReward(null);
						bool flag2 = UIScreenController.ShouldShowOnlineScreen();
						((UIScreenController)flag2).DebugCloseAllPopups();
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj2 = this + 12;
				obj2 = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
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

	private int _originalScreenTimeout;

	protected int _initialSampleCount;

	protected override int InitialSampleCount
	{
		get
		{
			IAutomationStep[] steps = _steps;
			return (steps[2] != null) ? 1 : 0;
		}
	}

	public unsafe SubwayBenchmark(IAutomationStep[] steps, IBenchmarkMetric[] metrics, IMetricSampler[] samplers)
	{
		//IL_036c: Expected I4, but got Obj
		//IL_037d: Expected Obj, but got I
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got I
		//IL_0078: Expected F4, but got I
		//IL_0078: Expected Obj, but got I
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_03d0: Expected Obj, but got I
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected Obj, but got Unknown
		//IL_0411: Expected Obj, but got I
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_044a: Expected Obj, but got I
		//IL_046d: Expected I, but got Obj
		//IL_0483: Expected Obj, but got I
		//IL_00c7: Expected I, but got Obj
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected VT, but got Unknown
		//IL_04dc: Expected F4, but got Obj
		//IL_04d7: Expected native int or pointer, but got VT
		//IL_04f1: Expected F4, but got I
		//IL_04ec: Expected native int or pointer, but got VT
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_0529: Expected VT, but got Obj
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected Obj, but got Unknown
		//IL_0551: Expected Obj, but got I
		//IL_057d: Expected F4, but got Obj
		//IL_0578: Expected native int or pointer, but got VT
		//IL_0592: Expected F4, but got I
		//IL_058d: Expected native int or pointer, but got VT
		//IL_05c0: Expected Obj, but got VT
		//IL_0114: Expected I, but got Obj
		//IL_012a: Expected Obj, but got I
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_0218: Expected Obj, but got I
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I
		//IL_0273: Expected F4, but got Obj
		//IL_026e: Expected native int or pointer, but got VT
		//IL_0288: Expected F4, but got I
		//IL_0283: Expected native int or pointer, but got VT
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02c0: Expected VT, but got Obj
		//IL_02da: Expected Obj, but got I
		//IL_01a2: Expected I, but got Obj
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected Obj, but got Unknown
		//IL_030b: Expected F4, but got Obj
		//IL_0306: Expected native int or pointer, but got VT
		//IL_0320: Expected F4, but got I
		//IL_031b: Expected native int or pointer, but got VT
		//IL_034e: Expected Obj, but got VT
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_0155: Expected I, but got Obj
		((CharacterCamera)(object)this).CameraSpeedType = (CameraSpeedType)steps;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.SubwayBenchmark)+6C]");
		GameObject gameObject = ((Component)0).gameObject;
		object obj = default;
		Transform transform = (Transform)(obj + 112);
		transform = (Transform)(object)metrics;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [metrics @ L2 (SYBO.Common.Benchmarking.IBenchmarkMetric[])+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.SubwayBenchmark)+6C]");
		GameObject gameObject2 = ((Component)0).gameObject;
		transform = (Transform)(object)samplers;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [samplers @ L3 (SYBO.Common.Benchmarking.IMetricSampler[])+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		IAutomationStep automationStep = steps[0];
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.SubwayBenchmark)+6C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v14 (SYBO.Common.Automation.IAutomationStep)+8]");
		((Camera)num).orthographicSize = 0f;
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v112 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.SubwayBenchmark)+90]");
		if ((UnityEngine.Object)0 != null)
		{
			nint num4 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v82 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(Character);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v88 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = this + 144;
			CharacterRendering instance = CharacterRendering.Instance;
			obj4 = instance;
		}
		object obj5 = obj + 84;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.SubwayBenchmark)+90]");
		object obj6 = (nint)0 + (nint)248;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v26+8]");
		_ = 0;
		object obj7 = obj + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.SubwayBenchmark)+38]");
		object obj8 = (nint)0 + (nint)20;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v33+8]");
		_ = 0;
		nint num6 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v28 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v77 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj + 96);
		((Vector3*)(nint)vector)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v22+8]");
		((Vector3*)(nint)vector)->z = 0f;
		transform = (Transform)obj7;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v25+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		object obj10 = obj + 60;
		Vector3 vector2 = vector - (Vector3)transform;
		object obj11 = obj + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.SubwayBenchmark)+38]");
		object obj12 = (nint)0 + (nint)32;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v52+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((Vector3*)(nint)vector)->x = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v38+8]");
		((Vector3*)(nint)vector)->z = 0f;
		transform = (Transform)obj11;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v40+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Game game = default;
		game.InputManager_OnInputEvent((object)vector, (InputEventArgs)(object)transform);
		object obj13 = this + 112;
		obj13 = game;
		object obj14 = obj + 36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.SubwayBenchmark)+90]");
		object obj15 = (nint)0 + (nint)248;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S1_v70+8]");
		_ = 0;
		object obj16 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.SubwayBenchmark)+38]");
		object obj17 = (nint)0 + (nint)44;
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v77+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v53+8]");
		((Vector3*)(nint)vector)->z = 0f;
		transform = (Transform)obj16;
		Transform transform6 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v56+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		object obj18 = obj + 12;
		Vector3 vector3 = vector - (Vector3)transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.SubwayBenchmark)+38]");
		object obj19 = (nint)0 + (nint)56;
		obj = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S1_v93+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((Vector3*)(nint)vector)->x = (float)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v63+8]");
		((Vector3*)(nint)vector)->z = 0f;
		transform = (Transform)obj;
		Transform transform7 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
		Game game2 = default;
		game2.InputManager_OnInputEvent((object)vector, (InputEventArgs)(object)transform);
		object obj20 = this + 140;
		obj20 = game2;
	}

	public override void Initialize()
	{
	}

	public override void Terminate()
	{
		//IL_01e7: Expected I, but got Obj
		//IL_01fd: Expected Obj, but got I
		//IL_024e: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I
		//IL_024e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_00ad: Expected VT, but got I4
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_0266: Expected VT, but got Obj
		//IL_026f: Expected Obj, but got VT
		//IL_0149: Expected I, but got Obj
		//IL_015f: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_0286: Expected Obj, but got I4
		//IL_01d2: Expected Obj, but got I4
		//IL_018a: Expected I, but got Obj
		base.Terminate();
		nint num = (nint)typeof(Layers);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<Layers>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v45 (Il2CppClass<Layers>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool startupFinished = LoadLevelCtrl.StartupFinished;
		bool startupFinished2 = LoadLevelCtrl.StartupFinished;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12 (System.Boolean)+14]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v5 (System.Boolean)+C]");
		((UnityWebRequest)num3)._002Ector((string)0, (string)1);
		bool startupFinished3 = LoadLevelCtrl.StartupFinished;
		bool startupFinished4 = LoadLevelCtrl.StartupFinished;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v15 (System.Boolean)+14]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v8 (System.Boolean)+1C]");
		((UnityWebRequest)num4)._002Ector((string)0, (string)1);
		int pixelLightCount = QualitySettings.pixelLightCount;
		_originalScreenTimeout = pixelLightCount;
		GL.Color((Color)(-1));
		nint num5 = (nint)typeof(RouteManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v20 (Il2CppClass<SYBO.Subway.Routes.RouteManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num6 = (nint)typeof(RouteManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v41 (Il2CppClass<SYBO.Subway.Routes.RouteManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @810D");
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		((RouteManager)val).Update();
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v29 (Il2CppClass<UIScreenController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v37 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).DebugCloseAllPopups();
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).DebugCloseAllPopups();
	}

	private IEnumerator ReturnToHomeScreen()
	{
		//IL_0007: Expected Obj, but got I4
		return (IEnumerator)_initialSampleCount;
	}

	protected override IBenchmarkProcessor CreateProcessor()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IBenchmarkProcessor result = default;
		return result;
	}
}
