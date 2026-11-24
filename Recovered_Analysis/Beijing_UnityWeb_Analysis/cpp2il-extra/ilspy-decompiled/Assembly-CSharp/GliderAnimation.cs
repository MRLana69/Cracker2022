using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Plugins.DeviceUtility.Internal;
using SYBO.Subway.Characters;
using UnityEngine;

public class GliderAnimation : MonoBehaviour
{
	private Animation _animation;

	private AnimationClip _clipClose;

	private AnimationClip _clipOpen;

	private AnimationState _stateClose;

	private AnimationState _stateOpen;

	private Character _character;

	private HoverboardModelPreviewFactory _factory;

	private bool _open;

	private unsafe void Awake()
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected I4, but got Unknown
		//IL_011d: Expected I4, but got Obj
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0019: Expected Obj, but got I
		//IL_0026: Expected I4, but got Obj
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I
		//IL_0076: Expected I4, but got Obj
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I
		//IL_00b8: Expected I4, but got Obj
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		CallingConvention callingConvention = (CallingConvention)(obj2 + 16);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		object obj3 = this + 16;
		obj3 = unmanagedFunctionPointerAttribute;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = obj2 + 8;
		obj4 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj4;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute2 = default;
		unmanagedFunctionPointerAttribute2._002Ector(callingConvention);
		object obj5 = this + 20;
		obj5 = unmanagedFunctionPointerAttribute2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj6 = obj2 + 4;
		obj6 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj6;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute3 = default;
		unmanagedFunctionPointerAttribute3._002Ector(callingConvention);
		object obj7 = this + 24;
		obj7 = unmanagedFunctionPointerAttribute3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		obj2 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj2;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute4 = default;
		unmanagedFunctionPointerAttribute4._002Ector(callingConvention);
		object obj8 = this + 28;
		obj8 = unmanagedFunctionPointerAttribute4;
		CancelInvoke();
	}

	private void HandleOnSwitchToHoverboard(HoverboardBundle hoverbooardBundle, Hoverboard.BoardAbility[] abilities)
	{
		//IL_006e: Expected Obj, but got I4
		//IL_0080: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		PlatformID platform = Environment.Platform;
		string msg = string.Format((IFormatProvider)(object)"{0}{1}===={1}{2}", (string)(object)this, platform, hoverbooardBundle);
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v4 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v9 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DeviceUtilityAndroid.LogError(msg);
	}

	public void AddEvents()
	{
		//IL_011a: Expected I, but got Obj
		//IL_0130: Expected Obj, but got I
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_006e: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00ff: Expected I4, but got Obj
		//IL_010b: Expected Obj, but got I4
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 32;
		CharacterRendering instance = CharacterRendering.Instance;
		obj2 = instance;
		object obj3 = this + 12;
		Animation component = GetComponent<Animation>();
		obj3 = component;
		object obj4 = this + 24;
		Animation component2 = GetComponent<Animation>();
		UnityEngine.Object obj5 = UnityEngine.Object.Instantiate((UnityEngine.Object)_clipClose);
		bool flag = component2.Play((PlayMode)obj5);
		obj4 = flag;
		_stateClose.time = 1f;
		_stateClose.normalizedTime = 1f;
		((CharacterController)(object)_stateClose).height = 0f;
		_stateClose.wrapMode = WrapMode.Once;
		object obj6 = this + 28;
		Animation component3 = GetComponent<Animation>();
		UnityEngine.Object obj7 = UnityEngine.Object.Instantiate((UnityEngine.Object)_clipOpen);
		bool flag2 = component3.Play((PlayMode)obj7);
		obj6 = flag2;
	}

	public void AddEvents(HoverboardModelPreviewFactory factory)
	{
	}

	private unsafe void OnDestroy()
	{
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0043: Expected I, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_0084: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Character.OnHangtimeDelegate onHangtimeDelegate = default;
		((Delegate)onHangtimeDelegate).method_ptr = method_ptr;
		((Delegate)onHangtimeDelegate).method = (nint)__ldftn(GliderAnimation.HandleOnHangtime);
		object obj = onHangtimeDelegate + 16;
		obj = this;
		_character.OnHangtime -= onHangtimeDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<Character> action = default;
		object obj2 = action + 16;
		obj2 = this;
		_character.OnLanding -= action;
		nint num2 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v10 (Il2CppClass<Hoverboard>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v16 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Hoverboard.OnSwitchToHoverboardDelegate onSwitchToHoverboardDelegate = default;
		((Delegate)onSwitchToHoverboardDelegate).method_ptr = method_ptr2;
		((Delegate)onSwitchToHoverboardDelegate).method = (nint)__ldftn(GliderAnimation.HandleOnSwitchToHoverboard);
		object obj4 = onSwitchToHoverboardDelegate + 16;
		obj4 = this;
		((Hoverboard)characterModifier).OnSwitchToHoverboard -= onSwitchToHoverboardDelegate;
	}

	private unsafe void HandleOnLanding(Character character)
	{
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		object obj = this + 36;
		obj = character;
		HoverboardModelPreviewFactory factory = _factory;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj2 = default;
		obj2.method_ptr = method_ptr;
		obj2.method = (nint)__ldftn(GliderAnimation.HandleOnOpenMenu);
		object obj3 = obj2 + 16;
		obj3 = this;
		object obj4 = _factory + 48;
		Delegate obj5 = ((Delegate)factory.OnOpenGlider).CombineImpl(obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj6 = default;
		obj4 = obj6;
		HoverboardModelPreviewFactory factory2 = _factory;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Delegate obj7 = default;
		obj7.method_ptr = method_ptr2;
		obj7.method = (nint)__ldftn(GliderAnimation.HandleOnCloseMenu);
		object obj8 = obj7 + 16;
		obj8 = this;
		object obj9 = _factory + 52;
		Delegate obj10 = ((Delegate)factory2.OnCloseGlider).CombineImpl(obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj11 = default;
		obj9 = obj11;
	}

	private unsafe void HandleOnClose()
	{
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0057: Expected I, but got Obj
		//IL_006d: Expected Obj, but got I
		//IL_02d3: Expected I, but got Obj
		//IL_02e9: Expected Obj, but got I
		//IL_0098: Expected I, but got Obj
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_01fb: Expected I, but got Obj
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Character.OnRollDelegate onRollDelegate = default;
		((Delegate)onRollDelegate).method_ptr = method_ptr;
		((Delegate)onRollDelegate).method = (nint)__ldftn(GliderAnimation.HandleOnHangtime);
		object obj = onRollDelegate + 16;
		obj = this;
		_character.OnRoll += onRollDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Character.OnHangtimeDelegate onHangtimeDelegate = default;
		((Delegate)onHangtimeDelegate).method_ptr = method_ptr2;
		((Delegate)onHangtimeDelegate).method = (nint)__ldftn(GliderAnimation.HandleOnLanding);
		object obj2 = onHangtimeDelegate + 16;
		obj2 = this;
		_character.OnHangtime += onHangtimeDelegate;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v54 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_factory).FindKernel((string)null) != 0)
		{
			HoverboardModelPreviewFactory factory = _factory;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr3 = 0;
			Delegate obj4 = default;
			obj4.method_ptr = method_ptr3;
			obj4.method = (nint)__ldftn(GliderAnimation.HandleOnOpenMenu);
			object obj5 = obj4 + 16;
			obj5 = this;
			object obj6 = _factory + 48;
			Delegate obj7 = ((Delegate)factory.OnOpenGlider).RemoveImpl(obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj8 = default;
			obj6 = obj8;
			HoverboardModelPreviewFactory factory2 = _factory;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr4 = 0;
			Delegate obj9 = default;
			obj9.method_ptr = method_ptr4;
			obj9.method = (nint)__ldftn(GliderAnimation.HandleOnCloseMenu);
			object obj10 = obj9 + 16;
			obj10 = this;
			object obj11 = _factory + 52;
			Delegate obj12 = ((Delegate)factory2.OnCloseGlider).RemoveImpl(obj9);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj13 = default;
			obj11 = obj13;
		}
		nint num3 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v14 (Il2CppClass<Hoverboard>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num4 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v20 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr5 = 0;
		Hoverboard.OnEndHoverboardDelegate onEndHoverboardDelegate = default;
		((Delegate)onEndHoverboardDelegate).method_ptr = method_ptr5;
		((Delegate)onEndHoverboardDelegate).method = (nint)__ldftn(GliderAnimation.HandleOnSwitchToHoverboard);
		object obj15 = onEndHoverboardDelegate + 16;
		obj15 = this;
		((Hoverboard)characterModifier).OnEndHoverboard += onEndHoverboardDelegate;
	}

	private void HandleOnHangtime()
	{
		//IL_0023: Expected I, but got Obj
		//IL_0039: Expected Obj, but got I
		//IL_0064: Expected I, but got Obj
		if (~(_open ? 1u : 0u) != 0)
		{
			return;
		}
		((CharacterController)(object)_stateClose).height = 1f;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_animation).FindKernel((string)null) != 0)
		{
			UnityEngine.Object animation = UnityEngine.Object.Instantiate((UnityEngine.Object)_clipClose);
			AnimationState animationState = _animation.CrossFadeQueued((string)(object)animation);
		}
		_open = false;
	}

	private void HandleOnCloseMenu()
	{
		//IL_0065: Expected I, but got Obj
		//IL_007b: Expected Obj, but got I
		//IL_00a6: Expected I, but got Obj
		if (~(_open ? 1u : 0u) == 0)
		{
			return;
		}
		Character character = _character;
		Variable<bool> isGrounded = character.IsGrounded;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v13 (Variable`1<System.Boolean>)+8]");
		if ((nint)0 != 0)
		{
			return;
		}
		_open = true;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_animation).FindKernel((string)null) != 0)
		{
			UnityEngine.Object animation = UnityEngine.Object.Instantiate((UnityEngine.Object)_clipOpen);
			AnimationState animationState = _animation.CrossFadeQueued((string)(object)animation);
		}
	}

	private void HandleOnOpenMenu()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		((CharacterController)(object)_stateClose).height = 1f;
		_stateClose.speed = 0f;
		_stateClose.time = 1f;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_animation).FindKernel((string)null) != 0)
		{
			UnityEngine.Object animation = UnityEngine.Object.Instantiate((UnityEngine.Object)_clipClose);
			AnimationState animationState = _animation.CrossFadeQueued((string)(object)animation);
		}
		_open = false;
	}

	public unsafe void RemoveEventHandling()
	{
		//IL_02ee: Expected I, but got Obj
		//IL_0304: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0239: Expected I, but got Obj
		//IL_024f: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_027a: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v56 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_animation != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v52 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_factory).FindKernel((string)null) != 0)
			{
				HoverboardModelPreviewFactory factory = _factory;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				Delegate obj3 = default;
				obj3.method_ptr = method_ptr;
				obj3.method = (nint)__ldftn(GliderAnimation.HandleOnOpenMenu);
				object obj4 = obj3 + 16;
				obj4 = this;
				object obj5 = _factory + 48;
				Delegate obj6 = ((Delegate)factory.OnOpenGlider).RemoveImpl(obj3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj7 = default;
				obj5 = obj7;
				HoverboardModelPreviewFactory factory2 = _factory;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr2 = 0;
				Delegate obj8 = default;
				obj8.method_ptr = method_ptr2;
				obj8.method = (nint)__ldftn(GliderAnimation.HandleOnCloseMenu);
				object obj9 = obj8 + 16;
				obj9 = this;
				object obj10 = _factory + 52;
				Delegate obj11 = ((Delegate)factory2.OnCloseGlider).RemoveImpl(obj8);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj12 = default;
				obj10 = obj12;
			}
			return;
		}
		_stateOpen.speed = 0f;
		_stateClose.time = 0f;
		_stateClose.speed = 0f;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_animation).FindKernel((string)null) != 0)
		{
			UnityEngine.Object animation = UnityEngine.Object.Instantiate((UnityEngine.Object)_clipOpen);
			AnimationState animationState = _animation.CrossFadeQueued((string)(object)animation);
		}
	}

	public unsafe GliderAnimation()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Character.OnRollDelegate onRollDelegate = default;
		((Delegate)onRollDelegate).method_ptr = method_ptr;
		((Delegate)onRollDelegate).method = (nint)__ldftn(GliderAnimation.HandleOnHangtime);
		object obj = onRollDelegate + 16;
		obj = this;
		_character.OnRoll += onRollDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Character.OnHangtimeDelegate onHangtimeDelegate = default;
		((Delegate)onHangtimeDelegate).method_ptr = method_ptr2;
		((Delegate)onHangtimeDelegate).method = (nint)__ldftn(GliderAnimation.HandleOnLanding);
		object obj2 = onHangtimeDelegate + 16;
		obj2 = this;
		_character.OnHangtime += onHangtimeDelegate;
	}
}
