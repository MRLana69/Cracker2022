using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using SYBO.Subway.Routes.Prototypes;
using UnityEngine;

public class playThruster : MonoBehaviour
{
	public enum JumpStyle
	{
		Super,
		Double
	}

	private Hoverboard _hoverboard;

	private Renderer[] _renderes;

	private AnimationClip _clip;

	private ParticleSystem _particles;

	private float thrusterPlayTime;

	private JumpStyle _jumpStyle;

	private AnimationState[] _states;

	private Character _character;

	private HoverboardModelPreviewFactory _factory;

	private bool addedEvent;

	private bool addedMenuEvent;

	public JumpStyle jumpStyle
	{
		get
		{
			//IL_02dc: Expected I, but got Obj
			//IL_02f2: Expected Obj, but got I
			//IL_0474: Expected Obj, but got I
			//IL_0030: Expected I, but got Obj
			//IL_0046: Expected Obj, but got I
			//IL_03ae: Expected I4, but got Obj
			//IL_014c: Expected I, but got Obj
			//IL_0199: Expected I, but got Obj
			//IL_01af: Expected Obj, but got I
			//IL_04bc: Expected Obj, but got I
			//IL_04cc: Expected Obj, but got I
			//IL_04dc: Expected Obj, but got I
			//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ea: Expected Obj, but got Unknown
			//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f8: Expected Obj, but got Unknown
			//IL_0071: Expected I, but got Obj
			//IL_00be: Expected I, but got Obj
			//IL_00d4: Expected Obj, but got I
			//IL_052e: Expected Obj, but got I
			//IL_053e: Expected Obj, but got I
			//IL_054e: Expected Obj, but got I
			//IL_0557: Unknown result type (might be due to invalid IL or missing references)
			//IL_055c: Expected Obj, but got Unknown
			//IL_0565: Unknown result type (might be due to invalid IL or missing references)
			//IL_056a: Expected Obj, but got Unknown
			//IL_01da: Expected I, but got Obj
			//IL_0362: Unknown result type (might be due to invalid IL or missing references)
			//IL_0367: Expected Obj, but got Unknown
			//IL_037e: Expected I, but got Obj
			//IL_0394: Expected Obj, but got I
			//IL_0227: Expected I, but got Obj
			//IL_023d: Expected Obj, but got I
			//IL_00ff: Expected I, but got Obj
			//IL_0401: Unknown result type (might be due to invalid IL or missing references)
			//IL_0406: Expected Obj, but got Unknown
			//IL_041d: Expected I, but got Obj
			//IL_0433: Expected Obj, but got I
			//IL_0268: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<Material> list = default;
			list._002Ector();
			MeshRenderer[] componentsInChildren = GetComponentsInChildren<MeshRenderer>(includeInactive: true);
			if (componentsInChildren != null)
			{
				nint num = (nint)typeof(ColorTeleboardEffect._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v74 (Il2CppClass<ColorTeleboardEffect+<>c>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(ColorTeleboardEffect._003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v113 (Il2CppClass<ColorTeleboardEffect+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = ColorTeleboardEffect._003C_003Ec._003C_003E9__2_0 == null;
				bool flag2 = !flag;
				Func<MeshRenderer, Material> selector = ColorTeleboardEffect._003C_003Ec._003C_003E9__2_0;
				if (!flag2)
				{
					nint num3 = (nint)typeof(ColorTeleboardEffect._003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v87 (Il2CppClass<ColorTeleboardEffect+<>c>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(ColorTeleboardEffect._003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v107 (Il2CppClass<ColorTeleboardEffect+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num5 = 0;
					_ = 0;
					Func<MeshRenderer, Material> func = default;
					object obj3 = func + 16;
					obj3 = ColorTeleboardEffect._003C_003Ec._003C_003E9;
					nint num6 = (nint)typeof(ColorTeleboardEffect._003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v104 (Il2CppClass<ColorTeleboardEffect+<>c>)+5C]");
					object obj4 = (nint)0 + (nint)4;
					obj4 = func;
					selector = func;
				}
				IEnumerable<Material> enumerable = Enumerable.Select(componentsInChildren, selector);
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S3_v9 (Il2CppMethodInfo)+C]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S3_v10+60]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S3_v11+38]");
				object obj7 = 0;
				object obj8 = obj7 & 0x1FFF;
				object obj9 = obj8 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v42 @ S4_v10 (should have been resolved before IL gen)");
			}
			nint num8 = (nint)typeof(CharacterRendering);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v12 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num9 = (nint)typeof(CharacterRendering);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v69 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterCamera instance = CharacterCamera.Instance;
			float previousCameraEndXRotation = instance._previousCameraEndXRotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v18 (System.Single)+6C]");
			MeshRenderer[] componentsInChildren2 = ((Component)0).GetComponentsInChildren<MeshRenderer>(includeInactive: true);
			if (componentsInChildren2 != null)
			{
				nint num10 = (nint)typeof(ColorTeleboardEffect._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v24 (Il2CppClass<ColorTeleboardEffect+<>c>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num11 = (nint)typeof(ColorTeleboardEffect._003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v63 (Il2CppClass<ColorTeleboardEffect+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = ColorTeleboardEffect._003C_003Ec._003C_003E9__2_1 == null;
				bool flag4 = !flag3;
				Func<MeshRenderer, Material> selector2 = ColorTeleboardEffect._003C_003Ec._003C_003E9__2_1;
				if (!flag4)
				{
					nint num12 = (nint)typeof(ColorTeleboardEffect._003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v37 (Il2CppClass<ColorTeleboardEffect+<>c>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num13 = (nint)typeof(ColorTeleboardEffect._003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v57 (Il2CppClass<ColorTeleboardEffect+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num14 = 0;
					_ = 0;
					Func<MeshRenderer, Material> func2 = default;
					object obj13 = func2 + 16;
					obj13 = ColorTeleboardEffect._003C_003Ec._003C_003E9;
					nint num15 = (nint)typeof(ColorTeleboardEffect._003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v54 (Il2CppClass<ColorTeleboardEffect+<>c>)+5C]");
					object obj14 = (nint)0 + (nint)8;
					obj14 = func2;
					selector2 = func2;
				}
				IEnumerable<Material> enumerable2 = Enumerable.Select(componentsInChildren2, selector2);
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S3_v4 (Il2CppMethodInfo)+C]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S3_v5+60]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S3_v6+38]");
				object obj17 = 0;
				object obj18 = obj17 & 0x1FFF;
				object obj19 = obj18 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v181 @ S4_v6 (should have been resolved before IL gen)");
			}
			return (JumpStyle)list;
		}
	}

	public void Initialize()
	{
		CancelInvoke();
	}

	public void InitializeMenu(HoverboardModelPreviewFactory factory)
	{
		//IL_0063: Expected I4, but got Obj
		//IL_002f: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (playThruster)+34]");
		if ((nint)0 > (nint)(-1))
		{
			Hoverboard hoverboard = _hoverboard;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (playThruster)+34]");
			GameObject gameObject = ((List<GameObject>)(object)hoverboard).get_Item(0);
			((HoverboardBundle)null).AddCustomBaseModel((int)gameObject, false);
		}
		Hoverboard hoverboard2 = _hoverboard;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (playThruster)+34]");
		GameObject gameObject2 = ((List<GameObject>)(object)hoverboard2).get_Item(0);
		((HoverboardBundle)null).AddCustomBaseModel((int)gameObject2, true);
	}

	private unsafe void OnEnable()
	{
		//IL_03db: Expected I, but got Obj
		//IL_03f1: Expected Obj, but got I
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected Obj, but got Unknown
		//IL_041c: Expected I, but got Obj
		//IL_0432: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0082: Expected Obj, but got I4
		//IL_01fb: Expected I, but got Obj
		//IL_032e: Expected I, but got Obj
		//IL_0344: Expected Obj, but got I
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_036f: Expected I, but got Obj
		//IL_00e0: Expected I4, but got Obj
		nint num = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Hoverboard>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v75 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 12;
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		obj2 = characterModifier;
		if (_renderes != null)
		{
			object obj3 = this + 36;
			Renderer[] renderes = _renderes;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj4 = default;
			obj3 = obj4;
			object obj5 = 0;
			Renderer[] renderes2 = _renderes;
			if ((nint)obj5 < renderes2.Length)
			{
				object obj6 = _renderes + 16;
				object obj7 = obj5 << 2;
				object obj8 = obj6 + obj7;
				Animation component = ((Component)obj8).GetComponent<Animation>();
				UnityEngine.Object obj9 = UnityEngine.Object.Instantiate((UnityEngine.Object)_clip);
				bool flag = component.Play((PlayMode)obj9);
				throw new ArrayTypeMismatchException();
			}
		}
		nint num3 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v16 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num4 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v43 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj11 = this + 40;
		CharacterRendering instance = CharacterRendering.Instance;
		obj11 = instance;
		if (_jumpStyle == JumpStyle.Super)
		{
			addedEvent = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Character.OnJumpDelegate onJumpDelegate = default;
			((Delegate)onJumpDelegate).method_ptr = method_ptr;
			((Delegate)onJumpDelegate).method = (nint)__ldftn(playThruster.Character_OnJump);
			object obj12 = onJumpDelegate + 16;
			obj12 = this;
			_character.OnJump -= onJumpDelegate;
		}
		if (_jumpStyle == JumpStyle.Double)
		{
			addedEvent = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			Character.OnDoubleJumpDelegate onDoubleJumpDelegate = default;
			((Delegate)onDoubleJumpDelegate).method_ptr = method_ptr2;
			((Delegate)onDoubleJumpDelegate).method = (nint)__ldftn(playThruster.Character_OnDoubleJump);
			object obj13 = onDoubleJumpDelegate + 16;
			obj13 = this;
			_character.OnDoubleJump -= onDoubleJumpDelegate;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_particles).FindKernel((string)null) != 0)
		{
			GameObject gameObject = _particles.gameObject;
			((Transform)(object)gameObject).parentInternal = null;
		}
	}

	private unsafe void OnDisable()
	{
		//IL_0225: Expected I, but got Obj
		//IL_023b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_character != null)
		{
			return;
		}
		if (~(addedEvent ? 1u : 0u) != 0)
		{
			if (_jumpStyle == JumpStyle.Super)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				Character.OnJumpDelegate onJumpDelegate = default;
				((Delegate)onJumpDelegate).method_ptr = method_ptr;
				((Delegate)onJumpDelegate).method = (nint)__ldftn(playThruster.Character_OnJump);
				object obj2 = onJumpDelegate + 16;
				obj2 = this;
				_character.OnJump -= onJumpDelegate;
			}
			if (_jumpStyle == JumpStyle.Double)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr2 = 0;
				Character.OnDoubleJumpDelegate onDoubleJumpDelegate = default;
				((Delegate)onDoubleJumpDelegate).method_ptr = method_ptr2;
				((Delegate)onDoubleJumpDelegate).method = (nint)__ldftn(playThruster.Character_OnDoubleJump);
				object obj3 = onDoubleJumpDelegate + 16;
				obj3 = this;
				_character.OnDoubleJump -= onDoubleJumpDelegate;
			}
			addedEvent = true;
		}
		if (~(addedMenuEvent ? 1u : 0u) != 0)
		{
			object obj4 = _factory - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr3 = 0;
			Delegate obj5 = default;
			obj5.method_ptr = method_ptr3;
			obj5.method = (nint)__ldftn(playThruster.Factory_OnJump);
			object obj6 = obj5 + 16;
			obj6 = this;
			object obj7 = _factory - -64;
			Delegate obj8 = ((Delegate)obj4).CombineImpl(obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj9 = default;
			obj7 = obj9;
			addedMenuEvent = true;
		}
	}

	private unsafe void OnDestroy()
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		if (~(addedEvent ? 1u : 0u) == 0)
		{
			if (_jumpStyle == JumpStyle.Super)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				Character.OnDoubleJumpDelegate onDoubleJumpDelegate = default;
				((Delegate)onDoubleJumpDelegate).method_ptr = method_ptr;
				((Delegate)onDoubleJumpDelegate).method = (nint)__ldftn(playThruster.Character_OnJump);
				object obj = onDoubleJumpDelegate + 16;
				obj = this;
				_character.OnDoubleJump += onDoubleJumpDelegate;
			}
			if (_jumpStyle == JumpStyle.Double)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr2 = 0;
				Character.OnJumpIfHitByTrainDelegate onJumpIfHitByTrainDelegate = default;
				((Delegate)onJumpIfHitByTrainDelegate).method_ptr = method_ptr2;
				((Delegate)onJumpIfHitByTrainDelegate).method = (nint)__ldftn(playThruster.Character_OnDoubleJump);
				object obj2 = onJumpIfHitByTrainDelegate + 16;
				obj2 = this;
				_character.OnJumpIfHitByTrain += onJumpIfHitByTrainDelegate;
			}
			addedEvent = false;
		}
		if (~(addedMenuEvent ? 1u : 0u) == 0)
		{
			object obj3 = _factory - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr3 = 0;
			Delegate obj4 = default;
			obj4.method_ptr = method_ptr3;
			obj4.method = (nint)__ldftn(playThruster.Factory_OnJump);
			object obj5 = obj4 + 16;
			obj5 = this;
			object obj6 = _factory - -64;
			Delegate obj7 = ((Delegate)obj3).RemoveImpl(obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj8 = default;
			obj6 = obj8;
			addedMenuEvent = false;
		}
	}

	private void Factory_OnJump()
	{
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_00b0: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_particles).FindKernel((string)null) == 0)
		{
			return;
		}
		string obj2 = _particles.tag;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj2);
	}

