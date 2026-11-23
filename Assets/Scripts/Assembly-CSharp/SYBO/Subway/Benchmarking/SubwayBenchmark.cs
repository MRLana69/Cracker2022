using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Common.Automation;
using SYBO.Common.Benchmarking;
using SYBO.Common.Components.Singleton;
using SYBO.Subway.Benchmarking.Processors;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Benchmarking;

public abstract class SubwayBenchmark : Benchmark
{
	private sealed class _003CReturnToHomeScreen_003Ed__7(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0038: Expected I4, but got I8
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					UIScreenController instance = UIScreenController.Instance;
					instance.GoToMainMenuFromGame(null);
					UIScreenController instance2 = UIScreenController.Instance;
					instance2.ClosePopup();
				}
				return false;
			}
			_003C_003E1__state = -1;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private int _originalScreenTimeout;

	protected int _initialSampleCount;

	protected override int InitialSampleCount => _initialSampleCount;

	public SubwayBenchmark(IAutomationStep[] steps, IBenchmarkMetric[] metrics, IMetricSampler[] samplers)
	{
		_steps = steps;
		base._metrics = metrics;
		base._samplers = samplers;
	}

	public override void Initialize()
	{
		//IL_00e1: Expected VT, but got Obj
		//IL_00ea: Expected Obj, but got VT
		base.Initialize();
		Layers instance = Layers.Instance;
		Layers instance2 = Layers.Instance;
		Physics.IgnoreLayerCollision(instance.Character, instance2.Hit, ignore: true);
		Layers instance3 = Layers.Instance;
		Layers instance4 = Layers.Instance;
		Physics.IgnoreLayerCollision(instance3.Character, instance4.Pickup, ignore: true);
		int sleepTimeout = Screen.sleepTimeout;
		_originalScreenTimeout = sleepTimeout;
		Screen.sleepTimeout = -1;
		RouteManager.UseBenchmarkRoute__BackingField = true;
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		((RouteManager)val).Reset();
		UIScreenController instance5 = UIScreenController.Instance;
		instance5.ClosePopup();
		UIScreenController instance6 = UIScreenController.Instance;
		instance6.ClosePopup();
	}

	public override void Terminate()
	{
		base.Terminate();
		UIScreenController instance = UIScreenController.Instance;
		instance.PushScreen("PauseUI");
		RouteManager.UseBenchmarkRoute__BackingField = false;
		Layers instance2 = Layers.Instance;
		Layers instance3 = Layers.Instance;
		Physics.IgnoreLayerCollision(instance2.Character, instance3.Hit, ignore: false);
		Layers instance4 = Layers.Instance;
		Layers instance5 = Layers.Instance;
		Physics.IgnoreLayerCollision(instance4.Character, instance5.Pickup, ignore: false);
		Screen.sleepTimeout = _originalScreenTimeout;
		IEnumerator coroutine = ReturnToHomeScreen();
		Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
	}

	private IEnumerator ReturnToHomeScreen()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	protected override IBenchmarkProcessor CreateProcessor()
	{
		string selectedBencharmProcessorPostfix = SubwayBenchmarkContainer.SelectedBencharmProcessorPostfix;
		GoogleSheetsProcessor googleSheetsProcessor = default;
		googleSheetsProcessor._002Ector(selectedBencharmProcessorPostfix);
		return googleSheetsProcessor;
	}
}
