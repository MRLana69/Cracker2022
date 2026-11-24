using Cpp2ILInjected;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Visuals.BaseCameraFX)+15]");
			return ((nint)0 != 0) ? CameraFXState.Off : CameraFXState.On;
		}
		set
		{
			//IL_000e: Expected Obj, but got I4
			object obj = value & CameraFXState.Off;
		}
	}

	protected virtual void Start()
	{
		CancelInvoke();
	}

	public BaseCameraFX()
	{
		//IL_000a: Expected Obj, but got I4
		ParticleSystem.MinMaxGradient minMaxGradient = ((HuntTokenCollectVFXColorCycle)1).PickRandomColorGradient();
	}
}
