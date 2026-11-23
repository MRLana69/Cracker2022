using System;
using SYBO.Common.Exceptions;
using UnityEngine;

namespace SYBO.Subway.Visuals;

public class BaseCameraFX : MonoBehaviour
{
	private GameObject _onGameObject;

	private GameObject _offGameObject;

	private CameraFXState _cameraFXState;

	public CameraFXState CameraFXState
	{
		get
		{
			return _cameraFXState;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj2 = default;
			Enum obj = (Enum)(obj2 - 16);
			_cameraFXState = value;
			switch (value)
			{
			case CameraFXState.On:
				_onGameObject.SetActive(value: true);
				_offGameObject.SetActive(value: false);
				return;
			case CameraFXState.Off:
				_onGameObject.SetActive(value: false);
				_offGameObject.SetActive(value: true);
				return;
			}
			_ = -1;
			obj = (Enum)(object)typeof(CameraFXState);
			_ = _cameraFXState;
			string missingSwitchValue = obj.ToString();
			SwitchDefaultException.Throw(missingSwitchValue);
		}
	}

	protected virtual void Start()
	{
		CameraFXState = CameraFXState.Off;
	}
}
