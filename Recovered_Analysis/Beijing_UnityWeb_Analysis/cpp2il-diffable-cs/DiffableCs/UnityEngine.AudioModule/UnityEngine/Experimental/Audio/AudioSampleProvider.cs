namespace UnityEngine.Experimental.Audio;

public class AudioSampleProvider
{
	public delegate ConsumeSampleFramesNativeFunction
	{

		public ConsumeSampleFramesNativeFunction(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(uint providerId, nint interleavedSampleFrames, uint sampleFrameCount, AsyncCallback callback, object object) { }

		public virtual uint EndInvoke(IAsyncResult result) { }

		public virtual uint Invoke(uint providerId, nint interleavedSampleFrames, uint sampleFrameCount) { }

	}

	public delegate SampleFramesHandler
	{

		public SampleFramesHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AudioSampleProvider provider, uint sampleFrameCount, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(AudioSampleProvider provider, uint sampleFrameCount) { }

	}

	private ConsumeSampleFramesNativeFunction m_ConsumeSampleFramesNativeFunction; //Field offset: 0x8
	private uint <id>k__BackingField; //Field offset: 0xC
	private ushort <trackIndex>k__BackingField; //Field offset: 0x10
	private Object <owner>k__BackingField; //Field offset: 0x14
	private ushort <channelCount>k__BackingField; //Field offset: 0x18
	private uint <sampleRate>k__BackingField; //Field offset: 0x1C
	private SampleFramesHandler sampleFramesAvailable; //Field offset: 0x20
	private SampleFramesHandler sampleFramesOverflow; //Field offset: 0x24

	public uint id
	{
		 get { } //Length: 49
		private set { } //Length: 39
	}

	public Object owner
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public void Dispose() { }

	protected override void Finalize() { }

	public uint get_id() { }

	public Object get_owner() { }

	internal static void InternalRemove(uint providerId) { }

	private static void InternalSetScriptingPtr(uint providerId, AudioSampleProvider provider) { }

	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }

	private void set_id(uint value) { }

	private void set_owner(Object value) { }

}

