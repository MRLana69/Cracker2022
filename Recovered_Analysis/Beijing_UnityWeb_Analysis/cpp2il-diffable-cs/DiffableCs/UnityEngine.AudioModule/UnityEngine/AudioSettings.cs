namespace UnityEngine;

public sealed class AudioSettings
{
	public delegate AudioConfigurationChangeHandler
	{

		public AudioConfigurationChangeHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(bool deviceWasChanged, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(bool deviceWasChanged) { }

	}

	private static AudioConfigurationChangeHandler OnAudioConfigurationChanged; //Field offset: 0x0

	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

}

