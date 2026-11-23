using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters.States;
using SYBO.Subway.Routes.Prototypes;
using UnityEngine;

public class SpeedStripes : MonoBehaviour, IRouteEffectGUIListener
{
	private float _fadeInTime = 0.5f;

	private Color _originalColor;

	private Renderer[] _renderers;

	private Material _OriginalMaterial;

	private Material _material;

	private IRouteEffectGUISubject _subject;

	private Color[] _colorSteps;

	private int _gearActivationThreshold = 1;

	private int _gearSteps;

	private Animator _animator;

	private readonly int id_Active = Animator.StringToHash("Active");

	private bool _isActive;

	private Vector3 _originalScale;

	private GameObject _scalingParent;

	private unsafe void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_026c: Expected VT, but got I
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected VT, but got Unknown
		//IL_0518: Expected I, but got Obj
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected VT, but got Unknown
		//IL_0592: Expected I, but got Obj
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected VT, but got Unknown
		//IL_05f3: Expected Obj, but got I4
		//IL_0354: Expected Obj, but got I
		//IL_039f: Expected Obj, but got I
		//IL_03d2: Expected Obj, but got I
		//IL_0405: Expected Obj, but got I
		//IL_0463: Expected Obj, but got I
		//IL_04b6: Expected Obj, but got I
		//IL_0606: Expected I, but got Obj
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Expected VT, but got Unknown
		//IL_068c: Expected Obj, but got I
		//IL_06a5: Expected F4, but got I
		//IL_06a0: Expected native int or pointer, but got VT
		//IL_06ba: Expected F4, but got I
		//IL_06b5: Expected native int or pointer, but got VT
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 192);
		_ = 0;
		_ = 0;
		JetpackState instance = JetpackState.Instance;
		JetpackState.OnStartDelegate onStartDelegate = default;
		onStartDelegate._002Ector(this, (nint)__ldftn(SpeedStripes.OnStartJetpack));
		Delegate obj2 = Delegate.Combine(instance.OnStart, onStartDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		JetpackState.OnStartDelegate onStart = default;
		instance.OnStart = onStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		JetpackState instance2 = JetpackState.Instance;
		JetpackState.OnStopDelegate onStopDelegate = default;
		onStopDelegate._002Ector(this, (nint)__ldftn(SpeedStripes.OnStopJetpack));
		Delegate obj3 = Delegate.Combine(instance2.OnStop, onStopDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		JetpackState.OnStopDelegate onStop = default;
		instance2.OnStop = onStop;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Hoverboard instance3 = Hoverboard.Instance;
		Hoverboard.OnSpeedStartDelegate onSpeedStartDelegate = default;
		onSpeedStartDelegate._002Ector(this, (nint)__ldftn(SpeedStripes.OnSpeederBoardStart));
		instance3.OnSpeedStart += onSpeedStartDelegate;
		Hoverboard instance4 = Hoverboard.Instance;
		Hoverboard.OnSpeedEndDelegate onSpeedEndDelegate = default;
		onSpeedEndDelegate._002Ector(this, (nint)__ldftn(SpeedStripes.OnSpeederBoardStop));
		instance4.OnSpeedEnd += onSpeedEndDelegate;
		PogoStickState instance5 = PogoStickState.Instance;
		PogoStickState.OnStartDelegate onStartDelegate2 = default;
		onStartDelegate2._002Ector(this, (nint)__ldftn(SpeedStripes.OnPogoStart));
		Delegate obj4 = Delegate.Combine(instance5.OnStart, onStartDelegate2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		PogoStickState.OnStartDelegate onStart2 = default;
		instance5.OnStart = onStart2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		PogoStickState instance6 = PogoStickState.Instance;
		PogoStickState.OnStopDelegate onStopDelegate2 = default;
		onStopDelegate2._002Ector(this, (nint)__ldftn(SpeedStripes.OnPogoStop));
		Delegate obj5 = Delegate.Combine(instance6.OnStop, onStopDelegate2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		PogoStickState.OnStopDelegate onStop2 = default;
		instance6.OnStop = onStop2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Game instance7 = Game.Instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(SpeedStripes.Reset));
		instance7.OnStageMenuSequence += action;
		Material material = default;
		material._002Ector(_OriginalMaterial);
		_material = material;
		Color color = _material.GetColor("_MainColor");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_originalColor = (Color)0;
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		_ = 0;
		_ = 0;
		Color value = (Color)(vector - -64);
		_material.SetColor("_MainColor", value);
		Animator component = GetComponent<Animator>();
		_animator = component;
		GameObject gameObject = default;
		gameObject._002Ector("SpeedStripesScalingParent");
		_scalingParent = gameObject;
		Transform transform = _scalingParent.transform;
		Transform parent = base.transform;
		transform.parent = parent;
		Transform transform2 = _scalingParent.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v100 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v101 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Vector3 localPosition = vector + 48;
		transform2.localPosition = localPosition;
		Transform transform3 = _scalingParent.transform;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v116 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S0_v117 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(vector + 32);
		transform3.localRotation = localRotation;
		object obj6 = 0;
		while (true)
		{
			Renderer[] renderers = _renderers;
			if (renderers.Length > (nint)obj6)
			{
				object obj7 = obj6 << 2;
				object obj8 = (object)renderers + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S0_v133+10]");
				GameObject gameObject2 = ((Component)0).gameObject;
				gameObject2.SetActive(value: true);
				object obj9 = obj6 << 2;
				object obj10 = (object)_renderers + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ S0_v138+10]");
				((Renderer)0).material = _material;
				object obj11 = obj6 << 2;
				object obj12 = (object)_renderers + obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S0_v142+10]");
				((Renderer)0).enabled = false;
				object obj13 = obj6 << 2;
				object obj14 = (object)_renderers + obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ S1_v99+10]");
				Transform transform4 = ((Component)0).transform;
				Vector3 localScale = transform4.localScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				_ = 0;
				object obj15 = obj6 << 2;
				object obj16 = (object)_renderers + obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S0_v150+10]");
				Transform transform5 = ((Component)0).transform;
				Transform parent2 = _scalingParent.transform;
				transform5.parent = parent2;
				object obj17 = obj6 << 2;
				object obj18 = (object)_renderers + obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v155+10]");
				Transform transform6 = ((Component)0).transform;
				nint num5 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S0_v163 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ S0_v164 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				_ = 0;
				_ = Vector3.zeroVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				_ = 0;
				Vector3 localPosition2 = vector + 16;
				transform6.localPosition = localPosition2;
				object obj19 = obj6 << 2;
				object obj20 = (object)_renderers + obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ S0_v173+10]");
				Transform transform7 = ((Component)0).transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
				((Vector3*)(nint)vector)->x = 0f;
				transform7.localScale = vector;
				object obj21 = obj6 + 1;
				obj6 = obj21;
				continue;
			}
			break;
		}
	}

	private unsafe void LateUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00bf: Expected F4, but got I
		//IL_00ba: Expected native int or pointer, but got VT
		//IL_00de: Expected F4, but got I
		//IL_00d9: Expected native int or pointer, but got VT
		//IL_00f9: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		if (~(_isActive ? 1u : 0u) != 0)
		{
			return;
		}
		CharacterCamera instance = CharacterCamera.Instance;
		float fieldOfView = instance._camera.fieldOfView;
		Transform transform = _scalingParent.transform;
		float num = fieldOfView / 68f;
		float num2 = (float)_originalScale * num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpeedStripes)+4C]");
		float num3 = 0f * num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpeedStripes)+50]");
		float num4 = 0f * num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform.localScale = vector;
		object obj2 = 0;
		while (true)
		{
			Renderer[] renderers = _renderers;
			if ((nint)obj2 < renderers.Length)
			{
				object obj3 = obj2 << 2;
				object obj4 = (object)renderers + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v33+10]");
				((Renderer)0).enabled = true;
				object obj5 = obj2 + 1;
				obj2 = obj5;
				continue;
			}
			break;
		}
	}

	public unsafe virtual void Initialize(IRouteEffectGUISubject subject)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_subject = subject;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(SpeedStripes.HandleOnEnteredTallyScreen));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		throw new ArgumentException();
	}

	public unsafe virtual void DeInitialize()
	{
		if (_subject != null)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(SpeedStripes.HandleOnEnteredTallyScreen));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			throw new ArgumentException();
		}
		HandleOnEnteredTallyScreen();
	}

	private void HandleOnEnteredSkatePark()
	{
	}

	private unsafe void HandleOnEnteredTallyScreen()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0021: Expected native int or pointer, but got VT
		//IL_0035: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 32);
		_ = 4575657221408423936L;
		((Color*)(nint)color)->b = 0f;
		_ = 0;
		((Color*)(nint)color)->r = 0f;
		Deactivate(4.2f, color);
	}

	private unsafe void HandleOnGearChanged(int gear)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0022: Expected Obj, but got I4
		//IL_0141: Expected F4, but got I
		//IL_013c: Expected native int or pointer, but got VT
		//IL_0163: Expected F4, but got I
		//IL_015e: Expected native int or pointer, but got VT
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected VT, but got Unknown
		//IL_0067: Expected Obj, but got I4
		object obj = default;
		Color color = (Color)(obj + -64);
		if (gear <= _gearActivationThreshold)
		{
			return;
		}
		object obj2 = gear - _gearActivationThreshold;
		object obj3 = default;
		if ((nint)obj2 >= 1)
		{
			Color[] colorSteps = _colorSteps;
			obj3 = colorSteps.Length - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				obj3 = obj2;
			}
		}
		Color color2 = _material.GetColor("_MainColor");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
		_ = 0;
		object obj4 = obj3 << 4;
		object obj5 = (object)_colorSteps + obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v19+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v19+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+28]");
		((Color*)(nint)color)->b = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
		((Color*)(nint)color)->r = 0f;
		Color currentColor = color + 16;
		Activate(0.4f, currentColor, color);
	}

	private unsafe void OnSpeederBoardStart()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0084: Expected F4, but got I
		//IL_007f: Expected native int or pointer, but got VT
		//IL_0093: Expected F4, but got VT
		//IL_008e: Expected native int or pointer, but got VT
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected VT, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 48);
		JetpackState instance = JetpackState.Instance;
		if (~(instance.isActive ? 1u : 0u) == 0)
		{
			JetpackState instance2 = JetpackState.Instance;
			if (instance2._isHeadStart)
			{
				return;
			}
		}
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpeedStripes)+18]");
		((Color*)(nint)color)->b = 0f;
		((Color*)(nint)color)->r = (float)_originalColor;
		Color currentColor = color + 16;
		Activate(_fadeInTime, currentColor, color);
	}

	private unsafe void OnSpeederBoardStop()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0059: Expected native int or pointer, but got VT
		//IL_006d: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 32);
		PogoStickState instance = PogoStickState.Instance;
		if (!instance.isActive)
		{
			JetpackState instance2 = JetpackState.Instance;
			if (!instance2.isActive)
			{
				_ = 4575657221408423936L;
				((Color*)(nint)color)->b = 0f;
				_ = 0;
				((Color*)(nint)color)->r = 0f;
				Deactivate(_fadeInTime, color);
			}
		}
	}

	private unsafe void OnPogoStart()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00ac: Expected native int or pointer, but got VT
		//IL_00c0: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 32);
		Hoverboard instance = Hoverboard.Instance;
		if (~(instance.isActive ? 1u : 0u) == 0)
		{
			Hoverboard instance2 = Hoverboard.Instance;
			if (instance2.isHighSpeedBoard)
			{
				goto IL_0099;
			}
		}
		Hoverboard instance3 = Hoverboard.Instance;
		if (~(instance3.isActive ? 1u : 0u) == 0)
		{
			Hoverboard instance4 = Hoverboard.Instance;
			if (~(instance4.isSpeedBoard ? 1u : 0u) == 0)
			{
				goto IL_0099;
			}
			return;
		}
		return;
		IL_0099:
		_ = 4575657221408423936L;
		((Color*)(nint)color)->b = 0f;
		_ = 0;
		((Color*)(nint)color)->r = 0f;
		Deactivate(0.1f, color);
	}

	private unsafe void OnPogoStop()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00ce: Expected F4, but got I
		//IL_00c9: Expected native int or pointer, but got VT
		//IL_00dd: Expected F4, but got VT
		//IL_00d8: Expected native int or pointer, but got VT
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected VT, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 48);
		Hoverboard instance = Hoverboard.Instance;
		if (~(instance.isActive ? 1u : 0u) == 0)
		{
			Hoverboard instance2 = Hoverboard.Instance;
			if (instance2.isHighSpeedBoard)
			{
				goto IL_0099;
			}
		}
		Hoverboard instance3 = Hoverboard.Instance;
		if (~(instance3.isActive ? 1u : 0u) == 0)
		{
			Hoverboard instance4 = Hoverboard.Instance;
			if (~(instance4.isSpeedBoard ? 1u : 0u) == 0)
			{
				goto IL_0099;
			}
			return;
		}
		return;
		IL_0099:
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpeedStripes)+18]");
		((Color*)(nint)color)->b = 0f;
		((Color*)(nint)color)->r = (float)_originalColor;
		Color currentColor = color + 16;
		Activate(0.1f, currentColor, color);
	}

	private unsafe void OnStartJetpack(bool isHeadstart)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected VT, but got Unknown
		//IL_012c: Expected F4, but got I
		//IL_0127: Expected native int or pointer, but got VT
		//IL_013b: Expected F4, but got VT
		//IL_0136: Expected native int or pointer, but got VT
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected VT, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 80);
		if (!isHeadstart)
		{
			_ = 4575657221408423936L;
			_ = 4575657221408423936L;
			_ = 0;
			_ = 0;
			Color colorTarget = color + 32;
			Deactivate(_fadeInTime, colorTarget);
			return;
		}
		Hoverboard instance = Hoverboard.Instance;
		if (~(instance.isActive ? 1u : 0u) == 0)
		{
			Hoverboard instance2 = Hoverboard.Instance;
			if (instance2.isHighSpeedBoard)
			{
				return;
			}
		}
		Hoverboard instance3 = Hoverboard.Instance;
		if (~(instance3.isActive ? 1u : 0u) == 0)
		{
			Hoverboard instance4 = Hoverboard.Instance;
			if (instance4.isSpeedBoard)
			{
				return;
			}
		}
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpeedStripes)+18]");
		((Color*)(nint)color)->b = 0f;
		((Color*)(nint)color)->r = (float)_originalColor;
		Color currentColor = color + 16;
		Activate(_fadeInTime, currentColor, color);
	}

	private unsafe void OnStopJetpack(bool isHeadstart)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00bc: Expected native int or pointer, but got VT
		//IL_00d0: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 32);
		if (!isHeadstart)
		{
			return;
		}
		Hoverboard instance = Hoverboard.Instance;
		if (~(instance.isActive ? 1u : 0u) == 0)
		{
			Hoverboard instance2 = Hoverboard.Instance;
			if (instance2.isHighSpeedBoard)
			{
				return;
			}
		}
		Hoverboard instance3 = Hoverboard.Instance;
		if (~(instance3.isActive ? 1u : 0u) == 0)
		{
			Hoverboard instance4 = Hoverboard.Instance;
			if (instance4.isSpeedBoard)
			{
				return;
			}
		}
		_ = 4575657221408423936L;
		((Color*)(nint)color)->b = 0f;
		_ = 0;
		((Color*)(nint)color)->r = 0f;
		Deactivate(_fadeInTime, color);
	}

	private void Activate(float time, Color currentColor, Color colorTargetColor)
	{
		//IL_0113: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		_ = currentColor.b;
		_ = currentColor.r;
		_ = colorTargetColor.r;
		_ = colorTargetColor.b;
		_isActive = true;
		object obj = 0;
		while (true)
		{
			Renderer[] renderers = _renderers;
			if (renderers.Length <= (nint)obj)
			{
				break;
			}
			object obj2 = obj << 2;
			object obj3 = (object)renderers + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v32+10]");
			((Renderer)0).enabled = true;
			object obj4 = obj + 1;
			obj = obj4;
		}
		if (!_animator.GetBool(id_Active))
		{
			_animator.SetBool(id_Active, value: true);
		}
		throw new ArgumentException();
	}

	private void Deactivate(float time, Color colorTarget)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = colorTarget.b;
		_ = colorTarget.r;
		_isActive = false;
		Color color = _material.GetColor("_MainColor");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		throw new ArgumentException();
	}

	private unsafe void Reset()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00be: Expected F4, but got I
		//IL_00b9: Expected native int or pointer, but got VT
		//IL_00d9: Expected F4, but got I
		//IL_00d4: Expected native int or pointer, but got VT
		//IL_0026: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 32);
		_isActive = false;
		_animator.SetBool(id_Active, value: false);
		StopAllCoroutines();
		_ = 4575657221408423936L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+18]");
		((Color*)(nint)color)->b = 0f;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+10]");
		((Color*)(nint)color)->r = 0f;
		_material.SetColor("_MainColor", color);
		Renderer[] renderers = _renderers;
		object obj2 = 0;
		while (renderers.Length > (nint)obj2)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)renderers + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v28+10]");
			((Renderer)0).enabled = false;
			object obj5 = obj2 + 1;
			obj2 = obj5;
		}
	}

	public SpeedStripes()
	{
		//IL_0014: Expected I4, but got I8
		//IL_004a: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		_ = 0;
		_originalScale = Vector3.oneVector;
		base._002Ector();
	}
}
