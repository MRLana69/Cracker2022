using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public static class NGUITools
{
	private static AudioListener mListener;

	private static bool mLoaded = false;

	private static float mGlobalVolume = 1f;

	private static float mLastTimestamp = 0f;

	private static AudioClip mLastClip;

	private static Vector3[] mSides;

	public static KeyCode[] keys;

	private static Comparison<UIWidget> _003C_003Ef__mg_0024cache0;

	private static Comparison<UIPanel> _003C_003Ef__mg_0024cache1;

	public static float soundVolume
	{
		get
		{
			if (~(mLoaded ? 1u : 0u) != 0)
			{
				mLoaded = true;
				float num = PlayerPrefs.GetFloat("Sound", 1f);
				mGlobalVolume = num;
			}
			return mGlobalVolume;
		}
		set
		{
			if (value != mGlobalVolume)
			{
				mLoaded = true;
				mGlobalVolume = value;
				PlayerPrefs.SetFloat("Sound", value);
			}
		}
	}

	public static bool fileAccess
	{
		get
		{
			RuntimePlatform platform = Application.platform;
			return platform != RuntimePlatform.WebGLPlayer;
		}
	}

	public static string clipboard
	{
		get
		{
			TextEditor textEditor = default;
			textEditor._002Ector();
			bool flag = textEditor.Paste();
			GUIContent content = textEditor.m_Content;
			return content.m_Text;
		}
		set
		{
			TextEditor textEditor = default;
			textEditor._002Ector();
			textEditor.text = value;
			textEditor.OnFocus();
			textEditor.Copy();
		}
	}

	public unsafe static Vector2 screenSize
	{
		get
		{
			//IL_0024: Expected F4, but got I4
			//IL_001f: Expected native int or pointer, but got VT
			//IL_0031: Expected F4, but got I4
			//IL_002c: Expected native int or pointer, but got VT
			int width = Screen.width;
			int height = Screen.height;
			Vector2 vector = default;
			((Vector2*)(nint)vector)->x = width;
			((Vector2*)(nint)vector)->y = height;
			return vector;
		}
	}

	public static AudioSource PlaySound(AudioClip clip)
	{
		return PlaySound(clip, 1f, 1f);
	}

	public static AudioSource PlaySound(AudioClip clip, float volume)
	{
		return PlaySound(clip, volume, 1f);
	}

	public static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
	{
		//IL_0152: Expected VT, but got Obj
		//IL_019d: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I
		//IL_02a1: Expected VT, but got Obj
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_021c: Expected Obj, but got I
		float unscaledTime = Time.unscaledTime;
		AudioSource audioSource;
		if (mLastClip == clip)
		{
			float num = mLastTimestamp + 0.1f;
			bool flag = unscaledTime < num;
			audioSource = null;
			if (flag)
			{
				goto IL_0445;
			}
		}
		mLastClip = clip;
		mLastTimestamp = unscaledTime;
		float num2 = soundVolume;
		float num3 = volume * num2;
		bool flag2 = clip != null;
		bool flag3 = !flag2;
		audioSource = null;
		if (!flag3)
		{
			bool flag4 = num3 > 0.01f;
			bool flag5 = !flag4;
			audioSource = null;
			if (!flag5)
			{
				if (mListener == null || !GetActive(mListener))
				{
					Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(AudioListener));
					UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(typeFromHandle);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
					object obj = default;
					if (obj != null)
					{
						object obj2 = 0;
						while (true)
						{
							object obj3 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v117+C]");
							if ((nint)obj3 >= 0)
							{
								break;
							}
							object obj4 = obj2 << 2;
							object obj5 = obj + obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v175+10]");
							if (GetActive((Behaviour)0))
							{
								object obj6 = obj2 << 2;
								object obj7 = obj + obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v184+10]");
								mListener = (AudioListener)0;
								break;
							}
							object obj8 = obj2 + 1;
							obj2 = obj8;
						}
					}
					if (mListener == null)
					{
						Camera main = Camera.main;
						bool flag6 = main == null;
						bool flag7 = !flag6;
						Camera camera = main;
						if (!flag7)
						{
							Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Camera));
							UnityEngine.Object obj9 = UnityEngine.Object.FindObjectOfType(typeFromHandle2);
							bool flag8 = (object)obj9 == null;
							UnityEngine.Object obj10 = null;
							if (!flag8)
							{
								bool flag9 = (object)obj9.GetType() == typeof(Camera);
								obj10 = obj9;
								if (!flag9)
								{
									obj10 = null;
								}
							}
							camera = (Camera)obj10;
						}
						if (camera != null)
						{
							GameObject gameObject = camera.gameObject;
							AudioListener audioListener = gameObject.AddComponent<AudioListener>();
							mListener = audioListener;
						}
					}
				}
				bool flag10 = mListener != null;
				bool flag11 = !flag10;
				audioSource = null;
				if (!flag11)
				{
					bool enabled = mListener.enabled;
					bool flag12 = !enabled;
					audioSource = null;
					if (!flag12)
					{
						GameObject gameObject2 = mListener.gameObject;
						bool active = GetActive(gameObject2);
						bool flag13 = !active;
						audioSource = null;
						if (!flag13)
						{
							AudioSource component = mListener.GetComponent<AudioSource>();
							bool flag14 = component == null;
							bool flag15 = !flag14;
							audioSource = component;
							if (!flag15)
							{
								GameObject gameObject3 = mListener.gameObject;
								AudioSource audioSource2 = gameObject3.AddComponent<AudioSource>();
								audioSource = audioSource2;
							}
							audioSource.priority = 50;
							audioSource.pitch = pitch;
							audioSource.PlayOneShot(clip, num3);
						}
					}
				}
			}
		}
		goto IL_0445;
		IL_0445:
		return audioSource;
	}

	public static int RandomRange(int min, int max)
	{
		if (min != max)
		{
			int maxExclusive = max + 1;
			return UnityEngine.Random.Range(min, maxExclusive);
		}
		return min;
	}

	public static string GetHierarchy(GameObject obj)
	{
		GameObject gameObject = default;
		if (gameObject == null)
		{
			return string.Empty;
		}
		string name = gameObject.name;
		string text = name;
		GameObject gameObject2 = default;
		while (true)
		{
			Transform transform = gameObject2.transform;
			Transform parent = transform.parent;
			if (!(parent != null))
			{
				break;
			}
			Transform transform2 = gameObject2.transform;
			Transform parent2 = transform2.parent;
			gameObject2 = parent2.gameObject;
			string name2 = gameObject2.name;
			string text2 = name2 + "\\" + text;
			text = text2;
		}
		return text;
	}

	public static T[] FindActive<T>() where T : Component
	{
		//IL_003f: Expected VT, but got I
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		T[] result = default;
		return result;
	}

	public static Camera FindCameraForLayer(int layer)
	{
		//IL_024d: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_0181: Expected Obj, but got I
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_01b4: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I
		//IL_0203: Expected Obj, but got I
		int num = 1 << layer;
		object obj = 0;
		Camera result;
		Camera[] array = default;
		while (true)
		{
			BetterList<UICamera> list = UICamera.list;
			if ((nint)obj < list.size)
			{
				BetterList<UICamera> list2 = UICamera.list;
				object obj2 = obj << 2;
				object obj3 = (object)list2.buffer + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v60+10]");
				Camera cachedCamera = ((UICamera)0).cachedCamera;
				if ((bool)cachedCamera)
				{
					int cullingMask = cachedCamera.cullingMask;
					int num2 = cullingMask & num;
					result = cachedCamera;
					if (num2 != 0)
					{
						break;
					}
				}
				object obj4 = obj + 1;
				obj = obj4;
				continue;
			}
			Camera main = Camera.main;
			if ((bool)main)
			{
				int cullingMask2 = main.cullingMask;
				int num3 = cullingMask2 & num;
				result = main;
				if (num3 != 0)
				{
					break;
				}
			}
			int allCamerasCount = Camera.GetAllCamerasCount();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			int allCameras = Camera.GetAllCameras(array);
			object obj5 = 0;
			while (true)
			{
				if ((nint)obj5 < allCameras)
				{
					object obj6 = obj5 << 2;
					object obj7 = (object)array + obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v34+10]");
					if ((bool)(UnityEngine.Object)0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v34+10]");
						if (((Behaviour)0).enabled)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v34+10]");
							int cullingMask3 = ((Camera)0).cullingMask;
							int num4 = cullingMask3 & num;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v34+10]");
							result = (Camera)0;
							if (num4 != 0)
							{
								break;
							}
						}
					}
					object obj8 = obj5 + 1;
					obj5 = obj8;
					continue;
				}
				result = null;
				break;
			}
			break;
		}
		return result;
	}

	public static void AddWidgetCollider(GameObject go)
	{
		AddWidgetCollider(go, considerInactive: false);
	}

	public static void AddWidgetCollider(GameObject go, bool considerInactive)
	{
		//IL_0125: Expected Obj, but got I4
		GameObject gameObject = default;
		if (!(gameObject != null))
		{
			return;
		}
		Collider component = gameObject.GetComponent<Collider>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		UnityEngine.Object obj = default;
		if (obj != null)
		{
			UpdateWidgetCollider((BoxCollider)obj, considerInactive);
			return;
		}
		if (!(component == null))
		{
			return;
		}
		BoxCollider2D component2 = gameObject.GetComponent<BoxCollider2D>();
		BoxCollider2D box;
		if (component2 != null)
		{
			box = component2;
			goto IL_0216;
		}
		int layer = gameObject.layer;
		UICamera uICamera = UICamera.FindCameraForLayer(layer);
		if (uICamera != null)
		{
			object obj2 = uICamera.eventType & (UICamera.EventType)(-2);
			if ((nint)obj2 == 2)
			{
				BoxCollider2D boxCollider2D = gameObject.AddComponent<BoxCollider2D>();
				boxCollider2D.isTrigger = true;
				UIWidget component3 = gameObject.GetComponent<UIWidget>();
				if (component3 != null)
				{
					_ = 1;
				}
				box = boxCollider2D;
				goto IL_0216;
			}
		}
		BoxCollider boxCollider = gameObject.AddComponent<BoxCollider>();
		boxCollider.isTrigger = true;
		UIWidget component4 = gameObject.GetComponent<UIWidget>();
		if (component4 != null)
		{
			component4.autoResizeBoxCollider = true;
		}
		UpdateWidgetCollider(boxCollider, considerInactive);
		return;
		IL_0216:
		UpdateWidgetCollider(box, considerInactive);
	}

	public static void UpdateWidgetCollider(GameObject go)
	{
		UpdateWidgetCollider(go, considerInactive: false);
	}

	public static void UpdateWidgetCollider(GameObject go, bool considerInactive)
	{
		if (!(go != null))
		{
			return;
		}
		BoxCollider component = go.GetComponent<BoxCollider>();
		if (component != null)
		{
			UpdateWidgetCollider(component, considerInactive);
			return;
		}
		BoxCollider2D component2 = go.GetComponent<BoxCollider2D>();
		if (component2 != null)
		{
			UpdateWidgetCollider(component2, considerInactive);
		}
	}

	public unsafe static void UpdateWidgetCollider(BoxCollider box, bool considerInactive)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected VT, but got Unknown
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected VT, but got Unknown
		//IL_0549: Expected Ref, but got VT
		//IL_006c: Invalid comparison between VT and F4
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected VT, but got Unknown
		//IL_0569: Expected Ref, but got VT
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected VT, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_010e: Expected I, but got Obj
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0143: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected VT, but got Unknown
		//IL_01e7: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected VT, but got Unknown
		//IL_0094: Invalid comparison between I and F4
		//IL_00bc: Invalid comparison between I and F4
		//IL_00e4: Invalid comparison between I and F4
		//IL_0248: Expected I, but got Obj
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_02b1: Expected Obj, but got I
		//IL_02f5: Expected Obj, but got I
		//IL_0339: Expected Obj, but got I
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected VT, but got Unknown
		//IL_03f5: Expected Obj, but got I
		//IL_0412: Expected Obj, but got I
		//IL_042f: Expected Obj, but got I
		//IL_0449: Expected F4, but got I
		//IL_0444: Expected native int or pointer, but got VT
		//IL_0468: Expected F4, but got I
		//IL_0463: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 288);
		_ = 0;
		_ = 0;
		_ = 0;
		if (!(box != null))
		{
			return;
		}
		GameObject gameObject = box.gameObject;
		UIWidget component = gameObject.GetComponent<UIWidget>();
		if (component != null)
		{
			if (component.mDrawRegion == (Vector4)(object)0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v20 (UIWidget)+98]");
				if (0f == 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v20 (UIWidget)+9C]");
					if (0f == 1f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v20 (UIWidget)+A0]");
						if (0f == 1f)
						{
							nint num = (nint)component;
							object obj2 = component + 72;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v228 @ S2_v27 (Il2CppClass<UIWidget>)+104] (should have been resolved before IL gen)");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v80+18]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v80+10]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v80+30]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v80+28]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
							nint num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
							object obj3 = num2 - 0;
							float num3 = (float)obj3 * 0.5f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
							float num4 = 0f + num3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+DC]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
							object obj4 = num5 - 0;
							float num6 = (float)obj4 * 0.5f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
							float num7 = 0f + num6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
							nint num8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
							object obj5 = num8 - 0;
							float num9 = (float)obj5 * 0.5f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
							float num10 = 0f + num9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
							_ = 0;
							Vector3 center = vector + 16;
							box.center = center;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v80+30]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v80+28]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v80+18]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v80+10]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
							nint num11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
							object obj6 = num11 - 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+BC]");
							nint num12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+AC]");
							object obj7 = num12 - 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
							nint num13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
							object obj8 = num13 - 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
							((Vector3*)(nint)vector)->z = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
							((Vector3*)(nint)vector)->x = 0f;
							box.size = vector;
							return;
						}
					}
				}
			}
			object obj9 = vector + 128;
			nint num14 = (nint)component;
			object obj10 = component + 184;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v128 @ S2_v15 (Il2CppClass<UIWidget>)+174] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			object obj11 = num15 + 0;
			float num16 = (float)obj11 * 0.5f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+8C]");
			object obj12 = num17 + 0;
			float num18 = (float)obj12 * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
			_ = 0;
			Vector3 center2 = vector + 48;
			box.center = center2;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+8C]");
			nint num19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
			object obj13 = num19 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			nint num20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			object obj14 = num20 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
			_ = 0;
			Vector3 size = vector + 32;
			box.size = size;
		}
		else
		{
			Transform transform = gameObject.transform;
			Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds(transform, considerInactive);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+108]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+110]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			_ = 0;
			Vector3 center3 = vector + 80;
			box.center = center3;
			Bounds bounds2 = (Bounds)(vector + 264);
			Vector3 size2 = ((Bounds*)bounds2)->size;
			Bounds bounds3 = (Bounds)(vector + 264);
			Vector3 size3 = ((Bounds*)bounds3)->size;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Vector3 size4 = vector - -64;
			box.size = size4;
		}
	}

	public unsafe static void UpdateWidgetCollider(BoxCollider2D box, bool considerInactive)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected VT, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected VT, but got Unknown
		//IL_02e2: Expected Ref, but got VT
		//IL_0066: Expected I, but got Obj
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_00cf: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_0148: Expected Obj, but got F4
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected VT, but got Unknown
		//IL_01cb: Expected Obj, but got I
		//IL_01e8: Expected Obj, but got I
		//IL_0203: Expected F4, but got Obj
		//IL_020b: Expected native int or pointer, but got VT
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected VT, but got Unknown
		//IL_0302: Expected Ref, but got VT
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected VT, but got Unknown
		object obj = default;
		Vector2 vector = (Vector2)(obj - 160);
		_ = 0;
		_ = 0;
		_ = 0;
		if (box != null)
		{
			GameObject gameObject = box.gameObject;
			UIWidget component = gameObject.GetComponent<UIWidget>();
			if (component != null)
			{
				nint num = (nint)component;
				object obj2 = component + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S2_v16 (Il2CppClass<UIWidget>)+104] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v46+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v46+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v46+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v46+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+78]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
				object obj3 = num2 - 0;
				float num3 = (float)obj3 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
				float num4 = 0f + num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+7C]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+34]");
				object obj4 = num5 - 0;
				float num6 = (float)obj4 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+34]");
				float num7 = 0f + num6;
				object obj5 = num7 << 32;
				object obj6 = num4 | obj5;
				Vector2 offset = vector + 8;
				box.offset = offset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v46+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v46+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v46+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v46+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+60]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+50]");
				object obj7 = num8 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+64]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+54]");
				object obj8 = num9 - 0;
				object obj9 = obj8 << 32;
				float x = obj7 | obj9;
				((Vector2*)(nint)vector)->x = x;
				box.size = vector;
			}
			else
			{
				Transform transform = gameObject.transform;
				Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds(transform, considerInactive);
				object obj10 = vector - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+90]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
				_ = 0;
				Vector2 offset2 = vector + 24;
				box.offset = offset2;
				Bounds bounds2 = (Bounds)(vector + 136);
				Vector3 size = ((Bounds*)bounds2)->size;
				Bounds bounds3 = (Bounds)(vector + 136);
				Vector3 size2 = ((Bounds*)bounds3)->size;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+34]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+20]");
				_ = 0;
				Vector2 size3 = vector + 16;
				box.size = size3;
			}
		}
	}

	public static string GetTypeName<T>()
	{
		//IL_009b: Expected VT, but got I
		//IL_00a7: Expected I, but got Obj
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		nint num2 = (nint)typeFromHandle;
		object obj = typeFromHandle + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S1_v4 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
		string text = default;
		bool flag = text.StartsWith("UI");
		bool flag2 = !flag;
		bool flag3 = !flag2;
		int startIndex = 2;
		string result;
		if (!flag3)
		{
			bool flag4 = text.StartsWith("UnityEngine.");
			bool flag5 = !flag4;
			startIndex = 12;
			result = text;
			if (flag5)
			{
				goto IL_00d6;
			}
		}
		string text2 = text.Substring(startIndex);
		result = text2;
		goto IL_00d6;
		IL_00d6:
		return result;
	}

	public static string GetTypeName(UnityEngine.Object obj)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		if (obj == null)
		{
			return "Null";
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		object obj3 = default;
		object obj2 = obj3;
		object obj4 = obj3 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S1_v4+D4] (should have been resolved before IL gen)");
		string text = default;
		if (text.StartsWith("UI"))
		{
			return text.Substring(2);
		}
		if (text.StartsWith("UnityEngine."))
		{
			return text.Substring(12);
		}
		return text;
	}

	public static void RegisterUndo(UnityEngine.Object obj, string name)
	{
	}

	public static void SetDirty(UnityEngine.Object obj)
	{
	}

	public static GameObject AddChild(GameObject parent)
	{
		return AddChild(parent, undo: false);
	}

	public unsafe static GameObject AddChild(GameObject parent, bool undo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_008c: Expected I, but got Obj
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected VT, but got Unknown
		//IL_00f7: Expected I, but got Obj
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected VT, but got Unknown
		//IL_0162: Expected I, but got Obj
		//IL_0187: Expected F4, but got I
		//IL_0182: Expected native int or pointer, but got VT
		//IL_0195: Expected F4, but got VT
		//IL_0190: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		GameObject gameObject = default;
		gameObject._002Ector();
		if (parent != null)
		{
			Transform transform = gameObject.transform;
			Transform transform2 = parent.transform;
			transform.parent = transform2;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v25 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v26 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			_ = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Vector3 localPosition = vector + 32;
			transform.localPosition = localPosition;
			nint num3 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v38 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v39 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			_ = Quaternion.identityQuaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Quaternion localRotation = (Quaternion)(vector + 16);
			transform.localRotation = localRotation;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v32 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v33 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
			transform.localScale = vector;
			int layer = parent.layer;
			gameObject.layer = layer;
		}
		return gameObject;
	}

	public unsafe static GameObject AddChild(GameObject parent, GameObject prefab)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00bc: Expected I, but got Obj
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected VT, but got Unknown
		//IL_0127: Expected I, but got Obj
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected VT, but got Unknown
		//IL_0192: Expected I, but got Obj
		//IL_01b7: Expected F4, but got I
		//IL_01b2: Expected native int or pointer, but got VT
		//IL_01c5: Expected F4, but got VT
		//IL_01c0: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		GameObject gameObject = UnityEngine.Object.Instantiate(prefab);
		if (gameObject != null && parent != null)
		{
			Transform transform = gameObject.transform;
			Transform transform2 = parent.transform;
			transform.parent = transform2;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v29 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v30 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			_ = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Vector3 localPosition = vector + 32;
			transform.localPosition = localPosition;
			nint num3 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v42 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v43 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			_ = Quaternion.identityQuaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Quaternion localRotation = (Quaternion)(vector + 16);
			transform.localRotation = localRotation;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v34 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v35 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
			transform.localScale = vector;
			int layer = parent.layer;
			gameObject.layer = layer;
		}
		return gameObject;
	}

	public static int CalculateRaycastDepth(GameObject go)
	{
		//IL_0085: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I
		UIWidget component = go.GetComponent<UIWidget>();
		if (component != null)
		{
			return component.raycastDepth;
		}
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v13+C]");
		if ((nint)0 != 0)
		{
			int num3 = int.MaxValue;
			object obj = 0;
			object obj5 = default;
			while (true)
			{
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v13+C]");
				if ((nint)obj2 >= 0)
				{
					break;
				}
				object obj3 = obj << 2;
				object obj4 = obj5 + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v23+10]");
				if (((Behaviour)0).enabled)
				{
					object obj6 = obj << 2;
					object obj7 = obj5 + obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v15+10]");
					int raycastDepth = ((UIWidget)0).raycastDepth;
					bool flag = num3 < raycastDepth;
					int num4 = num3;
					if (!flag)
					{
						num4 = raycastDepth;
					}
					num3 = num4;
				}
				object obj8 = obj + 1;
				obj = obj8;
			}
			return num3;
		}
		return 0;
	}

	public static int CalculateNextDepth(GameObject go)
	{
		//IL_002c: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected I4, but got Unknown
		//IL_0065: Expected Obj, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_00a1: Expected Obj, but got I
		if ((bool)go)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S3_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
			object obj = -1;
			object obj2 = 0;
			object obj6 = default;
			while (true)
			{
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13+C]");
				if ((nint)obj3 >= 0)
				{
					break;
				}
				object obj4 = obj2 << 2;
				object obj5 = obj6 + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v9+10]");
				object obj7 = 0;
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v10+68]");
				bool flag = (nint)obj8 > 0;
				object obj9 = obj;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v10+68]");
					obj9 = 0;
				}
				object obj10 = obj2 + 1;
				obj = obj9;
				obj2 = obj10;
			}
			return obj + 1;
		}
		return 0;
	}

	public static int CalculateNextDepth(GameObject go, bool ignoreChildrenWithColliders)
	{
		//IL_0045: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected I4, but got Unknown
		//IL_007e: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_016a: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I
		if ((bool)go && ignoreChildrenWithColliders)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
			object obj = -1;
			object obj2 = 0;
			object obj6 = default;
			while (true)
			{
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+C]");
				if ((nint)obj3 >= 0)
				{
					break;
				}
				object obj4 = obj2 << 2;
				object obj5 = obj6 + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v28+10]");
				UIRect uIRect = (UIRect)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v28+10]");
				GameObject cachedGameObject = ((UIRect)0).cachedGameObject;
				if (cachedGameObject != go)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v28+10]");
					Collider component = ((Component)0).GetComponent<Collider>();
					if (!(component == null))
					{
						goto IL_01bf;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v28+10]");
					Collider2D component2 = ((Component)0).GetComponent<Collider2D>();
					if (component2 != null)
					{
						goto IL_01bf;
					}
				}
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v29 (UIRect)+68]");
				bool flag = (nint)obj7 > 0;
				object obj8 = obj;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v29 (UIRect)+68]");
					obj8 = 0;
				}
				obj = obj8;
				goto IL_01bf;
				IL_01bf:
				object obj9 = obj2 + 1;
				obj2 = obj9;
			}
			return obj + 1;
		}
		return CalculateNextDepth(go);
	}

	public static int AdjustDepth(GameObject go, int adjustment)
	{
		//IL_0059: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_0133: Expected Obj, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		bool flag = go != null;
		bool flag2 = !flag;
		int result = 0;
		if (!flag2)
		{
			UIPanel component = go.GetComponent<UIPanel>();
			if (component != null)
			{
				UIPanel[] componentsInChildren = go.GetComponentsInChildren<UIPanel>(includeInactive: true);
				object obj = 0;
				while (true)
				{
					bool flag3 = (nint)obj >= componentsInChildren.Length;
					result = 1;
					if (flag3)
					{
						break;
					}
					object obj2 = obj << 2;
					object obj3 = (object)componentsInChildren + obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v56+10]");
					UIPanel uIPanel = (UIPanel)0;
					int depth = adjustment + uIPanel.mDepth;
					uIPanel.depth = depth;
					object obj4 = obj + 1;
					obj = obj4;
				}
			}
			else
			{
				UIPanel uIPanel2 = FindInParents<UIPanel>(go);
				bool flag4 = uIPanel2 != null;
				result = 0;
				if (flag4)
				{
					UIWidget[] componentsInChildren2 = go.GetComponentsInChildren<UIWidget>(includeInactive: true);
					object obj5 = 0;
					while ((nint)obj5 < componentsInChildren2.Length)
					{
						object obj6 = obj5 << 2;
						object obj7 = (object)componentsInChildren2 + obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v36+10]");
						UIWidget uIWidget = (UIWidget)0;
						if (!(uIWidget.panel != uIPanel2))
						{
							int depth2 = adjustment + uIWidget.mDepth;
							uIWidget.depth = depth2;
						}
						object obj8 = obj5 + 1;
						obj5 = obj8;
					}
					result = 2;
				}
			}
		}
		return result;
	}

	public static void BringForward(GameObject go)
	{
		//IL_005d: Expected Obj, but got I4
		int num = AdjustDepth(go, 1000);
		object obj = num - 1;
		if (num != 1)
		{
			if ((nint)obj == 1)
			{
				NormalizeWidgetDepths();
			}
		}
		else
		{
			NormalizePanelDepths();
		}
	}

	public static void PushBack(GameObject go)
	{
		//IL_005d: Expected Obj, but got I4
		int num = AdjustDepth(go, -1000);
		object obj = num - 1;
		if (num != 1)
		{
			if ((nint)obj == 1)
			{
				NormalizeWidgetDepths();
			}
		}
		else
		{
			NormalizePanelDepths();
		}
	}

	public static void NormalizeDepths()
	{
		NormalizeWidgetDepths();
		NormalizePanelDepths();
	}

	public static void NormalizeWidgetDepths()
	{
		_0021_00210[] list = (_0021_00210[])(object)NGUITools.FindActive<T>();
		NormalizeWidgetDepths((UIWidget[])(object)list);
	}

	public static void NormalizeWidgetDepths(GameObject go)
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		UIWidget[] list = default;
		NormalizeWidgetDepths(list);
	}

	public static void NormalizeWidgetDepths(UIWidget[] list)
	{
		if (list.Length >= 1)
		{
			throw new ArgumentException();
		}
	}

	public static void NormalizePanelDepths()
	{
		_0021_00210[] array = (_0021_00210[])(object)NGUITools.FindActive<T>();
		if (array.Length >= 1)
		{
			throw new ArgumentException();
		}
	}

	public static UIPanel CreateUI(bool advanced3D)
	{
		return CreateUI(null, advanced3D, -1);
	}

	public static UIPanel CreateUI(bool advanced3D, int layer)
	{
		return CreateUI(null, advanced3D, layer);
	}

	public static UIPanel CreateUI(Transform trans, bool advanced3D, int layer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_0a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a96: Expected Obj, but got Unknown
		//IL_03c9: Expected I4, but got Obj
		//IL_04d7: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I
		//IL_060b: Expected Obj, but got I4
		//IL_0619: Expected Obj, but got I4
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected I4, but got Unknown
		//IL_0646: Expected Obj, but got I4
		//IL_064f: Expected Obj, but got I4
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_0747: Expected VT, but got Obj
		//IL_0750: Expected Obj, but got VT
		//IL_0680: Expected Obj, but got I
		//IL_03a3: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected Obj, but got Unknown
		//IL_06ed: Expected Obj, but got I4
		//IL_0d6f: Expected I, but got Obj
		//IL_0d9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da0: Expected VT, but got Unknown
		//IL_0d0c: Expected Obj, but got VT
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d42: Expected VT, but got Unknown
		//IL_0d4f: Expected Obj, but got VT
		//IL_0d5c: Expected Obj, but got VT
		//IL_0c9c: Expected Obj, but got I
		//IL_0cb1: Expected Obj, but got I
		//IL_0cd7: Expected Obj, but got I
		//IL_06c0: Expected Obj, but got I
		//IL_0b55: Expected I, but got Obj
		//IL_0b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected VT, but got Unknown
		//IL_0dc0: Expected I, but got Obj
		//IL_0e06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0b: Expected VT, but got Unknown
		//IL_07b6: Expected Obj, but got VT
		//IL_0204: Expected Obj, but got I
		//IL_0214: Expected Obj, but got I
		//IL_0859: Expected Obj, but got VT
		//IL_0867: Expected Obj, but got VT
		//IL_0ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Expected Obj, but got Unknown
		//IL_087a: Expected Obj, but got VT
		//IL_0888: Expected Obj, but got VT
		//IL_07dd: Expected Obj, but got VT
		//IL_07eb: Expected Obj, but got VT
		//IL_07f9: Expected Obj, but got VT
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected Obj, but got Unknown
		//IL_081a: Expected Obj, but got I4
		//IL_082f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected VT, but got Unknown
		//IL_08d1: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 - 176;
		_ = 0;
		_ = 0;
		Transform transform = default;
		UIRoot uIRoot = default;
		if (transform != null)
		{
			GameObject gameObject = transform.gameObject;
			uIRoot = FindInParents<UIRoot>(gameObject);
			GameObject gameObject2 = gameObject;
		}
		UnityEngine.Object obj7;
		int num = default;
		if (uIRoot == null)
		{
			List<UIRoot> list = UIRoot.list;
			if (list._size >= 1)
			{
				object obj3 = obj + 144;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				_ = 0;
				object obj4 = obj + 160;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
				_ = 0;
				object obj6 = default;
				object obj8 = default;
				object obj9 = default;
				object obj10 = default;
				GameObject gameObject3 = default;
				GameObject gameObject4 = default;
				while (true)
				{
					_ = 0;
					object obj5 = obj + 160;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					GameObject gameObject2;
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						if (obj6 == null)
						{
							obj7 = uIRoot;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							gameObject2 = (GameObject)0;
							goto IL_02ed;
						}
						_ = 0;
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
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (num != (nint)obj8)
									{
										continue;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+AC]");
									obj7 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									gameObject2 = (GameObject)0;
									goto IL_02ed;
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
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					bool flag = obj9 != obj10;
					gameObject2 = gameObject3;
					if (!flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag2 = (nint)0 == 1;
						obj7 = uIRoot;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						gameObject2 = (GameObject)0;
						if (!flag2)
						{
							goto IL_02ed;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						gameObject2 = gameObject4;
					}
					_ = 0;
					object obj11 = obj + 144;
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					transform = (Transform)0;
					goto IL_0a75;
					IL_02ed:
					object obj12 = obj + 144;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A341");
					break;
				}
				goto IL_0ad6;
			}
		}
		goto IL_0a75;
		IL_0a16:
		UIPanel uIPanel;
		return uIPanel;
		IL_0a75:
		obj7 = uIRoot;
		goto IL_0ad6;
		IL_0ad6:
		UIPanel uIPanel2;
		if (obj7 == null)
		{
			List<UIPanel> list2 = UIPanel.list;
			GameObject gameObject6;
			for (GameObject gameObject2 = null; (nint)gameObject2 < list2._size; gameObject6 = (GameObject)(gameObject2 + 1), gameObject2 = gameObject6)
			{
				uIPanel2 = UIPanel.list.get_Item((int)gameObject2);
				GameObject gameObject5 = uIPanel2.gameObject;
				if (gameObject5.hideFlags != HideFlags.None)
				{
					continue;
				}
				int layer2 = gameObject5.layer;
				if (layer2 != num)
				{
					continue;
				}
				goto IL_042b;
			}
		}
		if (obj7 != null)
		{
			UICamera componentInChildren = ((Component)obj7).GetComponentInChildren<UICamera>();
			bool flag3 = componentInChildren != null;
			bool flag4 = !flag3;
			GameObject gameObject2 = (GameObject)(object)componentInChildren;
			if (!flag4)
			{
				Camera component = componentInChildren.GetComponent<Camera>();
				bool orthographic = component.orthographic;
				GameObject gameObject7 = (GameObject)(orthographic ^ advanced3D);
				Transform transform2 = transform;
				if ((object)gameObject7 == null)
				{
					transform2 = null;
				}
				UnityEngine.Object obj13 = obj7;
				if ((object)gameObject7 == null)
				{
					obj13 = null;
				}
				transform = transform2;
				obj7 = obj13;
				gameObject2 = gameObject7;
			}
		}
		if (obj7 == null)
		{
			GameObject gameObject8 = AddChild(null, undo: false);
			UIRoot uIRoot2 = gameObject8.AddComponent<UIRoot>();
			if (num == -1)
			{
				int num2 = LayerMask.NameToLayer("UI");
				bool flag5 = num2 != -1;
				num = num2;
				if (!flag5)
				{
					int num3 = LayerMask.NameToLayer("2D UI");
					num = num3;
				}
			}
			gameObject8.layer = num;
			object name = "UI Root (3D)";
			if (!advanced3D)
			{
				name = "UI Root";
			}
			gameObject8.name = (string)name;
			obj7 = uIRoot2;
		}
		UIPanel componentInChildren2 = ((Component)obj7).GetComponentInChildren<UIPanel>();
		bool flag6 = componentInChildren2 == null;
		bool flag7 = !flag6;
		uIPanel = componentInChildren2;
		if (!flag7)
		{
			_0021_00210[] array = (_0021_00210[])(object)NGUITools.FindActive<T>();
			GameObject gameObject9 = ((Component)obj7).gameObject;
			int layer3 = gameObject9.layer;
			int num4 = -2 << layer3;
			object obj14 = 32 - layer3;
			object obj15 = -2 >> (int)obj14;
			int num5 = num4 | obj15;
			int cullingMask = 1 << layer3;
			float num6 = -1f;
			object obj16 = 0;
			object obj17 = 0;
			while (array.Length > (nint)obj17)
			{
				object obj18 = obj17 << 2;
				object obj19 = (object)array + obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S0_v164+10]");
				CameraClearFlags clearFlags = ((Camera)0).clearFlags;
				if (clearFlags != CameraClearFlags.Color)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S0_v164+10]");
					CameraClearFlags clearFlags2 = ((Camera)0).clearFlags;
					if (clearFlags2 != CameraClearFlags.Skybox)
					{
						goto IL_0c8b;
					}
				}
				obj16 = 1;
				goto IL_0c8b;
				IL_0c8b:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S0_v164+10]");
				float depth = ((Camera)0).depth;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S0_v164+10]");
				int cullingMask2 = ((Camera)0).cullingMask;
				int cullingMask3 = cullingMask2 & num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S0_v164+10]");
				((Camera)0).cullingMask = cullingMask3;
				bool flag8 = num6 > depth;
				float num7 = num6;
				if (!flag8)
				{
					num7 = depth;
				}
				object obj20 = obj17 + 1;
				num6 = num7;
				obj17 = obj20;
			}
			GameObject gameObject10 = ((Component)obj7).gameObject;
			_0021_00210 val = (_0021_00210)NGUITools.AddChild<T>(gameObject10, false);
			GameObject gameObject11 = ((Component)val).gameObject;
			UICamera uICamera = gameObject11.AddComponent<UICamera>();
			object obj21 = obj16 & 1;
			CameraClearFlags clearFlags3 = CameraClearFlags.Depth;
			if (obj21 == null)
			{
				clearFlags3 = CameraClearFlags.Color;
			}
			((Camera)val).clearFlags = clearFlags3;
			_ = 4575657222465388544L;
			_ = 4575657222465388544L;
			_ = 4539628425446424576L;
			_ = 4539628425446424576L;
			Color backgroundColor = (Color)(obj + 72);
			((Camera)val).backgroundColor = backgroundColor;
			((Camera)val).cullingMask = cullingMask;
			float depth2 = num6 + 1f;
			((Camera)val).depth = depth2;
			if (advanced3D)
			{
				((Camera)val).nearClipPlane = 0.1f;
				((Camera)val).farClipPlane = 4f;
				Transform transform3 = ((Component)val).transform;
				_ = -1003552768;
				object obj22 = obj - -64;
				obj22 = -1003552768;
				_ = 0;
				_ = 0;
				Vector3 localPosition = (Vector3)(obj + 56);
				transform3.localPosition = localPosition;
			}
			else
			{
				((Camera)val).orthographic = true;
				((Camera)val).orthographicSize = 1f;
				((Camera)val).nearClipPlane = -10f;
				((Camera)val).farClipPlane = 10f;
			}
			_0021_00210[] array2 = (_0021_00210[])(object)NGUITools.FindActive<T>();
			if (array2 == null || array2.Length == 0)
			{
				GameObject gameObject12 = ((Component)val).gameObject;
				AudioListener audioListener = gameObject12.AddComponent<AudioListener>();
			}
			GameObject gameObject13 = ((Component)obj7).gameObject;
			UIPanel uIPanel3 = gameObject13.AddComponent<UIPanel>();
			uIPanel = uIPanel3;
		}
		if (transform != null)
		{
			while (true)
			{
				Transform parent = transform.parent;
				if (!(parent != null))
				{
					break;
				}
				Transform parent2 = transform.parent;
				transform = parent2;
			}
			Transform transform4 = uIPanel.transform;
			if (IsChild(transform, transform4))
			{
				GameObject gameObject14 = transform.gameObject;
				UIPanel uIPanel4 = gameObject14.AddComponent<UIPanel>();
				uIPanel = uIPanel4;
			}
			else
			{
				Transform transform5 = uIPanel.transform;
				transform.parent = transform5;
				nint num8 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ S1_v29 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ S1_v30 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
				_ = 0;
				_ = Vector3.oneVector;
				Vector3 localScale = (Vector3)(obj + 40);
				transform.localScale = localScale;
				nint num10 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ S0_v75 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ S0_v76 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
				_ = 0;
				_ = Vector3.zeroVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				_ = 0;
				Vector3 localPosition2 = (Vector3)(obj + 24);
				transform.localPosition = localPosition2;
				Transform cachedTransform = uIPanel.cachedTransform;
				GameObject cachedGameObject = uIPanel.cachedGameObject;
				int layer4 = cachedGameObject.layer;
				SetChildLayer(cachedTransform, layer4);
			}
		}
		goto IL_0a16;
		IL_042b:
		Transform transform6 = uIPanel2.transform;
		transform.parent = transform6;
		nint num12 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ S1_v149 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ S1_v150 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		_ = 0;
		_ = Vector3.oneVector;
		Vector3 localScale2 = (Vector3)(obj + 8);
		transform.localScale = localScale2;
		uIPanel = uIPanel2;
		goto IL_0a16;
	}

	public static void SetChildLayer(Transform t, int layer)
	{
		int num = 0;
		while (true)
		{
			int childCount = t.childCount;
			if (childCount > num)
			{
				Transform child = t.GetChild(num);
				GameObject gameObject = child.gameObject;
				gameObject.layer = layer;
				SetChildLayer(child, layer);
				int num2 = num + 1;
				num = num2;
				continue;
			}
			break;
		}
	}

	public static T AddChild<T>(GameObject parent) where T : Component
	{
		//IL_0021: Expected Obj, but got I
		GameObject gameObject = AddChild(parent);
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<NGUITools::AddChild>>)+4] (should have been resolved before IL gen)");
		string name = default;
		gameObject.name = name;
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S2_v7 (Il2CppMethodRgctx<NGUITools::AddChild>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S2_v8+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public static T AddChild<T>(GameObject parent, bool undo) where T : Component
	{
		//IL_0021: Expected Obj, but got I
		GameObject gameObject = AddChild(parent, undo);
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S2_v4 (Il2CppClass<Il2CppMethodRgctx<NGUITools::AddChild>>)+4] (should have been resolved before IL gen)");
		string name = default;
		gameObject.name = name;
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v8 (Il2CppMethodRgctx<NGUITools::AddChild>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S2_v9+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public static T AddWidget<T>(GameObject go) where T : UIWidget
	{
		int depth = CalculateNextDepth(go);
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<NGUITools::AddWidget>>)+4] (should have been resolved before IL gen)");
		UIWidget uIWidget = default;
		uIWidget.width = 100;
		uIWidget.height = 100;
		uIWidget.depth = depth;
		return (T)uIWidget;
	}

	public static T AddWidget<T>(GameObject go, int depth) where T : UIWidget
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<NGUITools::AddWidget>>)+4] (should have been resolved before IL gen)");
		UIWidget uIWidget = default;
		uIWidget.width = 100;
		uIWidget.height = 100;
		uIWidget.depth = depth;
		return (T)uIWidget;
	}

	public static UISprite AddSprite(GameObject go, UIAtlas atlas, string spriteName)
	{
		//IL_00e1: Expected I, but got Obj
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		bool flag = atlas != null;
		bool flag2 = !flag;
		UISpriteData uISpriteData = null;
		if (!flag2)
		{
			UISpriteData sprite = atlas.GetSprite(spriteName);
			uISpriteData = sprite;
		}
		UISprite uISprite = AddWidget<UISprite>(go);
		if (uISpriteData != null)
		{
			int num = uISpriteData.borderRight | uISpriteData.borderLeft;
			int num2 = uISpriteData.borderTop | num;
			int num3 = uISpriteData.borderBottom | num2;
			bool flag3 = num3 != 0;
		}
		else
		{
			bool flag3 = false;
		}
		nint num4 = (nint)uISprite;
		object obj = uISprite + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v64 @ S2_v5 (Il2CppClass<UISprite>)+1FC] (should have been resolved before IL gen)");
		uISprite.atlas = atlas;
		uISprite.spriteName = spriteName;
		return uISprite;
	}

	public static GameObject GetRoot(GameObject go)
	{
		Transform transform = go.transform;
		Transform transform2 = transform;
		Transform parent;
		bool flag2;
		do
		{
			parent = transform2.parent;
			bool flag = parent == null;
			flag2 = !flag;
			transform2 = parent;
		}
		while (flag2);
		return parent.gameObject;
	}

	public static T FindInParents<T>(GameObject go) where T : Component
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_003b: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		UnityEngine.Object obj4;
		if (go == null)
		{
			object obj3 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			obj4 = (UnityEngine.Object)0;
		}
		else
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S2_v5 (Il2CppClass<Il2CppMethodRgctx<NGUITools::FindInParents>>)+4] (should have been resolved before IL gen)");
			UnityEngine.Object obj5 = default;
			bool flag = obj5 == null;
			bool flag2 = !flag;
			obj4 = obj5;
			if (!flag2)
			{
				Transform transform = go.transform;
				Transform transform2 = transform;
				obj4 = obj5;
				UnityEngine.Object obj6 = default;
				while (true)
				{
					Transform parent = transform2.parent;
					if (!(parent != null) || !(obj4 == null))
					{
						break;
					}
					GameObject gameObject = parent.gameObject;
					nint num3 = 0;
					nint num4 = 0;
					IntPtr intPtr2 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ S2_v13 (Il2CppClass<Il2CppMethodRgctx<NGUITools::FindInParents>>)+4] (should have been resolved before IL gen)");
					transform2 = parent;
					obj4 = obj6;
				}
			}
		}
		return (T)obj4;
	}

	public static T FindInParents<T>(Transform trans) where T : Component
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_003b: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (trans == null)
		{
			object obj3 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			return (T)0;
		}
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S2_v5 (Il2CppClass<Il2CppMethodRgctx<NGUITools::FindInParents>>)+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public static void Destroy(UnityEngine.Object obj)
	{
		if (!obj)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		object obj2 = default;
		GameObject obj3;
		Component component2;
		GameObject obj4;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			Component component = default;
			GameObject gameObject = component.gameObject;
			bool isPlaying = Application.isPlaying;
			obj3 = gameObject;
			component2 = component;
			if (isPlaying)
			{
				goto IL_017f;
			}
			obj4 = gameObject;
		}
		else
		{
			bool flag = (object)obj == null;
			UnityEngine.Object obj5 = null;
			if (!flag)
			{
				bool flag2 = (object)obj.GetType() == typeof(GameObject);
				obj5 = obj;
				if (!flag2)
				{
					obj5 = null;
				}
			}
			if ((object)obj5 == null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(obj);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(obj);
				}
				return;
			}
			bool flag3 = (object)obj == null;
			GameObject gameObject2 = null;
			if (!flag3)
			{
				bool flag4 = (object)obj.GetType() == typeof(GameObject);
				gameObject2 = (GameObject)obj;
				if (!flag4)
				{
					gameObject2 = null;
				}
			}
			Transform transform = gameObject2.transform;
			bool isPlaying2 = Application.isPlaying;
			obj3 = gameObject2;
			component2 = transform;
			if (isPlaying2)
			{
				goto IL_017f;
			}
			obj4 = gameObject2;
		}
		UnityEngine.Object.DestroyImmediate(obj4);
		return;
		IL_017f:
		((Transform)component2).parent = null;
		UnityEngine.Object.Destroy(obj3);
	}

	public static void DestroyChildren(Transform t)
	{
		bool isPlaying = Application.isPlaying;
		while (t.childCount != 0)
		{
			Transform child = t.GetChild(0);
			if (isPlaying)
			{
				child.parent = null;
				GameObject gameObject = child.gameObject;
				UnityEngine.Object.Destroy(gameObject);
			}
			else
			{
				GameObject gameObject2 = child.gameObject;
				UnityEngine.Object.DestroyImmediate(gameObject2);
			}
		}
	}

	public static void DestroyImmediate(UnityEngine.Object obj)
	{
		if (obj != null)
		{
			UnityEngine.Object.Destroy(obj);
		}
	}

	public static void Broadcast(string funcName)
	{
		//IL_008f: Expected VT, but got Obj
		//IL_002a: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(GameObject));
		UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj = 0;
		object obj5 = default;
		while (true)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15+C]");
			if ((nint)obj2 < 0)
			{
				object obj3 = obj << 2;
				object obj4 = obj5 + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v22+10]");
				((GameObject)0).SendMessage(funcName, SendMessageOptions.DontRequireReceiver);
				object obj6 = obj + 1;
				obj = obj6;
				continue;
			}
			break;
		}
	}

	public static void Broadcast(string funcName, object param)
	{
		//IL_0093: Expected VT, but got Obj
		//IL_002a: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(GameObject));
		UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj = 0;
		object obj5 = default;
		while (true)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15+C]");
			if ((nint)obj2 < 0)
			{
				object obj3 = obj << 2;
				object obj4 = obj5 + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v22+10]");
				((GameObject)0).SendMessage(funcName, param, SendMessageOptions.DontRequireReceiver);
				object obj6 = obj + 1;
				obj = obj6;
				continue;
			}
			break;
		}
	}

	public static bool IsChild(Transform parent, Transform child)
	{
		bool flag = parent != null;
		bool result = false;
		if (flag)
		{
			Transform transform = default;
			bool flag2 = transform != null;
			result = false;
			if (flag2)
			{
				Transform parent2 = default;
				while (true)
				{
					bool flag3 = parent2 != null;
					bool flag4 = !flag3;
					result = flag3;
					if (flag4)
					{
						break;
					}
					bool flag5 = parent2 != parent;
					result = flag3;
					if (!flag5)
					{
						break;
					}
					parent2 = transform.parent;
				}
			}
		}
		return result;
	}

	private static void Activate(Transform t)
	{
		Activate(t, compatibilityMode: false);
	}

	private static void Activate(Transform t, bool compatibilityMode)
	{
		GameObject gameObject = t.gameObject;
		SetActiveSelf(gameObject, state: true);
		if (!compatibilityMode)
		{
			return;
		}
		int childCount = t.childCount;
		int num = 0;
		while (true)
		{
			if (num < childCount)
			{
				Transform child = t.GetChild(num);
				GameObject gameObject2 = child.gameObject;
				if (!gameObject2.activeSelf)
				{
					int num2 = num + 1;
					num = num2;
					continue;
				}
				break;
			}
			int childCount2 = t.childCount;
			int num3 = 0;
			while (num3 < childCount2)
			{
				Transform child2 = t.GetChild(num3);
				Activate(child2, compatibilityMode: true);
				int num4 = num3 + 1;
				num3 = num4;
			}
			break;
		}
	}

	private static void Deactivate(Transform t)
	{
		GameObject gameObject = t.gameObject;
		SetActiveSelf(gameObject, state: false);
	}

	public static void SetActive(GameObject go, bool state)
	{
		SetActive(go, state, compatibilityMode: true);
	}

	public static void SetActive(GameObject go, bool state, bool compatibilityMode)
	{
		if ((bool)go)
		{
			Transform transform = go.transform;
			if (state)
			{
				Activate(transform, compatibilityMode);
				Transform transform2 = go.transform;
				CallCreatePanel(transform2);
			}
			else
			{
				Deactivate(transform);
			}
		}
	}

	private static void CallCreatePanel(Transform t)
	{
		UIWidget component = t.GetComponent<UIWidget>();
		if (component != null)
		{
			UIPanel uIPanel = component.CreatePanel();
		}
		int childCount = t.childCount;
		int num = 0;
		while (num < childCount)
		{
			Transform child = t.GetChild(num);
			CallCreatePanel(child);
			int num2 = num + 1;
			num = num2;
		}
	}

	public static void SetActiveChildren(GameObject go, bool state)
	{
		Transform transform = go.transform;
		int childCount = transform.childCount;
		bool flag = !state;
		int num = 0;
		int num2 = 0;
		if (!flag)
		{
			while (num < childCount)
			{
				Transform child = transform.GetChild(num);
				Activate(child);
				int num3 = num + 1;
				num = num3;
			}
		}
		else
		{
			while (num2 < childCount)
			{
				Transform child2 = transform.GetChild(num2);
				Deactivate(child2);
				int num4 = num2 + 1;
				num2 = num4;
			}
		}
	}

	public static bool IsActive(Behaviour mb)
	{
		bool flag = mb != null;
		bool flag2 = !flag;
		bool result = false;
		if (!flag2)
		{
			bool enabled = mb.enabled;
			bool flag3 = !enabled;
			result = false;
			if (!flag3)
			{
				GameObject gameObject = mb.gameObject;
				bool activeInHierarchy = gameObject.activeInHierarchy;
				result = activeInHierarchy;
			}
		}
		return result;
	}

	public static bool GetActive(Behaviour mb)
	{
		bool flag = mb;
		bool flag2 = !flag;
		bool result = false;
		if (!flag2)
		{
			bool enabled = mb.enabled;
			bool flag3 = !enabled;
			result = false;
			if (!flag3)
			{
				GameObject gameObject = mb.gameObject;
				bool activeInHierarchy = gameObject.activeInHierarchy;
				result = activeInHierarchy;
			}
		}
		return result;
	}

	public static bool GetActive(GameObject go)
	{
		if ((bool)go)
		{
			return go.activeInHierarchy;
		}
		return false;
	}

	public static void SetActiveSelf(GameObject go, bool state)
	{
		go.SetActive(state);
	}

	public static void SetLayer(GameObject go, int layer)
	{
		go.layer = layer;
		Transform transform = go.transform;
		int childCount = transform.childCount;
		int num = 0;
		while (num < childCount)
		{
			Transform child = transform.GetChild(num);
			GameObject gameObject = child.gameObject;
			SetLayer(gameObject, layer);
			int num2 = num + 1;
			num = num2;
		}
	}

	public unsafe static Vector3 Round(Vector3 v)
	{
		//IL_0012: Expected native int or pointer, but got VT
		//IL_002e: Expected native int or pointer, but got VT
		//IL_0045: Expected native int or pointer, but got VT
		//IL_0057: Expected native int or pointer, but got VT
		//IL_0069: Expected native int or pointer, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float x = default;
		((Vector3*)(nint)v)->x = x;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float y = default;
		((Vector3*)(nint)v)->y = y;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float z = default;
		((Vector3*)(nint)v)->z = z;
		Vector3 vector = default;
		((Vector3*)(nint)vector)->x = v.x;
		((Vector3*)(nint)vector)->z = v.z;
		return vector;
	}

	public unsafe static void MakePixelPerfect(Transform t)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0034: Expected I, but got Obj
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected VT, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected VT, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected VT, but got Unknown
		//IL_01bd: Expected F4, but got I
		//IL_01b8: Expected native int or pointer, but got VT
		//IL_01d2: Expected F4, but got I
		//IL_01cd: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 144);
		UIWidget component = t.GetComponent<UIWidget>();
		if (component != null)
		{
			nint num = (nint)component;
			object obj2 = component + 296;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S1_v58 (Il2CppClass<UIWidget>)+1E4] (should have been resolved before IL gen)");
		}
		UIAnchor component2 = t.GetComponent<UIAnchor>();
		if (component2 == null)
		{
			UIRoot component3 = t.GetComponent<UIRoot>();
			if (component3 == null)
			{
				Vector3 localPosition = t.localPosition;
				object obj3 = vector + 120;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
				_ = 0;
				Vector3 v = vector + 48;
				Vector3 vector2 = Round(v);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				_ = 0;
				Vector3 localPosition2 = vector + 32;
				t.localPosition = localPosition2;
				Vector3 localScale = t.localScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Vector3 v2 = vector + 16;
				Vector3 vector3 = Round(v2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				((Vector3*)(nint)vector)->x = 0f;
				t.localScale = vector;
			}
		}
		int childCount = t.childCount;
		int num2 = 0;
		while (num2 < childCount)
		{
			Transform child = t.GetChild(num2);
			MakePixelPerfect(child);
			int num3 = num2 + 1;
			num2 = num3;
		}
	}

	public static bool Save(string fileName, byte[] bytes)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected Obj, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected Obj, but got Unknown
		//IL_0395: Expected Obj, but got I
		//IL_0226: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02cf: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		bool flag = fileAccess;
		bool flag2 = !flag;
		bool result = false;
		bool flag12 = default;
		if (!flag2)
		{
			string persistentDataPath = Application.persistentDataPath;
			string path = persistentDataPath + "/" + fileName;
			byte[] array = default;
			if (array == null)
			{
				bool flag3 = File.Exists(path);
				bool flag4 = !flag3;
				result = true;
				if (!flag4)
				{
					File.Delete(path);
					result = true;
				}
			}
			else
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 == 1;
				bool flag6 = !flag5;
				object obj5 = default;
				object obj4 = obj5;
				result = true;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					object obj6 = default;
					object obj7 = default;
					bool flag7 = obj6 == obj7;
					bool flag8 = !flag7;
					obj4 = obj5;
					bool flag9 = default;
					result = flag9;
					if (!flag8)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag10 = (nint)0 == 1;
						byte[] array2 = default;
						array = array2;
						if (!flag10)
						{
							object obj9 = default;
							object obj8 = obj9;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag11 = (nint)0 == 1;
							byte[] array3 = default;
							array = array3;
							if (!flag11)
							{
								if (array3 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
									object obj10 = (nint)0 << 2;
									object obj11 = obj3 + obj10;
									obj11 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
									object obj12 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
									object obj13 = (nint)0 << 2;
									object obj14 = obj13 + obj3;
									object obj15 = obj14 - 4;
									object obj16 = obj15;
									object obj17 = obj16;
									object obj18 = obj16 + 40;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v258 @ S1_v52+E4] (should have been resolved before IL gen)");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
									object obj19 = -1;
									result = false;
									goto IL_0428;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
								byte[] array4 = (byte[])obj9;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								flag12 = (nint)0 != 1;
								array = array4;
								if (flag12)
								{
									goto IL_03e3;
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag13 = (nint)0 == 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						obj4 = 0;
						bool flag14 = default;
						result = flag14;
						if (flag13)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
							goto IL_03e3;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				}
				object obj20 = obj4;
				object obj21 = obj4 + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v150 @ S4_v3+1CC] (should have been resolved before IL gen)");
				object obj22 = obj4;
				object obj23 = obj4 + 144;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v156 @ S1_v16+14C] (should have been resolved before IL gen)");
			}
		}
		goto IL_0428;
		IL_0428:
		return result;
		IL_03e3:
		return flag12;
	}

	public static byte[] Load(string fileName)
	{
		bool flag = fileAccess;
		bool flag2 = !flag;
		byte[] result = null;
		if (!flag2)
		{
			string persistentDataPath = Application.persistentDataPath;
			string path = persistentDataPath + "/" + fileName;
			bool flag3 = File.Exists(path);
			bool flag4 = !flag3;
			result = null;
			if (!flag4)
			{
				byte[] array = File.ReadAllBytes(path);
				result = array;
			}
		}
		return result;
	}

	public unsafe static Color ApplyPMA(Color c)
	{
		//IL_00b4: Expected native int or pointer, but got VT
		//IL_00c6: Expected native int or pointer, but got VT
		//IL_0051: Expected native int or pointer, but got VT
		//IL_0077: Expected native int or pointer, but got VT
		//IL_009d: Expected native int or pointer, but got VT
		if (c.a != 1f)
		{
			float r = c.r * c.a;
			((Color*)(nint)c)->r = r;
			float g = c.g * c.a;
			((Color*)(nint)c)->g = g;
			float b = c.b * c.a;
			((Color*)(nint)c)->b = b;
		}
		Color color = default;
		((Color*)(nint)color)->r = c.r;
		((Color*)(nint)color)->b = c.b;
		return color;
	}

	public static void MarkParentAsChanged(GameObject go)
	{
		//IL_0085: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		object obj = 0;
		object obj5 = default;
		while (true)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v7+C]");
			if ((nint)obj2 < 0)
			{
				object obj3 = obj << 2;
				object obj4 = obj5 + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v13+10]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ S1_v8+154] (should have been resolved before IL gen)");
				object obj8 = obj + 1;
				obj = obj8;
				continue;
			}
			break;
		}
	}

	public unsafe static string EncodeColor(Color c)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0020: Expected native int or pointer, but got VT
		//IL_0032: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 16);
		((Color*)(nint)color)->b = c.b;
		((Color*)(nint)color)->r = c.r;
		return NGUIText.EncodeColor24(color);
	}

	public unsafe static Color ParseColor(string text, int offset)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0039: Expected F4, but got I
		//IL_0034: Expected native int or pointer, but got VT
		//IL_0046: Expected F4, but got Obj
		//IL_0041: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Color color = NGUIText.ParseColor24(text, offset);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Color color2 = default;
		((Color*)(nint)color2)->b = 0f;
		((Color*)(nint)color2)->r = (float)obj;
		return color2;
	}

	public static string StripSymbols(string text)
	{
		return NGUIText.StripSymbols(text);
	}

	public static T AddMissingComponent<T>(GameObject go) where T : Component
	{
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<NGUITools::AddMissingComponent>>)+4] (should have been resolved before IL gen)");
		UnityEngine.Object obj = default;
		if (obj == null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v8 (Il2CppMethodRgctx<NGUITools::AddMissingComponent>)+8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S2_v9+4] (should have been resolved before IL gen)");
			T result = default;
			return result;
		}
		return (T)obj;
	}

	public static Vector3[] GetSides(Camera cam)
	{
		float nearClipPlane = cam.nearClipPlane;
		float farClipPlane = cam.farClipPlane;
		float num = farClipPlane - nearClipPlane;
		float num2 = num * 0.5f;
		float depth = nearClipPlane + num2;
		return GetSides(cam, depth, null);
	}

	public static Vector3[] GetSides(Camera cam, float depth)
	{
		return GetSides(cam, depth, null);
	}

	public static Vector3[] GetSides(Camera cam, Transform relativeTo)
	{
		float nearClipPlane = cam.nearClipPlane;
		float farClipPlane = cam.farClipPlane;
		float num = farClipPlane - nearClipPlane;
		float num2 = num * 0.5f;
		float depth = nearClipPlane + num2;
		return GetSides(cam, depth, relativeTo);
	}

	public static Vector3[] GetSides(Camera cam, float depth, Transform relativeTo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected VT, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected VT, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected VT, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected VT, but got Unknown
		//IL_0097: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I
		//IL_04f5: Expected Obj, but got I4
		//IL_0164: Expected F8, but got I4
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected Obj, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected VT, but got Unknown
		//IL_05a5: Expected Obj, but got I
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected Obj, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected Obj, but got Unknown
		//IL_01a3: Expected F8, but got I4
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected Obj, but got Unknown
		//IL_0a5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Expected VT, but got Unknown
		//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a70: Expected VT, but got Unknown
		//IL_0ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad5: Expected Obj, but got Unknown
		//IL_06cc: Expected Obj, but got I
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected VT, but got Unknown
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Expected VT, but got Unknown
		//IL_07d4: Expected Obj, but got I
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Expected VT, but got Unknown
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0880: Expected VT, but got Unknown
		//IL_08dc: Expected Obj, but got I
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_097a: Expected VT, but got Unknown
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Expected VT, but got Unknown
		//IL_01b8: Expected F4, but got I
		//IL_021d: Expected Obj, but got I
		//IL_01cd: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 - 688;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (cam.orthographic)
		{
			float orthographicSize = cam.orthographicSize;
			float num = 0f - orthographicSize;
			float num2 = 0f - orthographicSize;
			Rect rect = cam.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Vector2 vector = screenSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+284]");
			object obj3 = num3 / 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2A8]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2AC]");
			object obj4 = num4 / 0;
			object obj5 = obj3 * obj4;
			float num5 = num * (float)obj5;
			float num6 = orthographicSize * (float)obj5;
			Transform transform = cam.transform;
			Quaternion rotation = transform.rotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num8 = default;
			double num7 = Math.Abs(num8);
			if (!(num7 < 2147483648.0))
			{
				num8 = -2147483648.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num10 = default;
			double num9 = Math.Abs(num10);
			if (!(num9 < 2147483648.0))
			{
				num10 = -2147483648.0;
			}
			float num11 = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			float num12 = num11 / 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			float num13 = 0f - num12;
			object obj6 = num8 & 1;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
				num13 = 0f;
			}
			Vector3[] array = mSides;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+298]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+278]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+290]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			_ = 0;
			Quaternion quaternion = (Quaternion)(obj + 208);
			Vector3 vector2 = (Vector3)(obj + 192);
			Vector3 vector3 = quaternion * vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			float num14 = 0f + num13;
			float num15 = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+284]");
			float num16 = num15 / 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+284]");
			float num17 = 0f + num16;
			object obj7 = num10 & 1;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+284]");
				num17 = 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+284]");
			float num18 = 0f + num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			nint num19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			object obj8 = num19 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+268]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+260]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
			_ = 0;
			Vector3[] array2 = mSides;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+298]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+258]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+290]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+250]");
			_ = 0;
			Quaternion quaternion2 = (Quaternion)(obj + 160);
			Vector3 vector4 = (Vector3)(obj + 144);
			Vector3 vector5 = quaternion2 * vector4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			float num20 = 0f + num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+284]");
			float num21 = 0f + num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			nint num22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			object obj9 = num22 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+248]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+240]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			_ = 0;
			Vector3[] array3 = mSides;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+298]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+238]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+290]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
			_ = 0;
			Quaternion quaternion3 = (Quaternion)(obj + 112);
			Vector3 vector6 = (Vector3)(obj + 96);
			Vector3 vector7 = quaternion3 * vector6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			float num23 = 0f + num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+284]");
			float num24 = 0f + num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			nint num25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			object obj10 = num25 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+220]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
			_ = 0;
			Vector3[] array4 = mSides;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+298]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+218]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+290]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+210]");
			_ = 0;
			Quaternion quaternion4 = (Quaternion)(obj - -64);
			Vector3 vector8 = (Vector3)(obj + 48);
			Vector3 vector9 = quaternion4 * vector8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			float num26 = 0f + num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+284]");
			float num27 = 0f + num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			object obj11 = num28 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+208]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+200]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
		}
		else
		{
			Vector3[] array5 = mSides;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F8]");
			_ = 0;
			_ = 4539628424389459968L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F0]");
			_ = 0;
			Vector3 position2 = (Vector3)(obj + 336);
			Vector3 vector10 = cam.ViewportToWorldPoint(position2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+148]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+140]");
			_ = 0;
			Vector3[] array6 = mSides;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1D8]");
			_ = 0;
			_ = 4575657222465388544L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1D0]");
			_ = 0;
			Vector3 position3 = (Vector3)(obj + 304);
			Vector3 vector11 = cam.ViewportToWorldPoint(position3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+128]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+120]");
			_ = 0;
			Vector3[] array7 = mSides;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B8]");
			_ = 0;
			_ = 4539628425454813184L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B0]");
			_ = 0;
			Vector3 position4 = (Vector3)(obj + 272);
			Vector3 vector12 = cam.ViewportToWorldPoint(position4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
			_ = 0;
			Vector3[] array8 = mSides;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+198]");
			_ = 0;
			_ = 1056964608;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+190]");
			_ = 0;
			Vector3 position5 = (Vector3)(obj + 240);
			Vector3 vector13 = cam.ViewportToWorldPoint(position5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E0]");
			_ = 0;
		}
		if (relativeTo != null)
		{
			object obj12 = 0;
			while ((nint)obj12 < 4)
			{
				object obj13 = obj12 * 12;
				object obj14 = (object)mSides + obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S1_v18+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S1_v18+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
				_ = 0;
				Vector3 position6 = (Vector3)(obj + 16);
				Vector3 vector14 = relativeTo.InverseTransformPoint(position6);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
				obj = 0;
				object obj15 = obj12 * 12;
				object obj16 = (object)mSides + obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				object obj17 = obj12 + 1;
				obj12 = obj17;
			}
		}
		return mSides;
	}

	public static Vector3[] GetWorldCorners(Camera cam)
	{
		float nearClipPlane = cam.nearClipPlane;
		float farClipPlane = cam.farClipPlane;
		float num = farClipPlane - nearClipPlane;
		float num2 = num * 0.5f;
		float depth = nearClipPlane + num2;
		return GetWorldCorners(cam, depth, null);
	}

	public static Vector3[] GetWorldCorners(Camera cam, float depth)
	{
		return GetWorldCorners(cam, depth, null);
	}

	public static Vector3[] GetWorldCorners(Camera cam, Transform relativeTo)
	{
		float nearClipPlane = cam.nearClipPlane;
		float farClipPlane = cam.farClipPlane;
		float num = farClipPlane - nearClipPlane;
		float num2 = num * 0.5f;
		float depth = nearClipPlane + num2;
		return GetWorldCorners(cam, depth, relativeTo);
	}

	public static Vector3[] GetWorldCorners(Camera cam, float depth, Transform relativeTo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected VT, but got Unknown
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected VT, but got Unknown
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected VT, but got Unknown
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected VT, but got Unknown
		//IL_0087: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected VT, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected VT, but got Unknown
		//IL_080c: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected VT, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected VT, but got Unknown
		//IL_02c4: Expected Obj, but got I
		//IL_02e1: Expected Obj, but got I
		//IL_02fe: Expected Obj, but got I
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected VT, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected VT, but got Unknown
		//IL_03eb: Expected Obj, but got I
		//IL_0408: Expected Obj, but got I
		//IL_0425: Expected Obj, but got I
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected VT, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected VT, but got Unknown
		//IL_04fe: Expected Obj, but got I
		//IL_051b: Expected Obj, but got I
		//IL_0538: Expected Obj, but got I
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected Obj, but got Unknown
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Expected VT, but got Unknown
		//IL_08bc: Expected Obj, but got I
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected Obj, but got Unknown
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 688;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (cam.orthographic)
		{
			float orthographicSize = cam.orthographicSize;
			float num = 0f - orthographicSize;
			Rect rect = cam.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Vector2 vector = screenSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+284]");
			object obj3 = num2 / 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2A8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2AC]");
			object obj4 = num3 / 0;
			object obj5 = obj3 * obj4;
			float num4 = num * (float)obj5;
			Transform transform = cam.transform;
			Quaternion rotation = transform.rotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Vector3 position = transform.position;
			Vector3[] array = mSides;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+298]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+278]");
			_ = 0;
			float num5 = 0f - orthographicSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+290]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			_ = 0;
			Quaternion quaternion = (Quaternion)(obj + 208);
			Vector3 vector2 = (Vector3)(obj + 192);
			Vector3 vector3 = quaternion * vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			object obj6 = num6 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+284]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+284]");
			object obj7 = num7 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			object obj8 = num8 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+268]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+260]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
			_ = 0;
			Vector3[] array2 = mSides;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+298]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+258]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+290]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+250]");
			_ = 0;
			Quaternion quaternion2 = (Quaternion)(obj + 160);
			Vector3 vector4 = (Vector3)(obj + 144);
			Vector3 vector5 = quaternion2 * vector4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			object obj9 = num9 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+284]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+284]");
			object obj10 = num10 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			object obj11 = num11 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+248]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+240]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			_ = 0;
			Vector3[] array3 = mSides;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+298]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+238]");
			_ = 0;
			float num12 = orthographicSize * (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+290]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
			_ = 0;
			Quaternion quaternion3 = (Quaternion)(obj + 112);
			Vector3 vector6 = (Vector3)(obj + 96);
			Vector3 vector7 = quaternion3 * vector6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			object obj12 = num13 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+284]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+284]");
			object obj13 = num14 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			object obj14 = num15 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+220]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
			_ = 0;
			Vector3[] array4 = mSides;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+298]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+218]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+290]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+210]");
			_ = 0;
			Quaternion quaternion4 = (Quaternion)(obj - -64);
			Vector3 vector8 = (Vector3)(obj + 48);
			Vector3 vector9 = quaternion4 * vector8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			object obj15 = num16 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+284]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+284]");
			object obj16 = num17 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			object obj17 = num18 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+208]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+200]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
		}
		else
		{
			Vector3[] array5 = mSides;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F8]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F0]");
			_ = 0;
			Vector3 position2 = (Vector3)(obj + 336);
			Vector3 vector10 = cam.ViewportToWorldPoint(position2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+148]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+140]");
			_ = 0;
			Vector3[] array6 = mSides;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1D8]");
			_ = 0;
			_ = 4575657221408423936L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1D0]");
			_ = 0;
			Vector3 position3 = (Vector3)(obj + 304);
			Vector3 vector11 = cam.ViewportToWorldPoint(position3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+128]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+120]");
			_ = 0;
			Vector3[] array7 = mSides;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B8]");
			_ = 0;
			_ = 4575657222473777152L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B0]");
			_ = 0;
			Vector3 position4 = (Vector3)(obj + 272);
			Vector3 vector12 = cam.ViewportToWorldPoint(position4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
			_ = 0;
			Vector3[] array8 = mSides;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+198]");
			_ = 0;
			_ = 1065353216;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+190]");
			_ = 0;
			Vector3 position5 = (Vector3)(obj + 240);
			Vector3 vector13 = cam.ViewportToWorldPoint(position5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E0]");
			_ = 0;
		}
		if (relativeTo != null)
		{
			object obj18 = 0;
			while ((nint)obj18 < 4)
			{
				object obj19 = obj18 * 12;
				object obj20 = (object)mSides + obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S1_v18+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S1_v18+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
				_ = 0;
				Vector3 position6 = (Vector3)(obj + 16);
				Vector3 vector14 = relativeTo.InverseTransformPoint(position6);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
				obj = 0;
				object obj21 = obj18 * 12;
				object obj22 = (object)mSides + obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				object obj23 = obj18 + 1;
				obj18 = obj23;
			}
		}
		return mSides;
	}

	public static string GetFuncName(object obj, string method)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_00d0: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		if (obj == null)
		{
			return "<null>";
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		object obj3 = default;
		object obj2 = obj3;
		object obj4 = obj3 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S1_v3+D4] (should have been resolved before IL gen)");
		string text = default;
		int num = text.LastIndexOf('/');
		bool flag = num >= 1;
		bool flag2 = !flag;
		string text2 = text;
		if (!flag2)
		{
			int startIndex = num + 1;
			string text3 = text.Substring(startIndex);
			text2 = text3;
		}
		object obj5;
		if (method != null)
		{
			obj5 = 0;
			if (method._stringLength != 0)
			{
				goto IL_0147;
			}
		}
		obj5 = 1;
		goto IL_0147;
		IL_0147:
		if (obj5 != null)
		{
			return text2;
		}
		return text2 + "/" + method;
	}

	public static void Execute<T>(GameObject go, string funcName) where T : Component
	{
		//IL_0027: Expected Obj, but got I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_009c: Expected I, but got Obj
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<NGUITools::Execute>>)+4] (should have been resolved before IL gen)");
		object obj = 0;
		MethodInfo methodInfo = null;
		object obj4 = default;
		Type type = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ S0_v2+C]");
			if (0 > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = obj4 + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
				MethodInfo method = type.GetMethod(funcName, (BindingFlags)52);
				MethodInfo methodInfo2 = method;
				if ((object)method == null)
				{
					methodInfo2 = methodInfo;
				}
				if ((object)method != null)
				{
					nint num3 = (nint)methodInfo2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ S6_v4 (Il2CppClass<System.Reflection.MethodInfo>)+1BC] (should have been resolved before IL gen)");
				}
				object obj5 = obj + 1;
				obj = obj5;
				methodInfo = methodInfo2;
				continue;
			}
			break;
		}
	}

	public static void ExecuteAll<T>(GameObject root, string funcName) where T : Component
	{
		//IL_0052: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<NGUITools::ExecuteAll>>)+4] (should have been resolved before IL gen)");
		Transform transform = root.transform;
		int childCount = transform.childCount;
		int num3 = 0;
		while (num3 < childCount)
		{
			Transform child = transform.GetChild(num3);
			GameObject gameObject = child.gameObject;
			nint num4 = 0;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S3_v7 (Il2CppMethodRgctx<NGUITools::ExecuteAll>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S3_v8+4] (should have been resolved before IL gen)");
			int num6 = num3 + 1;
			num3 = num6;
		}
	}

	public static void ImmediatelyCreateDrawCalls(GameObject root)
	{
		ExecuteAll<UIWidget>(root, "Start");
		ExecuteAll<UIPanel>(root, "Start");
		ExecuteAll<UIWidget>(root, "Update");
		ExecuteAll<UIPanel>(root, "Update");
		ExecuteAll<UIPanel>(root, "LateUpdate");
	}

	public static string KeyToCaption(KeyCode key)
	{
		//IL_0f93: Expected Obj, but got I4
		bool flag = key == KeyCode.None;
		string result = null;
		if (!flag)
		{
			bool flag2 = key == (KeyCode)1;
			result = null;
			if (!flag2)
			{
				bool flag3 = key == (KeyCode)2;
				result = null;
				if (!flag3)
				{
					bool flag4 = key == (KeyCode)3;
					result = null;
					if (!flag4)
					{
						bool flag5 = key == (KeyCode)4;
						result = null;
						if (!flag5)
						{
							bool flag6 = key == (KeyCode)5;
							result = null;
							if (!flag6)
							{
								bool flag7 = key == (KeyCode)6;
								result = null;
								if (!flag7)
								{
									bool flag8 = key == (KeyCode)7;
									result = null;
									if (!flag8)
									{
										switch (key)
										{
										case KeyCode.Backspace:
											return "BS";
										case KeyCode.Tab:
											return "Tab";
										}
										bool flag9 = key == (KeyCode)10;
										result = null;
										if (!flag9)
										{
											bool flag10 = key == (KeyCode)11;
											result = null;
											if (!flag10)
											{
												switch (key)
												{
												case KeyCode.Clear:
													return "Clr";
												case KeyCode.Return:
													return "NT";
												}
												bool flag11 = key == (KeyCode)14;
												result = null;
												if (!flag11)
												{
													bool flag12 = key == (KeyCode)15;
													result = null;
													if (!flag12)
													{
														bool flag13 = key == (KeyCode)16;
														result = null;
														if (!flag13)
														{
															bool flag14 = key == (KeyCode)17;
															result = null;
															if (!flag14)
															{
																bool flag15 = key == (KeyCode)18;
																result = null;
																if (!flag15)
																{
																	if (key == KeyCode.Pause)
																	{
																		return "PS";
																	}
																	bool flag16 = key == (KeyCode)20;
																	result = null;
																	if (!flag16)
																	{
																		bool flag17 = key == (KeyCode)21;
																		result = null;
																		if (!flag17)
																		{
																			bool flag18 = key == (KeyCode)22;
																			result = null;
																			if (!flag18)
																			{
																				bool flag19 = key == (KeyCode)23;
																				result = null;
																				if (!flag19)
																				{
																					bool flag20 = key == (KeyCode)24;
																					result = null;
																					if (!flag20)
																					{
																						bool flag21 = key == (KeyCode)25;
																						result = null;
																						if (!flag21)
																						{
																							bool flag22 = key == (KeyCode)26;
																							result = null;
																							if (!flag22)
																							{
																								if (key == KeyCode.Escape)
																								{
																									return "Esc";
																								}
																								bool flag23 = key == (KeyCode)28;
																								result = null;
																								if (!flag23)
																								{
																									bool flag24 = key == (KeyCode)29;
																									result = null;
																									if (!flag24)
																									{
																										bool flag25 = key == (KeyCode)30;
																										result = null;
																										if (!flag25)
																										{
																											bool flag26 = key == (KeyCode)31;
																											result = null;
																											if (!flag26)
																											{
																												switch (key)
																												{
																												case KeyCode.Space:
																													return "SP";
																												case KeyCode.Exclaim:
																													return "!";
																												case KeyCode.DoubleQuote:
																													return "\"";
																												case KeyCode.Hash:
																													return "#";
																												case KeyCode.Dollar:
																													return "$";
																												}
																												bool flag27 = key == KeyCode.Percent;
																												result = null;
																												if (!flag27)
																												{
																													switch (key)
																													{
																													case KeyCode.Ampersand:
																														return "&";
																													case KeyCode.Quote:
																														return "'";
																													case KeyCode.LeftParen:
																														return "(";
																													case KeyCode.RightParen:
																														return ")";
																													case KeyCode.Asterisk:
																														return "*";
																													case KeyCode.Plus:
																														return "+";
																													case KeyCode.Comma:
																														return ",";
																													case KeyCode.Minus:
																														return "-";
																													case KeyCode.Period:
																														return ".";
																													case KeyCode.Slash:
																														return "/";
																													case KeyCode.Alpha0:
																														return "0";
																													case KeyCode.Alpha1:
																														return "1";
																													case KeyCode.Alpha2:
																														return "2";
																													case KeyCode.Alpha3:
																														return "3";
																													case KeyCode.Alpha4:
																														return "4";
																													case KeyCode.Alpha5:
																														return "5";
																													case KeyCode.Alpha6:
																														return "6";
																													case KeyCode.Alpha7:
																														return "7";
																													case KeyCode.Alpha8:
																														return "8";
																													case KeyCode.Alpha9:
																														return "9";
																													case KeyCode.Colon:
																														return ":";
																													case KeyCode.Semicolon:
																														return ";";
																													case KeyCode.Less:
																														return "<";
																													case KeyCode.Equals:
																														return "=";
																													case KeyCode.Greater:
																														return ">";
																													case KeyCode.Question:
																														return "?";
																													case KeyCode.At:
																														return "@";
																													}
																													bool flag28 = key == (KeyCode)65;
																													result = null;
																													if (!flag28)
																													{
																														bool flag29 = key == (KeyCode)66;
																														result = null;
																														if (!flag29)
																														{
																															bool flag30 = key == (KeyCode)67;
																															result = null;
																															if (!flag30)
																															{
																																bool flag31 = key == (KeyCode)68;
																																result = null;
																																if (!flag31)
																																{
																																	bool flag32 = key == (KeyCode)69;
																																	result = null;
																																	if (!flag32)
																																	{
																																		bool flag33 = key == (KeyCode)70;
																																		result = null;
																																		if (!flag33)
																																		{
																																			bool flag34 = key == (KeyCode)71;
																																			result = null;
																																			if (!flag34)
																																			{
																																				bool flag35 = key == (KeyCode)72;
																																				result = null;
																																				if (!flag35)
																																				{
																																					bool flag36 = key == (KeyCode)73;
																																					result = null;
																																					if (!flag36)
																																					{
																																						bool flag37 = key == (KeyCode)74;
																																						result = null;
																																						if (!flag37)
																																						{
																																							bool flag38 = key == (KeyCode)75;
																																							result = null;
																																							if (!flag38)
																																							{
																																								bool flag39 = key == (KeyCode)76;
																																								result = null;
																																								if (!flag39)
																																								{
																																									bool flag40 = key == (KeyCode)77;
																																									result = null;
																																									if (!flag40)
																																									{
																																										bool flag41 = key == (KeyCode)78;
																																										result = null;
																																										if (!flag41)
																																										{
																																											bool flag42 = key == (KeyCode)79;
																																											result = null;
																																											if (!flag42)
																																											{
																																												bool flag43 = key == (KeyCode)80;
																																												result = null;
																																												if (!flag43)
																																												{
																																													bool flag44 = key == (KeyCode)81;
																																													result = null;
																																													if (!flag44)
																																													{
																																														bool flag45 = key == (KeyCode)82;
																																														result = null;
																																														if (!flag45)
																																														{
																																															bool flag46 = key == (KeyCode)83;
																																															result = null;
																																															if (!flag46)
																																															{
																																																bool flag47 = key == (KeyCode)84;
																																																result = null;
																																																if (!flag47)
																																																{
																																																	bool flag48 = key == (KeyCode)85;
																																																	result = null;
																																																	if (!flag48)
																																																	{
																																																		bool flag49 = key == (KeyCode)86;
																																																		result = null;
																																																		if (!flag49)
																																																		{
																																																			bool flag50 = key == (KeyCode)87;
																																																			result = null;
																																																			if (!flag50)
																																																			{
																																																				bool flag51 = key == (KeyCode)88;
																																																				result = null;
																																																				if (!flag51)
																																																				{
																																																					bool flag52 = key == (KeyCode)89;
																																																					result = null;
																																																					if (!flag52)
																																																					{
																																																						bool flag53 = key == (KeyCode)90;
																																																						result = null;
																																																						if (!flag53)
																																																						{
																																																							switch (key)
																																																							{
																																																							case KeyCode.LeftBracket:
																																																								return "[";
																																																							case KeyCode.Backslash:
																																																								return "\\";
																																																							case KeyCode.RightBracket:
																																																								return "]";
																																																							case KeyCode.Caret:
																																																								return "^";
																																																							case KeyCode.Underscore:
																																																								return "_";
																																																							case KeyCode.BackQuote:
																																																								return "`";
																																																							case KeyCode.A:
																																																								return "A";
																																																							case KeyCode.B:
																																																								return "B";
																																																							case KeyCode.C:
																																																								return "C";
																																																							case KeyCode.D:
																																																								return "D";
																																																							case KeyCode.E:
																																																								return "E";
																																																							case KeyCode.F:
																																																								return "F";
																																																							case KeyCode.G:
																																																								return "G";
																																																							case KeyCode.H:
																																																								return "H";
																																																							case KeyCode.I:
																																																								return "I";
																																																							case KeyCode.J:
																																																								return "J";
																																																							case KeyCode.K:
																																																								return "K";
																																																							case KeyCode.L:
																																																								return "L";
																																																							case KeyCode.M:
																																																								return "M";
																																																							case KeyCode.N:
																																																								return "N0";
																																																							case KeyCode.O:
																																																								return "O";
																																																							case KeyCode.P:
																																																								return "P";
																																																							case KeyCode.Q:
																																																								return "Q";
																																																							case KeyCode.R:
																																																								return "R";
																																																							case KeyCode.S:
																																																								return "S";
																																																							case KeyCode.T:
																																																								return "T";
																																																							case KeyCode.U:
																																																								return "U";
																																																							case KeyCode.V:
																																																								return "V";
																																																							case KeyCode.W:
																																																								return "W";
																																																							case KeyCode.X:
																																																								return "X";
																																																							case KeyCode.Y:
																																																								return "Y";
																																																							case KeyCode.Z:
																																																								return "Z";
																																																							}
																																																							bool flag54 = key == KeyCode.LeftCurlyBracket;
																																																							result = null;
																																																							if (!flag54)
																																																							{
																																																								bool flag55 = key == KeyCode.Pipe;
																																																								result = null;
																																																								if (!flag55)
																																																								{
																																																									bool flag56 = key == KeyCode.RightCurlyBracket;
																																																									result = null;
																																																									if (!flag56)
																																																									{
																																																										bool flag57 = key == KeyCode.Tilde;
																																																										result = null;
																																																										if (!flag57)
																																																										{
																																																											if (key == KeyCode.Delete)
																																																											{
																																																												return "Del";
																																																											}
																																																											object obj = key - 256;
																																																											if (key == KeyCode.Keypad0)
																																																											{
																																																												return "K0";
																																																											}
																																																											if ((nint)obj == 1)
																																																											{
																																																												return "K1";
																																																											}
																																																											if ((nint)obj == 2)
																																																											{
																																																												return "K2";
																																																											}
																																																											if ((nint)obj == 3)
																																																											{
																																																												return "K3";
																																																											}
																																																											if ((nint)obj == 4)
																																																											{
																																																												return "K4";
																																																											}
																																																											if ((nint)obj == 5)
																																																											{
																																																												return "K5";
																																																											}
																																																											if ((nint)obj == 6)
																																																											{
																																																												return "K6";
																																																											}
																																																											if ((nint)obj == 7)
																																																											{
																																																												return "K7";
																																																											}
																																																											if ((nint)obj == 8)
																																																											{
																																																												return "K8";
																																																											}
																																																											if ((nint)obj == 9)
																																																											{
																																																												return "K9";
																																																											}
																																																											if ((nint)obj == 10)
																																																											{
																																																												return ".";
																																																											}
																																																											if ((nint)obj == 11)
																																																											{
																																																												return "/";
																																																											}
																																																											if ((nint)obj == 12)
																																																											{
																																																												return "*";
																																																											}
																																																											if ((nint)obj == 13)
																																																											{
																																																												return "-";
																																																											}
																																																											if ((nint)obj == 14)
																																																											{
																																																												return "+";
																																																											}
																																																											if ((nint)obj == 15)
																																																											{
																																																												return "NT";
																																																											}
																																																											if ((nint)obj == 16)
																																																											{
																																																												return "=";
																																																											}
																																																											if ((nint)obj == 17)
																																																											{
																																																												return "UP";
																																																											}
																																																											if ((nint)obj == 18)
																																																											{
																																																												return "DN";
																																																											}
																																																											if ((nint)obj == 19)
																																																											{
																																																												return "LT";
																																																											}
																																																											if ((nint)obj == 20)
																																																											{
																																																												return "RT";
																																																											}
																																																											if ((nint)obj == 21)
																																																											{
																																																												return "Ins";
																																																											}
																																																											if ((nint)obj == 22)
																																																											{
																																																												return "Home";
																																																											}
																																																											if ((nint)obj == 23)
																																																											{
																																																												return "End";
																																																											}
																																																											if ((nint)obj == 24)
																																																											{
																																																												return "PU";
																																																											}
																																																											if ((nint)obj == 25)
																																																											{
																																																												return "PD";
																																																											}
																																																											if ((nint)obj == 26)
																																																											{
																																																												return "F1";
																																																											}
																																																											if ((nint)obj == 27)
																																																											{
																																																												return "F2";
																																																											}
																																																											if ((nint)obj == 28)
																																																											{
																																																												return "F3";
																																																											}
																																																											if ((nint)obj == 29)
																																																											{
																																																												return "F4";
																																																											}
																																																											if ((nint)obj == 30)
																																																											{
																																																												return "F5";
																																																											}
																																																											if ((nint)obj == 31)
																																																											{
																																																												return "F6";
																																																											}
																																																											if ((nint)obj == 32)
																																																											{
																																																												return "F7";
																																																											}
																																																											if ((nint)obj == 33)
																																																											{
																																																												return "F8";
																																																											}
																																																											if ((nint)obj == 34)
																																																											{
																																																												return "F9";
																																																											}
																																																											if ((nint)obj == 35)
																																																											{
																																																												return "F10";
																																																											}
																																																											if ((nint)obj == 36)
																																																											{
																																																												return "F11";
																																																											}
																																																											if ((nint)obj == 37)
																																																											{
																																																												return "F12";
																																																											}
																																																											if ((nint)obj == 38)
																																																											{
																																																												return "F13";
																																																											}
																																																											if ((nint)obj == 39)
																																																											{
																																																												return "F14";
																																																											}
																																																											if ((nint)obj == 40)
																																																											{
																																																												return "F15";
																																																											}
																																																											bool flag58 = (nint)obj == 41;
																																																											result = null;
																																																											if (!flag58)
																																																											{
																																																												bool flag59 = (nint)obj == 42;
																																																												result = null;
																																																												if (!flag59)
																																																												{
																																																													bool flag60 = (nint)obj == 43;
																																																													result = null;
																																																													if (!flag60)
																																																													{
																																																														if ((nint)obj == 44)
																																																														{
																																																															return "Num";
																																																														}
																																																														if ((nint)obj == 45)
																																																														{
																																																															return "Cap";
																																																														}
																																																														if ((nint)obj == 46)
																																																														{
																																																															return "Scr";
																																																														}
																																																														if ((nint)obj == 47)
																																																														{
																																																															return "RS";
																																																														}
																																																														if ((nint)obj == 48)
																																																														{
																																																															return "LS";
																																																														}
																																																														if ((nint)obj == 49)
																																																														{
																																																															return "RC";
																																																														}
																																																														if ((nint)obj == 50)
																																																														{
																																																															return "LC";
																																																														}
																																																														if ((nint)obj == 51)
																																																														{
																																																															return "RA";
																																																														}
																																																														if ((nint)obj == 52)
																																																														{
																																																															return "LA";
																																																														}
																																																														bool flag61 = (nint)obj == 53;
																																																														result = null;
																																																														if (!flag61)
																																																														{
																																																															bool flag62 = (nint)obj == 54;
																																																															result = null;
																																																															if (!flag62)
																																																															{
																																																																bool flag63 = (nint)obj == 55;
																																																																result = null;
																																																																if (!flag63)
																																																																{
																																																																	bool flag64 = (nint)obj == 56;
																																																																	result = null;
																																																																	if (!flag64)
																																																																	{
																																																																		bool flag65 = (nint)obj == 57;
																																																																		result = null;
																																																																		if (!flag65)
																																																																		{
																																																																			bool flag66 = (nint)obj == 58;
																																																																			result = null;
																																																																			if (!flag66)
																																																																			{
																																																																				bool flag67 = (nint)obj == 59;
																																																																				result = null;
																																																																				if (!flag67)
																																																																				{
																																																																					bool flag68 = (nint)obj == 60;
																																																																					result = null;
																																																																					if (!flag68)
																																																																					{
																																																																						bool flag69 = (nint)obj == 61;
																																																																						result = null;
																																																																						if (!flag69)
																																																																						{
																																																																							bool flag70 = (nint)obj == 62;
																																																																							result = null;
																																																																							if (!flag70)
																																																																							{
																																																																								bool flag71 = (nint)obj == 63;
																																																																								result = null;
																																																																								if (!flag71)
																																																																								{
																																																																									bool flag72 = (nint)obj == 64;
																																																																									result = null;
																																																																									if (!flag72)
																																																																									{
																																																																										bool flag73 = (nint)obj == 65;
																																																																										result = null;
																																																																										if (!flag73)
																																																																										{
																																																																											bool flag74 = (nint)obj == 66;
																																																																											result = null;
																																																																											if (!flag74)
																																																																											{
																																																																												if ((nint)obj == 67)
																																																																												{
																																																																													return "M0";
																																																																												}
																																																																												if ((nint)obj == 68)
																																																																												{
																																																																													return "M1";
																																																																												}
																																																																												if ((nint)obj == 69)
																																																																												{
																																																																													return "M2";
																																																																												}
																																																																												if ((nint)obj == 70)
																																																																												{
																																																																													return "M3";
																																																																												}
																																																																												if ((nint)obj == 71)
																																																																												{
																																																																													return "M4";
																																																																												}
																																																																												if ((nint)obj == 72)
																																																																												{
																																																																													return "M5";
																																																																												}
																																																																												if ((nint)obj == 73)
																																																																												{
																																																																													return "M6";
																																																																												}
																																																																												if ((nint)obj == 74)
																																																																												{
																																																																													return "(A)";
																																																																												}
																																																																												if ((nint)obj == 75)
																																																																												{
																																																																													return "(B)";
																																																																												}
																																																																												if ((nint)obj == 76)
																																																																												{
																																																																													return "(X)";
																																																																												}
																																																																												if ((nint)obj == 77)
																																																																												{
																																																																													return "(Y)";
																																																																												}
																																																																												if ((nint)obj == 78)
																																																																												{
																																																																													return "(RB)";
																																																																												}
																																																																												if ((nint)obj == 79)
																																																																												{
																																																																													return "(LB)";
																																																																												}
																																																																												if ((nint)obj == 80)
																																																																												{
																																																																													return "(Back)";
																																																																												}
																																																																												if ((nint)obj == 81)
																																																																												{
																																																																													return "(Start)";
																																																																												}
																																																																												if ((nint)obj == 82)
																																																																												{
																																																																													return "(LS)";
																																																																												}
																																																																												if ((nint)obj == 83)
																																																																												{
																																																																													return "(RS)";
																																																																												}
																																																																												if ((nint)obj == 84)
																																																																												{
																																																																													return "J10";
																																																																												}
																																																																												if ((nint)obj == 85)
																																																																												{
																																																																													return "J11";
																																																																												}
																																																																												if ((nint)obj == 86)
																																																																												{
																																																																													return "J12";
																																																																												}
																																																																												if ((nint)obj == 87)
																																																																												{
																																																																													return "J13";
																																																																												}
																																																																												if ((nint)obj == 88)
																																																																												{
																																																																													return "J14";
																																																																												}
																																																																												if ((nint)obj == 89)
																																																																												{
																																																																													return "J15";
																																																																												}
																																																																												if ((nint)obj == 90)
																																																																												{
																																																																													return "J16";
																																																																												}
																																																																												if ((nint)obj == 91)
																																																																												{
																																																																													return "J17";
																																																																												}
																																																																												if ((nint)obj == 92)
																																																																												{
																																																																													return "J18";
																																																																												}
																																																																												result = (((nint)obj == 93) ? "J19" : null);
																																																																											}
																																																																										}
																																																																									}
																																																																								}
																																																																							}
																																																																						}
																																																																					}
																																																																				}
																																																																			}
																																																																		}
																																																																	}
																																																																}
																																																															}
																																																														}
																																																													}
																																																												}
																																																											}
																																																										}
																																																									}
																																																								}
																																																							}
																																																						}
																																																					}
																																																				}
																																																			}
																																																		}
																																																	}
																																																}
																																															}
																																														}
																																													}
																																												}
																																											}
																																										}
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		return result;
	}

	static NGUITools()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Vector3[] array = default;
		mSides = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array2 = default;
		RuntimeHelpers.InitializeArray(array2, __ldtoken(_003CPrivateImplementationDetails_003E._6383AD8D3ACB5400C9BB99B6431A223D7472A06120C1C15C09458B0FCB291E2B));
		keys = (KeyCode[])array2;
	}
}
