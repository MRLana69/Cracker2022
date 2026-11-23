using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Monetization.Offerwall.Internal;

public class ImageDownloader
{
	private sealed class _003CDownload_003Ed__17(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public ImageDownloader _003C_003E4__this;

		private float _003C_startedDownloading_003E5__2;

		private WWW _003Cwww_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_017e: Expected I, but got Obj
			//IL_01bd: Expected I, but got Obj
			ImageDownloader imageDownloader = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						goto IL_0340;
					}
					_003C_003E1__state = -1;
					string error = _003Cwww_003E5__3.error;
					if (error == null)
					{
						Texture2D texture = _003Cwww_003E5__3.texture;
						imageDownloader._image = texture;
						if (!(imageDownloader._image == null))
						{
							Texture2D image = imageDownloader._image;
							nint num = (nint)image;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v175 @ S1_v35 (Il2CppClass<UnityEngine.Texture2D>)+DC] (should have been resolved before IL gen)");
							object obj = default;
							if ((nint)obj == 8)
							{
								Texture2D image2 = imageDownloader._image;
								nint num2 = (nint)image2;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v191 @ S1_v42 (Il2CppClass<UnityEngine.Texture2D>)+EC] (should have been resolved before IL gen)");
								object obj2 = default;
								if ((nint)obj2 == 8)
								{
									goto IL_02cb;
								}
							}
							imageDownloader._isDownloading = true;
							Action<bool, ImageDownloader> onDownloadComplete = imageDownloader._onDownloadComplete;
							if (imageDownloader._onDownloadComplete != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v81 @ S0_v71 (System.Action`2<System.Boolean, Kiloo.Monetization.Offerwall.Internal.ImageDownloader>)+C] (should have been resolved before IL gen)");
							}
							goto IL_0340;
						}
					}
					goto IL_02cb;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				_003C_startedDownloading_003E5__2 = realtimeSinceStartup;
				if (imageDownloader._url == null)
				{
					goto IL_0340;
				}
				imageDownloader._isDownloading = true;
				WWW wWW = default;
				wWW._002Ector(imageDownloader._url);
				_003Cwww_003E5__3 = wWW;
			}
			if (_003Cwww_003E5__3.isDone)
			{
				_003C_003E2__current = _003Cwww_003E5__3;
				_003C_003E1__state = 2;
				return true;
			}
			if (imageDownloader._timeout > 0f)
			{
				float realtimeSinceStartup2 = Time.realtimeSinceStartup;
				float num3 = realtimeSinceStartup2 - _003C_startedDownloading_003E5__2;
				if (!(num3 < imageDownloader._timeout))
				{
					goto IL_02cb;
				}
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_0340:
			return false;
			IL_02cb:
			imageDownloader._isDownloading = true;
			Action<bool, ImageDownloader> onDownloadComplete2 = imageDownloader._onDownloadComplete;
			if (imageDownloader._onDownloadComplete != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ S0_v35 (System.Action`2<System.Boolean, Kiloo.Monetization.Offerwall.Internal.ImageDownloader>)+C] (should have been resolved before IL gen)");
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private Action<bool, ImageDownloader> _onDownloadComplete;

	private string _url;

	private Texture2D _image;

	private float _timeout;

	private object _cookie;

	private bool _isDownloading;

	public object cookie => _cookie;

	public Texture2D image => _image;

	public string url => _url;

	public bool isDownloading => _isDownloading;

	public ImageDownloader(string url, Action<bool, ImageDownloader> onDownloadComplete, float timeout, object obj)
	{
		_url = url;
		_cookie = obj;
		_timeout = timeout;
		AddOnDownloadCompleteHandler(onDownloadComplete);
	}

	public void AddOnDownloadCompleteHandler(Action<bool, ImageDownloader> handler)
	{
		if (handler != null)
		{
			Delegate obj = Delegate.Combine(_onDownloadComplete, handler);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			Action<bool, ImageDownloader> onDownloadComplete = default;
			_onDownloadComplete = onDownloadComplete;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		}
	}

	public void RemoveOnDownloadCompleteHandler(Action<bool, ImageDownloader> handler)
	{
		if (handler != null)
		{
			Delegate obj = Delegate.Remove(_onDownloadComplete, handler);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			Action<bool, ImageDownloader> onDownloadComplete = default;
			_onDownloadComplete = onDownloadComplete;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		}
	}

	public IEnumerator Download()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void DownloadComplete(bool succes)
	{
		_isDownloading = true;
		Action<bool, ImageDownloader> onDownloadComplete = _onDownloadComplete;
		if (_onDownloadComplete != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4 @ S0_v3 (System.Action`2<System.Boolean, Kiloo.Monetization.Offerwall.Internal.ImageDownloader>)+C] (should have been resolved before IL gen)");
		}
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
