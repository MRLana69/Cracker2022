using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Proyecto26.Common;
using UnityEngine;
using UnityEngine.Networking;

namespace Proyecto26;

public static class HttpBase
{
	private sealed class _003CCreateRequestAndRetry_003Ed__0(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public RequestHelper options;

		public Action<RequestException, ResponseHelper> callback;

		private int _003Cretries_003E5__2;

		private UnityWebRequest _003Crequest_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0034: Expected Obj, but got I4
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected Obj, but got Unknown
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 32;
			bool flag = _003C_003E1__state != -3;
			object obj3 = _003C_003E1__state - 1;
			if ((nint)obj3 <= 1)
			{
				flag = false;
			}
			if (!flag)
			{
				object obj4 = obj + 28;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				object obj5 = obj + 20;
				object obj6 = obj5;
				((_003CCreateRequestAndRetry_003Ed__0)obj6)._003C_003Em__Finally1();
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
			//IL_0dfd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e02: Expected Obj, but got Unknown
			//IL_0e2a: Expected Obj, but got I
			//IL_0088: Expected Obj, but got I
			//IL_0bb2: Expected Obj, but got I
			//IL_0bc7: Expected Obj, but got I
			//IL_00ec: Expected Obj, but got I
			//IL_0728: Expected Obj, but got I
			//IL_073e: Expected Obj, but got I
			//IL_0753: Expected Obj, but got I
			//IL_0d86: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d8b: Expected Obj, but got Unknown
			//IL_0c26: Expected Obj, but got I
			//IL_0c34: Expected Obj, but got I4
			//IL_0ed0: Expected Obj, but got I
			//IL_0c68: Expected Obj, but got I
			//IL_0137: Expected Obj, but got I
			//IL_0147: Expected Obj, but got I
			//IL_0e58: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e5d: Expected Obj, but got Unknown
			//IL_07cb: Expected Obj, but got I
			//IL_02dd: Expected Obj, but got I
			//IL_02ed: Expected Obj, but got I
			//IL_0ae5: Expected Obj, but got I
			//IL_0afb: Expected Obj, but got I
			//IL_0b0b: Expected Obj, but got I
			//IL_0816: Expected Obj, but got I
			//IL_0826: Expected Obj, but got I
			//IL_0345: Expected Obj, but got I
			//IL_0355: Expected Obj, but got I
			//IL_0939: Expected Obj, but got I
			//IL_0949: Expected Obj, but got I
			//IL_03ad: Expected Obj, but got I
			//IL_0994: Expected Obj, but got I
			//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0401: Expected Obj, but got Unknown
			//IL_0243: Expected Obj, but got I
			//IL_0251: Expected Obj, but got I4
			//IL_0486: Expected Obj, but got I
			//IL_0496: Expected Obj, but got I
			//IL_04b5: Expected I4, but got Obj
			//IL_0670: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 32;
			object obj3 = obj + 28;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
			object obj5;
			bool result = default;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
					if ((nint)0 != 2)
					{
						obj5 = obj;
						goto IL_0e4f;
					}
					_ = -3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+18]");
					object obj7 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v331+10]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v333+30]");
					bool flag = (nint)0 == 0;
					object obj9 = obj8;
					if (flag)
					{
						goto IL_0e6c;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
						object obj10 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ S0_v399+10]");
							obj9 = 0;
							goto IL_0e6c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S0_v387+18]");
						result = false;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						result = false;
					}
				}
				else
				{
					_ = -3;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
						object obj12 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ S0_v121+10]");
							object obj14 = 0;
							object obj15 = default;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ S0_v122+70]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ S0_v121+18]");
									nint num = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ S0_v122+28]");
									if (num < 0)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag2 = (nint)0 == 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										result = false;
										if (!flag2)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ S0_v122+2C]");
											_ = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag3 = (nint)0 == 1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											result = false;
											if (!flag3)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
												object obj16 = 0;
												object obj17 = 2;
												goto IL_0c58;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										goto IL_0ca2;
									}
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
									object obj18 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ S0_v279+10]");
									object obj19 = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
										object obj20 = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											goto IL_0a7b;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ S0_v292+14]");
										result = false;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										result = false;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									result = false;
								}
							}
							else
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
									object obj21 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ S0_v146+10]");
									object obj22 = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ S0_v147+8]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
										object obj23 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ S0_v160+10]");
										object obj24 = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S0_v161+C]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
											object obj25 = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3DE");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												object obj26 = obj + 8;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
														object obj27 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ S0_v209+10]");
														object obj28 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ S0_v210+68]");
														if ((nint)0 == 0)
														{
															result = (byte)(int)"body not parsed" != 0;
														}
														else
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															bool flag4 = (nint)0 == 1;
															bool flag5 = default;
															result = flag5;
															if (flag4)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																result = flag5;
																goto IL_0ca2;
															}
														}
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 == 1)
														{
															goto IL_0b58;
														}
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ S0_v122+34]");
															bool flag6 = (nint)0 != 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
																object obj29 = 0;
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	goto IL_0a7b;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																result = false;
																goto IL_0ca2;
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														result = false;
														goto IL_0ca2;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												bool flag7 = default;
												result = flag7;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												result = false;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S0_v161+C]");
											result = false;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ S0_v147+8]");
										result = false;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									result = false;
								}
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v106+10]");
							result = false;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				goto IL_0ca2;
			}
			_ = 0;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+10]");
			object obj30 = 0;
			goto IL_0b67;
			IL_0a7b:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag8 = (nint)0 == 1;
			result = false;
			if (flag8)
			{
				goto IL_0b58;
			}
			result = false;
			obj5 = obj;
			goto IL_0e4f;
			IL_0b58:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0ca2;
			IL_0e6c:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ L0_v34+34]");
				bool flag9 = (nint)0 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						result = false;
						goto IL_0b58;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
					object obj31 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
					object obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ S0_v371+10]");
					object obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ S0_v371+18]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ S1_v163+28]");
					bool flag10 = num2 <= 0;
					obj30 = obj33;
					if (flag10)
					{
						goto IL_0b67;
					}
					result = false;
					obj5 = obj;
					goto IL_0e4f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ L0_v34+34]");
			result = false;
			goto IL_0ca2;
			IL_0e4f:
			object obj34 = obj5 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9538");
			return result;
			IL_0c58:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
			object obj35 = 0;
			result = true;
			obj5 = obj;
			goto IL_0e4f;
			IL_0b67:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
				object obj37 = 0;
				_ = -3;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
					object obj38 = 0;
					object obj17 = 1;
					goto IL_0c58;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				result = false;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				result = false;
			}
			goto IL_0ca2;
			IL_0ca2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj39 = default;
			object obj40 = default;
			bool flag11 = obj39 == obj40;
			bool flag12 = !flag11;
			object obj42 = default;
			object obj41 = obj42;
			if (!flag12)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag13 = (nint)0 != 1;
				result = false;
				obj5 = obj;
				if (flag13)
				{
					goto IL_0e4f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = false;
				object obj43 = default;
				obj41 = obj43;
			}
			_ = 0;
			object obj44 = obj + 16;
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
			goto IL_0e4f;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003Crequest_003E5__3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
			}
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

	public static IEnumerator CreateRequestAndRetry(RequestHelper options, Action<RequestException, ResponseHelper> callback)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private static UnityWebRequest CreateRequest(RequestHelper options)
	{
		Dictionary<string, string> queryParams = options.Params;
		string text = Extensions.BuildUrl(options._uri, queryParams);
		string message = $"RestClient - Request\nUrl: {text}";
		DebugLog(options._enableDebug, message, isError: false);
		if (options._formData != null && options._method == "POST")
		{
			return UnityWebRequest.Post(text, options._formData);
		}
		UnityWebRequest unityWebRequest = default;
		unityWebRequest._002Ector(text, options._method);
		return unityWebRequest;
	}

	private static RequestException CreateException(RequestHelper options, UnityWebRequest request)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		string error = request.error;
		bool isHttpError = request.isHttpError;
		bool isNetworkError = request.isNetworkError;
		long responseCode = request.responseCode;
		string response = default;
		if (~(options._parseResponseBody ? 1u : 0u) != 0)
		{
			response = "body not parsed";
		}
		else
		{
			DownloadHandler downloadHandler = request.m_DownloadHandler;
			object obj = downloadHandler - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S1_v10+BC] (should have been resolved before IL gen)");
		}
		RequestException ex = default;
		ex._002Ector(error, isHttpError, isNetworkError, responseCode, response);
		return ex;
	}

	private static void DebugLog(bool debugEnabled, object message, bool isError)
	{
		if (debugEnabled)
		{
			if (isError)
			{
				Debug.LogError(message);
			}
			else
			{
				Debug.Log(message);
			}
		}
	}

	public static IEnumerator DefaultUnityWebRequest(RequestHelper options, Action<RequestException, ResponseHelper> callback)
	{
		return CreateRequestAndRetry(options, callback);
	}

	public static IEnumerator DefaultUnityWebRequest<TResponse>(RequestHelper options, Action<RequestException, ResponseHelper, TResponse> callback)
	{
		//IL_0054: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S2_v2 (Il2CppMethodRgctx<Proyecto26.HttpBase::DefaultUnityWebRequest>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S2_v3+4] (should have been resolved before IL gen)");
		throw new ArgumentException();
	}

	public static IEnumerator DefaultUnityWebRequest<TResponse>(RequestHelper options, Action<RequestException, ResponseHelper, TResponse[]> callback)
	{
		//IL_0054: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S2_v2 (Il2CppMethodRgctx<Proyecto26.HttpBase::DefaultUnityWebRequest>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S2_v3+4] (should have been resolved before IL gen)");
		throw new ArgumentException();
	}
}
