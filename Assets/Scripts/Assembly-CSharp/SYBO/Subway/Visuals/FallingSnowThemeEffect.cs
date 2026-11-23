using System;
using Cpp2ILInjected;
using SYBO.Subway.Characters;
using UnityEngine;

namespace SYBO.Subway.Visuals;

public class FallingSnowThemeEffect : ThemeEffect
{
	private ParticleSystem _snowPrefab;

	private ParticleSystem _snow;

	private float zOffset;

	private Vector3 _snowOriginalPosition;

	public unsafe override void Initialize(Transform root)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0091: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		ParticleSystem snow = UnityEngine.Object.Instantiate(_snowPrefab);
		_snow = snow;
		Transform transform = _snow.transform;
		transform.SetParent(root, worldPositionStays: true);
		GameObject gameObject = _snow.gameObject;
		gameObject.SetActive(value: true);
		Transform transform2 = _snow.transform;
		Vector3 position = transform2.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_snowOriginalPosition = (Vector3)obj;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FallingSnowThemeEffect.Game_OnGameStarted));
		Game.OnGameStarted += action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(FallingSnowThemeEffect.Game_OnGameEnded));
		Game.OnGameEnded += action2;
	}

	private void Game_OnGameStarted()
	{
		if (_snow != null)
		{
			_snow.Clear();
			_snow.Play();
		}
	}

	private void Game_OnGameEnded()
	{
		if (_snow != null)
		{
			_snow.Stop();
		}
	}

	public unsafe override void UpdateEffect()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_007d: Expected F4, but got I
		//IL_0078: Expected native int or pointer, but got VT
		//IL_0093: Expected F4, but got VT
		//IL_008e: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		Transform transform = _snow.transform;
		Character instance = Character.Instance;
		Transform transform2 = instance.transform;
		Vector3 position = transform2.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		float num = 0f + zOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = _snowOriginalPosition;
		((Vector3*)(nint)vector)->x = (float)_snowOriginalPosition;
		transform.position = vector;
	}

	public FallingSnowThemeEffect()
	{
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_snowOriginalPosition = Vector3.zeroVector;
		base._002Ector();
	}
}
