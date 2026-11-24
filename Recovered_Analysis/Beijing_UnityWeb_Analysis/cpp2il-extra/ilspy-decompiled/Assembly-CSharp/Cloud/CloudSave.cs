using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using AppRefresh;
using Authentication;
using Authentication.Internal;
using Cloud.Internal;
using Cpp2ILInjected;
using Data.DebugUtil;
using Data.Managers;
using Data.Migration;
using Data.Save;
using InApp;
using Info;
using Kiloo;
using Kiloo.Common.Backend;
using Kiloo.Common.Backend.Authentication;
using Kiloo.Common.Backend.Cloud;
using Kiloo.Common.Extensions;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using Kiloo.Monetization.FlurryPlugin;
using Kiloo.Serialization;
using Missions;
using SYBO.Components.Utilities.Data;
using SYBO.Subway.Info;
using UI.Screens;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace Cloud;

public static class CloudSave
{
	private sealed class _003CLoginAsync_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action onUpdateFinished;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0061: Expected I, but got Obj
				//IL_0077: Expected Obj, but got I
				//IL_01be: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c3: Expected Obj, but got Unknown
				//IL_01d4: Expected Obj, but got I4
				//IL_01e8: Expected Obj, but got I4
				//IL_00a2: Expected I, but got Obj
				//IL_00fa: Expected I, but got Obj
				//IL_0110: Expected Obj, but got I
				//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0202: Expected Obj, but got Unknown
				//IL_022d: Expected Obj, but got I4
				//IL_013b: Expected I, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
					nint num = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v24 (Il2CppClass<Cloud.CloudSave>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(CloudSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v33 (Il2CppClass<Cloud.CloudSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Disable();
					object obj2 = this + 12;
					IEnumerator enumerator = Update_Routine(onUpdateFinished);
					obj2 = enumerator;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				nint num3 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10 (Il2CppClass<Authentication.Auth>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(Auth);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v18 (Il2CppClass<Authentication.Auth>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj4 = this + 12;
				bool refreshInProgress = AppRefreshHandler.refreshInProgress;
				obj4 = refreshInProgress;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CLoginAsync_003Ed__39(int _003C_003E1__state)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 8;
			obj = _003C_003E1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Cloud.CloudSave+<LoginAsync>d__39)+11]");
			if ((nint)0 == 0)
			{
				((InAppManager)(object)"Invalid theme identifier requested.").onProductRequestDone += null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Cloud.CloudSave+<LoginAsync>d__39)+18]");
			return false;
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

	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public DateTime startTime;

		public _003C_003Ec__DisplayClass44_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CCommitAsync_003Eb__0(bool success)
		{
			//IL_000a: Expected VT, but got I4
			startTime = (DateTime)success;
		}
	}

	private sealed class _003CCommitAsync_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0201: Expected Obj, but got Unknown
				//IL_0054: Expected Obj, but got VT
				//IL_006f: Expected I, but got Obj
				//IL_0085: Expected Obj, but got I
				//IL_00b0: Expected I, but got Obj
				//IL_00fd: Expected I, but got Obj
				//IL_0113: Expected Obj, but got I
				//IL_0254: Expected I, but got Obj
				//IL_026a: Expected Obj, but got I
				//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02cb: Expected Obj, but got Unknown
				//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02de: Expected Obj, but got Unknown
				//IL_030c: Expected Obj, but got I4
				//IL_013e: Expected I, but got Obj
				//IL_018b: Expected I, but got Obj
				object obj2 = default;
				object obj = obj2 + 8;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				DateTime today = CDateTime.Today;
				obj2 = today;
				obj = obj2;
				nint num = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v21 (Il2CppClass<Cloud.CloudSave>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v62 (Il2CppClass<Cloud.CloudSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string rootDir = GetRootDir();
				if (rootDir != null)
				{
					nint num3 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v30 (Il2CppClass<Flurry>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num4 = (nint)typeof(Flurry);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v58 (Il2CppClass<Flurry>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					nint num5 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v35 (Il2CppClass<Cloud.CloudSave>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num6 = (nint)typeof(CloudSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v52 (Il2CppClass<Cloud.CloudSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint method_ptr = 0;
					CloudWorkingCopy.CompleteHandler completeHandler = default;
					((Delegate)completeHandler).method_ptr = method_ptr;
					((Delegate)completeHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass44_0._003CCommitAsync_003Eb__0);
					object obj6 = completeHandler + 16;
					object obj7 = default;
					obj6 = obj7;
					object obj8 = this + 12;
					Coroutine coroutine = _workingCopy.UpdateMetadataAsync(completeHandler);
					obj8 = coroutine;
					_003C_003E1__state = 1;
					return 1;
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public unsafe _003CCommitAsync_003Ed__44(int _003C_003E1__state)
		{
			//IL_0380: Unknown result type (might be due to invalid IL or missing references)
			//IL_0385: Expected Obj, but got Unknown
			//IL_038e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0393: Expected Obj, but got Unknown
			//IL_01c6: Expected I, but got Obj
			//IL_01dc: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_025d: Expected I, but got Obj
			//IL_0273: Expected Obj, but got I
			//IL_0207: Expected I, but got Obj
			//IL_040e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0413: Expected Obj, but got Unknown
			//IL_041b: Expected Obj, but got VT
			//IL_0424: Unknown result type (might be due to invalid IL or missing references)
			//IL_0429: Expected Obj, but got Unknown
			//IL_0433: Expected Obj, but got I4
			//IL_043c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0441: Expected VT, but got Unknown
			//IL_044e: Expected I8, but got Obj
			//IL_0449: Expected native int or pointer, but got VT
			//IL_0463: Expected Ref, but got VT
			//IL_0475: Expected I, but got Obj
			//IL_048b: Expected Obj, but got I
			//IL_0138: Expected I, but got Obj
			//IL_014e: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			//IL_04b0: Expected Obj, but got I8
			//IL_04d3: Expected I, but got Obj
			//IL_04e9: Expected Obj, but got I
			//IL_029e: Expected I, but got Obj
			//IL_03e4: Expected Obj, but got VT
			//IL_00a1: Expected I, but got Obj
			//IL_00b7: Expected Obj, but got I
			//IL_02eb: Expected I, but got Obj
			//IL_0179: Expected I, but got Obj
			//IL_0338: Expected I, but got Obj
			//IL_00e2: Expected I, but got Obj
			object obj = default;
			IFormatProvider formatProvider = (IFormatProvider)(obj + 40);
			object obj2 = obj + 24;
			if (_003C_003E1__state != 0)
			{
				nint num = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v70 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v101 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UserSave.hasCloudSaveCelebrationBeenShown)
				{
					nint num3 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v92 (Il2CppClass<Cloud.CloudSave>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num4 = (nint)typeof(CloudSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v97 (Il2CppClass<Cloud.CloudSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Auth.DeleteKilooAuthDebug();
				}
				DateTime today = CDateTime.Today;
				nint num5 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v80 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num6 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v87 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = today;
				formatProvider = (IFormatProvider)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9385");
			}
			else
			{
				nint num7 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v60 (Il2CppClass<Cloud.CloudSave>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num8 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v65 (Il2CppClass<Cloud.CloudSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				EnableAndInitIfNeeded();
			}
			DateTime today2 = CDateTime.Today;
			nint num9 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v19 (Il2CppClass<System.DateTime>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num10 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v55 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj8 = obj + 16;
			obj8 = today2;
			object obj9 = obj + 8;
			obj9 = this._003C_003E1__state;
			DateTime dateTime = (DateTime)(obj + 32);
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj8;
			formatProvider = (IFormatProvider)obj9;
			long num11 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
			nint num12 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v33 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num13 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v51 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = num11;
			formatProvider = (IFormatProvider)obj;
			CloudSaveConflictResolver.Recommendation recommendation = ((CloudSaveConflictResolver)formatProvider).recommendation;
			nint num14 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v42 (Il2CppClass<Flurry>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num15 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v47 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
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

	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public bool wait;

		public DateTime startTime;

		public bool hadConflict;

		public _003C_003Ec__DisplayClass47_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CUpdate_Routine_003Eb__0(ICloudConflict[] conflicts)
		{
			//IL_000a: Expected I4, but got Obj
			wait = (byte)(int)conflicts != 0;
		}

		internal unsafe void _003CUpdate_Routine_003Eb__1(bool updateSuccess)
		{
			//IL_044e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0453: Expected Obj, but got Unknown
			//IL_045c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0461: Expected VT, but got Unknown
			//IL_046a: Unknown result type (might be due to invalid IL or missing references)
			//IL_046f: Expected Obj, but got Unknown
			//IL_0478: Unknown result type (might be due to invalid IL or missing references)
			//IL_047d: Expected Obj, but got Unknown
			//IL_048b: Expected Obj, but got I4
			//IL_0499: Expected Obj, but got I4
			//IL_0509: Expected I, but got Obj
			//IL_051f: Expected Obj, but got I
			//IL_053c: Expected I, but got Obj
			//IL_05a4: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_032b: Expected I, but got Obj
			//IL_0341: Expected Obj, but got I
			//IL_0220: Expected I, but got Obj
			//IL_0250: Expected I, but got Obj
			//IL_05f9: Expected Obj, but got VT
			//IL_0603: Expected Obj, but got VT
			//IL_0610: Expected I8, but got Obj
			//IL_060b: Expected native int or pointer, but got VT
			//IL_0625: Expected Ref, but got VT
			//IL_0637: Expected I, but got Obj
			//IL_064d: Expected Obj, but got I
			//IL_0289: Expected I, but got Obj
			//IL_029f: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			//IL_0672: Expected Obj, but got I8
			//IL_0695: Expected I, but got Obj
			//IL_06ab: Expected Obj, but got I
			//IL_036c: Expected I, but got Obj
			//IL_0276: Expected I, but got Obj
			//IL_03b9: Expected I, but got Obj
			//IL_02ca: Expected I, but got Obj
			//IL_00c0: Expected Obj, but got I4
			//IL_0406: Expected I, but got Obj
			object obj = default;
			IFormatProvider formatProvider = (IFormatProvider)(obj + 32);
			DateTime dateTime = (DateTime)(obj + 24);
			object obj2 = obj + 16;
			object obj3 = obj + 8;
			object obj4 = (updateSuccess ? 1 : 0) + 16;
			object obj5 = (updateSuccess ? 1 : 0) + 12;
			bool flag = (nint)obj5 >= 2;
			bool flag2 = !flag;
			ICloudUserData data = (ICloudUserData)obj4;
			if (!flag2)
			{
				nint num = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v103 (Il2CppClass<Cloud.CloudSave>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num2 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v133 (Il2CppClass<Cloud.CloudSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((CloudSaveConflictResolver)(object)"Multiple conflicts. This should NOT happen.")._002Ector((ICloudConflict)null);
				data = (ICloudUserData)obj4;
				object obj7 = default;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
				{
					object obj8 = (updateSuccess ? 1 : 0) + 16;
					object obj9 = obj7 << 2;
					object obj10 = obj8 + obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					string a = default;
					if (string.Equals(a, "cloud"))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
					}
					else
					{
						data = (ICloudUserData)obj10;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					formatProvider = (IFormatProvider)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					throw new ArrayTypeMismatchException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			UserData userData = default;
			userData._002Ector(data);
			nint num3 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v28 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			bool flag3 = obj11 == null;
			nint num4 = (nint)typeof(CloudSave);
			if (!flag3)
			{
				nint num5 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v96 (Il2CppClass<Cloud.CloudSave>)+74]");
				bool flag4 = (nint)0 == 0;
				bool flag5 = !flag4;
				num4 = (nint)typeof(CloudSave);
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(CloudSave);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ L1_v2 (Il2CppClass<Cloud.CloudSave>)+5C]");
			object obj12 = (nint)0 + (nint)24;
			obj12 = userData;
			string sourceMine = _conflictResolver.sourceMine;
			if (sourceMine == null)
			{
				nint num6 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v87 (Il2CppClass<Cloud.CloudSave>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num7 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v92 (Il2CppClass<Cloud.CloudSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				errorState = (CloudSaveErrorState)3;
			}
			wait = false;
			DateTime today = CDateTime.Today;
			nint num8 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v48 (Il2CppClass<System.DateTime>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num9 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v82 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = today;
			obj3 = startTime;
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj2;
			formatProvider = (IFormatProvider)obj3;
			long num10 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
			nint num11 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v59 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num12 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v78 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = num10;
			formatProvider = (IFormatProvider)obj;
			CloudSaveConflictResolver.Recommendation recommendation = ((CloudSaveConflictResolver)formatProvider).recommendation;
			nint num13 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v68 (Il2CppClass<Flurry>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num14 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v74 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			hadConflict = true;
		}
	}

	private sealed class _003CUpdate_Routine_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private _003C_003Ec__DisplayClass47_0 _003C_003E8__1;

		public Action onFinished;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_044e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0453: Expected Obj, but got Unknown
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0071: Expected Obj, but got VT
				//IL_0086: Expected VT, but got Obj
				//IL_0094: Expected I, but got Obj
				//IL_00aa: Expected Obj, but got I
				//IL_00d5: Expected I, but got Obj
				//IL_0122: Expected I, but got Obj
				//IL_0138: Expected Obj, but got I
				//IL_0409: Unknown result type (might be due to invalid IL or missing references)
				//IL_040e: Expected Obj, but got Unknown
				//IL_0417: Expected Obj, but got I4
				//IL_042b: Expected Obj, but got I4
				//IL_0163: Expected I, but got Obj
				//IL_01b0: Expected I, but got Obj
				//IL_01c6: Expected Obj, but got I
				//IL_01f1: Expected I, but got Obj
				//IL_02b7: Expected I, but got Obj
				//IL_02cd: Expected Obj, but got I
				//IL_050c: Expected I, but got Obj
				//IL_0522: Expected Obj, but got I
				//IL_053f: Expected I, but got Obj
				//IL_0563: Expected Obj, but got I
				//IL_056c: Expected Obj, but got I4
				//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_05d6: Expected Obj, but got Unknown
				//IL_0615: Unknown result type (might be due to invalid IL or missing references)
				//IL_061a: Expected Obj, but got Unknown
				//IL_02f8: Expected I, but got Obj
				//IL_0345: Expected I, but got Obj
				//IL_0375: Expected I, but got Obj
				//IL_039b: Expected I, but got Obj
				object obj2 = default;
				object obj = obj2 + 8;
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
					object obj3 = this + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj4 = default;
					obj3 = obj4;
					_003C_003Ec__DisplayClass47_0 obj5 = _003C_003E8__1;
					DateTime today = CDateTime.Today;
					obj2 = today;
					obj = obj2;
					obj5.startTime = (DateTime)obj;
					nint num = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v30 (Il2CppClass<Cloud.CloudSave>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num2 = (nint)typeof(CloudSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v110 (Il2CppClass<Cloud.CloudSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!useSimulatedServer)
					{
						return null;
					}
					nint num3 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v39 (Il2CppClass<Cloud.CloudSave>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num4 = (nint)typeof(CloudSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v106 (Il2CppClass<Cloud.CloudSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78ED");
					object obj8 = default;
					if (obj8 == null)
					{
						return null;
					}
					nint num5 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v48 (Il2CppClass<Cloud.CloudSave>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num6 = (nint)typeof(CloudSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v100 (Il2CppClass<Cloud.CloudSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					CloudWorkingCopy workingCopy = _workingCopy;
					if (~(workingCopy._isUpdating ? 1u : 0u) == 0 || ~(workingCopy._isCommitting ? 1u : 0u) == 0 || ~(workingCopy._isMetadataUpdating ? 1u : 0u) == 0 || workingCopy._isSynchronizing)
					{
						return null;
					}
					nint num7 = (nint)typeof(SaveManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v58 (Il2CppClass<Data.Save.SaveManager>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num8 = (nint)typeof(SaveManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v86 (Il2CppClass<Data.Save.SaveManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					SaveManager.Load();
					nint num9 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v64 (Il2CppClass<Cloud.CloudSave>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					bool flag = obj11 == null;
					nint num10 = (nint)typeof(CloudSave);
					if (!flag)
					{
						nint num11 = (nint)typeof(CloudSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v80 (Il2CppClass<Cloud.CloudSave>)+74]");
						bool flag2 = (nint)0 == 0;
						bool flag3 = !flag2;
						num10 = (nint)typeof(CloudSave);
						if (!flag3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							num10 = (nint)typeof(CloudSave);
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ L1_v12 (Il2CppClass<Cloud.CloudSave>)+5C]");
					object obj12 = (nint)0 + (nint)24;
					obj12 = 0;
					_003C_003Ec__DisplayClass47_0 obj13 = _003C_003E8__1;
					obj13.wait = true;
					_003C_003Ec__DisplayClass47_0 obj14 = _003C_003E8__1;
					obj14.hadConflict = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint method_ptr = 0;
					CloudConflictResolver cloudConflictResolver = default;
					((Delegate)cloudConflictResolver).method_ptr = method_ptr;
					((Delegate)cloudConflictResolver).method = (nint)__ldftn(_003C_003Ec__DisplayClass47_0._003CUpdate_Routine_003Eb__0);
					object obj15 = cloudConflictResolver + 16;
					obj15 = _003C_003E8__1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint method_ptr2 = 0;
					CloudWorkingCopy.SynchronizeCompleteHandler synchronizeCompleteHandler = default;
					((Delegate)synchronizeCompleteHandler).method_ptr = method_ptr2;
					((Delegate)synchronizeCompleteHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass47_0._003CUpdate_Routine_003Eb__1);
					object obj16 = synchronizeCompleteHandler + 16;
					obj16 = _003C_003E8__1;
					Coroutine coroutine = _workingCopy.SynchronizeAsync(cloudConflictResolver, synchronizeCompleteHandler);
				}
				_003C_003Ec__DisplayClass47_0 obj17 = _003C_003E8__1;
				if (~(obj17.wait ? 1u : 0u) == 0)
				{
					object obj18 = this + 12;
					obj18 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				TransformExtensions.Reset((Transform)(object)onFinished);
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public unsafe _003CUpdate_Routine_003Ed__47(int _003C_003E1__state)
		{
			//IL_02fc: Expected I, but got Obj
			//IL_0312: Expected Obj, but got I
			//IL_032f: Expected I, but got Obj
			//IL_0460: Expected Obj, but got I
			//IL_0469: Expected Obj, but got I4
			//IL_0482: Expected I, but got Obj
			//IL_0498: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0043: Expected I, but got Obj
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Expected Obj, but got Unknown
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Expected VT, but got Unknown
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Expected Obj, but got Unknown
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Expected Obj, but got Unknown
			//IL_0116: Expected I, but got Obj
			//IL_0354: Expected Obj, but got I4
			//IL_0069: Expected I, but got Obj
			//IL_00a0: Expected I, but got Obj
			//IL_01d4: Expected I, but got Obj
			//IL_01ea: Expected Obj, but got I
			//IL_0370: Expected Obj, but got VT
			//IL_0387: Expected I8, but got Obj
			//IL_0382: Expected native int or pointer, but got VT
			//IL_039c: Expected Ref, but got VT
			//IL_03ae: Expected I, but got Obj
			//IL_03c4: Expected Obj, but got I
			//IL_03e9: Expected Obj, but got I8
			//IL_040c: Expected I, but got Obj
			//IL_0422: Expected Obj, but got I
			//IL_0215: Expected I, but got Obj
			//IL_0262: Expected I, but got Obj
			//IL_02af: Expected I, but got Obj
			nint num = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			bool flag = obj == null;
			nint num2 = (nint)typeof(CloudSave);
			if (!flag)
			{
				nint num3 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v98 (Il2CppClass<Cloud.CloudSave>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num2 = (nint)typeof(CloudSave);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num2 = (nint)typeof(CloudSave);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ L2_v2 (Il2CppClass<Cloud.CloudSave>)+5C]");
			object obj2 = (nint)0 + (nint)24;
			obj2 = 0;
			this._003C_003E1__state = 0;
			nint num4 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v18 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag4 = obj3 == null;
			if (_003C_003E1__state != 0)
			{
				if (!flag4)
				{
					nint num5 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v94 (Il2CppClass<Cloud.CloudSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Auth.DeleteKilooAuthDebug();
				bool flag5 = PrepareCommit();
				Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])flag5);
			}
			else
			{
				if (!flag4)
				{
					nint num6 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v83 (Il2CppClass<Cloud.CloudSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				EnableAndInitIfNeeded();
			}
			object obj4 = default;
			IFormatProvider formatProvider = (IFormatProvider)(obj4 + 32);
			DateTime dateTime = (DateTime)(obj4 + 24);
			object obj5 = obj4 + 16;
			object obj6 = obj4 + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Cloud.CloudSave+<Update_Routine>d__47)+18]");
			if ((nint)0 != 0)
			{
				return;
			}
			DateTime today = CDateTime.Today;
			nint num7 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v42 (Il2CppClass<System.DateTime>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v75 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj5 = today;
			obj6 = _003C_003E8__1;
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
			formatProvider = (IFormatProvider)obj6;
			long num9 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
			nint num10 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v53 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num11 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v71 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj4 = num9;
			formatProvider = (IFormatProvider)obj4;
			CloudSaveConflictResolver.Recommendation recommendation = ((CloudSaveConflictResolver)formatProvider).recommendation;
			nint num12 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v62 (Il2CppClass<Flurry>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num13 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v67 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_ = 0;
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

	private const string DEFAULT_CLOUD_BASE_URL = "https://cloudsave2-subwaysurfers.kiloo-games.com/";

	private const string ONLINESETTINGS_CLOUD_URL_KEY = "cloudsave_url";

	private const int DEFAULT_DATA_VERSION = 0;

	private const bool USE_SIMULATED_SERVER_IN_EDITOR = true;

	private const string CLOUD_SAVE_AVAILABLE_KEY = "cloudsave_enabled";

	private const bool CLOUD_SAVE_AVAILABLE_DEFAULT = false;

	private static Action m_stateChanged;

	private static int _dataVersion;

	private static CloudSaveState _state;

	private static CloudSaveErrorState _errorState;

	private static ICloudServer _cloudServer;

	private static CloudWorkingCopy _workingCopy;

	private static CloudSaveConflictResolver _conflictResolver;

	private static KilooSerializer _serializer;

	private static IFileSaver _fileSaver;

	private static IInstallationInfo _installationInfo;

	private static bool _allowReinitAfterMismatch;

	private static bool _mayQueueCelebration;

	private static bool isAvailable__BackingField;

	public static CloudSaveState state
	{
		get
		{
			//IL_0198: Expected I, but got Obj
			//IL_01ae: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_0210: Expected Obj, but got I4
			//IL_012f: Expected I, but got Obj
			nint num = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SaveGameDebug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v41 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string tmpCloudPath = SaveGameDebug.tmpCloudPath;
			if (File.GetAttributes(tmpCloudPath) != 0)
			{
				nint num3 = (nint)typeof(SaveGameDebug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v16 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(SaveGameDebug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v37 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string tmpLocalPath = SaveGameDebug.tmpLocalPath;
				if (File.GetAttributes(tmpLocalPath) != 0)
				{
					nint num5 = (nint)typeof(SaveGameDebug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v26 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(SaveGameDebug);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v33 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = SaveGameDebug.FilesExist();
					return (CloudSaveState)File.GetAttributes((string)flag);
				}
				return CloudSaveState.Disabled;
			}
			return CloudSaveState.Disabled;
		}
		private set
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_0132: Expected Obj, but got I4
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = CloudSave.m_stateChanged;
			Action action = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Cloud.CloudSave>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<Cloud.CloudSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)CloudSave.m_stateChanged == obj2)
				{
					CloudSave.m_stateChanged = action;
				}
				if ((object)CloudSave.m_stateChanged != obj2)
				{
					obj2 = CloudSave.m_stateChanged;
					continue;
				}
				break;
			}
		}
	}

	public static CloudSaveErrorState errorState
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (CloudSaveErrorState)_state;
		}
		private set
		{
			//IL_00ef: Expected I, but got Obj
			//IL_0105: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_state == (CloudSaveState)value)
			{
				return;
			}
			nint num3 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v26 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_state = (CloudSaveState)value;
			TransformExtensions.Reset((Transform)(object)CloudSave.m_stateChanged);
		}
	}

	public static CloudSaveConflictResolver conflictResolver
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (CloudSaveConflictResolver)_errorState;
		}
	}

	private static bool isInitialized
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)(int)_conflictResolver != 0;
		}
	}

	public static bool useSimulatedServer
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return _workingCopy != null;
		}
	}

	public static string userName => null;

	public static bool isAvailable
	{
		get
		{
			//IL_01a8: Expected I, but got Obj
			//IL_01be: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0115: Expected I, but got Obj
			//IL_012b: Expected Obj, but got I
			//IL_0220: Expected I4, but got Obj
			//IL_0087: Expected I, but got Obj
			//IL_009d: Expected Obj, but got I
			//IL_0156: Expected I, but got Obj
			//IL_020a: Expected I4, but got Obj
			//IL_00c8: Expected I, but got Obj
			nint num = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Authentication.Auth>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v41 (Il2CppClass<Authentication.Auth>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Coroutine coroutine = Auth.Init();
			if (coroutine == null || coroutine.m_Ptr == (IntPtr)0)
			{
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v26 (Il2CppClass<Strings>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v33 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = Strings.GetDefault("PLAYER_GENERIC_NAME");
				return (byte)(int)text != 0;
			}
			nint num5 = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v15 (Il2CppClass<Authentication.Auth>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v21 (Il2CppClass<Authentication.Auth>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Coroutine coroutine2 = Auth.Init();
			return (byte)(int)coroutine2 != 0;
		}
		private set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_errorState = (value ? CloudSaveErrorState.Unauthenticated : CloudSaveErrorState.Offline);
		}
	}

	public static event Action stateChanged
	{
		add
		{
		}
		remove
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = CloudSave.m_stateChanged;
			Action action = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Cloud.CloudSave>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<Cloud.CloudSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)CloudSave.m_stateChanged == obj2)
				{
					CloudSave.m_stateChanged = action;
				}
				if ((object)CloudSave.m_stateChanged != obj2)
				{
					obj2 = CloudSave.m_stateChanged;
					continue;
				}
				break;
			}
		}
	}

	static CloudSave()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public static IEnumerator LoginAsync(Action onUpdateFinished = null)
	{
		//IL_01d7: Expected I, but got Obj
		//IL_01ed: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_023d: Expected I, but got Obj
		//IL_0253: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_018a: Expected I, but got Obj
		//IL_0287: Expected I, but got Obj
		//IL_029d: Expected Obj, but got I
		//IL_02a5: Expected Obj, but got I4
		//IL_013d: Expected I, but got Obj
		nint num = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v64 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag;
		if (CharacterManager._characterList != null)
		{
			nint num3 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v47 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v58 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<KeyValuePair<Characters.CharacterId, Characters.Model>> characterList = CharacterManager._characterList;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v55 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<SYBO.Subway.Info.Characters+CharacterId, SYBO.Subway.Info.Characters+Model>>)+C]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		object obj3 = onUpdateFinished & 1;
		object obj4 = flag | obj3;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v31 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v41 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = FacebookWeeklyGiftManager.IsGiftAvailable();
			nint num7 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v38 (Il2CppClass<Data.Managers.CharacterManager>)+5C]");
			object obj6 = (nint)0 + (nint)4;
			obj6 = flag2;
		}
		nint num8 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v17 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num9 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v24 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (IEnumerator)CharacterManager._characterList;
	}

	public unsafe static void Init()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
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
		bool flag = ((OnlineSettings)(object)saveDataPath).TryGetValue("cloudsave_enabled", out *(string*)null);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8BE7");
	}

	private static int GetDataVersion()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return isAvailable__BackingField ? 1 : 0;
	}

	private static ICloudServer CreateServer(string url, IKilooAuth kilooAuth, IBsonSerializer serializer)
	{
		//IL_02a0: Expected Obj, but got I4
		//IL_00e8: Expected I, but got Obj
		//IL_00fe: Expected Obj, but got I
		//IL_02c6: Expected I4, but got Obj
		//IL_02d8: Expected I, but got Obj
		//IL_02ee: Expected Obj, but got I
		//IL_0129: Expected I, but got Obj
		//IL_036e: Expected I4, but got Obj
		//IL_0268: Expected Obj, but got I4
		//IL_020b: Expected I, but got Obj
		//IL_0323: Expected I4, but got Obj
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected I4, but got Unknown
		//IL_025a: Expected Obj, but got I
		//IL_033e: Expected Obj, but got I4
		//IL_019a: Expected I, but got Obj
		//IL_0288: Expected Obj, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		object obj = 0;
		int num2 = default;
		int num3 = default;
		while (true)
		{
			Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> boardThemeData = InventorySave.boardThemeData;
			int num = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8 (System.Collections.Generic.Dictionary`2<Info.Boards+BoardId, System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, Info.BoardThemeData>>)+C]");
			if ((nint)num >= (nint)0)
			{
				break;
			}
			Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> boardThemeData2 = InventorySave.boardThemeData;
			CelebrationReward celebrationReward = ((List<CelebrationReward>)(object)boardThemeData2).get_Item(num2);
			if (celebrationReward.rewardType == CelebrationRewardType.token)
			{
				Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> boardThemeData3 = InventorySave.boardThemeData;
				CelebrationReward celebrationReward2 = ((List<CelebrationReward>)(object)boardThemeData3).get_Item(num2);
				if ((nint)celebrationReward2.characterId == (nint)url)
				{
					Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> boardThemeData4 = InventorySave.boardThemeData;
					CelebrationReward celebrationReward3 = ((List<CelebrationReward>)(object)boardThemeData4).get_Item(num2);
					object obj2 = celebrationReward3.amount + obj;
					obj = obj2;
				}
			}
			num2 = num3 + 1;
		}
		nint num4 = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v35 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item((Characters.CharacterId)url);
		nint num6 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v24 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		bool flag = obj4 == null;
		int num8;
		if (serializer != null)
		{
			if (!flag)
			{
				nint num7 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v33 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			num8 = CharacterManager.GetOutfitIndex((Characters.CharacterId)url);
		}
		else
		{
			if (!flag)
			{
				nint num9 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v24 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int outfitIndex = CharacterManager.GetOutfitIndex((Characters.CharacterId)url);
			object obj5;
			if (kilooAuth != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [kilooAuth @ L1 (Kiloo.Common.Backend.Authentication.IKilooAuth)+14]");
				obj5 = 0;
			}
			else
			{
				obj5 = 0;
			}
			num8 = obj5 + outfitIndex;
		}
		object obj6 = model.Price - num8;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			bool flag2 = num8 < model.Price;
			return (ICloudServer)flag2;
		}
		return null;
	}

	public unsafe static void Commit()
	{
		//IL_09da: Expected I, but got Obj
		//IL_09f0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0a24: Expected I, but got Obj
		//IL_0a3a: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0248: Expected I, but got Obj
		//IL_025e: Expected Obj, but got I
		//IL_016d: Expected I, but got Obj
		//IL_0ad1: Expected I, but got Obj
		//IL_0ae7: Expected Obj, but got I
		//IL_01ba: Expected I, but got Obj
		//IL_01d0: Expected Obj, but got I
		//IL_0107: Expected I, but got Obj
		//IL_0289: Expected I, but got Obj
		//IL_01fb: Expected I, but got Obj
		//IL_0e51: Expected I, but got Obj
		//IL_0e67: Expected Obj, but got I
		//IL_0355: Expected I, but got Obj
		//IL_02ef: Expected I, but got Obj
		//IL_0e92: Expected I, but got Obj
		//IL_0ea8: Expected Obj, but got I
		//IL_0473: Expected I, but got Obj
		//IL_03bb: Expected I, but got Obj
		//IL_03d1: Expected Obj, but got I
		//IL_03ee: Expected I, but got Obj
		//IL_04c0: Expected I, but got Obj
		//IL_04d6: Expected Obj, but got I
		//IL_0b7f: Expected Obj, but got I
		//IL_0ed3: Expected I, but got Obj
		//IL_0ee9: Expected Obj, but got I
		//IL_05e8: Expected I, but got Obj
		//IL_0ba8: Expected I4, but got Obj
		//IL_0bba: Expected I, but got Obj
		//IL_0bd0: Expected Obj, but got I
		//IL_040a: Expected I, but got Obj
		//IL_043a: Expected I, but got Obj
		//IL_0635: Expected I, but got Obj
		//IL_064b: Expected Obj, but got I
		//IL_0c04: Expected I, but got Obj
		//IL_0c1a: Expected Obj, but got I
		//IL_0501: Expected I, but got Obj
		//IL_0f14: Expected I, but got Obj
		//IL_0f2a: Expected Obj, but got I
		//IL_06c3: Expected I, but got Obj
		//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbf: Expected Obj, but got Unknown
		//IL_0cd6: Expected I, but got Obj
		//IL_0cec: Expected Obj, but got I
		//IL_0c49: Expected I4, but got Obj
		//IL_0c49: Expected Obj, but got I4
		//IL_0c5b: Expected I, but got Obj
		//IL_0c71: Expected Obj, but got I
		//IL_054e: Expected I, but got Obj
		//IL_0460: Expected I, but got Obj
		//IL_0d86: Expected I4, but got Obj
		//IL_0710: Expected I, but got Obj
		//IL_0726: Expected Obj, but got I
		//IL_0676: Expected I, but got Obj
		//IL_059b: Expected I, but got Obj
		//IL_07d3: Expected I4, but got Obj
		//IL_07d3: Expected Obj, but got I4
		//IL_0784: Expected I, but got Obj
		//IL_0d35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3a: Expected Obj, but got Unknown
		//IL_0d51: Expected I, but got Obj
		//IL_0d67: Expected Obj, but got I
		//IL_07e6: Expected I, but got Obj
		//IL_07fc: Expected Obj, but got I
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected Obj, but got Unknown
		//IL_0833: Expected Obj, but got I4
		//IL_0751: Expected I, but got Obj
		//IL_0854: Expected I, but got Obj
		//IL_086a: Expected Obj, but got I
		//IL_0895: Expected I, but got Obj
		//IL_0966: Expected I, but got Obj
		//IL_097c: Expected Obj, but got I
		//IL_0e17: Expected Obj, but got I4
		//IL_08f2: Expected I, but got Obj
		//IL_0908: Expected Obj, but got I
		//IL_09a7: Expected I, but got Obj
		//IL_0e08: Expected I, but got Obj
		//IL_0933: Expected I, but got Obj
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v296 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78FB");
		object obj2 = default;
		if (obj2 == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v292 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool hasCloudSaveCelebrationBeenShown = UserSave.hasCloudSaveCelebrationBeenShown;
		nint num5 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		bool flag = obj4 != null;
		if (!hasCloudSaveCelebrationBeenShown)
		{
			if (flag)
			{
				nint num6 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v288 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			errorState = CloudSaveErrorState.Offline;
			return;
		}
		if (flag)
		{
			nint num7 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v281 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (useSimulatedServer)
		{
			nint num8 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v267 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num9 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v275 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(_allowReinitAfterMismatch ? 1u : 0u) != 0)
			{
				return;
			}
		}
		nint num10 = (nint)typeof(Auth);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v27 (Il2CppClass<Authentication.Auth>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num11 = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v262 (Il2CppClass<Authentication.Auth>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isLoggedIn = Auth.isLoggedIn;
		nint num12 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v13 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		bool flag2 = obj7 != null;
		if (!isLoggedIn)
		{
			if (flag2)
			{
				nint num13 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v258 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			errorState = CloudSaveErrorState.GameOutdated;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8BEA");
			return;
		}
		if (flag2)
		{
			nint num14 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v248 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_allowReinitAfterMismatch = false;
		if (_serializer == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = default;
			FlurryVideoAds.LogError(text, (UnityEngine.Object)null);
			nint num15 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v235 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			bool flag3 = obj8 == null;
			nint num16 = (nint)typeof(CloudSave);
			if (!flag3)
			{
				nint num17 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v242 (Il2CppClass<Cloud.CloudSave>)+74]");
				bool flag4 = (nint)0 == 0;
				bool flag5 = !flag4;
				num16 = (nint)typeof(CloudSave);
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num16 = (nint)typeof(CloudSave);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ L0_v47 (Il2CppClass<Cloud.CloudSave>)+5C]");
			object obj9 = (nint)0 + (nint)28;
			obj9 = text;
		}
		nint num18 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v45 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num19 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v225 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_cloudServer == null)
		{
			nint num20 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v209 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num21 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v221 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			bool value = ((OnlineSettings)(object)saveDataPath).GetValue("cloudsave_url", (byte)(int)"https://cloudsave2-subwaysurfers.kiloo-games.com/" != 0);
			nint num22 = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S1_v63 (Il2CppClass<Authentication.Auth>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num23 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S1_v71 (Il2CppClass<Authentication.Auth>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string displayName = Auth.displayName;
			nint num24 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ S2_v27 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num25 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S2_v34 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IDictionary dictionary = BsonBinaryReaderExtensions.ReadBsonObject((BinaryReader)value, (byte)(int)displayName != 0, ref *(int*)_serializer);
			nint num26 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ S0_v218 (Il2CppClass<Cloud.CloudSave>)+5C]");
			object obj14 = (nint)0 + (nint)16;
			obj14 = dictionary;
		}
		nint num27 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v55 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num28 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v202 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_fileSaver == null)
		{
			nint num29 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v181 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num30 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S0_v196 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj18 = default;
			object obj17 = obj18 + 8;
			obj17 = _serializer;
			nint num31 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S0_v193 (Il2CppClass<Cloud.CloudSave>)+5C]");
			object obj19 = (nint)0 + (nint)32;
			obj19 = obj18;
		}
		nint num32 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S0_v65 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num33 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S0_v174 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_installationInfo == null)
		{
			nint num34 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S0_v154 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num35 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S0_v169 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj23 = default;
			object obj22 = obj23 + 8;
			obj22 = _fileSaver;
			nint num36 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S0_v166 (Il2CppClass<Cloud.CloudSave>)+5C]");
			object obj24 = (nint)0 + (nint)36;
			obj24 = obj23;
		}
		nint num37 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S0_v75 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num38 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S0_v150 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IEnumerator enumerator = CommitAsync();
		_dataVersion = (int)enumerator;
		string filePath = GetFilePath();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KilooAuth kilooAuth = default;
		IKilooAuthPlatform[] platforms = default;
		kilooAuth._002Ector((Uri)_dataVersion, filePath, (byte)(int)_cloudServer != 0, (IJsonSerializer)_fileSaver, platforms);
		nint num39 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ S0_v104 (Il2CppClass<Cloud.CloudSave>)+5C]");
		object obj26 = (nint)0 + (nint)20;
		obj26 = kilooAuth;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num40 = 0;
		_ = 0;
		EventHandler<CloudItemUpdatedArgs> eventHandler = default;
		object obj27 = eventHandler + 16;
		obj27 = 0;
		_workingCopy.itemUpdated -= eventHandler;
		nint num41 = (nint)typeof(Auth);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ S0_v112 (Il2CppClass<Authentication.Auth>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num42 = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ S0_v147 (Il2CppClass<Authentication.Auth>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag6;
		if (Auth.isInitialized)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S0_v117 (System.Boolean)+8]");
			flag6 = (nint)0 == 0;
		}
		else
		{
			flag6 = true;
		}
		if (!flag6)
		{
			nint num43 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ S0_v131 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			if (obj29 != null)
			{
				nint num44 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ S0_v138 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ICloudUserData cloudUserData = MakeUserData();
			ICloudUserData cloudUserData2 = DEBUG_MakeUserData();
			((CloudConflictResolver)(object)_workingCopy)._002Ector((object)cloudUserData, (IntPtr)cloudUserData2);
		}
		nint num45 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ S0_v122 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num46 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ S0_v127 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((CloudSaveConflictResolver)1).RefreshLocalUserData();
	}

	private static IEnumerator CommitAsync()
	{
		//IL_0347: Expected I, but got Obj
		//IL_035d: Expected Obj, but got I
		//IL_03de: Expected Obj, but got I4
		//IL_03e7: Expected Obj, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00b7: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_0192: Expected Obj, but got I4
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_01cd: Expected I, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_020e: Expected I, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v75 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num3 = default;
		object obj2 = num3 + 16;
		obj2 = 46;
		string text = bundleIdentifier.Substring(num3);
		object obj3 = text + 12;
		if ((nint)obj3 == 3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num4 = 0;
			_ = 0;
			_0021_00210 val = default;
			object obj4 = val + 16;
			obj4 = 0;
			bool flag = Kiloo.Common.Extensions.CollectionExtensions.AddDistinct<T>((IList<T>)(object)text, (T)val);
			object obj5 = (flag ? 1 : 0) + 12;
			object obj6 = 0;
			while (true)
			{
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
				{
					object obj7 = (flag ? 1 : 0) + 16;
					object obj8 = obj6 << 2;
					object obj9 = obj7 + obj8;
					if ((nint)obj9 < 1000)
					{
						object obj10 = obj6 + 1;
						obj6 = obj10;
						continue;
					}
					break;
				}
				object obj11 = (flag ? 1 : 0) + 24;
				object obj12 = (flag ? 1 : 0) + 20;
				object obj13 = obj12 * 1000;
				object obj14 = (flag ? 1 : 0) + 16;
				object obj15 = obj14 * 1000000;
				object obj16 = obj13 + obj15;
				return (IEnumerator)(object)(obj11 + obj16);
			}
			nint num5 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v63 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num6 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v69 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((CloudSaveConflictResolver)(object)"Individual components of version code is higher larger than maximum allowed.")._002Ector((ICloudConflict)null);
			return null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj18 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}

	private static bool PrepareCommit()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool result = default;
		return result;
	}

	public static Coroutine UpdateAsync(Action onFinished = null)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Coroutine coroutine = default;
		coroutine.m_Ptr = (IntPtr)0;
		object obj = coroutine + 16;
		obj = onFinished;
		return coroutine;
	}

	private static IEnumerator Update_Routine(Action onFinished = null)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8BFC");
		YieldInstruction[] list = default;
		return (IEnumerator)(object)CoroutineUtil.WaitForAll(list);
	}

	private unsafe static string PutInSecondBucket(TimeSpan span)
	{
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_0042: Expected Obj, but got I4
		//IL_01a3: Invalid comparison between VT and I4
		//IL_0018: Expected native int or pointer, but got VT
		//IL_008b: Expected Obj, but got I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got VT
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected VT, but got Unknown
		//IL_01d3: Expected I, but got Obj
		//IL_01e9: Expected Obj, but got I
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected VT, but got Unknown
		//IL_0115: Expected I, but got Obj
		object obj = span + 2147483648L;
		if ((long)obj >= 4294967296L)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			System.ParamsArray paramsArray = default;
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)paramsArray, new System.ParamsArray("Part of OID doesn't fit in Int32"));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		TimeSpan timeSpan = span;
		object obj2 = 1;
		while (timeSpan >= (object)128)
		{
			TimeSpan timeSpan2 = (TimeSpan)(timeSpan >> 7);
			object obj3 = obj2 + 1;
			timeSpan = timeSpan2;
			obj2 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = 0;
		string text = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj5 = obj4 * 7;
			object obj6 = obj5 & 0x3F;
			object obj7 = span >> (int)obj6;
			TimeSpan timeSpan3 = (TimeSpan)(obj7 & 0x7F);
			bool flag = obj4 == null;
			TimeSpan ts = timeSpan3;
			if (!flag)
			{
				TimeSpan timeSpan4 = timeSpan3 + 128;
				ts = timeSpan4;
			}
			nint num = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v28 (Il2CppClass<System.Convert>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v37 (Il2CppClass<System.Convert>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj9 = obj2 - obj4;
			object obj10 = text + obj9;
			object obj11 = obj10 + 15;
			string text2 = PauseScreen.FormatTopRunTimeLeft(ts);
			obj11 = text2;
			object obj12 = obj4 + 1;
			obj4 = obj12;
		}
		return text;
	}

	private unsafe static void OnProccessUnsuccessful()
	{
		//IL_04b6: Expected I, but got Obj
		//IL_04cc: Expected Obj, but got I
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected VT, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected Obj, but got Unknown
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0564: Expected I, but got Obj
		//IL_057a: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_02ee: Expected I, but got Obj
		//IL_0304: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0385: Expected I, but got Obj
		//IL_039b: Expected Obj, but got I
		//IL_032f: Expected I, but got Obj
		//IL_05f4: Expected Obj, but got VT
		//IL_05fc: Expected Obj, but got VT
		//IL_0609: Expected I8, but got Obj
		//IL_0604: Expected native int or pointer, but got VT
		//IL_061e: Expected Ref, but got VT
		//IL_0630: Expected I, but got Obj
		//IL_0646: Expected Obj, but got I
		//IL_0260: Expected I, but got Obj
		//IL_0276: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_066b: Expected Obj, but got I8
		//IL_068e: Expected I, but got Obj
		//IL_06a4: Expected Obj, but got I
		//IL_03c6: Expected I, but got Obj
		//IL_05cb: Expected Obj, but got VT
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_0413: Expected I, but got Obj
		//IL_02a1: Expected I, but got Obj
		//IL_0460: Expected I, but got Obj
		//IL_020a: Expected I, but got Obj
		DateTime today = CDateTime.Today;
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v138 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 40);
		DateTime dateTime = (DateTime)(obj2 + 32);
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 16;
		object obj5 = obj2 + 8;
		string rootDir = GetRootDir();
		if (rootDir == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v30 (Il2CppClass<Flurry>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v134 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num5 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v35 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v128 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_workingCopy.UpdateMetadata())
		{
			nint num7 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v93 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num8 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v124 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UserSave.hasCloudSaveCelebrationBeenShown)
			{
				nint num9 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v115 (Il2CppClass<Cloud.CloudSave>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num10 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v120 (Il2CppClass<Cloud.CloudSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Auth.DeleteKilooAuthDebug();
			}
			DateTime today2 = CDateTime.Today;
			nint num11 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v103 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num12 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v110 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = today2;
			formatProvider = (IFormatProvider)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9385");
		}
		else
		{
			nint num13 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v83 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num14 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v88 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			EnableAndInitIfNeeded();
		}
		DateTime today3 = CDateTime.Today;
		nint num15 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v47 (Il2CppClass<System.DateTime>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num16 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v78 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj4 = today3;
		obj5 = today;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj4;
		formatProvider = (IFormatProvider)obj5;
		long num17 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		nint num18 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v58 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num19 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v74 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = num17;
		formatProvider = (IFormatProvider)obj2;
		CloudSaveConflictResolver.Recommendation recommendation = ((CloudSaveConflictResolver)formatProvider).recommendation;
		nint num20 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v67 (Il2CppClass<Flurry>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num21 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v70 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public static void EnableAndInitIfNeeded()
	{
		//IL_0589: Expected I, but got Obj
		//IL_059f: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_05ca: Expected I, but got Obj
		//IL_05e0: Expected Obj, but got I
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0638: Expected I, but got Obj
		//IL_064e: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_020a: Expected I, but got Obj
		//IL_06ae: Expected I, but got Obj
		//IL_06c4: Expected Obj, but got I
		//IL_02d6: Expected I, but got Obj
		//IL_0270: Expected I, but got Obj
		//IL_03a2: Expected I, but got Obj
		//IL_033c: Expected I, but got Obj
		//IL_046d: Expected I, but got Obj
		//IL_0483: Expected Obj, but got I
		//IL_04ae: Expected I, but got Obj
		//IL_04fb: Expected I, but got Obj
		//IL_0511: Expected Obj, but got I
		//IL_053c: Expected I, but got Obj
		nint num = (nint)typeof(Auth);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Authentication.Auth>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v140 (Il2CppClass<Authentication.Auth>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		KilooAuth kilooAuth = Auth.kilooAuth;
		if (kilooAuth == null)
		{
			nint num3 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v121 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v136 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num5 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v126 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v132 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			errorState = CloudSaveErrorState.GameOutdated;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8BEA");
			return;
		}
		nint num7 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v114 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_workingCopy == null)
		{
			return;
		}
		nint num9 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v22 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v108 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isAccountMismatch = _workingCopy.isAccountMismatch;
		nint num11 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v8 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		bool flag = obj6 != null;
		if (isAccountMismatch)
		{
			if (flag)
			{
				nint num12 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v104 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			errorState = CloudSaveErrorState.GameOutdated;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8BEA");
			return;
		}
		if (flag)
		{
			nint num13 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v94 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string kilooTag = _workingCopy.kilooTag;
		nint num14 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v14 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		bool flag2 = obj7 != null;
		if (kilooTag != null)
		{
			if (flag2)
			{
				nint num15 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v90 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SetStateOkAndQueueCelebrationIfNeeded();
			return;
		}
		if (flag2)
		{
			nint num16 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v81 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CloudWorkingCopy workingCopy = _workingCopy;
		if (~(workingCopy._isUpdating ? 1u : 0u) == 0 || ~(workingCopy._isCommitting ? 1u : 0u) == 0 || ~(workingCopy._isMetadataUpdating ? 1u : 0u) == 0 || workingCopy._isSynchronizing)
		{
			return;
		}
		nint num17 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v45 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num18 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v65 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_workingCopy.isIncompatible)
		{
			return;
		}
		nint num19 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v55 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num20 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v61 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		errorState = CloudSaveErrorState.GameOutdated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8BEA");
	}

	public static void Disable()
	{
		//IL_013c: Expected I, but got Obj
		//IL_0152: Expected Obj, but got I
		//IL_01c8: Expected I, but got Obj
		//IL_01de: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v38 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9383");
		nint num3 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v32 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_mayQueueCelebration = true;
		if (useSimulatedServer)
		{
			return;
		}
		nint num5 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v23 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Commit();
	}

	private static void RefreshState(bool calledFromInit = false)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		isAvailable__BackingField = calledFromInit;
	}

	private static string GetRootDir()
	{
		//IL_02d8: Expected I, but got Obj
		//IL_02ee: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0154: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I
		//IL_0195: Expected I, but got Obj
		//IL_0216: Expected I, but got Obj
		//IL_022c: Expected Obj, but got I
		//IL_0396: Expected I4, but got Obj
		//IL_02b6: Expected Obj, but got I4
		//IL_0257: Expected I, but got Obj
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v67 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (useSimulatedServer)
		{
			nint num3 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v63 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78ED");
			object obj3 = default;
			if (obj3 == null || ((nint)obj3 != 1 && ((nint)obj3 == 2 || (nint)obj3 == 3)))
			{
				return null;
			}
			nint num5 = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v23 (Il2CppClass<Authentication.Auth>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v59 (Il2CppClass<Authentication.Auth>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag;
			if (Auth.isInitialized)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v28 (System.Boolean)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				return null;
			}
			nint num7 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v32 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v48 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ICloudUserData cloudUserData = MakeUserData();
			ICloudUserData error = DEBUG_MakeUserData();
			((GameCenterLogin)(object)_workingCopy).OnAuthenticateHandler((byte)(int)cloudUserData != 0, (string)(object)error);
			_workingCopy.Abort();
			bool isOutOfDate = _workingCopy.isOutOfDate;
			return (string)isOutOfDate;
		}
		return null;
	}

	private static string GetFilePath()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8BF3");
		string result = default;
		return result;
	}

	private static void OnItemUpdated(object sender, CloudItemUpdatedArgs cloudItemUpdatedArgs)
	{
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0075: Expected I4, but got Obj
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((string)(object)cloudItemUpdatedArgs).LastIndexOfAny((char[])Path.DirectorySeparatorChar);
		if (num3 > 0)
		{
			string text = ((string)(object)cloudItemUpdatedArgs).InternalSubString(0, num3);
			if (((string)sender).get_Chars((int)text) != '\0')
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectoriesInternal(text);
			}
		}
	}

	public static ICloudUserData MakeUserData()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (ICloudUserData)PlayerInfoMigrator.MigrateInventorySave((Dictionary<Key, string>)(object)"");
	}

	public static ICloudUserData DEBUG_MakeUserData()
	{
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got Unknown
		//IL_0372: Expected Obj, but got I4
		//IL_0393: Expected I, but got Obj
		//IL_03a9: Expected Obj, but got I
		//IL_03d7: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I4
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0157: Expected I, but got Obj
		//IL_016d: Expected Obj, but got I
		//IL_010a: Expected I, but got Obj
		//IL_0448: Expected Obj, but got F4
		//IL_0198: Expected I, but got Obj
		//IL_0219: Expected Obj, but got I
		//IL_0258: Expected Obj, but got I
		//IL_029f: Expected Obj, but got I
		//IL_02d6: Expected I, but got Obj
		//IL_02ec: Expected Obj, but got I
		//IL_0317: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CloudWorkingCopy cloudWorkingCopy = default;
		cloudWorkingCopy.Clear();
		nint num = (nint)typeof(ScoreMultiplierInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v99 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool allowSellConsumablesDuringRun = SellConsumable.allowSellConsumablesDuringRun;
		obj = allowSellConsumablesDuringRun;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		Dictionary<string, string> userData = default;
		cloudWorkingCopy.SetUserData("multiplier", userData);
		int bragScoreThreshold = PlayerSave.bragScoreThreshold;
		obj = bragScoreThreshold;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		Dictionary<string, string> userData2 = default;
		cloudWorkingCopy.SetUserData("highscore", userData2);
		int coins = InventorySave.coins;
		obj = coins;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		Dictionary<string, string> userData3 = default;
		cloudWorkingCopy.SetUserData("keys", userData3);
		nint num3 = (nint)typeof(Upgrades);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v31 (Il2CppClass<Info.Upgrades>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v95 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WelcomePopupTheme instance = WelcomePopupTheme.instance;
		obj = instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		Dictionary<string, string> userData4 = default;
		cloudWorkingCopy.SetUserData("upgrades", userData4);
		nint num5 = (nint)typeof(AwardsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v40 (Il2CppClass<Missions.AwardsManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v91 (Il2CppClass<Missions.AwardsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MissionsManager instance2 = MissionsManager.Instance;
		float value = ((NumericFloatToggle)(object)instance2).Value;
		obj2 = value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string userData5 = $"{args:0}";
		cloudWorkingCopy.SetUserData("awards", (Dictionary<string, string>)(object)userData5);
		Dictionary<Characters.CharacterId, int> collectedCharacterTokens = InventorySave.collectedCharacterTokens;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v53 (System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterId, System.Int32>)+C]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		Dictionary<string, string> userData6 = default;
		cloudWorkingCopy.SetUserData("characters", userData6);
		Dictionary<UpgradeType, int> upgrades = InventorySave.upgrades;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v61 (System.Collections.Generic.Dictionary`2<Info.UpgradeType, System.Int32>)+C]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		Dictionary<string, string> userData7 = default;
		cloudWorkingCopy.SetUserData("board", userData7);
		List<Characters.CharacterId> unlockedCharacters = InventorySave.unlockedCharacters;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v69 (System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterId>)+10]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v69 (System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterId>)+1C]");
		object obj6 = num7 - 0;
		obj = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		Dictionary<string, string> userData8 = default;
		cloudWorkingCopy.SetUserData("outfits", userData8);
		nint num8 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v77 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num9 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v87 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<KeyValuePair<Characters.CharacterId, Characters.Model>> list = CharacterManager.GenerateAvailableCharacters();
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		Dictionary<string, string> userData9 = default;
		cloudWorkingCopy.SetUserData("boardThemes", userData9);
		return (ICloudUserData)(object)cloudWorkingCopy;
	}

	private static void HandleAccountMismatch()
	{
		//IL_01ae: Expected I, but got Obj
		//IL_01c4: Expected Obj, but got I
		//IL_0302: Expected I, but got Obj
		//IL_0318: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_021b: Expected I, but got Obj
		//IL_0231: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0161: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected Obj, but got Unknown
		//IL_02aa: Expected Obj, but got I4
		//IL_02c6: Expected I, but got Obj
		//IL_02dc: Expected Obj, but got I
		//IL_02e5: Expected Obj, but got I4
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v63 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9383");
		nint num3 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v59 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		errorState = CloudSaveErrorState.Offline;
		if (useSimulatedServer)
		{
			nint num5 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v31 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v53 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CloudWorkingCopy workingCopy = _workingCopy;
			if (~(workingCopy._isUpdating ? 1u : 0u) == 0)
			{
				workingCopy._abortUpdate = true;
			}
			if (~(workingCopy._isSynchronizing ? 1u : 0u) == 0)
			{
				workingCopy._abortSynchronize = true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num7 = 0;
			string text = default;
			text.m_stringLength = (int)num7;
			_ = 0;
			object obj4 = text + 16;
			obj4 = 0;
			_workingCopy.sourceDescription = text;
			nint num8 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v48 (Il2CppClass<Cloud.CloudSave>)+5C]");
			object obj5 = (nint)0 + (nint)20;
			obj5 = 0;
		}
		nint num9 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v21 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num10 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v26 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((CloudSaveConflictResolver)null).RefreshLocalUserData();
	}

	private static void SetUserDataIfChanged(CloudWorkingCopy workingCopy, string file, ICloudUserData userData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0042: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_01e5: Expected I4, but got Obj
		//IL_0221: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I
		//IL_0241: Expected Obj, but got I
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_02a5: Expected I4, but got Obj
		//IL_02bb: Expected I4, but got Obj
		//IL_06c0: Expected I4, but got Obj
		//IL_06d1: Expected I4, but got Obj
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected Obj, but got Unknown
		//IL_02f4: Expected I, but got Obj
		//IL_030a: Expected Obj, but got I
		//IL_0500: Expected I4, but got Obj
		//IL_051a: Expected Obj, but got I
		//IL_052a: Expected Obj, but got I
		//IL_053a: Expected Obj, but got I
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected Obj, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected Obj, but got Unknown
		//IL_0335: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = workingCopy;
		obj2 = file;
		if (file != null)
		{
			CelebrationReward lastAddedReward = InventorySave.lastAddedReward;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v4 (Il2CppMethodInfo)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S2_v5+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S2_v6+44]");
			object obj5 = 0;
			object obj6 = obj5 & 0x1FFF;
			object obj7 = obj6 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v46 @ S3_v5 (should have been resolved before IL gen)");
			object obj8 = default;
			if ((nint)obj8 <= -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
			CelebrationReward lastAddedReward2 = InventorySave.lastAddedReward;
			Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> dictionary = ((Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>>)(object)lastAddedReward2).get_Item((Boards.BoardId)workingCopy);
			if (dictionary != null)
			{
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S2_v15 (Il2CppMethodInfo)+C]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S2_v16+60]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S2_v17+44]");
				object obj11 = 0;
				object obj12 = obj11 & 0x1FFF;
				object obj13 = obj12 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v77 @ S3_v10 (should have been resolved before IL gen)");
				object obj14 = default;
				if ((nint)obj14 > -1)
				{
					CelebrationReward lastAddedReward3 = InventorySave.lastAddedReward;
					Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> dictionary2 = ((Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>>)(object)lastAddedReward3).get_Item((Boards.BoardId)workingCopy);
					BoardThemeData boardThemeData = dictionary2.get_Item((HoverboardThemes.ThemeIdentifier)file);
					if (~(boardThemeData.isOwned ? 1u : 0u) != 0)
					{
						nint num3 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v73 (Il2CppClass<Globals>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						if (obj15 != null)
						{
							nint num4 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v106 (Il2CppClass<Globals>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (~(Globals.DEBUG_ALL_BOARDS ? 1u : 0u) != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
							throw new ArrayTypeMismatchException();
						}
					}
					CelebrationReward lastAddedReward4 = InventorySave.lastAddedReward;
					Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> dictionary3 = ((Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>>)(object)lastAddedReward4).get_Item((Boards.BoardId)workingCopy);
					BoardThemeData boardThemeData2 = dictionary3.get_Item((HoverboardThemes.ThemeIdentifier)file);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					bool isOwned = boardThemeData2.isOwned;
					object obj16 = userData & 1;
					bool hasBeenSeen = boardThemeData2.hasBeenSeen;
					CelebrationReward lastAddedReward5 = InventorySave.lastAddedReward;
					Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> dictionary4 = ((Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>>)(object)lastAddedReward5).get_Item((Boards.BoardId)workingCopy);
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S4_v8 (Il2CppMethodInfo)+C]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S4_v9+60]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S4_v10+48]");
					object obj19 = 0;
					object obj20 = obj19 & 0x7FF;
					object obj21 = obj20 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v56 @ S5_v5 (should have been resolved before IL gen)");
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		SDebug.LogFormat("Trying to activate an invalid theme.", null);
	}

	private static void SetStateOkAndQueueCelebrationIfNeeded()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I4
		//IL_00e7: Expected I, but got Obj
		//IL_00fd: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		string text = default;
		text.m_stringLength = (int)num3;
		_ = 0;
		object obj2 = text + 16;
		obj2 = 0;
		_workingCopy.sourceDescription = text;
		nint num4 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v14 (Il2CppClass<Cloud.CloudSave>)+5C]");
		object obj3 = (nint)0 + (nint)20;
		obj3 = 0;
		_allowReinitAfterMismatch = true;
		Commit();
	}

	private static void Log(string msg, UnityEngine.Object obj = null)
	{
		//IL_000f: Expected Obj, but got I4
		((BaseTransformValueResetter)3)._002Ector(SpaceType.World);
	}

	private static void LogError(string msg, UnityEngine.Object obj = null)
	{
	}
}
