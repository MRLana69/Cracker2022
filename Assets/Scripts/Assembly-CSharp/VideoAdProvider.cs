using System;
using Cpp2ILInjected;

public abstract class VideoAdProvider
{
	protected Action<VideoAdProvider> _onVideoAvailable;

	protected Action<VideoAdProvider, string> _onVideoUnavailable;

	protected Action<VideoAdProvider> _onTakeoverBegan;

	protected Action<VideoAdProvider> _onTakeoverEnded;

	protected Action<VideoAdProvider> _onVideoWatched;

	protected Action<VideoAdProvider> _onCachingTimedOut;

	public abstract bool isInitialized { get; }

	public abstract bool allowedWhenAgeRestricted { get; }

	public abstract bool IsStopped { get; }

	public abstract string id { get; set; }

	public abstract int weight { get; set; }

	public abstract int priority { get; set; }

	protected void InvokeHandlerIfNotNull(Action handler)
	{
		if (handler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: handler.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	protected void InvokeHandlerIfNotNull<T>(Action<T> handler, T val)
	{
		//IL_0039: Expected Obj, but got I
		if (handler != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S3_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	protected void InvokeHandlerIfNotNull<T>(Action<T, string> handler, T val, string extraInfo = "")
	{
		//IL_0039: Expected Obj, but got I
		if (handler != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S4_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ S4_v4+4] (should have been resolved before IL gen)");
		}
	}

	protected void InvokeHandlerIfNotNull<T1, T2>(Action<T1, T2> handler, T1 val1, T2 val2)
	{
		//IL_0039: Expected Obj, but got I
		if (handler != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S4_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ S4_v4+4] (should have been resolved before IL gen)");
		}
	}

	public abstract void Init();

	public abstract bool PlayVideoIfAvailable();

	public abstract void StopProvider();

	public abstract void ResumeProvider();

	public abstract void StartCachingVideo();

	public unsafe static void SetVideoProviderData(string OnlineSettings_ID, int Default_Priority, int Default_Weight, ref int priority, ref int weight)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Ref, but got Unknown
		//IL_003c: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = string.Empty;
		OnlineSettings instance = OnlineSettings.instance;
		if (!instance.TryGetValue(OnlineSettings_ID, out *(string*)(obj + 12)))
		{
			goto IL_011d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		object obj4;
		if ((nint)0 != 0)
		{
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v23+8]");
			if ((nint)0 != 0)
			{
				goto IL_0167;
			}
		}
		obj4 = 1;
		goto IL_0167;
		IL_0167:
		ref int reference;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			string[] array = ((string)0).Split(';');
			if (array.Length >= 2)
			{
				if (!int.TryParse(array[0], out priority))
				{
					reference = ref *(int*)Default_Priority;
				}
				if (int.TryParse(array[1], out weight))
				{
					return;
				}
				goto IL_01a9;
			}
		}
		goto IL_011d;
		IL_011d:
		reference = ref *(int*)Default_Priority;
		goto IL_01a9;
		IL_01a9:
		ref int reference2 = ref *(int*)Default_Weight;
	}

	public void AddVideoAvailableHandler(Action<VideoAdProvider> handler)
	{
		Delegate obj = Delegate.Combine(_onVideoAvailable, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<VideoAdProvider> onVideoAvailable = default;
		_onVideoAvailable = onVideoAvailable;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
	}

	public void RemoveVideoAvailableHandler(Action<VideoAdProvider> handler)
	{
		Delegate obj = Delegate.Remove(_onVideoAvailable, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<VideoAdProvider> onVideoAvailable = default;
		_onVideoAvailable = onVideoAvailable;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
	}

	public void AddVideoUnavailableHandler(Action<VideoAdProvider, string> handler)
	{
		Delegate obj = Delegate.Combine(_onVideoUnavailable, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<VideoAdProvider, string> onVideoUnavailable = default;
		_onVideoUnavailable = onVideoUnavailable;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
	}

	public void RemoveVideoUnavailableHandler(Action<VideoAdProvider, string> handler)
	{
		Delegate obj = Delegate.Remove(_onVideoUnavailable, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<VideoAdProvider, string> onVideoUnavailable = default;
		_onVideoUnavailable = onVideoUnavailable;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
	}

	public void AddTakeoverBeganHandler(Action<VideoAdProvider> handler)
	{
		Delegate obj = Delegate.Combine(_onTakeoverBegan, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<VideoAdProvider> onTakeoverBegan = default;
		_onTakeoverBegan = onTakeoverBegan;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
	}

	public void RemoveTakeoverBeganHandler(Action<VideoAdProvider> handler)
	{
		Delegate obj = Delegate.Remove(_onTakeoverBegan, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<VideoAdProvider> onTakeoverBegan = default;
		_onTakeoverBegan = onTakeoverBegan;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
	}

	public void AddTakeoverEndedHandler(Action<VideoAdProvider> handler)
	{
		Delegate obj = Delegate.Combine(_onTakeoverEnded, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<VideoAdProvider> onTakeoverEnded = default;
		_onTakeoverEnded = onTakeoverEnded;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
	}

	public void RemoveTakeoverEndedHandler(Action<VideoAdProvider> handler)
	{
		Delegate obj = Delegate.Remove(_onTakeoverEnded, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<VideoAdProvider> onTakeoverEnded = default;
		_onTakeoverEnded = onTakeoverEnded;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
	}

	public void AddVideoWatchedHandler(Action<VideoAdProvider> handler)
	{
		Delegate obj = Delegate.Combine(_onVideoWatched, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<VideoAdProvider> onVideoWatched = default;
		_onVideoWatched = onVideoWatched;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
	}

	public void RemoveVideoWatchedHandler(Action<VideoAdProvider> handler)
	{
		Delegate obj = Delegate.Remove(_onVideoWatched, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<VideoAdProvider> onVideoWatched = default;
		_onVideoWatched = onVideoWatched;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
	}

	public void AddCachingTimedOutHandler(Action<VideoAdProvider> handler)
	{
		Delegate obj = Delegate.Combine(_onCachingTimedOut, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<VideoAdProvider> onCachingTimedOut = default;
		_onCachingTimedOut = onCachingTimedOut;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
	}

	public void RemoveCachingTimedOutHandler(Action<VideoAdProvider> handler)
	{
		Delegate obj = Delegate.Remove(_onCachingTimedOut, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<VideoAdProvider> onCachingTimedOut = default;
		_onCachingTimedOut = onCachingTimedOut;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
	}

	public virtual void OnPause()
	{
	}

	public virtual void OnResume()
	{
	}
}
