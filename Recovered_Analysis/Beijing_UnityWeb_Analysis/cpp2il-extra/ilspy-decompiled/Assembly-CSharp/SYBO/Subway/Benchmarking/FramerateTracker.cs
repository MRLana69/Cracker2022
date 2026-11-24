using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Common.Utility;
using SYBO.Common;
using SYBO.Common.Benchmarking.Utility;
using SYBO.Subway.Characters;
using SYBO.Subway.Promotion;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Benchmarking;

public class FramerateTracker
{
	private const float MillisecondsToSeconds = 0.001f;

	private Stopwatch _stopWatch;

	private float _framesRendered;

	private GameObject _updater;

	private FirstMonobehaviour _first;

	private LastMonobehaviour _last;

	private float _totalScriptTime;

	private float _totalRenderTime;

	private float _totalPhysicsTime;

	private float _scriptStartTime;

	private float _renderStartTime;

	private float _physicsStartTime;

	private bool _paused;

	private bool _skipFrame;

	private bool _maxFrametimeSamplingEnabled;

	private float _maxFrameTimeSampleInterval;

	private long _lastFrameStartTicks;

	private float[] _samples;

	private int _currentSampleIndex;

	private float _currentSampleInterval;

	private float _currentSampleMaxTime;

	public long ElapsedMilliseconds
	{
		get
		{
			//IL_00c0: Expected I, but got Obj
			//IL_00d6: Expected Obj, but got I
			//IL_00fb: Expected Obj, but got VT
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected Obj, but got Unknown
			//IL_012c: Expected I, but got Obj
			//IL_0142: Expected Obj, but got I
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			TimeSpan timeLeft = ((PromotionDefinition)this).TimeLeft;
			DateTime utcNow = CDateTime.UtcNow;
			nint num = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v7 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(TimeUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v18 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = utcNow;
			string text = (string)(obj2 + 8);
			text = (string)obj2;
			long num3 = TimeUtility.RFC1123StringToUnixTime(text);
			nint num4 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S2_v8 (Il2CppClass<System.TimeSpan>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S2_v12 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = timeLeft - num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
			long result = default;
			return result;
		}
	}

	public bool IsTracking
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_updater != 0;
		}
	}

	public float MaxFrameTime => _renderStartTime;

