//Type is in global namespace

public class KeyFrameAudio : KeyFrameAction
{
	public delegate ExtraKeyframeCall
	{

		public ExtraKeyframeCall(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(KeyFrameAudio info, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(KeyFrameAudio info) { }

	}

	public AudioKeyFrameType audioKeyFrameType; //Field offset: 0x14
	public AudioClipInfo Audio; //Field offset: 0x18
	public ExtraKeyframeCall Callback; //Field offset: 0x1C

	public KeyFrameAudio() { }

}

