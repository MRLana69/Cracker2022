using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Ads;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using UI.Generic.Layout;
using UI.Screens.RewardManagement;
using UnityEngine;

public class TutorialMultilineLabelsHelper : MonoBehaviour
{
	private UILabel _label1Title;

	private UILabel _label1Subtitle;

	private UILabel _label2Title;

	private UILabel _label2Subtitle;

	private UILabel _label3Title;

	private UILabel _label3Subtitle;

	private VerticalLayout _verticalLayout;

	private static readonly Vector3 _defaultPosition;

	private const int DEFAULT_FONT_SIZE_TITLE = 20;

	private const int DEFAULT_FONT_SIZE_SUBTITLE = 16;

	public static TutorialMultilineLabelsHelper AddToGameObject(GameObject go, GameObject prefab, Vector3? position = null)
	{
		//IL_0425: Expected I4, but got Obj
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I4
		//IL_006c: Expected VT, but got I4
		//IL_0097: Expected I, but got Obj
		//IL_00ad: Expected Obj, but got I
		//IL_0493: Expected I4, but got Obj
		//IL_0493: Expected Obj, but got I
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected Obj, but got Unknown
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected Obj, but got Unknown
		//IL_04bf: Expected Obj, but got VT
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_00d8: Expected I, but got Obj
		//IL_0179: Expected I, but got Obj
		//IL_018f: Expected Obj, but got I
		//IL_0128: Expected Obj, but got I
		//IL_0525: Expected I, but got Obj
		//IL_053b: Expected Obj, but got I
		//IL_01ba: Expected I, but got Obj
		//IL_0258: Expected I, but got Obj
		//IL_02ae: Expected I, but got Obj
		//IL_02c4: Expected Obj, but got I
		//IL_05ad: Expected I, but got Obj
		//IL_05c3: Expected Obj, but got I
		//IL_05f7: Expected I, but got Obj
		//IL_060d: Expected Obj, but got I
		//IL_02ef: Expected I, but got Obj
		//IL_0649: Expected Obj, but got I4
		//IL_0649: Expected Obj, but got I4
		//IL_065b: Expected I, but got Obj
		//IL_0671: Expected Obj, but got I
		//IL_033c: Expected I, but got Obj
		//IL_0389: Expected I, but got Obj
		//IL_03d6: Expected I, but got Obj
		_ = 0;
		string text = ((MysteryBoxDoubleUpButton)null).GroupCoinsForFlurryLogging((int)prefab);
		bool flag = ((MysteryBoxDoubleUpButton)null).IsValidOrigin((CelebrationReward)(object)prefab);
		object obj = text & flag;
		IEnumerator enumerator = ((MysteryBoxDoubleUpButton)null).AnimateButton();
		object obj2 = obj & (object)enumerator;
		bool flag2 = ((MysteryBoxDoubleUpButton)null).IsVideoAvailable();
		string text2 = (string)(obj2 & flag2);
		object obj3 = text2 & 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L0 (UnityEngine.GameObject)+C]");
		((GameObject)0).tag = text2;
		PrizePositionData.PositionModel((PrizePositionData.TransformValues?)(object)0, (Transform)(object)text, (UIWidget)flag, flag2);
		if (text2 != null)
		{
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v49 (Il2CppClass<Strings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v68 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text3 = Strings.GetDefault("CELEBRATION_POPUP_DOUBLE_UP");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L0 (UnityEngine.GameObject)+10]");
			((UILabel)0).fontSize = (int)text3;
			object obj5 = go + 28;
			obj5 = prefab;
			object obj6 = go + 36;
			obj6 = position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L0 (UnityEngine.GameObject)+28]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L0 (UnityEngine.GameObject)+28]");
				FileUtil.LogError((string)0);
			}
			object obj7 = go + 40;
			IEnumerator list = ((QuickVideoButtonHelper)(object)go).StartVideoWithDelay();
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
			obj7 = coroutine;
			((MysteryBoxDoubleUpButton)(object)go)._002Ector();
			nint num3 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v62 (Il2CppClass<Flurry>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v65 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		if (obj != null)
		{
			string format = ((!flag2) ? "No Chance" : "Chance");
			object arg = ((enumerator == null) ? "No Fill" : "Fill");
			string text4 = string.Format((IFormatProvider)(object)"{0} - {1}", format, arg);
			nint num5 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v27 (Il2CppClass<Flurry>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v45 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (enumerator == null)
			{
				OfferWallManager instance = OfferWallManager.instance;
				nint num7 = (nint)typeof(AdLocations);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S1_v17 (Il2CppClass<AdLocations>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num8 = (nint)typeof(AdLocations);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v40 (Il2CppClass<AdLocations>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				AdLocationInfo dOUBLE_UP_VIDEOS = AdLocations.DOUBLE_UP_VIDEOS;
				bool availabilityForLocation = ((AdSystemManager)(object)instance).GetAvailabilityForLocation(dOUBLE_UP_VIDEOS.id);
				nint num9 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v26 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num10 = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S1_v36 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string unfilteredLocale = DeviceUtility.GetUnfilteredLocale();
				nint num11 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S2_v19 (Il2CppClass<Utils>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num12 = (nint)typeof(Utils);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S2_v25 (Il2CppClass<Utils>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = Utils.IsEnum((Type)(object)unfilteredLocale);
				object obj13 = ((IConvertible)availabilityForLocation).ToType((Type)(object)";", (IFormatProvider)flag3);
				nint num13 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v38 (Il2CppClass<Flurry>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num14 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v41 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
			}
		}
		return (TutorialMultilineLabelsHelper)(object)text2;
	}

	public unsafe void SetupPosition(Vector3 position)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0019: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0056: Expected F4, but got VT
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		object obj = _label1Title + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = _label1Title + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			((ParticleSystem.MainModule*)obj5)->startSizeMultiplier = (float)position;
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
	}

	public unsafe void SetText(string line1, string line2, string line3, string line4, string line5, string line6)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1475: Unknown result type (might be due to invalid IL or missing references)
		//IL_147a: Expected Ref, but got Unknown
		//IL_148c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1491: Expected Obj, but got Unknown
		//IL_149a: Expected Obj, but got I4
		//IL_14c0: Expected I, but got Obj
		//IL_14d6: Expected Obj, but got I
		//IL_1987: Expected Obj, but got I
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected VT, but got Unknown
		//IL_012f: Expected Obj, but got I
		//IL_0140: Expected Obj, but got F4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_0029: Expected I, but got Obj
		//IL_01e5: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got F4
		//IL_0079: Expected Obj, but got I
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_0282: Expected I, but got Obj
		//IL_0298: Expected Obj, but got I
		//IL_00cc: Expected I, but got Obj
		//IL_1538: Expected Obj, but got I
		//IL_1544: Unknown result type (might be due to invalid IL or missing references)
		//IL_1549: Expected I4, but got Unknown
		//IL_03b3: Expected I, but got Obj
		//IL_03c9: Expected Obj, but got I
		//IL_02c3: Expected I, but got Obj
		//IL_1582: Expected I4, but got Obj
		//IL_158c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1591: Expected Obj, but got Unknown
		//IL_0313: Expected Obj, but got I
		//IL_0325: Expected I, but got Obj
		//IL_033b: Expected Obj, but got I
		//IL_0449: Expected I, but got Obj
		//IL_045f: Expected Obj, but got I
		//IL_03f4: Expected I, but got Obj
		//IL_15ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bf: Expected VT, but got Unknown
		//IL_15c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cd: Expected Obj, but got Unknown
		//IL_15df: Expected Obj, but got I
		//IL_0366: Expected I, but got Obj
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected Obj, but got Unknown
		//IL_0502: Expected Obj, but got I4
		//IL_0511: Expected Obj, but got F4
		//IL_052b: Expected I, but got Obj
		//IL_0541: Expected Obj, but got I
		//IL_048a: Expected I, but got Obj
		//IL_1609: Expected F4, but got Obj
		//IL_1604: Expected native int or pointer, but got VT
		//IL_161e: Expected F4, but got I
		//IL_1619: Expected native int or pointer, but got VT
		//IL_162b: Expected F4, but got Obj
		//IL_1626: Expected native int or pointer, but got VT
		//IL_1640: Expected F4, but got I
		//IL_163b: Expected native int or pointer, but got VT
		//IL_1688: Expected Obj, but got I
		//IL_056c: Expected I, but got Obj
		//IL_05bc: Expected Obj, but got I
		//IL_05cd: Expected VT, but got Obj
		//IL_05cd: Expected Obj, but got VT
		//IL_05df: Expected native int or pointer, but got VT
		//IL_05f1: Expected native int or pointer, but got VT
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected Obj, but got Unknown
		//IL_060e: Expected Obj, but got F4
		object obj2 = default;
		object obj = obj2 - -64;
		obj = line1;
		ref HoverboardModelPreviewFactory.HoverboardModelSetup reference = ref *(HoverboardModelPreviewFactory.HoverboardModelSetup*)(obj2 + 60);
		reference = ref *(HoverboardModelPreviewFactory.HoverboardModelSetup*)null;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v334 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TutorialMultilineLabelsHelper)+AC]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TutorialMultilineLabelsHelper)+AC]");
			string obj5 = ((Component)0).tag;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v325 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v330 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj5);
		}
		Vector3 vector = (Vector3)(obj2 + 80);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TutorialMultilineLabelsHelper)+78]");
		AnimatorStateInfo nextAnimatorStateInfo = ((Animator)0).GetNextAnimatorStateInfo(0);
		obj3 = vector.x;
		_ = vector.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v23 (UnityEngine.Vector3)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v23 (UnityEngine.Vector3)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v23 (UnityEngine.Vector3)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+8]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TutorialMultilineLabelsHelper)+70]");
		bool flag = num5 == 0;
		object obj7 = flag & line4;
		if (obj7 != null)
		{
			MonoBehaviour.print(this);
			((HoverboardModelPreviewFactory)this).OnDestroy();
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TutorialMultilineLabelsHelper)+78]");
			AnimatorStateInfo nextAnimatorStateInfo2 = ((Animator)0).GetNextAnimatorStateInfo(0);
			obj3 = vector.x;
			_ = vector.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v23 (UnityEngine.Vector3)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v23 (UnityEngine.Vector3)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v23 (UnityEngine.Vector3)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+8]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TutorialMultilineLabelsHelper)+74]");
			if (num6 == 0)
			{
				((HoverboardModelPreviewFactory)this).OnDestroy();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TutorialMultilineLabelsHelper)+B5]");
		if ((nint)0 != 0)
		{
			((HoverboardModelPreviewFactory)this).OpenGlider();
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v301 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TutorialMultilineLabelsHelper)+58]");
		int num9 = ((ComputeShader)0).FindKernel(null);
		if ((num9 & line4) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TutorialMultilineLabelsHelper)+58]");
			string obj9 = ((Component)0).tag;
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v292 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S1_v297 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj9);
		}
		nint num12 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v43 (Il2CppClass<Info.Boards>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num13 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v361 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item((Boards.BoardId)obj);
		object obj12 = this + 176;
		string current = ((Component)(object)line3).tag;
		Animation animation = ((AvatarAnimations)null).FindAnimationInParent((GameObject)(object)current);
		obj12 = animation;
		nint num14 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v57 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num15 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v357 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector2 = (Vector3)(obj2 + 68);
		object obj14 = obj2 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TutorialMultilineLabelsHelper)+B0]");
		if ((UnityEngine.Object)0 != null)
		{
			SDebug.LogFormat("HoverboardModelPreviewFactory - characterModel was null!", null);
			return;
		}
		object obj15 = this + 124;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S1_v58+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = -1f;
		_ = -1f;
		_ = -1f;
		nint num16 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v77 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num17 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v351 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)obj14;
		Vector3 vector3 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v64+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		if (vector2 != vector)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TutorialMultilineLabelsHelper)+B0]");
			GameObject gameObject = ((Component)0).gameObject;
			((Transform)vector2).localScale = (Vector3)gameObject;
			((Vector3*)(nint)vector)->x = vector2.x;
			((Vector3*)(nint)vector)->z = vector2.z;
			object obj17 = this + 124;
			obj17 = vector.x;
			_ = vector.z;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TutorialMultilineLabelsHelper)+44]");
		if (!((Dictionary<string, HoverboardModelPreviewFactory.HoverboardModelSetup>)0).TryGetValue(board.boardModelName, out reference))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private void AdjustFontSizes()
	{
		CancelInvoke();
	}

	private void SetFontSizes(IEnumerable<UILabel> labels, int fontSize)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		if (fontSize == 0)
		{
			object obj = labels - 3;
			if ((nint)labels != 3)
			{
				if ((nint)obj != 1 && (nint)obj != 2 && (nint)obj != 3 && (nint)obj != 4 && (nint)obj != 5 && (nint)obj != 6 && (nint)obj != 7 && (nint)obj != 8 && (nint)obj != 9 && (nint)obj != 10 && (nint)obj != 11 && (nint)obj == 12)
				{
					((SlideinPowerupHelper)this).HidePowerup2(true);
				}
			}
			else
			{
				((SuperMysteryBoxEffect)this).isRendering = true;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73B9");
		IngameScreen ingameScreen = default;
		ingameScreen.StartHidingScoreboosterSpeedometer(5f);
	}

	public TutorialMultilineLabelsHelper()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}
}
