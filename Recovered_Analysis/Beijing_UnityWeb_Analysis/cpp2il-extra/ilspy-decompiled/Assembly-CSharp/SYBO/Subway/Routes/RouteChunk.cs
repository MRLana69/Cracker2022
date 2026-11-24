using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using SYBO.Common.Automation;
using SYBO.Common.Data;
using SYBO.Common.Utilities;
using SYBO.Common.Visuals;
using SYBO.Components.Utilities;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Characters;
using SYBO.Subway.Level;
using SYBO.Subway.Managers;
using SYBO.Subway.Pickups;
using SYBO.Subway.Routes.Builders;
using SYBO.Subway.StateSystem;
using SYBO.Subway.StateSystem.States;
using SYBO.Subway.Themes;
using SYBO.Subway.Utilities;
using UnityEngine;
using UnityEngine.U2D;

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
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected Obj, but got Unknown
			//IL_00b9: Expected Obj, but got VT
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.EventArgs>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventArgs);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<System.EventArgs>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = this + 8;
			obj2 = envKind;
			object obj3 = this + 12;
			obj3 = envBaseKind;
		}

		public static bool operator ==(ChunkBlockConstraint c1, ChunkBlockConstraint c2)
		{
			if ((object)c2 != null)
			{
				if ((nint)c2 != 1)
				{
					if ((nint)c2 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c1 @ L0 (SYBO.Subway.Routes.RouteChunk+ChunkBlockConstraint)+18]");
						return false;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
					UnityEngine.Object context = default;
					SDebug.LogAssertion("Unhandled performance level in preload settings", context);
					return false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c1 @ L0 (SYBO.Subway.Routes.RouteChunk+ChunkBlockConstraint)+14]");
				return false;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c1 @ L0 (SYBO.Subway.Routes.RouteChunk+ChunkBlockConstraint)+10]");
			return false;
		}

		public static bool operator !=(ChunkBlockConstraint c1, ChunkBlockConstraint c2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			bool result = default;
			return result;
		}

		public override bool Equals(object other)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			object obj = default;
			return (byte)(obj ^ 1) != 0;
		}

		public override int GetHashCode()
		{
			//IL_0007: Expected I4, but got VT
			return (int)EnvironmentBaseKind;
		}

		static ChunkBlockConstraint()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Game._003C_003Ec obj = default;
			Game._003C_003Ec._003C_003E9 = obj;
		}
	}

	private sealed class _003CDestruct_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RouteChunk _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0042: Expected I, but got Obj
				//IL_0058: Expected Obj, but got I
				//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c5: Expected Obj, but got Unknown
				//IL_02ce: Expected Obj, but got I4
				//IL_02dc: Expected I, but got Obj
				//IL_02f2: Expected Obj, but got I
				//IL_0083: Expected I, but got Obj
				//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d5: Expected Obj, but got Unknown
				//IL_00de: Expected Obj, but got I4
				//IL_0318: Unknown result type (might be due to invalid IL or missing references)
				//IL_031d: Expected Obj, but got Unknown
				//IL_0326: Expected Obj, but got I4
				//IL_00f1: Expected I, but got Obj
				//IL_01de: Expected I, but got Obj
				//IL_01f4: Expected Obj, but got I
				//IL_013e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0143: Expected Obj, but got Unknown
				//IL_014c: Expected Obj, but got I4
				//IL_0339: Expected Obj, but got I4
				//IL_033f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0344: Expected Obj, but got Unknown
				//IL_034d: Expected Obj, but got I4
				//IL_0361: Expected Obj, but got I4
				//IL_021f: Expected I, but got Obj
				RouteChunk routeChunk = _003C_003E4__this;
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
					nint num = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)routeChunk.Next).FindKernel((string)null) != 0)
					{
						object obj2 = routeChunk.Next + 72;
						obj2 = 0;
					}
					object obj3 = routeChunk + 76;
					obj3 = 0;
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)routeChunk.Previous).FindKernel((string)null) != 0)
					{
						object obj5 = routeChunk.Previous + 76;
						obj5 = 0;
					}
					object obj6 = routeChunk + 72;
					obj6 = 0;
				}
				int siblingIndex = routeChunk._environmentTransform.GetSiblingIndex();
				if (siblingIndex < 1)
				{
					routeChunk._built = false;
					return null;
				}
				bool flag = ((SpriteAtlas)(object)routeChunk._environmentTransform).CanBindTo((Sprite)null);
				nint num5 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v8 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num6 = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v16 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				PoolManager.AddPool((PrefabPool)flag);
				object obj8 = this + 12;
				obj8 = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CDestruct_003Ed__41(int _003C_003E1__state)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_00a6: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.EventArgs>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventArgs);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<System.EventArgs>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = this + 8;
			obj2 = _003C_003E1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0017: Expected Obj, but got I4
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected Obj, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected Obj, but got Unknown
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected Obj, but got Unknown
			//IL_0094: Expected I4, but got Obj
			object obj2 = default;
			object obj = obj2 + 12;
			obj = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj3 = this + 12;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v8+8]");
			_ = 0;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9806");
			object obj5 = default;
			object obj4 = obj5 + 493;
			object obj6 = obj4 * 29;
			object obj7 = default;
			return (byte)(int)(obj7 + obj6) != 0;
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

	private sealed class _003CActivateTrackObjectsASync_003Ed__84(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public RouteChunk _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0600: Expected Obj, but got Unknown
				//IL_0067: Expected Obj, but got I4
				//IL_0080: Expected Obj, but got I4
				//IL_00cf: Expected Obj, but got I4
				//IL_0099: Expected Obj, but got I4
				//IL_010d: Expected Obj, but got I
				//IL_066e: Expected Obj, but got I
				//IL_0168: Expected Obj, but got I
				//IL_017a: Expected I, but got Obj
				//IL_0190: Expected Obj, but got I
				//IL_00a7: Expected Obj, but got I4
				//IL_0402: Expected Obj, but got I
				//IL_0414: Expected I, but got Obj
				//IL_042a: Expected Obj, but got I
				//IL_03e6: Expected Obj, but got I4
				//IL_01bb: Expected I, but got Obj
				//IL_0455: Expected I, but got Obj
				//IL_0332: Unknown result type (might be due to invalid IL or missing references)
				//IL_0337: Expected Obj, but got Unknown
				//IL_0340: Expected Obj, but got I4
				//IL_0354: Expected Obj, but got I4
				//IL_035d: Expected Obj, but got I4
				//IL_05ed: Expected Obj, but got I4
				//IL_031d: Expected Obj, but got I4
				//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_05b7: Expected Obj, but got Unknown
				//IL_05c0: Expected Obj, but got I4
				//IL_05d4: Expected Obj, but got I4
				//IL_05de: Expected Obj, but got I4
				object obj2 = default;
				object obj = obj2 + 4;
				RouteChunk original = _003C_003E4__this;
				object obj3;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							obj3 = 24;
						}
						else
						{
							obj3 = 26;
						}
					}
					else
					{
						_003C_003E1__state = -1;
						obj3 = 13;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					_003Ci_003E5__2 = 0;
					obj3 = 14;
				}
				object obj4 = obj3;
				object result = default;
				while (true)
				{
					if ((nint)obj4 == 13)
					{
						int num = _003Ci_003E5__2 + 1;
						_003Ci_003E5__2 = num;
						obj4 = 14;
						continue;
					}
					if ((nint)obj4 == 14)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (SYBO.Subway.Routes.RouteChunk)+2C]");
						object obj5 = 0;
						int num2 = _003Ci_003E5__2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v50+C]");
						if ((nint)num2 < (nint)0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (SYBO.Subway.Routes.RouteChunk)+2C]");
							TrackObject trackObject = ((List<TrackObject>)0).get_Item(_003Ci_003E5__2);
							nint num3 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v84 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj6 = (nint)0 & (nint)0x200;
							if (obj6 != null)
							{
								nint num4 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v116 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (trackObject != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
								UnityEngine.Object obj7 = UnityEngine.Object.Instantiate((UnityEngine.Object)original);
								throw new ArrayTypeMismatchException();
							}
							string tag = trackObject.tag;
							string tag2 = ((GameObject)(object)tag).tag;
							if (tag2 == null)
							{
								obj4 = 13;
								continue;
							}
							trackObject.Deactivate();
							object obj8 = this + 12;
							obj8 = 0;
							_003C_003E1__state = 1;
							result = 1;
							obj4 = 26;
							continue;
						}
						_003Ci_003E5__2 = 0;
					}
					else if ((nint)obj4 == 24)
					{
						int num5 = _003Ci_003E5__2 + 1;
						_003Ci_003E5__2 = num5;
					}
					else if ((nint)obj4 == 26)
					{
						return result;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (SYBO.Subway.Routes.RouteChunk)+30]");
					object obj9 = 0;
					int num6 = _003Ci_003E5__2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v10+C]");
					if ((nint)num6 >= (nint)0)
					{
						result = null;
						obj4 = 26;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (SYBO.Subway.Routes.RouteChunk)+30]");
					TrackObject trackObject2 = ((List<TrackObject>)0).get_Item(_003Ci_003E5__2);
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num8 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v62 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!(trackObject2 != null))
					{
						string tag3 = trackObject2.tag;
						string tag4 = ((GameObject)(object)tag3).tag;
						object obj12;
						if (tag4 != null)
						{
							trackObject2.Deactivate();
							object obj11 = this + 12;
							obj11 = 0;
							_003C_003E1__state = 2;
							result = 1;
							obj12 = 26;
						}
						else
						{
							obj12 = 24;
						}
						obj4 = obj12;
						continue;
					}
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				UnityEngine.Object obj13 = UnityEngine.Object.Instantiate((UnityEngine.Object)original);
				throw new ArrayTypeMismatchException();
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

	private sealed class _003CDeactivateTrackObjects_003Ed__85(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public RouteChunk _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0691: Unknown result type (might be due to invalid IL or missing references)
				//IL_0696: Expected Obj, but got Unknown
				//IL_009b: Expected Obj, but got I4
				//IL_00b4: Expected Obj, but got I4
				//IL_00cd: Expected Obj, but got I4
				//IL_0103: Expected Obj, but got I4
				//IL_0141: Expected Obj, but got I
				//IL_00db: Expected Obj, but got I4
				//IL_0704: Expected Obj, but got I
				//IL_019c: Expected Obj, but got I
				//IL_01ae: Expected I, but got Obj
				//IL_01c4: Expected Obj, but got I
				//IL_0471: Expected Obj, but got I
				//IL_0483: Expected I, but got Obj
				//IL_0499: Expected Obj, but got I
				//IL_01ef: Expected I, but got Obj
				//IL_04c4: Expected I, but got Obj
				//IL_0683: Expected Obj, but got I4
				//IL_039b: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a0: Expected Obj, but got Unknown
				//IL_03a9: Expected Obj, but got I4
				//IL_03bd: Expected Obj, but got I4
				//IL_03c6: Expected Obj, but got I4
				//IL_0350: Expected Obj, but got I4
				//IL_0386: Expected Obj, but got I4
				//IL_0675: Expected Obj, but got I4
				//IL_063c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0641: Expected Obj, but got Unknown
				//IL_064a: Expected Obj, but got I4
				//IL_065e: Expected Obj, but got I4
				//IL_0667: Expected Obj, but got I4
				object obj2 = default;
				object obj = obj2 + 4;
				RouteChunk original = _003C_003E4__this;
				object obj3;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							obj3 = 28;
						}
						else
						{
							obj3 = 31;
						}
					}
					else
					{
						_003C_003E1__state = -1;
						obj3 = 16;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (SYBO.Subway.Routes.RouteChunk)+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
					}
					_003Ci_003E5__2 = 0;
					obj3 = 17;
				}
				object obj4 = obj3;
				object result = default;
				while (true)
				{
					if ((nint)obj4 == 16)
					{
						int num = _003Ci_003E5__2 + 1;
						_003Ci_003E5__2 = num;
						obj4 = 17;
						continue;
					}
					if ((nint)obj4 == 17)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (SYBO.Subway.Routes.RouteChunk)+2C]");
						object obj5 = 0;
						int num2 = _003Ci_003E5__2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v53+C]");
						if ((nint)num2 < (nint)0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (SYBO.Subway.Routes.RouteChunk)+2C]");
							TrackObject trackObject = ((List<TrackObject>)0).get_Item(_003Ci_003E5__2);
							nint num3 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v90 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj6 = (nint)0 & (nint)0x200;
							if (obj6 != null)
							{
								nint num4 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v126 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (trackObject != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
								UnityEngine.Object obj7 = UnityEngine.Object.Instantiate((UnityEngine.Object)original);
								throw new ArrayTypeMismatchException();
							}
							string tag = trackObject.tag;
							string tag2 = ((GameObject)(object)tag).tag;
							if (tag2 == null)
							{
								obj4 = 16;
								continue;
							}
							if (~(trackObject._active ? 1u : 0u) != 0)
							{
								obj4 = 16;
								continue;
							}
							trackObject._002Ector();
							object obj8 = this + 12;
							obj8 = 0;
							_003C_003E1__state = 1;
							result = 1;
							obj4 = 31;
							continue;
						}
						_003Ci_003E5__2 = 0;
					}
					else if ((nint)obj4 == 28)
					{
						int num5 = _003Ci_003E5__2 + 1;
						_003Ci_003E5__2 = num5;
					}
					else if ((nint)obj4 == 31)
					{
						return result;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (SYBO.Subway.Routes.RouteChunk)+30]");
					object obj9 = 0;
					int num6 = _003Ci_003E5__2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v10+C]");
					if ((nint)num6 >= (nint)0)
					{
						throw new IndexOutOfRangeException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (SYBO.Subway.Routes.RouteChunk)+30]");
					TrackObject trackObject2 = ((List<TrackObject>)0).get_Item(_003Ci_003E5__2);
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num8 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v67 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (trackObject2 != null)
					{
						break;
					}
					string tag3 = trackObject2.tag;
					string tag4 = ((GameObject)(object)tag3).tag;
					object obj12;
					if (tag4 != null)
					{
						if (~(trackObject2._active ? 1u : 0u) == 0)
						{
							trackObject2._002Ector();
							object obj11 = this + 12;
							obj11 = 0;
							_003C_003E1__state = 2;
							result = 1;
							obj12 = 31;
						}
						else
						{
							obj12 = 28;
						}
					}
					else
					{
						obj12 = 28;
					}
					obj4 = obj12;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				UnityEngine.Object obj13 = UnityEngine.Object.Instantiate((UnityEngine.Object)original);
				throw new ArrayTypeMismatchException();
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

	public const int TrackLaneWidth = 20;

	public const int TrackWidth = 60;

	public const int TrackHeight = 90;

	public const int BlockLength = 90;

	public const int BlockCountMin = 2;

	public const int MinChunkLength = 180;

	private const float BaseColliderCenterY = -9.4f;

	private const float BaseColliderSizeY = 20f;

	private readonly Vector3 LogicHideOffset;

	private Action m_OnDeactivate;

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

	public bool GenerateEnvironmentBase
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			return flag;
		}
	}

	public List<Selector> Selectors
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool generateEnvironmentBase = _generateEnvironmentBase;
			return (List<Selector>)generateEnvironmentBase;
		}
	}

	public List<Selector> EnvironmentSelectors => _selectors;

	public Transform EnvironmentTransform
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			return (Transform)(this - -64);
		}
	}

	public bool IsRepeatableInSections
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_environmentTransform != 0;
		}
	}

	public bool IsBuilt => _isRepeatableInSections;

	public int Length => _built ? 1 : 0;

	public int BlockCount => _blockCount * 90;

	public bool GenerateEnvironment => (byte)_blockCount != 0;

	public IList<EnvironmentKind> LimitedAllowedEnvironmentKinds
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool generateEnvironment = _generateEnvironment;
			return (IList<EnvironmentKind>)generateEnvironment;
		}
	}

	public Bounds TrackBounds
	{
		get
		{
			//IL_0034: Expected Obj, but got I
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+18]");
			Delegate obj = (Delegate)0;
			Bounds bounds = default;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)(object)this);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = bounds + 24;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 == obj)
				{
					break;
				}
				obj = (Delegate)obj3;
			}
			return bounds;
		}
	}

	public float GamePositionStartZ
	{
		get
		{
			//IL_0007: Expected F4, but got Obj
			return (float)_forcedEnvironmentBases;
		}
	}

	public unsafe Vector3 GamePositionStart
	{
		get
		{
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Expected Obj, but got Unknown
			//IL_00de: Expected Obj, but got I4
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected Obj, but got Unknown
			//IL_00fb: Expected Obj, but got I4
			//IL_0111: Expected Obj, but got I4
			//IL_011a: Expected Obj, but got F4
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Expected Obj, but got Unknown
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Expected Obj, but got Unknown
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected Obj, but got Unknown
			//IL_0182: Expected Obj, but got I4
			//IL_0191: Expected Obj, but got F4
			//IL_01b9: Expected I, but got Obj
			//IL_01cf: Expected Obj, but got I
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fa: Expected VT, but got Unknown
			//IL_0207: Expected F4, but got Obj
			//IL_0202: Expected native int or pointer, but got VT
			//IL_021c: Expected F4, but got I
			//IL_0217: Expected native int or pointer, but got VT
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Expected Obj, but got Unknown
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Expected Obj, but got Unknown
			//IL_0272: Unknown result type (might be due to invalid IL or missing references)
			//IL_0277: Expected VT, but got Unknown
			//IL_0284: Expected F4, but got Obj
			//IL_027f: Expected native int or pointer, but got VT
			//IL_0299: Expected F4, but got I
			//IL_0294: Expected native int or pointer, but got VT
			//IL_02a6: Expected F4, but got Obj
			//IL_02a1: Expected native int or pointer, but got VT
			//IL_02bb: Expected F4, but got I
			//IL_02b6: Expected native int or pointer, but got VT
			//IL_005b: Expected native int or pointer, but got VT
			//IL_0069: Expected native int or pointer, but got VT
			//IL_0081: Expected F4, but got Obj
			//IL_007c: Expected native int or pointer, but got VT
			//IL_0096: Expected F4, but got I
			//IL_0091: Expected native int or pointer, but got VT
			//IL_00a3: Expected F4, but got Obj
			//IL_009e: Expected native int or pointer, but got VT
			//IL_00b8: Expected F4, but got I
			//IL_00b3: Expected native int or pointer, but got VT
			//IL_0013: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 84;
			obj = 0;
			_ = 0;
			object obj3 = obj2 + 72;
			obj3 = 0;
			_ = 0;
			object obj4 = _blockCount * 90;
			obj = 60f;
			_ = 90f;
			object obj5 = obj2 + 60;
			obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj6 = obj2 + 48;
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj7 = obj2 + 36;
			obj7 = 0;
			_ = 0;
			obj7 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v21+4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v26+8]");
			_ = 0;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v37 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v65 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector = (Vector3)(obj2 + 108);
			((Vector3*)(nint)vector)->x = (float)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v31+8]");
			((Vector3*)(nint)vector)->z = 0f;
			object obj9 = obj2 + 24;
			Vector3 vector2 = vector / 0.5f;
			obj3 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v45+8]");
			_ = 0;
			object obj10 = obj2 + 12;
			Vector3 gamePositionEnd = GamePositionEnd;
			Vector3 vector3 = (Vector3)(obj2 + 96);
			((Vector3*)(nint)vector3)->x = (float)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v49+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector4 = vector3 - vector;
			Vector3 vector5 = default;
			((Vector3*)(nint)vector5)->x = 0f;
			((Vector3*)(nint)vector5)->z = 0f;
			_ = 0;
			((Vector3*)(nint)vector3)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
			return vector5;
		}
	}

	public Vector3 GamePositionEnd
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ab: Expected VT, but got Obj
			//IL_00ab: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GamePositionRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isRestricted = AgeRestriction.isRestricted;
			Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)_transform);
			Vector3 result = default;
			return result;
		}
	}

	public RouteBuilder RouteBuilder => (RouteBuilder)(object)_limitedAllowedEnvironmentKinds;

	public RouteSection Section => (RouteSection)(object)_builder;

	public string ReportedName => (string)(object)_section;

	public RouteTransitionTrigger RouteTransitionTrigger => (RouteTransitionTrigger)(object)_reportedName;

	public unsafe event Action OnDeactivate
	{
		add
		{
			//IL_001f: Expected Obj, but got I4
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected Obj, but got Unknown
			//IL_009f: Expected I, but got Obj
			//IL_00b5: Expected Obj, but got I
			//IL_00e0: Expected I, but got Obj
			if (_environmentTrackObjects == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
			_environmentTrackObjects = (List<TrackObject>)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Character.OnHangtimeDelegate onHangtimeDelegate = default;
			((Delegate)onHangtimeDelegate).method_ptr = method_ptr;
			((Delegate)onHangtimeDelegate).method = (nint)__ldftn(Route.Character_OnLanding);
			object obj = onHangtimeDelegate + 16;
			obj = this;
			((Character)(object)_trackObjects).OnHangtime += onHangtimeDelegate;
			if (this.m_OnDeactivate == null)
			{
				return;
			}
			nint num = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v16 (Il2CppClass<System.EventArgs>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(EventArgs);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v21 (Il2CppClass<System.EventArgs>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnDeactivate;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 24;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public unsafe void Initialize(RouteBuilder builder, RouteSection section, RouteChunk sourcePrefab)
	{
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected VT, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_025a: Expected Obj, but got I4
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got I4
		//IL_00a5: Expected native int or pointer, but got VT
		//IL_00bf: Expected Obj, but got I
		//IL_00ba: Expected native int or pointer, but got VT
		//IL_00c4: Expected native int or pointer, but got Obj
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_012a: Expected Obj, but got I4
		//IL_013d: Expected native int or pointer, but got VT
		//IL_0157: Expected Obj, but got I
		//IL_0152: Expected native int or pointer, but got VT
		//IL_015c: Expected native int or pointer, but got Obj
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01c2: Expected Obj, but got I4
		//IL_01d5: Expected native int or pointer, but got VT
		//IL_01ef: Expected Obj, but got I
		//IL_01ea: Expected native int or pointer, but got VT
		//IL_01f4: Expected native int or pointer, but got Obj
		object obj = default;
		EnvironmentSegmentParts environmentSegmentParts = (EnvironmentSegmentParts)(obj - -64);
		object obj2 = obj + 12;
		object obj3 = obj + 48;
		obj3 = 0;
		_ = 0;
		object obj4 = sourcePrefab - 1;
		if ((nint)sourcePrefab != 1)
		{
			if ((nint)obj4 != 1)
			{
				if ((nint)obj4 == 2)
				{
					obj2 = section;
					_ = ((RouteBuilder)(object)section).OnCompletedLayingSections;
					_ = ((RouteBuilder)(object)section).OnRouteChunkSpawned;
					_ = ((RouteBuilder)(object)section)._midSectionsCountLimited;
					_ = ((RouteBuilder)(object)section)._startSectionPrefabs;
					object obj5 = obj2 + 24;
					obj = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v64+8]");
					_ = 0;
					RouteChunk routeChunk = (RouteChunk)0;
					((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
					System.Runtime.CompilerServices.Unsafe.Write(&((EnvironmentSegmentParts*)(nint)environmentSegmentParts)->Left, obj);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					System.Runtime.CompilerServices.Unsafe.Write(&((EnvironmentSegmentParts*)(nint)environmentSegmentParts)->Joint, (Transform)0);
					System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)this, new EnvironmentSegmentParts?(environmentSegmentParts));
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
					RouteChunk routeChunk = (RouteChunk)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
				}
			}
			else
			{
				obj2 = section;
				_ = ((RouteBuilder)(object)section).OnCompletedLayingSections;
				_ = ((RouteBuilder)(object)section).OnRouteChunkSpawned;
				_ = ((RouteBuilder)(object)section)._midSectionsCountLimited;
				_ = ((RouteBuilder)(object)section)._startSectionPrefabs;
				object obj6 = obj2 + 12;
				obj = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v42+8]");
				_ = 0;
				RouteChunk routeChunk = (RouteChunk)0;
				((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
				System.Runtime.CompilerServices.Unsafe.Write(&((EnvironmentSegmentParts*)(nint)environmentSegmentParts)->Left, obj);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				System.Runtime.CompilerServices.Unsafe.Write(&((EnvironmentSegmentParts*)(nint)environmentSegmentParts)->Joint, (Transform)0);
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)this, new EnvironmentSegmentParts?(environmentSegmentParts));
			}
		}
		else
		{
			obj2 = section;
			_ = ((RouteBuilder)(object)section).OnCompletedLayingSections;
			_ = ((RouteBuilder)(object)section).OnRouteChunkSpawned;
			_ = ((RouteBuilder)(object)section)._midSectionsCountLimited;
			_ = ((RouteBuilder)(object)section)._startSectionPrefabs;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			_ = 0;
			RouteChunk routeChunk = (RouteChunk)0;
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
			System.Runtime.CompilerServices.Unsafe.Write(&((EnvironmentSegmentParts*)(nint)environmentSegmentParts)->Left, obj);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			System.Runtime.CompilerServices.Unsafe.Write(&((EnvironmentSegmentParts*)(nint)environmentSegmentParts)->Joint, (Transform)0);
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)this, new EnvironmentSegmentParts?(environmentSegmentParts));
		}
	}

	protected void Awake()
	{
		CancelInvoke();
	}

	public IEnumerator Destruct()
	{
		return (IEnumerator)UnityEngine.Object.Instantiate((UnityEngine.Object)this);
	}

	private void OnDrawGizmos()
	{
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected Obj, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected Obj, but got Unknown
		//IL_04aa: Expected VT, but got Obj
		//IL_04b2: Expected Obj, but got VT
		//IL_04c0: Expected I, but got Obj
		//IL_04d6: Expected Obj, but got I
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected Obj, but got Unknown
		//IL_0527: Expected I4, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj = this + 88;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
		object obj2 = this + 100;
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		obj2 = val;
		nint num = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v72 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = this + 104;
		GameStateMachine instance = GameStateMachine.Instance;
		obj4 = instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject2 = default;
		gameObject2.layer = (int)"GeneratedEnvironment";
		object obj5 = this + 92;
		int layer = gameObject2.layer;
		obj5 = layer;
		_environmentTransform.parentInternal = _transform;
		SYBO.Common.Utilities.GameObjectUtil.ResetLocalRotation(_environmentTransform);
		throw new IndexOutOfRangeException();
	}

	public void DrawSegments(Vector3 from, float length, float ySize, float zStep, Color startColor, Color midColor, Color endColor)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public bool SupportsAnyEnvironmentOf(IList<EnvironmentKind> environmentKinds)
	{
		return true;
	}

	public bool SupportsEnvironment(EnvironmentKind environmentKind)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_010f: Expected Obj, but got I4
		//IL_01d9: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I4
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		EnvironmentKind[] limitedAllowedEnvironmentKinds = _limitedAllowedEnvironmentKinds;
		if (limitedAllowedEnvironmentKinds.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj3 = default;
			object obj4 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj4 != null)
					{
						object obj5 = obj2 + 4;
						object obj6 = obj5 + 1;
						obj5 = obj6;
						object obj7 = obj6 << 2;
						object obj8 = obj2 + obj7;
						obj8 = 67;
						break;
					}
					continue;
				}
				object obj9 = obj2 + 4;
				object obj10 = obj9 + 1;
				obj9 = obj10;
				object obj11 = obj10 << 2;
				object obj12 = obj2 + obj11;
				obj12 = 65;
				break;
			}
			object obj13 = default;
			if (obj13 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj14 = (nint)0 << 2;
				object obj15 = obj2 + obj14;
				if ((nint)obj15 == 67)
				{
					object obj16 = obj2 + 4;
					if ((nint)obj16 > -1)
					{
						object obj17 = obj16 + -1;
						obj16 = obj17;
					}
					return true;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj18 = (nint)0 << 2;
				object obj19 = obj2 + obj18;
				if ((nint)obj19 == 65)
				{
					object obj20 = obj2 + 4;
					if ((nint)obj20 > -1)
					{
						object obj21 = obj20 + -1;
						obj20 = obj21;
					}
					goto IL_03e3;
				}
			}
			object obj22 = default;
			if (obj22 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_03e3;
		}
		return true;
		IL_03e3:
		bool result = default;
		return result;
	}

	public EnvironmentKind GetRandomAllowedEnvironmentKind(SyboRandom random)
	{
		//IL_0093: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		nint num = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v28 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GamePositionRoot instance = GamePositionRoot.Instance;
		IRandomGen randomGen = random._randomGen;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (SYBO.Subway.Level.GamePositionRoot)+8]");
		if (randomGen == null)
		{
		}
		EnvironmentKind[] limitedAllowedEnvironmentKinds = _limitedAllowedEnvironmentKinds;
		if (limitedAllowedEnvironmentKinds.Length != 0)
		{
			bool flag = Enumerable.Contains(_limitedAllowedEnvironmentKinds, (EnvironmentKind)(object)random);
			return (EnvironmentKind)flag;
		}
		return (EnvironmentKind)1;
	}

	public override string ToString()
	{
		return (string)(object)_routeTransitionTrigger;
	}

	public IEnumerator ActivateTrackObjectsASync()
	{
		//IL_0027: Expected Obj, but got I4
		if (_builder != null)
		{
			RouteBuilder builder = _builder;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		}
		else
		{
			object obj = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		UnityEngine.Object obj2 = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
		throw new ArrayTypeMismatchException();
	}

	public IEnumerator DeactivateTrackObjects()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	public unsafe void Build(EnvironmentKind routeDesiredEnvironmentKind, EnvironmentKind previousDesiredEnvironmentKind)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_00a3: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected VT, but got Unknown
		//IL_00f1: Expected F4, but got Obj
		//IL_00ec: Expected native int or pointer, but got VT
		//IL_0106: Expected F4, but got I
		//IL_0101: Expected native int or pointer, but got VT
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected VT, but got Unknown
		//IL_0121: Expected F4, but got Obj
		//IL_011c: Expected native int or pointer, but got VT
		//IL_0136: Expected F4, but got I
		//IL_0131: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 12;
		obj = previousDesiredEnvironmentKind;
		_ = previousDesiredEnvironmentKind._type;
		object obj3 = routeDesiredEnvironmentKind + 60;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v9+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v14 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v26 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 24);
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj2 + 36);
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Quaternion quaternion = Quaternion.FromToRotation(vector, vector2);
	}

	public unsafe void HideLogic(float untilGamePositionZ)
	{
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_028a: Expected Obj, but got I4
		//IL_02b1: Expected Obj, but got I4
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_02f2: Expected Obj, but got I4
		//IL_003e: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_0332: Expected Obj, but got I4
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_0385: Expected Obj, but got I4
		//IL_0394: Expected Obj, but got F4
		//IL_03ae: Expected I, but got Obj
		//IL_03c4: Expected Obj, but got I
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected VT, but got Unknown
		//IL_03fc: Expected F4, but got Obj
		//IL_03f7: Expected native int or pointer, but got VT
		//IL_0411: Expected F4, but got I
		//IL_040c: Expected native int or pointer, but got VT
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected VT, but got Unknown
		//IL_042c: Expected F4, but got Obj
		//IL_0427: Expected native int or pointer, but got VT
		//IL_0441: Expected F4, but got I
		//IL_043c: Expected native int or pointer, but got VT
		//IL_0475: Expected I, but got Obj
		//IL_048b: Expected Obj, but got I
		//IL_007f: Expected I, but got Obj
		//IL_04b4: Expected Obj, but got I4
		//IL_00cc: Expected I, but got Obj
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected Obj, but got Unknown
		//IL_04e9: Expected VT, but got Obj
		//IL_04f2: Expected Obj, but got VT
		//IL_04fe: Expected Obj, but got I4
		//IL_0509: Expected Obj, but got I4
		//IL_0119: Expected I, but got Obj
		//IL_01f3: Expected F4, but got Obj
		//IL_01ee: Expected native int or pointer, but got VT
		//IL_0208: Expected F4, but got I
		//IL_0203: Expected native int or pointer, but got VT
		//IL_021a: Expected I4, but got VT
		//IL_021a: Expected Obj, but got I4
		//IL_021a: Expected Obj, but got I4
		//IL_0225: Expected Obj, but got I4
		//IL_0161: Expected VT, but got Obj
		//IL_016c: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got VT
		//IL_0254: Expected VT, but got Obj
		//IL_0182: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got VT
		//IL_0262: Expected Obj, but got VT
		//IL_01ac: Expected VT, but got Obj
		//IL_01b7: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got VT
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01e1: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		int num = UnityEngine.Random.RandomRangeInt(0, 3);
		object obj3 = num - 1;
		object obj4 = obj3 * 20;
		bool isRepeatableInSections = _isRepeatableInSections;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (System.Boolean)+C]");
		int num2 = UnityEngine.Random.RandomRangeInt(0, 0);
		_0021_00210 eventValue = (_0021_00210)((SpecialPowerBoardEventManager)_isRepeatableInSections).GetEventValue<T>(out *(bool*)num2);
		Action onDeactivate = this.m_OnDeactivate;
		float num3 = PlayerPrefs.GetFloat((string)(object)((Delegate)onDeactivate).data, 1f);
		Action onDeactivate2 = this.m_OnDeactivate;
		nint num4 = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v28 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num5 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v90 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		float num6 = untilGamePositionZ;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v16 (System.Boolean)+10]");
		float num7 = num6 - 0f;
		object obj6 = obj2 + 24;
		obj6 = 0;
		_ = 0;
		obj6 = obj4;
		float num8 = num3 * (float)(nint)((Delegate)onDeactivate2).invoke_impl;
		float num9 = num7 + 20f;
		object obj7 = obj2 + 12;
		obj7 = 0;
		_ = 0;
		obj7 = 0f;
		_ = 10f;
		_ = 0f;
		nint num10 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v47 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num11 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v86 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 48);
		((Vector3*)(nint)vector)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v35+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj2 + 60);
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v41+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = vector - vector2;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		nint num12 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v49 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v77 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)_blockCount).FindKernel(null) != 0)
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			int layer = ((GameObject)_blockCount).layer;
			if (PickupManager.SortSpawnPointsClosestFirst((PickupSpawnPoint)val, (PickupSpawnPoint)layer) != 0)
			{
				_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
				int layer2 = ((GameObject)_blockCount).layer;
				((PickupManager)val2).ResetPickupAndPickerLastPositions((PickupManager.ReasonToResetHistory)layer2);
				object obj10 = this + 32;
				obj10 = 0;
			}
		}
		object obj11 = this + 32;
		_00210 val3 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		bool flag = ((PickupManagerController)val3).IsCharacterNameEventActive();
		obj11 = flag;
		int layer3 = ((GameObject)_blockCount).layer;
		((Vector3*)(nint)vector2)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		HierarchyUtility.Reparent((Transform)layer3, (Transform)2, (byte)(int)vector2 != 0);
		PickupSpawnPoint component = ((GameObject)_blockCount).GetComponent<PickupSpawnPoint>();
		((AssetManager)(object)component).CombineEnvironmentBaseModelsAndStore((EnvironmentBaseInfo)eventValue, (Transform)1, (Transform)null, (Transform)1, 0);
		_00210 val4 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		((PickupManager)val4).Game_OnGameStarted();
		((ReturnToCheckpointState)(object)this)._002Ector(1);
	}

	private void HideLogicRecursive(Transform target, float maxGamePositionZ)
	{
		//IL_005b: Expected Obj, but got I
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0071: Expected Obj, but got F4
		//IL_000d: Expected Obj, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteChunk)+10]");
		AudioSource.PlayOneShotHelper((AudioSource)0, (AudioClip)(object)target, maxGamePositionZ);
		object obj2 = default;
		object obj = obj2 + 4;
		obj = maxGamePositionZ;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text = (string)(object)target + " , " + text2;
		obj2 = maxGamePositionZ;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text3 = default;
		string meshInfos = (string)(object)target + " , " + text3;
		((MeshCombiner)this).Combine((GameObject)(object)"CrossFade", (IList<ObjectModelInfo>)(object)meshInfos);
	}

	public void RestoreHiddenLogic()
	{
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02d0: Expected VT, but got Obj
		//IL_02e0: Expected Obj, but got I4
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		//IL_01ad: Expected VT, but got Obj
		//IL_01bd: Expected Obj, but got I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		if (_limitedAllowedEnvironmentKinds != null)
		{
			nint num = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v62 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v69 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (Enumerable.Contains(_limitedAllowedEnvironmentKinds, EnvironmentKind.Epic))
			{
				float num3 = 360f;
			}
			else
			{
				float num3 = 180f;
			}
		}
		else
		{
			float num3 = 180f;
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 112);
		GameObject gameObject = base.gameObject;
		transform.position = (Vector3)gameObject;
		object obj3 = _blockCount * 90;
		object obj4 = obj2 + 96;
		Color black = Color.black;
		object obj5 = obj2 + 80;
		Color black2 = Color.black;
		object obj6 = obj2 - -64;
		Color black3 = Color.black;
		object obj7 = obj2 + 124;
		obj7 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj8 = obj2 + 136;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v17+8]");
		_ = 0;
		object obj9 = obj2 + 152;
		obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19+8]");
		_ = 0;
		object obj10 = obj2 + 168;
		obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v21+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @80B4");
		Transform transform2 = (Transform)(obj2 + 48);
		GameObject gameObject2 = base.gameObject;
		transform2.position = (Vector3)gameObject2;
		object obj11 = _blockCount * 90;
		object obj12 = obj2 + 32;
		Color blue = Color.blue;
		object obj13 = obj2 + 16;
		Color black4 = Color.black;
		Color green = Color.green;
		obj7 = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		obj8 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v41+8]");
		_ = 0;
		obj9 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v43+8]");
		_ = 0;
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @80B4");
	}

	private unsafe EnvironmentBaseKind GetEnvironmentBaseKindToPlace(EnvironmentKind envKind, EnvironmentKind previousEnvKind, EnvironmentKind routeDesiredEnvironment, EnvironmentBaseKind envBaseKindConstraint, EnvironmentBaseKind nextConstraint, int blockIndex, int envKindEndBlock)
	{
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected Obj, but got Unknown
		//IL_05ef: Expected Obj, but got I4
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected Ref, but got Unknown
		//IL_061a: Expected I, but got Obj
		//IL_0630: Expected Obj, but got I
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Expected VT, but got Unknown
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected VT, but got Unknown
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Expected Obj, but got Unknown
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Expected Obj, but got Unknown
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Expected Obj, but got Unknown
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected VT, but got Unknown
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Expected Obj, but got Unknown
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Expected Obj, but got Unknown
		//IL_0937: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_005c: Expected I4, but got Obj
		//IL_066a: Expected I, but got Obj
		//IL_0680: Expected Obj, but got I
		//IL_06aa: Expected F4, but got Obj
		//IL_06a5: Expected native int or pointer, but got VT
		//IL_06db: Expected F4, but got Obj
		//IL_06d6: Expected native int or pointer, but got VT
		//IL_011e: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_00d1: Expected I, but got Obj
		//IL_0707: Expected F4, but got Obj
		//IL_0702: Expected native int or pointer, but got VT
		//IL_071c: Expected F4, but got I
		//IL_0717: Expected native int or pointer, but got VT
		//IL_0729: Expected native int or pointer, but got VT
		//IL_015f: Expected I, but got Obj
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Expected Obj, but got Unknown
		//IL_07c9: Expected Obj, but got I4
		//IL_0580: Expected Obj, but got I
		//IL_0590: Expected Obj, but got I
		//IL_05a0: Expected VT, but got I
		//IL_05b3: Expected Obj, but got I4
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected Obj, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0226: Expected I4, but got Obj
		//IL_0226: Expected Obj, but got I4
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected Obj, but got Unknown
		//IL_0804: Expected Obj, but got I4
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_0284: Expected F4, but got Obj
		//IL_027f: Expected native int or pointer, but got VT
		//IL_0299: Expected F4, but got I
		//IL_0294: Expected native int or pointer, but got VT
		//IL_02a6: Expected native int or pointer, but got VT
		//IL_02cc: Expected F4, but got Obj
		//IL_02c7: Expected native int or pointer, but got VT
		//IL_02fe: Expected Obj, but got I4
		//IL_031c: Expected Obj, but got I
		//IL_032c: Expected Obj, but got I
		//IL_034a: Expected Obj, but got I
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected Obj, but got Unknown
		//IL_03f1: Expected I, but got Obj
		//IL_0407: Expected Obj, but got I
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected Obj, but got Unknown
		//IL_04a6: Expected I4, but got Obj
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04c0: Expected F4, but got Obj
		//IL_04bb: Expected native int or pointer, but got VT
		//IL_04cd: Expected Obj, but got F4
		//IL_04da: Expected F4, but got Obj
		//IL_04d5: Expected native int or pointer, but got VT
		//IL_04e7: Expected Obj, but got VT
		//IL_082c: Expected F4, but got Obj
		//IL_0827: Expected native int or pointer, but got VT
		//IL_0841: Expected F4, but got I
		//IL_083c: Expected native int or pointer, but got VT
		//IL_084e: Expected F4, but got Obj
		//IL_0849: Expected native int or pointer, but got VT
		//IL_086c: Expected Ref, but got VT
		//IL_0879: Expected native int or pointer, but got VT
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected Obj, but got Unknown
		//IL_0523: Expected I4, but got Obj
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected Obj, but got Unknown
		//IL_053d: Expected F4, but got Obj
		//IL_0538: Expected native int or pointer, but got VT
		//IL_054a: Expected Obj, but got F4
		//IL_0557: Expected F4, but got Obj
		//IL_0552: Expected native int or pointer, but got VT
		//IL_0564: Expected Obj, but got VT
		//IL_0432: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 120;
		obj = 0;
		_ = 0;
		ref int reference = ref *(int*)(obj2 + 112);
		reference = ref *(int*)null;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v170 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 vector = (Vector2)(obj2 + 136);
		Quaternion quaternion = (Quaternion)(obj2 + 16);
		object obj4 = obj2 + 96;
		object obj5 = obj2 + 80;
		object obj6 = obj2 - -64;
		Quaternion quaternion2 = (Quaternion)(obj2 + 48);
		object obj7 = obj2 + 32;
		object obj8 = obj2 + 8;
		UnityEngine.Object obj9 = default;
		bool flag = obj9 != null;
		bool flag2 = !flag;
		bool flag3 = !flag2;
		EnvironmentBaseKind result = (EnvironmentBaseKind)obj9;
		if (!flag3)
		{
			int[] indices = ((Mesh)obj9).GetIndices((int)this);
			Vector3[] normals = ((Mesh)obj9).normals;
			Vector4[] tangents = ((Mesh)obj9).tangents;
			bool flag4 = tangents != null && tangents.Length != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6D4");
			nint num3 = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v48 (Il2CppClass<UnityEngine.Vector4>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num4 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v162 (Il2CppClass<UnityEngine.Vector4>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector2*)(nint)vector)->x = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v23+8]");
			_ = 0;
			Vector4 vector2 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6D4");
			((Vector2*)(nint)vector)->x = (float)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27+8]");
			_ = 0;
			Vector4 vector3 = vector;
			nint num5 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v60 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num6 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v158 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Quaternion*)(nint)quaternion)->x = (float)obj5;
			Quaternion quaternion3 = quaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v25+8]");
			((Quaternion*)(nint)quaternion3)->z = 0f;
			((Vector2*)(nint)vector)->x = quaternion2.x;
			_ = quaternion2.z;
			Quaternion quaternion4 = quaternion * (Quaternion)vector;
			obj = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v31+8]");
			_ = 0;
			Vector2[] uv = ((Mesh)obj9).uv2;
			bool flag5 = uv != null && uv.Length != 0;
			Vector2[] uv2 = ((Mesh)obj9).uv3;
			bool flag6 = uv2 != null && uv2.Length != 0;
			object obj12 = indices + 12;
			object obj13 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
			{
				object obj14 = indices + 16;
				object obj15 = obj13 << 2;
				object obj16 = obj14 + obj15;
				if (!((Dictionary<int, int>)envKindEndBlock).TryGetValue((int)obj16, out reference))
				{
					object obj17 = normals + 16;
					object obj18 = obj16 * 12;
					object obj19 = obj17 + obj18;
					((Quaternion*)(nint)quaternion)->x = (float)obj19;
					Quaternion quaternion5 = quaternion;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S1_v73+8]");
					((Quaternion*)(nint)quaternion5)->z = 0f;
					((Vector2*)(nint)vector)->x = quaternion.x;
					_ = quaternion.z;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DF");
					((Vector2*)(nint)vector)->x = (float)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v23+8]");
					_ = 0;
					((List<Vector3>)(object)previousEnvKind).Add((Vector3)vector);
					object obj20 = previousEnvKind._density - 1;
					reference = ref *(int*)obj20;
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S4_v9 (Il2CppMethodInfo)+C]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S4_v10+60]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S4_v11+48]");
					nint num8 = 0;
					object obj23 = num8 & 0x7FF;
					object obj24 = obj23 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v270 @ S5_v5 (should have been resolved before IL gen)");
					if (flag4)
					{
						object obj25 = tangents + 16;
						object obj26 = obj16 * 12;
						object obj27 = obj25 + obj26;
						obj4 = obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ S1_v113+8]");
						_ = 0;
						obj5 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						_ = 0;
						obj6 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v23+8]");
						_ = 0;
						nint num9 = (nint)typeof(Quaternion);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S0_v132 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
						object obj28 = (nint)0 & (nint)0x200;
						if (obj28 != null)
						{
							nint num10 = (nint)typeof(Quaternion);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ S0_v146 (Il2CppClass<UnityEngine.Quaternion>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Quaternion*)(nint)quaternion)->x = (float)obj5;
						Quaternion quaternion6 = quaternion;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v25+8]");
						((Quaternion*)(nint)quaternion6)->z = 0f;
						((Vector2*)(nint)vector)->x = (float)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27+8]");
						_ = 0;
						((Quaternion*)quaternion2)->SetLookRotation((Vector3)quaternion, vector);
						((Vector2*)(nint)vector)->x = quaternion2.x;
						_ = quaternion2.z;
						((List<Vector3>)(object)routeDesiredEnvironment).Add((Vector3)vector);
					}
					if (flag5)
					{
						object obj29 = uv + 16;
						int num11 = obj16 << 3;
						object obj30 = obj29 + num11;
						((Quaternion*)(nint)quaternion)->x = (float)obj30;
						obj8 = quaternion.x;
						((Vector2*)(nint)vector)->x = (float)obj8;
						((List<Vector2>)envBaseKindConstraint).Add(vector);
					}
					if (flag6)
					{
						object obj31 = uv2 + 16;
						int num12 = obj16 << 3;
						object obj32 = obj31 + num12;
						((Quaternion*)(nint)quaternion)->x = (float)obj32;
						obj2 = quaternion.x;
						((Vector2*)(nint)vector)->x = (float)obj2;
						((List<Vector2>)nextConstraint).Add(vector);
					}
				}
				object obj33 = indices + 16;
				object obj34 = obj13 << 2;
				object obj35 = obj33 + obj34;
				obj35 = reference;
				object obj36 = obj13 + 1;
				obj13 = obj36;
			}
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S3_v7 (Il2CppMethodInfo)+C]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S3_v8+60]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S3_v9+38]");
			EnvironmentBaseKind environmentBaseKind = (EnvironmentBaseKind)0;
			object obj39 = environmentBaseKind.Type & (EnvironmentBaseType)0x1FFF;
			object obj40 = obj39 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v108 @ S4_v6 (should have been resolved before IL gen)");
			result = environmentBaseKind;
		}
		return result;
	}

	private unsafe EnvironmentBaseKind GetStartEnvironmentBase(int numTracks)
	{
		//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca6: Expected I4, but got Unknown
		//IL_0caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Expected I4, but got Unknown
		//IL_0cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc2: Expected Obj, but got Unknown
		//IL_0ccb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd0: Expected VT, but got Unknown
		//IL_0cd9: Expected native int or pointer, but got VT
		//IL_0ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cec: Expected Obj, but got Unknown
		//IL_0cf5: Expected Obj, but got I4
		//IL_0d04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d09: Expected Obj, but got Unknown
		//IL_0d12: Expected Obj, but got I4
		//IL_0d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d26: Expected Obj, but got Unknown
		//IL_0d2f: Expected Obj, but got I4
		//IL_0d3e: Expected Obj, but got VT
		//IL_0d47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4c: Expected Obj, but got Unknown
		//IL_002e: Expected I, but got Obj
		//IL_0044: Expected Obj, but got I
		//IL_0d89: Expected native int or pointer, but got VT
		//IL_0d9c: Expected I, but got Obj
		//IL_0db2: Expected Obj, but got I
		//IL_0dcf: Expected I, but got Obj
		//IL_0df3: Expected Obj, but got I
		//IL_0e00: Expected I4, but got Obj
		//IL_0e1a: Expected Obj, but got I4
		//IL_006f: Expected I, but got Obj
		//IL_00bc: Expected I, but got Obj
		//IL_00ec: Expected I, but got Obj
		//IL_0125: Expected Obj, but got VT
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0144: Expected I4, but got Obj
		//IL_015e: Expected Obj, but got I4
		//IL_0112: Expected I, but got Obj
		//IL_0182: Expected Obj, but got VT
		//IL_01af: Expected I4, but got VT
		//IL_0e83: Expected VT, but got I4
		//IL_0e93: Expected I4, but got Obj
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_0989: Expected I, but got Obj
		//IL_099f: Expected Obj, but got I
		//IL_06dc: Expected Obj, but got VT
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected Obj, but got Unknown
		//IL_06fb: Expected I4, but got Obj
		//IL_0715: Expected Obj, but got I4
		//IL_13e1: Expected Obj, but got I
		//IL_0965: Expected Obj, but got VT
		//IL_12ea: Expected Obj, but got I
		//IL_12f8: Expected I, but got Obj
		//IL_130e: Expected Obj, but got I
		//IL_132b: Expected I, but got Obj
		//IL_0221: Expected I, but got Obj
		//IL_0a43: Expected I, but got Obj
		//IL_0a59: Expected Obj, but got I
		//IL_09ca: Expected I, but got Obj
		//IL_1418: Expected Obj, but got I
		//IL_1637: Expected Obj, but got VT
		//IL_1651: Expected I4, but got Obj
		//IL_1668: Expected I4, but got Obj
		//IL_1682: Expected Obj, but got I4
		//IL_0765: Expected I4, but got Obj
		//IL_077f: Expected I4, but got Obj
		//IL_07b2: Expected I4, but got Obj
		//IL_07b2: Expected I4, but got Obj
		//IL_07b2: Expected Obj, but got VT
		//IL_07e2: Expected I4, but got Obj
		//IL_0eec: Expected Obj, but got I4
		//IL_0ef9: Expected Obj, but got VT
		//IL_0275: Invalid comparison between VT and I
		//IL_0a1f: Expected Obj, but got I
		//IL_0b14: Expected I, but got Obj
		//IL_0b2a: Expected Obj, but got I
		//IL_1356: Expected Obj, but got I
		//IL_1364: Expected I, but got Obj
		//IL_137a: Expected Obj, but got I
		//IL_1397: Expected I, but got Obj
		//IL_07fd: Expected I, but got Obj
		//IL_082d: Expected I, but got Obj
		//IL_0f3b: Expected I, but got Obj
		//IL_0f51: Expected Obj, but got I
		//IL_0a84: Expected I, but got Obj
		//IL_145f: Expected Obj, but got I
		//IL_0ad0: Expected Obj, but got VT
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Expected I, but got Unknown
		//IL_0af0: Expected I4, but got VT
		//IL_16b8: Expected Obj, but got VT
		//IL_16d2: Expected I4, but got Obj
		//IL_16e9: Expected I4, but got Obj
		//IL_1703: Expected Obj, but got I4
		//IL_02a4: Expected Obj, but got I
		//IL_0bee: Expected I, but got Obj
		//IL_0c04: Expected Obj, but got I
		//IL_0c21: Expected I, but got Obj
		//IL_0b55: Expected I, but got Obj
		//IL_149a: Expected Obj, but got I4
		//IL_14af: Expected I4, but got Obj
		//IL_14b7: Expected Obj, but got I4
		//IL_0880: Expected I, but got Obj
		//IL_08b0: Expected I, but got Obj
		//IL_0853: Expected I, but got Obj
		//IL_02bf: Expected I, but got Obj
		//IL_14e2: Expected I4, but got VT
		//IL_0baa: Expected Obj, but got I
		//IL_0bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbc: Expected I, but got Unknown
		//IL_0bca: Expected I4, but got VT
		//IL_13b2: Expected Obj, but got I4
		//IL_13c2: Expected VT, but got I4
		//IL_08e8: Expected I4, but got Obj
		//IL_0902: Expected I4, but got Obj
		//IL_0928: Expected Obj, but got I4
		//IL_0928: Expected Obj, but got VT
		//IL_0935: Expected I, but got Obj
		//IL_0c3d: Expected I, but got Obj
		//IL_0c6d: Expected I, but got Obj
		//IL_08d6: Expected I, but got Obj
		//IL_0c93: Expected I, but got Obj
		//IL_0fde: Expected Obj, but got I4
		//IL_0fec: Expected I, but got Obj
		//IL_1002: Expected Obj, but got I
		//IL_035f: Invalid comparison between VT and I
		//IL_0386: Expected I, but got Obj
		//IL_102d: Expected VT, but got I4
		//IL_103b: Expected I, but got Obj
		//IL_1051: Expected Obj, but got I
		//IL_03da: Invalid comparison between I and VT
		//IL_0401: Expected I, but got Obj
		//IL_107c: Expected Obj, but got I4
		//IL_0455: Invalid comparison between I and VT
		//IL_15eb: Expected I, but got Obj
		//IL_1601: Expected Obj, but got I
		//IL_10b6: Expected Obj, but got I4
		//IL_10be: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c3: Expected Obj, but got Unknown
		//IL_10d0: Expected I4, but got Obj
		//IL_0477: Expected native int or pointer, but got VT
		//IL_048f: Expected I, but got Obj
		//IL_111b: Expected Obj, but got I4
		//IL_04e3: Invalid comparison between VT and I
		//IL_0644: Expected Obj, but got I4
		//IL_120d: Expected I4, but got VT
		//IL_121d: Expected I4, but got Obj
		//IL_1225: Expected I4, but got Obj
		//IL_050a: Expected I, but got Obj
		//IL_0520: Expected Obj, but got I
		//IL_0657: Expected Obj, but got VT
		//IL_0669: Expected I, but got Obj
		//IL_067f: Expected Obj, but got I
		//IL_054b: Expected I, but got Obj
		//IL_1241: Expected Obj, but got I4
		//IL_1256: Unknown result type (might be due to invalid IL or missing references)
		//IL_125b: Expected Obj, but got Unknown
		//IL_126b: Expected Obj, but got I
		//IL_127b: Expected Obj, but got I
		//IL_1295: Expected I4, but got VT
		//IL_12ab: Expected I4, but got Obj
		//IL_12b3: Expected I4, but got Obj
		//IL_1180: Expected Obj, but got I4
		//IL_0582: Invalid comparison between VT and I4
		//IL_06aa: Expected I, but got Obj
		//IL_05a9: Expected I, but got Obj
		//IL_05bf: Expected Obj, but got I
		//IL_11c7: Expected I4, but got Obj
		//IL_11c7: Expected Obj, but got I4
		//IL_11c7: Expected Obj, but got VT
		//IL_11e4: Expected I4, but got Obj
		//IL_11e4: Expected Obj, but got VT
		//IL_0631: Expected I, but got VT
		//IL_05ea: Expected I, but got Obj
		object obj = default;
		int num = obj + 76;
		bool flag = (byte)(obj - -64) != 0;
		EnvironmentInfo environmentInfo = (EnvironmentInfo)(obj + 12);
		Vector3 vector = (Vector3)(obj + 60);
		((Vector3*)(nint)vector)->x = 0f;
		object obj2 = obj + 48;
		obj2 = 0;
		_ = 0;
		object obj3 = obj + 36;
		obj3 = 0;
		_ = 0;
		object obj4 = obj + 24;
		obj4 = 0;
		_ = 0;
		EnvironmentBaseKind environmentBaseKind = default;
		((RouteChunk)environmentBaseKind).EvaluateEnvironmentConstraints();
		object obj5 = environmentBaseKind - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+24]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+25]");
			if ((nint)0 == 0)
			{
				goto IL_0d6c;
			}
		}
		nint num2 = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v36 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v360 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GamePositionRoot instance = GamePositionRoot.Instance;
		((Vector3*)(nint)vector)->x = 0f;
		nint num4 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v44 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		bool flag2 = obj7 == null;
		nint num5 = (nint)typeof(EnvironmentBaseKind);
		if (!flag2)
		{
			nint num6 = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v354 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
			bool flag3 = (nint)0 == 0;
			bool flag4 = !flag3;
			num5 = (nint)typeof(EnvironmentBaseKind);
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num5 = (nint)typeof(EnvironmentBaseKind);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ L3_v5 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj8 = (nint)0 + (nint)132;
		((int*)num)->m_value = (int)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v28+8]");
		_ = 0;
		obj2 = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+20]");
		Route route = default;
		if ((nint)0 >= (nint)2)
		{
			ChunkBlockConstraint nextEnvironmentConstraint = ((RouteChunk)environmentBaseKind).GetNextEnvironmentConstraint(1);
			object obj9 = nextEnvironmentConstraint + 12;
			((int*)num)->m_value = (int)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S1_v261+8]");
			_ = 0;
			obj2 = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
			_ = 0;
			route = null;
		}
		int num7 = numTracks;
		int num8 = -1;
		RouteChunk routeChunk = this;
		GamePositionRoot gamePositionRoot = instance;
		int num9 = 0;
		int num11 = default;
		RouteType routeType = default;
		Vector3 vector2 = default;
		ChunkBuildMode chunkBuildMode = default;
		nint num29 = default;
		object obj28 = default;
		while (true)
		{
			int num10 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+20]");
			if ((nint)num10 >= (nint)0)
			{
				break;
			}
			ChunkBlockConstraint nextEnvironmentConstraint2 = ((RouteChunk)environmentBaseKind).GetNextEnvironmentConstraint(num11);
			bool flag5 = num9 == num11;
			bool flag6 = !flag5;
			int num12 = (int)routeType;
			int num13 = (int)vector2;
			int num14 = (int)chunkBuildMode;
			if (flag6)
			{
				goto IL_0e5a;
			}
			EnvironmentKind environmentKind = nextEnvironmentConstraint2.EnvironmentKind;
			nint num15 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v194 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num16 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S0_v346 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GamePositionRoot instance2 = GamePositionRoot.Instance;
			IntPtr cachedPtr = ((UnityEngine.Object)(object)environmentKind).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v199 (SYBO.Subway.Level.GamePositionRoot)+8]");
			bool flag7;
			if (cachedPtr == (IntPtr)0)
			{
				Vector3 logicHideOffset = ((RouteChunk)(object)environmentKind).LogicHideOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v199 (SYBO.Subway.Level.GamePositionRoot)+C]");
				flag7 = logicHideOffset == (Vector3)(object)0;
			}
			else
			{
				flag7 = false;
			}
			object obj11 = (flag7 ? 1 : 0) ^ 1;
			ChunkBlockConstraint environmentConstraintFromIndex = ((RouteChunk)environmentBaseKind).GetEnvironmentConstraintFromIndex(num11);
			bool flag8 = (nint)environmentConstraintFromIndex == -1;
			bool flag9 = !flag8;
			ChunkBlockConstraint chunkBlockConstraint = environmentConstraintFromIndex;
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+20]");
				ChunkBlockConstraint chunkBlockConstraint2 = (ChunkBlockConstraint)(-1);
				chunkBlockConstraint = chunkBlockConstraint2;
			}
			nint num17 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ S1_v188 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num18 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ S1_v250 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			RouteChunk routeChunk2;
			if (obj11 != null)
			{
				routeChunk = (RouteChunk)(object)environmentKind;
				routeChunk2 = (RouteChunk)(object)environmentKind;
			}
			else
			{
				routeChunk = this;
				routeChunk2 = this;
			}
			bool flag10 = ((UnityEngine.Object)routeChunk2).m_CachedPtr == ((UnityEngine.Object)this).m_CachedPtr && routeChunk2.LogicHideOffset == LogicHideOffset;
			IntPtr cachedPtr2 = ((UnityEngine.Object)routeChunk).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ L7_v3 (SYBO.Subway.Level.GamePositionRoot)+8]");
			bool flag11;
			if (cachedPtr2 == (IntPtr)0)
			{
				Vector3 logicHideOffset2 = routeChunk.LogicHideOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ L7_v3 (SYBO.Subway.Level.GamePositionRoot)+C]");
				flag11 = logicHideOffset2 == (Vector3)(object)0;
			}
			else
			{
				flag11 = false;
			}
			object obj13 = (flag11 ? 1 : 0) ^ 1;
			nint num19 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ S0_v215 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num20 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ S0_v328 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ L4_v3 (System.Int32)+8]");
			bool flag12;
			if ((IntPtr)0 == ((UnityEngine.Object)routeChunk).m_CachedPtr)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ L4_v3 (System.Int32)+C]");
				flag12 = (object)0 == (object)routeChunk.LogicHideOffset;
			}
			else
			{
				flag12 = false;
			}
			Vector3 vector3 = (Vector3)((flag12 ? 1 : 0) ^ 1);
			nint num21 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ S0_v225 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num22 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ S0_v320 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ L4_v3 (System.Int32)+8]");
			bool flag13;
			if ((IntPtr)0 == ((UnityEngine.Object)routeChunk).m_CachedPtr)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ L4_v3 (System.Int32)+C]");
				flag13 = (object)0 == (object)routeChunk.LogicHideOffset;
			}
			else
			{
				flag13 = false;
			}
			object obj16 = (flag13 ? 1 : 0) ^ 1;
			if (obj16 != null)
			{
				((Vector3*)(nint)vector)->x = 0f;
			}
			nint num23 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ S0_v236 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num24 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ S0_v311 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag14 = num11 > 0;
			object obj18 = (flag10 ? 1 : 0) ^ 1;
			object obj19 = flag14 & obj18;
			RouteType routeType2 = (RouteType)(obj19 & obj13);
			GamePositionRoot instance3 = GamePositionRoot.Instance;
			IntPtr cachedPtr3 = ((UnityEngine.Object)routeChunk).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ S0_v245 (SYBO.Subway.Level.GamePositionRoot)+8]");
			bool flag15;
			if (cachedPtr3 == (IntPtr)0)
			{
				Vector3 logicHideOffset3 = routeChunk.LogicHideOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ S0_v245 (SYBO.Subway.Level.GamePositionRoot)+C]");
				flag15 = logicHideOffset3 == (Vector3)(object)0;
			}
			else
			{
				flag15 = false;
			}
			object obj20 = (flag15 ? 1 : 0) ^ 1;
			Route route2;
			if (obj20 != null)
			{
				nint num25 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v278 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
				object obj21 = (nint)0 & (nint)0x200;
				if (obj21 != null)
				{
					nint num26 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v883 @ S0_v302 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				EnvironmentKind empty = EnvironmentKind.Empty;
				bool flag16 = ((UnityEngine.Object)routeChunk).m_CachedPtr == (IntPtr)(nint)empty._type && routeChunk.LogicHideOffset == (Vector3)(object)empty._density;
				object obj22 = (flag16 ? 1 : 0) ^ 1;
				if (obj22 != null)
				{
					nint num27 = (nint)typeof(EnvironmentInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ S0_v289 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+BA]");
					object obj23 = (nint)0 & (nint)0x200;
					if (obj23 != null)
					{
						nint num28 = (nint)typeof(EnvironmentInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ S0_v295 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					EnvironmentType type = ((EnvironmentKind)(object)routeChunk).Type;
					route = ((RouteManager)environmentBaseKind).CreateRoute((Route)num11, (SectionSpawnMode)chunkBlockConstraint, (ChunkBuildMode)type, vector3, routeType2);
					route2 = ((RouteManager)environmentBaseKind).CreateRoute((RouteType)num11, (SectionSpawnMode)type, (ChunkBuildMode)route, vector);
					routeType = routeType2;
					vector2 = vector3;
					chunkBuildMode = (ChunkBuildMode)type;
					num29 = (nint)vector;
					goto IL_11ed;
				}
			}
			route2 = (Route)(num11 + 1);
			route = null;
			goto IL_11ed;
			IL_11ed:
			bool flag17 = OnEnvironmentSegmentSpawned == null;
			num12 = (int)routeType;
			num13 = (int)vector2;
			num14 = (int)chunkBuildMode;
			num8 = (int)chunkBlockConstraint;
			num9 = (int)route2;
			if (!flag17)
			{
				float timeInDefaultRoute = ((RouteManager)environmentBaseKind).TimeInDefaultRoute;
				nint num30 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ S0_v260 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				if (obj24 != null)
				{
					nint num31 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ S0_v271 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj25 = num11 * 90;
				int num32 = Mathf.RoundToInt(timeInDefaultRoute);
				object obj26 = obj25 + num32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+74]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v962 @ S3_v17+44]");
				route = (Route)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8967");
				num12 = (int)routeType;
				num13 = (int)vector2;
				num14 = (int)chunkBuildMode;
				num29 = 0;
				num8 = (int)chunkBlockConstraint;
				num9 = (int)route2;
			}
			goto IL_0e5a;
			IL_0e5a:
			bool flag18 = (nint)obj28 == num11;
			bool flag19 = !flag18;
			routeType = (RouteType)num12;
			vector2 = (Vector3)num13;
			chunkBuildMode = (ChunkBuildMode)num14;
			bool flag20 = (byte)(int)route != 0;
			if (!flag19)
			{
				ChunkBlockConstraint nextEnvironmentConstraint3 = ((RouteChunk)environmentBaseKind).GetNextEnvironmentConstraint(num11);
				object obj29 = nextEnvironmentConstraint3 + 12;
				((int*)num)->m_value = (int)obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S1_v98+8]");
				_ = 0;
				obj3 = ((int*)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+25]");
				bool flag21 = (nint)0 == 0;
				bool flag22 = (byte)num29 != 0;
				flag20 = false;
				if (!flag21)
				{
					((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj3 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+8]");
					_ = 0;
					((int*)num)->m_value = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+8]");
					_ = 0;
					environmentInfo._002Ector((EnvironmentKind)environmentBaseKind, (byte)(int)routeChunk != 0, (byte)num7 != 0, (byte)(int)this != 0, flag, num, num11, num8);
					obj3 = environmentInfo;
					_ = environmentInfo.Kind;
					num12 = num8;
					num13 = num11;
					num14 = num;
					flag22 = (byte)(int)this != 0;
					flag20 = (byte)num7 != 0;
				}
				obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+8]");
				_ = 0;
				environmentInfo = (EnvironmentInfo)obj2;
				EnvironmentInfo environmentInfo2 = environmentInfo;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+8]");
				environmentInfo2.Kind = (EnvironmentKind)0;
				nint num33 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S0_v133 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
				object obj30 = (nint)0 & (nint)0x200;
				bool flag23 = obj30 == null;
				nint num34 = (nint)typeof(EnvironmentBaseKind);
				if (!flag23)
				{
					nint num35 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S0_v178 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
					bool flag24 = (nint)0 == 0;
					bool flag25 = !flag24;
					num34 = (nint)typeof(EnvironmentBaseKind);
					if (!flag25)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num34 = (nint)typeof(EnvironmentBaseKind);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ L4_v18 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
				nint num36 = 0;
				obj = EnvironmentBaseKind.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S1_v117 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
				_ = 0;
				((bool*)(flag ? 1 : 0))->m_value = (byte)(int)environmentInfo != 0;
				_ = environmentInfo.Kind;
				((int*)num)->m_value = (int)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				if ((flag ? ((EnvironmentBaseKind*)1) : ((EnvironmentBaseKind*)null))->Equals(num))
				{
					obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+8]");
					_ = 0;
				}
				environmentInfo = (EnvironmentInfo)obj3;
				EnvironmentInfo environmentInfo3 = environmentInfo;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+8]");
				environmentInfo3.Kind = (EnvironmentKind)0;
				nint num37 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ S0_v149 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
				object obj31 = (nint)0 & (nint)0x200;
				bool flag26 = obj31 == null;
				nint num38 = (nint)typeof(EnvironmentBaseKind);
				if (!flag26)
				{
					nint num39 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ S0_v170 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
					bool flag27 = (nint)0 == 0;
					bool flag28 = !flag27;
					num38 = (nint)typeof(EnvironmentBaseKind);
					if (!flag28)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num38 = (nint)typeof(EnvironmentBaseKind);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ L4_v21 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
				nint num40 = 0;
				obj = EnvironmentBaseKind.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ S1_v137 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
				_ = 0;
				((bool*)(flag ? 1 : 0))->m_value = (byte)(int)environmentInfo != 0;
				_ = environmentInfo.Kind;
				((int*)num)->m_value = (int)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				int num41;
				if ((flag ? ((EnvironmentBaseKind*)1) : ((EnvironmentBaseKind*)null))->Equals(num))
				{
					((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj3 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+8]");
					_ = 0;
					((int*)num)->m_value = (int)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+8]");
					_ = 0;
					num41 = ((RouteChunk)environmentBaseKind).CreateEnvironmentSegment(num11, (EnvironmentInfo)flag, (EnvironmentSequence)num, ref *(int*)routeChunk);
					num29 = (nint)routeChunk;
					flag20 = (byte)num != 0;
				}
				else
				{
					num29 = (flag22 ? 1 : 0);
					num41 = 1;
				}
				obj28 = num41 + num11;
				routeType = (RouteType)num12;
				vector2 = (Vector3)num13;
				chunkBuildMode = (ChunkBuildMode)num14;
			}
			num11++;
			int num42 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+20]");
			GamePositionRoot gamePositionRoot2;
			if ((nint)num42 < (nint)0)
			{
				ChunkBlockConstraint nextEnvironmentConstraint4 = ((RouteChunk)environmentBaseKind).GetNextEnvironmentConstraint(num9);
				gamePositionRoot2 = (GamePositionRoot)(object)nextEnvironmentConstraint4.EnvironmentKind;
			}
			else
			{
				nint num43 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S1_v84 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj32 = (nint)0 & (nint)0x200;
				if (obj32 != null)
				{
					nint num44 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ S1_v91 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+4C]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+4C]");
					ChunkBlockConstraint nextEnvironmentConstraint5 = ((RouteChunk)0).GetNextEnvironmentConstraint(0);
					gamePositionRoot2 = (GamePositionRoot)(object)nextEnvironmentConstraint5.EnvironmentKind;
				}
				else
				{
					nint num45 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ S0_v104 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
					object obj33 = (nint)0 & (nint)0x200;
					if (obj33 != null)
					{
						nint num46 = (nint)typeof(EnvironmentKind);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ S0_v110 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					gamePositionRoot2 = GamePositionRoot.Instance;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+20]");
			object obj34 = -1;
			if (num11 < (nint)obj34)
			{
				ChunkBlockConstraint nextEnvironmentConstraint6 = ((RouteChunk)environmentBaseKind).GetNextEnvironmentConstraint(num11);
				nint num47 = (nint)(nextEnvironmentConstraint6 + 12);
				((int*)num)->m_value = (int)EnvironmentBaseKind.None;
				IntPtr intPtr = num47;
				flag20 = false;
			}
			else
			{
				nint num48 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ S1_v61 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj35 = (nint)0 & (nint)0x200;
				if (obj35 != null)
				{
					nint num49 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ S1_v75 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+4C]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+4C]");
					ChunkBlockConstraint nextEnvironmentConstraint7 = ((RouteChunk)0).GetNextEnvironmentConstraint(0);
					nint num50 = (nint)(nextEnvironmentConstraint7 + 12);
					((int*)num)->m_value = (int)EnvironmentBaseKind.None;
					IntPtr intPtr = num50;
					flag20 = false;
				}
				else
				{
					nint num51 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ S0_v87 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
					object obj36 = (nint)0 & (nint)0x200;
					bool flag29 = obj36 == null;
					nint num52 = (nint)typeof(EnvironmentBaseKind);
					if (!flag29)
					{
						nint num53 = (nint)typeof(EnvironmentBaseKind);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ S0_v92 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
						bool flag30 = (nint)0 == 0;
						bool flag31 = !flag30;
						num52 = (nint)typeof(EnvironmentBaseKind);
						if (!flag31)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							num52 = (nint)typeof(EnvironmentBaseKind);
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ L4_v10 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
					nint num54 = 0;
					((int*)num)->m_value = (int)EnvironmentBaseKind.None;
					IntPtr intPtr = num54;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ L4_v6 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
			_ = 0;
			obj2 = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+8]");
			_ = 0;
			num7 = (int)routeChunk;
			route = (Route)flag20;
			gamePositionRoot = gamePositionRoot2;
		}
		goto IL_0d6c;
		IL_0d6c:
		_ = 1;
		return environmentBaseKind;
	}

	private unsafe EnvironmentBaseKind GetEndEnvironmentBase(int numTracks)
	{
		//IL_00cb: Expected I, but got Obj
		//IL_00e1: Expected Obj, but got I
		//IL_01c4: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0046: Expected I, but got Obj
		//IL_02f3: Expected Obj, but got I
		//IL_0300: Expected I4, but got Obj
		//IL_02fb: Expected native int or pointer, but got VT
		//IL_0310: Expected native int or pointer, but got VT
		//IL_0134: Expected I, but got Obj
		//IL_0279: Expected Obj, but got I
		//IL_0286: Expected I4, but got Obj
		//IL_0281: Expected native int or pointer, but got VT
		//IL_0296: Expected native int or pointer, but got VT
		//IL_01e0: Expected I, but got Obj
		//IL_0210: Expected I, but got Obj
		//IL_02b6: Expected Obj, but got I
		//IL_02c3: Expected I4, but got Obj
		//IL_02be: Expected native int or pointer, but got VT
		//IL_02d3: Expected native int or pointer, but got VT
		//IL_0062: Expected I, but got Obj
		//IL_0092: Expected I, but got Obj
		//IL_0150: Expected I, but got Obj
		//IL_0180: Expected I, but got Obj
		//IL_0236: Expected I, but got Obj
		//IL_00b8: Expected I, but got Obj
		//IL_01a6: Expected I, but got Obj
		EnvironmentBaseKind environmentBaseKind = default;
		if (numTracks == 1)
		{
			nint num = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v36 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			bool flag = obj == null;
			nint num2 = (nint)typeof(EnvironmentBaseKind);
			if (!flag)
			{
				nint num3 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v42 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num2 = (nint)typeof(EnvironmentBaseKind);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num2 = (nint)typeof(EnvironmentBaseKind);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ L1_v10 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
			object obj2 = (nint)0 + (nint)48;
			((EnvironmentBaseKind*)(nint)environmentBaseKind)->Type = (EnvironmentBaseType)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v22+8]");
			((EnvironmentBaseKind*)(nint)environmentBaseKind)->NumTracks = 0;
		}
		else
		{
			nint num4 = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v9 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag4 = obj3 != null;
			if (numTracks == 2)
			{
				bool flag5 = !flag4;
				nint num5 = (nint)typeof(EnvironmentBaseKind);
				if (!flag5)
				{
					nint num6 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v29 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
					bool flag6 = (nint)0 == 0;
					bool flag7 = !flag6;
					num5 = (nint)typeof(EnvironmentBaseKind);
					if (!flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num5 = (nint)typeof(EnvironmentBaseKind);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ L1_v6 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
				object obj4 = (nint)0 + (nint)96;
				((EnvironmentBaseKind*)(nint)environmentBaseKind)->Type = (EnvironmentBaseType)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v15+8]");
				((EnvironmentBaseKind*)(nint)environmentBaseKind)->NumTracks = 0;
			}
			else
			{
				bool flag8 = !flag4;
				nint num7 = (nint)typeof(EnvironmentBaseKind);
				if (!flag8)
				{
					nint num8 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v19 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
					bool flag9 = (nint)0 == 0;
					bool flag10 = !flag9;
					num7 = (nint)typeof(EnvironmentBaseKind);
					if (!flag10)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num7 = (nint)typeof(EnvironmentBaseKind);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ L1_v3 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
				object obj5 = (nint)0 + (nint)144;
				((EnvironmentBaseKind*)(nint)environmentBaseKind)->Type = (EnvironmentBaseType)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v9+8]");
				((EnvironmentBaseKind*)(nint)environmentBaseKind)->NumTracks = 0;
			}
		}
		return environmentBaseKind;
	}

	private unsafe EnvironmentBaseKind GetDefaultEnvironmentBaseKind(RouteType routeType)
	{
		//IL_00cb: Expected I, but got Obj
		//IL_00e1: Expected Obj, but got I
		//IL_01c4: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0046: Expected I, but got Obj
		//IL_02f3: Expected Obj, but got I
		//IL_0300: Expected I4, but got Obj
		//IL_02fb: Expected native int or pointer, but got VT
		//IL_0310: Expected native int or pointer, but got VT
		//IL_0134: Expected I, but got Obj
		//IL_0279: Expected Obj, but got I
		//IL_0286: Expected I4, but got Obj
		//IL_0281: Expected native int or pointer, but got VT
		//IL_0296: Expected native int or pointer, but got VT
		//IL_01e0: Expected I, but got Obj
		//IL_0210: Expected I, but got Obj
		//IL_02b6: Expected Obj, but got I
		//IL_02c3: Expected I4, but got Obj
		//IL_02be: Expected native int or pointer, but got VT
		//IL_02d3: Expected native int or pointer, but got VT
		//IL_0062: Expected I, but got Obj
		//IL_0092: Expected I, but got Obj
		//IL_0150: Expected I, but got Obj
		//IL_0180: Expected I, but got Obj
		//IL_0236: Expected I, but got Obj
		//IL_00b8: Expected I, but got Obj
		//IL_01a6: Expected I, but got Obj
		EnvironmentBaseKind environmentBaseKind = default;
		if (routeType == RouteType.Default)
		{
			nint num = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v36 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			bool flag = obj == null;
			nint num2 = (nint)typeof(EnvironmentBaseKind);
			if (!flag)
			{
				nint num3 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v42 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num2 = (nint)typeof(EnvironmentBaseKind);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num2 = (nint)typeof(EnvironmentBaseKind);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ L1_v10 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
			object obj2 = (nint)0 + (nint)72;
			((EnvironmentBaseKind*)(nint)environmentBaseKind)->Type = (EnvironmentBaseType)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v22+8]");
			((EnvironmentBaseKind*)(nint)environmentBaseKind)->NumTracks = 0;
		}
		else
		{
			nint num4 = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v9 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag4 = obj3 != null;
			if (routeType == (RouteType)2)
			{
				bool flag5 = !flag4;
				nint num5 = (nint)typeof(EnvironmentBaseKind);
				if (!flag5)
				{
					nint num6 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v29 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
					bool flag6 = (nint)0 == 0;
					bool flag7 = !flag6;
					num5 = (nint)typeof(EnvironmentBaseKind);
					if (!flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num5 = (nint)typeof(EnvironmentBaseKind);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ L1_v6 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
				object obj4 = (nint)0 + (nint)120;
				((EnvironmentBaseKind*)(nint)environmentBaseKind)->Type = (EnvironmentBaseType)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v15+8]");
				((EnvironmentBaseKind*)(nint)environmentBaseKind)->NumTracks = 0;
			}
			else
			{
				bool flag8 = !flag4;
				nint num7 = (nint)typeof(EnvironmentBaseKind);
				if (!flag8)
				{
					nint num8 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v19 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
					bool flag9 = (nint)0 == 0;
					bool flag10 = !flag9;
					num7 = (nint)typeof(EnvironmentBaseKind);
					if (!flag10)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num7 = (nint)typeof(EnvironmentBaseKind);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ L1_v3 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
				object obj5 = (nint)0 + (nint)168;
				((EnvironmentBaseKind*)(nint)environmentBaseKind)->Type = (EnvironmentBaseType)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v9+8]");
				((EnvironmentBaseKind*)(nint)environmentBaseKind)->NumTracks = 0;
			}
		}
		return environmentBaseKind;
	}

	private unsafe int GetCurrentEnvironmentEndBlock(int currentBlockIndex)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		//IL_004e: Expected I4, but got Obj
		EnvironmentKind[] limitedAllowedEnvironmentKinds = _limitedAllowedEnvironmentKinds;
		bool flag = ((Theme)currentBlockIndex).TryGetDevicePerformanceRelativeMaterial(null, out *(Material*)limitedAllowedEnvironmentKinds.Length);
		object obj = _limitedAllowedEnvironmentKinds + 16;
		object obj2 = (flag ? 1u : 0u) << 2;
		object obj3 = obj + obj2;
		return (int)obj3;
	}

	private ChunkBlockConstraint GetEnvironmentConstraintFromIndex(int blockIndex)
	{
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_02d0: Expected Obj, but got I4
		//IL_004e: Expected I, but got Obj
		//IL_0064: Expected Obj, but got I
		//IL_008f: Expected I, but got Obj
		//IL_027c: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		List<ChunkBlockConstraint> blockConstraints = _blockConstraints;
		int num = default;
		if (blockConstraints._size > num)
		{
			ChunkBlockConstraint nextEnvironmentConstraint = GetNextEnvironmentConstraint(num);
			int num2 = default;
			ChunkBlockConstraint result;
			while (true)
			{
				num2++;
				List<ChunkBlockConstraint> blockConstraints2 = _blockConstraints;
				bool flag = num2 >= blockConstraints2._size;
				result = (ChunkBlockConstraint)(-1);
				if (flag)
				{
					break;
				}
				ChunkBlockConstraint nextEnvironmentConstraint2 = GetNextEnvironmentConstraint(num2);
				EnvironmentKind environmentKind = nextEnvironmentConstraint.EnvironmentKind;
				EnvironmentKind environmentKind2 = nextEnvironmentConstraint2.EnvironmentKind;
				nint num3 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v48 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v64 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = environmentKind._type == environmentKind2._type && environmentKind._density == environmentKind2._density;
				object obj4 = (flag2 ? 1 : 0) ^ 1;
				if (obj4 != null)
				{
					result = (ChunkBlockConstraint)(num2 - 1);
					break;
				}
			}
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private unsafe ChunkBlockConstraint GetNextEnvironmentConstraint(int currentBlockIndex)
	{
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected I4, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00c1: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_0102: Expected I, but got Obj
		//IL_0187: Expected I, but got Obj
		//IL_019d: Expected Obj, but got I
		//IL_04c3: Expected Obj, but got I4
		//IL_04ed: Expected I, but got Obj
		//IL_0503: Expected Obj, but got I
		//IL_0520: Expected I, but got Obj
		//IL_0547: Expected Obj, but got VT
		//IL_056b: Expected I4, but got Obj
		//IL_01c8: Expected I, but got Obj
		//IL_0215: Expected I, but got Obj
		//IL_0245: Expected I, but got Obj
		//IL_026b: Expected I, but got Obj
		object obj = default;
		int num = obj + 12;
		List<ChunkBlockConstraint> blockConstraints = _blockConstraints;
		if (blockConstraints._size > currentBlockIndex)
		{
			nint num2 = (nint)typeof(DebugQueuedEnvironments);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v55 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num3 = (nint)typeof(DebugQueuedEnvironments);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v111 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, string> selected = DebugQueuedEnvironments.GetSelected();
			if (selected != null)
			{
				ChunkBlockConstraint chunkBlockConstraint = _blockConstraints.get_Item(currentBlockIndex);
				EnvironmentKind environmentKind = chunkBlockConstraint.EnvironmentKind;
				nint num4 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v70 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num5 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v107 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GamePositionRoot instance = GamePositionRoot.Instance;
				EnvironmentType type = environmentKind._type;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v75 (SYBO.Subway.Level.GamePositionRoot)+8]");
				bool flag;
				if ((nint)type == (nint)0)
				{
					EnvironmentDensity density = environmentKind._density;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v75 (SYBO.Subway.Level.GamePositionRoot)+C]");
					flag = (nint)density == (nint)0;
				}
				else
				{
					flag = false;
				}
				if (flag)
				{
					float timeInDefaultRoute = ((RouteManager)this).TimeInDefaultRoute;
					nint num6 = (nint)typeof(DebugQueuedEnvironments);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v45 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num7 = (nint)typeof(DebugQueuedEnvironments);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S1_v63 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj5 = currentBlockIndex * 90;
					float runLength = timeInDefaultRoute + (float)obj5;
					IAutomationStep[] routeConfig = SubwayRunningBenchmark.GenerateSteps(runLength);
					nint num8 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v85 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					bool flag2 = obj6 == null;
					nint num9 = (nint)typeof(EnvironmentBaseKind);
					if (!flag2)
					{
						nint num10 = (nint)typeof(EnvironmentBaseKind);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v97 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
						bool flag3 = (nint)0 == 0;
						bool flag4 = !flag3;
						num9 = (nint)typeof(EnvironmentBaseKind);
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							num9 = (nint)typeof(EnvironmentBaseKind);
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ L0_v10 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
					nint num11 = 0;
					obj = EnvironmentBaseKind.None;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S1_v54 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					((int*)num)->m_value = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					ChunkBlockConstraint chunkBlockConstraint2 = default;
					((RouteManager.WeightedAlternateRouteConfig)(object)chunkBlockConstraint2)._002Ector((RouteManager.AlternateRouteConfig)(object)routeConfig, num);
					return chunkBlockConstraint2;
				}
			}
			return _blockConstraints.get_Item(currentBlockIndex);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private int CreateEnvironmentBase(int blockIndex, EnvironmentBaseKind baseKind, EnvironmentBaseKind baseKindNext, EnvironmentKind envKind)
	{
		//IL_0041: Expected I4, but got Obj
		//IL_0041: Expected Obj, but got VT
		//IL_0041: Expected I4, but got Obj
		//IL_0041: Expected I4, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Component> list = default;
		list._002Ector();
		((Game)this).OnStumble((Character.StumbleType)blockIndex, (Character.StumbleHorizontalHit)baseKind, (Character.StumbleVerticalHit)list, (string)baseKindNext, (byte)(int)envKind != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BBA9");
		int result = default;
		return result;
	}

	private EnvironmentSequence EvalNextEnvironmentSequence(int nextEnvBlockIndex, int envEndBlockIndex, EnvironmentInfo environmentInfo, bool shouldStartCurrentEnvironment, bool shouldEndCurrentEnvironment)
	{
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected Obj, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected Obj, but got Unknown
		//IL_0537: Expected Obj, but got I4
		//IL_0558: Expected Obj, but got I
		//IL_001f: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_0140: Expected Obj, but got I4
		//IL_05e9: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I
		//IL_019c: Expected I, but got Obj
		//IL_01b2: Expected Obj, but got I
		//IL_01dd: Expected I, but got Obj
		//IL_027e: Expected Obj, but got I
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_02ce: Expected Obj, but got I
		//IL_062f: Expected Obj, but got I
		//IL_043b: Expected Obj, but got I4
		//IL_04ab: Expected I4, but got Obj
		RouteChunk routeChunk = default;
		RouteSection routeSection = (RouteSection)(routeChunk + 72);
		object obj = routeChunk + 16;
		object obj2 = routeChunk + 56;
		obj2 = 0;
		_ = 0;
		int blockCount = _blockCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (System.Int32)+A8]");
		EnvironmentSequence result;
		if (Enumerable.Count((IEnumerable<RouteEnvironmentModelAssets>)0) != 0)
		{
			object obj5 = default;
			object obj10 = default;
			bool flag4 = default;
			while (true)
			{
				int blockCount2 = _blockCount;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S2_v4 (System.Int32)+A8]");
				object obj3 = 0;
				object obj4 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S2_v5+C]");
				bool flag = (nint)obj4 >= 0;
				result = EnvironmentSequence.None;
				if (flag)
				{
					break;
				}
				int blockCount3 = _blockCount;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v24 (System.Int32)+A8]");
				object obj6 = (nint)0 + (nint)16;
				object obj7 = obj5 << 2;
				object obj8 = obj6 + obj7;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v28+8]");
				if ((nint)0 != nextEnvBlockIndex)
				{
					obj5 = obj10 + 1;
					continue;
				}
				int blockCount4 = _blockCount;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v32 (System.Int32)+A8]");
				object obj11 = (nint)0 + (nint)16;
				object obj12 = obj5 << 2;
				object obj13 = obj11 + obj12;
				object obj14 = obj13;
				if (obj13 != null)
				{
					object obj15 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v36+C]");
						object obj16 = 0;
						object obj17 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S2_v12+C]");
						bool flag2 = (nint)obj17 >= 0;
						result = EnvironmentSequence.None;
						if (flag2)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v36+C]");
						object obj18 = (nint)0 + (nint)16;
						object obj19 = obj15 << 2;
						object obj20 = obj18 + obj19;
						object obj21 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v46+C]");
						object obj22 = 0;
						nint num = (nint)typeof(EnvironmentKind);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v49 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
						object obj23 = (nint)0 & (nint)0x200;
						if (obj23 != null)
						{
							nint num2 = (nint)typeof(EnvironmentKind);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v128 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v47+8]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envEndBlockIndex @ L2 (System.Int32)+8]");
						bool flag3;
						if (num3 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v47+C]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envEndBlockIndex @ L2 (System.Int32)+C]");
							flag3 = num4 == 0;
						}
						else
						{
							flag3 = false;
						}
						if (!flag3)
						{
							object obj24 = obj15 + 1;
							obj15 = obj24;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v36+C]");
						object obj25 = (nint)0 + (nint)16;
						object obj26 = obj15 << 2;
						object obj27 = obj25 + obj26;
						object obj28 = obj27;
						if (obj27 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v62+10]");
							object obj29 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v66+C]");
							if ((nint)0 < (nint)(flag4 ? 1 : 0))
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
								throw new ArrayTypeMismatchException();
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v66+C]");
							object obj30 = -1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @80CC");
							routeSection = (RouteSection)obj;
							RouteSection routeSection2 = routeSection;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
							((UnityEngine.Object)routeSection2).m_CachedPtr = (IntPtr)0;
							RouteSection routeSection3 = routeSection;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
							routeSection3._zMaximumActive = false;
							RouteSection routeSection4 = routeSection;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+18]");
							routeSection4._minSpawnOrder = 0;
							RouteSection routeSection5 = routeSection;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+20]");
							routeSection5._middleChunkCountLimited = false;
							routeChunk.Initialize(null, routeSection, (RouteChunk)(object)environmentInfo);
							obj2 = routeChunk;
							_ = ((UnityEngine.Object)routeChunk).m_CachedPtr;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+C]");
							if ((nint)0 != 0)
							{
								object obj31 = (shouldStartCurrentEnvironment ? 1 : 0) - 1;
								if (!shouldStartCurrentEnvironment)
								{
									if ((nint)obj31 == 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @80CE");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (SYBO.Subway.Routes.RouteSection)+4]");
										result = EnvironmentSequence.None;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @80CE");
										result = (EnvironmentSequence)(nint)((UnityEngine.Object)routeSection).m_CachedPtr;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @80CE");
									result = (EnvironmentSequence)routeSection;
								}
							}
							else
							{
								result = EnvironmentSequence.None;
							}
							break;
						}
						result = EnvironmentSequence.None;
						break;
					}
				}
				else
				{
					result = EnvironmentSequence.None;
				}
				break;
			}
		}
		else
		{
			result = EnvironmentSequence.None;
		}
		return result;
	}

	private unsafe int CreateEnvironmentSegment(int blockIndex, EnvironmentInfo environmentInfo, EnvironmentSequence sequence, ref int prevSegmentVariation)
	{
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected Obj, but got Unknown
		//IL_0588: Expected I, but got Obj
		//IL_059e: Expected Obj, but got I
		//IL_05bb: Expected I, but got Obj
		//IL_07ee: Expected Obj, but got I
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected Obj, but got Unknown
		//IL_082f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected I4, but got Unknown
		//IL_0841: Expected I4, but got Obj
		//IL_0089: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_00d3: Expected I4, but got Obj
		//IL_05d6: Expected I4, but got Obj
		//IL_0069: Expected I, but got Obj
		//IL_015d: Expected I, but got Obj
		//IL_01d8: Expected I, but got Obj
		//IL_01ee: Expected Obj, but got I
		//IL_02ef: Expected I4, but got Obj
		//IL_0318: Expected VT, but got Obj
		//IL_0219: Expected I, but got Obj
		//IL_033c: Expected I, but got Obj
		//IL_0352: Expected Obj, but got I
		//IL_048d: Expected I, but got Obj
		//IL_04a3: Expected Obj, but got I
		//IL_037d: Expected I, but got Obj
		//IL_0745: Expected I, but got Obj
		//IL_075b: Expected Obj, but got I
		//IL_078e: Expected I4, but got Obj
		//IL_07a8: Expected VT, but got I4
		//IL_07b9: Expected I4, but got Obj
		//IL_07cf: Expected Obj, but got I4
		//IL_04ce: Expected I, but got Obj
		//IL_051b: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 12;
		obj = environmentInfo;
		_ = environmentInfo.Kind;
		nint num = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag = obj3 == null;
		nint num2 = (nint)typeof(EnvironmentBaseKind);
		if (!flag)
		{
			nint num3 = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v152 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(EnvironmentBaseKind);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(EnvironmentBaseKind);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ L3_v2 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj4 = (nint)0 + (nint)192;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v11+8]");
		_ = 0;
		object obj5 = obj2 + 24;
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		EnvironmentType environmentType = (EnvironmentType)(obj2 + 36);
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8656");
		object obj6 = default;
		int num4;
		if (obj6 != null)
		{
			num4 = 4;
		}
		else
		{
			((EnvironmentType*)(int)environmentType)->value__ = (int)environmentInfo;
			_ = environmentInfo.Kind;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v22 (SYBO.Subway.Level.EnvironmentType)+4]");
			if ((nint)0 != 1)
			{
				((EnvironmentType*)(int)environmentType)->value__ = (int)environmentInfo;
				_ = environmentInfo.Kind;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v22 (SYBO.Subway.Level.EnvironmentType)+4]");
				bool flag4 = (nint)0 != 3;
				num4 = 2;
				if (flag4)
				{
					goto IL_05c9;
				}
			}
			nint num5 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v115 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v142 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			EnvironmentKind pillars = EnvironmentKind.Pillars;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [prevSegmentVariation @ L4 (SYBO.Subway.Level.EnvironmentSequence)+8]");
			bool flag5;
			if ((nint)0 == (nint)pillars._type)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [prevSegmentVariation @ L4 (SYBO.Subway.Level.EnvironmentSequence)+C]");
				flag5 = (nint)0 == (nint)pillars._density;
			}
			else
			{
				flag5 = false;
			}
			if (!flag5)
			{
				nint num7 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v127 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num8 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v132 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				EnvironmentKind station = EnvironmentKind.Station;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [prevSegmentVariation @ L4 (SYBO.Subway.Level.EnvironmentSequence)+8]");
				bool flag6;
				if ((nint)0 == (nint)station._type)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [prevSegmentVariation @ L4 (SYBO.Subway.Level.EnvironmentSequence)+C]");
					flag6 = (nint)0 == (nint)station._density;
				}
				else
				{
					flag6 = false;
				}
				bool flag7 = !flag6;
				num4 = 2;
				if (flag7)
				{
					goto IL_05c9;
				}
			}
			num4 = 1;
		}
		goto IL_05c9;
		IL_05c9:
		((EnvironmentType*)(int)environmentType)->value__ = (int)environmentInfo;
		_ = environmentInfo.Kind;
		if (((EnvironmentType*)(int)environmentType)->value__ != 1)
		{
			ThemeManager themeManager = _themeManager;
			if (!((ThemeManager)(object)themeManager._theme).NeedSameVariationForAllSegments((EnvironmentType)(int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref prevSegmentVariation)))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				((EnvironmentType*)(int)environmentType)->value__ = (int)environmentInfo;
				_ = environmentInfo.Kind;
				EnvironmentKind environmentKind = default;
				environmentKind._002Ector(environmentType, (EnvironmentDensity)num4);
				_00210 ga = (_00210)SingletonMonoBehaviour<>.Instantiate();
				Transform[] prefabsForBaseInfo = AssetManager.GetPrefabsForBaseInfo((GroundAssetGroup)ga, (EnvironmentBaseInfo)(object)environmentKind);
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num10 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v104 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)prefabsForBaseInfo).FindKernel((string)null) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					throw new ArrayTypeMismatchException();
				}
				nint num11 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v59 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num12 = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v83 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float angle = (float)blockIndex * 90f;
				PrefabPool prefabPool = PoolManager.GetPrefabPool((Transform)(object)prefabsForBaseInfo);
				((Transform)(object)prefabPool).parentInternal = _environmentTransform;
				nint num13 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v68 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num14 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S0_v79 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 back = Vector3.back;
				((EnvironmentType*)(int)environmentType)->value__ = (int)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v19+8]");
				_ = 0;
				Quaternion quaternion = Quaternion.AngleAxis(angle, (Vector3)environmentType);
				((EnvironmentType*)(int)environmentType)->value__ = (int)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Vector3 eulerAngles = ((Transform)environmentType).eulerAngles;
			}
		}
		return num4;
	}

	private void CreateEnvironmentLogic(EnvironmentType envType, EnvironmentSequence sequence, float positionZ)
	{
		//IL_000b: Expected Obj, but got F4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_001e: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got F4
		//IL_0042: Expected Obj, but got I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		this.m_OnDeactivate = (Action)1f;
		object obj = this + 12;
		obj = sequence;
		this.m_OnDeactivate = (Action)positionZ;
		_ = 3000f;
		_isRepeatableInSections = (byte)envType != 0;
		((ScoreMultiplier)(object)this).RaiseOnValueChanged((ScoreMultiplier.ValueChangedEventArgs)envType);
		object obj2 = this + 36;
		string text = ((SmoothDampVector3B)(object)this).ToString();
		obj2 = text;
		((ScoreMultiplier)(object)this).RestartCoolDownCoroutine();
	}

	private unsafe int CreateEnvironmentModel(EnvironmentInfo environmentInfo, EnvironmentSequence sequence, int prevVariation, float positionZ)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 16;
		obj = this;
		object obj2 = num + 24;
		obj2 = environmentInfo;
		object obj3 = ((EnvironmentSequence*)(int)sequence)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sequence @ L2 (SYBO.Subway.Level.EnvironmentSequence)+8]");
		_ = 0;
		object obj4 = num + 28;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		obj3 = ((int*)prevVariation)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [prevVariation @ L3 (System.Int32)+8]");
		_ = 0;
		object obj5 = num + 44;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return num;
	}

	private unsafe void PlaceEnvironmentModel(EnvironmentKind envTypeInfo, EnvironmentSequence sequence, EnvironmentSide side, int variation, float positionZ)
	{
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected Obj, but got Unknown
		//IL_033b: Expected Obj, but got I4
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0358: Expected Obj, but got I4
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected Obj, but got Unknown
		//IL_0399: Expected Obj, but got I4
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_03b6: Expected Obj, but got I4
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_03d3: Expected Obj, but got I4
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected Obj, but got Unknown
		//IL_03f4: Expected Obj, but got I4
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected Obj, but got Unknown
		//IL_041c: Expected Obj, but got I4
		//IL_0437: Expected I, but got Obj
		//IL_044d: Expected Obj, but got I
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected VT, but got Unknown
		//IL_0485: Expected F4, but got Obj
		//IL_0480: Expected native int or pointer, but got VT
		//IL_049a: Expected F4, but got I
		//IL_0495: Expected native int or pointer, but got VT
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_04bd: Expected F4, but got I
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected VT, but got Unknown
		//IL_04dc: Expected F4, but got Obj
		//IL_04d7: Expected native int or pointer, but got VT
		//IL_04f1: Expected F4, but got I
		//IL_04ec: Expected native int or pointer, but got VT
		//IL_04fe: Expected F4, but got Obj
		//IL_04f9: Expected native int or pointer, but got VT
		//IL_0513: Expected F4, but got I
		//IL_050e: Expected native int or pointer, but got VT
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Obj, but got Unknown
		//IL_0562: Expected VT, but got I4
		//IL_00bf: Expected F4, but got Obj
		//IL_00ba: Expected native int or pointer, but got VT
		//IL_00d4: Expected F4, but got I
		//IL_00cf: Expected native int or pointer, but got VT
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_0113: Expected F4, but got I4
		//IL_010e: Expected native int or pointer, but got VT
		//IL_0128: Expected F4, but got I
		//IL_0123: Expected native int or pointer, but got VT
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_017f: Expected F4, but got Obj
		//IL_017a: Expected native int or pointer, but got VT
		//IL_0194: Expected F4, but got I
		//IL_018f: Expected native int or pointer, but got VT
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0235: Expected F4, but got Obj
		//IL_0230: Expected native int or pointer, but got VT
		//IL_024a: Expected F4, but got I
		//IL_0245: Expected native int or pointer, but got VT
		//IL_0257: Expected F4, but got Obj
		//IL_0252: Expected native int or pointer, but got VT
		//IL_026c: Expected F4, but got I
		//IL_0267: Expected native int or pointer, but got VT
		//IL_02de: Expected Obj, but got I4
		//IL_0319: Expected VT, but got F4
		object obj2 = default;
		object obj = obj2 + 304;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 240;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 224;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 212;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 200;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 188;
		obj7 = ((EnvironmentSide*)(int)side)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [side @ L3 (SYBO.Subway.Level.EnvironmentSide)+8]");
		_ = 0;
		object obj8 = obj2 + 176;
		obj8 = ((int*)variation)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [variation @ L4 (System.Int32)+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v38 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v116 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 328);
		((Vector3*)(nint)vector)->x = (float)obj8;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v33+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj10 = obj2 + 164;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envTypeInfo @ L1 (SYBO.Subway.Level.EnvironmentKind)+18]");
		Vector3 vector4 = vector3 / 0f;
		Vector3 vector5 = (Vector3)(obj2 + 316);
		((Vector3*)(nint)vector5)->x = (float)obj7;
		Vector3 vector6 = vector5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v30+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj10;
		Vector3 vector7 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v46+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		object obj11 = obj2 + 152;
		Vector3 vector8 = vector5 - vector;
		obj = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v53+8]");
		_ = 0;
		Camera camera = (Camera)(obj2 + 88);
		camera.worldToCameraMatrix = (Matrix4x4)sequence;
		obj3 = camera;
		_ = ((UnityEngine.Object)camera).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v57 (UnityEngine.Camera)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v57 (UnityEngine.Camera)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v57 (UnityEngine.Camera)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v57 (UnityEngine.Camera)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v57 (UnityEngine.Camera)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v57 (UnityEngine.Camera)+38]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector9 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector9)->z = 0f;
		object obj12 = obj2 + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DD");
		obj4 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v69+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = ((int*)variation)->m_value;
		Vector3 vector10 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [variation @ L4 (System.Int32)+8]");
		((Vector3*)(nint)vector10)->z = 0f;
		object obj13 = obj2 + 60;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6E1");
		obj6 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v75+8]");
		_ = 0;
		object obj14 = obj2 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11463");
		((Vector3*)(nint)vector)->x = (float)obj14;
		Vector3 vector11 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v79+8]");
		((Vector3*)(nint)vector11)->z = 0f;
		object obj15 = obj2 + 36;
		Vector3 vector12 = vector / positionZ;
		obj5 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v83+8]");
		_ = 0;
		object obj16 = obj2 + 24;
		obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v83+8]");
		_ = 0;
		object obj17 = obj2 + 12;
		obj17 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v24+8]");
		_ = 0;
		obj2 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v24+8]");
		_ = 0;
		((Vector3*)(nint)vector5)->x = (float)obj4;
		Vector3 vector13 = vector5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v21+8]");
		((Vector3*)(nint)vector13)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj5;
		Vector3 vector14 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v24+8]");
		((Vector3*)(nint)vector14)->z = 0f;
		float num3 = vector5.x * vector.x;
		float num4 = vector5.y * vector.y;
		float num5 = num3 + num4;
		float num6 = vector5.z * vector.z;
		float num7 = num5 + num6;
		RouteChunk routeChunk = (RouteChunk)0;
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		routeChunk = (RouteChunk)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v92+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		Vector3 logicHideOffset = (Vector3)(0f - num7);
		LogicHideOffset = logicHideOffset;
	}

	private void EvaluateEnvironmentConstraints()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0981: Unknown result type (might be due to invalid IL or missing references)
		//IL_0986: Expected Obj, but got Unknown
		//IL_098f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0994: Expected Obj, but got Unknown
		//IL_099d: Expected Obj, but got I4
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected Obj, but got Unknown
		//IL_09c6: Expected Obj, but got I4
		//IL_09d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09da: Expected Obj, but got Unknown
		//IL_09f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f6: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_00b4: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_00f5: Expected I, but got Obj
		//IL_01f5: Expected I, but got Obj
		//IL_020b: Expected Obj, but got I
		//IL_0236: Expected I, but got Obj
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_02c5: Expected Obj, but got I4
		//IL_08ce: Expected Obj, but got I
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected Obj, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_093f: Expected Obj, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Expected Obj, but got Unknown
		//IL_0836: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Expected Obj, but got Unknown
		//IL_0867: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 112;
		object obj3 = obj2 + 12;
		object obj4 = obj2 + 40;
		obj4 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 24;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 16;
		obj6 = obj;
		_ = -1;
		object obj7 = obj2 + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10B8B");
		obj4 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25+18]");
		_ = 0;
		object obj8 = default;
		object obj10 = default;
		object obj13 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj5 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S0_v122 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S0_v214 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S0_v140 (Il2CppClass<System.Type>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ S0_v183 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj3 = typeof(IHideable);
			obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18");
			object obj12 = obj13 + 12;
			object obj14 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
			{
				object obj15 = obj13 + 16;
				object obj16 = obj14 << 2;
				object obj17 = obj15 + obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				object obj18 = obj14 + 1;
				obj14 = obj18;
			}
		}
		object obj19 = 41;
		object obj20 = obj19 - 9;
		object obj23;
		object obj24 = default;
		object obj21;
		if ((nint)obj19 != 9 && (nint)obj20 != 1)
		{
			if ((nint)obj20 != 2 && (nint)obj20 != 3)
			{
				if ((nint)obj20 == 4)
				{
					goto IL_086c;
				}
				if ((nint)obj20 != 5 && (nint)obj20 != 6 && (nint)obj20 != 7 && (nint)obj20 != 8 && (nint)obj20 != 9 && (nint)obj20 != 10 && (nint)obj20 != 11 && (nint)obj20 != 12 && (nint)obj20 != 13)
				{
					if ((nint)obj20 != 14)
					{
						if ((nint)obj20 != 15)
						{
							if ((nint)obj20 != 16)
							{
								if ((nint)obj20 != 17)
								{
									if ((nint)obj20 == 18 || (nint)obj20 == 19 || (nint)obj20 == 20)
									{
										goto IL_0aed;
									}
									if ((nint)obj20 != 21)
									{
										if ((nint)obj20 != 22)
										{
											if ((nint)obj20 != 23 && (nint)obj20 != 24 && (nint)obj20 != 25 && (nint)obj20 != 26)
											{
												if ((nint)obj20 == 27)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													object obj22 = default;
													obj21 = obj22;
													obj23 = obj24;
													goto IL_0aa8;
												}
												if ((nint)obj20 != 28 && (nint)obj20 != 29 && (nint)obj20 != 30)
												{
													if ((nint)obj20 == 31)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														object obj25 = default;
														obj21 = obj25;
														obj23 = obj24;
														goto IL_0aa8;
													}
													if ((nint)obj20 == 32)
													{
														object obj26 = obj6 + 4;
														object obj27 = obj26 + 1;
														obj26 = obj27;
														object obj28 = obj27 << 2;
														object obj29 = obj6 + obj28;
														obj29 = 134;
													}
												}
											}
											goto IL_0aed;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj30 = default;
										obj21 = obj30;
										obj23 = obj24;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj31 = default;
										obj21 = obj31;
										obj23 = obj24;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj32 = default;
									obj21 = obj32;
									obj23 = obj24;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj33 = default;
								obj21 = obj33;
								obj23 = obj24;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj34 = default;
							obj21 = obj34;
							obj23 = obj24;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj35 = default;
						obj21 = obj35;
						obj23 = obj24;
					}
					goto IL_0aa8;
				}
			}
			goto IL_0aed;
		}
		goto IL_086c;
		IL_0b12:
		((Dictionary<TKey, TValue>)(object)_hiddenObstacles).Resize();
		return;
		IL_0aed:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22+4]");
			object obj36 = (nint)0 << 2;
			object obj37 = obj6 + obj36;
			if ((nint)obj37 == 134)
			{
				object obj38 = obj6 + 4;
				if ((nint)obj38 > -1)
				{
					object obj39 = obj38 + -1;
					obj38 = obj39;
				}
				goto IL_0b12;
			}
		}
		object obj40 = default;
		if (obj40 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0b12;
		IL_086c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj41 = default;
		obj21 = obj41;
		obj23 = obj24;
		goto IL_0aa8;
		IL_0aa8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj42 = default;
		if (obj23 == obj42)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0aed;
	}

	private SYBO.Subway.Level.Environment GetEnvironmentConstraint(int blockIndex)
	{
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected Obj, but got Unknown
		//IL_0169: Expected I, but got Obj
		//IL_017f: Expected Obj, but got I
		//IL_0071: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_01aa: Expected I, but got Obj
		//IL_01f7: Expected I, but got Obj
		//IL_020d: Expected Obj, but got I
		//IL_00b2: Expected I, but got Obj
		//IL_0462: Expected Obj, but got I4
		//IL_0238: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		List<ChunkBlockConstraint> blockConstraints = _blockConstraints;
		if (blockConstraints._size > blockIndex)
		{
			ChunkBlockConstraint nextEnvironmentConstraint = GetNextEnvironmentConstraint(blockIndex);
			int currentBlockIndex = blockIndex + 1;
			ChunkBlockConstraint nextEnvironmentConstraint2 = GetNextEnvironmentConstraint(currentBlockIndex);
			ChunkBlockConstraint chunkBlockConstraint = nextEnvironmentConstraint2;
			int num = blockIndex;
			while (true)
			{
				List<ChunkBlockConstraint> blockConstraints2 = _blockConstraints;
				if (num >= blockConstraints2._size)
				{
					break;
				}
				EnvironmentKind environmentKind = nextEnvironmentConstraint.EnvironmentKind;
				EnvironmentKind environmentKind2 = chunkBlockConstraint.EnvironmentKind;
				nint num2 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v94 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num3 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v112 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = environmentKind._type == environmentKind2._type && environmentKind._density == environmentKind2._density;
				object obj4 = (flag ? 1 : 0) ^ 1;
				if (obj4 == null)
				{
					break;
				}
				int currentBlockIndex2 = num + 1;
				ChunkBlockConstraint nextEnvironmentConstraint3 = GetNextEnvironmentConstraint(currentBlockIndex2);
				int num4 = num + 1;
				chunkBlockConstraint = nextEnvironmentConstraint3;
				num = num4;
			}
			nint num5 = (nint)typeof(ChunkBlockConstraint);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v64 (Il2CppClass<SYBO.Subway.Routes.RouteChunk+ChunkBlockConstraint>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(ChunkBlockConstraint);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v85 (Il2CppClass<SYBO.Subway.Routes.RouteChunk+ChunkBlockConstraint>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (nextEnvironmentConstraint != chunkBlockConstraint)
			{
				nint num7 = (nint)typeof(ChunkBlockConstraint);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v72 (Il2CppClass<SYBO.Subway.Routes.RouteChunk+ChunkBlockConstraint>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num8 = (nint)typeof(ChunkBlockConstraint);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v79 (Il2CppClass<SYBO.Subway.Routes.RouteChunk+ChunkBlockConstraint>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				chunkBlockConstraint = ChunkBlockConstraint.None;
			}
			return (SYBO.Subway.Level.Environment)(object)chunkBlockConstraint;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private unsafe EnvironmentBase GetEnvironmentBaseConstraint(int blockIndex)
	{
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected VT, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected VT, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0071: Expected VT, but got Obj
		//IL_0085: Expected VT, but got Obj
		//IL_0093: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_01b0: Expected F4, but got Obj
		//IL_01ab: Expected native int or pointer, but got VT
		//IL_01c2: Expected F4, but got I
		//IL_01bd: Expected native int or pointer, but got VT
		//IL_01cf: Expected F4, but got Obj
		//IL_01ca: Expected native int or pointer, but got VT
		//IL_01e1: Expected F4, but got I
		//IL_01dc: Expected native int or pointer, but got VT
		//IL_01ff: Expected F4, but got Obj
		//IL_01fa: Expected native int or pointer, but got VT
		//IL_0214: Expected F4, but got I
		//IL_020f: Expected native int or pointer, but got VT
		//IL_021d: Expected Obj, but got VT
		//IL_0244: Expected Obj, but got I
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_026d: Expected Obj, but got I4
		//IL_00d4: Expected I, but got Obj
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj + 48);
		Vector3 vector2 = (Vector3)(obj + 36);
		Transform transform = (Transform)(obj + 24);
		Transform transform2 = (Transform)(obj + 12);
		SYBO.Subway.Level.Environment[] forcedEnvironments = _forcedEnvironments;
		if (forcedEnvironments.Length != 0)
		{
			object obj2 = _forcedEnvironments + 12;
			object obj3 = default;
			object obj6;
			object obj11 = default;
			while (true)
			{
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
				{
					return null;
				}
				object obj4 = _forcedEnvironments + 16;
				object obj5 = obj3 << 2;
				obj6 = obj4 + obj5;
				Component component = (Component)obj6;
				GameObject gameObject = ((Component)obj6).gameObject;
				transform.position = (Vector3)gameObject;
				transform2.position = (Vector3)_transform;
				nint num = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v32 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num2 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v49 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector2)->x = (float)transform;
				((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				((Vector3*)(nint)vector)->x = (float)transform2;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
				Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
				((Vector3*)(nint)vector)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Vector3*)(nint)vector)->z = 0f;
				bool flag = HasParentRouteChunk((Transform)vector);
				bool flag2 = (flag ? 1 : 0) > blockIndex;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v15 (UnityEngine.Component)+10]");
				object obj8 = (nint)0 + (nint)(flag ? 1 : 0);
				object obj9 = obj8 - 1;
				bool flag3 = (nint)obj9 < blockIndex;
				object obj10 = flag2 | flag3;
				if (obj10 == null)
				{
					break;
				}
				obj3 = obj11 + 1;
			}
			return (EnvironmentBase)obj6;
		}
		return null;
	}

	public unsafe static EnvironmentBaseKind EnvironentBaseToBaseKind(EnvironmentBase envBase)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0080: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected VT, but got Unknown
		//IL_00fd: Expected F4, but got Obj
		//IL_00f8: Expected native int or pointer, but got VT
		//IL_0112: Expected F4, but got I
		//IL_010d: Expected native int or pointer, but got VT
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected VT, but got Unknown
		//IL_013e: Expected F4, but got Obj
		//IL_0139: Expected native int or pointer, but got VT
		//IL_0153: Expected F4, but got I
		//IL_014e: Expected native int or pointer, but got VT
		//IL_0160: Expected F4, but got Obj
		//IL_015b: Expected native int or pointer, but got VT
		//IL_0175: Expected F4, but got I
		//IL_0170: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		Vector3 gamePositionEnd = ((RouteChunk)(object)envBase).GamePositionEnd;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v31 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 12;
		Vector3 back = Vector3.back;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envBase @ L1 (SYBO.Subway.Level.EnvironmentBase)+20]");
		float num3 = 0f * 90f;
		Vector3 vector = (Vector3)(obj2 + 48);
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v16+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = vector / num3;
		Vector3 vector3 = (Vector3)(obj2 + 36);
		((Vector3*)(nint)vector3)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector4 = vector3 - vector;
		EnvironmentBaseKind result = default;
		return result;
	}

	public static int GetBlockIndexFromLocalPosition(Vector3 localPos)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 16;
		obj = localPos;
		return num;
	}

	public static float GetBaseColliderOffsetY()
	{
		return 13f;
	}

	public static bool HasParentRouteChunk(Transform childTransform)
	{
		//IL_0138: Expected Obj, but got I
		//IL_0146: Expected I, but got Obj
		//IL_015c: Expected Obj, but got I
		//IL_0069: Invalid comparison between Obj and F4
		//IL_0013: Expected I, but got Obj
		//IL_00a2: Invalid comparison between Obj and F4
		//IL_005b: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected I4, but got Unknown
		//IL_00db: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I4
		_ = ((UnityEngine.Object)childTransform).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		object obj = 0;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v36 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (obj != obj)
		{
			obj = int.MinValue;
		}
		else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)2.1474836E+09f))
		{
			obj = int.MinValue;
		}
		else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)(-2.1474836E+09f)))
		{
			obj = int.MinValue;
		}
		if ((nint)obj < 0)
		{
			obj = 0;
		}
		else if ((nint)obj > int.MaxValue)
		{
			obj = int.MaxValue;
		}
		return (byte)(obj / 90) != 0;
	}

	public static RouteChunk GetParentRouteChunk(Transform childTransform)
	{
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		List<Route> routes = ((RouteCollection)(object)childTransform).Routes;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (RouteChunk)((ComputeShader)(object)routes).FindKernel((string)null);
	}

	public unsafe RouteChunk()
	{
		//IL_0250: Expected Obj, but got I4
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected VT, but got Unknown
		//IL_001e: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0297: Expected I, but got Obj
		//IL_02ad: Expected Obj, but got I
		//IL_02ca: Expected I, but got Obj
		//IL_02f6: Expected Obj, but got VT
		//IL_02f1: Expected native int or pointer, but got VT
		//IL_0335: Expected VT, but got I4
		//IL_0347: Expected I, but got Obj
		//IL_035d: Expected Obj, but got I
		//IL_00b3: Expected I, but got Obj
		//IL_0100: Expected I, but got Obj
		//IL_0130: Expected I, but got Obj
		//IL_03b3: Expected I, but got Obj
		//IL_03c9: Expected Obj, but got I
		//IL_0169: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I4
		//IL_0156: Expected I, but got Obj
		//IL_03f8: Expected native int or pointer, but got VT
		//IL_041b: Expected I4, but got VT
		//IL_01c8: Expected I, but got Obj
		//IL_020f: Expected native int or pointer, but got VT
		object obj = 0;
		_ = 0;
		if (_blockConstraints == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<> list = default;
			((List<T>)(object)list)._002Ector((IEnumerable<T>)_blockCount);
			object obj2 = this + 96;
			obj2 = list;
		}
		RouteConstraint routeConstraint = (RouteConstraint)(obj + 12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		int num = default;
		RouteManager.WeightedAlternateRouteConfig weightedAlternateRouteConfig = default;
		int num12 = default;
		while (num < _blockCount)
		{
			nint num2 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v23 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num3 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v82 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GamePositionRoot routeConfig = GamePositionRoot.Instance;
			nint num4 = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v30 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num5 = (nint)typeof(EnvironmentBaseKind);
			if (!flag)
			{
				nint num6 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v76 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num5 = (nint)typeof(EnvironmentBaseKind);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num5 = (nint)typeof(EnvironmentBaseKind);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ L1_v5 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
			nint num7 = 0;
			System.Runtime.CompilerServices.Unsafe.Write(&((RouteConstraint*)(nint)routeConstraint)->AllowedEnvironmentKinds, (EnvironmentKind[])EnvironmentBaseKind.None);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v15 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
			_ = 0;
			obj = routeConstraint.AllowedEnvironmentKinds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v15 (SYBO.Subway.Routes.RouteConstraint)+8]");
			_ = 0;
			EnvironmentBase environmentBaseConstraint = GetEnvironmentBaseConstraint(num);
			Route routeContainingPoint = ((RouteCollection)(object)this).GetRouteContainingPoint((Vector3)num);
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v72 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)environmentBaseConstraint).FindKernel((string)null) != 0)
			{
				routeConfig = (GamePositionRoot)environmentBaseConstraint._type;
			}
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v65 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)routeContainingPoint).FindKernel((string)null) != 0)
			{
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)routeConstraint, new RouteConstraint((EnvironmentKind[])(object)routeContainingPoint));
				obj = routeConstraint.AllowedEnvironmentKinds;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v15 (SYBO.Subway.Routes.RouteConstraint)+8]");
				_ = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			System.Runtime.CompilerServices.Unsafe.Write(&((RouteConstraint*)(nint)routeConstraint)->AllowedEnvironmentKinds, obj);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			weightedAlternateRouteConfig._002Ector((RouteManager.AlternateRouteConfig)(object)routeConfig, (int)routeConstraint);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
			num = num12 + 1;
		}
	}
}
