using System;
using Cpp2ILInjected;
using SYBO.Subway.Cameras;
using UnityEngine;

public class MoveGameObject : MonoBehaviour
{
	private const float MinCameraSpeedDelta = 0.15f;

	public Vector3 vector;

	public float MaxMagnitude;

	public float Speed;

	public Transform model;

	private CharacterCamera characterCamera;

	private float _speedMultiplier;

	private float _lastCameraSpeed;

	private Vector3 _startLocal;

	public float SpeedMultiplier
	{
		get
		{
			return _speedMultiplier;
		}
		set
		{
			_speedMultiplier = value;
		}
	}

	public unsafe void UpdatePosition(Vector3 localPos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001d: Expected VT, but got F4
		//IL_0046: Expected F4, but got I
		//IL_0041: Expected native int or pointer, but got VT
		//IL_0055: Expected F4, but got VT
		//IL_0050: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		_startLocal = (Vector3)localPos.x;
		_ = localPos.z;
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (MoveGameObject)+38]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)_startLocal;
		transform.localPosition = vector;
	}

	public unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_00a2: Expected VT, but got I
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_017a: Expected F4, but got I
		//IL_0175: Expected native int or pointer, but got VT
		//IL_01b0: Expected F4, but got I
		//IL_01ab: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		if (this.characterCamera == null)
		{
			object obj2 = this + 36;
			CharacterCamera instance = CharacterCamera.Instance;
			obj2 = instance;
		}
		CharacterCamera characterCamera = this.characterCamera;
		float value = _lastCameraSpeed - characterCamera._speed;
		float num = Math.Abs(value);
		if (num > 0.15f)
		{
			CharacterCamera characterCamera2 = this.characterCamera;
			_lastCameraSpeed = characterCamera2._speed;
			Transform transform = base.transform;
			Vector3 localPosition = transform.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_startLocal = (Vector3)0;
		}
		CharacterCamera characterCamera3 = this.characterCamera;
		Speed = characterCamera3._speed;
		if (characterCamera3._speed > 0f)
		{
			object obj3 = _lastCameraSpeed & 0x7FFFFFFF;
			if ((nint)obj3 != 2139095040)
			{
				Transform transform2 = base.transform;
				Vector3 localPosition2 = transform2.localPosition;
				float deltaTime = Time.deltaTime;
				float num2 = _lastCameraSpeed * _speedMultiplier;
				float num3 = num2 * deltaTime;
				float num4 = (float)this.vector * num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (MoveGameObject)+10]");
				float num5 = 0f * num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
				float num6 = 0f + num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (MoveGameObject)+14]");
				float num7 = 0f * num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				float num8 = 0f + num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				float num9 = 0f + num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				transform2.localPosition = vector;
			}
		}
	}

	public MoveGameObject()
	{
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		vector = Vector3.zeroVector;
		_speedMultiplier = 1f;
		MaxMagnitude = 1f;
		base._002Ector();
	}
}
