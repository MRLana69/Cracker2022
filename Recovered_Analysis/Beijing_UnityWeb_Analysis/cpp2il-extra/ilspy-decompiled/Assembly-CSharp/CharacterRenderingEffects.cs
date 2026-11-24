using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using SYBO.Subway.StateSystem;
using SYBO.Subway.Themes;
using SYBO.Subway.Visuals;
using UnityEngine;
using UnityEngine.Rendering;

internal class CharacterRenderingEffects : MonoBehaviour
{
	public delegate void OnDoubleJumpDelegate();

	private Renderer leftJumpThruster;

	private Renderer rightJumpThruster;

	private float thrusterPlayTime;

	private Transform _scoreBoosterRoot;

	private Animation _scoreBoostAnimation;

	private ParticleSystem _scoreBoostParticle;

	private GameObject jetpackParticles;

	private GameObject pogostickParticles;

	public ParticleFollow pogostickParticleCloud;

	public ParticleFollow jetpackParticleCloudL;

	public ParticleFollow jetpackParticleCloudR;

	private OnDoubleJumpDelegate m_OnDoubleJump;

	private GameObject dustPrefab;

	private ParticleSystem dustParticles;

	private AnimationState leftJumpThrusterState;

	private AnimationState rightJumpThrusterState;

	private Vector3 _starsOriginalPosition;

	private Character _character;

	private CharacterModel _characterModel;

	private CharacterCamera characterCamera;

	private Hoverboard _hoverboard;

	private RoofedCulling _environmentCulling;

	public GameObject JetpackParticles => (GameObject)(object)rightJumpThruster;

	public GameObject PogostickParticles => jetpackParticles;

