using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using InAppPurchase;
using Ionic.Zlib;
using Kiloo.Common.Extensions;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;

public class UITexture : UIBasicSprite
{
	private Rect mRect;

	private Texture mTexture;

	private Shader mShader;

	private Vector4 mBorder;

	private bool mFixedAspect;

	private float mPixelSize;

	[NonSerialized]
	private int mPMA;

	public override Texture mainTexture
	{
		get
		{
			//IL_0027: Expected I, but got Obj
			//IL_003d: Expected Obj, but got I
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected Obj, but got Unknown
			//IL_0068: Expected I, but got Obj
			if (((UITextList)(object)this).scrollHeight != 0)
			{
				AnchorPoint anchorPoint = leftAnchor;
				float num = pixelSize;
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v7 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v16 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (UIRect+AnchorPoint)+68]");
				float f = 0f / num;
				int num4 = Mathf.RoundToInt(f);
				Texture texture = (Texture)(mTrans - num4);
				if (0 > (nint)texture)
				{
					return null;
				}
				return texture;
			}
			return null;
		}
		set
		{
			((InitDelegate)(object)this)._002Ector((object)value, (IntPtr)0);
		}
	}

	public override Material material
	{
		get
		{
			//IL_0123: Expected I, but got Obj
			//IL_0139: Expected Obj, but got I
			//IL_006f: Expected I, but got Obj
			//IL_0085: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00b0: Expected I, but got Obj
			//IL_0106: Expected Obj, but got I4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mTexture).FindKernel((string)null) != 0)
			{
				return (Material)(object)mTexture;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mMat).FindKernel((string)null) != 0)
			{
				int renderQueue = mMat.renderQueue;
				return (Material)renderQueue;
			}
			return null;
		}
		set
		{
			//IL_01da: Expected I, but got Obj
			//IL_01f0: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Expected Obj, but got Unknown
			//IL_00a1: Expected I, but got Obj
			//IL_0125: Expected I, but got Obj
			//IL_013b: Expected Obj, but got I
			//IL_0166: Expected I, but got Obj
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v35 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mTexture).FindKernel((string)(object)value) == 0)
			{
				return;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)drawCall).FindKernel((string)null) != 0)
			{
				UIDrawCall uIDrawCall = drawCall;
				if (uIDrawCall.widgetCount == 1)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (mMat != null)
					{
						object obj4 = this + 412;
						obj4 = value;
						drawCall.shader = (Shader)(object)value;
						return;
					}
				}
			}
			base.MarkAsChanged();
			object obj5 = this + 412;
			obj5 = value;
			mPMA = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	public override Shader shader
	{
		get
		{
			return (Shader)(object)mMat;
		}
		set
		{
			//IL_00a8: Expected I, but got Obj
			//IL_00be: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_006c: Expected Obj, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mMat).FindKernel((string)(object)value) != 0)
			{
				base.MarkAsChanged();
				object obj2 = this + 416;
				obj2 = 0;
				object obj3 = this + 112;
				obj3 = value;
				mPMA = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public override bool premultipliedAlpha
	{
		get
		{
			//IL_0130: Expected I, but got Obj
			//IL_0146: Expected Obj, but got I
			//IL_007c: Expected I, but got Obj
			//IL_0092: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0069: Expected I4, but got Obj
			//IL_019b: Expected I4, but got Obj
			//IL_00bd: Expected I, but got Obj
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected Obj, but got Unknown
			//IL_011d: Expected Obj, but got I4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mMat).FindKernel((string)null) != 0)
			{
				Texture texture = mMat.mainTexture;
				return (byte)(int)texture != 0;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mShader != null)
			{
				object obj3 = this + 416;
				int num5 = Shader.PropertyToID("Unlit/Transparent Colored");
				obj3 = num5;
			}
			return (byte)(int)mShader != 0;
		}
	}

	public override Vector4 border
	{
		get
		{
			//IL_01e6: Expected I, but got Obj
			//IL_01fc: Expected Obj, but got I
			//IL_02da: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_022b: Expected Obj, but got I
			//IL_0255: Expected Obj, but got VT
			//IL_025e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Expected Obj, but got Unknown
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Expected Obj, but got Unknown
			//IL_0285: Expected Obj, but got I4
			//IL_00a1: Expected I, but got Obj
			//IL_00f0: Expected Obj, but got I
			//IL_012e: Expected I, but got Obj
			//IL_0144: Expected Obj, but got I
			//IL_02a6: Expected Obj, but got I
			//IL_016f: Expected I, but got Obj
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Expected Obj, but got Unknown
			//IL_01d3: Expected I4, but got Obj
			//IL_01d3: Expected Obj, but got I
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector4)+1A0]");
			Vector4 vector = default;
			if (((ComputeShader)0).FindKernel((string)(object)this) != 0)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector4)+F8]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector4)+F8]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v27+C]");
					if ((nint)0 == 1)
					{
						nint num5 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num6 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector4)+70]");
						if ((UnityEngine.Object)0 != null)
						{
							object obj5 = vector + 416;
							obj5 = this;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector4)+F8]");
							((UIDrawCall)0).shadowMode = (UIDrawCall.ShadowMode)this;
							goto IL_02c3;
						}
					}
				}
				((UIWidget)vector).MarkAsChanged();
				object obj6 = vector + 416;
				obj6 = this;
				_ = -1;
				object obj7 = vector + 112;
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
			goto IL_02c3;
			IL_02c3:
			return vector;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 420;
			UITexture uITexture = (UITexture)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public Rect uvRect
	{
		get
		{
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected Obj, but got Unknown
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected Obj, but got Unknown
			//IL_00e5: Expected I, but got Obj
			//IL_00fb: Expected Obj, but got I
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Expected Obj, but got Unknown
			//IL_0143: Expected VT, but got I
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected Obj, but got Unknown
			//IL_016e: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0066: Expected Obj, but got I
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			Rect rect = default;
			object obj3 = rect + 420;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5+8]");
			_ = 0;
			obj2 = this;
			_ = ((UnityEngine.Object)this).m_CachedPtr;
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
				messageTypeSubscribers = (UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers)(object)this;
				messageTypeSubscribers.m_messageTypeId = (string)(nint)((UnityEngine.Object)this).m_CachedPtr;
				object obj7 = rect + 420;
				obj7 = messageTypeSubscribers;
				_ = messageTypeSubscribers.m_messageTypeId;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
			return rect;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 396;
			UITexture uITexture = (UITexture)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public override float pixelSize
	{
		get
		{
			//IL_00d1: Expected I, but got Obj
			//IL_00e7: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00b0: Expected Obj, but got I
			//IL_009b: Expected Obj, but got I
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)leftAnchor).FindKernel((string)null) != 0)
			{
				AnchorPoint anchorPoint = leftAnchor;
				AnchorPoint anchorPoint2 = leftAnchor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (UIRect+AnchorPoint)+194]");
				object obj2;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (UIRect+AnchorPoint)+19C]");
					obj2 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (UIRect+AnchorPoint)+190]");
					obj2 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v11 (UIRect+AnchorPoint)+130]");
				return 0f + (float)obj2;
			}
			return 20f;
		}
	}

	public unsafe override Vector4 drawingDimensions
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected VT, but got Unknown
			//IL_003e: Expected F4, but got Obj
			//IL_0039: Expected native int or pointer, but got VT
			//IL_0053: Expected F4, but got I
			//IL_004e: Expected native int or pointer, but got VT
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected VT, but got Unknown
			//IL_006b: Expected F4, but got Obj
			//IL_0066: Expected native int or pointer, but got VT
			//IL_007a: Expected F4, but got I
			//IL_0075: Expected native int or pointer, but got VT
			//IL_00ae: Expected F4, but got Obj
			//IL_00a9: Expected native int or pointer, but got VT
			//IL_00bd: Expected F4, but got I
			//IL_00b8: Expected native int or pointer, but got VT
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected Obj, but got Unknown
			//IL_00d8: Expected Obj, but got F4
			Vector4 vector = default;
			object obj = vector + 396;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
			_ = 0;
			Rect rect = (Rect)(obj2 + 16);
			((Rect*)(nint)rect)->m_XMin = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Rect rect2 = (Rect)(obj2 + 32);
			((Rect*)(nint)rect2)->m_XMin = (float)this;
			((Rect*)(nint)rect2)->m_Width = (nint)((UnityEngine.Object)this).m_CachedPtr;
			if (rect == rect2)
			{
				((Rect*)(nint)rect2)->m_XMin = (float)this;
				((Rect*)(nint)rect2)->m_Width = (nint)((UnityEngine.Object)this).m_CachedPtr;
				object obj3 = vector + 396;
				obj3 = rect2.m_XMin;
				_ = rect2.m_Width;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
			return vector;
		}
	}

	public bool fixedAspect
	{
		get
		{
			//IL_001d: Expected I, but got Obj
			//IL_0033: Expected Obj, but got I
			//IL_005e: Expected I, but got Obj
			//IL_00b8: Expected I, but got Obj
			//IL_00ce: Expected Obj, but got I
			//IL_00f9: Expected I, but got Obj
			if (mPMA == -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				ComputeShader computeShader = default;
				int num5;
				if (computeShader.FindKernel(null) != 0)
				{
					Texture texture = ((Material)(object)computeShader).mainTexture;
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S2_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S2_v17 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)texture).FindKernel((string)null) != 0)
					{
						Texture original = ((Material)(object)computeShader).mainTexture;
						UnityEngine.Object obj3 = UnityEngine.Object.Instantiate((UnityEngine.Object)original);
						bool flag = ((string)(object)obj3).EndsWith("Premultiplied");
						num5 = (flag ? 1 : 0);
					}
					else
					{
						num5 = 0;
					}
				}
				else
				{
					num5 = 0;
				}
				mPMA = num5;
			}
			return mPMA == 1;
		}
		set
		{
			//IL_0466: Unknown result type (might be due to invalid IL or missing references)
			//IL_046b: Expected Obj, but got Unknown
			//IL_0474: Expected Obj, but got I4
			//IL_0483: Unknown result type (might be due to invalid IL or missing references)
			//IL_0488: Expected Obj, but got Unknown
			//IL_04a1: Unsupported input type for neg.
			//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a6: Expected Obj, but got Unknown
			//IL_04e5: Expected Obj, but got I
			//IL_0521: Expected I, but got Obj
			//IL_0537: Expected Obj, but got I
			//IL_055d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0562: Expected Obj, but got Unknown
			//IL_056b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0570: Expected Obj, but got Unknown
			//IL_0579: Unknown result type (might be due to invalid IL or missing references)
			//IL_057e: Expected Obj, but got Unknown
			//IL_0590: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_071d: Expected Obj, but got I4
			//IL_072b: Expected I, but got Obj
			//IL_0741: Expected Obj, but got I
			//IL_07b1: Expected F4, but got Obj
			//IL_07d2: Expected Obj, but got I4
			//IL_07eb: Expected F4, but got I
			//IL_080c: Expected Obj, but got I4
			//IL_0825: Expected F4, but got I
			//IL_040a: Expected Obj, but got I4
			//IL_0423: Expected F4, but got I
			//IL_0430: Expected Obj, but got I4
			//IL_0443: Expected Obj, but got F4
			//IL_0452: Expected I, but got F4
			//IL_045c: Expected Obj, but got F4
			//IL_03ae: Expected I, but got Obj
			//IL_00e9: Expected Obj, but got I4
			//IL_05da: Unknown result type (might be due to invalid IL or missing references)
			//IL_05df: Expected Obj, but got Unknown
			//IL_0118: Expected Obj, but got I4
			//IL_0121: Expected Obj, but got I4
			//IL_01c7: Expected Obj, but got I4
			//IL_062a: Unknown result type (might be due to invalid IL or missing references)
			//IL_062f: Expected Obj, but got Unknown
			//IL_01b9: Expected Obj, but got I4
			//IL_01e3: Expected Obj, but got I4
			//IL_0199: Expected Obj, but got I4
			//IL_01a2: Expected Obj, but got I4
			//IL_01d5: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 80;
			obj = 0;
			_ = 0;
			UIWidget uIWidget = (UIWidget)(obj2 + 16);
			uIWidget.width = (value ? 1 : 0);
			obj2 = uIWidget;
			object obj3 = 0 - obj2;
			float num = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+64]");
			float num2 = num * 0f;
			float num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+64]");
			float num4 = num3 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj4 = -0;
			float num5 = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+68]");
			float num6 = num5 * 0f;
			float num7 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+68]");
			float num8 = num7 + 0f;
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v148 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj6 = obj2 - -64;
			object obj7 = obj2 + 48;
			object obj8 = obj2 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+19C]");
			int num11 = ((ComputeShader)0).FindKernel(null);
			bool flag = num11 == 0;
			float num12 = num8;
			float num13 = num6;
			float num14 = num4;
			float num15 = num2;
			float num16;
			object obj12;
			object obj13;
			float num17;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+120]");
				bool flag2 = (nint)0 != 2;
				bool flag3 = !flag2;
				num12 = num8;
				num13 = num6;
				num14 = num4;
				num15 = num2;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					object obj9 = default;
					bool flag4 = (nint)obj9 < 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					object obj10 = default;
					bool flag5 = (nint)obj10 < 1;
					object obj11 = flag4 | flag5;
					if (obj11 != null)
					{
						num16 = 1f;
						obj12 = 0;
						obj13 = 0;
						num17 = 1f;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+120]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+120]");
							if ((nint)0 != 3)
							{
								num16 = 1f;
								obj12 = 0;
								obj13 = 0;
								num17 = 1f;
								goto IL_05fc;
							}
						}
						object obj14 = obj9 & 1;
						object obj15 = ((obj14 == null) ? ((object)0) : ((object)1));
						object obj16 = obj10 & 1;
						object obj17 = ((obj16 == null) ? ((object)0) : ((object)1));
						float num18 = 1f / (float)obj9;
						float num19 = num18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+64]");
						float num20 = num19 * 0f;
						float num21 = 1f / (float)obj10;
						float num22 = num21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+68]");
						num17 = num22 * 0f;
						num16 = num20;
						obj12 = obj15;
						obj13 = obj17;
					}
					goto IL_05fc;
				}
			}
			goto IL_06ea;
			IL_05fc:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+130]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+130]");
				if ((nint)0 != 3)
				{
					float num23 = (float)obj12 * num16;
					float num24 = num4 - num23;
					num14 = num24;
					num15 = num2;
					goto IL_06b7;
				}
			}
			float num25 = (float)obj12 * num16;
			float num26 = num2 + num25;
			num14 = num4;
			num15 = num26;
			goto IL_06b7;
			IL_06b7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+130]");
			if ((nint)0 != 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+130]");
				if ((nint)0 != 3)
				{
					float num27 = (float)obj13 * num17;
					float num28 = num8 - num27;
					num12 = num28;
					num13 = num6;
					goto IL_06ea;
				}
			}
			float num29 = (float)obj13 * num17;
			float num30 = num6 + num29;
			num12 = num8;
			num13 = num30;
			goto IL_06ea;
			IL_06ea:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+1B4]");
			float num31;
			float num32;
			if ((nint)0 != 0)
			{
				num31 = 0f;
				num32 = 0f;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
				obj = uIWidget;
				_ = ((UnityEngine.Object)uIWidget).m_CachedPtr;
				obj2 = uIWidget;
				_ = ((UnityEngine.Object)uIWidget).m_CachedPtr;
				obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				float num33 = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v32+8]");
				float num34 = num33 + 0f;
				obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v34+4]");
				float num35 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v36+C]");
				num32 = num35 + 0f;
				num31 = num34;
			}
			object obj18 = (value ? 1 : 0) + 156;
			nint num36 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v47 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num37 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v68 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float b = num14 - num31;
			float num38 = Mathf.LerpUnclamped(num15, b, (float)obj18);
			float b2 = num12 - num32;
			object obj20 = (value ? 1 : 0) + 156;
			float a = num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S2_v9+4]");
			float num39 = Mathf.LerpUnclamped(a, b2, 0f);
			float a2 = num15 + num31;
			object obj21 = (value ? 1 : 0) + 156;
			float b3 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S2_v12+8]");
			float num40 = Mathf.LerpUnclamped(a2, b3, 0f);
			float a3 = num13 + num32;
			object obj22 = (value ? 1 : 0) + 156;
			float b4 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S2_v15+C]");
			float num41 = Mathf.LerpUnclamped(a3, b4, 0f);
			UITexture uITexture = (UITexture)0;
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
			uITexture = (UITexture)num38;
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)num40;
			leftAnchor = (AnchorPoint)num41;
		}
	}

	public bool applyGradient
	{
		get
		{
			return mFixedAspect;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002f: Expected Obj, but got I4
			//IL_005f: Expected Obj, but got I4
			//IL_006e: Expected Obj, but got F4
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			bool flag = mFixedAspect;
			object obj3 = flag ^ value;
			if (obj3 != null)
			{
				mFixedAspect = value;
				obj2 = 0;
				_ = 0;
				obj2 = 0f;
				_ = 0f;
				_ = 1f;
				_ = 1f;
				obj = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				object obj4 = this + 156;
				obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public Color gradientTop
	{
		get
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected Obj, but got Unknown
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+134]");
			bool flag = (nint)0 != 0;
			object obj = flag ^ this;
			if (obj != null)
			{
				object obj2 = this & 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
			Color result = default;
			return result;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 312;
			UITexture uITexture = (UITexture)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public unsafe Color gradientBottom
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected I, but got Unknown
			//IL_0066: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected Obj, but got Unknown
			//IL_00c3: Expected Obj, but got I
			Color color = default;
			object obj = color + 312;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
			_ = 0;
			Gradient gradient = (Gradient)(obj2 + 16);
			gradient = (Gradient)obj2;
			Gradient gradient2 = gradient;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			gradient2.m_Ptr = (IntPtr)0;
			nint num = (nint)(obj2 + 32);
			((IntPtr*)num)->m_value = (void*)(nint)this;
			_ = ((UnityEngine.Object)this).m_CachedPtr;
			if (gradient.Internal_Equals((IntPtr)num))
			{
				((IntPtr*)num)->m_value = (void*)(nint)this;
				_ = ((UnityEngine.Object)this).m_CachedPtr;
				object obj3 = color + 312;
				obj3 = (object)((IntPtr*)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v10 (System.IntPtr)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+134]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				}
			}
			return color;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 328;
			UITexture uITexture = (UITexture)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public void SetPixelSize(float f)
	{
		Texture texture = mainTexture;
		if ((object)texture != null)
		{
			float num = pixelSize;
			float num2 = f * num;
			float num3 = num2 / (float)texture;
			float val = (float)mGo - num3;
			((UITextList)(object)this).OnScroll(val);
		}
	}

	public override void MakePixelPerfect()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_0031: Expected Obj, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		topAnchor = (AnchorPoint)100;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 10;
		object obj3 = this + 28;
		obj3 = obj2;
		CancelInvoke();
	}

	protected override void OnUpdate()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_024c: Expected I, but got Obj
		//IL_0262: Expected Obj, but got I
		//IL_010f: Expected I, but got Obj
		//IL_01d0: Expected Obj, but got I4
		AdaptScale();
		if (mType == Type.Tiled)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v49 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj2 = default;
		if (obj2 != null || (mType != Type.Simple && mType != Type.Filled && base.premultipliedAlpha))
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj2).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			object obj4 = default;
			object obj5 = default;
			float f = (float)obj4 * (float)obj5;
			int num5 = NumberExtensions.CeilToInt(f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			object obj6 = default;
			object obj7 = default;
			float f2 = (float)obj6 * (float)obj7;
			int num6 = NumberExtensions.CeilToInt(f2);
			height = num5;
			Color color = ((UIWidget)num6).color;
		}
	}

	public unsafe override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected Obj, but got Unknown
		//IL_042f: Expected Obj, but got I4
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected Obj, but got Unknown
		//IL_044c: Expected Obj, but got I4
		//IL_046a: Expected I, but got Obj
		//IL_0480: Expected Obj, but got I
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected VT, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected I4, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected Obj, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected Obj, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got VT
		//IL_00c5: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		//IL_013c: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01db: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_0208: Expected Obj, but got I
		//IL_0218: Expected Obj, but got I
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_023d: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I
		//IL_026a: Expected Obj, but got I
		//IL_02bc: Expected F4, but got Obj
		//IL_02b7: Expected native int or pointer, but got VT
		//IL_02d1: Expected F4, but got I
		//IL_02cc: Expected native int or pointer, but got VT
		//IL_0336: Expected F4, but got Obj
		//IL_0331: Expected native int or pointer, but got VT
		//IL_034b: Expected F4, but got I
		//IL_0346: Expected native int or pointer, but got VT
		//IL_0387: Expected I4, but got Obj
		//IL_03a1: Expected F4, but got Obj
		//IL_039c: Expected native int or pointer, but got VT
		//IL_03b6: Expected F4, but got I
		//IL_03b1: Expected native int or pointer, but got VT
		//IL_03d0: Expected I4, but got VT
		//IL_03d0: Expected I4, but got Obj
		//IL_03d0: Expected I4, but got Obj
		//IL_0413: Expected I4, but got Obj
		//IL_0413: Expected I4, but got Obj
		//IL_0413: Expected I4, but got Obj
		//IL_0413: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 80;
		obj = 0;
		_ = 0;
		object obj3 = obj2 - -64;
		obj3 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v110 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Rect rect = (Rect)(obj2 + 112);
		int num3 = obj2 + 96;
		object obj5 = obj2 + 48;
		object obj6 = obj2 + 32;
		object obj7 = obj2 + 16;
		UnityEngine.Object obj8 = default;
		if (obj8 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+198]");
		if ((nint)0 == 0)
		{
			object obj9 = this + 408;
			Rect rect2 = mRect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+190]");
			string randomSprite = ((UIAtlas)rect2).GetRandomSprite((string)0);
			obj9 = randomSprite;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+198]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+198]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+198]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+198]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+198]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v20+C]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v43+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v46+14]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v49+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+198]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+198]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v56+24]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v26+10]");
			object obj16 = num4 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+198]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+198]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v60+14]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v29+1C]");
			object obj19 = num5 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+198]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v32+20]");
			object obj21 = obj19 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+198]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+198]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v65+18]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v35+28]");
			object obj24 = num6 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+198]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v38+24]");
			object obj26 = obj24 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+198]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+198]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v41+1C]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S2_v5+C]");
			object obj29 = num7 + 0;
			obj3 = obj29;
			obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			((Rect*)(nint)rect)->m_XMin = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v26+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			int num8 = default;
			int num9 = default;
			Rect rect3 = NGUIMath.MakePixelPerfect(rect, num8, num9);
			obj = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28+8]");
			_ = 0;
			obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			((Rect*)(nint)rect)->m_XMin = (float)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v30+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			int num10 = default;
			int num11 = default;
			Rect rect4 = NGUIMath.MakePixelPerfect(rect, num10, num11);
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			((int*)num3)->m_value = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			((Rect*)(nint)rect)->m_XMin = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			SetAnchor((GameObject)(object)verts, (int)uvs, (int)cols, num3, (int)rect);
			if (onPostFill != null)
			{
				OnPostFillCallback onPostFillCallback = onPostFill;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
				((DeflateManager.Config)(object)onPostFillCallback)._002Ector((int)this, 0, (int)verts, (int)uvs, (DeflateFlavor)cols);
			}
		}
	}

	public UITexture()
	{
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_01a2: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got F4
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected I4, but got Unknown
		//IL_01cf: Expected Obj, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected I4, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0128: Expected Obj, but got I4
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected I4, but got Unknown
		//IL_0173: Expected Obj, but got F4
		object obj = default;
		UIWidget uIWidget = (UIWidget)(obj + 16);
		base.OnDisable();
		if (~(mFixedAspect ? 1u : 0u) != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v57 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj4 = default;
			object obj3 = obj4 & 1;
			bool flag = obj3 == null;
			object obj5 = obj4;
			if (!flag)
			{
				object obj6 = obj4 + 1;
				obj5 = obj6;
			}
			object obj8 = default;
			object obj7 = obj8 & 1;
			bool flag2 = obj7 == null;
			object obj9 = obj8;
			if (!flag2)
			{
				object obj10 = obj8 + 1;
				obj9 = obj10;
			}
			object obj11 = obj5 / obj9;
			int num3 = mWidth / mHeight;
			if ((nint)obj11 < num3)
			{
				obj = 0;
				_ = 0;
				object obj12 = mHeight * obj11;
				object obj13 = mWidth - obj12;
				int num4 = obj13 / mWidth;
				float num5 = (float)num4 * 0.5f;
				obj = num5;
				_ = 0f;
				float num6 = 1f - num5;
				_ = 1f;
			}
			else
			{
				obj = 0;
				_ = 0;
				obj = 0f;
				int num7 = mWidth / obj11;
				object obj14 = mHeight - num7;
				int num8 = obj14 / mHeight;
				float num9 = (float)num8 * 0.5f;
				_ = 1f;
				float num10 = 1f - num9;
			}
			uIWidget = (UIWidget)obj;
			UIWidget uIWidget2 = uIWidget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)uIWidget2).m_CachedPtr = (IntPtr)0;
			Vector2 vector = uIWidget.pivotOffset;
		}
	}
}
