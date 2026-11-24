namespace UnityEngine;

public sealed class AudioClip : Object
{
	public delegate PCMReaderCallback
	{

		public PCMReaderCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(float[] data, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(float[] data) { }

	}

	public delegate PCMSetPositionCallback
	{

		public PCMSetPositionCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(int position, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(int position) { }

	}

	private PCMReaderCallback m_PCMReaderCallback; //Field offset: 0xC
	private PCMSetPositionCallback m_PCMSetPositionCallback; //Field offset: 0x10

	public float length
	{
		 get { } //Length: 49
	}

	private AudioClip() { }

	public float get_length() { }

	private void InvokePCMReaderCallback_Internal(float[] data) { }

	private void InvokePCMSetPositionCallback_Internal(int position) { }

}