	public event OnDoubleJumpDelegate OnDoubleJump
	{
		add
		{
			//IL_0572: Expected VT, but got Obj
			//IL_0583: Invalid comparison between I and F4
			//IL_00fa: Expected VT, but got Obj
			//IL_010b: Invalid comparison between I and F4
			//IL_0612: Unknown result type (might be due to invalid IL or missing references)
			//IL_0617: Expected Obj, but got Unknown
			//IL_0049: Expected I, but got Obj
			//IL_005f: Expected Obj, but got I
			//IL_047d: Expected Obj, but got I4
			//IL_0142: Expected VT, but got Obj
			//IL_0153: Invalid comparison between I and F4
			//IL_079e: Expected I, but got Obj
			//IL_07b4: Expected Obj, but got I
			//IL_01b1: Expected VT, but got Obj
			//IL_01c2: Invalid comparison between I and F4
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Expected Obj, but got Unknown
			//IL_008a: Expected I, but got Obj
			//IL_0915: Unknown result type (might be due to invalid IL or missing references)
			//IL_091a: Expected Obj, but got Unknown
			//IL_0220: Expected VT, but got Obj
			//IL_0231: Invalid comparison between I and F4
			//IL_017f: Expected VT, but got Obj
			//IL_0190: Invalid comparison between I and F4
			//IL_0742: Expected I, but got Obj
			//IL_0758: Expected Obj, but got I
			//IL_0512: Expected Obj, but got I4
			//IL_0490: Expected I, but got Obj
			//IL_028f: Expected VT, but got Obj
			//IL_02a0: Invalid comparison between I and F4
			//IL_01ee: Expected VT, but got Obj
			//IL_01ff: Invalid comparison between I and F4
			//IL_0310: Unknown result type (might be due to invalid IL or missing references)
			//IL_0315: Expected Obj, but got Unknown
			//IL_025d: Expected VT, but got Obj
			//IL_026e: Invalid comparison between I and F4
			//IL_0525: Expected I, but got Obj
			//IL_0658: Unknown result type (might be due to invalid IL or missing references)
			//IL_065d: Expected Obj, but got Unknown
			//IL_02cc: Expected VT, but got Obj
			//IL_02dd: Invalid comparison between I and F4
			//IL_03a0: Expected Obj, but got I4
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_034e: Expected Obj, but got Unknown
			//IL_06b2: Expected I, but got Obj
			//IL_06c8: Expected Obj, but got I
			//IL_0864: Unknown result type (might be due to invalid IL or missing references)
			//IL_0869: Expected Obj, but got Unknown
			//IL_0435: Expected Obj, but got I4
			//IL_03b3: Expected I, but got Obj
			Transform transform = default;
			transform.position = (Vector3)value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
			if (0f > 80f)
			{
				jetpackParticles = null;
				Transform scoreBoosterRoot = _scoreBoosterRoot;
				float defaultValue = (float)pogostickParticles / 48f;
				float num = PlayerPrefs.GetFloat((string)(object)jetpackParticleCloudL, defaultValue);
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v90 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S2_v98 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AE");
				Transform scoreBoosterRoot2 = _scoreBoosterRoot;
				float defaultValue2 = (float)pogostickParticles / 48f;
				float num4 = PlayerPrefs.GetFloat((string)(object)jetpackParticleCloudL, defaultValue2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AE");
				GameObject gameObject = (GameObject)(pogostickParticles + 1);
				pogostickParticles = gameObject;
			}
			else
			{
				transform.position = (Vector3)value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
				if (0f < 0.1f)
				{
					goto IL_05ef;
				}
				transform.position = (Vector3)value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
				if (0f > 8.795f)
				{
					transform.position = (Vector3)value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
					if (0f < 8.805f)
					{
						goto IL_05ef;
					}
				}
				transform.position = (Vector3)value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
				if (0f > 9.95f)
				{
					transform.position = (Vector3)value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
					if (0f < 10.05f)
					{
						goto IL_05ef;
					}
				}
				transform.position = (Vector3)value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
				if (0f > 28.95f)
				{
					transform.position = (Vector3)value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
					if (0f < 29.05f)
					{
						goto IL_05ef;
					}
				}
				transform.position = (Vector3)value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
				if (0f > 34.95f)
				{
					transform.position = (Vector3)value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
					if (0f < 35.05f)
					{
						goto IL_05ef;
					}
				}
				pogostickParticles = null;
				ParticleFollow particleFollow = pogostickParticleCloud;
				object obj2 = particleFollow.Target - 1;
				GameObject gameObject2 = jetpackParticles;
				if (System.Runtime.CompilerServices.Unsafe.As<GameObject, UIntPtr>(ref gameObject2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
				{
					GameObject gameObject3 = (GameObject)(jetpackParticles + 1);
					jetpackParticles = gameObject3;
				}
				Transform scoreBoosterRoot3 = _scoreBoosterRoot;
				object obj3 = pogostickParticleCloud + 16;
				ParticleFollow particleFollow2 = pogostickParticleCloud;
				object obj6;
				if ((object)particleFollow2.Target != null)
				{
					object obj4 = (object)jetpackParticles / (object)particleFollow2.Target;
					object obj5 = obj4 * (object)particleFollow2.Target;
					obj6 = (object)jetpackParticles - obj5;
				}
				else
				{
					obj6 = 0;
				}
				object obj7 = obj6 << 2;
				object obj8 = obj3 + obj7;
				nint num5 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S2_v57 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num6 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S2_v74 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num7 = (float)obj8 / 12f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AE");
				object obj10 = default;
				float num8 = (float)obj10 * 0.5f;
				Transform scoreBoosterRoot4 = _scoreBoosterRoot;
				object obj11 = pogostickParticleCloud + 16;
				ParticleFollow particleFollow3 = pogostickParticleCloud;
				object obj14;
				if ((object)particleFollow3.Target != null)
				{
					object obj12 = (object)jetpackParticles / (object)particleFollow3.Target;
					object obj13 = obj12 * (object)particleFollow3.Target;
					obj14 = (object)jetpackParticles - obj13;
				}
				else
				{
					obj14 = 0;
				}
				object obj15 = obj14 << 2;
				object obj16 = obj11 + obj15;
				float num9 = (float)obj16 / 12f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AE");
				object obj17 = default;
				float num10 = (float)obj17 * 0.5f;
			}
			goto IL_0734;
			IL_05ef:
			pogostickParticles = null;
			jetpackParticles = null;
			Transform scoreBoosterRoot5 = _scoreBoosterRoot;
			object obj18 = pogostickParticleCloud + 16;
			ParticleFollow particleFollow4 = pogostickParticleCloud;
			object obj21;
			if ((object)particleFollow4.Target != null)
			{
				object obj19 = (object)jetpackParticles / (object)particleFollow4.Target;
				object obj20 = obj19 * (object)particleFollow4.Target;
				obj21 = (object)jetpackParticles - obj20;
			}
			else
			{
				obj21 = 0;
			}
			object obj22 = obj21 << 2;
			object obj23 = obj18 + obj22;
			nint num11 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S2_v16 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num12 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S2_v33 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num13 = (float)obj23 / 12f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AE");
			object obj25 = default;
			float num14 = (float)obj25 * 0.5f;
			Transform scoreBoosterRoot6 = _scoreBoosterRoot;
			object obj26 = pogostickParticleCloud + 16;
			ParticleFollow particleFollow5 = pogostickParticleCloud;
			object obj29;
			if ((object)particleFollow5.Target != null)
			{
				object obj27 = (object)jetpackParticles / (object)particleFollow5.Target;
				object obj28 = obj27 * (object)particleFollow5.Target;
				obj29 = (object)jetpackParticles - obj28;
			}
			else
			{
				obj29 = 0;
			}
			object obj30 = obj29 << 2;
			object obj31 = obj26 + obj30;
			float num15 = (float)obj31 / 12f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AE");
			object obj32 = default;
			float num16 = (float)obj32 * 0.5f;
			goto IL_0734;
			IL_0734:
			nint num17 = (nint)typeof(So);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v14 (Il2CppClass<So>)+BA]");
			object obj33 = (nint)0 & (nint)0x200;
			if (obj33 != null)
			{
				nint num18 = (nint)typeof(So);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v25 (Il2CppClass<So>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)_scoreBoosterRoot, false);
			List<Material> routine = ((ColorTeleboardMenuEffect)this).CollectMaterials((CharacterModel)(object)jetpackParticleCloudR);
			Coroutine coroutine = StartCoroutine_Auto((IEnumerator)routine);
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnDoubleJump;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 56;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	private unsafe void Awake()
	{
		//IL_0016: Expected Obj, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected I4, but got Unknown
		//IL_0031: Expected I4, but got Obj
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj = 0;
		CallingConvention callingConvention = (CallingConvention)(obj + 4);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		object obj2 = this + 44;
		obj2 = unmanagedFunctionPointerAttribute;
		CancelInvoke();
	}

	public void Initialize(CharacterModel characterModel)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_OnDoubleJump;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)characterModel);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 56;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	public void InitializeModel(CharacterModel characterModel)
	{
		//IL_00fb: Expected I, but got Obj
		//IL_0111: Expected Obj, but got I
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_01f9: Expected I, but got Obj
		//IL_020f: Expected Obj, but got I
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_014a: Expected Obj, but got I4
		//IL_0158: Expected I, but got Obj
		//IL_016e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v38 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 88;
		CharacterRendering instance = CharacterRendering.Instance;
		obj2 = instance;
		object obj3 = this + 92;
		obj3 = characterModel;
		nint num3 = (nint)typeof(CharacterCamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v15 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(CharacterCamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v34 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = this + 96;
		int selectedBenchmarkIndex = SubwayBenchmarkContainer.SelectedBenchmarkIndex;
		obj5 = selectedBenchmarkIndex;
		nint num5 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v22 (Il2CppClass<Hoverboard>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v30 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = this + 100;
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		obj7 = characterModifier;
		RecreateModel(characterModel);
		PlayDoubleJumpThruster();
	}

	public void RecreateModel(CharacterModel characterModel)
	{
		//IL_0018: Expected I4, but got Obj
		((ATeleboardMenuEffect)this).Initialize(characterModel._leftFoot, (byte)(int)characterModel._rightFoot != 0);
	}

	private void SetupScoorboosterFX()
	{
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_018a: Expected I, but got Obj
		//IL_01a0: Expected Obj, but got I
		//IL_01d6: Expected Obj, but got I
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0214: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I4
		//IL_00b1: Expected I, but got Obj
		//IL_0106: Expected Obj, but got I
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		FallingSnowThemeEffect fallingSnowThemeEffect = default;
		fallingSnowThemeEffect.Game_OnGameStarted();
		object obj = this + 104;
		obj = fallingSnowThemeEffect;
		nint num = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v43 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameStateMachine instance = GameStateMachine.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+60]");
		if ((nint)0 != 0)
		{
			_environmentCulling.Game_OnGameStarted();
		}
		nint num3 = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v37 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameStateMachine instance2 = GameStateMachine.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v26 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27+5C]");
		object obj6 = (nint)0 + (nint)12;
		object obj7 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27+5C]");
			object obj8 = (nint)0 + (nint)16;
			object obj9 = obj7 << 2;
			object obj10 = obj8 + obj9;
			GameObject gameObject = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			object obj11 = obj7 + 1;
			obj7 = obj11;
		}
	}

	private unsafe void SetupDoubleJumpThrusters(Transform leftFoot, Transform rightFoot)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0092: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		object obj3 = obj2 + 12;
		obj3 = rightFoot;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(CharacterModelPreviewFactory._003C_003Ec__DisplayClass13_0._003CGetFacebookScreenModel_003Eb__0);
		object obj4 = action + 16;
		obj4 = obj2;
		((CoinEarnerVideoAds)this).Init((int)leftFoot, (string)null, (string)null, (string)null, 0, action, (UIScrollView)null);
	}

