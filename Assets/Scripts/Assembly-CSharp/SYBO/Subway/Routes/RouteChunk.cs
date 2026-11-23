using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Level;
using SYBO.Subway.Managers;
using SYBO.Subway.Routes.Builders;
using SYBO.Subway.Themes;
using SYBO.Subway.Utilities;
using UnityEngine;

namespace SYBO.Subway.Routes;

public class RouteChunk : MonoBehaviour
{
	public class ChunkBlockConstraint
	{
		public readonly EnvironmentKind EnvironmentKind;

		public readonly EnvironmentBaseKind EnvironmentBaseKind;

		public static readonly ChunkBlockConstraint None;

		public ChunkBlockConstraint(EnvironmentKind envKind, EnvironmentBaseKind envBaseKind)
		{
			//IL_0023: Expected VT, but got I4
			EnvironmentKind = envKind;
			_ = envBaseKind.NumTracks;
			EnvironmentBaseKind = (EnvironmentBaseKind)envBaseKind.Type;
		}

		public static bool operator ==(ChunkBlockConstraint c1, ChunkBlockConstraint c2)
		{
			//IL_0008: Expected I, but got Obj
			nint num = (nint)c1;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S2_v2 (Il2CppClass<SYBO.Subway.Routes.RouteChunk+ChunkBlockConstraint>)+BC] (should have been resolved before IL gen)");
			bool result = default;
			return result;
		}

