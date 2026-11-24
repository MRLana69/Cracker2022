using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.JsonUtil;
using Kiloo.Common.UI;
using SYBO.Subway.Info;
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
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a2: Expected Obj, but got I4
			//IL_00a6: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (Container)((ComputeShader)position).FindKernel((string)(object)activeContainers);
		}

		public unsafe void AddToActiveContainers(Container container, bool endOfList)
		{
			//IL_000f: Expected Obj, but got I4
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected Obj, but got Unknown
			activeContainers = (List<Container>)((bool*)(endOfList ? 1 : 0))->m_value;
			object obj = this + 16;
			obj = container;
		}

		public void AddScrapContainer(Container container)
		{
			activeContainers = (List<Container>)(object)container;
		}

		public void Clear()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		public Container GetScrapContainer(int modelType)
		{
			if (modelType > -1)
			{
				List<Container> list = activeContainers;
				if (list._size > modelType)
				{
					Container container = activeContainers.get_Item(modelType);
					if (container != null)
					{
						activeContainers.RemoveAt(modelType);
						return container;
					}
					return null;
				}
				return null;
			}
			return null;
		}

		public void ScrapActiveContainers()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_078a: Unknown result type (might be due to invalid IL or missing references)
			//IL_078f: Expected Obj, but got Unknown
			//IL_0798: Expected Obj, but got I4
			//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ac: Expected Obj, but got Unknown
			//IL_07b5: Expected Obj, but got I4
			//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c9: Expected Obj, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I4
			//IL_00a4: Expected Obj, but got I4
			//IL_0157: Expected Obj, but got I
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Expected Obj, but got Unknown
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Expected Obj, but got Unknown
			Dictionary<, >.ValueCollection valueCollection = default;
			object obj = valueCollection - -64;
			object obj2 = valueCollection + 40;
			obj2 = 0;
			_ = 0;
			object obj3 = valueCollection + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = valueCollection + 16;
			obj4 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj2 = valueCollection;
			_ = valueCollection.dictionary;
			object obj5 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			object obj6 = obj4 + 4;
			object obj7 = obj6 + 1;
			obj6 = obj7;
			object obj8 = obj7 << 2;
			object obj9 = obj4 + obj8;
			obj9 = 54;
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj11 = (nint)0 << 2;
				object obj12 = obj4 + obj11;
				if ((nint)obj12 == 54)
				{
					object obj13 = obj4 + 4;
					if ((nint)obj13 > -1)
					{
						object obj14 = obj13 + -1;
						obj13 = obj14;
					}
					goto IL_084b;
				}
			}
			if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_084b;
			IL_084b:
			throw new IndexOutOfRangeException();
		}

		public static void Log(string msg)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Expected Obj, but got Unknown
			//IL_0208: Expected Obj, but got I4
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Expected Obj, but got Unknown
			//IL_0246: Expected VT, but got I4
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<> list = default;
			((List<T>)(object)list).Add((T)msg.m_stringLength);
			throw new IndexOutOfRangeException();
		}
	}

	private sealed class _003C_003Ec__DisplayClass83_0
	{
		public int dataIndex;

		public _003C_003Ec__DisplayClass83_0()
		{
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected Obj, but got Unknown
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected Obj, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<Container> list = default;
			list._002Ector();
			object obj = this + 8;
			obj = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v2 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S3_v3+60]");
			object obj3 = (object)((object)0 & 0x1FFF) + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v39 @ S4_v4 (should have been resolved before IL gen)");
			object obj4 = this + 12;
			object obj5 = default;
			obj4 = obj5;
		}

		internal bool _003CSmoothScrollToIndex_003Eb__0(Container item)
		{
			//IL_01b6: Expected Obj, but got I
			//IL_01d3: Expected Obj, but got I
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003b: Expected Obj, but got I
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected Obj, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected Obj, but got Unknown
			//IL_012b: Expected I4, but got Obj
			//IL_012b: Expected Obj, but got I
			//IL_0208: Expected I4, but got Obj
			//IL_00c2: Expected Obj, but got I
			//IL_00d2: Expected Obj, but got I
			//IL_00e2: Expected Obj, but got I
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected Obj, but got Unknown
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView+<>c__DisplayClass83_0)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8+1C]");
			object obj2 = num - 0;
			if ((nint)obj2 > 0)
			{
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S2_v3 (Il2CppMethodInfo)+C]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S2_v4+60]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v5+44]");
				object obj5 = 0;
				object obj6 = obj5 & 0x1FFF;
				object obj7 = obj6 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v39 @ S3_v5 (should have been resolved before IL gen)");
				object obj8 = default;
				if ((nint)obj8 <= -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					List<Container> list = default;
					list._002Ector();
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S4_v5 (Il2CppMethodInfo)+C]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S4_v6+60]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S4_v7+48]");
					object obj11 = 0;
					object obj12 = obj11 & 0x7FF;
					object obj13 = obj12 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v64 @ S5_v5 (should have been resolved before IL gen)");
					return false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView+<>c__DisplayClass83_0)+C]");
				List<Container> list2 = ((Dictionary<int, List<Container>>)0).get_Item((int)item);
				Container container2;
				if (list2._size > 0)
				{
					Container container = list2.get_Item(0);
					list2.RemoveAt(0);
					container2 = container;
				}
				else
				{
					container2 = null;
				}
				return (byte)(int)container2 != 0;
			}
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass86_0
	{
		public int dataPosition1;

		public int dataPosition2;

		public _003C_003Ec__DisplayClass86_0()
		{
			int num = dataPosition1;
			_ = 0;
			if (dataPosition2 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			}
		}

		internal bool _003CAnimateSwapPositions_003Eb__0(Container T)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = T - -64;
			return (nint)obj == dataPosition1;
		}

		internal bool _003CAnimateSwapPositions_003Eb__1(Container T)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = T - -64;
			return (nint)obj == dataPosition1;
		}
	}

	private sealed class _003CAnimateSwapPositions_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int dataPosition1;

		public int dataPosition2;

		public ScrollView _003C_003E4__this;

		public float time;

		private _003C_003Ec__DisplayClass86_0 _003C_003E8__1;

		public Action onComplete;

		private Container _003Citem1_003E5__2;

		private Container _003Citem2_003E5__3;

		private Vector3 _003Corigin1_003E5__4;

		private Vector3 _003Corigin2_003E5__5;

		private float _003CtimePassed_003E5__6;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0554: Unknown result type (might be due to invalid IL or missing references)
				//IL_0559: Expected Obj, but got Unknown
				//IL_0562: Unknown result type (might be due to invalid IL or missing references)
				//IL_0567: Expected Obj, but got Unknown
				//IL_0570: Unknown result type (might be due to invalid IL or missing references)
				//IL_0575: Expected Obj, but got Unknown
				//IL_057e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0583: Expected Obj, but got Unknown
				//IL_058c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0591: Expected Obj, but got Unknown
				//IL_059a: Unknown result type (might be due to invalid IL or missing references)
				//IL_059f: Expected Obj, but got Unknown
				//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_05ad: Expected Obj, but got Unknown
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Expected Obj, but got Unknown
				//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d1: Expected Obj, but got Unknown
				//IL_0108: Unknown result type (might be due to invalid IL or missing references)
				//IL_010d: Expected Obj, but got Unknown
				//IL_011d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0122: Expected Obj, but got Unknown
				//IL_03d3: Expected I, but got Obj
				//IL_03e9: Expected Obj, but got I
				//IL_0612: Unknown result type (might be due to invalid IL or missing references)
				//IL_0617: Expected Obj, but got Unknown
				//IL_063a: Unknown result type (might be due to invalid IL or missing references)
				//IL_063f: Expected Obj, but got Unknown
				//IL_0662: Expected I, but got Obj
				//IL_0678: Expected Obj, but got I
				//IL_0282: Unknown result type (might be due to invalid IL or missing references)
				//IL_0287: Expected Obj, but got Unknown
				//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d6: Expected Obj, but got Unknown
				//IL_018d: Expected VT, but got Obj
				//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b2: Expected Obj, but got Unknown
				//IL_01e0: Expected VT, but got Obj
				//IL_06dd: Expected VT, but got Obj
				//IL_06dd: Expected VT, but got Obj
				//IL_0711: Unknown result type (might be due to invalid IL or missing references)
				//IL_0716: Expected Obj, but got Unknown
				//IL_0731: Unknown result type (might be due to invalid IL or missing references)
				//IL_0736: Expected Obj, but got Unknown
				//IL_0796: Expected VT, but got Obj
				//IL_0796: Expected VT, but got Obj
				//IL_0414: Expected I, but got Obj
				//IL_032a: Unknown result type (might be due to invalid IL or missing references)
				//IL_032f: Expected Obj, but got Unknown
				//IL_0346: Expected Obj, but got I4
				//IL_0351: Unknown result type (might be due to invalid IL or missing references)
				//IL_0356: Expected Obj, but got Unknown
				//IL_036d: Expected Obj, but got I4
				//IL_0373: Unknown result type (might be due to invalid IL or missing references)
				//IL_0378: Expected Obj, but got Unknown
				//IL_0388: Unknown result type (might be due to invalid IL or missing references)
				//IL_038d: Expected Obj, but got Unknown
				//IL_0205: Unknown result type (might be due to invalid IL or missing references)
				//IL_020a: Expected Obj, but got Unknown
				//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_04d5: Expected Obj, but got Unknown
				//IL_0461: Expected I, but got Obj
				//IL_0500: Expected Obj, but got I4
				object obj = default;
				Transform transform = (Transform)(obj + 84);
				Transform transform2 = (Transform)(obj + 72);
				Transform transform3 = (Transform)(obj + 60);
				object obj2 = obj + 48;
				object obj3 = obj + 36;
				object obj4 = obj + 24;
				object obj5 = obj + 12;
				ScrollView scrollView = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					object obj6 = this + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj7 = default;
					obj6 = obj7;
					_003C_003Ec__DisplayClass86_0 obj8 = _003C_003E8__1;
					obj8.dataPosition1 = dataPosition1;
					_003C_003Ec__DisplayClass86_0 obj9 = _003C_003E8__1;
					obj9.dataPosition2 = dataPosition2;
					scrollView.animating__BackingField = true;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num = 0;
					_ = 0;
					object obj11 = default;
					object obj10 = obj11 + 16;
					obj10 = _003C_003E8__1;
					object obj12 = this + 40;
					NullReferenceException ex = new NullReferenceException();
					obj12 = ex;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num2 = 0;
					_ = 0;
					object obj14 = default;
					object obj13 = obj14 + 16;
					obj13 = _003C_003E8__1;
					object obj15 = this + 44;
					NullReferenceException ex2 = new NullReferenceException();
					obj15 = ex2;
					if (_003Citem1_003E5__2 == null || _003Citem2_003E5__3 == null)
					{
						goto IL_0505;
					}
					Container container = _003Citem1_003E5__2;
					transform2.localPosition = (Vector3)container._modelTransform;
					transform = transform2;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
					object obj16 = this + 48;
					obj16 = transform;
					_ = ((UnityEngine.Object)transform).m_CachedPtr;
					Container container2 = _003Citem2_003E5__3;
					transform3.localPosition = (Vector3)container2._modelTransform;
					transform = transform3;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
					object obj17 = this + 60;
					obj17 = transform;
					_ = ((UnityEngine.Object)transform).m_CachedPtr;
					_003CtimePassed_003E5__6 = 0f;
				}
				if (!(_003CtimePassed_003E5__6 < time))
				{
					object obj18 = this + 60;
					transform2 = (Transform)obj18;
					Transform transform4 = transform2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S2_v56+8]");
					((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
					transform = transform2;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
					Vector3 eulerAngles = transform.eulerAngles;
					object obj19 = this + 48;
					transform3 = (Transform)obj19;
					Transform transform5 = transform3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S2_v66+8]");
					((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
					transform = transform3;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
					Vector3 eulerAngles2 = transform.eulerAngles;
					object obj20 = _003Citem1_003E5__2 - -64;
					_003C_003Ec__DisplayClass86_0 obj21 = _003C_003E8__1;
					obj20 = obj21.dataPosition2;
					object obj22 = _003Citem2_003E5__3 - -64;
					_003C_003Ec__DisplayClass86_0 obj23 = _003C_003E8__1;
					obj22 = obj23.dataPosition1;
					object obj24 = this + 48;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
					object obj25 = this + 60;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
					goto IL_0505;
				}
				float unscaledTime = Time.unscaledTime;
				float num3 = _003CtimePassed_003E5__6 + unscaledTime;
				_003CtimePassed_003E5__6 = num3;
				nint num4 = (nint)typeof(Math);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v46 (Il2CppClass<System.Math>)+BA]");
				object obj26 = (nint)0 & (nint)0x200;
				if (obj26 != null)
				{
					nint num5 = (nint)typeof(Math);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v64 (Il2CppClass<System.Math>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				double num6 = Math.PI / 2.0 * (double)_003CtimePassed_003E5__6;
				double num7 = num6 / (double)time;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E6");
				object obj27 = this + 48;
				transform3 = (Transform)obj27;
				Transform transform6 = transform3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S2_v7+8]");
				((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
				object obj28 = this + 60;
				obj2 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S2_v12+8]");
				_ = 0;
				nint num8 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S1_v30 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj29 = (nint)0 & (nint)0x200;
				if (obj29 != null)
				{
					nint num9 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S1_v59 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				transform2 = transform3;
				((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
				transform = (Transform)obj2;
				Transform transform7 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
				float t = default;
				Vector3 vector = Vector3.LerpUnclamped((Vector3)transform2, (Vector3)transform, t);
				transform = (Transform)obj3;
				Transform transform8 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles3 = transform.eulerAngles;
				object obj30 = this + 60;
				obj4 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S2_v32+8]");
				_ = 0;
				object obj31 = this + 48;
				obj5 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S2_v37+8]");
				_ = 0;
				transform2 = (Transform)obj4;
				Transform transform9 = transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
				((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
				transform = (Transform)obj5;
				Transform transform10 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
				((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
				Vector3 vector2 = Vector3.LerpUnclamped((Vector3)transform2, (Vector3)transform, t);
				transform = (Transform)obj;
				Transform transform11 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform11).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles4 = transform.eulerAngles;
				object obj32 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj33 = default;
				obj32 = obj33;
				_003C_003E1__state = 1;
				return 1;
				IL_0505:
				scrollView.animating__BackingField = false;
				if (onComplete != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CAnimateSwapPositions_003Ed__86(int _003C_003E1__state)
		{
			//IL_0119: Expected Obj, but got I
			//IL_0129: Expected Obj, but got I
			//IL_0139: Expected Obj, but got I
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Expected Obj, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected Obj, but got Unknown
			//IL_01b2: Expected Obj, but got I4
			//IL_0090: Expected Obj, but got I4
			//IL_00ac: Expected Obj, but got I4
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_0033: Expected Obj, but got I
			//IL_0043: Expected Obj, but got I
			//IL_0053: Expected Obj, but got I
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Obj, but got Unknown
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v3+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S2_v4+44]");
			object obj3 = 0;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S3_v4 (should have been resolved before IL gen)");
			object obj6 = default;
			if ((nint)obj6 <= -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				List<Container> list = default;
				list._002Ector();
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S4_v5 (Il2CppMethodInfo)+C]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S4_v6+60]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S4_v7+48]");
				object obj9 = 0;
				object obj10 = obj9 & 0x7FF;
				object obj11 = obj10 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v50 @ S5_v5 (should have been resolved before IL gen)");
			}
			object obj12 = _003C_003E2__current;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [<>1__state @ L1 (System.Int32)+44]");
			List<Container> list2 = ((Dictionary<int, List<Container>>)obj12).get_Item(0);
			list2.Add((Container)_003C_003E1__state);
			int height = Screen.height;
			int sleepTimeout = Screen.sleepTimeout;
			object obj13 = 0;
			_ = 0;
			int num3 = height << 1;
			obj13 = num3;
			int num4 = sleepTimeout << 1;
			_ = 0f;
			Transform transform = (Transform)(obj13 + 12);
			transform = (Transform)obj13;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
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

	private Arrangement _arrangement;

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

	private Vector2 _nextAppendPosition;

	private Vector2 _nextPrependPosition;

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

	[NonSerialized]
	public float scrollViewHeight;

	[NonSerialized]
	public float scrollViewWidth;

	private const int PULL_TO_REFRESH_CONTAINER = -100;

	private int _currentMaxListCount;

	private int _currentMinListCount;

	private PullDownToRefreshState _pullDownToRefreshState;

	private BoundsCalculationMode boundsCalculationMode;

	public float _currentPos;

	private float _previousPos;

	private ScrollDirection _scrollDirection;

	private bool animating__BackingField;

	private bool press;

	private float _movementDelta;

	private float _cumulativeDelta;

	public Transform rootPanelTransform
	{
		get
		{
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Expected Obj, but got Unknown
			//IL_01b5: Expected Obj, but got I4
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Expected Obj, but got Unknown
			//IL_01d2: Expected Obj, but got I4
			//IL_018b: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Expected Obj, but got Unknown
			//IL_0054: Expected I, but got Obj
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_00f3: Expected Obj, but got I4
			//IL_016a: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 24;
			object obj3 = obj2 - -64;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 40;
			obj4 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView)+16]");
			Transform result;
			if ((nint)0 != 0)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v58 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((UnityEngine.Object)(object)_bottomActiveContainer != null)
				{
					object obj6 = this + 104;
					UIPanel component = GetComponent<UIPanel>();
					obj6 = component;
				}
				object obj7 = _bottomActiveContainer + 220;
				obj = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v22+8]");
				_ = 0;
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
				_ = 0;
				if (((UIScrollView)this).canMoveVertically)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
					obj2 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					bool flag = (nint)obj8 > 0;
					result = (Transform)1;
					if (flag)
					{
						goto IL_02b5;
					}
				}
				if (((UIScrollView)this).shouldMoveHorizontally)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
					obj2 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
					bool flag2 = num3 > 0;
					result = (Transform)1;
					if (flag2)
					{
						goto IL_02b5;
					}
				}
				result = null;
			}
			else
			{
				result = (Transform)1;
			}
			goto IL_02b5;
			IL_02b5:
			return result;
		}
	}

	public UIPanel rootPanel
	{
		get
		{
			//IL_0098: Expected I, but got Obj
			//IL_00ae: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)_rootTransform))
			{
				return (UIPanel)(object)_rootTransform;
			}
			UIScrollView uIScrollView = uiScrollView;
			return (UIPanel)(object)uIScrollView.gameObject;
		}
	}

	public UIScrollView uiScrollView
	{
		get
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected Obj, but got Unknown
			if ((object)_rootPanel != null)
			{
				return (UIScrollView)(object)_rootPanel;
			}
			object obj = this + 44;
			string text = tag;
			UIPanel component = ((GameObject)(object)text).GetComponent<UIPanel>();
			obj = component;
			return (UIScrollView)(object)component;
		}
	}

	public ScrollDirection scrollDirection
	{
		get
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected Obj, but got Unknown
			//IL_0043: Expected Obj, but got VT
			//IL_004b: Expected I4, but got VT
			//IL_000f: Expected I4, but got Obj
			if ((object)_uiScrollView != null)
			{
				return (ScrollDirection)_uiScrollView;
			}
			object obj = this + 48;
			string text = tag;
			_0021_00210 componentInChildren = (_0021_00210)((GameObject)(object)text).GetComponentInChildren<T>();
			obj = componentInChildren;
			return (ScrollDirection)componentInChildren;
		}
	}

	public unsafe bool animating
	{
		get
		{
			return (byte)_scrollDirection != 0;
		}
		private set
		{
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Expected Obj, but got Unknown
			//IL_0317: Unknown result type (might be due to invalid IL or missing references)
			//IL_031c: Expected Obj, but got Unknown
			//IL_0472: Expected Obj, but got I4
			//IL_0491: Expected VT, but got Obj
			//IL_0010: Expected Obj, but got I4
			//IL_0021: Expected VT, but got Obj
			//IL_0031: Expected Obj, but got I4
			//IL_005c: Expected Obj, but got I4
			//IL_0072: Expected VT, but got Obj
			//IL_007f: Expected Obj, but got I4
			//IL_00a9: Expected Obj, but got I
			//IL_00b2: Invalid comparison between Obj and F4
			//IL_0360: Expected Obj, but got I4
			//IL_036d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0372: Expected Obj, but got Unknown
			//IL_03e2: Expected Obj, but got I4
			//IL_00e6: Expected Obj, but got I4
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected Obj, but got Unknown
			//IL_022a: Expected Obj, but got I4
			//IL_0250: Invalid comparison between I and F4
			//IL_0159: Expected Obj, but got I4
			//IL_0179: Expected Obj, but got I4
			//IL_018a: Expected VT, but got Obj
			//IL_0280: Expected I, but got Obj
			//IL_0296: Expected Obj, but got I
			//IL_019d: Expected I, but got Obj
			//IL_01b3: Expected Obj, but got I
			//IL_0456: Expected I4, but got Obj
			//IL_041b: Expected F4, but got I
			//IL_02c1: Expected I, but got Obj
			//IL_01de: Expected I, but got Obj
			object obj = default;
			Transform transform = (Transform)(obj + 24);
			Transform transform2 = (Transform)(obj + 12);
			bool flag = animating__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (System.Boolean)+1C]");
			if ((nint)0 != 0)
			{
				UIPanel uIPanel = ((ScrollView)animating__BackingField).rootPanel;
				transform.localPosition = (Vector3)uIPanel;
				Container lastVisibleContainerOnScreen = ((ScrollView)animating__BackingField).GetLastVisibleContainerOnScreen();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
				float num = 0f - lastVisibleContainerOnScreen.top;
				UIPanel uIPanel2 = ((ScrollView)animating__BackingField).rootPanel;
				transform2.localPosition = (Vector3)uIPanel2;
				obj = ((bool*)(value ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Transform)+4]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj2 = num2 + 0;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
				{
					bool flag2 = animating__BackingField;
					UIScrollView uIScrollView = ((ScrollView)animating__BackingField).uiScrollView;
					object obj3 = uIScrollView + 220;
					transform = (Transform)obj3;
					Transform transform3 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S3_v14+8]");
					((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v45 (System.Boolean)+A8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+C]");
					if (num3 < 0)
					{
						transform = (Transform)((bool*)(value ? 1 : 0))->m_value;
						Transform transform4 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+8]");
						((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
						UIPanel uIPanel3 = ((ScrollView)animating__BackingField).rootPanel;
						transform2.localPosition = (Vector3)uIPanel3;
						nint num4 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v56 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num5 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v61 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Transform)+4]");
						float num6 = Math.Abs(0f);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
						float num7 = 0f - num6;
					}
				}
				bool flag3 = animating__BackingField;
				UIScrollView uIScrollView2 = ((ScrollView)animating__BackingField).uiScrollView;
				object obj5 = uIScrollView2 + 220;
				transform = (Transform)obj5;
				Transform transform5 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S2_v18+8]");
				((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
				bool flag4 = !(num < 0f);
				bool flag5 = !flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v25 (System.Boolean)+A8]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+C]");
				bool flag6 = num8 < 0;
				bool flag7 = !flag6;
				object obj6 = flag5 | flag7;
				if (obj6 == null)
				{
					transform = (Transform)((bool*)(value ? 1 : 0))->m_value;
					Transform transform6 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+8]");
					((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
					if (!(0f < 0f))
					{
						nint num9 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v34 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num10 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v41 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Vector3 one = Vector3.one;
						((bool*)(value ? 1 : 0))->m_value = (byte)(int)transform != 0;
						_ = ((UnityEngine.Object)transform).m_CachedPtr;
					}
				}
			}
			transform = (Transform)((bool*)(value ? 1 : 0))->m_value;
			Transform transform7 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+8]");
			((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
			((UIScrollView)this).MoveAbsolute((Vector3)transform);
		}
	}

	public Bounds listViewBounds
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this & 1;
			Bounds result = default;
			return result;
		}
	}

	public bool infinite => animating__BackingField;

	private void InitScrollView()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScrollView);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScrollView>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScrollView);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UIScrollView>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UIShowControlScheme)this).OnEnable();
	}

	private void Start()
	{
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		if (_adapter != null)
		{
			if (~(_dataChangedDelegatesAdded ? 1u : 0u) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				_ = 0;
				object obj2 = default;
				object obj = obj2 + 16;
				obj = this;
				object obj3 = _adapter + 8;
				obj3 = obj2;
				UIScrollView uIScrollView = uiScrollView;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num2 = 0;
				_ = 0;
				object obj5 = default;
				object obj4 = obj5 + 16;
				obj4 = this;
				object obj6 = uIScrollView + 196;
				obj6 = obj5;
				_dataChangedDelegatesAdded = true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_003C_003Ec__DisplayClass83_0 obj7 = default;
			obj7._002Ector();
			object obj8 = this + 100;
			obj8 = obj7;
		}
		ScrollDirection scrollDirection = this.scrollDirection;
		bool flag = _arrangement != Arrangement.Horizontal;
	}

	private void OnPress(GameObject go, bool state)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009d: Expected I, but got Obj
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00b0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EventArgs);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.EventArgs>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<System.EventArgs>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)go;
		object obj2 = this + 12;
		obj2 = state;
	}

	private unsafe void CreatePullDownToRefreshContainer()
	{
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_0118: Expected I, but got Obj
		//IL_012e: Expected Obj, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0077: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v20 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj2 = default;
		obj2.method_ptr = method_ptr;
		obj2.method = (nint)__ldftn(ScrollView.OnPress);
		object obj3 = obj2 + 16;
		obj3 = this;
		Delegate obj4 = ((Delegate)UICamera.onPress).CombineImpl(obj2);
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v15 (Il2CppClass<UICamera>)+5C]");
		object obj5 = (nint)0 + (nint)188;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj6 = default;
		obj5 = obj6;
		object obj7 = this + 36;
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		obj7 = componentInChildren;
	}

	private unsafe void UpdatePullDownToRefreshContainer()
	{
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected I4, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected Obj, but got Unknown
		//IL_0354: Expected Obj, but got I4
		//IL_001e: Expected I4, but got Obj
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_00a5: Expected VT, but got Obj
		//IL_00b3: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_00f4: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_023e: Expected I4, but got Obj
		//IL_0250: Expected VT, but got I4
		//IL_0269: Expected I, but got Obj
		//IL_027f: Expected Obj, but got I
		//IL_03d9: Expected I4, but got Obj
		//IL_02aa: Expected I, but got Obj
		object obj = default;
		int num = obj + 88;
		object obj2 = obj + 72;
		object obj3 = obj + 56;
		object obj4 = obj + 40;
		object obj5 = obj + 32;
		object obj6 = obj + 16;
		object obj7 = obj + 8;
		obj7 = 0;
		if (pullDownToRefreshContainer != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Container container = default;
		container.Measure((byte)(int)pullDownToRefreshPrefab != 0);
		object obj8 = this + 120;
		obj8 = container;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Container container2 = pullDownToRefreshContainer;
		Container container3 = pullDownToRefreshContainer;
		float top = 0f - container3.height;
		container2.top = top;
		Container container4 = pullDownToRefreshContainer;
		container4.bottom = 0f;
		UIPanel uIPanel = rootPanel;
		pullDownToRefreshContainer.SetScale((Vector3)uIPanel);
		nint num2 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v42 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num3 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v71 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 one = Vector2.one;
		UIScrollView uIScrollView = uiScrollView;
		object obj10 = uIScrollView + 220;
		obj2 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v28+8]");
		_ = 0;
		UIScrollView uIScrollView2 = uiScrollView;
		object obj11 = uIScrollView2 + 220;
		obj3 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v34+8]");
		_ = 0;
		Container container5 = pullDownToRefreshContainer;
		object obj12 = pullDownToRefreshContainer + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
		UIScrollView uIScrollView3 = uiScrollView;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v42 (UIScrollView)+EC]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+C]");
		float num4 = 0f * 0.5f;
		float num5 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
		float num6 = num5 + 0f;
		float num7 = container5.height * 0.5f;
		float num8 = num6 + num7;
		float num9 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
		float num10 = num9 - 0f;
		float num11 = num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+4]");
		float num12 = num11 - 0f;
		Container container6 = pullDownToRefreshContainer;
		obj = obj7;
		((int*)num)->m_value = (int)obj;
		container6.coordinates = (Vector2)((int*)num)->m_value;
		((AdSystemEventLogger)(object)pullDownToRefreshContainer)._002Ector();
		nint num13 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v56 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num14 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S1_v65 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 forward = Vector3.forward;
		((int*)num)->m_value = (int)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		_ = 0;
		pullDownToRefreshContainer.SetModelType(num);
		Container container7 = pullDownToRefreshContainer;
		container7.modelType = -100;
	}

	private void Update()
	{
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected Obj, but got Unknown
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected Obj, but got Unknown
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected Obj, but got Unknown
		//IL_068f: Expected Obj, but got I4
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected Obj, but got Unknown
		//IL_06ac: Expected Obj, but got I4
		//IL_0578: Expected VT, but got Obj
		//IL_012f: Expected VT, but got Obj
		//IL_0595: Expected I, but got Obj
		//IL_05ab: Expected Obj, but got I
		//IL_014c: Expected I, but got Obj
		//IL_0162: Expected Obj, but got I
		//IL_072d: Expected I4, but got Obj
		//IL_05d6: Expected I, but got Obj
		//IL_0256: Expected VT, but got Obj
		//IL_018d: Expected I, but got Obj
		//IL_0273: Expected I, but got Obj
		//IL_0289: Expected Obj, but got I
		//IL_02b4: Expected I, but got Obj
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected Obj, but got Unknown
		//IL_03d1: Expected Obj, but got I
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_0405: Expected Obj, but got F4
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected Obj, but got Unknown
		//IL_0449: Expected Obj, but got F4
		//IL_0452: Expected Obj, but got F4
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected Obj, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected Obj, but got Unknown
		//IL_04e5: Expected Obj, but got I4
		object obj = default;
		Transform transform = (Transform)(obj - -64);
		object obj2 = obj + 28;
		object obj3 = obj + 16;
		object obj4 = obj + 52;
		obj4 = 0;
		_ = 0;
		object obj5 = obj + 40;
		obj5 = 0;
		_ = 0;
		if (~(pullDownToRefreshList ? 1u : 0u) != 0 || ~(_refreshingContainers ? 1u : 0u) == 0)
		{
			return;
		}
		if (_topDataIndexCursor == -1 && ~(_refreshContainerEncapsulated ? 1u : 0u) != 0 && _scrollDirection == ScrollDirection.Down && ~(press ? 1u : 0u) == 0)
		{
			_pullDownToRefreshState = PullDownToRefreshState.PullDown;
		}
		if (_pullDownToRefreshState == PullDownToRefreshState.PullDown)
		{
			ScrollDirection scrollDirection = this.scrollDirection;
			_ = 2;
			if (onPullDown != null && pullDownToRefreshContainer != null)
			{
				UIPanel uIPanel = rootPanel;
				transform.localPosition = (Vector3)uIPanel;
				Container container = pullDownToRefreshContainer;
				nint num = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S2_v45 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num2 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S2_v51 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
				float width = 0f - container.top;
				GUILayoutOption gUILayoutOption = GUILayout.Width(width);
				onPullDown((int)gUILayoutOption);
			}
		}
		if (~(pullDownToRefreshList ? 1u : 0u) == 0 && _topDataIndexCursor == -1 && _pullDownToRefreshState == PullDownToRefreshState.PullDown && pullDownToRefreshContainer != null)
		{
			UIPanel uIPanel2 = rootPanel;
			transform.localPosition = (Vector3)uIPanel2;
			Container container2 = pullDownToRefreshContainer;
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S2_v18 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S2_v38 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
			float width2 = 0f - container2.top;
			GUILayoutOption gUILayoutOption2 = GUILayout.Width(width2);
			if ((nint)gUILayoutOption2 <= -1 && ~(_refreshContainerEncapsulated ? 1u : 0u) != 0 && ~(press ? 1u : 0u) != 0)
			{
				object obj8 = this + 76;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				object obj9 = this + 76;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
				obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				_ = 0;
				UIScrollView uIScrollView = uiScrollView;
				object obj10 = uIScrollView + 220;
				obj = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S1_v50+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				obj4 = 0;
				object obj11 = obj4 + 4;
				Container container3 = pullDownToRefreshContainer;
				float num5 = (float)obj11 + container3.height;
				obj11 = num5;
				object obj12 = obj5 + 4;
				Container container4 = pullDownToRefreshContainer;
				float num6 = container4.height * 0.5f;
				float num7 = (float)obj12 + num6;
				obj12 = num7;
				obj5 = 0f;
				transform = (Transform)obj4;
				Transform transform2 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
				object obj13 = this + 76;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A5");
				transform = (Transform)obj5;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				object obj14 = this + 76;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A1");
				_refreshContainerEncapsulated = true;
				ScrollDirection scrollDirection2 = this.scrollDirection;
				UISprite uISprite = NGUITools.AddSprite((GameObject)scrollDirection2, null, null, 1);
				ScrollDirection scrollDirection3 = this.scrollDirection;
				_ = 1;
				_pullDownToRefreshState = PullDownToRefreshState.Refreshing;
				if (onPullDownRelease != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
				}
			}
		}
		if (pullDownToRefreshContainer == null || _pullDownToRefreshState != PullDownToRefreshState.Refreshing)
		{
			return;
		}
		UIPanel uIPanel3 = rootPanel;
		transform.localPosition = (Vector3)uIPanel3;
		Container container5 = pullDownToRefreshContainer;
		nint num8 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S2_v7 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num9 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S2_v11 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
		float width3 = 0f - container5.top;
		GUILayoutOption gUILayoutOption3 = GUILayout.Width(width3);
		if (gUILayoutOption3 == null && onPullDownToTriggerRefresh != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			_pullDownToRefreshState = PullDownToRefreshState.None;
		}
	}

	private void OnClipMove(UIPanel panel)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = panel + 76;
		ScrollView scrollView = (ScrollView)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+10]");
		cellSpaceY = 0;
	}

	private void SetContainerPositions()
	{
		HandleScrollDown();
	}

	private void ClearList()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		RecycleBin recycleBin = _recycleBin;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 56)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				return;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private void OnDataSetChanged(int selection)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_01ad: Expected Obj, but got I
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_014d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 44;
		object obj3 = obj2 + 8;
		object obj4 = obj2 + 32;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 20;
		obj5 = 0;
		_ = 0;
		if (~(_refreshingContainers ? 1u : 0u) == 0 || _adapter == null)
		{
			return;
		}
		Log((string)(object)this);
		HandleScrollUp();
		Update();
		if (_infinite == Infinite.BothWays)
		{
			object obj6 = this + 76;
			if (_arrangement == Arrangement.Horizontal)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
				obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
				_ = 0;
				UIScrollView uIScrollView = uiScrollView;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v40 (UIScrollView)+104]");
				obj2 = 0;
				obj4 = obj2;
				obj = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
				_ = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
				obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
				_ = 0;
				UIScrollView uIScrollView2 = uiScrollView;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v26 (UIScrollView)+104]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				_ = 0;
				obj = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12+8]");
				_ = 0;
			}
			object obj7 = this + 76;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A1");
		}
	}

	public void CancelLoading()
	{
		//IL_012f: Expected Obj, but got I4
		//IL_0153: Expected I, but got Obj
		//IL_0169: Expected Obj, but got I
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01bd: Expected VT, but got Obj
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01e6: Expected VT, but got Obj
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_00ae: Expected I, but got Obj
		ScrollDirection scrollDirection = this.scrollDirection;
		((UIScrollView)scrollDirection).UpdateScrollbars();
		_endDataIndexCursor = 0;
		_topDataIndexCursor = 0;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v34 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 16;
		Vector2 one = Vector2.one;
		Transform transform = (Transform)(obj3 + 36);
		transform = (Transform)obj2;
		_nextAppendPosition = (Vector2)transform;
		object obj4 = obj3 + 8;
		Vector2 one2 = Vector2.one;
		transform = (Transform)obj4;
		_nextPrependPosition = (Vector2)transform;
		UIScrollView uIScrollView = uiScrollView;
		GameObject gameObject = uIScrollView.gameObject;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v24 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v38 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj3 + 24;
		Vector3 one3 = Vector3.one;
		transform = (Transform)obj6;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v29+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		UIScrollView uIScrollView2 = uiScrollView;
		Vector2 one4 = Vector2.one;
		transform = (Transform)obj3;
		((UIPanel)(object)uIScrollView2).clipTexture = (Texture2D)(object)transform;
		_recycleBin.ScrapActiveContainers();
	}

	public void SetAdapter(AbstractListAdapter adapter)
	{
		//IL_0015: Expected VT, but got Obj
		//IL_0068: Expected I, but got Obj
		//IL_007e: Expected Obj, but got I
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_00f6: Expected I, but got Obj
		//IL_010c: Expected Obj, but got I
		//IL_00a9: Expected I, but got Obj
		//IL_0137: Expected I, but got Obj
		_refreshingContainers = true;
		_refreshingContainerAdded = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj = default;
		if (obj != null)
		{
			SmoothScrollToOffset((Vector3)adapter, null, 0f);
		}
		else
		{
			CancelLoading();
		}
		ScrollDirection scrollDirection = this.scrollDirection;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		UIScrollView uIScrollView = uiScrollView;
		GameObject gameObject = uIScrollView.gameObject;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v13 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v37 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 8;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj4 + 20);
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v18+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		UIScrollView uIScrollView2 = uiScrollView;
		nint num3 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v25 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v33 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 one2 = Vector2.one;
		transform = (Transform)obj4;
		((UIPanel)(object)uIScrollView2).clipTexture = (Texture2D)(object)transform;
		_refreshingContainers = false;
	}

	public void PrintActiveContainers()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj = this + 136;
		SpringPanel component = GetComponent<SpringPanel>();
		obj = component;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v21 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj4 = default;
		object obj3 = obj4 + 12;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = _springPanel + 12;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v13+8]");
		_ = 0;
		_springPanel.tag = (string)1;
	}

	private void PrependContainer(int position, Container container, bool setPosition)
	{
		//IL_0c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c55: Expected Obj, but got Unknown
		//IL_0c5e: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I
		//IL_04d6: Expected Obj, but got I4
		//IL_04e7: Expected I4, but got Obj
		//IL_04fa: Expected Obj, but got I4
		//IL_05b5: Expected Obj, but got I4
		//IL_05c6: Expected I4, but got Obj
		//IL_0556: Expected Obj, but got I4
		//IL_05d9: Expected Obj, but got I4
		//IL_0522: Expected Obj, but got I4
		//IL_0539: Expected I4, but got Obj
		//IL_0539: Expected Obj, but got I4
		//IL_0635: Expected Obj, but got I4
		//IL_03a0: Expected Obj, but got I4
		//IL_0601: Expected Obj, but got I4
		//IL_0618: Expected I4, but got Obj
		//IL_0618: Expected Obj, but got I4
		//IL_03d0: Expected Obj, but got I4
		//IL_03e6: Expected I4, but got Obj
		//IL_03f4: Expected Obj, but got I4
		//IL_0c3d: Expected VT, but got Obj
		//IL_0c3d: Expected VT, but got Obj
		//IL_0455: Expected Obj, but got I4
		//IL_0b92: Expected Obj, but got I4
		//IL_0ba3: Expected I4, but got Obj
		//IL_0421: Expected Obj, but got I4
		//IL_0438: Expected I4, but got Obj
		//IL_0438: Expected Obj, but got I4
		//IL_0159: Expected I4, but got Obj
		//IL_0bb6: Expected Obj, but got I4
		//IL_016c: Expected Obj, but got I4
		//IL_0c05: Expected Obj, but got I4
		//IL_0c1b: Expected VT, but got Obj
		//IL_0c1b: Expected VT, but got Obj
		//IL_02d2: Expected I4, but got Obj
		//IL_0bde: Expected Obj, but got I4
		//IL_0bf5: Expected I4, but got Obj
		//IL_0bf5: Expected Obj, but got I4
		//IL_01ab: Expected I4, but got Obj
		//IL_02e5: Expected Obj, but got I4
		//IL_02b1: Expected Obj, but got I4
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected Obj, but got Unknown
		//IL_06ae: Expected Obj, but got I
		//IL_06bc: Expected I, but got Obj
		//IL_06d2: Expected Obj, but got I
		//IL_0cc6: Expected Obj, but got I
		//IL_0324: Expected I4, but got Obj
		//IL_06fd: Expected I, but got Obj
		//IL_0ac9: Expected I4, but got Obj
		//IL_09ea: Expected I4, but got Obj
		//IL_074a: Expected I, but got Obj
		//IL_0760: Expected Obj, but got I
		//IL_0adc: Expected Obj, but got I4
		//IL_09fd: Expected Obj, but got I4
		//IL_09c9: Expected Obj, but got I4
		//IL_0cf8: Expected Obj, but got I
		//IL_0d0e: Expected Obj, but got I
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected Obj, but got Unknown
		//IL_089b: Expected I, but got Obj
		//IL_08b1: Expected Obj, but got I
		//IL_078b: Expected I, but got Obj
		//IL_0b1b: Expected I4, but got Obj
		//IL_0a3c: Expected I4, but got Obj
		//IL_0d4f: Expected Obj, but got I
		//IL_07db: Expected Obj, but got I
		//IL_07ed: Expected I, but got Obj
		//IL_0803: Expected Obj, but got I
		//IL_0938: Expected I, but got Obj
		//IL_094e: Expected Obj, but got I
		//IL_08dc: Expected I, but got Obj
		//IL_082e: Expected I, but got Obj
		//IL_0979: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView)+B5]");
		if ((nint)0 != 0)
		{
			((HoverboardModelPreviewFactory)this).OpenGlider();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [position @ L1 (System.Int32)+8]");
		object obj3 = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [position @ L1 (System.Int32)+8]");
		if ((nint)0 != 1)
		{
			if ((nint)obj3 != 1)
			{
				if ((nint)obj3 != 2 && (nint)obj3 != 3)
				{
					if ((nint)obj3 != 4)
					{
						if ((nint)obj3 != 5)
						{
							if ((nint)obj3 != 6)
							{
								if ((nint)obj3 == 7)
								{
									UnityEngine.Object obj4 = UnityEngine.Object.Instantiate((UnityEngine.Object)_rootPanel);
									bool flag = ((Animation)(object)container).Play((PlayMode)obj4);
									if ((TrackedReference)flag != null)
									{
										UnityEngine.Object obj5 = UnityEngine.Object.Instantiate((UnityEngine.Object)_rootPanel);
										((AnimationState)(object)container).AddMixingTransform((Transform)(object)_rootPanel, (byte)(int)obj5 != 0);
									}
									bool flag2 = ((Animation)(object)container).Play();
									UnityEngine.Object obj6 = UnityEngine.Object.Instantiate((UnityEngine.Object)_rootPanel);
									if (flag2)
									{
										AudioSource.PlayOneShotHelper((AudioSource)(object)container, (AudioClip)obj6, 0.2f);
									}
									else
									{
										AnimationState animationState = ((Animation)(object)container).CrossFadeQueued((string)(object)obj6);
									}
								}
							}
							else
							{
								object obj7 = this + 136;
								int currentMaxListCount = _currentMaxListCount;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v120 (System.Int32)+B4]");
								obj7 = 0;
								nint num = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v112 (Il2CppClass<UnityEngine.Object>)+BA]");
								object obj8 = (nint)0 & (nint)0x200;
								if (obj8 != null)
								{
									nint num2 = (nint)typeof(UnityEngine.Object);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v169 (Il2CppClass<UnityEngine.Object>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [position @ L1 (System.Int32)+24]");
								if (((ComputeShader)0).FindKernel(null) != 0)
								{
									nint num3 = (nint)typeof(UnityEngine.Object);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S1_v157 (Il2CppClass<UnityEngine.Object>)+BA]");
									object obj9 = (nint)0 & (nint)0x200;
									if (obj9 != null)
									{
										nint num4 = (nint)typeof(UnityEngine.Object);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S1_v193 (Il2CppClass<UnityEngine.Object>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [position @ L1 (System.Int32)+24]");
									GameObject gameObject = UnityEngine.Object.Instantiate((GameObject)0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView)+58]");
									if (((ComputeShader)0).FindKernel(null) != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView)+58]");
										string obj10 = ((Component)0).tag;
										nint num5 = (nint)typeof(UnityEngine.Object);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ S1_v184 (Il2CppClass<UnityEngine.Object>)+BA]");
										object obj11 = (nint)0 & (nint)0x200;
										if (obj11 != null)
										{
											nint num6 = (nint)typeof(UnityEngine.Object);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ S1_v189 (Il2CppClass<UnityEngine.Object>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj10);
									}
									object obj12 = this + 88;
									ATeleboardMenuEffect component = gameObject.GetComponent<ATeleboardMenuEffect>();
									obj12 = component;
									nint num7 = (nint)typeof(UnityEngine.Object);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ S1_v169 (Il2CppClass<UnityEngine.Object>)+BA]");
									object obj13 = (nint)0 & (nint)0x200;
									if (obj13 != null)
									{
										nint num8 = (nint)typeof(UnityEngine.Object);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ S1_v178 (Il2CppClass<UnityEngine.Object>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollView)+58]");
									if (!((UnityEngine.Object)0 != null))
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
									}
									else
									{
										nint num9 = (nint)typeof(UnityEngine.Object);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ S0_v156 (Il2CppClass<UnityEngine.Object>)+BA]");
										object obj14 = (nint)0 & (nint)0x200;
										if (obj14 != null)
										{
											nint num10 = (nint)typeof(UnityEngine.Object);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ S0_v161 (Il2CppClass<UnityEngine.Object>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										UnityEngine.Object.DestroyImmediate(gameObject);
									}
								}
								AnimatorStateInfo nextAnimatorStateInfo = ((Animator)(object)pullDownToRefreshContainer).GetNextAnimatorStateInfo(0);
								obj = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
								if ((nint)0 != _endDataIndexCursor)
								{
									((Animator)(object)pullDownToRefreshContainer).SetTriggerString((string)_endDataIndexCursor);
								}
								UnityEngine.Object obj15 = UnityEngine.Object.Instantiate((UnityEngine.Object)_centerOnChild);
								bool flag3 = ((Animation)(object)container).Play((PlayMode)obj15);
								if ((TrackedReference)flag3 != null)
								{
									UnityEngine.Object obj16 = UnityEngine.Object.Instantiate((UnityEngine.Object)_centerOnChild);
									((AnimationState)(object)container).AddMixingTransform((Transform)(object)_centerOnChild, (byte)(int)obj16 != 0);
								}
								bool flag4 = ((Animation)(object)container).Play();
								UnityEngine.Object obj17 = UnityEngine.Object.Instantiate((UnityEngine.Object)_centerOnChild);
								if (flag4)
								{
									AudioSource.PlayOneShotHelper((AudioSource)(object)container, (AudioClip)obj17, 0.2f);
								}
								else
								{
									AnimationState animationState2 = ((Animation)(object)container).CrossFadeQueued((string)(object)obj17);
								}
							}
						}
						else
						{
							AnimatorStateInfo nextAnimatorStateInfo2 = ((Animator)(object)pullDownToRefreshContainer).GetNextAnimatorStateInfo(0);
							obj = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
							if ((nint)0 != _topDataIndexCursor)
							{
								((Animator)(object)pullDownToRefreshContainer).SetTriggerString((string)_topDataIndexCursor);
							}
							UnityEngine.Object obj18 = UnityEngine.Object.Instantiate((UnityEngine.Object)_rootTransform);
							bool flag5 = ((Animation)(object)container).Play((PlayMode)obj18);
							if ((TrackedReference)flag5 != null)
							{
								UnityEngine.Object obj19 = UnityEngine.Object.Instantiate((UnityEngine.Object)_rootTransform);
								((AnimationState)(object)container).AddMixingTransform(_rootTransform, (byte)(int)obj19 != 0);
							}
							bool flag6 = ((Animation)(object)container).Play();
							UnityEngine.Object obj20 = UnityEngine.Object.Instantiate((UnityEngine.Object)_rootTransform);
							if (flag6)
							{
								AudioSource.PlayOneShotHelper((AudioSource)(object)container, (AudioClip)obj20, 0.2f);
							}
							else
							{
								AnimationState animationState3 = ((Animation)(object)container).CrossFadeQueued((string)(object)obj20);
							}
						}
					}
					else
					{
						IEnumerator routine = ((HoverboardModelPreviewFactory)this).SpeederEvents(1f);
						Coroutine coroutine = StartCoroutine_Auto(routine);
						UnityEngine.Object obj21 = UnityEngine.Object.Instantiate((UnityEngine.Object)pullDownToRefreshPrefab);
						bool flag7 = ((Animation)(object)container).Play((PlayMode)obj21);
						if ((TrackedReference)flag7 != null)
						{
							UnityEngine.Object obj22 = UnityEngine.Object.Instantiate((UnityEngine.Object)pullDownToRefreshPrefab);
							((AnimationState)(object)container).AddMixingTransform((Transform)(object)pullDownToRefreshPrefab, (byte)(int)obj22 != 0);
						}
						bool flag8 = ((Animation)(object)container).Play();
						UnityEngine.Object obj23 = UnityEngine.Object.Instantiate((UnityEngine.Object)pullDownToRefreshPrefab);
						if (flag8)
						{
							AudioSource.PlayOneShotHelper((AudioSource)(object)container, (AudioClip)obj23, 0.2f);
						}
						else
						{
							AnimationState animationState4 = ((Animation)(object)container).CrossFadeQueued((string)(object)obj23);
						}
					}
				}
				else
				{
					float frameRate = ((AnimationClip)cellSpaceX).frameRate;
					IEnumerator routine2 = ((HoverboardModelPreviewFactory)this).TeleportFXStartScale(frameRate);
					Coroutine coroutine2 = StartCoroutine_Auto(routine2);
					UnityEngine.Object obj24 = UnityEngine.Object.Instantiate((UnityEngine.Object)cellSpaceX);
					bool flag9 = ((Animation)(object)container).Play((PlayMode)obj24);
					if ((TrackedReference)flag9 != null)
					{
						UnityEngine.Object obj25 = UnityEngine.Object.Instantiate((UnityEngine.Object)cellSpaceX);
						((AnimationState)(object)container).AddMixingTransform((Transform)cellSpaceX, (byte)(int)obj25 != 0);
					}
					bool flag10 = ((Animation)(object)container).Play();
					UnityEngine.Object obj26 = UnityEngine.Object.Instantiate((UnityEngine.Object)cellSpaceX);
					if (flag10)
					{
						AudioSource.PlayOneShotHelper((AudioSource)(object)container, (AudioClip)obj26, 0.2f);
					}
					else
					{
						AnimationState animationState5 = ((Animation)(object)container).CrossFadeQueued((string)(object)obj26);
					}
				}
			}
			else
			{
				UnityEngine.Object obj27 = UnityEngine.Object.Instantiate((UnityEngine.Object)pullDownToRefreshList);
				bool flag11 = ((Animation)(object)container).Play((PlayMode)obj27);
				if ((TrackedReference)flag11 != null)
				{
					UnityEngine.Object obj28 = UnityEngine.Object.Instantiate((UnityEngine.Object)pullDownToRefreshList);
					((AnimationState)(object)container).AddMixingTransform((Transform)pullDownToRefreshList, (byte)(int)obj28 != 0);
				}
				bool flag12 = ((Animation)(object)container).Play();
				UnityEngine.Object obj29 = UnityEngine.Object.Instantiate((UnityEngine.Object)pullDownToRefreshList);
				if (flag12)
				{
					AudioSource.PlayOneShotHelper((AudioSource)(object)container, (AudioClip)obj29, 0.2f);
				}
				else
				{
					AnimationState animationState6 = ((Animation)(object)container).CrossFadeQueued((string)(object)obj29);
				}
			}
		}
		else
		{
			IEnumerator routine3 = ((HoverboardModelPreviewFactory)this).SpeederEvents(0.4f);
			Coroutine coroutine3 = StartCoroutine_Auto(routine3);
			UnityEngine.Object obj30 = UnityEngine.Object.Instantiate((UnityEngine.Object)cellSpaceY);
			bool flag13 = ((Animation)(object)container).Play((PlayMode)obj30);
			if ((TrackedReference)flag13 != null)
			{
				UnityEngine.Object obj31 = UnityEngine.Object.Instantiate((UnityEngine.Object)cellSpaceY);
				((AnimationState)(object)container).AddMixingTransform((Transform)cellSpaceY, (byte)(int)obj31 != 0);
			}
			bool flag14 = ((Animation)(object)container).Play();
			UnityEngine.Object obj32 = UnityEngine.Object.Instantiate((UnityEngine.Object)cellSpaceY);
			if (flag14)
			{
				AudioSource.PlayOneShotHelper((AudioSource)(object)container, (AudioClip)obj32, 0.2f);
			}
			else
			{
				AnimationState animationState7 = ((Animation)(object)container).CrossFadeQueued((string)(object)obj32);
			}
		}
		if (setPosition)
		{
			UnityEngine.Object obj33 = UnityEngine.Object.Instantiate((UnityEngine.Object)_infinite);
			bool flag15 = ((Animation)(object)container).Play((PlayMode)obj33);
			if ((TrackedReference)flag15 != null)
			{
				UnityEngine.Object obj34 = UnityEngine.Object.Instantiate((UnityEngine.Object)_infinite);
				((AnimationState)(object)container).AddMixingTransform((Transform)_infinite, (byte)(int)obj34 != 0);
			}
			UnityEngine.Object obj35 = UnityEngine.Object.Instantiate((UnityEngine.Object)_infinite);
			bool flag16 = Physics.Raycast((Vector3)container, (Vector3)obj35, 0.2f);
		}
		else
		{
			bool flag17 = Physics.Raycast((Vector3)container, (Vector3)_adapter, 0.2f);
		}
	}

	private unsafe void AppendContainer(int position, Container container, bool setPosition)
	{
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_041d: Expected Obj, but got I4
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_0433: Expected Obj, but got I4
		//IL_002e: Expected VT, but got Obj
		//IL_003c: Expected I, but got Obj
		//IL_0052: Expected Obj, but got I
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected Obj, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected Obj, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected I4, but got Unknown
		//IL_04b0: Expected I4, but got Obj
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Obj, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected Obj, but got Unknown
		//IL_007d: Expected I, but got Obj
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_0107: Expected Obj, but got VT
		//IL_0114: Expected I4, but got Obj
		//IL_0123: Expected VT, but got I4
		//IL_0556: Expected Obj, but got VT
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_03d8: Expected I4, but got Obj
		//IL_03f2: Expected Obj, but got I4
		//IL_01f8: Expected Obj, but got F4
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_059f: Expected I4, but got Obj
		//IL_05b1: Expected VT, but got I4
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_039e: Expected I4, but got Obj
		//IL_02d3: Expected Obj, but got F4
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		object obj3 = container - -64;
		obj3 = position;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730E");
		long rowId = default;
		container.rowId = rowId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		int modelType = default;
		container.modelType = modelType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		UIScrollView uIScrollView = uiScrollView;
		GameObject gameObject = uIScrollView.gameObject;
		container.SetScale((Vector3)gameObject);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v17 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v107 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 8;
		object obj6 = obj2 + 48;
		Vector3 forward = Vector3.forward;
		int num3 = obj2 - -64;
		((int*)num3)->m_value = (int)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v24+8]");
		_ = 0;
		container.SetModelType(num3);
		RecycleBin recycleBin = _recycleBin;
		List<Container> activeContainers = recycleBin.activeContainers;
		if (activeContainers._size >= 1)
		{
			object obj7 = this + 108;
			RecycleBin recycleBin2 = _recycleBin;
			Container container2 = recycleBin2.activeContainers.get_Item(0);
			obj7 = container2;
			Container topActiveContainer = _topActiveContainer;
			obj5 = topActiveContainer.coordinates;
			((int*)num3)->m_value = (int)obj5;
			_nextPrependPosition = (Vector2)((int*)num3)->m_value;
		}
		object obj8 = obj2 + 36;
		object obj9 = obj2 + 24;
		if (_topActiveContainer != null)
		{
			object obj10 = this + 60;
			Container topActiveContainer2 = _topActiveContainer;
			object obj11 = container + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			object obj12 = _topActiveContainer + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			float num4 = container.width * 0.5f;
			float num5 = topActiveContainer2.width * 0.5f;
			float num6 = num4 + num5;
			float num7 = num6 + (float)cellSpaceX;
			float num8 = num7 + (float)((int*)num3)->m_value;
			float num9 = num8 - (float)obj6;
			float num10 = (float)obj10 - num9;
			obj10 = num10;
			object obj13 = this - -64;
			Container topActiveContainer3 = _topActiveContainer;
			object obj14 = container + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			object obj15 = _topActiveContainer + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			float num11 = container.height * 0.5f;
			float num12 = topActiveContainer3.height * 0.5f;
			float num13 = num11 + num12;
			float num14 = num13 + (float)cellSpaceY;
			float num15 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v38+4]");
			float num16 = num15 - 0f;
			float num17 = num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v40+4]");
			float num18 = num17 + 0f;
			float num19 = (float)obj13 + num18;
			obj13 = num19;
		}
		if (_topActiveContainer != null)
		{
			Container topActiveContainer4 = _topActiveContainer;
			container.bottom = topActiveContainer4.top;
			float num20 = container.bottom - container.height;
			float top = num20 - (float)cellSpaceY;
			container.top = top;
			Container topActiveContainer5 = _topActiveContainer;
			container.right = topActiveContainer5.left;
			float num21 = container.right - container.width;
			float left = num21 - (float)cellSpaceX;
			container.left = left;
		}
		obj = _nextPrependPosition;
		bool flag = _arrangement == Arrangement.Horizontal;
		UIScrollView uIScrollView2 = uiScrollView;
		if (flag)
		{
			object obj16 = uIScrollView2 + 220;
			((int*)num3)->m_value = (int)obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S1_v57+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v26 (System.Int32)+4]");
			_ = 0;
		}
		else
		{
			object obj17 = uIScrollView2 + 220;
			((int*)num3)->m_value = (int)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S1_v50+8]");
			_ = 0;
			obj = ((int*)num3)->m_value;
		}
		obj2 = obj;
		((int*)num3)->m_value = (int)obj2;
		container.coordinates = (Vector2)((int*)num3)->m_value;
		((FollowingGuard.OnCatchPlayerDelegate)(object)_recycleBin)._002Ector((object)container, (IntPtr)0);
		int topDataIndexCursor = _topDataIndexCursor - 1;
		_topDataIndexCursor = topDataIndexCursor;
		if (setPosition)
		{
			((AdSystemEventLogger)(object)container)._002Ector();
		}
	}

	public void SetSelection(int position, ContainerPivot containerPivot = ContainerPivot.Top, float offset = 0f)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4EF3");
	}

	public unsafe void SmoothScrollToIndex(int dataIndex, ContainerPivot containerPivot = ContainerPivot.Center, Action onFinished = null)
	{
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected Obj, but got Unknown
		//IL_047e: Expected Obj, but got I4
		//IL_048c: Expected Obj, but got I4
		//IL_0494: Expected Obj, but got I4
		//IL_001f: Expected VT, but got Obj
		//IL_001f: Expected Obj, but got I4
		//IL_0032: Expected I, but got Obj
		//IL_0048: Expected Obj, but got I
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected Obj, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected Obj, but got Unknown
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected I4, but got Unknown
		//IL_0501: Expected I4, but got Obj
		//IL_051b: Expected Obj, but got I4
		//IL_0073: Expected I, but got Obj
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got VT
		//IL_0190: Expected I4, but got Obj
		//IL_019f: Expected VT, but got I4
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected Obj, but got Unknown
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_010a: Expected Obj, but got I4
		//IL_05d9: Expected Obj, but got VT
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected Obj, but got Unknown
		//IL_0604: Expected I4, but got Obj
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected Obj, but got Unknown
		//IL_0439: Expected I4, but got Obj
		//IL_0453: Expected Obj, but got I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01e1: Expected Obj, but got I4
		//IL_057a: Expected I4, but got Obj
		//IL_0598: Expected Obj, but got I4
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Unknown
		//IL_03ff: Expected I4, but got Obj
		//IL_0277: Expected Obj, but got F4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02b4: Expected Obj, but got I4
		//IL_0355: Expected Obj, but got F4
		//IL_0386: Expected Obj, but got I
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		//IL_03cb: Expected Obj, but got I
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_0461: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 32;
		obj = 0;
		object obj3 = containerPivot - -64;
		obj3 = dataIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		UIScrollView uIScrollView = uiScrollView;
		GameObject gameObject = uIScrollView.gameObject;
		((Container)containerPivot).SetScale((Vector3)gameObject);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v16 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v111 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 40;
		object obj6 = obj2 + 16;
		Vector3 forward = Vector3.forward;
		int num3 = obj2 + 72;
		((int*)num3)->m_value = (int)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v23+8]");
		_ = 0;
		((Container)containerPivot).SetModelType(num3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		RecycleBin recycleBin = _recycleBin;
		List<Container> activeContainers = recycleBin.activeContainers;
		if (activeContainers._size < 1)
		{
			object obj7 = this + 104;
			obj7 = 0;
		}
		else
		{
			object obj8 = this + 104;
			RecycleBin recycleBin2 = _recycleBin;
			RecycleBin recycleBin3 = _recycleBin;
			List<Container> activeContainers2 = recycleBin3.activeContainers;
			int index = activeContainers2._size - 1;
			Container container = recycleBin2.activeContainers.get_Item(index);
			obj8 = container;
			Container bottomActiveContainer = _bottomActiveContainer;
			obj5 = bottomActiveContainer.coordinates;
			((int*)num3)->m_value = (int)obj5;
			_nextAppendPosition = (Vector2)((int*)num3)->m_value;
		}
		object obj9 = obj2 + 60;
		object obj10 = obj2 + 48;
		if (_bottomActiveContainer != null)
		{
			object obj11 = this + 52;
			Container bottomActiveContainer2 = _bottomActiveContainer;
			object obj12 = _bottomActiveContainer + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			object obj13 = containerPivot + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [containerPivot @ L2 (ContainerPivot)+4C]");
			float num4 = 0f * 0.5f;
			float num5 = bottomActiveContainer2.width * 0.5f;
			float num6 = num4 + num5;
			float num7 = num6 + (float)cellSpaceX;
			float num8 = num7 + (float)((int*)num3)->m_value;
			float num9 = num8 - (float)obj6;
			float num10 = (float)obj11 + num9;
			obj11 = num10;
			object obj14 = this + 56;
			Container bottomActiveContainer3 = _bottomActiveContainer;
			object obj15 = _bottomActiveContainer + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			object obj16 = containerPivot + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [containerPivot @ L2 (ContainerPivot)+48]");
			float num11 = 0f * 0.5f;
			float num12 = bottomActiveContainer3.height * 0.5f;
			float num13 = num11 + num12;
			float num14 = num13 + (float)cellSpaceY;
			float num15 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v38+4]");
			float num16 = num15 - 0f;
			float num17 = num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v40+4]");
			float num18 = num17 + 0f;
			float num19 = (float)obj14 - num18;
			obj14 = num19;
			Container bottomActiveContainer4 = _bottomActiveContainer;
			_ = bottomActiveContainer4.bottom;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [containerPivot @ L2 (ContainerPivot)+5C]");
			nint num20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [containerPivot @ L2 (ContainerPivot)+48]");
			object obj17 = num20 + 0;
			object obj18 = obj17 + cellSpaceY;
			Container bottomActiveContainer5 = _bottomActiveContainer;
			_ = bottomActiveContainer5.right;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [containerPivot @ L2 (ContainerPivot)+68]");
			nint num21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [containerPivot @ L2 (ContainerPivot)+4C]");
			object obj19 = num21 + 0;
			object obj20 = obj19 + cellSpaceX;
		}
		obj6 = _nextAppendPosition;
		obj = obj6;
		object obj21 = obj2 + 8;
		obj21 = obj6;
		((int*)num3)->m_value = (int)obj21;
		_ = ((int*)num3)->m_value;
		bool flag = _arrangement == Arrangement.Horizontal;
		UIScrollView uIScrollView2 = uiScrollView;
		if (flag)
		{
			object obj22 = uIScrollView2 + 220;
			((int*)num3)->m_value = (int)obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S1_v64+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v25 (System.Int32)+4]");
			_ = 0;
		}
		else
		{
			object obj23 = uIScrollView2 + 220;
			((int*)num3)->m_value = (int)obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S1_v57+8]");
			_ = 0;
			obj = ((int*)num3)->m_value;
		}
		obj2 = obj;
		((int*)num3)->m_value = (int)obj2;
		_ = ((int*)num3)->m_value;
		((FollowingGuard.OnCatchPlayerDelegate)(object)_recycleBin)._002Ector((object)containerPivot, (IntPtr)1);
		int endDataIndexCursor = _endDataIndexCursor + 1;
		_endDataIndexCursor = endDataIndexCursor;
		if (onFinished != null)
		{
			((AdSystemEventLogger)containerPivot)._002Ector();
		}
	}

	public unsafe void SmoothScrollToItem(Transform target, ContainerPivot containerPivot = ContainerPivot.Center, Action onFinished = null)
	{
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected Obj, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected VT, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected Obj, but got Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected Obj, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected Obj, but got Unknown
		//IL_051f: Expected Obj, but got I4
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected Obj, but got Unknown
		//IL_053c: Expected Obj, but got I4
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected Obj, but got Unknown
		//IL_0333: Expected VT, but got Obj
		//IL_0346: Expected I, but got Obj
		//IL_035c: Expected Obj, but got I
		//IL_0103: Expected VT, but got Obj
		//IL_068b: Expected Obj, but got F4
		//IL_069d: Expected I4, but got F4
		//IL_06aa: Expected I4, but got Obj
		//IL_0116: Expected I, but got Obj
		//IL_012c: Expected Obj, but got I
		//IL_0431: Expected Obj, but got I4
		//IL_0440: Expected Obj, but got F4
		//IL_0387: Expected I, but got Obj
		//IL_05a3: Expected Obj, but got F4
		//IL_05b5: Expected I4, but got F4
		//IL_05c2: Expected I4, but got Obj
		//IL_06dd: Expected I, but got Obj
		//IL_06f3: Expected Obj, but got I
		//IL_03e4: Expected Obj, but got I4
		//IL_0408: Expected Obj, but got F4
		//IL_0201: Expected Obj, but got I4
		//IL_0210: Expected Obj, but got F4
		//IL_0157: Expected I, but got Obj
		//IL_07de: Expected F4, but got Obj
		//IL_07d9: Expected native int or pointer, but got VT
		//IL_07f3: Expected F4, but got I
		//IL_07ee: Expected native int or pointer, but got VT
		//IL_081d: Expected VT, but got Obj
		//IL_0845: Expected I4, but got Obj
		//IL_05f5: Expected I, but got Obj
		//IL_060b: Expected Obj, but got I
		//IL_01b4: Expected Obj, but got I4
		//IL_01d8: Expected Obj, but got F4
		//IL_046e: Expected I, but got Obj
		//IL_074f: Expected F4, but got Obj
		//IL_074a: Expected native int or pointer, but got VT
		//IL_0764: Expected F4, but got I
		//IL_075f: Expected native int or pointer, but got VT
		//IL_078e: Expected VT, but got Obj
		//IL_07b6: Expected I4, but got Obj
		//IL_023e: Expected I, but got Obj
		object obj = default;
		FPSLog fPSLog = (FPSLog)(obj + 72);
		Vector3 vector = (Vector3)(obj + 60);
		object obj2 = obj + 24;
		object obj3 = obj + 12;
		object obj4 = obj + 48;
		obj4 = 0;
		_ = 0;
		object obj5 = obj + 36;
		obj5 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj7 = default;
		object obj6 = obj7 + 16;
		object obj8 = default;
		obj6 = obj8;
		NullReferenceException ex = new NullReferenceException();
		if (ex != null)
		{
			((BiggerJackpotEventManager)(object)this).GetRibbonDescription(out *(string*)((Exception)ex)._remoteStackTraceString, out *(string*)(int)containerPivot, out *(string*)onFinished);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v24+8]");
		if ((nint)0 > (nint)_topDataIndexCursor)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			int num2 = _endDataIndexCursor;
			Container item = default;
			Container container = default;
			int modelType = default;
			while (true)
			{
				int num3 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v24+8]");
				if ((nint)num3 > (nint)0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				bool flag = ((_003C_003Ec__DisplayClass83_0)(object)_recycleBin)._003CSmoothScrollToIndex_003Eb__0(item);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				container.modelType = modelType;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				UIScrollView uIScrollView = uiScrollView;
				GameObject gameObject = uIScrollView.gameObject;
				container.SetScale((Vector3)gameObject);
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v118 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num5 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S0_v170 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 forward = Vector3.forward;
				fPSLog = (FPSLog)vector.x;
				fPSLog._logging = (byte)(int)vector.z != 0;
				container.SetModelType((int)fPSLog);
				if (_arrangement != Arrangement.Vertical)
				{
					obj2 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20+8]");
					_ = 0;
					obj3 = 0;
					_ = 0;
					float num6 = container.width + (float)cellSpaceX;
					obj3 = num6;
					_ = 0f;
				}
				else
				{
					obj2 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20+8]");
					_ = 0;
					obj3 = 0;
					_ = 0;
					obj3 = 0f;
					float num7 = container.height + (float)cellSpaceY;
				}
				_ = 0f;
				nint num8 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ S0_v131 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num9 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S0_v146 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector)->x = (float)obj2;
				Vector3 vector2 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Vector3*)(nint)vector2)->z = 0f;
				fPSLog = (FPSLog)obj3;
				FPSLog fPSLog2 = fPSLog;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				fPSLog2._logging = false;
				Quaternion quaternion = Quaternion.FromToRotation(vector, (Vector3)fPSLog);
				obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				((_003CAnimateSwapPositions_003Ed__86)(object)_recycleBin)._002Ector((int)container);
				int num10 = num2 + 1;
				num2 = num10;
			}
			fPSLog = (FPSLog)obj5;
			FPSLog fPSLog3 = fPSLog;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20+8]");
			fPSLog3._logging = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			int num11 = _topDataIndexCursor;
			Container item2 = default;
			Container container2 = default;
			int modelType2 = default;
			while (true)
			{
				int num12 = num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v24+8]");
				if ((nint)num12 < (nint)0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				bool flag2 = ((_003C_003Ec__DisplayClass83_0)(object)_recycleBin)._003CSmoothScrollToIndex_003Eb__0(item2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				container2.modelType = modelType2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				UIScrollView uIScrollView2 = uiScrollView;
				GameObject gameObject2 = uIScrollView2.gameObject;
				container2.SetScale((Vector3)gameObject2);
				nint num13 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v49 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num14 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v101 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 forward2 = Vector3.forward;
				fPSLog = (FPSLog)vector.x;
				fPSLog._logging = (byte)(int)vector.z != 0;
				container2.SetModelType((int)fPSLog);
				if (_arrangement != Arrangement.Vertical)
				{
					obj2 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					_ = 0;
					obj3 = 0;
					_ = 0;
					float num15 = container2.width + (float)cellSpaceX;
					obj3 = num15;
					_ = 0f;
				}
				else
				{
					obj2 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					_ = 0;
					obj3 = 0;
					_ = 0;
					obj3 = 0f;
					float num16 = container2.height + (float)cellSpaceY;
				}
				_ = 0f;
				nint num17 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S0_v62 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num18 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S0_v77 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector)->x = (float)obj2;
				Vector3 vector3 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Vector3*)(nint)vector3)->z = 0f;
				fPSLog = (FPSLog)obj3;
				FPSLog fPSLog4 = fPSLog;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				fPSLog4._logging = false;
				Vector3 vector4 = vector - (Vector3)fPSLog;
				obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				((_003CAnimateSwapPositions_003Ed__86)(object)_recycleBin)._002Ector((int)container2);
				int num19 = num11 - 1;
				num11 = num19;
			}
			fPSLog = (FPSLog)obj4;
			FPSLog fPSLog5 = fPSLog;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			fPSLog5._logging = false;
		}
		KeyValuePair<bool, string> keyValuePair = fPSLog.SendRequest((string)(object)onFinished, 8f);
	}

	private unsafe void SmoothScrollToOffset(Vector3 localOffset, Action onFinished, float strength = 8f)
	{
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected I4, but got Unknown
		//IL_0104: Expected I4, but got Obj
		//IL_000e: Invalid comparison between VT and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_005b: Invalid comparison between Obj and VT
		//IL_0169: Expected VT, but got Obj
		//IL_0169: Expected I4, but got VT
		//IL_0181: Expected I, but got Obj
		//IL_0197: Expected Obj, but got I
		//IL_0036: Expected VT, but got I4
		//IL_01ca: Expected I4, but got Obj
		//IL_01e4: Expected Obj, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected VT, but got Unknown
		//IL_00ad: Expected I, but got Obj
		object obj = default;
		bool flag = (byte)(obj + 12) != 0;
		if (_adapter != null)
		{
			Vector3 vector = default;
			if (vector < (object)0)
			{
				vector = (Vector3)0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj3 = default;
				object obj2 = obj3 - 1;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref vector))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					object obj4 = default;
					Vector3 vector2 = (Vector3)(obj4 - 1);
					vector = vector2;
				}
			}
			((Curve)(object)this).MoveKey((int)vector, strength, (Vector3)onFinished);
			ScrollDirection scrollDirection = this.scrollDirection;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v15 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v23 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			((UIScrollView)scrollDirection).UpdateScrollbars(flag);
		}
		else
		{
			UnityEngine.Object values = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
			string msg = string.ConcatArray((string[])(object)values, (int)" : Set the adapter first.");
			string args = tag;
			SDebug.LogFormat(msg, (object[])(object)args);
		}
	}

	public unsafe IEnumerator AnimateSwapPositions(int dataPosition1, int dataPosition2, float time, Action onComplete = null)
	{
		//IL_000d: Expected F4, but got Obj
		//IL_0008: Expected native int or pointer, but got VT
		//IL_001f: Expected F4, but got I
		//IL_001a: Expected native int or pointer, but got VT
		//IL_0048: Expected Obj, but got I4
		Vector3 vector = default;
		((Vector3*)(nint)vector)->x = (float)onComplete;
		((Vector3*)(nint)vector)->z = (nint)((Delegate)onComplete).method_ptr;
		return ((Sound)(object)this).playAudioClip((AudioClip)dataPosition1, (AudioRolloffMode)dataPosition2, time, time, 1f, 1f, vector, false);
	}

	public void Recenter()
	{
	}

	private unsafe void FillFromIndex(int i, float topOffset, ContainerPivot containerPivot = ContainerPivot.None)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001e: Expected Obj, but got I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected VT, but got Unknown
		//IL_003e: Expected F4, but got Obj
		//IL_0039: Expected native int or pointer, but got VT
		//IL_0050: Expected F4, but got I
		//IL_004b: Expected native int or pointer, but got VT
		GameObject gameObject = ((Component)i).gameObject;
		SocialManager socialManager = default;
		socialManager.ReportAchievement((string)i, topOffset);
		Vector3 vector = (Vector3)(socialManager + 12);
		((Vector3*)(nint)vector)->x = (float)socialManager;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)socialManager).m_CachedPtr;
		Vector3 vector2 = ((Transform)(object)gameObject).InverseTransformPoint(vector);
	}

	private void CheckScrollState()
	{
		//IL_0071: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_centerOnChild).FindKernel((string)null) != 0)
		{
			_centerOnChild._002Ector();
		}
	}

	private unsafe bool ShouldRecycleContainer(Container container)
	{
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected VT, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected VT, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected I4, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected Obj, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected Obj, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected Obj, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected Obj, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected Obj, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected Obj, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected Obj, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected Obj, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected Obj, but got Unknown
		//IL_04f8: Expected Obj, but got I
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected Obj, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected Obj, but got Unknown
		//IL_03ef: Expected I4, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0050: Expected VT, but got Obj
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_0546: Expected F4, but got Obj
		//IL_0541: Expected native int or pointer, but got VT
		//IL_0558: Expected F4, but got I
		//IL_0553: Expected native int or pointer, but got VT
		//IL_0565: Expected F4, but got Obj
		//IL_0560: Expected native int or pointer, but got VT
		//IL_057a: Expected F4, but got I
		//IL_0575: Expected native int or pointer, but got VT
		//IL_0102: Expected F4, but got Obj
		//IL_00fd: Expected native int or pointer, but got VT
		//IL_0117: Expected F4, but got I
		//IL_0112: Expected native int or pointer, but got VT
		//IL_0131: Expected F4, but got Obj
		//IL_012c: Expected native int or pointer, but got VT
		//IL_0146: Expected F4, but got I
		//IL_0141: Expected native int or pointer, but got VT
		//IL_00b6: Expected I, but got Obj
		//IL_0176: Expected VT, but got Obj
		//IL_0188: Expected F4, but got Obj
		//IL_0183: Expected native int or pointer, but got VT
		//IL_019d: Expected F4, but got I
		//IL_0198: Expected native int or pointer, but got VT
		//IL_01aa: Expected F4, but got Obj
		//IL_01a5: Expected native int or pointer, but got VT
		//IL_01bc: Expected F4, but got I
		//IL_01b7: Expected native int or pointer, but got VT
		//IL_01da: Expected F4, but got Obj
		//IL_01d5: Expected native int or pointer, but got VT
		//IL_01ef: Expected F4, but got I
		//IL_01ea: Expected native int or pointer, but got VT
		//IL_0204: Expected F4, but got I
		//IL_0239: Expected F4, but got Obj
		//IL_0234: Expected native int or pointer, but got VT
		//IL_024e: Expected F4, but got I
		//IL_0249: Expected native int or pointer, but got VT
		//IL_027e: Expected VT, but got Obj
		//IL_028b: Expected F4, but got Obj
		//IL_0286: Expected native int or pointer, but got VT
		//IL_02a0: Expected F4, but got I
		//IL_029b: Expected native int or pointer, but got VT
		//IL_02ad: Expected F4, but got Obj
		//IL_02a8: Expected native int or pointer, but got VT
		//IL_02bf: Expected F4, but got I
		//IL_02ba: Expected native int or pointer, but got VT
		//IL_02e2: Expected F4, but got Obj
		//IL_02dd: Expected native int or pointer, but got VT
		//IL_02f7: Expected F4, but got I
		//IL_02f2: Expected native int or pointer, but got VT
		//IL_030c: Expected F4, but got I
		//IL_031d: Expected I4, but got Obj
		//IL_0337: Expected F4, but got Obj
		//IL_0332: Expected native int or pointer, but got VT
		//IL_034c: Expected F4, but got I
		//IL_0347: Expected native int or pointer, but got VT
		//IL_0359: Expected F4, but got Obj
		//IL_0354: Expected native int or pointer, but got VT
		//IL_036e: Expected F4, but got I
		//IL_0369: Expected native int or pointer, but got VT
		//IL_038f: Expected I4, but got VT
		//IL_038f: Expected I4, but got VT
		//IL_038f: Expected F4, but got I
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_03ce: Expected F4, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj + 192);
		Vector3 vector2 = (Vector3)(obj + 180);
		bool flag = (byte)(obj + 168) != 0;
		Transform transform = (Transform)(obj + 156);
		object obj2 = obj + 144;
		object obj3 = obj + 132;
		object obj4 = obj + 120;
		object obj5 = obj + 108;
		object obj6 = obj + 96;
		Transform transform2 = (Transform)(obj + 84);
		object obj7 = obj + 72;
		object obj8 = obj + 60;
		object obj9 = obj + 48;
		object obj10 = obj + 36;
		Transform transform3 = (Transform)(obj + 24);
		object obj11 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		FixedRotation fixedRotation = default;
		fixedRotation.Awake();
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S2_v2 (Il2CppMethodInfo)+18]");
		object obj12 = 0;
		object obj13 = obj12;
		object obj14 = obj13 & 0x1FFF;
		object obj15 = obj14 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v99 @ S3_v4 (should have been resolved before IL gen)");
		object obj17 = default;
		object obj16 = obj17 + 12;
		Curve curve = default;
		Curve curve3 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<Curve, UIntPtr>(ref curve) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16))
		{
			object obj18 = obj17 + 16;
			object obj19 = (object)curve << 2;
			object obj20 = obj18 + obj19;
			Component component = (Component)obj20;
			GameObject gameObject = ((Component)obj20).gameObject;
			transform.localPosition = (Vector3)gameObject;
			obj2 = container;
			_ = container.onRecycleContainer;
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v60 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num3 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v119 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)transform;
			((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector3 = vector2 - vector;
			GameObject gameObject2 = ((Component)obj20).gameObject;
			Vector3 tangentOutPoint = ((CurvePoint)obj20).TangentOutPoint;
			((Vector3*)(nint)vector)->x = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Quaternion quaternion = Quaternion.Inverse((Quaternion)vector);
			((Vector3*)(nint)vector)->x = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector4 = ((Transform)(object)gameObject2).InverseTransformPoint(vector);
			GameObject gameObject3 = ((Component)obj20).gameObject;
			transform2.position = (Vector3)gameObject3;
			((Vector3*)(nint)vector2)->x = (float)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)transform2;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
			Quaternion quaternion2 = Quaternion.FromToRotation(vector2, vector);
			((Vector3*)(nint)vector)->x = (float)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v54 (UnityEngine.Component)+1C]");
			Vector3 vector5 = vector / 0f;
			GameObject gameObject4 = ((Component)obj20).gameObject;
			Bounds bounds = ((KUIScrollView)obj20).bounds;
			((Vector3*)(nint)vector)->x = (float)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector6 = ((Transform)(object)gameObject4).InverseTransformPoint(vector);
			GameObject gameObject5 = ((Component)obj20).gameObject;
			transform3.position = (Vector3)gameObject5;
			((Vector3*)(nint)vector2)->x = (float)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)transform3;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
			Quaternion quaternion3 = Quaternion.FromToRotation(vector2, vector);
			((Vector3*)(nint)vector)->x = (float)obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v54 (UnityEngine.Component)+1C]");
			Vector3 vector7 = vector / 0f;
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj3 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			_ = 0;
			((Vector3*)(nint)vector2)->x = (float)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v54 (UnityEngine.Component)+C]");
			((ParticleSystem)(object)fixedRotation).Simulate(0f, flag, (byte)(int)vector2 != 0, (byte)(int)vector != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v54 (UnityEngine.Component)+10]");
			if ((nint)0 != 0)
			{
				Curve curve2 = curve;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v54 (UnityEngine.Component)+1C]");
				Vector3 vector8 = curve2.Evaluate(0f);
			}
			curve = (Curve)(curve3 + 1);
		}
		return (byte)(int)fixedRotation != 0;
	}

	private bool ShouldAppendContainer(Container container)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_00b1: Expected VT, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_00da: Invalid comparison between Obj and F4
		//IL_0060: Expected Obj, but got I
		//IL_006d: Invalid comparison between Obj and F4
		//IL_01fd: Expected VT, but got Obj
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_014b: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_029a: Invalid comparison between Obj and F4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_01c4: Invalid comparison between Obj and F4
		object obj = default;
		Transform transform = (Transform)(obj + 32);
		object obj2 = obj + 16;
		bool result;
		if (_arrangement == Arrangement.Horizontal)
		{
			UIScrollView uIScrollView = uiScrollView;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v48 (UIScrollView)+104]");
			transform = (Transform)0;
			if (System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)container.right))
			{
				goto IL_0107;
			}
			result = true;
		}
		else
		{
			UIPanel uIPanel = rootPanel;
			transform.localPosition = (Vector3)uIPanel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5 (UnityEngine.Transform)+4]");
			object obj3 = (nint)0 + (nint)cellSpaceY;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)container.bottom))
			{
				goto IL_0107;
			}
			result = true;
		}
		goto IL_02ca;
		IL_02ca:
		return result;
		IL_02b7:
		result = false;
		goto IL_02ca;
		IL_0107:
		if (_arrangement == Arrangement.Horizontal)
		{
			UIScrollView uIScrollView2 = uiScrollView;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v27 (UIScrollView)+104]");
			transform = (Transform)0;
			UIScrollView uIScrollView3 = uiScrollView;
			object obj4 = uIScrollView3 + 220;
			obj2 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v31+8]");
			_ = 0;
			object obj5 = container + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			object obj6 = transform2 + 0;
			object obj7 = obj6 - obj;
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)container.left);
			result = true;
			if (!flag)
			{
				goto IL_02b7;
			}
		}
		else
		{
			UIPanel uIPanel2 = rootPanel;
			transform.localPosition = (Vector3)uIPanel2;
			UIScrollView uIScrollView4 = uiScrollView;
			object obj8 = uIScrollView4 + 220;
			obj2 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v15+8]");
			_ = 0;
			object obj9 = container + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5 (UnityEngine.Transform)+4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			object obj10 = num + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj11 = obj10 - 0;
			object obj12 = obj11 + cellSpaceX;
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)container.top);
			result = true;
			if (!flag2)
			{
				goto IL_02b7;
			}
		}
		goto IL_02ca;
	}

	private bool ShouldPrependContainer(Container container)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00df: Expected VT, but got Obj
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_012e: Expected Obj, but got I
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_014a: Invalid comparison between Obj and F4
		//IL_0047: Expected Obj, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_009b: Invalid comparison between Obj and F4
		object obj = default;
		Transform transform = (Transform)(obj + 16);
		if (_arrangement != Arrangement.Vertical)
		{
			UIScrollView uIScrollView = uiScrollView;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v18 (UIScrollView)+104]");
			transform = (Transform)0;
			UIScrollView uIScrollView2 = uiScrollView;
			object obj2 = uIScrollView2 + 220;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S2_v15+8]");
			_ = 0;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			object obj3 = transform2 + 0;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)container.right))
			{
				return true;
			}
		}
		else
		{
			UIPanel uIPanel = rootPanel;
			transform.localPosition = (Vector3)uIPanel;
			UIScrollView uIScrollView3 = uiScrollView;
			object obj4 = uIScrollView3 + 220;
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S2_v8+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5 (UnityEngine.Transform)+4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
			object obj5 = num + 0;
			object obj6 = obj5 - cellSpaceY;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)container.bottom))
			{
				return true;
			}
		}
		return false;
	}

	private void HandleScrollDown()
	{
		//IL_02e9: Expected I, but got Obj
		//IL_02ff: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_0155: Expected VT, but got Obj
		//IL_016c: Expected F4, but got I
		//IL_012f: Expected Obj, but got I
		//IL_0139: Expected F4, but got Obj
		//IL_0241: Expected I, but got Obj
		//IL_0257: Expected Obj, but got I
		//IL_0282: Expected I, but got Obj
		UIScrollView uIScrollView = uiScrollView;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v49 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (uIScrollView != null)
		{
			return;
		}
		UIPanel uIPanel = rootPanel;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v56 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (uIPanel != null)
		{
			return;
		}
		_previousPos = _currentPos;
		if (_arrangement != Arrangement.Vertical)
		{
			UIScrollView uIScrollView2 = uiScrollView;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v52 (UIScrollView)+104]");
			Transform transform = (Transform)0;
			_currentPos = (float)transform;
		}
		else
		{
			UIPanel uIPanel2 = rootPanel;
			Transform transform = default;
			transform.localPosition = (Vector3)uIPanel2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
			_currentPos = 0f;
		}
		float movementDelta = _currentPos - _previousPos;
		_movementDelta = movementDelta;
		if (~(press ? 1u : 0u) == 0)
		{
			float cumulativeDelta = _cumulativeDelta + _movementDelta;
			_cumulativeDelta = cumulativeDelta;
		}
		if (!(_movementDelta < 0f))
		{
			if (!(_movementDelta > 0f))
			{
				nint num5 = (nint)typeof(Math);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v24 (Il2CppClass<System.Math>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(Math);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v30 (Il2CppClass<System.Math>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (_movementDelta == 0f)
				{
					_scrollDirection = ScrollDirection.Stationary;
				}
			}
			else
			{
				ScrollDirection scrollDirection = ((_arrangement != Arrangement.Vertical) ? ScrollDirection.Left : ScrollDirection.Up);
				_scrollDirection = scrollDirection;
			}
		}
		else
		{
			ScrollDirection scrollDirection2 = ((_arrangement == Arrangement.Vertical) ? ScrollDirection.Down : ScrollDirection.Right);
			_scrollDirection = scrollDirection2;
		}
	}

	private void HandleScrollUp()
	{
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		//IL_084f: Expected Obj, but got Unknown
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected Obj, but got Unknown
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Expected Obj, but got Unknown
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected Obj, but got Unknown
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected Obj, but got Unknown
		//IL_0890: Expected Obj, but got I4
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Expected Obj, but got Unknown
		//IL_08ad: Expected Obj, but got I4
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected Obj, but got Unknown
		//IL_08ca: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0168: Expected I4, but got Obj
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected I4, but got Unknown
		//IL_01ea: Expected I4, but got Obj
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_02b2: Expected Obj, but got VT
		//IL_02cc: Expected VT, but got Obj
		//IL_06a1: Expected Obj, but got VT
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected Obj, but got Unknown
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected Obj, but got Unknown
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected Obj, but got Unknown
		//IL_0753: Expected Obj, but got I
		//IL_0790: Expected Obj, but got F4
		//IL_07b7: Expected VT, but got Obj
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected Obj, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected Obj, but got Unknown
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected Obj, but got Unknown
		//IL_0518: Expected Obj, but got F4
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected Obj, but got Unknown
		//IL_0573: Expected Obj, but got F4
		//IL_090e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Expected Obj, but got Unknown
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Expected Obj, but got Unknown
		//IL_048b: Expected Obj, but got F4
		//IL_04d8: Expected Obj, but got F4
		object obj2 = default;
		object obj = obj2 + 76;
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 40;
		object obj5 = obj2 + 24;
		object obj6 = obj2 - -64;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 52;
		obj7 = 0;
		_ = 0;
		object obj8 = obj2 + 16;
		obj8 = 0;
		if (_recycleBin == null)
		{
			return;
		}
		RecycleBin recycleBin = _recycleBin;
		List<Container> activeContainers = recycleBin.activeContainers;
		if (activeContainers._size <= 0)
		{
			return;
		}
		while (true)
		{
			RecycleBin recycleBin2 = _recycleBin;
			RecycleBin recycleBin3 = _recycleBin;
			List<Container> activeContainers2 = recycleBin3.activeContainers;
			int index = activeContainers2._size - 1;
			Container container = recycleBin2.activeContainers.get_Item(index);
			if (!ShouldAppendContainer(container))
			{
				break;
			}
			RecycleBin recycleBin4 = _recycleBin;
			List<Container> activeContainers3 = recycleBin4.activeContainers;
			object obj9 = activeContainers3._size - 1;
			if ((nint)obj9 < 1)
			{
				break;
			}
			RecycleBin recycleBin5 = _recycleBin;
			RecycleBin recycleBin6 = _recycleBin;
			List<Container> activeContainers4 = recycleBin6.activeContainers;
			int index2 = activeContainers4._size - 1;
			Container container2 = recycleBin5.activeContainers.get_Item(index2);
			object obj10 = container2 - -64;
			_endDataIndexCursor = (int)obj10;
			RecycleBin recycleBin7 = _recycleBin;
			List<Container> activeContainers5 = recycleBin7.activeContainers;
			int modelType = activeContainers5._size - 1;
			Container scrapContainer = _recycleBin.GetScrapContainer(modelType);
			if (scrapContainer.onRecycleContainer != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			}
			((_003CAnimateSwapPositions_003Ed__86)(object)_recycleBin)._002Ector((int)scrapContainer);
			RecycleBin recycleBin8 = _recycleBin;
			List<Container> activeContainers6 = recycleBin8.activeContainers;
			if (activeContainers6._size < 1)
			{
				SDebug.LogFormat("Recycle bin has no active containers# Handle scroll up  #", null);
				continue;
			}
			object obj11 = this + 104;
			RecycleBin recycleBin9 = _recycleBin;
			RecycleBin recycleBin10 = _recycleBin;
			List<Container> activeContainers7 = recycleBin10.activeContainers;
			int index3 = activeContainers7._size - 1;
			Container container3 = recycleBin9.activeContainers.get_Item(index3);
			obj11 = container3;
			Container bottomActiveContainer = _bottomActiveContainer;
			obj2 = bottomActiveContainer.coordinates;
			obj3 = obj2;
			obj = obj3;
			_nextAppendPosition = (Vector2)obj;
		}
		Container item = default;
		Container container5 = default;
		while (true)
		{
			RecycleBin recycleBin11 = _recycleBin;
			Container charactersList = recycleBin11.activeContainers.get_Item(0);
			List<string> list = ((CharacterNameEventManager)(object)this).CreateNewCategoryWordsDict((List<Characters.CharacterId>)(object)charactersList);
			if (list == null || _topDataIndexCursor < 0)
			{
				break;
			}
			RecycleBin recycleBin12 = _recycleBin;
			Container container4 = recycleBin12.activeContainers.get_Item(0);
			if (container4.modelType == -100)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			bool flag = ((_003C_003Ec__DisplayClass83_0)(object)_recycleBin)._003CSmoothScrollToIndex_003Eb__0(item);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
			if (container5 == null)
			{
				continue;
			}
			AppendContainer(_topDataIndexCursor, container5, setPosition: true);
			if (_currentMinListCount <= _topDataIndexCursor)
			{
				continue;
			}
			if (boundsCalculationMode == BoundsCalculationMode.Incremental)
			{
				object obj12 = this + 76;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
				obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				object obj13 = this + 76;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
				obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				if (_arrangement != Arrangement.Vertical)
				{
					float num = container5.width + (float)cellSpaceX;
					float num2 = (float)obj6 + num;
					obj6 = num2;
					float num3 = container5.width * 0.5f;
					float num4 = (float)cellSpaceX * 0.5f;
					float num5 = num3 + num4;
					float num6 = (float)obj7 - num5;
					obj7 = num6;
				}
				else
				{
					object obj14 = obj6 + 4;
					float num7 = container5.height + (float)cellSpaceY;
					float num8 = (float)obj14 + num7;
					obj14 = num8;
					Container container6 = (Container)(obj7 + 4);
					float num9 = container5.height * 0.5f;
					float num10 = (float)cellSpaceY * 0.5f;
					float num11 = num9 + num10;
					float num12 = (float)container6 + num11;
					container6 = (Container)num12;
				}
				obj = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				_ = 0;
				object obj15 = this + 76;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A5");
				obj = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20+8]");
				_ = 0;
				object obj16 = this + 76;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A1");
			}
			_currentMinListCount = _topDataIndexCursor;
		}
		if (_infinite == Infinite.BothWays && _topDataIndexCursor <= -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj17 = default;
			int topDataIndexCursor = obj17 - 1;
			_topDataIndexCursor = topDataIndexCursor;
		}
		if (~(pullDownToRefreshList ? 1u : 0u) == 0 && _pullDownToRefreshState == PullDownToRefreshState.PullDown && _topDataIndexCursor == -1 && ~(_refreshingContainerAdded ? 1u : 0u) != 0)
		{
			UpdatePullDownToRefreshContainer();
			Container lastVisibleContainerOnScreen = GetLastVisibleContainerOnScreen();
			obj8 = lastVisibleContainerOnScreen.coordinates;
			object obj18 = obj8 + 4;
			Container container7 = pullDownToRefreshContainer;
			Container lastVisibleContainerOnScreen2 = GetLastVisibleContainerOnScreen();
			object obj19 = pullDownToRefreshContainer + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			Container lastVisibleContainerOnScreen3 = GetLastVisibleContainerOnScreen();
			object obj20 = lastVisibleContainerOnScreen3 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			float num13 = container7.height * 0.5f;
			float num14 = lastVisibleContainerOnScreen2.height * 0.5f;
			float num15 = num13 + num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj21 = -0;
			float num16 = num15 + (float)obj21;
			float num17 = num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
			float num18 = num17 + 0f;
			float num19 = (float)obj18 + num18;
			obj18 = num19;
			Container container8 = pullDownToRefreshContainer;
			obj5 = obj8;
			obj = obj5;
			container8.coordinates = (Vector2)obj;
			Container container9 = pullDownToRefreshContainer;
			Container lastVisibleContainerOnScreen4 = GetLastVisibleContainerOnScreen();
			container9.bottom = lastVisibleContainerOnScreen4.top;
			Container container10 = pullDownToRefreshContainer;
			Container container11 = pullDownToRefreshContainer;
			Container container12 = pullDownToRefreshContainer;
			float top = container11.bottom - container12.height;
			container10.top = top;
			((AdSystemEventLogger)(object)pullDownToRefreshContainer)._002Ector();
			_refreshingContainerAdded = true;
		}
	}

	private void CalculateVirtualRelativeWidgetBounds(BoundsCalculationMode mode)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0042: Expected Obj, but got I4
		//IL_0064: Expected VT, but got I4
		if (_recycleBin != null)
		{
			_recycleBin.ScrapActiveContainers();
		}
		object obj = this + 72;
		obj = mode;
		_dataChangedDelegatesAdded = false;
		Start();
		SmoothScrollToOffset((Vector3)0, null, 0f);
		ScrollDirection scrollDirection = this.scrollDirection;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	public Container GetFirstVisibleContainerOnScreen()
	{
		//IL_0016: Expected Obj, but got I4
		bool flag = _infinite == Infinite.BothWays;
		return (Container)flag;
	}

	public Container GetLastVisibleContainerOnScreen()
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		if (_recycleBin != null)
		{
			RecycleBin recycleBin = _recycleBin;
			if (recycleBin.activeContainers == null)
			{
				SDebug.LogFormat("GetFirstVisibleContainerOnScreen: activeContainers was null!", null);
			}
			else
			{
				RecycleBin recycleBin2 = _recycleBin;
				List<Container> activeContainers = recycleBin2.activeContainers;
				if (activeContainers._size > 0)
				{
					RecycleBin recycleBin3 = _recycleBin;
					Container container = recycleBin3.activeContainers.get_Item(0);
					if (container != null)
					{
						object obj = this + 140;
						RecycleBin recycleBin4 = _recycleBin;
						Container container2 = recycleBin4.activeContainers.get_Item(0);
						obj = container2;
					}
					else
					{
						SDebug.LogFormat("GetFirstVisibleContainerOnScreen: _recycleBin.activeContainers[0] was null!", null);
					}
				}
			}
		}
		else
		{
			SDebug.LogFormat("GetFirstVisibleContainerOnScreen: _recycleBin was null!", null);
		}
		return _firstVisibleContainer;
	}

	public List<Container> GetActiveContainers()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		RecycleBin recycleBin = _recycleBin;
		List<Container> activeContainers = recycleBin.activeContainers;
		if (activeContainers._size > 0)
		{
			object obj = this + 144;
			RecycleBin recycleBin2 = _recycleBin;
			RecycleBin recycleBin3 = _recycleBin;
			List<Container> activeContainers2 = recycleBin3.activeContainers;
			int index = activeContainers2._size - 1;
			Container container = recycleBin2.activeContainers.get_Item(index);
			obj = container;
		}
		return (List<Container>)(object)_lastVisibleContainer;
	}

	public unsafe static void Log(string msg)
	{
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected Obj, but got Unknown
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected Obj, but got Unknown
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected Obj, but got Unknown
		//IL_071b: Expected Obj, but got I4
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected Obj, but got Unknown
		//IL_0738: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_077e: Expected Obj, but got I
		//IL_078e: Expected Obj, but got I
		//IL_079e: Expected Obj, but got I
		//IL_07c9: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0154: Expected Obj, but got I
		//IL_02c7: Expected Obj, but got I
		//IL_01a3: Expected I4, but got Obj
		//IL_01a3: Expected Obj, but got I
		//IL_01b3: Expected Obj, but got I
		//IL_01c3: Expected Obj, but got I
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0206: Expected Obj, but got I
		//IL_021c: Expected Obj, but got I
		//IL_0238: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I
		//IL_0315: Expected Obj, but got I4
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected Obj, but got Unknown
		//IL_05f2: Expected Obj, but got I
		//IL_065d: Expected Obj, but got F4
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081a: Expected Obj, but got Unknown
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Expected Obj, but got Unknown
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected Obj, but got Unknown
		//IL_05d0: Expected Obj, but got F4
		//IL_04e3: Expected Obj, but got I
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected I4, but got Unknown
		//IL_0566: Expected I4, but got F4
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected I4, but got Unknown
		//IL_04c1: Expected I4, but got F4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 36;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 24;
		obj5 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+64]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+64]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v25+8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v26+C]");
		if ((nint)0 <= (nint)0)
		{
			return;
		}
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+64]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v15+8]");
			Container container = ((List<Container>)0).get_Item(0);
			if (((ScrollView)(object)msg).ShouldAppendContainer(container))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+64]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v108+8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v109+C]");
				object obj11 = -1;
				if ((nint)obj11 >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+64]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v95+8]");
					Container container2 = ((List<Container>)0).get_Item(0);
					object obj13 = container2 - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+64]");
					Container scrapContainer = ((RecycleBin)0).GetScrapContainer(0);
					if (scrapContainer.onRecycleContainer != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+64]");
					((_003CAnimateSwapPositions_003Ed__86)0)._002Ector((int)scrapContainer);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+64]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v124+8]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v125+C]");
					if ((nint)0 >= (nint)1)
					{
						object obj16 = msg + 108;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+64]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S1_v107+8]");
						Container container3 = ((List<Container>)0).get_Item(0);
						obj16 = container3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+6C]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S1_v111+1C]");
						obj2 = 0;
						obj3 = obj2;
						obj = obj3;
						continue;
					}
					SDebug.LogFormat("Recycle bin has no active containers# Handle scroll up  #", null);
					break;
				}
				break;
			}
			break;
		}
		object obj22 = default;
		Container item = default;
		ContainerPivot containerPivot = default;
		object obj26 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+64]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+64]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S2_v9+8]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S2_v10+C]");
			int index = (int)(-1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v20+8]");
			Container container4 = ((List<Container>)0).get_Item(index);
			if (!((ScrollView)(object)msg).ShouldPrependContainer(container4))
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+70]");
			if (0 >= (nint)obj22)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+64]");
			bool flag = ((_003C_003Ec__DisplayClass83_0)0)._003CSmoothScrollToIndex_003Eb__0(item);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
			if (containerPivot == ContainerPivot.Top)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+70]");
			((ScrollView)(object)msg).SmoothScrollToIndex(0, containerPivot, (Action)1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+B0]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+70]");
			if (num >= 0)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+BC]");
			if ((nint)0 == 1)
			{
				object obj23 = msg + 76;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
				obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				object obj24 = msg + 76;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
				obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				bool flag2 = msg.m_firstChar == '\0';
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj25 = obj26 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+70]");
				bool flag3 = 0 > (nint)obj25;
				if (flag2)
				{
					object obj27 = obj4 + 4;
					if (flag3)
					{
						object obj28 = obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v49 (ContainerPivot)+48]");
						object obj29 = obj28 + 0;
						obj27 = obj29;
						bool flag4 = (byte)(obj5 + 4) != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v49 (ContainerPivot)+48]");
						float num2 = 0f * 0.5f;
						float num3 = (float)(((bool*)(flag4 ? 1 : 0))->m_value ? 1 : 0) - num2;
						((bool*)(flag4 ? 1 : 0))->m_value = (byte)(int)num3 != 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v49 (ContainerPivot)+48]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+10]");
						object obj30 = num4 + 0;
						object obj31 = obj27 + obj30;
						obj27 = obj31;
						bool flag5 = (byte)(obj5 + 4) != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v49 (ContainerPivot)+48]");
						float num5 = 0f * 0.5f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+10]");
						float num6 = 0f * 0.5f;
						float num7 = num5 + num6;
						float num8 = (float)(((bool*)(flag5 ? 1 : 0))->m_value ? 1 : 0) - num7;
						((bool*)(flag5 ? 1 : 0))->m_value = (byte)(int)num8 != 0;
					}
				}
				else if (flag3)
				{
					object obj32 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v49 (ContainerPivot)+4C]");
					object obj33 = obj32 + 0;
					obj4 = obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v49 (ContainerPivot)+4C]");
					float num9 = 0f * 0.5f;
					float num10 = (float)obj5 + num9;
					obj5 = num10;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v49 (ContainerPivot)+4C]");
					nint num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+14]");
					object obj34 = num11 + 0;
					object obj35 = obj4 + obj34;
					obj4 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v49 (ContainerPivot)+4C]");
					float num12 = 0f * 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+14]");
					float num13 = 0f * 0.5f;
					float num14 = num12 + num13;
					float num15 = (float)obj5 + num14;
					obj5 = num15;
				}
				obj = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				_ = 0;
				object obj36 = msg + 76;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A5");
				obj = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+8]");
				_ = 0;
				object obj37 = msg + 76;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A1");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+70]");
			_ = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+70]");
		object obj38 = default;
		if (0 == (nint)obj38)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+20]");
			if ((nint)0 == 1)
			{
				_ = 0;
			}
		}
	}
}
