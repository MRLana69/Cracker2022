using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class FBNativeDownloader : MonoBehaviour
{
	public delegate void DidDownload(Texture2D iconImage, Texture2D coverImage);

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public Texture2D iconImage;

		public Texture2D coverImage;

		internal void _003CStartImageDownload_003Eb__0(Texture2D x)
		{
			iconImage = x;
		}

		internal void _003CStartImageDownload_003Eb__1(Texture2D x)
		{
			coverImage = x;
		}
	}

	private sealed class _003CStartImageDownload_003Ed__8(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FBNativeDownloader _003C_003E4__this;

		public string iconImageURL;

		public string coverImageURL;

		private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						FBNativeDownloader fBNativeDownloader = _003C_003E4__this;
						DidDownload onDownloaded = fBNativeDownloader.m_onDownloaded;
						if (fBNativeDownloader.m_onDownloaded != null)
						{
							_003C_003Ec__DisplayClass8_0 obj = _003C_003E8__1;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v55.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						}
					}
					return false;
				}
				_003C_003E1__state = -1;
				throw new ArgumentException();
			}
			_003C_003E1__state = -1;
			_003C_003Ec__DisplayClass8_0 obj2 = default;
			_003C_003E8__1 = obj2;
			_003C_003Ec__DisplayClass8_0 obj3 = _003C_003E8__1;
			obj3.iconImage = null;
			_003C_003Ec__DisplayClass8_0 obj4 = _003C_003E8__1;
			obj4.coverImage = null;
			throw new ArgumentException();
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

	private sealed class _003CLoadImage_003Ed__9(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public Action<Texture2D> result;

		private Texture2D _003Ctexture_003E5__2;

		private WWW _003Cwww_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0020: Expected Obj, but got I4
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected Obj, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 32;
			object obj3 = _003C_003E1__state + 3;
			if (obj3 == null || ((nint)obj3 != 1 && (nint)obj3 != 2 && (nint)obj3 != 3 && (nint)obj3 == 4))
			{
				object obj4 = obj + 28;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				object obj5 = obj + 20;
				object obj6 = obj5;
				((_003CLoadImage_003Ed__9)obj6)._003C_003Em__Finally1();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @254");
				}
			}
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f4: Expected Obj, but got Unknown
			//IL_061c: Expected Obj, but got I
			//IL_0578: Unknown result type (might be due to invalid IL or missing references)
			//IL_057d: Expected Obj, but got Unknown
			//IL_00dc: Expected Obj, but got I
			//IL_00f1: Expected Obj, but got I
			//IL_064a: Unknown result type (might be due to invalid IL or missing references)
			//IL_064f: Expected Obj, but got Unknown
			//IL_06a4: Expected Obj, but got I
			//IL_0283: Expected Obj, but got I4
			//IL_0264: Expected Obj, but got I4
			//IL_0177: Expected Obj, but got I
			//IL_018c: Expected Obj, but got I
			//IL_01af: Expected Obj, but got I
			//IL_02c9: Expected Obj, but got I
			//IL_0322: Expected Obj, but got I
			//IL_03c5: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 32;
			object obj3 = obj + 28;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+8]");
			bool flag;
			object obj5;
			object obj7;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+8]");
				if ((nint)0 != 1)
				{
					flag = false;
					obj5 = obj;
					goto IL_0641;
				}
				_ = -3;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					object obj6 = default;
					if (obj6 != null)
					{
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v105+8]");
						if ((nint)0 != 0)
						{
							goto IL_065e;
						}
					}
					obj7 = 1;
					goto IL_065e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				_ = -1;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
						object obj9 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
								object obj10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
								object obj11 = 0;
								_ = -3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v95+1C]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
								object obj12 = 0;
								_ = 1;
								flag = true;
								obj5 = obj;
								goto IL_0641;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_049d;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_049d;
			IL_049d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj13 = default;
			object obj14 = default;
			bool flag2 = obj13 == obj14;
			bool flag3 = !flag2;
			bool flag4 = default;
			flag = flag4;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 != 1;
				flag = false;
				obj5 = obj;
				if (flag5)
				{
					goto IL_0641;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				bool flag6 = default;
				flag = flag6;
			}
			_ = 0;
			object obj15 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj5 = 0;
			goto IL_0641;
			IL_043f:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag7 = (nint)0 != 1;
			flag = false;
			obj5 = obj;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_049d;
			}
			goto IL_0641;
			IL_0641:
			object obj16 = obj5 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0EA");
			return flag;
			IL_065e:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj7 == null)
				{
					goto IL_043f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
				object obj17 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
					object obj18 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj19 = default;
							if (obj19 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
								object obj20 = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									goto IL_049d;
								}
							}
							goto IL_043f;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_049d;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			_003Cwww_003E5__3.Dispose();
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

	private static FBNativeDownloader _instance;

	private DidDownload m_onDownloaded;

	public static FBNativeDownloader instance
	{
		get
		{
			if (_instance == null)
			{
				FBNativeDownloader fBNativeDownloader = CreateInstance();
				_instance = fBNativeDownloader;
			}
			return _instance;
		}
	}

	public event DidDownload onDownloaded
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 12;
			Delegate obj2 = this.m_onDownloaded;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 12;
			Delegate obj2 = this.m_onDownloaded;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public void DownloadImages(string iconImageURL, string coverImageURL)
	{
		IEnumerator routine = StartImageDownload(iconImageURL, coverImageURL);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator StartImageDownload(string iconImageURL, string coverImageURL)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator LoadImage(string url, Action<Texture2D> result)
	{
		_ = 0;
		IEnumerator result2 = default;
		return result2;
	}

	private static FBNativeDownloader CreateInstance()
	{
		GameObject gameObject = default;
		gameObject._002Ector("FacebookNativeImageDownloader");
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		return gameObject.AddComponent<FBNativeDownloader>();
	}
}
