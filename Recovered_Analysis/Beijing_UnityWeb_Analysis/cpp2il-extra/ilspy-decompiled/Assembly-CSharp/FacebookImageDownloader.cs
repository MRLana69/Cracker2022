using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using InApp;
using Info;
using UnityEngine;

public static class FacebookImageDownloader
{
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public Texture2D iconImage;

		public Texture2D coverImage;

		internal void _003CStartImageDownload_003Eb__0(Texture2D x)
		{
			iconImage = x;
		}

		internal void _003CStartImageDownload_003Eb__1(Texture2D x)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = x;
		}
	}

	private sealed class _003CStartImageDownload_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string iconImageUrl;

		public string coverImageUrl;

		private _003C_003Ec__DisplayClass1_0 _003C_003E8__1;

		public Action<Texture2D, Texture2D> onFinishedDownloading;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected Obj, but got Unknown
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Expected Obj, but got Unknown
				//IL_0089: Expected Obj, but got I4
				//IL_0094: Unknown result type (might be due to invalid IL or missing references)
				//IL_0099: Expected Obj, but got Unknown
				//IL_00a2: Expected Obj, but got I4
				//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d5: Expected Obj, but got Unknown
				//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ea: Expected Obj, but got Unknown
				//IL_0105: Expected Obj, but got I4
				//IL_0119: Expected Obj, but got I4
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_0157: Expected Obj, but got Unknown
				//IL_0167: Unknown result type (might be due to invalid IL or missing references)
				//IL_016c: Expected Obj, but got Unknown
				//IL_018c: Expected Obj, but got I4
				//IL_01a0: Expected Obj, but got I4
				//IL_01f9: Expected Obj, but got I
				//IL_020a: Unknown result type (might be due to invalid IL or missing references)
				//IL_020f: Expected Obj, but got Unknown
				//IL_0218: Unknown result type (might be due to invalid IL or missing references)
				//IL_021d: Expected Obj, but got Unknown
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							_003C_003Ec__DisplayClass1_0 obj = _003C_003E8__1;
							_003C_003Ec__DisplayClass1_0 obj2 = _003C_003E8__1;
							if (onFinishedDownloading != null)
							{
								nint num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S3_v5 (Il2CppMethodInfo)+18]");
								object obj3 = 0;
								object obj4 = obj3;
								object obj5 = obj4 & 0x1FFF;
								object obj6 = obj5 + 113696;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S4_v6 (should have been resolved before IL gen)");
							}
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num2 = 0;
					string text = default;
					text.m_stringLength = (int)num2;
					_ = 0;
					object obj7 = text + 16;
					obj7 = _003C_003E8__1;
					object obj8 = this + 12;
					bool flag = ((FlurryAdProvider)(object)coverImageUrl).HasCachedVideo(text);
					obj8 = flag;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				object obj9 = this + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj10 = default;
				obj9 = obj10;
				object obj11 = _003C_003E8__1 + 8;
				obj11 = 0;
				object obj12 = _003C_003E8__1 + 12;
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num3 = 0;
				string text2 = default;
				text2.m_stringLength = (int)num3;
				_ = 0;
				object obj13 = text2 + 16;
				obj13 = _003C_003E8__1;
				object obj14 = this + 12;
				bool flag2 = ((FlurryAdProvider)(object)iconImageUrl).HasCachedVideo(text2);
				obj14 = flag2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CStartImageDownload_003Ed__1(int _003C_003E1__state)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 12;
			obj = _003C_003E1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CLoadImage_003Ed__2(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public Action<Texture2D> result;

		private Texture2D _003Ctexture_003E5__2;

		private WWW _003Cwww_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_00fc: Expected I, but got Obj
				//IL_0112: Expected Obj, but got I
				//IL_013d: Expected I, but got Obj
				//IL_02af: Expected Obj, but got I4
				//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c2: Expected Obj, but got Unknown
				//IL_01cb: Expected Obj, but got I4
				object obj2 = default;
				object obj = obj2 + 16;
				obj2 = obj;
				_ = -1;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						nint num = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v83 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num2 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v107 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						object obj4 = default;
						if (obj4 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						object obj5 = this + 28;
						obj5 = 0;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					object obj6 = default;
					object obj7 = default;
					if (obj6 != obj7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
					_003C_003Em__Finally1();
					object obj8 = default;
					if (obj8 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
					}
				}
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002c: Expected Obj, but got I4
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected Obj, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected Obj, but got Unknown
			//IL_010c: Expected Obj, but got I4
			//IL_015b: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = obj2;
			_ = -1;
			object obj3 = _003C_003E1__state - -3;
			if (_003C_003E1__state != -3 && ((nint)obj3 == 1 || (nint)obj3 == 2 || (nint)obj3 == 3 || (nint)obj3 != 4))
			{
				return;
			}
			object obj4 = obj + 4;
			object obj5 = obj4 + 1;
			obj4 = obj5;
			object obj6 = obj5 << 2;
			object obj7 = obj + obj6;
			obj7 = 26;
			((IEnumerator)this).Reset();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			if ((nint)0 == -1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj + obj8;
			if ((nint)obj9 == 26)
			{
				object obj10 = obj + 4;
				if ((nint)obj10 > -1)
				{
					object obj11 = obj10 + -1;
					obj10 = obj11;
				}
			}
		}

		void IEnumerator.Reset()
		{
			_003C_003E1__state = -1;
			if (_003Cwww_003E5__3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
		}
	}

	public static void DownloadImages(string iconImageUrl, string coverImageUrl, Action<Texture2D, Texture2D> onFinishedDownloading)
	{
		((Action<string>)(object)coverImageUrl)?.Invoke((string)(object)onFinishedDownloading);
	}

	private static IEnumerator StartImageDownload(string iconImageUrl, string coverImageUrl, Action<Texture2D, Texture2D> onFinishedDownloading)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = iconImageUrl;
		object obj2 = enumerator + 16;
		obj2 = coverImageUrl;
		return enumerator;
	}

	private static IEnumerator LoadImage(string url, Action<Texture2D> result)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_011e: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_00fe: Expected I4, but got Obj
		//IL_00fe: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v10 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Strings.HasLocalizedOnlineSettings(url);
		return (IEnumerator)((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])flag, (byte)(int)result != 0);
	}
}
