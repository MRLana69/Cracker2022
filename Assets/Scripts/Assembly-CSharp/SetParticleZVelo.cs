using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway;
using UnityEngine;

public class SetParticleZVelo : MonoBehaviour
{
	private float _speedMultiplier;

	private ParticleSystem _particleSystem;

	private Game _game;

	private void Awake()
	{
		GameObject gameObject = base.gameObject;
		ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
		_particleSystem = component;
		Game instance = Game.Instance;
		_game = instance;
	}

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_010d: Expected I, but got Obj
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected VT, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I
		//IL_00a2: Expected native int or pointer, but got VT
		//IL_00bc: Expected F4, but got I
		//IL_00b7: Expected native int or pointer, but got VT
		//IL_00d9: Expected native int or pointer, but got VT
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected VT, but got Unknown
		//IL_00f9: Expected Ref, but got VT
		object obj = default;
		ParticleSystem.MinMaxCurve minMaxCurve = (ParticleSystem.MinMaxCurve)(obj - 112);
		_ = 0;
		Transform transform = base.transform;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.ParticleSystem+MinMaxCurve)+60]");
		_ = 0;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.ParticleSystem+MinMaxCurve)+58]");
		_ = 0;
		Quaternion rotation = (Quaternion)(minMaxCurve + 24);
		transform.rotation = rotation;
		if (_speedMultiplier > 0f)
		{
			object obj2 = minMaxCurve - 16;
			_ = 0;
			_ = _particleSystem;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v28+8]");
			_ = 0;
			Game game = _game;
			float num3 = game.__currentSpeed * _speedMultiplier;
			ParticleSystem.MinMaxCurve minMaxCurve2 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.ParticleSystem+MinMaxCurve)+50]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.ParticleSystem+MinMaxCurve)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.ParticleSystem+MinMaxCurve)+48]");
			System.Runtime.CompilerServices.Unsafe.Write(&((ParticleSystem.MinMaxCurve*)(nint)minMaxCurve)->m_CurveMin, (AnimationCurve)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.ParticleSystem+MinMaxCurve)+50]");
			((ParticleSystem.MinMaxCurve*)(nint)minMaxCurve)->m_ConstantMin = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.ParticleSystem+MinMaxCurve)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.ParticleSystem+MinMaxCurve)+40]");
			((ParticleSystem.MinMaxCurve*)(nint)minMaxCurve)->m_Mode = ParticleSystemCurveMode.Constant;
			ParticleSystem.MainModule mainModule = (ParticleSystem.MainModule)(minMaxCurve + 104);
			((ParticleSystem.MainModule*)mainModule)->startSpeed = minMaxCurve;
		}
	}
}
