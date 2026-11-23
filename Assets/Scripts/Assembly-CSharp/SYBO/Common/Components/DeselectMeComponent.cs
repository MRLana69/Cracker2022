using UnityEngine;

namespace SYBO.Common.Components;

public class DeselectMeComponent : MonoBehaviour
{
	private Transform _redirectTarget;

	private DeselectMeMode _deselectMeMode;

	public Transform RedirectTarget => _redirectTarget;

	public DeselectMeMode DeselectMeMode
	{
		get
		{
			return _deselectMeMode;
		}
		set
		{
			_deselectMeMode = value;
		}
	}
}