	private void Character_OnDoubleJump()
	{
		((SpeedStripes)this).Initialize((IRouteEffectGUISubject)null);
	}

	private void Character_OnJump(float jumpHeight, bool willPlaySound)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected Obj, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02cc: Expected Obj, but got I4
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02fc: Expected Obj, but got I4
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_0329: Expected Obj, but got I4
		//IL_0345: Expected Obj, but got I
		//IL_0029: Expected Obj, but got I
		//IL_003a: Expected VT, but got Obj
		//IL_004d: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_008e: Expected I, but got Obj
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_017c: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got F4
		//IL_0204: Expected Obj, but got I
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		Material material = (Material)(obj2 + 48);
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 32;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 24;
		obj5 = obj;
		_ = -1;
		((BatTeleboardMenuEffect)this).EndTeleboardEffect(jumpHeight, (CharacterModel)willPlaySound);
		float num = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (playThruster)+34]");
		float num2 = num / 0f;
		object obj6 = this + 56;
		GameObject gameObject = ((HoverboardBundle)this).InstatiateAndParentModelPrefab((GameObject)willPlaySound);
		obj6 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (playThruster)+38]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v29+C]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (playThruster)+38]");
		Material material2 = ((List<Material>)0).get_Item(0);
		material.mainTextureOffset = (Vector2)material2;
		nint num3 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v23 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v74 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float t = (float)material + num2;
		float num5 = Mathf.PingPong(t, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj9 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj9 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj2 = 0;
			obj2 = num5;
			_ = 0f;
			obj3 = obj2;
			material = (Material)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj10 = obj5 + 4;
		object obj11 = obj10 + 1;
		obj10 = obj11;
		object obj12 = obj11 << 2;
		object obj13 = obj5 + obj12;
		obj13 = 146;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+4]");
			object obj14 = (nint)0 << 2;
			object obj15 = obj5 + obj14;
			if ((nint)obj15 == 146)
			{
				object obj16 = obj5 + 4;
				if ((nint)obj16 > -1)
				{
					object obj17 = obj16 + -1;
					obj16 = obj17;
				}
				return;
			}
		}
		object obj18 = default;
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private unsafe void PlayEffects(bool playParticleEffect = true)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0029: Expected Obj, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		if (~(addedMenuEvent ? 1u : 0u) != 0)
		{
			OnEnable();
			addedMenuEvent = true;
			object obj = this + 44;
			obj = playParticleEffect;
			object obj2 = _factory - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Delegate obj3 = default;
			obj3.method_ptr = method_ptr;
			obj3.method = (nint)__ldftn(playThruster.Factory_OnJump);
			object obj4 = obj3 + 16;
			obj4 = this;
			object obj5 = _factory - -64;
			Delegate obj6 = ((Delegate)obj2).CombineImpl(obj3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj7 = default;
			obj5 = obj7;
		}
	}

	public playThruster()
	{
		//IL_0010: Expected VT, but got I4
		((SpeedStripes)this).Deactivate(0f, (Color)0);
	}

	private void _003CPlayEffects_003Eb__22_0(float t)
	{
		//IL_0494: Expected I, but got Obj
		//IL_04aa: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_04d1: Expected Obj, but got F4
		//IL_04ed: Expected F4, but got I4
		//IL_050f: Invalid comparison between Obj and F4
		//IL_0546: Invalid comparison between F4 and I4
		//IL_0273: Invalid comparison between F4 and I4
		//IL_00ee: Expected Obj, but got I4
		//IL_03d9: Expected I, but got Obj
		//IL_03ef: Expected Obj, but got I
		//IL_01a0: Expected I, but got Obj
		//IL_01b6: Expected Obj, but got I
		//IL_0641: Expected Obj, but got I4
		//IL_03ab: Expected I4, but got Obj
		//IL_0593: Expected Obj, but got I
		//IL_041a: Expected I, but got Obj
		//IL_02dd: Expected I, but got Obj
		//IL_02f3: Expected Obj, but got I
		//IL_01e1: Expected I, but got Obj
		//IL_0480: Expected I4, but got Obj
		//IL_0480: Expected Obj, but got I4
		//IL_05de: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I4
		//IL_031e: Expected I, but got Obj
		//IL_036e: Expected Obj, but got I
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v90 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3;
		if (t < 0f)
		{
			num3 = 0f;
		}
		else
		{
			num3 = ((!(t > 1f)) ? t : 1f);
		}
		_particles = (ParticleSystem)num3;
		ParticleSystem particles = _particles;
		ParticleSystem particles2 = _particles;
		bool flag = System.Runtime.CompilerServices.Unsafe.As<ParticleSystem, UIntPtr>(ref particles) < System.Runtime.CompilerServices.Unsafe.As<ParticleSystem, UIntPtr>(ref particles2);
		thrusterPlayTime = (flag ? 1 : 0);
		ParticleSystem particles3 = _particles;
		ParticleSystem particles4 = _particles;
		bool flag2 = System.Runtime.CompilerServices.Unsafe.As<ParticleSystem, UIntPtr>(ref particles3) < System.Runtime.CompilerServices.Unsafe.As<ParticleSystem, UIntPtr>(ref particles4);
		bool wrapMode;
		AnimationState states;
		if (_particles == (object)1f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (playThruster)+1E]");
			if ((nint)0 == 0)
			{
				((AnimationState)(object)_states).wrapMode = WrapMode.Once;
				Animation.INTERNAL_CALL_Sample((Animation)_jumpStyle);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (playThruster)+1E]");
			wrapMode = (nint)0 != 0;
			states = (AnimationState)(object)_states;
			goto IL_052e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (playThruster)+1F]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (playThruster)+1D]");
			if ((nint)0 != 0)
			{
				((AnimationState)(object)_states).wrapMode = WrapMode.Once;
				((AnimationState)(object)_states).layer = 2;
				((AnimationState)(object)_states).speed = 0f;
				_ = 0;
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S1_v64 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S1_v71 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (playThruster)+34]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					Vector3 focusPoint = ((AvatarEyeAnimation)10).GetFocusPoint();
				}
				goto IL_05b4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (playThruster)+1E]");
		if ((nint)0 == 0 && thrusterPlayTime != 0f)
		{
			((AnimationState)(object)_states).layer = 8;
			float speed = ((AnimationState)(object)_states).speed;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CE");
			float speed2 = default;
			((AnimationState)(object)_states).speed = speed2;
			_ = 1;
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S1_v49 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S1_v55 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (playThruster)+34]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (playThruster)+34]");
				((AvatarEyeAnimation)0).ForceBlink();
			}
		}
		goto IL_05b4;
		IL_052e:
		states.wrapMode = (wrapMode ? WrapMode.Once : WrapMode.Default);
		bool flag3 = thrusterPlayTime != 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (playThruster)+1D]");
		bool flag4 = (nint)0 != 0;
		int num8 = 0;
		while (true)
		{
			HoverboardModelPreviewFactory factory = _factory;
			if (num8 >= (nint)factory.hoverboards)
			{
				break;
			}
			Material material = ((List<Material>)(object)_factory).get_Item(num8);
			float value = (float)_particles * (float)_renderes;
			((SkinnedMeshRenderer)(object)material).SetBlendShapeWeight((int)"_ShiftColor", value);
			int num9 = num8 + 1;
			num8 = num9;
		}
		nint num10 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)addedEvent).FindKernel(null) != 0)
		{
			float value2 = (float)_particles * (float)_hoverboard;
			((SkinnedMeshRenderer)addedEvent).SetBlendShapeWeight((int)"_Fade", value2);
		}
		return;
		IL_05b4:
		states = (AnimationState)(object)_states;
		wrapMode = true;
		goto IL_052e;
	}
}
