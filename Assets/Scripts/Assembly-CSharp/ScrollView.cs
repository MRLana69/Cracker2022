using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.UI;
using UnityEngine;

public class ScrollView : MonoBehaviour
{
	public enum ScrollDirection
	{
		Up,
		Down,
		Left,
		Right,
		Stationary
	}

	private enum Infinite
	{
		None,
		BothWays
	}

	private enum BoundsCalculationMode
	{
		FullSize,
		Incremental
	}

	private enum Arrangement
	{
		Vertical,
		Horizontal
	}

	private enum PullDownToRefreshState
	{
		None,
		PullDown,
		Refreshing
	}

	private class RecycleBin
	{
		public readonly List<Container> activeContainers;

		private readonly Dictionary<int, List<Container>> _scrapViews;

		public Container GetActiveContainer(int position)
		{
			bool flag = position < 0;
			Container result = null;
			if (!flag)
			{
				List<Container> list = activeContainers;
				bool flag2 = position >= list._size;
				result = null;
				if (!flag2)
				{
					Container container = activeContainers.get_Item(position);
					bool flag3 = container == null;
					result = null;
					if (!flag3)
					{
						activeContainers.RemoveAt(position);
						result = container;
					}
				}
			}
			return result;
		}

		public void AddToActiveContainers(Container container, bool endOfList)
		{
			if (endOfList)
			{
				activeContainers.Add(container);
			}
			else
			{
				activeContainers.Insert(0, container);
			}
		}

