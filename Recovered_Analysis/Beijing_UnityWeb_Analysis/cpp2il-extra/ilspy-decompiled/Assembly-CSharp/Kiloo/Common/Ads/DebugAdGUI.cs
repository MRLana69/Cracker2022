using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.JsonUtil;
using Kiloo.Common.UI;
using UnityEngine;

namespace Kiloo.Common.Ads;

public class DebugAdGUI : MonoBehaviour
{
	private const int DEFAULT_CLOSE_BUTTON_SIZE = 60;

	private const int VIDEO_LENGTH = 5;

	private const int DEFAULT_TEXT_FONT_SIZE = 20;

	private bool _showVideo;

	private bool _showInterstitial;

	private string _adProvider;

	private float _timeLeftForVideo;

	private int _closeButtonSize;

	private GUIStyle _interstitialGuiStyle;

	private GUIStyle _videoGuiStyle;

	private string adLocationID__BackingField;

	private Action m_finishedWatchingVideo;

	private Action<AdType> m_dismissedAd;

	public string adLocationID
	{
		get
		{
			return _adProvider;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
		}
	}

	public event Action finishedWatchingVideo
	{
		add
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 36;
			obj = value;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_finishedWatchingVideo;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 40;
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

	public event Action<AdType> dismissedAd
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_finishedWatchingVideo;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 40;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_dismissedAd;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 44;
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

	private void Awake()
	{
		//IL_0125: Expected I, but got Obj
		//IL_013b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AdSystemLog);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v36 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(AdSystemLog.isRunningTests ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
	}

	private void SetupInterstitialGuiStyle(GUIStyle baseGuiStyle)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_dismissedAd;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)baseGuiStyle);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 44;
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

	private unsafe void SetupVideoGuiStyle(GUIStyle baseGuiStyle)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Ref, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got F4
		//IL_00b3: Expected Obj, but got I4
		//IL_00c9: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GUIStyle gUIStyle = default;
		gUIStyle.name = (string)(object)baseGuiStyle;
		object obj = this + 28;
		obj = gUIStyle;
		RectOffset margin = _interstitialGuiStyle.margin;
		object obj3 = default;
		object obj2 = obj3 + 16;
		Color magenta = Color.magenta;
		ref Color reference = ref *(Color*)(obj3 + 32);
		reference = ref *(Color*)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v8+8]");
		_ = 0;
		((GUIStyleState)(object)margin).set_textColor_Injected(ref reference);
		RectOffset margin2 = _interstitialGuiStyle.margin;
		obj3 = 0;
		_ = 0;
		obj3 = 0f;
		_ = 0f;
		_ = 0f;
		_ = 0.88f;
		reference = ref *(Color*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Container container = ((AbstractListAdapter)null).GetContainer((Container)1, 1, (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != 0);
		((GUIStyleState)(object)margin2).textColor = (Color)container;
	}

	public void SetGuiProperties(int closeButtonSize, int textFontSize)
	{
		//IL_0036: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I
		if (((UnityEngine.Object)this).m_CachedPtr == (IntPtr)0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string text = default;
		if (!((string)closeButtonSize != text))
		{
			return;
		}
		string text2 = adLocationID__BackingField;
		if (((string)textFontSize).get_Chars(text2.m_stringLength) != '\0')
		{
			_interstitialGuiStyle = (GUIStyle)1;
		}
		string text3 = adLocationID__BackingField;
		if ((string)textFontSize != (string)text3.m_stringLength)
		{
			string text4 = adLocationID__BackingField;
			bool flag = ((AdLocation)(object)this).IsCached();
			IEnumerator enumerator = ((DebugAdProvider)(nint)((UnityEngine.Object)this).m_CachedPtr).CacheInterstitialCoroutine((string)text4.m_firstChar, (string)flag);
			if (enumerator == null)
			{
				((AdProviderConfiguration)(object)this)._002Ector();
			}
		}
	}

	public void ShowInterstitial(string location, string adProvider)
	{
		//IL_000a: Expected I4, but got Obj
		//IL_0019: Expected VT, but got Obj
		//IL_0028: Expected VT, but got Obj
		_closeButtonSize = (int)location;
		_interstitialGuiStyle.Internal_clipOffset = (Vector2)adProvider;
		_videoGuiStyle.Internal_clipOffset = (Vector2)adProvider;
	}

	public void ShowVideo(string location, string adProvider)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		_showInterstitial = true;
		_showVideo = false;
		object obj = this + 16;
		obj = adProvider;
		object obj2 = this + 36;
		obj2 = location;
	}

	private void OnGUI()
	{
		//IL_0059: Expected VT, but got I4
		//IL_0059: Expected Obj, but got I
		//IL_000f: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		IntPtr intPtr = default;
		GUIStyle.Internal_Destroy(intPtr);
		((GUIStyle)(nint)intPtr).Internal_clipOffset = (Vector2)20;
		Vector2 contentOffset = ((GUIStyle)1).contentOffset;
		_closeButtonSize = 60;
		SetupVideoGuiStyle((GUIStyle)(nint)intPtr);
		((DebugAdProvider)(object)this).CheckPlatformSupport((AdProviderConfiguration)(nint)intPtr);
	}

	private unsafe Texture2D MakeTexture(int width, int height, Color color)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0118: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got VT
		//IL_0147: Expected Obj, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		object obj3 = obj2 + 20;
		obj3 = width;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+14]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		AdSystemEventLogger adSystemEventLogger = default;
		adSystemEventLogger.ShowedAd((AdType)num, (string)0, (string)color);
		object obj4 = obj2 + 16;
		obj4 = adSystemEventLogger;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(AdController._003C_003Ec__DisplayClass46_0._003CCreatePriorityListForID_003Eb__0);
		object obj5 = action + 16;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+10]");
		((PriorityList)0).changedProvider -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(AdController._003C_003Ec__DisplayClass46_0._003CCreatePriorityListForID_003Eb__1);
		object obj6 = action2 + 16;
		obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+10]");
		((PriorityList)0).resetToTop -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+10]");
		return (Texture2D)0;
	}

	private bool CloseButton()
	{
		//IL_0007: Expected I4, but got Obj
		return (byte)(int)adLocationID__BackingField != 0;
	}

	public unsafe DebugAdGUI()
	{
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected Obj, but got Unknown
		//IL_05ce: Expected Obj, but got I4
		//IL_05e2: Expected I, but got Obj
		//IL_05f8: Expected Obj, but got I
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected Obj, but got Unknown
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected Obj, but got Unknown
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Expected VT, but got Unknown
		//IL_07c6: Expected Obj, but got F4
		//IL_0013: Expected I, but got Obj
		//IL_06bb: Expected I, but got Obj
		//IL_06d1: Expected Obj, but got I
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_028b: Expected I, but got Obj
		//IL_02a1: Expected Obj, but got I
		//IL_0622: Expected F4, but got Obj
		//IL_061d: Expected native int or pointer, but got VT
		//IL_0637: Expected F4, but got I
		//IL_0632: Expected native int or pointer, but got VT
		//IL_0578: Expected I, but got Obj
		//IL_06fb: Expected F4, but got Obj
		//IL_06f6: Expected native int or pointer, but got VT
		//IL_0710: Expected F4, but got I
		//IL_070b: Expected native int or pointer, but got VT
		//IL_010b: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got F4
		//IL_013a: Expected I4, but got Obj
		//IL_014b: Expected F4, but got Obj
		//IL_0146: Expected native int or pointer, but got VT
		//IL_0160: Expected F4, but got I
		//IL_015b: Expected native int or pointer, but got VT
		//IL_00c3: Expected I, but got Obj
		//IL_0314: Expected Obj, but got I4
		//IL_0323: Expected Obj, but got F4
		//IL_02cc: Expected I, but got Obj
		//IL_067a: Expected I, but got Obj
		//IL_0690: Expected Obj, but got I
		//IL_07f5: Expected F4, but got Obj
		//IL_07f0: Expected native int or pointer, but got VT
		//IL_080a: Expected F4, but got I
		//IL_0805: Expected native int or pointer, but got VT
		//IL_021c: Expected I, but got Obj
		//IL_01db: Expected Obj, but got I
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 40;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(GUI);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UnityEngine.GUI>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v27 (Il2CppClass<UnityEngine.GUI>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 24;
		object obj5 = obj2 + 8;
		Color color = (GUI.color = (Color)(obj2 + 56));
		obj = color.r;
		_ = color.b;
		bool usePageScrollbars = GUI.usePageScrollbars;
		GUI.GrabMouseControl(int.MinValue);
		if (~(_showInterstitial ? 1u : 0u) == 0)
		{
			Color magenta = Color.magenta;
			nint num3 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v108 (Il2CppClass<UnityEngine.GUI>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(GUI);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v156 (Il2CppClass<UnityEngine.GUI>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Color*)(nint)color)->r = (float)obj4;
			Color color3 = color;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17+8]");
			((Color*)(nint)color3)->b = 0f;
			Color backgroundColor = GUI.backgroundColor;
			int height = Screen.height;
			int sleepTimeout = Screen.sleepTimeout;
			obj5 = 0;
			_ = 0;
			obj5 = 0f;
			_ = 0f;
			string content = string.ConcatArray((string[])(object)"Interstitial from ", (int)_adProvider);
			((Color*)(nint)color)->r = (float)obj5;
			Color color4 = color;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+8]");
			((Color*)(nint)color4)->b = 0f;
			GUI.Box((Rect)color, (GUIContent)(object)content, _interstitialGuiStyle);
			if (((DebugAdProvider)(object)this).errorHappened)
			{
				_showInterstitial = false;
				if (this.m_dismissedAd != null)
				{
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S3_v13 (Il2CppMethodInfo)+18]");
					object obj7 = 0;
					object obj8 = obj7;
					object obj9 = obj8 & 0x3FFF;
					object obj10 = obj9 + 97173;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v260 @ S4_v13 (should have been resolved before IL gen)");
				}
			}
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			nint num6 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S1_v139 (Il2CppClass<UnityEngine.GUI>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num7 = (nint)typeof(GUI);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S1_v146 (Il2CppClass<UnityEngine.GUI>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Color*)(nint)color)->r = (float)obj4;
			Color color5 = color;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17+8]");
			((Color*)(nint)color5)->b = 0f;
			Color backgroundColor2 = GUI.backgroundColor;
		}
		else if (~(_showVideo ? 1u : 0u) == 0)
		{
			Color blue = Color.blue;
			nint num8 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v33 (Il2CppClass<UnityEngine.GUI>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num9 = (nint)typeof(GUI);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v102 (Il2CppClass<UnityEngine.GUI>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Color*)(nint)color)->r = (float)obj4;
			Color color6 = color;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17+8]");
			((Color*)(nint)color6)->b = 0f;
			Color backgroundColor3 = GUI.backgroundColor;
			int height2 = Screen.height;
			int sleepTimeout2 = Screen.sleepTimeout;
			obj5 = 0;
			_ = 0;
			obj5 = 0f;
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		nint num10 = (nint)typeof(GUI);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v20 (Il2CppClass<UnityEngine.GUI>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num11 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v25 (Il2CppClass<UnityEngine.GUI>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GUI.GrabMouseControl(usePageScrollbars ? 1 : 0);
	}
}