		public static bool operator !=(ChunkBlockConstraint c1, ChunkBlockConstraint c2)
		{
			//IL_0008: Expected I, but got Obj
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected I4, but got Unknown
			nint num = (nint)c1;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S2_v2 (Il2CppClass<SYBO.Subway.Routes.RouteChunk+ChunkBlockConstraint>)+BC] (should have been resolved before IL gen)");
			object obj = default;
			return (byte)(obj ^ 1) != 0;
		}

		public unsafe override bool Equals(object other)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_002d: Expected Obj, but got I
			//IL_00e9: Expected native int or pointer, but got VT
			//IL_010b: Expected native int or pointer, but got VT
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Expected VT, but got Unknown
			object obj = default;
			EnvironmentBaseKind environmentBaseKind = (EnvironmentBaseKind)(obj + -64);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			object obj2 = default;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v15+8]");
				object obj3 = 0;
				EnvironmentKind environmentKind = EnvironmentKind;
				EnvironmentType type = environmentKind._type;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v16+8]");
				bool flag;
				if ((nint)type == (nint)0)
				{
					EnvironmentDensity density = environmentKind._density;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v16+C]");
					flag = (nint)density == (nint)0;
				}
				else
				{
					flag = false;
				}
				if (flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteChunk+ChunkBlockConstraint)+14]");
					_ = 0;
					_ = EnvironmentBaseKind;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v15+14]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v15+C]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+28]");
					((EnvironmentBaseKind*)(nint)environmentBaseKind)->NumTracks = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+30]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+20]");
					((EnvironmentBaseKind*)(nint)environmentBaseKind)->Type = EnvironmentBaseType.None;
					EnvironmentBaseKind environmentBaseKind2 = (EnvironmentBaseKind)(environmentBaseKind + 16);
					return environmentBaseKind2 == environmentBaseKind;
				}
			}
			bool result = default;
			return result;
		}

		public override int GetHashCode()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0025: Expected I, but got Obj
			//IL_0046: Expected Obj, but got VT
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected Obj, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected Obj, but got Unknown
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected Obj, but got Unknown
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected Obj, but got Unknown
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected Obj, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected I4, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			EnvironmentKind environmentKind = EnvironmentKind;
			nint num = (nint)environmentKind;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S1_v4 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+CC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteChunk+ChunkBlockConstraint)+14]");
			_ = 0;
			obj = EnvironmentBaseKind;
			object obj3 = obj * 29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj4 = 0 + obj3;
			object obj5 = obj4 * 29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj6 = 0 + obj5;
			object obj8 = default;
			object obj7 = obj8 * 29;
			object obj9 = obj6 + obj7;
			return obj9 + 428910;
		}

		static ChunkBlockConstraint()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0021: Expected I, but got Obj
			//IL_0061: Expected Obj, but got I
			//IL_0088: Expected VT, but got Obj
			object obj2 = default;
			object obj = obj2 - 32;
			EnvironmentKind none = EnvironmentKind.None;
			nint num = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v4 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v5 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8C]");
			_ = 0;
			_ = EnvironmentBaseKind.Tracks3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			obj = 0;
			ChunkBlockConstraint chunkBlockConstraint = default;
			chunkBlockConstraint.EnvironmentKind = none;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			chunkBlockConstraint.EnvironmentBaseKind = (EnvironmentBaseKind)obj;
			None = chunkBlockConstraint;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<EnvironmentBase> _003C_003E9__77_0;

		public static Comparison<SYBO.Subway.Level.Environment> _003C_003E9__77_1;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal int _003CAwake_003Eb__77_0(EnvironmentBase l, EnvironmentBase r)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00b7: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 80;
			Transform transform = l.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			_ = 0;
			Transform transform2 = r.transform;
			Vector3 position2 = transform2.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			bool flag = num < 0;
			int result = -1;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				bool flag2 = num2 > 0;
				result = 1;
				if (!flag2)
				{
					result = 0;
				}
			}
			return result;
		}

		internal int _003CAwake_003Eb__77_1(SYBO.Subway.Level.Environment l, SYBO.Subway.Level.Environment r)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00b7: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 80;
			Transform transform = l.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			_ = 0;
			Transform transform2 = r.transform;
			Vector3 position2 = transform2.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			bool flag = num < 0;
			int result = -1;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				bool flag2 = num2 > 0;
				result = 1;
				if (!flag2)
				{
					result = 0;
				}
			}
			return result;
		}
	}

	private sealed class _003CDestruct_003Ed__78(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public RouteChunk _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected Obj, but got Unknown
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Expected Obj, but got Unknown
			//IL_0179: Expected Obj, but got I4
			RouteChunk routeChunk = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0124;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				object obj = _003C_003E4__this + 72;
				if (routeChunk.Next != null)
				{
					object obj2 = obj;
					_ = 0;
				}
				routeChunk.Next = null;
				object obj3 = _003C_003E4__this + 68;
				if (routeChunk.Previous != null)
				{
					object obj4 = obj3;
					_ = 0;
				}
				obj3 = 0;
			}
			int childCount = routeChunk._environmentTransform.childCount;
			if (childCount <= 0)
			{
				routeChunk._built = false;
				goto IL_0124;
			}
			Transform child = routeChunk._environmentTransform.GetChild(0);
			PoolManager.Despawn(child);
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_0124:
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

	private sealed class _003CActivateTrackObjectsASync_003Ed__85(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public RouteChunk _003C_003E4__this;

		private int _003Cj_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00b5: Expected Obj, but got I4
			//IL_008e: Expected Obj, but got I4
			//IL_00f2: Expected Obj, but got I
			//IL_00a7: Expected Obj, but got I4
			//IL_0271: Expected Obj, but got I4
			//IL_00dd: Expected Obj, but got I4
			//IL_0138: Expected Obj, but got I
			//IL_02b6: Expected Obj, but got I
			//IL_0297: Expected Obj, but got I4
			//IL_02fd: Expected Obj, but got I
			//IL_025a: Expected Obj, but got I4
			//IL_041f: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 - 16;
			RouteChunk routeChunk = _003C_003E4__this;
			bool result;
			object obj3;
			object obj4;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						result = false;
						goto IL_044d;
					}
					_003C_003E1__state = -1;
					obj3 = 0;
					goto IL_045f;
				}
				_003C_003E1__state = -1;
				obj4 = 0;
			}
			else
			{
				_003Cj_003E5__2 = 0;
				_003C_003E1__state = -1;
				obj4 = 1;
			}
			object obj5 = obj4;
			int num = default;
			TrackObject trackObject;
			while (true)
			{
				if (obj5 == null)
				{
					num = ++_003Cj_003E5__2;
					obj5 = 1;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (SYBO.Subway.Routes.RouteChunk)+28]");
				object obj6 = 0;
				int num2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v39+C]");
				if ((nint)num2 >= (nint)0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (SYBO.Subway.Routes.RouteChunk)+28]");
				trackObject = ((List<TrackObject>)0).get_Item(_003Cj_003E5__2);
				if (trackObject == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					string name = routeChunk.name;
					throw new ArrayTypeMismatchException();
				}
				GameObject gameObject = trackObject.gameObject;
				if (gameObject.activeInHierarchy)
				{
					goto IL_023b;
				}
				obj5 = 0;
			}
			int num3 = 0;
			obj3 = 1;
			goto IL_045f;
			IL_044d:
			return result;
			IL_023b:
			int num4 = 1;
			TrackObject trackObject2 = trackObject;
			goto IL_0494;
			IL_045f:
			object obj7 = obj3;
			TrackObject trackObject3;
			while (true)
			{
				if (obj7 == null)
				{
					int num5 = _003Cj_003E5__2 + 1;
					num3 = num5;
					obj7 = 1;
					continue;
				}
				_003Cj_003E5__2 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (SYBO.Subway.Routes.RouteChunk)+2C]");
				object obj8 = 0;
				int num6 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S1_v11+C]");
				bool flag = (nint)num6 >= (nint)0;
				result = false;
				if (flag)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (SYBO.Subway.Routes.RouteChunk)+2C]");
				trackObject3 = ((List<TrackObject>)0).get_Item(_003Cj_003E5__2);
				if (trackObject3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					string name2 = routeChunk.name;
					throw new ArrayTypeMismatchException();
				}
				GameObject gameObject2 = trackObject3.gameObject;
				if (gameObject2.activeInHierarchy)
				{
					goto IL_0400;
				}
				obj7 = 0;
			}
			goto IL_044d;
			IL_0494:
			trackObject2.Activate();
			_003C_003E2__current = null;
			_003C_003E1__state = num4;
			result = true;
			goto IL_044d;
			IL_0400:
			num4 = 2;
			trackObject2 = trackObject3;
			goto IL_0494;
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

	private sealed class _003CDeactivateTrackObjects_003Ed__86(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public RouteChunk _003C_003E4__this;

		private int _003Cj_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0071: Expected Obj, but got I
			//IL_00e0: Expected Obj, but got I4
			//IL_00b9: Expected Obj, but got I4
			//IL_00d2: Expected Obj, but got I4
			//IL_011d: Expected Obj, but got I
			//IL_02cb: Expected Obj, but got I4
			//IL_00fe: Expected Obj, but got I4
			//IL_0163: Expected Obj, but got I
			//IL_0310: Expected Obj, but got I
			//IL_04af: Expected Obj, but got I
			//IL_02f1: Expected Obj, but got I4
			//IL_0356: Expected Obj, but got I
			//IL_02b4: Expected Obj, but got I4
			//IL_04c6: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 - 16;
			RouteChunk routeChunk = _003C_003E4__this;
			object obj3;
			object obj4;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						obj3 = 0;
						goto IL_050b;
					}
					bool result = default;
					return result;
				}
				_003C_003E1__state = -1;
				obj4 = 0;
			}
			else
			{
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SYBO.Subway.Routes.RouteChunk)+7C]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SYBO.Subway.Routes.RouteChunk)+7C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S0_v114+C] (should have been resolved before IL gen)");
				}
				obj4 = 1;
			}
			object obj6 = obj4;
			int num = default;
			while (true)
			{
				if (obj6 == null)
				{
					num = _003Cj_003E5__2 + 1;
					obj6 = 1;
					continue;
				}
				_003Cj_003E5__2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SYBO.Subway.Routes.RouteChunk)+28]");
				object obj7 = 0;
				int num2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v39+C]");
				if ((nint)num2 >= (nint)0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SYBO.Subway.Routes.RouteChunk)+28]");
				TrackObject trackObject = ((List<TrackObject>)0).get_Item(_003Cj_003E5__2);
				if (trackObject == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					string name = routeChunk.name;
					throw new ArrayTypeMismatchException();
				}
				GameObject gameObject = trackObject.gameObject;
				if (gameObject.activeInHierarchy && ~(trackObject._active ? 1u : 0u) == 0)
				{
					trackObject.Deactivate();
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				obj6 = 0;
			}
			int num3 = 0;
			obj3 = 1;
			goto IL_050b;
			IL_050b:
			object obj8 = obj3;
			while (true)
			{
				if (obj8 == null)
				{
					int num4 = _003Cj_003E5__2 + 1;
					num3 = num4;
					obj8 = 1;
					continue;
				}
				_003Cj_003E5__2 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SYBO.Subway.Routes.RouteChunk)+2C]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v22+C]");
				if ((nint)0 <= (nint)num3)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SYBO.Subway.Routes.RouteChunk)+2C]");
				TrackObject trackObject2 = ((List<TrackObject>)0).get_Item(_003Cj_003E5__2);
				if (trackObject2 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					string name2 = routeChunk.name;
					throw new ArrayTypeMismatchException();
				}
				GameObject gameObject2 = trackObject2.gameObject;
				if (gameObject2.activeInHierarchy && ~(trackObject2._active ? 1u : 0u) == 0)
				{
					trackObject2.Deactivate();
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				obj8 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SYBO.Subway.Routes.RouteChunk)+2C]");
			((List<T>)0).Clear();
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

	public const int TrackLaneWidth = 20;

	public const int TrackWidth = 60;

	public const int TrackHeight = 90;

	public const int BlockLength = 90;

	public const int BlockCountMin = 2;

	public const int MinChunkLength = 180;

	private const float BaseColliderCenterY = -9.4f;

	private const float BaseColliderSizeY = 20f;

	private readonly Vector3 LogicHideOffset;

	public static Action<EnvironmentKind, int, Route> OnEnvironmentSegmentSpawned;

	private bool _isRepeatableInSections;

	private int _blockCount;

	private bool _generateEnvironment;

	private bool _generateEnvironmentBase;

	private EnvironmentKind[] _limitedAllowedEnvironmentKinds;

	private List<TrackObject> _trackObjects;

	private List<TrackObject> _environmentTrackObjects;

	private EnvironmentBase[] _forcedEnvironmentBases;

	private SYBO.Subway.Level.Environment[] _forcedEnvironments;

	private List<Selector> _selectors;

	private List<Selector> _environmentSelectors;

	private RouteTransitionTrigger _routeTransitionTrigger;

	public RouteChunk Previous;

	public RouteChunk Next;

	private string _reportedName;

	public int PreviewEnvironmentIndex;

	private Transform _transform;

	private Transform _environmentTransform;

	private List<ChunkBlockConstraint> _blockConstraints;

	private LogicAssetsManager _logicAssetManager;

	private ThemeManager _themeManager;

	private bool _built;

	private Dictionary<Transform, Vector3> _hiddenObstacles;

	private RouteBuilder _builder;

	internal RouteSection _section;

	private RouteChunk _sourcePrefab;

	private Action m_OnDeactivate;

	public bool GenerateEnvironmentBase => _generateEnvironmentBase;

	public List<Selector> Selectors => _selectors;

	public List<Selector> EnvironmentSelectors => _environmentSelectors;

	public Transform EnvironmentTransform => _environmentTransform;

	public bool IsRepeatableInSections => _isRepeatableInSections;

	public bool IsBuilt => _built;

	public int Length => _blockCount * 90;

	public int BlockCount => _blockCount;

	public bool GenerateEnvironment => _generateEnvironment;

	public IList<EnvironmentKind> LimitedAllowedEnvironmentKinds => _limitedAllowedEnvironmentKinds;

	public unsafe Bounds TrackBounds
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_001e: Expected Obj, but got I4
			//IL_009e: Expected VT, but got I4
			//IL_0099: Expected native int or pointer, but got VT
			//IL_00ca: Expected F4, but got I
			//IL_00c5: Expected native int or pointer, but got VT
			//IL_0100: Expected F4, but got I
			//IL_00fb: Expected native int or pointer, but got VT
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Expected VT, but got Unknown
			//IL_011a: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 80);
			object obj2 = _blockCount * 90;
			float num = (float)obj2 * 0.5f;
			Vector3 position = _transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			float num2 = 0f + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			float num3 = 0f + 45f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			float num4 = 0f + num;
			_ = 0;
			_ = 0;
			Bounds bounds = default;
			((Bounds*)(nint)bounds)->m_Center = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			_ = 4806466703425798144L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			Vector3 center = vector + 16;
			*(Bounds*)(nint)bounds = new Bounds(center, vector);
			return bounds;
		}
	}

	public float PosStartZ
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002a: Expected F4, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			Vector3 position = _transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			return 0f;
		}
	}

	public unsafe Vector3 PosStart
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0032: Expected F4, but got I
			//IL_002d: Expected native int or pointer, but got VT
			//IL_003f: Expected F4, but got Obj
			//IL_003a: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			Vector3 position = _transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			Vector3 vector = default;
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj;
			return vector;
		}
	}

	public unsafe Vector3 PosEnd
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0030: Expected I, but got Obj
			//IL_0050: Expected Obj, but got I4
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected Obj, but got Unknown
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected Obj, but got Unknown
			//IL_0092: Expected native int or pointer, but got VT
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Expected Obj, but got Unknown
			//IL_00cb: Expected native int or pointer, but got VT
			//IL_00e7: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			Vector3 position = _transform.position;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			object obj3 = _blockCount * 90;
			object obj4 = Vector3.forwardVector * obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
			object obj5 = 0 * obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			float z = 0f + (float)obj5;
			Vector3 vector = default;
			((Vector3*)(nint)vector)->z = z;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppStaticFields<UnityEngine.Vector3>)+4C]");
			object obj6 = 0 * obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			float y = 0f + (float)obj6;
			((Vector3*)(nint)vector)->y = y;
			float x = (float)obj + (float)obj4;
			((Vector3*)(nint)vector)->x = x;
			return vector;
		}
	}

	public RouteBuilder RouteBuilder => _builder;

	public RouteSection Section => _section;

	public string ReportedName => _reportedName;

	public RouteTransitionTrigger RouteTransitionTrigger => _routeTransitionTrigger;

	public event Action OnDeactivate
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 124;
			Delegate obj2 = this.m_OnDeactivate;
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
			object obj = this + 124;
			Delegate obj2 = this.m_OnDeactivate;
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

	public void Initialize(RouteBuilder builder, RouteSection section, RouteChunk sourcePrefab)
	{
		_builder = builder;
		_section = section;
		_sourcePrefab = sourcePrefab;
	}

	protected unsafe void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_025e: Expected VT, but got Obj
		//IL_0268: Expected Obj, but got VT
		//IL_00cf: Expected Obj, but got I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected VT, but got Unknown
		//IL_0130: Expected Obj, but got I4
		//IL_014a: Expected F4, but got I
		//IL_0145: Expected native int or pointer, but got VT
		//IL_015d: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		Transform transform = base.transform;
		_transform = transform;
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		_logicAssetManager = (LogicAssetsManager)val;
		ThemeManager instance = ThemeManager.Instance;
		_themeManager = instance;
		GameObject gameObject = default;
		gameObject._002Ector("GeneratedEnvironment");
		Transform environmentTransform = gameObject.transform;
		_environmentTransform = environmentTransform;
		_environmentTransform.parent = _transform;
		GameObjectUtil.ResetLocalPosition(_environmentTransform);
		((List<T>)(object)_trackObjects).Clear();
		GameObjectUtil.GetComponentsInChildrenBFS<T>((Component)this, true, (List<T>)(object)_trackObjects);
		Rigidbody rigidbody = GameObjectUtil.AddComponentIfMissing<Rigidbody>(_environmentTransform);
		rigidbody.isKinematic = true;
		BoxCollider boxCollider = GameObjectUtil.AddComponentIfMissing<BoxCollider>(_environmentTransform);
		object obj2 = _blockCount * 90;
		float num = (float)obj2 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		_ = -4533323386629128192L;
		_ = -4533323386629128192L;
		Vector3 center = vector + 16;
		boxCollider.center = center;
		object obj3 = _blockCount * 90;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = 4728779609855492096L;
		((Vector3*)(nint)vector)->x = 70f;
		boxCollider.size = vector;
		boxCollider.tag = "Ground";
		nint num2 = 0;
		nint num3 = 0;
		IntPtr intPtr = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v133 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		EnvironmentBase[] forcedEnvironmentBases = default;
		_forcedEnvironmentBases = forcedEnvironmentBases;
		nint num4 = 0;
		nint num5 = 0;
		IntPtr intPtr2 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v146 @ S4_v7 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		SYBO.Subway.Level.Environment[] forcedEnvironments = default;
		_forcedEnvironments = forcedEnvironments;
		bool flag = _003C_003Ec._003C_003E9__77_0 == null;
		bool flag2 = !flag;
		Comparison<EnvironmentBase> comparison = _003C_003Ec._003C_003E9__77_0;
		if (!flag2)
		{
			throw new ArgumentException();
		}
		Array.Sort(_forcedEnvironmentBases, comparison);
		bool flag3 = _003C_003Ec._003C_003E9__77_1 == null;
		bool flag4 = !flag3;
		Comparison<SYBO.Subway.Level.Environment> comparison2 = _003C_003Ec._003C_003E9__77_1;
		if (!flag4)
		{
			throw new ArgumentException();
		}
		Array.Sort(_forcedEnvironments, comparison2);
		EvaluateEnvironmentConstraints();
	}

	public IEnumerator Destruct()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void OnDrawGizmos()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0239: Expected I4, but got I8
		//IL_024b: Expected Obj, but got I8
		//IL_025d: Expected Obj, but got I8
		//IL_0272: Expected Obj, but got I
		//IL_02a2: Expected Obj, but got I8
		//IL_02b4: Expected I4, but got I8
		//IL_02c6: Expected Obj, but got I8
		//IL_02db: Expected Obj, but got I
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected VT, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected VT, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected VT, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected VT, but got Unknown
		//IL_00c9: Expected Obj, but got I8
		//IL_00db: Expected I4, but got I8
		//IL_00ed: Expected I, but got I8
		//IL_0102: Expected Obj, but got I
		//IL_012e: Expected I4, but got I8
		//IL_0141: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected VT, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected VT, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected VT, but got Unknown
		//IL_01a6: Expected VT, but got Obj
		object obj = default;
		RouteChunk routeChunk = (RouteChunk)(obj - 272);
		float zStep;
		if (_limitedAllowedEnvironmentKinds != null)
		{
			bool flag = Enumerable.Contains(_limitedAllowedEnvironmentKinds, EnvironmentKind.Epic);
			zStep = 360f;
			if (flag)
			{
				goto IL_01c6;
			}
		}
		zStep = 180f;
		goto IL_01c6;
		IL_01c6:
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Routes.RouteChunk)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Routes.RouteChunk)+100]");
		_ = 0;
		float length = (float)_blockCount * 90f;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		routeChunk._built = false;
		routeChunk._environmentTransform = (Transform)4575657222473777152L;
		routeChunk.Next = (RouteChunk)4575657222473777152L;
		RouteChunk routeChunk2 = routeChunk;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Routes.RouteChunk)+F8]");
		routeChunk2._sourcePrefab = (RouteChunk)0;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		routeChunk._logicAssetManager = (LogicAssetsManager)4575657222473777152L;
		routeChunk.PreviewEnvironmentIndex = 1065353216;
		routeChunk._routeTransitionTrigger = (RouteTransitionTrigger)4575657222473777152L;
		RouteChunk routeChunk3 = routeChunk;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Routes.RouteChunk)+F0]");
		routeChunk3._builder = (RouteBuilder)0;
		Vector3 vector = (Vector3)(routeChunk + 112);
		Color startColor = (Color)(routeChunk + 96);
		Color midColor = (Color)(routeChunk + 80);
		Color endColor = (Color)(routeChunk - -64);
		routeChunk.DrawSegments(vector, length, 0f, 90f, startColor, midColor, endColor);
		Transform transform2 = base.transform;
		Vector3 position2 = transform2.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Routes.RouteChunk)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Routes.RouteChunk)+100]");
		_ = 0;
		float length2 = (float)_blockCount * 90f;
		_ = 4575657221408423936L;
		_ = 4575657222473777152L;
		_ = 4575657221408423936L;
		routeChunk._trackObjects = (List<TrackObject>)4575657221408423936L;
		routeChunk._isRepeatableInSections = false;
		((UnityEngine.Object)routeChunk).m_CachedPtr = unchecked((nint)4575657221408423936L);
		RouteChunk routeChunk4 = routeChunk;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Routes.RouteChunk)+B8]");
		routeChunk4._selectors = (List<Selector>)0;
		_ = 4575657221408423936L;
		_ = 4575657222473777152L;
		_ = 1065353216;
		routeChunk._generateEnvironment = false;
		_ = 4575657222473777152L;
		routeChunk = (RouteChunk)1065353216;
		RouteChunk routeChunk5 = routeChunk;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Routes.RouteChunk)+B0]");
		routeChunk5._forcedEnvironmentBases = (EnvironmentBase[])0;
		Vector3 vector2 = (Vector3)(routeChunk + 48);
		Color startColor2 = (Color)(routeChunk + 32);
		Color midColor2 = (Color)(routeChunk + 16);
		routeChunk.DrawSegments(vector2, length2, 90f, zStep, startColor2, midColor2, (Color)routeChunk);
	}

	public unsafe void DrawSegments(Vector3 from, float length, float ySize, float zStep, Color startColor, Color midColor, Color endColor)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected VT, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected VT, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected VT, but got Unknown
		//IL_0183: Expected native int or pointer, but got VT
		//IL_0195: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 96);
		_ = startColor.b;
		_ = startColor.r;
		Color color2 = color + 48;
		Gizmos.color = color2;
		float num = default;
		while (length > num)
		{
			float num2 = zStep * 0.5f;
			float num3 = num + num2;
			float num4 = from.z + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+48]");
			_ = 0;
			float num5 = ySize * 0.5f;
			float num6 = from.y + num5;
			float num7 = from.x + 0f;
			_ = 1114636288;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+50]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+40]");
			_ = 0;
			Vector3 center = (Vector3)(color + 32);
			Vector3 size = (Vector3)(color + 16);
			Gizmos.DrawWireCube(center, size);
			num += zStep;
			float num8 = length - zStep;
			bool flag = num < num8;
			Color color3 = midColor;
			if (!flag)
			{
				color3 = endColor;
			}
			((Color*)(nint)color)->b = color3.b;
			((Color*)(nint)color)->r = color3.r;
			Gizmos.color = color;
		}
	}

	public bool SupportsAnyEnvironmentOf(IList<EnvironmentKind> environmentKinds)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		EnvironmentKind[] limitedAllowedEnvironmentKinds = _limitedAllowedEnvironmentKinds;
		bool result;
		if (limitedAllowedEnvironmentKinds.Length == 0)
		{
			result = true;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = obj + 28;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			bool flag2 = default;
			object obj4 = default;
			object obj5 = default;
			object obj6 = default;
			object obj8 = default;
			object obj9 = default;
			bool result2 = default;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					bool flag = !flag2;
					result = flag2;
					if (flag)
					{
						break;
					}
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
							if (obj4 != null)
							{
								result = flag2;
								break;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag3 = obj5 != obj6;
				object obj7 = obj8;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag4 = (nint)0 == 1;
					result = false;
					if (!flag4)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj7 = obj9;
				}
				_ = 0;
				object obj10 = obj + 16;
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
				return result2;
			}
			object obj11 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		}
		return result;
	}

	public bool SupportsEnvironment(EnvironmentKind environmentKind)
	{
		EnvironmentKind none = EnvironmentKind.None;
		if (environmentKind._type == none._type)
		{
		}
		EnvironmentKind[] limitedAllowedEnvironmentKinds = _limitedAllowedEnvironmentKinds;
		if (limitedAllowedEnvironmentKinds.Length == 0)
		{
			return true;
		}
		return Enumerable.Contains(limitedAllowedEnvironmentKinds, environmentKind);
	}

	public EnvironmentKind GetRandomAllowedEnvironmentKind(SyboRandom random)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_004c: Expected Obj, but got I
		EnvironmentKind[] limitedAllowedEnvironmentKinds = _limitedAllowedEnvironmentKinds;
		int num = random.Range(0, limitedAllowedEnvironmentKinds.Length);
		int num2 = num << 2;
		object obj = num2 + _limitedAllowedEnvironmentKinds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v4+10]");
		return (EnvironmentKind)0;
	}

	public new string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0028: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		RouteBuilder builder = _builder;
		if (_builder != null)
		{
			Route route = builder._route;
			nint num = (nint)route;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S1_v32 (Il2CppClass<SYBO.Subway.Routes.Route>)+E4] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		string text = name;
		throw new ArrayTypeMismatchException();
	}

	public IEnumerator ActivateTrackObjectsASync()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public IEnumerator DeactivateTrackObjects()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public unsafe void Build(EnvironmentKind routeDesiredEnvironmentKind, EnvironmentKind previousDesiredEnvironmentKind)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_004e: Expected I, but got Obj
		//IL_010b: Expected VT, but got Obj
		//IL_0113: Expected Obj, but got Ref
		//IL_087d: Expected Obj, but got VT
		//IL_04f6: Expected I, but got Obj
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected VT, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected VT, but got Unknown
		//IL_06d0: Expected Obj, but got I4
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected VT, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected VT, but got Unknown
		//IL_08a1: Expected Obj, but got I4
		//IL_0b36: Expected I, but got Obj
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b81: Expected VT, but got Unknown
		//IL_0b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8f: Expected VT, but got Unknown
		//IL_07a1: Expected I, but got Obj
		//IL_0bc6: Expected Obj, but got I4
		//IL_0bde: Expected Obj, but got VT
		//IL_05ba: Expected native int or pointer, but got VT
		//IL_05dc: Expected native int or pointer, but got VT
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected VT, but got Unknown
		//IL_091f: Expected Obj, but got I4
		//IL_099d: Expected Obj, but got I4
		//IL_09c8: Expected Obj, but got I4
		//IL_0a38: Expected VT, but got Obj
		//IL_0a40: Expected Obj, but got Ref
		//IL_09f3: Expected Obj, but got I4
		//IL_03f4: Expected F8, but got I4
		//IL_0ab8: Expected Obj, but got I4
		//IL_0ae1: Expected Obj, but got I
		//IL_0af1: Expected VT, but got I
		//IL_0b13: Expected VT, but got Obj
		//IL_0329: Expected Obj, but got I4
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected Obj, but got Unknown
		//IL_0352: Expected I4, but got Obj
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Ref, but got Unknown
		object obj = default;
		EnvironmentBaseKind environmentBaseKind = (EnvironmentBaseKind)(obj - 192);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		RestoreHiddenLogic();
		((List<T>)(object)_environmentSelectors).Clear();
		if (~(_generateEnvironment ? 1u : 0u) == 0 || ~(_generateEnvironmentBase ? 1u : 0u) == 0)
		{
			EnvironmentKind none = EnvironmentKind.None;
			_ = 0;
			nint num = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v17 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v18 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8C]");
			_ = 0;
			_ = EnvironmentBaseKind.Tracks3;
			if (_blockCount >= 2)
			{
				ChunkBlockConstraint chunkBlockConstraint = _blockConstraints.get_Item(1);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v179 (SYBO.Subway.Routes.RouteChunk+ChunkBlockConstraint)+14]");
				_ = 0;
				_ = chunkBlockConstraint.EnvironmentBaseKind;
			}
			int num3 = -1;
			EnvironmentKind environmentKind = routeDesiredEnvironmentKind;
			EnvironmentKind environmentKind2 = none;
			int num4 = default;
			int num5 = default;
			bool flag2 = default;
			bool flag3 = default;
			EnvironmentInfo environmentInfo = default;
			ref int reference = default;
			object obj10 = default;
			while (num4 < _blockCount)
			{
				ChunkBlockConstraint chunkBlockConstraint2 = _blockConstraints.get_Item(num4);
				bool flag = num5 != num4;
				int num6 = (flag2 ? 1 : 0);
				int num7 = (flag3 ? 1 : 0);
				EnvironmentBaseKind environmentBaseKind2 = (EnvironmentBaseKind)environmentInfo;
				EnvironmentKind environmentKind3 = (EnvironmentKind)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
				if (flag)
				{
					goto IL_084c;
				}
				EnvironmentKind environmentKind4 = chunkBlockConstraint2.EnvironmentKind;
				EnvironmentKind none2 = EnvironmentKind.None;
				bool flag4 = environmentKind4._type == none2._type && environmentKind4._density == none2._density;
				object obj2 = (flag4 ? 1 : 0) ^ 1;
				if (obj2 == null)
				{
					environmentKind4 = routeDesiredEnvironmentKind;
				}
				int currentEnvironmentEndBlock = GetCurrentEnvironmentEndBlock(num4);
				bool flag5 = currentEnvironmentEndBlock == -1;
				bool flag6 = !flag5;
				num3 = currentEnvironmentEndBlock;
				if (!flag6)
				{
					int num8 = _blockCount - 1;
					num3 = num8;
				}
				bool flag7 = environmentKind4._type == routeDesiredEnvironmentKind._type && environmentKind4._density == routeDesiredEnvironmentKind._density;
				bool flag8 = environmentKind4._type == environmentKind2._type && environmentKind4._density == environmentKind2._density;
				object obj3 = (flag8 ? 1 : 0) ^ 1;
				bool flag9 = environmentKind._type == environmentKind4._type && environmentKind._density == environmentKind4._density;
				bool flag10 = (byte)((flag9 ? 1u : 0u) ^ 1u) != 0;
				bool flag11 = environmentKind._type == environmentKind4._type && environmentKind._density == environmentKind4._density;
				object obj4 = (flag11 ? 1 : 0) ^ 1;
				if (obj4 != null)
				{
					_ = 0;
				}
				EnvironmentKind none3 = EnvironmentKind.None;
				bool flag12 = environmentKind4._type == none3._type && environmentKind4._density == none3._density;
				object obj5 = (flag12 ? 1 : 0) ^ 1;
				int num9;
				if (obj5 != null)
				{
					EnvironmentKind empty = EnvironmentKind.Empty;
					bool flag13 = environmentKind4._type == empty._type && environmentKind4._density == empty._density;
					object obj6 = (flag13 ? 1 : 0) ^ 1;
					if (obj6 != null)
					{
						EnvironmentInfo byKind = EnvironmentInfo.GetByKind(environmentKind4);
						object obj7 = (flag7 ? 1 : 0) ^ -1;
						bool flag14 = num4 > 0;
						object obj8 = obj7 & flag14;
						flag2 = (byte)(obj8 & obj3) != 0;
						EnvironmentSequence sequence = EvalNextEnvironmentSequence(num4, num3, byKind, flag10, flag2);
						reference = ref *(int*)(environmentBaseKind + 188);
						num9 = CreateEnvironmentSegment(num4, byKind, sequence, ref reference);
						flag3 = flag10;
						environmentInfo = byKind;
						EnvironmentBaseKind environmentBaseKind3 = environmentBaseKind;
						goto IL_0a10;
					}
				}
				num9 = num4 + 1;
				goto IL_0a10;
				IL_0a10:
				bool flag15 = OnEnvironmentSegmentSpawned == null;
				num6 = (flag2 ? 1 : 0);
				num7 = (flag3 ? 1 : 0);
				environmentBaseKind2 = (EnvironmentBaseKind)environmentInfo;
				environmentKind3 = (EnvironmentKind)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
				num5 = num9;
				environmentKind = environmentKind4;
				if (!flag15)
				{
					float posStartZ = PosStartZ;
					Action<EnvironmentKind, int, Route> onEnvironmentSegmentSpawned = OnEnvironmentSegmentSpawned;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
					double num10 = Math.Abs((double)posStartZ);
					double num11 = ((!(num10 < 2147483648.0)) ? (-2147483648.0) : ((double)posStartZ));
					object obj9 = num4 * 90;
					double num12 = num11 + (double)obj9;
					RouteBuilder builder = _builder;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ S0_v210 (System.Action`3<SYBO.Subway.Level.EnvironmentKind, System.Int32, SYBO.Subway.Routes.Route>)+14]");
					environmentKind3 = (EnvironmentKind)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ S0_v210 (System.Action`3<SYBO.Subway.Level.EnvironmentKind, System.Int32, SYBO.Subway.Routes.Route>)+C]");
					EnvironmentBaseKind environmentBaseKind3 = (EnvironmentBaseKind)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v737 @ S0_v210 (System.Action`3<SYBO.Subway.Level.EnvironmentKind, System.Int32, SYBO.Subway.Routes.Route>)+C] (should have been resolved before IL gen)");
					num6 = (flag2 ? 1 : 0);
					num7 = (flag3 ? 1 : 0);
					environmentBaseKind2 = (EnvironmentBaseKind)environmentInfo;
					num5 = num9;
					environmentKind = environmentKind4;
				}
				goto IL_084c;
				IL_084c:
				bool flag16 = num4 == (nint)obj10;
				bool flag17 = !flag16;
				flag2 = (byte)num6 != 0;
				flag3 = (byte)num7 != 0;
				environmentInfo = (EnvironmentInfo)environmentBaseKind2;
				reference = ref *(int*)environmentKind3;
				if (!flag17)
				{
					ChunkBlockConstraint chunkBlockConstraint3 = _blockConstraints.get_Item(num4);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S1_v68 (SYBO.Subway.Routes.RouteChunk+ChunkBlockConstraint)+14]");
					_ = 0;
					_ = chunkBlockConstraint3.EnvironmentBaseKind;
					if (~(_generateEnvironmentBase ? 1u : 0u) == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S1_v68 (SYBO.Subway.Routes.RouteChunk+ChunkBlockConstraint)+14]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+B8]");
						_ = 0;
						_ = chunkBlockConstraint3.EnvironmentBaseKind;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+B0]");
						_ = 0;
						EnvironmentBaseKind environmentBaseKind3 = (EnvironmentBaseKind)(environmentBaseKind + 112);
						environmentBaseKind2 = (EnvironmentBaseKind)(environmentBaseKind + 96);
						EnvironmentBaseKind environmentBaseKindToPlace = GetEnvironmentBaseKindToPlace(environmentKind, environmentKind, routeDesiredEnvironmentKind, environmentBaseKind3, environmentBaseKind2, num4, num3);
						num6 = num3;
						num7 = num4;
						environmentKind3 = routeDesiredEnvironmentKind;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+A8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+A0]");
					_ = 0;
					nint num13 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S0_v106 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
					nint num14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+B8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+B0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S0_v107 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
					_ = 0;
					_ = EnvironmentBaseKind.None;
					EnvironmentBaseKind environmentBaseKind4 = (EnvironmentBaseKind)(environmentBaseKind + 80);
					EnvironmentBaseKind environmentBaseKind5 = (EnvironmentBaseKind)(environmentBaseKind - -64);
					if (environmentBaseKind4 != environmentBaseKind5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+B8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+B0]");
						_ = 0;
					}
					nint num15 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ S0_v119 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
					nint num16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+A8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+A0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S0_v120 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
					_ = 0;
					_ = EnvironmentBaseKind.None;
					EnvironmentBaseKind environmentBaseKind6 = (EnvironmentBaseKind)(environmentBaseKind + 48);
					EnvironmentBaseKind environmentBaseKind7 = (EnvironmentBaseKind)(environmentBaseKind + 32);
					int num17;
					if (environmentBaseKind6 != environmentBaseKind7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+A8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+98]");
						((EnvironmentBaseKind*)(nint)environmentBaseKind)->NumTracks = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+A0]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+90]");
						((EnvironmentBaseKind*)(nint)environmentBaseKind)->Type = EnvironmentBaseType.None;
						EnvironmentBaseKind baseKind = (EnvironmentBaseKind)(environmentBaseKind + 16);
						num17 = CreateEnvironmentBase(num4, baseKind, environmentBaseKind, environmentKind);
						EnvironmentBaseKind environmentBaseKind3 = environmentBaseKind;
						environmentKind3 = environmentKind;
					}
					else
					{
						num17 = 1;
					}
					obj10 = num17 + num4;
					flag2 = (byte)num6 != 0;
					flag3 = (byte)num7 != 0;
					environmentInfo = (EnvironmentInfo)environmentBaseKind2;
					reference = ref *(int*)environmentKind3;
				}
				num4++;
				EnvironmentKind environmentKind5;
				if (_blockCount > num5)
				{
					ChunkBlockConstraint chunkBlockConstraint4 = _blockConstraints.get_Item(num5);
					environmentKind5 = chunkBlockConstraint4.EnvironmentKind;
				}
				else if (Next != null)
				{
					RouteChunk next = Next;
					ChunkBlockConstraint chunkBlockConstraint5 = next._blockConstraints.get_Item(0);
					environmentKind5 = chunkBlockConstraint5.EnvironmentKind;
				}
				else
				{
					environmentKind5 = EnvironmentKind.None;
				}
				object obj11 = _blockCount - 1;
				if (num4 < (nint)obj11)
				{
					ChunkBlockConstraint chunkBlockConstraint6 = _blockConstraints.get_Item(num4);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ S1_v59 (SYBO.Subway.Routes.RouteChunk+ChunkBlockConstraint)+14]");
					_ = 0;
					_ = chunkBlockConstraint6.EnvironmentBaseKind;
				}
				else if (Next != null)
				{
					RouteChunk next2 = Next;
					ChunkBlockConstraint chunkBlockConstraint7 = next2._blockConstraints.get_Item(0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ S1_v53 (SYBO.Subway.Routes.RouteChunk+ChunkBlockConstraint)+14]");
					_ = 0;
					_ = chunkBlockConstraint7.EnvironmentBaseKind;
				}
				else
				{
					nint num18 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ S1_v45 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
					nint num19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ S1_v46 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
					_ = 0;
					_ = EnvironmentBaseKind.None;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+80]");
				_ = 0;
				environmentKind2 = environmentKind5;
			}
		}
		_built = true;
	}

	public void HideLogic(float untilPositionZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected Obj, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_02fe: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		Transform transform = base.transform;
		IEnumerator enumerator = transform.GetEnumerator();
		object obj3 = obj + 24;
		object obj4 = obj + 28;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj6;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				bool flag = obj5 == null;
				obj6 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
								if (obj7 != null)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @29");
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
						goto IL_01bb;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_01bb;
			IL_01bb:
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
				obj6 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
			}
			_ = 0;
			object obj13 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj6 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj14 = obj6 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
	}

	private unsafe void HideLogicRecursive(Transform target, float maxZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected VT, but got Unknown
		//IL_0077: Expected Ref, but got VT
		//IL_031d: Invalid comparison between F4 and I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected Obj, but got Unknown
		//IL_014b: Expected Obj, but got I
		//IL_0394: Expected VT, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_03ce: Expected Obj, but got I4
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Obj, but got Unknown
		//IL_0422: Expected Obj, but got I
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Ref, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected VT, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected Obj, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected Obj, but got Unknown
		//IL_0590: Expected Obj, but got I
		//IL_05ad: Expected Obj, but got I
		//IL_05c7: Expected F4, but got I
		//IL_05c2: Expected native int or pointer, but got VT
		//IL_05e6: Expected F4, but got I
		//IL_05e1: Expected native int or pointer, but got VT
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 144);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Collider component = target.GetComponent<Collider>();
		if (component != null)
		{
			Bounds bounds = component.bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Bounds bounds2 = (Bounds)(vector + 120);
			Vector3 min = ((Bounds*)bounds2)->min;
		}
		else
		{
			Vector3 position = target.position;
		}
		SnapObject component2 = target.GetComponent<SnapObject>();
		if (component2 != null)
		{
			goto IL_030d;
		}
		IEnumerator enumerator = target.GetEnumerator();
		object obj2 = vector + 112;
		object obj3 = vector + 116;
		_ = 0;
		object obj4 = vector - -64;
		Component[] array;
		object obj5 = default;
		Component[] array2 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				array = (Component[])0;
				break;
			}
			if (obj5 != null)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag = (nint)0 == 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				array = (Component[])0;
				if (!flag)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 == 1;
					array = array2;
					if (!flag2)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @29");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						array = array2;
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				break;
			}
			object obj6 = vector + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj7 = default;
		object obj8 = default;
		bool flag3 = obj7 != obj8;
		object obj10 = default;
		object obj9 = obj10;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj11 = vector + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
				goto IL_030d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj12 = default;
			obj9 = obj12;
		}
		_ = 0;
		object obj13 = vector + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		RouteChunk routeChunk = (RouteChunk)0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			goto IL_06d0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		return;
		IL_06d0:
		while (array.Length > (nint)obj9)
		{
			object obj14 = obj9 << 2;
			object obj15 = (object)array + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
			object obj16 = obj9 + 1;
			obj9 = obj16;
		}
		if (!routeChunk._hiddenObstacles.TryGetValue(target, out *(Vector3*)(vector + 96)))
		{
			Vector3 localPosition = target.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Vector3 value = vector + 16;
			routeChunk._hiddenObstacles.set_Item(target, value);
			Vector3 localPosition2 = target.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			object obj17 = 0 + routeChunk.LogicHideOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+4C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S0_v103 (SYBO.Subway.Routes.RouteChunk)+10]");
			object obj18 = num + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S0_v103 (SYBO.Subway.Routes.RouteChunk)+14]");
			object obj19 = num2 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			target.localPosition = vector;
		}
		return;
		IL_030d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		if (maxZ > 0f)
		{
			GameObject gameObject = target.gameObject;
			int layer = gameObject.layer;
			Layers instance = Layers.Instance;
			if (layer != instance.Unremovable)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(IHideable));
				Component[] componentsInChildrenBFS = GameObjectUtil.GetComponentsInChildrenBFS(target, typeFromHandle, includeInactive: false, includeSelf: true, 1);
				array = componentsInChildrenBFS;
				obj9 = 0;
				goto IL_06d0;
			}
		}
	}

	public void RestoreHiddenLogic()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected Obj, but got Unknown
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected Obj, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected Obj, but got Unknown
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected Obj, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected Obj, but got Unknown
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_035a: Expected Obj, but got I4
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 128;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D1E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		object obj4 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		_ = 0;
		object obj5 = obj + 96;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		_ = 0;
		object obj7 = default;
		object obj8 = default;
		object obj14 = default;
		object obj16 = default;
		object obj17 = default;
		object obj19 = default;
		object obj20 = default;
		while (true)
		{
			_ = 0;
			object obj6 = obj + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj7 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+6C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+74]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
					_ = 0;
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj8 == null)
								{
									goto IL_026f;
								}
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+54]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+5C]");
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
										_ = 0;
										object obj9 = obj + 8;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											goto IL_026f;
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
							goto IL_04b0;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			goto IL_04b0;
			IL_04a1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_04b0;
			IL_026f:
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
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj10 = 0;
							while (true)
							{
								object obj11 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ S0_v148+C]");
								if ((nint)obj11 >= 0)
								{
									break;
								}
								object obj12 = obj10 << 2;
								object obj13 = obj14 + obj12;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
										object obj15 = obj10 + 1;
										obj10 = obj15;
										continue;
									}
								}
								goto IL_04a1;
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
			goto IL_04b0;
			IL_04b0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj16 == obj17;
			bool flag2 = !flag;
			object obj18 = obj19;
			if (!flag2)
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
				obj18 = obj20;
			}
			_ = 0;
			object obj21 = obj + 40;
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
		}
		object obj22 = obj + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4A8");
		throw new IndexOutOfRangeException();
	}

	private unsafe EnvironmentBaseKind GetEnvironmentBaseKindToPlace(EnvironmentKind envKind, EnvironmentKind previousEnvKind, EnvironmentKind routeDesiredEnvironment, EnvironmentBaseKind envBaseKindConstraint, EnvironmentBaseKind nextConstraint, int blockIndex, int envKindEndBlock)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_004c: Expected I, but got Obj
		//IL_006a: Expected I4, but got VT
		//IL_0065: Expected native int or pointer, but got VT
		//IL_007a: Expected native int or pointer, but got VT
		//IL_00f7: Expected I, but got Obj
		//IL_0115: Expected I4, but got VT
		//IL_0110: Expected native int or pointer, but got VT
		//IL_0125: Expected native int or pointer, but got VT
		//IL_0775: Expected Obj, but got I4
		//IL_028e: Expected Obj, but got I4
		//IL_04be: Expected Obj, but got I4
		//IL_0510: Expected I, but got Obj
		//IL_052e: Expected I4, but got VT
		//IL_0529: Expected native int or pointer, but got VT
		//IL_053e: Expected native int or pointer, but got VT
		//IL_0478: Expected Obj, but got I
		//IL_048c: Expected native int or pointer, but got VT
		//IL_04a1: Expected native int or pointer, but got VT
		//IL_07f8: Expected Obj, but got I4
		//IL_0556: Expected I, but got Obj
		//IL_0574: Expected I4, but got VT
		//IL_056f: Expected native int or pointer, but got VT
		//IL_0584: Expected native int or pointer, but got VT
		//IL_032e: Expected Obj, but got I4
		//IL_0336: Expected I, but got Obj
		//IL_0349: Expected Obj, but got I4
		//IL_059c: Expected I, but got Obj
		//IL_05ba: Expected I4, but got VT
		//IL_05b5: Expected native int or pointer, but got VT
		//IL_05ca: Expected native int or pointer, but got VT
		//IL_0365: Expected I, but got Obj
		//IL_0396: Expected Obj, but got I
		//IL_0396: Expected native int or pointer, but got VT
		//IL_03a3: Expected native int or pointer, but got VT
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected VT, but got Unknown
		//IL_05e2: Expected I, but got Obj
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected VT, but got Unknown
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Expected VT, but got Unknown
		//IL_0416: Expected Obj, but got I
		//IL_042a: Expected native int or pointer, but got VT
		//IL_043f: Expected native int or pointer, but got VT
		//IL_03da: Expected Obj, but got I4
		//IL_06ac: Expected I, but got Obj
		//IL_06c3: Expected Obj, but got I
		//IL_06d7: Expected native int or pointer, but got VT
		//IL_06ec: Expected native int or pointer, but got VT
		//IL_0671: Expected native int or pointer, but got VT
		//IL_0683: Expected native int or pointer, but got VT
		object obj = default;
		EnvironmentBaseKind environmentBaseKind = (EnvironmentBaseKind)(obj - 80);
		EnvironmentKind epic = EnvironmentKind.Epic;
		EnvironmentKind environmentKind = default;
		EnvironmentBaseKind environmentBaseKind2 = default;
		nint num10 = default;
		if (environmentKind._type == epic._type && environmentKind._density == epic._density)
		{
			nint num = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v133 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
			nint num2 = 0;
			((EnvironmentBaseKind*)(nint)environmentBaseKind2)->Type = (EnvironmentBaseType)EnvironmentBaseKind.None;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v134 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
			((EnvironmentBaseKind*)(nint)environmentBaseKind2)->NumTracks = 0;
		}
		else
		{
			EnvironmentKind gates = EnvironmentKind.Gates;
			if (environmentKind._type == gates._type && environmentKind._density == gates._density)
			{
				nint num3 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v125 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
				nint num4 = 0;
				((EnvironmentBaseKind*)(nint)environmentBaseKind2)->Type = (EnvironmentBaseType)EnvironmentBaseKind.Tracks3GatesShadow;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v126 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+C8]");
				((EnvironmentBaseKind*)(nint)environmentBaseKind2)->NumTracks = 0;
			}
			else
			{
				bool flag = environmentKind._type == previousEnvKind._type && environmentKind._density == previousEnvKind._density;
				object obj2 = (flag ? 1 : 0) ^ 1;
				EnvironmentKind tube = EnvironmentKind.Tube;
				if (environmentKind._type != tube._type || environmentKind._density != tube._density)
				{
					EnvironmentKind pillars = EnvironmentKind.Pillars;
					if (environmentKind._type != pillars._type || environmentKind._density != pillars._density)
					{
						EnvironmentKind station = EnvironmentKind.Station;
						if (environmentKind._type != station._type || environmentKind._density != station._density)
						{
							nint num5 = (nint)typeof(EnvironmentBaseKind);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S0_v111 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
							nint num6 = 0;
							_ = envBaseKindConstraint.NumTracks;
							_ = envBaseKindConstraint.Type;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S0_v112 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
							_ = 0;
							_ = EnvironmentBaseKind.None;
							EnvironmentBaseKind environmentBaseKind3 = (EnvironmentBaseKind)(environmentBaseKind + 48);
							EnvironmentBaseKind environmentBaseKind4 = (EnvironmentBaseKind)(environmentBaseKind + 32);
							if (environmentBaseKind3 != environmentBaseKind4)
							{
								((EnvironmentBaseKind*)(nint)environmentBaseKind2)->Type = envBaseKindConstraint.Type;
								((EnvironmentBaseKind*)(nint)environmentBaseKind2)->NumTracks = envBaseKindConstraint.NumTracks;
							}
							else
							{
								RouteBuilder builder = _builder;
								Route route = builder._route;
								nint num7 = (nint)route;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v406 @ S3_v10 (Il2CppClass<SYBO.Subway.Routes.Route>)+E4] (should have been resolved before IL gen)");
								RouteType routeType = default;
								EnvironmentBaseKind defaultEnvironmentBaseKind = ((RouteChunk)num6).GetDefaultEnvironmentBaseKind(routeType);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+48]");
								((EnvironmentBaseKind*)(nint)environmentBaseKind2)->NumTracks = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+40]");
								((EnvironmentBaseKind*)(nint)environmentBaseKind2)->Type = EnvironmentBaseType.None;
							}
							goto IL_0749;
						}
					}
				}
				object obj3 = envKindEndBlock - 1;
				if (blockIndex >= (nint)obj3)
				{
					bool flag2 = routeDesiredEnvironment._type == environmentKind._type && routeDesiredEnvironment._density == environmentKind._density;
					bool flag3 = !flag2;
					object obj4 = 1;
					if (!flag3)
					{
						RouteBuilder builder2 = _builder;
						object obj5 = _blockCount * 90;
						nint num8 = (nint)builder2;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v303 @ S2_v12 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+12C] (should have been resolved before IL gen)");
						obj4 = 1;
						object obj6 = default;
						if (obj6 == null)
						{
							nint num9 = (nint)typeof(EnvironmentBaseKind);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v81 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
							num10 = 0;
							_ = nextConstraint.NumTracks;
							_ = nextConstraint.Type;
							((EnvironmentBaseKind*)(nint)environmentBaseKind)->NumTracks = (int)((EnvironmentKind)num10)._type;
							((EnvironmentBaseKind*)(nint)environmentBaseKind)->Type = (EnvironmentBaseType)num10;
							EnvironmentBaseKind environmentBaseKind5 = (EnvironmentBaseKind)(environmentBaseKind + 16);
							bool flag4 = environmentBaseKind5 == environmentBaseKind;
							object obj7 = (flag4 ? 1 : 0) ^ 1;
							obj4 = obj7;
						}
					}
					if (obj2 != null)
					{
						goto IL_0466;
					}
					if (obj4 != null)
					{
						EnvironmentBaseKind endEnvironmentBase = ((RouteChunk)num10).GetEndEnvironmentBase(envBaseKindConstraint.NumTracks);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+48]");
						((EnvironmentBaseKind*)(nint)environmentBaseKind2)->NumTracks = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+40]");
						((EnvironmentBaseKind*)(nint)environmentBaseKind2)->Type = EnvironmentBaseType.None;
						goto IL_0749;
					}
				}
				else if (obj2 != null)
				{
					goto IL_0466;
				}
				object obj8 = envBaseKindConstraint.NumTracks - 1;
				if (envBaseKindConstraint.NumTracks != 1)
				{
					if ((nint)obj8 == 1)
					{
						nint num11 = (nint)typeof(EnvironmentBaseKind);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S1_v39 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
						nint num12 = 0;
						((EnvironmentBaseKind*)(nint)environmentBaseKind2)->Type = (EnvironmentBaseType)EnvironmentBaseKind.Tracks2ShadowMid;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S1_v40 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
						((EnvironmentBaseKind*)(nint)environmentBaseKind2)->NumTracks = 0;
					}
					else
					{
						nint num13 = (nint)typeof(EnvironmentBaseKind);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S1_v45 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
						nint num14 = 0;
						((EnvironmentBaseKind*)(nint)environmentBaseKind2)->Type = (EnvironmentBaseType)EnvironmentBaseKind.Tracks3ShadowMid;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S1_v46 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+A4]");
						((EnvironmentBaseKind*)(nint)environmentBaseKind2)->NumTracks = 0;
					}
				}
				else
				{
					nint num15 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S1_v33 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
					nint num16 = 0;
					((EnvironmentBaseKind*)(nint)environmentBaseKind2)->Type = (EnvironmentBaseType)EnvironmentBaseKind.Tracks1ShadowMid;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S1_v34 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+44]");
					((EnvironmentBaseKind*)(nint)environmentBaseKind2)->NumTracks = 0;
				}
			}
		}
		goto IL_0749;
		IL_0749:
		return environmentBaseKind2;
		IL_0466:
		EnvironmentBaseKind startEnvironmentBase = ((RouteChunk)num10).GetStartEnvironmentBase(envBaseKindConstraint.NumTracks);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+48]");
		((EnvironmentBaseKind*)(nint)environmentBaseKind2)->NumTracks = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+40]");
		((EnvironmentBaseKind*)(nint)environmentBaseKind2)->Type = EnvironmentBaseType.None;
		goto IL_0749;
	}

	private unsafe EnvironmentBaseKind GetStartEnvironmentBase(int numTracks)
	{
		//IL_002e: Expected I, but got Obj
		//IL_0046: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_009c: Expected I4, but got Obj
		//IL_0097: Expected native int or pointer, but got VT
		//IL_00ac: Expected native int or pointer, but got VT
		//IL_000e: Expected Obj, but got I4
		nint num = (nint)typeof(EnvironmentBaseKind);
		bool flag = numTracks == 2;
		object obj = 96;
		if (!flag)
		{
			obj = 144;
		}
		bool flag2 = numTracks == 1;
		object obj2 = 48;
		if (!flag2)
		{
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj3 = 0 + obj2;
		EnvironmentBaseKind environmentBaseKind = default;
		((EnvironmentBaseKind*)(nint)environmentBaseKind)->Type = (EnvironmentBaseType)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v5+8]");
		((EnvironmentBaseKind*)(nint)environmentBaseKind)->NumTracks = 0;
		return environmentBaseKind;
	}

	private unsafe EnvironmentBaseKind GetEndEnvironmentBase(int numTracks)
	{
		//IL_002e: Expected I, but got Obj
		//IL_0046: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_009c: Expected I4, but got Obj
		//IL_0097: Expected native int or pointer, but got VT
		//IL_00ac: Expected native int or pointer, but got VT
		//IL_000e: Expected Obj, but got I4
		nint num = (nint)typeof(EnvironmentBaseKind);
		bool flag = numTracks == 2;
		object obj = 120;
		if (!flag)
		{
			obj = 168;
		}
		bool flag2 = numTracks == 1;
		object obj2 = 72;
		if (!flag2)
		{
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj3 = 0 + obj2;
		EnvironmentBaseKind environmentBaseKind = default;
		((EnvironmentBaseKind*)(nint)environmentBaseKind)->Type = (EnvironmentBaseType)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v5+8]");
		((EnvironmentBaseKind*)(nint)environmentBaseKind)->NumTracks = 0;
		return environmentBaseKind;
	}

	private unsafe EnvironmentBaseKind GetDefaultEnvironmentBaseKind(RouteType routeType)
	{
		//IL_0028: Expected I, but got Obj
		//IL_0069: Expected I4, but got VT
		//IL_0064: Expected native int or pointer, but got VT
		//IL_0079: Expected native int or pointer, but got VT
		nint num = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num2 = (nint)0 + (nint)132;
		if (routeType != RouteType.Default)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
			num2 = 0;
		}
		EnvironmentBaseKind environmentBaseKind = default;
		((EnvironmentBaseKind*)(nint)environmentBaseKind)->Type = (EnvironmentBaseType)EnvironmentBaseKind.None;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v6 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
		((EnvironmentBaseKind*)(nint)environmentBaseKind)->NumTracks = 0;
		return environmentBaseKind;
	}

	private unsafe int GetCurrentEnvironmentEndBlock(int currentBlockIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected I4, but got Unknown
		//IL_01c7: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		List<ChunkBlockConstraint> blockConstraints = _blockConstraints;
		int result;
		if (currentBlockIndex >= blockConstraints._size)
		{
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			List<ChunkBlockConstraint> blockConstraints2 = _blockConstraints;
			_ = blockConstraints2._size;
			int num2 = obj + 8;
			string text2 = ((int*)num2)->ToString();
			string text3 = "Block index " + text + " out of bounds, block constraint count " + text2;
		}
		else
		{
			ChunkBlockConstraint chunkBlockConstraint = _blockConstraints.get_Item(currentBlockIndex);
			int num3 = currentBlockIndex + 1;
			int num4 = num3;
			while (true)
			{
				List<ChunkBlockConstraint> blockConstraints3 = _blockConstraints;
				if (num4 >= blockConstraints3._size)
				{
					break;
				}
				ChunkBlockConstraint chunkBlockConstraint2 = _blockConstraints.get_Item(num4);
				EnvironmentKind environmentKind = chunkBlockConstraint2.EnvironmentKind;
				EnvironmentKind environmentKind2 = chunkBlockConstraint.EnvironmentKind;
				result = num4 - 1;
				bool flag = environmentKind2._type == environmentKind._type && environmentKind2._density == environmentKind._density;
				object obj3 = (flag ? 1 : 0) ^ 1;
				if (obj3 == null)
				{
					int num5 = num4 + 1;
					num4 = num5;
					continue;
				}
				goto IL_0203;
			}
		}
		result = -1;
		goto IL_0203;
		IL_0203:
		return result;
	}

	private unsafe ChunkBlockConstraint GetNextEnvironmentConstraint(int currentBlockIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected I4, but got Unknown
		//IL_018c: Expected I, but got Obj
		//IL_020e: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		List<ChunkBlockConstraint> blockConstraints = _blockConstraints;
		int num = default;
		ChunkBlockConstraint chunkBlockConstraint3;
		if (num >= blockConstraints._size)
		{
			int num2 = obj + 12;
			string text = ((int*)num2)->ToString();
			List<ChunkBlockConstraint> blockConstraints2 = _blockConstraints;
			_ = blockConstraints2._size;
			int num3 = obj + 8;
			string text2 = ((int*)num3)->ToString();
			string text3 = "Block index " + text + " out of bounds, block constraint count " + text2;
		}
		else
		{
			ChunkBlockConstraint chunkBlockConstraint = _blockConstraints.get_Item(num);
			int index = num + 1;
			ChunkBlockConstraint chunkBlockConstraint2 = _blockConstraints.get_Item(index);
			chunkBlockConstraint3 = chunkBlockConstraint2;
			int num4 = default;
			while (true)
			{
				List<ChunkBlockConstraint> blockConstraints3 = _blockConstraints;
				if (num4 >= blockConstraints3._size)
				{
					break;
				}
				EnvironmentKind environmentKind = chunkBlockConstraint3.EnvironmentKind;
				EnvironmentKind environmentKind2 = chunkBlockConstraint.EnvironmentKind;
				bool flag = environmentKind2._type == environmentKind._type && environmentKind2._density == environmentKind._density;
				object obj3 = (flag ? 1 : 0) ^ 1;
				if (obj3 == null)
				{
					break;
				}
				int index2 = num + 1;
				ChunkBlockConstraint chunkBlockConstraint4 = _blockConstraints.get_Item(index2);
				num4 = num + 1;
				chunkBlockConstraint3 = chunkBlockConstraint4;
			}
			nint num5 = (nint)chunkBlockConstraint;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v150 @ S2_v10 (Il2CppClass<SYBO.Subway.Routes.RouteChunk+ChunkBlockConstraint>)+BC] (should have been resolved before IL gen)");
			object obj4 = default;
			if (obj4 == null)
			{
				goto IL_0259;
			}
		}
		chunkBlockConstraint3 = ChunkBlockConstraint.None;
		goto IL_0259;
		IL_0259:
		return chunkBlockConstraint3;
	}

	private unsafe int CreateEnvironmentBase(int blockIndex, EnvironmentBaseKind baseKind, EnvironmentBaseKind baseKindNext, EnvironmentKind envKind)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_02e4: Expected I, but got Obj
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected VT, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected VT, but got Unknown
		//IL_002b: Expected Obj, but got I4
		//IL_00ab: Expected native int or pointer, but got Obj
		//IL_0113: Expected native int or pointer, but got Obj
		//IL_01fa: Expected VT, but got I
		//IL_0210: Expected VT, but got Obj
		//IL_0222: Expected Obj, but got VT
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected I4, but got Unknown
		//IL_02b8: Expected I, but got Obj
		//IL_03d5: Expected I, but got Obj
		//IL_03f3: Expected Obj, but got I4
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected Obj, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_0445: Expected F4, but got I
		//IL_0440: Expected native int or pointer, but got VT
		//IL_0464: Expected F4, but got I
		//IL_045f: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 96);
		nint num = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num2 = 0;
		_ = baseKind.NumTracks;
		_ = baseKind.Type;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+C8]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks3GatesShadow;
		EnvironmentBaseKind environmentBaseKind = (EnvironmentBaseKind)(vector + 48);
		EnvironmentBaseKind environmentBaseKind2 = (EnvironmentBaseKind)(vector + 32);
		bool flag = environmentBaseKind != environmentBaseKind2;
		int num3 = 4;
		if (flag)
		{
			object obj2 = baseKind.ShadowSequence - 1;
			if (baseKind.ShadowSequence == EnvironmentBaseShadowSequence.Start)
			{
				goto IL_009e;
			}
			bool flag2 = (nint)obj2 == 1;
			num3 = 2;
			if (!flag2)
			{
				if ((nint)obj2 == 2)
				{
					goto IL_009e;
				}
				num3 = 2;
			}
		}
		goto IL_035f;
		IL_035f:
		if (baseKind.Type != EnvironmentBaseType.Empty)
		{
			ThemeManager themeManager = _themeManager;
			if (!themeManager._theme.ShouldIgnoreBase(envKind))
			{
				_ = baseKind.NumTracks;
				_ = baseKind.Type;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				EnvironmentBaseInfo environmentBaseInfo = default;
				environmentBaseInfo.EnvironmentBaseKind = (EnvironmentBaseKind)0;
				environmentBaseInfo.LengthInBlocks = num3;
				_00210 val = (_00210)SingletonMonobehavior<>.Instance;
				Transform environmentBaseModel = ((AssetManager)val).GetEnvironmentBaseModel(environmentBaseInfo);
				if (environmentBaseModel != null)
				{
					Transform transform = PoolManager.Spawn(environmentBaseModel);
					transform.parent = _environmentTransform;
					nint num4 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v66 (Il2CppClass<UnityEngine.Vector3>)+5C]");
					nint num5 = 0;
					object obj3 = blockIndex * 90;
					object obj4 = Vector3.forwardVector * obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v67 (Il2CppStaticFields<UnityEngine.Vector3>)+4C]");
					object obj5 = 0 * obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v67 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
					object obj6 = 0 * obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
					((Vector3*)(nint)vector)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
					((Vector3*)(nint)vector)->x = 0f;
					transform.localPosition = vector;
				}
				else
				{
					int num6 = (int)(vector + 92);
					string text = ((int*)num6)->ToString();
					string text2 = default;
					if ((object)environmentBaseInfo != null)
					{
						nint num7 = (nint)environmentBaseInfo;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v233 @ S4_v5 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+D4] (should have been resolved before IL gen)");
					}
					else
					{
						text2 = null;
					}
					string text3 = "Env Base at block " + text + ", no model for ground " + text2;
				}
			}
		}
		return num3;
		IL_009e:
		EnvironmentKind pillars = EnvironmentKind.Pillars;
		bool flag3;
		if (((EnvironmentBaseKind*)(nint)envKind)->NumTracks == (int)pillars._type)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envKind @ L4 (SYBO.Subway.Level.EnvironmentBaseKind)+C]");
			flag3 = (nint)0 == (nint)pillars._density;
		}
		else
		{
			flag3 = false;
		}
		if (!flag3)
		{
			EnvironmentKind station = EnvironmentKind.Station;
			bool flag4;
			if (((EnvironmentBaseKind*)(nint)envKind)->NumTracks == (int)station._type)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envKind @ L4 (SYBO.Subway.Level.EnvironmentBaseKind)+C]");
				flag4 = (nint)0 == (nint)station._density;
			}
			else
			{
				flag4 = false;
			}
			bool flag5 = !flag4;
			num3 = 2;
			if (flag5)
			{
				goto IL_035f;
			}
		}
		num3 = 1;
		goto IL_035f;
	}

	private unsafe EnvironmentSequence EvalNextEnvironmentSequence(int nextEnvBlockIndex, int envEndBlockIndex, EnvironmentInfo environmentInfo, bool shouldStartCurrentEnvironment, bool shouldEndCurrentEnvironment)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00d6: Expected Obj, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected I4, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		EnvironmentSequence environmentSequence = EnvironmentSequence.End;
		if (!shouldEndCurrentEnvironment)
		{
			environmentSequence = EnvironmentSequence.Start;
		}
		EnvironmentSequence result = environmentSequence;
		if (!shouldEndCurrentEnvironment)
		{
			result = environmentSequence;
			if (!shouldStartCurrentEnvironment)
			{
				if (nextEnvBlockIndex >= _blockCount)
				{
					int num = obj + 12;
					string text = ((int*)num)->ToString();
					int num2 = this + 28;
					string text2 = ((int*)num2)->ToString();
					string text3 = "RouteChunk: next environment blockIndex=" + text + " out of bounds, numBlocks= " + text2;
					result = EnvironmentSequence.End;
				}
				else
				{
					object obj3 = envEndBlockIndex - nextEnvBlockIndex;
					object obj4 = obj3 + 1;
					object obj5 = environmentInfo + 24;
					object obj6 = environmentInfo + 20;
					if (!environmentInfo.HasStartEnd)
					{
						obj5 = obj6;
					}
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						throw new ArrayTypeMismatchException();
					}
					bool flag = obj4 == obj5;
					EnvironmentSequence environmentSequence2 = EnvironmentSequence.End;
					if (!flag)
					{
						environmentSequence2 = EnvironmentSequence.Mid;
					}
					result = environmentSequence2;
				}
			}
		}
		return result;
	}

	private unsafe int CreateEnvironmentSegment(int blockIndex, EnvironmentInfo environmentInfo, EnvironmentSequence sequence, ref int prevSegmentVariation)
	{
		//IL_01f1: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_0031: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected I4, but got Unknown
		//IL_014e: Expected Obj, but got I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		float num = (float)blockIndex * 90f;
		if (!environmentInfo.HasStartEnd)
		{
			EnvironmentSequence environmentSequence = default;
			object obj = environmentSequence - 1;
			if (environmentSequence != EnvironmentSequence.Start && (nint)obj != 1 && (nint)obj == 2)
			{
			}
		}
		EnvironmentKind kind = environmentInfo.Kind;
		object obj2 = kind._type - 2;
		object obj4;
		if ((nint)obj2 <= 14)
		{
			object obj3 = 16389 >> (int)obj2;
			obj4 = obj3 & 1;
		}
		else
		{
			obj4 = 0;
		}
		float positionZ;
		if (obj4 == null)
		{
			positionZ = num;
		}
		else
		{
			EnvironmentKind kind2 = environmentInfo.Kind;
			CreateEnvironmentLogic(kind2._type, EnvironmentSequence.Mid, num);
			positionZ = num;
		}
		int num2 = CreateEnvironmentModel(environmentInfo, EnvironmentSequence.Mid, prevSegmentVariation, positionZ);
		ref int reference = ref *(int*)num2;
		object obj6;
		if (~(environmentInfo.HasStartEnd ? 1u : 0u) == 0)
		{
			object obj5 = 2 - 1;
			if (2 == 1 || ((nint)obj5 != 1 && (nint)obj5 == 2))
			{
				obj6 = environmentInfo + 24;
				goto IL_0244;
			}
		}
		obj6 = environmentInfo + 20;
		goto IL_0244;
		IL_0244:
		return obj6 + blockIndex;
	}

	private unsafe void CreateEnvironmentLogic(EnvironmentType envType, EnvironmentSequence sequence, float positionZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00ea: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I
		//IL_0188: Expected I, but got Obj
		//IL_01f0: Expected F4, but got I
		//IL_01eb: Expected native int or pointer, but got VT
		//IL_020f: Expected F4, but got I
		//IL_020a: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		Transform transform = _logicAssetManager.SpawnEnvironmentSegmentLogic(envType, sequence);
		if (!(transform == null))
		{
			PlaceholderPrefab component = transform.GetComponent<PlaceholderPrefab>();
			bool flag = component != null;
			List<Selector> environmentSelectors = _environmentSelectors;
			if (flag)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S4_v15 (Il2CppRgctx<System.Collections.Generic.List`1<SYBO.Subway.Level.Selector>>)+3C]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v107 @ S4_v16+4] (should have been resolved before IL gen)");
				TrackObject[] trackObjects = component._trackObjects;
				List<TrackObject> environmentTrackObjects = _environmentTrackObjects;
			}
			else
			{
				Selector[] componentsInChildren = transform.GetComponentsInChildren<Selector>(includeInactive: true);
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S4_v10 (Il2CppRgctx<System.Collections.Generic.List`1<SYBO.Subway.Level.Selector>>)+3C]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ S4_v11+4] (should have been resolved before IL gen)");
				TrackObject[] trackObjects = transform.GetComponentsInChildren<TrackObject>(includeInactive: true);
				List<TrackObject> environmentTrackObjects = _environmentTrackObjects;
			}
			nint num5 = 0;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S4_v5 (Il2CppRgctx<System.Collections.Generic.List`1<TrackObject>>)+3C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v147 @ S4_v6+4] (should have been resolved before IL gen)");
			transform.parent = _environmentTransform;
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v35 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num8 = 0;
			float num9 = (float)Vector3.forwardVector * positionZ;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v36 (Il2CppStaticFields<UnityEngine.Vector3>)+4C]");
			float num10 = 0f * positionZ;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v36 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
			float num11 = 0f * positionZ;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			transform.localPosition = vector;
		}
	}

	private int CreateEnvironmentModel(EnvironmentInfo environmentInfo, EnvironmentSequence sequence, int prevVariation, float positionZ)
	{
		//IL_0018: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I4
		int num = default;
		bool flag = num == 0;
		object obj = 0;
		int num2;
		if (!flag)
		{
			bool flag2 = (byte)(~(environmentInfo.UseSameVariationPerSequence ? 1u : 0u)) != 0;
			obj = 0;
			if (!flag2)
			{
				if (environmentInfo.UseSameVariationForSides)
				{
					bool flag3 = (byte)(~(environmentInfo.HasSides ? 1u : 0u)) != 0;
					num2 = 1;
					if (!flag3)
					{
						goto IL_00cc;
					}
					goto IL_0155;
				}
				obj = 1;
			}
		}
		int environmentModelVariationCount = _themeManager.GetEnvironmentModelVariationCount(RouteCategory.Default, environmentInfo.Kind);
		num2 = environmentModelVariationCount;
		if (environmentInfo.HasSides)
		{
			goto IL_00cc;
		}
		if (obj == null)
		{
			int maxExclusive = environmentModelVariationCount + 1;
			int num3 = UnityEngine.Random.Range(1, maxExclusive);
			num = num3;
		}
		goto IL_0155;
		IL_00cc:
		bool flag4 = (byte)(~(environmentInfo.UseSameVariationForSides ? 1u : 0u)) != 0;
		bool flag5 = !flag4;
		int variation = num;
		if (!flag5)
		{
			int maxExclusive2 = num2 + 1;
			int num4 = UnityEngine.Random.Range(1, maxExclusive2);
			int maxExclusive3 = num2 + 1;
			int num5 = UnityEngine.Random.Range(1, maxExclusive3);
			variation = num4;
			num = num5;
		}
		PlaceEnvironmentModel(environmentInfo.Kind, sequence, EnvironmentSide.Left, variation, positionZ);
		PlaceEnvironmentModel(environmentInfo.Kind, sequence, EnvironmentSide.Right, num, positionZ);
		return 0;
		IL_0155:
		PlaceEnvironmentModel(environmentInfo.Kind, sequence, EnvironmentSide.None, num, positionZ);
		return num;
	}

	private unsafe void PlaceEnvironmentModel(EnvironmentKind envTypeInfo, EnvironmentSequence sequence, EnvironmentSide side, int variation, float positionZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00fc: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_01a7: Expected I, but got Obj
		//IL_020f: Expected F4, but got I
		//IL_020a: Expected native int or pointer, but got VT
		//IL_022e: Expected F4, but got I
		//IL_0229: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		Transform environmentSegmentModel = _themeManager.GetEnvironmentSegmentModel(RouteCategory.Default, envTypeInfo, sequence, side, variation);
		if (!(environmentSegmentModel == null))
		{
			Transform transform = PoolManager.Spawn(environmentSegmentModel);
			PlaceholderPrefab component = transform.GetComponent<PlaceholderPrefab>();
			bool flag = component != null;
			List<Selector> environmentSelectors = _environmentSelectors;
			if (flag)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S4_v16 (Il2CppRgctx<System.Collections.Generic.List`1<SYBO.Subway.Level.Selector>>)+3C]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v116 @ S4_v17+4] (should have been resolved before IL gen)");
				TrackObject[] trackObjects = component._trackObjects;
				List<TrackObject> environmentTrackObjects = _environmentTrackObjects;
			}
			else
			{
				Selector[] componentsInChildren = transform.GetComponentsInChildren<Selector>(includeInactive: true);
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S4_v11 (Il2CppRgctx<System.Collections.Generic.List`1<SYBO.Subway.Level.Selector>>)+3C]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v173 @ S4_v12+4] (should have been resolved before IL gen)");
				TrackObject[] trackObjects = transform.GetComponentsInChildren<TrackObject>(includeInactive: true);
				List<TrackObject> environmentTrackObjects = _environmentTrackObjects;
			}
			nint num5 = 0;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S4_v6 (Il2CppRgctx<System.Collections.Generic.List`1<TrackObject>>)+3C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v156 @ S4_v7+4] (should have been resolved before IL gen)");
			transform.parent = _environmentTransform;
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v38 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num8 = 0;
			float num9 = (float)Vector3.forwardVector * positionZ;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v39 (Il2CppStaticFields<UnityEngine.Vector3>)+4C]");
			float num10 = 0f * positionZ;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v39 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
			float num11 = 0f * positionZ;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			transform.localPosition = vector;
		}
	}

	private void EvaluateEnvironmentConstraints()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006b: Expected I, but got Obj
		//IL_0124: Expected Obj, but got I
		//IL_014b: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		List<> blockConstraints;
		if (_blockConstraints != null)
		{
			blockConstraints = (List<>)(object)_blockConstraints;
		}
		else
		{
			List<ChunkBlockConstraint> list = default;
			list._002Ector(_blockCount);
			_blockConstraints = list;
			blockConstraints = (List<>)(object)_blockConstraints;
		}
		((List<T>)(object)blockConstraints).Clear();
		int num = 0;
		ChunkBlockConstraint chunkBlockConstraint = default;
		while (_blockCount > num)
		{
			EnvironmentKind none = EnvironmentKind.None;
			nint num2 = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v12 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v13 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
			_ = 0;
			_ = EnvironmentBaseKind.None;
			SYBO.Subway.Level.Environment environmentConstraint = GetEnvironmentConstraint(num);
			EnvironmentBase environmentBaseConstraint = GetEnvironmentBaseConstraint(num);
			bool flag = environmentConstraint != null;
			bool flag2 = !flag;
			EnvironmentKind environmentKind = none;
			if (!flag2)
			{
				environmentKind = environmentConstraint._environmentKind;
			}
			if (environmentBaseConstraint != null)
			{
				EnvironmentBaseKind environmentBaseKind = EnvironentBaseToBaseKind(environmentBaseConstraint);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			obj = 0;
			chunkBlockConstraint.EnvironmentKind = environmentKind;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			chunkBlockConstraint.EnvironmentBaseKind = (EnvironmentBaseKind)obj;
			_blockConstraints.Add(chunkBlockConstraint);
			int num4 = num + 1;
			num = num4;
		}
	}

	private unsafe SYBO.Subway.Level.Environment GetEnvironmentConstraint(int blockIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I
		//IL_0132: Expected F4, but got I
		//IL_012d: Expected native int or pointer, but got VT
		//IL_0151: Expected F4, but got I
		//IL_014c: Expected native int or pointer, but got VT
		//IL_0178: Expected Obj, but got I
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_01fb: Expected Obj, but got I
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_01dc: Expected Obj, but got I4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		SYBO.Subway.Level.Environment[] forcedEnvironments = _forcedEnvironments;
		bool flag = forcedEnvironments.Length == 0;
		object obj2 = forcedEnvironments.Length;
		Component result;
		if (!flag)
		{
			object obj3 = default;
			object obj11 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				object obj4 = obj3 << 2;
				object obj5 = (object)forcedEnvironments + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v9+10]");
				Component component = (Component)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v9+10]");
				Transform transform = ((Component)0).transform;
				Vector3 position = transform.position;
				Vector3 position2 = _transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				object obj6 = num - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				object obj7 = num2 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				object obj8 = num3 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				int blockIndexFromLocalPosition = GetBlockIndexFromLocalPosition(vector);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v10 (UnityEngine.Component)+10]");
				object obj9 = (nint)blockIndexFromLocalPosition + (nint)0;
				object obj10 = obj9 - 1;
				bool flag2 = blockIndex >= blockIndexFromLocalPosition;
				if (blockIndex > (nint)obj10)
				{
					flag2 = false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v9+10]");
				result = (Component)0;
				if (!flag2)
				{
					obj3 = obj11 + 1;
					obj2 = forcedEnvironments.Length;
					continue;
				}
				goto IL_0209;
			}
		}
		result = null;
		goto IL_0209;
		IL_0209:
		return (SYBO.Subway.Level.Environment)result;
	}

	private unsafe EnvironmentBase GetEnvironmentBaseConstraint(int blockIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I
		//IL_0132: Expected F4, but got I
		//IL_012d: Expected native int or pointer, but got VT
		//IL_0151: Expected F4, but got I
		//IL_014c: Expected native int or pointer, but got VT
		//IL_0178: Expected Obj, but got I
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_01fb: Expected Obj, but got I
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_01dc: Expected Obj, but got I4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		EnvironmentBase[] forcedEnvironmentBases = _forcedEnvironmentBases;
		bool flag = forcedEnvironmentBases.Length == 0;
		object obj2 = forcedEnvironmentBases.Length;
		Component result;
		if (!flag)
		{
			object obj3 = default;
			object obj11 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				object obj4 = obj3 << 2;
				object obj5 = (object)forcedEnvironmentBases + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v9+10]");
				Component component = (Component)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v9+10]");
				Transform transform = ((Component)0).transform;
				Vector3 position = transform.position;
				Vector3 position2 = _transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				object obj6 = num - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				object obj7 = num2 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				object obj8 = num3 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				int blockIndexFromLocalPosition = GetBlockIndexFromLocalPosition(vector);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v10 (UnityEngine.Component)+14]");
				object obj9 = (nint)blockIndexFromLocalPosition + (nint)0;
				object obj10 = obj9 - 1;
				bool flag2 = blockIndex >= blockIndexFromLocalPosition;
				if (blockIndex > (nint)obj10)
				{
					flag2 = false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v9+10]");
				result = (Component)0;
				if (!flag2)
				{
					obj3 = obj11 + 1;
					obj2 = forcedEnvironmentBases.Length;
					continue;
				}
				goto IL_0209;
			}
		}
		result = null;
		goto IL_0209;
		IL_0209:
		return (EnvironmentBase)result;
	}

	public unsafe static EnvironmentBaseKind EnvironentBaseToBaseKind(EnvironmentBase envBase)
	{
		//IL_0167: Expected I, but got Obj
		//IL_01bd: Expected I4, but got VT
		//IL_01b8: Expected native int or pointer, but got VT
		//IL_01cd: Expected native int or pointer, but got VT
		//IL_00a0: Expected I, but got Obj
		//IL_00c9: Expected I, but got Obj
		//IL_00f2: Expected I, but got Obj
		//IL_011b: Expected I, but got Obj
		//IL_0144: Expected I, but got Obj
		if (envBase._type == EnvironmentBase.EnvironmentBaseType.Tracks)
		{
			if (envBase._numTracks != 0)
			{
				if (envBase._numTracks != 1)
				{
					if (envBase._numTracks != 2)
					{
						if (envBase._numTracks == 3)
						{
							nint num = (nint)typeof(EnvironmentBaseKind);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v38 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
							nint num2 = (nint)0 + (nint)132;
						}
						else
						{
							nint num3 = (nint)typeof(EnvironmentBaseKind);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v44 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
							nint num2 = 0;
						}
					}
					else
					{
						nint num4 = (nint)typeof(EnvironmentBaseKind);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v32 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
						nint num2 = (nint)0 + (nint)84;
					}
				}
				else
				{
					nint num5 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v26 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
					nint num2 = (nint)0 + (nint)36;
				}
			}
			else
			{
				nint num6 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v20 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
				nint num2 = (nint)0 + (nint)24;
			}
		}
		else
		{
			nint num7 = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v12 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
			nint num2 = (nint)0 + (nint)12;
		}
		EnvironmentBaseKind environmentBaseKind = default;
		((EnvironmentBaseKind*)(nint)environmentBaseKind)->Type = (EnvironmentBaseType)EnvironmentBaseKind.None;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v5 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
		((EnvironmentBaseKind*)(nint)environmentBaseKind)->NumTracks = 0;
		return environmentBaseKind;
	}

	public static int GetBlockIndexFromLocalPosition(Vector3 localPos)
	{
		//IL_0059: Expected F8, but got I4
		//IL_0075: Invalid comparison between F8 and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected I4, but got Unknown
		//IL_0067: Expected F8, but got I4
		double num = localPos.z;
		double num2 = Math.Abs((double)localPos.z);
		if (!(num2 < 2147483648.0))
		{
			num = -2147483648.0;
		}
		if (!(num > 0.0))
		{
			num = 0.0;
		}
		return (int)(num / 90);
	}

	public static float GetBaseColliderOffsetY()
	{
		return 0.6000004f;
	}

	public static bool HasParentRouteChunk(Transform childTransform)
	{
		RouteChunk parentRouteChunk = GetParentRouteChunk(childTransform);
		return parentRouteChunk != null;
	}

	public static RouteChunk GetParentRouteChunk(Transform childTransform)
	{
		return childTransform.GetComponentInParent<RouteChunk>();
	}

	public RouteChunk()
	{
		//IL_008f: Expected I, but got Obj
		//IL_0115: Expected VT, but got F4
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		float num3 = (float)Vector3.upVector * -1000f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
		float num4 = 0f * -1000f;
		_generateEnvironmentBase = true;
		_blockCount = 2;
		_isRepeatableInSections = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		float num5 = 0f * -1000f;
		LogicHideOffset = (Vector3)num3;
		List<TrackObject> list = default;
		list._002Ector();
		_trackObjects = list;
		List<TrackObject> list2 = default;
		list2._002Ector();
		_environmentTrackObjects = list2;
		List<Selector> list3 = default;
		list3._002Ector();
		_selectors = list3;
		List<Selector> list4 = default;
		list4._002Ector();
		_environmentSelectors = list4;
		nint num6 = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Transform, UnityEngine.Vector3>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Transform, Vector3> hiddenObstacles = default;
		_hiddenObstacles = hiddenObstacles;
		base._002Ector();
	}
}