		public unsafe void AddScrapContainer(Container container)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00d8: Expected Obj, but got I
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected Obj, but got Unknown
			//IL_0072: Expected native int or pointer, but got VT
			//IL_00a4: Expected F4, but got I
			//IL_009f: Expected native int or pointer, but got VT
			//IL_003d: Expected Obj, but got I
			object obj = default;
			Vector3 vector = (Vector3)(obj - 32);
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Collections.Generic.List`1<Kiloo.Common.UI.Container>>>)+54]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v4+4] (should have been resolved before IL gen)");
			object obj4 = default;
			object obj3 = obj4 ^ -1;
			object obj5 = obj3 >> 31;
			if (obj5 == null)
			{
				List<Container> list = default;
				list._002Ector();
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Collections.Generic.List`1<Kiloo.Common.UI.Container>>>)+5C]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v92 @ S5_v5+4] (should have been resolved before IL gen)");
			}
			List<Container> list2 = _scrapViews.get_Item(container.modelType);
			list2.Add(container);
			int width = Screen.width;
			int height = Screen.height;
			int num5 = height << 1;
			_ = 0;
			((Vector3*)(nint)vector)->z = 0f;
			int num6 = width << 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			container._modelTransform.localPosition = vector;
		}

		public void Clear()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_082d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0832: Expected Obj, but got Unknown
			//IL_085f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0864: Expected Obj, but got Unknown
			//IL_0890: Unknown result type (might be due to invalid IL or missing references)
			//IL_0895: Expected Obj, but got Unknown
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Expected Obj, but got Unknown
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Expected Obj, but got Unknown
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected Obj, but got Unknown
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Expected Obj, but got Unknown
			//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f4: Expected Obj, but got Unknown
			//IL_0751: Unknown result type (might be due to invalid IL or missing references)
			//IL_0756: Expected Obj, but got Unknown
			//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a5: Expected Obj, but got Unknown
			//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d8: Expected Obj, but got Unknown
			//IL_0330: Unknown result type (might be due to invalid IL or missing references)
			//IL_0335: Expected Obj, but got Unknown
			//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ea: Expected Obj, but got Unknown
			//IL_093e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0943: Expected Obj, but got Unknown
			//IL_05ea: Expected Obj, but got I4
			//IL_098a: Unknown result type (might be due to invalid IL or missing references)
			//IL_098f: Expected Obj, but got Unknown
			//IL_039e: Expected Obj, but got I
			//IL_03e9: Expected Obj, but got I
			//IL_05dc: Expected Obj, but got I4
			//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bc: Expected Obj, but got Unknown
			//IL_044b: Expected Obj, but got I
			//IL_045b: Expected Obj, but got I
			//IL_046b: Expected Obj, but got I
			//IL_047b: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 + -64;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			object obj3 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj4 = obj + 48;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj6 = default;
			object obj7 = default;
			object obj8 = default;
			object obj10 = default;
			object obj11 = default;
			object obj17 = default;
			object obj22 = default;
			object obj24 = default;
			object obj25 = default;
			object obj28 = default;
			object obj29 = default;
			object obj31 = default;
			object obj33 = default;
			object obj34 = default;
			object obj36 = default;
			object obj37 = default;
			object obj39 = default;
			object obj40 = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj6 == null)
					{
						goto IL_0160;
					}
					_ = 0;
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
						goto IL_0160;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj9 = obj11;
				}
				_ = 0;
				object obj12 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				goto IL_07e3;
				IL_0160:
				object obj13 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @121D");
				((List<T>)(object)activeContainers).Clear();
				object obj14 = obj + 16;
				Dictionary<int, List<Container>>.ValueCollection values = _scrapViews.Values;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @961");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				object obj15 = obj + 32;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				while (true)
				{
					_ = 0;
					object obj16 = obj + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					object obj30;
					object obj32;
					if ((nint)0 != 1)
					{
						if (obj17 == null)
						{
							goto IL_0748;
						}
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							object obj18 = obj + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
								_ = 0;
								object obj19 = obj + 48;
								obj = obj19;
								_ = 0;
								object obj21;
								object obj23;
								while (true)
								{
									_ = 0;
									object obj20 = obj + 48;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag2 = (nint)0 == 1;
									obj21 = obj22;
									obj23 = obj24;
									if (flag2)
									{
										break;
									}
									if (obj25 != null)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
										object obj26 = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag3 = (nint)0 == 1;
										obj21 = obj22;
										obj23 = obj24;
										if (flag3)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S0_v189+8]");
										object obj27 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S0_v189+8]");
										if ((nint)0 != 0)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag4 = (nint)0 == 1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ S0_v196+20]");
											obj22 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ S0_v196+14]");
											obj24 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ S0_v196+20]");
											obj21 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ S0_v196+14]");
											obj23 = 0;
											if (flag4)
											{
												break;
											}
										}
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag5 = (nint)0 == 1;
										obj21 = obj22;
										obj23 = obj24;
										if (flag5)
										{
											break;
										}
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag6 = (nint)0 != 1;
										obj21 = obj22;
										obj23 = obj24;
										if (!flag6)
										{
											break;
										}
										continue;
									}
									goto IL_05e1;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
								bool flag7 = obj28 != obj29;
								obj30 = obj28;
								obj9 = obj31;
								if (!flag7)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										obj22 = obj21;
										obj24 = obj23;
										obj32 = 0;
										goto IL_097b;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									obj30 = obj33;
									obj9 = obj34;
								}
								_ = 0;
								object obj35 = obj + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									break;
								}
								goto IL_0a29;
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
					goto IL_06da;
					IL_05e1:
					obj32 = 10;
					goto IL_097b;
					IL_0a29:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					if (obj36 == obj30)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							goto IL_0748;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						obj9 = obj37;
					}
					_ = 0;
					object obj38 = obj + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto end_IL_0881;
					}
					break;
					IL_06da:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj30 = obj39;
					obj9 = obj40;
					goto IL_0a29;
					IL_0748:
					object obj41 = obj + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4F7E");
					throw new IndexOutOfRangeException();
					IL_097b:
					_ = 0;
					object obj42 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						bool flag8 = (nint)obj32 != 10;
						if (obj32 == null)
						{
							flag8 = false;
						}
						if (flag8)
						{
							object obj43 = obj + 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4F7E");
							return;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
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
					goto IL_06da;
				}
				goto IL_07e3;
				IL_07e3:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
				continue;
				end_IL_0881:
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}

		public Container GetScrapContainer(int modelType)
		{
			//IL_0138: Expected Obj, but got I
			//IL_0021: Expected Obj, but got I
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected Obj, but got Unknown
			//IL_0099: Expected Obj, but got I
			Dictionary<int, List<Container>> scrapViews = _scrapViews;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (System.Collections.Generic.Dictionary`2<System.Int32, System.Collections.Generic.List`1<Kiloo.Common.UI.Container>>)+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (System.Collections.Generic.Dictionary`2<System.Int32, System.Collections.Generic.List`1<Kiloo.Common.UI.Container>>)+18]");
			object obj = num - 0;
			bool flag = (nint)obj < 1;
			Container result = null;
			if (!flag)
			{
				nint num2 = 0;
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Collections.Generic.List`1<Kiloo.Common.UI.Container>>>)+54]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S3_v5+4] (should have been resolved before IL gen)");
				object obj4 = default;
				object obj3 = obj4 ^ -1;
				object obj5 = obj3 >> 31;
				if (obj5 == null)
				{
					List<Container> list = default;
					list._002Ector();
					nint num4 = 0;
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Collections.Generic.List`1<Kiloo.Common.UI.Container>>>)+5C]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v118 @ S5_v4+4] (should have been resolved before IL gen)");
					return null;
				}
				List<Container> list2 = _scrapViews.get_Item(modelType);
				bool flag2 = list2._size < 1;
				result = null;
				if (!flag2)
				{
					Container container = list2.get_Item(0);
					list2.RemoveAt(0);
					result = container;
				}
			}
			return result;
		}

		public void ScrapActiveContainers()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected Obj, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected Obj, but got Unknown
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Expected Obj, but got Unknown
			//IL_02be: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c3: Expected Obj, but got Unknown
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Expected Obj, but got Unknown
			//IL_0279: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 48;
			_ = 0;
			_ = 0;
			List<Container> list = default;
			list._002Ector((IEnumerable<Container>)activeContainers);
			((List<T>)(object)activeContainers).Clear();
			object obj3 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj4 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj6 = default;
			object obj7;
			object obj8 = default;
			object obj9 = default;
			object obj11 = default;
			object obj12 = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					bool flag = obj6 == null;
					obj7 = obj;
					if (flag)
					{
						break;
					}
					_ = 0;
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
				bool flag2 = obj8 == obj9;
				bool flag3 = !flag2;
				object obj10 = obj11;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag4 = (nint)0 != 1;
					obj7 = obj;
					if (flag4)
					{
						break;
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
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj7 = 0;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return;
			}
			object obj14 = obj7 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @121D");
		}

		public static void Log(string msg)
		{
		}

		public RecycleBin()
		{
			List<Container> list = default;
			list._002Ector();
			activeContainers = list;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Collections.Generic.List`1<Kiloo.Common.UI.Container>>>>)+4] (should have been resolved before IL gen)");
			Dictionary<int, List<Container>> scrapViews = default;
			_scrapViews = scrapViews;
		}
	}

	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public ScrollView _003C_003E4__this;

		public Action onFinished;

		internal void _003CSmoothScrollToOffset_003Eb__0()
		{
			ScrollView scrollView = _003C_003E4__this;
			scrollView.animating__BackingField = false;
			Action action = onFinished;
			if (onFinished != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v5.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass88_0
	{
		public int dataPosition1;

		public int dataPosition2;

		internal bool _003CAnimateSwapPositions_003Eb__0(Container T)
		{
			return T.dataIndex == dataPosition1;
		}

		internal bool _003CAnimateSwapPositions_003Eb__1(Container T)
		{
			return T.dataIndex == dataPosition2;
		}
	}

	private sealed class _003CAnimateSwapPositions_003Ed__88(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public int dataPosition1;

		public int dataPosition2;

		public ScrollView _003C_003E4__this;

		public float time;

		private _003C_003Ec__DisplayClass88_0 _003C_003E8__1;

		public Action onComplete;

		private Container _003Citem3_003E5__2;

		private Container _003Citem2_003E5__3;

		private Vector3 _003Corigin3_003E5__4;

		private Vector3 _003Corigin2_003E5__5;

		private float _003CtimePassed_003E5__6;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_03d2: Expected Obj, but got VT
			//IL_023e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0243: Expected VT, but got Unknown
			//IL_027c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0281: Expected VT, but got Unknown
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Expected Obj, but got Unknown
			//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fa: Expected Obj, but got Unknown
			//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b6: Expected Obj, but got Unknown
			//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cb: Expected Obj, but got Unknown
			//IL_050e: Expected Obj, but got I
			//IL_0566: Unknown result type (might be due to invalid IL or missing references)
			//IL_056b: Expected VT, but got Unknown
			//IL_0598: Expected Obj, but got VT
			//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cd: Expected Obj, but got Unknown
			//IL_0608: Expected Obj, but got I
			//IL_0648: Expected F4, but got I
			//IL_0643: Expected native int or pointer, but got VT
			//IL_0667: Expected F4, but got I
			//IL_0662: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 144);
			ScrollView scrollView = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				bool result = default;
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					float num = _003CtimePassed_003E5__6;
					if (!(num < time))
					{
						Container container = _003Citem3_003E5__2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView+<AnimateSwapPositions>d__88)+44]");
						_ = 0;
						_ = _003Corigin2_003E5__5;
						Vector3 localPosition = vector + 48;
						container._modelTransform.localPosition = localPosition;
						Container container2 = _003Citem2_003E5__3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView+<AnimateSwapPositions>d__88)+38]");
						_ = 0;
						_ = _003Corigin3_003E5__4;
						Vector3 localPosition2 = vector + 32;
						container2._modelTransform.localPosition = localPosition2;
						Container container3 = _003Citem3_003E5__2;
						_003C_003Ec__DisplayClass88_0 obj2 = _003C_003E8__1;
						container3.dataIndex = obj2.dataPosition2;
						Container container4 = _003Citem2_003E5__3;
						container4.dataIndex = obj2.dataPosition1;
						object obj3 = this + 48;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
						object obj4 = this + 60;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
						scrollView.animating__BackingField = false;
						Action action = onComplete;
						bool flag = onComplete == null;
						result = false;
						if (!flag)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v266.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
							result = false;
						}
					}
					else
					{
						float deltaTime = Time.deltaTime;
						float num2 = (_003CtimePassed_003E5__6 = num + deltaTime) * ((float)Math.PI / 2f);
						float num3 = num2 / time;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EAE");
						Container container5 = _003Citem3_003E5__2;
						object obj5 = _003Corigin2_003E5__5 - _003Corigin3_003E5__4;
						float num5 = default;
						float num4 = Math.Min(num5, 1f);
						bool flag2 = num5 < 0f;
						float num6 = 0f;
						if (!flag2)
						{
							num6 = num4;
						}
						float num7 = (float)obj5 * num6;
						float num8 = (float)_003Corigin3_003E5__4 + num7;
						object obj6 = this - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView+<AnimateSwapPositions>d__88)+34]");
						object obj7 = obj6 - 0;
						float num9 = (float)obj7 * num6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView+<AnimateSwapPositions>d__88)+34]");
						float num10 = 0f + num9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView+<AnimateSwapPositions>d__88)+44]");
						nint num11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView+<AnimateSwapPositions>d__88)+38]");
						object obj8 = num11 - 0;
						float num12 = (float)obj8 * num6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView+<AnimateSwapPositions>d__88)+38]");
						float num13 = 0f + num12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
						_ = 0;
						Vector3 localPosition3 = vector + 16;
						container5._modelTransform.localPosition = localPosition3;
						Container container6 = _003Citem2_003E5__3;
						object obj9 = _003Corigin3_003E5__4 - _003Corigin2_003E5__5;
						float num14 = (float)obj9 * num6;
						float num15 = (float)_003Corigin2_003E5__5 + num14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView+<AnimateSwapPositions>d__88)+34]");
						object obj10 = 0 - obj6;
						float num16 = (float)obj10 * num6;
						float num17 = (float)obj6 + num16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView+<AnimateSwapPositions>d__88)+38]");
						nint num18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView+<AnimateSwapPositions>d__88)+44]");
						object obj11 = num18 - 0;
						float num19 = (float)obj11 * num6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView+<AnimateSwapPositions>d__88)+44]");
						float num20 = 0f + num19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
						((Vector3*)(nint)vector)->z = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
						((Vector3*)(nint)vector)->x = 0f;
						container6._modelTransform.localPosition = vector;
						object obj12 = default;
						_003C_003E2__current = obj12;
						_003C_003E1__state = 1;
						result = true;
					}
				}
				return result;
			}
			_003C_003E1__state = -1;
			_003C_003Ec__DisplayClass88_0 obj13 = default;
			_003C_003E8__1 = obj13;
			_003C_003Ec__DisplayClass88_0 obj14 = _003C_003E8__1;
			obj14.dataPosition1 = dataPosition1;
			obj14.dataPosition2 = dataPosition2;
			scrollView.animating__BackingField = true;
			RecycleBin recycleBin = scrollView._recycleBin;
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

	private Arrangement _arrangement = Arrangement.Horizontal;

	public Vector2 cellSize;

	public int cellSpaceY;

	public int cellSpaceX;

	public GameObject pullDownToRefreshPrefab;

	public bool pullDownToRefreshList;

	private Infinite _infinite;

	private UICenterOnChild _centerOnChild;

	private Transform _rootTransform;

	[NonSerialized]
	private UIPanel _rootPanel;

	[NonSerialized]
	private UIScrollView _uiScrollView;

	private Vector2 _nextAppendPosition = Vector2.zeroVector;

	private Vector2 _nextPrependPosition = Vector2.zeroVector;

	private bool _dataChangedDelegatesAdded;

	private AbstractListAdapter _adapter;

	private Bounds _mListViewBounds;

	private RecycleBin _recycleBin;

	private Container _bottomActiveContainer;

	private Container _topActiveContainer;

	private int _endDataIndexCursor;

	private int _topDataIndexCursor;

	public Container pullDownToRefreshContainer;

	private bool _refreshingContainers;

	public Action onTopReached;

	public Action onDraggingStoppped;

	private SpringPanel _springPanel;

	private Container _firstVisibleContainer;

	private Container _lastVisibleContainer;

	public Action onPreLayout;

	public Action onPullDownRelease;

	public Action onPullDownToTriggerRefresh;

	public Action<int> onPullDown;

	private bool _refreshingContainerAdded;

	private bool _refreshContainerEncapsulated;

	public float scrollViewHeight;

	public float scrollViewWidth;

	private const int PULL_TO_REFRESH_CONTAINER = -100;

	private int _currentMaxListCount;

	private int _currentMinListCount;

	private PullDownToRefreshState _pullDownToRefreshState;

	private BoundsCalculationMode boundsCalculationMode;

	private float _currentPos;

	private float _previousPos;

	private ScrollDirection _scrollDirection;

	private bool press;

	private float _movementDelta;

	private float _cumulativeDelta;

	private bool animating__BackingField;

	public Transform rootPanelTransform
	{
		get
		{
			if ((bool)_rootTransform)
			{
				return _rootTransform;
			}
			UIPanel uIPanel = rootPanel;
			return uIPanel.transform;
		}
	}

	public UIPanel rootPanel
	{
		get
		{
			bool flag = (object)_rootPanel == null;
			bool flag2 = !flag;
			UIPanel result = _rootPanel;
			if (!flag2)
			{
				GameObject gameObject = base.gameObject;
				result = (_rootPanel = gameObject.GetComponent<UIPanel>());
			}
			return result;
		}
	}

	public UIScrollView uiScrollView
	{
		get
		{
			bool flag = (object)_uiScrollView == null;
			bool flag2 = !flag;
			UIScrollView result = _uiScrollView;
			if (!flag2)
			{
				GameObject gameObject = base.gameObject;
				result = (_uiScrollView = gameObject.GetComponent<UIScrollView>());
			}
			return result;
		}
	}

	public ScrollDirection scrollDirection => _scrollDirection;

	public bool animating
	{
		get
		{
			return animating__BackingField;
		}
		private set
		{
			animating__BackingField = value;
		}
	}

	public unsafe Bounds listViewBounds
	{
		get
		{
			//IL_000a: Expected native int or pointer, but got VT
			Bounds bounds = default;
			((Bounds*)(nint)bounds)->m_Center = (Vector3)_mListViewBounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (ScrollView)+64]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (ScrollView)+5C]");
			_ = 0;
			return bounds;
		}
	}

	public bool infinite => _infinite == Infinite.BothWays;

	private void InitScrollView()
	{
		AbstractListAdapter adapter = _adapter;
		if (_adapter != null)
		{
			if (~(_dataChangedDelegatesAdded ? 1u : 0u) != 0)
			{
				throw new ArgumentException();
			}
			RecycleBin recycleBin = default;
			recycleBin._002Ector();
			_recycleBin = recycleBin;
		}
		UIScrollView uIScrollView = uiScrollView;
		if (uIScrollView.verticalScrollBar != null)
		{
			UIScrollView uIScrollView2 = uiScrollView;
			uIScrollView2.verticalScrollBar.enabled = false;
		}
		UIScrollView uIScrollView3 = uiScrollView;
		if (uIScrollView3.horizontalScrollBar != null)
		{
			UIScrollView uIScrollView4 = uiScrollView;
			uIScrollView4.horizontalScrollBar.enabled = false;
		}
		UIScrollView uIScrollView5 = uiScrollView;
		bool movement = _arrangement != Arrangement.Horizontal;
		uIScrollView5.movement = (movement ? UIScrollView.Movement.Vertical : UIScrollView.Movement.Horizontal);
	}

	private unsafe void Start()
	{
		UICamera.BoolDelegate boolDelegate = default;
		boolDelegate._002Ector(this, (nint)__ldftn(ScrollView.OnPress));
		Delegate obj = Delegate.Combine(UICamera.onPress, boolDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UICamera.BoolDelegate onPress = default;
		UICamera.onPress = onPress;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UICenterOnChild component = GetComponent<UICenterOnChild>();
		_centerOnChild = component;
	}

	private void OnPress(GameObject go, bool state)
	{
		press = state;
		if (!state)
		{
			_cumulativeDelta = 0f;
		}
	}

	private unsafe void CreatePullDownToRefreshContainer()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0043: Expected I, but got Obj
		//IL_01dc: Expected I, but got Obj
		//IL_0201: Expected F4, but got I
		//IL_01fc: Expected native int or pointer, but got VT
		//IL_020f: Expected F4, but got VT
		//IL_020a: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		if (pullDownToRefreshContainer == null)
		{
			Container container = default;
			container._002Ector(pullDownToRefreshPrefab);
			pullDownToRefreshContainer = container;
			Container container2 = pullDownToRefreshContainer;
			nint num = (nint)container2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ S2_v4 (Il2CppClass<Kiloo.Common.UI.Container>)+DC] (should have been resolved before IL gen)");
			Container container3 = pullDownToRefreshContainer;
			float top = 0f - container3.height;
			container3.top = top;
			Container container4 = pullDownToRefreshContainer;
			container4.bottom = 0f;
			Transform parent = rootPanelTransform;
			container4.SetParent(parent);
			UIPanel uIPanel = rootPanel;
			UIPanel uIPanel2 = rootPanel;
			Container container5 = pullDownToRefreshContainer;
			_ = container5.bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v41 (Kiloo.Common.UI.Container)+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v35 (UIPanel)+D4]");
			float num2 = 0f * 0.5f;
			float num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v38 (UIPanel)+CC]");
			float num4 = num3 + 0f;
			float num5 = container5.height * 0.5f;
			float num6 = num4 + num5;
			float num7 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+14]");
			float num8 = num7 - 0f;
			UIPanel uIPanel3 = rootPanel;
			float num9 = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v27 (UIPanel)+DC]");
			float num10 = num9 - 0f;
			Container container6 = pullDownToRefreshContainer;
			container6.coordinates = Vector2.zeroVector;
			pullDownToRefreshContainer.SetPosition();
			nint num11 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v34 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v35 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
			pullDownToRefreshContainer.SetScale(vector);
			Container container7 = pullDownToRefreshContainer;
			container7.modelType = -100;
		}
	}

	private unsafe void UpdatePullDownToRefreshContainer()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0520: Expected F8, but got I4
		//IL_018b: Expected F8, but got I4
		//IL_0274: Expected F8, but got I4
		//IL_061d: Invalid comparison between F8 and I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected VT, but got Unknown
		//IL_02ad: Expected Ref, but got VT
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_02cc: Expected Obj, but got VT
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected VT, but got Unknown
		//IL_0398: Expected Ref, but got VT
		//IL_03cd: Expected Obj, but got I
		//IL_03da: Expected VT, but got Obj
		//IL_03d5: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 80;
		if (~(pullDownToRefreshList ? 1u : 0u) != 0 || _refreshingContainers)
		{
			return;
		}
		if (_topDataIndexCursor == -1 && !_refreshContainerEncapsulated && _scrollDirection == ScrollDirection.Down && ~(press ? 1u : 0u) == 0)
		{
			_pullDownToRefreshState = PullDownToRefreshState.PullDown;
		}
		if (_pullDownToRefreshState == PullDownToRefreshState.PullDown)
		{
			UIScrollView uIScrollView = uiScrollView;
			uIScrollView.dragEffect = UIScrollView.DragEffect.MomentumAndSpring;
			if (onPullDown != null && pullDownToRefreshContainer != null)
			{
				Transform transform = rootPanelTransform;
				Vector3 localPosition = transform.localPosition;
				Container container = pullDownToRefreshContainer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
				float num = 0f - container.top;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double value = default;
				double num2 = Math.Abs(value);
				if (!(num2 < 2147483648.0))
				{
					value = -2147483648.0;
				}
				Action<int> action = onPullDown;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v261 @ S0_v159 (System.Action`1<System.Int32>)+C] (should have been resolved before IL gen)");
			}
		}
		if (~(pullDownToRefreshList ? 1u : 0u) == 0 && _topDataIndexCursor == -1 && _pullDownToRefreshState == PullDownToRefreshState.PullDown && pullDownToRefreshContainer != null)
		{
			Transform transform2 = rootPanelTransform;
			Vector3 localPosition2 = transform2.localPosition;
			Container container2 = pullDownToRefreshContainer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
			float num3 = 0f - container2.top;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num5 = default;
			double num4 = Math.Abs(num5);
			if (!(num4 < 2147483648.0))
			{
				num5 = -2147483648.0;
			}
			if (!(num5 > -1.0) && !_refreshContainerEncapsulated && !press)
			{
				Bounds bounds = (Bounds)(this + 84);
				Vector3 size = ((Bounds*)bounds)->size;
				object obj3 = obj - -64;
				obj3 = bounds.m_Center;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S1_v35 (UnityEngine.Bounds)+8]");
				_ = 0;
				UIPanel uIPanel = rootPanel;
				Container container3 = pullDownToRefreshContainer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
				float num6 = 0f + container3.height;
				Container container4 = pullDownToRefreshContainer;
				float num7 = container4.height * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
				float num8 = 0f + num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v99 (UIPanel)+D0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				_ = 0;
				Vector3 size2 = (Vector3)(obj + 16);
				((Bounds*)bounds)->size = size2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				obj = 0;
				((Bounds*)(nint)bounds)->m_Center = (Vector3)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				_refreshContainerEncapsulated = true;
				UIScrollView uIScrollView2 = uiScrollView;
				bool flag = uIScrollView2.RestrictWithinBounds(instant: false, horizontal: false, vertical: true);
				UIScrollView uIScrollView3 = uiScrollView;
				uIScrollView3.movement = UIScrollView.Movement.Vertical;
				_pullDownToRefreshState = PullDownToRefreshState.Refreshing;
				Action action2 = onPullDownRelease;
				if (onPullDownRelease != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v366.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
		}
		if (pullDownToRefreshContainer == null || _pullDownToRefreshState != PullDownToRefreshState.Refreshing)
		{
			return;
		}
		Transform transform3 = rootPanelTransform;
		Vector3 localPosition3 = transform3.localPosition;
		Container container5 = pullDownToRefreshContainer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
		float num9 = 0f - container5.top;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num11 = default;
		double num10 = Math.Abs(num11);
		if (!(num10 < 2147483648.0))
		{
			num11 = -2147483648.0;
		}
		if ((int)num11 == 0)
		{
			Action action3 = onPullDownToTriggerRefresh;
			if (onPullDownToTriggerRefresh != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v268.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				_pullDownToRefreshState = PullDownToRefreshState.None;
			}
		}
	}

	private void Update()
	{
		CheckScrollState();
	}

	private void OnClipMove(UIPanel panel)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		if (_refreshingContainers || _adapter == null)
		{
			return;
		}
		HandleScrollUp();
		HandleScrollDown();
		UpdatePullDownToRefreshContainer();
		if (_infinite == Infinite.BothWays)
		{
			object obj3 = this + 84;
			object obj4;
			if (_arrangement == Arrangement.Horizontal)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v18+8]");
				_ = 0;
				UIPanel uIPanel = rootPanel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				_ = 0;
				_ = uIPanel.mClipOffset;
				obj4 = obj + 32;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v18+8]");
				_ = 0;
				UIPanel uIPanel2 = rootPanel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v27 (UIPanel)+F0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				_ = 0;
				obj4 = obj + 16;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v12+8]");
			_ = 0;
			obj = obj4;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
		}
	}

	private void SetContainerPositions()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_02fa: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		RecycleBin recycleBin = _recycleBin;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
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
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj8 == obj9;
			bool flag3 = !flag2;
			object obj10 = obj11;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj7 = 0;
			break;
		}
		object obj14 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @121D");
	}

	private unsafe void ClearList()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0054: Expected I, but got Obj
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected VT, but got Unknown
		//IL_00c9: Expected F4, but got VT
		//IL_00c4: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 48);
		UIScrollView uIScrollView = uiScrollView;
		uIScrollView.DisableSpring();
		_endDataIndexCursor = 0;
		_nextAppendPosition = Vector2.zeroVector;
		_nextPrependPosition = Vector2.zeroVector;
		UIPanel uIPanel = rootPanel;
		Transform transform = uIPanel.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v24 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v25 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+28]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+20]");
		_ = 0;
		Vector3 localPosition = (Vector3)(vector + 8);
		transform.localPosition = localPosition;
		UIPanel uIPanel2 = rootPanel;
		((Vector2*)(nint)vector)->x = (float)Vector2.zeroVector;
		_ = Vector2.zeroVector;
		uIPanel2.clipOffset = vector;
		_recycleBin.Clear();
	}

	private unsafe void OnDataSetChanged(int selection)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0036: Expected I, but got Obj
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00eb: Expected I, but got Obj
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected VT, but got Unknown
		//IL_0160: Expected F4, but got VT
		//IL_015b: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 48);
		_refreshingContainerAdded = false;
		_refreshingContainers = true;
		AbstractListAdapter adapter = _adapter;
		nint num = (nint)adapter;
		object obj2 = adapter + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v5 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
		object obj3 = default;
		if (obj3 == null)
		{
			ClearList();
		}
		else
		{
			SetSelection(selection);
		}
		UIScrollView uIScrollView = uiScrollView;
		object obj4 = uIScrollView - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S2_v7+BC] (should have been resolved before IL gen)");
		UIPanel uIPanel = rootPanel;
		Transform transform = uIPanel.transform;
		nint num2 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v20 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v21 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+28]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+20]");
		_ = 0;
		Vector3 localPosition = (Vector3)(vector + 8);
		transform.localPosition = localPosition;
		UIPanel uIPanel2 = rootPanel;
		((Vector2*)(nint)vector)->x = (float)Vector2.zeroVector;
		_ = Vector2.zeroVector;
		uIPanel2.clipOffset = vector;
		_refreshingContainers = false;
	}

	public void CancelLoading()
	{
		//IL_0036: Expected I, but got Obj
		SpringPanel component = GetComponent<SpringPanel>();
		_springPanel = component;
		SpringPanel springPanel = _springPanel;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		springPanel.target = Vector3.zeroVector;
		_springPanel.enabled = true;
	}

	public void SetAdapter(AbstractListAdapter adapter)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		if (_recycleBin != null)
		{
			_recycleBin.Clear();
		}
		_adapter = adapter;
		_dataChangedDelegatesAdded = false;
		InitScrollView();
		SetSelection(0);
		UIScrollView uIScrollView = uiScrollView;
		object obj = uIScrollView - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S2_v4+BC] (should have been resolved before IL gen)");
	}

	public void PrintActiveContainers()
	{
	}

	private unsafe void PrependContainer(int position, Container container, bool setPosition)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0384: Expected I, but got Obj
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected Obj, but got Unknown
		//IL_03bb: Expected I, but got Obj
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected Obj, but got Unknown
		//IL_03e8: Expected I, but got Obj
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_0437: Expected I, but got Obj
		//IL_045c: Expected F4, but got I
		//IL_0457: Expected native int or pointer, but got VT
		//IL_046a: Expected F4, but got VT
		//IL_0465: Expected native int or pointer, but got VT
		//IL_0344: Expected Obj, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_0166: Expected VT, but got F4
		//IL_031b: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		container.dataIndex = position;
		AbstractListAdapter adapter = _adapter;
		nint num = (nint)adapter;
		object obj2 = adapter + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S3_v2 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+F4] (should have been resolved before IL gen)");
		long rowId = default;
		container.rowId = rowId;
		AbstractListAdapter adapter2 = _adapter;
		nint num2 = (nint)adapter2;
		object obj3 = adapter2 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S3_v6 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
		int modelType = default;
		container.modelType = modelType;
		nint num3 = (nint)container;
		object obj4 = container + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S2_v4 (Il2CppClass<Kiloo.Common.UI.Container>)+DC] (should have been resolved before IL gen)");
		UIPanel uIPanel = rootPanel;
		Transform parent = uIPanel.transform;
		container.SetParent(parent);
		nint num4 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v16 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v17 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		container.SetScale(vector);
		RecycleBin recycleBin = _recycleBin;
		List<Container> activeContainers = recycleBin.activeContainers;
		Container container2;
		if (activeContainers._size >= 1)
		{
			RecycleBin recycleBin2 = _recycleBin;
			Container topActiveContainer = recycleBin2.activeContainers.get_Item(0);
			_topActiveContainer = topActiveContainer;
			Container topActiveContainer2 = _topActiveContainer;
			_nextPrependPosition = topActiveContainer2.coordinates;
			container2 = topActiveContainer2;
		}
		else
		{
			bool flag = _topActiveContainer == null;
			container2 = _topActiveContainer;
			if (flag)
			{
				goto IL_04be;
			}
		}
		object obj5 = container + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v39+8]");
		_ = 0;
		float num6 = container.width * 0.5f;
		float num7 = container2.width * 0.5f;
		float num8 = num6 + num7;
		float num9 = num8 + (float)cellSpaceX;
		float num10 = num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		float num11 = num10 + 0f;
		Container topActiveContainer3 = _topActiveContainer;
		_ = topActiveContainer3.bounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v50 (Kiloo.Common.UI.Container)+30]");
		_ = 0;
		float num12 = num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		float num13 = num12 - 0f;
		float num14 = (float)_nextPrependPosition - num13;
		_nextPrependPosition = (Vector2)num14;
		Container topActiveContainer4 = _topActiveContainer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v39+8]");
		_ = 0;
		float num15 = container.height * 0.5f;
		float num16 = topActiveContainer4.height * 0.5f;
		float num17 = num15 + num16;
		float num18 = num17 + (float)cellSpaceY;
		float num19 = num18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+14]");
		float num20 = num19 - 0f;
		Container topActiveContainer5 = _topActiveContainer;
		_ = topActiveContainer5.bounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v67 (Kiloo.Common.UI.Container)+30]");
		_ = 0;
		float num21 = num20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+14]");
		float num22 = num21 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView)+48]");
		float num23 = 0f + num22;
		Container topActiveContainer6 = _topActiveContainer;
		if (_topActiveContainer != null)
		{
			container.bottom = topActiveContainer6.top;
			float num24 = topActiveContainer6.top - container.height;
			float top = num24 - (float)cellSpaceY;
			container.top = top;
			Container topActiveContainer7 = _topActiveContainer;
			container.right = topActiveContainer7.left;
			float num25 = topActiveContainer7.left - container.width;
			float left = num25 - (float)cellSpaceX;
			container.left = left;
		}
		goto IL_04be;
		IL_04be:
		Vector4 coordinates;
		if (_arrangement == Arrangement.Horizontal)
		{
			UIPanel uIPanel2 = rootPanel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v49 (UIPanel)+CC]");
			object obj6 = 0;
			coordinates = _nextPrependPosition;
		}
		else
		{
			UIPanel uIPanel3 = rootPanel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView)+48]");
			object obj6 = 0;
			coordinates = uIPanel3.mClipRange;
		}
		container.coordinates = (Vector2)coordinates;
		_recycleBin.AddToActiveContainers(container, endOfList: false);
		int topDataIndexCursor = _topDataIndexCursor - 1;
		_topDataIndexCursor = topDataIndexCursor;
		if (setPosition)
		{
			container.SetPosition();
		}
	}

	private unsafe void AppendContainer(int position, Container container, bool setPosition)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_035c: Expected I, but got Obj
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Obj, but got Unknown
		//IL_0393: Expected I, but got Obj
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got Unknown
		//IL_03ef: Expected I, but got Obj
		//IL_0414: Expected F4, but got I
		//IL_040f: Expected native int or pointer, but got VT
		//IL_0422: Expected F4, but got VT
		//IL_041d: Expected native int or pointer, but got VT
		//IL_0437: Expected I, but got Obj
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Obj, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_017d: Expected VT, but got F4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_024a: Expected Obj, but got F4
		//IL_0305: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		container.dataIndex = position;
		AbstractListAdapter adapter = _adapter;
		nint num = (nint)adapter;
		object obj2 = adapter + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S3_v2 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+F4] (should have been resolved before IL gen)");
		long rowId = default;
		container.rowId = rowId;
		AbstractListAdapter adapter2 = _adapter;
		nint num2 = (nint)adapter2;
		object obj3 = adapter2 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S3_v6 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
		int modelType = default;
		container.modelType = modelType;
		UIPanel uIPanel = rootPanel;
		Transform parent = uIPanel.transform;
		container.SetParent(parent);
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v15 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v16 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		container.SetScale(vector);
		nint num5 = (nint)container;
		object obj4 = container + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ S2_v8 (Il2CppClass<Kiloo.Common.UI.Container>)+DC] (should have been resolved before IL gen)");
		RecycleBin recycleBin = _recycleBin;
		List<Container> activeContainers = recycleBin.activeContainers;
		Container container2;
		if (activeContainers._size >= 1)
		{
			RecycleBin recycleBin2 = _recycleBin;
			List<Container> activeContainers2 = recycleBin2.activeContainers;
			int index = activeContainers2._size - 1;
			Container bottomActiveContainer = activeContainers2.get_Item(index);
			_bottomActiveContainer = bottomActiveContainer;
			Container bottomActiveContainer2 = _bottomActiveContainer;
			_nextAppendPosition = bottomActiveContainer2.coordinates;
			container2 = bottomActiveContainer2;
		}
		else
		{
			_bottomActiveContainer = null;
			bool flag = _bottomActiveContainer == null;
			container2 = _bottomActiveContainer;
			if (flag)
			{
				goto IL_0496;
			}
		}
		_ = container2.bounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ L1_v6 (Kiloo.Common.UI.Container)+30]");
		_ = 0;
		float num6 = container.width * 0.5f;
		float num7 = container2.width * 0.5f;
		float num8 = num6 + num7;
		float num9 = num8 + (float)cellSpaceX;
		float num10 = num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		float num11 = num10 + 0f;
		object obj5 = container + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v51+8]");
		_ = 0;
		float num12 = num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		float num13 = num12 - 0f;
		float num14 = (float)_nextAppendPosition + num13;
		_nextAppendPosition = (Vector2)num14;
		object obj6 = this - -64;
		Container bottomActiveContainer3 = _bottomActiveContainer;
		_ = bottomActiveContainer3.bounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v75 (Kiloo.Common.UI.Container)+30]");
		_ = 0;
		float num15 = container.height * 0.5f;
		float num16 = bottomActiveContainer3.height * 0.5f;
		float num17 = num15 + num16;
		float num18 = num17 + (float)cellSpaceY;
		float num19 = num18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+14]");
		float num20 = num19 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v51+8]");
		_ = 0;
		float num21 = num20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+14]");
		float num22 = num21 + 0f;
		float num23 = (float)obj6 - num22;
		obj6 = num23;
		Container bottomActiveContainer4 = _bottomActiveContainer;
		container.top = bottomActiveContainer4.bottom;
		float num24 = bottomActiveContainer4.bottom + container.height;
		float bottom = num24 + (float)cellSpaceY;
		container.bottom = bottom;
		Container bottomActiveContainer5 = _bottomActiveContainer;
		container.left = bottomActiveContainer5.right;
		float num25 = bottomActiveContainer5.right + container.width;
		float right = num25 + (float)cellSpaceX;
		container.right = right;
		goto IL_0496;
		IL_0496:
		object obj7 = this - -64;
		container.coordinates = _nextAppendPosition;
		UIPanel uIPanel2 = rootPanel;
		Vector4 coordinates;
		if (_arrangement == Arrangement.Horizontal)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v34 (UIPanel)+CC]");
			object obj8 = 0;
			coordinates = _nextAppendPosition;
		}
		else
		{
			object obj8 = obj7;
			coordinates = uIPanel2.mClipRange;
		}
		container.coordinates = (Vector2)coordinates;
		_recycleBin.AddToActiveContainers(container, endOfList: true);
		int endDataIndexCursor = _endDataIndexCursor + 1;
		_endDataIndexCursor = endDataIndexCursor;
		if (setPosition)
		{
			container.SetPosition();
		}
	}

	public void SetSelection(int position, ContainerPivot containerPivot = ContainerPivot.Top, float offset = 0f)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0167: Expected I, but got Obj
		//IL_01a7: Expected Obj, but got I
		//IL_01b4: Expected VT, but got Obj
		//IL_0071: Expected I, but got Obj
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00d0: Expected I, but got Obj
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		AbstractListAdapter adapter = _adapter;
		if (_adapter == null)
		{
			string text = name;
			string text2 = text + " : Set the adapter first.";
			GameObject gameObject = base.gameObject;
			return;
		}
		bool flag = position < 0;
		int i = 0;
		if (!flag)
		{
			nint num = (nint)adapter;
			object obj3 = adapter + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S1_v24 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
			object obj5 = default;
			object obj4 = obj5 - 1;
			bool flag2 = (nint)obj4 >= position;
			i = position;
			if (!flag2)
			{
				AbstractListAdapter adapter2 = _adapter;
				nint num2 = (nint)adapter2;
				object obj6 = adapter2 + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v74 @ S1_v30 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
				object obj7 = default;
				int num3 = obj7 - 1;
				i = num3;
			}
		}
		FillFromIndex(i, offset, containerPivot);
		UIScrollView uIScrollView = uiScrollView;
		nint num4 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v25 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v26 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		obj = 0;
		uIScrollView.mMomentum = (Vector3)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		uIScrollView.mShouldMove = true;
	}

	public void SmoothScrollToIndex(int dataIndex, ContainerPivot containerPivot = ContainerPivot.Center, Action onFinished = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 96);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		RecycleBin recycleBin = _recycleBin;
		throw new ArgumentException();
	}

	public unsafe void SmoothScrollToItem(Transform target, ContainerPivot containerPivot = ContainerPivot.Center, Action onFinished = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0046: Expected I, but got Obj
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_02f2: Expected Obj, but got I
		//IL_031f: Expected Obj, but got I
		//IL_034c: Expected Obj, but got I
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Expected VT, but got Unknown
		//IL_0222: Expected Obj, but got I
		//IL_024f: Expected Obj, but got I
		//IL_027c: Expected Obj, but got I
		//IL_0128: Expected Obj, but got I
		//IL_0155: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected VT, but got Unknown
		//IL_06ae: Expected Obj, but got I
		//IL_06ce: Expected Obj, but got I4
		//IL_0906: Expected F4, but got I
		//IL_0901: Expected native int or pointer, but got VT
		//IL_0925: Expected F4, but got I
		//IL_0920: Expected native int or pointer, but got VT
		//IL_04bc: Expected Obj, but got I
		//IL_04e9: Expected Obj, but got I
		//IL_0516: Expected Obj, but got I
		//IL_03ec: Expected Obj, but got I
		//IL_0419: Expected Obj, but got I
		//IL_0446: Expected Obj, but got I
		//IL_058c: Expected Obj, but got I
		//IL_05b9: Expected Obj, but got I
		//IL_05e6: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 128);
		if (_centerOnChild != null)
		{
			_centerOnChild.CenterOn(target);
			return;
		}
		UIScrollView uIScrollView = _uiScrollView;
		UIPanel mPanel = uIScrollView.mPanel;
		nint num = (nint)mPanel;
		object obj2 = mPanel + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S1_v7 (Il2CppClass<UIPanel>)+10C] (should have been resolved before IL gen)");
		switch (containerPivot)
		{
		case ContainerPivot.Center:
		case ContainerPivot.None:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			nint num30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			object obj18 = num30 + 0;
			float num31 = (float)obj18 * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+74]");
			nint num32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			object obj19 = num32 + 0;
			float num33 = (float)obj19 * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			nint num34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			object obj20 = num34 + 0;
			float num7 = (float)obj20 * 0.5f;
			float num8 = num33;
			float num9 = num31;
			break;
		}
		case ContainerPivot.Top:
			if (_arrangement == Arrangement.Vertical)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+24]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+1C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
				nint num20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				object obj12 = num20 + 0;
				float num21 = (float)obj12 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+74]");
				nint num22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
				object obj13 = num22 + 0;
				float num23 = (float)obj13 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
				nint num24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				object obj14 = num24 + 0;
				float num7 = (float)obj14 * 0.5f;
				float num8 = num23;
				float num9 = num21;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+24]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+1C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
				nint num25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				object obj15 = num25 + 0;
				float num26 = (float)obj15 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+74]");
				nint num27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
				object obj16 = num27 + 0;
				float num28 = (float)obj16 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
				nint num29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				object obj17 = num29 + 0;
				float num7 = (float)obj17 * 0.5f;
				float num8 = num28;
				float num9 = num26;
			}
			break;
		case ContainerPivot.Bottom:
			if (_arrangement == Arrangement.Vertical)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+3C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+34]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				object obj6 = num10 + 0;
				float num11 = (float)obj6 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+74]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
				object obj7 = num12 + 0;
				float num13 = (float)obj7 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				object obj8 = num14 + 0;
				float num7 = (float)obj8 * 0.5f;
				float num8 = num13;
				float num9 = num11;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+3C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+34]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				object obj9 = num15 + 0;
				float num16 = (float)obj9 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+74]");
				nint num17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
				object obj10 = num17 + 0;
				float num18 = (float)obj10 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
				nint num19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				object obj11 = num19 + 0;
				float num7 = (float)obj11 * 0.5f;
				float num8 = num18;
				float num9 = num16;
			}
			break;
		default:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			object obj3 = num2 + 0;
			float num3 = (float)obj3 * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+74]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			object obj4 = num4 + 0;
			float num5 = (float)obj4 * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			object obj5 = num6 + 0;
			float num7 = (float)obj5 * 0.5f;
			float num8 = num5;
			float num9 = num3;
			break;
		}
		}
		UIScrollView uIScrollView2 = _uiScrollView;
		Transform cachedTransform = uIScrollView2.mPanel.cachedTransform;
		Vector3 position = target.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Vector3 position2 = vector + 32;
		Vector3 vector2 = cachedTransform.InverseTransformPoint(position2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 position3 = vector + 16;
		Vector3 vector3 = cachedTransform.InverseTransformPoint(position3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		float num35 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		float num36 = num35 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+74]");
		float num37 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+74]");
		float num38 = num37 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		nint num39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		object obj21 = num39 - 0;
		UIWidget component = target.GetComponent<UIWidget>();
		object obj22 = containerPivot - 1;
		bool flag = containerPivot == ContainerPivot.Center;
		float num40 = num38;
		float num41 = num36;
		if (!flag)
		{
			if ((nint)obj22 != 1)
			{
				bool flag2 = (nint)obj22 == 2;
				num40 = num38;
				num41 = num36;
				if (flag2)
				{
					goto IL_08ec;
				}
			}
			bool flag3 = component != null;
			bool flag4 = !flag3;
			num40 = num38;
			num41 = num36;
			if (!flag4)
			{
				if (_arrangement != Arrangement.Vertical)
				{
					if (_arrangement != Arrangement.Horizontal)
					{
						num40 = num38;
						num41 = num36;
					}
					else
					{
						bool flag5 = containerPivot == ContainerPivot.Bottom;
						float num42 = -0.5f;
						if (!flag5)
						{
							num42 = 0.5f;
						}
						float num43 = num42 * (float)component.mWidth;
						float num44 = num36 + num43;
						num40 = num38;
						num41 = num44;
					}
				}
				else
				{
					bool flag6 = containerPivot == ContainerPivot.Bottom;
					float num45 = -0.5f;
					if (!flag6)
					{
						num45 = 0.5f;
					}
					float num46 = num45 * (float)component.mHeight;
					float num47 = num38 + num46;
					num40 = num47;
					num41 = num36;
				}
			}
		}
		goto IL_08ec;
		IL_08ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		((Vector3*)(nint)vector)->x = 0f;
		SmoothScrollToOffset(vector, onFinished);
	}

	private unsafe void SmoothScrollToOffset(Vector3 localOffset, Action onFinished, float strength = 8f)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_032b: Expected Obj, but got I4
		//IL_00ba: Expected native int or pointer, but got VT
		//IL_0154: Expected native int or pointer, but got VT
		//IL_0095: Invalid comparison between VT and F4
		//IL_01cc: Expected F4, but got I
		//IL_01c7: Expected native int or pointer, but got VT
		//IL_01eb: Expected F4, but got I
		//IL_01e6: Expected native int or pointer, but got VT
		//IL_011d: Invalid comparison between I and F4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		animating__BackingField = true;
		UIScrollView uIScrollView = _uiScrollView;
		bool flag = uIScrollView.movement == UIScrollView.Movement.Horizontal;
		bool flag2 = true;
		bool flag4;
		if (!flag)
		{
			if (uIScrollView.movement != UIScrollView.Movement.Vertical)
			{
				bool flag3 = uIScrollView.movement == UIScrollView.Movement.Unrestricted;
				flag2 = true;
				if (flag3)
				{
					goto IL_026d;
				}
				if (uIScrollView.movement == UIScrollView.Movement.Custom)
				{
					flag4 = uIScrollView.customMovement != (Vector2)(object)0f;
					goto IL_027a;
				}
			}
			flag2 = false;
		}
		goto IL_026d;
		IL_02ab:
		bool flag5;
		float num;
		if (flag5)
		{
			num = localOffset.y;
		}
		else
		{
			((Vector3*)(nint)localOffset)->y = 0f;
			num = 0f;
		}
		UIScrollView uIScrollView2 = _uiScrollView;
		Transform cachedTransform = uIScrollView2.mPanel.cachedTransform;
		UIScrollView uIScrollView3 = _uiScrollView;
		GameObject cachedGameObject = uIScrollView3.mPanel.cachedGameObject;
		Vector3 localPosition = cachedTransform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		float num2 = 0f - localOffset.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		float num3 = 0f - num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		float num4 = 0f - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		SpringPanel springPanel = SpringPanel.Begin(cachedGameObject, vector, strength);
		SpringPanel.OnFinished onFinished2 = default;
		object obj2 = default;
		onFinished2._002Ector(obj2, (nint)__ldftn(_003C_003Ec__DisplayClass87_0._003CSmoothScrollToOffset_003Eb__0));
		springPanel.onFinished = onFinished2;
		return;
		IL_026d:
		flag4 = flag2;
		goto IL_027a;
		IL_027a:
		if (!flag4)
		{
			((Vector3*)(nint)localOffset)->x = 0f;
		}
		UIScrollView uIScrollView4 = _uiScrollView;
		object obj3 = uIScrollView4.movement - 1;
		bool flag6 = uIScrollView4.movement == UIScrollView.Movement.Vertical;
		bool flag7 = true;
		if (!flag6)
		{
			bool flag8 = (nint)obj3 == 1;
			flag7 = true;
			if (!flag8)
			{
				if ((nint)obj3 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v21 (UIScrollView)+34]");
					flag5 = 0f != 0f;
					goto IL_02ab;
				}
				flag7 = false;
			}
		}
		flag5 = flag7;
		goto IL_02ab;
	}

	public IEnumerator AnimateSwapPositions(int dataPosition1, int dataPosition2, float time, Action onComplete = null)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void Recenter()
	{
		if (_centerOnChild != null)
		{
			_centerOnChild.Recenter();
		}
	}

	private void FillFromIndex(int i, float topOffset, ContainerPivot containerPivot = ContainerPivot.None)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_23b5: Expected I, but got Obj
		//IL_23be: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c3: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003a: Expected Obj, but got I4
		//IL_0070: Expected I, but got Obj
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_1c5b: Expected I, but got Obj
		//IL_1ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca6: Expected VT, but got Unknown
		//IL_1cd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cdc: Expected VT, but got Unknown
		//IL_1d1b: Expected I, but got Obj
		//IL_1d24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d29: Expected Obj, but got Unknown
		//IL_00ef: Expected I, but got Obj
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_013a: Expected I, but got Obj
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_0757: Expected F4, but got I
		//IL_1db5: Expected VT, but got F4
		//IL_073a: Expected F4, but got VT
		//IL_1e03: Expected I, but got Obj
		//IL_1e0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e11: Expected Obj, but got Unknown
		//IL_1e5f: Expected I, but got Obj
		//IL_1e8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e90: Expected VT, but got Unknown
		//IL_1ea3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea8: Expected Obj, but got Unknown
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected Obj, but got Unknown
		//IL_08d1: Expected F4, but got I
		//IL_1f18: Expected Obj, but got I
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Expected Obj, but got Unknown
		//IL_2407: Expected I, but got Obj
		//IL_2410: Unknown result type (might be due to invalid IL or missing references)
		//IL_2415: Expected Obj, but got Unknown
		//IL_202e: Expected I, but got Obj
		//IL_2037: Unknown result type (might be due to invalid IL or missing references)
		//IL_203c: Expected Obj, but got Unknown
		//IL_097e: Expected I, but got Obj
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Expected Obj, but got Unknown
		//IL_1f9a: Expected I, but got Obj
		//IL_1fa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa8: Expected Obj, but got Unknown
		//IL_091d: Expected I, but got Obj
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Expected Obj, but got Unknown
		//IL_093e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Expected I4, but got Unknown
		//IL_0d25: Invalid comparison between F4 and I
		//IL_0a16: Invalid comparison between F4 and I
		//IL_0d56: Expected I, but got Obj
		//IL_0d5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d64: Expected Obj, but got Unknown
		//IL_0d89: Expected I, but got Obj
		//IL_0d92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d97: Expected Obj, but got Unknown
		//IL_0eb0: Expected I, but got Obj
		//IL_0eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebe: Expected Obj, but got Unknown
		//IL_0ee3: Expected I, but got Obj
		//IL_0eec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef1: Expected Obj, but got Unknown
		//IL_0a47: Expected I, but got Obj
		//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a55: Expected Obj, but got Unknown
		//IL_0a7a: Expected I, but got Obj
		//IL_0a83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a88: Expected Obj, but got Unknown
		//IL_1bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf7: Expected Obj, but got Unknown
		//IL_1c07: Expected Obj, but got I
		//IL_0fe9: Expected I, but got Obj
		//IL_0ff2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff7: Expected Obj, but got Unknown
		//IL_0de5: Expected I, but got Obj
		//IL_0dee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df3: Expected Obj, but got Unknown
		//IL_0baf: Expected I, but got Obj
		//IL_0bb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbd: Expected Obj, but got Unknown
		//IL_0be2: Expected I, but got Obj
		//IL_0beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Expected Obj, but got Unknown
		//IL_1b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7f: Expected Obj, but got Unknown
		//IL_1b8f: Expected Obj, but got I
		//IL_1b9f: Expected F4, but got I
		//IL_0ad6: Expected I, but got Obj
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae4: Expected Obj, but got Unknown
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected Obj, but got Unknown
		//IL_1081: Invalid comparison between F4 and I
		//IL_0f8a: Expected I, but got Obj
		//IL_0f93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f98: Expected Obj, but got Unknown
		//IL_0fab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb0: Expected I4, but got Unknown
		//IL_0c89: Expected I, but got Obj
		//IL_0c92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c97: Expected Obj, but got Unknown
		//IL_0caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caf: Expected I4, but got Unknown
		//IL_17b9: Expected I, but got Obj
		//IL_17c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c7: Expected Obj, but got Unknown
		//IL_17ec: Expected I, but got Obj
		//IL_17f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fa: Expected Obj, but got Unknown
		//IL_181a: Expected I, but got Obj
		//IL_1823: Unknown result type (might be due to invalid IL or missing references)
		//IL_1828: Expected Obj, but got Unknown
		//IL_11be: Expected I, but got Obj
		//IL_11c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cc: Expected Obj, but got Unknown
		//IL_11df: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e4: Expected I4, but got Unknown
		//IL_1200: Expected I, but got Obj
		//IL_1209: Unknown result type (might be due to invalid IL or missing references)
		//IL_120e: Expected Obj, but got Unknown
		//IL_1221: Unknown result type (might be due to invalid IL or missing references)
		//IL_1226: Expected I4, but got Unknown
		//IL_1242: Expected I, but got Obj
		//IL_124b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1250: Expected Obj, but got Unknown
		//IL_1263: Unknown result type (might be due to invalid IL or missing references)
		//IL_1268: Expected Obj, but got Unknown
		//IL_1270: Expected I, but got Obj
		//IL_1279: Unknown result type (might be due to invalid IL or missing references)
		//IL_127e: Expected Obj, but got Unknown
		//IL_12ad: Expected I, but got Obj
		//IL_12b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bb: Expected Obj, but got Unknown
		//IL_12ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d3: Expected Obj, but got Unknown
		//IL_12db: Expected I, but got Obj
		//IL_12e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e9: Expected Obj, but got Unknown
		//IL_1309: Expected I, but got Obj
		//IL_1312: Unknown result type (might be due to invalid IL or missing references)
		//IL_1317: Expected Obj, but got Unknown
		//IL_1333: Expected I, but got Obj
		//IL_133c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1341: Expected Obj, but got Unknown
		//IL_1354: Unknown result type (might be due to invalid IL or missing references)
		//IL_1359: Expected I4, but got Unknown
		//IL_1899: Expected I, but got Obj
		//IL_18a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a7: Expected Obj, but got Unknown
		//IL_13ab: Expected F4, but got I
		//IL_13e6: Expected I, but got Obj
		//IL_13ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f4: Expected Obj, but got Unknown
		//IL_1407: Unknown result type (might be due to invalid IL or missing references)
		//IL_140c: Expected Obj, but got Unknown
		//IL_1414: Expected I, but got Obj
		//IL_141d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1422: Expected Obj, but got Unknown
		//IL_2265: Expected I, but got Obj
		//IL_2291: Unknown result type (might be due to invalid IL or missing references)
		//IL_2296: Expected VT, but got Unknown
		//IL_22c9: Expected I, but got Obj
		//IL_22d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d7: Expected Obj, but got Unknown
		//IL_247c: Expected I, but got Obj
		//IL_2485: Unknown result type (might be due to invalid IL or missing references)
		//IL_248a: Expected Obj, but got Unknown
		//IL_2169: Expected I, but got Obj
		//IL_2195: Unknown result type (might be due to invalid IL or missing references)
		//IL_219a: Expected VT, but got Unknown
		//IL_21b9: Expected I, but got Obj
		//IL_21c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c7: Expected Obj, but got Unknown
		//IL_1aed: Expected Obj, but got I
		//IL_194b: Invalid comparison between F4 and I
		//IL_165a: Expected Obj, but got I
		//IL_197c: Expected I, but got Obj
		//IL_1985: Unknown result type (might be due to invalid IL or missing references)
		//IL_198a: Expected Obj, but got Unknown
		//IL_19af: Expected I, but got Obj
		//IL_19b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_19bd: Expected Obj, but got Unknown
		//IL_1a10: Expected I, but got Obj
		//IL_1a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1e: Expected Obj, but got Unknown
		//IL_14cc: Expected I, but got Obj
		//IL_14d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14da: Expected Obj, but got Unknown
		//IL_14ff: Expected I, but got Obj
		//IL_1508: Unknown result type (might be due to invalid IL or missing references)
		//IL_150d: Expected Obj, but got Unknown
		//IL_15ab: Expected I, but got Obj
		//IL_15b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b9: Expected Obj, but got Unknown
		//IL_15cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d1: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 272;
		Container container = pullDownToRefreshContainer;
		if (pullDownToRefreshContainer != null)
		{
			NGUITools.Destroy(container.model);
			object obj3 = this + 128;
			obj3 = 0;
		}
		_scrollDirection = ScrollDirection.Stationary;
		_pullDownToRefreshState = PullDownToRefreshState.None;
		_refreshingContainerAdded = false;
		_currentPos = 0f;
		AbstractListAdapter adapter = _adapter;
		nint num = (nint)adapter;
		object obj4 = adapter + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S1_v9 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
		object obj5 = default;
		if (i < 0 || i >= (nint)obj5)
		{
			return;
		}
		AbstractListAdapter adapter2 = _adapter;
		nint num2 = (nint)adapter2;
		object obj6 = adapter2 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v127 @ S1_v17 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
		object obj7 = default;
		if (obj7 == null)
		{
			return;
		}
		_refreshingContainers = true;
		UIScrollView uIScrollView = uiScrollView;
		uIScrollView.DisableSpring();
		_recycleBin.Clear();
		Transform transform = rootPanelTransform;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v40 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v41 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
		_ = 0;
		Vector3 localPosition = (Vector3)(obj + 120);
		transform.localPosition = localPosition;
		UIPanel uIPanel = rootPanel;
		_ = Vector2.zeroVector;
		_ = Vector2.zeroVector;
		Vector2 clipOffset = (Vector2)(obj + 112);
		uIPanel.clipOffset = clipOffset;
		_endDataIndexCursor = i;
		_topDataIndexCursor = i;
		CalculateVirtualRelativeWidgetBounds(boundsCalculationMode);
		AbstractListAdapter adapter3 = _adapter;
		nint num5 = (nint)adapter3;
		object obj8 = adapter3 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v218 @ S4_v3 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
		int modelType = default;
		Container scrapContainer = _recycleBin.GetScrapContainer(modelType);
		nint num6 = (nint)adapter3;
		object obj9 = adapter3 + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v231 @ S4_v7 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+E4] (should have been resolved before IL gen)");
		Container container2 = default;
		if (container2 != null)
		{
			container2.isMeasured = false;
			nint num7 = (nint)container2;
			object obj10 = container2 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v246 @ S2_v21 (Il2CppClass<Kiloo.Common.UI.Container>)+DC] (should have been resolved before IL gen)");
			UIPanel uIPanel2 = rootPanel;
			UIPanel uIPanel3 = rootPanel;
			object obj11 = container2 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S1_v61+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v74 (UIPanel)+D4]");
			float num8 = 0f * 0.5f;
			float num9 = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v77 (UIPanel)+CC]");
			float num10 = num9 + 0f;
			float num11 = container2.height * 0.5f;
			float num12 = num10 - num11;
			float num13 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+EC]");
			float num14 = num13 - 0f;
			float num16 = default;
			float num15 = num14 - num16;
			UIPanel uIPanel4 = rootPanel;
			UIPanel uIPanel5 = rootPanel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S1_v61+8]");
			_ = 0;
			float num17 = container2.width * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v92 (UIPanel)+D0]");
			float num18 = 0f * 0.5f;
			float num19 = num17 - num18;
			float num20 = num19 + (float)uIPanel5.mClipRange;
			float num21 = num20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
			float num22 = num21 + 0f;
			float num23 = num22 + num16;
			float num41;
			float num42;
			switch (containerPivot)
			{
			default:
				num41 = num15;
				num42 = num23;
				break;
			case ContainerPivot.Top:
			{
				UIPanel uIPanel11 = rootPanel;
				UIPanel uIPanel12 = rootPanel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S1_v61+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v535 (UIPanel)+D4]");
				float num44 = 0f * 0.5f;
				float num45 = num44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S0_v538 (UIPanel)+CC]");
				float num46 = num45 + 0f;
				float num47 = container2.height * 0.5f;
				float num48 = num46 - num47;
				float num49 = num48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+EC]");
				float num50 = num49 - 0f;
				UIPanel uIPanel13 = rootPanel;
				UIPanel uIPanel14 = rootPanel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S1_v61+8]");
				_ = 0;
				float num51 = container2.width * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S0_v552 (UIPanel)+D0]");
				float num52 = 0f * 0.5f;
				float num53 = num51 - num52;
				float num54 = num53 + (float)uIPanel14.mClipRange;
				float num55 = num54;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
				float num56 = num55 + 0f;
				num16 = 0f;
				num41 = num50;
				num42 = num56;
				break;
			}
			case ContainerPivot.Center:
			{
				UIPanel uIPanel15 = rootPanel;
				if (_arrangement == Arrangement.Horizontal)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S0_v568 (UIPanel)+D0]");
					float num57 = 0f * 0.5f;
					float num58 = container2.width * 0.5f;
					float num59 = num57 - num58;
					num16 = num59;
					num41 = 0f;
					num42 = 0f;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S0_v568 (UIPanel)+D4]");
					float num60 = 0f * 0.5f;
					float num61 = container2.height * 0.5f;
					float num62 = num60 - num61;
					num16 = num62;
					num41 = 0f;
					num42 = 0f;
				}
				break;
			}
			case ContainerPivot.Bottom:
			{
				UIPanel uIPanel6 = rootPanel;
				UIPanel uIPanel7 = rootPanel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S1_v61+8]");
				_ = 0;
				float num24 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S0_v584 (UIPanel)+D4]");
				float num25 = num24 - 0f;
				float num26 = num25 * 0.5f;
				float num27 = num26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S0_v587 (UIPanel)+CC]");
				float num28 = num27 + 0f;
				float num29 = container2.height * 0.5f;
				float num30 = num28 + num29;
				float num31 = num30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+EC]");
				float num32 = num31 - 0f;
				UIPanel uIPanel8 = rootPanel;
				UIPanel uIPanel9 = rootPanel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S1_v61+8]");
				_ = 0;
				float num33 = 0f - container2.width;
				float num34 = num33 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v602 (UIPanel)+D0]");
				float num35 = 0f * 0.5f;
				float num36 = num34 + num35;
				float num37 = num36 + (float)uIPanel9.mClipRange;
				float num38 = num37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
				float num39 = num38 + 0f;
				UIPanel uIPanel10 = rootPanel;
				if (_arrangement == Arrangement.Horizontal)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ S0_v618 (UIPanel)+D0]");
					float num40 = 0f - container2.width;
					num16 = num40;
					num41 = num32;
					num42 = num39;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ S0_v618 (UIPanel)+D4]");
					float num43 = 0f - container2.height;
					num16 = num43;
					num41 = num32;
					num42 = num39;
				}
				break;
			}
			}
			UIPanel uIPanel16 = rootPanel;
			if (_arrangement == Arrangement.Vertical)
			{
				num42 = (float)uIPanel16.mClipRange;
				float num63 = num41;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ S0_v110 (UIPanel)+CC]");
				float num63 = 0f;
			}
			container2.coordinates = (Vector2)num42;
			float right;
			if (_arrangement == Arrangement.Vertical)
			{
				container2.top = num16;
				float num64 = num16 + container2.height;
				float bottom = num64 + (float)cellSpaceY;
				container2.left = 0f;
				container2.bottom = bottom;
				right = container2.width + 0f;
			}
			else
			{
				container2.top = 0f;
				float bottom2 = container2.height + 0f;
				container2.left = num16;
				container2.bottom = bottom2;
				float num65 = num16 + container2.width;
				right = num65 + (float)cellSpaceX;
			}
			container2.right = right;
			AbstractListAdapter adapter4 = _adapter;
			nint num66 = (nint)adapter4;
			object obj12 = adapter4 + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v646 @ S3_v10 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
			int modelType2 = default;
			container2.modelType = modelType2;
			UIPanel uIPanel17 = rootPanel;
			Transform parent = uIPanel17.transform;
			container2.SetParent(parent);
			nint num67 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ S1_v101 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num68 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ S1_v102 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			_ = 0;
			_ = Vector3.oneVector;
			Vector3 scale = (Vector3)(obj + 96);
			container2.SetScale(scale);
			object obj13 = this + 84;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ S1_v109+8]");
			_ = 0;
			if (_arrangement == Arrangement.Vertical)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+EC]");
				float num69 = 0f - num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
				_ = 0;
				object obj14 = obj + 216;
				float num70 = num69;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S1_v61+8]");
				_ = 0;
				float num71 = num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
				float num72 = num71 + 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
				float num73 = 0f + num72;
				object obj14 = obj + 200;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+EC]");
				float num70 = 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ S0_v137+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
			_ = 0;
			int topDataIndexCursor = _topDataIndexCursor - 1;
			_topDataIndexCursor = topDataIndexCursor;
			int num74 = ++_endDataIndexCursor;
			container2.dataIndex = i;
			if (_infinite == Infinite.BothWays)
			{
				bool flag = _topDataIndexCursor <= -1;
				bool flag2 = !flag;
				int num75 = num74;
				if (!flag2)
				{
					AbstractListAdapter adapter5 = _adapter;
					nint num76 = (nint)adapter5;
					object obj15 = adapter5 + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v819 @ S2_v244 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
					object obj16 = default;
					int topDataIndexCursor2 = obj16 - 1;
					_topDataIndexCursor = topDataIndexCursor2;
					num75 = _endDataIndexCursor;
				}
				AbstractListAdapter adapter6 = _adapter;
				nint num77 = (nint)adapter6;
				object obj17 = adapter6 + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v840 @ S1_v483 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
				object obj18 = default;
				if ((nint)obj18 == num75)
				{
					_endDataIndexCursor = 0;
				}
			}
			AbstractListAdapter adapter7 = _adapter;
			nint num78 = (nint)adapter7;
			object obj19 = adapter7 + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v801 @ S3_v16 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+F4] (should have been resolved before IL gen)");
			long rowId = default;
			container2.rowId = rowId;
			_recycleBin.AddToActiveContainers(container2, endOfList: true);
			if (_arrangement == Arrangement.Vertical)
			{
				object obj21 = default;
				int modelType3 = default;
				Container container4 = default;
				object obj26 = default;
				while (true)
				{
					AbstractListAdapter adapter8 = _adapter;
					nint num79 = (nint)adapter8;
					object obj20 = adapter8 + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v882 @ S2_v208 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
					if (_endDataIndexCursor >= (nint)obj21)
					{
						break;
					}
					RecycleBin recycleBin = _recycleBin;
					List<Container> activeContainers = recycleBin.activeContainers;
					int index = activeContainers._size - 1;
					Container container3 = activeContainers.get_Item(index);
					UIPanel uIPanel18 = rootPanel;
					float bottom3 = container3.bottom;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ S1_v467 (UIPanel)+D4]");
					if (!(bottom3 < 0f))
					{
						break;
					}
					AbstractListAdapter adapter9 = _adapter;
					nint num80 = (nint)adapter9;
					object obj22 = adapter9 + 48;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1097 @ S4_v116 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
					Container scrapContainer2 = _recycleBin.GetScrapContainer(modelType3);
					nint num81 = (nint)adapter9;
					object obj23 = adapter9 + 40;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1174 @ S4_v120 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+E4] (should have been resolved before IL gen)");
					if (container4 != null)
					{
						AppendContainer(_endDataIndexCursor, container4, setPosition: false);
						AbstractListAdapter adapter10 = _adapter;
						nint num82 = (nint)adapter10;
						object obj24 = adapter10 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1322 @ S2_v235 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
						object obj25 = obj26 - 1;
						if (_endDataIndexCursor == (nint)obj25 && _infinite == Infinite.BothWays)
						{
							_endDataIndexCursor = 0;
						}
					}
				}
				int modelType4 = default;
				Container container6 = default;
				object obj30 = default;
				while (true)
				{
					IL_1ff0:
					int num83 = _topDataIndexCursor;
					while (num83 >= 0)
					{
						RecycleBin recycleBin2 = _recycleBin;
						Container container5 = recycleBin2.activeContainers.get_Item(0);
						if (!(container5.top > 0f))
						{
							break;
						}
						AbstractListAdapter adapter11 = _adapter;
						nint num84 = (nint)adapter11;
						object obj27 = adapter11 + 48;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1189 @ S4_v107 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
						Container scrapContainer3 = _recycleBin.GetScrapContainer(modelType4);
						nint num85 = (nint)adapter11;
						object obj28 = adapter11 + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1257 @ S4_v111 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+E4] (should have been resolved before IL gen)");
						if (container6 != null)
						{
							PrependContainer(_topDataIndexCursor, container6, setPosition: false);
							if (_infinite == Infinite.BothWays)
							{
								bool flag3 = _topDataIndexCursor > -1;
								num83 = _topDataIndexCursor;
								if (!flag3)
								{
									AbstractListAdapter adapter12 = _adapter;
									nint num86 = (nint)adapter12;
									object obj29 = adapter12 + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1434 @ S2_v221 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
									num83 = (_topDataIndexCursor = obj30 - 1);
								}
								continue;
							}
						}
						goto IL_1ff0;
					}
					break;
				}
			}
			else
			{
				object obj32 = default;
				int modelType5 = default;
				Container container8 = default;
				object obj36 = default;
				while (true)
				{
					AbstractListAdapter adapter13 = _adapter;
					nint num87 = (nint)adapter13;
					object obj31 = adapter13 + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v923 @ S2_v45 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
					if (_endDataIndexCursor >= (nint)obj32)
					{
						break;
					}
					RecycleBin recycleBin3 = _recycleBin;
					List<Container> activeContainers2 = recycleBin3.activeContainers;
					int index2 = activeContainers2._size - 1;
					Container container7 = activeContainers2.get_Item(index2);
					UIPanel uIPanel19 = rootPanel;
					float right2 = container7.right;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ S1_v163 (UIPanel)+D0]");
					if (!(right2 < 0f))
					{
						break;
					}
					AbstractListAdapter adapter14 = _adapter;
					nint num88 = (nint)adapter14;
					object obj33 = adapter14 + 48;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1161 @ S4_v30 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
					Container scrapContainer4 = _recycleBin.GetScrapContainer(modelType5);
					nint num89 = (nint)adapter14;
					object obj34 = adapter14 + 40;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1226 @ S4_v34 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+E4] (should have been resolved before IL gen)");
					if (container8 != null)
					{
						AppendContainer(_endDataIndexCursor, container8, setPosition: false);
						AbstractListAdapter adapter15 = _adapter;
						nint num90 = (nint)adapter15;
						object obj35 = adapter15 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1349 @ S2_v72 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
						if (_endDataIndexCursor == (nint)obj36 && _infinite == Infinite.BothWays)
						{
							_endDataIndexCursor = 0;
						}
					}
				}
				int modelType6 = default;
				Container container10 = default;
				object obj40 = default;
				while (true)
				{
					IL_2067:
					int num91 = _topDataIndexCursor;
					while (num91 >= 0)
					{
						RecycleBin recycleBin4 = _recycleBin;
						Container container9 = recycleBin4.activeContainers.get_Item(0);
						if (!(container9.left > 0f))
						{
							break;
						}
						AbstractListAdapter adapter16 = _adapter;
						nint num92 = (nint)adapter16;
						object obj37 = adapter16 + 48;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1241 @ S4_v21 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
						Container scrapContainer5 = _recycleBin.GetScrapContainer(modelType6);
						nint num93 = (nint)adapter16;
						object obj38 = adapter16 + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1310 @ S4_v25 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+E4] (should have been resolved before IL gen)");
						if (container10 != null)
						{
							PrependContainer(_topDataIndexCursor, container10, setPosition: false);
							if (_infinite == Infinite.BothWays)
							{
								bool flag4 = _topDataIndexCursor > -1;
								num91 = _topDataIndexCursor;
								if (!flag4)
								{
									AbstractListAdapter adapter17 = _adapter;
									nint num94 = (nint)adapter17;
									object obj39 = adapter17 + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1466 @ S2_v58 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
									num91 = (_topDataIndexCursor = obj40 - 1);
								}
								continue;
							}
						}
						goto IL_2067;
					}
					break;
				}
			}
			if (_infinite != Infinite.BothWays && _arrangement == Arrangement.Vertical)
			{
				AbstractListAdapter adapter18 = _adapter;
				nint num95 = (nint)adapter18;
				object obj41 = adapter18 + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1204 @ S2_v90 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
				object obj42 = default;
				if (_endDataIndexCursor == (nint)obj42)
				{
					RecycleBin recycleBin5 = _recycleBin;
					List<Container> activeContainers3 = recycleBin5.activeContainers;
					int index3 = activeContainers3._size - 1;
					Container container11 = activeContainers3.get_Item(index3);
					UIPanel uIPanel20 = rootPanel;
					float bottom4 = container11.bottom;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1333 @ S1_v329 (UIPanel)+D4]");
					if (bottom4 < 0f)
					{
						RecycleBin recycleBin6 = _recycleBin;
						List<Container> activeContainers4 = recycleBin6.activeContainers;
						int index4 = activeContainers4._size - 1;
						Container container12 = activeContainers4.get_Item(index4);
						UIPanel uIPanel21 = rootPanel;
						_ = container12.bounds;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1385 @ S0_v366 (Kiloo.Common.UI.Container)+30]");
						_ = 0;
						float num96 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1444 @ S0_v368 (UIPanel)+D4]");
						float num97 = num96 - 0f;
						float num98 = num97 * 0.5f;
						float num99 = container12.height * 0.5f;
						float num100 = num98 + num99;
						float num101 = num100;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+EC]");
						float num102 = num101 - 0f;
						UIPanel uIPanel22 = rootPanel;
						float num103 = num102;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1500 @ S1_v348 (UIPanel)+CC]");
						float num104 = num103 + 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1385 @ S0_v366 (Kiloo.Common.UI.Container)+20]");
						float num105 = 0f - num104;
						_recycleBin.ScrapActiveContainers();
						AbstractListAdapter adapter19 = _adapter;
						nint num106 = (nint)adapter19;
						object obj43 = adapter19 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1569 @ S2_v151 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
						object obj44 = default;
						int topDataIndexCursor3 = obj44 - 1;
						_topDataIndexCursor = topDataIndexCursor3;
						AbstractListAdapter adapter20 = _adapter;
						nint num107 = (nint)adapter20;
						object obj45 = adapter20 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1584 @ S2_v156 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
						object obj46 = default;
						int endDataIndexCursor = obj46 - 1;
						_endDataIndexCursor = endDataIndexCursor;
						AbstractListAdapter adapter21 = _adapter;
						nint num108 = (nint)adapter21;
						object obj47 = adapter21 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1603 @ S4_v67 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
						object obj49 = default;
						object obj48 = obj49 - 1;
						nint num109 = (nint)adapter21;
						object obj50 = adapter21 + 48;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1614 @ S4_v72 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
						int modelType7 = default;
						Container scrapContainer6 = _recycleBin.GetScrapContainer(modelType7);
						AbstractListAdapter adapter22 = _adapter;
						nint num110 = (nint)adapter22;
						object obj51 = adapter22 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1649 @ S3_v92 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
						object obj53 = default;
						object obj52 = obj53 - 1;
						nint num111 = (nint)adapter21;
						object obj54 = adapter21 + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1661 @ S4_v79 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+E4] (should have been resolved before IL gen)");
						Container container13 = default;
						container13.isMeasured = false;
						nint num112 = (nint)container13;
						object obj55 = container13 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1674 @ S2_v167 (Il2CppClass<Kiloo.Common.UI.Container>)+DC] (should have been resolved before IL gen)");
						AbstractListAdapter adapter23 = _adapter;
						nint num113 = (nint)adapter23;
						object obj56 = adapter23 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1685 @ S1_v366 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
						object obj57 = default;
						int dataIndex = obj57 - 1;
						container13.dataIndex = dataIndex;
						UIPanel uIPanel23 = rootPanel;
						container13.coordinates = (Vector2)uIPanel23.mClipRange;
						UIPanel uIPanel24 = rootPanel;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1741 @ S1_v376 (UIPanel)+D4]");
						container13.bottom = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1741 @ S1_v376 (UIPanel)+D4]");
						float top = 0f - container13.height;
						container13.top = top;
						AbstractListAdapter adapter24 = _adapter;
						nint num114 = (nint)adapter24;
						object obj58 = adapter24 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1782 @ S3_v101 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
						object obj60 = default;
						object obj59 = obj60 - 1;
						nint num115 = (nint)adapter24;
						object obj61 = adapter24 + 48;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1793 @ S3_v106 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
						int modelType8 = default;
						container13.modelType = modelType8;
						UIPanel uIPanel25 = rootPanel;
						Transform parent2 = uIPanel25.transform;
						container13.SetParent(parent2);
						nint num116 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1845 @ S1_v388 (Il2CppClass<UnityEngine.Vector3>)+5C]");
						nint num117 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1846 @ S1_v389 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
						_ = 0;
						_ = Vector3.oneVector;
						Vector3 scale2 = (Vector3)(obj - -64);
						container13.SetScale(scale2);
						AbstractListAdapter adapter25 = _adapter;
						nint num118 = (nint)adapter25;
						object obj62 = adapter25 + 56;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1869 @ S3_v110 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+F4] (should have been resolved before IL gen)");
						long rowId2 = default;
						container13.rowId = rowId2;
						_recycleBin.AddToActiveContainers(container13, endOfList: true);
						int topDataIndexCursor4 = _topDataIndexCursor - 1;
						_topDataIndexCursor = topDataIndexCursor4;
						int endDataIndexCursor2 = _endDataIndexCursor + 1;
						_endDataIndexCursor = endDataIndexCursor2;
						int modelType9 = default;
						Container container15 = default;
						object obj66 = default;
						while (true)
						{
							IL_222b:
							int num119 = _topDataIndexCursor;
							while (num119 >= 0)
							{
								RecycleBin recycleBin7 = _recycleBin;
								Container container14 = recycleBin7.activeContainers.get_Item(0);
								if (!(container14.top > 0f))
								{
									break;
								}
								AbstractListAdapter adapter26 = _adapter;
								nint num120 = (nint)adapter26;
								object obj63 = adapter26 + 48;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2101 @ S4_v94 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
								Container scrapContainer7 = _recycleBin.GetScrapContainer(modelType9);
								nint num121 = (nint)adapter26;
								object obj64 = adapter26 + 40;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2127 @ S4_v98 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+E4] (should have been resolved before IL gen)");
								if (container15 != null)
								{
									PrependContainer(_topDataIndexCursor, container15, setPosition: false);
								}
								if (_infinite != Infinite.BothWays)
								{
									goto IL_222b;
								}
								bool flag5 = _topDataIndexCursor > -1;
								num119 = _topDataIndexCursor;
								if (!flag5)
								{
									AbstractListAdapter adapter27 = _adapter;
									nint num122 = (nint)adapter27;
									object obj65 = adapter27 + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2181 @ S2_v201 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
									num119 = (_topDataIndexCursor = obj66 - 1);
								}
							}
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ S1_v109+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+EC]");
						float num123 = 0f - num105;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
						obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
						_ = 0;
					}
				}
				if (_topDataIndexCursor <= -1)
				{
					RecycleBin recycleBin8 = _recycleBin;
					Container container16 = recycleBin8.activeContainers.get_Item(0);
					if (container16.top > 0f)
					{
						RecycleBin recycleBin9 = _recycleBin;
						Container container17 = recycleBin9.activeContainers.get_Item(0);
						UIPanel uIPanel26 = rootPanel;
						UIPanel uIPanel27 = rootPanel;
						_ = container17.bounds;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1392 @ S0_v266 (Kiloo.Common.UI.Container)+30]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1448 @ S0_v268 (UIPanel)+D4]");
						float num124 = 0f * 0.5f;
						float num125 = num124;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1505 @ S0_v271 (UIPanel)+CC]");
						float num126 = num125 + 0f;
						float num127 = container17.height * 0.5f;
						float num128 = num126 - num127;
						float num129 = num128;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+EC]");
						float num130 = num129 - 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1392 @ S0_v266 (Kiloo.Common.UI.Container)+20]");
						float num131 = 0f - num130;
						_recycleBin.ScrapActiveContainers();
						_endDataIndexCursor = 0;
						AbstractListAdapter adapter28 = _adapter;
						nint num132 = (nint)adapter28;
						object obj67 = adapter28 + 48;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1635 @ S4_v42 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
						int modelType10 = default;
						Container scrapContainer8 = _recycleBin.GetScrapContainer(modelType10);
						nint num133 = (nint)adapter28;
						object obj68 = adapter28 + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1707 @ S4_v46 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+E4] (should have been resolved before IL gen)");
						Container container18 = default;
						container18.isMeasured = false;
						nint num134 = (nint)container18;
						object obj69 = container18 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1720 @ S2_v108 (Il2CppClass<Kiloo.Common.UI.Container>)+DC] (should have been resolved before IL gen)");
						container18.dataIndex = _topDataIndexCursor;
						UIPanel uIPanel28 = rootPanel;
						container18.bottom = container18.height;
						container18.coordinates = (Vector2)uIPanel28.mClipRange;
						container18.top = 0f;
						AbstractListAdapter adapter29 = _adapter;
						nint num135 = (nint)adapter29;
						object obj70 = adapter29 + 48;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1757 @ S3_v63 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
						int modelType11 = default;
						container18.modelType = modelType11;
						UIPanel uIPanel29 = rootPanel;
						Transform parent3 = uIPanel29.transform;
						container18.SetParent(parent3);
						nint num136 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1826 @ S1_v261 (Il2CppClass<UnityEngine.Vector3>)+5C]");
						nint num137 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1827 @ S1_v262 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
						_ = 0;
						_ = Vector3.oneVector;
						Vector3 scale3 = (Vector3)(obj + 32);
						container18.SetScale(scale3);
						_recycleBin.AddToActiveContainers(container18, endOfList: true);
						AbstractListAdapter adapter30 = _adapter;
						nint num138 = (nint)adapter30;
						object obj71 = adapter30 + 56;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1889 @ S3_v68 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+F4] (should have been resolved before IL gen)");
						long rowId3 = default;
						container18.rowId = rowId3;
						int topDataIndexCursor5 = _topDataIndexCursor - 1;
						_topDataIndexCursor = topDataIndexCursor5;
						int num139 = ++_endDataIndexCursor;
						object obj73 = default;
						int modelType12 = default;
						Container container20 = default;
						object obj77 = default;
						while (true)
						{
							AbstractListAdapter adapter31 = _adapter;
							nint num140 = (nint)adapter31;
							object obj72 = adapter31 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1936 @ S1_v280 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
							if ((nint)obj73 <= num139)
							{
								break;
							}
							RecycleBin recycleBin10 = _recycleBin;
							List<Container> activeContainers5 = recycleBin10.activeContainers;
							int index5 = activeContainers5._size - 1;
							Container container19 = activeContainers5.get_Item(index5);
							UIPanel uIPanel30 = rootPanel;
							float bottom5 = container19.bottom;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2029 @ S1_v308 (UIPanel)+D4]");
							if (!(bottom5 < 0f))
							{
								break;
							}
							AbstractListAdapter adapter32 = _adapter;
							nint num141 = (nint)adapter32;
							object obj74 = adapter32 + 48;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2082 @ S4_v57 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
							Container scrapContainer9 = _recycleBin.GetScrapContainer(modelType12);
							nint num142 = (nint)adapter32;
							object obj75 = adapter32 + 40;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2115 @ S4_v61 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+E4] (should have been resolved before IL gen)");
							if (container20 != null)
							{
								AppendContainer(_endDataIndexCursor, container20, setPosition: false);
							}
							AbstractListAdapter adapter33 = _adapter;
							nint num143 = (nint)adapter33;
							object obj76 = adapter33 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2150 @ S2_v137 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
							if (_endDataIndexCursor == (nint)obj77 && _infinite == Infinite.BothWays)
							{
								_endDataIndexCursor = 0;
							}
							num139 = _endDataIndexCursor;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ S1_v109+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+EC]");
						float num144 = 0f - num131;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
						obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
						_ = 0;
					}
				}
			}
			RecycleBin recycleBin11 = _recycleBin;
			Container firstVisibleContainer = recycleBin11.activeContainers.get_Item(0);
			_firstVisibleContainer = firstVisibleContainer;
			RecycleBin recycleBin12 = _recycleBin;
			List<Container> activeContainers6 = recycleBin12.activeContainers;
			int index6 = activeContainers6._size - 1;
			Container lastVisibleContainer = activeContainers6.get_Item(index6);
			_lastVisibleContainer = lastVisibleContainer;
			_refreshingContainers = false;
			_currentMaxListCount = _endDataIndexCursor;
			if (boundsCalculationMode == BoundsCalculationMode.Incremental)
			{
				CalculateVirtualRelativeWidgetBounds(BoundsCalculationMode.Incremental);
				object obj78;
				if (_arrangement == Arrangement.Horizontal)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ S1_v109+8]");
					_ = 0;
					Container firstVisibleContainerOnScreen = GetFirstVisibleContainerOnScreen();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
					float num145 = 0f + firstVisibleContainerOnScreen.left;
					obj78 = obj + 152;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
					object obj79 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+EC]");
					float num146 = 0f;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ S1_v109+8]");
					_ = 0;
					Container firstVisibleContainerOnScreen2 = GetFirstVisibleContainerOnScreen();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+EC]");
					float num147 = 0f - firstVisibleContainerOnScreen2.top;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
					_ = 0;
					obj78 = obj + 136;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
					object obj79 = 0;
					float num146 = num147;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1507 @ S0_v220+8]");
				_ = 0;
				obj = obj78;
				obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
			}
		}
		Action action = onPreLayout;
		if (onPreLayout != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v291.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		SetContainerPositions();
	}

	private void CheckScrollState()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d7: Expected F4, but got VT
		//IL_00ae: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		UIPanel uIPanel = rootPanel;
		if (!(uIPanel != null))
		{
			return;
		}
		Transform transform = rootPanelTransform;
		if (!(transform != null))
		{
			return;
		}
		_previousPos = _currentPos;
		Vector2 vector;
		if (_arrangement == Arrangement.Vertical)
		{
			Transform transform2 = rootPanelTransform;
			Vector3 localPosition = transform2.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			vector = (Vector2)0;
		}
		else
		{
			UIPanel uIPanel2 = rootPanel;
			vector = uIPanel2.mClipOffset;
		}
		_currentPos = (float)vector;
		float num = (_movementDelta = (float)vector - _previousPos);
		bool flag = (byte)(~(press ? 1u : 0u)) != 0;
		float num2 = num;
		if (!flag)
		{
			float cumulativeDelta = _cumulativeDelta + num;
			_cumulativeDelta = cumulativeDelta;
			num2 = _movementDelta;
		}
		ScrollDirection scrollDirection2;
		if (num2 < 0f)
		{
			ScrollDirection scrollDirection = ScrollDirection.Right;
			if (_arrangement == Arrangement.Vertical)
			{
				scrollDirection = ScrollDirection.Down;
			}
			scrollDirection2 = scrollDirection;
		}
		else if (num2 > 0f)
		{
			bool flag2 = _arrangement != Arrangement.Vertical;
			ScrollDirection scrollDirection3 = (ScrollDirection)((flag2 ? 1u : 0u) << 1);
			scrollDirection2 = scrollDirection3;
		}
		else
		{
			bool flag3 = num2 != 0f;
			scrollDirection2 = ScrollDirection.Stationary;
			if (flag3)
			{
				return;
			}
		}
		_scrollDirection = scrollDirection2;
	}

	private bool ShouldRecycleContainer(Container container)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b4: Expected Obj, but got I
		//IL_00c1: Invalid comparison between F4 and Obj
		//IL_0054: Invalid comparison between VT and F4
		//IL_01cf: Expected Obj, but got VT
		//IL_01f9: Expected Obj, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_022a: Invalid comparison between F4 and Obj
		//IL_012e: Expected Obj, but got VT
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_016f: Invalid comparison between F4 and Obj
		object obj2 = default;
		object obj = obj2 - 16;
		bool result;
		if (_arrangement == Arrangement.Horizontal)
		{
			UIPanel uIPanel = rootPanel;
			if (uIPanel.mClipOffset <= (object)container.right)
			{
				goto IL_00de;
			}
			result = true;
		}
		else
		{
			Transform transform = rootPanelTransform;
			Vector3 localPosition = transform.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj3 = (nint)0 + (nint)cellSpaceY;
			float bottom = container.bottom;
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)bottom) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
			result = true;
			if (!flag)
			{
				goto IL_00de;
			}
		}
		goto IL_0255;
		IL_0255:
		return result;
		IL_0247:
		result = false;
		goto IL_0255;
		IL_00de:
		if (_arrangement == Arrangement.Horizontal)
		{
			UIPanel uIPanel2 = rootPanel;
			UIPanel uIPanel3 = rootPanel;
			obj = container.bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [container @ L1 (Kiloo.Common.UI.Container)+30]");
			_ = 0;
			Vector2 mClipOffset = uIPanel2.mClipOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v32 (UIPanel)+D0]");
			object obj4 = mClipOffset + 0;
			object obj5 = obj4 - obj;
			float left = container.left;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)left) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
			{
				goto IL_0247;
			}
			result = true;
		}
		else
		{
			Transform transform2 = rootPanelTransform;
			Vector3 localPosition2 = transform2.localPosition;
			UIPanel uIPanel4 = rootPanel;
			obj = container.bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [container @ L1 (Kiloo.Common.UI.Container)+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v21 (UIPanel)+D4]");
			object obj6 = num + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj7 = obj6 - 0;
			object obj8 = obj7 + cellSpaceX;
			float top = container.top;
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)top) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
			result = true;
			if (!flag2)
			{
				goto IL_0247;
			}
		}
		goto IL_0255;
	}

	private bool ShouldAppendContainer(Container container)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0104: Invalid comparison between F4 and Obj
		//IL_007b: Expected Obj, but got I
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_0097: Invalid comparison between F4 and Obj
		object obj2 = default;
		object obj = obj2 - 16;
		bool result;
		if (_arrangement == Arrangement.Vertical)
		{
			Transform transform = rootPanelTransform;
			Vector3 localPosition = transform.localPosition;
			UIPanel uIPanel = rootPanel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v25 (UIPanel)+D4]");
			object obj3 = num + 0;
			object obj4 = obj3 - cellSpaceY;
			float bottom = container.bottom;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)bottom) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
			{
				goto IL_0121;
			}
			result = true;
		}
		else
		{
			UIPanel uIPanel2 = rootPanel;
			UIPanel uIPanel3 = rootPanel;
			Vector2 mClipOffset = uIPanel2.mClipOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v16 (UIPanel)+D0]");
			object obj5 = mClipOffset + 0;
			float right = container.right;
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)right) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
			result = true;
			if (!flag)
			{
				goto IL_0121;
			}
		}
		goto IL_012f;
		IL_012f:
		return result;
		IL_0121:
		result = false;
		goto IL_012f;
	}

	private bool ShouldPrependContainer(Container container)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c1: Invalid comparison between VT and F4
		//IL_006b: Expected Obj, but got I
		//IL_0078: Invalid comparison between F4 and Obj
		object obj2 = default;
		object obj = obj2 - 16;
		bool result;
		if (_arrangement == Arrangement.Vertical)
		{
			Transform transform = rootPanelTransform;
			Vector3 localPosition = transform.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj3 = (nint)0 + (nint)cellSpaceY;
			float top = container.top;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)top) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				goto IL_00de;
			}
			result = true;
		}
		else
		{
			UIPanel uIPanel = rootPanel;
			bool flag = uIPanel.mClipOffset < (object)container.left;
			result = true;
			if (!flag)
			{
				goto IL_00de;
			}
		}
		goto IL_00ec;
		IL_00ec:
		return result;
		IL_00de:
		result = false;
		goto IL_00ec;
	}

	private unsafe void HandleScrollDown()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected VT, but got Unknown
		//IL_00d3: Expected Obj, but got I4
		//IL_05f3: Expected I, but got Obj
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected Obj, but got Unknown
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected I4, but got Unknown
		//IL_02a2: Expected I, but got Obj
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_02d5: Expected I, but got Obj
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected Obj, but got Unknown
		//IL_0375: Expected Ref, but got VT
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected VT, but got Unknown
		//IL_057b: Expected Ref, but got VT
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected Obj, but got Unknown
		//IL_090b: Expected VT, but got Obj
		//IL_0906: Expected native int or pointer, but got VT
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected VT, but got Unknown
		//IL_0488: Expected Ref, but got VT
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 128;
		RecycleBin recycleBin = _recycleBin;
		if (_recycleBin == null)
		{
			return;
		}
		List<Container> activeContainers = recycleBin.activeContainers;
		if (activeContainers._size < 1)
		{
			return;
		}
		while (true)
		{
			RecycleBin recycleBin2 = _recycleBin;
			List<Container> activeContainers2 = recycleBin2.activeContainers;
			int index = activeContainers2._size - 1;
			Container container = activeContainers2.get_Item(index);
			if (!ShouldRecycleContainer(container))
			{
				break;
			}
			RecycleBin recycleBin3 = _recycleBin;
			List<Container> activeContainers3 = recycleBin3.activeContainers;
			object obj3 = activeContainers3._size - 1;
			if ((nint)obj3 <= 0)
			{
				break;
			}
			RecycleBin recycleBin4 = _recycleBin;
			List<Container> activeContainers4 = recycleBin4.activeContainers;
			int index2 = activeContainers4._size - 1;
			Container container2 = activeContainers4.get_Item(index2);
			_endDataIndexCursor = container2.dataIndex;
			RecycleBin recycleBin5 = _recycleBin;
			List<Container> activeContainers5 = recycleBin5.activeContainers;
			int position = activeContainers5._size - 1;
			Container activeContainer = recycleBin5.GetActiveContainer(position);
			Action onRecycleContainer = activeContainer.onRecycleContainer;
			if (activeContainer.onRecycleContainer != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v213.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			_recycleBin.AddScrapContainer(activeContainer);
			RecycleBin recycleBin6 = _recycleBin;
			List<Container> activeContainers6 = recycleBin6.activeContainers;
			if (activeContainers6._size >= 1)
			{
				RecycleBin recycleBin7 = _recycleBin;
				List<Container> activeContainers7 = recycleBin7.activeContainers;
				int index3 = activeContainers7._size - 1;
				Container bottomActiveContainer = activeContainers7.get_Item(index3);
				_bottomActiveContainer = bottomActiveContainer;
				Container bottomActiveContainer2 = _bottomActiveContainer;
				_nextAppendPosition = bottomActiveContainer2.coordinates;
			}
		}
		Bounds bounds = (Bounds)(this + 84);
		int modelType = default;
		Container container5 = default;
		while (true)
		{
			RecycleBin recycleBin8 = _recycleBin;
			Container container3 = recycleBin8.activeContainers.get_Item(0);
			if (!ShouldPrependContainer(container3) || _topDataIndexCursor < 0)
			{
				break;
			}
			RecycleBin recycleBin9 = _recycleBin;
			Container container4 = recycleBin9.activeContainers.get_Item(0);
			if (container4.modelType == -100)
			{
				break;
			}
			AbstractListAdapter adapter = _adapter;
			nint num = (nint)adapter;
			object obj4 = adapter + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v301 @ S4_v4 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
			Container scrapContainer = _recycleBin.GetScrapContainer(modelType);
			nint num2 = (nint)adapter;
			object obj5 = adapter + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v314 @ S4_v8 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+E4] (should have been resolved before IL gen)");
			if (container5 == null)
			{
				continue;
			}
			PrependContainer(_topDataIndexCursor, container5, setPosition: true);
			if (_currentMinListCount <= _topDataIndexCursor)
			{
				continue;
			}
			if (boundsCalculationMode == BoundsCalculationMode.Incremental)
			{
				Vector3 size = ((Bounds*)bounds)->size;
				_ = bounds.m_Center;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v25 (UnityEngine.Bounds)+8]");
				_ = 0;
				object obj6;
				if (_arrangement == Arrangement.Vertical)
				{
					float num3 = container5.height + (float)cellSpaceY;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+74]");
					float num4 = 0f + num3;
					float num5 = container5.height * 0.5f;
					float num6 = (float)cellSpaceY * 0.5f;
					float num7 = num5 + num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+74]");
					float num8 = 0f + num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
					_ = 0;
					Vector3 size2 = (Vector3)(obj + 16);
					((Bounds*)bounds)->size = size2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
					_ = 0;
					obj6 = obj + 80;
				}
				else
				{
					float num9 = container5.width + (float)cellSpaceX;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
					float num10 = 0f + num9;
					float num11 = container5.width * 0.5f;
					float num12 = (float)cellSpaceX * 0.5f;
					float num13 = num11 + num12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
					float num14 = 0f - num13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+74]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
					_ = 0;
					Vector3 size3 = (Vector3)(obj + 32);
					((Bounds*)bounds)->size = size3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+74]");
					_ = 0;
					obj6 = obj + 48;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ S0_v123+8]");
				_ = 0;
				obj = obj6;
				((Bounds*)(nint)bounds)->m_Center = (Vector3)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
			}
			_currentMinListCount = _topDataIndexCursor;
		}
		if (_infinite == Infinite.BothWays && _topDataIndexCursor <= -1)
		{
			AbstractListAdapter adapter2 = _adapter;
			nint num15 = (nint)adapter2;
			object obj7 = adapter2 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v282 @ S2_v24 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
			object obj8 = default;
			int topDataIndexCursor = obj8 - 1;
			_topDataIndexCursor = topDataIndexCursor;
		}
		if (~(pullDownToRefreshList ? 1u : 0u) == 0 && _pullDownToRefreshState == PullDownToRefreshState.PullDown && _topDataIndexCursor == -1 && !_refreshingContainerAdded)
		{
			CreatePullDownToRefreshContainer();
			Container firstVisibleContainerOnScreen = GetFirstVisibleContainerOnScreen();
			Container container6 = pullDownToRefreshContainer;
			Container firstVisibleContainerOnScreen2 = GetFirstVisibleContainerOnScreen();
			Container container7 = pullDownToRefreshContainer;
			_ = container7.bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S1_v27 (Kiloo.Common.UI.Container)+30]");
			_ = 0;
			float num16 = container6.height * 0.5f;
			float num17 = firstVisibleContainerOnScreen2.height * 0.5f;
			float num18 = num16 + num17;
			float num19 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+74]");
			float num20 = num19 - 0f;
			float num21 = num18 + num20;
			Container firstVisibleContainerOnScreen3 = GetFirstVisibleContainerOnScreen();
			_ = firstVisibleContainerOnScreen3.bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S1_v37 (Kiloo.Common.UI.Container)+30]");
			_ = 0;
			float num22 = num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+74]");
			float num23 = num22 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S0_v48 (Kiloo.Common.UI.Container)+20]");
			float num24 = 0f + num23;
			Container container8 = pullDownToRefreshContainer;
			container8.coordinates = firstVisibleContainerOnScreen.coordinates;
			Container container9 = pullDownToRefreshContainer;
			Container firstVisibleContainerOnScreen4 = GetFirstVisibleContainerOnScreen();
			container9.bottom = firstVisibleContainerOnScreen4.top;
			Container container10 = pullDownToRefreshContainer;
			float top = container10.bottom - container10.height;
			container10.top = top;
			pullDownToRefreshContainer.SetPosition();
			_refreshingContainerAdded = true;
		}
	}

	private unsafe void HandleScrollUp()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected VT, but got Unknown
		//IL_00b9: Expected Obj, but got I4
		//IL_0738: Expected I, but got Obj
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Expected Obj, but got Unknown
		//IL_01cb: Expected I, but got Obj
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_0216: Expected I, but got Obj
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_0249: Expected I, but got Obj
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_02e9: Expected Ref, but got VT
		//IL_0316: Expected I, but got Obj
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected Obj, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Expected VT, but got Unknown
		//IL_0701: Expected Ref, but got VT
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Expected Obj, but got Unknown
		//IL_08b7: Expected VT, but got Obj
		//IL_08b2: Expected native int or pointer, but got VT
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected VT, but got Unknown
		//IL_0640: Expected Ref, but got VT
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected Obj, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected VT, but got Unknown
		//IL_0521: Expected Ref, but got VT
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected Obj, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected VT, but got Unknown
		//IL_0460: Expected Ref, but got VT
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 224;
		RecycleBin recycleBin = _recycleBin;
		if (_recycleBin == null)
		{
			return;
		}
		List<Container> activeContainers = recycleBin.activeContainers;
		if (activeContainers._size < 1)
		{
			return;
		}
		while (true)
		{
			RecycleBin recycleBin2 = _recycleBin;
			Container container = recycleBin2.activeContainers.get_Item(0);
			if (!ShouldRecycleContainer(container))
			{
				break;
			}
			RecycleBin recycleBin3 = _recycleBin;
			List<Container> activeContainers2 = recycleBin3.activeContainers;
			object obj3 = activeContainers2._size - 1;
			if ((nint)obj3 <= 0)
			{
				break;
			}
			RecycleBin recycleBin4 = _recycleBin;
			Container container2 = recycleBin4.activeContainers.get_Item(0);
			_topDataIndexCursor = container2.dataIndex;
			Container activeContainer = _recycleBin.GetActiveContainer(0);
			Action onRecycleContainer = activeContainer.onRecycleContainer;
			if (activeContainer.onRecycleContainer != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v210.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			_recycleBin.AddScrapContainer(activeContainer);
			RecycleBin recycleBin5 = _recycleBin;
			List<Container> activeContainers3 = recycleBin5.activeContainers;
			if (activeContainers3._size < 1)
			{
				break;
			}
			RecycleBin recycleBin6 = _recycleBin;
			Container topActiveContainer = recycleBin6.activeContainers.get_Item(0);
			_topActiveContainer = topActiveContainer;
			Container topActiveContainer2 = _topActiveContainer;
			_nextPrependPosition = topActiveContainer2.coordinates;
		}
		Bounds bounds = (Bounds)(this + 84);
		object obj5 = default;
		int modelType = default;
		Container container4 = default;
		object obj10 = default;
		while (true)
		{
			RecycleBin recycleBin7 = _recycleBin;
			List<Container> activeContainers4 = recycleBin7.activeContainers;
			int index = activeContainers4._size - 1;
			Container container3 = activeContainers4.get_Item(index);
			if (!ShouldAppendContainer(container3))
			{
				break;
			}
			AbstractListAdapter adapter = _adapter;
			nint num = (nint)adapter;
			object obj4 = adapter + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v231 @ S2_v19 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
			if (_endDataIndexCursor >= (nint)obj5)
			{
				break;
			}
			AbstractListAdapter adapter2 = _adapter;
			nint num2 = (nint)adapter2;
			object obj6 = adapter2 + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v269 @ S4_v4 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
			Container scrapContainer = _recycleBin.GetScrapContainer(modelType);
			nint num3 = (nint)adapter2;
			object obj7 = adapter2 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v288 @ S4_v8 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+E4] (should have been resolved before IL gen)");
			if (container4 == null)
			{
				continue;
			}
			AppendContainer(_endDataIndexCursor, container4, setPosition: true);
			if (_currentMaxListCount >= _endDataIndexCursor)
			{
				continue;
			}
			if (boundsCalculationMode == BoundsCalculationMode.Incremental)
			{
				Vector3 size = ((Bounds*)bounds)->size;
				_ = bounds.m_Center;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v25 (UnityEngine.Bounds)+8]");
				_ = 0;
				AbstractListAdapter adapter3 = _adapter;
				nint num4 = (nint)adapter3;
				object obj8 = adapter3 + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v362 @ S1_v45 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
				object obj9 = obj10 - 1;
				object obj11;
				if (_arrangement == Arrangement.Vertical)
				{
					if ((nint)obj9 >= _endDataIndexCursor)
					{
						float num5 = container4.height + (float)cellSpaceY;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D4]");
						float num6 = 0f + num5;
						float num7 = container4.height * 0.5f;
						float num8 = (float)cellSpaceY * 0.5f;
						float num9 = num7 + num8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D4]");
						float num10 = 0f - num9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
						_ = 0;
						Vector3 size2 = (Vector3)(obj + 32);
						((Bounds*)bounds)->size = size2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
						_ = 0;
						obj11 = obj + 176;
					}
					else
					{
						float num11 = container4.height * 0.5f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D4]");
						float num12 = 0f - num11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D4]");
						float num13 = 0f + container4.height;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
						_ = 0;
						Vector3 size3 = (Vector3)(obj + 16);
						((Bounds*)bounds)->size = size3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
						_ = 0;
						obj11 = obj + 144;
					}
				}
				else if ((nint)obj9 >= _endDataIndexCursor)
				{
					float num14 = container4.width + (float)cellSpaceX;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
					float num15 = 0f + num14;
					float num16 = container4.width * 0.5f;
					float num17 = (float)cellSpaceX * 0.5f;
					float num18 = num16 + num17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
					float num19 = 0f + num18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D4]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
					_ = 0;
					Vector3 size4 = (Vector3)(obj - -64);
					((Bounds*)bounds)->size = size4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D4]");
					_ = 0;
					obj11 = obj + 112;
				}
				else
				{
					float num20 = container4.width * 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
					float num21 = 0f + num20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D4]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
					float num22 = 0f + container4.width;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
					_ = 0;
					Vector3 size5 = (Vector3)(obj + 48);
					((Bounds*)bounds)->size = size5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D4]");
					_ = 0;
					obj11 = obj + 80;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ S0_v80+8]");
				_ = 0;
				obj = obj11;
				((Bounds*)(nint)bounds)->m_Center = (Vector3)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
			}
			_currentMaxListCount = _endDataIndexCursor;
		}
		AbstractListAdapter adapter4 = _adapter;
		nint num23 = (nint)adapter4;
		object obj12 = adapter4 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v250 @ S2_v15 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
		object obj13 = default;
		if (_endDataIndexCursor == (nint)obj13 && _infinite == Infinite.BothWays)
		{
			_endDataIndexCursor = 0;
		}
	}

	private unsafe void CalculateVirtualRelativeWidgetBounds(BoundsCalculationMode mode)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da5: Expected Obj, but got Unknown
		//IL_0db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbd: Expected Obj, but got Unknown
		//IL_108e: Expected I, but got Obj
		//IL_11ef: Expected I, but got Obj
		//IL_125a: Unknown result type (might be due to invalid IL or missing references)
		//IL_125f: Expected VT, but got Unknown
		//IL_1268: Unknown result type (might be due to invalid IL or missing references)
		//IL_126d: Expected VT, but got Unknown
		//IL_1276: Unknown result type (might be due to invalid IL or missing references)
		//IL_127b: Expected VT, but got Unknown
		//IL_1287: Expected native int or pointer, but got VT
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected I, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected I, but got Unknown
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0836: Expected Obj, but got Unknown
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Expected Obj, but got Unknown
		//IL_0d4d: Expected VT, but got I
		//IL_0ee7: Expected I, but got Obj
		//IL_111d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1122: Expected Obj, but got Unknown
		//IL_073e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected Obj, but got Unknown
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Expected Obj, but got Unknown
		//IL_10c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ca: Expected Obj, but got Unknown
		//IL_00c4: Expected I, but got Obj
		//IL_00e9: Expected I, but got Obj
		//IL_0105: Expected I, but got Obj
		//IL_0124: Expected I, but got Obj
		//IL_06ef: Expected F4, but got I
		//IL_1049: Unknown result type (might be due to invalid IL or missing references)
		//IL_104e: Expected VT, but got Unknown
		//IL_1057: Unknown result type (might be due to invalid IL or missing references)
		//IL_105c: Expected VT, but got Unknown
		//IL_1065: Unknown result type (might be due to invalid IL or missing references)
		//IL_106a: Expected VT, but got Unknown
		//IL_1076: Expected native int or pointer, but got VT
		//IL_06b8: Expected F4, but got I
		//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Expected Obj, but got Unknown
		//IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae8: Expected Obj, but got Unknown
		//IL_0b22: Expected Obj, but got I
		//IL_08b8: Expected Obj, but got I
		//IL_0bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdc: Expected Obj, but got Unknown
		//IL_0f3a: Expected F4, but got I
		//IL_0f4c: Expected F4, but got I
		//IL_043a: Expected F4, but got I
		//IL_0442: Expected VT, but got F4
		//IL_0df2: Expected I, but got Obj
		//IL_0e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e23: Expected VT, but got Unknown
		//IL_0cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccc: Expected Obj, but got Unknown
		//IL_0d03: Expected Obj, but got I
		//IL_07c5: Expected Obj, but got I
		//IL_0f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f83: Expected Obj, but got Unknown
		//IL_0f93: Expected Obj, but got I
		//IL_0fbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected VT, but got Unknown
		//IL_0fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcf: Expected VT, but got Unknown
		//IL_0fd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdd: Expected VT, but got Unknown
		//IL_0fe9: Expected native int or pointer, but got VT
		//IL_11aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_11af: Expected VT, but got Unknown
		//IL_11b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bd: Expected VT, but got Unknown
		//IL_11c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cb: Expected VT, but got Unknown
		//IL_11d7: Expected native int or pointer, but got VT
		//IL_08fa: Expected Obj, but got I
		//IL_0e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e68: Expected VT, but got Unknown
		//IL_0e71: Expected Ref, but got VT
		//IL_0ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea9: Expected Obj, but got Unknown
		//IL_0807: Expected Obj, but got I
		//IL_02a4: Expected I, but got Obj
		//IL_01bf: Expected I, but got Obj
		//IL_05d1: Expected Obj, but got I
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_0ebe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Expected Obj, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 256;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		object obj4 = obj + 224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		float num2 = default;
		object obj13;
		ScrollView scrollView;
		if (mode != BoundsCalculationMode.FullSize)
		{
			if (mode == BoundsCalculationMode.Incremental)
			{
				RecycleBin recycleBin = _recycleBin;
				if (_arrangement == Arrangement.Vertical)
				{
					object obj5 = obj + 184;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
					_ = 0;
					object obj6 = obj + 208;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
					_ = 0;
					object obj8 = default;
					while (true)
					{
						_ = 0;
						object obj7 = obj + 208;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							break;
						}
						if (obj8 != null)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+DC]");
							object obj9 = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ S0_v394+48]");
							object obj10 = (nint)0 + (nint)cellSpaceY;
							float num = num2 + (float)obj10;
							num2 = num;
							continue;
						}
						goto IL_0bce;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					object obj11 = default;
					object obj12 = default;
					bool flag = obj11 != obj12;
					object obj14 = default;
					obj13 = obj14;
					if (!flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							goto IL_0bce;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						object obj15 = default;
						obj13 = obj15;
					}
					_ = 0;
					object obj16 = obj + 184;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 == 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					scrollView = (ScrollView)0;
					if (!flag2)
					{
						goto IL_0d11;
					}
					goto IL_0d4e;
				}
				object obj17 = obj + 184;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
				_ = 0;
				object obj18 = obj + 208;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
				_ = 0;
				object obj20 = default;
				while (true)
				{
					_ = 0;
					object obj19 = obj + 208;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						break;
					}
					if (obj20 == null)
					{
						goto IL_09fd;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+DC]");
					object obj21 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ S0_v324+4C]");
						object obj22 = (nint)0 + (nint)cellSpaceX;
						float num3 = num2 + (float)obj22;
						num2 = num3;
						continue;
					}
					goto IL_10ff;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_096e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ArgumentOutOfRangeException ex = default;
			ex._002Ector("mode");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			scrollView = (ScrollView)(object)ex;
			goto IL_10ff;
		}
		if (_recycleBin != null)
		{
			if (_infinite != Infinite.None)
			{
				if (_infinite != Infinite.BothWays)
				{
					goto IL_1080;
				}
				UIPanel uIPanel = rootPanel;
				if (_arrangement == Arrangement.Vertical)
				{
					UIPanel uIPanel2 = rootPanel;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S0_v236 (UIPanel)+D4]");
					float num4 = 0f * 3f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v211 (UIPanel)+D0]");
					float num5 = 0f;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v211 (UIPanel)+D0]");
					float num6 = 0f * 3f;
					UIPanel uIPanel3 = rootPanel;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v233 (UIPanel)+D4]");
					float num4 = 0f;
					float num5 = num6;
				}
				_ = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
				_ = 0;
				_ = 0;
				Bounds bounds = (Bounds)(obj + 184);
				Vector3 center = (Vector3)(obj + 104);
				Vector3 size = (Vector3)(obj + 88);
				*(Bounds*)(nint)bounds = new Bounds(center, size);
			}
			else
			{
				nint num7 = (nint)(this + 28);
				nint num8 = (nint)(this + 24);
				object obj23 = default;
				object obj24 = default;
				int modelType = default;
				Container container = default;
				int modelType2 = default;
				float num18 = default;
				object obj25 = default;
				float num22 = default;
				object obj28 = default;
				object obj31 = default;
				object obj32 = default;
				object obj33 = default;
				while (true)
				{
					AbstractListAdapter adapter = _adapter;
					nint num9 = (nint)adapter;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v189 @ S1_v52 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24))
					{
						break;
					}
					AbstractListAdapter adapter2 = _adapter;
					nint num10 = (nint)adapter2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v300 @ S4_v4 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
					Container scrapContainer = _recycleBin.GetScrapContainer(modelType);
					nint num11 = (nint)adapter2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v345 @ S4_v7 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+E4] (should have been resolved before IL gen)");
					AbstractListAdapter adapter3 = _adapter;
					nint num12 = (nint)adapter3;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v355 @ S3_v11 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+EC] (should have been resolved before IL gen)");
					container.modelType = modelType2;
					nint num13 = (nint)container;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v363 @ S2_v28 (Il2CppClass<Kiloo.Common.UI.Container>)+DC] (should have been resolved before IL gen)");
					UIPanel uIPanel4 = rootPanel;
					Transform parent = uIPanel4.transform;
					container.SetParent(parent);
					nint num14 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ S1_v149 (Il2CppClass<UnityEngine.Vector3>)+5C]");
					nint num15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ S1_v150 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
					_ = 0;
					_ = Vector3.oneVector;
					Vector3 scale = (Vector3)(obj + 40);
					container.SetScale(scale);
					object obj27;
					IntPtr intPtr;
					if (_arrangement == Arrangement.Horizontal)
					{
						float num16 = container.width + (float)cellSpaceX;
						float num17 = num18 + num16;
						bool flag3 = _topDataIndexCursor < 1;
						num18 = num17;
						if (flag3)
						{
							goto IL_0e5a;
						}
						AbstractListAdapter adapter4 = _adapter;
						nint num19 = (nint)adapter4;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v967 @ S1_v184 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
						bool flag4 = (nint)obj25 <= _topDataIndexCursor;
						num18 = num17;
						if (flag4)
						{
							goto IL_0e5a;
						}
						bool flag5 = _topDataIndexCursor <= (nint)obj24;
						num18 = num17;
						if (flag5)
						{
							goto IL_0e5a;
						}
						object obj26 = container + 76;
						num18 = num17;
						obj27 = obj26;
						intPtr = num7;
					}
					else
					{
						float num20 = container.height + (float)cellSpaceY;
						float num21 = num22 + num20;
						bool flag6 = _topDataIndexCursor < 0;
						num22 = num21;
						if (flag6)
						{
							goto IL_0e5a;
						}
						AbstractListAdapter adapter5 = _adapter;
						nint num23 = (nint)adapter5;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1005 @ S1_v174 (Il2CppClass<Kiloo.Common.UI.AbstractListAdapter>)+DC] (should have been resolved before IL gen)");
						bool flag7 = (nint)obj28 <= _topDataIndexCursor;
						num22 = num21;
						if (flag7)
						{
							goto IL_0e5a;
						}
						bool flag8 = _topDataIndexCursor <= (nint)obj24;
						num22 = num21;
						if (flag8)
						{
							goto IL_0e5a;
						}
						object obj29 = container + 72;
						num22 = num21;
						obj27 = obj29;
						intPtr = num8;
					}
					object obj30 = obj27 + (nint)intPtr;
					obj31 = obj32 + obj30;
					goto IL_0e5a;
					IL_0e5a:
					Bounds bounds2 = (Bounds)(container + 40);
					Vector3 size2 = ((Bounds*)bounds2)->size;
					float num24 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
					float num25 = num24 + 0f;
					_recycleBin.AddScrapContainer(container);
					obj24 = obj33 + 1;
					num2 = num25;
				}
				if (_arrangement == Arrangement.Horizontal)
				{
					float num26 = num18 - (float)cellSpaceX;
					UIPanel uIPanel5 = rootPanel;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ S0_v135 (UIPanel)+D4]");
					_ = 0;
					float num27 = num18 * 0.5f;
					UIPanel uIPanel6 = rootPanel;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S1_v126 (UIPanel)+D0]");
					float num28 = 0f * 0.5f;
					float num29 = num27 - num28;
					float num30 = num29 - (float)obj31;
					UIPanel uIPanel7 = rootPanel;
					float num31 = num30 + (float)uIPanel7.mClipRange;
					float num32 = (float)cellSpaceX * 0.5f;
					float num33 = num31 - num32;
					UIPanel uIPanel8 = rootPanel;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ S0_v147 (UIPanel)+CC]");
					float num34 = 0f;
					Vector4 vector = (Vector4)num33;
				}
				else
				{
					UIPanel uIPanel9 = rootPanel;
					float num35 = num22 - (float)cellSpaceY;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S0_v115 (UIPanel)+D0]");
					_ = 0;
					UIPanel uIPanel10 = rootPanel;
					float num36 = 0f - num22;
					float num37 = num36 * 0.5f;
					UIPanel uIPanel11 = rootPanel;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S1_v108 (UIPanel)+D4]");
					float num38 = 0f * 0.5f;
					float num39 = num37 + num38;
					float num40 = num39 + (float)obj31;
					float num41 = (float)cellSpaceY * 0.5f;
					float num42 = num40 + num41;
					UIPanel uIPanel12 = rootPanel;
					float num43 = num42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ S1_v116 (UIPanel)+CC]");
					float num34 = num43 + 0f;
					Vector4 vector = uIPanel10.mClipRange;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F4]");
				scrollViewHeight = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
				scrollViewWidth = 0f;
				if (_arrangement == Arrangement.Vertical && ~(pullDownToRefreshList ? 1u : 0u) == 0)
				{
					UIPanel uIPanel13 = rootPanel;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F4]");
					nint num44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ S1_v81 (UIPanel)+D4]");
					if (num44 < 0)
					{
						UIPanel uIPanel14 = rootPanel;
						UIPanel uIPanel15 = rootPanel;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1066 @ S0_v98 (UIPanel)+D4]");
						nint num45 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1066 @ S0_v98 (UIPanel)+D4]");
						object obj34 = num45 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ S0_v95 (UIPanel)+D0]");
						_ = 0;
						UIPanel uIPanel16 = rootPanel;
						UIPanel uIPanel17 = rootPanel;
						float num46 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1083 @ S1_v91 (UIPanel)+D4]");
						float num47 = num46 - 0f;
						float num48 = num47 * 0.5f;
						float num49 = num48 + (float)obj31;
						_ = 0;
						_ = uIPanel16.mClipRange;
					}
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
				_ = 0;
				object obj35 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
				obj35 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
				_ = 0;
				Bounds bounds3 = (Bounds)(obj + 184);
				Vector3 center2 = (Vector3)(obj + 72);
				Vector3 size3 = (Vector3)(obj + 56);
				*(Bounds*)(nint)bounds3 = new Bounds(center2, size3);
			}
			goto IL_0d21;
		}
		goto IL_1080;
		IL_09fd:
		object obj36 = obj + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @121D");
		UIPanel uIPanel18 = rootPanel;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ S0_v265 (UIPanel)+D4]");
		_ = 0;
		float num50 = num2 * 0.5f;
		UIPanel uIPanel19 = rootPanel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ S2_v63 (UIPanel)+D0]");
		float num51 = 0f * 0.5f;
		float num52 = num50 - num51;
		UIPanel uIPanel20 = rootPanel;
		float num53 = num52 + (float)uIPanel20.mClipRange;
		num2 = 0f;
		goto IL_1157;
		IL_1080:
		nint num54 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v23 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v24 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_ = Vector3.zeroVector;
		nint num56 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v30 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S1_v31 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S1_v31 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_ = Vector3.zeroVector;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		_ = Vector3.zeroVector;
		_ = 0;
		Bounds bounds4 = (Bounds)(obj + 184);
		Vector3 center3 = (Vector3)(obj + 24);
		Vector3 size4 = (Vector3)(obj + 8);
		*(Bounds*)(nint)bounds4 = new Bounds(center3, size4);
		goto IL_0d21;
		IL_0d4e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		return;
		IL_0d11:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_1157;
		IL_10ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_096e;
		IL_1157:
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E0]");
		_ = 0;
		_ = 0;
		Bounds bounds5 = (Bounds)(obj + 184);
		Vector3 center4 = (Vector3)(obj + 136);
		Vector3 size5 = (Vector3)(obj + 120);
		*(Bounds*)(nint)bounds5 = new Bounds(center4, size5);
		goto IL_0d21;
		IL_0bce:
		object obj37 = obj + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @121D");
		UIPanel uIPanel21 = rootPanel;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ S0_v353 (UIPanel)+D0]");
		_ = 0;
		float num58 = 0f - num2;
		float num59 = num58 * 0.5f;
		UIPanel uIPanel22 = rootPanel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ S1_v305 (UIPanel)+D4]");
		float num60 = 0f * 0.5f;
		float num61 = num59 + num60;
		UIPanel uIPanel23 = rootPanel;
		float num62 = num61;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ S1_v309 (UIPanel)+CC]");
		float num63 = num62 + 0f;
		_ = 0;
		num2 = num63;
		goto IL_1157;
		IL_096e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj38 = default;
		object obj39 = default;
		bool flag9 = obj38 != obj39;
		object obj40 = default;
		obj13 = obj40;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_09fd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj41 = default;
			obj13 = obj41;
		}
		_ = 0;
		object obj42 = obj + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag10 = (nint)0 != 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		scrollView = (ScrollView)0;
		if (flag10)
		{
			goto IL_0d11;
		}
		goto IL_0d4e;
		IL_0d21:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
		_mListViewBounds = (Bounds)0;
	}

	public Container GetFirstVisibleContainerOnScreen()
	{
		RecycleBin recycleBin = _recycleBin;
		List<Container> activeContainers = recycleBin.activeContainers;
		if (activeContainers._size >= 1)
		{
			RecycleBin recycleBin2 = _recycleBin;
			Container firstVisibleContainer = recycleBin2.activeContainers.get_Item(0);
			_firstVisibleContainer = firstVisibleContainer;
		}
		return _firstVisibleContainer;
	}

	public Container GetLastVisibleContainerOnScreen()
	{
		RecycleBin recycleBin = _recycleBin;
		List<Container> activeContainers = recycleBin.activeContainers;
		if (activeContainers._size >= 1)
		{
			RecycleBin recycleBin2 = _recycleBin;
			List<Container> activeContainers2 = recycleBin2.activeContainers;
			int index = activeContainers2._size - 1;
			Container lastVisibleContainer = activeContainers2.get_Item(index);
			_lastVisibleContainer = lastVisibleContainer;
		}
		return _lastVisibleContainer;
	}

	public List<Container> GetActiveContainers()
	{
		RecycleBin recycleBin = _recycleBin;
		return recycleBin.activeContainers;
	}

	public static void Log(string msg)
	{
	}
}
