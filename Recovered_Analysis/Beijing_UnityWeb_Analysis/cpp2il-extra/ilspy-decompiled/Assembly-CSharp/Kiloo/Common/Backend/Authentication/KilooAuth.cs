using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Ads;
using Kiloo.Common.Backend.Cloud;
using Kiloo.Common.HTTP;
using Kiloo.Common.HTTP.Internal;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.Backend.Authentication;

public sealed class KilooAuth : IKilooAuth
{
	public delegate void DetachPlatformsCompleteHandler(bool success, Error error);

	public class TempCode
	{
		public string code;

		public DateTimeOffset expires;

		public TempCode()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public delegate void GenerateTemporaryCodeCompleteHandler(TempCode tempCode, Error error);

	private struct PersistentAuthData
	{
		public string loginToken;

		public KilooAuthState state;

		public DateTime expires;

		public string kilooId;

		public string kilooTag;

		public Dictionary<string, string> signatures;
	}

	private class AccessTokenResult
	{
		public string accessToken;

		public string kilooId;

		public string kilooTag;

		public DateTime expires;
	}

	private sealed class _003Cget_platforms_003Ed__30 : IEnumerable<IKilooAuthPlatform>, IEnumerable, IEnumerator<IKilooAuthPlatform>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private IKilooAuthPlatform _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public KilooAuth _003C_003E4__this;

		private Dictionary<string, IKilooAuthPlatform>.ValueCollection.Enumerator _003C_003E7__wrap1;

		IKilooAuthPlatform IEnumerator<IKilooAuthPlatform>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_020a: Unknown result type (might be due to invalid IL or missing references)
				//IL_020f: Expected Obj, but got Unknown
				//IL_0218: Unknown result type (might be due to invalid IL or missing references)
				//IL_021d: Expected Obj, but got Unknown
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Expected Obj, but got Unknown
				//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ba: Expected Obj, but got Unknown
				//IL_014b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0150: Expected Obj, but got Unknown
				//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f1: Expected Obj, but got Unknown
				//IL_010b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0110: Expected Obj, but got Unknown
				//IL_012c: Expected Obj, but got I4
				object obj2 = default;
				object obj = obj2 + 48;
				object obj3 = obj2 + 24;
				object obj4 = obj2 + 16;
				obj4 = obj;
				_ = -1;
				KilooAuth kilooAuth = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					IKilooAuthPlatform result = default;
					if (_003C_003E1__state != 1)
					{
						return result;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					object obj5 = this + 24;
					obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
				}
				_003C_003E1__state = -3;
				object obj6 = this + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj7 = default;
				if (obj7 != null)
				{
					object obj8 = this + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					object obj9 = this + 12;
					object obj10 = default;
					obj9 = obj10;
					_003C_003E1__state = 1;
					return (IKilooAuthPlatform)1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj11 = this + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003Cget_platforms_003Ed__30(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
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
		}

		IEnumerator<IKilooAuthPlatform> IEnumerable<IKilooAuthPlatform>.GetEnumerator()
		{
			return (IEnumerator<IKilooAuthPlatform>)_003C_003E2__current;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected Obj, but got Unknown
			if (_003C_003E1__state == -2)
			{
				bool hasShutdownStarted = Environment.HasShutdownStarted;
				if (_003C_003El__initialThreadId == (hasShutdownStarted ? 1 : 0))
				{
					_003C_003E1__state = 0;
					goto IL_0097;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8589");
			_003Cget_platforms_003Ed__30 obj2 = default;
			object obj = obj2 + 20;
			obj = _003C_003E4__this;
			goto IL_0097;
			IL_0097:
			return obj2;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<KeyValuePair<string, IKilooAuthPlatform>, bool> _003C_003E9__44_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			SimulatedCloudServer._003C_003Ec obj = default;
			SimulatedCloudServer._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal bool _003CCanAuthenticate_003Eb__44_0(KeyValuePair<string, IKilooAuthPlatform> pair)
		{
			//IL_006a: Expected Obj, but got I
			//IL_007f: Expected Obj, but got I
			//IL_001f: Expected Obj, but got I
			//IL_0034: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Authentication.KilooAuth+<>c)+8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5+8]");
			string text = default;
			if (text != (string)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Authentication.KilooAuth+<>c)+8]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v11+C]");
				string text2 = default;
				return text2 != (string)0;
			}
			return false;
		}
	}

	private sealed class _003CAuthenticateCoroutine_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KilooAuth _003C_003E4__this;

		public AuthenticateCompleteHandler completeHandler;

		private Error _003Cerror_003E5__2;

		private Dictionary<string, string> _003Csignatures_003E5__3;

