//Type is in global namespace

public static class FacebookImageDownloader
{
	private sealed class <>c__DisplayClass1_0
	{
		public Texture2D iconImage; //Field offset: 0x8
		public Texture2D coverImage; //Field offset: 0xC

		public <>c__DisplayClass1_0() { }

		internal void <StartImageDownload>b__0(Texture2D x) { }

		internal void <StartImageDownload>b__1(Texture2D x) { }

	}

	private sealed class <LoadImage>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string url; //Field offset: 0x10
		public Action<Texture2D> result; //Field offset: 0x14
		private Texture2D <texture>5__2; //Field offset: 0x18
		private WWW <www>5__3; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 598
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LoadImage>d__2(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <StartImageDownload>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string iconImageUrl; //Field offset: 0x10
		public string coverImageUrl; //Field offset: 0x14
		private <>c__DisplayClass1_0 <>8__1; //Field offset: 0x18
		public Action<Texture2D, Texture2D> onFinishedDownloading; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 413
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <StartImageDownload>d__1(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}


	public static void DownloadImages(string iconImageUrl, string coverImageUrl, Action<Texture2D, Texture2D> onFinishedDownloading) { }

	private static IEnumerator LoadImage(string url, Action<Texture2D> result) { }

	private static IEnumerator StartImageDownload(string iconImageUrl, string coverImageUrl, Action<Texture2D, Texture2D> onFinishedDownloading) { }

}