	public FramerateTracker(float maxFrameTimeSampleRange, int maxFrametimeSampleCount)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_027b: Expected Obj, but got F4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_005e: Expected Obj, but got F4
		//IL_029c: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_01a0: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_0179: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0146: Expected Obj, but got F4
		//IL_01ee: Expected Obj, but got I
		//IL_021d: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.FramerateTracker)+DF]");
		if ((nint)0 != 0)
		{
			((CharacterRendering)this).OverrideRollTransition();
		}
		object obj = this - -64;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10+54]");
		if ((nint)0 != 0)
		{
			object obj3 = this + 236;
			string roll = ((CharacterRendering.Animations)_physicsStartTime).Roll;
			string text = ((List<string>)(object)roll).get_Item(0);
			obj3 = text;
			object obj4 = this + 240;
			string text2 = ((List<string>)(object)roll).get_Item(1);
			obj4 = text2;
		}
		else
		{
			if (maxFrameTimeSampleRange != 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.FramerateTracker)+3C]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v39+6C]");
				float num = 0f * 0.5f;
				if (!(num < maxFrameTimeSampleRange))
				{
					object obj6 = this + 236;
					string tuck = ((CharacterRendering.Animations)_physicsStartTime).Tuck;
					obj6 = tuck;
					goto IL_028c;
				}
			}
			object obj7 = this + 236;
			string smallJump = ((CharacterRendering.Animations)_physicsStartTime).SmallJump;
			obj7 = smallJump;
		}
		goto IL_028c;
		IL_028c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.FramerateTracker)+3C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v18+A1]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.FramerateTracker)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.FramerateTracker)+EC]");
			((RouteChunk)num2).HideLogicRecursive((Transform)0, 1f);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.FramerateTracker)+5C]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.FramerateTracker)+EC]");
			((RouteChunk)num3).HideLogicRecursive((Transform)0, 0.15f);
		}
		object obj9 = this - -64;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v23+54]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.FramerateTracker)+60]");
			if (((WorkLoadQueue)0).IsIdle)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.FramerateTracker)+EC]");
				bool flag = ((CharacterRendering)this).HasHoverboardAnimation((string)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.FramerateTracker)+60]");
				((RouteChunk)0).HideLogicRecursive((Transform)flag, 0.15f);
			}
		}
	}

	public void StartTracking()
	{
	}

	public unsafe void EndTracking()
	{
		//IL_0396: Expected I4, but got Obj
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		gameObject.layer = (int)"Updater";
		object obj = this + 16;
		obj = gameObject;
		object obj2 = this + 20;
		FirstMonobehaviour firstMonobehaviour = _updater.AddComponent<FirstMonobehaviour>();
		obj2 = firstMonobehaviour;
		object obj3 = this + 24;
		LastMonobehaviour lastMonobehaviour = _updater.AddComponent<LastMonobehaviour>();
		obj3 = lastMonobehaviour;
		FirstMonobehaviour first = _first;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj4 = default;
		obj4.method_ptr = method_ptr;
		obj4.method = (nint)__ldftn(FramerateTracker.FirstMonobehaviour_OnUpdate);
		object obj5 = obj4 + 16;
		obj5 = this;
		object obj6 = _first + 12;
		Delegate obj7 = ((Delegate)first.OnUpdate).CombineImpl(obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj8 = default;
		obj6 = obj8;
		FirstMonobehaviour first2 = _first;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Delegate obj9 = default;
		obj9.method_ptr = method_ptr2;
		obj9.method = (nint)__ldftn(FramerateTracker.FirstMonobehaviour_OnFixedUpdate);
		object obj10 = obj9 + 16;
		obj10 = this;
		object obj11 = _first + 20;
		Delegate obj12 = ((Delegate)first2.OnFixedUpdate).CombineImpl(obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj13 = default;
		obj11 = obj13;
		LastMonobehaviour last = _last;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Delegate obj14 = default;
		obj14.method_ptr = method_ptr3;
		obj14.method = (nint)__ldftn(FramerateTracker.LastMonobehaviour_OnLateUpdate);
		object obj15 = obj14 + 16;
		obj15 = this;
		object obj16 = _last + 16;
		Delegate obj17 = ((Delegate)last.OnLateUpdate).CombineImpl(obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj18 = default;
		obj16 = obj18;
		FirstMonobehaviour first3 = _first;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Delegate obj19 = default;
		obj19.method_ptr = method_ptr4;
		obj19.method = (nint)__ldftn(FramerateTracker.FirstMonobehaviour_OnOnGUI);
		object obj20 = obj19 + 16;
		obj20 = this;
		object obj21 = _first + 24;
		Delegate obj22 = ((Delegate)first3.OnOnGUI).CombineImpl(obj19);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj23 = default;
		obj21 = obj23;
		LastMonobehaviour last2 = _last;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr5 = 0;
		Delegate obj24 = default;
		obj24.method_ptr = method_ptr5;
		obj24.method = (nint)__ldftn(FramerateTracker.LastMonobehaviour_OnYieldFixedUpdate);
		object obj25 = obj24 + 16;
		obj25 = this;
		object obj26 = _last + 24;
		Delegate obj27 = ((Delegate)last2.OnYieldFixedUpdate).CombineImpl(obj24);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj28 = default;
		obj26 = obj28;
		FirstMonobehaviour first4 = _first;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr6 = 0;
		Delegate obj29 = default;
		obj29.method_ptr = method_ptr6;
		obj29.method = (nint)__ldftn(FramerateTracker.FirstMonobehaviour_OnOnApplicationPause);
		object obj30 = obj29 + 16;
		obj30 = this;
		object obj31 = _first + 28;
		Delegate obj32 = ((Delegate)first4.OnOnApplicationPause).CombineImpl(obj29);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj33 = default;
		obj31 = obj33;
		_paused = false;
		_stopWatch.Stop();
	}

	public void Reset()
	{
		//IL_0075: Expected I8, but got I4
		//IL_0097: Expected I, but got Obj
		//IL_00ad: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		((ArrayConverter)(object)_stopWatch)._002Ector();
		Stopwatch stopWatch = _stopWatch;
		stopWatch.elapsed = 0L;
		stopWatch.is_running = false;
		FirstMonobehaviour_OnFixedUpdate();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate(_updater);
	}

	private void ResetFrameTimes()
	{
		//IL_0023: Expected I8, but got I4
		((ArrayConverter)(object)_stopWatch)._002Ector();
		Stopwatch stopWatch = _stopWatch;
		stopWatch.elapsed = 0L;
		stopWatch.is_running = false;
		FirstMonobehaviour_OnFixedUpdate();
		_paused = false;
		_stopWatch.Stop();
	}

	public void TogglePause(bool paused)
	{
		//IL_004e: Expected Obj, but got I4
		bool flag;
		if (paused)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [paused @ L1 (System.Boolean)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (!flag)
		{
			_stopWatch = (Stopwatch)1;
		}
	}

	public unsafe float GetFramerate()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		float num3;
		if (~(_maxFrametimeSamplingEnabled ? 1u : 0u) == 0)
		{
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v11 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			num3 = ((Vector2*)_samples)->magnitude;
			if (!(num3 > _currentSampleMaxTime))
			{
				num3 = _currentSampleMaxTime;
			}
		}
		else
		{
			num3 = 0f;
		}
		return num3;
	}

	public float GetPotentialFramerate()
	{
		long elapsedTicks = _stopWatch.ElapsedTicks;
		float num = (float)elapsedTicks * 0.001f;
		return _framesRendered / num;
	}

	private void FirstMonobehaviour_OnOnApplicationPause(bool paused)
	{
		_paused = paused;
		_skipFrame = true;
		_scriptStartTime = 0f;
		_renderStartTime = 0f;
		_physicsStartTime = 0f;
		if (_paused)
		{
			((ArrayConverter)(object)_stopWatch)._002Ector();
		}
		else
		{
			_stopWatch.Stop();
		}
	}

	private void FirstMonobehaviour_OnFixedUpdate()
	{
		_framesRendered = 0f;
		_totalScriptTime = 0f;
		_totalRenderTime = 0f;
		_totalPhysicsTime = 0f;
		_scriptStartTime = 0f;
		_renderStartTime = 0f;
		_physicsStartTime = 0f;
	}

	private void LastMonobehaviour_OnYieldFixedUpdate()
	{
		//IL_003d: Expected F4, but got I8
		if (~(_paused ? 1u : 0u) != 0)
		{
			long elapsedTicks = _stopWatch.ElapsedTicks;
			_physicsStartTime = elapsedTicks;
		}
	}

	private void FirstMonobehaviour_OnOnGUI()
	{
		if (~(_paused ? 1u : 0u) != 0 && _physicsStartTime > 0f)
		{
			long elapsedTicks = _stopWatch.ElapsedTicks;
			float num = (float)elapsedTicks - _physicsStartTime;
			float totalPhysicsTime = _totalPhysicsTime + num;
			_totalPhysicsTime = totalPhysicsTime;
			_physicsStartTime = 0f;
		}
	}

	private void LastMonobehaviour_OnLateUpdate()
	{
		if (~(_paused ? 1u : 0u) != 0 && _renderStartTime > 0f)
		{
			long elapsedTicks = _stopWatch.ElapsedTicks;
			float num = (float)elapsedTicks - _renderStartTime;
			float totalRenderTime = _totalRenderTime + num;
			_totalRenderTime = totalRenderTime;
			_renderStartTime = 0f;
		}
	}

	private void FirstMonobehaviour_OnUpdate()
	{
		//IL_00b3: Expected F4, but got I8
		if (~(_paused ? 1u : 0u) != 0)
		{
			if (_scriptStartTime > 0f)
			{
				long elapsedTicks = _stopWatch.ElapsedTicks;
				float num = (float)elapsedTicks - _scriptStartTime;
				float totalScriptTime = _totalScriptTime + num;
				_totalScriptTime = totalScriptTime;
				_scriptStartTime = 0f;
			}
			long elapsedTicks2 = _stopWatch.ElapsedTicks;
			_renderStartTime = elapsedTicks2;
		}
	}
}
