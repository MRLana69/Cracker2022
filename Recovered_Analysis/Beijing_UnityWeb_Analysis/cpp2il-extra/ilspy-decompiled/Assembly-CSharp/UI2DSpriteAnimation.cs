using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;

public class UI2DSpriteAnimation : MonoBehaviour
{
	public int frameIndex;

	protected int framerate;

	public bool ignoreTimeScale;

	public bool loop;

	public Sprite[] frames;

	private SpriteRenderer mUnitySprite;

	private UI2DSprite mNguiSprite;

	private float mUpdate;

	public bool isPlaying
	{
		get
		{
			//IL_001d: Expected I, but got Obj
			//IL_0033: Expected Obj, but got I
			//IL_005e: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI2DSpriteAnimation)+1B0]");
			if ((nint)0 == -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				ComputeShader computeShader = default;
				if (computeShader.FindKernel(null) != 0)
				{
					UnityEngine.Object obj2 = UnityEngine.Object.Instantiate((UnityEngine.Object)computeShader);
					bool flag = ((string)(object)obj2).EndsWith("Premultiplied");
				}
				else
				{
					bool flag = false;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI2DSpriteAnimation)+1B0]");
			return (nint)0 == 1;
		}
	}

	public unsafe int framesPerSecond
	{
		get
		{
			return isActiveAndEnabled ? 1 : 0;
		}
		set
		{
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected Obj, but got Unknown
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected Obj, but got Unknown
			//IL_00dc: Expected Obj, but got I4
			//IL_00f7: Expected I, but got Obj
			//IL_010d: Expected Obj, but got I
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected Obj, but got Unknown
			//IL_0155: Expected VT, but got I
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Expected Obj, but got Unknown
			//IL_0180: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_005f: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			object obj3 = this + 404;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5+8]");
			_ = 0;
			obj2 = ((int*)value)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+8]");
			_ = 0;
			nint num = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v14 (Il2CppClass<UnityEngine.Vector4>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v34 (Il2CppClass<UnityEngine.Vector4>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PlayerConnection._003CRegister_003Ec__AnonStorey0 obj5 = (PlayerConnection._003CRegister_003Ec__AnonStorey0)(obj2 + 32);
			obj5 = (PlayerConnection._003CRegister_003Ec__AnonStorey0)obj;
			PlayerConnection._003CRegister_003Ec__AnonStorey0 obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			obj6.messageId = (Guid)0;
			UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers messageTypeSubscribers = (UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers)(obj2 + 48);
			messageTypeSubscribers = (UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers)obj2;
			UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers messageTypeSubscribers2 = messageTypeSubscribers;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			messageTypeSubscribers2.m_messageTypeId = (string)0;
			if (obj5._003C_003Em__0(messageTypeSubscribers))
			{
				messageTypeSubscribers = (UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers)((int*)value)->m_value;
				UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers messageTypeSubscribers3 = messageTypeSubscribers;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+8]");
				messageTypeSubscribers3.m_messageTypeId = (string)0;
				object obj7 = this + 404;
				obj7 = messageTypeSubscribers;
				_ = messageTypeSubscribers.m_messageTypeId;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public void Play()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_014a: Expected I, but got Obj
		//IL_0160: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Vector4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector4>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v33 (Il2CppClass<UnityEngine.Vector4>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MessageEventArgs e = default;
		e._002Ector();
		object obj2 = e + 16;
		obj2 = e;
		_ = e.playerId;
		object obj3 = this + 404;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v15+8]");
		_ = 0;
		_ = 1f;
		_ = -1;
		nint num3 = (nint)typeof(UIBasicSprite);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v23 (Il2CppClass<UIBasicSprite>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UIBasicSprite);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v29 (Il2CppClass<UIBasicSprite>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UIDrawCall)this).CreateMaterial();
	}

