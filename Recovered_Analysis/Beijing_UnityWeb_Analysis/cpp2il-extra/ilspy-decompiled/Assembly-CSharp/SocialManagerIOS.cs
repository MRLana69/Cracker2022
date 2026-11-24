using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Info;
using Kiloo;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.GameCenter;
using Kiloo.Plugins.Facebook;
using SYBO.Common.Utilities;
using UnityEngine;

public class SocialManagerIOS : MonoBehaviour
{
	public enum GCState
	{
		LoggedOut,
		Authenticating,
		LoadingFriends,
		LoggedIn
	}

	private sealed class _003CRefreshFriendImages_003Ed__30(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SocialManagerIOS _003C_003E4__this;

		public Dictionary<string, GameCenterProfile> gcProfiles;

		private int _003CphotoDownloadContext_003E5__2;

		private List<GameCenterProfile>.Enumerator _003C_003E7__wrap2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_067b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0680: Expected Obj, but got Unknown
				//IL_0689: Unknown result type (might be due to invalid IL or missing references)
				//IL_068e: Expected Obj, but got Unknown
				//IL_0697: Expected Obj, but got I4
				//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_06ab: Expected Obj, but got Unknown
				//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_04a8: Expected Obj, but got Unknown
				//IL_0484: Expected Obj, but got I4
				//IL_0513: Unknown result type (might be due to invalid IL or missing references)
				//IL_0518: Expected Obj, but got Unknown
				object obj2 = default;
				object obj = obj2 - -64;
				object obj3 = obj2 + 40;
				object obj4 = obj2 + 24;
				obj4 = 0;
				_ = 0;
				object obj5 = obj2 + 16;
				obj5 = obj;
				_ = -1;
				SocialManagerIOS socialManagerIOS = _003C_003E4__this;
				object obj10;
				object obj11 = default;
				object obj8;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1 || _003C_003E1__state == 2)
					{
						_003C_003E1__state = -3;
						if (~(socialManagerIOS._pausePhotoDownloading ? 1u : 0u) == 0 && _003CphotoDownloadContext_003E5__2 == socialManagerIOS._photoDownloadContext)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
							_003C_003E1__state = 2;
							return 1;
						}
						if (_003CphotoDownloadContext_003E5__2 != socialManagerIOS._photoDownloadContext)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						}
						else
						{
							object obj6 = this + 28;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							object obj7 = default;
							if (obj7 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj9 = default;
								obj8 = obj9;
								obj10 = obj11;
								goto IL_06e2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
							object obj12 = this + 28;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
						}
					}
					goto IL_07cd;
				}
				_003C_003E1__state = -1;
				_003CphotoDownloadContext_003E5__2 = ++socialManagerIOS._photoDownloadContext;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj13 = default;
				obj8 = obj13;
				obj10 = obj11;
				goto IL_06e2;
				IL_07cd:
				object result = default;
				return result;
				IL_06e2:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj14 = default;
				if (obj10 != obj14)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				_003C_003Em__Finally1();
				object obj15 = default;
				if (obj15 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				goto IL_07cd;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

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

		private void _003C_003Em__Finally1()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			//IL_00b5: Expected Obj, but got I4
			//IL_004b: Expected Obj, but got I4
			//IL_0104: Expected Obj, but got I
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Expected Obj, but got Unknown
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = obj2;
			_ = -1;
			if (_003C_003E1__state != -3)
			{
				object obj3 = _003C_003E1__state - 1;
				if ((nint)obj3 >= 2)
				{
					return;
				}
			}
			object obj4 = obj + 4;
			object obj5 = obj4 + 1;
			obj4 = obj5;
			object obj6 = obj5 << 2;
			object obj7 = obj + obj6;
			obj7 = 28;
			((IEnumerator)this).Reset();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			if ((nint)0 == -1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj + obj8;
			if ((nint)obj9 == 28)
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
		}
	}

	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public GameCenterProfile profile;

		public Action<GameCenterProfile, Texture2D> handler;

		public _003C_003Ec__DisplayClass31_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CDownloadPictureForProfile_003Eb__0(string playerID, Texture2D photo, string error)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_1671: Unknown result type (might be due to invalid IL or missing references)
			//IL_1676: Expected Obj, but got Unknown
			//IL_167f: Expected Obj, but got I4
			//IL_1688: Unknown result type (might be due to invalid IL or missing references)
			//IL_168d: Expected Obj, but got Unknown
			//IL_1696: Expected Obj, but got I4
			//IL_169f: Unknown result type (might be due to invalid IL or missing references)
			//IL_16a4: Expected Obj, but got Unknown
			//IL_16ad: Expected Obj, but got I4
			//IL_16bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_16c1: Expected I, but got Unknown
			//IL_16c9: Expected I, but got Obj
			//IL_16da: Invalid comparison between Obj and F4
			//IL_0027: Expected I, but got Obj
			//IL_003d: Expected Obj, but got I
			//IL_0068: Expected I, but got Obj
			//IL_0280: Expected I, but got Obj
			//IL_0296: Expected Obj, but got I
			//IL_01d9: Expected I, but got Obj
			//IL_01ef: Expected Obj, but got I
			//IL_02c1: Expected I, but got Obj
			//IL_021a: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 44;
			obj3 = 0;
			object obj4 = obj2 + 40;
			obj4 = 0;
			object obj5 = obj2 + 24;
			obj5 = 0;
			_ = 0;
			nint num = (nint)(obj2 + 16);
			num = (nint)obj;
			_ = -1;
			if (System.Runtime.CompilerServices.Unsafe.As<GameCenterProfile, UIntPtr>(ref profile) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
			{
				return;
			}
			_ = 1;
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v29 (Il2CppClass<SocialManager>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num3 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v799 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj7 = default;
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			else if (playerID != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj8 = default;
				if (obj8 != null)
				{
					nint num4 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ S0_v138 (Il2CppClass<Info.OnlineSettings>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num5 = (nint)typeof(OnlineSettings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ S0_v748 (Il2CppClass<Info.OnlineSettings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj11 = default;
					object obj10 = obj11;
					object obj13 = default;
					object obj12 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					object obj14 = default;
					if (obj10 == obj14)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						object obj15 = default;
						string text = (string)obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
						object obj17 = default;
						object obj16 = obj17;
					}
					else
					{
						object obj16 = obj12;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
					return;
				}
				nint num6 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ S0_v758 (Il2CppClass<SocialManager>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num7 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ S0_v774 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			Action<GameCenterProfile, Texture2D> action = handler;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
	}

	private sealed class _003CDownloadPictureForProfile_003Ed__31(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameCenterProfile profile;

		public Action<GameCenterProfile, Texture2D> handler;

		public SocialManager.SocialPictureSize pictureSize;

		private _003C_003Ec__DisplayClass31_0 _003C_003E8__1;

		private DateTime _003ClastRefresh_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0400: Expected Obj, but got Unknown
				//IL_0409: Unknown result type (might be due to invalid IL or missing references)
				//IL_040e: Expected VT, but got Unknown
				//IL_0417: Unknown result type (might be due to invalid IL or missing references)
				//IL_041c: Expected Obj, but got Unknown
				//IL_0425: Unknown result type (might be due to invalid IL or missing references)
				//IL_042a: Expected Obj, but got Unknown
				//IL_0433: Unknown result type (might be due to invalid IL or missing references)
				//IL_0438: Expected Obj, but got Unknown
				//IL_0441: Unknown result type (might be due to invalid IL or missing references)
				//IL_0446: Expected Obj, but got Unknown
				//IL_044f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0454: Expected Obj, but got Unknown
				//IL_045d: Expected Obj, but got I4
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Expected Obj, but got Unknown
				//IL_0076: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Expected Obj, but got Unknown
				//IL_00a9: Expected Obj, but got VT
				//IL_00bb: Expected VT, but got Obj
				//IL_00e0: Expected I, but got Obj
				//IL_00f6: Expected Obj, but got I
				//IL_0243: Unknown result type (might be due to invalid IL or missing references)
				//IL_0248: Expected Obj, but got Unknown
				//IL_0260: Expected I, but got Obj
				//IL_0276: Expected Obj, but got I
				//IL_0121: Expected I, but got Obj
				//IL_0177: Expected I, but got Obj
				//IL_018d: Expected Obj, but got I
				//IL_033b: Expected I, but got Obj
				//IL_0351: Expected Obj, but got I
				//IL_02f7: Expected Obj, but got I4
				//IL_02a1: Expected I, but got Obj
				//IL_04bb: Expected Obj, but got VT
				//IL_04c5: Expected Obj, but got VT
				//IL_04d2: Expected I8, but got Obj
				//IL_04cd: Expected native int or pointer, but got VT
				//IL_04e7: Expected Ref, but got VT
				//IL_04f3: Expected Obj, but got I8
				//IL_0594: Expected Obj, but got VT
				//IL_059e: Expected Obj, but got VT
				//IL_05ab: Expected I8, but got Obj
				//IL_05a6: Expected native int or pointer, but got VT
				//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_05dc: Expected Obj, but got Unknown
				//IL_0582: Expected I4, but got Obj
				//IL_02e9: Expected Obj, but got I4
				//IL_01b8: Expected I, but got Obj
				//IL_037c: Expected I, but got Obj
				//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c6: Expected Obj, but got Unknown
				//IL_03cf: Expected Obj, but got I4
				//IL_03e3: Expected Obj, but got I4
				object obj = default;
				IFormatProvider formatProvider = (IFormatProvider)(obj + 56);
				DateTime dateTime = (DateTime)(obj + 48);
				object obj2 = obj + 40;
				object obj3 = obj + 32;
				object obj4 = obj + 16;
				object obj5 = obj + 8;
				object obj6 = obj + 24;
				obj6 = 0;
				object result;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						result = null;
						goto IL_0538;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					object obj7 = this + 28;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj8 = default;
					obj7 = obj8;
					object obj9 = _003C_003E8__1 + 8;
					obj9 = profile;
					object obj10 = _003C_003E8__1 + 12;
					obj10 = handler;
					_003C_003Ec__DisplayClass31_0 obj11 = _003C_003E8__1;
					GameCenterProfile gameCenterProfile = obj11.profile;
					obj2 = gameCenterProfile.refreshedTime;
					formatProvider = (IFormatProvider)obj2;
					_003ClastRefresh_003E5__2 = (DateTime)formatProvider;
					_003C_003Ec__DisplayClass31_0 obj12 = _003C_003E8__1;
					GameCenterProfile gameCenterProfile2 = obj12.profile;
					nint num = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v86 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!(gameCenterProfile2.image != null))
					{
						DateTime utcNow = CDateTime.UtcNow;
						nint num3 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v84 (Il2CppClass<System.DateTime>)+BA]");
						object obj14 = (nint)0 & (nint)0x200;
						if (obj14 != null)
						{
							nint num4 = (nint)typeof(DateTime);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v94 (Il2CppClass<System.DateTime>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj3 = utcNow;
						obj4 = _003ClastRefresh_003E5__2;
						((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj3;
						formatProvider = (IFormatProvider)obj4;
						long num5 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
						obj6 = num5;
						double num6 = (double)obj6 * 1E-07;
						bool flag = num6 > 3600.0;
						bool flag2 = !flag;
						result = null;
						if (flag2)
						{
							goto IL_0538;
						}
					}
					_003C_003Ec__DisplayClass31_0 obj15 = _003C_003E8__1;
					GameCenterProfile gameCenterProfile3 = obj15.profile;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint method_ptr = 0;
					FacebookSession.RequestCompleteHandler requestCompleteHandler = default;
					((Delegate)requestCompleteHandler).method_ptr = method_ptr;
					((Delegate)requestCompleteHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass31_0._003CDownloadPictureForProfile_003Eb__0);
					object obj16 = requestCompleteHandler + 16;
					obj16 = _003C_003E8__1;
					nint num7 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S1_v63 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj17 = (nint)0 & (nint)0x200;
					if (obj17 != null)
					{
						nint num8 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S1_v68 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					IDictionary<string, object> dictionary = ((pictureSize != SocialManager.SocialPictureSize.Large) ? ((IDictionary<string, object>)50) : ((IDictionary<string, object>)250));
					((FacebookSession)(object)gameCenterProfile3.id).GraphRequest((string)null, dictionary, (HttpMethod)dictionary, requestCompleteHandler);
				}
				_003C_003Ec__DisplayClass31_0 obj18 = _003C_003E8__1;
				GameCenterProfile gameCenterProfile4 = obj18.profile;
				nint num9 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v33 (Il2CppClass<System.DateTime>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num10 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v50 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj5 = gameCenterProfile4.refreshedTime;
				obj = _003ClastRefresh_003E5__2;
				((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
				formatProvider = (IFormatProvider)obj;
				long num11 = (long)(dateTime.dateData & 0x3FFFFFFFFFFFFFFFL);
				object obj20 = formatProvider & 0x3FFFFFFFFFFFFFFFL;
				if (num11 == (long)obj20)
				{
					object obj21 = this + 12;
					obj21 = 0;
					_003C_003E1__state = 1;
					result = 1;
				}
				else
				{
					result = null;
				}
				goto IL_0538;
				IL_0538:
				return result;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static GameCenterPlugin.RequestCompleteHandler _003C_003E9__36_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			SocialManager._003C_003Ec obj = default;
			SocialManager._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CReportScore_003Eb__36_0(string error)
		{
		}
	}

	private const string ONLINESETTINGS_FILTER_GC_FRIENDS_KEY = "social_filter_gc_friends";

	private const bool FILTER_GC_FRIENDS_USING_LEADERBOARD_DEFAULT = true;

	private const string GC_LEADERBOARD_ID = "com.kiloo.subwaysurfers.ScoreLeaderboard";

	private static SocialManagerIOS _instance;

	private GCState _gcState;

	private Dictionary<string, GameCenterProfile> _gcFriends;

	private static Action<GameCenterProfile> m_playerPhotoDownloadedHandler;

	private bool _pausePhotoDownloading;

	private int _photoDownloadContext;

	private List<string> _latestPreConsolidationGCIds;

	private List<string> _latestSuccesfullyConsolidationGCIds;

	private static bool _applicationIsQuiting;

	private int _loadFriendsContext;

	private GameCenterPlugin.ShowViewState _lastViewState;

	private string _lastLeaderboardCategory;

	private GameCenterPlugin.LeaderboardTimeScope _lastTimeScope;

	private Action _invalidate;

	public GCState gameCenterState
	{
		get
		{
			//IL_0016: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SocialManagerIOS)+70]");
			object obj = (nint)0 & (nint)1;
			return (obj != null) ? GCState.Authenticating : GCState.LoggedOut;
		}
		set
		{
			_ = 0;
		}
	}

	public bool pausePhotoDownloading
	{
		get
		{
			return (byte)_gcState != 0;
		}
		set
		{
			if (_gcState != (value ? GCState.Authenticating : GCState.LoggedOut))
			{
				_gcState = (value ? GCState.Authenticating : GCState.LoggedOut);
			}
		}
	}

	public static SocialManagerIOS instance => (SocialManagerIOS)(object)"Smart Phone";

	public static bool isInstanced
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009e: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManagerIOS>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SocialManagerIOS);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<SocialManagerIOS>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SocialManagerIOS._002Ecctor();
			return (byte)(int)_instance != 0;
		}
	}

	private static event Action<GameCenterProfile> playerPhotoDownloadedHandler
	{
		add
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected Obj, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected Obj, but got Unknown
			//IL_0093: Expected Obj, but got I4
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected Obj, but got Unknown
			_ = 1;
			object obj = value + 36;
			obj = "unset";
			object obj3 = default;
			object obj2 = obj3 + 8;
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC47");
			obj3 = obj2;
			object obj4 = obj3 + 16;
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManagerIOS>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SocialManagerIOS);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SocialManagerIOS>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = SocialManagerIOS.m_playerPhotoDownloadedHandler;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(SocialManagerIOS);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SocialManagerIOS>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(SocialManagerIOS);
				if (!flag)
				{
					nint num5 = (nint)typeof(SocialManagerIOS);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SocialManagerIOS>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SocialManagerIOS);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SocialManagerIOS);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SocialManagerIOS>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	private void OnApplicationQuit()
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(SocialManagerIOS);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManagerIOS>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SocialManagerIOS>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = SocialManagerIOS.m_playerPhotoDownloadedHandler;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SocialManagerIOS>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(SocialManagerIOS);
			if (!flag)
			{
				nint num5 = (nint)typeof(SocialManagerIOS);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SocialManagerIOS>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(SocialManagerIOS);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(SocialManagerIOS);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SocialManagerIOS>)+5C]");
			object obj5 = (nint)0 + (nint)4;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	private static void Init()
	{
	}

	private void Awake()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SocialManagerIOS);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManagerIOS>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SocialManagerIOS>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_applicationIsQuiting = true;
	}

	public void LoadFriends()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SocialManagerIOS);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManagerIOS>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SocialManagerIOS>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_instance = this;
	}

	private IEnumerator RefreshFriendImages(Dictionary<string, GameCenterProfile> gcProfiles)
	{
		//IL_00ab: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		if (gcProfiles.comparer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SocialManagerIOS)+38]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SocialManagerIOS)+38]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v15+10]");
				return (IEnumerator)0;
			}
			return null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SocialManagerIOS)+3C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SocialManagerIOS)+3C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+C]");
			return (IEnumerator)0;
		}
		return null;
	}

	public IEnumerator DownloadPictureForProfile(GameCenterProfile profile, SocialManager.SocialPictureSize pictureSize, Action<GameCenterProfile, Texture2D> handler)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 24;
		obj = this;
		object obj2 = enumerator + 16;
		obj2 = profile;
		object obj3 = enumerator + 28;
		obj3 = pictureSize;
		object obj4 = enumerator + 20;
		obj4 = handler;
		return enumerator;
	}

	public void AbortAsynchronousProcesses()
	{
		//IL_01b5: Expected I, but got Obj
		//IL_01cb: Expected Obj, but got I
		//IL_0126: Expected I, but got Obj
		//IL_013c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0167: Expected I, but got Obj
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0224: Expected I, but got Obj
		//IL_023a: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I4
		//IL_0279: Expected Obj, but got I4
		//IL_0279: Expected Obj, but got I4
		//IL_0279: Expected Obj, but got I4
		//IL_00d9: Expected I, but got Obj
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v57 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref GameCenterPlugin.LocalPlayer player = default;
		GameCenterPlugin.GetLocalPlayer(ref player);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (LocalPlayer&)+D]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj3 = default;
			object obj2 = obj3 + 12;
			obj2 = this;
			int loadFriendsContext = _loadFriendsContext + 1;
			_loadFriendsContext = loadFriendsContext;
			if (_gcState != GCState.LoadingFriends)
			{
				_gcState = GCState.LoadingFriends;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			Action<string> action = default;
			object obj4 = action + 16;
			obj4 = obj3;
			nint num4 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v46 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num5 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v52 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DeviceUtility.ShowNativePopup("com.kiloo.subwaysurfers.ScoreLeaderboard", (string)1, (string)2, (string)1, (string)100, action);
			return;
		}
		nint num6 = (nint)typeof(SocialManagerIOS);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19 (Il2CppClass<SocialManagerIOS>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v25 (Il2CppClass<SocialManagerIOS>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
	}

	private unsafe void FlurryLogGCFriendsRetrieved(int total, int withGameInstalled)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0024: Expected Obj, but got I4
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected Ref, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected Obj, but got Unknown
		//IL_066a: Expected Obj, but got I4
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected Obj, but got Unknown
		//IL_0687: Expected Obj, but got I4
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected Obj, but got Unknown
		//IL_06a4: Expected Obj, but got I4
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got VT
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected Obj, but got Unknown
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected Obj, but got Unknown
		//IL_0725: Expected Obj, but got I4
		//IL_08b0: Expected Obj, but got I4
		//IL_0258: Expected Obj, but got I
		//IL_0759: Expected Obj, but got I4
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_0168: Expected Obj, but got I4
		//IL_07a3: Expected I, but got Obj
		//IL_07b9: Expected Obj, but got I
		//IL_0337: Expected Obj, but got I
		//IL_0347: Expected Obj, but got I
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_08ee: Expected Obj, but got VT
		//IL_0908: Expected Obj, but got VT
		//IL_0368: Expected I, but got Obj
		//IL_03cc: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 96;
		object obj3 = obj2 + 80;
		obj3 = total;
		ref GameCenterPlugin.LocalPlayer reference = ref *(GameCenterPlugin.LocalPlayer*)(obj2 + 16);
		object obj4 = obj2 - -64;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 48;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 40;
		obj6 = 0;
		object obj7 = obj2 + 32;
		obj7 = obj;
		_ = -1;
		if (withGameInstalled == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [withGameInstalled @ L2 (System.Int32)+C]");
		string value = (string)((nint)0 << 3);
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector(value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [withGameInstalled @ L2 (System.Int32)+C]");
		string value2 = (string)((nint)0 << 1);
		StringBuilder stringBuilder2 = default;
		stringBuilder2._002Ector(value2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj4 = reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (LocalPlayer&)+8]");
		_ = 0;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v184+20]");
			bool flag = (nint)0 != 0;
			bool flag2 = (byte)((flag ? 1u : 0u) | 2u) != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v184+1C]");
			if ((nint)0 != 0)
			{
				bool flag3 = flag2;
			}
			else
			{
				bool flag3 = flag;
				flag2 = flag;
			}
			bool flag4 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v184+8]");
			bool flag5 = (nint)0 == 0;
			object obj9 = flag4 | flag5;
			if (obj9 == null)
			{
				object obj10 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
				if ((nint)obj10 >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			}
		}
		object obj11 = obj7 + 4;
		object obj12 = obj11 + 1;
		obj11 = obj12;
		object obj13 = obj12 << 2;
		object obj14 = obj7 + obj13;
		obj14 = 135;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj7 + obj15;
			if ((nint)obj16 == 135)
			{
				object obj17 = obj7 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				goto IL_0899;
			}
		}
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0899;
		IL_0899:
		object obj20 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
		if ((nint)obj20 <= 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SocialManagerIOS)+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SocialManagerIOS)+38]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v146+10]");
			object obj22 = 0;
		}
		else
		{
			object obj22 = "";
		}
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S0_v63 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S0_v139 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameCenterPlugin.GetLocalPlayer(ref reference);
		obj5 = reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (LocalPlayer&)+8]");
		_ = 0;
		obj2 = reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (LocalPlayer&)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+D]");
		if ((nint)0 != 0)
		{
			reference = ref *(GameCenterPlugin.LocalPlayer*)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (LocalPlayer&)+4]");
			object obj24 = 0;
		}
		else
		{
			object obj24 = "";
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private void PerformLoadFriendsDoneActions()
	{
		int photoDownloadContext = _photoDownloadContext + 1;
		_photoDownloadContext = photoDownloadContext;
		int loadFriendsContext = _loadFriendsContext + 1;
		_loadFriendsContext = loadFriendsContext;
	}

	public bool IsDoneAuthenticating()
	{
		return _pausePhotoDownloading;
	}

	public void ReportScore(int newScore)
	{
		int num = newScore & 1;
		_pausePhotoDownloading = (byte)num != 0;
	}

	public void ShowLeaderBoard()
	{
		if (_gcState != GCState.LoggedIn)
		{
			_gcState = GCState.LoggedIn;
		}
		if (_invalidate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	public string GetGCListAsStringAndSaveAsPreConsolidated()
	{
		//IL_0051: Expected Obj, but got I4
		//IL_0033: Expected Obj, but got I4
		if (_gcState == GCState.LoggedIn)
		{
			return (string)1;
		}
		bool flag = _gcState == GCState.LoggedOut;
		return (string)flag;
	}

	public unsafe void HandleConsolidatedFriendsSuccess()
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		GameCenterPlugin.LoadLeaderboardCompletionHandler loadLeaderboardCompletionHandler = default;
		((Delegate)loadLeaderboardCompletionHandler).method_ptr = method_ptr;
		((Delegate)loadLeaderboardCompletionHandler).method = (nint)__ldftn(SocialManagerIOS._003CShowLeaderBoard_003Eb__40_0);
		object obj = loadLeaderboardCompletionHandler + 16;
		obj = this;
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S3_v8 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S3_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameCenterPlugin.LoadLeaderboardForIDs((string)_lastViewState, (string[])(object)_lastLeaderboardCategory, _lastTimeScope, loadLeaderboardCompletionHandler);
	}

	public bool HasUnconsolidatedGCFriends()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_02ce: Expected Obj, but got I4
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_02b2: Expected I4, but got Obj
		//IL_0073: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00f0: Expected Obj, but got I4
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected Obj, but got Unknown
		//IL_0376: Expected Obj, but got I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_03eb: Expected Obj, but got I
		//IL_03fb: Expected Obj, but got I
		//IL_040b: Expected Obj, but got I
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected Obj, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_01ff: Expected Obj, but got I
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if (_latestPreConsolidationGCIds != null)
		{
			throw new IndexOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		object obj5 = this + 28;
		obj5 = list;
		string text = default;
		if (_gcFriends != null)
		{
			Dictionary<string, GameCenterProfile>.KeyCollection keys = _gcFriends.Keys;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v16 (Il2CppMethodInfo)+C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v17+60]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v18+8]");
			object obj8 = 0;
			object obj9 = obj8 & 0x3FFF;
			object obj10 = obj9 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v84 @ S2_v5 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @821F");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj11 = 0;
			object obj12 = default;
			object obj17 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj12 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj13 = obj11 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj14 = text + 16;
				object obj15 = obj11 << 2;
				object obj16 = obj14 + obj15;
				obj16 = obj17;
				obj11 = obj13;
			}
			object obj18 = obj4 + 4;
			object obj19 = obj18 + 1;
			obj18 = obj19;
			object obj20 = obj19 << 2;
			object obj21 = obj4 + obj20;
			obj21 = 116;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj22 = (nint)0 << 2;
				object obj23 = obj4 + obj22;
				if ((nint)obj23 == 116)
				{
					object obj24 = obj4 + 4;
					if ((nint)obj24 > -1)
					{
						object obj25 = obj24 + -1;
						obj24 = obj25;
					}
					goto IL_03b9;
				}
			}
			object obj26 = default;
			if (obj26 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_03b9;
		}
		return (byte)(int)"" != 0;
		IL_03b9:
		int result = string.CompareOrdinalIgnoreCaseHelper(";", text);
		List<string> latestPreConsolidationGCIds = _latestPreConsolidationGCIds;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S4_v3 (Il2CppMethodInfo)+C]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S4_v4+60]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S4_v5+38]");
		object obj29 = 0;
		object obj30 = obj29 & 0x1FFF;
		object obj31 = obj30 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v99 @ S5_v5 (should have been resolved before IL gen)");
		return (byte)result != 0;
	}

	public void ClearFriends()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0029: Expected Obj, but got I4
		object obj = this + 32;
		obj = _latestPreConsolidationGCIds;
		object obj2 = this + 28;
		obj2 = 0;
	}

	public bool GCFriendsContainKey(string key)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		object obj2 = (flag ? 1 : 0) + 20;
		obj2 = key;
		return flag;
	}

	public GameCenterProfile TryGetUserProfileFromKey(string key)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I4
		if (_gcFriends != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S2_v3 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S2_v4+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v5+44]");
			object obj3 = 0;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v30 @ S3_v5 (should have been resolved before IL gen)");
			object obj6 = default;
			bool flag = (nint)obj6 > -1;
			return (GameCenterProfile)flag;
		}
		return null;
	}

	public unsafe void AddInvalidateHandler(Action handler)
	{
		//IL_01ca: Expected I, but got Obj
		//IL_01e0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_02f6: Expected I, but got Obj
		//IL_030c: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_0280: Expected I, but got Obj
		//IL_0296: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v31 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref GameCenterPlugin.LocalPlayer player = default;
		GameCenterPlugin.GetLocalPlayer(ref player);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (LocalPlayer&)+D]");
		if ((nint)0 == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v19 (Il2CppClass<SocialManagerIOS+<>c>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v25 (Il2CppClass<SocialManagerIOS+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__36_0 == null;
		bool flag2 = !flag;
		GameCenterPlugin.RequestCompleteHandler requestCompleteHandler = _003C_003Ec._003C_003E9__36_0;
		if (!flag2)
		{
			nint num5 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v23 (Il2CppClass<SocialManagerIOS+<>c>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v40 (Il2CppClass<SocialManagerIOS+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			GameCenterPlugin.RequestCompleteHandler requestCompleteHandler2 = default;
			((Delegate)requestCompleteHandler2).method_ptr = method_ptr;
			((Delegate)requestCompleteHandler2).method = (nint)__ldftn(_003C_003Ec._003CReportScore_003Eb__36_0);
			object obj4 = requestCompleteHandler2 + 16;
			obj4 = _003C_003Ec._003C_003E9;
			nint num7 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v37 (Il2CppClass<SocialManagerIOS+<>c>)+5C]");
			object obj5 = (nint)0 + (nint)4;
			obj5 = requestCompleteHandler2;
			requestCompleteHandler = requestCompleteHandler2;
		}
		nint num8 = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num9 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v18 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D7CC");
	}

	public static void AddPlayerPhotoDownloadedHandler(Action<GameCenterProfile> handler)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0045: Expected Obj, but got I4
		object obj = handler + 32;
		obj = 0;
		object obj2 = handler + 28;
		obj2 = 0;
		object obj3 = handler + 16;
		obj3 = 0;
	}

	public static void RemovePlayerPhotoDownloadedHandler(Action<GameCenterProfile> handler)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SocialManagerIOS);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManagerIOS>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<SocialManagerIOS>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		playerPhotoDownloadedHandler -= handler;
	}

	public static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0028: Expected Obj, but got I
		object obj = msg + 52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+34]");
		Delegate obj2 = ((Delegate)0).CombineImpl((Delegate)(object)context);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj3 = default;
		obj = obj3;
	}

	public static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		SDebug.LogFormat(msg, (object[])(object)context);
	}

	public static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public SocialManagerIOS()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SocialManagerIOS);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManagerIOS>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<SocialManagerIOS>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnApplicationQuit();
	}

	static SocialManagerIOS()
	{
		//IL_0247: Expected I, but got Obj
		//IL_025d: Expected Obj, but got I
		//IL_02d4: Expected I, but got Obj
		//IL_02ea: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0153: Expected I4, but got Obj
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_01f4: Expected VT, but got I4
		//IL_01f4: Expected Obj, but got I4
		//IL_01a2: Expected I, but got Obj
		//IL_020f: Expected Obj, but got I4
		//IL_0234: Expected VT, but got I4
		//IL_0234: Expected Obj, but got I4
		nint num = (nint)typeof(SocialManagerIOS);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManagerIOS>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v52 (Il2CppClass<SocialManagerIOS>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(_instance != null))
		{
			return;
		}
		nint num5 = (nint)typeof(SocialManagerIOS);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v16 (Il2CppClass<SocialManagerIOS>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v46 (Il2CppClass<SocialManagerIOS>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_applicationIsQuiting ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Stream stream = default;
		UnityEngine.ManagedStreamHelpers.ValidateLoadFromStream(stream);
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)stream, (byte)(int)"SocialManagerIOS" != 0);
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.UnitySynchronizationContext)(object)stream).Exec();
		SocialManagerIOS socialManagerIOS = ((GameObject)(object)stream).AddComponent<SocialManagerIOS>();
		int layer = ((GameObject)(object)stream).layer;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)layer, HierarchyPathType.Dynamic, (Vector3)0);
		int layer2 = ((GameObject)(object)stream).layer;
		((HierarchyUtility)layer2)._002Ector();
		int layer3 = ((GameObject)(object)stream).layer;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)layer3, HierarchyPathType.DynamicManagers, (Vector3)0);
	}

	private void _003CShowLeaderBoard_003Eb__40_0(GameCenterPlugin.ShowViewState viewState, string leaderboardCategory, GameCenterPlugin.LeaderboardTimeScope leaderboardTimescope)
	{
		//IL_003b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SocialManagerIOS)+3C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SocialManagerIOS)+3C]");
			object obj = (nint)0 + (nint)20;
			obj = leaderboardCategory;
		}
	}
}
