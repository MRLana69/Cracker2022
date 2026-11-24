using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Backend.Authentication;
using Kiloo.Common.Utility;
using Kiloo.Google;
using Kiloo.Google.Internal;
using Kiloo.Integration.GameCenter;
using Kiloo.Monetization.FacebookAds;
using Kiloo.Serialization;
using UnityEngine;

namespace Kiloo.Integration.Google;

public class GoogleKilooAuthPlatform : IKilooAuthPlatform
{
	private sealed class _003CUpdateAsyncCoroutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GoogleKilooAuthPlatform _003C_003E4__this;

		private GoogleSignInPluginRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c7: Expected Obj, but got Unknown
				//IL_01d0: Expected Obj, but got I4
				//IL_0230: Expected Obj, but got I4
				//IL_0178: Unknown result type (might be due to invalid IL or missing references)
				//IL_017d: Expected Obj, but got Unknown
				//IL_018b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0190: Expected Obj, but got Unknown
				//IL_020a: Unknown result type (might be due to invalid IL or missing references)
				//IL_020f: Expected Obj, but got Unknown
				//IL_0218: Expected Obj, but got I4
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fb: Expected Obj, but got Unknown
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						GoogleSignInPluginRequest googleSignInPluginRequest = _003Crequest_003E5__2;
						if (googleSignInPluginRequest.profile__BackingField != null)
						{
							GoogleSignInPluginRequest googleSignInPluginRequest2 = _003Crequest_003E5__2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							object obj = default;
							if (obj != null)
							{
								GoogleSignInPluginRequest googleSignInPluginRequest3 = _003Crequest_003E5__2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
								object obj2 = default;
								if (obj2 != null)
								{
									object obj3 = _003C_003E4__this + 8;
									GoogleSignInPluginRequest googleSignInPluginRequest4 = _003Crequest_003E5__2;
									obj3 = googleSignInPluginRequest4.profile__BackingField;
									return null;
								}
							}
						}
						object obj4 = _003C_003E4__this + 8;
						obj4 = 0;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				if (AndroidGoogleSignInBridge.IsSupported())
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A068");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = 1;
					object obj5 = this + 20;
					object obj6 = default;
					obj5 = obj6;
					object obj7 = this + 12;
					GoogleSignInPlugin googleSignInPlugin = default;
					Coroutine coroutine = googleSignInPlugin.SignOut(_003Crequest_003E5__2);
					obj7 = coroutine;
					_003C_003E1__state = 2;
				}
				else
				{
					object obj8 = this + 12;
					obj8 = 0;
					_003C_003E1__state = 1;
				}
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CUpdateAsyncCoroutine_003Ed__9(int _003C_003E1__state)
		{
			//IL_09db: Expected Obj, but got I4
			//IL_09e8: Expected Obj, but got I4
			//IL_09fa: Expected Obj, but got I4
			//IL_0a03: Expected Obj, but got I4
			//IL_09c6: Expected Obj, but got I4
			//IL_0013: Expected Obj, but got I4
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected I4, but got Unknown
			//IL_004a: Expected Obj, but got I4
			//IL_010d: Expected Obj, but got I4
			//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a9: Expected Obj, but got Unknown
			//IL_0126: Expected Obj, but got I4
			//IL_013f: Expected Obj, but got I4
			//IL_0a16: Expected I, but got Obj
			//IL_0a2c: Expected Obj, but got I
			//IL_0ab9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0abe: Expected I4, but got Unknown
			//IL_0acc: Expected Obj, but got I4
			//IL_015d: Expected Obj, but got I4
			//IL_0902: Expected I, but got Obj
			//IL_0918: Expected Obj, but got I
			//IL_089d: Expected I, but got Obj
			//IL_0a6e: Expected Obj, but got I4
			//IL_0a80: Expected I4, but got Obj
			//IL_08eb: Expected I4, but got Obj
			//IL_08eb: Expected Obj, but got I4
			//IL_0176: Expected Obj, but got I4
			//IL_0991: Expected Obj, but got I4
			//IL_0943: Expected I, but got Obj
			//IL_018d: Expected I4, but got Obj
			//IL_01a9: Expected Obj, but got I4
			//IL_086d: Expected Obj, but got I4
			//IL_0886: Expected Obj, but got I4
			StringBuilder stringBuilder = ((StringBuilder)this._003C_003E1__state).Append(34);
			bool flag = string.IsNullOrEmpty((string)_003C_003E1__state);
			object obj = (flag ? 1 : 0) + 12;
			object obj11;
			for (object obj2 = 0; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj); obj11 = obj2 + 1, obj2 = obj11)
			{
				object obj3 = (flag ? 1 : 0) + 16;
				object obj4 = obj2 << 1;
				object obj5 = obj3 + obj4;
				int num = obj5 & 0xFFFF;
				object obj6 = num - 8;
				if (num != 8)
				{
					if ((nint)obj6 != 1)
					{
						if ((nint)obj6 != 2)
						{
							if ((nint)obj6 != 3)
							{
								if ((nint)obj6 == 4)
								{
									StringBuilder stringBuilder2 = ((StringBuilder)this._003C_003E1__state).AppendLine("\\f");
									continue;
								}
								if ((nint)obj6 == 5)
								{
									StringBuilder stringBuilder3 = ((StringBuilder)this._003C_003E1__state).AppendLine("\\r");
									continue;
								}
								int num2 = obj5 << 16;
								int num3 = num2 >> 16;
								object obj7 = num3 - 34;
								if (num3 == 34)
								{
									StringBuilder stringBuilder4 = ((StringBuilder)this._003C_003E1__state).AppendLine("\\\"");
									continue;
								}
								if ((nint)obj7 != 1 && (nint)obj7 != 2 && (nint)obj7 != 3 && (nint)obj7 != 4 && (nint)obj7 != 5 && (nint)obj7 != 6 && (nint)obj7 != 7 && (nint)obj7 != 8 && (nint)obj7 != 9 && (nint)obj7 != 10 && (nint)obj7 != 11 && (nint)obj7 != 12 && (nint)obj7 != 13 && (nint)obj7 != 14 && (nint)obj7 != 15 && (nint)obj7 != 16 && (nint)obj7 != 17 && (nint)obj7 != 18 && (nint)obj7 != 19 && (nint)obj7 != 20 && (nint)obj7 != 21 && (nint)obj7 != 22 && (nint)obj7 != 23 && (nint)obj7 != 24 && (nint)obj7 != 25 && (nint)obj7 != 26 && (nint)obj7 != 27 && (nint)obj7 != 28 && (nint)obj7 != 29 && (nint)obj7 != 30 && (nint)obj7 != 31 && (nint)obj7 != 32 && (nint)obj7 != 33 && (nint)obj7 != 34 && (nint)obj7 != 35 && (nint)obj7 != 36 && (nint)obj7 != 37 && (nint)obj7 != 38 && (nint)obj7 != 39 && (nint)obj7 != 40 && (nint)obj7 != 41 && (nint)obj7 != 42 && (nint)obj7 != 43 && (nint)obj7 != 44 && (nint)obj7 != 45 && (nint)obj7 != 46 && (nint)obj7 != 47 && (nint)obj7 != 48 && (nint)obj7 != 49 && (nint)obj7 != 50 && (nint)obj7 != 51 && (nint)obj7 != 52 && (nint)obj7 != 53 && (nint)obj7 != 54 && (nint)obj7 != 55 && (nint)obj7 != 56 && (nint)obj7 != 57 && (nint)obj7 == 58)
								{
									StringBuilder stringBuilder5 = ((StringBuilder)this._003C_003E1__state).AppendLine("\\\\");
									continue;
								}
							}
							nint num4 = (nint)typeof(Convert);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v38 (Il2CppClass<System.Convert>)+BA]");
							object obj8 = (nint)0 & (nint)0x200;
							if (obj8 != null)
							{
								nint num5 = (nint)typeof(Convert);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v64 (Il2CppClass<System.Convert>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							int num6 = obj5 & 0xFFFF;
							object obj9 = num6 + -32;
							if ((nint)obj9 <= 94)
							{
								StringBuilder stringBuilder6 = ((StringBuilder)this._003C_003E1__state).Append((int)obj5);
								continue;
							}
							nint num7 = (nint)typeof(Convert);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v49 (Il2CppClass<System.Convert>)+BA]");
							object obj10 = (nint)0 & (nint)0x200;
							if (obj10 != null)
							{
								nint num8 = (nint)typeof(Convert);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v58 (Il2CppClass<System.Convert>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							int num9 = Convert.ToBase64_CalculateAndValidateOutputLength(num6, true);
							string text = ((string)num9).PadRight(4, '0');
							string value = string.ConcatArray((string[])(object)"\\u", (int)text);
							StringBuilder stringBuilder7 = ((StringBuilder)this._003C_003E1__state).AppendLine(value);
						}
						else
						{
							StringBuilder stringBuilder8 = ((StringBuilder)this._003C_003E1__state).AppendLine("\\n");
						}
					}
					else
					{
						StringBuilder stringBuilder9 = ((StringBuilder)this._003C_003E1__state).AppendLine("\\t");
					}
				}
				else
				{
					StringBuilder stringBuilder10 = ((StringBuilder)this._003C_003E1__state).AppendLine("\\b");
				}
			}
			StringBuilder stringBuilder11 = ((StringBuilder)this._003C_003E1__state).Append(34);
		}

		void IDisposable.Dispose()
		{
			//IL_0071: Expected I, but got Obj
			//IL_0087: Expected Obj, but got I
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			_003C_003E1__state = 1;
			_ = 1;
			nint num = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CultureInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v14 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = this + 12;
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			obj2 = currentCulture;
		}

		private bool MoveNext()
		{
			//IL_048a: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I4
			//IL_0967: Expected Obj, but got I4
			//IL_08a6: Expected Obj, but got I4
			//IL_08df: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj = default;
			bool result;
			if ((nint)obj == -1)
			{
				result = false;
			}
			else
			{
				((KilooSerializer.Options)this)._002Ector();
				char nextChar = ((KilooJson.Parser)this).NextChar;
				int num = nextChar & 0xFFFF;
				if (num < 92)
				{
					int num2 = nextChar & 0xFFFF;
					object obj2 = num2 - 34;
					if (num2 != 34)
					{
						if ((nint)obj2 == 1 || (nint)obj2 == 2 || (nint)obj2 == 3 || (nint)obj2 == 4 || (nint)obj2 == 5 || (nint)obj2 == 6 || (nint)obj2 == 7 || (nint)obj2 == 8 || (nint)obj2 == 9)
						{
							goto IL_094f;
						}
						if ((nint)obj2 != 10)
						{
							if ((nint)obj2 != 11)
							{
								if ((nint)obj2 == 12 || (nint)obj2 == 13)
								{
									goto IL_094f;
								}
								if ((nint)obj2 != 14)
								{
									if ((nint)obj2 != 15)
									{
										if ((nint)obj2 != 16)
										{
											if ((nint)obj2 != 17)
											{
												if ((nint)obj2 != 18)
												{
													if ((nint)obj2 != 19)
													{
														if ((nint)obj2 != 20)
														{
															if ((nint)obj2 != 21)
															{
																if ((nint)obj2 != 22)
																{
																	if ((nint)obj2 != 23)
																	{
																		if ((nint)obj2 == 24)
																		{
																			result = true;
																		}
																		else
																		{
																			int num3 = nextChar & 0xFFFF;
																			bool flag = num3 == 91;
																			result = true;
																			if (!flag)
																			{
																				goto IL_094f;
																			}
																		}
																	}
																	else
																	{
																		result = true;
																	}
																}
																else
																{
																	result = true;
																}
															}
															else
															{
																result = true;
															}
														}
														else
														{
															result = true;
														}
													}
													else
													{
														result = true;
													}
												}
												else
												{
													result = true;
												}
											}
											else
											{
												result = true;
											}
										}
										else
										{
											result = true;
										}
									}
									else
									{
										result = true;
									}
								}
								else
								{
									result = true;
								}
							}
							else
							{
								result = true;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							result = true;
						}
					}
					else
					{
						result = true;
					}
				}
				else
				{
					int num4 = (int)((uint)nextChar << 16);
					int num5 = num4 >> 16;
					object obj3 = num5 - 93;
					if (num5 != 93)
					{
						if ((nint)obj3 == 1 || (nint)obj3 == 2 || (nint)obj3 == 3 || (nint)obj3 == 4 || (nint)obj3 == 5 || (nint)obj3 == 6 || (nint)obj3 == 7 || (nint)obj3 == 8 || (nint)obj3 == 9 || (nint)obj3 == 10 || (nint)obj3 == 11 || (nint)obj3 == 12 || (nint)obj3 == 13 || (nint)obj3 == 14 || (nint)obj3 == 15 || (nint)obj3 == 16 || (nint)obj3 == 17 || (nint)obj3 == 18 || (nint)obj3 == 19 || (nint)obj3 == 20 || (nint)obj3 == 21 || (nint)obj3 == 22 || (nint)obj3 == 23 || (nint)obj3 == 24 || (nint)obj3 == 25 || (nint)obj3 == 26 || (nint)obj3 == 27 || (nint)obj3 == 28 || (nint)obj3 == 29)
						{
							goto IL_094f;
						}
						if ((nint)obj3 != 30)
						{
							if ((nint)obj3 == 31 || (nint)obj3 != 32)
							{
								goto IL_094f;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							result = true;
						}
						else
						{
							result = true;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						result = true;
					}
				}
			}
			goto IL_094a;
			IL_094f:
			KilooJson.Parser.TOKEN nextToken = ((KilooJson.Parser)this).NextToken;
			if ((string)nextToken != "false")
			{
				result = true;
			}
			else
			{
				result = (((string)nextToken != "true") ? true : (((string)nextToken != "null") ? true : false));
			}
			goto IL_094a;
			IL_094a:
			return result;
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

	public const string NAME = "Google";

	private IGoogleProfile _profile;

	public string name
	{
		get
		{
			//IL_00f8: Expected I, but got Obj
			//IL_010e: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(FacebookNativeAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FacebookNativeAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (FacebookNativeAds.IsSupportedOnPlatform())
			{
				nint num3 = (nint)typeof(FacebookNativeAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(FacebookNativeAds);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v21 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				string result = default;
				return result;
			}
			return null;
		}
	}

	public IDictionary<string, string> value => (IDictionary<string, string>)(object)"Google";

	public string signature
	{
		get
		{
			//IL_0025: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected Obj, but got Unknown
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected Obj, but got Unknown
			//IL_0088: Expected Obj, but got I
			//IL_0098: Expected Obj, but got I
			//IL_00a8: Expected Obj, but got I
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected Obj, but got Unknown
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected Obj, but got Unknown
			//IL_00ee: Expected Obj, but got I
			//IL_00fe: Expected Obj, but got I
			//IL_010e: Expected Obj, but got I
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Expected Obj, but got Unknown
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected Obj, but got Unknown
			if (_profile != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v3 (Il2CppMethodInfo)+C]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v4+60]");
				object obj2 = 0;
				object obj3 = obj2;
				object obj4 = obj3 & 0x1FFF;
				object obj5 = obj4 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S4_v5 (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S4_v7 (Il2CppMethodInfo)+C]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S4_v8+60]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S4_v9+48]");
				object obj8 = 0;
				object obj9 = obj8 & 0x7FF;
				object obj10 = obj9 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v86 @ S5_v7 (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S4_v12 (Il2CppMethodInfo)+C]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S4_v13+60]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S4_v14+48]");
				object obj13 = 0;
				object obj14 = obj13 & 0x7FF;
				object obj15 = obj14 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51 @ S5_v11 (should have been resolved before IL gen)");
				string result = default;
				return result;
			}
			return null;
		}
	}

	public Coroutine UpdateAsync()
	{
		//IL_0030: Expected I, but got Obj
		//IL_0046: Expected Obj, but got I
		//IL_0071: Expected I, but got Obj
		if (_profile != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			IEnumerable<YieldInstruction> list = default;
			Coroutine s = CoroutineUtil.WaitForAll(list);
			nint num = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v7 (Il2CppClass<System.Convert>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v12 (Il2CppClass<System.Convert>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (Coroutine)(object)Convert.FromBase64String((string)(object)s);
		}
		return null;
	}

	private IEnumerator UpdateAsyncCoroutine()
	{
		IGoogleSignInBridge googleSignInBridge = GoogleSignInBridgeFactory.Create();
		if (googleSignInBridge != null)
		{
			string list = ((GameCenterKilooAuthPlatform)this).name;
			return (IEnumerator)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
		}
		return null;
	}

	public GoogleKilooAuthPlatform()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
