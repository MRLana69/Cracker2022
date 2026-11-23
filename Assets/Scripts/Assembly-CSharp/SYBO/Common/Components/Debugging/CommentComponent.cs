using UnityEngine;

namespace SYBO.Common.Components.Debugging;

public class CommentComponent : MonoBehaviour
{
	public string Comment = string.Empty;

	private bool _isCommentEditableInInspector = true;

	public bool IsCommentEditableInInspector
	{
		get
		{
			return _isCommentEditableInInspector;
		}
		set
		{
			_isCommentEditableInInspector = value;
		}
	}

	protected void Reset()
	{
		_isCommentEditableInInspector = true;
	}
}