	public void PlayScoreboostFX(int version)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		//IL_0031: Expected Obj, but got I
		object obj = this + 92;
		obj = version;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [version @ L1 (System.Int32)+B8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [version @ L1 (System.Int32)+BC]");
		((ATeleboardMenuEffect)this).Initialize((Transform)num, false);
	}

	public void PlayDoubleJumpThruster()
	{
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		GameObject parentInternal = _character.gameObject;
		_scoreBoosterRoot.parentInternal = (Transform)(object)parentInternal;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v35 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 32;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj3 + 48);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v12+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v18 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v31 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj3 + 16;
		Vector2 zero = Vector2.zero;
		transform = (Transform)obj5;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v23+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj3;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		_scoreBoosterRoot.parent = transform;
	}

	public void SetRightAndLeftParticlesActive(bool active)
	{
		//IL_00b9: Expected Obj, but got I4
		object obj = (active ? 1 : 0) - 1;
		if (!active)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj == 2)
				{
					AnimationState animationState = _scoreBoostAnimation.CrossFadeQueued("ScoreBooster");
					_scoreBoostParticle.Stop();
					characterCamera.ResetShake();
				}
			}
			else
			{
				AnimationState animationState2 = _scoreBoostAnimation.CrossFadeQueued("ScoreBooster");
			}
		}
		else
		{
			AnimationState animationState3 = _scoreBoostAnimation.CrossFadeQueued("ScoreBoosterFirst");
		}
	}

	public void SetPogostickParticlesActive(bool active)
	{
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_031f: Expected I, but got Obj
		//IL_0335: Expected Obj, but got I
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_00ab: Expected I, but got Obj
		//IL_0266: Expected Obj, but got I4
		//IL_028f: Expected Obj, but got I4
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		ParticleFollow particleFollow = jetpackParticleCloudL;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v62 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (particleFollow.Target == null)
		{
			ParticleFollow particleFollow2 = jetpackParticleCloudR;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v56 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!(particleFollow2.Target != null))
			{
				goto IL_0394;
			}
		}
		object obj5 = jetpackParticleCloudL + 12;
		CharacterModel characterModel = _characterModel;
		obj5 = characterModel._jetpackCloudPositionL;
		object obj6 = jetpackParticleCloudR + 12;
		CharacterModel characterModel2 = _characterModel;
		obj6 = characterModel2._jetpackCloudPositionR;
		goto IL_0394;
		IL_0394:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			bool flag = (nint)0 != 0;
			jetpackParticles.tag = (string)flag;
			string text = jetpackParticleCloudL.tag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			bool flag2 = (nint)0 != 0;
			((GameObject)(object)text).tag = (string)flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			bool flag3 = (nint)0 != 0;
			jetpackParticleCloudL.tag = (string)flag3;
			string text2 = jetpackParticleCloudR.tag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			bool flag4 = (nint)0 != 0;
			((GameObject)(object)text2).tag = (string)flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			bool flag5 = (nint)0 != 0;
			jetpackParticleCloudR.tag = (string)flag5;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			bool flag6 = (nint)0 != 0;
			jetpackParticleCloudL.tag = (string)flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			bool flag7 = (nint)0 != 0;
			jetpackParticleCloudR.tag = (string)flag7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			object obj8 = default;
			object obj7 = obj8 + 16;
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
			IEnumerator routine = default;
			Coroutine coroutine = StartCoroutine_Auto(routine);
		}
	}

	public void ToggleDust(bool active)
	{
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		ParticleFollow particleFollow = pogostickParticleCloud;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (particleFollow.Target != null)
		{
			object obj4 = pogostickParticleCloud + 12;
			CharacterModel characterModel = _characterModel;
			obj4 = characterModel._attachPoint1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			bool flag = (nint)0 != 0;
			pogostickParticles.tag = (string)flag;
			string text = pogostickParticleCloud.tag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			bool flag2 = (nint)0 != 0;
			((GameObject)(object)text).tag = (string)flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			bool flag3 = (nint)0 != 0;
			pogostickParticleCloud.tag = (string)flag3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			bool flag4 = (nint)0 != 0;
			pogostickParticleCloud.tag = (string)flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			object obj6 = default;
			object obj5 = obj6 + 16;
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
			IEnumerator routine = default;
			Coroutine coroutine = StartCoroutine_Auto(routine);
		}
	}

	private void Update()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		Hoverboard hoverboard = _hoverboard;
		if (~(hoverboard.isActive ? 1u : 0u) == 0)
		{
			if (this.m_OnDoubleJump != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			}
			return;
		}
		leftJumpThruster.shadowCastingMode = ShadowCastingMode.On;
		rightJumpThruster.shadowCastingMode = ShadowCastingMode.On;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
		IEnumerator routine = default;
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	public CharacterRenderingEffects()
	{
		//IL_015a: Expected I, but got Obj
		//IL_0170: Expected Obj, but got I
		//IL_02a6: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_025a: Expected I, but got Obj
		//IL_0270: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I
		//IL_007e: Expected I, but got Obj
		//IL_00cb: Expected I, but got Obj
		//IL_00e1: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I
		//IL_020c: Expected Obj, but got I
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_010c: Expected I, but got Obj
		nint num = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v42 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameStateMachine instance = GameStateMachine.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12+60]");
		if ((nint)0 != 0)
		{
			_environmentCulling._002Ector();
		}
		object obj3 = 0;
		while (true)
		{
			nint num3 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v18 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(ThemeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v36 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameStateMachine instance2 = GameStateMachine.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v7 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v8+5C]");
			object obj6 = 0;
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v9+C]");
			if ((nint)obj7 >= 0)
			{
				break;
			}
			nint num5 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v25 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num6 = (nint)typeof(ThemeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameStateMachine instance3 = GameStateMachine.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v13 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v14+5C]");
			object obj10 = (nint)0 + (nint)16;
			object obj11 = obj3 << 2;
			object obj12 = obj10 + obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			object obj13 = obj3 + 1;
			obj3 = obj13;
		}
	}

	private void _003CPlayDoubleJumpThruster_003Eb__36_0(float t)
	{
		//IL_001e: Expected I4, but got Obj
		//IL_001e: Expected Obj, but got F4
		//IL_0034: Expected Obj, but got I4
		UnityEngine.Object obj = UnityEngine.Object.Instantiate((UnityEngine.Object)_scoreBoosterRoot);
		bool flag = ((Animation)thrusterPlayTime).Play((PlayMode)obj);
		((CharacterController)flag).height = t;
	}
}
