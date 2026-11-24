using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace Kiloo.GameCenter;

public class GameCenterReportAchievementsRequest : GameCenterRequest
{
	private GameCenterPlugin.Achievement[] achievements__BackingField;

	public GameCenterPlugin.Achievement[] achievements
	{
		get
		{
			return achievements__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 20;
			obj = value;
		}
	}

	public bool showsCompletionBanner
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)achievements__BackingField != 0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 20;
			obj = value;
		}
	}

	public GameCenterReportAchievementsRequest(GameCenterPlugin.Achievement[] achievements, bool showsCompletionBanner)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0354: Expected I, but got Obj
		//IL_036a: Expected Obj, but got I
		//IL_0414: Expected I, but got Obj
		//IL_042a: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_03a5: Expected I, but got Obj
		//IL_03bb: Expected Obj, but got I
		//IL_046f: Expected Obj, but got I4
		//IL_0183: Expected I, but got Obj
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0223: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I4
		//IL_01d0: Expected I, but got Obj
		//IL_0112: Expected I, but got Obj
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_02a8: Expected Obj, but got I
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 8)
		{
			nint num = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v12 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v78 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num5 = ((ComputeShader)(object)GameCenterPlugin._instance).FindKernel((string)null);
			nint num6 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v14 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag = obj3 == null;
			if (num5 == 0)
			{
				if (!flag)
				{
					nint num7 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v74 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GameCenterPlugin.LogWarning("ReportAchievements was called before Init");
				return;
			}
			if (!flag)
			{
				nint num8 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v63 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num9 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v28 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num10 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v59 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num11 = FileUtil.CopyTo((Stream)showsCompletionBanner, (Stream)(object)GameCenterPlugin._instance);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			StringBuilder stringBuilder = default;
			System.Text.StringBuilderCache.Release(stringBuilder);
			object obj5 = this + 12;
			object obj6 = 0;
			object obj7 = 0;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
			{
				object obj8 = this + 16;
				object obj9 = obj7 << 2;
				object obj10 = obj8 + obj9;
				object obj11 = obj10;
				if (obj6 != null)
				{
					StringBuilder stringBuilder2 = stringBuilder.Append(124);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v47+8]");
				StringBuilder stringBuilder3 = stringBuilder.AppendLine((string)0);
				StringBuilder stringBuilder4 = stringBuilder3.Append(124);
				throw new OverflowException();
			}
		}
		else if (showsCompletionBanner)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
		}
	}

	public GameCenterReportAchievementsRequest(GameCenterPlugin.Achievement achievement, bool showsCompletionBanner)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 20;
		obj = achievement;
		this.showsCompletionBanner__BackingField = showsCompletionBanner;
	}

	public GameCenterReportAchievementsRequest(string identifier, float percentComplete, bool showsCompletionBanner)
	{
		//IL_001c: Expected Obj, but got I4
		bool flag = ((RouteBuilder)(object)this).CanDespawnPassedChunk((RouteChunk)(object)identifier, percentComplete);
		Coroutine coroutine = ((MonoBehaviour)(object)this).StartCoroutine_Auto((IEnumerator)flag);
	}
}
