//Type is in global namespace

public class AssetBundleFactory`1
{
	private sealed class <>c__DisplayClass5_0
	{
		public Action<T> onSuccess; //Field offset: 0x0
		public bool asynchronous; //Field offset: 0x0
		public AssetBundleFactory<T> <>4__this; //Field offset: 0x0
		public string name; //Field offset: 0x0

		public <>c__DisplayClass5_0() { }

		internal void <RequestItemInstance>b__0(AssetBundle bundle) { }

	}

	private sealed class <LoadAssetFromBundlesAsync>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public AssetBundleFactory<T> <>4__this; //Field offset: 0x0
		public AssetBundle bundle; //Field offset: 0x0
		public string name; //Field offset: 0x0
		public Action<T> onSucces; //Field offset: 0x0
		private AssetBundleRequest <request>5__2; //Field offset: 0x0

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 6
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LoadAssetFromBundlesAsync>d__8(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private Dictionary<string, int> _requests; //Field offset: 0x0
	private Dictionary<string, List<Disposable<T>>> _disposableReferences; //Field offset: 0x0
	private bool _isComponent; //Field offset: 0x0
	private List<string> _toRemove; //Field offset: 0x0

	public AssetBundleFactory`1() { }

	private Disposable<T> CreateDisposableObject(string name, T obj) { }

	private void HandleOnLateUpdate() { }

	public bool IsAssetBundleInUse(string assetBundleName) { }

	private void LoadAssetFromBundles(AssetBundle bundle, string name, Action<T> onSucces) { }

	private IEnumerator LoadAssetFromBundlesAsync(AssetBundle bundle, string name, Action<T> onSucces) { }

	public void RequestItemInstance(string name, Action<T> onSuccess, bool asynchronous = false) { }

}

