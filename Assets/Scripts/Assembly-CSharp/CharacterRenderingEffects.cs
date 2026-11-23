using System;
using Cpp2ILInjected;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using SYBO.Subway.Themes;
using SYBO.Subway.Visuals;
using UnityEngine;

internal class CharacterRenderingEffects : MonoBehaviour
{
	public delegate void OnDoubleJumpDelegate();

	private Renderer leftJumpThruster;

	private Renderer rightJumpThruster;

	private float thrusterPlayTime = 0.2f;

	private Transform _scoreBoosterRoot;

	private Animation _scoreBoostAnimation;

	private ParticleSystem _scoreBoostParticle;

	private GameObject jetpackParticles;

	private GameObject pogostickParticles;

	public ParticleFollow pogostickParticleCloud;

	public ParticleFollow jetpackParticleCloudL;

	public ParticleFollow jetpackParticleCloudR;

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

	private OnDoubleJumpDelegate m_OnDoubleJump;

	public GameObject JetpackParticles => jetpackParticles;

	public GameObject PogostickParticles => pogostickParticles;

	public event OnDoubleJumpDelegate OnDoubleJump
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 104;
			Delegate obj2 = this.m_OnDoubleJump;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 104;
			Delegate obj2 = this.m_OnDoubleJump;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	private void Awake()
	{
		//IL_006a: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		RoofedCulling roofedCulling = default;
		roofedCulling._002Ector();
		_environmentCulling = roofedCulling;
		ThemeManager instance = ThemeManager.Instance;
		Theme theme = instance._theme;
		if (~(theme._roofedCullingEnabled ? 1u : 0u) == 0)
		{
			_environmentCulling.Initialize();
		}
		ThemeManager instance2 = ThemeManager.Instance;
		Theme theme2 = instance2._theme;
		ThemeEffect[] effects = theme2._effects;
		object obj = 0;
		while (effects.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)effects + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v24+10]");
			object obj4 = 0;
			Transform transform = base.transform;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S2_v5+DC] (should have been resolved before IL gen)");
			object obj6 = obj + 1;
			obj = obj6;
		}
	}

	public void Initialize(CharacterModel characterModel)
	{
		Character instance = Character.Instance;
		_character = instance;
		_characterModel = characterModel;
		CharacterCamera instance2 = CharacterCamera.Instance;
		characterCamera = instance2;
		Hoverboard instance3 = Hoverboard.Instance;
		_hoverboard = instance3;
		InitializeModel(characterModel);
		SetupScoorboosterFX();
	}

	public void InitializeModel(CharacterModel characterModel)
	{
		SetupDoubleJumpThrusters(characterModel._leftFoot, characterModel._rightFoot);
	}

	public void RecreateModel(CharacterModel characterModel)
	{
		_characterModel = characterModel;
		SetupDoubleJumpThrusters(characterModel._leftFoot, characterModel._rightFoot);
	}

	private unsafe void SetupScoorboosterFX()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0044: Expected I, but got Obj
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected VT, but got Unknown
		//IL_00b1: Expected I, but got Obj
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected VT, but got Unknown
		//IL_011e: Expected I, but got Obj
		//IL_0143: Expected F4, but got I
		//IL_013e: Expected native int or pointer, but got VT
		//IL_0151: Expected F4, but got VT
		//IL_014c: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		Transform parent = _character.transform;
		_scoreBoosterRoot.parent = parent;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 localPosition = vector + 32;
		_scoreBoosterRoot.localPosition = localPosition;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v28 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(vector + 16);
		_scoreBoosterRoot.localRotation = localRotation;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v27 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v28 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		_scoreBoosterRoot.localScale = vector;
	}

	private unsafe void SetupDoubleJumpThrusters(Transform leftFoot, Transform rightFoot)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected VT, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected VT, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected VT, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected VT, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected VT, but got Unknown
		//IL_0263: Expected F4, but got I
		//IL_025e: Expected native int or pointer, but got VT
		//IL_0285: Expected F4, but got I
		//IL_0280: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 192);
		Transform transform = leftJumpThruster.transform;
		transform.parent = leftFoot;
		leftJumpThruster.enabled = false;
		Transform transform2 = leftJumpThruster.transform;
		_ = -1085485875;
		_ = -1085485875;
		_ = 4503599627370496000L;
		_ = 4503599627370496000L;
		Vector3 localPosition = (Vector3)(quaternion + 80);
		transform2.localPosition = localPosition;
		Transform transform3 = leftJumpThruster.transform;
		_ = 0.61086524f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+A8]");
		_ = 0;
		_ = (float)Math.PI / 2f;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+A0]");
		_ = 0;
		Vector3 euler = (Vector3)(quaternion - -64);
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+B0]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(quaternion + 48);
		transform3.localRotation = localRotation;
		Animation component = leftJumpThruster.GetComponent<Animation>();
		AnimationState animationState = component.get_Item("POOF");
		leftJumpThrusterState = animationState;
		leftJumpThrusterState.enabled = true;
		leftJumpThrusterState.weight = 1f;
		Transform transform4 = rightJumpThruster.transform;
		transform4.parent = rightFoot;
		rightJumpThruster.enabled = false;
		Transform transform5 = rightJumpThruster.transform;
		_ = 1061997773;
		_ = 1061997773;
		_ = -4719772409484279808L;
		_ = -4719772409484279808L;
		Vector3 localPosition2 = (Vector3)(quaternion + 32);
		transform5.localPosition = localPosition2;
		Transform transform6 = rightJumpThruster.transform;
		_ = 5.67232f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+A8]");
		_ = 0;
		_ = 4.712389f;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+A0]");
		_ = 0;
		Vector3 euler2 = (Vector3)(quaternion + 16);
		Quaternion quaternion3 = Quaternion.Internal_FromEulerRad(euler2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+B8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+B0]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		transform6.localRotation = quaternion;
		Animation component2 = rightJumpThruster.GetComponent<Animation>();
		AnimationState animationState2 = component2.get_Item("POOF");
		rightJumpThrusterState = animationState2;
		rightJumpThrusterState.enabled = true;
		rightJumpThrusterState.weight = 1f;
	}

	public void PlayScoreboostFX(int version)
	{
		//IL_00b1: Expected Obj, but got I4
		object obj = version - 1;
		if (version != 1)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj == 2)
				{
					bool flag = _scoreBoostAnimation.Play("ScoreBooster");
					_scoreBoostParticle.Play();
					characterCamera.Shake();
				}
			}
			else
			{
				bool flag2 = _scoreBoostAnimation.Play("ScoreBooster");
			}
		}
		else
		{
			bool flag3 = _scoreBoostAnimation.Play("ScoreBoosterFirst");
		}
	}

	public void PlayDoubleJumpThruster()
	{
		Hoverboard hoverboard = _hoverboard;
		if (~(hoverboard.isActive ? 1u : 0u) != 0)
		{
			leftJumpThruster.enabled = true;
			rightJumpThruster.enabled = true;
			throw new ArgumentException();
		}
		OnDoubleJumpDelegate onDoubleJump = this.m_OnDoubleJump;
		if (this.m_OnDoubleJump != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v22.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void SetRightAndLeftParticlesActive(bool active)
	{
		ParticleFollow particleFollow = jetpackParticleCloudL;
		if (!(particleFollow.Target == null))
		{
			ParticleFollow particleFollow2 = jetpackParticleCloudR;
			if (!(particleFollow2.Target == null))
			{
				goto IL_01d1;
			}
		}
		ParticleFollow particleFollow3 = jetpackParticleCloudL;
		CharacterModel characterModel = _characterModel;
		particleFollow3.Target = characterModel._jetpackCloudPositionL;
		ParticleFollow particleFollow4 = jetpackParticleCloudR;
		CharacterModel characterModel2 = _characterModel;
		particleFollow4.Target = characterModel2._jetpackCloudPositionR;
		goto IL_01d1;
		IL_01d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+C]");
		if ((nint)0 != 0)
		{
			jetpackParticles.SetActive(value: true);
			GameObject gameObject = jetpackParticleCloudL.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+C]");
			gameObject.SetActive(value: false);
			ParticleFollow particleFollow5 = jetpackParticleCloudL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+C]");
			particleFollow5.enabled = false;
			GameObject gameObject2 = jetpackParticleCloudR.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+C]");
			gameObject2.SetActive(value: false);
			ParticleFollow particleFollow6 = jetpackParticleCloudR;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+C]");
			particleFollow6.enabled = false;
			return;
		}
		jetpackParticleCloudL.enabled = false;
		ParticleFollow particleFollow7 = jetpackParticleCloudR;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+C]");
		particleFollow7.enabled = false;
		throw new ArgumentException();
	}

	public void SetPogostickParticlesActive(bool active)
	{
		ParticleFollow particleFollow = pogostickParticleCloud;
		if (particleFollow.Target == null)
		{
			ParticleFollow particleFollow2 = pogostickParticleCloud;
			CharacterModel characterModel = _characterModel;
			particleFollow2.Target = characterModel._attachPoint1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+C]");
		if ((nint)0 != 0)
		{
			pogostickParticles.SetActive(value: true);
			GameObject gameObject = pogostickParticleCloud.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+C]");
			gameObject.SetActive(value: false);
			ParticleFollow particleFollow3 = pogostickParticleCloud;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+C]");
			particleFollow3.enabled = false;
			return;
		}
		pogostickParticleCloud.enabled = false;
		throw new ArgumentException();
	}

	public unsafe void ToggleDust(bool active)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0105: Expected I, but got Obj
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected VT, but got Unknown
		//IL_017d: Expected I, but got Obj
		//IL_01af: Expected F4, but got I
		//IL_01aa: Expected native int or pointer, but got VT
		//IL_01ca: Expected F4, but got I
		//IL_01c5: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		if (dustParticles == null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(dustPrefab);
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v81 @ S4_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
			ParticleSystem particleSystem = default;
			dustParticles = particleSystem;
			Transform transform = gameObject.transform;
			Transform parent = _characterModel.transform;
			transform.parent = parent;
			Transform transform2 = gameObject.transform;
			nint num3 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v36 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v37 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			_ = Quaternion.identityQuaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Quaternion localRotation = (Quaternion)(vector + 16);
			transform2.localRotation = localRotation;
			Transform transform3 = gameObject.transform;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v51 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v52 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			_ = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			transform3.localPosition = vector;
		}
		if (active)
		{
			dustParticles.Play();
		}
		else
		{
			dustParticles.Stop();
		}
	}

	private void Update()
	{
		//IL_004b: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		ThemeManager instance = ThemeManager.Instance;
		Theme theme = instance._theme;
		if (~(theme._roofedCullingEnabled ? 1u : 0u) == 0)
		{
			_environmentCulling.UpdateCulling();
		}
		object obj = 0;
		while (true)
		{
			ThemeManager instance2 = ThemeManager.Instance;
			Theme theme2 = instance2._theme;
			ThemeEffect[] effects = theme2._effects;
			if (effects.Length > (nint)obj)
			{
				ThemeManager instance3 = ThemeManager.Instance;
				Theme theme3 = instance3._theme;
				object obj2 = obj << 2;
				object obj3 = (object)theme3._effects + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v18+10]");
				object obj4 = 0;
				object obj5 = obj4;
				object obj6 = obj4 + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S1_v7+E4] (should have been resolved before IL gen)");
				object obj7 = obj + 1;
				obj = obj7;
				continue;
			}
			break;
		}
	}

	private void _003CPlayDoubleJumpThruster_003Eb__36_0(float t)
	{
		leftJumpThrusterState.normalizedTime = t;
		rightJumpThrusterState.normalizedTime = t;
		if (t == 1f)
		{
			leftJumpThruster.enabled = false;
			rightJumpThruster.enabled = false;
		}
	}
}
