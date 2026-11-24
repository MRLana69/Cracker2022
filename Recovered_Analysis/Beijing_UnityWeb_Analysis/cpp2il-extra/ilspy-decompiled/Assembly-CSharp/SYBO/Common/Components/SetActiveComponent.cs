using SYBO.Common.Components.Debugging;
using UnityEngine;

namespace SYBO.Common.Components;

public class SetActiveComponent : MonoBehaviour
{
	private bool _toggleActiveValue;

	private Timing _toggleActiveTiming;

	protected void Awake()
	{
		_ = 1;
		CancelInvoke();
	}

	protected void Start()
	{
		((CommentComponent)this).IsCommentEditableInInspector = false;
	}

	protected void CheckTiming(Timing currentUnityTiming)
	{
		_toggleActiveTiming = currentUnityTiming;
	}

	public SetActiveComponent()
	{
		((CommentComponent)this).IsCommentEditableInInspector = true;
	}
}
