using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;
using Kiloo.Plugins.DeviceUtility;
using SYBO.Subway;
using SYBO.Subway.Info;
using UI.Screens;
using UnityEngine;

public class AssetBundleManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string, bool> _003C_003E9__50_1;

		public static Predicate<string> _003C_003E9__50_0;

		public static Func<string, bool> _003C_003E9__73_0;

		public static Predicate<string> _003C_003E9__73_1;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal bool _003CGetAbsolutePath_003Eb__50_1(string s)
		{
			return s == "..";
		}

		internal bool _003CGetAbsolutePath_003Eb__50_0(string s)
		{
			return s == "..";
		}

		internal bool _003CConvertFromRelativeToAbsolute_003Eb__73_0(string s)
		{
			int num = string.Compare(s, "..", StringComparison.Ordinal);
			return num == 0;
		}

		internal bool _003CConvertFromRelativeToAbsolute_003Eb__73_1(string s)
		{
			int num = string.Compare(s, "..", StringComparison.Ordinal);
			return num == 0;
		}
	}

	private sealed class _003CCacheNeededAssetBundles_003Ed__55(int _003C_003E1__state) : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private float _003C_003E2__current;

		public AssetBundleManager _003C_003E4__this;

		private Dictionary<string, int> _003CneededBundles_003E5__2;

		private int _003CnShippedBundles_003E5__3;

		private int _003CnBundlesProcessed_003E5__4;

		private Dictionary<string, int>.KeyCollection.Enumerator _003C_003E7__wrap4;

		float IEnumerator<float>.Current => _003C_003E2__current;

		object IEnumerator.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_0023: Unknown result type (might be due to invalid IL or missing references)
				//IL_0028: Expected Obj, but got Unknown
				object obj2 = default;
				object obj = obj2 - 16;
				_ = _003C_003E2__current;
				object obj3 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object result = default;
				return result;
			}
		}

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
				((_003CCacheNeededAssetBundles_003Ed__55)obj6)._003C_003Em__Finally1();
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
			//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a8f: Expected Obj, but got Unknown
			//IL_0ab7: Expected Obj, but got I
			//IL_0ac7: Expected Obj, but got I
			//IL_00a6: Expected Obj, but got I
			//IL_00bb: Expected Obj, but got I
			//IL_00cb: Expected Obj, but got I
			//IL_00ee: Expected Obj, but got I
			//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b1d: Expected Obj, but got Unknown
			//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a18: Expected Obj, but got Unknown
			//IL_0129: Expected Obj, but got I
			//IL_0302: Expected Obj, but got I
			//IL_0af5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0afa: Expected Obj, but got Unknown
			//IL_0be1: Expected Obj, but got I
			//IL_0b6d: Expected Obj, but got I
			//IL_0b7d: Expected Obj, but got I
			//IL_0b93: Expected Obj, but got I
			//IL_0bae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb3: Expected Obj, but got Unknown
			//IL_01c0: Expected Obj, but got I
			//IL_0389: Expected Obj, but got I
			//IL_04f5: Expected Obj, but got I
			//IL_0258: Expected Obj, but got I
			//IL_0280: Expected Obj, but got I
			//IL_0610: Expected Obj, but got I
			//IL_06d4: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 48;
			object obj3 = obj + 44;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
			object obj6;
			object obj7;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
				if ((nint)0 != 1)
				{
					obj6 = obj;
					goto IL_0aec;
				}
				_ = -3;
				obj7 = obj4;
				goto IL_0b09;
			}
			_ = -1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v270+14]");
				object obj10 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v271+10]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v271+18]");
				object obj11 = num - 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj12 = 0;
					_ = 0;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj13 = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @961");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
									object obj14 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
									_ = 0;
									_ = -3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
									obj7 = 0;
									goto IL_0b09;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							goto IL_0938;
						}
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
			goto IL_0938;
			IL_0b09:
			_ = 0;
			object obj15 = obj7 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool result = default;
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj16 = 0;
				object obj17 = default;
				if (obj17 == null)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						object obj18 = (nint)0 + (nint)32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag = (nint)0 != 1;
							result = false;
							obj6 = obj;
							if (flag)
							{
								goto IL_0aec;
							}
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
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj19 = default;
							if ((nint)obj19 >= 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
								object obj20 = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											obj6 = obj;
											object obj21 = default;
											if (obj21 != null)
											{
												goto IL_0b5d;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+2C]");
											object obj22 = (nint)0 + (nint)1;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													object obj23 = default;
													bool flag2 = obj23 == null;
													obj6 = obj;
													if (!flag2)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+30]");
														object obj24 = (nint)0 + (nint)1;
														obj6 = obj;
													}
													goto IL_0b5d;
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
										goto IL_0938;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													obj6 = obj;
													object obj25 = default;
													if (obj25 != null)
													{
														goto IL_0b5d;
													}
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														bool flag3 = (nint)0 != 1;
														obj6 = obj;
														if (flag3)
														{
															goto IL_0b5d;
														}
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
												goto IL_0938;
											}
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
			}
			goto IL_0938;
			IL_0938:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj26 = default;
			object obj27 = default;
			bool flag4 = obj26 == obj27;
			bool flag5 = !flag4;
			object obj29 = default;
			object obj28 = obj29;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag6 = (nint)0 != 1;
				result = false;
				obj6 = obj;
				if (flag6)
				{
					goto IL_0aec;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj30 = default;
				obj28 = obj30;
			}
			_ = 0;
			object obj31 = obj + 32;
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
			obj6 = 0;
			goto IL_0b5d;
			IL_0b5d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ L1_v3+2C]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ L1_v3+2C]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ S1_v11+1C]");
			object obj34 = (nint)0 + (nint)1;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S0_v19+18]");
			object obj35 = obj34 / 0;
			result = true;
			goto IL_0aec;
			IL_0aec:
			object obj36 = obj6 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A008");
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
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

	private sealed class _003CUnloadBundlesCoroutine_003Ed__60(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetBundleManager _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f9: Expected Obj, but got Unknown
			//IL_0902: Expected Obj, but got I4
			//IL_0076: Expected Obj, but got I
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected Obj, but got Unknown
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected Obj, but got Unknown
			//IL_00e4: Expected Obj, but got I
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Expected Obj, but got Unknown
			//IL_094d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0952: Expected Obj, but got Unknown
			//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b9: Expected Obj, but got Unknown
			//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d1: Expected Obj, but got Unknown
			//IL_0650: Unknown result type (might be due to invalid IL or missing references)
			//IL_0655: Expected Obj, but got Unknown
			//IL_0603: Unknown result type (might be due to invalid IL or missing references)
			//IL_0608: Expected Obj, but got Unknown
			//IL_014a: Expected Obj, but got I
			//IL_0996: Unknown result type (might be due to invalid IL or missing references)
			//IL_099b: Expected Obj, but got Unknown
			//IL_08d0: Expected I4, but got Obj
			//IL_0742: Expected Obj, but got I
			//IL_081a: Unknown result type (might be due to invalid IL or missing references)
			//IL_081f: Expected Obj, but got Unknown
			//IL_0867: Unknown result type (might be due to invalid IL or missing references)
			//IL_086c: Expected Obj, but got Unknown
			//IL_0761: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 80;
			_ = 0;
			object obj3 = obj - -64;
			obj3 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					AssetBundleManager assetBundleManager = _003C_003E4__this;
					_003C_003E1__state = -1;
					Dictionary<string, bool> pendingUnloads = assetBundleManager._pendingUnloads;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v30 (System.Collections.Generic.Dictionary`2<System.String, System.Boolean>)+10]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v30 (System.Collections.Generic.Dictionary`2<System.String, System.Boolean>)+18]");
					object obj4 = num - 0;
					if ((nint)obj4 >= 1)
					{
						List<string> list = default;
						list._002Ector();
						object obj5 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
						_ = 0;
						object obj6 = obj - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
						obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_ = 0;
						object obj7 = obj + 56;
						obj = obj7;
						_ = 0;
						object obj9 = default;
						object obj10 = default;
						object obj11 = default;
						object obj12 = default;
						object obj17 = default;
						object obj18 = default;
						object obj19 = default;
						bool result;
						bool flag2 = default;
						bool flag3 = default;
						object obj22 = default;
						object obj23 = default;
						bool flag5 = default;
						bool flag6 = default;
						while (true)
						{
							_ = 0;
							object obj8 = obj + 56;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj9 == null)
								{
									goto IL_05ab;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
								obj = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												if (obj10 != null)
												{
													continue;
												}
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													if (obj11 == null)
													{
														goto IL_03fc;
													}
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																if (obj12 == null)
																{
																	goto IL_03fc;
																}
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																		if ((nint)0 != 1)
																		{
																			goto IL_03fc;
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
															goto IL_051c;
														}
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
							goto IL_051c;
							IL_05ab:
							object obj13 = obj + 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2283");
							object obj14 = obj + 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							_ = 0;
							object obj15 = obj + 32;
							obj = obj15;
							_ = 0;
							List<string> list2;
							while (true)
							{
								_ = 0;
								object obj16 = obj + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj17 == null)
									{
										goto IL_0811;
									}
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											continue;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										list2 = (List<string>)(object)assetBundleManager._pendingUnloads;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										list2 = (List<string>)0;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									list2 = (List<string>)0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
								bool flag = obj18 != obj19;
								result = flag2;
								if (flag)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									goto IL_0811;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								result = flag3;
								break;
								IL_0811:
								object obj20 = obj + 8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C5");
								return false;
							}
							_ = 0;
							object obj21 = obj + 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								break;
							}
							goto IL_08a4;
							IL_08a4:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
							return (byte)(int)list2 != 0;
							IL_051c:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
							bool flag4 = obj22 != obj23;
							result = flag5;
							if (!flag4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									goto IL_05ab;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								result = flag6;
							}
							_ = 0;
							object obj24 = obj + 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag7 = (nint)0 == 1;
							list2 = list;
							if (!flag7)
							{
								break;
							}
							goto IL_08a4;
							IL_03fc:
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							goto IL_051c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
						return result;
					}
				}
				bool result2 = default;
				return result2;
			}
			_003C_003E1__state = -1;
			object obj25 = default;
			_003C_003E2__current = obj25;
			_003C_003E1__state = 1;
			return true;
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

	private sealed class _003CDownloadAllAssetBundles_003Ed__67(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetBundleManager _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num;
			if (_003C_003E1__state != 0)
			{
				bool flag = _003C_003E1__state == 1;
				num = -1;
				if (!flag)
				{
					goto IL_0093;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				AssetBundleManager assetBundleManager = _003C_003E4__this;
				assetBundleManager._isDownloading = false;
				_003C_003E2__current = null;
				num = 1;
			}
			_003C_003E1__state = num;
			goto IL_0093;
			IL_0093:
			return true;
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

	private sealed class _003CDownloadAssetBundle_003Ed__68(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public string bundleName;

		public int version;

		public AssetBundleManager _003C_003E4__this;

		private bool _003CdownloadSuccessful_003E5__2;

		private IRequest _003Crequest_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected Obj, but got Unknown
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Expected Obj, but got Unknown
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Expected VT, but got Unknown
			object obj2 = default;
			object obj = obj2 - 48;
			_ = 0;
			_ = 0;
			_ = 0;
			AssetBundleManager assetBundleManager = _003C_003E4__this;
			bool result = default;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj3 = default;
					if (obj3 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						object obj4 = default;
						if (obj4 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
							byte[] source = default;
							byte[] bundleBytes = CompressionExtensions.Decompress(source, "subway_bundles");
							if (CacheAssetBundle(bundleName, version, bundleBytes))
							{
								_003CdownloadSuccessful_003E5__2 = true;
								int succesfullyDownloaded = assetBundleManager.succesfullyDownloaded + 1;
								assetBundleManager.succesfullyDownloaded = succesfullyDownloaded;
								_003C_003E4__this.ResolveDownloadRequest(bundleName, version);
							}
							else
							{
								LogError("Attempt to cache downloaded bundle from the server failed.");
							}
							goto IL_048b;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj5 = default;
					if (obj5 != null)
					{
						string locale = DeviceUtility.GetLocale();
						string contryCodeFromLocale = Utils.GetContryCodeFromLocale(locale);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						throw new ArrayTypeMismatchException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj6 = default;
					string text = default;
					if (obj6 != null)
					{
						object obj7 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v201 @ S3_v16+D4] (should have been resolved before IL gen)");
					}
					else
					{
						text = null;
					}
					string msg = "Attempt to download from the server failed. Error message: " + text;
					LogError(msg);
					goto IL_048b;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				_ = version;
				object obj8 = obj + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg = default;
				string message = $"download bundle: {bundleName} => {arg}";
				Debug.Log(message);
				OnlineSettings instance = OnlineSettings.instance;
				_003CdownloadSuccessful_003E5__2 = false;
				string assetBundlesServerURL = _003C_003E4__this.GetAssetBundlesServerURL(bundleName);
				float value = instance.GetValue("asset_bundle_request_timeout", _requestDownloadTimeout);
				float value2 = instance.GetValue("asset_bundle_request_max_backoff_time", _requestMaxBackoffTime);
				Uri uri = default;
				uri._002Ector(assetBundlesServerURL);
				IRequest request = WebClient.CreateGet(uri);
				IRequest request2 = RequestExtensions.WithTimeout(request, value);
				IRequest request3 = RequestExtensions.WithMaxBackOffTime(request2, value2);
				_003Crequest_003E5__3 = request3;
				object obj9 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				_ = 0;
				WebClient.SendOptions options = (WebClient.SendOptions)(obj + 8);
				Coroutine coroutine = RequestExtensions.SendAsync(_003Crequest_003E5__3, null, options);
				_003C_003E2__current = coroutine;
				_003C_003E1__state = 1;
				result = true;
			}
			goto IL_04c9;
			IL_04c9:
			return result;
			IL_048b:
			result = false;
			if (!_003CdownloadSuccessful_003E5__2)
			{
				_003C_003E4__this.DownloadFailedFor(bundleName, version);
				result = false;
			}
			goto IL_04c9;
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

	public const string COMPRESSION_SIGNATURE = "subway_bundles";

	private const string ASSET_BUNDLE_RESOURCES_PATH = "AssetBundles";

	private const string ASSET_BUNDLES_ROOT_PATH = "..\\..\\AssetBundles";

	private const string EDITOR_ASSET_BUNDLE_CACHE_PATH = "..\\EditorCache";

	private const string UNCOMPRESSED_ASSET_BUNDLE_ANDROID_FOLDER = "android";

	private const string UNCOMPRESSED_ASSET_BUNDLE_IOS_FOLDER = "ios";

	private const string UNCOMPRESSED_ASSET_BUNDLE_WP_FOLDER = "wp";

	private const string UNCOMPRESSED_ASSET_BUNDLE_STANDALONE_FOLDER = "standalone";

	private const string TEMPORARY_EDITOR_ASSET_BUNDLE_FOLDER = "Temp";

	private const string DEBUG_TAG = "[AssetBundleManager]: ";

	private const char VALUE_SEPARATOR = '-';

	private const char ITEM_SEPARATOR = ',';

	private const string ASSET_BUNDLE_SERVER_URL_OS_KEY = "asset_bundle_server";

	private const string ASSET_BUNDLE_SERVER_IOS_FOLDER_OS_KEY = "asset_bundle_server_ios_folder";

	private const string ASSET_BUNDLE_SERVER_ANDROID_FOLDER_OS_KEY = "asset_bundle_server_android_folder";

	private const string ASSET_BUNDLE_SERVER_WP_FOLDER_OS_KEY = "asset_bundle_server_wp_folder";

	private const string ASSET_BUNDLE_REQUEST_TIMEOUT_OS_KEY = "asset_bundle_request_timeout";

	private const string ASSET_BUNDLE_REQUEST_MAX_BACKOFF_TIME_OS_KEY = "asset_bundle_request_max_backoff_time";

	private const string ASSET_BUNDLE_DOWNLOAD_REST_TIME_OS_KEY = "asset_bundle_download_rest_time";

	private const string ASSET_BUNDLE_IS_USING_EXTENSION_OS_KEY = "asset_bundle_using_extension";

	private const string ASSET_BUNDLE_EXTENSION_OS_KEY = "asset_bundle_extension";

	private static string _assetBundleBaseServerUrl = "http://az827068.vo.msecnd.net/subway/";

	private static string _serverDirIos = "ios";

	private static string _serverDirAndroid = "android";

	private static string _serverDirWindowsPhone = "wp";

	private static float _requestDownloadTimeout = 30f;

	private static float _requestMaxBackoffTime = 300f;

	private static float _downloadAttemptRestTime = 10f;

	private static bool _usingBundleExtension = true;

	private static string _assetBundleExtension = ".bytes";

	private AssetBundleVersionControl _versionControl;

	private List<string> _assetBundlesLoading;

	private Dictionary<string, AssetBundle> _loadedAssetBundles;

	private Dictionary<string, bool> _pendingUnloads;

	private Dictionary<string, int> _pendingDownloads;

	private bool _isDownloading;

	private float _lastInitializedDownloads;

	private bool _downloadableBundlesUpdated;

	private IEnumerator _currentDownloaderCoroutine;

	private static AssetBundleManager _instance;

	private int attemptingToPrecacheAmount;

	private int succesfullyPrecached;

	private int attemptingToDownloadAmount;

	private int succesfullyDownloaded;

	public static AssetBundleManager Instance
	{
		get
		{
			bool flag = _instance == null;
			bool flag2 = !flag;
			AssetBundleManager result = _instance;
			if (!flag2)
			{
				AssetBundleManager assetBundleManager = default;
				assetBundleManager._002Ector();
				_instance = assetBundleManager;
				result = assetBundleManager;
			}
			return result;
		}
		private set
		{
		}
	}

	private unsafe AssetBundleManager()
	{
		List<string> list = default;
		list._002Ector();
		_assetBundlesLoading = list;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, UnityEngine.AssetBundle>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, AssetBundle> loadedAssetBundles = default;
		_loadedAssetBundles = loadedAssetBundles;
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ S4_v9 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Boolean>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, bool> pendingUnloads = default;
		_pendingUnloads = pendingUnloads;
		_lastInitializedDownloads = 0f - _downloadAttemptRestTime;
		AssetBundleCache.Initialize();
		_versionControl = AssetBundleVersionControl.Instance;
		AssetBundleVersionControl versionControl = _versionControl;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(AssetBundleManager.OnDownloadableAssetBundlesUpdated));
		Delegate obj = Delegate.Combine(versionControl.OnDownloadableAssetBundlesUpdated, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onDownloadableAssetBundlesUpdated = default;
		versionControl.OnDownloadableAssetBundlesUpdated = onDownloadableAssetBundlesUpdated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(AssetBundleManager.StopAssetbundlesDownload));
		Game.OnGameStarted += action2;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(AssetBundleManager.ResumeAssetBundlesDownload));
		Game.OnMenuScreenShown += action3;
		InitializeDownloadRequests();
	}

	private unsafe string GetAssetBundlesServerURL(string bundleName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I4, but got Unknown
		//IL_0099: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		OnlineSettings instance = OnlineSettings.instance;
		string version = Application.version;
		int currentlyAvailableBundleVersion = ((AssetBundleVersionControl)(object)version).GetCurrentlyAvailableBundleVersion();
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		string text2 = version + "/v" + text + "/";
		RuntimePlatform platform = Application.platform;
		string text3;
		string text4;
		if (platform != RuntimePlatform.OSXEditor)
		{
			object obj3 = platform - 7;
			if (platform != RuntimePlatform.WindowsEditor)
			{
				if ((nint)obj3 != 1)
				{
					bool flag = (nint)obj3 == 2;
					text3 = text2;
					if (!flag)
					{
						bool flag2 = (nint)obj3 == 3;
						text3 = text2;
						if (!flag2)
						{
							if ((nint)obj3 != 4)
							{
								bool flag3 = platform != RuntimePlatform.MetroPlayerARM;
								text3 = text2;
								if (flag3)
								{
									goto IL_02a4;
								}
								text4 = instance.GetValue("asset_bundle_server_wp_folder", _serverDirWindowsPhone);
							}
							else
							{
								text4 = instance.GetValue("asset_bundle_server_android_folder", _serverDirAndroid);
							}
							goto IL_02c0;
						}
					}
					goto IL_02a4;
				}
				text4 = instance.GetValue("asset_bundle_server_ios_folder", _serverDirIos);
				goto IL_02c0;
			}
		}
		text4 = _serverDirIos;
		goto IL_02c0;
		IL_02a4:
		string value = instance.GetValue("asset_bundle_server", _assetBundleBaseServerUrl);
		string text5 = Path.Combine(value, text3);
		string message = "text: " + text3 + " asset bundle path: " + text5;
		Debug.Log(message);
		string text6 = bundleName.ToLower();
		string text7 = ((!instance.GetValue("asset_bundle_using_extension", _usingBundleExtension)) ? string.Empty : instance.GetValue("asset_bundle_extension", _assetBundleExtension));
		string path = text6 + text7;
		return Path.Combine(text5, path);
		IL_02c0:
		string text8 = text2 + text4;
		text3 = text8;
		goto IL_02a4;
	}

	public static string GetAssetBundlesCachePath()
	{
		return DeviceUtility.GetUserDataPath();
	}

	private static string GetAbsolutePath(string path)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		string dataPath = Application.dataPath;
		string[] source = path.Split('\\');
		List<string> source2 = Enumerable.ToList(source);
		string path2 = dataPath;
		object obj = default;
		object obj3 = default;
		string text = default;
		while (true)
		{
			bool flag = _003C_003Ec._003C_003E9__50_1 == null;
			bool flag2 = !flag;
			Func<string, bool> predicate = _003C_003Ec._003C_003E9__50_1;
			if (!flag2)
			{
				throw new ArgumentException();
			}
			int num = Enumerable.Count(source2, predicate);
			if (num <= (nint)obj)
			{
				break;
			}
			DirectoryInfo parent = Directory.GetParent(path2);
			object obj2 = parent - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v103 @ S1_v22+BC] (should have been resolved before IL gen)");
			obj = obj3 + 1;
			path2 = text;
		}
		if (_003C_003Ec._003C_003E9__50_0 == null)
		{
			throw new ArgumentException();
		}
		throw new IndexOutOfRangeException();
	}

	public unsafe string GetPreCachedBundles()
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected I4, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected I4, but got Unknown
		int num = this + 44;
		if (attemptingToPrecacheAmount == succesfullyPrecached)
		{
			string text = ((int*)num)->ToString();
			return "Complete(" + text + ")";
		}
		int num2 = this + 48;
		string text2 = ((int*)num2)->ToString();
		string text3 = ((int*)num)->ToString();
		return string.Empty + text2 + "/" + text3;
	}

	public unsafe string GetDownloadedBundles()
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected I4, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected I4, but got Unknown
		int num = this + 52;
		if (attemptingToDownloadAmount == succesfullyDownloaded)
		{
			string text = ((int*)num)->ToString();
			return "Complete(" + text + ")";
		}
		int num2 = this + 56;
		string text2 = ((int*)num2)->ToString();
		string text3 = ((int*)num)->ToString();
		return string.Empty + text2 + "/" + text3;
	}

	public unsafe AssetBundle GetAssetBundle(string bundleName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Ref, but got Unknown
		//IL_02df: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_042b: Expected Obj, but got I
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		object obj = default;
		AssetBundleManager assetBundleManager = (AssetBundleManager)(obj - 16);
		assetBundleManager._assetBundlesLoading = null;
		_ = 0;
		assetBundleManager._assetBundlesLoading = null;
		AssetBundle result = default;
		AssetBundle result2;
		if (_loadedAssetBundles.TryGetValue(bundleName, out *(AssetBundle*)(assetBundleManager + 12)))
		{
			result = (AssetBundle)(object)assetBundleManager._assetBundlesLoading;
		}
		else if (!_assetBundlesLoading.Contains(bundleName))
		{
			_assetBundlesLoading.Add(bundleName);
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag = (nint)0 != 1;
			AssetBundle assetBundle = default;
			result = assetBundle;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj2 = default;
				object obj3 = default;
				bool flag2 = obj2 != obj3;
				AssetBundle assetBundle2 = default;
				result2 = assetBundle2;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj5 = default;
						object obj4 = obj5;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj6 = default;
							if (obj6 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (AssetBundleManager)+4]");
								object obj7 = (nint)0 << 2;
								object obj8 = (object)assetBundleManager + obj7;
								obj8 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (AssetBundleManager)+4]");
								object obj9 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (AssetBundleManager)+4]");
								object obj10 = (nint)0 << 2;
								object obj11 = obj10 + (object)assetBundleManager;
								object obj12 = obj11 - 4;
								object obj13 = obj12;
								bool flag3 = obj12 == null;
								string text = "Exception caught while trying to retrieve an AssetBundle: ";
								string text2 = "Error: ";
								if (!flag3)
								{
									object obj14 = obj13;
									object obj15 = obj13 + 24;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v275 @ S1_v56+D4] (should have been resolved before IL gen)");
									text = "Exception caught while trying to retrieve an AssetBundle: ";
									text2 = "Error: ";
								}
								string text3 = default;
								string msg = text + bundleName + text2 + text3;
								assetBundleManager.LogError(msg);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (AssetBundleManager)+4]");
								object obj16 = -1;
								result = null;
								goto IL_03da;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj17 = obj5;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag4 = (nint)0 != 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							result2 = (AssetBundle)0;
							if (flag4)
							{
								goto IL_03df;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag5 = (nint)0 != 1;
					AssetBundle assetBundle3 = default;
					result2 = assetBundle3;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
						result2 = assetBundle3;
					}
				}
				goto IL_03df;
			}
		}
		goto IL_03da;
		IL_03df:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return result2;
		IL_03da:
		return result;
	}

	private AssetBundle RequestAssetBundle(string bundleName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_021c: Expected Obj, but got I
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_02cc: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		int latestVersionForBundle = _versionControl.GetLatestVersionForBundle(bundleName);
		int versionForCachedBundle = AssetBundleCache.GetVersionForCachedBundle(bundleName);
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		string message = $"{bundleName} ===> {arg}";
		Debug.Log(message);
		if (latestVersionForBundle <= -1)
		{
			string msg = "No version information exists for bundle :" + bundleName;
			((AssetBundleManager)(object)bundleName).LogError(msg);
		}
		else if (latestVersionForBundle > versionForCachedBundle && !_versionControl.IsBundleVersionShipped(bundleName, latestVersionForBundle))
		{
			AddAssetBundleDownloadRequest(bundleName, latestVersionForBundle);
		}
		bool flag = versionForCachedBundle <= -1;
		bool flag2 = !flag;
		int version = versionForCachedBundle;
		if (flag2)
		{
			goto IL_01be;
		}
		int availableShippedVersionForBundle = _versionControl.GetAvailableShippedVersionForBundle(bundleName);
		bool flag3 = availableShippedVersionForBundle < 0;
		AssetBundle assetBundle = null;
		if (!flag3)
		{
			bool flag4 = ((AssetBundleManager)(object)bundleName).CacheAssetBundle(bundleName, availableShippedVersionForBundle, (byte[])null);
			int versionForCachedBundle2 = AssetBundleCache.GetVersionForCachedBundle(bundleName);
			bool flag5 = versionForCachedBundle2 < 0;
			version = versionForCachedBundle2;
			assetBundle = null;
			if (!flag5)
			{
				goto IL_01be;
			}
		}
		goto IL_01d4;
		IL_01d4:
		if (assetBundle != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S3_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, UnityEngine.AssetBundle>>)+54]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ S3_v9+4] (should have been resolved before IL gen)");
			object obj6 = default;
			object obj5 = obj6 ^ -1;
			object obj7 = obj5 >> 31;
			if (obj7 != null)
			{
				AssetBundle assetBundle2 = _loadedAssetBundles.get_Item(bundleName);
				bool flag6 = assetBundle2 != null;
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, UnityEngine.AssetBundle>>)+5C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v238 @ S5_v10+4] (should have been resolved before IL gen)");
			}
			else
			{
				nint num5 = 0;
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, UnityEngine.AssetBundle>>)+5C]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v194 @ S5_v5+4] (should have been resolved before IL gen)");
			}
		}
		else
		{
			string msg2 = "AssetBundle request finished unsuccessfully for bundle: " + bundleName;
			((AssetBundleManager)(object)bundleName).LogError(msg2);
		}
		if (_assetBundlesLoading.Contains(bundleName))
		{
			bool flag7 = _assetBundlesLoading.Remove(bundleName);
		}
		return assetBundle;
		IL_01be:
		assetBundle = AssetBundleCache.LoadAssetBundle(bundleName, version);
		goto IL_01d4;
	}

	public IEnumerator<float> CacheNeededAssetBundles()
	{
		_ = 0;
		IEnumerator<float> result = default;
		return result;
	}

	public void PerformAvailabilityCheck()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_003d: Expected I4, but got Obj
		//IL_004f: Expected I4, but got Obj
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got I4
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected Obj, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Obj, but got Unknown
		//IL_00cc: Expected Obj, but got I4
		//IL_0104: Expected F4, but got Obj
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_01f1: Expected Obj, but got I4
		object obj = default;
		AssetBundleManager assetBundleManager = (AssetBundleManager)(obj + -64);
		assetBundleManager.succesfullyDownloaded = 0;
		assetBundleManager.succesfullyPrecached = 0;
		assetBundleManager._currentDownloaderCoroutine = null;
		assetBundleManager._lastInitializedDownloads = 0f;
		Dictionary<string, int> neededBundles = _versionControl.GetNeededBundles();
		AssetBundleCache.StartBulkCaching();
		object obj2 = assetBundleManager + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		assetBundleManager.succesfullyDownloaded = (int)assetBundleManager._pendingDownloads;
		assetBundleManager.succesfullyPrecached = (int)assetBundleManager._loadedAssetBundles;
		assetBundleManager._currentDownloaderCoroutine = (IEnumerator)assetBundleManager._versionControl;
		object obj3 = assetBundleManager + 40;
		assetBundleManager = (AssetBundleManager)obj3;
		assetBundleManager._versionControl = null;
		assetBundleManager._assetBundlesLoading = (List<string>)(object)assetBundleManager;
		object obj4 = 1;
		object obj6 = default;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj12 = default;
		object obj14 = default;
		object versionControl = default;
		object obj15 = default;
		while (true)
		{
			_ = 0;
			object obj5 = assetBundleManager + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_03ce;
				}
				_ = 0;
				assetBundleManager = (AssetBundleManager)assetBundleManager.attemptingToDownloadAmount;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					assetBundleManager._lastInitializedDownloads = (float)assetBundleManager;
					object obj7 = obj4 & 1;
					if (obj7 == null)
					{
						object obj8 = assetBundleManager + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @126E");
						AssetBundleCache.EndBulkCaching();
						break;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
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
								bool flag = (nint)obj9 != -1;
								obj4 = 1;
								if (flag)
								{
									continue;
								}
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag2 = (nint)0 != 1;
										obj4 = obj10;
										if (flag2)
										{
											continue;
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
							goto IL_0337;
						}
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
			goto IL_0337;
			IL_0337:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj11 != obj12;
			object obj13 = obj14;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				assetBundleManager._versionControl = (AssetBundleVersionControl)versionControl;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_03ce;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj13 = obj15;
			}
			_ = 0;
			object obj16 = assetBundleManager + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
			IL_03ce:
			object obj17 = assetBundleManager + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @126E");
			AssetBundleCache.EndBulkCaching();
			object obj18 = obj4 & 1;
			if (obj18 == null)
			{
				break;
			}
			return;
		}
		assetBundleManager.LogError("We do not have all the necessary bundles cached. Please free some disk space and restart the App.");
	}

	private bool CacheAssetBundle(string bundleName, int version, byte[] bundleBytes = null)
	{
		if (bundleBytes != null)
		{
			return AssetBundleCache.CacheAssetBundle(bundleName, version, bundleBytes);
		}
		string path = Path.Combine("AssetBundles", bundleName);
		TextAsset textAsset = Resources.Load<TextAsset>(path);
		if ((bool)textAsset)
		{
			byte[] bytes = textAsset.bytes;
			byte[] bytes2 = CompressionExtensions.Decompress(bytes, "subway_bundles");
			return AssetBundleCache.CacheAssetBundle(bundleName, version, bytes2);
		}
		string text = Path.Combine("AssetBundles", bundleName);
		string msg = "Cannot load bundle from resources: " + text;
		((AssetBundleManager)(object)text).LogError(msg);
		return false;
	}

	public void UnloadAssetBundle(string bundleName, bool unloadAllLoadedObjects)
	{
		//IL_0077: Expected Obj, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_004c: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Boolean>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Boolean>>)+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S5_v10+4] (should have been resolved before IL gen)");
		}
		else
		{
			nint num5 = 0;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Boolean>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S5_v5+4] (should have been resolved before IL gen)");
		}
		IEnumerator coroutine = UnloadBundlesCoroutine();
		Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
	}

	public static void ClearCache()
	{
		AssetBundleCache.ClearCache();
	}

	private IEnumerator UnloadBundlesCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void InitializeDownloadRequests()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected Obj, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I
		//IL_04bb: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		_lastInitializedDownloads = timeSinceLevelLoad;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, int> pendingDownloads = default;
		_pendingDownloads = pendingDownloads;
		object obj3 = obj + 8;
		CharacterScreenManager instance = CharacterScreenManager.Instance;
		List<KeyValuePair<Characters.CharacterType, Characters.Model>> characterList = instance.GetCharacterList();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1119");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 40;
		obj = obj4;
		_ = 0;
		object obj6 = default;
		object obj11 = default;
		object obj12 = default;
		object obj13 = default;
		object obj15 = default;
		object obj16 = default;
		object obj18 = default;
		object obj19 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_0431;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				obj = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								object obj7 = 0;
								while (true)
								{
									object obj8 = obj7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v133+C]");
									if ((nint)obj8 >= 0)
									{
										break;
									}
									object obj9 = obj7 << 2;
									object obj10 = obj11 + obj9;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										goto IL_0348;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										goto IL_0357;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										goto IL_0366;
									}
									if (obj12 != null)
									{
										goto IL_0300;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										goto IL_0384;
									}
									if (obj13 != null)
									{
										goto IL_0300;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										goto IL_0300;
									}
									goto IL_0393;
									IL_0300:
									object obj14 = obj7 + 1;
									obj7 = obj14;
								}
								continue;
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
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_03a2;
			IL_0393:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_03a2;
			IL_0366:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_03a2;
			IL_0357:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_03a2;
			IL_03a2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj15 != obj16;
			object obj17 = obj18;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0431;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj17 = obj19;
			break;
			IL_0348:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_03a2;
			IL_0384:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_03a2;
			IL_0431:
			object obj20 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2284");
			PlayerInfo instance2 = PlayerInfo.Instance;
			bool flag2 = Enumerable.Any(_pendingDownloads);
			bool allAssetBundlesDownloaded = (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
			instance2._dirty = true;
			instance2._allAssetBundlesDownloaded = allAssetBundlesDownloaded;
			Dictionary<string, int> pendingDownloads2 = _pendingDownloads;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v51 (System.Collections.Generic.Dictionary`2<System.String, System.Int32>)+10]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v51 (System.Collections.Generic.Dictionary`2<System.String, System.Int32>)+18]");
			object obj21 = num3 - 0;
			bool flag3 = (nint)obj21 > 0;
			bool flag4 = !flag3;
			int num4 = 0;
			if (!flag4)
			{
				Dictionary<string, int> pendingDownloads3 = _pendingDownloads;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S0_v63 (System.Collections.Generic.Dictionary`2<System.String, System.Int32>)+10]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S0_v63 (System.Collections.Generic.Dictionary`2<System.String, System.Int32>)+18]");
				int num6 = (int)(num5 - 0);
				num4 = num6;
			}
			succesfullyDownloaded = 0;
			attemptingToDownloadAmount = num4;
			return;
		}
		_ = 0;
		object obj22 = obj + 8;
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
	}

	private void OnDownloadableAssetBundlesUpdated()
	{
		_downloadableBundlesUpdated = true;
	}

	private void AddAssetBundleDownloadRequest(string bundleName, int version)
	{
		//IL_00a5: Expected Obj, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			int num3 = _pendingDownloads.get_Item(bundleName);
			if (num3 > version)
			{
				nint num4 = 0;
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v87 @ S5_v10+4] (should have been resolved before IL gen)");
			}
		}
		else
		{
			nint num6 = 0;
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v57 @ S5_v5+4] (should have been resolved before IL gen)");
		}
	}

	public void ResumeAssetBundlesDownload()
	{
		do
		{
			if (_pendingDownloads == null || !Enumerable.Any(_pendingDownloads) || ~(_downloadableBundlesUpdated ? 1u : 0u) == 0)
			{
				if (AllowedToInitializeDownloads())
				{
					InitializeDownloadRequests();
					continue;
				}
				break;
			}
			if (!_isDownloading)
			{
				Game instance = Game.Instance;
				Variable<bool> isInGame = instance.IsInGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v30 (Variable`1<System.Boolean>)+8]");
				if ((nint)0 == 0)
				{
					IEnumerator currentDownloaderCoroutine = DownloadAllAssetBundles();
					_currentDownloaderCoroutine = currentDownloaderCoroutine;
					Coroutine coroutine = CoroutineUtil.StartCoroutine(_currentDownloaderCoroutine);
				}
			}
			break;
		}
		while (Enumerable.Any(_pendingDownloads));
	}

	private bool AllowedToInitializeDownloads()
	{
		if (~(_downloadableBundlesUpdated ? 1u : 0u) == 0)
		{
			_downloadableBundlesUpdated = false;
			return true;
		}
		OnlineSettings instance = OnlineSettings.instance;
		float value = instance.GetValue("asset_bundle_download_rest_time", _downloadAttemptRestTime);
		float num = _lastInitializedDownloads + value;
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		return num < timeSinceLevelLoad;
	}

	private void StopAssetbundlesDownload()
	{
		if (~(_isDownloading ? 1u : 0u) == 0)
		{
			CoroutineUtil.StopCoroutine(_currentDownloaderCoroutine);
			_isDownloading = false;
		}
	}

	private IEnumerator DownloadAllAssetBundles()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator DownloadAssetBundle(string bundleName, int version)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe void DownloadFailedFor(string bundleName, int version)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I4, but got Unknown
		object obj = default;
		AssetBundleManager assetBundleManager = (AssetBundleManager)(obj - 16);
		assetBundleManager._assetBundlesLoading = (List<string>)version;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+54]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj4 = default;
		object obj3 = obj4 ^ -1;
		object obj5 = obj3 >> 31;
		if (obj5 != null)
		{
			bool flag = _pendingDownloads.Remove(bundleName);
			return;
		}
		int num3 = assetBundleManager + 12;
		string text = ((int*)num3)->ToString();
		string msg = "No pending download found for failed download: " + bundleName + " version " + text;
		assetBundleManager.LogError(msg);
	}

	private void ResolveDownloadRequest(string bundleName, int version)
	{
		//IL_0069: Expected Obj, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			int num3 = _pendingDownloads.get_Item(bundleName);
			if (num3 <= version)
			{
				bool flag = _pendingDownloads.Remove(bundleName);
			}
		}
	}

	public static string SerializeAssetBundleVersionData(Dictionary<string, int> versionData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_035d: Expected I, but got Obj
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected Obj, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		if (versionData != null)
		{
			object obj3 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj4 = obj + 40;
			obj = obj4;
			_ = 0;
			object obj6 = default;
			object obj7 = default;
			object obj8 = default;
			object obj10 = default;
			object obj11 = default;
			string result = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj6 == null)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
					obj = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												continue;
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
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj7 != obj8;
				object obj9 = obj10;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj9 = obj11;
				}
				_ = 0;
				object obj12 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return result;
			}
			object obj13 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @126E");
		}
		nint num = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v57 @ S1_v10 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string result2 = default;
		return result2;
	}

	public static Dictionary<string, int> ParseAssetBundleVersionData(string serializedData)
	{
		//IL_00ef: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_009c: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>>)+4] (should have been resolved before IL gen)");
		string[] array = serializedData.Split(',');
		object obj = 0;
		while (array.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)array + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v17+10]");
			string[] array2 = ((string)0).Split('-');
			if (array2.Length == 2)
			{
				int num3 = int.Parse(array2[1]);
				nint num4 = 0;
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v101 @ S5_v6+4] (should have been resolved before IL gen)");
			}
			object obj5 = obj + 1;
			obj = obj5;
		}
		Dictionary<string, int> result = default;
		return result;
	}

	private unsafe static string ConvertFromRelativeToAbsolute(string filePath)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0071: Expected I, but got Obj
		//IL_00d4: Expected I, but got Obj
		//IL_0132: Expected I, but got Obj
		//IL_04a7: Expected Obj, but got I4
		//IL_02d5: Expected I, but got Obj
		string dataPath = Application.dataPath;
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v16 (Il2CppClass<System.IO.Path>)+5C]");
		char c = (char)((nuint)0u + (nuint)6u);
		string text = ((char*)(ushort)c)->ToString();
		string newValue = text + string.Empty;
		string text2 = filePath.Replace("\\", newValue);
		nint num2 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v24 (Il2CppClass<System.IO.Path>)+5C]");
		char c2 = (char)((nuint)0u + (nuint)6u);
		string text3 = ((char*)(ushort)c2)->ToString();
		string newValue2 = text3 + string.Empty;
		string text4 = dataPath.Replace("\\", newValue2);
		nint num3 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v32 (Il2CppClass<System.IO.Path>)+5C]");
		char c3 = (char)((nuint)0u + (nuint)6u);
		string text5 = ((char*)(ushort)c3)->ToString();
		string newValue3 = text5 + string.Empty;
		string text6 = text2.Replace("//", newValue3);
		nint num4 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v40 (Il2CppClass<System.IO.Path>)+5C]");
		char c4 = (char)((nuint)0u + (nuint)6u);
		string text7 = ((char*)(ushort)c4)->ToString();
		string newValue4 = text7 + string.Empty;
		string text8 = text4.Replace("//", newValue4);
		string text9 = text6.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
		string text10 = text8.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
		string[] source = text9.Split(Path.DirectorySeparatorChar);
		List<string> source2 = Enumerable.ToList(source);
		string[] source3 = text10.Split(Path.DirectorySeparatorChar);
		List<string> list = Enumerable.ToList(source3);
		bool flag = _003C_003Ec._003C_003E9__73_0 == null;
		bool flag2 = !flag;
		Func<string, bool> predicate = _003C_003Ec._003C_003E9__73_0;
		if (!flag2)
		{
			throw new ArgumentException();
		}
		int num5 = Enumerable.Count(source2, predicate);
		if (num5 != 0)
		{
			string text11 = string.Empty;
			int num6 = 0;
			while (true)
			{
				int num7 = Enumerable.Count(list);
				object obj = num7 - num5;
				if (num6 >= (nint)obj)
				{
					break;
				}
				string text12 = list.get_Item(num6);
				nint num8 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S2_v47 (Il2CppClass<System.IO.Path>)+5C]");
				char c5 = (char)((nuint)0u + (nuint)6u);
				string text13 = ((char*)(ushort)c5)->ToString();
				string text14 = text11 + text12 + text13;
				int num9 = num6 + 1;
				text11 = text14;
				num6 = num9;
			}
			if (_003C_003Ec._003C_003E9__73_1 == null)
			{
				throw new ArgumentException();
			}
			throw new IndexOutOfRangeException();
		}
		string dataPath2 = Application.dataPath;
		string text15 = dataPath2.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
		return text15 + text9;
	}

	private void Log(string msg)
	{
	}

	private void LogWarning(string msg)
	{
	}

	private void LogError(string msg)
	{
		string text = "[AssetBundleManager]: " + msg;
	}

	private void DebugRequestStatus(string bundleName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Expected Obj, but got Unknown
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_085b: Expected Obj, but got Unknown
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected Obj, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Expected Obj, but got Unknown
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		string text = "REQUESTED: " + bundleName + "\n";
		string text2 = text + "LOADED:\n";
		object obj3 = obj + 16;
		Dictionary<string, AssetBundle>.KeyCollection keys = _loadedAssetBundles.Keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @961");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj - -64;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		string text3 = text2;
		object obj6 = default;
		string text4 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		object obj18 = default;
		string text7 = default;
		object obj19 = default;
		object obj20 = default;
		object obj21 = default;
		object obj22 = default;
		object obj29 = default;
		string text10 = default;
		object obj30 = default;
		object obj31 = default;
		object obj32 = default;
		object obj33 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_01cd;
				}
				_ = 0;
				object obj7 = obj - -64;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag = (nint)0 != 1;
					text3 = text4;
					if (flag)
					{
						continue;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj8 != obj9;
			object obj10 = obj11;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_01cd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_0717;
			}
			goto IL_0740;
			IL_0717:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			break;
			IL_01cd:
			object obj14 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A00C");
			string text5 = text3 + "LOADING:\n";
			object obj15 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj16 = obj + 48;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			string text6 = text5;
			while (true)
			{
				_ = 0;
				object obj17 = obj + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj18 == null)
					{
						goto IL_0425;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag3 = (nint)0 != 1;
						text6 = text7;
						if (flag3)
						{
							continue;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag4 = obj19 != obj20;
				obj10 = obj21;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0425;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj22;
				break;
				IL_0425:
				object obj23 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C5");
				string text8 = text6 + "UNLOADING:\n";
				object obj24 = obj + 16;
				Dictionary<string, bool>.KeyCollection keys2 = _pendingUnloads.Keys;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @961");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				object obj25 = obj + 32;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				string text9 = text8;
				goto IL_0866;
			}
			_ = 0;
			object obj26 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_0717;
			}
			goto IL_0740;
			IL_0740:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
			IL_06cb:
			_ = 0;
			object obj27 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_0717;
			}
			goto IL_0740;
			IL_0866:
			while (true)
			{
				_ = 0;
				object obj28 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj29 == null)
					{
						break;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							string text9 = text10;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag5 = obj30 == obj31;
				bool flag6 = !flag5;
				obj10 = obj32;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj10 = obj33;
				}
				goto IL_06cb;
			}
			break;
		}
		object obj34 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1EE4");
	}
}
