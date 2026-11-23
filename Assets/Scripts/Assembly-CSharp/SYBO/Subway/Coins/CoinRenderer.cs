using Cpp2ILInjected;
using SYBO.Subway.Pickups;
using UnityEngine;

namespace SYBO.Subway.Coins;

public class CoinRenderer : MonoBehaviour
{
	private Renderer _renderer;

	private Glow _glow;

	private PickupRotate _pickupRotate;

	private Transform _transform;

	private bool _actualRendering;

	private bool _renderersEnabled;

	private void Awake()
	{
		PickupRotate component = GetComponent<PickupRotate>();
		_pickupRotate = component;
		Transform transform = base.transform;
		_transform = transform;
	}

	public void UpdateCoinRenderer(float time, float characterZ, bool lowPerformanceLevel)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0093: Invalid comparison between I and F4
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(_renderersEnabled ? 1u : 0u) != 0)
		{
			return;
		}
		if (~(_actualRendering ? 1u : 0u) != 0)
		{
			if (lowPerformanceLevel)
			{
				Vector3 position = _transform.position;
				float num = characterZ + 750f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				if (0f > num)
				{
					return;
				}
			}
			_actualRendering = true;
			_renderer.enabled = true;
			_glow.SetVisible(visible: true);
		}
		else
		{
			_pickupRotate.PhasedRotate(time);
		}
	}

	public void ToggleRenderers(bool enabled)
	{
		_renderer.enabled = false;
		_glow.SetVisible(visible: false);
		_renderersEnabled = enabled;
		_actualRendering = false;
	}
}