	public void Pause()
	{
		//IL_01a4: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I4
		if (frames == null)
		{
			return;
		}
		Sprite[] array = frames;
		if (array.Length == 0)
		{
			return;
		}
		if (!isActiveAndEnabled && ~(loop ? 1u : 0u) != 0)
		{
			object obj = ((framerate <= 0) ? ((object)(frameIndex - 1)) : ((object)(frameIndex + 1)));
			if ((nint)obj >= 0)
			{
				Sprite[] array2 = frames;
				if ((nint)obj < array2.Length)
				{
					goto IL_0199;
				}
			}
			int num;
			if (framerate < 0)
			{
				Sprite[] array3 = frames;
				num = array3.Length - 1;
			}
			else
			{
				num = 0;
			}
			frameIndex = num;
		}
		goto IL_0199;
		IL_0199:
		tag = (string)1;
		this._002Ector();
	}

	public void ResetToBeginning()
	{
		tag = null;
	}

	private void Start()
	{
		int num;
		if (framerate < 0)
		{
			Sprite[] array = frames;
			num = array.Length - 1;
		}
		else
		{
			num = 0;
		}
		frameIndex = num;
		this._002Ector();
	}

	private void Update()
	{
		Pause();
	}

	private void UpdateSprite()
	{
		//IL_01df: Expected I4, but got Obj
		int num2;
		if (frames != null)
		{
			Sprite[] array = frames;
			if (array.Length != 0)
			{
				if (framerate == 0)
				{
					return;
				}
				float num = ((~(ignoreTimeScale ? 1u : 0u) != 0) ? Time.timeSinceLevelLoad : Time.unscaledDeltaTime);
				if (!(mUpdate < num))
				{
					return;
				}
				mUpdate = num;
				num2 = ((framerate <= 0) ? (frameIndex - 1) : (frameIndex + 1));
				if (~(loop ? 1u : 0u) != 0)
				{
					if (num2 >= 0)
					{
						Sprite[] array2 = frames;
						if (num2 < array2.Length)
						{
							goto IL_01b8;
						}
					}
					tag = null;
					return;
				}
				goto IL_01b8;
			}
		}
		tag = null;
		return;
		IL_01b8:
		Sprite[] array3 = frames;
		string text = NGUIMath.IntToBinary(num2, array3.Length);
		frameIndex = (int)text;
		this._002Ector();
	}

	public UI2DSpriteAnimation()
	{
		//IL_049b: Expected I, but got Obj
		//IL_04b1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0558: Expected I, but got Obj
		//IL_056e: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_02a9: Expected I, but got Obj
		//IL_02bf: Expected Obj, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_03c3: Expected I, but got Obj
		//IL_03d9: Expected Obj, but got I
		//IL_0337: Expected I, but got Obj
		//IL_011f: Expected Obj, but got VT
		//IL_012d: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected Obj, but got Unknown
		//IL_02ea: Expected I, but got Obj
		//IL_0404: Expected I, but got Obj
		//IL_016e: Expected I, but got Obj
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected Obj, but got Unknown
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected Obj, but got Unknown
		//IL_01bb: Expected I, but got Obj
		//IL_01d1: Expected Obj, but got I
		//IL_01fc: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v67 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mUnitySprite != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v74 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mNguiSprite != null)
			{
				object obj3 = this + 28;
				SpriteRenderer component = GetComponent<SpriteRenderer>();
				obj3 = component;
				object obj4 = this + 32;
				_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
				obj4 = componentInChildren;
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v54 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v70 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (mUnitySprite != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v60 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num8 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S1_v66 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (mNguiSprite != null)
					{
						tag = null;
						return;
					}
				}
			}
		}
		float num9 = ((~(ignoreTimeScale ? 1u : 0u) != 0) ? Time.timeSinceLevelLoad : Time.unscaledDeltaTime);
		if (framerate != 0)
		{
			nint num10 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v37 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num11 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v42 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float value = 1f / (float)framerate;
			float num12 = Math.Abs(value);
			float num13 = num9 + num12;
			mUpdate = num13;
		}
		nint num14 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num15 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mUnitySprite).FindKernel((string)null) != 0)
		{
			object obj9 = frames + 16;
			int num16 = frameIndex << 2;
			object obj10 = obj9 + num16;
			Color color = ((SpriteRenderer)obj10).color;
			return;
		}
		nint num17 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num18 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mNguiSprite).FindKernel((string)null) != 0)
		{
			object obj12 = mNguiSprite + 428;
			object obj13 = frames + 16;
			int num19 = frameIndex << 2;
			object obj14 = obj13 + num19;
			obj12 = obj14;
		}
	}
}
