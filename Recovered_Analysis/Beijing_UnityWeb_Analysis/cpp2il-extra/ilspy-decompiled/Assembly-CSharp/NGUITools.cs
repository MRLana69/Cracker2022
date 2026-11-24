using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using Missions;
using SYBO.Components.Json;
using UI.ModelCamera;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;

public static class NGUITools
{
	public delegate void OnInitFunc<T>(T w) where T : UIWidget;

	[NonSerialized]
	private static AudioListener mListener;

	[NonSerialized]
	public static AudioSource audioSource;

	private static bool mLoaded;

	private static float mGlobalVolume;

	private static float mLastTimestamp;

	private static AudioClip mLastClip;

	private static Dictionary<Type, string> mTypeNames;

	private static Vector3[] mSides;

	public static KeyCode[] keys;

	private static Dictionary<string, UIWidget> mWidgets;

	private static UIPanel mRoot;

	private static GameObject mGo;

	private static ColorSpace mColorSpace;

	public static float soundVolume
	{
		get
		{
			//IL_0056: Expected I, but got Obj
			//IL_006c: Expected Obj, but got I
			//IL_0097: Expected I, but got Obj
			int height = Screen.height;
			int sleepTimeout = Screen.sleepTimeout;
			int num;
			int num2;
			if (height > sleepTimeout)
			{
				int height2 = Screen.height;
				num = Screen.sleepTimeout;
				num2 = height2;
			}
			else
			{
				int sleepTimeout2 = Screen.sleepTimeout;
				num = Screen.height;
				num2 = sleepTimeout2;
			}
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float value = (float)num2 / (float)num;
			return Math.Abs(value);
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		}
	}

	public static bool fileAccess
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(NGUIDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUIDebug>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(NGUIDebug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<NGUIDebug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return NGUIDebug.mRayDebug;
		}
	}

	public static string clipboard
	{
		get
		{
			//IL_0020: Expected Obj, but got I4
			string dataPath = Application.dataPath;
			bool flag = (nint)dataPath != 17;
			return (string)flag;
		}
		set
		{
			//IL_006a: Expected Obj, but got I
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected Obj, but got Unknown
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected Obj, but got Unknown
			//IL_00a1: Expected Obj, but got I4
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected Obj, but got Unknown
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S2_v2 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x1FFF;
			object obj4 = obj3 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v24 @ S3_v4 (should have been resolved before IL gen)");
			object obj5 = 0;
			object obj8 = default;
			while (true)
			{
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v6+C]");
				if ((nint)obj6 < 0)
				{
					object obj7 = obj8 + 16;
					object obj9 = obj5 << 2;
					object obj10 = obj7 + obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
					object obj11 = obj5 + 1;
					obj5 = obj11;
					continue;
				}
				break;
			}
		}
	}

	public static Vector2 screenSize
	{
		get
		{
			//IL_0086: Expected I, but got Obj
			//IL_009c: Expected Obj, but got I
			//IL_00c7: Expected Obj, but got VT
			//IL_00d5: Expected Obj, but got VT
			//IL_00e3: Expected Obj, but got VT
			//IL_0060: Expected Obj, but got VT
			//IL_006e: Expected Obj, but got VT
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 vector = default;
			ExecuteAll<UIWidget>((GameObject)vector, "Start");
			ExecuteAll<UIPanel>((GameObject)vector, "Start");
			ExecuteAll<UIWidget>((GameObject)vector, "Update");
			ExecuteAll<UIPanel>((GameObject)vector, "Update");
			ExecuteAll<UIPanel>((GameObject)vector, "LateUpdate");
			return vector;
		}
	}

	public static AudioSource PlaySound(AudioClip clip)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected I4, but got Unknown
		//IL_00c3: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<NGUIText>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v14 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string endOfLineThatFits = NGUIText.GetEndOfLineThatFits((string)(object)clip);
		int length = (int)((nint)((UnityEngine.Object)clip).m_CachedPtr - endOfLineThatFits);
		return (AudioSource)(object)((string)(object)clip).InternalSubString((int)endOfLineThatFits, length);
	}

	public static AudioSource PlaySound(AudioClip clip, float volume)
	{
		//IL_000d: Invalid comparison between Obj and F4
		//IL_0039: Invalid comparison between I and F4
		//IL_004a: Expected Obj, but got I4
		if (System.Runtime.CompilerServices.Unsafe.As<AudioClip.PCMReaderCallback, UIntPtr>(ref clip.m_PCMReaderCallback) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)volume))
		{
			bool flag = !((float)(nint)((UnityEngine.Object)clip).m_CachedPtr < volume);
			return (AudioSource)flag;
		}
		return null;
	}

	public static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AudioSource audioSource = default;
		((UnityEngine.Object)audioSource).m_CachedPtr = (IntPtr)0;
		object obj = audioSource + 16;
		obj = clip;
		return audioSource;
	}

	public static int RandomRange(int min, int max)
	{
		//IL_005b: Expected Obj, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00a0: Expected Obj, but got I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00b7: Expected Obj, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I4
		//IL_00dc: Expected I, but got Obj
		//IL_00f2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		object obj2 = obj + 8;
		obj2 = 0;
		object obj3 = obj + 7;
		obj3 = 0;
		object obj4 = obj + 6;
		obj4 = 0;
		object obj5 = obj + 5;
		obj5 = 0;
		object obj6 = obj + 4;
		obj6 = 0;
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<NGUIText>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v26 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B752");
		int result = default;
		return result;
	}

	public static string GetHierarchy(GameObject obj)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)(object)TweenFill.Begin(obj, 1f, 1f);
	}

	public static T[] FindActive<T>() where T : Component
	{
		//IL_0310: Expected Obj, but got I
		//IL_032a: Expected Obj, but got I
		//IL_0344: Expected Obj, but got I
		//IL_0352: Expected I, but got Obj
		//IL_0368: Expected Obj, but got I
		//IL_03c6: Expected Obj, but got I
		//IL_03e0: Expected Obj, but got I
		//IL_03ee: Expected I, but got Obj
		//IL_0404: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006c: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_02de: Expected Obj, but got I
		//IL_018d: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_02fd: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_0255: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I
		//IL_02b5: Expected Obj, but got I
		nint num = default;
		object obj = num + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11+5C]");
		object obj3 = 0;
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v56+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v57+10]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v62+60]");
			object obj7 = 0;
			object obj8 = obj6 & 0xFFF;
			object obj9 = obj8 + 1797;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v71 @ S1_v35 (should have been resolved before IL gen)");
			int sceneHandle = default;
			string nameInternal = Scene.GetNameInternal(sceneHandle);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v69+60]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v72+5C]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S2_v13+60]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S2_v19+60]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
			object obj14 = default;
			obj11 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v18+60]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v21+5C]");
		object obj16 = 0;
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v36+60]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v37+14]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v42+60]");
			object obj20 = 0;
			object obj21 = obj19 & 0xFFF;
			object obj22 = obj21 + 1797;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v138 @ S1_v19 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v48+60]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v51+5C]");
			object obj24 = 0;
			object obj25 = default;
			obj24 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v23+60]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v26+5C]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v28+60]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v31+5C]");
		return (T[])0;
	}

	public static Camera FindCameraForLayer(int layer)
	{
		//IL_0136: Expected I, but got Obj
		//IL_014c: Expected Obj, but got I
		//IL_0206: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I4
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_0088: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = default;
		Camera result;
		if ((UnityEngine.Object)num3 != null)
		{
			result = (Camera)(object)"";
		}
		else
		{
			UnityEngine.Object obj2 = UnityEngine.Object.Instantiate((UnityEngine.Object)num3);
			UnityEngine.Object obj3 = obj2;
			string tag = default;
			while (true)
			{
				int layer2 = ((GameObject)(object)tag).layer;
				Transform parentInternal = ((Transform)layer2).parentInternal;
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num6 = ((ComputeShader)(object)parentInternal).FindKernel((string)null);
				bool flag = num6 == 0;
				result = (Camera)obj3;
				if (flag)
				{
					break;
				}
				int layer3 = ((GameObject)(object)tag).layer;
				Transform parentInternal2 = ((Transform)layer3).parentInternal;
				tag = parentInternal2.tag;
				UnityEngine.Object obj5 = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)tag);
				object obj6 = ((IConvertible)obj5).ToType((Type)(object)"\\", (IFormatProvider)obj3);
				obj3 = (UnityEngine.Object)obj6;
			}
		}
		return result;
	}

	public static void AddWidgetCollider(GameObject go)
	{
		//IL_00c3: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0024: Expected I, but got Obj
		//IL_003a: Expected Obj, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0065: Expected I, but got Obj
		//IL_00b6: Expected I4, but got Obj
		nint num = (nint)go;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (Il2CppClass<UnityEngine.GameObject>)+10]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (Il2CppClass<UnityEngine.GameObject>)+14]");
		object obj = num2 + 0;
		string text = (string)(obj - 1);
		if ((nint)text <= 0)
		{
			return;
		}
		StringBuilder stringBuilder = ((StringBuilder)(object)go).Append(text);
		nint num3 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v9 (Il2CppClass<NGUIText>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v16 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = (string)(stringBuilder & 0xFFFF);
		if (NGUIText.CalculateOffsetToFit(text2) != 0)
		{
			((UnicodeEncoding)(object)go)._002Ector((byte)(int)text != 0, true);
		}
	}

	public unsafe static void AddWidgetCollider(GameObject go, bool considerInactive)
	{
		//IL_0bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf3: Expected Obj, but got Unknown
		//IL_0bfc: Expected Obj, but got I4
		//IL_0c05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0a: Expected Obj, but got Unknown
		//IL_0c13: Expected Obj, but got I4
		//IL_0c1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c21: Expected Obj, but got Unknown
		//IL_0c2a: Expected Obj, but got I4
		//IL_0c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c38: Expected Obj, but got Unknown
		//IL_0c41: Expected Obj, but got I4
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4f: Expected Obj, but got Unknown
		//IL_0c58: Expected Obj, but got I4
		//IL_0c61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c66: Expected Obj, but got Unknown
		//IL_0c6f: Expected Obj, but got I4
		//IL_0c78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Expected Obj, but got Unknown
		//IL_0c86: Expected Obj, but got I4
		//IL_0c8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Expected Obj, but got Unknown
		//IL_0c9d: Expected Obj, but got I4
		//IL_0cab: Expected I, but got Obj
		//IL_0cc1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_0d2d: Expected Obj, but got I4
		//IL_0d36: Expected Obj, but got I4
		//IL_0d3f: Expected Obj, but got I4
		//IL_0d48: Expected Obj, but got I4
		//IL_0d51: Expected Obj, but got I4
		//IL_0d5a: Expected Obj, but got I4
		//IL_00cb: Expected I, but got Obj
		//IL_11ef: Expected I, but got Obj
		//IL_1205: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_1422: Expected Obj, but got F4
		//IL_1430: Expected I, but got Obj
		//IL_1446: Expected Obj, but got I
		//IL_0acb: Expected I, but got Obj
		//IL_0ae1: Expected Obj, but got I
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0b59: Expected I, but got Obj
		//IL_016d: Expected I, but got Obj
		//IL_0183: Expected Obj, but got I
		//IL_0ba6: Expected I, but got Obj
		//IL_0b0c: Expected I, but got Obj
		//IL_0df7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfc: Expected Obj, but got Unknown
		//IL_023e: Expected I, but got Obj
		//IL_0254: Expected Obj, but got I
		//IL_01ae: Expected I, but got Obj
		//IL_12c7: Expected I, but got Obj
		//IL_12dd: Expected Obj, but got I
		//IL_027f: Expected I, but got Obj
		//IL_02cc: Expected I, but got Obj
		//IL_02e2: Expected Obj, but got I
		//IL_0386: Expected I, but got Obj
		//IL_0e62: Expected I, but got Obj
		//IL_0e78: Expected Obj, but got I
		//IL_03d3: Expected I, but got Obj
		//IL_03e9: Expected Obj, but got I
		//IL_030d: Expected I, but got Obj
		//IL_0e42: Expected VT, but got I
		//IL_0e42: Expected Obj, but got I4
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0414: Expected I, but got Obj
		//IL_0504: Expected I, but got Obj
		//IL_06ab: Expected I, but got Obj
		//IL_06c1: Expected Obj, but got I
		//IL_0493: Expected I, but got Obj
		//IL_0f9a: Expected VT, but got Obj
		//IL_0a7c: Expected VT, but got Obj
		//IL_06ec: Expected I, but got Obj
		//IL_11dc: Expected Obj, but got VT
		//IL_134e: Expected I, but got Obj
		//IL_1364: Expected Obj, but got I
		//IL_0fc9: Expected I, but got Obj
		//IL_0fdf: Expected Obj, but got I
		//IL_075d: Expected I, but got Obj
		//IL_0773: Expected Obj, but got I
		//IL_1397: Expected Obj, but got I
		//IL_0656: Expected I, but got Obj
		//IL_0866: Expected I, but got Obj
		//IL_068b: Expected Obj, but got I
		//IL_0ee1: Expected I, but got Obj
		//IL_0ef7: Expected Obj, but got I
		//IL_1155: Expected I, but got Obj
		//IL_116b: Expected Obj, but got I
		//IL_1096: Unknown result type (might be due to invalid IL or missing references)
		//IL_109b: Expected Obj, but got Unknown
		//IL_10b2: Expected Obj, but got F4
		//IL_10bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c0: Expected Obj, but got Unknown
		//IL_10d7: Expected Obj, but got F4
		//IL_08df: Expected I, but got Obj
		//IL_08f5: Expected Obj, but got I
		//IL_0833: Expected I, but got Obj
		//IL_1026: Unknown result type (might be due to invalid IL or missing references)
		//IL_102b: Expected Obj, but got Unknown
		//IL_1042: Expected Obj, but got F4
		//IL_104b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1050: Expected Obj, but got Unknown
		//IL_1067: Expected Obj, but got F4
		//IL_05ef: Expected I, but got Obj
		//IL_13cc: Expected I, but got Obj
		//IL_13e2: Expected Obj, but got I
		//IL_0987: Expected I, but got Obj
		//IL_07dc: Expected I, but got Obj
		//IL_09ba: Expected I, but got Obj
		//IL_09d0: Expected Obj, but got I
		//IL_0920: Expected I, but got Obj
		//IL_0a2e: Expected I, but got Obj
		//IL_09fb: Expected I, but got Obj
		//IL_0a67: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		object obj3 = obj2 + 20;
		obj3 = 0;
		object obj4 = obj2 + 28;
		obj4 = 0;
		object obj5 = obj2 + 27;
		obj5 = 0;
		object obj6 = obj2 + 26;
		obj6 = 0;
		object obj7 = obj2 + 25;
		obj7 = 0;
		object obj8 = obj2 + 24;
		obj8 = 0;
		object obj9 = obj2 + 16;
		obj9 = 0;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v25 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v409 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 one = Vector2.one;
		obj = obj2;
		bool flag;
		if (considerInactive)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [considerInactive @ L1 (System.Boolean)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		bool flag2 = !flag;
		bool flag3 = !flag2;
		object obj11 = obj2;
		if (!flag3)
		{
			nint num3 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v38 (Il2CppClass<NGUIText>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num4 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v401 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUIText.EndLine(ref *(considerInactive ? ((StringBuilder*)1) : ((StringBuilder*)null)));
			float num5 = (float)NGUIText.regionWidth + 0.01f;
			obj3 = 0;
			obj4 = 0;
			obj5 = 0;
			obj6 = 0;
			obj7 = 0;
			obj8 = 0;
			char[] array = null;
			float num9 = default;
			float num10 = default;
			float num11 = default;
			GameObject gameObject2 = default;
			object obj18 = default;
			float num59 = default;
			while (true)
			{
				obj9 = array;
				char[] array2 = array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [considerInactive @ L1 (System.Boolean)+8]");
				if ((nint)array2 >= 0)
				{
					break;
				}
				string[] array3 = ((string)considerInactive).Split(array);
				GameObject gameObject = (GameObject)(array3 & 0xFFFF);
				object obj13 = array3 & 0xFFFF;
				float num12;
				if ((nint)obj13 == 10)
				{
					nint num6 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S0_v383 (Il2CppClass<NGUIText>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num7 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v395 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num8 = num9 + NGUIText.finalLineHeight;
					if (num10 > num11)
					{
						num11 = num10;
					}
					num9 = num8;
					num12 = 0f;
					gameObject2 = null;
				}
				else
				{
					object obj15 = array3 & 0xFFFF;
					if ((nint)obj15 > 31)
					{
						nint num13 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S0_v119 (Il2CppClass<NGUIText>)+BA]");
						object obj16 = (nint)0 & (nint)0x200;
						if (obj16 != null)
						{
							nint num14 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v376 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (~(NGUIText.encoding ? 1u : 0u) == 0)
						{
							nint num15 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ S0_v361 (Il2CppClass<NGUIText>)+BA]");
							object obj17 = (nint)0 & (nint)0x200;
							if (obj17 != null)
							{
								nint num16 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ S0_v370 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool premultiply = NGUIText.premultiply;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B752");
							if (obj18 != null)
							{
								object obj19 = obj9 - 1;
								obj9 = obj19;
								num12 = num10;
								gameObject2 = gameObject2;
								goto IL_0dee;
							}
						}
						nint num17 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S0_v128 (Il2CppClass<NGUIText>)+BA]");
						object obj20 = (nint)0 & (nint)0x200;
						if (obj20 != null)
						{
							nint num18 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ S0_v354 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int num21;
						if (~(NGUIText.useSymbols ? 1u : 0u) == 0)
						{
							nint num19 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S0_v344 (Il2CppClass<NGUIText>)+BA]");
							object obj21 = (nint)0 & (nint)0x200;
							if (obj21 != null)
							{
								nint num20 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ S0_v350 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool flag4 = considerInactive;
							object indices = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [considerInactive @ L1 (System.Boolean)+8]");
							num21 = NGUIText.GetExactCharacterIndex((List<Vector3>)flag4, (List<int>)indices, (Vector2)0);
							bool premultiply = false;
						}
						else
						{
							num21 = 0;
						}
						nint num22 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ S0_v137 (Il2CppClass<NGUIText>)+BA]");
						object obj22 = (nint)0 & (nint)0x200;
						bool flag5 = obj22 == null;
						bool flag6 = obj3 == null;
						float num24;
						if (flag6)
						{
							if (!flag5)
							{
								nint num23 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ S0_v334 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							num24 = NGUIText.fontScale;
						}
						else
						{
							if (!flag5)
							{
								nint num25 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ S0_v322 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							num24 = NGUIText.fontScale * 0.75f;
						}
						if (~num21 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ S0_v135 (System.Int32)+2C]");
							float num26 = 0f * num24;
							float num27 = num10 + num26;
							if (num27 > num5)
							{
								if (num10 == 0f)
								{
									break;
								}
								if (num10 > num11)
								{
									num11 = num10;
								}
								nint num28 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ S0_v302 (Il2CppClass<NGUIText>)+BA]");
								object obj23 = (nint)0 & (nint)0x200;
								if (obj23 != null)
								{
									nint num29 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ S0_v309 (Il2CppClass<NGUIText>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								float num30 = num9 + NGUIText.finalLineHeight;
								num10 = 0f;
								num9 = num30;
							}
							else if (num27 > num11)
							{
								num11 = num27;
							}
							nint num31 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ S0_v273 (Il2CppClass<NGUIText>)+BA]");
							object obj24 = (nint)0 & (nint)0x200;
							if (obj24 != null)
							{
								nint num32 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ S0_v288 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							float num33 = num26 + NGUIText.finalSpacingX;
							float num34 = num10 + num33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ S0_v135 (System.Int32)+18]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ S0_v135 (System.Int32)+8]");
								object obj25 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ S1_v124+8]");
								_ = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ S0_v135 (System.Int32)+18]");
							object obj26 = -1;
							object obj27 = obj26 + obj9;
							obj9 = obj27;
							num12 = num34;
							gameObject2 = null;
						}
						else
						{
							nint num35 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ S0_v147 (Il2CppClass<NGUIText>)+BA]");
							object obj28 = (nint)0 & (nint)0x200;
							if (obj28 != null)
							{
								nint num36 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ S0_v264 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							SpringPanel springPanel = SpringPanel.Begin(gameObject, (Vector3)gameObject2, num24);
							Vector3 vector;
							bool premultiply;
							if ((object)springPanel != null)
							{
								if (!flag6)
								{
									nint num37 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ S0_v224 (Il2CppClass<NGUIText>)+BA]");
									object obj29 = (nint)0 & (nint)0x200;
									bool flag7 = obj29 == null;
									if ((nint)obj3 == 1)
									{
										if (!flag7)
										{
											nint num38 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ S0_v259 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										float num39 = NGUIText.fontScale * (float)NGUIText.fontSize;
										float num40 = num39 * 0.4f;
										object obj30 = springPanel + 12;
										float num41 = (float)obj30 - num40;
										obj30 = num41;
										object obj31 = springPanel + 20;
										float num42 = (float)obj31 - num40;
										obj31 = num42;
									}
									else
									{
										if (!flag7)
										{
											nint num43 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ S0_v242 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										float num44 = NGUIText.fontScale * (float)NGUIText.fontSize;
										float num45 = num44 * 0.05f;
										object obj32 = springPanel + 12;
										float num46 = (float)obj32 + num45;
										obj32 = num46;
										object obj33 = springPanel + 20;
										float num47 = (float)obj33 + num45;
										obj33 = num47;
									}
								}
								nint num48 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ S0_v162 (Il2CppClass<NGUIText>)+BA]");
								object obj34 = (nint)0 & (nint)0x200;
								if (obj34 != null)
								{
									nint num49 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ S0_v218 (Il2CppClass<NGUIText>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ S0_v152 (SpringPanel)+38]");
								float num50 = 0f + NGUIText.finalSpacingX;
								float num51 = num10 + num50;
								if (num51 > num5)
								{
									if (num10 == 0f)
									{
										premultiply = false;
										num12 = num10;
										gameObject2 = gameObject;
										goto IL_0dee;
									}
									nint num52 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ S0_v206 (Il2CppClass<NGUIText>)+BA]");
									object obj35 = (nint)0 & (nint)0x200;
									if (obj35 != null)
									{
										nint num53 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ S0_v212 (Il2CppClass<NGUIText>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									float num54 = num9 + NGUIText.finalLineHeight;
									num9 = num54;
								}
								else if (num51 > num11)
								{
									num11 = num51;
								}
								nint num55 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ S0_v171 (Il2CppClass<NGUIText>)+BA]");
								object obj36 = (nint)0 & (nint)0x200;
								if (obj36 != null)
								{
									nint num56 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ S0_v196 (Il2CppClass<NGUIText>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								bool flag8 = !flag6;
								bool flag9 = !flag8;
								num12 = num51;
								if (!flag9)
								{
									nint num57 = (nint)typeof(Mathf);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ S0_v187 (Il2CppClass<UnityEngine.Mathf>)+BA]");
									object obj37 = (nint)0 & (nint)0x200;
									if (obj37 != null)
									{
										nint num58 = (nint)typeof(Mathf);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ S0_v193 (Il2CppClass<UnityEngine.Mathf>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
									num12 = num59;
								}
								nint num60 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ S0_v179 (Il2CppClass<NGUIText>)+BA]");
								object obj38 = (nint)0 & (nint)0x200;
								bool flag10 = obj38 == null;
								premultiply = false;
								gameObject2 = gameObject;
								if (flag10)
								{
									goto IL_0dee;
								}
								nint num61 = (nint)typeof(NGUIText);
								premultiply = false;
								gameObject2 = gameObject;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ S0_v183 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 != 0)
								{
									goto IL_0dee;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								vector = (Vector3)gameObject;
							}
							else
							{
								num12 = num10;
								vector = (Vector3)gameObject2;
							}
							premultiply = false;
							gameObject2 = (GameObject)vector;
						}
					}
					else
					{
						num12 = num10;
						gameObject2 = gameObject;
					}
				}
				goto IL_0dee;
				IL_0dee:
				char[] array4 = (char[])(obj9 + 1);
				num10 = num12;
				array = array4;
			}
			if (num10 > num11)
			{
				nint num62 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S0_v90 (Il2CppClass<NGUIText>)+BA]");
				object obj39 = (nint)0 & (nint)0x200;
				if (obj39 != null)
				{
					nint num63 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S0_v96 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num64 = num10 - NGUIText.finalSpacingX;
				num11 = num64;
			}
			nint num65 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v66 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj40 = (nint)0 & (nint)0x200;
			if (obj40 != null)
			{
				nint num66 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v85 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Ceiling not resolved\"");
			obj = num11;
			nint num67 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S0_v72 (Il2CppClass<NGUIText>)+BA]");
			object obj41 = (nint)0 & (nint)0x200;
			if (obj41 != null)
			{
				nint num68 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S0_v79 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num69 = num9 + NGUIText.finalLineHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Ceiling not resolved\"");
			obj11 = obj;
		}
		GameObject gameObject3 = (GameObject)obj11;
	}

	public static void UpdateWidgetCollider(GameObject go)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UpdateWidgetCollider(go, considerInactive: false);
	}

	public static void UpdateWidgetCollider(GameObject go, bool considerInactive)
	{
		//IL_069b: Expected I, but got Obj
		//IL_06b1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_0198: Expected I, but got Obj
		//IL_01ae: Expected Obj, but got I
		//IL_00bd: Expected I, but got Obj
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_01d9: Expected I, but got Obj
		//IL_0706: Expected Obj, but got I4
		//IL_0233: Expected I, but got Obj
		//IL_0249: Expected Obj, but got I
		//IL_014b: Expected I, but got Obj
		//IL_035c: Expected I, but got Obj
		//IL_0372: Expected Obj, but got I
		//IL_0274: Expected I, but got Obj
		//IL_0788: Expected Obj, but got I4
		//IL_079a: Expected I, but got Obj
		//IL_07b0: Expected Obj, but got I
		//IL_02c1: Expected I, but got Obj
		//IL_02d7: Expected Obj, but got I
		//IL_07d7: Expected Obj, but got I4
		//IL_039d: Expected I, but got Obj
		//IL_077a: Expected Obj, but got I4
		//IL_080f: Expected Obj, but got I4
		//IL_03ea: Expected I, but got Obj
		//IL_0302: Expected I, but got Obj
		//IL_05ad: Expected I, but got Obj
		//IL_05c3: Expected Obj, but got I
		//IL_049f: Expected VT, but got I4
		//IL_08ca: Expected I, but got Obj
		//IL_08e0: Expected Obj, but got I
		//IL_05ee: Expected I, but got Obj
		//IL_04bf: Expected I, but got Obj
		//IL_04d5: Expected Obj, but got I
		//IL_0947: Expected Obj, but got I4
		//IL_064e: Expected I, but got Obj
		//IL_085e: Expected I, but got Obj
		//IL_0874: Expected Obj, but got I
		//IL_0500: Expected I, but got Obj
		//IL_0935: Expected Obj, but got I4
		//IL_0560: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v148 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)go).FindKernel((string)null) == 0)
		{
			return;
		}
		Collider component = go.GetComponent<Collider>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v144 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			nint num5 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v135 (Il2CppClass<NGUITools>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v140 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UpdateWidgetCollider((UIWidget)(object)computeShader, (BoxCollider)considerInactive);
			return;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v130 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			return;
		}
		BoxCollider2D component2 = go.GetComponent<BoxCollider2D>();
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v34 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v126 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
		{
			nint num11 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v117 (Il2CppClass<NGUITools>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num12 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v122 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			RegisterUndo(component2, (string)considerInactive);
			return;
		}
		bool activeSelf = go.activeSelf;
		nint num13 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S1_v19 (Il2CppClass<UICamera>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num14 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v52 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int direction = UICamera.GetDirection((string)activeSelf);
		nint num15 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v112 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)direction).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v42 (System.Int32)+C]");
			if ((nint)0 != 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v42 (System.Int32)+C]");
				if ((nint)0 != 3)
				{
					goto IL_07f8;
				}
			}
			BoxCollider2D boxCollider2D = go.AddComponent<BoxCollider2D>();
			boxCollider2D.offset = (Vector2)1;
			UIWidget component3 = go.GetComponent<UIWidget>();
			nint num17 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v87 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num18 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v105 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component3).FindKernel((string)null) != 0)
			{
				component3.autoResizeBoxCollider = true;
			}
			nint num19 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v95 (Il2CppClass<NGUITools>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num20 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S0_v100 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			RegisterUndo(boxCollider2D, (string)considerInactive);
			return;
		}
		goto IL_07f8;
		IL_07f8:
		BoxCollider w = go.AddComponent<BoxCollider>();
		Bounds bounds = ((Collider)1).bounds;
		UIWidget component4 = go.GetComponent<UIWidget>();
		nint num21 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num22 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v74 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component4).FindKernel((string)null) != 0)
		{
			component4.autoResizeBoxCollider = true;
		}
		nint num23 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v64 (Il2CppClass<NGUITools>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num24 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v69 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UpdateWidgetCollider((UIWidget)(object)w, (BoxCollider)considerInactive);
	}

	public static void UpdateWidgetCollider(BoxCollider box, bool considerInactive)
	{
		//IL_02b2: Expected I, but got Obj
		//IL_02c8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0196: Expected I, but got Obj
		//IL_01ac: Expected Obj, but got I
		//IL_00ae: Expected I, but got Obj
		//IL_00fb: Expected I, but got Obj
		//IL_0111: Expected Obj, but got I
		//IL_01d7: Expected I, but got Obj
		//IL_031d: Expected Obj, but got I4
		//IL_0224: Expected I, but got Obj
		//IL_023a: Expected Obj, but got I
		//IL_013c: Expected I, but got Obj
		//IL_035b: Expected Obj, but got I4
		//IL_0265: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v59 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)box).FindKernel((string)null) == 0)
		{
			return;
		}
		BoxCollider component = ((GameObject)(object)box).GetComponent<BoxCollider>();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v55 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			nint num5 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v46 (Il2CppClass<NGUITools>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v51 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UpdateWidgetCollider((UIWidget)(object)component, (BoxCollider)considerInactive);
			return;
		}
		BoxCollider2D component2 = ((GameObject)(object)box).GetComponent<BoxCollider2D>();
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v41 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component2).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num9 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v32 (Il2CppClass<NGUITools>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v37 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RegisterUndo(component2, (string)considerInactive);
	}

	public static void UpdateWidgetCollider(UIWidget w)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UpdateWidgetCollider((BoxCollider)(object)w, considerInactive: false);
	}

	public unsafe static void UpdateWidgetCollider(UIWidget w, BoxCollider box)
	{
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected Obj, but got Unknown
		//IL_0482: Expected Obj, but got I4
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected Obj, but got Unknown
		//IL_049f: Expected Obj, but got I4
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04bc: Expected Obj, but got I4
		//IL_04d6: Expected I, but got Obj
		//IL_04ec: Expected Obj, but got I
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected Obj, but got Unknown
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected VT, but got Unknown
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected Obj, but got Unknown
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Expected Obj, but got Unknown
		//IL_0887: Unknown result type (might be due to invalid IL or missing references)
		//IL_088c: Expected Obj, but got Unknown
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected Obj, but got Unknown
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Expected Obj, but got Unknown
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected Obj, but got Unknown
		//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c4: Expected Obj, but got Unknown
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Expected Obj, but got Unknown
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_023b: Expected F4, but got Obj
		//IL_0236: Expected native int or pointer, but got VT
		//IL_024d: Expected F4, but got I
		//IL_0248: Expected native int or pointer, but got VT
		//IL_00c0: Expected I, but got Obj
		//IL_0557: Expected Obj, but got F4
		//IL_056e: Expected Obj, but got F4
		//IL_05c0: Expected Obj, but got I4
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected Obj, but got Unknown
		//IL_05f3: Expected Obj, but got F4
		//IL_0610: Expected Obj, but got I
		//IL_06b2: Expected Obj, but got I4
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected Obj, but got Unknown
		//IL_06f2: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I4
		//IL_02a8: Invalid comparison between I and F4
		//IL_012f: Expected Obj, but got F4
		//IL_02f2: Invalid comparison between I and F4
		//IL_01a1: Expected Obj, but got I4
		//IL_033f: Invalid comparison between I and F4
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected Obj, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected Obj, but got Unknown
		//IL_03bc: Expected I, but got Obj
		//IL_03d2: Expected Obj, but got I
		//IL_0739: Expected F4, but got Obj
		//IL_0734: Expected native int or pointer, but got VT
		//IL_074e: Expected F4, but got I
		//IL_0749: Expected native int or pointer, but got VT
		//IL_077d: Expected VT, but got Obj
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected Obj, but got Unknown
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected Obj, but got Unknown
		//IL_07fe: Expected F4, but got Obj
		//IL_07f9: Expected native int or pointer, but got VT
		//IL_0813: Expected F4, but got I
		//IL_080e: Expected native int or pointer, but got VT
		//IL_083d: Expected VT, but got Obj
		//IL_03fd: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 200;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 184;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 160;
		obj4 = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v195 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoxCollider boxCollider = (BoxCollider)(obj2 + 240);
		Vector3 vector = (Vector3)(obj2 + 216);
		object obj6 = obj2 + 144;
		object obj7 = obj2 + 128;
		object obj8 = obj2 + 112;
		object obj9 = obj2 + 96;
		object obj10 = obj2 + 80;
		object obj11 = obj2 - -64;
		object obj12 = obj2 + 48;
		object obj13 = obj2 + 32;
		object obj14 = obj2 + 16;
		if (((ComputeShader)(object)w).FindKernel((string)null) == 0)
		{
			return;
		}
		string tag = w.tag;
		UIWidget component = ((GameObject)(object)tag).GetComponent<UIWidget>();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v53 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v191 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) == 0)
		{
			int layer = ((GameObject)(object)tag).layer;
			Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds((Transform)layer, (Transform)(object)box);
			obj4 = vector.x;
			_ = vector.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v26 (UnityEngine.Vector3)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			boxCollider = (BoxCollider)obj6;
			BoxCollider boxCollider2 = boxCollider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28+8]");
			((UnityEngine.Object)boxCollider2).m_CachedPtr = (IntPtr)0;
			Vector3 size = boxCollider.size;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
			obj9 = 0;
			_ = 0;
			obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v32+4]");
			_ = 0;
			_ = 0f;
			boxCollider = (BoxCollider)obj9;
			BoxCollider boxCollider3 = boxCollider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v34+8]");
			((UnityEngine.Object)boxCollider3).m_CachedPtr = (IntPtr)0;
			((BoxCollider)(object)w).get_center_Injected(out *(Vector3*)boxCollider);
			return;
		}
		object obj16 = component + 156;
		boxCollider = (BoxCollider)obj16;
		BoxCollider boxCollider4 = boxCollider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S1_v33+8]");
		((UnityEngine.Object)boxCollider4).m_CachedPtr = (IntPtr)0;
		obj = boxCollider;
		_ = ((UnityEngine.Object)boxCollider).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)boxCollider;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)boxCollider).m_CachedPtr;
		if (vector.x == 0f)
		{
			boxCollider = (BoxCollider)obj;
			BoxCollider boxCollider5 = boxCollider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)boxCollider5).m_CachedPtr = (IntPtr)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v24 (UnityEngine.BoxCollider)+4]");
			if (0f == 0f)
			{
				boxCollider = (BoxCollider)obj;
				BoxCollider boxCollider6 = boxCollider;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((UnityEngine.Object)boxCollider6).m_CachedPtr = (IntPtr)0;
				if ((float)(nint)((UnityEngine.Object)boxCollider).m_CachedPtr == 1f)
				{
					boxCollider = (BoxCollider)obj;
					BoxCollider boxCollider7 = boxCollider;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					((UnityEngine.Object)boxCollider7).m_CachedPtr = (IntPtr)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v24 (UnityEngine.BoxCollider)+C]");
					if (0f == 1f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj18 = default;
						object obj17 = obj18 + 16;
						obj6 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S1_v127+8]");
						_ = 0;
						object obj19 = obj18 + 40;
						obj7 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S1_v132+8]");
						_ = 0;
						nint num5 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S0_v141 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj20 = (nint)0 & (nint)0x200;
						if (obj20 != null)
						{
							nint num6 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ S0_v165 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Vector3*)(nint)vector)->x = (float)obj6;
						Vector3 vector2 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28+8]");
						((Vector3*)(nint)vector2)->z = 0f;
						boxCollider = (BoxCollider)obj7;
						BoxCollider boxCollider8 = boxCollider;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v30+8]");
						((UnityEngine.Object)boxCollider8).m_CachedPtr = (IntPtr)0;
						Vector3 vector3 = Vector3.LerpUnclamped(vector, (Vector3)boxCollider, 0.5f);
						boxCollider = (BoxCollider)obj8;
						BoxCollider boxCollider9 = boxCollider;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v32+8]");
						((UnityEngine.Object)boxCollider9).m_CachedPtr = (IntPtr)0;
						Vector3 size2 = boxCollider.size;
						object obj21 = obj18 + 40;
						obj9 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ S1_v152+8]");
						_ = 0;
						object obj22 = obj18 + 16;
						obj10 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S1_v157+8]");
						_ = 0;
						((Vector3*)(nint)vector)->x = (float)obj9;
						Vector3 vector4 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v34+8]");
						((Vector3*)(nint)vector4)->z = 0f;
						boxCollider = (BoxCollider)obj10;
						BoxCollider boxCollider10 = boxCollider;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v36+8]");
						((UnityEngine.Object)boxCollider10).m_CachedPtr = (IntPtr)0;
						Quaternion quaternion = Quaternion.FromToRotation(vector, (Vector3)boxCollider);
						boxCollider = (BoxCollider)obj11;
						BoxCollider boxCollider11 = boxCollider;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v38+8]");
						((UnityEngine.Object)boxCollider11).m_CachedPtr = (IntPtr)0;
						((BoxCollider)(object)w).get_center_Injected(out *(Vector3*)boxCollider);
						return;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		obj3 = vector.x;
		_ = vector.z;
		obj6 = vector.x;
		_ = vector.z;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj10 = 0;
		_ = 0;
		object obj23 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v30+8]");
		object obj24 = obj23 + 0;
		float num7 = (float)obj24 * 0.5f;
		obj10 = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v32+4]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v34+C]");
		object obj25 = num8 + 0;
		float num9 = (float)obj25 * 0.5f;
		_ = 0f;
		boxCollider = (BoxCollider)obj10;
		BoxCollider boxCollider12 = boxCollider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v36+8]");
		((UnityEngine.Object)boxCollider12).m_CachedPtr = (IntPtr)0;
		Vector3 size3 = boxCollider.size;
		obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v38+8]");
		object obj26 = 0 - obj12;
		obj2 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v42+C]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v44+4]");
		object obj27 = num10 - 0;
		_ = 0f;
		boxCollider = (BoxCollider)obj2;
		BoxCollider boxCollider13 = boxCollider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)boxCollider13).m_CachedPtr = (IntPtr)0;
		((BoxCollider)(object)w).get_center_Injected(out *(Vector3*)boxCollider);
	}

	public unsafe static void UpdateWidgetCollider(UIWidget w, BoxCollider2D box)
	{
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected Obj, but got Unknown
		//IL_0371: Expected Obj, but got I4
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_038e: Expected Obj, but got I4
		//IL_03a2: Expected I, but got Obj
		//IL_03b8: Expected Obj, but got I
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Expected Obj, but got Unknown
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected VT, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected Obj, but got Unknown
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Expected Obj, but got Unknown
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected Obj, but got Unknown
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected Obj, but got Unknown
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Expected Obj, but got Unknown
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected Obj, but got Unknown
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected Obj, but got Unknown
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Expected Obj, but got Unknown
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_012a: Expected F4, but got Obj
		//IL_0125: Expected native int or pointer, but got VT
		//IL_013c: Expected F4, but got I
		//IL_0137: Expected native int or pointer, but got VT
		//IL_0417: Expected Obj, but got F4
		//IL_042e: Expected Obj, but got F4
		//IL_0480: Expected Obj, but got I4
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected Obj, but got Unknown
		//IL_04b3: Expected Obj, but got F4
		//IL_04d0: Expected Obj, but got I
		//IL_0572: Expected Obj, but got I4
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected Obj, but got Unknown
		//IL_05b2: Expected Obj, but got I
		//IL_0197: Invalid comparison between I and F4
		//IL_01e1: Invalid comparison between I and F4
		//IL_022e: Invalid comparison between I and F4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_02ab: Expected I, but got Obj
		//IL_02c1: Expected Obj, but got I
		//IL_05f9: Expected F4, but got Obj
		//IL_05f4: Expected native int or pointer, but got VT
		//IL_060e: Expected F4, but got I
		//IL_0609: Expected native int or pointer, but got VT
		//IL_063d: Expected VT, but got Obj
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected Obj, but got Unknown
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected Obj, but got Unknown
		//IL_06be: Expected F4, but got Obj
		//IL_06b9: Expected native int or pointer, but got VT
		//IL_06d3: Expected F4, but got I
		//IL_06ce: Expected native int or pointer, but got VT
		//IL_06fd: Expected VT, but got Obj
		//IL_02ec: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 176;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 160;
		obj3 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v165 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoxCollider boxCollider = (BoxCollider)(obj2 + 208);
		Vector3 vector = (Vector3)(obj2 + 192);
		object obj5 = obj2 + 144;
		object obj6 = obj2 + 128;
		object obj7 = obj2 + 112;
		object obj8 = obj2 + 96;
		object obj9 = obj2 + 80;
		object obj10 = obj2 - -64;
		object obj11 = obj2 + 48;
		object obj12 = obj2 + 32;
		object obj13 = obj2 + 16;
		if (((ComputeShader)(object)box).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v46 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v161 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)w).FindKernel((string)null) == 0)
		{
			return;
		}
		object obj15 = w + 156;
		boxCollider = (BoxCollider)obj15;
		BoxCollider boxCollider2 = boxCollider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v26+8]");
		((UnityEngine.Object)boxCollider2).m_CachedPtr = (IntPtr)0;
		obj = boxCollider;
		_ = ((UnityEngine.Object)boxCollider).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)boxCollider;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)boxCollider).m_CachedPtr;
		if (vector.x == 0f)
		{
			boxCollider = (BoxCollider)obj;
			BoxCollider boxCollider3 = boxCollider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)boxCollider3).m_CachedPtr = (IntPtr)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20 (UnityEngine.BoxCollider)+4]");
			if (0f == 0f)
			{
				boxCollider = (BoxCollider)obj;
				BoxCollider boxCollider4 = boxCollider;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((UnityEngine.Object)boxCollider4).m_CachedPtr = (IntPtr)0;
				if ((float)(nint)((UnityEngine.Object)boxCollider).m_CachedPtr == 1f)
				{
					boxCollider = (BoxCollider)obj;
					BoxCollider boxCollider5 = boxCollider;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					((UnityEngine.Object)boxCollider5).m_CachedPtr = (IntPtr)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20 (UnityEngine.BoxCollider)+C]");
					if (0f == 1f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj17 = default;
						object obj16 = obj17 + 16;
						obj5 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ S1_v120+8]");
						_ = 0;
						object obj18 = obj17 + 40;
						obj6 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S1_v125+8]");
						_ = 0;
						nint num5 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S0_v133 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj19 = (nint)0 & (nint)0x200;
						if (obj19 != null)
						{
							nint num6 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S0_v157 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Vector3*)(nint)vector)->x = (float)obj5;
						Vector3 vector2 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v24+8]");
						((Vector3*)(nint)vector2)->z = 0f;
						boxCollider = (BoxCollider)obj6;
						BoxCollider boxCollider6 = boxCollider;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v26+8]");
						((UnityEngine.Object)boxCollider6).m_CachedPtr = (IntPtr)0;
						Vector3 vector3 = Vector3.LerpUnclamped(vector, (Vector3)boxCollider, 0.5f);
						boxCollider = (BoxCollider)obj7;
						BoxCollider boxCollider7 = boxCollider;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v28+8]");
						((UnityEngine.Object)boxCollider7).m_CachedPtr = (IntPtr)0;
						Vector3 size = boxCollider.size;
						object obj20 = obj17 + 40;
						obj8 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S1_v145+8]");
						_ = 0;
						object obj21 = obj17 + 16;
						obj9 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S1_v150+8]");
						_ = 0;
						((Vector3*)(nint)vector)->x = (float)obj8;
						Vector3 vector4 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v30+8]");
						((Vector3*)(nint)vector4)->z = 0f;
						boxCollider = (BoxCollider)obj9;
						BoxCollider boxCollider8 = boxCollider;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v32+8]");
						((UnityEngine.Object)boxCollider8).m_CachedPtr = (IntPtr)0;
						Quaternion quaternion = Quaternion.FromToRotation(vector, (Vector3)boxCollider);
						boxCollider = (BoxCollider)obj10;
						BoxCollider boxCollider9 = boxCollider;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v34+8]");
						((UnityEngine.Object)boxCollider9).m_CachedPtr = (IntPtr)0;
						((BoxCollider)(object)box).get_center_Injected(out *(Vector3*)boxCollider);
						return;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		obj3 = vector.x;
		_ = vector.z;
		obj5 = vector.x;
		_ = vector.z;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj9 = 0;
		_ = 0;
		object obj22 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v26+8]");
		object obj23 = obj22 + 0;
		float num7 = (float)obj23 * 0.5f;
		obj9 = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v28+4]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v30+C]");
		object obj24 = num8 + 0;
		float num9 = (float)obj24 * 0.5f;
		_ = 0f;
		boxCollider = (BoxCollider)obj9;
		BoxCollider boxCollider10 = boxCollider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v32+8]");
		((UnityEngine.Object)boxCollider10).m_CachedPtr = (IntPtr)0;
		Vector3 size2 = boxCollider.size;
		obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v34+8]");
		object obj25 = 0 - obj11;
		obj2 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v38+C]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v40+4]");
		object obj26 = num10 - 0;
		_ = 0f;
		boxCollider = (BoxCollider)obj2;
		BoxCollider boxCollider11 = boxCollider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)boxCollider11).m_CachedPtr = (IntPtr)0;
		((BoxCollider)(object)box).get_center_Injected(out *(Vector3*)boxCollider);
	}

	public unsafe static void UpdateWidgetCollider(BoxCollider2D box, bool considerInactive)
	{
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected Obj, but got Unknown
		//IL_044a: Expected Obj, but got I4
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected Obj, but got Unknown
		//IL_0467: Expected Obj, but got I4
		//IL_047b: Expected I, but got Obj
		//IL_0491: Expected Obj, but got I
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected VT, but got Unknown
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected VT, but got Unknown
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected Obj, but got Unknown
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected Obj, but got Unknown
		//IL_08c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Expected Obj, but got Unknown
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected Obj, but got Unknown
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Expected Obj, but got Unknown
		//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Expected Obj, but got Unknown
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Expected Obj, but got Unknown
		//IL_090e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Expected Obj, but got Unknown
		//IL_091c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0921: Expected Obj, but got Unknown
		//IL_092a: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected Obj, but got Unknown
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Expected Obj, but got Unknown
		//IL_0946: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Expected Obj, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Expected Obj, but got Unknown
		//IL_0963: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_00fb: Expected F4, but got Obj
		//IL_00f6: Expected native int or pointer, but got VT
		//IL_0115: Expected Obj, but got F4
		//IL_012f: Expected native int or pointer, but got VT
		//IL_0149: Expected F4, but got I
		//IL_0144: Expected native int or pointer, but got VT
		//IL_04f0: Expected Obj, but got F4
		//IL_0507: Expected Obj, but got F4
		//IL_0559: Expected Obj, but got I4
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected Obj, but got Unknown
		//IL_058c: Expected Obj, but got F4
		//IL_05a9: Expected Obj, but got I
		//IL_05d2: Expected I, but got Obj
		//IL_05e8: Expected Obj, but got I
		//IL_077f: Expected F4, but got Obj
		//IL_077a: Expected native int or pointer, but got VT
		//IL_07a6: Expected F4, but got Obj
		//IL_07a1: Expected native int or pointer, but got VT
		//IL_07b3: Expected Ref, but got VT
		//IL_07b3: Expected Obj, but got I4
		//IL_0810: Expected Obj, but got I4
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected Obj, but got Unknown
		//IL_0850: Expected Obj, but got I
		//IL_0868: Expected F4, but got Obj
		//IL_0863: Expected native int or pointer, but got VT
		//IL_0183: Expected F4, but got Obj
		//IL_017e: Expected native int or pointer, but got VT
		//IL_0421: Expected F4, but got Obj
		//IL_041c: Expected native int or pointer, but got VT
		//IL_042e: Expected Ref, but got VT
		//IL_042e: Expected Obj, but got I4
		//IL_03d5: Expected I, but got Obj
		//IL_01ca: Expected F4, but got Obj
		//IL_01c5: Expected native int or pointer, but got VT
		//IL_01e8: Invalid comparison between I and F4
		//IL_0214: Expected F4, but got Obj
		//IL_020f: Expected native int or pointer, but got VT
		//IL_0232: Invalid comparison between I and F4
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_02af: Expected I, but got Obj
		//IL_02c5: Expected Obj, but got I
		//IL_0612: Expected F4, but got Obj
		//IL_060d: Expected native int or pointer, but got VT
		//IL_0627: Expected F4, but got I
		//IL_0622: Expected native int or pointer, but got VT
		//IL_0634: Expected F4, but got Obj
		//IL_062f: Expected native int or pointer, but got VT
		//IL_0665: Expected I, but got Obj
		//IL_067b: Expected Obj, but got I
		//IL_06a5: Expected F4, but got Obj
		//IL_06a0: Expected native int or pointer, but got VT
		//IL_06cc: Expected F4, but got Obj
		//IL_06c7: Expected native int or pointer, but got VT
		//IL_06d9: Expected Ref, but got VT
		//IL_06d9: Expected Obj, but got I4
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected Obj, but got Unknown
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected Obj, but got Unknown
		//IL_072c: Expected F4, but got Obj
		//IL_0727: Expected native int or pointer, but got VT
		//IL_0741: Expected F4, but got I
		//IL_073c: Expected native int or pointer, but got VT
		//IL_074e: Expected F4, but got Obj
		//IL_0749: Expected native int or pointer, but got VT
		//IL_02f0: Expected I, but got Obj
		//IL_0389: Expected F4, but got Obj
		//IL_0384: Expected native int or pointer, but got VT
		//IL_03b0: Expected F4, but got Obj
		//IL_03ab: Expected native int or pointer, but got VT
		//IL_03bd: Expected Ref, but got VT
		//IL_03bd: Expected Obj, but got I4
		//IL_033d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 208;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 192;
		obj3 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v199 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 vector = (Vector2)(obj2 + 240);
		Vector3 vector2 = (Vector3)(obj2 + 224);
		object obj5 = obj2 + 176;
		object obj6 = obj2 + 160;
		object obj7 = obj2 + 144;
		object obj8 = obj2 + 128;
		object obj9 = obj2 + 112;
		object obj10 = obj2 + 24;
		object obj11 = obj2 + 96;
		object obj12 = obj2 + 80;
		object obj13 = obj2 - -64;
		object obj14 = obj2 + 48;
		object obj15 = obj2 + 32;
		object obj16 = obj2 + 16;
		object obj17 = obj2 + 8;
		if (((ComputeShader)considerInactive).FindKernel(null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v54 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v195 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)box).FindKernel((string)null) == 0)
		{
			return;
		}
		object obj19 = box + 156;
		((Vector2*)(nint)vector)->x = (float)obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v30+8]");
		_ = 0;
		obj = vector.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20 (UnityEngine.Vector2)+8]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = vector.x;
		Vector3 vector3 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20 (UnityEngine.Vector2)+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		if (vector2.x == 0f)
		{
			((Vector2*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			if (vector.y == 0f)
			{
				((Vector2*)(nint)vector)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20 (UnityEngine.Vector2)+8]");
				if (0f == 1f)
				{
					((Vector2*)(nint)vector)->x = (float)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20 (UnityEngine.Vector2)+C]");
					if (0f == 1f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj21 = default;
						object obj20 = obj21 + 16;
						obj5 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S1_v131+8]");
						_ = 0;
						object obj22 = obj21 + 40;
						obj6 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S1_v136+8]");
						_ = 0;
						nint num5 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S0_v154 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj23 = (nint)0 & (nint)0x200;
						if (obj23 != null)
						{
							nint num6 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S0_v191 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Vector3*)(nint)vector2)->x = (float)obj5;
						Vector3 vector4 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v24+8]");
						((Vector3*)(nint)vector4)->z = 0f;
						((Vector2*)(nint)vector)->x = (float)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v26+8]");
						_ = 0;
						Vector3 vector5 = Vector3.LerpUnclamped(vector2, vector, 0.5f);
						nint num7 = (nint)typeof(Vector2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S0_v164 (Il2CppClass<UnityEngine.Vector2>)+BA]");
						object obj24 = (nint)0 & (nint)0x200;
						if (obj24 != null)
						{
							nint num8 = (nint)typeof(Vector2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S0_v187 (Il2CppClass<UnityEngine.Vector2>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Vector2*)(nint)vector)->x = (float)obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v28+8]");
						_ = 0;
						Vector3 vector6 = vector;
						((Vector2*)(nint)vector)->x = (float)obj17;
						((Collider2D)considerInactive).set_offset_Injected(ref *(Vector2*)vector);
						object obj25 = obj21 + 40;
						obj8 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ S1_v160+8]");
						_ = 0;
						object obj26 = obj21 + 16;
						obj9 = obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S1_v165+8]");
						_ = 0;
						((Vector3*)(nint)vector2)->x = (float)obj8;
						Vector3 vector7 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v30+8]");
						((Vector3*)(nint)vector7)->z = 0f;
						((Vector2*)(nint)vector)->x = (float)obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v32+8]");
						_ = 0;
						Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
						((Vector2*)(nint)vector)->x = (float)obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v36+8]");
						_ = 0;
						Vector3 vector8 = vector;
						((Vector2*)(nint)vector)->x = (float)obj2;
						((BoxCollider2D)considerInactive).set_size_Injected(ref *(Vector2*)vector);
						return;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		obj3 = vector2.x;
		_ = vector2.z;
		obj5 = vector2.x;
		_ = vector2.z;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj9 = 0;
		_ = 0;
		object obj27 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v26+8]");
		object obj28 = obj27 + 0;
		float num9 = (float)obj28 * 0.5f;
		obj9 = num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v28+4]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v30+C]");
		object obj29 = num10 + 0;
		float num11 = (float)obj29 * 0.5f;
		_ = 0f;
		nint num12 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S0_v95 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num13 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v130 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector2*)(nint)vector)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v32+8]");
		_ = 0;
		Vector3 vector9 = vector;
		((Vector2*)(nint)vector)->x = (float)obj10;
		((Collider2D)considerInactive).set_offset_Injected(ref *(Vector2*)vector);
		obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj15 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v36+8]");
		object obj31 = 0 - obj12;
		obj15 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v40+C]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v42+4]");
		object obj32 = num14 - 0;
		_ = 0f;
		((Vector2*)(nint)vector)->x = (float)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v44+8]");
		_ = 0;
		Vector3 vector10 = vector;
		((Vector2*)(nint)vector)->x = (float)obj16;
		((BoxCollider2D)considerInactive).set_size_Injected(ref *(Vector2*)vector);
	}

	public unsafe static string GetTypeName<T>()
	{
		//IL_00b2: Expected Obj, but got I
		//IL_00c8: Expected I, but got Obj
		//IL_00de: Expected Obj, but got I
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected I, but got Unknown
		//IL_014c: Expected I, but got Obj
		//IL_0167: Expected I, but got Obj
		//IL_017d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v24 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2;
		nint num4 = (nint)(obj4 + 4);
		((IntPtr*)num4)->m_value = (void*)(nint)obj4;
		Type type = Type.internal_from_handle((IntPtr)num4);
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HideFlags hideFlags = ((UnityEngine.Object)(object)type).hideFlags;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		string result = default;
		return result;
	}

	public static string GetTypeName(UnityEngine.Object obj)
	{
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_03ae: Expected Obj, but got I4
		//IL_03b7: Expected Obj, but got I4
		//IL_0475: Expected I, but got Obj
		//IL_048b: Expected Obj, but got I
		//IL_0194: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01d5: Expected I, but got Obj
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected Obj, but got Unknown
		//IL_040e: Expected I, but got Obj
		//IL_0424: Expected Obj, but got I
		//IL_0272: Expected Obj, but got I4
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected I4, but got Unknown
		//IL_0236: Expected I4, but got Obj
		//IL_044a: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_04ad: Expected Obj, but got I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_00ee: Expected I, but got Obj
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_02bc: Expected I, but got Obj
		//IL_02d2: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected I4, but got Unknown
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected Obj, but got Unknown
		//IL_02fd: Expected I, but got Obj
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected I4, but got Unknown
		//IL_0384: Expected I4, but got Obj
		object obj2 = obj & 0x1F;
		object obj3 = 1 << (int)obj2;
		object obj4 = 0;
		bool flag2;
		UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper scriptableRuntimeReflectionSystemWrapper = default;
		while (true)
		{
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v10 (Il2CppClass<UICamera>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v105 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<UICamera> list = UICamera.list;
			if ((nint)obj4 < list.size)
			{
				nint num3 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v70 (Il2CppClass<UICamera>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num4 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v99 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BetterList<UICamera> list2 = UICamera.list;
				object obj7 = list2.buffer + 16;
				object obj8 = obj4 << 2;
				object go = obj7 + obj8;
				bool flag = UICamera.IsPartOfUI((GameObject)go);
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v83 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v95 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)flag))
				{
					int eventMask = ((Camera)flag).eventMask;
					if ((eventMask & obj3) != 0)
					{
						flag2 = flag;
						break;
					}
				}
				object obj10 = obj4 + 1;
				obj4 = obj10;
				continue;
			}
			Camera current = Camera.current;
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v65 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)current))
			{
				int eventMask2 = current.eventMask;
				int num9 = eventMask2 & obj3;
				flag2 = (byte)(int)current != 0;
				if (num9 != 0)
				{
					break;
				}
			}
			int allCamerasCount = Camera.allCamerasCount;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			IScriptableRuntimeReflectionSystem implementation = scriptableRuntimeReflectionSystemWrapper.implementation;
			object obj12 = 0;
			while (true)
			{
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) >= System.Runtime.CompilerServices.Unsafe.As<IScriptableRuntimeReflectionSystem, UIntPtr>(ref implementation))
				{
					flag2 = false;
					break;
				}
				object obj13 = scriptableRuntimeReflectionSystemWrapper + 16;
				object obj14 = obj12 << 2;
				object obj15 = obj13 + obj14;
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num11 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v57 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)obj15) && ((Behaviour)obj15).isActiveAndEnabled)
				{
					int eventMask3 = ((Camera)obj15).eventMask;
					int num12 = eventMask3 & obj3;
					flag2 = (byte)(int)obj15 != 0;
					if (num12 != 0)
					{
						break;
					}
				}
				object obj17 = obj12 + 1;
				obj12 = obj17;
			}
			break;
		}
		return (string)flag2;
	}

	public unsafe static void RegisterUndo(UnityEngine.Object obj, string name)
	{
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected Obj, but got Unknown
		//IL_059c: Expected Obj, but got I4
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected Obj, but got Unknown
		//IL_05b9: Expected Obj, but got I4
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected Obj, but got Unknown
		//IL_05d6: Expected Obj, but got I4
		//IL_05f0: Expected I, but got Obj
		//IL_0606: Expected Obj, but got I
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a65: Expected VT, but got Unknown
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Expected VT, but got Unknown
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a81: Expected Obj, but got Unknown
		//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8f: Expected Obj, but got Unknown
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Expected Obj, but got Unknown
		//IL_0aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aab: Expected Obj, but got Unknown
		//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab9: Expected Obj, but got Unknown
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Expected Obj, but got Unknown
		//IL_0ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad5: Expected Obj, but got Unknown
		//IL_0ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae3: Expected Obj, but got Unknown
		//IL_0aec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af1: Expected Obj, but got Unknown
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Expected Obj, but got Unknown
		//IL_0b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0d: Expected Obj, but got Unknown
		//IL_0b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1b: Expected Obj, but got Unknown
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Expected Obj, but got Unknown
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected Obj, but got Unknown
		//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_024d: Expected F4, but got Obj
		//IL_0248: Expected native int or pointer, but got VT
		//IL_0267: Expected Obj, but got F4
		//IL_0281: Expected native int or pointer, but got VT
		//IL_029b: Expected F4, but got I
		//IL_0296: Expected native int or pointer, but got VT
		//IL_00c0: Expected I, but got Obj
		//IL_06c1: Expected Obj, but got F4
		//IL_06d8: Expected Obj, but got F4
		//IL_072a: Expected Obj, but got I4
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected Obj, but got Unknown
		//IL_075d: Expected Obj, but got F4
		//IL_077a: Expected Obj, but got I
		//IL_07a3: Expected I, but got Obj
		//IL_07b9: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I4
		//IL_094f: Expected F4, but got Obj
		//IL_094a: Expected native int or pointer, but got VT
		//IL_0976: Expected F4, but got Obj
		//IL_0971: Expected native int or pointer, but got VT
		//IL_0983: Expected Ref, but got VT
		//IL_09e0: Expected Obj, but got I4
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fb: Expected Obj, but got Unknown
		//IL_0a20: Expected Obj, but got I
		//IL_0a38: Expected F4, but got Obj
		//IL_0a33: Expected native int or pointer, but got VT
		//IL_02d5: Expected F4, but got Obj
		//IL_02d0: Expected native int or pointer, but got VT
		//IL_012f: Expected Obj, but got F4
		//IL_015e: Expected I, but got Obj
		//IL_0174: Expected Obj, but got I
		//IL_0573: Expected F4, but got Obj
		//IL_056e: Expected native int or pointer, but got VT
		//IL_0580: Expected Ref, but got VT
		//IL_0527: Expected I, but got Obj
		//IL_0666: Expected F4, but got Obj
		//IL_0661: Expected native int or pointer, but got VT
		//IL_068d: Expected F4, but got Obj
		//IL_0688: Expected native int or pointer, but got VT
		//IL_069a: Expected Ref, but got VT
		//IL_031c: Expected F4, but got Obj
		//IL_0317: Expected native int or pointer, but got VT
		//IL_033a: Invalid comparison between I and F4
		//IL_01f1: Expected Obj, but got I4
		//IL_021b: Expected F4, but got Obj
		//IL_0216: Expected native int or pointer, but got VT
		//IL_0228: Expected Ref, but got VT
		//IL_019f: Expected I, but got Obj
		//IL_0366: Expected F4, but got Obj
		//IL_0361: Expected native int or pointer, but got VT
		//IL_0384: Invalid comparison between I and F4
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_0401: Expected I, but got Obj
		//IL_0417: Expected Obj, but got I
		//IL_07e3: Expected F4, but got Obj
		//IL_07de: Expected native int or pointer, but got VT
		//IL_07f8: Expected F4, but got I
		//IL_07f3: Expected native int or pointer, but got VT
		//IL_0805: Expected F4, but got Obj
		//IL_0800: Expected native int or pointer, but got VT
		//IL_0836: Expected I, but got Obj
		//IL_084c: Expected Obj, but got I
		//IL_0876: Expected F4, but got Obj
		//IL_0871: Expected native int or pointer, but got VT
		//IL_089d: Expected F4, but got Obj
		//IL_0898: Expected native int or pointer, but got VT
		//IL_08aa: Expected Ref, but got VT
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected Obj, but got Unknown
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected Obj, but got Unknown
		//IL_08fd: Expected F4, but got Obj
		//IL_08f8: Expected native int or pointer, but got VT
		//IL_0912: Expected F4, but got I
		//IL_090d: Expected native int or pointer, but got VT
		//IL_091f: Expected F4, but got Obj
		//IL_091a: Expected native int or pointer, but got VT
		//IL_0442: Expected I, but got Obj
		//IL_04db: Expected F4, but got Obj
		//IL_04d6: Expected native int or pointer, but got VT
		//IL_0502: Expected F4, but got Obj
		//IL_04fd: Expected native int or pointer, but got VT
		//IL_050f: Expected Ref, but got VT
		//IL_048f: Expected I, but got Obj
		object obj3 = default;
		object obj2 = obj3 + 248;
		obj2 = 0;
		_ = 0;
		object obj4 = obj3 + 232;
		obj4 = 0;
		_ = 0;
		object obj5 = obj3 + 208;
		obj5 = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v242 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 vector = (Vector2)(obj3 + 288);
		Vector3 vector2 = (Vector3)(obj3 + 264);
		object obj7 = obj3 + 192;
		object obj8 = obj3 + 176;
		object obj9 = obj3 + 160;
		object obj10 = obj3 + 144;
		object obj11 = obj3 + 56;
		object obj12 = obj3 + 128;
		object obj13 = obj3 + 112;
		object obj14 = obj3 + 96;
		object obj15 = obj3 + 80;
		object obj16 = obj3 - -64;
		object obj17 = obj3 + 48;
		object obj18 = obj3 + 40;
		object obj19 = obj3 + 32;
		object obj20 = obj3 + 24;
		object obj21 = obj3 + 16;
		if (((ComputeShader)obj).FindKernel((string)null) == 0)
		{
			return;
		}
		string tag = ((Component)obj).tag;
		UIWidget component = ((GameObject)(object)tag).GetComponent<UIWidget>();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v65 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v238 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) == 0)
		{
			int layer = ((GameObject)(object)tag).layer;
			Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds((Transform)layer, (Transform)(object)name);
			obj5 = vector2.x;
			_ = vector2.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v26 (UnityEngine.Vector3)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
			nint num5 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S0_v213 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num6 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v234 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector2*)(nint)vector)->x = (float)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28+8]");
			_ = 0;
			Vector3 vector3 = vector;
			((Vector2*)(nint)vector)->x = (float)obj20;
			((Collider2D)obj).set_offset_Injected(ref *(Vector2*)vector);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
			obj3 = 0;
			obj3 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v32+4]");
			_ = 0;
			obj21 = obj3;
			((Vector2*)(nint)vector)->x = (float)obj21;
			((BoxCollider2D)obj).set_size_Injected(ref *(Vector2*)vector);
			return;
		}
		object obj24 = component + 156;
		((Vector2*)(nint)vector)->x = (float)obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S1_v39+8]");
		_ = 0;
		obj2 = vector.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v24 (UnityEngine.Vector2)+8]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = vector.x;
		Vector3 vector4 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v24 (UnityEngine.Vector2)+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		if (vector2.x == 0f)
		{
			((Vector2*)(nint)vector)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			if (vector.y == 0f)
			{
				((Vector2*)(nint)vector)->x = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v24 (UnityEngine.Vector2)+8]");
				if (0f == 1f)
				{
					((Vector2*)(nint)vector)->x = (float)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v24 (UnityEngine.Vector2)+C]");
					if (0f == 1f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj26 = default;
						object obj25 = obj26 + 16;
						obj7 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S1_v140+8]");
						_ = 0;
						object obj27 = obj26 + 40;
						obj8 = obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ S1_v145+8]");
						_ = 0;
						nint num7 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ S0_v166 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj28 = (nint)0 & (nint)0x200;
						if (obj28 != null)
						{
							nint num8 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ S0_v203 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Vector3*)(nint)vector2)->x = (float)obj7;
						Vector3 vector5 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28+8]");
						((Vector3*)(nint)vector5)->z = 0f;
						((Vector2*)(nint)vector)->x = (float)obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v30+8]");
						_ = 0;
						Vector3 vector6 = Vector3.LerpUnclamped(vector2, vector, 0.5f);
						nint num9 = (nint)typeof(Vector2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ S0_v176 (Il2CppClass<UnityEngine.Vector2>)+BA]");
						object obj29 = (nint)0 & (nint)0x200;
						if (obj29 != null)
						{
							nint num10 = (nint)typeof(Vector2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S0_v199 (Il2CppClass<UnityEngine.Vector2>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Vector2*)(nint)vector)->x = (float)obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v32+8]");
						_ = 0;
						Vector3 vector7 = vector;
						((Vector2*)(nint)vector)->x = (float)obj18;
						((Collider2D)obj).set_offset_Injected(ref *(Vector2*)vector);
						object obj30 = obj26 + 40;
						obj3 = obj30;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ S1_v169+8]");
						_ = 0;
						object obj31 = obj26 + 16;
						obj10 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ S1_v174+8]");
						_ = 0;
						((Vector3*)(nint)vector2)->x = (float)obj3;
						Vector3 vector8 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Vector3*)(nint)vector8)->z = 0f;
						((Vector2*)(nint)vector)->x = (float)obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v34+8]");
						_ = 0;
						Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
						((Vector2*)(nint)vector)->x = (float)obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v38+8]");
						_ = 0;
						Vector3 vector9 = vector;
						((Vector2*)(nint)vector)->x = (float)obj19;
						((BoxCollider2D)obj).set_size_Injected(ref *(Vector2*)vector);
						return;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		obj4 = vector2.x;
		_ = vector2.z;
		obj7 = vector2.x;
		_ = vector2.z;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj10 = 0;
		_ = 0;
		object obj32 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v30+8]");
		object obj33 = obj32 + 0;
		float num11 = (float)obj33 * 0.5f;
		obj10 = num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v32+4]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
		object obj34 = num12 + 0;
		float num13 = (float)obj34 * 0.5f;
		_ = 0f;
		nint num14 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S0_v107 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj35 = (nint)0 & (nint)0x200;
		if (obj35 != null)
		{
			nint num15 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S0_v142 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector2*)(nint)vector)->x = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v34+8]");
		_ = 0;
		Vector3 vector10 = vector;
		((Vector2*)(nint)vector)->x = (float)obj11;
		((Collider2D)obj).set_offset_Injected(ref *(Vector2*)vector);
		obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj13 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj14 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj15 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj16 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v38+8]");
		object obj36 = 0 - obj13;
		obj16 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v42+C]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v44+4]");
		object obj37 = num16 - 0;
		_ = 0f;
		((Vector2*)(nint)vector)->x = (float)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v46+8]");
		_ = 0;
		Vector3 vector11 = vector;
		((Vector2*)(nint)vector)->x = (float)obj17;
		((BoxCollider2D)obj).set_size_Injected(ref *(Vector2*)vector);
	}

	public static void SetDirty(UnityEngine.Object obj, string undoName = "last change")
	{
	}

	public static GameObject AddChildAsFirstSibling(GameObject parent, GameObject prefab)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected I4, but got Unknown
		//IL_004f: Expected I4, but got Obj
		//IL_005b: Expected Obj, but got I4
		if ((object)parent == prefab)
		{
			return parent;
		}
		int max = prefab + 1;
		int num = UnityEngine.Random.RandomRangeInt((int)parent, max);
		return (GameObject)num;
	}

	public static GameObject AddChild(GameObject parent)
	{
		//IL_012b: Expected I, but got Obj
		//IL_0141: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject result;
		if (parent != null)
		{
			result = (GameObject)(object)"Null";
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string text2 = default;
			string text = text2.ToLower((CultureInfo)(object)"UI");
			if (text != null)
			{
				string text3 = text2.Trim((char[])2);
				result = (GameObject)(object)text3;
			}
			else
			{
				string text4 = text2.ToLower((CultureInfo)(object)"UnityEngine.");
				bool flag = text4 == null;
				result = (GameObject)(object)text2;
				if (!flag)
				{
					string text5 = text2.Trim((char[])12);
					result = (GameObject)(object)text5;
				}
			}
		}
		return result;
	}

	public static GameObject AddChild(GameObject parent, int layer)
	{
		//IL_0065: Expected I, but got Obj
		//IL_007b: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = CalculateNextDepth(parent, (byte)layer != 0);
		int layer2 = ((GameObject)num3).layer;
		((Transform)layer2).SetAsLastSibling();
		return (GameObject)num3;
	}

	public static GameObject AddChild(GameObject parent, bool undo)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return AddChild(parent, null, undo ? 1 : 0);
	}

	public unsafe static GameObject AddChild(GameObject parent, bool undo, int layer)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUIText>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (GameObject)NGUIText.ReplaceLink(ref *(string*)parent, ref *(undo ? ((int*)1) : ((int*)null)), null, (string)layer);
	}

	public static GameObject AddChild(GameObject parent, GameObject prefab)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return AddChild(parent, null, -1);
	}

	public static GameObject AddChild(GameObject parent, GameObject prefab, int layer)
	{
		//IL_022a: Expected I, but got Obj
		//IL_0240: Expected Obj, but got I
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_007e: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I4
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_02f3: Expected I, but got Obj
		//IL_0309: Expected Obj, but got I
		//IL_00cd: Expected I, but got Obj
		//IL_0183: Expected Obj, but got I4
		//IL_011a: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Stream stream = default;
		UnityEngine.ManagedStreamHelpers.ValidateLoadFromStream(stream);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v65 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 48);
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 16;
		if (((ComputeShader)(object)parent).FindKernel((string)null) != 0)
		{
			int layer2 = ((GameObject)(object)stream).layer;
			int layer3 = parent.layer;
			((Transform)layer2).parentInternal = (Transform)layer3;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v30 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v61 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			transform = (Transform)obj3;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			nint num5 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v39 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v57 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 zero = Vector2.zero;
			transform = (Transform)obj4;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 localScale = transform.localScale;
			Vector3 forward = Vector3.forward;
			transform = (Transform)obj2;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			((Transform)layer2).parent = transform;
			if (layer == -1)
			{
				bool activeSelf = parent.activeSelf;
				((GameObject)(object)stream).SetActive(activeSelf);
			}
			else if (layer < 32)
			{
				((GameObject)(object)stream).SetActive((byte)layer != 0);
			}
		}
		return (GameObject)(object)stream;
	}

	public static int CalculateRaycastDepth(GameObject go)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a6: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (int)AddChild(go, null, -1);
	}

	public static int CalculateNextDepth(GameObject go)
	{
		//IL_0220: Expected I, but got Obj
		//IL_0236: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I4
		//IL_029a: Expected I4, but got Obj
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0177: Expected I, but got Obj
		//IL_018d: Expected Obj, but got I
		//IL_01b8: Expected I, but got Obj
		UIWidget component = go.GetComponent<UIWidget>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v53 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3[] array;
		Vector3[] array2;
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			array = component.localCorners;
		}
		else
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v5 (Il2CppMethodInfo)+18]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51 @ S3_v6 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v18+C]");
			if ((nint)0 != 0)
			{
				array2 = (Vector3[])int.MaxValue;
				object obj6 = 0;
				object obj9 = default;
				while (true)
				{
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v18+C]");
					if ((nint)obj7 >= 0)
					{
						break;
					}
					object obj8 = obj9 + 16;
					object obj10 = obj6 << 2;
					object obj11 = obj8 + obj10;
					if (((Behaviour)obj11).isActiveAndEnabled)
					{
						object obj12 = obj9 + 16;
						object obj13 = obj6 << 2;
						object obj14 = obj12 + obj13;
						Vector3[] localCorners = ((UIWidget)obj14).localCorners;
						nint num4 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v40 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						if (obj15 != null)
						{
							nint num5 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v47 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (System.Runtime.CompilerServices.Unsafe.As<Vector3[], UIntPtr>(ref array2) >= System.Runtime.CompilerServices.Unsafe.As<Vector3[], UIntPtr>(ref localCorners))
						{
							array2 = localCorners;
						}
					}
					object obj16 = obj6 + 1;
					obj6 = obj16;
				}
				goto IL_0295;
			}
			array = null;
		}
		array2 = array;
		goto IL_0295;
		IL_0295:
		return (int)array2;
	}

	public static int CalculateNextDepth(GameObject go, bool ignoreChildrenWithColliders)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a9: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (int)CreateUI((Transform)(object)go, ignoreChildrenWithColliders, -1);
	}

	public static int AdjustDepth(GameObject go, int adjustment)
	{
		//IL_040b: Expected I, but got Obj
		//IL_0421: Expected Obj, but got I
		//IL_0378: Expected I, but got Obj
		//IL_038e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0523: Expected I4, but got Obj
		//IL_052f: Expected I4, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009f: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_03b9: Expected I, but got Obj
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected I4, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00f9: Expected I, but got Obj
		//IL_010f: Expected Obj, but got I
		//IL_02c2: Expected I, but got Obj
		//IL_02d8: Expected Obj, but got I
		//IL_013a: Expected I, but got Obj
		//IL_0194: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected Obj, but got Unknown
		//IL_0303: Expected I, but got Obj
		//IL_0352: Expected Obj, but got I
		//IL_01d5: Expected I, but got Obj
		//IL_022f: Expected I, but got Obj
		//IL_0245: Expected Obj, but got I
		//IL_0270: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v79 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)go);
		if (((flag ? 1u : 0u) & (uint)adjustment) != 0)
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v3 (Il2CppMethodInfo)+18]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S3_v5 (should have been resolved before IL gen)");
			object obj6 = 0;
			object obj7 = -1;
			object obj10 = default;
			while (true)
			{
				object obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v26+C]");
				if ((nint)obj8 >= 0)
				{
					break;
				}
				object obj9 = obj10 + 16;
				object obj11 = obj6 << 2;
				object obj12 = obj9 + obj11;
				UIRect uIRect = (UIRect)obj12;
				Transform cachedTransform = ((UIRect)obj12).cachedTransform;
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v41 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v75 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)cachedTransform).FindKernel((string)(object)go) != 0)
				{
					Collider component = ((Component)obj12).GetComponent<Collider>();
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num7 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
					{
						goto IL_04cd;
					}
					Collider2D component2 = ((Component)obj12).GetComponent<Collider2D>();
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num9 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
					{
						goto IL_04cd;
					}
				}
				nint num10 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v55 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num11 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v62 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj17 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v38 (UIRect)+6C]");
				if ((nint)obj17 <= 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v38 (UIRect)+6C]");
					obj7 = 0;
				}
				goto IL_04cd;
				IL_04cd:
				object obj18 = obj6 + 1;
				obj6 = obj18;
			}
			return obj7 + 1;
		}
		nint num12 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v15 (Il2CppClass<NGUITools>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num13 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v21 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIPanel uIPanel = CreateUI((byte)(int)go != 0);
		return (int)uIPanel;
	}

	public static void BringForward(GameObject go)
	{
		//IL_0224: Expected I, but got Obj
		//IL_023a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0196: Expected I, but got Obj
		//IL_01ac: Expected Obj, but got I
		//IL_00ae: Expected I, but got Obj
		//IL_02a2: Expected I4, but got Obj
		//IL_00fb: Expected I, but got Obj
		//IL_0111: Expected Obj, but got I
		//IL_01d7: Expected I, but got Obj
		//IL_013c: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v49 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (go != null)
		{
			return;
		}
		BoxCollider component = ((Component)(object)go).GetComponent<BoxCollider>();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v45 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			nint num5 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v36 (Il2CppClass<NGUITools>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v41 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UpdateWidgetCollider((UIWidget)(object)go, (BoxCollider2D)(object)component);
			return;
		}
		BoxCollider2D component2 = ((Component)(object)go).GetComponent<BoxCollider2D>();
		nint num7 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v26 (Il2CppClass<NGUITools>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v31 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UpdateWidgetCollider((BoxCollider2D)(object)go, (byte)(int)component2 != 0);
	}

	public static void PushBack(GameObject go)
	{
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_01f4: Expected I4, but got Obj
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00c3: Expected I, but got Obj
		//IL_0110: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I
		//IL_0151: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIPanel uIPanel = CreateUI((byte)(int)go != 0, 1000);
		object obj2 = uIPanel - 1;
		if ((nint)uIPanel != 1)
		{
			if ((nint)obj2 != 1)
			{
				return;
			}
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v25 (Il2CppClass<NGUITools>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v30 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NormalizePanelDepths();
			return;
		}
		nint num5 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v15 (Il2CppClass<NGUITools>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v20 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools._002Ecctor();
	}

	public unsafe static void NormalizeDepths()
	{
		//IL_02a5: Expected I, but got Obj
		//IL_02bb: Expected Obj, but got I
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_031a: Expected I, but got Obj
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected I4, but got Unknown
		//IL_0335: Expected I4, but got Obj
		//IL_0358: Expected Obj, but got I
		//IL_0365: Expected Obj, but got I4
		//IL_03a8: Expected I, but got Obj
		//IL_03be: Expected Obj, but got I
		//IL_03c7: Expected Obj, but got I4
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0020: Expected I4, but got Obj
		//IL_0043: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0082: Expected I, but got Obj
		//IL_008f: Expected I4, but got Obj
		//IL_00b2: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got F4
		//IL_015e: Expected I, but got Obj
		//IL_016b: Expected I4, but got Obj
		//IL_018e: Expected Obj, but got I
		//IL_019b: Expected Obj, but got I4
		//IL_01c5: Expected I, but got Obj
		//IL_01db: Expected Obj, but got I
		//IL_0205: Expected I, but got Obj
		//IL_021b: Expected Obj, but got I
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0246: Expected Obj, but got I
		//IL_0253: Expected I4, but got Obj
		//IL_026e: Expected I, but got Obj
		//IL_0284: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<NGUIText>)+5C]");
		object obj = (nint)0 + (nint)8;
		object obj2 = default;
		obj = obj2;
		NGUIText.fontSize = 16;
		NGUIText.fontScale = 1f;
		NGUIText.pixelDensity = 1f;
		NGUIText.fontStyle = FontStyle.Normal;
		NGUIText.alignment = NGUIText.Alignment.Left;
		object obj4 = default;
		object obj3 = obj4 + 48;
		Color black = Color.black;
		nint num2 = (nint)typeof(NGUIText);
		CallingConvention callingConvention = (CallingConvention)(obj4 + 72);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v31+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v33 (Il2CppClass<NGUIText>)+5C]");
		object obj5 = (nint)0 + (nint)32;
		obj5 = ((CallingConvention*)(int)callingConvention)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v13 (System.Runtime.InteropServices.CallingConvention)+8]");
		_ = 0;
		NGUIText.rectWidth = 1000000;
		NGUIText.rectHeight = 1000000;
		NGUIText.regionWidth = 1000000;
		NGUIText.regionHeight = 1000000;
		nint num3 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v50 (Il2CppClass<NGUIText>)+5C]");
		object obj6 = -(-64);
		obj6 = 0;
		NGUIText.gradient = false;
		object obj7 = obj4 + 32;
		Color black2 = Color.black;
		nint num4 = (nint)typeof(NGUIText);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v57+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v59 (Il2CppClass<NGUIText>)+5C]");
		object obj8 = (nint)0 + (nint)72;
		obj8 = ((CallingConvention*)(int)callingConvention)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v13 (System.Runtime.InteropServices.CallingConvention)+8]");
		_ = 0;
		object obj9 = obj4 + 16;
		Color black3 = Color.black;
		nint num5 = (nint)typeof(NGUIText);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v64+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v66 (Il2CppClass<NGUIText>)+5C]");
		object obj10 = (nint)0 + (nint)88;
		obj10 = ((CallingConvention*)(int)callingConvention)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v13 (System.Runtime.InteropServices.CallingConvention)+8]");
		_ = 0;
		NGUIText.encoding = false;
		NGUIText.spacingX = 0f;
		NGUIText.spacingY = 0f;
		NGUIText.premultiply = false;
		NGUIText.finalSize = 0;
		NGUIText.finalSpacingX = 0f;
		NGUIText.finalLineHeight = 0f;
		NGUIText.baseline = 0f;
		NGUIText.useSymbols = false;
		obj4 = 0;
		_ = 0;
		obj4 = 0f;
		_ = 0f;
		_ = 0f;
		_ = 0f;
		nint num6 = (nint)typeof(NGUIText);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v104 (Il2CppClass<NGUIText>)+5C]");
		object obj11 = (nint)0 + (nint)144;
		obj11 = ((CallingConvention*)(int)callingConvention)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v13 (System.Runtime.InteropServices.CallingConvention)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v114 (Il2CppClass<NGUIText>)+5C]");
		object obj12 = (nint)0 + (nint)160;
		object obj13 = default;
		obj12 = obj13;
		NGUIText.mAlpha = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v126 (Il2CppClass<NGUIText>)+5C]");
		object obj14 = (nint)0 + (nint)220;
		object obj15 = default;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj16 = obj4 - -64;
		obj16 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj16;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		nint num9 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v137 (Il2CppClass<NGUIText>)+5C]");
		object obj17 = (nint)0 + (nint)256;
		obj17 = unmanagedFunctionPointerAttribute;
	}

	public static void NormalizeWidgetDepths()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NormalizePanelDepths();
		NGUITools._002Ecctor();
	}

	public static void NormalizeWidgetDepths(GameObject go)
	{
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_01f4: Expected I4, but got Obj
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00c3: Expected I, but got Obj
		//IL_0110: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I
		//IL_0151: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIPanel uIPanel = CreateUI((byte)(int)go != 0, -1000);
		object obj2 = uIPanel - 1;
		if ((nint)uIPanel != 1)
		{
			if ((nint)obj2 != 1)
			{
				return;
			}
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v25 (Il2CppClass<NGUITools>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v30 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NormalizePanelDepths();
			return;
		}
		nint num5 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v15 (Il2CppClass<NGUITools>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v20 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools._002Ecctor();
	}

	public static void NormalizeWidgetDepths(UIWidget[] list)
	{
		//IL_0068: Expected Obj, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_00a4: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S2_v2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x1FFF;
		object obj4 = obj3 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v24 @ S3_v4 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v4 (Il2CppClass<NGUITools>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v9 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj6 = default;
		Destroy(obj6);
	}

	public static void NormalizePanelDepths()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string typeName = NGUITools.GetTypeName<T>();
		Destroy((UnityEngine.Object)(object)typeName);
	}

	public static UIPanel CreateUI(bool advanced3D)
	{
		//IL_01ac: Expected I, but got Obj
		//IL_01c2: Expected Obj, but got I
		//IL_024e: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009f: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00ec: Expected I, but got Obj
		//IL_0102: Expected Obj, but got I
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_012d: Expected I, but got Obj
		//IL_017c: Expected Obj, but got I
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)advanced3D))
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v3 (Il2CppMethodInfo)+18]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v42 @ S3_v5 (should have been resolved before IL gen)");
			object obj6 = -1;
			object obj7 = 0;
			object obj10 = default;
			while (true)
			{
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v15+C]");
				if ((nint)obj8 >= 0)
				{
					break;
				}
				object obj9 = obj10 + 16;
				object obj11 = obj7 << 2;
				object obj12 = obj9 + obj11;
				object obj13 = obj12;
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v30 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num5 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v40 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj15 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v27+6C]");
				if ((nint)obj15 <= 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v27+6C]");
					obj6 = 0;
				}
				object obj16 = obj7 + 1;
				obj7 = obj16;
			}
			return (UIPanel)(obj6 + 1);
		}
		return null;
	}

	public static UIPanel CreateUI(bool advanced3D, int layer)
	{
		//IL_036c: Expected I, but got Obj
		//IL_0382: Expected Obj, but got I
		//IL_04dd: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected Obj, but got I4
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_03d8: Expected I, but got Obj
		//IL_03ee: Expected Obj, but got I
		//IL_00ae: Expected I, but got Obj
		//IL_0507: Expected Obj, but got I4
		//IL_0519: Expected I, but got Obj
		//IL_052f: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got I4
		//IL_01a2: Expected I, but got Obj
		//IL_0241: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I4
		//IL_01ef: Expected I, but got Obj
		//IL_018f: Expected Obj, but got I4
		//IL_04c5: Expected Obj, but got I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected Obj, but got Unknown
		//IL_0292: Expected I, but got Obj
		//IL_02a8: Expected Obj, but got I
		//IL_047d: Expected Obj, but got I
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_02d3: Expected I, but got Obj
		//IL_0327: Expected Obj, but got I
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v71 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIPanel result;
		if (((ComputeShader)advanced3D).FindKernel(null) != 0)
		{
			UIPanel component = ((GameObject)advanced3D).GetComponent<UIPanel>();
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v50 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				_0021_00210[] componentsInParent = (_0021_00210[])(object)((GameObject)advanced3D).GetComponentsInParent<T>(true);
				object obj3 = componentsInParent + 12;
				object obj4 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
				{
					object obj5 = componentsInParent + 16;
					object obj6 = obj4 << 2;
					object obj7 = obj5 + obj6;
					UIPanel uIPanel = (UIPanel)obj7;
					int sortingOrder = layer + uIPanel.mDepth;
					uIPanel.sortingOrder = sortingOrder;
					object obj8 = obj4 + 1;
					obj4 = obj8;
				}
				result = (UIPanel)1;
			}
			else
			{
				nint num5 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v18 (Il2CppClass<NGUITools>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num6 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v53 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UIPanel uIPanel2 = FindInParents<UIPanel>((GameObject)advanced3D);
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v49 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!(uIPanel2 != null))
				{
					UIWidget[] componentsInChildren = ((GameObject)advanced3D).GetComponentsInChildren<UIWidget>(includeInactive: true);
					object obj11 = 0;
					while (true)
					{
						bool flag = (nint)obj11 >= componentsInChildren.Length;
						result = (UIPanel)2;
						if (flag)
						{
							break;
						}
						object obj12 = componentsInChildren + 16;
						object obj13 = obj11 << 2;
						object obj14 = obj12 + obj13;
						object obj15 = obj14;
						nint num9 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj16 = (nint)0 & (nint)0x200;
						if (obj16 != null)
						{
							nint num10 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v40+90]");
						if (((ComputeShader)0).FindKernel((string)(object)uIPanel2) == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v40+6C]");
							UIWidget uIWidget = (UIWidget)((nint)layer + (nint)0);
							Vector2 localSize = uIWidget.localSize;
						}
						object obj17 = obj11 + 1;
						obj11 = obj17;
					}
				}
				else
				{
					result = null;
				}
			}
		}
		else
		{
			result = null;
		}
		return result;
	}

	public static UIPanel CreateUI(Transform trans, bool advanced3D, int layer)
	{
		//IL_0436: Expected I, but got Obj
		//IL_044c: Expected Obj, but got I
		//IL_00fb: Expected I, but got Obj
		//IL_0111: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0488: Expected Obj, but got I4
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0189: Expected I, but got Obj
		//IL_019f: Expected Obj, but got I
		//IL_013c: Expected I, but got Obj
		//IL_0476: Expected Obj, but got I4
		//IL_0476: Expected Obj, but got I4
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected Obj, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected Obj, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected Obj, but got Unknown
		//IL_00ae: Expected I, but got Obj
		//IL_01ca: Expected I, but got Obj
		//IL_021f: Expected Obj, but got I4
		//IL_0235: Expected I4, but got Obj
		//IL_0243: Expected I, but got Obj
		//IL_0259: Expected Obj, but got I
		//IL_051f: Expected I, but got Obj
		//IL_0535: Expected Obj, but got I
		//IL_0284: Expected I, but got Obj
		//IL_05ff: Expected I, but got Obj
		//IL_0615: Expected Obj, but got I
		//IL_035a: Expected I, but got Obj
		//IL_0410: Expected Obj, but got I4
		//IL_041e: Expected Obj, but got I4
		//IL_03a7: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v112 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject gameObject;
		if (((ComputeShader)(object)trans).FindKernel((string)null) != 0)
		{
			int layer2 = ((GameObject)(object)trans).layer;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v102 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v108 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			gameObject = UnityEngine.Object.Instantiate((GameObject)advanced3D, (Transform)layer2);
		}
		else
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v89 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v95 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			gameObject = UnityEngine.Object.Instantiate((GameObject)advanced3D);
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v84 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		Transform transform = (Transform)(obj5 + 48);
		object obj6 = obj5 + 32;
		object obj7 = obj5 + 16;
		if (((ComputeShader)(object)gameObject).FindKernel((string)null) != 0)
		{
			int layer3 = gameObject.layer;
			UnityEngine.Object obj8 = UnityEngine.Object.Instantiate((UnityEngine.Object)advanced3D);
			UnityEngine.Object.DestroyImmediate(gameObject, (byte)(int)obj8 != 0);
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v80 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)trans).FindKernel((string)null) != 0)
			{
				if (layer == -1)
				{
					bool activeSelf = ((GameObject)(object)trans).activeSelf;
					gameObject.SetActive(activeSelf);
				}
				else if (layer <= 31)
				{
					gameObject.SetActive((byte)layer != 0);
				}
			}
			nint num11 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v44 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num12 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v70 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			transform = (Transform)obj6;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v24+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			nint num13 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v53 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num14 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v66 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 zero = Vector2.zero;
			transform = (Transform)obj7;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v26+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 localScale = transform.localScale;
			Vector3 forward = Vector3.forward;
			transform = (Transform)obj5;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			((Transform)layer3).parent = transform;
			gameObject.tag = (string)1;
		}
		return (UIPanel)(object)gameObject;
	}

	public static void SetChildLayer(Transform t, int layer)
	{
	}

	public static T AddChild<T>(GameObject parent) where T : Component
	{
		//IL_0010: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0134: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		//IL_0176: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [parent @ L0 (UnityEngine.GameObject)+10]");
		object obj = 0;
		if (((UnityEngine.Object)parent).m_CachedPtr != (IntPtr)0)
		{
			if (((UnityEngine.Object)parent).m_CachedPtr != (IntPtr)1)
			{
				return null;
			}
			((UnityEngine.Object)parent).m_CachedPtr = (IntPtr)(-1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [parent @ L0 (UnityEngine.GameObject)+14]");
			object obj2 = (nint)0 + (nint)1;
		}
		else
		{
			((UnityEngine.Object)parent).m_CachedPtr = (IntPtr)(-1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2+8]");
			if ((nint)0 == 0)
			{
				return null;
			}
			_ = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [parent @ L0 (UnityEngine.GameObject)+14]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2+C]");
		if (num < 0)
		{
			object obj3 = parent + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2+8]");
			object obj4 = (nint)0 + (nint)16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [parent @ L0 (UnityEngine.GameObject)+14]");
			object obj5 = (nint)0 << 2;
			object obj6 = obj4 + obj5;
			obj3 = obj6;
			((UnityEngine.Object)parent).m_CachedPtr = (IntPtr)1;
			return (T)1;
		}
		return null;
	}

	public static T AddChild<T>(GameObject parent, bool undo) where T : Component
	{
		InvalidOperationException ex = new InvalidOperationException();
		throw new NullReferenceException();
	}

	public unsafe static T AddWidget<T>(GameObject go, int depth = int.MaxValue) where T : UIWidget
	{
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Ref, but got Unknown
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_0363: Expected Obj, but got I4
		//IL_0375: Expected Obj, but got I
		//IL_038b: Expected I, but got Obj
		//IL_03a1: Expected Obj, but got I
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected I, but got Unknown
		//IL_0203: Expected I, but got Obj
		//IL_0234: Expected Obj, but got I4
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0284: Expected I4, but got Obj
		//IL_029c: Expected Obj, but got I
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_0323: Expected I, but got Obj
		//IL_0339: Expected Obj, but got I
		//IL_03d3: Expected I, but got Obj
		//IL_03f6: Expected Obj, but got I
		//IL_0406: Expected Obj, but got I
		//IL_0416: Expected Obj, but got I
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected Obj, but got Unknown
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		object obj = default;
		ref string reference = ref *(string*)(obj + 8);
		reference = ref *(string*)null;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v48 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject obj3 = AddChild(go, (GameObject)depth);
		nint num3 = default;
		object obj4 = num3 + 24;
		object obj5 = obj4;
		nint num4 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v12 (Il2CppClass<System.Type>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num5 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v51 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj + 4;
		obj7 = obj5;
		nint num6 = (nint)(obj + 12);
		((IntPtr*)num6)->m_value = (void*)(nint)obj7;
		Type key = Type.internal_from_handle((IntPtr)num6);
		bool flag = mTypeNames.TryGetValue(key, out reference);
		object obj8 = (flag ? 1 : 0) ^ 1;
		bool flag2 = reference == null;
		object obj9 = flag2 | obj8;
		bool flag3 = obj9 == null;
		string text = reference;
		if (!flag3)
		{
			nint num7 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v32 (Il2CppClass<NGUITools>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num8 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v44 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj11 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v32+4]");
			object obj12 = 0;
			object obj13 = obj12 & 0xFFF;
			object obj14 = obj13 + 1797;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v148 @ S2_v20 (should have been resolved before IL gen)");
			object obj15 = default;
			reference = ref *(string*)obj15;
			object obj16 = obj4;
			nint num9 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v39 (Il2CppClass<System.Type>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num10 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v47 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = obj16;
			((IntPtr*)num6)->m_value = (void*)(nint)obj;
			Type type = Type.internal_from_handle((IntPtr)num6);
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S4_v3 (Il2CppMethodInfo)+C]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S4_v4+60]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S4_v5+48]");
			object obj20 = 0;
			object obj21 = obj20 & 0x7FF;
			object obj22 = obj21 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v111 @ S5_v5 (should have been resolved before IL gen)");
			text = reference;
		}
		UnityEngine.Object.DestroyImmediate(obj3, (byte)(int)text != 0);
		object obj23 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S1_v27+8]");
		object obj24 = 0;
		object obj25 = obj24 & 0x3FFF;
		object obj26 = obj25 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v174 @ S2_v16 (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public unsafe static UISprite AddSprite(GameObject go, UIAtlas atlas, string spriteName, int depth = int.MaxValue)
	{
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected Obj, but got Unknown
		//IL_0495: Expected Obj, but got I4
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected Obj, but got Unknown
		//IL_04b8: Expected Obj, but got I4
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected Obj, but got Unknown
		//IL_04d5: Expected Obj, but got I4
		//IL_04e9: Expected I, but got Obj
		//IL_04ff: Expected Obj, but got I
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Expected VT, but got Unknown
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected VT, but got Unknown
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected Obj, but got Unknown
		//IL_086e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected Obj, but got Unknown
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Expected Obj, but got Unknown
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected Obj, but got Unknown
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Expected Obj, but got Unknown
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Expected Obj, but got Unknown
		//IL_08bd: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a2: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_0529: Expected F4, but got Obj
		//IL_0524: Expected native int or pointer, but got VT
		//IL_055a: Expected F4, but got Obj
		//IL_0555: Expected native int or pointer, but got VT
		//IL_0137: Expected F4, but got Obj
		//IL_0132: Expected native int or pointer, but got VT
		//IL_0144: Expected F4, but got Obj
		//IL_013f: Expected native int or pointer, but got VT
		//IL_00e3: Expected I, but got Obj
		//IL_0904: Expected Obj, but got I
		//IL_092e: Expected Obj, but got I
		//IL_0944: Invalid comparison between Obj and F4
		//IL_0194: Expected Obj, but got F4
		//IL_05ae: Expected F4, but got Obj
		//IL_05a9: Expected native int or pointer, but got VT
		//IL_05d2: Expected F4, but got Obj
		//IL_05cd: Expected native int or pointer, but got VT
		//IL_05ed: Expected I, but got Obj
		//IL_0603: Expected Obj, but got I
		//IL_077e: Expected F4, but got Obj
		//IL_0779: Expected native int or pointer, but got VT
		//IL_0799: Expected I, but got Obj
		//IL_07af: Expected Obj, but got I
		//IL_034d: Expected I, but got Obj
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected Obj, but got Unknown
		//IL_03a3: Expected Obj, but got F4
		//IL_0211: Expected VT, but got I
		//IL_0234: Expected I, but got Obj
		//IL_024a: Expected Obj, but got I
		//IL_07d9: Expected F4, but got Obj
		//IL_07d4: Expected native int or pointer, but got VT
		//IL_07f4: Expected I, but got Obj
		//IL_080a: Expected Obj, but got I
		//IL_03b6: Expected I, but got Obj
		//IL_062d: Expected F4, but got Obj
		//IL_0628: Expected native int or pointer, but got VT
		//IL_063f: Expected F4, but got I
		//IL_063a: Expected native int or pointer, but got VT
		//IL_064c: Expected F4, but got Obj
		//IL_0647: Expected native int or pointer, but got VT
		//IL_068c: Expected F4, but got Obj
		//IL_0687: Expected native int or pointer, but got VT
		//IL_06a1: Expected F4, but got I
		//IL_069c: Expected native int or pointer, but got VT
		//IL_06af: Expected I, but got Obj
		//IL_06c5: Expected Obj, but got I
		//IL_09ae: Expected F4, but got I
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_0729: Expected Obj, but got I
		//IL_0275: Expected I, but got Obj
		//IL_0836: Expected Obj, but got I4
		//IL_041c: Expected I, but got Obj
		//IL_030e: Expected F4, but got Obj
		//IL_0309: Expected native int or pointer, but got VT
		//IL_033a: Expected Obj, but got I4
		//IL_02c2: Expected I, but got Obj
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 120;
		obj = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj2 + 108;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 96;
		obj4 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v168 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 vector = (Vector2)(obj2 + 156);
		Vector3 vector2 = (Vector3)(obj2 + 144);
		Transform transform = (Transform)(obj2 + 72);
		object obj6 = obj2 + 56;
		object obj7 = obj2 + 44;
		object obj8 = obj2 + 32;
		object obj9 = obj2 + 24;
		object obj10 = obj2 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L0 (UnityEngine.GameObject)+68]");
		if ((UnityEngine.Object)0 != null)
		{
			return null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v30 (UnityEngine.Transform)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		nint num3 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v52 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num4 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v163 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector2*)(nint)vector)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v32+8]");
		_ = 0;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		((Vector2*)(nint)vector)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v34+8]");
		_ = 0;
		Vector3 vector4 = vector;
		obj9 = obj2;
		((Vector3*)(nint)vector2)->x = (float)obj9;
		((Vector2*)(nint)vector)->x = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8D58");
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v36+8]");
		_ = 0;
		if (spriteName == null)
		{
			obj3 = 0f;
		}
		if (depth == 0)
		{
			_ = 0f;
		}
		object obj12 = obj3 * obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+4]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+4]");
		object obj13 = num5 * 0;
		object obj14 = obj12 + obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
		object obj15 = num6 * 0;
		object obj16 = obj14 + obj15;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.1f))
		{
			if ((object)atlas == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L0 (UnityEngine.GameObject)+10]");
				if ((nint)0 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L0 (UnityEngine.GameObject)+64]");
					transform.localPosition = (Vector3)0;
					obj6 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
					_ = 0;
					nint num7 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v124 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj17 = (nint)0 & (nint)0x200;
					if (obj17 != null)
					{
						nint num8 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S0_v157 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector2)->x = (float)transform;
					((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
					((Vector2*)(nint)vector)->x = (float)obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v32+8]");
					_ = 0;
					Vector3 vector5 = vector2 - (Vector3)vector;
					obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					((Vector3*)(nint)vector2)->x = (float)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Vector3*)(nint)vector2)->z = 0f;
					nint num9 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v140 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj18 = (nint)0 & (nint)0x200;
					if (obj18 != null)
					{
						nint num10 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S0_v153 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
					object obj19 = default;
					obj4 = obj19;
					obj7 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L0 (UnityEngine.GameObject)+68]");
					string tag = ((Component)0).tag;
					((Vector2*)(nint)vector)->x = (float)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
					_ = 0;
					SpringPosition springPosition = SpringPosition.Begin((GameObject)(object)tag, vector, 8f);
					return (UISprite)1;
				}
			}
			((Vector2*)(nint)vector)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EC");
			((Vector2*)(nint)vector)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
			_ = 0;
			nint num11 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S1_v78 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num12 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S1_v121 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num13 = Math.Abs(vector.x);
			if (num13 > 0.01f)
			{
				object obj21 = go + 140;
				obj21 = 0f;
			}
			((Vector2*)(nint)vector)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
			_ = 0;
			nint num14 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S1_v89 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num15 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S1_v115 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num16 = Math.Abs(vector.y);
			if (num16 > 0.01f)
			{
				object obj23 = go + 140;
				_ = 0f;
			}
			((Vector2*)(nint)vector)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
			_ = 0;
			nint num17 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S1_v100 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num18 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ S1_v109 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v26 (UnityEngine.Vector2)+8]");
			float num19 = Math.Abs(0f);
			if (num19 > 0.01f)
			{
				object obj25 = go + 140;
				_ = 0f;
			}
			_ = 0f;
			return (UISprite)1;
		}
		return null;
	}

	public unsafe static GameObject GetRoot(GameObject go)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (GameObject)PropertyReference.Convert(ref *(object*)null, (Type)(object)go, (Type)(-1));
	}

	public unsafe static T FindInParents<T>(GameObject go) where T : Component
	{
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Ref, but got Unknown
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_0371: Expected Obj, but got I
		//IL_0387: Expected I, but got Obj
		//IL_039d: Expected Obj, but got I
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected I, but got Unknown
		//IL_0203: Expected I, but got Obj
		//IL_0234: Expected Obj, but got I4
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0284: Expected I4, but got Obj
		//IL_0284: Expected Obj, but got I4
		//IL_029c: Expected Obj, but got I
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_0323: Expected I, but got Obj
		//IL_0339: Expected Obj, but got I
		//IL_03cf: Expected I, but got Obj
		//IL_03f2: Expected Obj, but got I
		//IL_0402: Expected Obj, but got I
		//IL_0412: Expected Obj, but got I
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected Obj, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected Obj, but got Unknown
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		object obj = default;
		ref string reference = ref *(string*)(obj + 8);
		reference = ref *(string*)null;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v48 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = CalculateRaycastDepth(go);
		nint num4 = default;
		object obj3 = num4 + 24;
		object obj4 = obj3;
		nint num5 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v12 (Il2CppClass<System.Type>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v51 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj + 4;
		obj6 = obj4;
		nint num7 = (nint)(obj + 12);
		((IntPtr*)num7)->m_value = (void*)(nint)obj6;
		Type key = Type.internal_from_handle((IntPtr)num7);
		bool flag = mTypeNames.TryGetValue(key, out reference);
		object obj7 = (flag ? 1 : 0) ^ 1;
		bool flag2 = reference == null;
		object obj8 = flag2 | obj7;
		bool flag3 = obj8 == null;
		string text = reference;
		if (!flag3)
		{
			nint num8 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v32 (Il2CppClass<NGUITools>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num9 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v44 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj10 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v32+4]");
			object obj11 = 0;
			object obj12 = obj11 & 0xFFF;
			object obj13 = obj12 + 1797;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v146 @ S2_v19 (should have been resolved before IL gen)");
			object obj14 = default;
			reference = ref *(string*)obj14;
			object obj15 = obj3;
			nint num10 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v39 (Il2CppClass<System.Type>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num11 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v47 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = obj15;
			((IntPtr*)num7)->m_value = (void*)(nint)obj;
			Type type = Type.internal_from_handle((IntPtr)num7);
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S4_v3 (Il2CppMethodInfo)+C]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S4_v4+60]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S4_v5+48]");
			object obj19 = 0;
			object obj20 = obj19 & 0x7FF;
			object obj21 = obj20 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v109 @ S5_v5 (should have been resolved before IL gen)");
			text = reference;
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)num3, (byte)(int)text != 0);
		object obj22 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v27+8]");
		object obj23 = 0;
		object obj24 = obj23 & 0x3FFF;
		object obj25 = obj24 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v172 @ S2_v15 (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public static T FindInParents<T>(Transform trans) where T : Component
	{
		//IL_00b5: Expected Obj, but got I4
		//IL_00c3: Expected I, but got Obj
		//IL_00d9: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		object result = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (trans != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			return (T)result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+18]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52 @ S2_v6 (should have been resolved before IL gen)");
		T result2 = default;
		return result2;
	}

	public static void Destroy(UnityEngine.Object obj)
	{
		//IL_002a: Expected VT, but got I
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0041: Expected Obj, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_0120: Expected Obj, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ L0 (UnityEngine.Object)+C]");
		if ((nint)0 <= (nint)0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_0021_00211[] array = default;
		array[1] = (_0021_00211)0;
		object obj2 = array + 16;
		obj2 = 0;
		Array.Sort<TKey, TValue>((TKey[])(object)obj, (TValue[])(object)array);
		object obj3 = obj + 16;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v22+6C]");
		object obj5 = 0;
		UIWidget uIWidget = null;
		object obj7 = default;
		object obj12 = default;
		while (true)
		{
			object obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ L0 (UnityEngine.Object)+C]");
			if ((nint)obj6 < 0)
			{
				object obj8 = obj + 16;
				object obj9 = obj7 << 2;
				object obj10 = obj8 + obj9;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v30+6C]");
				if (0 == (nint)obj5)
				{
					Vector2 localSize = uIWidget.localSize;
				}
				else
				{
					UIWidget uIWidget2 = (UIWidget)(uIWidget + 1);
					Vector2 localSize2 = uIWidget2.localSize;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v30+6C]");
					obj5 = 0;
					uIWidget = uIWidget2;
				}
				obj7 = obj12 + 1;
				continue;
			}
			break;
		}
	}

	public static void DestroyChildren(Transform t)
	{
		//IL_053a: Expected I, but got Obj
		//IL_0550: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0408: Expected I, but got Obj
		//IL_041e: Expected Obj, but got I
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_00d3: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I
		//IL_01a2: Expected I, but got Obj
		//IL_04ed: Expected I, but got Obj
		//IL_0114: Expected I, but got Obj
		//IL_047c: Expected I, but got Obj
		//IL_036c: Expected I, but got Obj
		//IL_0382: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got I4
		//IL_02de: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got I
		//IL_03ad: Expected I, but got Obj
		//IL_031f: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v107 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)t))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj2 = default;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			Component component = default;
			string tag = component.tag;
			if (Application.platform != RuntimePlatform.OSXEditor)
			{
				((Transform)component).parentInternal = null;
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v98 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v103 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)tag);
				return;
			}
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v87 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v92 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object)(object)tag);
			return;
		}
		Transform transform;
		if ((object)t == null)
		{
			transform = null;
		}
		else
		{
			transform = (((object)t.GetType() != typeof(GameObject)) ? null : t);
		}
		if ((object)transform == null)
		{
			RuntimePlatform platform = Application.platform;
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			bool flag = obj5 == null;
			if (platform != RuntimePlatform.OSXEditor)
			{
				if (!flag)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate(t);
				return;
			}
			if (!flag)
			{
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DontDestroyOnLoad(t);
			return;
		}
		GameObject gameObject;
		if ((object)t == null)
		{
			gameObject = null;
		}
		else
		{
			gameObject = (GameObject)(object)(((object)t.GetType() != typeof(GameObject)) ? null : t);
		}
		int layer = gameObject.layer;
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			((Transform)layer).parentInternal = null;
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v57 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v62 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate(gameObject);
			return;
		}
		nint num12 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v46 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
	}

	public static void DestroyImmediate(UnityEngine.Object obj)
	{
		//IL_00e3: Expected Obj, but got I4
		//IL_00f5: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I4
		//IL_0043: Expected Obj, but got I4
		//IL_0136: Expected I, but got Obj
		//IL_005a: Expected I, but got Obj
		//IL_0070: Expected Obj, but got I
		//IL_009b: Expected I, but got Obj
		RuntimePlatform platform = Application.platform;
		while (((Transform)obj).GetSiblingIndex() != 0)
		{
			bool flag = ((SpriteAtlas)obj).CanBindTo((Sprite)null);
			if (platform != RuntimePlatform.OSXEditor)
			{
				((Transform)flag).parentInternal = null;
				string tag = ((Component)flag).tag;
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)tag);
				continue;
			}
			string tag2 = ((Component)flag).tag;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object)(object)tag2);
		}
	}

	public static void Broadcast(string funcName)
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)funcName).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)funcName);
	}

	public static void Broadcast(string funcName, object param)
	{
		//IL_001f: Expected Obj, but got I4
		//IL_0035: Expected I4, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_0084: Expected I, but got Obj
		Sprite sprite = null;
		while (true)
		{
			int siblingIndex = ((Transform)(object)funcName).GetSiblingIndex();
			if ((nint)sprite >= siblingIndex)
			{
				break;
			}
			bool flag = ((SpriteAtlas)(object)funcName).CanBindTo(sprite);
			string tag = ((Component)flag).tag;
			((GameObject)(object)tag).SetActive((byte)(int)param != 0);
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v13 (Il2CppClass<NGUITools>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v20 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Broadcast((string)flag, param);
			Sprite sprite2 = (Sprite)(sprite + 1);
			sprite = sprite2;
		}
	}

	public unsafe static bool IsChild(Transform parent, Transform child)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return PropertyReference.Convert(ref *(object*)null, (Type)(object)parent, (Type)(object)child);
	}

	private unsafe static void Activate(Transform t)
	{
		//IL_0104: Expected I, but got Obj
		//IL_011a: Expected Obj, but got I
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected I, but got Unknown
		//IL_01b4: Expected I, but got Obj
		//IL_01cf: Expected I, but got Obj
		//IL_01e5: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00da: Expected I4, but got Obj
		//IL_00d5: Expected native int or pointer, but got Obj
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v34 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(GameObject);
		nint num3 = (nint)(typeFromHandle + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
		Type type = Type.internal_from_handle((IntPtr)num3);
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HideFlags hideFlags = ((UnityEngine.Object)(object)type).hideFlags;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj3 = 0;
		object obj6 = default;
		while (true)
		{
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v21+C]");
			if ((nint)obj4 < 0)
			{
				object obj5 = obj6 + 16;
				object obj7 = obj3 << 2;
				object obj8 = obj5 + obj7;
				*(RangeInt*)(nint)obj8 = new RangeInt((int)t, 1);
				object obj9 = obj3 + 1;
				obj3 = obj9;
				continue;
			}
			break;
		}
	}

	private unsafe static void Activate(Transform t, bool compatibilityMode)
	{
		//IL_0108: Expected I, but got Obj
		//IL_011e: Expected Obj, but got I
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected I, but got Unknown
		//IL_01b8: Expected I, but got Obj
		//IL_01d3: Expected I, but got Obj
		//IL_01e9: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00de: Expected Obj, but got I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v34 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(GameObject);
		nint num3 = (nint)(typeFromHandle + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
		Type type = Type.internal_from_handle((IntPtr)num3);
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HideFlags hideFlags = ((UnityEngine.Object)(object)type).hideFlags;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj3 = 0;
		object obj6 = default;
		while (true)
		{
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v21+C]");
			if ((nint)obj4 < 0)
			{
				object obj5 = obj6 + 16;
				object obj7 = obj3 << 2;
				object obj8 = obj5 + obj7;
				((GameObject)obj8).BroadcastMessage((string)(object)t, (object)compatibilityMode, SendMessageOptions.DontRequireReceiver);
				object obj9 = obj3 + 1;
				obj3 = obj9;
				continue;
			}
			break;
		}
	}

	private static void Deactivate(Transform t)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SetActive((GameObject)(object)t, state: false);
	}

	public static void SetActive(GameObject go, bool state)
	{
		//IL_0193: Expected I, but got Obj
		//IL_01a9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I4
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I4
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_0139: Expected I, but got Obj
		string tag = ((Component)(object)go).tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v32 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SetLayer((GameObject)(object)tag, 1);
		if (!state)
		{
			return;
		}
		int siblingIndex = ((Transform)(object)go).GetSiblingIndex();
		Sprite sprite = null;
		while (true)
		{
			if ((nint)sprite < siblingIndex)
			{
				bool flag = ((SpriteAtlas)(object)go).CanBindTo(sprite);
				string tag2 = ((Component)flag).tag;
				if (!((GameObject)(object)tag2).activeInHierarchy)
				{
					Sprite sprite2 = (Sprite)(sprite + 1);
					sprite = sprite2;
					continue;
				}
				break;
			}
			int siblingIndex2 = ((Transform)(object)go).GetSiblingIndex();
			Sprite sprite3 = null;
			while ((nint)sprite3 < siblingIndex2)
			{
				bool flag2 = ((SpriteAtlas)(object)go).CanBindTo(sprite3);
				nint num3 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v18 (Il2CppClass<NGUITools>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v24 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				SetActive((GameObject)flag2, state: true);
				Sprite sprite4 = (Sprite)(sprite3 + 1);
				sprite3 = sprite4;
			}
			break;
		}
	}

	public static void SetActive(GameObject go, bool state, bool compatibilityMode)
	{
		//IL_0150: Expected Obj, but got I4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got I4
		//IL_01af: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I4
		//IL_00a6: Expected I, but got Obj
		//IL_0219: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0186: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I4
		//IL_00b9: Expected I, but got Obj
		//IL_00cf: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_01f0: Expected Obj, but got I4
		//IL_01f0: Expected Obj, but got I4
		//IL_00fa: Expected I, but got Obj
		//IL_0141: Expected I, but got Obj
		UIPanel uIPanel = (UIPanel)0;
		UIPanel uIPanel2 = (UIPanel)(uIPanel + 4);
		uIPanel2 = (UIPanel)0;
		UIDrawCall uIDrawCall;
		do
		{
			nint num = (nint)go;
			UIPanel uIPanel3 = uIPanel2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v8 (Il2CppClass<UnityEngine.GameObject>)+8]");
			if ((nint)uIPanel3 >= 0)
			{
				break;
			}
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v37 (Il2CppClass<NGUIText>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num3 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v46 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			uIDrawCall = UIDrawCall.Create((string)(object)go, uIPanel2, (Material)(object)"http://", (Texture)state, (Shader)compatibilityMode);
		}
		while ((object)uIDrawCall != null);
		uIPanel = (UIPanel)0;
		nint num4 = unchecked((nint)null);
		while (true)
		{
			nint num5 = (nint)go;
			nint intPtr = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v14 (Il2CppClass<UnityEngine.GameObject>)+8]");
			if (intPtr >= 0)
			{
				break;
			}
			nint num6 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v23 (Il2CppClass<NGUIText>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num7 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v32 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIDrawCall uIDrawCall2 = UIDrawCall.Create((string)(object)go, uIPanel, (Material)(object)"https://", (Texture)state, (Shader)compatibilityMode);
			if ((object)uIDrawCall2 != null)
			{
				num4 = (nint)uIPanel;
				continue;
			}
			break;
		}
	}

	private static void CallCreatePanel(Transform t)
	{
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string tag = t.tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v9 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SetLayer((GameObject)(object)tag, 0);
	}

	public static void SetActiveChildren(GameObject go, bool state)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Expected VT, but got I4
		//IL_00a5: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FitOnScreen((Camera)(object)go, (Transform)state, (Vector3)1);
	}

	public static bool IsActive(Behaviour mb)
	{
		//IL_00c6: Expected Obj, but got I4
		//IL_00d8: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I4
		//IL_006c: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_005a: Expected I4, but got Obj
		int layer = ((GameObject)(object)mb).layer;
		int num = layer;
		while (true)
		{
			Transform parentInternal = ((Transform)num).parentInternal;
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (parentInternal != null)
			{
				break;
			}
			num = (int)parentInternal;
		}
		return (byte)(int)((Component)num).tag != 0;
	}

	public static bool GetActive(Behaviour mb)
	{
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_009f: Expected I4, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mb).FindKernel((string)null) != 0)
		{
			if (mb.isActiveAndEnabled)
			{
				string tag = mb.tag;
				string tag2 = ((GameObject)(object)tag).tag;
				return (byte)(int)tag2 != 0;
			}
			return false;
		}
		return false;
	}

	public static bool GetActive(GameObject go)
	{
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_009f: Expected I4, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)go))
		{
			if (((Behaviour)(object)go).isActiveAndEnabled)
			{
				string tag = ((Component)(object)go).tag;
				string tag2 = ((GameObject)(object)tag).tag;
				return (byte)(int)tag2 != 0;
			}
			return false;
		}
		return false;
	}

	public static void SetActiveSelf(GameObject go, bool state)
	{
		//IL_0163: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I4
		//IL_00cd: Expected I, but got Obj
		//IL_00e3: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I4
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_002e: Expected I, but got Obj
		//IL_0044: Expected Obj, but got I
		//IL_010e: Expected I, but got Obj
		//IL_0194: Expected Obj, but got I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_006f: Expected I, but got Obj
		int layer = go.layer;
		int siblingIndex = ((Transform)layer).GetSiblingIndex();
		if (state)
		{
			Sprite sprite = null;
			while ((nint)sprite < siblingIndex)
			{
				bool flag = ((SpriteAtlas)layer).CanBindTo(sprite);
				nint num = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v23 (Il2CppClass<NGUITools>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v29 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Deactivate((Transform)flag);
				Sprite sprite2 = (Sprite)(sprite + 1);
				sprite = sprite2;
			}
			return;
		}
		Sprite sprite3 = null;
		while ((nint)sprite3 < siblingIndex)
		{
			bool flag2 = ((SpriteAtlas)layer).CanBindTo(sprite3);
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v9 (Il2CppClass<NGUITools>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v15 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CallCreatePanel((Transform)flag2);
			Sprite sprite4 = (Sprite)(sprite3 + 1);
			sprite3 = sprite4;
		}
	}

	public static void SetLayer(GameObject go, int layer)
	{
		//IL_000d: Expected Obj, but got I4
		go.tag = (string)layer;
	}

	public static Vector3 Round(Vector3 v)
	{
		//IL_00d6: Expected I4, but got VT
		//IL_00ec: Expected Obj, but got I4
		//IL_000e: Expected VT, but got I4
		//IL_0125: Invalid comparison between VT and I4
		//IL_0020: Expected Obj, but got VT
		//IL_0020: Expected Obj, but got I4
		//IL_002d: Expected Obj, but got I4
		//IL_0044: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected VT, but got Unknown
		//IL_0085: Expected I, but got Obj
		GameObject gameObject = default;
		gameObject.SetActive((byte)(int)v != 0);
		int layer = gameObject.layer;
		int siblingIndex = ((Transform)layer).GetSiblingIndex();
		Vector3 vector = (Vector3)0;
		while (vector < (object)siblingIndex)
		{
			bool flag = ((SpriteAtlas)layer).CanBindTo((Sprite)vector);
			string tag = ((Component)flag).tag;
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v10 (Il2CppClass<NGUITools>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v16 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector2 = Round(v);
			Vector3 vector3 = vector + 1;
			vector = vector3;
		}
		return vector;
	}

	public static void MakePixelPerfect(Transform t)
	{
		//IL_0136: Expected I, but got Obj
		//IL_014c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I4
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_00db: Expected I, but got Obj
		UIWidget component = t.GetComponent<UIWidget>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			int minWidth = component.minWidth;
		}
		int siblingIndex = t.GetSiblingIndex();
		Sprite sprite = null;
		while ((nint)sprite < siblingIndex)
		{
			bool flag = ((SpriteAtlas)(object)t).CanBindTo(sprite);
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v12 (Il2CppClass<NGUITools>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v18 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MakePixelPerfect((Transform)flag);
			Sprite sprite2 = (Sprite)(sprite + 1);
			sprite = sprite2;
		}
	}

	public unsafe static void FitOnScreen(Camera cam, Transform t, bool considerInactive = false, bool considerChildren = true)
	{
		//IL_3020: Unknown result type (might be due to invalid IL or missing references)
		//IL_3025: Expected VT, but got Unknown
		//IL_302e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3033: Expected VT, but got Unknown
		//IL_303c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3041: Expected VT, but got Unknown
		//IL_304a: Unknown result type (might be due to invalid IL or missing references)
		//IL_304f: Expected VT, but got Unknown
		//IL_3058: Unknown result type (might be due to invalid IL or missing references)
		//IL_305d: Expected Obj, but got Unknown
		//IL_3066: Unknown result type (might be due to invalid IL or missing references)
		//IL_306b: Expected Obj, but got Unknown
		//IL_3074: Unknown result type (might be due to invalid IL or missing references)
		//IL_3079: Expected I4, but got Unknown
		//IL_3082: Unknown result type (might be due to invalid IL or missing references)
		//IL_3087: Expected Obj, but got Unknown
		//IL_3090: Unknown result type (might be due to invalid IL or missing references)
		//IL_3095: Expected Obj, but got Unknown
		//IL_309e: Unknown result type (might be due to invalid IL or missing references)
		//IL_30a3: Expected Obj, but got Unknown
		//IL_30ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_30b1: Expected Obj, but got Unknown
		//IL_30ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_30bf: Expected Obj, but got Unknown
		//IL_30c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_30cd: Expected Obj, but got Unknown
		//IL_30d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_30db: Expected Obj, but got Unknown
		//IL_30e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_30e9: Expected Obj, but got Unknown
		//IL_30f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_30f7: Expected Obj, but got Unknown
		//IL_3100: Unknown result type (might be due to invalid IL or missing references)
		//IL_3105: Expected Obj, but got Unknown
		//IL_310e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3113: Expected Obj, but got Unknown
		//IL_311c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3121: Expected Obj, but got Unknown
		//IL_312a: Unknown result type (might be due to invalid IL or missing references)
		//IL_312f: Expected Obj, but got Unknown
		//IL_3138: Unknown result type (might be due to invalid IL or missing references)
		//IL_313d: Expected Obj, but got Unknown
		//IL_3146: Expected Obj, but got I4
		//IL_3155: Unknown result type (might be due to invalid IL or missing references)
		//IL_315a: Expected Obj, but got Unknown
		//IL_3163: Expected Obj, but got I4
		//IL_3172: Unknown result type (might be due to invalid IL or missing references)
		//IL_3177: Expected Obj, but got Unknown
		//IL_3180: Expected Obj, but got I4
		//IL_318f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3194: Expected Obj, but got Unknown
		//IL_319d: Expected Obj, but got I4
		//IL_31ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_31b1: Expected Obj, but got Unknown
		//IL_31ba: Expected Obj, but got I4
		//IL_31c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_31c8: Expected Obj, but got Unknown
		//IL_31d1: Expected Obj, but got I4
		//IL_31da: Unknown result type (might be due to invalid IL or missing references)
		//IL_31df: Expected Obj, but got Unknown
		//IL_31e8: Expected Obj, but got I4
		//IL_31f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_31f6: Expected Obj, but got Unknown
		//IL_31ff: Expected Obj, but got I4
		//IL_3208: Unknown result type (might be due to invalid IL or missing references)
		//IL_320d: Expected Obj, but got Unknown
		//IL_3216: Expected Obj, but got I4
		//IL_321f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3224: Expected Obj, but got Unknown
		//IL_322d: Expected Obj, but got I4
		//IL_3236: Unknown result type (might be due to invalid IL or missing references)
		//IL_323b: Expected Obj, but got Unknown
		//IL_3244: Expected Obj, but got I4
		//IL_324d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3252: Expected Obj, but got Unknown
		//IL_325b: Expected Obj, but got I4
		//IL_326a: Unknown result type (might be due to invalid IL or missing references)
		//IL_326f: Expected Obj, but got Unknown
		//IL_3278: Expected Obj, but got I4
		//IL_3287: Unknown result type (might be due to invalid IL or missing references)
		//IL_328c: Expected Obj, but got Unknown
		//IL_3295: Expected Obj, but got I4
		//IL_003a: Expected I, but got Obj
		//IL_0050: Expected Obj, but got I
		//IL_32fb: Expected native int or pointer, but got VT
		//IL_330d: Expected native int or pointer, but got VT
		//IL_00d2: Expected I, but got Obj
		//IL_00e8: Expected Obj, but got I
		//IL_00f5: Expected F4, but got Obj
		//IL_00f0: Expected native int or pointer, but got VT
		//IL_010a: Expected F4, but got I
		//IL_0105: Expected native int or pointer, but got VT
		//IL_0118: Expected I, but got Obj
		//IL_012e: Expected Obj, but got I
		//IL_0150: Expected native int or pointer, but got VT
		//IL_0162: Expected native int or pointer, but got VT
		//IL_0174: Expected F4, but got Obj
		//IL_016f: Expected native int or pointer, but got VT
		//IL_0189: Expected F4, but got I
		//IL_0184: Expected native int or pointer, but got VT
		//IL_01bd: Expected I, but got Obj
		//IL_01d3: Expected Obj, but got I
		//IL_01f6: Expected I, but got Obj
		//IL_020c: Expected Obj, but got I
		//IL_0219: Expected I4, but got Obj
		//IL_0233: Expected F4, but got Obj
		//IL_022e: Expected native int or pointer, but got VT
		//IL_0248: Expected F4, but got I
		//IL_0243: Expected native int or pointer, but got VT
		//IL_025a: Expected F4, but got I4
		//IL_0255: Expected native int or pointer, but got VT
		//IL_026f: Expected F4, but got I
		//IL_026a: Expected native int or pointer, but got VT
		//IL_007b: Expected I, but got Obj
		//IL_02a8: Expected I, but got Obj
		//IL_02be: Expected Obj, but got I
		//IL_02cb: Expected F4, but got Obj
		//IL_02c6: Expected native int or pointer, but got VT
		//IL_02e0: Expected F4, but got I
		//IL_02db: Expected native int or pointer, but got VT
		//IL_02ed: Expected Obj, but got F4
		//IL_032c: Expected Obj, but got I4
		//IL_0335: Expected Obj, but got I4
		//IL_033e: Expected Obj, but got I4
		//IL_0347: Expected Obj, but got I4
		//IL_0350: Expected Obj, but got I4
		//IL_0359: Expected Obj, but got I4
		//IL_0367: Expected I, but got Obj
		//IL_037d: Expected Obj, but got I
		//IL_03a8: Expected I, but got Obj
		//IL_33ea: Expected VT, but got I4
		//IL_03f5: Expected I, but got Obj
		//IL_040b: Expected Obj, but got I
		//IL_335f: Expected VT, but got Obj
		//IL_335f: Expected Obj, but got VT
		//IL_336c: Expected Obj, but got F4
		//IL_2e8d: Expected I, but got Obj
		//IL_2ea3: Expected Obj, but got I
		//IL_0436: Expected I, but got Obj
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Obj, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected Obj, but got Unknown
		//IL_58f2: Expected I, but got Obj
		//IL_5908: Expected Obj, but got I
		//IL_2ece: Expected I, but got Obj
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected Obj, but got Unknown
		//IL_068f: Expected VT, but got Obj
		//IL_3945: Unknown result type (might be due to invalid IL or missing references)
		//IL_394a: Expected Obj, but got Unknown
		//IL_0504: Expected I, but got Obj
		//IL_051a: Expected Obj, but got I
		//IL_2fd8: Expected I, but got Obj
		//IL_06ab: Expected I, but got Obj
		//IL_06c1: Expected Obj, but got I
		//IL_2f4a: Expected I, but got Obj
		//IL_2f60: Expected Obj, but got I
		//IL_52fb: Expected I, but got Obj
		//IL_5311: Expected Obj, but got I
		//IL_0545: Expected I, but got Obj
		//IL_533c: Expected I, but got Obj
		//IL_5352: Expected Obj, but got I
		//IL_06ec: Expected I, but got Obj
		//IL_3494: Expected VT, but got I4
		//IL_0592: Expected I, but got Obj
		//IL_05a8: Expected Obj, but got I
		//IL_2f8b: Expected I, but got Obj
		//IL_0739: Expected I, but got Obj
		//IL_074f: Expected Obj, but got I
		//IL_0620: Expected I, but got Obj
		//IL_0ad0: Expected I, but got Obj
		//IL_05d3: Expected I, but got Obj
		//IL_39a5: Expected I, but got Obj
		//IL_39bb: Expected Obj, but got I
		//IL_39d3: Expected I4, but got Obj
		//IL_0b1d: Expected I, but got Obj
		//IL_0b33: Expected Obj, but got I
		//IL_077a: Expected I, but got Obj
		//IL_398d: Expected VT, but got I
		//IL_07c7: Expected I, but got Obj
		//IL_07dd: Expected Obj, but got I
		//IL_0b5e: Expected I, but got Obj
		//IL_0884: Expected I, but got Obj
		//IL_0c4e: Expected I, but got Obj
		//IL_35e9: Expected Obj, but got I
		//IL_35f6: Expected F4, but got Obj
		//IL_35f1: Expected native int or pointer, but got VT
		//IL_360b: Expected F4, but got I
		//IL_3606: Expected native int or pointer, but got VT
		//IL_3633: Expected Obj, but got I
		//IL_3643: Unknown result type (might be due to invalid IL or missing references)
		//IL_3648: Expected Obj, but got Unknown
		//IL_3655: Expected F4, but got Obj
		//IL_3650: Expected native int or pointer, but got VT
		//IL_366a: Expected F4, but got I
		//IL_3665: Expected native int or pointer, but got VT
		//IL_3677: Expected native int or pointer, but got VT
		//IL_3689: Expected native int or pointer, but got VT
		//IL_369b: Expected native int or pointer, but got VT
		//IL_36ad: Expected native int or pointer, but got VT
		//IL_36e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_36e6: Expected Obj, but got Unknown
		//IL_36fe: Expected Obj, but got F4
		//IL_3706: Expected F4, but got Obj
		//IL_5933: Expected I, but got Obj
		//IL_5949: Expected Obj, but got I
		//IL_0bdd: Expected I, but got Obj
		//IL_537d: Expected I, but got Obj
		//IL_5393: Expected Obj, but got I
		//IL_08a0: Expected I, but got Obj
		//IL_08ae: Expected I, but got Obj
		//IL_3515: Expected Obj, but got I
		//IL_3525: Unknown result type (might be due to invalid IL or missing references)
		//IL_352a: Expected Obj, but got Unknown
		//IL_3537: Expected F4, but got Obj
		//IL_3532: Expected native int or pointer, but got VT
		//IL_354c: Expected F4, but got I
		//IL_3547: Expected native int or pointer, but got VT
		//IL_3559: Expected Obj, but got F4
		//IL_356c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3571: Expected Obj, but got Unknown
		//IL_357f: Expected I, but got Obj
		//IL_3595: Expected Obj, but got I
		//IL_35c5: Expected Obj, but got F4
		//IL_35cd: Expected F4, but got Obj
		//IL_0c9b: Expected I, but got Obj
		//IL_0cb1: Expected Obj, but got I
		//IL_083b: Expected I, but got Obj
		//IL_2e71: Expected I4, but got Obj
		//IL_1368: Expected I, but got Obj
		//IL_08ef: Expected I, but got Obj
		//IL_08dc: Expected I, but got Obj
		//IL_0cdc: Expected I, but got Obj
		//IL_09be: Expected I, but got Obj
		//IL_09d4: Expected Obj, but got I
		//IL_3d68: Expected I, but got Obj
		//IL_3d7e: Expected Obj, but got I
		//IL_5455: Expected native int or pointer, but got VT
		//IL_5463: Expected native int or pointer, but got VT
		//IL_5470: Expected native int or pointer, but got VT
		//IL_547d: Expected native int or pointer, but got VT
		//IL_548b: Expected native int or pointer, but got VT
		//IL_549d: Expected native int or pointer, but got VT
		//IL_54af: Expected native int or pointer, but got VT
		//IL_54ca: Expected native int or pointer, but got VT
		//IL_54d8: Expected native int or pointer, but got VT
		//IL_54e5: Expected native int or pointer, but got VT
		//IL_54f2: Expected native int or pointer, but got VT
		//IL_5500: Expected native int or pointer, but got VT
		//IL_5512: Expected native int or pointer, but got VT
		//IL_5524: Expected native int or pointer, but got VT
		//IL_553f: Expected native int or pointer, but got VT
		//IL_554d: Expected native int or pointer, but got VT
		//IL_555a: Expected native int or pointer, but got VT
		//IL_5567: Expected native int or pointer, but got VT
		//IL_5575: Expected native int or pointer, but got VT
		//IL_5587: Expected native int or pointer, but got VT
		//IL_5599: Expected native int or pointer, but got VT
		//IL_0937: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Expected Obj, but got Unknown
		//IL_094a: Expected I, but got Obj
		//IL_0960: Expected Obj, but got I
		//IL_3e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ea3: Expected Obj, but got Unknown
		//IL_3ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ec0: Expected Obj, but got Unknown
		//IL_3ee0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ee5: Expected Obj, but got Unknown
		//IL_3efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f02: Expected Obj, but got Unknown
		//IL_13da: Expected I, but got Obj
		//IL_13f0: Expected Obj, but got I
		//IL_0e96: Expected Obj, but got I4
		//IL_0ea4: Expected Obj, but got F4
		//IL_0ebc: Expected F4, but got Obj
		//IL_0eb7: Expected native int or pointer, but got VT
		//IL_0ed1: Expected F4, but got I
		//IL_0ecc: Expected native int or pointer, but got VT
		//IL_0eec: Expected I, but got Obj
		//IL_0f02: Expected Obj, but got I
		//IL_53e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_53e5: Expected Obj, but got Unknown
		//IL_09ff: Expected I, but got Obj
		//IL_3758: Expected Obj, but got I
		//IL_3766: Expected Obj, but got I4
		//IL_3780: Expected F4, but got Obj
		//IL_377b: Expected native int or pointer, but got VT
		//IL_3795: Expected F4, but got I
		//IL_3790: Expected native int or pointer, but got VT
		//IL_37b1: Expected Obj, but got F4
		//IL_37cf: Expected F4, but got Obj
		//IL_14e3: Expected I, but got Obj
		//IL_0d2c: Expected I, but got Obj
		//IL_0d42: Expected Obj, but got I
		//IL_0a32: Expected I, but got Obj
		//IL_0a48: Expected Obj, but got I
		//IL_0a65: Expected I, but got Obj
		//IL_098b: Expected I, but got Obj
		//IL_566e: Expected I, but got Obj
		//IL_5684: Expected Obj, but got I
		//IL_3e36: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e3b: Expected Obj, but got Unknown
		//IL_3e52: Expected Obj, but got F4
		//IL_3e5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e60: Expected Obj, but got Unknown
		//IL_3e77: Expected Obj, but got F4
		//IL_55c6: Expected Obj, but got I
		//IL_0f2d: Expected I, but got Obj
		//IL_3803: Expected Obj, but got I
		//IL_3810: Expected F4, but got Obj
		//IL_380b: Expected native int or pointer, but got VT
		//IL_3825: Expected F4, but got I
		//IL_3820: Expected native int or pointer, but got VT
		//IL_3832: Expected native int or pointer, but got VT
		//IL_3844: Expected native int or pointer, but got VT
		//IL_3856: Expected F4, but got Obj
		//IL_3851: Expected native int or pointer, but got VT
		//IL_386b: Expected F4, but got I
		//IL_3866: Expected native int or pointer, but got VT
		//IL_3889: Expected Obj, but got F4
		//IL_38a1: Expected I, but got Obj
		//IL_38b7: Expected Obj, but got I
		//IL_38d9: Expected F4, but got Obj
		//IL_38d4: Expected native int or pointer, but got VT
		//IL_38ee: Expected F4, but got I
		//IL_38e9: Expected native int or pointer, but got VT
		//IL_38fb: Expected F4, but got Obj
		//IL_38f6: Expected native int or pointer, but got VT
		//IL_3910: Expected F4, but got I
		//IL_390b: Expected native int or pointer, but got VT
		//IL_14b0: Expected I, but got Obj
		//IL_3dc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dca: Expected Obj, but got Unknown
		//IL_3de1: Expected Obj, but got F4
		//IL_3dea: Unknown result type (might be due to invalid IL or missing references)
		//IL_3def: Expected Obj, but got Unknown
		//IL_3e06: Expected Obj, but got F4
		//IL_0f62: Expected Obj, but got I
		//IL_3b5b: Expected I, but got Obj
		//IL_3b71: Expected Obj, but got I
		//IL_0d6d: Expected I, but got Obj
		//IL_0a81: Expected I, but got Obj
		//IL_0a8f: Expected I, but got Obj
		//IL_16a2: Expected I, but got Obj
		//IL_1533: Expected I, but got Obj
		//IL_1549: Expected Obj, but got I
		//IL_1459: Expected I, but got Obj
		//IL_118e: Expected I, but got Obj
		//IL_11a4: Expected Obj, but got I
		//IL_0f82: Expected Obj, but got I4
		//IL_0f8f: Expected F4, but got Obj
		//IL_0f8a: Expected native int or pointer, but got VT
		//IL_0fa4: Expected F4, but got I
		//IL_0f9f: Expected native int or pointer, but got VT
		//IL_0fb1: Expected Obj, but got F4
		//IL_0ffa: Expected native int or pointer, but got VT
		//IL_100c: Expected F4, but got Obj
		//IL_1007: Expected native int or pointer, but got VT
		//IL_1021: Expected F4, but got I
		//IL_101c: Expected native int or pointer, but got VT
		//IL_102e: Expected Obj, but got F4
		//IL_103b: Expected F4, but got Obj
		//IL_1036: Expected native int or pointer, but got VT
		//IL_1048: Expected Obj, but got I4
		//IL_1051: Expected native int or pointer, but got VT
		//IL_1063: Expected F4, but got Obj
		//IL_105e: Expected native int or pointer, but got VT
		//IL_106b: Expected native int or pointer, but got VT
		//IL_107d: Expected Obj, but got F4
		//IL_108a: Expected F4, but got Obj
		//IL_1085: Expected native int or pointer, but got VT
		//IL_1097: Expected Obj, but got I4
		//IL_16d0: Expected Obj, but got I4
		//IL_1172: Expected I4, but got Obj
		//IL_117b: Expected VT, but got I4
		//IL_10a5: Expected Obj, but got I4
		//IL_10ad: Expected Obj, but got F4
		//IL_10c7: Expected F4, but got Obj
		//IL_10c2: Expected native int or pointer, but got VT
		//IL_10d4: Expected Obj, but got I4
		//IL_10dd: Expected Obj, but got I4
		//IL_10e5: Expected Obj, but got F4
		//IL_1107: Expected F4, but got Obj
		//IL_1102: Expected native int or pointer, but got VT
		//IL_1114: Expected Obj, but got I4
		//IL_112c: Expected F4, but got I
		//IL_1134: Expected F4, but got Obj
		//IL_0e3b: Expected I, but got Obj
		//IL_0abd: Expected I, but got Obj
		//IL_56af: Expected I, but got Obj
		//IL_56c5: Expected Obj, but got I
		//IL_3fa7: Expected I, but got Obj
		//IL_3fbd: Expected Obj, but got I
		//IL_1574: Expected I, but got Obj
		//IL_5615: Expected Obj, but got F4
		//IL_562d: Expected I, but got Obj
		//IL_5643: Expected Obj, but got I
		//IL_11cf: Expected I, but got Obj
		//IL_0dc7: Expected I, but got Obj
		//IL_0ddd: Expected Obj, but got I
		//IL_411b: Expected I4, but got Obj
		//IL_4123: Expected VT, but got Obj
		//IL_1731: Expected I, but got Obj
		//IL_1747: Expected Obj, but got I
		//IL_11fd: Expected Obj, but got I4
		//IL_17a5: Expected I, but got Obj
		//IL_1642: Expected I, but got Obj
		//IL_12c6: Expected F4, but got Obj
		//IL_12c1: Expected native int or pointer, but got VT
		//IL_12db: Expected F4, but got I
		//IL_12d6: Expected native int or pointer, but got VT
		//IL_1280: Expected I, but got Obj
		//IL_0e08: Expected I, but got Obj
		//IL_1772: Expected I, but got Obj
		//IL_1704: Expected Obj, but got I4
		//IL_15ce: Expected I, but got Obj
		//IL_15e4: Expected Obj, but got I
		//IL_3cfb: Expected Obj, but got I4
		//IL_12ae: Expected Obj, but got F4
		//IL_1235: Expected F4, but got Obj
		//IL_1230: Expected native int or pointer, but got VT
		//IL_124a: Expected F4, but got I
		//IL_1245: Expected native int or pointer, but got VT
		//IL_1257: Expected Obj, but got I4
		//IL_1260: Unknown result type (might be due to invalid IL or missing references)
		//IL_1265: Expected Obj, but got Unknown
		//IL_121a: Expected I4, but got Obj
		//IL_1223: Expected VT, but got I4
		//IL_17f1: Expected I, but got Obj
		//IL_1807: Expected Obj, but got I
		//IL_160f: Expected I, but got Obj
		//IL_131d: Expected F4, but got Obj
		//IL_1318: Expected native int or pointer, but got VT
		//IL_1332: Expected F4, but got I
		//IL_132d: Expected native int or pointer, but got VT
		//IL_133f: Expected Obj, but got I4
		//IL_1348: Unknown result type (might be due to invalid IL or missing references)
		//IL_134d: Expected Obj, but got Unknown
		//IL_4203: Expected I, but got Obj
		//IL_4219: Expected Obj, but got I
		//IL_413f: Expected I, but got Obj
		//IL_4155: Expected Obj, but got I
		//IL_1302: Expected I4, but got Obj
		//IL_130b: Expected VT, but got I4
		//IL_1832: Expected I, but got Obj
		//IL_5704: Unknown result type (might be due to invalid IL or missing references)
		//IL_5709: Expected Obj, but got Unknown
		//IL_5717: Expected I, but got Obj
		//IL_572d: Expected Obj, but got I
		//IL_1e20: Expected I, but got Obj
		//IL_42a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_42a5: Expected Obj, but got Unknown
		//IL_1865: Expected I, but got Obj
		//IL_4355: Unknown result type (might be due to invalid IL or missing references)
		//IL_435a: Expected Obj, but got Unknown
		//IL_439d: Expected F4, but got Obj
		//IL_4398: Expected native int or pointer, but got VT
		//IL_43b2: Expected F4, but got I
		//IL_43ad: Expected native int or pointer, but got VT
		//IL_43bf: Expected F4, but got Obj
		//IL_43ba: Expected native int or pointer, but got VT
		//IL_43d4: Expected F4, but got I
		//IL_43cf: Expected native int or pointer, but got VT
		//IL_43f8: Expected I4, but got VT
		//IL_43f8: Expected I4, but got VT
		//IL_43f8: Expected Ref, but got VT
		//IL_4406: Expected I, but got Obj
		//IL_4413: Expected native int or pointer, but got VT
		//IL_4425: Expected native int or pointer, but got VT
		//IL_4440: Expected Obj, but got I
		//IL_444d: Expected Obj, but got F4
		//IL_4464: Expected F4, but got Obj
		//IL_445f: Expected native int or pointer, but got VT
		//IL_4479: Expected F4, but got I
		//IL_4474: Expected native int or pointer, but got VT
		//IL_4486: Expected F4, but got Obj
		//IL_4481: Expected native int or pointer, but got VT
		//IL_449b: Expected F4, but got I
		//IL_4496: Expected native int or pointer, but got VT
		//IL_44b0: Expected I4, but got VT
		//IL_44b0: Expected I4, but got VT
		//IL_44b0: Expected Ref, but got VT
		//IL_44be: Expected I, but got Obj
		//IL_44cb: Expected native int or pointer, but got VT
		//IL_44dd: Expected native int or pointer, but got VT
		//IL_44f8: Expected Obj, but got I
		//IL_4505: Expected Obj, but got F4
		//IL_1c06: Expected F4, but got Obj
		//IL_1c01: Expected native int or pointer, but got VT
		//IL_1c1b: Expected F4, but got I
		//IL_1c16: Expected native int or pointer, but got VT
		//IL_1c32: Expected Obj, but got F4
		//IL_1c52: Expected Obj, but got I
		//IL_1a86: Expected Obj, but got I4
		//IL_1893: Unknown result type (might be due to invalid IL or missing references)
		//IL_1898: Expected Obj, but got Unknown
		//IL_18a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a6: Expected Obj, but got Unknown
		//IL_18ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b3: Expected Obj, but got Unknown
		//IL_18d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d6: Expected Obj, but got Unknown
		//IL_18df: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e4: Expected Obj, but got Unknown
		//IL_18ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f1: Expected Obj, but got Unknown
		//IL_190f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1914: Expected Obj, but got Unknown
		//IL_1931: Expected Obj, but got I
		//IL_193a: Unknown result type (might be due to invalid IL or missing references)
		//IL_193f: Expected Obj, but got Unknown
		//IL_1973: Unknown result type (might be due to invalid IL or missing references)
		//IL_1978: Expected Obj, but got Unknown
		//IL_1995: Expected Obj, but got I
		//IL_199e: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a3: Expected Obj, but got Unknown
		//IL_19d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_19dd: Expected Obj, but got Unknown
		//IL_19e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_19eb: Expected Obj, but got Unknown
		//IL_19fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a01: Expected Obj, but got Unknown
		//IL_1a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0f: Expected Obj, but got Unknown
		//IL_1a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2a: Expected Obj, but got Unknown
		//IL_1a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a38: Expected Obj, but got Unknown
		//IL_1a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4e: Expected Obj, but got Unknown
		//IL_1a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a5c: Expected Obj, but got Unknown
		//IL_1f1f: Expected Obj, but got I4
		//IL_1ee3: Expected I, but got Obj
		//IL_1e79: Expected Obj, but got I4
		//IL_1cdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce1: Expected Obj, but got Unknown
		//IL_1cf9: Expected Obj, but got F4
		//IL_41c4: Expected Obj, but got I4
		//IL_1a78: Expected Obj, but got I4
		//IL_453d: Expected Obj, but got I4
		//IL_1f11: Expected Obj, but got I4
		//IL_42f9: Expected Obj, but got I4
		//IL_1e6b: Expected Obj, but got I4
		//IL_46db: Unknown result type (might be due to invalid IL or missing references)
		//IL_46e0: Expected Obj, but got Unknown
		//IL_4707: Expected VT, but got Obj
		//IL_223a: Expected I, but got Obj
		//IL_2250: Expected Obj, but got I
		//IL_1db5: Expected Obj, but got I4
		//IL_1d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0c: Expected Obj, but got Unknown
		//IL_1d24: Expected Obj, but got F4
		//IL_2325: Expected I, but got Obj
		//IL_233b: Expected Obj, but got I
		//IL_473e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4743: Expected I4, but got Unknown
		//IL_475b: Expected native int or pointer, but got VT
		//IL_4769: Expected native int or pointer, but got VT
		//IL_4785: Expected native int or pointer, but got VT
		//IL_4792: Expected native int or pointer, but got VT
		//IL_47a0: Expected native int or pointer, but got VT
		//IL_47b2: Expected native int or pointer, but got VT
		//IL_47c4: Expected native int or pointer, but got VT
		//IL_47df: Expected native int or pointer, but got VT
		//IL_47ed: Expected native int or pointer, but got VT
		//IL_4809: Expected native int or pointer, but got VT
		//IL_4816: Expected native int or pointer, but got VT
		//IL_4824: Expected native int or pointer, but got VT
		//IL_4836: Expected native int or pointer, but got VT
		//IL_4848: Expected native int or pointer, but got VT
		//IL_4863: Expected native int or pointer, but got VT
		//IL_4871: Expected native int or pointer, but got VT
		//IL_488d: Expected native int or pointer, but got VT
		//IL_489a: Expected native int or pointer, but got VT
		//IL_48a8: Expected native int or pointer, but got VT
		//IL_48ba: Expected native int or pointer, but got VT
		//IL_48cc: Expected native int or pointer, but got VT
		//IL_206e: Expected native int or pointer, but got VT
		//IL_207c: Expected native int or pointer, but got VT
		//IL_2089: Expected native int or pointer, but got VT
		//IL_2096: Expected native int or pointer, but got VT
		//IL_20a4: Expected native int or pointer, but got VT
		//IL_20b6: Expected native int or pointer, but got VT
		//IL_20c8: Expected native int or pointer, but got VT
		//IL_20e3: Expected native int or pointer, but got VT
		//IL_20f1: Expected native int or pointer, but got VT
		//IL_20fe: Expected native int or pointer, but got VT
		//IL_210b: Expected native int or pointer, but got VT
		//IL_2119: Expected native int or pointer, but got VT
		//IL_212b: Expected native int or pointer, but got VT
		//IL_213d: Expected native int or pointer, but got VT
		//IL_425c: Expected Obj, but got I4
		//IL_1da7: Expected Obj, but got I4
		//IL_48ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_48f2: Expected Obj, but got Unknown
		//IL_4932: Unknown result type (might be due to invalid IL or missing references)
		//IL_4937: Expected Obj, but got Unknown
		//IL_22a9: Expected Obj, but got I4
		//IL_22c6: Expected Obj, but got F4
		//IL_22de: Expected F4, but got Obj
		//IL_22d9: Expected native int or pointer, but got VT
		//IL_22f3: Expected F4, but got I
		//IL_22ee: Expected native int or pointer, but got VT
		//IL_227b: Expected I, but got Obj
		//IL_215d: Expected native int or pointer, but got VT
		//IL_216b: Expected native int or pointer, but got VT
		//IL_2178: Expected native int or pointer, but got VT
		//IL_2185: Expected native int or pointer, but got VT
		//IL_2193: Expected native int or pointer, but got VT
		//IL_21a5: Expected native int or pointer, but got VT
		//IL_21b7: Expected native int or pointer, but got VT
		//IL_21d2: Expected Obj, but got I4
		//IL_21e0: Expected Obj, but got F4
		//IL_21f8: Expected F4, but got Obj
		//IL_21f3: Expected native int or pointer, but got VT
		//IL_220d: Expected F4, but got I
		//IL_2208: Expected native int or pointer, but got VT
		//IL_1a98: Expected native int or pointer, but got VT
		//IL_1aaa: Expected Obj, but got F4
		//IL_1ab7: Expected F4, but got Obj
		//IL_1ab2: Expected native int or pointer, but got VT
		//IL_1ac4: Expected Obj, but got I4
		//IL_1ad6: Expected F4, but got Obj
		//IL_1ad1: Expected native int or pointer, but got VT
		//IL_1ae3: Expected Obj, but got F4
		//IL_1af0: Expected F4, but got Obj
		//IL_1aeb: Expected native int or pointer, but got VT
		//IL_1afd: Expected Obj, but got I4
		//IL_1f32: Expected I, but got Obj
		//IL_1f48: Expected Obj, but got I
		//IL_1f65: Expected I, but got Obj
		//IL_1e8b: Expected F4, but got Obj
		//IL_1e86: Expected native int or pointer, but got VT
		//IL_1ea0: Expected F4, but got I
		//IL_1e9b: Expected native int or pointer, but got VT
		//IL_1ead: Expected Obj, but got I4
		//IL_1eb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ebb: Expected Obj, but got Unknown
		//IL_24da: Expected Obj, but got I4
		//IL_23a7: Expected I, but got Obj
		//IL_23bd: Expected Obj, but got I
		//IL_2366: Expected I, but got Obj
		//IL_1b14: Expected F4, but got Obj
		//IL_1b0f: Expected native int or pointer, but got VT
		//IL_1b21: Expected Obj, but got F4
		//IL_1b2e: Expected F4, but got Obj
		//IL_1b29: Expected native int or pointer, but got VT
		//IL_1b3b: Expected Obj, but got I4
		//IL_1b4b: Expected Obj, but got I
		//IL_1b60: Expected F4, but got Obj
		//IL_1b5b: Expected native int or pointer, but got VT
		//IL_1b6d: Expected Obj, but got I4
		//IL_4558: Expected Obj, but got I
		//IL_4565: Expected F4, but got Obj
		//IL_4560: Expected native int or pointer, but got VT
		//IL_457a: Expected F4, but got I
		//IL_4575: Expected native int or pointer, but got VT
		//IL_4587: Expected native int or pointer, but got VT
		//IL_4599: Expected native int or pointer, but got VT
		//IL_45ab: Expected Obj, but got I4
		//IL_45b9: Expected I, but got Obj
		//IL_45cf: Expected Obj, but got I
		//IL_45dc: Expected F4, but got Obj
		//IL_45d7: Expected native int or pointer, but got VT
		//IL_45f1: Expected F4, but got I
		//IL_45ec: Expected native int or pointer, but got VT
		//IL_45fe: Expected native int or pointer, but got VT
		//IL_4610: Expected native int or pointer, but got VT
		//IL_4622: Expected Obj, but got I4
		//IL_4630: Expected I, but got Obj
		//IL_4646: Expected Obj, but got I
		//IL_4653: Expected F4, but got Obj
		//IL_464e: Expected native int or pointer, but got VT
		//IL_4668: Expected F4, but got I
		//IL_4663: Expected native int or pointer, but got VT
		//IL_4675: Expected native int or pointer, but got VT
		//IL_4687: Expected native int or pointer, but got VT
		//IL_4699: Expected Obj, but got I4
		//IL_4ba8: Expected I, but got Obj
		//IL_4bbe: Expected Obj, but got I
		//IL_24cc: Expected Obj, but got I4
		//IL_4b64: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b69: Expected I4, but got Unknown
		//IL_1b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b80: Expected Obj, but got Unknown
		//IL_1fd0: Expected I, but got Obj
		//IL_1fe6: Expected Obj, but got I
		//IL_2008: Expected F4, but got Obj
		//IL_2003: Expected native int or pointer, but got VT
		//IL_201d: Expected F4, but got I
		//IL_2018: Expected native int or pointer, but got VT
		//IL_202a: Expected Obj, but got I4
		//IL_2033: Unknown result type (might be due to invalid IL or missing references)
		//IL_2038: Expected Obj, but got Unknown
		//IL_1f81: Expected I, but got Obj
		//IL_1f8f: Expected I, but got Obj
		//IL_1dc7: Expected F4, but got Obj
		//IL_1dc2: Expected native int or pointer, but got VT
		//IL_1ddc: Expected F4, but got I
		//IL_1dd7: Expected native int or pointer, but got VT
		//IL_1de9: Expected Obj, but got I4
		//IL_1df2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df7: Expected Obj, but got Unknown
		//IL_1d46: Expected Obj, but got F4
		//IL_4bec: Expected VT, but got Obj
		//IL_4c17: Expected VT, but got Obj
		//IL_4959: Expected native int or pointer, but got VT
		//IL_4967: Expected native int or pointer, but got VT
		//IL_4992: Expected native int or pointer, but got VT
		//IL_49ae: Expected native int or pointer, but got VT
		//IL_49bc: Expected native int or pointer, but got VT
		//IL_49ce: Expected native int or pointer, but got VT
		//IL_49e0: Expected native int or pointer, but got VT
		//IL_49fb: Expected native int or pointer, but got VT
		//IL_4a09: Expected native int or pointer, but got VT
		//IL_4a34: Expected native int or pointer, but got VT
		//IL_4a50: Expected native int or pointer, but got VT
		//IL_4a5e: Expected native int or pointer, but got VT
		//IL_4a70: Expected native int or pointer, but got VT
		//IL_4a82: Expected native int or pointer, but got VT
		//IL_4a9d: Expected native int or pointer, but got VT
		//IL_4aab: Expected native int or pointer, but got VT
		//IL_4ad6: Expected native int or pointer, but got VT
		//IL_4af2: Expected native int or pointer, but got VT
		//IL_4b00: Expected native int or pointer, but got VT
		//IL_4b12: Expected native int or pointer, but got VT
		//IL_4b24: Expected native int or pointer, but got VT
		//IL_23e8: Expected I, but got Obj
		//IL_24ed: Expected I, but got Obj
		//IL_2416: Expected Obj, but got I4
		//IL_2442: Expected Obj, but got F4
		//IL_2469: Expected F4, but got Obj
		//IL_2464: Expected native int or pointer, but got VT
		//IL_247e: Expected F4, but got I
		//IL_2479: Expected native int or pointer, but got VT
		//IL_2494: Unknown result type (might be due to invalid IL or missing references)
		//IL_2499: Expected Obj, but got Unknown
		//IL_1fbd: Expected I, but got Obj
		//IL_575c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5761: Expected Obj, but got Unknown
		//IL_5781: Unknown result type (might be due to invalid IL or missing references)
		//IL_5786: Expected Obj, but got Unknown
		//IL_1d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d81: Expected Obj, but got Unknown
		//IL_1d99: Expected Obj, but got F4
		//IL_2ab4: Expected Obj, but got I4
		//IL_253a: Expected I, but got Obj
		//IL_2550: Expected Obj, but got I
		//IL_28e5: Expected native int or pointer, but got VT
		//IL_28f3: Expected native int or pointer, but got VT
		//IL_2900: Expected native int or pointer, but got VT
		//IL_290d: Expected native int or pointer, but got VT
		//IL_291b: Expected native int or pointer, but got VT
		//IL_292d: Expected native int or pointer, but got VT
		//IL_293f: Expected native int or pointer, but got VT
		//IL_295a: Expected native int or pointer, but got VT
		//IL_2968: Expected native int or pointer, but got VT
		//IL_2975: Expected native int or pointer, but got VT
		//IL_2982: Expected native int or pointer, but got VT
		//IL_2990: Expected native int or pointer, but got VT
		//IL_29a2: Expected native int or pointer, but got VT
		//IL_29b4: Expected native int or pointer, but got VT
		//IL_4c34: Expected I, but got Obj
		//IL_4c4a: Expected Obj, but got I
		//IL_4d29: Expected I, but got Obj
		//IL_4d3f: Expected Obj, but got I
		//IL_29d4: Expected native int or pointer, but got VT
		//IL_29e2: Expected native int or pointer, but got VT
		//IL_29ef: Expected native int or pointer, but got VT
		//IL_29fc: Expected native int or pointer, but got VT
		//IL_2a0a: Expected native int or pointer, but got VT
		//IL_2a1c: Expected native int or pointer, but got VT
		//IL_2a2e: Expected native int or pointer, but got VT
		//IL_2a49: Expected Obj, but got I4
		//IL_2a57: Expected Obj, but got F4
		//IL_2a6f: Expected F4, but got Obj
		//IL_2a6a: Expected native int or pointer, but got VT
		//IL_2a84: Expected F4, but got I
		//IL_2a7f: Expected native int or pointer, but got VT
		//IL_257b: Expected I, but got Obj
		//IL_2ac7: Expected I, but got Obj
		//IL_2add: Expected Obj, but got I
		//IL_4c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ca2: Expected Obj, but got Unknown
		//IL_4cab: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cb0: Expected Obj, but got Unknown
		//IL_25ae: Expected I, but got Obj
		//IL_57bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_57c4: Expected Obj, but got Unknown
		//IL_57f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_57f8: Expected Obj, but got Unknown
		//IL_583a: Expected F4, but got Obj
		//IL_5835: Expected native int or pointer, but got VT
		//IL_584f: Expected F4, but got I
		//IL_584a: Expected native int or pointer, but got VT
		//IL_585c: Expected F4, but got Obj
		//IL_5857: Expected native int or pointer, but got VT
		//IL_5871: Expected F4, but got I
		//IL_586c: Expected native int or pointer, but got VT
		//IL_5895: Expected I4, but got VT
		//IL_5895: Expected I4, but got VT
		//IL_5895: Expected Ref, but got VT
		//IL_58a3: Expected I, but got Obj
		//IL_58b9: Expected Obj, but got I
		//IL_58d6: Expected I, but got Obj
		//IL_2bd5: Expected I, but got Obj
		//IL_4d66: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d6b: Expected Obj, but got Unknown
		//IL_4dab: Unknown result type (might be due to invalid IL or missing references)
		//IL_4db0: Expected Obj, but got Unknown
		//IL_4db9: Expected native int or pointer, but got VT
		//IL_4dc7: Expected native int or pointer, but got VT
		//IL_4de3: Expected native int or pointer, but got VT
		//IL_4dff: Expected native int or pointer, but got VT
		//IL_4e0d: Expected native int or pointer, but got VT
		//IL_4e1f: Expected native int or pointer, but got VT
		//IL_4e31: Expected native int or pointer, but got VT
		//IL_4e4c: Expected native int or pointer, but got VT
		//IL_4e5a: Expected native int or pointer, but got VT
		//IL_4e76: Expected native int or pointer, but got VT
		//IL_4e92: Expected native int or pointer, but got VT
		//IL_4ea0: Expected native int or pointer, but got VT
		//IL_4eb2: Expected native int or pointer, but got VT
		//IL_4ec4: Expected native int or pointer, but got VT
		//IL_4edf: Expected native int or pointer, but got VT
		//IL_4eed: Expected native int or pointer, but got VT
		//IL_4f09: Expected native int or pointer, but got VT
		//IL_4f25: Expected native int or pointer, but got VT
		//IL_4f33: Expected native int or pointer, but got VT
		//IL_4f45: Expected native int or pointer, but got VT
		//IL_4f57: Expected native int or pointer, but got VT
		//IL_2735: Expected Obj, but got I4
		//IL_25dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_25e1: Expected Obj, but got Unknown
		//IL_25ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ef: Expected Obj, but got Unknown
		//IL_25f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_25fc: Expected Obj, but got Unknown
		//IL_261a: Unknown result type (might be due to invalid IL or missing references)
		//IL_261f: Expected Obj, but got Unknown
		//IL_2628: Unknown result type (might be due to invalid IL or missing references)
		//IL_262d: Expected Obj, but got Unknown
		//IL_2635: Unknown result type (might be due to invalid IL or missing references)
		//IL_263a: Expected Obj, but got Unknown
		//IL_2658: Unknown result type (might be due to invalid IL or missing references)
		//IL_265d: Expected Obj, but got Unknown
		//IL_267a: Expected Obj, but got I
		//IL_2683: Unknown result type (might be due to invalid IL or missing references)
		//IL_2688: Expected Obj, but got Unknown
		//IL_26bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_26c1: Expected Obj, but got Unknown
		//IL_26de: Expected Obj, but got I
		//IL_26e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ec: Expected Obj, but got Unknown
		//IL_4ff0: Expected native int or pointer, but got VT
		//IL_5002: Expected native int or pointer, but got VT
		//IL_501d: Expected Obj, but got I
		//IL_502a: Expected Obj, but got F4
		//IL_5041: Expected F4, but got Obj
		//IL_503c: Expected native int or pointer, but got VT
		//IL_5056: Expected F4, but got I
		//IL_5051: Expected native int or pointer, but got VT
		//IL_5063: Expected F4, but got Obj
		//IL_505e: Expected native int or pointer, but got VT
		//IL_5078: Expected F4, but got I
		//IL_5073: Expected native int or pointer, but got VT
		//IL_508d: Expected I4, but got VT
		//IL_508d: Expected I4, but got VT
		//IL_508d: Expected Ref, but got VT
		//IL_509b: Expected I, but got Obj
		//IL_50a8: Expected native int or pointer, but got VT
		//IL_50ba: Expected native int or pointer, but got VT
		//IL_50d5: Expected Obj, but got I
		//IL_50e2: Expected Obj, but got F4
		//IL_2b36: Expected Obj, but got I4
		//IL_2b53: Expected Obj, but got F4
		//IL_2b7a: Expected F4, but got Obj
		//IL_2b75: Expected native int or pointer, but got VT
		//IL_2b8f: Expected F4, but got I
		//IL_2b8a: Expected native int or pointer, but got VT
		//IL_2ba5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2baa: Expected Obj, but got Unknown
		//IL_2bb2: Expected F4, but got Obj
		//IL_2bba: Expected F4, but got Obj
		//IL_2b08: Expected I, but got Obj
		//IL_4cef: Expected Obj, but got I4
		//IL_2727: Expected Obj, but got I4
		//IL_2d04: Expected Obj, but got I4
		//IL_2cac: Expected I, but got Obj
		//IL_2cba: Expected I, but got Obj
		//IL_2c2a: Expected Obj, but got I4
		//IL_2cf6: Expected Obj, but got I4
		//IL_2c1c: Expected Obj, but got I4
		//IL_2ce8: Expected I, but got Obj
		//IL_2743: Unknown result type (might be due to invalid IL or missing references)
		//IL_2748: Expected Obj, but got Unknown
		//IL_2751: Expected native int or pointer, but got VT
		//IL_275e: Expected native int or pointer, but got VT
		//IL_2778: Expected F4, but got I
		//IL_2773: Expected native int or pointer, but got VT
		//IL_2785: Expected Obj, but got F4
		//IL_2792: Expected F4, but got Obj
		//IL_278d: Expected native int or pointer, but got VT
		//IL_279f: Expected Obj, but got I4
		//IL_27a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ad: Expected Obj, but got Unknown
		//IL_27b6: Expected native int or pointer, but got VT
		//IL_27c3: Expected native int or pointer, but got VT
		//IL_27dd: Expected F4, but got I
		//IL_27d8: Expected native int or pointer, but got VT
		//IL_27ea: Expected Obj, but got F4
		//IL_27f7: Expected F4, but got Obj
		//IL_27f2: Expected native int or pointer, but got VT
		//IL_2804: Expected Obj, but got I4
		//IL_2e5a: Expected VT, but got Obj
		//IL_2c99: Expected VT, but got Obj
		//IL_2812: Unknown result type (might be due to invalid IL or missing references)
		//IL_2817: Expected Obj, but got Unknown
		//IL_2820: Expected native int or pointer, but got VT
		//IL_282d: Expected native int or pointer, but got VT
		//IL_2847: Expected F4, but got I
		//IL_2842: Expected native int or pointer, but got VT
		//IL_2854: Expected Obj, but got F4
		//IL_2861: Expected F4, but got Obj
		//IL_285c: Expected native int or pointer, but got VT
		//IL_286e: Expected Obj, but got I4
		//IL_2877: Unknown result type (might be due to invalid IL or missing references)
		//IL_287c: Expected Obj, but got Unknown
		//IL_2885: Expected Obj, but got I4
		//IL_288d: Expected Obj, but got F4
		//IL_28af: Expected F4, but got Obj
		//IL_28aa: Expected native int or pointer, but got VT
		//IL_28bc: Expected Obj, but got I4
		//IL_2d17: Expected I, but got Obj
		//IL_2d2d: Expected Obj, but got I
		//IL_2d4a: Expected I, but got Obj
		//IL_2c3c: Expected F4, but got Obj
		//IL_2c37: Expected native int or pointer, but got VT
		//IL_2c51: Expected F4, but got I
		//IL_2c4c: Expected native int or pointer, but got VT
		//IL_2c5e: Expected Obj, but got I4
		//IL_28ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_28cf: Expected Obj, but got Unknown
		//IL_5129: Expected Obj, but got I
		//IL_5136: Expected F4, but got Obj
		//IL_5131: Expected native int or pointer, but got VT
		//IL_514b: Expected F4, but got I
		//IL_5146: Expected native int or pointer, but got VT
		//IL_5158: Expected native int or pointer, but got VT
		//IL_516a: Expected native int or pointer, but got VT
		//IL_517c: Expected Obj, but got I4
		//IL_518a: Expected I, but got Obj
		//IL_51a0: Expected Obj, but got I
		//IL_51ad: Expected F4, but got Obj
		//IL_51a8: Expected native int or pointer, but got VT
		//IL_51c2: Expected F4, but got I
		//IL_51bd: Expected native int or pointer, but got VT
		//IL_51cf: Expected native int or pointer, but got VT
		//IL_51e1: Expected native int or pointer, but got VT
		//IL_51f3: Expected Obj, but got I4
		//IL_5201: Expected I, but got Obj
		//IL_5217: Expected Obj, but got I
		//IL_5224: Expected F4, but got Obj
		//IL_521f: Expected native int or pointer, but got VT
		//IL_5239: Expected F4, but got I
		//IL_5234: Expected native int or pointer, but got VT
		//IL_5246: Expected native int or pointer, but got VT
		//IL_5258: Expected native int or pointer, but got VT
		//IL_526a: Expected Obj, but got I4
		//IL_2db5: Expected I, but got Obj
		//IL_2dcb: Expected Obj, but got I
		//IL_2ded: Expected F4, but got Obj
		//IL_2de8: Expected native int or pointer, but got VT
		//IL_2e02: Expected F4, but got I
		//IL_2dfd: Expected native int or pointer, but got VT
		//IL_2e0f: Expected Obj, but got I4
		//IL_2d66: Expected I, but got Obj
		//IL_2d74: Expected I, but got Obj
		//IL_2da2: Expected I, but got Obj
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 344);
		Matrix4x4 matrix4x2 = (Matrix4x4)(obj + 160);
		Matrix4x4 matrix4x3 = (Matrix4x4)(obj + 48);
		Matrix4x4 matrix4x4 = (Matrix4x4)(obj + 32);
		object obj2 = obj + 16;
		object obj3 = obj + 208;
		bool flag = (byte)(obj + 192) != 0;
		object obj4 = obj + 176;
		object obj5 = obj + 152;
		object obj6 = obj + 144;
		object obj7 = obj + 136;
		object obj8 = obj + 128;
		object obj9 = obj + 120;
		object obj10 = obj + 112;
		object obj11 = obj + 104;
		object obj12 = obj + 96;
		object obj13 = obj + 88;
		object obj14 = obj + 80;
		object obj15 = obj + 72;
		object obj16 = obj - -64;
		object obj17 = obj + 328;
		obj17 = 0;
		_ = 0;
		object obj18 = obj + 312;
		obj18 = 0;
		_ = 0;
		object obj19 = obj + 296;
		obj19 = 0;
		_ = 0;
		object obj20 = obj + 280;
		obj20 = 0;
		_ = 0;
		object obj21 = obj + 276;
		obj21 = 0;
		object obj22 = obj + 364;
		obj22 = 0;
		object obj23 = obj + 363;
		obj23 = 0;
		object obj24 = obj + 362;
		obj24 = 0;
		object obj25 = obj + 361;
		obj25 = 0;
		object obj26 = obj + 360;
		obj26 = 0;
		object obj27 = obj + 272;
		obj27 = 0;
		object obj28 = obj + 256;
		obj28 = 0;
		_ = 0;
		object obj29 = obj + 240;
		obj29 = 0;
		_ = 0;
		object obj30 = obj + 224;
		obj30 = 0;
		_ = 0;
		if ((object)cam == null || ((UnityEngine.Object)cam).m_CachedPtr == (IntPtr)0)
		{
			return;
		}
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v60 (Il2CppClass<NGUIText>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S1_v1237 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUIText.EndLine(ref *(StringBuilder*)cam);
		Color black = Color.black;
		((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x3.m00;
		((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x3.m20;
		NGUIText.mColors.Add((Color)matrix4x);
		NGUIText.mAlpha = 1f;
		nint num3 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S3_v9 (Il2CppClass<NGUIText>)+5C]");
		object obj32 = (nint)0 + (nint)32;
		((Matrix4x4*)(nint)matrix4x4)->m00 = (float)obj32;
		Matrix4x4 matrix4x5 = matrix4x4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S3_v11+8]");
		((Matrix4x4*)(nint)matrix4x5)->m20 = 0f;
		nint num4 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S3_v16 (Il2CppClass<NGUIText>)+5C]");
		object obj33 = (nint)0 + (nint)72;
		obj2 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S3_v18+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x2)->m00 = matrix4x4.m00;
		((Matrix4x4*)(nint)matrix4x2)->m20 = matrix4x4.m20;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Matrix4x4 matrix4x6 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
		((Matrix4x4*)(nint)matrix4x6)->m20 = 0f;
		Matrix4x4 matrix4x7 = matrix4x2 * matrix4x;
		obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		nint num5 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S3_v36 (Il2CppClass<NGUIText>)+5C]");
		object obj34 = (nint)0 + (nint)32;
		obj3 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ S3_v38+8]");
		_ = 0;
		nint num6 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S3_v43 (Il2CppClass<NGUIText>)+5C]");
		object obj35 = (nint)0 + (nint)88;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj35 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ S3_v45+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x2)->m00 = (float)obj3;
		Matrix4x4 matrix4x8 = matrix4x2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		((Matrix4x4*)(nint)matrix4x8)->m20 = 0f;
		((Matrix4x4*)(nint)matrix4x)->m00 = (((bool*)(flag ? 1 : 0))->m_value ? 1 : 0);
		Matrix4x4 matrix4x9 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21 (System.Boolean)+8]");
		((Matrix4x4*)(nint)matrix4x9)->m20 = 0f;
		Matrix4x4 matrix4x10 = matrix4x2 * matrix4x;
		obj18 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
		_ = 0;
		nint num7 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S3_v63 (Il2CppClass<NGUIText>)+5C]");
		object obj36 = (nint)0 + (nint)32;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj36;
		Matrix4x4 matrix4x11 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S3_v65+8]");
		((Matrix4x4*)(nint)matrix4x11)->m20 = 0f;
		obj19 = matrix4x.m00;
		_ = matrix4x.m20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		float num8 = (float)NGUIText.finalSize * NGUIText.pixelDensity;
		float num9 = (float)NGUIText.regionWidth + 0.01f;
		obj21 = 0;
		obj22 = 0;
		obj23 = 0;
		obj24 = 0;
		obj25 = 0;
		obj26 = 0;
		nint num10 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ S2_v52 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj37 = (nint)0 & (nint)0x200;
		if (obj37 != null)
		{
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ S2_v384 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num14 = default;
		float num15;
		if (((ComputeShader)(object)NGUIText.bitmapFont).FindKernel((string)null) != 0)
		{
			nint num12 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S1_v1218 (Il2CppClass<NGUIText>)+BA]");
			object obj38 = (nint)0 & (nint)0x200;
			if (obj38 != null)
			{
				nint num13 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ S1_v1231 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((UIFont)matrix4x).uvRect = (Rect)NGUIText.bitmapFont;
			obj20 = matrix4x.m00;
			_ = matrix4x.m20;
			int texHeight = NGUIText.bitmapFont.texHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v58+8]");
			num14 = (int)((nint)0 / (nint)texHeight);
			bool hasSymbols = NGUIText.bitmapFont.hasSymbols;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v58+C]");
			num15 = 0f / (float)(hasSymbols ? 1 : 0);
		}
		else
		{
			num15 = 0f;
		}
		bool flag2 = !considerInactive;
		bool flag3 = !considerChildren;
		bool flag4 = considerInactive;
		bool flag5 = flag;
		char[] array = null;
		Vector3 vector = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ L1 (UnityEngine.Transform)+C]");
		int num16 = 0;
		float num21 = default;
		float num25 = default;
		object obj46 = default;
		float num136 = default;
		while (true)
		{
			obj27 = array;
			GameObject gameObject;
			Vector3 vector2;
			float num58;
			SpringPanel springPanel;
			float num130;
			object obj137;
			bool flag12;
			float num84;
			float m2;
			float num85;
			float num36;
			if ((nint)array < (nint)((UnityEngine.Object)cam).m_CachedPtr)
			{
				string[] array2 = ((string)(object)cam).Split(array);
				gameObject = (GameObject)(array2 & 0xFFFF);
				object obj39 = array2 & 0xFFFF;
				if ((nint)obj39 == 10)
				{
					nint num17 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ S0_v1502 (Il2CppClass<NGUIText>)+BA]");
					object obj40 = (nint)0 & (nint)0x200;
					if (obj40 != null)
					{
						nint num18 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ S0_v1542 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (NGUIText.alignment != NGUIText.Alignment.Left)
					{
						nint num19 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ S0_v1527 (Il2CppClass<NGUIText>)+BA]");
						object obj41 = (nint)0 & (nint)0x200;
						if (obj41 != null)
						{
							nint num20 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v961 @ S0_v1536 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float completedFactor = num21 - NGUIText.finalSpacingX;
						((MissionsManager)(object)t).Complete(num16, completedFactor, true);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ L1 (UnityEngine.Transform)+C]");
						num16 = 0;
					}
					nint num22 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ S0_v1512 (Il2CppClass<NGUIText>)+BA]");
					object obj42 = (nint)0 & (nint)0x200;
					if (obj42 != null)
					{
						nint num23 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ S0_v1520 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num24 = num25 + NGUIText.finalLineHeight;
					num25 = num24;
					num21 = 0f;
					vector2 = (Vector3)0;
					goto IL_393c;
				}
				object obj43 = array2 & 0xFFFF;
				bool flag6 = (nint)obj43 > 31;
				bool flag7 = !flag6;
				vector2 = (Vector3)gameObject;
				if (flag7)
				{
					goto IL_393c;
				}
				nint num26 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ S0_v164 (Il2CppClass<NGUIText>)+BA]");
				object obj44 = (nint)0 & (nint)0x200;
				if (obj44 != null)
				{
					nint num27 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ S0_v1495 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (~(NGUIText.encoding ? 1u : 0u) == 0)
				{
					nint num28 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ S0_v1348 (Il2CppClass<NGUIText>)+BA]");
					object obj45 = (nint)0 & (nint)0x200;
					if (obj45 != null)
					{
						nint num29 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ S0_v1489 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool premultiply = NGUIText.premultiply;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B752");
					if (obj46 != null)
					{
						nint num30 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ S0_v1355 (Il2CppClass<NGUIText>)+BA]");
						object obj47 = (nint)0 & (nint)0x200;
						bool flag8 = obj47 == null;
						if (obj26 != null)
						{
							if (!flag8)
							{
								nint num31 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ S0_v1484 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							BetterList<Color> mColors = NGUIText.mColors;
							BetterList<Color> mColors2 = NGUIText.mColors;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1139 @ S2_v355 (BetterList`1<UnityEngine.Color>)+C]");
							object obj48 = (nint)0 << 4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1134 @ S1_v1194 (BetterList`1<UnityEngine.Color>)+8]");
							object obj49 = 0 + obj48;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj49;
							Matrix4x4 matrix4x12 = matrix4x;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1143 @ S1_v1196+8]");
							((Matrix4x4*)(nint)matrix4x12)->m20 = 0f;
							obj19 = matrix4x.m00;
							_ = matrix4x.m20;
							object obj50 = obj19 + 12;
							nint num32 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1168 @ S3_v158 (Il2CppClass<NGUIText>)+5C]");
							object obj51 = (nint)0 + (nint)32;
							float num33 = NGUIText.mAlpha;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ S3_v160+C]");
							float num34 = num33 * 0f;
							float num35 = (float)obj50 * num34;
							obj50 = num35;
							num36 = (float)obj50;
						}
						else
						{
							bool flag9 = !flag8;
							bool flag10 = !flag9;
							nint num37 = (nint)typeof(NGUIText);
							if (!flag10)
							{
								nint num38 = (nint)typeof(NGUIText);
								num37 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ S0_v1466 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									num37 = (nint)typeof(NGUIText);
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ L0_v79 (Il2CppClass<NGUIText>)+5C]");
							object obj52 = (nint)0 + (nint)32;
							((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj52;
							Matrix4x4 matrix4x13 = matrix4x3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ S1_v1163+8]");
							((Matrix4x4*)(nint)matrix4x13)->m20 = 0f;
							BetterList<Color> mColors3 = NGUIText.mColors;
							BetterList<Color> mColors4 = NGUIText.mColors;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1202 @ S2_v344 (BetterList`1<UnityEngine.Color>)+C]");
							object obj53 = (nint)0 << 4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1197 @ S1_v1170 (BetterList`1<UnityEngine.Color>)+8]");
							object obj54 = 0 + obj53;
							((Matrix4x4*)(nint)matrix4x4)->m00 = (float)obj54;
							Matrix4x4 matrix4x14 = matrix4x4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ S1_v1172+8]");
							((Matrix4x4*)(nint)matrix4x14)->m20 = 0f;
							((Matrix4x4*)(nint)matrix4x2)->m00 = matrix4x3.m00;
							((Matrix4x4*)(nint)matrix4x2)->m20 = matrix4x3.m20;
							((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x4.m00;
							((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x4.m20;
							matrix4x10 = matrix4x2 * matrix4x;
							obj19 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
							_ = 0;
							object obj55 = obj19 + 12;
							float num39 = (float)obj55 * NGUIText.mAlpha;
							obj55 = num39;
							num36 = (float)obj55;
						}
						nint num40 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ S0_v1363 (Il2CppClass<NGUIText>)+BA]");
						object obj56 = (nint)0 & (nint)0x200;
						if (obj56 != null)
						{
							nint num41 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1300 @ S0_v1440 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						BetterList<Color> mColors5 = NGUIText.mColors;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1311 @ S0_v1369 (BetterList`1<UnityEngine.Color>)+C]");
						bool flag11 = (byte)(-2) != 0;
						flag12 = false;
						while ((flag12 ? 1 : 0) < (flag11 ? 1 : 0))
						{
							object obj57 = obj19 + 12;
							nint num42 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1415 @ S0_v1424 (Il2CppClass<NGUIText>)+BA]");
							object obj58 = (nint)0 & (nint)0x200;
							if (obj58 != null)
							{
								nint num43 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1432 @ S0_v1435 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							BetterList<Color> mColors6 = NGUIText.mColors;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1443 @ S1_v1151 (BetterList`1<UnityEngine.Color>)+8]");
							object obj59 = (nint)0 + (nint)16;
							object obj60 = (flag12 ? 1u : 0u) << 4;
							object obj61 = obj59 + obj60;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj61;
							Matrix4x4 matrix4x15 = matrix4x;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1449 @ S1_v1154+8]");
							((Matrix4x4*)(nint)matrix4x15)->m20 = 0f;
							float num44 = (float)obj57 * matrix4x.m30;
							obj57 = num44;
							bool flag13 = (byte)((flag12 ? 1u : 0u) + 1u) != 0;
							flag12 = flag13;
							num36 = (float)obj57;
						}
						nint num45 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1421 @ S0_v1377 (Il2CppClass<NGUIText>)+BA]");
						object obj62 = (nint)0 & (nint)0x200;
						if (obj62 != null)
						{
							nint num46 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1459 @ S0_v1415 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (~(NGUIText.gradient ? 1u : 0u) == 0)
						{
							nint num47 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1530 @ S0_v1388 (Il2CppClass<NGUIText>)+BA]");
							object obj63 = (nint)0 & (nint)0x200;
							bool flag14 = obj63 == null;
							nint num48 = (nint)typeof(NGUIText);
							if (!flag14)
							{
								nint num49 = (nint)typeof(NGUIText);
								num48 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ S0_v1410 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									num48 = (nint)typeof(NGUIText);
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1622 @ L0_v69 (Il2CppClass<NGUIText>)+5C]");
							object obj64 = (nint)0 + (nint)72;
							((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj64;
							Matrix4x4 matrix4x16 = matrix4x3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1630 @ S1_v1110+8]");
							((Matrix4x4*)(nint)matrix4x16)->m20 = 0f;
							((Matrix4x4*)(nint)matrix4x2)->m00 = matrix4x3.m00;
							((Matrix4x4*)(nint)matrix4x2)->m20 = matrix4x3.m20;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj19;
							Matrix4x4 matrix4x17 = matrix4x;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v55+8]");
							((Matrix4x4*)(nint)matrix4x17)->m20 = 0f;
							Matrix4x4 matrix4x18 = matrix4x2 * matrix4x;
							obj17 = matrix4x4.m00;
							_ = matrix4x4.m20;
							nint num50 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1757 @ S1_v1128 (Il2CppClass<NGUIText>)+5C]");
							object obj65 = (nint)0 + (nint)88;
							obj2 = obj65;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1760 @ S1_v1130+8]");
							_ = 0;
							((Matrix4x4*)(nint)matrix4x2)->m00 = (float)obj2;
							Matrix4x4 matrix4x19 = matrix4x2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
							((Matrix4x4*)(nint)matrix4x19)->m20 = 0f;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj19;
							Matrix4x4 matrix4x20 = matrix4x;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v55+8]");
							((Matrix4x4*)(nint)matrix4x20)->m20 = 0f;
							matrix4x10 = matrix4x2 * matrix4x;
							obj18 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							_ = 0;
						}
						object obj66 = obj27 - 1;
						obj27 = obj66;
						flag5 = flag11;
						vector2 = vector;
						goto IL_393c;
					}
				}
				nint num51 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ S0_v173 (Il2CppClass<NGUIText>)+BA]");
				object obj67 = (nint)0 & (nint)0x200;
				if (obj67 != null)
				{
					nint num52 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ S0_v1341 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num55;
				if (~(NGUIText.useSymbols ? 1u : 0u) == 0)
				{
					nint num53 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1062 @ S0_v1331 (Il2CppClass<NGUIText>)+BA]");
					object obj68 = (nint)0 & (nint)0x200;
					if (obj68 != null)
					{
						nint num54 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1082 @ S0_v1337 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					num55 = NGUIText.GetExactCharacterIndex((List<Vector3>)(object)cam, (List<int>)obj27, (Vector2)(nint)((UnityEngine.Object)cam).m_CachedPtr);
				}
				else
				{
					num55 = 0;
				}
				nint num56 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1101 @ S0_v182 (Il2CppClass<NGUIText>)+BA]");
				object obj69 = (nint)0 & (nint)0x200;
				bool flag15 = obj69 == null;
				bool flag16 = (byte)(int)(~obj21) != 0;
				if (flag16)
				{
					if (!flag15)
					{
						nint num57 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1229 @ S0_v1321 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					num58 = NGUIText.fontScale;
				}
				else
				{
					if (!flag15)
					{
						nint num59 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1241 @ S0_v1309 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					num58 = NGUIText.fontScale * 0.75f;
				}
				if (num55 != 0)
				{
					nint num60 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1322 @ S0_v1051 (Il2CppClass<NGUIText>)+BA]");
					object obj70 = (nint)0 & (nint)0x200;
					if (obj70 != null)
					{
						nint num61 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1355 @ S0_v1297 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ S0_v180 (System.Int32)+1C]");
					float num62 = 0f * NGUIText.fontScale;
					float num63 = num21 + num62;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ S0_v180 (System.Int32)+24]");
					float num64 = 0f * NGUIText.fontScale;
					float num65 = num63 + num64;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ S0_v180 (System.Int32)+20]");
					float num66 = 0f * NGUIText.fontScale;
					float num67 = num25 + num66;
					float num68 = 0f - num67;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ S0_v180 (System.Int32)+28]");
					float num69 = 0f * NGUIText.fontScale;
					float num70 = num68 - num69;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ S0_v180 (System.Int32)+2C]");
					float num71 = 0f * num58;
					float num72 = num21 + num71;
					float m;
					if (num72 > num9)
					{
						if (num21 == 0f)
						{
							break;
						}
						nint num73 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1471 @ S0_v1243 (Il2CppClass<NGUIText>)+BA]");
						object obj71 = (nint)0 & (nint)0x200;
						if (obj71 != null)
						{
							nint num74 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1549 @ S0_v1292 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (NGUIText.alignment != NGUIText.Alignment.Left)
						{
							int num75 = num16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ L1 (UnityEngine.Transform)+C]");
							if ((nint)num75 < (nint)0)
							{
								nint num76 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1781 @ S0_v1278 (Il2CppClass<NGUIText>)+BA]");
								object obj72 = (nint)0 & (nint)0x200;
								if (obj72 != null)
								{
									nint num77 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1893 @ S0_v1287 (Il2CppClass<NGUIText>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								float completedFactor2 = num21 - NGUIText.finalSpacingX;
								((MissionsManager)(object)t).Complete(num16, completedFactor2, true);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ L1 (UnityEngine.Transform)+C]");
								num16 = 0;
							}
						}
						float num78 = num63 - num21;
						float num79 = num65 - num21;
						nint num80 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1679 @ S0_v1257 (Il2CppClass<NGUIText>)+BA]");
						object obj73 = (nint)0 & (nint)0x200;
						if (obj73 != null)
						{
							nint num81 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1786 @ S0_v1268 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float num82 = num68 - NGUIText.finalLineHeight;
						float num83 = num25 + NGUIText.finalLineHeight;
						m = num70 - NGUIText.finalLineHeight;
						num25 = num83;
						num84 = num79;
						m2 = num78;
						num85 = 0f;
						num36 = num82;
					}
					else
					{
						num84 = num65;
						m2 = num63;
						num85 = num21;
						num36 = num68;
						m = num70;
					}
					((Matrix4x4*)(nint)matrix4x2)->m00 = 0f;
					((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x2)->m00 = m2;
					((Matrix4x4*)(nint)matrix4x2)->m10 = m;
					((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x2.m00;
					((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x2.m20;
					((List<Vector3>)(object)t).Add((Vector3)matrix4x);
					((Matrix4x4*)(nint)matrix4x3)->m00 = 0f;
					((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x3)->m00 = m2;
					((Matrix4x4*)(nint)matrix4x3)->m10 = num36;
					((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x3.m00;
					((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x3.m20;
					((List<Vector3>)(object)t).Add((Vector3)matrix4x);
					((Matrix4x4*)(nint)matrix4x4)->m00 = 0f;
					((Matrix4x4*)(nint)matrix4x4)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x4)->m00 = num84;
					((Matrix4x4*)(nint)matrix4x4)->m10 = num36;
					((Matrix4x4*)(nint)matrix4x4)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x4.m00;
					((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x4.m20;
					((List<Vector3>)(object)t).Add((Vector3)matrix4x);
					obj2 = 0;
					_ = 0;
					obj2 = num84;
					_ = 0f;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
					Matrix4x4 matrix4x21 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					((Matrix4x4*)(nint)matrix4x21)->m20 = 0f;
					((List<Vector3>)(object)t).Add((Vector3)matrix4x);
					nint num86 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1905 @ S0_v1107 (Il2CppClass<NGUIText>)+BA]");
					object obj74 = (nint)0 & (nint)0x200;
					if (obj74 != null)
					{
						nint num87 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1950 @ S0_v1233 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num88 = num71 + NGUIText.finalSpacingX;
					float num89 = num85 + num88;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ S0_v180 (System.Int32)+18]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ S0_v180 (System.Int32)+8]");
						object obj75 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1995 @ S1_v1067+8]");
						_ = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ S0_v180 (System.Int32)+18]");
					object obj76 = -1;
					object obj77 = obj76 + obj27;
					obj27 = obj77;
					if (!flag2)
					{
						object obj78 = num55 + 48;
						((Matrix4x4*)(nint)matrix4x2)->m00 = (float)obj78;
						Matrix4x4 matrix4x22 = matrix4x2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2045 @ S1_v1022+8]");
						((Matrix4x4*)(nint)matrix4x22)->m20 = 0f;
						obj28 = matrix4x2.m00;
						_ = matrix4x2.m20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v75+8]");
						float num90 = 0f + (float)obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v75+C]");
						float num91 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v75+4]");
						float num92 = num91 + 0f;
						((Matrix4x4*)(nint)matrix4x3)->m00 = 0f;
						((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj28;
						Matrix4x4 matrix4x23 = matrix4x3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v75+4]");
						((Matrix4x4*)(nint)matrix4x23)->m10 = 0f;
						obj5 = matrix4x3.m00;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
						((List<Vector2>)considerInactive).Add((Vector2)matrix4x);
						((Matrix4x4*)(nint)matrix4x4)->m00 = 0f;
						((Matrix4x4*)(nint)matrix4x4)->m00 = (float)obj28;
						((Matrix4x4*)(nint)matrix4x4)->m10 = num92;
						obj6 = matrix4x4.m00;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
						((List<Vector2>)considerInactive).Add((Vector2)matrix4x);
						obj2 = 0;
						obj2 = num90;
						obj7 = obj2;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
						((List<Vector2>)considerInactive).Add((Vector2)matrix4x);
						obj = 0;
						obj = num90;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v75+4]");
						_ = 0;
						obj8 = obj;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
						((List<Vector2>)considerInactive).Add((Vector2)matrix4x);
						num84 = num90;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v75+4]");
						m2 = 0f;
						num85 = (float)obj28;
						num36 = num92;
					}
					if (flag3)
					{
						flag12 = flag16;
						num21 = num89;
						flag5 = (byte)(int)obj21 != 0;
						vector2 = (Vector3)0;
					}
					else
					{
						nint num93 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2151 @ S0_v1125 (Il2CppClass<NGUIText>)+BA]");
						object obj79 = (nint)0 & (nint)0x200;
						if (obj79 != null)
						{
							nint num94 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2200 @ S0_v1180 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (NGUIText.symbolStyle == NGUIText.SymbolStyle.Colored)
						{
							object obj80 = 0;
							while ((nint)obj80 <= 3)
							{
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj19;
								Matrix4x4 matrix4x24 = matrix4x;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v55+8]");
								((Matrix4x4*)(nint)matrix4x24)->m20 = 0f;
								((List<Color>)considerChildren).Add((Color)matrix4x);
								object obj81 = obj80 + 1;
								obj80 = obj81;
							}
							flag12 = flag16;
							num21 = num89;
							flag5 = (byte)(int)obj21 != 0;
							vector2 = (Vector3)0;
						}
						else
						{
							Color black2 = Color.black;
							obj29 = matrix4x.m00;
							_ = matrix4x.m20;
							nint num95 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2284 @ S0_v1137 (Il2CppClass<NGUIText>)+BA]");
							object obj82 = (nint)0 & (nint)0x200;
							if (obj82 != null)
							{
								nint num96 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2300 @ S0_v1163 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (NGUIText.symbolStyle == NGUIText.SymbolStyle.NoOutline)
							{
								obj29 = -1f;
								_ = 0f;
							}
							else
							{
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj19;
								Matrix4x4 matrix4x25 = matrix4x;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v55+8]");
								((Matrix4x4*)(nint)matrix4x25)->m20 = 0f;
								_ = matrix4x.m30;
							}
							object obj83 = 0;
							while ((nint)obj83 <= 3)
							{
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj29;
								Matrix4x4 matrix4x26 = matrix4x;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v78+8]");
								((Matrix4x4*)(nint)matrix4x26)->m20 = 0f;
								((List<Color>)considerChildren).Add((Color)matrix4x);
								object obj84 = obj83 + 1;
								obj83 = obj84;
							}
							flag12 = flag16;
							num21 = num89;
							flag5 = (byte)(int)obj21 != 0;
							vector2 = (Vector3)0;
						}
					}
					goto IL_393c;
				}
				nint num97 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ S0_v192 (Il2CppClass<NGUIText>)+BA]");
				object obj85 = (nint)0 & (nint)0x200;
				if (obj85 != null)
				{
					nint num98 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1400 @ S0_v1044 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				springPanel = SpringPanel.Begin(gameObject, vector, num58);
				if ((object)springPanel != null)
				{
					if (!flag16)
					{
						nint num99 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1584 @ S1_v881 (Il2CppClass<NGUIText>)+BA]");
						object obj86 = (nint)0 & (nint)0x200;
						bool flag17 = obj86 == null;
						if ((nint)obj21 == 1)
						{
							if (!flag17)
							{
								nint num100 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1829 @ S1_v916 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							float num101 = NGUIText.fontScale * (float)NGUIText.fontSize;
							float num102 = num101 * 0.4f;
							object obj87 = springPanel + 12;
							float num103 = (float)obj87 - num102;
							obj87 = num103;
							object obj88 = springPanel + 20;
							float num104 = (float)obj88 - num102;
							obj88 = num104;
						}
						else
						{
							if (!flag17)
							{
								nint num105 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1857 @ S1_v899 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							float num106 = NGUIText.fontScale * (float)NGUIText.fontSize;
							float num107 = num106 * 0.05f;
							object obj89 = springPanel + 12;
							float num108 = (float)obj89 + num107;
							obj89 = num108;
							object obj90 = springPanel + 20;
							float num109 = (float)obj90 + num107;
							obj90 = num109;
						}
					}
					nint num110 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1613 @ S1_v133 (Il2CppClass<NGUIText>)+BA]");
					object obj91 = (nint)0 & (nint)0x200;
					if (obj91 != null)
					{
						nint num111 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1710 @ S1_v875 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1408 @ S0_v197 (SpringPanel)+38]");
					float num112 = 0f + NGUIText.finalSpacingX;
					object obj92 = springPanel + 8;
					float num113 = (float)obj92 + num21;
					object obj93 = springPanel + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1727 @ S0_v207+4]");
					float num114 = 0f - num25;
					object obj94 = springPanel + 16;
					float num115 = (float)obj94 + num21;
					object obj95 = springPanel + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1739 @ S0_v215+4]");
					float num116 = 0f - num25;
					float num117 = num21 + num112;
					if (num117 > num9)
					{
						if (num21 == 0f)
						{
							break;
						}
						nint num118 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1915 @ S0_v990 (Il2CppClass<NGUIText>)+BA]");
						object obj96 = (nint)0 & (nint)0x200;
						if (obj96 != null)
						{
							nint num119 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1972 @ S0_v1039 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (NGUIText.alignment != NGUIText.Alignment.Left)
						{
							int num120 = num16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ L1 (UnityEngine.Transform)+C]");
							if ((nint)num120 < (nint)0)
							{
								nint num121 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2102 @ S0_v1025 (Il2CppClass<NGUIText>)+BA]");
								object obj97 = (nint)0 & (nint)0x200;
								if (obj97 != null)
								{
									nint num122 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2157 @ S0_v1034 (Il2CppClass<NGUIText>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								float completedFactor3 = num21 - NGUIText.finalSpacingX;
								((MissionsManager)(object)t).Complete(num16, completedFactor3, true);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ L1 (UnityEngine.Transform)+C]");
								num16 = 0;
							}
						}
						float num123 = num113 - num21;
						float num124 = num115 - num21;
						nint num125 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2035 @ S0_v1004 (Il2CppClass<NGUIText>)+BA]");
						object obj98 = (nint)0 & (nint)0x200;
						if (obj98 != null)
						{
							nint num126 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2107 @ S0_v1015 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float num127 = num114 - NGUIText.finalLineHeight;
						float num128 = num116 - NGUIText.finalLineHeight;
						float num129 = num25 + NGUIText.finalLineHeight;
						num25 = num129;
						num84 = num123;
						m2 = num127;
						num85 = num128;
						num36 = num124;
						num130 = 0f;
					}
					else
					{
						num84 = num113;
						m2 = num114;
						num85 = num116;
						num36 = num115;
						num130 = num21;
					}
					nint num131 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1940 @ S0_v223 (Il2CppClass<NGUIText>)+BA]");
					object obj99 = (nint)0 & (nint)0x200;
					if (obj99 != null)
					{
						nint num132 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1984 @ S0_v983 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text;
					if (NGUIText.CalculateOffsetToFit((string)(object)gameObject) != 0)
					{
						text = (string)95;
						if (obj24 == null)
						{
							text = (string)((obj25 == null) ? ((object)gameObject) : ((object)(string)45));
						}
					}
					else
					{
						text = (string)(object)gameObject;
					}
					float num133 = num130 + num112;
					bool flag18 = !flag16;
					bool flag19 = !flag18;
					num21 = num133;
					if (!flag19)
					{
						nint num134 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2220 @ S1_v842 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj100 = (nint)0 & (nint)0x200;
						if (obj100 != null)
						{
							nint num135 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2256 @ S1_v848 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
						num21 = num136;
					}
					nint num137 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2233 @ S1_v160 (Il2CppClass<NGUIText>)+BA]");
					object obj101 = (nint)0 & (nint)0x200;
					if (obj101 != null)
					{
						nint num138 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2261 @ S1_v838 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num139 = NGUIText.CalculateOffsetToFit(text);
					flag12 = flag16;
					flag5 = (byte)(int)obj21 != 0;
					vector2 = (Vector3)gameObject;
					if (num139 != 0)
					{
						goto IL_393c;
					}
					if (flag4)
					{
						nint num140 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2330 @ S0_v911 (Il2CppClass<NGUIText>)+BA]");
						object obj102 = (nint)0 & (nint)0x200;
						if (obj102 != null)
						{
							nint num141 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2361 @ S0_v971 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						nint num142 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2371 @ S1_v764 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj103 = (nint)0 & (nint)0x200;
						if (obj103 != null)
						{
							nint num143 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2394 @ S1_v835 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (((ComputeShader)(object)NGUIText.bitmapFont).FindKernel((string)null) != 0)
						{
							object obj104 = springPanel + 24;
							object obj105 = springPanel + 24;
							object obj106 = num14 * obj105;
							object obj107 = obj20 + obj106;
							obj104 = obj107;
							object obj108 = springPanel + 40;
							object obj109 = springPanel + 40;
							object obj110 = num14 * obj109;
							object obj111 = obj20 + obj110;
							obj108 = obj111;
							object obj112 = springPanel + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v58+C]");
							nint num144 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v58+4]");
							object obj113 = num144 + 0;
							object obj114 = springPanel + 24;
							float num145 = num15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2548 @ S3_v122+4]");
							float num146 = num145 * 0f;
							float num147 = (float)obj113 - num146;
							object obj115 = springPanel + 40;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v58+C]");
							nint num148 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v58+4]");
							object obj116 = num148 + 0;
							object obj117 = springPanel + 40;
							float num149 = num15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2563 @ S3_v125+4]");
							float num150 = num149 * 0f;
							float num151 = (float)obj116 - num150;
							object obj118 = springPanel + 32;
							object obj119 = springPanel + 24;
							obj118 = obj119;
							object obj120 = springPanel + 32;
							object obj121 = springPanel + 40;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2579 @ S1_v825+4]");
							_ = 0;
							object obj122 = springPanel + 48;
							object obj123 = springPanel + 40;
							obj122 = obj123;
							object obj124 = springPanel + 48;
							object obj125 = springPanel + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2593 @ S1_v833+4]");
							_ = 0;
						}
						object obj126 = ((obj22 == null) ? ((object)1) : ((object)4));
						object obj127 = 0;
						while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj127) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj126))
						{
							((Matrix4x4*)(nint)matrix4x2)->m00 = springPanel.strength;
							obj9 = matrix4x2.m00;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
							((List<Vector2>)considerInactive).Add((Vector2)matrix4x);
							((Matrix4x4*)(nint)matrix4x3)->m00 = (float)springPanel.mPanel;
							obj10 = matrix4x3.m00;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
							((List<Vector2>)considerInactive).Add((Vector2)matrix4x);
							((Matrix4x4*)(nint)matrix4x4)->m00 = (float)springPanel.mDrag;
							obj11 = matrix4x4.m00;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
							((List<Vector2>)considerInactive).Add((Vector2)matrix4x);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1408 @ S0_v197 (SpringPanel)+30]");
							obj2 = 0;
							obj12 = obj2;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
							((List<Vector2>)considerInactive).Add((Vector2)matrix4x);
							object obj128 = obj127 + 1;
							obj127 = obj128;
						}
					}
					object obj129;
					if (flag3)
					{
						obj129 = obj22;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1408 @ S0_v197 (SpringPanel)+3C]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1408 @ S0_v197 (SpringPanel)+3C]");
							if ((nint)0 != 15)
							{
								obj30 = obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v55+8]");
								_ = 0;
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj19;
								Matrix4x4 matrix4x27 = matrix4x;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v55+8]");
								((Matrix4x4*)(nint)matrix4x27)->m20 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F51F");
								obj30 = matrix4x2.m00;
								_ = matrix4x2.m20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1408 @ S0_v197 (SpringPanel)+3C]");
								object obj130 = -1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1408 @ S0_v197 (SpringPanel)+3C]");
								if ((nint)0 != 1)
								{
									if ((nint)obj130 != 1)
									{
										if ((nint)obj130 != 2)
										{
											if ((nint)obj130 == 3)
											{
												float num152 = (float)obj30 + 0.51f;
												obj30 = num152;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1408 @ S0_v197 (SpringPanel)+3C]");
												if ((nint)0 == 8)
												{
													object obj131 = obj30 + 12;
													float num153 = (float)obj131 + 0.51f;
													obj131 = num153;
												}
											}
										}
									}
									else
									{
										object obj132 = obj30 + 4;
										float num154 = (float)obj132 + 0.51f;
										obj132 = num154;
									}
								}
								else
								{
									object obj133 = obj30 + 8;
									float num155 = (float)obj133 + 0.51f;
									obj133 = num155;
								}
								object obj134 = ((obj22 == null) ? ((object)4) : ((object)16));
								object obj135 = 0;
								while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj135) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj134))
								{
									((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj30;
									Matrix4x4 matrix4x28 = matrix4x;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v81+8]");
									((Matrix4x4*)(nint)matrix4x28)->m20 = 0f;
									((List<Color>)considerChildren).Add((Color)matrix4x);
									object obj136 = obj135 + 1;
									obj135 = obj136;
								}
								obj137 = obj22;
								goto IL_4288;
							}
						}
						nint num156 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2433 @ S0_v752 (Il2CppClass<NGUIText>)+BA]");
						object obj138 = (nint)0 & (nint)0x200;
						if (obj138 != null)
						{
							nint num157 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2501 @ S0_v864 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (~(NGUIText.gradient ? 1u : 0u) != 0)
						{
							object obj139 = ((obj22 == null) ? ((object)4) : ((object)16));
							object obj140 = 0;
							while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj140) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj139))
							{
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj19;
								Matrix4x4 matrix4x29 = matrix4x;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v55+8]");
								((Matrix4x4*)(nint)matrix4x29)->m20 = 0f;
								((List<Color>)considerChildren).Add((Color)matrix4x);
								object obj141 = obj140 + 1;
								obj140 = obj141;
							}
							obj137 = obj22;
							goto IL_4288;
						}
						object obj142 = springPanel + 8;
						nint num158 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2626 @ S0_v764 (Il2CppClass<NGUIText>)+BA]");
						object obj143 = (nint)0 & (nint)0x200;
						if (obj143 != null)
						{
							nint num159 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2696 @ S0_v843 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2622 @ S0_v761+4]");
						float num160 = 0f / NGUIText.fontScale;
						float num161 = num8 + num160;
						object obj144 = springPanel + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2712 @ S1_v627+4]");
						float num162 = 0f / NGUIText.fontScale;
						float num163 = num8 + num162;
						float value = num163 / num8;
						((Matrix4x4*)(nint)matrix4x2)->m00 = (float)obj17;
						Matrix4x4 matrix4x30 = matrix4x2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49+8]");
						((Matrix4x4*)(nint)matrix4x30)->m20 = 0f;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj18;
						Matrix4x4 matrix4x31 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v52+8]");
						((Matrix4x4*)(nint)matrix4x31)->m20 = 0f;
						float value2 = num161 / num8;
						((Matrix4x4*)matrix4x3)->set_Item((int)matrix4x2, (int)matrix4x, value2);
						nint num164 = (nint)typeof(NGUIText);
						((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x3.m00;
						((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x3.m20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2867 @ S0_v779 (Il2CppClass<NGUIText>)+5C]");
						object obj145 = (nint)0 + (nint)224;
						obj145 = matrix4x.m00;
						_ = matrix4x.m20;
						((Matrix4x4*)(nint)matrix4x2)->m00 = (float)obj17;
						Matrix4x4 matrix4x32 = matrix4x2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49+8]");
						((Matrix4x4*)(nint)matrix4x32)->m20 = 0f;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj18;
						Matrix4x4 matrix4x33 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v52+8]");
						((Matrix4x4*)(nint)matrix4x33)->m20 = 0f;
						((Matrix4x4*)matrix4x4)->set_Item((int)matrix4x2, (int)matrix4x, value);
						nint num165 = (nint)typeof(NGUIText);
						((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x4.m00;
						((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x4.m20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2997 @ S0_v789 (Il2CppClass<NGUIText>)+5C]");
						object obj146 = (nint)0 + (nint)240;
						obj146 = matrix4x.m00;
						_ = matrix4x.m20;
						obj129 = obj22;
						object obj147 = ((obj22 == null) ? ((object)1) : ((object)4));
						object obj148 = 0;
						while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj148) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj147))
						{
							nint num166 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3328 @ S0_v802 (Il2CppClass<NGUIText>)+BA]");
							object obj149 = (nint)0 & (nint)0x200;
							bool flag20 = obj149 == null;
							nint num167 = (nint)typeof(NGUIText);
							if (!flag20)
							{
								nint num168 = (nint)typeof(NGUIText);
								num167 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3362 @ S0_v836 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									num167 = (nint)typeof(NGUIText);
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3364 @ L5_v101 (Il2CppClass<NGUIText>)+5C]");
							object obj150 = (nint)0 + (nint)224;
							((Matrix4x4*)(nint)matrix4x2)->m00 = (float)obj150;
							Matrix4x4 matrix4x34 = matrix4x2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3372 @ S1_v668+8]");
							((Matrix4x4*)(nint)matrix4x34)->m20 = 0f;
							((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x2.m00;
							((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x2.m20;
							((List<Color>)considerChildren).Add((Color)matrix4x);
							nint num169 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3437 @ S1_v678 (Il2CppClass<NGUIText>)+5C]");
							object obj151 = (nint)0 + (nint)240;
							((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj151;
							Matrix4x4 matrix4x35 = matrix4x3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3440 @ S1_v680+8]");
							((Matrix4x4*)(nint)matrix4x35)->m20 = 0f;
							((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x3.m00;
							((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x3.m20;
							((List<Color>)considerChildren).Add((Color)matrix4x);
							nint num170 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3501 @ S1_v690 (Il2CppClass<NGUIText>)+5C]");
							object obj152 = (nint)0 + (nint)240;
							((Matrix4x4*)(nint)matrix4x4)->m00 = (float)obj152;
							Matrix4x4 matrix4x36 = matrix4x4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3504 @ S1_v692+8]");
							((Matrix4x4*)(nint)matrix4x36)->m20 = 0f;
							((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x4.m00;
							((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x4.m20;
							((List<Color>)considerChildren).Add((Color)matrix4x);
							nint num171 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3573 @ S1_v702 (Il2CppClass<NGUIText>)+5C]");
							object obj153 = (nint)0 + (nint)224;
							obj2 = obj153;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3576 @ S1_v704+8]");
							_ = 0;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
							Matrix4x4 matrix4x37 = matrix4x;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
							((Matrix4x4*)(nint)matrix4x37)->m20 = 0f;
							((List<Color>)considerChildren).Add((Color)matrix4x);
							object obj154 = obj148 + 1;
							obj148 = obj154;
						}
					}
					obj137 = obj129;
					goto IL_4288;
				}
				flag12 = flag16;
				flag5 = (byte)(int)obj21 != 0;
				vector2 = vector;
				goto IL_393c;
			}
			nint num172 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ S0_v98 (Il2CppClass<NGUIText>)+BA]");
			object obj155 = (nint)0 & (nint)0x200;
			if (obj155 != null)
			{
				nint num173 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ S0_v143 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (NGUIText.alignment != NGUIText.Alignment.Left)
			{
				int num174 = num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ L1 (UnityEngine.Transform)+C]");
				if ((nint)num174 < (nint)0)
				{
					nint num175 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ S0_v128 (Il2CppClass<NGUIText>)+BA]");
					object obj156 = (nint)0 & (nint)0x200;
					if (obj156 != null)
					{
						nint num176 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ S0_v137 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float completedFactor4 = num21 - NGUIText.finalSpacingX;
					((MissionsManager)(object)t).Complete(num16, completedFactor4, true);
				}
			}
			nint num177 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ S0_v108 (Il2CppClass<NGUIText>)+BA]");
			object obj157 = (nint)0 & (nint)0x200;
			if (obj157 != null)
			{
				nint num178 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ S0_v117 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<Color> mColors7 = NGUIText.mColors;
			_ = 0;
			break;
			IL_393c:
			char[] array3 = (char[])(obj27 + 1);
			array = array3;
			vector = vector2;
			continue;
			IL_4288:
			bool flag21 = obj23 == null;
			object obj158 = obj137 & 0xFF;
			bool flag22 = obj158 == null;
			if (flag22)
			{
				if (flag21)
				{
					((Matrix4x4*)(nint)matrix4x2)->m00 = 0f;
					((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x2)->m00 = num84;
					((Matrix4x4*)(nint)matrix4x2)->m10 = m2;
					((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x2.m00;
					((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x2.m20;
					((List<Vector3>)(object)t).Add((Vector3)matrix4x);
					((Matrix4x4*)(nint)matrix4x3)->m00 = 0f;
					((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x3)->m00 = num84;
					((Matrix4x4*)(nint)matrix4x3)->m10 = num85;
					((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x3.m00;
					((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x3.m20;
					((List<Vector3>)(object)t).Add((Vector3)matrix4x);
					((Matrix4x4*)(nint)matrix4x4)->m00 = 0f;
					((Matrix4x4*)(nint)matrix4x4)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x4)->m00 = num36;
					((Matrix4x4*)(nint)matrix4x4)->m10 = num85;
					((Matrix4x4*)(nint)matrix4x4)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x4.m00;
					((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x4.m20;
					((List<Vector3>)(object)t).Add((Vector3)matrix4x);
					obj2 = 0;
					_ = 0;
					obj2 = num36;
					_ = 0f;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
					Matrix4x4 matrix4x38 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					((Matrix4x4*)(nint)matrix4x38)->m20 = 0f;
					((List<Vector3>)(object)t).Add((Vector3)matrix4x);
					SpringPanel springPanel2 = springPanel;
				}
				else
				{
					nint num179 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2657 @ S0_v653 (Il2CppClass<NGUIText>)+BA]");
					object obj159 = (nint)0 & (nint)0x200;
					if (obj159 != null)
					{
						nint num180 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2766 @ S0_v702 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num181 = (float)NGUIText.fontSize * 0.1f;
					float num182 = num85 - m2;
					int num183 = (int)(num182 / NGUIText.fontSize);
					float num184 = num181 * (float)num183;
					((Matrix4x4*)(nint)matrix4x2)->m00 = 0f;
					((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
					float m3 = num84 - num184;
					((Matrix4x4*)(nint)matrix4x2)->m00 = m3;
					((Matrix4x4*)(nint)matrix4x2)->m10 = m2;
					((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x2.m00;
					((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x2.m20;
					((List<Vector3>)(object)t).Add((Vector3)matrix4x);
					((Matrix4x4*)(nint)matrix4x3)->m00 = 0f;
					((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
					float m4 = num84 + num184;
					((Matrix4x4*)(nint)matrix4x3)->m00 = m4;
					((Matrix4x4*)(nint)matrix4x3)->m10 = num85;
					((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x3.m00;
					((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x3.m20;
					((List<Vector3>)(object)t).Add((Vector3)matrix4x);
					((Matrix4x4*)(nint)matrix4x4)->m00 = 0f;
					((Matrix4x4*)(nint)matrix4x4)->m20 = 0f;
					float m5 = num36 + num184;
					((Matrix4x4*)(nint)matrix4x4)->m00 = m5;
					((Matrix4x4*)(nint)matrix4x4)->m10 = num85;
					((Matrix4x4*)(nint)matrix4x4)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x4.m00;
					((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x4.m20;
					((List<Vector3>)(object)t).Add((Vector3)matrix4x);
					obj2 = 0;
					_ = 0;
					float num185 = num36 - num184;
					obj2 = num185;
					_ = 0f;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
					Matrix4x4 matrix4x39 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					((Matrix4x4*)(nint)matrix4x39)->m20 = 0f;
					((List<Vector3>)(object)t).Add((Vector3)matrix4x);
					SpringPanel springPanel2 = springPanel;
				}
			}
			else
			{
				SpringPanel springPanel2 = null;
				while ((nint)springPanel2 <= 3)
				{
					nint num186 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2812 @ S0_v569 (Il2CppClass<NGUIText>)+BA]");
					object obj160 = (nint)0 & (nint)0x200;
					if (obj160 != null)
					{
						nint num187 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2953 @ S0_v646 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj161 = NGUIText.mBoldOffset + 16;
					object obj162 = (object)springPanel2 << 3;
					object obj163 = obj161 + obj162;
					object obj164 = (object)springPanel2 << 3;
					object obj165 = (object)NGUIText.mBoldOffset + obj164;
					object obj166 = obj165 + 20;
					float num188;
					if (flag21)
					{
						num188 = 0f;
					}
					else
					{
						nint num189 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3077 @ S0_v631 (Il2CppClass<NGUIText>)+BA]");
						object obj167 = (nint)0 & (nint)0x200;
						if (obj167 != null)
						{
							nint num190 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3174 @ S0_v640 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float num191 = (float)NGUIText.fontSize * 0.1f;
						float num192 = num85 - m2;
						int num193 = (int)(num192 / NGUIText.fontSize);
						num188 = num191 * (float)num193;
					}
					((Matrix4x4*)(nint)matrix4x2)->m00 = 0f;
					((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
					float num194 = num84 + (float)obj163;
					float m6 = num194 - num188;
					((Matrix4x4*)(nint)matrix4x2)->m00 = m6;
					float m7 = m2 + (float)obj166;
					((Matrix4x4*)(nint)matrix4x2)->m10 = m7;
					((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x2.m00;
					((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x2.m20;
					((List<Vector3>)(object)t).Add((Vector3)matrix4x);
					((Matrix4x4*)(nint)matrix4x3)->m00 = 0f;
					((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
					float num195 = num84 + (float)obj163;
					float m8 = num195 + num188;
					((Matrix4x4*)(nint)matrix4x3)->m00 = m8;
					float m9 = num85 + (float)obj166;
					((Matrix4x4*)(nint)matrix4x3)->m10 = m9;
					((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x3.m00;
					((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x3.m20;
					((List<Vector3>)(object)t).Add((Vector3)matrix4x);
					((Matrix4x4*)(nint)matrix4x4)->m00 = 0f;
					((Matrix4x4*)(nint)matrix4x4)->m20 = 0f;
					float num196 = num36 + (float)obj163;
					float m10 = num196 + num188;
					((Matrix4x4*)(nint)matrix4x4)->m00 = m10;
					float m11 = num85 + (float)obj166;
					((Matrix4x4*)(nint)matrix4x4)->m10 = m11;
					((Matrix4x4*)(nint)matrix4x4)->m20 = 0f;
					((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x4.m00;
					((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x4.m20;
					((List<Vector3>)(object)t).Add((Vector3)matrix4x);
					obj2 = 0;
					_ = 0;
					float num197 = num36 + (float)obj163;
					float num198 = num197 - num188;
					obj2 = num198;
					float num199 = m2 + (float)obj166;
					_ = 0f;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
					Matrix4x4 matrix4x40 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					((Matrix4x4*)(nint)matrix4x40)->m20 = 0f;
					((List<Vector3>)(object)t).Add((Vector3)matrix4x);
					SpringPanel springPanel3 = (SpringPanel)(springPanel2 + 1);
					springPanel2 = springPanel3;
				}
			}
			object obj168 = obj25 | obj24;
			object obj169 = obj168 & 0xFF;
			bool flag23 = obj169 == null;
			flag12 = flag22;
			flag5 = flag21;
			vector2 = (Vector3)gameObject;
			if (!flag23)
			{
				GameObject go = ((obj25 == null) ? ((GameObject)95) : ((GameObject)45));
				nint num200 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3192 @ S1_v173 (Il2CppClass<NGUIText>)+BA]");
				object obj170 = (nint)0 & (nint)0x200;
				if (obj170 != null)
				{
					nint num201 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3254 @ S1_v459 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				SpringPanel springPanel4 = SpringPanel.Begin(go, (Vector3)gameObject, num58);
				bool flag24 = (object)springPanel4 == null;
				flag12 = flag22;
				flag5 = flag21;
				vector2 = (Vector3)gameObject;
				if (!flag24)
				{
					if (flag4)
					{
						nint num202 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3392 @ S0_v481 (Il2CppClass<NGUIText>)+BA]");
						object obj171 = (nint)0 & (nint)0x200;
						if (obj171 != null)
						{
							nint num203 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3458 @ S0_v557 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						nint num204 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3468 @ S1_v388 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj172 = (nint)0 & (nint)0x200;
						if (obj172 != null)
						{
							nint num205 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3523 @ S1_v456 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (((ComputeShader)(object)NGUIText.bitmapFont).FindKernel((string)null) != 0)
						{
							object obj173 = springPanel4 + 24;
							object obj174 = springPanel4 + 24;
							object obj175 = num14 * obj174;
							object obj176 = obj20 + obj175;
							obj173 = obj176;
							object obj177 = springPanel4 + 40;
							object obj178 = springPanel4 + 40;
							object obj179 = num14 * obj178;
							object obj180 = obj20 + obj179;
							obj177 = obj180;
							object obj181 = springPanel4 + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v58+C]");
							nint num206 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v58+4]");
							object obj182 = num206 + 0;
							object obj183 = springPanel4 + 24;
							float num207 = num15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3675 @ S3_v104+4]");
							float num208 = num207 * 0f;
							float num209 = (float)obj182 - num208;
							object obj184 = springPanel4 + 40;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v58+C]");
							nint num210 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v58+4]");
							object obj185 = num210 + 0;
							object obj186 = springPanel4 + 40;
							float num211 = num15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3690 @ S3_v107+4]");
							float num212 = num211 * 0f;
							float num213 = (float)obj185 - num212;
						}
						object obj187 = springPanel4 + 24;
						object obj188 = springPanel4 + 40;
						object obj189 = obj187 + obj188;
						float num214 = (float)obj189 * 0.5f;
						object obj190 = ((!flag22) ? ((object)4) : ((object)1));
						object obj191 = 0;
						while (true)
						{
							bool flag25 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj191) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj190);
							num84 = num214;
							if (flag25)
							{
								break;
							}
							object obj192 = springPanel4 + 24;
							((Matrix4x4*)(nint)matrix4x2)->m00 = 0f;
							((Matrix4x4*)(nint)matrix4x2)->m00 = num214;
							Matrix4x4 matrix4x41 = matrix4x2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3975 @ S0_v502+4]");
							((Matrix4x4*)(nint)matrix4x41)->m10 = 0f;
							obj13 = matrix4x2.m00;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
							((List<Vector2>)considerInactive).Add((Vector2)matrix4x);
							object obj193 = springPanel4 + 40;
							((Matrix4x4*)(nint)matrix4x3)->m00 = 0f;
							((Matrix4x4*)(nint)matrix4x3)->m00 = num214;
							Matrix4x4 matrix4x42 = matrix4x3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4028 @ S0_v513+4]");
							((Matrix4x4*)(nint)matrix4x42)->m10 = 0f;
							obj14 = matrix4x3.m00;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj14;
							((List<Vector2>)considerInactive).Add((Vector2)matrix4x);
							object obj194 = springPanel4 + 40;
							((Matrix4x4*)(nint)matrix4x4)->m00 = 0f;
							((Matrix4x4*)(nint)matrix4x4)->m00 = num214;
							Matrix4x4 matrix4x43 = matrix4x4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4064 @ S0_v524+4]");
							((Matrix4x4*)(nint)matrix4x43)->m10 = 0f;
							obj15 = matrix4x4.m00;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj15;
							((List<Vector2>)considerInactive).Add((Vector2)matrix4x);
							object obj195 = springPanel4 + 24;
							obj2 = 0;
							obj2 = num214;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4091 @ S0_v535+4]");
							_ = 0;
							obj16 = obj2;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj16;
							((List<Vector2>)considerInactive).Add((Vector2)matrix4x);
							object obj196 = obj191 + 1;
							obj191 = obj196;
						}
					}
					float num215 = 0f - num25;
					object obj197 = springPanel4 + 8;
					float num216 = num215;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3423 @ S1_v180+4]");
					float num217 = num216 + 0f;
					object obj198 = springPanel4 + 16;
					float num218 = num215;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3429 @ S1_v183+4]");
					float num219 = num218 + 0f;
					if (flag22)
					{
						((Matrix4x4*)(nint)matrix4x2)->m00 = 0f;
						((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
						((Matrix4x4*)(nint)matrix4x2)->m00 = num130;
						((Matrix4x4*)(nint)matrix4x2)->m10 = num217;
						((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
						((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x2.m00;
						((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x2.m20;
						((List<Vector3>)(object)t).Add((Vector3)matrix4x);
						((Matrix4x4*)(nint)matrix4x3)->m00 = 0f;
						((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
						((Matrix4x4*)(nint)matrix4x3)->m00 = num130;
						((Matrix4x4*)(nint)matrix4x3)->m10 = num219;
						((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
						((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x3.m00;
						((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x3.m20;
						((List<Vector3>)(object)t).Add((Vector3)matrix4x);
						((Matrix4x4*)(nint)matrix4x4)->m00 = 0f;
						((Matrix4x4*)(nint)matrix4x4)->m20 = 0f;
						((Matrix4x4*)(nint)matrix4x4)->m00 = num21;
						((Matrix4x4*)(nint)matrix4x4)->m10 = num219;
						((Matrix4x4*)(nint)matrix4x4)->m20 = 0f;
						((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x4.m00;
						((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x4.m20;
						((List<Vector3>)(object)t).Add((Vector3)matrix4x);
						obj2 = 0;
						_ = 0;
						obj2 = num21;
						_ = 0f;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
						Matrix4x4 matrix4x44 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
						((Matrix4x4*)(nint)matrix4x44)->m20 = 0f;
						((List<Vector3>)(object)t).Add((Vector3)matrix4x);
						num36 = num215;
					}
					else
					{
						num36 = num215;
						object obj199 = 0;
						while ((nint)obj199 <= 3)
						{
							nint num220 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3617 @ S0_v376 (Il2CppClass<NGUIText>)+BA]");
							object obj200 = (nint)0 & (nint)0x200;
							if (obj200 != null)
							{
								nint num221 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3727 @ S0_v435 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							object obj201 = NGUIText.mBoldOffset + 16;
							object obj202 = obj199 << 3;
							object obj203 = obj201 + obj202;
							object obj204 = obj199 << 3;
							object obj205 = (object)NGUIText.mBoldOffset + obj204;
							object obj206 = obj205 + 20;
							((Matrix4x4*)(nint)matrix4x2)->m00 = 0f;
							((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
							float m12 = num130 + (float)obj203;
							((Matrix4x4*)(nint)matrix4x2)->m00 = m12;
							float m13 = num217 + (float)obj206;
							((Matrix4x4*)(nint)matrix4x2)->m10 = m13;
							((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
							((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x2.m00;
							((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x2.m20;
							((List<Vector3>)(object)t).Add((Vector3)matrix4x);
							((Matrix4x4*)(nint)matrix4x3)->m00 = 0f;
							((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
							float m14 = num130 + (float)obj203;
							((Matrix4x4*)(nint)matrix4x3)->m00 = m14;
							float m15 = num219 + (float)obj206;
							((Matrix4x4*)(nint)matrix4x3)->m10 = m15;
							((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
							((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x3.m00;
							((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x3.m20;
							((List<Vector3>)(object)t).Add((Vector3)matrix4x);
							((Matrix4x4*)(nint)matrix4x4)->m00 = 0f;
							((Matrix4x4*)(nint)matrix4x4)->m20 = 0f;
							float m16 = num21 + (float)obj203;
							((Matrix4x4*)(nint)matrix4x4)->m00 = m16;
							float m17 = num219 + (float)obj206;
							((Matrix4x4*)(nint)matrix4x4)->m10 = m17;
							((Matrix4x4*)(nint)matrix4x4)->m20 = 0f;
							((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x4.m00;
							((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x4.m20;
							((List<Vector3>)(object)t).Add((Vector3)matrix4x);
							obj2 = 0;
							_ = 0;
							float num222 = num21 + (float)obj203;
							obj2 = num222;
							float num223 = num217 + (float)obj206;
							_ = 0f;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
							Matrix4x4 matrix4x45 = matrix4x;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
							((Matrix4x4*)(nint)matrix4x45)->m20 = 0f;
							((List<Vector3>)(object)t).Add((Vector3)matrix4x);
							object obj207 = obj199 + 1;
							num84 = (float)obj203;
							num36 = (float)obj206;
							obj199 = obj207;
						}
					}
					nint num224 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3633 @ S0_v261 (Il2CppClass<NGUIText>)+BA]");
					object obj208 = (nint)0 & (nint)0x200;
					if (obj208 != null)
					{
						nint num225 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3780 @ S0_v366 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(NGUIText.gradient ? 1u : 0u) != 0)
					{
						object obj209 = ((!flag22) ? ((object)16) : ((object)4));
						flag5 = false;
						while ((flag5 ? 1 : 0) < (nint)obj209)
						{
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj19;
							Matrix4x4 matrix4x46 = matrix4x;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v55+8]");
							((Matrix4x4*)(nint)matrix4x46)->m20 = 0f;
							((List<Color>)considerChildren).Add((Color)matrix4x);
							bool flag26 = (byte)((flag5 ? 1u : 0u) + 1u) != 0;
							flag5 = flag26;
						}
						flag12 = flag22;
						m2 = num219;
						num85 = num217;
						vector2 = (Vector3)gameObject;
					}
					else
					{
						object obj210 = springPanel4 + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3826 @ S1_v188+4]");
						float num226 = 0f / num58;
						float num227 = num8 + num226;
						object obj211 = springPanel4 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3834 @ S1_v192+4]");
						float num228 = 0f / num58;
						float num229 = num8 + num228;
						float num230 = num229 / num8;
						((Matrix4x4*)(nint)matrix4x2)->m00 = (float)obj17;
						Matrix4x4 matrix4x47 = matrix4x2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49+8]");
						((Matrix4x4*)(nint)matrix4x47)->m20 = 0f;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj18;
						Matrix4x4 matrix4x48 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v52+8]");
						((Matrix4x4*)(nint)matrix4x48)->m20 = 0f;
						float value3 = num227 / num8;
						((Matrix4x4*)matrix4x3)->set_Item((int)matrix4x2, (int)matrix4x, value3);
						nint num231 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3894 @ S0_v280 (Il2CppClass<NGUIText>)+BA]");
						object obj212 = (nint)0 & (nint)0x200;
						bool flag27 = obj212 == null;
						nint num232 = (nint)typeof(NGUIText);
						if (!flag27)
						{
							nint num233 = (nint)typeof(NGUIText);
							num232 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3936 @ S0_v346 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								num232 = (nint)typeof(NGUIText);
							}
						}
						((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x3.m00;
						((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x3.m20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3938 @ L5_v33 (Il2CppClass<NGUIText>)+5C]");
						object obj213 = (nint)0 + (nint)224;
						obj213 = matrix4x.m00;
						_ = matrix4x.m20;
						((Matrix4x4*)(nint)matrix4x2)->m00 = (float)obj17;
						Matrix4x4 matrix4x49 = matrix4x2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49+8]");
						((Matrix4x4*)(nint)matrix4x49)->m20 = 0f;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj18;
						Matrix4x4 matrix4x50 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v52+8]");
						((Matrix4x4*)(nint)matrix4x50)->m20 = 0f;
						((Matrix4x4*)matrix4x4)->set_Item((int)matrix4x2, (int)matrix4x, num230);
						nint num234 = (nint)typeof(NGUIText);
						((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x4.m00;
						((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x4.m20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4008 @ S0_v294 (Il2CppClass<NGUIText>)+5C]");
						object obj214 = (nint)0 + (nint)240;
						obj214 = matrix4x.m00;
						_ = matrix4x.m20;
						object obj215 = ((!flag22) ? ((object)4) : ((object)1));
						flag5 = false;
						while ((flag5 ? 1 : 0) < (nint)obj215)
						{
							nint num235 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4121 @ S0_v305 (Il2CppClass<NGUIText>)+BA]");
							object obj216 = (nint)0 & (nint)0x200;
							bool flag28 = obj216 == null;
							nint num236 = (nint)typeof(NGUIText);
							if (!flag28)
							{
								nint num237 = (nint)typeof(NGUIText);
								num236 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4126 @ S0_v339 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									num236 = (nint)typeof(NGUIText);
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4128 @ L5_v36 (Il2CppClass<NGUIText>)+5C]");
							object obj217 = (nint)0 + (nint)224;
							((Matrix4x4*)(nint)matrix4x2)->m00 = (float)obj217;
							Matrix4x4 matrix4x51 = matrix4x2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4136 @ S1_v234+8]");
							((Matrix4x4*)(nint)matrix4x51)->m20 = 0f;
							((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x2.m00;
							((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x2.m20;
							((List<Color>)considerChildren).Add((Color)matrix4x);
							nint num238 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4157 @ S1_v244 (Il2CppClass<NGUIText>)+5C]");
							object obj218 = (nint)0 + (nint)240;
							((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj218;
							Matrix4x4 matrix4x52 = matrix4x3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4160 @ S1_v246+8]");
							((Matrix4x4*)(nint)matrix4x52)->m20 = 0f;
							((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x3.m00;
							((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x3.m20;
							((List<Color>)considerChildren).Add((Color)matrix4x);
							nint num239 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4181 @ S1_v256 (Il2CppClass<NGUIText>)+5C]");
							object obj219 = (nint)0 + (nint)240;
							((Matrix4x4*)(nint)matrix4x4)->m00 = (float)obj219;
							Matrix4x4 matrix4x53 = matrix4x4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4184 @ S1_v258+8]");
							((Matrix4x4*)(nint)matrix4x53)->m20 = 0f;
							((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x4.m00;
							((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x4.m20;
							((List<Color>)considerChildren).Add((Color)matrix4x);
							nint num240 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4204 @ S1_v268 (Il2CppClass<NGUIText>)+5C]");
							object obj220 = (nint)0 + (nint)224;
							obj2 = obj220;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4207 @ S1_v270+8]");
							_ = 0;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
							Matrix4x4 matrix4x54 = matrix4x;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
							((Matrix4x4*)(nint)matrix4x54)->m20 = 0f;
							((List<Color>)considerChildren).Add((Color)matrix4x);
							bool flag29 = (byte)((flag5 ? 1u : 0u) + 1u) != 0;
							flag5 = flag29;
						}
						flag12 = flag22;
						num84 = num227;
						m2 = num219;
						num85 = num217;
						num36 = num230;
						vector2 = (Vector3)gameObject;
					}
				}
			}
			goto IL_393c;
		}
	}

	public static void FitOnScreen(Camera cam, Transform transform, Vector3 pos)
	{
		//IL_01a4: Expected I, but got Obj
		//IL_01ba: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I4
		//IL_0157: Expected I, but got Obj
		//IL_01e5: Expected I4, but got VT
		//IL_01e5: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I4
		//IL_00e1: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)cam))
		{
			return;
		}
		int layer = ((GameObject)(object)cam).layer;
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v16 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		if ((object)transform != null)
		{
			if (!flag)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v35 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SetActive((GameObject)layer, (byte)(int)pos != 0);
			int layer2 = ((GameObject)(object)cam).layer;
			MakePixelPerfect((Transform)layer2);
			return;
		}
		if (!flag)
		{
			nint num5 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v25 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CallCreatePanel((Transform)layer);
	}

	public unsafe static void FitOnScreen(Camera cam, Transform transform, Transform content, Vector3 pos, bool considerInactive = false)
	{
		//IL_1c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8f: Expected Obj, but got Unknown
		//IL_1c98: Expected Obj, but got I4
		//IL_1ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca6: Expected Obj, but got Unknown
		//IL_1caf: Expected Obj, but got I4
		//IL_1cb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cbd: Expected Obj, but got Unknown
		//IL_1cc6: Expected Obj, but got I4
		//IL_1ccf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd4: Expected Obj, but got Unknown
		//IL_1cdd: Expected Obj, but got I4
		//IL_1ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ceb: Expected Obj, but got Unknown
		//IL_1cf4: Expected Obj, but got I4
		//IL_1cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d02: Expected Obj, but got Unknown
		//IL_1d0b: Expected Obj, but got I4
		//IL_1d14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d19: Expected Obj, but got Unknown
		//IL_1d22: Expected Obj, but got I4
		//IL_1d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d30: Expected Obj, but got Unknown
		//IL_1d39: Expected Obj, but got I4
		//IL_1d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d47: Expected Obj, but got Unknown
		//IL_1d50: Expected Obj, but got I4
		//IL_1d7b: Expected I, but got Obj
		//IL_1d91: Expected Obj, but got I
		//IL_003a: Expected I, but got Obj
		//IL_1dc5: Expected I, but got Obj
		//IL_1ddb: Expected Obj, but got I
		//IL_1e12: Invalid comparison between VT and I4
		//IL_00a2: Expected I, but got Obj
		//IL_1e5a: Expected Obj, but got I4
		//IL_1e63: Expected Obj, but got I4
		//IL_1e6c: Expected Obj, but got I4
		//IL_1e75: Expected Obj, but got I4
		//IL_1e7e: Expected Obj, but got I4
		//IL_1e87: Expected Obj, but got I4
		//IL_1e90: Expected Obj, but got I4
		//IL_1e9e: Expected I, but got Obj
		//IL_1eb4: Expected Obj, but got I
		//IL_26c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_26cb: Expected VT, but got Unknown
		//IL_26d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d9: Expected Obj, but got Unknown
		//IL_26e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e7: Expected Obj, but got Unknown
		//IL_26f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f5: Expected Obj, but got Unknown
		//IL_26fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2703: Expected Obj, but got Unknown
		//IL_270c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2711: Expected Obj, but got Unknown
		//IL_271a: Unknown result type (might be due to invalid IL or missing references)
		//IL_271f: Expected Obj, but got Unknown
		//IL_2728: Unknown result type (might be due to invalid IL or missing references)
		//IL_272d: Expected Obj, but got Unknown
		//IL_2736: Unknown result type (might be due to invalid IL or missing references)
		//IL_273b: Expected Obj, but got Unknown
		//IL_2744: Unknown result type (might be due to invalid IL or missing references)
		//IL_2749: Expected Obj, but got Unknown
		//IL_2752: Unknown result type (might be due to invalid IL or missing references)
		//IL_2757: Expected Obj, but got Unknown
		//IL_2760: Unknown result type (might be due to invalid IL or missing references)
		//IL_2765: Expected Obj, but got Unknown
		//IL_0135: Expected I, but got Obj
		//IL_1f00: Expected Obj, but got F4
		//IL_1f22: Expected Obj, but got I4
		//IL_1f2b: Expected Obj, but got I4
		//IL_1563: Invalid comparison between VT and I4
		//IL_01b6: Expected I, but got Obj
		//IL_01cc: Expected Obj, but got I
		//IL_2917: Expected I, but got Obj
		//IL_292d: Expected Obj, but got I
		//IL_1762: Expected I, but got Obj
		//IL_1778: Expected Obj, but got I
		//IL_1c42: Expected I, but got Obj
		//IL_1978: Expected Obj, but got I4
		//IL_15a8: Expected Obj, but got I4
		//IL_15c6: Expected Obj, but got F4
		//IL_15cf: Expected Obj, but got F4
		//IL_15f6: Expected F4, but got Obj
		//IL_15f1: Expected native int or pointer, but got VT
		//IL_160b: Expected F4, but got I
		//IL_1606: Expected native int or pointer, but got VT
		//IL_1618: Expected Obj, but got VT
		//IL_1621: Expected Obj, but got I4
		//IL_163f: Expected Obj, but got F4
		//IL_1657: Expected F4, but got Obj
		//IL_1652: Expected native int or pointer, but got VT
		//IL_166c: Expected F4, but got I
		//IL_1667: Expected native int or pointer, but got VT
		//IL_1679: Expected Obj, but got VT
		//IL_2795: Invalid comparison between VT and I4
		//IL_27a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_27a8: Expected Obj, but got Unknown
		//IL_27be: Unknown result type (might be due to invalid IL or missing references)
		//IL_27c3: Expected Obj, but got Unknown
		//IL_029b: Expected I, but got Obj
		//IL_2632: Expected I, but got Obj
		//IL_2648: Expected Obj, but got I
		//IL_189b: Expected I, but got Obj
		//IL_18b1: Expected Obj, but got I
		//IL_17a3: Expected I, but got Obj
		//IL_1687: Expected Obj, but got I4
		//IL_16a5: Expected Obj, but got F4
		//IL_16bd: Expected F4, but got Obj
		//IL_16b8: Expected native int or pointer, but got VT
		//IL_16d2: Expected F4, but got I
		//IL_16cd: Expected native int or pointer, but got VT
		//IL_16df: Expected Obj, but got VT
		//IL_16e8: Expected Obj, but got I4
		//IL_1706: Expected Obj, but got F4
		//IL_172d: Expected F4, but got Obj
		//IL_1728: Expected native int or pointer, but got VT
		//IL_1742: Expected F4, but got I
		//IL_173d: Expected native int or pointer, but got VT
		//IL_174f: Expected Obj, but got VT
		//IL_2983: Expected Obj, but got Ref
		//IL_2990: Unknown result type (might be due to invalid IL or missing references)
		//IL_2995: Expected Obj, but got Unknown
		//IL_299e: Unknown result type (might be due to invalid IL or missing references)
		//IL_29a3: Expected Obj, but got Unknown
		//IL_022a: Expected I, but got Obj
		//IL_199e: Expected Obj, but got I4
		//IL_19ac: Expected Obj, but got F4
		//IL_19b5: Expected Obj, but got F4
		//IL_19dc: Expected F4, but got Obj
		//IL_19d7: Expected native int or pointer, but got VT
		//IL_19f1: Expected F4, but got I
		//IL_19ec: Expected native int or pointer, but got VT
		//IL_19fe: Expected Obj, but got I4
		//IL_1a07: Expected Obj, but got I4
		//IL_1a15: Expected Obj, but got F4
		//IL_1a2d: Expected F4, but got Obj
		//IL_1a28: Expected native int or pointer, but got VT
		//IL_1a42: Expected F4, but got I
		//IL_1a3d: Expected native int or pointer, but got VT
		//IL_1a4f: Expected Obj, but got I4
		//IL_25c1: Expected F4, but got Obj
		//IL_25bc: Expected native int or pointer, but got VT
		//IL_25db: Expected F4, but got Obj
		//IL_25d6: Expected native int or pointer, but got VT
		//IL_25f0: Expected F4, but got I
		//IL_25eb: Expected native int or pointer, but got VT
		//IL_25fd: Expected Obj, but got I4
		//IL_2612: Expected F4, but got Obj
		//IL_260d: Expected native int or pointer, but got VT
		//IL_17f0: Expected I, but got Obj
		//IL_1806: Expected Obj, but got I
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Expected Obj, but got Unknown
		//IL_02e3: Expected Obj, but got I4
		//IL_0301: Expected Obj, but got F4
		//IL_0331: Expected F4, but got Obj
		//IL_032c: Expected native int or pointer, but got VT
		//IL_0346: Expected F4, but got I
		//IL_0341: Expected native int or pointer, but got VT
		//IL_0353: Expected Obj, but got VT
		//IL_035c: Expected Obj, but got I4
		//IL_037a: Expected Obj, but got F4
		//IL_0392: Expected F4, but got Obj
		//IL_038d: Expected native int or pointer, but got VT
		//IL_03a7: Expected F4, but got I
		//IL_03a2: Expected native int or pointer, but got VT
		//IL_03b4: Expected Obj, but got VT
		//IL_1b38: Expected I, but got Obj
		//IL_1a5d: Expected Obj, but got I4
		//IL_1a7b: Expected Obj, but got F4
		//IL_1a93: Expected F4, but got Obj
		//IL_1a8e: Expected native int or pointer, but got VT
		//IL_1aa8: Expected F4, but got I
		//IL_1aa3: Expected native int or pointer, but got VT
		//IL_1ab5: Expected Obj, but got I4
		//IL_1abe: Expected Obj, but got I4
		//IL_1adc: Expected Obj, but got F4
		//IL_1b03: Expected F4, but got Obj
		//IL_1afe: Expected native int or pointer, but got VT
		//IL_1b18: Expected F4, but got I
		//IL_1b13: Expected native int or pointer, but got VT
		//IL_1b25: Expected Obj, but got I4
		//IL_1928: Expected F4, but got Obj
		//IL_1923: Expected native int or pointer, but got VT
		//IL_193d: Expected F4, but got I
		//IL_1938: Expected native int or pointer, but got VT
		//IL_194a: Expected Obj, but got I4
		//IL_18dc: Expected I, but got Obj
		//IL_25a7: Expected Obj, but got VT
		//IL_04b6: Invalid comparison between VT and I4
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected Obj, but got Unknown
		//IL_03c2: Expected Obj, but got I4
		//IL_03e0: Expected Obj, but got F4
		//IL_03f8: Expected F4, but got Obj
		//IL_03f3: Expected native int or pointer, but got VT
		//IL_040d: Expected F4, but got I
		//IL_0408: Expected native int or pointer, but got VT
		//IL_041a: Expected Obj, but got VT
		//IL_0423: Expected Obj, but got I4
		//IL_0441: Expected Obj, but got F4
		//IL_0468: Expected F4, but got Obj
		//IL_0463: Expected native int or pointer, but got VT
		//IL_047d: Expected F4, but got I
		//IL_0478: Expected native int or pointer, but got VT
		//IL_048a: Expected Obj, but got VT
		//IL_1831: Expected I, but got Obj
		//IL_2156: Unknown result type (might be due to invalid IL or missing references)
		//IL_215b: Expected Obj, but got Unknown
		//IL_0a66: Expected I, but got Obj
		//IL_0a7c: Expected Obj, but got I
		//IL_04a8: Expected Obj, but got I4
		//IL_04f7: Expected I, but got Obj
		//IL_050d: Expected Obj, but got I
		//IL_1bb4: Expected I, but got Obj
		//IL_1bca: Expected Obj, but got I
		//IL_286e: Expected I, but got Obj
		//IL_2884: Expected Obj, but got I
		//IL_0aa7: Expected I, but got Obj
		//IL_282d: Expected I, but got Obj
		//IL_2843: Expected Obj, but got I
		//IL_268b: Expected Obj, but got I4
		//IL_0af4: Expected I, but got Obj
		//IL_0b0a: Expected Obj, but got I
		//IL_071e: Expected Obj, but got I4
		//IL_060e: Expected VT, but got I4
		//IL_0538: Expected I, but got Obj
		//IL_1bf5: Expected I, but got Obj
		//IL_0c84: Expected I, but got Obj
		//IL_0c9a: Expected Obj, but got I
		//IL_0ba6: Expected I, but got Obj
		//IL_09e3: Expected I, but got Obj
		//IL_2058: Expected I, but got Obj
		//IL_206e: Expected Obj, but got I
		//IL_063e: Expected I, but got Obj
		//IL_0654: Expected Obj, but got I
		//IL_0585: Expected I, but got Obj
		//IL_059b: Expected Obj, but got I
		//IL_0bf3: Expected I, but got Obj
		//IL_0c09: Expected Obj, but got I
		//IL_0b35: Expected I, but got Obj
		//IL_0744: Expected Obj, but got I4
		//IL_0752: Expected Obj, but got F4
		//IL_0782: Expected F4, but got Obj
		//IL_077d: Expected native int or pointer, but got VT
		//IL_0797: Expected F4, but got I
		//IL_0792: Expected native int or pointer, but got VT
		//IL_07a4: Expected Obj, but got I4
		//IL_07ad: Expected Obj, but got I4
		//IL_07bb: Expected Obj, but got F4
		//IL_07d3: Expected F4, but got Obj
		//IL_07ce: Expected native int or pointer, but got VT
		//IL_07e8: Expected F4, but got I
		//IL_07e3: Expected native int or pointer, but got VT
		//IL_07f5: Expected Obj, but got I4
		//IL_1fe7: Expected F4, but got Obj
		//IL_1fe2: Expected native int or pointer, but got VT
		//IL_2001: Expected F4, but got Obj
		//IL_1ffc: Expected native int or pointer, but got VT
		//IL_2016: Expected F4, but got I
		//IL_2011: Expected native int or pointer, but got VT
		//IL_2023: Expected Obj, but got I4
		//IL_2038: Expected F4, but got Obj
		//IL_2033: Expected native int or pointer, but got VT
		//IL_1fcc: Expected Obj, but got VT
		//IL_0cc5: Expected I, but got Obj
		//IL_21a9: Expected VT, but got I
		//IL_21a9: Expected Obj, but got Ref
		//IL_0b7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b82: Expected Obj, but got Unknown
		//IL_29d4: Expected Obj, but got I4
		//IL_08e6: Expected I, but got Obj
		//IL_0803: Expected Obj, but got I4
		//IL_0821: Expected Obj, but got F4
		//IL_0839: Expected F4, but got Obj
		//IL_0834: Expected native int or pointer, but got VT
		//IL_084e: Expected F4, but got I
		//IL_0849: Expected native int or pointer, but got VT
		//IL_085b: Expected Obj, but got I4
		//IL_0864: Expected Obj, but got I4
		//IL_0882: Expected Obj, but got F4
		//IL_08a9: Expected F4, but got Obj
		//IL_08a4: Expected native int or pointer, but got VT
		//IL_08be: Expected F4, but got I
		//IL_08b9: Expected native int or pointer, but got VT
		//IL_08cb: Expected Obj, but got I4
		//IL_06cb: Expected F4, but got Obj
		//IL_06c6: Expected native int or pointer, but got VT
		//IL_06e0: Expected F4, but got I
		//IL_06db: Expected native int or pointer, but got VT
		//IL_06ed: Expected Obj, but got I4
		//IL_067f: Expected I, but got Obj
		//IL_05c6: Expected I, but got Obj
		//IL_0d54: Expected I, but got Obj
		//IL_0d6a: Expected Obj, but got I
		//IL_0c34: Expected I, but got Obj
		//IL_2203: Invalid comparison between F4 and I4
		//IL_0d95: Expected I, but got Obj
		//IL_0962: Expected I, but got Obj
		//IL_0978: Expected Obj, but got I
		//IL_28d6: Expected I, but got Obj
		//IL_28ec: Expected Obj, but got I
		//IL_20b1: Expected Obj, but got I4
		//IL_09a3: Expected I, but got Obj
		//IL_249c: Expected Obj, but got F4
		//IL_24a9: Expected Obj, but got F4
		//IL_1316: Expected I, but got Obj
		//IL_0de0: Invalid comparison between VT and I4
		//IL_0df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df6: Expected Obj, but got Unknown
		//IL_1367: Expected Obj, but got I4
		//IL_0e21: Expected I, but got Obj
		//IL_0e37: Expected Obj, but got I
		//IL_14a8: Expected I, but got Obj
		//IL_14be: Expected Obj, but got I
		//IL_2376: Expected I, but got Obj
		//IL_238c: Expected Obj, but got I
		//IL_24d8: Expected F4, but got Obj
		//IL_24d3: Expected native int or pointer, but got VT
		//IL_24f2: Expected F4, but got Obj
		//IL_24ed: Expected native int or pointer, but got VT
		//IL_2507: Expected F4, but got I
		//IL_2502: Expected native int or pointer, but got VT
		//IL_2514: Expected Obj, but got I4
		//IL_2529: Expected F4, but got Obj
		//IL_2524: Expected native int or pointer, but got VT
		//IL_1495: Expected Obj, but got I4
		//IL_13b8: Expected Obj, but got I4
		//IL_13c6: Expected Obj, but got F4
		//IL_13de: Expected F4, but got Obj
		//IL_13d9: Expected native int or pointer, but got VT
		//IL_13f3: Expected F4, but got I
		//IL_13ee: Expected native int or pointer, but got VT
		//IL_1400: Expected Obj, but got I4
		//IL_1409: Expected Obj, but got I4
		//IL_1417: Expected Obj, but got F4
		//IL_142f: Expected F4, but got Obj
		//IL_142a: Expected native int or pointer, but got VT
		//IL_1444: Expected F4, but got I
		//IL_143f: Expected native int or pointer, but got VT
		//IL_1451: Expected Obj, but got I4
		//IL_0fee: Expected Obj, but got I4
		//IL_0ea3: Expected I, but got Obj
		//IL_0eb9: Expected Obj, but got I
		//IL_0e62: Expected I, but got Obj
		//IL_151b: Expected F4, but got Obj
		//IL_1516: Expected native int or pointer, but got VT
		//IL_1530: Expected F4, but got I
		//IL_152b: Expected native int or pointer, but got VT
		//IL_153d: Expected Obj, but got I4
		//IL_1546: Expected Obj, but got I4
		//IL_14e9: Expected I, but got Obj
		//IL_145f: Expected Obj, but got I4
		//IL_13aa: Expected Obj, but got I4
		//IL_12be: Expected I, but got Obj
		//IL_1199: Expected I, but got Obj
		//IL_11af: Expected Obj, but got I
		//IL_0f34: Expected I, but got Obj
		//IL_0f4a: Expected Obj, but got I
		//IL_228a: Expected Obj, but got VT
		//IL_2294: Expected VT, but got I4
		//IL_0e90: Expected VT, but got I4
		//IL_233c: Expected Obj, but got I4
		//IL_1014: Expected Obj, but got I4
		//IL_1022: Expected Obj, but got F4
		//IL_1049: Expected F4, but got Obj
		//IL_1044: Expected native int or pointer, but got VT
		//IL_105e: Expected F4, but got I
		//IL_1059: Expected native int or pointer, but got VT
		//IL_106b: Expected Obj, but got I4
		//IL_1074: Expected Obj, but got I4
		//IL_1082: Expected Obj, but got F4
		//IL_109a: Expected F4, but got Obj
		//IL_1095: Expected native int or pointer, but got VT
		//IL_10af: Expected F4, but got I
		//IL_10aa: Expected native int or pointer, but got VT
		//IL_10bc: Expected Obj, but got I4
		//IL_22ae: Expected F4, but got Obj
		//IL_22a9: Expected native int or pointer, but got VT
		//IL_22c8: Expected F4, but got Obj
		//IL_22c3: Expected native int or pointer, but got VT
		//IL_22dd: Expected F4, but got I
		//IL_22d8: Expected native int or pointer, but got VT
		//IL_22ea: Expected Obj, but got I4
		//IL_22ff: Expected F4, but got Obj
		//IL_22fa: Expected native int or pointer, but got VT
		//IL_0ee4: Expected I, but got Obj
		//IL_11da: Expected I, but got Obj
		//IL_10ca: Expected Obj, but got I4
		//IL_10e8: Expected Obj, but got F4
		//IL_1100: Expected F4, but got Obj
		//IL_10fb: Expected native int or pointer, but got VT
		//IL_1115: Expected F4, but got I
		//IL_1110: Expected native int or pointer, but got VT
		//IL_1122: Expected Obj, but got I4
		//IL_112b: Expected Obj, but got I4
		//IL_1149: Expected Obj, but got F4
		//IL_1170: Expected F4, but got Obj
		//IL_116b: Expected native int or pointer, but got VT
		//IL_1185: Expected F4, but got I
		//IL_1180: Expected native int or pointer, but got VT
		//IL_0fa7: Expected F4, but got Obj
		//IL_0fa2: Expected native int or pointer, but got VT
		//IL_0fbc: Expected F4, but got I
		//IL_0fb7: Expected native int or pointer, but got VT
		//IL_0f75: Expected I, but got Obj
		//IL_1221: Expected Obj, but got I4
		//IL_231e: Expected Obj, but got I4
		//IL_123d: Expected I, but got Obj
		//IL_1253: Expected Obj, but got I
		//IL_23cf: Expected Obj, but got I4
		//IL_23e9: Expected Obj, but got I4
		//IL_127e: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 148;
		obj = 0;
		object obj3 = obj2 + 144;
		obj3 = 0;
		object obj4 = obj2 + 156;
		obj4 = 0;
		object obj5 = obj2 + 155;
		obj5 = 0;
		object obj6 = obj2 + 154;
		obj6 = 0;
		object obj7 = obj2 + 153;
		obj7 = 0;
		object obj8 = obj2 + 152;
		obj8 = 0;
		object obj9 = obj2 + 24;
		obj9 = 0;
		object obj10 = obj2 + 16;
		obj10 = 0;
		bool flag = (object)cam == null || ((UnityEngine.Object)cam).m_CachedPtr == (IntPtr)0;
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v24 (Il2CppClass<NGUIText>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v549 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref StringBuilder reference = ref !flag ? ref *(StringBuilder*)cam : ref *(StringBuilder*)" ";
		NGUIText.EndLine(ref reference);
		nint num3 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v30 (Il2CppClass<NGUIText>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num4 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v857 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num5 = (float)NGUIText.fontSize * NGUIText.fontScale;
		Vector3 vector = default;
		int index;
		if (vector != (Vector3)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1629 @ L3_v5 (UnityEngine.Vector3)+C]");
			index = 0;
		}
		else
		{
			index = 0;
		}
		bool flag2 = considerInactive;
		int num6;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [considerInactive @ L4 (System.Boolean)+C]");
			num6 = 0;
		}
		else
		{
			num6 = 0;
		}
		obj = 0;
		obj3 = 0;
		obj4 = 0;
		obj5 = 0;
		obj6 = 0;
		obj7 = 0;
		obj8 = 0;
		nint num7 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v53 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num8 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v843 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector4 vector2 = (Vector4)(obj2 + 96);
		object obj14 = obj2 + 132;
		object obj15 = obj2 + 120;
		object obj16 = obj2 + 108;
		object obj17 = obj2 + 88;
		object obj18 = obj2 + 80;
		object obj19 = obj2 + 72;
		object obj20 = obj2 - -64;
		object obj21 = obj2 + 56;
		object obj22 = obj2 + 48;
		object obj23 = obj2 + 40;
		object obj24 = obj2 + 32;
		bool flag3 = System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform) > System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref content);
		Transform transform2 = ((!flag3) ? content : transform);
		Transform transform3 = ((!flag3) ? transform : content);
		Vector2 one = Vector2.one;
		obj9 = vector2.x;
		Vector2 one2 = Vector2.one;
		obj10 = obj2;
		object obj25 = obj;
		object obj26 = 0;
		object obj27 = 0;
		int num9 = num6;
		string text = null;
		float num15 = default;
		float num17 = default;
		object obj45 = default;
		while (true)
		{
			object obj28 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v28 (System.Text.StringBuilder&)+8]");
			if ((nint)obj28 >= 0)
			{
				break;
			}
			nint num10 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v294 (Il2CppClass<NGUIText>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			bool flag4 = obj29 == null;
			float num12;
			if (obj3 != null)
			{
				if (!flag4)
				{
					nint num11 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v833 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				num12 = NGUIText.fontScale * 0.75f;
			}
			else
			{
				if (!flag4)
				{
					nint num13 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S0_v820 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				num12 = NGUIText.fontScale;
			}
			bool flag5 = vector == (Vector3)(object)0;
			object obj30 = obj27 | flag5;
			bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref content);
			object obj31 = obj30 | flag6;
			bool flag7 = obj31 == null;
			bool flag8 = !flag7;
			char[] separator = (char[])obj;
			float num23;
			if (!flag8)
			{
				obj2 = 0;
				_ = 0;
				float num14 = num15 - 1f;
				obj2 = num14;
				float num16 = 0f - num17;
				float num18 = num16 - num5;
				_ = 0f;
				((Vector4*)(nint)vector2)->x = (float)obj2;
				Vector4 vector3 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Vector4*)(nint)vector3)->z = 0f;
				((List<Vector3>)vector).Add(vector2);
				obj14 = 0;
				_ = 0;
				float num19 = num15 - 1f;
				obj14 = num19;
				_ = 0f;
				((Vector4*)(nint)vector2)->x = (float)obj14;
				Vector4 vector4 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v60+8]");
				((Vector4*)(nint)vector4)->z = 0f;
				((List<Vector3>)vector).Add(vector2);
				obj15 = 0;
				_ = 0;
				float num20 = num15 + 1f;
				obj15 = num20;
				_ = 0f;
				((Vector4*)(nint)vector2)->x = (float)obj15;
				Vector4 vector5 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v62+8]");
				((Vector4*)(nint)vector5)->z = 0f;
				((List<Vector3>)vector).Add(vector2);
				obj16 = 0;
				_ = 0;
				float num21 = num15 + 1f;
				obj16 = num21;
				float num22 = num16 - num5;
				_ = 0f;
				((Vector4*)(nint)vector2)->x = (float)obj16;
				Vector4 vector6 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v64+8]");
				((Vector4*)(nint)vector6)->z = 0f;
				((List<Vector3>)vector).Add(vector2);
				num23 = num16;
				separator = (char[])obj;
				obj27 = 1;
			}
			string[] array = ((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).Split(separator);
			JsonDict jsonDict = (JsonDict)(array & 0xFFFF);
			object obj32 = array & 0xFFFF;
			string text2;
			if ((nint)obj32 == 10)
			{
				bool flag9 = vector != (Vector3)(object)0;
				object obj33 = flag9 & obj27;
				if (obj33 != null)
				{
					nint num24 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ S0_v743 (Il2CppClass<NGUIText>)+BA]");
					object obj34 = (nint)0 & (nint)0x200;
					if (obj34 != null)
					{
						nint num25 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ S0_v765 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (NGUIText.alignment != NGUIText.Alignment.Left)
					{
						nint num26 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1143 @ S0_v754 (Il2CppClass<NGUIText>)+BA]");
						object obj35 = (nint)0 & (nint)0x200;
						if (obj35 != null)
						{
							nint num27 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1226 @ S0_v759 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float completedFactor = num15 - NGUIText.finalSpacingX;
						((MissionsManager)vector).Complete(index, completedFactor, true);
					}
					vector = (Vector3)0;
				}
				object obj40;
				if (flag2)
				{
					if (obj26 != null)
					{
						nint num28 = (nint)typeof(Vector2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ S0_v718 (Il2CppClass<UnityEngine.Vector2>)+BA]");
						object obj36 = (nint)0 & (nint)0x200;
						if (obj36 != null)
						{
							nint num29 = (nint)typeof(Vector2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1237 @ S0_v738 (Il2CppClass<UnityEngine.Vector2>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj17 = obj10;
						((Vector4*)(nint)vector2)->x = (float)obj17;
						Vector3 vector7 = vector2;
						((Vector4*)(nint)vector2)->x = (float)obj2;
						Vector4 vector8 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Vector4*)(nint)vector8)->z = 0f;
						((List<Vector3>)considerInactive).Add(vector2);
						obj18 = obj9;
						((Vector4*)(nint)vector2)->x = (float)obj18;
						Vector3 vector9 = vector2;
						((Vector4*)(nint)vector2)->x = (float)obj14;
						Vector4 vector10 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v60+8]");
						((Vector4*)(nint)vector10)->z = 0f;
						((List<Vector3>)considerInactive).Add(vector2);
					}
					else
					{
						bool flag10 = System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform3) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
						bool flag11 = System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
						object obj37 = flag10 & flag11;
						if (obj37 != null)
						{
							obj2 = 0;
							_ = 0;
							obj2 = num15;
							float num30 = 0f - num17;
							float num31 = num30 - num5;
							_ = 0f;
							((Vector4*)(nint)vector2)->x = (float)obj2;
							Vector4 vector11 = vector2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							((Vector4*)(nint)vector11)->z = 0f;
							((List<Vector3>)considerInactive).Add(vector2);
							obj14 = 0;
							_ = 0;
							obj14 = num15;
							_ = 0f;
							((Vector4*)(nint)vector2)->x = (float)obj14;
							Vector4 vector12 = vector2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v60+8]");
							((Vector4*)(nint)vector12)->z = 0f;
							((List<Vector3>)considerInactive).Add(vector2);
							obj15 = 0;
							_ = 0;
							float num32 = num15 + 2f;
							obj15 = num32;
							_ = 0f;
							((Vector4*)(nint)vector2)->x = (float)obj15;
							Vector4 vector13 = vector2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v62+8]");
							((Vector4*)(nint)vector13)->z = 0f;
							((List<Vector3>)considerInactive).Add(vector2);
							obj16 = 0;
							_ = 0;
							float num33 = num15 + 2f;
							obj16 = num33;
							float num34 = num30 - num5;
							_ = 0f;
							((Vector4*)(nint)vector2)->x = (float)obj16;
							Vector4 vector14 = vector2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v64+8]");
							((Vector4*)(nint)vector14)->z = 0f;
							((List<Vector3>)considerInactive).Add(vector2);
							num23 = num30;
						}
					}
					nint num35 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1294 @ S0_v637 (Il2CppClass<NGUIText>)+BA]");
					object obj38 = (nint)0 & (nint)0x200;
					if (obj38 != null)
					{
						nint num36 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1378 @ S0_v666 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (NGUIText.alignment != NGUIText.Alignment.Left)
					{
						int num37 = num9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [considerInactive @ L4 (System.Boolean)+C]");
						if ((nint)num37 < (nint)0)
						{
							nint num38 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1529 @ S0_v652 (Il2CppClass<NGUIText>)+BA]");
							object obj39 = (nint)0 & (nint)0x200;
							if (obj39 != null)
							{
								nint num39 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1543 @ S0_v661 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							float completedFactor2 = num15 - NGUIText.finalSpacingX;
							((MissionsManager)considerInactive).Complete(num9, completedFactor2, true);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [considerInactive @ L4 (System.Boolean)+C]");
							num9 = 0;
						}
					}
					obj40 = 0;
				}
				else
				{
					obj40 = obj26;
				}
				nint num40 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1194 @ S1_v406 (Il2CppClass<NGUIText>)+BA]");
				object obj41 = (nint)0 & (nint)0x200;
				if (obj41 != null)
				{
					nint num41 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1300 @ S1_v413 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num42 = num17 + NGUIText.finalLineHeight;
				num15 = 0f;
				num17 = num42;
				obj26 = obj40;
				text2 = null;
				goto IL_214d;
			}
			object obj42 = array & 0xFFFF;
			float num51;
			if ((nint)obj42 > 31)
			{
				nint num43 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ S0_v318 (Il2CppClass<NGUIText>)+BA]");
				object obj43 = (nint)0 & (nint)0x200;
				if (obj43 != null)
				{
					nint num44 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ S0_v620 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (~(NGUIText.encoding ? 1u : 0u) == 0)
				{
					nint num45 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1202 @ S0_v606 (Il2CppClass<NGUIText>)+BA]");
					object obj44 = (nint)0 & (nint)0x200;
					if (obj44 != null)
					{
						nint num46 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1313 @ S0_v614 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool premultiply = NGUIText.premultiply;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B752");
					if (obj45 != null)
					{
						object obj46 = obj - 1;
						obj = obj46;
						text2 = text;
						goto IL_214d;
					}
				}
				nint num47 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1218 @ S0_v327 (Il2CppClass<NGUIText>)+BA]");
				object obj47 = (nint)0 & (nint)0x200;
				if (obj47 != null)
				{
					nint num48 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ S0_v599 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (~(NGUIText.useSymbols ? 1u : 0u) == 0)
				{
					nint num49 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1400 @ S0_v586 (Il2CppClass<NGUIText>)+BA]");
					object obj48 = (nint)0 & (nint)0x200;
					if (obj48 != null)
					{
						nint num50 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1482 @ S0_v596 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object indices = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v28 (System.Text.StringBuilder&)+8]");
					if (NGUIText.GetExactCharacterIndex((List<Vector3>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), (List<int>)indices, (Vector2)0) != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ S0_v591 (System.Int32)+2C]");
						num51 = 0f * num12;
						goto IL_0cea;
					}
				}
				nint num52 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1419 @ S0_v574 (Il2CppClass<NGUIText>)+BA]");
				object obj49 = (nint)0 & (nint)0x200;
				if (obj49 != null)
				{
					nint num53 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1488 @ S0_v580 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				num51 = jsonDict.GetFloat(text, num12);
				goto IL_0cea;
			}
			text2 = null;
			goto IL_214d;
			IL_118b:
			nint num54 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1871 @ S0_v442 (Il2CppClass<NGUIText>)+BA]");
			object obj50 = (nint)0 & (nint)0x200;
			if (obj50 != null)
			{
				nint num55 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1963 @ S0_v466 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag12 = NGUIText.alignment == NGUIText.Alignment.Left;
			object obj51 = 0;
			if (!flag12)
			{
				int num56 = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [considerInactive @ L4 (System.Boolean)+C]");
				bool flag13 = (nint)num56 >= (nint)0;
				obj51 = 0;
				if (!flag13)
				{
					nint num57 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2092 @ S0_v451 (Il2CppClass<NGUIText>)+BA]");
					object obj52 = (nint)0 & (nint)0x200;
					if (obj52 != null)
					{
						nint num58 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2109 @ S0_v461 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float completedFactor3 = num15 - NGUIText.finalSpacingX;
					((MissionsManager)considerInactive).Complete(num9, completedFactor3, true);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [considerInactive @ L4 (System.Boolean)+C]");
					num9 = 0;
					obj51 = 0;
				}
			}
			goto IL_234a;
			IL_28c8:
			nint num59 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ S0_v353 (Il2CppClass<NGUIText>)+BA]");
			object obj53 = (nint)0 & (nint)0x200;
			if (obj53 != null)
			{
				nint num60 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1681 @ S0_v422 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num61 = num51 + NGUIText.finalSpacingX;
			float num62 = num15 + num61;
			float num63;
			if (flag2)
			{
				bool flag14 = System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform3) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
				bool flag15 = System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
				object obj54 = flag14 & flag15;
				if (obj54 != null)
				{
					if (obj26 != null)
					{
						obj26 = 1;
					}
					else
					{
						obj2 = 0;
						_ = 0;
						obj2 = num63;
						_ = 0f;
						((Vector4*)(nint)vector2)->x = (float)obj2;
						Vector4 vector15 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Vector4*)(nint)vector15)->z = 0f;
						((List<Vector3>)considerInactive).Add(vector2);
						obj14 = 0;
						_ = 0;
						obj14 = num63;
						_ = 0f;
						((Vector4*)(nint)vector2)->x = (float)obj14;
						Vector4 vector16 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v60+8]");
						((Vector4*)(nint)vector16)->z = 0f;
						((List<Vector3>)considerInactive).Add(vector2);
						obj26 = 1;
					}
				}
				else if (obj26 == null)
				{
					obj26 = 0;
				}
				else
				{
					nint num64 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1923 @ S0_v374 (Il2CppClass<UnityEngine.Vector2>)+BA]");
					object obj55 = (nint)0 & (nint)0x200;
					if (obj55 != null)
					{
						nint num65 = (nint)typeof(Vector2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1992 @ S0_v395 (Il2CppClass<UnityEngine.Vector2>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj21 = obj10;
					((Vector4*)(nint)vector2)->x = (float)obj21;
					Vector3 vector17 = vector2;
					((Vector4*)(nint)vector2)->x = (float)obj2;
					Vector4 vector18 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Vector4*)(nint)vector18)->z = 0f;
					((List<Vector3>)considerInactive).Add(vector2);
					obj22 = obj9;
					((Vector4*)(nint)vector2)->x = (float)obj22;
					Vector3 vector19 = vector2;
					((Vector4*)(nint)vector2)->x = (float)obj14;
					Vector4 vector20 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v60+8]");
					((Vector4*)(nint)vector20)->z = 0f;
					((List<Vector3>)considerInactive).Add(vector2);
					obj26 = 0;
				}
			}
			float num66;
			obj9 = num66;
			obj10 = num66;
			num15 = num62;
			text2 = (string)(object)jsonDict;
			goto IL_214d;
			IL_214d:
			object obj56 = obj + 1;
			obj = obj56;
			obj25 = obj56;
			text = text2;
			continue;
			IL_234a:
			float num67 = num15 - num15;
			float num69;
			float num68 = num69 - num15;
			nint num70 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1801 @ S1_v292 (Il2CppClass<NGUIText>)+BA]");
			object obj57 = (nint)0 & (nint)0x200;
			if (obj57 != null)
			{
				nint num71 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1876 @ S1_v303 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num73;
			float num72 = num73 - NGUIText.finalLineHeight;
			float num75;
			float num74 = num75 - NGUIText.finalLineHeight;
			float num76 = num17 + NGUIText.finalLineHeight;
			num15 = 0f;
			num17 = num76;
			num63 = num67;
			float num77 = num72;
			num66 = num68;
			num23 = num74;
			obj26 = obj51;
			goto IL_28c8;
			IL_0cea:
			if (num51 == 0f)
			{
				text2 = text;
				goto IL_214d;
			}
			num69 = num15 + num51;
			num75 = 0f - num17;
			num73 = num75 - num5;
			nint num78 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1564 @ S0_v344 (Il2CppClass<NGUIText>)+BA]");
			object obj58 = (nint)0 & (nint)0x200;
			if (obj58 != null)
			{
				nint num79 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1592 @ S0_v566 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num80 = num69 + NGUIText.finalSpacingX;
			if (num80 > (float)NGUIText.regionWidth)
			{
				if (num15 == 0f)
				{
					return;
				}
				bool flag16 = vector != (Vector3)(object)0;
				object obj59 = flag16 & obj27;
				if (obj59 != null)
				{
					nint num81 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1654 @ S0_v540 (Il2CppClass<NGUIText>)+BA]");
					object obj60 = (nint)0 & (nint)0x200;
					if (obj60 != null)
					{
						nint num82 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1696 @ S0_v561 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (NGUIText.alignment == NGUIText.Alignment.Left)
					{
						vector = (Vector3)0;
					}
					else
					{
						nint num83 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1747 @ S0_v549 (Il2CppClass<NGUIText>)+BA]");
						object obj61 = (nint)0 & (nint)0x200;
						if (obj61 != null)
						{
							nint num84 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1811 @ S0_v555 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float completedFactor4 = num15 - NGUIText.finalSpacingX;
						((MissionsManager)vector).Complete(index, completedFactor4, true);
						vector = (Vector3)0;
					}
				}
				if (flag2)
				{
					if (obj26 != null)
					{
						nint num85 = (nint)typeof(Vector2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1756 @ S0_v517 (Il2CppClass<UnityEngine.Vector2>)+BA]");
						object obj62 = (nint)0 & (nint)0x200;
						if (obj62 != null)
						{
							nint num86 = (nint)typeof(Vector2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1821 @ S0_v536 (Il2CppClass<UnityEngine.Vector2>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj19 = obj10;
						((Vector4*)(nint)vector2)->x = (float)obj19;
						Vector3 vector21 = vector2;
						((Vector4*)(nint)vector2)->x = (float)obj2;
						Vector4 vector22 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Vector4*)(nint)vector22)->z = 0f;
						((List<Vector3>)considerInactive).Add(vector2);
						obj20 = obj9;
						((Vector4*)(nint)vector2)->x = (float)obj20;
						Vector3 vector23 = vector2;
						((Vector4*)(nint)vector2)->x = (float)obj14;
						Vector4 vector24 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v60+8]");
						((Vector4*)(nint)vector24)->z = 0f;
					}
					else
					{
						bool flag17 = System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform3) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
						bool flag18 = System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
						object obj63 = flag17 & flag18;
						if (obj63 == null)
						{
							goto IL_118b;
						}
						obj2 = 0;
						_ = 0;
						obj2 = num15;
						float num87 = num75 - num5;
						_ = 0f;
						((Vector4*)(nint)vector2)->x = (float)obj2;
						Vector4 vector25 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Vector4*)(nint)vector25)->z = 0f;
						((List<Vector3>)considerInactive).Add(vector2);
						obj14 = 0;
						_ = 0;
						obj14 = num15;
						_ = 0f;
						((Vector4*)(nint)vector2)->x = (float)obj14;
						Vector4 vector26 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v60+8]");
						((Vector4*)(nint)vector26)->z = 0f;
						((List<Vector3>)considerInactive).Add(vector2);
						obj15 = 0;
						_ = 0;
						float num88 = num15 + 2f;
						obj15 = num88;
						_ = 0f;
						((Vector4*)(nint)vector2)->x = (float)obj15;
						Vector4 vector27 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v62+8]");
						((Vector4*)(nint)vector27)->z = 0f;
						((List<Vector3>)considerInactive).Add(vector2);
						obj16 = 0;
						_ = 0;
						float num89 = num15 + 2f;
						obj16 = num89;
						float num90 = num75 - num5;
						_ = 0f;
						((Vector4*)(nint)vector2)->x = (float)obj16;
						Vector4 vector28 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v64+8]");
						((Vector4*)(nint)vector28)->z = 0f;
					}
					((List<Vector3>)considerInactive).Add(vector2);
					goto IL_118b;
				}
				obj51 = obj26;
				goto IL_234a;
			}
			num63 = num15;
			num77 = num73;
			num66 = num69;
			num23 = num75;
			goto IL_28c8;
		}
		if (vector != (Vector3)(object)0)
		{
			if (obj27 == null)
			{
				obj2 = 0;
				_ = 0;
				float num91 = num15 - 1f;
				obj2 = num91;
				object obj64 = 0f - num17;
				float num92 = (float)obj64 - num5;
				_ = 0f;
				((Vector4*)(nint)vector2)->x = (float)obj2;
				Vector4 vector29 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Vector4*)(nint)vector29)->z = 0f;
				((List<Vector3>)vector).Add(vector2);
				obj14 = 0;
				_ = 0;
				float num93 = num15 - 1f;
				obj14 = num93;
				_ = 0f;
				((Vector4*)(nint)vector2)->x = (float)obj14;
				Vector4 vector30 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v60+8]");
				((Vector4*)(nint)vector30)->z = 0f;
				((List<Vector3>)vector).Add(vector2);
				obj15 = 0;
				_ = 0;
				float num94 = num15 + 1f;
				obj15 = num94;
				_ = 0f;
				((Vector4*)(nint)vector2)->x = (float)obj15;
				Vector4 vector31 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v62+8]");
				((Vector4*)(nint)vector31)->z = 0f;
				((List<Vector3>)vector).Add(vector2);
				obj16 = 0;
				_ = 0;
				float num95 = num15 + 1f;
				obj16 = num95;
				float num96 = (float)obj64 - num5;
				_ = 0f;
				((Vector4*)(nint)vector2)->x = (float)obj16;
				Vector4 vector32 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v64+8]");
				((Vector4*)(nint)vector32)->z = 0f;
				((List<Vector3>)vector).Add(vector2);
			}
			nint num97 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S0_v227 (Il2CppClass<NGUIText>)+BA]");
			object obj65 = (nint)0 & (nint)0x200;
			if (obj65 != null)
			{
				nint num98 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v247 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (NGUIText.alignment != NGUIText.Alignment.Left)
			{
				nint num99 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ S0_v236 (Il2CppClass<NGUIText>)+BA]");
				object obj66 = (nint)0 & (nint)0x200;
				if (obj66 != null)
				{
					nint num100 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ S0_v241 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float completedFactor5 = num15 - NGUIText.finalSpacingX;
				((MissionsManager)vector).Complete(index, completedFactor5, true);
			}
		}
		if (flag2)
		{
			if (obj26 != null)
			{
				nint num101 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ S0_v199 (Il2CppClass<UnityEngine.Vector2>)+BA]");
				object obj67 = (nint)0 & (nint)0x200;
				if (obj67 != null)
				{
					nint num102 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ S0_v219 (Il2CppClass<UnityEngine.Vector2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj23 = obj10;
				((Vector4*)(nint)vector2)->x = (float)obj23;
				Vector3 vector33 = vector2;
				((Vector4*)(nint)vector2)->x = (float)obj2;
				Vector4 vector34 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Vector4*)(nint)vector34)->z = 0f;
				((List<Vector3>)considerInactive).Add(vector2);
				obj24 = obj9;
				((Vector4*)(nint)vector2)->x = (float)obj24;
				Vector3 vector35 = vector2;
				((Vector4*)(nint)vector2)->x = (float)obj14;
				Vector4 vector36 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v60+8]");
				((Vector4*)(nint)vector36)->z = 0f;
				((List<Vector3>)considerInactive).Add(vector2);
			}
			else
			{
				bool flag19 = System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
				bool flag20 = transform2 == obj;
				object obj68 = flag19 & flag20;
				if (obj68 != null)
				{
					obj2 = 0;
					_ = 0;
					obj2 = num15;
					object obj69 = 0f - num17;
					float num103 = (float)obj69 - num5;
					_ = 0f;
					((Vector4*)(nint)vector2)->x = (float)obj2;
					Vector4 vector37 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Vector4*)(nint)vector37)->z = 0f;
					((List<Vector3>)considerInactive).Add(vector2);
					obj14 = 0;
					_ = 0;
					obj14 = num15;
					_ = 0f;
					((Vector4*)(nint)vector2)->x = (float)obj14;
					Vector4 vector38 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v60+8]");
					((Vector4*)(nint)vector38)->z = 0f;
					((List<Vector3>)considerInactive).Add(vector2);
					obj15 = 0;
					_ = 0;
					float num104 = num15 + 2f;
					obj15 = num104;
					_ = 0f;
					((Vector4*)(nint)vector2)->x = (float)obj15;
					Vector4 vector39 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v62+8]");
					((Vector4*)(nint)vector39)->z = 0f;
					((List<Vector3>)considerInactive).Add(vector2);
					obj16 = 0;
					_ = 0;
					float num105 = num15 + 2f;
					obj16 = num105;
					float num106 = (float)obj69 - num5;
					_ = 0f;
					((Vector4*)(nint)vector2)->x = (float)obj16;
					Vector4 vector40 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v64+8]");
					((Vector4*)(nint)vector40)->z = 0f;
					((List<Vector3>)considerInactive).Add(vector2);
				}
			}
			nint num107 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ S0_v123 (Il2CppClass<NGUIText>)+BA]");
			object obj70 = (nint)0 & (nint)0x200;
			if (obj70 != null)
			{
				nint num108 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ S0_v147 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (NGUIText.alignment != NGUIText.Alignment.Left)
			{
				int num109 = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [considerInactive @ L4 (System.Boolean)+C]");
				if ((nint)num109 < (nint)0)
				{
					nint num110 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1042 @ S0_v136 (Il2CppClass<NGUIText>)+BA]");
					object obj71 = (nint)0 & (nint)0x200;
					if (obj71 != null)
					{
						nint num111 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1130 @ S0_v141 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float completedFactor6 = num15 - NGUIText.finalSpacingX;
					((MissionsManager)considerInactive).Complete(num9, completedFactor6, true);
				}
			}
		}
		nint num112 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ S0_v105 (Il2CppClass<NGUIText>)+BA]");
		object obj72 = (nint)0 & (nint)0x200;
		if (obj72 != null)
		{
			nint num113 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ S0_v114 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BetterList<Color> mColors = NGUIText.mColors;
		_ = 0;
	}

	public unsafe static void FitOnScreen(Camera cam, Transform transform, Transform content, Vector3 pos, out Bounds bounds, bool considerInactive = false)
	{
		//IL_0068: Expected I4, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0099: Expected I, but got Obj
		//IL_00af: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got Ref
		//IL_00fb: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cam @ L0 (UnityEngine.Camera)+58]");
		ModelScreenData modelScreenData = ((Dictionary<UIModelController.ModelScreen, ModelScreenData>)0).get_Item((UIModelController.ModelScreen)content);
		CharacterModel characterModel = modelScreenData.characterModel__BackingField;
		HoverboardBundle line = modelScreenData.characterModel__BackingField.AddEquippedHoverboard();
		nint num = (nint)typeof(HoverboardModelPreviewFactory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<HoverboardModelPreviewFactory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HoverboardModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v21 (Il2CppClass<HoverboardModelPreviewFactory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CoinMagnet instance = CoinMagnet.Instance;
		((TutorialMultilineLabelsHelper)(object)instance).SetText((string)(object)transform, (string)(object)line, (string)(object)characterModel._characterAnimation, (string)pos, (string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref bounds), (string)considerInactive);
		TransformExtensions.Reset((Transform)(object)UIModelController.OnChangedCurrentlyShownHoverboard);
	}

	public static bool Save(string fileName, byte[] bytes)
	{
		//IL_000d: Expected I4, but got Obj
		//IL_0011: Expected I4, but got Obj
		return (byte)(int)((Transform)(object)bytes).GetChild((int)fileName) != 0;
	}

	public static byte[] Load(string fileName)
	{
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)(object)fileName))
		{
			return (byte[])(object)((GameObject)(object)fileName).tag;
		}
		return null;
	}

	public unsafe static Color ApplyPMA(Color c)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got F4
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_0100: Expected native int or pointer, but got VT
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0120: Expected Obj, but got F4
		//IL_013c: Expected native int or pointer, but got VT
		//IL_014e: Expected Obj, but got F4
		//IL_005a: Expected native int or pointer, but got VT
		//IL_006c: Expected native int or pointer, but got VT
		//IL_007e: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = c.r;
		_ = c.b;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v29 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
		float r = default;
		((Color*)(nint)c)->r = r;
		object obj4 = obj2 + 12;
		obj4 = c.r;
		_ = c.b;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
		float g = default;
		((Color*)(nint)c)->g = g;
		obj2 = c.r;
		_ = c.b;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
		float b = default;
		((Color*)(nint)c)->b = b;
		Color color = default;
		((Color*)(nint)color)->r = c.r;
		((Color*)(nint)color)->b = c.b;
		return color;
	}

	public unsafe static void MarkParentAsChanged(GameObject go)
	{
		//IL_034d: Expected I, but got Obj
		//IL_0363: Expected Obj, but got I
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected VT, but got Unknown
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected Obj, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected Obj, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_00bd: Expected I, but got Obj
		//IL_0117: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_042b: Expected Obj, but got VT
		//IL_02b1: Expected I, but got Obj
		//IL_02c7: Expected Obj, but got I
		//IL_0158: Expected I, but got Obj
		//IL_04be: Expected Obj, but got I4
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected Obj, but got Unknown
		//IL_01a4: Expected VT, but got Obj
		//IL_01b2: Expected I, but got Obj
		//IL_01c8: Expected Obj, but got I
		//IL_02f2: Expected I, but got Obj
		//IL_0455: Expected F4, but got Obj
		//IL_0450: Expected native int or pointer, but got VT
		//IL_0467: Expected F4, but got I
		//IL_0462: Expected native int or pointer, but got VT
		//IL_0481: Expected F4, but got Obj
		//IL_047c: Expected native int or pointer, but got VT
		//IL_0496: Expected F4, but got I
		//IL_0491: Expected native int or pointer, but got VT
		//IL_049f: Expected Obj, but got VT
		//IL_04b0: Expected VT, but got Obj
		//IL_023f: Expected F4, but got Obj
		//IL_023a: Expected native int or pointer, but got VT
		//IL_0251: Expected F4, but got I
		//IL_024c: Expected native int or pointer, but got VT
		//IL_026b: Expected F4, but got Obj
		//IL_0266: Expected native int or pointer, but got VT
		//IL_0280: Expected F4, but got I
		//IL_027b: Expected native int or pointer, but got VT
		//IL_028d: Expected Obj, but got VT
		//IL_01f3: Expected I, but got Obj
		UIWidget component = ((Component)(object)go).GetComponent<UIWidget>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v60 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		UIAnchor component2 = ((Component)(object)go).GetComponent<UIAnchor>();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v75 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = default;
		Color color = (Color)(transform + 48);
		Transform transform2 = (Transform)(transform + 12);
		object obj3 = transform + 36;
		object obj4 = transform + 24;
		if (component2 != null)
		{
			_0021_00210 componentInChildren = (_0021_00210)((Component)(object)go).GetComponentInChildren<T>();
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v71 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)componentInChildren != null)
			{
				transform2.localPosition = (Vector3)go;
				nint num7 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v38 (Il2CppClass<NGUITools>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num8 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v55 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Color*)(nint)color)->r = (float)transform2;
				((Color*)(nint)color)->b = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
				Color color2 = ApplyPMA(color);
				((Color*)(nint)color)->r = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v20+8]");
				((Color*)(nint)color)->b = 0f;
				Vector3 eulerAngles = ((Transform)color).eulerAngles;
				transform.localScale = (Vector3)go;
				((Color*)(nint)color)->r = (float)transform;
				((Color*)(nint)color)->b = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				Color color3 = ApplyPMA(color);
				((Color*)(nint)color)->r = (float)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v22+8]");
				((Color*)(nint)color)->b = 0f;
				((Transform)(object)go).parent = (Transform)color;
			}
		}
		int siblingIndex = ((Transform)(object)go).GetSiblingIndex();
		Sprite sprite = null;
		while ((nint)sprite < siblingIndex)
		{
			bool flag = ((SpriteAtlas)(object)go).CanBindTo(sprite);
			nint num9 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v30 (Il2CppClass<NGUITools>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num10 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v36 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MarkParentAsChanged((GameObject)flag);
			Sprite sprite2 = (Sprite)(sprite + 1);
			sprite = sprite2;
		}
	}

	public static string EncodeColor(Color c)
	{
		//IL_00d4: Expected I, but got Obj
		//IL_00ea: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006d: Expected Obj, but got VT
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v22 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = clipboard;
		if (text != null)
		{
			string temporaryCachePath = Application.temporaryCachePath;
			object path = ((IConvertible)temporaryCachePath).ToType((Type)(object)"/", (IFormatProvider)c);
			if (File.GetAttributes((string)path) != 0)
			{
				return File.ReadAllText((string)path);
			}
			return null;
		}
		return null;
	}

	public unsafe static Color ParseColor(string text, int offset)
	{
		//IL_005f: Expected Obj, but got I4
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected I4, but got Unknown
		//IL_00c8: Expected I4, but got Obj
		//IL_00ef: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		object obj = ((int*)offset)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [offset @ L2 (System.Int32)+8]");
		_ = 0;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v20 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = obj + 12;
		((int*)num3)->m_value = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Color color = default;
		((UIBasicSprite)color).AddVertexColours((List<Color>)(object)text, ref *(Color*)text, num3, 0);
		return color;
	}

	public unsafe static string StripSymbols(string text)
	{
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected VT, but got Unknown
		//IL_00c0: Expected F4, but got Obj
		//IL_00bb: Expected native int or pointer, but got VT
		//IL_00d5: Expected F4, but got I
		//IL_00d0: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		_ = text.m_stringLength;
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<NGUIText>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v20 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Color color = (Color)(text + 16);
		((Color*)(nint)color)->r = (float)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Color*)(nint)color)->b = 0f;
		return NGUIText.EncodeColor32(color);
	}

	public static T AddMissingComponent<T>(GameObject go) where T : Component
	{
		//IL_00b5: Expected Obj, but got I4
		//IL_00c3: Expected I, but got Obj
		//IL_00d9: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		object result = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (go != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			return (T)result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+18]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52 @ S2_v6 (should have been resolved before IL gen)");
		T result2 = default;
		return result2;
	}

	public static Vector3[] GetSides(Camera cam)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected I4, but got Obj
		//IL_00a0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUIText>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (Vector3[])NGUIText.IsSpace((int)cam);
	}

	public static Vector3[] GetSides(Camera cam, float depth)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (Vector3[])(object)TweenFill.Begin((GameObject)(object)cam, depth, 1f);
	}

	public static Vector3[] GetSides(Camera cam, Transform relativeTo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02eb: Expected I, but got Obj
		//IL_0301: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0101: Expected Obj, but got I4
		//IL_00ea: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<NGUITools>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v84 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = clipboard;
		if (text != null)
		{
			string temporaryCachePath = Application.temporaryCachePath;
			object obj4 = ((IConvertible)temporaryCachePath).ToType((Type)(object)"/", (IFormatProvider)(object)cam);
			if ((object)relativeTo == null)
			{
				if (File.GetAttributes((string)obj4) == 0)
				{
					return (Vector3[])1;
				}
				((FileStream)obj4).ExposeHandle();
				return (Vector3[])1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj5 = default;
			object obj6 = default;
			if (obj5 == obj6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj8 = default;
				object obj7 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj10 = default;
				object obj9 = obj10;
			}
			else
			{
				object obj11 = default;
				object obj9 = obj11;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		Vector3[] result = default;
		return result;
	}

	public static Vector3[] GetSides(Camera cam, float depth, Transform relativeTo)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		Vector3[] array = default;
		object obj = array + 20;
		obj = cam;
		return array;
	}

	public static Vector3[] GetWorldCorners(Camera cam)
	{
		//IL_00c7: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_011e: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		float farClipPlane = cam.farClipPlane;
		float fieldOfView = cam.fieldOfView;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v3 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v9 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float depth = Mathf.LerpUnclamped(farClipPlane, fieldOfView, 0.5f);
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v9 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v15 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return GetWorldCorners(cam, depth, null);
	}

	public static Vector3[] GetWorldCorners(Camera cam, float depth)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return GetWorldCorners(cam, depth, null);
	}

	public static Vector3[] GetWorldCorners(Camera cam, Transform relativeTo)
	{
		//IL_00c7: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_011e: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		float farClipPlane = cam.farClipPlane;
		float fieldOfView = cam.fieldOfView;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v3 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v9 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float depth = Mathf.LerpUnclamped(farClipPlane, fieldOfView, 0.5f);
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v9 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v15 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return GetWorldCorners(cam, depth, relativeTo);
	}

	public unsafe static Vector3[] GetWorldCorners(Camera cam, float depth, Transform relativeTo)
	{
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected Obj, but got Unknown
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected Obj, but got Unknown
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected Obj, but got Unknown
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected Obj, but got Unknown
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Expected Obj, but got Unknown
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected Obj, but got Unknown
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Expected Obj, but got Unknown
		//IL_0846: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected VT, but got Unknown
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Expected Obj, but got Unknown
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_0867: Expected Obj, but got Unknown
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected Obj, but got Unknown
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected VT, but got Unknown
		//IL_088c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0891: Expected Obj, but got Unknown
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_089f: Expected Obj, but got Unknown
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Expected Obj, but got Unknown
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Expected VT, but got Unknown
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected Obj, but got Unknown
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected Obj, but got Unknown
		//IL_08e0: Expected Obj, but got I4
		//IL_08ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f4: Expected Obj, but got Unknown
		//IL_08fd: Expected Obj, but got I4
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Expected Obj, but got Unknown
		//IL_091a: Expected Obj, but got I4
		//IL_055b: Expected I, but got Obj
		//IL_0571: Expected Obj, but got I
		//IL_0c7c: Expected Obj, but got I4
		//IL_0c93: Expected Obj, but got F4
		//IL_0ca6: Expected I, but got F4
		//IL_0ccd: Expected VT, but got Obj
		//IL_0cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfa: Expected Obj, but got Unknown
		//IL_0d15: Expected Obj, but got I4
		//IL_0d24: Expected Obj, but got F4
		//IL_0d59: Expected VT, but got Obj
		//IL_0d81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Expected Obj, but got Unknown
		//IL_0da1: Expected Obj, but got I4
		//IL_0db8: Expected Obj, but got F4
		//IL_0dcb: Expected I, but got F4
		//IL_0df2: Expected VT, but got Obj
		//IL_001f: Expected VT, but got Obj
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected Obj, but got Unknown
		//IL_0622: Expected Obj, but got I4
		//IL_0631: Expected Obj, but got F4
		//IL_0666: Expected VT, but got Obj
		//IL_0677: Expected Obj, but got F4
		//IL_0689: Expected I, but got F4
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected Obj, but got Unknown
		//IL_059c: Expected I, but got Obj
		//IL_0044: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_0c40: Expected I, but got Obj
		//IL_0c56: Expected Obj, but got I
		//IL_096c: Expected Obj, but got F4
		//IL_097c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0981: Expected Obj, but got Unknown
		//IL_099e: Expected Obj, but got I
		//IL_09e1: Expected VT, but got Obj
		//IL_00e3: Expected VT, but got Obj
		//IL_010b: Expected I, but got Obj
		//IL_0121: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_0e09: Expected I, but got Obj
		//IL_0e1f: Expected Obj, but got I
		//IL_06b3: Expected I, but got Obj
		//IL_09ef: Expected F4, but got Obj
		//IL_0a0c: Expected F4, but got I
		//IL_0a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Expected Obj, but got Unknown
		//IL_06fb: Expected Obj, but got I4
		//IL_0a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a49: Expected Obj, but got Unknown
		//IL_014c: Expected I, but got Obj
		//IL_079c: Expected I, but got Obj
		//IL_0f4a: Expected I, but got Obj
		//IL_0f60: Expected Obj, but got I
		//IL_01ba: Expected Obj, but got F4
		//IL_0a8c: Expected Obj, but got I4
		//IL_0ab3: Expected I, but got Obj
		//IL_0ac9: Expected Obj, but got I
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_0204: Expected Obj, but got F4
		//IL_070e: Expected I, but got Obj
		//IL_0724: Expected Obj, but got I
		//IL_0fc5: Expected VT, but got Obj
		//IL_0fc5: Expected VT, but got Obj
		//IL_0ff0: Expected I, but got Obj
		//IL_1006: Expected Obj, but got I
		//IL_0217: Expected I, but got Obj
		//IL_0e46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4b: Expected Obj, but got Unknown
		//IL_0e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e59: Expected Obj, but got Unknown
		//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed7: Expected Obj, but got Unknown
		//IL_0ee0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee5: Expected Obj, but got Unknown
		//IL_0f0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f12: Expected Obj, but got Unknown
		//IL_0b27: Expected VT, but got Obj
		//IL_0b27: Expected VT, but got Obj
		//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Expected Obj, but got Unknown
		//IL_0b72: Expected Obj, but got I4
		//IL_0b81: Expected Obj, but got F4
		//IL_0bd6: Expected VT, but got Obj
		//IL_0bd6: Expected VT, but got Obj
		//IL_0bd6: Expected Ref, but got VT
		//IL_0be3: Expected Obj, but got F4
		//IL_0bf5: Expected I, but got F4
		//IL_0c1f: Expected VT, but got Obj
		//IL_0c1f: Expected VT, but got Obj
		//IL_0264: Expected I, but got Obj
		//IL_074f: Expected I, but got Obj
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_034c: Expected Obj, but got I4
		//IL_035a: Expected Obj, but got F4
		//IL_03b0: Expected VT, but got Obj
		//IL_03b0: Expected VT, but got Obj
		//IL_03b0: Expected Ref, but got VT
		//IL_03bd: Expected Obj, but got F4
		//IL_03cf: Expected I, but got F4
		//IL_03f9: Expected VT, but got Obj
		//IL_03f9: Expected VT, but got Obj
		//IL_02b1: Expected I, but got Obj
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected Obj, but got Unknown
		//IL_045e: Expected Obj, but got I4
		//IL_046d: Expected Obj, but got F4
		//IL_04c2: Expected VT, but got Obj
		//IL_04c2: Expected VT, but got Obj
		//IL_04c2: Expected Ref, but got VT
		//IL_04cf: Expected Obj, but got F4
		//IL_04e1: Expected I, but got F4
		//IL_050b: Expected VT, but got Obj
		//IL_050b: Expected VT, but got Obj
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected Obj, but got Unknown
		object obj = default;
		Camera camera = (Camera)(obj + 80);
		PropertyBinding propertyBinding = (PropertyBinding)(obj - -64);
		Transform transform = (Transform)(obj + 48);
		object obj2 = obj + 32;
		Transform transform2 = (Transform)(obj + 248);
		Transform transform3 = (Transform)(obj + 232);
		object obj3 = obj + 16;
		Quaternion quaternion = (Quaternion)(obj + 220);
		object obj4 = obj + 208;
		object obj5 = obj + 192;
		object obj6 = obj + 176;
		Quaternion quaternion2 = (Quaternion)(obj + 164);
		object obj7 = obj + 152;
		object obj8 = obj + 136;
		object obj9 = obj + 120;
		Quaternion quaternion3 = (Quaternion)(obj + 108);
		object obj10 = obj + 96;
		object obj11 = obj + 296;
		obj11 = 0;
		_ = 0;
		object obj12 = obj + 280;
		obj12 = 0;
		_ = 0;
		object obj13 = obj + 264;
		obj13 = 0;
		_ = 0;
		if (cam.transparencySortMode != TransparencySortMode.Default)
		{
			float depth2 = cam.depth;
			camera.rect = (Rect)cam;
			obj11 = camera;
			_ = ((UnityEngine.Object)camera).m_CachedPtr;
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v143 (Il2CppClass<NGUITools>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v214 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			propertyBinding.Start();
			transform = (Transform)(object)propertyBinding;
			obj2 = propertyBinding;
			object obj15 = 0f - depth2;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
			object obj16 = transform4 / 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v43+8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v43+C]");
			object obj17 = num3 / 0;
			object obj18 = obj16 * obj17;
			object obj19 = obj15 * obj18;
			float num4 = depth2 * (float)obj18;
			GameObject gameObject = cam.gameObject;
			transform2.rotation = (Quaternion)gameObject;
			obj12 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			transform3.position = (Vector3)gameObject;
			obj13 = transform3;
			_ = ((UnityEngine.Object)transform3).m_CachedPtr;
			obj3 = propertyBinding;
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ S1_v143 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num6 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S1_v276 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GUILayoutOption gUILayoutOption = GUILayout.Width((float)obj3);
			obj = propertyBinding;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			GUILayoutOption gUILayoutOption2 = GUILayout.Width(0f);
			object obj21 = gUILayoutOption & 1;
			if (obj21 != null)
			{
				camera = (Camera)(object)propertyBinding;
				float num7 = 1f / (float)camera;
				float num8 = (float)obj13 - num7;
				obj13 = num8;
			}
			object obj22 = gUILayoutOption2 & 1;
			if (obj22 != null)
			{
				object obj23 = obj13 + 4;
				camera = (Camera)(object)propertyBinding;
				float num9 = 1f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Camera)+4]");
				float num10 = num9 / 0f;
				float num11 = (float)obj23 + num10;
				obj23 = num11;
			}
			nint num12 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S0_v173 (Il2CppClass<NGUITools>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num13 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ S0_v199 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			transform = (Transform)obj12;
			Transform transform5 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v46+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			obj2 = 0;
			_ = 0;
			obj2 = obj19;
			_ = 0f;
			nint num14 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ S1_v165 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num15 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ S1_v265 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			propertyBinding = (PropertyBinding)(object)transform;
			((UnityEngine.Object)propertyBinding).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
			camera = (Camera)obj2;
			Camera camera2 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			((UnityEngine.Object)camera2).m_CachedPtr = (IntPtr)0;
			((Quaternion*)transform2)->SetLookRotation((Vector3)propertyBinding, (Vector3)camera);
			transform3 = (Transform)obj13;
			Transform transform6 = transform3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v49+8]");
			((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
			nint num16 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ S1_v177 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num17 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ S1_v261 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			propertyBinding = (PropertyBinding)(object)transform2;
			((UnityEngine.Object)propertyBinding).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
			camera = (Camera)(object)transform3;
			((UnityEngine.Object)camera).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
			Vector3 vector = (Vector3)propertyBinding - (Vector3)camera;
			camera = (Camera)obj3;
			Camera camera3 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
			((UnityEngine.Object)camera3).m_CachedPtr = (IntPtr)0;
			object obj27 = mSides + 16;
			obj27 = camera;
			_ = ((UnityEngine.Object)camera).m_CachedPtr;
			obj = 0;
			_ = 0;
			obj = 0f;
			propertyBinding = (PropertyBinding)obj12;
			PropertyBinding propertyBinding2 = propertyBinding;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v46+8]");
			((UnityEngine.Object)propertyBinding2).m_CachedPtr = (IntPtr)0;
			camera = (Camera)obj;
			Camera camera4 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)camera4).m_CachedPtr = (IntPtr)0;
			((Quaternion*)quaternion)->SetLookRotation((Vector3)propertyBinding, (Vector3)camera);
			propertyBinding = (PropertyBinding)quaternion.x;
			((UnityEngine.Object)propertyBinding).m_CachedPtr = (IntPtr)quaternion.z;
			camera = (Camera)obj13;
			Camera camera5 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v49+8]");
			((UnityEngine.Object)camera5).m_CachedPtr = (IntPtr)0;
			Vector3 vector2 = (Vector3)propertyBinding - (Vector3)camera;
			camera = (Camera)obj4;
			Camera camera6 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
			((UnityEngine.Object)camera6).m_CachedPtr = (IntPtr)0;
			object obj28 = mSides + 28;
			obj28 = camera;
			_ = ((UnityEngine.Object)camera).m_CachedPtr;
			obj5 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v46+8]");
			_ = 0;
			obj6 = 0;
			_ = 0;
			obj6 = num4;
			_ = 0f;
			propertyBinding = (PropertyBinding)obj5;
			PropertyBinding propertyBinding3 = propertyBinding;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+8]");
			((UnityEngine.Object)propertyBinding3).m_CachedPtr = (IntPtr)0;
			camera = (Camera)obj6;
			Camera camera7 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
			((UnityEngine.Object)camera7).m_CachedPtr = (IntPtr)0;
			((Quaternion*)quaternion2)->SetLookRotation((Vector3)propertyBinding, (Vector3)camera);
			propertyBinding = (PropertyBinding)quaternion2.x;
			((UnityEngine.Object)propertyBinding).m_CachedPtr = (IntPtr)quaternion2.z;
			camera = (Camera)obj13;
			Camera camera8 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v49+8]");
			((UnityEngine.Object)camera8).m_CachedPtr = (IntPtr)0;
			Vector3 vector3 = (Vector3)propertyBinding - (Vector3)camera;
			camera = (Camera)obj7;
			Camera camera9 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33+8]");
			((UnityEngine.Object)camera9).m_CachedPtr = (IntPtr)0;
			object obj29 = mSides + 40;
			obj29 = camera;
			_ = ((UnityEngine.Object)camera).m_CachedPtr;
			obj8 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v46+8]");
			_ = 0;
			obj9 = 0;
			_ = 0;
			obj9 = 0f;
			propertyBinding = (PropertyBinding)obj8;
			PropertyBinding propertyBinding4 = propertyBinding;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+8]");
			((UnityEngine.Object)propertyBinding4).m_CachedPtr = (IntPtr)0;
			camera = (Camera)obj9;
			Camera camera10 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+8]");
			((UnityEngine.Object)camera10).m_CachedPtr = (IntPtr)0;
			((Quaternion*)quaternion3)->SetLookRotation((Vector3)propertyBinding, (Vector3)camera);
			propertyBinding = (PropertyBinding)quaternion3.x;
			((UnityEngine.Object)propertyBinding).m_CachedPtr = (IntPtr)quaternion3.z;
			camera = (Camera)obj13;
			Camera camera11 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v49+8]");
			((UnityEngine.Object)camera11).m_CachedPtr = (IntPtr)0;
			Vector3 vector4 = (Vector3)propertyBinding - (Vector3)camera;
			camera = (Camera)obj10;
			Camera camera12 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41+8]");
			((UnityEngine.Object)camera12).m_CachedPtr = (IntPtr)0;
			object obj30 = mSides + 52;
			obj30 = camera;
		}
		else
		{
			nint num18 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v105 (Il2CppClass<NGUITools>)+BA]");
			object obj31 = (nint)0 & (nint)0x200;
			if (obj31 != null)
			{
				nint num19 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v131 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			propertyBinding = (PropertyBinding)0;
			((UnityEngine.Object)propertyBinding).m_CachedPtr = (IntPtr)0;
			propertyBinding = (PropertyBinding)0f;
			_ = 0.5f;
			((UnityEngine.Object)propertyBinding).m_CachedPtr = (IntPtr)depth;
			camera = (Camera)(object)propertyBinding;
			((UnityEngine.Object)camera).m_CachedPtr = ((UnityEngine.Object)propertyBinding).m_CachedPtr;
			Vector3 vector5 = cam.ScreenToWorldPoint((Vector3)camera);
			camera = (Camera)(object)transform;
			((UnityEngine.Object)camera).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
			object obj32 = mSides + 16;
			obj32 = camera;
			_ = ((UnityEngine.Object)camera).m_CachedPtr;
			obj2 = 0;
			_ = 0;
			obj2 = 0.5f;
			_ = 1f;
			camera = (Camera)obj2;
			Camera camera13 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			((UnityEngine.Object)camera13).m_CachedPtr = (IntPtr)0;
			Vector3 vector6 = cam.ScreenToWorldPoint((Vector3)camera);
			camera = (Camera)(object)transform2;
			((UnityEngine.Object)camera).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
			object obj33 = mSides + 28;
			obj33 = camera;
			_ = ((UnityEngine.Object)camera).m_CachedPtr;
			transform3 = (Transform)0;
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			transform3 = (Transform)1f;
			_ = 0.5f;
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)depth;
			camera = (Camera)(object)transform3;
			((UnityEngine.Object)camera).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
			Vector3 vector7 = cam.ScreenToWorldPoint((Vector3)camera);
			camera = (Camera)obj3;
			Camera camera14 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
			((UnityEngine.Object)camera14).m_CachedPtr = (IntPtr)0;
			object obj34 = mSides + 40;
			obj34 = camera;
			_ = ((UnityEngine.Object)camera).m_CachedPtr;
			obj = 0;
			_ = 0;
			obj = 0.5f;
			_ = 0f;
			camera = (Camera)obj;
			Camera camera15 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)camera15).m_CachedPtr = (IntPtr)0;
			Vector3 vector8 = cam.ScreenToWorldPoint((Vector3)camera);
			camera = (Camera)quaternion.x;
			((UnityEngine.Object)camera).m_CachedPtr = (IntPtr)quaternion.z;
			object obj35 = mSides + 52;
			obj35 = camera;
		}
		_ = ((UnityEngine.Object)camera).m_CachedPtr;
		nint num20 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj36 = (nint)0 & (nint)0x200;
		if (obj36 != null)
		{
			nint num21 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S0_v100 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)relativeTo).FindKernel((string)null) != 0)
		{
			object obj37 = 0;
			while ((nint)obj37 <= 3)
			{
				nint num22 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ S0_v82 (Il2CppClass<NGUITools>)+BA]");
				object obj38 = (nint)0 & (nint)0x200;
				if (obj38 != null)
				{
					nint num23 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ S0_v94 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj39 = mSides + 16;
				object obj40 = obj37 * 12;
				object obj41 = obj39 + obj40;
				propertyBinding = (PropertyBinding)obj41;
				PropertyBinding propertyBinding5 = propertyBinding;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ S2_v10+8]");
				((UnityEngine.Object)propertyBinding5).m_CachedPtr = (IntPtr)0;
				camera = (Camera)(object)propertyBinding;
				((UnityEngine.Object)camera).m_CachedPtr = ((UnityEngine.Object)propertyBinding).m_CachedPtr;
				transform.Internal_LookAt_Injected(ref *(Vector3*)relativeTo, ref *(Vector3*)camera);
				camera = (Camera)(object)transform;
				((UnityEngine.Object)camera).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
				object obj42 = mSides + 16;
				object obj43 = obj37 * 12;
				object obj44 = obj42 + obj43;
				obj44 = camera;
				_ = ((UnityEngine.Object)camera).m_CachedPtr;
				object obj45 = obj37 + 1;
				obj37 = obj45;
			}
		}
		nint num24 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S0_v64 (Il2CppClass<NGUITools>)+BA]");
		object obj46 = (nint)0 & (nint)0x200;
		if (obj46 != null)
		{
			nint num25 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S0_v71 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return mSides;
	}

	public static string GetFuncName(object obj, string method)
	{
		//IL_00c7: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_011e: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_0162: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		float farClipPlane = ((Camera)obj).farClipPlane;
		float fieldOfView = ((Camera)obj).fieldOfView;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v3 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v9 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float duration = Mathf.LerpUnclamped(farClipPlane, fieldOfView, 0.5f);
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v9 (Il2CppClass<NGUITools>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v15 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)(object)TweenColor.Begin((GameObject)obj, duration, (Color)method);
	}

	public static void Execute<T>(GameObject go, string funcName) where T : Component
	{
		//IL_000d: Expected I, but got Obj
		((UnityEngine.Object)go).m_CachedPtr = (IntPtr)funcName;
	}

	public static void ExecuteAll<T>(GameObject root, string funcName) where T : Component
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0055: Expected Obj, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_009f: Expected Obj, but got I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_00e1: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x3FFF;
		object obj4 = obj3 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v12 @ S2_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		object obj5 = obj6 + 12;
		object obj7 = 0;
		Type type = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
		{
			object obj8 = obj6 + 16;
			object obj9 = obj7 << 2;
			object obj10 = obj8 + obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			PropertyInfo property = type.GetProperty(funcName, (Type)52);
			if (((MethodInfo)(object)property).Equals((object)null))
			{
				string text = MethodBase.ConstructParameters((Type[])(object)property, (CallingConventions)obj10, false);
			}
			object obj11 = obj7 + 1;
			obj7 = obj11;
		}
	}

	public static void ImmediatelyCreateDrawCalls(GameObject root)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		TextEditor textEditor = default;
		textEditor.ClearCursorPos();
		Rect position = ((TextEditor)(object)root).position;
		textEditor.OnLostFocus();
		textEditor.InitKeyActions();
	}

	public static string KeyToCaption(KeyCode key)
	{
		//IL_00a8: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I4
		//IL_00c7: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_011e: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_0163: Expected VT, but got I4
		//IL_0163: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		float farClipPlane = ((Camera)key).farClipPlane;
		float fieldOfView = ((Camera)key).fieldOfView;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v3 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v9 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float duration = Mathf.LerpUnclamped(farClipPlane, fieldOfView, 0.5f);
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v9 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v15 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)(object)TweenColor.Begin((GameObject)key, duration, (Color)0);
	}

	public static T Draw<T>(string id, OnInitFunc<T> onInit = null) where T : UIWidget
	{
		//IL_0199: Expected I, but got Obj
		//IL_01af: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_0175: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0116: Expected I4, but got Obj
		//IL_0054: Expected I, but got Obj
		OnInitFunc<T> onInitFunc = default;
		UIPanel uIPanel = default;
		if ((nint)onInitFunc == int.MaxValue)
		{
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v23 (Il2CppClass<NGUITools>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v29 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			uIPanel = CreateUI((byte)(int)id != 0);
		}
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v9 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v18 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v64 @ S2_v4 (should have been resolved before IL gen)");
		UIWidget uIWidget = default;
		uIWidget.height = 100;
		Color color = ((UIWidget)100).color;
		Vector2 localSize = ((UIWidget)(object)uIPanel).localSize;
		return (T)uIWidget;
	}

	public unsafe static Color GammaToLinearSpace(Color c)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0029: Expected Obj, but got F4
		//IL_0044: Invalid comparison between I and F4
		//IL_013c: Expected native int or pointer, but got VT
		//IL_014e: Expected native int or pointer, but got VT
		//IL_0073: Expected Obj, but got F4
		//IL_00a1: Expected native int or pointer, but got VT
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00c1: Expected Obj, but got F4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got F4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 32;
		obj3 = c.r;
		_ = c.b;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		if (0f != 1f)
		{
			obj3 = c.r;
			_ = c.b;
			float num = c.r;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			float r = num * 0f;
			((Color*)(nint)c)->r = r;
			object obj4 = c + 4;
			obj = c.r;
			_ = c.b;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+C]");
			object obj6 = obj5 * 0;
			obj4 = obj6;
			object obj7 = c + 8;
			obj2 = c.r;
			_ = c.b;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
			object obj9 = obj8 * 0;
			obj7 = obj9;
		}
		Color color = default;
		((Color*)(nint)color)->r = c.r;
		((Color*)(nint)color)->b = c.b;
		return color;
	}

	static NGUITools()
	{
		//IL_0199: Expected I, but got Obj
		//IL_01af: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0077: Expected VT, but got I
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_008e: Expected Obj, but got I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v47 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string typeName = NGUITools.GetTypeName<T>();
		if (typeName.m_firstChar <= '\0')
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_0021_00211[] array = default;
		array[1] = (_0021_00211)0;
		object obj2 = array + 16;
		obj2 = 0;
		Array.Sort<TKey, TValue>((TKey[])(object)typeName, (TValue[])(object)array);
		object obj3 = typeName + 16;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v29+F4]");
		int num4 = 0;
		int num5 = 0;
		object obj5 = default;
		object obj9 = default;
		while ((nint)obj5 < (int)typeName.m_firstChar)
		{
			object obj6 = typeName + 16;
			object obj7 = obj5 << 2;
			object obj8 = obj6 + obj7;
			UIPanel uIPanel = (UIPanel)obj8;
			if (uIPanel.mDepth == num4)
			{
				uIPanel.sortingOrder = num5;
			}
			else
			{
				int num6 = (uIPanel.sortingOrder = num5 + 1);
				num4 = uIPanel.mDepth;
				num5 = num6;
			}
			obj5 = obj9 + 1;
		}
	}
}
