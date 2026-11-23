using System;
using SYBO.Subway;
using SYBO.Subway.Cameras;
using UnityEngine;

public class Tunnel : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__3_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CAwake_003Eb__3_0()
		{
			CharacterCamera instance = CharacterCamera.Instance;
			instance.offsetDeltaCurve = null;
		}
	}

	private float _tunnelLength;

	private Game _game;

	public AudioStateLoop audioStateLoop;

	private unsafe void Awake()
	{
		Game instance = Game.Instance;
		bool flag = _003C_003Ec._003C_003E9__3_0 == null;
		bool flag2 = !flag;
		Action value = _003C_003Ec._003C_003E9__3_0;
		if (!flag2)
		{
			Action action = default;
			action._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CAwake_003Eb__3_0));
			_003C_003Ec._003C_003E9__3_0 = action;
			value = action;
		}
		instance.OnStageMenuSequence += value;
	}

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.CompareTag("Player"))
		{
			CharacterCamera instance = CharacterCamera.Instance;
			instance.EnterCameraModifierCollider(_tunnelLength);
		}
	}
}
