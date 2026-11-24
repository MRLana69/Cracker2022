using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.StateSystem;
using SYBO.Subway;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Cameras;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Prototypes;
using SYBO.Subway.StateSystem;
using SYBO.Subway.StateSystem.States;
using UnityEngine;
using UnityEngine.Rendering;

public class SpeedStripes : MonoBehaviour, IRouteEffectGUIListener
{
	private float _fadeInTime;

	private Color _originalColor;

	private Renderer[] _renderers;

	private Material _OriginalMaterial;

	private Material _material;

	private IRouteEffectGUISubject _subject;

	private Color[] _colorSteps;

	private int _gearActivationThreshold;

	private int _gearSteps;

	private Animator _animator;

	private readonly int id_Active;

	private bool _isActive = false;

	private Vector3 _originalScale;

	private GameObject _scalingParent;

	private void Awake()
	{
		CancelInvoke();
	}

	private unsafe void LateUpdate()
	{
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected Obj, but got Unknown
		//IL_09cc: Expected Obj, but got I4
		//IL_09e0: Expected I, but got Obj
		//IL_09f6: Expected Obj, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_01f7: Expected I, but got Obj
		//IL_020d: Expected Obj, but got I
		//IL_0a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a56: Expected Obj, but got Unknown
		//IL_0238: Expected I, but got Obj
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_0406: Expected I, but got Obj
		//IL_041c: Expected Obj, but got I
		//IL_0aab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab0: Expected Obj, but got Unknown
		//IL_0ac2: Expected Obj, but got I4
		//IL_0447: Expected I, but got Obj
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected Obj, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		//IL_04d9: Expected VT, but got Obj
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected VT, but got Unknown
		//IL_04f4: Expected F4, but got Obj
		//IL_04ef: Expected native int or pointer, but got VT
		//IL_0506: Expected F4, but got I
		//IL_0501: Expected native int or pointer, but got VT
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected Obj, but got Unknown
		//IL_051e: Expected Obj, but got F4
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected Obj, but got Unknown
		//IL_0551: Expected F4, but got Obj
		//IL_054c: Expected native int or pointer, but got VT
		//IL_0566: Expected F4, but got I
		//IL_0561: Expected native int or pointer, but got VT
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected Obj, but got Unknown
		//IL_05b4: Expected I4, but got Obj
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected Obj, but got Unknown
		//IL_05f7: Expected Obj, but got I4
		//IL_0619: Expected I, but got Obj
		//IL_062f: Expected Obj, but got I
		//IL_0ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad5: Expected Obj, but got Unknown
		//IL_0aeb: Expected F4, but got Obj
		//IL_0ae6: Expected native int or pointer, but got VT
		//IL_0b00: Expected F4, but got I
		//IL_0afb: Expected native int or pointer, but got VT
		//IL_0b09: Expected Obj, but got VT
		//IL_06a7: Expected I, but got Obj
		//IL_06bd: Expected Obj, but got I
		//IL_065a: Expected I, but got Obj
		//IL_0b37: Expected F4, but got Obj
		//IL_0b32: Expected native int or pointer, but got VT
		//IL_0b4c: Expected F4, but got I
		//IL_0b47: Expected native int or pointer, but got VT
		//IL_0b55: Expected Obj, but got VT
		//IL_0b62: Expected Obj, but got I4
		//IL_06e8: Expected I, but got Obj
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected Obj, but got Unknown
		//IL_076d: Expected Obj, but got I4
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected Obj, but got Unknown
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected Obj, but got Unknown
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Expected Obj, but got Unknown
		//IL_082f: Expected VT, but got Obj
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected Obj, but got Unknown
		//IL_089f: Expected Obj, but got I4
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected Obj, but got Unknown
		//IL_08ea: Expected I, but got Obj
		//IL_0900: Expected Obj, but got I
		//IL_0b7d: Expected F4, but got Obj
		//IL_0b78: Expected native int or pointer, but got VT
		//IL_0b92: Expected F4, but got I
		//IL_0b8d: Expected native int or pointer, but got VT
		//IL_0b9b: Expected Obj, but got VT
		//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0baf: Expected Obj, but got Unknown
		//IL_0977: Expected F4, but got Obj
		//IL_0972: Expected native int or pointer, but got VT
		//IL_098c: Expected F4, but got I
		//IL_0987: Expected native int or pointer, but got VT
		//IL_0999: Expected Obj, but got VT
		//IL_09a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a7: Expected Obj, but got Unknown
		//IL_092b: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - -64;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v177 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj4 = default;
		obj4.method_ptr = method_ptr;
		obj4.method = (nint)__ldftn(SpeedStripes.OnStartJetpack);
		object obj5 = obj4 + 16;
		obj5 = this;
		object obj6 = ex + 28;
		Delegate obj7 = ((Delegate)((Exception)ex)._stackTrace).CombineImpl(obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj8 = default;
		obj6 = obj8;
		bool useBenchmarkRoute2 = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex2 = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Delegate obj9 = default;
		obj9.method_ptr = method_ptr2;
		obj9.method = (nint)__ldftn(SpeedStripes.OnStartHeadstart);
		object obj10 = obj9 + 16;
		obj10 = this;
		object obj11 = ex2 + 28;
		Delegate obj12 = ((Delegate)((Exception)ex2)._stackTrace).CombineImpl(obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj13 = default;
		obj11 = obj13;
		bool useBenchmarkRoute3 = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex3 = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Delegate obj14 = default;
		obj14.method_ptr = method_ptr3;
		obj14.method = (nint)__ldftn(SpeedStripes.OnStopHeadstart);
		object obj15 = obj14 + 16;
		obj15 = this;
		object obj16 = ex3 + 28;
		Delegate obj17 = ((Delegate)((Exception)ex3)._stackTrace).CombineImpl(obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj18 = default;
		obj16 = obj18;
		nint num3 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v53 (Il2CppClass<Hoverboard>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num4 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v173 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Hoverboard.OnSpeedStartDelegate onSpeedStartDelegate = default;
		((Delegate)onSpeedStartDelegate).method_ptr = method_ptr4;
		((Delegate)onSpeedStartDelegate).method = (nint)__ldftn(SpeedStripes.OnSpeederBoardStart);
		object obj20 = onSpeedStartDelegate + 16;
		obj20 = this;
		((Hoverboard)characterModifier).OnSpeedStart -= onSpeedStartDelegate;
		CharacterModifier characterModifier2 = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr5 = 0;
		Hoverboard.OnSpeedEndDelegate onSpeedEndDelegate = default;
		((Delegate)onSpeedEndDelegate).method_ptr = method_ptr5;
		((Delegate)onSpeedEndDelegate).method = (nint)__ldftn(SpeedStripes.OnSpeederBoardStop);
		object obj21 = onSpeedEndDelegate + 16;
		obj21 = this;
		((Hoverboard)characterModifier2).OnSpeedEnd -= onSpeedEndDelegate;
		bool useBenchmarkRoute4 = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex4 = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr6 = 0;
		Delegate obj22 = default;
		obj22.method_ptr = method_ptr6;
		obj22.method = (nint)__ldftn(SpeedStripes.OnPogoStart);
		object obj23 = obj22 + 16;
		obj23 = this;
		object obj24 = ex4 + 36;
		Delegate obj25 = ((Delegate)(object)((Exception)ex4)._remoteStackTraceString).CombineImpl(obj22);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj26 = default;
		obj24 = obj26;
		bool useBenchmarkRoute5 = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex5 = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr7 = 0;
		Delegate obj27 = default;
		obj27.method_ptr = method_ptr7;
		obj27.method = (nint)__ldftn(SpeedStripes.OnPogoStop);
		object obj28 = obj27 + 16;
		obj28 = this;
		object obj29 = ex5 + 44;
		Delegate obj30 = ((Delegate)((Exception)ex5)._dynamicMethods).CombineImpl(obj27);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj31 = default;
		obj29 = obj31;
		nint num5 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v86 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj32 = (nint)0 & (nint)0x200;
		if (obj32 != null)
		{
			nint num6 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v169 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr8 = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr8;
		((Delegate)action).method = (nint)__ldftn(SpeedStripes.Reset);
		object obj33 = action + 16;
		obj33 = this;
		((Game)isInstantiated).OnStageMenuSequence -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Material material = default;
		material._002Ector((string)(object)_OriginalMaterial);
		object obj34 = this + 40;
		obj34 = material;
		Material material2 = (Material)(obj2 + 48);
		material2.SetTextureOffset((string)(object)_material, (Vector2)"_MainColor");
		Vector4 vector = (Vector4)(obj2 + 80);
		((Vector4*)(nint)vector)->x = (float)material2;
		((Vector4*)(nint)vector)->z = (nint)((UnityEngine.Object)material2).m_CachedPtr;
		object obj35 = this + 16;
		obj35 = vector.x;
		_ = vector.z;
		object obj36 = obj2 + 32;
		Color yellow = Color.yellow;
		((Vector4*)(nint)vector)->x = (float)obj36;
		Vector4 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S1_v102+8]");
		((Vector4*)(nint)vector2)->z = 0f;
		_material.SetVector("_MainColor", vector);
		object obj37 = this + 60;
		Animator component = GetComponent<Animator>();
		obj37 = component;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		gameObject.layer = (int)"SpeedStripesScalingParent";
		object obj38 = this + 84;
		obj38 = gameObject;
		int layer = _scalingParent.layer;
		GameObject parentInternal = base.gameObject;
		((Transform)layer).parentInternal = (Transform)(object)parentInternal;
		int layer2 = _scalingParent.layer;
		nint num7 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S1_v117 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj39 = (nint)0 & (nint)0x200;
		if (obj39 != null)
		{
			nint num8 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S1_v200 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj40 = obj2 + 16;
		Vector3 one = Vector3.one;
		((Vector4*)(nint)vector)->x = (float)obj40;
		Vector4 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S1_v122+8]");
		((Vector4*)(nint)vector3)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector).eulerAngles;
		int layer3 = _scalingParent.layer;
		nint num9 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S1_v128 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj41 = (nint)0 & (nint)0x200;
		if (obj41 != null)
		{
			nint num10 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S1_v196 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		((Vector4*)(nint)vector)->x = (float)obj2;
		Vector4 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector4*)(nint)vector4)->z = 0f;
		Vector3 localScale = ((Transform)vector).localScale;
		object obj42 = 0;
		while (true)
		{
			Renderer[] renderers = _renderers;
			if ((nint)obj42 >= renderers.Length)
			{
				break;
			}
			object obj43 = _renderers + 16;
			object obj44 = obj42 << 2;
			object obj45 = obj43 + obj44;
			string text = ((Component)obj45).tag;
			((GameObject)(object)text).tag = (string)1;
			object obj46 = _renderers + 16;
			object obj47 = obj42 << 2;
			object obj48 = obj46 + obj47;
			((Renderer)obj48).sharedMaterials = (Material[])(object)_material;
			object obj49 = _renderers + 16;
			object obj50 = obj42 << 2;
			object obj51 = obj49 + obj50;
			((Renderer)obj51).shadowCastingMode = ShadowCastingMode.Off;
			object obj52 = _renderers + 16;
			object obj53 = obj42 << 2;
			object obj54 = obj52 + obj53;
			GameObject gameObject2 = ((Component)obj54).gameObject;
			((Transform)(object)material2).localScale = (Vector3)gameObject2;
			obj = material2;
			_ = ((UnityEngine.Object)material2).m_CachedPtr;
			object obj55 = _renderers + 16;
			object obj56 = obj42 << 2;
			object obj57 = obj55 + obj56;
			GameObject gameObject3 = ((Component)obj57).gameObject;
			int layer4 = _scalingParent.layer;
			((Transform)(object)gameObject3).parentInternal = (Transform)layer4;
			object obj58 = _renderers + 16;
			object obj59 = obj42 << 2;
			object obj60 = obj58 + obj59;
			GameObject gameObject4 = ((Component)obj60).gameObject;
			nint num11 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S1_v176 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj61 = (nint)0 & (nint)0x200;
			if (obj61 != null)
			{
				nint num12 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ S1_v192 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one2 = Vector3.one;
			((Vector4*)(nint)vector)->x = (float)obj36;
			Vector4 vector5 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S1_v102+8]");
			((Vector4*)(nint)vector5)->z = 0f;
			Vector3 eulerAngles2 = ((Transform)vector).eulerAngles;
			object obj62 = _renderers + 16;
			object obj63 = obj42 << 2;
			object obj64 = obj62 + obj63;
			GameObject gameObject5 = ((Component)obj64).gameObject;
			((Vector4*)(nint)vector)->x = (float)obj;
			Vector4 vector6 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector4*)(nint)vector6)->z = 0f;
			((Transform)(object)gameObject5).parent = (Transform)vector;
			object obj65 = obj42 + 1;
			obj42 = obj65;
		}
	}

