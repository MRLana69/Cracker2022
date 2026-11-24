namespace SYBO.Common.Components.Debugging;

public class CommentComponent : MonoBehaviour
{
	public string Comment; //Field offset: 0xC
	private bool _isCommentEditableInInspector; //Field offset: 0x10

	public bool IsCommentEditableInInspector
	{
		 get { } //Length: 273
		 set { } //Length: 34
	}

	public CommentComponent() { }

	public bool get_IsCommentEditableInInspector() { }

	protected void Reset() { }

	public void set_IsCommentEditableInInspector(bool value) { }

}

