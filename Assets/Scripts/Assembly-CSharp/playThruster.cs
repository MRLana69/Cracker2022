using System;
using Cpp2ILInjected;
using SYBO.Subway.Characters;
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

	private bool addedEvent;

	public JumpStyle jumpStyle => _jumpStyle;

	public unsafe void Initialize()
	{
		//IL_0022: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I
		Hoverboard instance = Hoverboard.Instance;
		_hoverboard = instance;
		Renderer[] renderes = _renderes;
		if (_renderes != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			AnimationState[] states = default;
			_states = states;
			object obj = 0;
			Renderer[] renderes2 = _renderes;
			if ((nint)obj < renderes2.Length)
			{
				object obj2 = obj << 2;
				object obj3 = (object)renderes2 + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v28+10]");
				Animation component = ((Component)0).GetComponent<Animation>();
				string text = _clip.name;
				AnimationState animationState = component.get_Item(text);
				throw new ArrayTypeMismatchException();
			}
		}
		Character instance2 = Character.Instance;
		_character = instance2;
		JumpStyle jumpStyle = _jumpStyle;
		if (_jumpStyle == JumpStyle.Super)
		{
			addedEvent = true;
			Character.OnJumpDelegate onJumpDelegate = default;
			onJumpDelegate._002Ector(this, (nint)__ldftn(playThruster.Character_OnJump));
			_character.OnJump += onJumpDelegate;
			jumpStyle = _jumpStyle;
		}
		if (jumpStyle == JumpStyle.Double)
		{
			addedEvent = true;
			Character.OnDoubleJumpDelegate onDoubleJumpDelegate = default;
			onDoubleJumpDelegate._002Ector(this, (nint)__ldftn(playThruster.Character_OnDoubleJump));
			_character.OnDoubleJump += onDoubleJumpDelegate;
		}
		if (_particles != null)
		{
			Transform transform = _particles.transform;
			transform.parent = null;
		}
	}

	private unsafe void OnDestroy()
	{
		if (~(addedEvent ? 1u : 0u) == 0)
		{
			JumpStyle jumpStyle = _jumpStyle;
			if (_jumpStyle == JumpStyle.Super)
			{
				Character.OnJumpDelegate onJumpDelegate = default;
				onJumpDelegate._002Ector(this, (nint)__ldftn(playThruster.Character_OnJump));
				_character.OnJump -= onJumpDelegate;
				jumpStyle = _jumpStyle;
			}
			if (jumpStyle == JumpStyle.Double)
			{
				Character.OnDoubleJumpDelegate onDoubleJumpDelegate = default;
				onDoubleJumpDelegate._002Ector(this, (nint)__ldftn(playThruster.Character_OnDoubleJump));
				_character.OnDoubleJump -= onDoubleJumpDelegate;
			}
		}
		if (_particles != null)
		{
			GameObject obj = _particles.gameObject;
			UnityEngine.Object.Destroy(obj);
		}
	}

	private void Character_OnDoubleJump()
	{
		Character_OnJump(0f, willPlaySound: false);
	}

	private unsafe void Character_OnJump(float jumpHeight, bool willPlaySound)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0045: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I4
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected VT, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected VT, but got Unknown
		//IL_007d: Expected Obj, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_0287: Expected F4, but got I
		//IL_0282: Expected native int or pointer, but got VT
		//IL_02a9: Expected F4, but got I
		//IL_02a4: Expected native int or pointer, but got VT
		//IL_00d7: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 112);
		Hoverboard hoverboard = _hoverboard;
		if (~(hoverboard.isActive ? 1u : 0u) != 0)
		{
			return;
		}
		Renderer[] renderes = _renderes;
		if (_renderes != null)
		{
			object obj2 = 0;
			while (renderes.Length > (nint)obj2)
			{
				object obj3 = obj2 << 2;
				object obj4 = (object)_renderes + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v90+10]");
				((Renderer)0).enabled = true;
				object obj5 = obj2 + 1;
				obj2 = obj5;
			}
			object obj6 = 0;
			while (true)
			{
				AnimationState[] states = _states;
				if (states.Length <= (nint)obj6)
				{
					break;
				}
				object obj7 = obj6 << 2;
				object obj8 = (object)states + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v81+10]");
				((AnimationState)0).weight = 1f;
				object obj9 = obj6 << 2;
				object obj10 = (object)_states + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v85+10]");
				((AnimationState)0).enabled = true;
				object obj11 = obj6 + 1;
				obj6 = obj11;
			}
			throw new ArgumentException();
		}
		if (_particles != null)
		{
			Transform transform = _particles.transform;
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			_ = 0;
			_ = 0f;
			_ = 4.712389f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			_ = 0;
			Vector3 euler = vector + 32;
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(euler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Quaternion localRotation = (Quaternion)(vector + 16);
			transform.localRotation = localRotation;
			Transform transform2 = _particles.transform;
			Transform transform3 = base.transform;
			Vector3 position = transform3.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			((Vector3*)(nint)vector)->x = 0f;
			transform2.position = vector;
			_ = 0;
			throw new ArgumentException();
		}
	}

	private void _003CCharacter_OnJump_003Eb__15_0(float t)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0096: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		AnimationState[] states = _states;
		object obj = 0;
		while (states.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)states + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v23+10]");
			((AnimationState)0).normalizedTime = t;
			object obj4 = obj + 1;
			obj = obj4;
		}
		if (t == 1f)
		{
			Renderer[] renderes = _renderes;
			object obj5 = 0;
			while ((nint)obj5 < renderes.Length)
			{
				object obj6 = obj5 << 2;
				object obj7 = (object)renderes + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v18+10]");
				((Renderer)0).enabled = false;
				object obj8 = obj5 + 1;
				obj5 = obj8;
			}
		}
	}
}