	public unsafe virtual void Initialize(IRouteEffectGUISubject subject)
	{
		//IL_039f: Invalid comparison between VT and I4
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected Ref, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Ref, but got Unknown
		//IL_044f: Expected Obj, but got I
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected I4, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_01a2: Expected I, but got Obj
		//IL_006f: Expected Obj, but got I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0232: Expected Obj, but got I
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0244: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got F4
		//IL_026d: Expected I, but got Obj
		//IL_0283: Expected Obj, but got I
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_04ad: Expected Ref, but got VT
		//IL_04c3: Expected Obj, but got Ref
		//IL_04d8: Expected Obj, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0304: Expected VT, but got Obj
		//IL_02ae: Expected I, but got Obj
		//IL_0324: Expected Obj, but got Ref
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_038f: Expected Obj, but got I
		if (_originalColor != (Color)(object)0)
		{
			object obj = _originalColor + 12;
			object obj2 = default;
			object obj5 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				object obj3 = _originalColor + 16;
				object obj4 = obj5 << 2;
				object obj6 = obj3 + obj4;
				((Renderer)obj6).shadowCastingMode = ShadowCastingMode.On;
				obj2 = obj5 + 1;
			}
			object obj7 = 0;
			while (true)
			{
				Material originalMaterial = _OriginalMaterial;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v67 (UnityEngine.Material)+C]");
				if ((nint)obj8 >= 0)
				{
					break;
				}
				object obj9 = _OriginalMaterial + 16;
				object obj10 = obj7 << 2;
				object obj11 = obj9 + obj10;
				((AnimationState)obj11).time = 1f;
				object obj12 = _OriginalMaterial + 16;
				object obj13 = obj7 << 2;
				object obj14 = obj12 + obj13;
				((AnimationState)obj14).wrapMode = WrapMode.Once;
				object obj15 = obj7 + 1;
				obj7 = obj15;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			object obj17 = default;
			object obj16 = obj17 + 16;
			obj16 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
			IEnumerator routine = default;
			Coroutine coroutine = StartCoroutine_Auto(routine);
		}
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v57 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = default;
		ref Quaternion reference = ref *(Quaternion*)(transform + 48);
		object obj19 = transform + 32;
		ref Quaternion reference2 = ref *(Quaternion*)(transform + 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpeedStripes)+18]");
		int num4 = ((ComputeShader)0).FindKernel(null);
		if ((num4 & subject) == 0 || !isActiveAndEnabled)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj21 = default;
		object obj20 = obj21 + 12;
		obj20 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpeedStripes)+18]");
		GameObject gameObject = ((Component)0).gameObject;
		obj19 = 0;
		_ = 0;
		obj19 = 270f;
		_ = 0f;
		_ = 0f;
		nint num5 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S1_v28 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num6 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S1_v53 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		reference = ref *(Quaternion*)obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v12+8]");
		_ = 0;
		Quaternion.Inverse_Injected(ref reference2, out reference);
		reference = ref *(Quaternion*)reference2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v14 (UnityEngine.Quaternion&)+8]");
		_ = 0;
		Vector3 localScale = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).localScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpeedStripes)+18]");
		GameObject gameObject2 = ((Component)0).gameObject;
		GameObject gameObject3 = base.gameObject;
		transform.position = (Vector3)gameObject3;
		reference = ref *(Quaternion*)transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 localPosition = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).localPosition;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		object obj24 = default;
		object obj23 = obj24 + 16;
		obj23 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
		IEnumerator routine2 = default;
		Coroutine coroutine2 = StartCoroutine_Auto(routine2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SpeedStripes)+18]");
		((ParticleSystem)0).Stop();
	}

	public unsafe virtual void DeInitialize()
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected VT, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01e4: Expected Obj, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00c1: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0209: Expected F4, but got Obj
		//IL_0204: Expected native int or pointer, but got VT
		//IL_021e: Expected F4, but got I
		//IL_0219: Expected native int or pointer, but got VT
		//IL_024c: Expected F4, but got Obj
		//IL_0247: Expected native int or pointer, but got VT
		//IL_0261: Expected F4, but got I
		//IL_025c: Expected native int or pointer, but got VT
		//IL_026e: Expected Obj, but got VT
		//IL_026e: Expected Obj, but got I4
		//IL_0277: Expected Obj, but got I4
		//IL_0102: Expected I, but got Obj
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj + 24);
		object obj2 = obj + 12;
		if (~(_isActive ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(CharacterCamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v17 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(CharacterCamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v39 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int selectedBenchmarkIndex = SubwayBenchmarkContainer.SelectedBenchmarkIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v22 (System.Int32)+6C]");
		float orthographicSize = ((Camera)0).orthographicSize;
		int layer = _scalingParent.layer;
		object obj4 = this + 72;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S2_v3+8]");
		_ = 0;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v12 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v31 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		((Vector3*)(nint)vector)->z = 0f;
		float num5 = orthographicSize / 68f;
		Vector3 vector2 = vector / num5;
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Transform)layer).parent = (Transform)vector;
		object obj6 = 0;
		while (true)
		{
			Renderer[] renderers = _renderers;
			if ((nint)obj6 < renderers.Length)
			{
				object obj7 = _renderers + 16;
				object obj8 = obj6 << 2;
				object obj9 = obj7 + obj8;
				((Renderer)obj9).shadowCastingMode = ShadowCastingMode.On;
				object obj10 = obj6 + 1;
				obj6 = obj10;
				continue;
			}
			break;
		}
	}

	private void HandleOnEnteredSkatePark()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I4
		if (_subject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			object obj2 = default;
			object obj = obj2 + 16;
			obj = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num2 = 0;
			_ = 0;
			object obj4 = default;
			object obj3 = obj4 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
			object obj5 = this + 44;
			obj5 = 0;
		}
		OnSpeederBoardStart();
	}

	private void HandleOnEnteredTallyScreen()
	{
	}

	private void HandleOnGearChanged(int gear)
	{
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_025c: Expected Obj, but got I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00d1: Expected Obj, but got I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_010a: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = this + 44;
		obj3 = gear;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj5 = default;
		object obj4 = obj5 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		object obj7 = default;
		object obj6 = obj7 + 16;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		object obj8 = this + 48;
		object obj9 = _gearSteps + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj10 = default;
		obj8 = obj10;
		Color[] colorSteps = _colorSteps;
		object obj11 = colorSteps.Length - 2;
		object obj12 = obj11;
		while ((nint)obj12 >= 0)
		{
			object obj13 = this + 16;
			Color[] colorSteps2 = _colorSteps;
			object obj14 = this + 16;
			Color[] colorSteps3 = _colorSteps;
			object obj15 = this + 16;
			Color[] colorSteps4 = _colorSteps;
			obj2 = 0;
			_ = 0;
			object obj16 = obj13 / colorSteps2.Length;
			object obj17 = obj12 * obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v57+4]");
			object obj18 = (nint)0 / (nint)colorSteps3.Length;
			object obj19 = obj12 * obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v62+8]");
			object obj20 = (nint)0 / (nint)colorSteps4.Length;
			object obj21 = obj12 * obj20;
			obj2 = obj17;
			_ = 1f;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj22 = _colorSteps + 16;
			object obj23 = obj12 << 4;
			object obj24 = obj22 + obj23;
			obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj25 = obj12 - 1;
			obj12 = obj25;
		}
		object obj26 = this + 16;
		obj2 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v30+8]");
		_ = 0;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj27 = _colorSteps + 16;
		int num3 = _gearSteps << 4;
		object obj28 = obj27 + num3;
		obj28 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
	}

	private unsafe void OnSpeederBoardStart()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I4, but got Unknown
		//IL_0024: Expected I4, but got Obj
		Color yellow = Color.yellow;
		object obj = default;
		bool flag = (byte)(obj + 16) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((FollowingGuard)this).OnJump(4.2f, flag);
	}

	private unsafe void OnSpeederBoardStop()
	{
		//IL_00df: Expected I, but got Obj
		//IL_00f5: Expected Obj, but got I
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected VT, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected I4, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_014e: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0088: Expected I4, but got Obj
		//IL_00a2: Expected F4, but got Obj
		//IL_009d: Expected native int or pointer, but got VT
		//IL_00b7: Expected F4, but got I
		//IL_00b2: Expected native int or pointer, but got VT
		nint num = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v35 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Color color = (Color)(obj2 + 48);
		int num3 = obj2 + 32;
		object obj3 = obj2 + 16;
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		if (!((StateMachine)useBenchmarkRoute).IsCurrentState<HeadstartState>())
		{
			Color yellow = Color.yellow;
			object obj4 = this + 16;
			obj2 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v12+8]");
			_ = 0;
			((int*)num3)->m_value = (int)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18+8]");
			_ = 0;
			((Color*)(nint)color)->r = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Color*)(nint)color)->b = 0f;
			Utils.Bar((string)(object)this, _fadeInTime, num3, color);
		}
	}

	private unsafe void OnPogoStart()
	{
		//IL_0126: Expected I, but got Obj
		//IL_013c: Expected Obj, but got I
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected I4, but got Unknown
		//IL_01b4: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_00f6: Expected I4, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v40 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		bool flag = (byte)(obj2 + 16) != 0;
		bool isInstantiated = Game.IsInstantiated;
		if (((Game)isInstantiated).HasSuperSneakers)
		{
			return;
		}
		nint num3 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v22 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v36 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		if (!((StateMachine)useBenchmarkRoute).IsCurrentState<HeadstartState>())
		{
			Color yellow = Color.yellow;
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj2 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			((FollowingGuard)this).OnJump(_fadeInTime, flag);
		}
	}

	private unsafe void OnPogoStop()
	{
		//IL_0247: Expected I, but got Obj
		//IL_025d: Expected Obj, but got I
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected I4, but got Unknown
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_0217: Expected I4, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_01bd: Expected I, but got Obj
		nint num = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Hoverboard>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v63 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		bool flag = (byte)(obj2 + 16) != 0;
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (CharacterModifier)+54]");
		if ((nint)0 != 0)
		{
			nint num3 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v52 (Il2CppClass<Hoverboard>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v59 (Il2CppClass<Hoverboard>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterModifier characterModifier2 = MysteryPowerup.SelectRandomCharacterModifier();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v57 (CharacterModifier)+22]");
			if ((nint)0 != 0)
			{
				goto IL_0201;
			}
		}
		nint num5 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v27 (Il2CppClass<Hoverboard>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v47 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterModifier characterModifier3 = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v32 (CharacterModifier)+54]");
		if ((nint)0 == 0)
		{
			return;
		}
		nint num7 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v36 (Il2CppClass<Hoverboard>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v43 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterModifier characterModifier4 = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v41 (CharacterModifier)+23]");
		if ((nint)0 == 0)
		{
			return;
		}
		goto IL_0201;
		IL_0201:
		Color yellow = Color.yellow;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj2 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((FollowingGuard)this).OnJump(0.1f, flag);
	}

	private unsafe void OnStartJetpack()
	{
		//IL_028d: Expected I, but got Obj
		//IL_02a3: Expected Obj, but got I
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected VT, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected I4, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_0237: Expected I4, but got Obj
		//IL_0251: Expected F4, but got Obj
		//IL_024c: Expected native int or pointer, but got VT
		//IL_0266: Expected F4, but got I
		//IL_0261: Expected native int or pointer, but got VT
		//IL_00a1: Expected I, but got Obj
		//IL_01bd: Expected I, but got Obj
		nint num = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Hoverboard>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v71 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Color color = (Color)(obj2 + 48);
		int num3 = obj2 + 32;
		object obj3 = obj2 + 16;
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20 (CharacterModifier)+54]");
		if ((nint)0 != 0)
		{
			nint num4 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v60 (Il2CppClass<Hoverboard>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v67 (Il2CppClass<Hoverboard>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterModifier characterModifier2 = MysteryPowerup.SelectRandomCharacterModifier();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v65 (CharacterModifier)+22]");
			if ((nint)0 != 0)
			{
				goto IL_0201;
			}
		}
		nint num6 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v35 (Il2CppClass<Hoverboard>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v55 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterModifier characterModifier3 = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v40 (CharacterModifier)+54]");
		if ((nint)0 == 0)
		{
			return;
		}
		nint num8 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v44 (Il2CppClass<Hoverboard>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num9 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v51 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterModifier characterModifier4 = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v49 (CharacterModifier)+23]");
		if ((nint)0 == 0)
		{
			return;
		}
		goto IL_0201;
		IL_0201:
		Color yellow = Color.yellow;
		object obj7 = this + 16;
		obj2 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v11+8]");
		_ = 0;
		((int*)num3)->m_value = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18+8]");
		_ = 0;
		((Color*)(nint)color)->r = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Color*)(nint)color)->b = 0f;
		Utils.Bar((string)(object)this, 0.1f, num3, color);
	}

	private unsafe void OnStartHeadstart()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I4, but got Unknown
		//IL_0024: Expected I4, but got Obj
		Color yellow = Color.yellow;
		object obj = default;
		bool flag = (byte)(obj + 16) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((FollowingGuard)this).OnJump(_fadeInTime, flag);
	}

	private unsafe void OnStopHeadstart()
	{
		//IL_028e: Expected I, but got Obj
		//IL_02a4: Expected Obj, but got I
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected VT, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected I4, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_00f3: Expected I, but got Obj
		//IL_0109: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_0237: Expected I4, but got Obj
		//IL_0251: Expected F4, but got Obj
		//IL_024c: Expected native int or pointer, but got VT
		//IL_0266: Expected F4, but got I
		//IL_0261: Expected native int or pointer, but got VT
		//IL_0134: Expected I, but got Obj
		//IL_0181: Expected I, but got Obj
		//IL_0197: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_01c2: Expected I, but got Obj
		nint num = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Hoverboard>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v74 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Color color = (Color)(obj2 + 48);
		int num3 = obj2 + 32;
		object obj3 = obj2 + 16;
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20 (CharacterModifier)+54]");
		if ((nint)0 != 0)
		{
			nint num4 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v62 (Il2CppClass<Hoverboard>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v70 (Il2CppClass<Hoverboard>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterModifier characterModifier2 = MysteryPowerup.SelectRandomCharacterModifier();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v67 (CharacterModifier)+22]");
			if ((nint)0 != 0)
			{
				return;
			}
		}
		nint num6 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v27 (Il2CppClass<Hoverboard>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v57 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterModifier characterModifier3 = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v32 (CharacterModifier)+54]");
		if ((nint)0 != 0)
		{
			nint num8 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v46 (Il2CppClass<Hoverboard>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num9 = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v53 (Il2CppClass<Hoverboard>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterModifier characterModifier4 = MysteryPowerup.SelectRandomCharacterModifier();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v51 (CharacterModifier)+23]");
			if ((nint)0 != 0)
			{
				return;
			}
		}
		Color yellow = Color.yellow;
		object obj7 = this + 16;
		obj2 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v13+8]");
		_ = 0;
		((int*)num3)->m_value = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18+8]");
		_ = 0;
		((Color*)(nint)color)->r = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Color*)(nint)color)->b = 0f;
		Utils.Bar((string)(object)this, _fadeInTime, num3, color);
	}

	private void Activate(float time, Color currentColor, Color colorTargetColor)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	private void Deactivate(float time, Color colorTarget)
	{
		//IL_003a: Expected Obj, but got I4
		float fadeInTime = _fadeInTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (System.Single)+54]");
		if ((nint)0 != 0)
		{
			Initialize((IRouteEffectGUISubject)1);
		}
	}

	private unsafe void Reset()
	{
		//IL_0248: Expected I, but got Obj
		//IL_025e: Expected Obj, but got I
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected I4, but got Unknown
		//IL_00f3: Expected I, but got Obj
		//IL_0109: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0217: Expected I4, but got Obj
		//IL_0134: Expected I, but got Obj
		//IL_0181: Expected I, but got Obj
		//IL_0197: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_01c2: Expected I, but got Obj
		nint num = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Hoverboard>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v66 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		bool flag = (byte)(obj2 + 16) != 0;
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (CharacterModifier)+54]");
		if ((nint)0 != 0)
		{
			nint num3 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v54 (Il2CppClass<Hoverboard>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v62 (Il2CppClass<Hoverboard>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterModifier characterModifier2 = MysteryPowerup.SelectRandomCharacterModifier();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v59 (CharacterModifier)+22]");
			if ((nint)0 != 0)
			{
				return;
			}
		}
		nint num5 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v23 (Il2CppClass<Hoverboard>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v49 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterModifier characterModifier3 = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v28 (CharacterModifier)+54]");
		if ((nint)0 != 0)
		{
			nint num7 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v38 (Il2CppClass<Hoverboard>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v45 (Il2CppClass<Hoverboard>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterModifier characterModifier4 = MysteryPowerup.SelectRandomCharacterModifier();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v43 (CharacterModifier)+23]");
			if ((nint)0 != 0)
			{
				return;
			}
		}
		Color yellow = Color.yellow;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj2 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((FollowingGuard)this).OnJump(_fadeInTime, flag);
	}

	public unsafe SpeedStripes()
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00e6: Expected I4, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected VT, but got Unknown
		//IL_0020: Expected F4, but got Obj
		//IL_001b: Expected native int or pointer, but got VT
		//IL_0035: Expected F4, but got I
		//IL_0030: Expected native int or pointer, but got VT
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0062: Expected Obj, but got I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		object obj = this - -64;
		_animator.SetInteger((int)obj, 0);
		MonoBehaviour.print(this);
		Color yellow = Color.yellow;
		object obj2 = default;
		Vector4 vector = (Vector4)(obj2 + 16);
		((Vector4*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector4*)(nint)vector)->z = 0f;
		_material.SetVector("_MainColor", vector);
		object obj3 = _renderers + 12;
		object obj4 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
		{
			object obj5 = _renderers + 16;
			object obj6 = obj4 << 2;
			object obj7 = obj5 + obj6;
			((Renderer)obj7).shadowCastingMode = ShadowCastingMode.Off;
			object obj8 = obj4 + 1;
			obj4 = obj8;
		}
	}
}