		private IRequest _003Crequest_003E5__4;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_06d1: Expected VT, but got Unknown
				//IL_06da: Unknown result type (might be due to invalid IL or missing references)
				//IL_06df: Expected Obj, but got Unknown
				//IL_06e8: Expected Obj, but got I4
				//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_06fc: Expected Obj, but got Unknown
				//IL_0705: Expected Obj, but got I4
				//IL_0714: Unknown result type (might be due to invalid IL or missing references)
				//IL_0719: Expected Obj, but got Unknown
				//IL_0722: Expected Obj, but got I4
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_008b: Expected Obj, but got Unknown
				//IL_0094: Expected Obj, but got I4
				//IL_0427: Unknown result type (might be due to invalid IL or missing references)
				//IL_042c: Expected Obj, but got Unknown
				//IL_0435: Expected Obj, but got I4
				//IL_0449: Expected Obj, but got I4
				//IL_0495: Expected Obj, but got I4
				//IL_0109: Expected Obj, but got I4
				//IL_038b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0390: Expected Obj, but got Unknown
				//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03be: Expected Obj, but got Unknown
				//IL_03c7: Expected Obj, but got I4
				//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d2: Expected Obj, but got Unknown
				//IL_03db: Expected Obj, but got I4
				//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0501: Expected Obj, but got Unknown
				//IL_050a: Unknown result type (might be due to invalid IL or missing references)
				//IL_050f: Expected Obj, but got Unknown
				//IL_053b: Expected Obj, but got I4
				//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b8: Expected Obj, but got Unknown
				//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c9: Expected Obj, but got Unknown
				//IL_01f9: Expected Obj, but got I
				//IL_02fa: Expected I, but got Obj
				//IL_0310: Expected Obj, but got I
				//IL_0873: Unknown result type (might be due to invalid IL or missing references)
				//IL_0878: Expected Obj, but got Unknown
				//IL_088e: Expected Obj, but got I4
				//IL_08a2: Expected Obj, but got I4
				//IL_05c3: Expected Obj, but got I
				//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_07fb: Expected Obj, but got Unknown
				//IL_0255: Expected I, but got Obj
				//IL_026b: Expected Obj, but got I
				//IL_079b: Expected I4, but got Obj
				//IL_0796: Expected native int or pointer, but got VT
				//IL_07b0: Expected Obj, but got I
				//IL_07ab: Expected native int or pointer, but got VT
				//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_07bb: Expected Obj, but got Unknown
				//IL_07eb: Expected Obj, but got I4
				//IL_033b: Expected I, but got Obj
				//IL_075f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0764: Expected Obj, but got Unknown
				//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_05fe: Expected Obj, but got Unknown
				//IL_0296: Expected I, but got Obj
				//IL_062f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0634: Expected Obj, but got Unknown
				object obj2 = default;
				object obj = obj2 - -64;
				WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj2 + 48);
				object obj3 = obj2 + 32;
				obj3 = 0;
				_ = 0;
				object obj4 = obj2 + 16;
				obj4 = 0;
				_ = 0;
				object obj5 = obj2 + 8;
				obj5 = 0;
				obj2 = obj;
				_ = -1;
				KilooAuth kilooAuth = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state != 3)
							{
								return null;
							}
							_003C_003E1__state = -1;
							object obj6 = this + 24;
							IEnumerator enumerator = _003C_003E4__this.DetachPlatformsCoroutine((string[])(object)_003Crequest_003E5__4, (DetachPlatformsCompleteHandler)(object)_003Csignatures_003E5__3);
							obj6 = enumerator;
							object obj7 = this + 28;
							obj7 = 0;
							object obj8 = this + 32;
							obj8 = 0;
						}
						else
						{
							_003C_003E1__state = -1;
							if (!_003C_003E4__this.IsCachedTokenValid())
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								obj5 = 2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
								throw new NullReferenceException();
							}
							if (KilooAuthErrorExtensions.KilooAuthError((Error)(object)_003C_003E4__this) == KilooAuthError.Unknown)
							{
								object obj9 = _003C_003E4__this + 32;
								_ = 1;
								AuthenticateCompleteHandler authenticateCompleteHandler = (AuthenticateCompleteHandler)(this + 28);
								IEnumerator jsonData = _003C_003E4__this.AuthenticateCoroutine(authenticateCompleteHandler);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v134 (System.Collections.IEnumerator)+10]");
								nint num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v134 (System.Collections.IEnumerator)+1C]");
								object obj10 = num - 0;
								bool flag = obj10 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								Uri uri = default;
								if (flag)
								{
									uri._002Ector(kilooAuth._baseUri, (Uri)(object)"api/v3/user/create");
									nint num2 = (nint)typeof(KilooWebClient);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S0_v166 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
									object obj11 = (nint)0 & (nint)0x200;
									if (obj11 != null)
									{
										nint num3 = (nint)typeof(KilooWebClient);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v172 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									object obj12 = this + 32;
									IRequest request = KilooWebClient.CreateGet(uri);
									obj12 = request;
								}
								else
								{
									uri._002Ector(kilooAuth._baseUri, (Uri)(object)"api/v3/user/login");
									nint num4 = (nint)typeof(KilooWebClient);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v154 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
									object obj13 = (nint)0 & (nint)0x200;
									if (obj13 != null)
									{
										nint num5 = (nint)typeof(KilooWebClient);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S0_v160 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									object obj14 = this + 32;
									IRequest request2 = KilooWebClient.CreateGet(uri);
									IRequest request3 = RequestExtensions.WithBsonContent(request2, jsonData, (IBsonSerializer)kilooAuth._jsonSerializer);
									obj14 = request3;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
								_ = int.MaxValue;
								((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj4 != 0;
								WebClient.SendOptions sendOptions2 = sendOptions;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
								System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions2)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
								object obj15 = this + 12;
								Coroutine coroutine = WebClient.RequestAsync(_003Crequest_003E5__4, null, sendOptions);
								obj15 = coroutine;
								_003C_003E1__state = 3;
								return 1;
							}
						}
						if (completeHandler != null)
						{
							bool allowAnonymous = _003C_003E4__this.allowAnonymous;
							bool flag2 = (allowAnonymous ? 1 : 0) == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8957");
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					object obj16 = this + 24;
					obj16 = 0;
					bool allowAnonymous2 = _003C_003E4__this.allowAnonymous;
				}
				bool allowAnonymous3 = _003C_003E4__this.allowAnonymous;
				if (allowAnonymous3)
				{
					object obj17 = this + 12;
					obj17 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
				Dictionary<string, IKilooAuthPlatform>.ValueCollection values = kilooAuth._platforms.Values;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @773C");
				obj3 = sendOptions.disableCache;
				_ = sendOptions.simulatedRequestResults;
				object obj18 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj18 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				}
				object obj19 = obj2 + 4;
				object obj20 = obj19 + 1;
				obj19 = obj20;
				object obj21 = obj20 << 2;
				object obj22 = obj2 + obj21;
				obj22 = 167;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					object obj23 = (nint)0 << 2;
					object obj24 = obj2 + obj23;
					if ((nint)obj24 == 167)
					{
						object obj25 = obj2 + 4;
						if ((nint)obj25 > -1)
						{
							object obj26 = obj25 + -1;
							obj25 = obj26;
						}
						goto IL_086d;
					}
				}
				object obj27 = default;
				if (obj27 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				goto IL_086d;
				IL_086d:
				object obj28 = this + 12;
				object deposit = default;
				int num6 = Depository.CheckIn(deposit, null);
				obj28 = num6;
				_003C_003E1__state = 2;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CAuthenticateCoroutine_003Ed__48(int _003C_003E1__state)
		{
			//IL_001d: Expected Obj, but got I4
			this._003C_003E1__state = _003C_003E1__state;
			bool hasShutdownStarted = Environment.HasShutdownStarted;
			_003C_003E4__this = (KilooAuth)hasShutdownStarted;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_000a: Expected I4, but got Obj
			return (byte)(int)((IEnumerable)(object)this).GetEnumerator() != 0;
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

	private sealed class _003CDetachPlatformsCoroutine_003Ed__49(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public string[] platformsToDetach;

		public KilooAuth _003C_003E4__this;

		public DetachPlatformsCompleteHandler completeHandler;

		private IRequest _003Crequest_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0563: Unknown result type (might be due to invalid IL or missing references)
				//IL_0568: Expected VT, but got Unknown
				//IL_0571: Unknown result type (might be due to invalid IL or missing references)
				//IL_0576: Expected Ref, but got Unknown
				//IL_0588: Unknown result type (might be due to invalid IL or missing references)
				//IL_058d: Expected Obj, but got Unknown
				//IL_0596: Expected Obj, but got I4
				//IL_05a5: Expected Obj, but got I4
				//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ba: Expected Obj, but got Unknown
				//IL_02db: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e0: Expected Obj, but got Unknown
				//IL_0474: Expected Obj, but got I4
				//IL_00fe: Expected I, but got Obj
				//IL_0114: Expected Obj, but got I
				//IL_033d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0342: Expected Obj, but got Unknown
				//IL_0370: Unknown result type (might be due to invalid IL or missing references)
				//IL_0375: Expected Obj, but got Unknown
				//IL_037e: Expected Obj, but got I4
				//IL_05ef: Expected I4, but got Obj
				//IL_0187: Unknown result type (might be due to invalid IL or missing references)
				//IL_018c: Expected Obj, but got Unknown
				//IL_019c: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a1: Expected Obj, but got Unknown
				//IL_01b7: Expected Obj, but got I4
				//IL_013f: Expected I, but got Obj
				//IL_01df: Expected I4, but got Obj
				//IL_01da: Expected native int or pointer, but got VT
				//IL_01f4: Expected Obj, but got I
				//IL_01ef: Expected native int or pointer, but got VT
				//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ff: Expected Obj, but got Unknown
				//IL_022f: Expected Obj, but got I4
				//IL_0641: Expected I4, but got Obj
				//IL_038e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0393: Expected Obj, but got Unknown
				//IL_039e: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a3: Expected Obj, but got Unknown
				//IL_03d3: Expected Obj, but got I
				//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e5: Expected Obj, but got Unknown
				object obj = default;
				WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 32);
				ref ServiceResponse<AccessTokenResult> reference = ref *(ServiceResponse<AccessTokenResult>*)(obj + 24);
				reference = ref *(ServiceResponse<AccessTokenResult>*)null;
				object obj2 = obj + 8;
				obj2 = 0;
				_ = 0;
				obj = 0;
				KilooAuth kilooAuth = _003C_003E4__this;
				Error error;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						reference = ref *(ServiceResponse<AccessTokenResult>*)null;
						IResponse response = default;
						if (response != null)
						{
							bool flag = ResponseExtensions.TryParseJson<ServiceResponse<AccessTokenResult>>(response, out reference, kilooAuth._jsonSerializer);
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj4 = default;
						object obj3 = obj4 ^ 1;
						ServiceResponse<AccessTokenResult> serviceResponse = reference;
						bool flag2 = reference == null;
						object obj5 = flag2 | obj3;
						ServiceResponse<AccessTokenResult> serviceResponse2 = reference;
						if (obj5 == null)
						{
							if (serviceResponse.result != null)
							{
								object obj6 = _003C_003E4__this + 32;
								ServiceResponse<AccessTokenResult> serviceResponse3 = reference;
								AccessTokenResult result = serviceResponse3.result;
								obj6 = result.accessToken;
								object obj7 = platformsToDetach + 12;
								object obj8 = 0;
								while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
								{
									object obj9 = _003C_003E4__this + 32;
									object obj10 = platformsToDetach + 16;
									object obj11 = obj8 << 2;
									object key = obj10 + obj11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v134+18]");
									bool flag3 = ((Dictionary<string, string>)0).Remove((string)key);
									object obj12 = obj8 + 1;
									obj8 = obj12;
								}
								LogError((string)(object)_003C_003E4__this);
								error = null;
								goto IL_0509;
							}
							serviceResponse2 = reference;
						}
						if (serviceResponse2 != null && serviceResponse2.error != null)
						{
							ServiceResponse<AccessTokenResult> serviceResponse4 = reference;
							error = serviceResponse4.error;
							string msg = string.ConcatArray((string[])(object)"DetachPlatformsAsync: ", (int)error.message);
							LogWarning(msg);
							goto IL_0509;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						obj = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						throw new NullReferenceException();
					}
					return null;
				}
				_003C_003E1__state = -1;
				if (platformsToDetach != null)
				{
					string[] array = platformsToDetach;
					if (array.Length != 0)
					{
						bool allowAnonymous = _003C_003E4__this.allowAnonymous;
						if ((allowAnonymous ? 1 : 0) != 2)
						{
							LogWarning("DetachPlatformsAsync: Not authorized.");
							return null;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Uri uri = default;
						uri._002Ector(kilooAuth._baseUri, (Uri)(object)"api/v3/user/detach");
						nint num = (nint)typeof(KilooWebClient);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v40 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num2 = (nint)typeof(KilooWebClient);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v64 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						IRequest request = KilooWebClient.CreateGet(uri);
						bool flag4 = ((AbstractAdProvider)request).IsSupportedOnPlatform((AdType)_003C_003E4__this);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						object obj15 = default;
						object obj14 = obj15 + 8;
						obj14 = platformsToDetach;
						object obj16 = this + 28;
						IRequest request2 = RequestExtensions.WithBsonContent((IRequest)flag4, obj15, (IBsonSerializer)kilooAuth._jsonSerializer);
						obj16 = request2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
						((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj2 != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
						System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
						object obj17 = this + 12;
						Coroutine coroutine = WebClient.RequestAsync(_003Crequest_003E5__2, null, sendOptions);
						obj17 = coroutine;
						_003C_003E1__state = 1;
						return 1;
					}
					return null;
				}
				return null;
				IL_0509:
				if (completeHandler != null)
				{
					bool flag5 = error == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8957");
				}
				return null;
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CGenerateTemporaryCodeCoroutine_003Ed__50(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public KilooAuth _003C_003E4__this;

		public GenerateTemporaryCodeCompleteHandler completeHandler;

		private IRequest _003Crequest_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_03fd: Expected VT, but got Unknown
				//IL_0406: Unknown result type (might be due to invalid IL or missing references)
				//IL_040b: Expected Ref, but got Unknown
				//IL_041d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0422: Expected Obj, but got Unknown
				//IL_042b: Expected Obj, but got I4
				//IL_043a: Expected Obj, but got I4
				//IL_00b6: Expected I, but got Obj
				//IL_00cc: Expected Obj, but got I
				//IL_046e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0473: Expected Obj, but got Unknown
				//IL_048f: Expected I4, but got Obj
				//IL_049b: Expected Obj, but got I4
				//IL_0205: Unknown result type (might be due to invalid IL or missing references)
				//IL_020a: Expected Obj, but got Unknown
				//IL_0213: Expected VT, but got Obj
				//IL_022b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0230: Expected Obj, but got Unknown
				//IL_0239: Expected VT, but got Obj
				//IL_0143: Expected I4, but got Obj
				//IL_013e: Expected native int or pointer, but got VT
				//IL_0158: Expected Obj, but got I
				//IL_0153: Expected native int or pointer, but got VT
				//IL_015e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0163: Expected Obj, but got Unknown
				//IL_0193: Expected Obj, but got I4
				//IL_00f7: Expected I, but got Obj
				//IL_02cd: Invalid comparison between VT and I4
				//IL_0337: Expected Obj, but got I4
				//IL_0267: Expected VT, but got Obj
				//IL_0270: Expected VT, but got Obj
				//IL_0289: Unknown result type (might be due to invalid IL or missing references)
				//IL_028e: Expected Obj, but got Unknown
				//IL_029e: Expected Obj, but got I
				//IL_02ae: Expected Obj, but got I
				//IL_02bf: Expected Obj, but got I4
				//IL_030f: Expected VT, but got Obj
				//IL_031f: Expected Obj, but got I
				//IL_04f5: Expected Obj, but got I4
				object obj = default;
				WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 32);
				ref _0021_00210 reference = ref *(_0021_00210*)(obj + 24);
				reference = ref *(_0021_00210*)null;
				object obj2 = obj + 8;
				obj2 = 0;
				_ = 0;
				obj = 0;
				KilooAuth kilooAuth = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						reference = ref *(_0021_00210*)null;
						IResponse response = default;
						if (response != null)
						{
							bool flag = ResponseExtensions.TryParseBson<T>(response, out System.Runtime.CompilerServices.Unsafe.As<_0021_00210, T>(ref reference), (IBsonSerializer)kilooAuth._jsonSerializer);
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj4 = default;
						object obj3 = obj4 ^ 1;
						_0021_00210 val = (_0021_00210)System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
						bool flag2 = System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference) == null;
						object obj5 = flag2 | obj3;
						_0021_00210 val2 = (_0021_00210)System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v63 (T)+8]");
							bool flag3 = (nint)0 == 0;
							_0021_00210 val3 = (_0021_00210)System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
							val2 = (_0021_00210)System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
							if (!flag3)
							{
								object obj6 = _003C_003E4__this + 8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S1_v72 (T)+8]");
								object obj7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v75+8]");
								obj6 = 0;
								object obj8 = obj7;
								object obj9 = 0;
								goto IL_04aa;
							}
						}
						if (val2 != (_0021_00210)(object)0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ L1_v9 (T)+C]");
							if ((nint)0 != 0)
							{
								_0021_00210 val4 = (_0021_00210)System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v100 (T)+C]");
								object obj9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ L1_v8+10]");
								string msg = string.ConcatArray((string[])(object)"GenerateTemporaryCodeAsync: ", 0);
								LogWarning(msg);
								object obj8 = 0;
								goto IL_04aa;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						obj = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						throw new NullReferenceException();
					}
					return null;
				}
				_003C_003E1__state = -1;
				bool allowAnonymous = _003C_003E4__this.allowAnonymous;
				if ((allowAnonymous ? 1 : 0) != 2)
				{
					LogWarning("GenerateTemporaryCodeAsync: Not authorized.");
					return null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Uri uri = default;
				uri._002Ector(kilooAuth._baseUri, (Uri)(object)"api/v3/user/generatetemporarycode");
				nint num = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v31 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num2 = (nint)typeof(KilooWebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v46 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj11 = this + 24;
				IRequest request = KilooWebClient.CreateGet(uri);
				bool flag4 = ((AbstractAdProvider)request).IsSupportedOnPlatform((AdType)_003C_003E4__this);
				obj11 = flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
				((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj2 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
				System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
				object obj12 = this + 12;
				Coroutine coroutine = WebClient.RequestAsync(_003Crequest_003E5__2, null, sendOptions);
				obj12 = coroutine;
				_003C_003E1__state = 1;
				return 1;
				IL_04aa:
				if (completeHandler != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
				}
				return null;
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

		void IEnumerator.Reset()
		{
		}
	}

	public const string KILOO_ID_KEY = "kilooId";

	public const string TEMPORARY_CODE_KEY = "temporaryCode";

	private string temporaryCode__BackingField;

	private bool allowAnonymous__BackingField;

	private const float TIME_TOLERANCE = 60f;

	private const string API_CREATE = "api/v3/user/create";

	private const string API_LOGIN = "api/v3/user/login";

	private const string API_DETACH = "api/v3/user/detach";

	private const string API_GENERATE_TEMPORARY_CODE = "api/v3/user/generatetemporarycode";

	private readonly Uri _baseUri;

	private readonly string _file;

	private readonly IJsonSerializer _jsonSerializer;

	private readonly Dictionary<string, IKilooAuthPlatform> _platforms;

	private PersistentAuthData _data;

	public string temporaryCode
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0894: Unknown result type (might be due to invalid IL or missing references)
			//IL_0899: Expected Obj, but got Unknown
			//IL_08a2: Expected Obj, but got I4
			//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_08bc: Expected Obj, but got Unknown
			//IL_08c5: Expected Obj, but got I4
			//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d3: Expected Obj, but got Unknown
			//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ef: Expected Obj, but got Unknown
			//IL_08f8: Expected Obj, but got I4
			//IL_0907: Unknown result type (might be due to invalid IL or missing references)
			//IL_090c: Expected Obj, but got Unknown
			//IL_0915: Expected Obj, but got I4
			//IL_0937: Unknown result type (might be due to invalid IL or missing references)
			//IL_093c: Expected Obj, but got Unknown
			//IL_09ec: Expected Obj, but got I4
			//IL_0052: Expected Obj, but got I4
			//IL_0954: Unknown result type (might be due to invalid IL or missing references)
			//IL_0959: Expected Obj, but got Unknown
			//IL_0073: Expected Obj, but got I4
			//IL_0093: Expected Obj, but got I4
			//IL_00ab: Expected Obj, but got I4
			//IL_00c3: Expected Obj, but got I4
			//IL_00db: Expected Obj, but got I4
			//IL_07e1: Expected Obj, but got I
			//IL_00f3: Expected Obj, but got I4
			//IL_010b: Expected Obj, but got I4
			//IL_0817: Unknown result type (might be due to invalid IL or missing references)
			//IL_081c: Expected Obj, but got Unknown
			//IL_011e: Expected I, but got Obj
			//IL_0134: Expected Obj, but got I
			//IL_084d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0852: Expected Obj, but got Unknown
			//IL_01d8: Expected I, but got Obj
			//IL_01ee: Expected Obj, but got I
			//IL_015f: Expected I, but got Obj
			//IL_09d4: Expected Obj, but got I4
			//IL_0274: Expected Obj, but got I4
			//IL_0219: Expected I, but got Obj
			//IL_09bc: Expected Obj, but got I4
			//IL_01a2: Expected Obj, but got I4
			//IL_0287: Expected I, but got Obj
			//IL_029d: Expected Obj, but got I
			//IL_02ef: Expected Obj, but got I4
			//IL_025c: Expected Obj, but got I4
			//IL_073b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0740: Expected Obj, but got Unknown
			//IL_0749: Unknown result type (might be due to invalid IL or missing references)
			//IL_074e: Expected Obj, but got Unknown
			//IL_077a: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 112;
			object obj3 = obj2 + 88;
			obj3 = 0;
			_ = 0;
			_ = 0;
			object obj4 = obj2 + 48;
			obj4 = 0;
			object obj5 = obj2 + 80;
			obj5 = obj;
			_ = -1;
			object obj6 = obj2 + 32;
			obj6 = 0;
			_ = 0;
			object obj7 = obj2 + 16;
			obj7 = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<ICloudItem> list = default;
			list._002Ector();
			object obj8 = obj2 + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
			obj3 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v30+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v30+10]");
			_ = 0;
			object obj10 = default;
			SimulatedCloudServer.Item.GetBytesFunction getBytesFunction2 = default;
			object obj9;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj9 = 41;
				bool flag = obj10 == null;
				obj9 = 44;
				if (flag)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj9 = 15;
				obj4 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj9 = 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj9 = 17;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj9 = 18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj9 = 19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj9 = 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj9 = 21;
				nint num = (nint)typeof(SimulatedCloudServer._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S0_v155 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num2 = (nint)typeof(SimulatedCloudServer._003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ S0_v230 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						obj9 = 21;
					}
				}
				obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				if (SimulatedCloudServer._003C_003Ec._003C_003E9__44_0 != null)
				{
					obj6 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					SimulatedCloudServer.Item.GetBytesFunction getBytesFunction = SimulatedCloudServer._003C_003Ec._003C_003E9__44_0;
				}
				else
				{
					nint num3 = (nint)typeof(SimulatedCloudServer._003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ S0_v190 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num4 = (nint)typeof(SimulatedCloudServer._003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ S0_v218 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							obj9 = 30;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					obj9 = 39;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
					obj9 = 39;
					nint num5 = (nint)typeof(SimulatedCloudServer._003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ S0_v213 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c>)+5C]");
					object obj13 = (nint)0 + (nint)12;
					obj13 = getBytesFunction2;
					obj6 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+8]");
					_ = 0;
					SimulatedCloudServer.Item.GetBytesFunction getBytesFunction = getBytesFunction2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				obj9 = 40;
				obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31");
				obj9 = 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			object obj14 = obj9 - 15;
			object obj21;
			object obj22 = default;
			if ((nint)obj9 != 15)
			{
				if ((nint)obj14 != 1)
				{
					if ((nint)obj14 != 2 && (nint)obj14 != 3 && (nint)obj14 != 4 && (nint)obj14 != 5 && (nint)obj14 != 6)
					{
						if ((nint)obj14 == 7 || (nint)obj14 == 8 || (nint)obj14 == 9 || (nint)obj14 == 10 || (nint)obj14 == 11 || (nint)obj14 == 12 || (nint)obj14 == 13 || (nint)obj14 == 14)
						{
							goto IL_0a2c;
						}
						if ((nint)obj14 != 15)
						{
							if ((nint)obj14 == 16 || (nint)obj14 == 17 || (nint)obj14 == 18 || (nint)obj14 == 19 || (nint)obj14 == 20 || (nint)obj14 == 21 || (nint)obj14 == 22 || (nint)obj14 == 23)
							{
								goto IL_0a2c;
							}
							if ((nint)obj14 != 24)
							{
								if ((nint)obj14 != 25)
								{
									if ((nint)obj14 != 26)
									{
										if ((nint)obj14 != 27 && (nint)obj14 != 28 && (nint)obj14 == 29)
										{
											object obj15 = obj5 + 4;
											object obj16 = obj15 + 1;
											obj15 = obj16;
											object obj17 = obj16 << 2;
											object obj18 = obj5 + obj17;
											obj18 = 145;
										}
										goto IL_0a2c;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj20 = default;
									object obj19 = obj20;
									obj21 = obj22;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj23 = default;
									object obj19 = obj23;
									obj21 = obj22;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj24 = default;
								object obj19 = obj24;
								obj21 = obj22;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj25 = default;
							object obj19 = obj25;
							obj21 = obj22;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj26 = default;
						object obj19 = obj26;
						obj21 = obj22;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj27 = default;
					object obj19 = obj27;
					obj21 = obj22;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj28 = default;
				object obj19 = obj28;
				obj21 = obj22;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj29 = default;
			if (obj21 == obj29)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
			goto IL_0a2c;
			IL_0a51:
			return (string)(object)list.ToArray();
			IL_0a2c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj30 = (nint)0 << 2;
				object obj31 = obj5 + obj30;
				if ((nint)obj31 == 145)
				{
					object obj32 = obj5 + 4;
					if ((nint)obj32 > -1)
					{
						object obj33 = obj32 + -1;
						obj32 = obj33;
					}
					goto IL_0a51;
				}
			}
			object obj34 = default;
			if (obj34 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_0a51;
		}
		set
		{
			throw new InvalidOperationException();
		}
	}

	public string kilooTag => temporaryCode__BackingField;

	public string accessToken
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0018: Expected Obj, but got I
			object obj = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
			return (string)0;
		}
	}

	public KilooAuthState state
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0010: Expected I4, but got Obj
			object obj = this + 32;
			return (KilooAuthState)obj;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 8;
			obj = value;
		}
	}

	public unsafe bool allowAnonymous
	{
		get
		{
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected I4, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Expected Obj, but got Unknown
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected VT, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected Obj, but got Unknown
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected Obj, but got Unknown
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Expected Obj, but got Unknown
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_001e: Expected I, but got Obj
			//IL_0034: Expected Obj, but got I
			//IL_0154: Expected Obj, but got I
			//IL_0161: Expected I4, but got Obj
			//IL_0169: Expected native int or pointer, but got VT
			//IL_0184: Expected Obj, but got I4
			//IL_019b: Expected I4, but got Obj
			//IL_01b5: Expected Obj, but got I4
			//IL_005f: Expected I, but got Obj
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected Obj, but got Unknown
			DBNull dBNull = default;
			int num = dBNull + 56;
			DBNull dBNull2 = (DBNull)(dBNull + 40);
			decimal num2 = dBNull + 16;
			object obj = dBNull + 32;
			object obj2 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+4]");
			if ((nint)0 == 2)
			{
				object obj3 = this + 32;
				nint num3 = (nint)typeof(DateTimeOffset);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v28 (Il2CppClass<System.DateTimeOffset>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(DateTimeOffset);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v44 (Il2CppClass<System.DateTimeOffset>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v25+8]");
				obj = 0;
				((int*)num)->m_value = (int)obj;
				*(decimal*)(nint)num2 = new decimal(num);
				dBNull._002Ector();
				dBNull2 = (DBNull)num2.flags;
				_ = num2.lo;
				((int*)num)->m_value = (int)dBNull;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (System.DBNull)+8]");
				_ = 0;
				string text = dBNull2.ToString((IFormatProvider)num);
				if (text != null)
				{
					object obj5 = this + 32;
					_ = 5;
				}
			}
			object obj6 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v22+4]");
			return false;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 32;
		}
	}

	public IEnumerable<IKilooAuthPlatform> platforms
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = allowAnonymous__BackingField;
			return (IEnumerable<IKilooAuthPlatform>)flag;
		}
	}

	public KilooAuth(Uri baseUri, string file, bool allowAnonymous, IJsonSerializer jsonSerializer, IKilooAuthPlatform[] platforms)
	{
		//IL_02a1: Expected Obj, but got I4
		//IL_00ed: Expected I, but got Obj
		//IL_0103: Expected Obj, but got I
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_031e: Expected Obj, but got VT
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected Obj, but got Unknown
		//IL_038f: Expected I, but got Obj
		//IL_03a5: Expected Obj, but got I
		//IL_012e: Expected I, but got Obj
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected Obj, but got Unknown
		//IL_0448: Expected Obj, but got VT
		//IL_0454: Expected Obj, but got I4
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_0467: Expected Obj, but got I4
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_0493: Expected Obj, but got I4
		//IL_017b: Expected I, but got Obj
		//IL_0191: Expected Obj, but got I
		//IL_0209: Expected I, but got Obj
		//IL_03cb: Expected Obj, but got I4
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_03ef: Expected Obj, but got VT
		//IL_01bc: Expected I, but got Obj
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		object obj = 0;
		if (!Directory.IsRootDirectory(file))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentNullException ex = default;
			ex._002Ector("localDir");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		if (!allowAnonymous)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentOutOfRangeException ex2 = default;
			ex2._002Ector("cloudServer");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		if (jsonSerializer == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentOutOfRangeException ex3 = default;
			ex3._002Ector("fileSaver");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		_platforms = (Dictionary<string, IKilooAuthPlatform>)(object)baseUri;
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v21 (Il2CppClass<System.IO.Path>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v84 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = this + 32;
		string fullPathInternal = Path.GetFullPathInternal(file);
		obj3 = fullPathInternal;
		PersistentAuthData data = _data;
		char[] separator = (char[])(data.expires - 1);
		string[] array = ((string)_data).Split(separator);
		object obj4 = array & 0xFFFF;
		if ((nint)obj4 != (int)Path.DirectorySeparatorChar)
		{
			nint num3 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v71 (Il2CppClass<System.IO.Path>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v78 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = Path.DirectorySeparatorChar;
			object obj6 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
			int totalLength = default;
			string text = string.ConcatArray((string[])_data, totalLength);
			obj6 = text;
		}
		object obj7 = this + 20;
		obj7 = jsonSerializer;
		object obj8 = this + 24;
		obj8 = platforms;
		nint num5 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v40 (Il2CppClass<System.IO.Path>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v64 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj10 = this + 36;
		bool flag = Path.SameRoot((string)_data, ".cloudsave");
		obj10 = flag;
		object obj11 = this + 16;
		obj11 = allowAnonymous;
		object obj12 = this + 12;
		string deviceModel = SystemInfo.GetDeviceModel();
		obj12 = deviceModel;
		if ((string)this.allowAnonymous__BackingField != "<unknown>")
		{
			object obj13 = this + 12;
			string graphicsDeviceName = SystemInfo.GetGraphicsDeviceName();
			obj13 = graphicsDeviceName;
		}
		((CloudWorkingCopy)this).SaveWorkingCopy();
		string text2 = ((CloudWorkingCopy)this).kilooTag;
		if (text2 != null)
		{
			CloudWorkingCopy.Log("Wrong account used for cloud save.");
		}
		((CloudWorkingCopy)this).Abort();
	}

	public KilooAuth(Uri baseUri, string file, bool allowAnonymous, IJsonSerializer jsonSerializer, IEnumerable<IKilooAuthPlatform> platforms)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_001a: Expected I4, but got Obj
		base((UIWidget)(object)baseUri, (int)file, (List<Vector3>)allowAnonymous, (List<Vector2>)jsonSerializer, (List<Color>)platforms);
	}

	public Coroutine AuthenticateAsync(AuthenticateCompleteHandler completeHandler = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
		Coroutine result = default;
		return result;
	}

	public void Invalidate()
	{
		//IL_005d: Expected I4, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string message = string.ConcatArray((string[])(object)"[SimulatedCloudServer] ", (int)this);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(message);
	}

	public void AddPlatform(IKilooAuthPlatform platform)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		bool flag = (byte)(platform & 1) != 0;
		allowAnonymous__BackingField = flag;
	}

	public void RemovePlatform(string platformKey)
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S4_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S4_v4+48]");
		object obj3 = 0;
		object obj4 = obj3 & 0x7FF;
		object obj5 = obj4 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S5_v4 (should have been resolved before IL gen)");
	}

	public bool HasPlatform(string platformKey)
	{
		//IL_001b: Expected I4, but got Obj
		IEnumerator list = GenerateTemporaryCodeCoroutine((GenerateTemporaryCodeCompleteHandler)(object)platformKey);
		return (byte)(int)CoroutineUtil.WaitForAll((YieldInstruction[])(object)list) != 0;
	}

	public Coroutine DetachPlatformsAsync(string[] platformsToDetach, DetachPlatformsCompleteHandler completeHandler = null)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Coroutine coroutine = default;
		coroutine.m_Ptr = (IntPtr)0;
		object obj = coroutine + 16;
		obj = this;
		object obj2 = coroutine + 20;
		obj2 = platformsToDetach;
		object obj3 = coroutine + 24;
		obj3 = completeHandler;
		return coroutine;
	}

	public Coroutine GenerateTemporaryCodeAsync(GenerateTemporaryCodeCompleteHandler completeHandler = null)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I4
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		bool flag = (nint)obj6 > -1;
		return (Coroutine)flag;
	}

	public void Reset()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		bool flag = allowAnonymous;
		if ((flag ? 1 : 0) == 2)
		{
			object obj = this + 32;
			_ = 4;
			LogError((string)(object)this);
		}
		else
		{
			Log("Invalidate called when not Authorized. This has no effect.");
		}
	}

	private bool CanAuthenticate()
	{
		//IL_0027: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8589");
		bool flag = default;
		object obj = (flag ? 1 : 0) + 20;
		obj = this;
		return flag;
	}

	private bool IsCachedTokenValid()
	{
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01bc: Expected I, but got Obj
		//IL_01d2: Expected Obj, but got I
		//IL_00f0: Expected I, but got Obj
		if (~(allowAnonymous__BackingField ? 1u : 0u) == 0)
		{
			return true;
		}
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v4 (Il2CppClass<Kiloo.Common.Backend.Authentication.KilooAuth+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v41 (Il2CppClass<Kiloo.Common.Backend.Authentication.KilooAuth+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__44_0 == null;
		bool flag2 = !flag;
		Func<KeyValuePair<string, IKilooAuthPlatform>, bool> predicate = _003C_003Ec._003C_003E9__44_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v15 (Il2CppClass<Kiloo.Common.Backend.Authentication.KilooAuth+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v35 (Il2CppClass<Kiloo.Common.Backend.Authentication.KilooAuth+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Func<KeyValuePair<string, IKilooAuthPlatform>, bool> func = default;
			object obj3 = func + 16;
			obj3 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v32 (Il2CppClass<Kiloo.Common.Backend.Authentication.KilooAuth+<>c>)+5C]");
			object obj4 = (nint)0 + (nint)4;
			obj4 = func;
			predicate = func;
		}
		return Enumerable.Any(_platforms, predicate);
	}

	private unsafe Dictionary<string, object> BuildAuthenticationRequestContent(out Dictionary<string, string> signatures)
	{
		//IL_000a: Expected Obj, but got Ref
		string authenticatedSignature = GetAuthenticatedSignature((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref signatures));
		return (Dictionary<string, object>)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)authenticatedSignature);
	}

	private Error HandleAuthenticationResult(IRequest request, Dictionary<string, string> signatures)
	{
		//IL_000e: Expected I4, but got Obj
		//IL_001b: Expected Obj, but got I4
		bool flag = ((AbstractAdProvider)this).HasCachedAd((AdType)request, (string)(object)signatures);
		return (Error)(object)CoroutineUtil.WaitForAll((YieldInstruction[])flag);
	}

	private IEnumerator AuthenticateCoroutine(AuthenticateCompleteHandler completeHandler)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Expected Obj, but got Unknown
		//IL_07a3: Expected Obj, but got I4
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Expected Obj, but got Unknown
		//IL_07e5: Expected Obj, but got I
		//IL_07f5: Expected Obj, but got I
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Expected Obj, but got Unknown
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Expected Obj, but got Unknown
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Expected Obj, but got Unknown
		//IL_0873: Expected Obj, but got I
		//IL_0883: Expected Obj, but got I
		//IL_0894: Unknown result type (might be due to invalid IL or missing references)
		//IL_0899: Expected Obj, but got Unknown
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Expected I, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_00b4: Expected Obj, but got I
		//IL_00c4: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_0158: Expected Obj, but got I4
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_06e2: Expected Obj, but got I
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected Obj, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected Obj, but got Unknown
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected Obj, but got Unknown
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected Obj, but got Unknown
		//IL_065a: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S3_v3+60]");
		object obj6 = 0;
		object obj7 = obj6;
		object obj8 = obj7 & 0x1FFF;
		object obj9 = obj8 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v55 @ S4_v4 (should have been resolved before IL gen)");
		object obj10 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v21+10]");
		if ((nint)0 != 0)
		{
			object obj11 = this + 32;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S4_v21 (Il2CppMethodInfo)+C]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S4_v22+60]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S4_v23+48]");
			object obj14 = 0;
			object obj15 = obj14 & 0x7FF;
			object obj16 = obj15 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v82 @ S5_v13 (should have been resolved before IL gen)");
		}
		else if (temporaryCode__BackingField != null)
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S4_v16 (Il2CppMethodInfo)+C]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S4_v17+60]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S4_v18+48]");
			object obj19 = 0;
			object obj20 = obj19 & 0x7FF;
			object obj21 = obj20 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v91 @ S5_v9 (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S3_v8 (Il2CppMethodInfo)+C]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S3_v9+60]");
		object obj23 = 0;
		object obj24 = obj23;
		object obj25 = obj24 & 0x1FFF;
		nint num5 = (nint)(obj25 + 113696);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v164 @ S4_v12 (Il2CppMethodInfo) (should have been resolved before IL gen)");
		Dictionary<string, IKilooAuthPlatform>.ValueCollection values = _platforms.Values;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @773C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj26 = default;
		object obj27 = default;
		object obj28 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj26 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj27 == null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj28 == null)
			{
				object obj29 = this + 32;
				num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S0_v158+10]");
				if ((nint)0 != 0)
				{
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			num5 = 0;
		}
		object obj30 = 36;
		object obj31 = obj30 - 13;
		if ((nint)obj30 != 13 && (nint)obj31 != 1 && (nint)obj31 != 2 && (nint)obj31 != 3)
		{
			if ((nint)obj31 != 4 && (nint)obj31 != 5 && (nint)obj31 != 6 && (nint)obj31 != 7 && (nint)obj31 != 8)
			{
				if ((nint)obj31 == 9 || (nint)obj31 == 10 || (nint)obj31 == 11 || (nint)obj31 == 12)
				{
					goto IL_065f;
				}
				if ((nint)obj31 != 13 && (nint)obj31 != 14 && (nint)obj31 != 15 && (nint)obj31 != 16 && (nint)obj31 != 17 && (nint)obj31 != 18 && (nint)obj31 != 19)
				{
					if ((nint)obj31 == 20 || (nint)obj31 == 21 || (nint)obj31 == 22)
					{
						goto IL_065f;
					}
					if ((nint)obj31 == 23)
					{
						object obj32 = obj4 + 4;
						object obj33 = obj32 + 1;
						obj32 = obj33;
						object obj34 = obj33 << 2;
						object obj35 = obj4 + obj34;
						obj35 = 212;
					}
				}
			}
			goto IL_08ed;
		}
		goto IL_065f;
		IL_0912:
		object obj36 = default;
		AuthenticateCompleteHandler authenticateCompleteHandler = (AuthenticateCompleteHandler)obj36;
		IEnumerator result = default;
		return result;
		IL_065f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj37 = default;
		object obj38 = default;
		if (obj37 == obj38)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_08ed;
		IL_08ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj39 = (nint)0 << 2;
			object obj40 = obj4 + obj39;
			if ((nint)obj40 == 212)
			{
				object obj41 = obj4 + 4;
				if ((nint)obj41 > -1)
				{
					object obj42 = obj41 + -1;
					obj41 = obj42;
				}
				goto IL_0912;
			}
		}
		object obj43 = default;
		if (obj43 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0912;
	}

	private unsafe IEnumerator DetachPlatformsCoroutine(string[] platformsToDetach, DetachPlatformsCompleteHandler completeHandler)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected Ref, but got Unknown
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected Obj, but got Unknown
		//IL_06b9: Expected Obj, but got I4
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected VT, but got Unknown
		//IL_06d0: Expected VT, but got I4
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Expected Obj, but got Unknown
		//IL_06ed: Expected Obj, but got I4
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected Obj, but got Unknown
		//IL_070a: Expected Obj, but got I4
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_05f6: Expected Obj, but got I4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_01f0: Expected I, but got Obj
		//IL_0206: Expected Obj, but got I
		//IL_0767: Expected Obj, but got I8
		//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cb: Expected Obj, but got Unknown
		//IL_028d: Expected Obj, but got I
		//IL_02ac: Expected VT, but got Obj
		//IL_0231: Expected I, but got Obj
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0844: Expected Obj, but got Unknown
		//IL_0852: Expected I, but got Obj
		//IL_0868: Expected Obj, but got I
		//IL_0932: Expected Obj, but got I
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Expected Obj, but got Unknown
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Expected Obj, but got Unknown
		//IL_02e4: Expected Ref, but got VT
		//IL_02f6: Expected I, but got Obj
		//IL_030c: Expected Obj, but got I
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Expected Obj, but got Unknown
		//IL_050c: Expected I, but got Obj
		//IL_0788: Expected Obj, but got VT
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected Obj, but got Unknown
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Expected Obj, but got Unknown
		//IL_07d5: Expected I, but got Obj
		//IL_07eb: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got I
		//IL_03e0: Expected Obj, but got I8
		//IL_0337: Expected I, but got Obj
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got Unknown
		//IL_0384: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 160;
		ref ServiceResponse<AccessTokenResult> reference = ref *(ServiceResponse<AccessTokenResult>*)(obj2 + 156);
		reference = ref *(ServiceResponse<AccessTokenResult>*)null;
		object obj3 = obj2 + 80;
		obj3 = 0;
		DateTime? dateTime = (DateTime?)(object)(obj2 + 56);
		dateTime = (DateTime?)(object)0;
		_ = 0;
		object obj4 = obj2 + 32;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 152;
		obj5 = 0;
		object obj6 = obj2 + 144;
		obj6 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		reference = ref *(ServiceResponse<AccessTokenResult>*)null;
		IResponse response = default;
		if (response != null)
		{
			bool flag = ResponseExtensions.TryParseJson<ServiceResponse<AccessTokenResult>>(response, out reference, _jsonSerializer);
		}
		Headers headers = (Headers)(obj2 + 128);
		Response response2 = (Response)(obj2 + 112);
		object obj7 = obj2 + 104;
		object obj8 = obj2 + 96;
		object obj9 = obj2 + 88;
		object obj10 = obj2 + 72;
		object obj11 = obj2 + 48;
		object obj12 = obj2 + 24;
		object obj13 = obj2 + 16;
		object obj14 = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj16 = default;
		object obj15 = obj16 ^ 1;
		ServiceResponse<AccessTokenResult> serviceResponse = reference;
		bool flag2 = reference == null;
		object obj17 = flag2 | obj15;
		ServiceResponse<AccessTokenResult> serviceResponse2 = reference;
		IEnumerator result2;
		if (obj17 == null)
		{
			bool flag3 = serviceResponse.result == null;
			ServiceResponse<AccessTokenResult> serviceResponse3 = reference;
			serviceResponse2 = reference;
			if (!flag3)
			{
				object obj18 = this + 32;
				AccessTokenResult result = serviceResponse3.result;
				obj18 = result.accessToken;
				object obj19 = this + 48;
				obj19 = result.kilooId;
				object obj20 = this + 52;
				obj20 = result.kilooTag;
				object obj21 = this + 32;
				_ = 2;
				object obj22 = result + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCA5");
				object obj23 = default;
				obj7 = obj23;
				headers = (Headers)obj7;
				object obj24 = this + 32;
				nint num = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v106 (Il2CppClass<System.DateTime>)+BA]");
				object obj25 = (nint)0 & (nint)0x200;
				if (obj25 != null)
				{
					nint num2 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v248 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
				obj3 = systemTimeAsFileTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
				headers = (Headers)obj4;
				Headers headers2 = headers;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16+8]");
				headers2._headers = (Dictionary<string, List<string>>)0;
				int status = default;
				response2._002Ector(status, "Date", headers, null);
				dateTime = (DateTime?)(object)response2;
				_ = response2.status__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (System.Nullable`1<System.DateTime>)+8]");
				if ((nint)0 != 0)
				{
					DateTime value = ((DateTime?*)dateTime)->Value;
					nint num3 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v163 (Il2CppClass<System.DateTime>)+BA]");
					object obj26 = (nint)0 & (nint)0x200;
					if (obj26 != null)
					{
						nint num4 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ S0_v244 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj8 = value;
					obj9 = obj3;
					response2 = (Response)obj8;
					headers = (Headers)obj9;
					long num5 = ((DateTime*)response2)->System_002EIConvertible_002EToInt64((IFormatProvider)headers);
					object obj27 = this + 32;
					object obj28 = this + 32;
					nint num6 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S0_v179 (Il2CppClass<System.DateTime>)+BA]");
					object obj29 = (nint)0 & (nint)0x200;
					if (obj29 != null)
					{
						nint num7 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S0_v234 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S0_v176+8]");
					obj10 = 0;
					obj11 = num5;
					response2 = (Response)obj10;
					headers = (Headers)obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DC");
					object obj31 = default;
					object obj30 = obj31 << 32;
					object obj33 = default;
					object obj32 = obj33 | obj30;
					obj12 = obj32;
					headers = (Headers)obj12;
				}
				object obj34 = this + 32;
				nint num8 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S0_v132 (Il2CppClass<System.DateTime>)+BA]");
				object obj35 = (nint)0 & (nint)0x200;
				if (obj35 != null)
				{
					nint num9 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S0_v154 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S0_v127+8]");
				obj13 = 0;
				obj14 = obj3;
				response2 = (Response)obj13;
				headers = (Headers)obj14;
				object obj36 = response2 & 0x3FFFFFFFFFFFFFFFL;
				object obj37 = headers & 0x3FFFFFFFFFFFFFFFL;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj36) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj37))
				{
					LogWarning("Access token expire time returned by server is in the past. This is an error.");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCA8");
					object obj38 = default;
					obj2 = obj38;
					headers = (Headers)obj2;
					object obj39 = this + 32;
				}
				object obj40 = this + 56;
				obj40 = completeHandler;
				result2 = null;
				goto IL_09a4;
			}
		}
		if (serviceResponse2 != null && serviceResponse2.error != null)
		{
			ServiceResponse<AccessTokenResult> serviceResponse4 = reference;
			Error error = serviceResponse4.error;
			object obj41 = this + 32;
			_ = 3;
			result2 = (IEnumerator)error;
			goto IL_09a4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		obj5 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
		IL_09a4:
		LogError((string)(object)this);
		return result2;
	}

	private IEnumerator GenerateTemporaryCodeCoroutine(GenerateTemporaryCodeCompleteHandler completeHandler)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 20;
		obj2 = completeHandler;
		return enumerator;
	}

	private void Load()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = 0;
		object obj2 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		LogError((string)(object)this);
	}

	private void Save()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		string text = default;
		object obj = text + 80;
		object obj2 = text + 32;
		object obj3 = text - -64;
		obj3 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj4 = default;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
			((IJsonSerializer)5515).FromJson<PersistentAuthData>(text);
			obj2 = text;
			_ = text.m_stringLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (System.String)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (System.String)+18]");
			_ = 0;
			object obj5 = this + 32;
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
			_ = 0;
		}
		else
		{
			object obj6 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		}
	}

	private string GetAuthenticatedSignature(string platformName)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 0;
		object obj = text + 16;
		obj = this;
		object obj2 = text + 20;
		obj2 = platformName;
		return text;
	}

	private static void LogError(string msg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 - -64;
		obj3 = obj;
		_ = -1;
		object obj4 = obj2 + 32;
		object obj5 = msg + 32;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v9+18]");
		_ = 0;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj7 = default;
		object obj6 = obj7;
		object obj9 = default;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj10 = default;
		if (obj8 == obj10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj11 = default;
			string text = (string)obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj13 = default;
			object obj12 = obj13;
		}
		else
		{
			object obj12 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private static void LogWarning(string msg)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string exception = string.ConcatArray((string[])(object)"[KilooAuth] ", (int)msg);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogException((Exception)(object)exception);
	}

	private static void Log(string msg)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string message = string.ConcatArray((string[])(object)"[KilooAuth] ", (int)msg);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogAssertion(message);
	}

	private unsafe bool _003CIsCachedTokenValid_003Eb__45_0(KeyValuePair<string, IKilooAuthPlatform> pair)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0029: Expected Obj, but got VT
		//IL_0029: Expected Obj, but got I
		//IL_0036: Expected I4, but got Obj
		ref string reference = ref *(string*)null;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10+18]");
		if ((nint)0 != 0)
		{
			object obj2 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v15+18]");
			bool flag = ((Dictionary<string, string>)0).TryGetValue((string)pair, out reference);
			return (byte)(int)reference != 0;
		}
		return false;
	}
}
