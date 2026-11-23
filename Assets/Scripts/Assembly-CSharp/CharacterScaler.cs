using System;
using Cpp2ILInjected;
using UnityEngine;

public class CharacterScaler : MonoBehaviour
{
	public enum ScaleAnchorType
	{
		CharacterAnchor,
		GameOverAnchor,
		TutorialPupupAnchor,
		CelebrationPopupAnchor,
		LimitedCharacterPopupAnchor,
		BirthdayAnchor
	}

	public bool lookAtCamera;

	private Camera _camera;

	public ScaleAnchorType _anchorType;

	private float _posX = 90f;

	private float _posY;

	private static float _scaleMultiplierForRotation = 56f;

	private static float _scaleDelta = 450f;

	private UIRoot _root;

	private void Start()
	{
		if (_camera == null)
		{
			GameObject go = gameObject;
			Camera camera = NGUITools.FindInParents<Camera>(go);
			_camera = camera;
		}
		UIScreenController instance = UIScreenController.Instance;
		_root = instance.root;
		SetScreenRelatedSettings();
		bool flag = _root == null;
		ScaleCharacter();
		PositionCharacter();
		RotateCharacter();
	}

	private void Update()
	{
		if (~(lookAtCamera ? 1u : 0u) == 0)
		{
			RotateCharacter();
			lookAtCamera = false;
		}
	}

	private void SetScreenRelatedSettings()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_014c: Expected F4, but got I4
		//IL_01d4: Expected F4, but got Obj
		//IL_0202: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		if (_anchorType != ScaleAnchorType.CharacterAnchor)
		{
			if (_anchorType != ScaleAnchorType.GameOverAnchor)
			{
				if (_anchorType != ScaleAnchorType.TutorialPupupAnchor)
				{
					if (_anchorType != ScaleAnchorType.CelebrationPopupAnchor)
					{
						if (_anchorType != ScaleAnchorType.LimitedCharacterPopupAnchor)
						{
							if (_anchorType == ScaleAnchorType.BirthdayAnchor)
							{
								Transform transform = base.transform;
								Vector3 localPosition = transform.localPosition;
								_posX = (float)obj;
								Transform transform2 = base.transform;
								Vector3 localPosition2 = transform2.localPosition;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								_posY = 0f;
							}
						}
						else
						{
							_posX = -75f;
							UIRoot root = _root;
							float num = (float)root.manualHeight * 0.5f;
							float posY = num - 45f;
							_posY = posY;
							_scaleMultiplierForRotation = 56f;
							_scaleDelta = -400f;
						}
					}
					else
					{
						_posX = 0f;
						_scaleMultiplierForRotation = 0f;
						UIRoot root2 = _root;
						_scaleDelta = root2.manualHeight;
					}
				}
				else
				{
					_posX = 55f;
					_scaleMultiplierForRotation = 0f;
					_scaleDelta = 450f;
				}
			}
			else
			{
				_posX = -85f;
				_scaleMultiplierForRotation = 32f;
				_scaleDelta = 450f;
			}
		}
		else
		{
			_posX = -115f;
			_scaleMultiplierForRotation = 56f;
			_scaleDelta = 450f;
		}
	}

	private unsafe void ScaleCharacter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00ce: Expected F4, but got I
		//IL_00c9: Expected native int or pointer, but got VT
		//IL_00e3: Expected F4, but got I
		//IL_00de: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		UIRoot root = _root;
		Transform transform = base.transform;
		Vector3 localPosition = transform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		_ = 0;
		if (_scaleDelta != 0f)
		{
			float num = (float)root.manualHeight - _scaleDelta;
		}
		else
		{
			float num = 0f;
		}
		Transform transform2 = transform.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector)->x = 0f;
		transform2.localPosition = vector;
	}

	private unsafe void RotateCharacter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected VT, but got Unknown
		//IL_006d: Expected F4, but got I
		//IL_0068: Expected native int or pointer, but got VT
		//IL_008f: Expected F4, but got I
		//IL_008a: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 80);
		if (_camera != null)
		{
			UIRoot root = _root;
			float num = (float)root.manualHeight - 480f;
			float num3;
			if (_scaleMultiplierForRotation != 0f)
			{
				float num2 = num / _scaleMultiplierForRotation;
				num3 = num2 + 5f;
			}
			else
			{
				num3 = 0f;
			}
			float num4 = 0f - num3;
			GameObject gameObject = base.gameObject;
			Transform transform = gameObject.transform;
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
			_ = 0;
			_ = 0f;
			float num5 = num4 * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
			_ = 0;
			Vector3 euler = (Vector3)(quaternion + 16);
			Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
			((Quaternion*)(nint)quaternion)->x = 0f;
			transform.localRotation = quaternion;
		}
	}

	private unsafe void PositionCharacter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_004c: Expected F4, but got I
		//IL_0047: Expected native int or pointer, but got VT
		//IL_005d: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		Transform transform = base.transform;
		Vector3 localPosition = transform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = _posX;
		((Vector3*)(nint)vector)->x = _posX;
		transform.localPosition = vector;
	}
}
