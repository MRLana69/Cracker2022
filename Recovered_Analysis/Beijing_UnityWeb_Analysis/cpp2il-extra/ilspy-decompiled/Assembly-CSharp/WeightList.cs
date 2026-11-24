using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.ModelCamera;
using UnityEngine;
using UnityEngine.U2D;

[Serializable]
public class WeightList
{
	[Serializable]
	public class WeightEntry
	{
		public Transform Transform;

		public Vector2 Weight;

		public WeightEntry(Transform transform, Vector2 weight)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0018: Expected Obj, but got VT
			object obj = Transform + 20;
			obj = weight;
		}

		public WeightEntry(Transform transform)
		{
			Transform = transform;
		}
	}

	private List<WeightEntry> _entries;

	public List<WeightEntry> Entries
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (WeightList)+18]");
			return (List<WeightEntry>)0;
		}
	}

	public List<Vector2> CalculateProportionalWeights()
	{
		//IL_001e: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<> list = default;
		((List<T>)(object)list).Add((T)_entries);
		return (List<Vector2>)(object)list;
	}

	private bool WeightEntryExists(Transform transform)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj = default;
		return (nint)((UnityEngine.Object)transform).m_CachedPtr > (nint)obj;
	}

	private void AddWeightEntry(Transform transform)
	{
		//IL_008c: Expected Obj, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		((UIRect)(object)transform).ResetAnchors();
		GameObject gameObject = transform.gameObject;
		if (((Transform)(object)gameObject).GetSiblingIndex() == 0)
		{
			return;
		}
		Sprite sprite = default;
		Sprite sprite2 = default;
		while (true)
		{
			GameObject gameObject2 = transform.gameObject;
			int siblingIndex = ((Transform)(object)gameObject2).GetSiblingIndex();
			if ((nint)sprite < siblingIndex)
			{
				GameObject gameObject3 = transform.gameObject;
				bool flag = ((SpriteAtlas)(object)gameObject3).CanBindTo(sprite);
				UIWidget component = ((Component)flag).GetComponent<UIWidget>();
				AddWeightEntry((Transform)(object)component);
				sprite = (Sprite)(sprite2 + 1);
				continue;
			}
			break;
		}
	}

	public unsafe Vector2 WeightForTransform(Transform transform)
	{
		//IL_08fc: Expected I, but got Obj
		//IL_0912: Expected Obj, but got I
		//IL_0d7d: Expected Obj, but got I4
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Expected VT, but got Unknown
		//IL_0946: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Expected Obj, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Expected Obj, but got Unknown
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected Obj, but got Unknown
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Expected Obj, but got Unknown
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_013b: Expected Obj, but got I
		//IL_0150: Expected F4, but got Obj
		//IL_014b: Expected native int or pointer, but got VT
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_09ff: Expected F4, but got Obj
		//IL_09fa: Expected native int or pointer, but got VT
		//IL_0a14: Expected F4, but got I
		//IL_0a0f: Expected native int or pointer, but got VT
		//IL_0a29: Expected I4, but got VT
		//IL_0a29: Expected Obj, but got I
		//IL_0a3a: Expected Obj, but got I
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_0126: Expected F4, but got Obj
		//IL_0121: Expected native int or pointer, but got VT
		//IL_09bd: Expected Obj, but got I4
		//IL_016a: Expected I4, but got Obj
		//IL_016a: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00f6: Expected I4, but got Obj
		//IL_00f6: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I
		//IL_01bf: Expected Obj, but got I
		//IL_0a51: Expected I, but got Obj
		//IL_0a67: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I
		//IL_0226: Expected I, but got Obj
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_0275: Expected Obj, but got I
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_0393: Expected Obj, but got VT
		//IL_03a8: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I
		//IL_03d3: Expected Obj, but got I
		//IL_0312: Expected Obj, but got I4
		//IL_02aa: Expected Obj, but got I
		//IL_02ba: Expected Obj, but got I
		//IL_0aa3: Expected Obj, but got I
		//IL_0ac0: Expected Obj, but got I
		//IL_02f4: Expected Obj, but got I
		//IL_0304: Expected Obj, but got I
		//IL_0591: Expected Obj, but got I4
		//IL_0591: Expected Obj, but got I
		//IL_05a3: Expected Obj, but got I
		//IL_041a: Expected Obj, but got I
		//IL_05b9: Expected Obj, but got I
		//IL_05cb: Expected I, but got Obj
		//IL_05e1: Expected Obj, but got I
		//IL_043e: Expected Obj, but got I
		//IL_0454: Expected Obj, but got I4
		//IL_0454: Expected Obj, but got I
		//IL_0b59: Expected Obj, but got I
		//IL_0b69: Expected Obj, but got I
		//IL_0467: Expected I, but got Obj
		//IL_047d: Expected Obj, but got I
		//IL_0bb0: Expected Obj, but got I
		//IL_0bdd: Expected I, but got Obj
		//IL_0bf3: Expected Obj, but got I
		//IL_060c: Expected I, but got Obj
		//IL_0b0b: Expected I4, but got Obj
		//IL_0b0b: Expected Obj, but got I
		//IL_0b1c: Expected Obj, but got I
		//IL_0dd9: Invalid comparison between F4 and I4
		//IL_065b: Expected Obj, but got I
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected Obj, but got Unknown
		//IL_04fe: Expected Obj, but got VT
		//IL_051b: Expected Obj, but got I
		//IL_04a8: Expected I, but got Obj
		//IL_06d1: Invalid comparison between F4 and I4
		//IL_067b: Expected I, but got Obj
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got Unknown
		//IL_0554: Expected F4, but got Obj
		//IL_054f: Expected native int or pointer, but got VT
		//IL_0569: Expected F4, but got I
		//IL_0564: Expected native int or pointer, but got VT
		//IL_0572: Expected Obj, but got VT
		//IL_06c3: Expected F4, but got I4
		//IL_0b36: Expected Obj, but got I
		//IL_0c18: Expected native int or pointer, but got VT
		//IL_0c30: Expected Obj, but got I4
		//IL_06f9: Expected F4, but got I4
		//IL_071d: Expected I4, but got Obj
		//IL_072d: Expected Obj, but got I
		//IL_073d: Expected Obj, but got I
		//IL_0c64: Expected Obj, but got I
		//IL_0c81: Expected Obj, but got I
		//IL_07bd: Expected Obj, but got I
		//IL_07cd: Expected Obj, but got I
		//IL_07db: Expected I, but got Obj
		//IL_07f1: Expected Obj, but got I
		//IL_0784: Expected Obj, but got I
		//IL_0cda: Expected Obj, but got I
		//IL_0ce3: Expected Obj, but got VT
		//IL_0cf8: Expected F4, but got Obj
		//IL_0cf3: Expected native int or pointer, but got VT
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0a: Expected Obj, but got Unknown
		//IL_0d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Expected Obj, but got Unknown
		//IL_07a8: Expected I4, but got Obj
		//IL_07a8: Expected Obj, but got I
		//IL_081c: Expected I, but got Obj
		//IL_0869: Expected I, but got Obj
		//IL_087f: Expected Obj, but got I
		//IL_0d66: Expected Obj, but got I4
		//IL_08aa: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v154 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		if (!((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
		{
			nint num3 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v140 (Il2CppClass<SocialManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v150 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
			if (!((SocialManager)facebookDialogsSupported2).gamecenterIsLoggedOut)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+30]");
				((UISprite)0).fillCenter = (byte)(int)"ic_lock" != 0;
			}
		}
		object obj3 = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj3 + 32);
		object obj4 = obj3 + 16;
		object obj5 = obj3 + 48;
		object obj6 = obj3 + 68;
		object obj7 = obj3 - -64;
		_ = 0;
		Vector2 vector = default;
		object obj8 = vector + 52;
		obj8 = this;
		if ((object)transform != null)
		{
			object obj9 = vector - -64;
			obj4 = obj9;
			obj7 = obj4;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+3C]");
			obj4 = 0;
			obj6 = obj4;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		}
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Matrix4x4 matrix4x3 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v23+8]");
		((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+20]");
		((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+34]");
		Texture2D image = ((Friend)0).image;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+18]");
		((UILabel)0).fontSize = (int)image;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+34]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v36+20]");
		ComputeShader computeShader;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v36+20]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v137+14]");
			computeShader = (ComputeShader)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v36+1C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v36+1C]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v134+14]");
				computeShader = (ComputeShader)0;
			}
			else
			{
				computeShader = null;
			}
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v127 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (computeShader.FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+34]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S2_v87+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S2_v87+20]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S2_v97+14]");
				object obj16 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S2_v87+1C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S2_v87+1C]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S2_v94+14]");
					object obj16 = 0;
				}
				else
				{
					object obj16 = 0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		object obj18 = obj3 + 8;
		int num7 = Shader.PropertyToID("Unlit/Transparent Colored (AlphaClip)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(FriendHelperCrew.OnFriendUpdatedHandler);
		object obj19 = action + 16;
		obj19 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+34]");
		((Friend)0).updated -= action;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+34]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v48+28]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v48+14]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S1_v44+10]");
		if (num8 < 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v48+28]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v48+14]");
			_ = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v48+28]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v48+14]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S1_v48+10]");
		object obj24 = num9 - 0;
		if ((nint)obj24 > 24)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+14]");
			((GameObject)0).tag = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+C]");
			((GameObject)0).tag = (string)1;
			nint num10 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S1_v101 (Il2CppClass<Strings>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num11 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S1_v119 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("TOPRUN_COLLECT_BUTTON_TITLE");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+10]");
			((UILabel)0).fontSize = (int)text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+C]");
			UIButtonMessage component = ((GameObject)0).GetComponent<UIButtonMessage>();
			object obj26 = component + 12;
			string tag = ((Component)vector).tag;
			obj26 = tag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+C]");
			int layer = ((GameObject)0).layer;
			object obj27 = vector + 68;
			obj4 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S2_v75+8]");
			_ = 0;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
			Matrix4x4 matrix4x4 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v21+8]");
			((Matrix4x4*)(nint)matrix4x4)->m20 = 0f;
			Vector3 eulerAngles = ((Transform)matrix4x).eulerAngles;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+14]");
			((GameObject)0).tag = (string)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+C]");
			((GameObject)0).tag = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+14]");
			FriendProgressHelper component2 = ((GameObject)0).GetComponent<FriendProgressHelper>();
			nint num12 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S1_v59 (Il2CppClass<Strings>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num13 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S1_v94 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string provider = Strings.GetDefault("TOPRUN_COLLECT_PROGRESS");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+34]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S2_v31+28]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S2_v31+14]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S3_v7+10]");
			if (num14 < 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S2_v31+28]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S2_v31+14]");
				_ = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S2_v31+28]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S2_v31+14]");
			float num15 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S3_v11+10]");
			float num16 = num15 - 0f;
			nint num17 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S2_v39 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj33 = (nint)0 & (nint)0x200;
			if (obj33 != null)
			{
				nint num18 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S2_v62 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float m;
			if (num16 < 0f)
			{
				m = 0f;
			}
			else
			{
				m = ((!(num16 > 25f)) ? num16 : 25f);
			}
			((Matrix4x4*)(nint)matrix4x)->m00 = m;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			obj4 = 25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string format = default;
			object arg = default;
			string text2 = string.Format((IFormatProvider)(object)provider, format, arg);
			component2.label.fontSize = (int)text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+34]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S1_v68+28]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S1_v68+14]");
			nint num19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S2_v49+10]");
			if (num19 < 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S1_v68+28]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S1_v68+14]");
				_ = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S1_v68+28]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S1_v68+14]");
			nint num20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ S2_v53+10]");
			object obj38 = num20 - 0;
			float alpha = (float)obj38 / 25f;
			component2.slider.alpha = alpha;
			string text3 = RemoteNotificationControl.CacheTokenAndGetOldIfChanged((string)(object)this);
			if (text3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+24]");
				((FriendGhostHandler)0).RefreshListOnSettingsChanged((byte)(int)this != 0);
				goto IL_08e9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+34]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ S0_v76+28]");
			object obj40 = 0;
			nint num21 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ S0_v80 (Il2CppClass<System.DateTime>)+BA]");
			object obj41 = (nint)0 & (nint)0x200;
			if (obj41 != null)
			{
				nint num22 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ S0_v106 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S0_v77+8]");
			obj18 = 0;
			obj3 = DateTime.MinValue;
			obj4 = obj18;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			object obj42 = obj4 & 0x3FFFFFFFFFFFFFFFL;
			object obj43 = matrix4x.m00 & 0x3FFFFFFFFFFFFFFFL;
			if (obj42 == obj43)
			{
				nint num23 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S0_v96 (Il2CppClass<SocialManager>)+BA]");
				object obj44 = (nint)0 & (nint)0x200;
				if (obj44 != null)
				{
					nint num24 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ S0_v102 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool facebookDialogsSupported3 = SocialManager.facebookDialogsSupported;
				bool flag = facebookDialogsSupported3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+34]");
				((SocialManager)flag).AnnounceToFriends(0);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+24]");
		((FriendCrewPokeHelper)0).OnClick();
		goto IL_08e9;
		IL_08e9:
		return vector;
	}

	public void SyncList(Transform layout)
	{
		//IL_00c9: Expected I4, but got Obj
		//IL_00aa: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		RenderTextureCamera availableCamera = ((RenderTextureManager)this).GetAvailableCamera((byte)(int)layout != 0);
		if (availableCamera != null)
		{
			nint num = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v11 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v17 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogException((Exception)(object)"Trying to add weight entry that already exists.");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ResumeButtonHelper._003CEnableButtonWhenReady_003Ed__10 obj2 = default;
			obj2._002Ector((int)layout);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		}
	}

	public WeightList()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MeButtonNotificationHelper meButtonNotificationHelper = default;
		meButtonNotificationHelper.OnEnable();
		object obj = this + 24;
		obj = meButtonNotificationHelper;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
