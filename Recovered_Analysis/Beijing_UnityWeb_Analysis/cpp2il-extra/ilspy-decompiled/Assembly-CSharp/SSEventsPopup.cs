using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using SYBO.Subway.Info;
using UI.FreeStuff;
using UI.Generic;
using UI.Generic.Layout;
using UI.Screens;
using UI.Screens.BoardScreenInternal;
using UI.Screens.RewardManagement;
using UnityEngine;
using UnityEngine.U2D;

public class SSEventsPopup : UIScreen
{
	[Serializable]
	private class EventTypeGameObjectPair
	{
		public SSEventType _eventType;

		public GameObject _gameObject;

		public EventTypeGameObjectPair()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private sealed class _003CDelayPositioning_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISprite tracker;

		public GameObject objectToPosition;

		public Vector3 positionOffset;

		public Vector3 newRotation;

		public Vector3 newScale;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d8: Expected VT, but got Unknown
				//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e6: Expected VT, but got Unknown
				//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f4: Expected Obj, but got Unknown
				//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0402: Expected Obj, but got Unknown
				//IL_040b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0410: Expected Obj, but got Unknown
				//IL_0419: Unknown result type (might be due to invalid IL or missing references)
				//IL_041e: Expected Obj, but got Unknown
				//IL_0427: Unknown result type (might be due to invalid IL or missing references)
				//IL_042c: Expected Obj, but got Unknown
				//IL_0435: Unknown result type (might be due to invalid IL or missing references)
				//IL_043a: Expected Obj, but got Unknown
				//IL_0443: Unknown result type (might be due to invalid IL or missing references)
				//IL_0448: Expected Obj, but got Unknown
				//IL_0451: Unknown result type (might be due to invalid IL or missing references)
				//IL_0456: Expected Obj, but got Unknown
				//IL_045f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0464: Expected Ref, but got Unknown
				//IL_046d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0472: Expected Obj, but got Unknown
				//IL_047b: Expected Obj, but got I4
				//IL_048a: Unknown result type (might be due to invalid IL or missing references)
				//IL_048f: Expected Obj, but got Unknown
				//IL_0498: Expected Obj, but got I4
				//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ac: Expected Obj, but got Unknown
				//IL_04b5: Expected Obj, but got I4
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0065: Expected Obj, but got I4
				//IL_0091: Expected VT, but got Obj
				//IL_00b6: Expected I, but got Obj
				//IL_00cc: Expected Obj, but got I
				//IL_04f5: Expected F4, but got Obj
				//IL_04f0: Expected native int or pointer, but got VT
				//IL_050a: Expected F4, but got I
				//IL_0505: Expected native int or pointer, but got VT
				//IL_051f: Expected Obj, but got I
				//IL_0143: Expected F4, but got Obj
				//IL_013e: Expected native int or pointer, but got VT
				//IL_0158: Expected F4, but got I
				//IL_0153: Expected native int or pointer, but got VT
				//IL_016d: Expected Obj, but got I
				//IL_00f7: Expected I, but got Obj
				//IL_01a7: Expected F4, but got Obj
				//IL_01a2: Expected native int or pointer, but got VT
				//IL_01bc: Expected F4, but got I
				//IL_01b7: Expected native int or pointer, but got VT
				//IL_01c5: Expected Obj, but got VT
				//IL_01f9: Expected VT, but got I4
				//IL_0204: Unknown result type (might be due to invalid IL or missing references)
				//IL_0209: Expected Obj, but got Unknown
				//IL_022c: Expected I, but got Obj
				//IL_0242: Expected Obj, but got I
				//IL_0598: Expected F4, but got Obj
				//IL_0593: Expected native int or pointer, but got VT
				//IL_05aa: Expected F4, but got I
				//IL_05a5: Expected native int or pointer, but got VT
				//IL_05b7: Expected F4, but got Obj
				//IL_05b2: Expected native int or pointer, but got VT
				//IL_05cc: Expected F4, but got I
				//IL_05c7: Expected native int or pointer, but got VT
				//IL_05ea: Expected F4, but got Obj
				//IL_05e5: Expected native int or pointer, but got VT
				//IL_05ff: Expected F4, but got I
				//IL_05fa: Expected native int or pointer, but got VT
				//IL_0608: Expected Obj, but got VT
				//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b7: Expected Obj, but got Unknown
				//IL_02c4: Expected F4, but got Obj
				//IL_02bf: Expected native int or pointer, but got VT
				//IL_02d9: Expected F4, but got I
				//IL_02d4: Expected native int or pointer, but got VT
				//IL_02e7: Expected I, but got Obj
				//IL_02fd: Expected Obj, but got I
				//IL_026d: Expected I, but got Obj
				//IL_062d: Expected native int or pointer, but got VT
				//IL_063f: Expected native int or pointer, but got VT
				//IL_0651: Expected Ref, but got VT
				//IL_0663: Expected F4, but got VT
				//IL_065e: Expected native int or pointer, but got VT
				//IL_0678: Expected F4, but got I
				//IL_0673: Expected native int or pointer, but got VT
				//IL_0681: Expected Obj, but got VT
				//IL_036d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0372: Expected Obj, but got Unknown
				//IL_0394: Expected F4, but got Obj
				//IL_038f: Expected native int or pointer, but got VT
				//IL_03a9: Expected F4, but got I
				//IL_03a4: Expected native int or pointer, but got VT
				//IL_03b6: Expected Obj, but got VT
				//IL_03b6: Expected Obj, but got I4
				//IL_0328: Expected I, but got Obj
				object obj = default;
				Vector3 vector = (Vector3)(obj + 176);
				Vector3 vector2 = (Vector3)(obj + 164);
				Transform transform = (Transform)(obj + 116);
				object obj2 = obj + 104;
				object obj3 = obj + 92;
				object obj4 = obj + 80;
				object obj5 = obj + 68;
				Transform transform2 = (Transform)(obj + 56);
				object obj6 = obj + 44;
				object obj7 = obj + 32;
				ref Quaternion reference = ref *(Quaternion*)(obj + 16);
				object obj8 = obj + 152;
				obj8 = 0;
				_ = 0;
				object obj9 = obj + 140;
				obj9 = 0;
				_ = 0;
				object obj10 = obj + 128;
				obj10 = 0;
				_ = 0;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						GameObject gameObject = tracker.gameObject;
						transform.position = (Vector3)gameObject;
						obj8 = transform;
						_ = ((UnityEngine.Object)transform).m_CachedPtr;
						nint num = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v52 (Il2CppClass<UIScreenController>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num2 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v96 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag = UIScreenController.ShouldShowOnlineScreen();
						((Vector3*)(nint)vector)->x = (float)obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
						((Vector3*)(nint)vector)->z = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v57 (System.Boolean)+30]");
						Vector3 vector3 = ((Camera)0).WorldToViewportPoint(vector);
						obj9 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
						_ = 0;
						obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
						_ = 0;
						obj4 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v34+8]");
						_ = 0;
						obj9 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+4]");
						_ = 0;
						_ = 1f;
						bool flag2 = UIScreenController.ShouldShowOnlineScreen();
						((Vector3*)(nint)vector)->x = (float)obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v34+8]");
						((Vector3*)(nint)vector)->z = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v76 (System.Boolean)+20]");
						Vector3 vector4 = ((Camera)0).ScreenToViewportPoint(vector);
						obj10 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
						_ = 0;
						int layer = objectToPosition.layer;
						((Vector3*)(nint)vector)->x = (float)obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v37+8]");
						((Vector3*)(nint)vector)->z = 0f;
						Vector3 localPosition = ((Transform)vector).localPosition;
						int layer2 = objectToPosition.layer;
						int layer3 = objectToPosition.layer;
						transform2.localPosition = (Vector3)layer3;
						object obj12 = this + 24;
						obj6 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S2_v15+8]");
						_ = 0;
						nint num3 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S1_v78 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num4 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S1_v114 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Vector3*)(nint)vector2)->x = (float)transform2;
						((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
						((Vector3*)(nint)vector)->x = (float)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
						((Vector3*)(nint)vector)->z = 0f;
						Vector3 vector5 = vector2 - vector;
						((Vector3*)(nint)vector)->x = (float)obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+8]");
						((Vector3*)(nint)vector)->z = 0f;
						Vector3 eulerAngles = ((Transform)vector).eulerAngles;
						int layer4 = objectToPosition.layer;
						object obj14 = this + 36;
						((Vector3*)(nint)vector2)->x = (float)obj14;
						Vector3 vector6 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S2_v35+8]");
						((Vector3*)(nint)vector6)->z = 0f;
						nint num5 = (nint)typeof(Quaternion);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S1_v94 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						if (obj15 != null)
						{
							nint num6 = (nint)typeof(Quaternion);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S1_v110 (Il2CppClass<UnityEngine.Quaternion>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Vector3*)(nint)vector)->x = vector2.x;
						((Vector3*)(nint)vector)->z = vector2.z;
						Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)vector);
						((Vector3*)(nint)vector)->x = (float)reference;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29 (UnityEngine.Quaternion&)+8]");
						((Vector3*)(nint)vector)->z = 0f;
						Vector3 localScale = ((Transform)vector).localScale;
						int layer5 = objectToPosition.layer;
						object obj16 = this + 48;
						obj = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S2_v51+8]");
						_ = 0;
						((Vector3*)(nint)vector)->x = (float)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Vector3*)(nint)vector)->z = 0f;
						((Transform)layer5).parent = (Transform)vector;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj17 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj18 = default;
				obj17 = obj18;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public unsafe _003CDelayPositioning_003Ed__85(int _003C_003E1__state)
		{
			//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03de: Expected Obj, but got Unknown
			//IL_03e7: Expected Obj, but got I4
			//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ff: Expected Obj, but got Unknown
			//IL_0408: Expected Obj, but got I4
			//IL_041b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0420: Expected Obj, but got Unknown
			//IL_0429: Expected Obj, but got I4
			//IL_0443: Expected Obj, but got I4
			//IL_044b: Expected Obj, but got I4
			//IL_0463: Expected I, but got Obj
			//IL_0479: Expected Obj, but got I
			//IL_0844: Unknown result type (might be due to invalid IL or missing references)
			//IL_0849: Expected I4, but got Unknown
			//IL_0852: Unknown result type (might be due to invalid IL or missing references)
			//IL_0857: Expected I4, but got Unknown
			//IL_0860: Unknown result type (might be due to invalid IL or missing references)
			//IL_0865: Expected I4, but got Unknown
			//IL_086e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0873: Expected Obj, but got Unknown
			//IL_0885: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0073: Expected I4, but got Obj
			//IL_00a1: Expected Obj, but got I
			//IL_00c5: Expected Obj, but got I4
			//IL_00c5: Expected Obj, but got I
			//IL_00d7: Expected I, but got Obj
			//IL_00ed: Expected Obj, but got I
			//IL_04a9: Expected Obj, but got I
			//IL_0118: Expected I, but got Obj
			//IL_0165: Expected I, but got Obj
			//IL_017b: Expected Obj, but got I
			//IL_04e0: Expected Obj, but got I4
			//IL_04f5: Expected Obj, but got I
			//IL_050b: Expected Obj, but got I4
			//IL_0520: Expected Obj, but got I
			//IL_01f2: Expected Obj, but got I4
			//IL_0207: Expected Obj, but got I
			//IL_01a6: Expected I, but got Obj
			//IL_068e: Expected I4, but got Obj
			//IL_06a5: Expected I4, but got Obj
			//IL_06bc: Expected I4, but got Obj
			//IL_06ed: Expected Obj, but got I
			//IL_06ed: Expected Obj, but got I4
			//IL_023f: Expected I, but got Obj
			//IL_0255: Expected Obj, but got I
			//IL_0272: Expected I, but got Obj
			//IL_0326: Expected I, but got Obj
			//IL_033c: Expected Obj, but got I
			//IL_0359: Expected I, but got Obj
			//IL_0544: Expected Obj, but got I
			//IL_0551: Expected I4, but got Obj
			//IL_0594: Expected I4, but got Obj
			//IL_05a2: Expected I, but got Obj
			//IL_05b8: Expected Obj, but got I
			//IL_05c5: Expected I4, but got Obj
			//IL_0608: Expected I4, but got Obj
			//IL_0616: Expected I, but got Obj
			//IL_062c: Expected Obj, but got I
			//IL_064e: Expected I4, but got Obj
			//IL_0672: Expected I4, but got Obj
			//IL_0708: Expected Obj, but got I
			//IL_0715: Expected I4, but got Obj
			//IL_0758: Expected I4, but got Obj
			//IL_0766: Expected I, but got Obj
			//IL_077c: Expected Obj, but got I
			//IL_0789: Expected I4, but got Obj
			//IL_07cc: Expected I4, but got Obj
			//IL_07da: Expected I, but got Obj
			//IL_07f0: Expected Obj, but got I
			//IL_0812: Expected I4, but got Obj
			//IL_0836: Expected I4, but got Obj
			//IL_028e: Expected I, but got Obj
			//IL_02be: Expected I, but got Obj
			//IL_0375: Expected I, but got Obj
			//IL_03a5: Expected I, but got Obj
			//IL_02e4: Expected I, but got Obj
			//IL_03cb: Expected I, but got Obj
			object obj = default;
			PurchaseHandler purchaseHandler = (PurchaseHandler)(obj + 44);
			purchaseHandler = (PurchaseHandler)0;
			purchaseHandler.onUpgradePurchase = null;
			PurchaseHandler purchaseHandler2 = (PurchaseHandler)(obj + 32);
			purchaseHandler2 = (PurchaseHandler)0;
			purchaseHandler2.onUpgradePurchase = null;
			PurchaseHandler purchaseHandler3 = (PurchaseHandler)(obj + 20);
			purchaseHandler3 = (PurchaseHandler)0;
			purchaseHandler3.onUpgradePurchase = null;
			object obj2 = this._003C_003E1__state + 56;
			obj2 = _003C_003E1__state;
			int num = this._003C_003E1__state;
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v132 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num4 = obj + 80;
			int num5 = obj + 68;
			Boards.BoardId boardId = (Boards.BoardId)(obj + 56);
			object obj4 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (System.Int32)+38]");
			if ((UnityEngine.Object)0 != null)
			{
				return;
			}
			int num6 = this._003C_003E1__state;
			obj = _003C_003E2__current;
			((int*)num4)->m_value = (int)obj;
			_ = ((int*)num4)->m_value;
			int num7 = this._003C_003E1__state;
			bool isInstanced = UIScreenController.IsInstanced;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S2_v13 (System.Boolean)+18]");
			int layer = ((GameObject)0).layer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v34 (System.Int32)+38]");
			GameObject ht = ((SSEventsPopup)null).PlacePrefabUnderAnchor((GameObject)0, (Transform)layer, 31);
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v34 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v143 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v34 (System.Int32)+38]");
			if (((ComputeShader)0).FindKernel(null) == 0)
			{
				return;
			}
			nint num10 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v41 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num11 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v139 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			purchaseHandler = (PurchaseHandler)((int*)num4)->m_value;
			PurchaseHandler purchaseHandler4 = purchaseHandler;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v20 (System.Int32)+8]");
			purchaseHandler4.onUpgradePurchase = (Action<UpgradeType, int>)0;
			Vector3 one2 = Vector3.one;
			purchaseHandler2 = (PurchaseHandler)((int*)num5)->m_value;
			PurchaseHandler purchaseHandler5 = purchaseHandler2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v22 (System.Int32)+8]");
			purchaseHandler5.onUpgradePurchase = (Action<UpgradeType, int>)0;
			Vector3 one3 = Vector3.one;
			purchaseHandler3 = (PurchaseHandler)((Boards.BoardId*)(int)boardId)->value__;
			PurchaseHandler purchaseHandler6 = purchaseHandler3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v24 (Info.Boards+BoardId)+8]");
			purchaseHandler6.onUpgradePurchase = (Action<UpgradeType, int>)0;
			if ((nint)objectToPosition == 3)
			{
				nint num12 = (nint)typeof(SSEventsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v104 (Il2CppClass<SSEventsPopup>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				bool flag = obj7 == null;
				nint num13 = (nint)typeof(SSEventsPopup);
				if (!flag)
				{
					nint num14 = (nint)typeof(SSEventsPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v133 (Il2CppClass<SSEventsPopup>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num13 = (nint)typeof(SSEventsPopup);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num13 = (nint)typeof(SSEventsPopup);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ L1_v16 (Il2CppClass<SSEventsPopup>)+5C]");
				object obj8 = (nint)0 + (nint)36;
				((int*)num5)->m_value = (int)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S1_v99+8]");
				_ = 0;
				((int*)num4)->m_value = ((int*)num5)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v22 (System.Int32)+8]");
				_ = 0;
				purchaseHandler.PurchaseCharacter(Characters.CharacterId.slick, (int)"event_popup_element_new_position_offset", num4);
				nint num15 = (nint)typeof(SSEventsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S1_v109 (Il2CppClass<SSEventsPopup>)+5C]");
				object obj9 = (nint)0 + (nint)48;
				((Boards.BoardId*)(int)boardId)->value__ = (int)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S1_v111+8]");
				_ = 0;
				((int*)num4)->m_value = ((Boards.BoardId*)(int)boardId)->value__;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v24 (Info.Boards+BoardId)+8]");
				_ = 0;
				purchaseHandler2.PurchaseCharacter(Characters.CharacterId.slick, (int)"event_popup_element_new_rotation", num4);
				nint num16 = (nint)typeof(SSEventsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S1_v121 (Il2CppClass<SSEventsPopup>)+5C]");
				object obj10 = (nint)0 + (nint)60;
				obj4 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S1_v123+8]");
				_ = 0;
				((int*)num4)->m_value = (int)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v26+8]");
				_ = 0;
				purchaseHandler3.PurchaseCharacter(Characters.CharacterId.slick, (int)"event_popup_element_new_scale", num4);
			}
			else if ((nint)objectToPosition == 7)
			{
				nint num17 = (nint)typeof(SSEventsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v66 (Il2CppClass<SSEventsPopup>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				bool flag4 = obj11 == null;
				nint num18 = (nint)typeof(SSEventsPopup);
				if (!flag4)
				{
					nint num19 = (nint)typeof(SSEventsPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v95 (Il2CppClass<SSEventsPopup>)+74]");
					bool flag5 = (nint)0 == 0;
					bool flag6 = !flag5;
					num18 = (nint)typeof(SSEventsPopup);
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num18 = (nint)typeof(SSEventsPopup);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ L1_v7 (Il2CppClass<SSEventsPopup>)+5C]");
				object obj12 = (nint)0 + (nint)72;
				((int*)num5)->m_value = (int)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ S1_v63+8]");
				_ = 0;
				((int*)num4)->m_value = ((int*)num5)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v22 (System.Int32)+8]");
				_ = 0;
				purchaseHandler.PurchaseCharacter(Characters.CharacterId.slick, (int)"event_popup_element_new_position_offset", num4);
				nint num20 = (nint)typeof(SSEventsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S1_v73 (Il2CppClass<SSEventsPopup>)+5C]");
				object obj13 = (nint)0 + (nint)84;
				((Boards.BoardId*)(int)boardId)->value__ = (int)obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S1_v75+8]");
				_ = 0;
				((int*)num4)->m_value = ((Boards.BoardId*)(int)boardId)->value__;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v24 (Info.Boards+BoardId)+8]");
				_ = 0;
				purchaseHandler2.PurchaseCharacter(Characters.CharacterId.slick, (int)"event_popup_element_new_rotation", num4);
				nint num21 = (nint)typeof(SSEventsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S1_v85 (Il2CppClass<SSEventsPopup>)+5C]");
				object obj14 = (nint)0 + (nint)96;
				obj4 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S1_v87+8]");
				_ = 0;
				((int*)num4)->m_value = (int)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v26+8]");
				_ = 0;
				purchaseHandler3.PurchaseCharacter(Characters.CharacterId.slick, (int)"event_popup_element_new_scale", num4);
			}
			int num22 = this._003C_003E1__state;
			((Boards.BoardId*)(int)boardId)->value__ = (int)purchaseHandler;
			_ = purchaseHandler.onUpgradePurchase;
			((int*)num5)->m_value = (int)purchaseHandler2;
			_ = purchaseHandler2.onUpgradePurchase;
			((int*)num4)->m_value = (int)purchaseHandler3;
			_ = purchaseHandler3.onUpgradePurchase;
			int num23 = this._003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S1_v57 (System.Int32)+90]");
			((UIHoverboardThemeShifter)num23).SetActiveBubbles((HoverboardThemeButton)0, (HoverboardThemes.HoverboardTheme)(object)ht, boardId, num5, num4);
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

	private List<EventTypeGameObjectPair> _stateGameObjects;

	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_POSITION_OFFSET = "event_popup_element_new_position_offset";

	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_ROTATION = "event_popup_element_new_rotation";

	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_SCALE = "event_popup_element_new_scale";

	private Color32 _timerBackgroundColor;

	private Color32 _timerContentColor;

	private static Vector3 SPECIAL_POWER_BOARD_POSITION_OFFSET;

	private static Vector3 SPECIAL_POWER_BOARD_ROTATION;

	private static Vector3 SPECIAL_POWER_BOARD_SCALE;

	private static Vector3 LIMITED_CHAR_POSITION_OFFSET;

	private static Vector3 LIMITED_CHAR_ROTATION;

	private static Vector3 LIMITED_CHAR_SCALE;

	private static Vector3 CHARACTER_DAY_MODEL_POSITION_OFFSET;

	private static Vector3 CHARACTER_DAY_MODEL_ROTATION;

	private static Vector3 CHARACTER_DAY_MODEL_SCALE;

	private static Vector3 MYSTERY_POWERUP_POSITION_OFFSET;

	private static Vector3 MYSTERY_POWERUP_ROTATION;

	private static Vector3 MYSTERY_POWERUP_SCALE;

	private GameObject _specialPowerBoard;

	private GameObject _limitedCharacter;

	private GameObject _mysteryPowerup;

	private UISprite _bgFill;

	private UISprite _bgOutline;

	private UILabel _eventTitleLine1;

	private UILabel _eventTitleLine2;

	private UILabel _checkItOutLabel;

	private UILabel _messageTitleLabel;

	private UILabel _messageSecondTitleLabel;

	private GameObject _twoLinesDescription;

	private Layout _twoLinesLayout;

	private GameObject _jackpotBottomElements;

	private GameObject _jackpotTopElements;

	private GameObject _jackpotTopElementsHearts;

	private GameObject _jackpotTopElementsNormal;

	private GameObject _goToItemButton;

	private UILabel _jackpotsDescriptionLabel;

	private UILabel _MBJackpotLabel;

	private UILabel _SMBJackpotLabel;

	private UISprite _coinLeft;

	private UISprite _coinRight;

	private UISprite _bottomDescriptionBoxSprite;

	private UISprite _topSplatSprite;

	private UISprite _glowEffectSprite;

	private List<UISprite> _listBgStripes;

	private GameObject _mysteryPowerupPrefab;

	private TimerHelper _timerPrefab;

	private UIWidget _timerContainer;

	private TimerHelper _timer;

	private const float COIN_SPRITE_OFFSET = 2f;

	private IEventManager _activeEventManager;

	private readonly Vector2 _dimensionsBgFillNormalEvent;

	private readonly Vector2 _dimensionsBgOutlineNormalEvent;

	private readonly Vector2 _dimensionsBgFillCheckOutItemEvent;

	private readonly Vector2 _dimensionsBgOutlineCheckOutItemEvent;

	private readonly Vector2 _dimensionsBgFillExtendedCheckOutItemEvent;

	private readonly Vector2 _dimensionsBgOutlineExtendedCheckOutItemEvent;

	private const int DESCRIPTION_BOX_NORMAL_HEIGHT = 80;

	private const int DESCRIPTION_BOX_EXTENDED_HEIGHT = 105;

	private Characters.CharacterId? _cachedCharacter;

	private List<SSEventCategory> _supportedCategories;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void Show()
	{
		ShowIfInactive();
		UpdateUIElements();
	}

	public unsafe override void Hide()
	{
		//IL_03a3: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected Obj, but got Unknown
		//IL_03d6: Expected Obj, but got I4
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_0442: Expected I, but got Obj
		//IL_0458: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected Obj, but got Unknown
		//IL_0552: Expected I, but got Obj
		//IL_0568: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_02e8: Expected I, but got Obj
		//IL_0335: Expected I, but got Obj
		//IL_0178: Expected I, but got Obj
		//IL_018e: Expected Obj, but got I
		//IL_00ec: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I4
		//IL_0237: Expected I, but got Obj
		//IL_024d: Expected Obj, but got I
		//IL_01b9: Expected I, but got Obj
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_0224: Expected Obj, but got I4
		//IL_0278: Expected I, but got Obj
		//IL_02d5: Expected Obj, but got I4
		base.Hide();
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).DeactivateModelScreen(UIModelController.ModelScreen.TutorialPopup);
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v73 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 172;
		string flurryUserId = Flurry.flurryUserId;
		bool flag = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick);
		obj2 = flag;
		if (_activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v68 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = default;
			if (((ComputeShader)(object)_specialPowerBoard).FindKernel((string)null) != 0)
			{
				bool flag2 = (nint)obj4 == 1;
				bool flag3 = (nint)obj4 == 6;
				string text = (string)(flag2 | flag3);
				_specialPowerBoard.tag = text;
			}
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v61 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_limitedCharacter).FindKernel((string)null) != 0)
			{
				object obj6 = obj4 | 4;
				bool flag4 = (nint)obj6 == 7;
				_limitedCharacter.tag = (string)flag4;
			}
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v54 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_mysteryPowerup).FindKernel((string)null) != 0)
			{
				bool flag5 = (nint)obj4 == 5;
				_mysteryPowerup.tag = (string)flag5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(SSEventsPopup.HidePopupIfNeeded);
		object obj8 = action + 16;
		obj8 = this;
		nint num9 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v25 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num10 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v50 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventFinishedHandler -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(SSEventsPopup.HidePopupIfNeeded);
		object obj10 = action2 + 16;
		obj10 = this;
		nint num11 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v37 (Il2CppClass<UIScreenController>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num12 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v46 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationResumed -= action2;
		SetCategorySpecificElements();
		StartTimer();
		PositionMysteryPowerup3DElements();
		StopTimer();
	}

	private unsafe void InitializeTimer()
	{
		//IL_0319: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00b2: Expected I, but got Obj
		//IL_00c8: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0151: Expected I, but got Obj
		//IL_0167: Expected Obj, but got I
		//IL_00f3: Expected I, but got Obj
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_022f: Expected I, but got Obj
		//IL_0245: Expected Obj, but got I
		//IL_0192: Expected I, but got Obj
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_03e7: Expected I, but got Obj
		//IL_03fd: Expected Obj, but got I
		//IL_0270: Expected I, but got Obj
		//IL_02bd: Expected I, but got Obj
		base.LoseFocus();
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).ClearScreenAnchor(UIModelController.ModelScreen.TutorialPopup);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v53 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_specialPowerBoard).FindKernel((string)null) != 0)
		{
			_specialPowerBoard.tag = null;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_limitedCharacter).FindKernel((string)null) != 0)
		{
			_limitedCharacter.tag = null;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_mysteryPowerup).FindKernel((string)null) != 0)
		{
			_mysteryPowerup.tag = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(SSEventsPopup.HidePopupIfNeeded);
		object obj4 = action + 16;
		obj4 = this;
		nint num7 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v27 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v49 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventChangedHandler += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num9 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj6 = action2 + 16;
		obj6 = this;
		nint num10 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v39 (Il2CppClass<UIScreenController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num11 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v45 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown += action2;
		PresentCurrentEventAvailable();
	}

	private void UpdateUIElements()
	{
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		GameObject parent = _timerContainer.gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 168;
		TimerHelper timerHelper = UnityEngine.Object.Instantiate(_timerPrefab, (Transform)(object)parent);
		obj2 = timerHelper;
	}

	private unsafe void SetCategorySpecificElements()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b52: Expected VT, but got Unknown
		//IL_0b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b60: Expected Obj, but got Unknown
		//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6e: Expected Obj, but got Unknown
		//IL_0b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7c: Expected Obj, but got Unknown
		//IL_0b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8a: Expected Obj, but got Unknown
		//IL_0b93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Expected Obj, but got Unknown
		//IL_0ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba6: Expected Obj, but got Unknown
		//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb4: Expected Obj, but got Unknown
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc2: Expected Obj, but got Unknown
		//IL_0bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd0: Expected Obj, but got Unknown
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Expected Obj, but got Unknown
		//IL_0be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bec: Expected Obj, but got Unknown
		//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Expected Obj, but got Unknown
		//IL_0c03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c08: Expected Obj, but got Unknown
		//IL_0c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c16: Expected Obj, but got Unknown
		//IL_0c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c24: Expected Obj, but got Unknown
		//IL_0c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c32: Expected Obj, but got Unknown
		//IL_0c3b: Expected Obj, but got I4
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4f: Expected Obj, but got Unknown
		//IL_002b: Expected I, but got Obj
		//IL_0041: Expected Obj, but got I
		//IL_0c85: Expected Obj, but got VT
		//IL_0c9a: Expected F4, but got Obj
		//IL_0c95: Expected native int or pointer, but got VT
		//IL_0cb4: Expected F4, but got Obj
		//IL_0caf: Expected native int or pointer, but got VT
		//IL_0cc9: Expected F4, but got I
		//IL_0cc4: Expected native int or pointer, but got VT
		//IL_0cd8: Expected I4, but got VT
		//IL_0ce1: Expected Obj, but got VT
		//IL_0cf6: Expected F4, but got Obj
		//IL_0cf1: Expected native int or pointer, but got VT
		//IL_00b8: Expected F4, but got Obj
		//IL_00b3: Expected native int or pointer, but got VT
		//IL_00cd: Expected F4, but got I
		//IL_00c8: Expected native int or pointer, but got VT
		//IL_00dc: Expected I4, but got VT
		//IL_00e5: Expected Obj, but got VT
		//IL_00fa: Expected F4, but got Obj
		//IL_00f5: Expected native int or pointer, but got VT
		//IL_006c: Expected I, but got Obj
		//IL_0119: Expected F4, but got Obj
		//IL_0114: Expected native int or pointer, but got VT
		//IL_012e: Expected F4, but got I
		//IL_0129: Expected native int or pointer, but got VT
		//IL_013d: Expected I4, but got VT
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_04aa: Expected Obj, but got I4
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected Obj, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Obj, but got Unknown
		//IL_04ce: Expected I, but got Obj
		//IL_04e4: Expected Obj, but got I
		//IL_0175: Expected Obj, but got I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_0199: Expected I, but got Obj
		//IL_01af: Expected Obj, but got I
		//IL_0ddc: Expected F4, but got Obj
		//IL_0ded: Expected I4, but got Obj
		//IL_0df3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df8: Expected Obj, but got Unknown
		//IL_0e09: Expected F4, but got I
		//IL_0d11: Expected F4, but got Obj
		//IL_0d22: Expected I4, but got Obj
		//IL_0d28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2d: Expected Obj, but got Unknown
		//IL_0d3e: Expected F4, but got I
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Obj, but got Unknown
		//IL_056f: Expected F4, but got Obj
		//IL_050f: Expected I, but got Obj
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected Obj, but got Unknown
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected Obj, but got Unknown
		//IL_0601: Expected I, but got Obj
		//IL_0617: Expected Obj, but got I
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_023a: Expected F4, but got Obj
		//IL_01da: Expected I, but got Obj
		//IL_0587: Expected I4, but got Obj
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected Obj, but got Unknown
		//IL_05a3: Expected F4, but got I
		//IL_0e7b: Expected F4, but got Obj
		//IL_0e8c: Expected I4, but got Obj
		//IL_0e92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e97: Expected Obj, but got Unknown
		//IL_0ea8: Expected F4, but got I
		//IL_0252: Expected I4, but got Obj
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_026e: Expected F4, but got I
		//IL_05c3: Expected Obj, but got I4
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected Obj, but got Unknown
		//IL_06a2: Expected F4, but got Obj
		//IL_0642: Expected I, but got Obj
		//IL_028e: Expected Obj, but got I4
		//IL_06ba: Expected I4, but got Obj
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected Obj, but got Unknown
		//IL_06d6: Expected F4, but got I
		//IL_02a5: Expected I, but got Obj
		//IL_02bb: Expected Obj, but got I
		//IL_0e28: Expected Obj, but got I
		//IL_0e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3e: Expected Obj, but got Unknown
		//IL_0e47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4c: Expected Obj, but got Unknown
		//IL_0e5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e64: Expected Obj, but got Unknown
		//IL_0e6d: Expected Obj, but got I4
		//IL_06f6: Expected Obj, but got I4
		//IL_0d50: Expected Obj, but got VT
		//IL_0d65: Expected F4, but got Obj
		//IL_0d60: Expected native int or pointer, but got VT
		//IL_0d7f: Expected F4, but got Obj
		//IL_0d7a: Expected native int or pointer, but got VT
		//IL_0d94: Expected F4, but got I
		//IL_0d8f: Expected native int or pointer, but got VT
		//IL_0da3: Expected I4, but got VT
		//IL_0dac: Expected Obj, but got VT
		//IL_0dc1: Expected F4, but got Obj
		//IL_0dbc: Expected native int or pointer, but got VT
		//IL_0332: Expected F4, but got Obj
		//IL_032d: Expected native int or pointer, but got VT
		//IL_0347: Expected F4, but got I
		//IL_0342: Expected native int or pointer, but got VT
		//IL_0356: Expected I4, but got VT
		//IL_035f: Expected Obj, but got VT
		//IL_0374: Expected F4, but got Obj
		//IL_036f: Expected native int or pointer, but got VT
		//IL_02e6: Expected I, but got Obj
		//IL_0393: Expected F4, but got Obj
		//IL_038e: Expected native int or pointer, but got VT
		//IL_03a8: Expected F4, but got I
		//IL_03a3: Expected native int or pointer, but got VT
		//IL_03b7: Expected I4, but got VT
		//IL_0777: Expected I, but got Obj
		//IL_078d: Expected Obj, but got I
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected Obj, but got Unknown
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Expected Obj, but got Unknown
		//IL_0ee1: Expected Obj, but got VT
		//IL_0ef6: Expected F4, but got Obj
		//IL_0ef1: Expected native int or pointer, but got VT
		//IL_0f10: Expected F4, but got Obj
		//IL_0f0b: Expected native int or pointer, but got VT
		//IL_0f25: Expected F4, but got I
		//IL_0f20: Expected native int or pointer, but got VT
		//IL_0f34: Expected I4, but got VT
		//IL_0f3d: Expected Obj, but got VT
		//IL_0f52: Expected F4, but got Obj
		//IL_0f4d: Expected native int or pointer, but got VT
		//IL_0804: Expected F4, but got Obj
		//IL_07ff: Expected native int or pointer, but got VT
		//IL_0819: Expected F4, but got I
		//IL_0814: Expected native int or pointer, but got VT
		//IL_0828: Expected I4, but got VT
		//IL_0831: Expected Obj, but got VT
		//IL_0846: Expected F4, but got Obj
		//IL_0841: Expected native int or pointer, but got VT
		//IL_0855: Expected VT, but got F4
		//IL_07b8: Expected I, but got Obj
		//IL_0871: Expected Obj, but got F4
		//IL_09e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ed: Expected Obj, but got Unknown
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fb: Expected Obj, but got Unknown
		//IL_0a27: Expected Obj, but got I4
		//IL_08ba: Expected I, but got Obj
		//IL_08d0: Expected Obj, but got I
		//IL_0aaf: Expected Obj, but got I
		//IL_0f92: Expected F4, but got VT
		//IL_0f8d: Expected native int or pointer, but got VT
		//IL_0aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af2: Expected Obj, but got Unknown
		//IL_0ff3: Expected Obj, but got F4
		//IL_1000: Expected F4, but got Obj
		//IL_0ffb: Expected native int or pointer, but got VT
		//IL_101a: Expected F4, but got Obj
		//IL_1015: Expected native int or pointer, but got VT
		//IL_102f: Expected F4, but got I
		//IL_102a: Expected native int or pointer, but got VT
		//IL_099b: Expected I, but got Obj
		//IL_0f72: Expected F4, but got VT
		//IL_0f6d: Expected native int or pointer, but got VT
		//IL_092a: Expected I, but got Obj
		//IL_0b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b28: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 160;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 144);
		object obj3 = obj2 - -64;
		object obj4 = obj2 + 48;
		object obj5 = obj2 + 140;
		object obj6 = obj2 + 40;
		object obj7 = obj2 + 24;
		object obj8 = obj2 + 136;
		object obj9 = obj2 + 16;
		object obj10 = obj2 + 132;
		object obj11 = obj2 + 128;
		object obj12 = obj2 + 124;
		object obj13 = obj2 + 120;
		object obj14 = obj2 + 116;
		object obj15 = obj2 + 112;
		object obj16 = obj2 + 108;
		object obj17 = obj2 + 104;
		object obj18 = obj2 + 88;
		obj18 = 0;
		_ = 0;
		object obj19 = obj2 + 80;
		obj19 = obj;
		_ = -1;
		if (_activeEventManager == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v30 (Il2CppClass<GlobalColors>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S1_v260 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj3 = GlobalColors.EVENTS_POPUP_DESCRIPTION_BOX_NORMAL_COLOR;
		obj5 = obj3;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Matrix4x4 matrix4x3 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
		_bottomDescriptionBoxSprite.rawPivot = (UIWidget.Pivot)matrix4x;
		obj6 = GlobalColors.EVENTS_POPUP_SPLASH_COLOR;
		obj8 = obj6;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
		Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
		Matrix4x4 matrix4x5 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		((Matrix4x4*)(nint)matrix4x5)->m20 = 0f;
		_topSplatSprite.rawPivot = (UIWidget.Pivot)matrix4x;
		obj9 = GlobalColors.EVENTS_POPUP_GLOW_DEFAULT_COLOR;
		obj10 = obj9;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
		Matrix4x4 matrix4x6 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Matrix4x4 matrix4x7 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x7)->m20 = 0f;
		_glowEffectSprite.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj21 = default;
		bool flag = (nint)obj21 == 4;
		if (flag)
		{
			_goToItemButton.tag = (string)1;
			object obj22 = this - -64;
			object obj23 = this + 208;
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S2_v147 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S2_v205 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GUILayoutOption gUILayoutOption = GUILayout.Width((float)obj23);
			((UIWidget)obj22).height = (int)gUILayoutOption;
			object obj25 = this + 208;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S1_v216+4]");
			GUILayoutOption gUILayoutOption2 = GUILayout.Width(0f);
			Color color = ((UIWidget)(object)gUILayoutOption2).color;
			object obj26 = this + 216;
			GUILayoutOption gUILayoutOption3 = GUILayout.Width((float)obj26);
			_bgOutline.height = (int)gUILayoutOption3;
			object obj27 = this + 216;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S1_v224+4]");
			GUILayoutOption gUILayoutOption4 = GUILayout.Width(0f);
			Color color2 = ((UIWidget)(object)gUILayoutOption4).color;
			Color color3 = ((UIWidget)105).color;
			nint num5 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S1_v229 (Il2CppClass<GlobalColors>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num6 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ S1_v254 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = GlobalColors.EVENTS_POPUP_DESCRIPTION_BOX_JACKPOT_EVENT_COLOR;
			obj11 = obj3;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
			Matrix4x4 matrix4x8 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
			Matrix4x4 matrix4x9 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Matrix4x4*)(nint)matrix4x9)->m20 = 0f;
			_bottomDescriptionBoxSprite.rawPivot = (UIWidget.Pivot)matrix4x;
			obj6 = GlobalColors.EVENTS_POPUP_DESCRIPTION_BOX_NORMAL_COLOR;
			obj12 = obj6;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
			Matrix4x4 matrix4x10 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
			Matrix4x4 matrix4x11 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			((Matrix4x4*)(nint)matrix4x11)->m20 = 0f;
			_topSplatSprite.rawPivot = (UIWidget.Pivot)matrix4x;
			obj9 = GlobalColors.EVENTS_POPUP_GLOW_JACKPOT_COLOR;
			obj13 = obj9;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
			Matrix4x4 matrix4x12 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
			Matrix4x4 matrix4x13 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x13)->m20 = 0f;
			_glowEffectSprite.rawPivot = (UIWidget.Pivot)matrix4x;
		}
		else
		{
			object obj29 = obj21 - 1;
			if ((nint)obj21 == 1 || ((nint)obj29 != 1 && ((nint)obj29 == 2 || ((nint)obj29 != 3 && (nint)obj29 != 4 && ((nint)obj29 == 5 || (nint)obj29 == 6)))))
			{
				_goToItemButton.tag = (string)1;
				object obj30 = this - -64;
				object obj31 = this + 192;
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S2_v101 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj32 = (nint)0 & (nint)0x200;
				if (obj32 != null)
				{
					nint num8 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S2_v117 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GUILayoutOption gUILayoutOption5 = GUILayout.Width((float)obj31);
				((UIWidget)obj30).height = (int)gUILayoutOption5;
				object obj33 = this + 192;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S1_v176+4]");
				GUILayoutOption gUILayoutOption6 = GUILayout.Width(0f);
				Color color4 = ((UIWidget)(object)gUILayoutOption6).color;
				object obj34 = this + 200;
				GUILayoutOption gUILayoutOption7 = GUILayout.Width((float)obj34);
				_bgOutline.height = (int)gUILayoutOption7;
				object obj35 = this + 200;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ S1_v184+4]");
				GUILayoutOption gUILayoutOption8 = GUILayout.Width(0f);
				Color color5 = ((UIWidget)(object)gUILayoutOption8).color;
				Color color6 = ((UIWidget)80).color;
			}
			else
			{
				_goToItemButton.tag = null;
				object obj36 = this - -64;
				object obj37 = this + 176;
				nint num9 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S2_v124 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj38 = (nint)0 & (nint)0x200;
				if (obj38 != null)
				{
					nint num10 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S2_v140 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GUILayoutOption gUILayoutOption9 = GUILayout.Width((float)obj37);
				((UIWidget)obj36).height = (int)gUILayoutOption9;
				object obj39 = this + 176;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S1_v196+4]");
				GUILayoutOption gUILayoutOption10 = GUILayout.Width(0f);
				Color color7 = ((UIWidget)(object)gUILayoutOption10).color;
				object obj40 = this + 184;
				GUILayoutOption gUILayoutOption11 = GUILayout.Width((float)obj40);
				_bgOutline.height = (int)gUILayoutOption11;
				object obj41 = this + 184;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ S1_v204+4]");
				GUILayoutOption gUILayoutOption12 = GUILayout.Width(0f);
				Color color8 = ((UIWidget)(object)gUILayoutOption12).color;
				Color color9 = ((UIWidget)80).color;
			}
		}
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ S2_v48 (Il2CppMethodInfo)+18]");
		object obj42 = 0;
		object obj43 = obj42;
		object obj44 = obj43 & 0x1FFF;
		object obj45 = obj44 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v529 @ S3_v9 (should have been resolved before IL gen)");
		object obj47 = default;
		object obj46 = obj47 + 12;
		object obj48 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj48) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj46))
		{
			object obj49 = obj47 + 16;
			object obj50 = obj48 << 2;
			object obj51 = obj49 + obj50;
			((UIRect)obj51).ResetAnchors();
			object obj52 = obj48 + 1;
			obj48 = obj52;
		}
		UIWidget component = _goToItemButton.GetComponent<UIWidget>();
		component.ResetAnchors();
		nint num12 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ S1_v66 (Il2CppClass<GlobalColors>)+BA]");
		object obj53 = (nint)0 & (nint)0x200;
		if (obj53 != null)
		{
			nint num13 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ S1_v156 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj3 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_1_COLOR;
		obj14 = obj3;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj14;
		Matrix4x4 matrix4x14 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Matrix4x4 matrix4x15 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Matrix4x4*)(nint)matrix4x15)->m20 = 0f;
		_eventTitleLine1.rawPivot = (UIWidget.Pivot)matrix4x;
		obj6 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_2_COLOR;
		obj15 = obj6;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj15;
		Matrix4x4 matrix4x16 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
		Matrix4x4 matrix4x17 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		((Matrix4x4*)(nint)matrix4x17)->m20 = 0f;
		_eventTitleLine2.rawPivot = (UIWidget.Pivot)matrix4x;
		obj9 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_COLOR;
		obj16 = obj9;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj16;
		_timerBackgroundColor = (Color32)matrix4x.m00;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj18 = matrix4x.m00;
		_ = matrix4x.m20;
		object obj54 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj54 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num14 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ S0_v138 (Il2CppClass<GlobalColors>)+BA]");
			object obj55 = (nint)0 & (nint)0x200;
			bool flag2 = obj55 == null;
			float m;
			if (flag)
			{
				if (!flag2)
				{
					nint num15 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ S0_v175 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)GlobalColors.EVENTS_POPUP_STRIPES_JACKPOT;
				m = matrix4x.m00;
			}
			else
			{
				if (!flag2)
				{
					nint num16 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ S0_v160 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)GlobalColors.EVENTS_POPUP_STRIPES_NORMAL;
				m = matrix4x.m00;
			}
			obj17 = m;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj17;
			Matrix4x4 matrix4x18 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Matrix4x4 matrix4x19 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((Matrix4x4*)(nint)matrix4x19)->m20 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj56 = obj19 + 4;
		object obj57 = obj56 + 1;
		obj56 = obj57;
		object obj58 = obj57 << 2;
		object obj59 = obj19 + obj58;
		obj59 = 759;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v47+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v47+4]");
			object obj60 = (nint)0 << 2;
			object obj61 = obj19 + obj60;
			if ((nint)obj61 == 759)
			{
				object obj62 = obj19 + 4;
				if ((nint)obj62 > -1)
				{
					object obj63 = obj62 + -1;
					obj62 = obj63;
				}
				return;
			}
		}
		object obj64 = default;
		if (obj64 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private SSEventCategory GetEventCategory()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		SSEventCategory sSEventCategory = default;
		object obj = sSEventCategory + 16;
		obj = this;
		return sSEventCategory;
	}

	private unsafe void SetLabelsTexts()
	{
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected VT, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected Obj, but got Unknown
		//IL_0382: Expected I, but got Obj
		//IL_0398: Expected Obj, but got I
		//IL_04a1: Expected Obj, but got VT
		//IL_04b6: Expected F4, but got Obj
		//IL_04b1: Expected native int or pointer, but got VT
		//IL_04d0: Expected F4, but got Obj
		//IL_04cb: Expected native int or pointer, but got VT
		//IL_04e5: Expected F4, but got I
		//IL_04e0: Expected native int or pointer, but got VT
		//IL_04f4: Expected I4, but got VT
		//IL_04fd: Expected Obj, but got VT
		//IL_0512: Expected F4, but got Obj
		//IL_050d: Expected native int or pointer, but got VT
		//IL_0241: Expected F4, but got Obj
		//IL_023c: Expected native int or pointer, but got VT
		//IL_0256: Expected F4, but got I
		//IL_0251: Expected native int or pointer, but got VT
		//IL_0265: Expected I4, but got VT
		//IL_026e: Expected Obj, but got VT
		//IL_0283: Expected F4, but got Obj
		//IL_027e: Expected native int or pointer, but got VT
		//IL_0292: Expected VT, but got F4
		//IL_01f5: Expected I, but got Obj
		//IL_03c9: Expected Obj, but got VT
		//IL_03de: Expected F4, but got Obj
		//IL_03d9: Expected native int or pointer, but got VT
		//IL_03f8: Expected F4, but got Obj
		//IL_03f3: Expected native int or pointer, but got VT
		//IL_040d: Expected F4, but got I
		//IL_0408: Expected native int or pointer, but got VT
		//IL_041c: Expected I4, but got VT
		//IL_0425: Expected Obj, but got VT
		//IL_043a: Expected F4, but got Obj
		//IL_0435: Expected native int or pointer, but got VT
		//IL_0488: Expected Obj, but got I4
		//IL_0497: Expected Obj, but got I4
		//IL_0083: Expected F4, but got Obj
		//IL_007e: Expected native int or pointer, but got VT
		//IL_0098: Expected F4, but got I
		//IL_0093: Expected native int or pointer, but got VT
		//IL_00a7: Expected I4, but got VT
		//IL_00b0: Expected Obj, but got VT
		//IL_00c5: Expected F4, but got Obj
		//IL_00c0: Expected native int or pointer, but got VT
		//IL_00d4: Expected VT, but got F4
		//IL_00dd: Expected Obj, but got VT
		//IL_00f2: Expected F4, but got Obj
		//IL_00ed: Expected native int or pointer, but got VT
		//IL_0037: Expected I, but got Obj
		//IL_0111: Expected F4, but got Obj
		//IL_010c: Expected native int or pointer, but got VT
		//IL_0126: Expected F4, but got I
		//IL_0121: Expected native int or pointer, but got VT
		//IL_0135: Expected I4, but got VT
		//IL_0143: Expected I, but got Obj
		//IL_0159: Expected Obj, but got I
		//IL_0469: Expected I4, but got Obj
		//IL_0184: Expected I, but got Obj
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 96);
		object obj2 = obj + 76;
		object obj3 = obj + 56;
		object obj4 = obj + 92;
		object obj5 = obj + 40;
		object obj6 = obj + 24;
		object obj7 = obj + 88;
		object obj8 = obj + 20;
		object obj9 = obj + 84;
		object obj10 = obj + 16;
		object obj11 = obj + 80;
		object obj12 = obj + 72;
		object obj13 = obj + 48;
		object obj14 = obj + 44;
		bool returningFromSelect = ((SelectPopupButton)(object)this).returningFromSelect;
		bool flag = returningFromSelect;
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v42 (Il2CppClass<GlobalColors>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		bool flag2 = obj15 == null;
		if (flag)
		{
			if (!flag2)
			{
				nint num2 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v95 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TITLE_LINE_1_COLOR;
			obj4 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Matrix4x4 matrix4x3 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
			_eventTitleLine1.rawPivot = (UIWidget.Pivot)matrix4x;
			obj5 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TITLE_LINE_2_COLOR;
			obj7 = obj5;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
			Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
			Matrix4x4 matrix4x5 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			((Matrix4x4*)(nint)matrix4x5)->m20 = 0f;
			_eventTitleLine2.rawPivot = (UIWidget.Pivot)matrix4x;
			obj8 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TIMER_COLOR;
			obj9 = obj8;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
			_timerBackgroundColor = (Color32)matrix4x.m00;
			obj10 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_SPLASH_COLOR;
			obj11 = obj10;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
			Matrix4x4 matrix4x6 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Matrix4x4 matrix4x7 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x7)->m20 = 0f;
			_topSplatSprite.rawPivot = (UIWidget.Pivot)matrix4x;
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S1_v92 (Il2CppClass<Strings>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S1_v99 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("EVENTS_POPUP_CATEGORY_VALENTINE_TITLE");
			_eventTitleLine1.fontSize = (int)text;
		}
		else
		{
			if (!flag2)
			{
				nint num5 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v69 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_1_COLOR;
			obj12 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
			Matrix4x4 matrix4x8 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Matrix4x4 matrix4x9 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Matrix4x4*)(nint)matrix4x9)->m20 = 0f;
			_eventTitleLine1.rawPivot = (UIWidget.Pivot)matrix4x;
			obj5 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_2_COLOR;
			obj13 = obj5;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
			Matrix4x4 matrix4x10 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
			Matrix4x4 matrix4x11 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			((Matrix4x4*)(nint)matrix4x11)->m20 = 0f;
			_eventTitleLine2.rawPivot = (UIWidget.Pivot)matrix4x;
			obj8 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_COLOR;
			obj14 = obj8;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj14;
			_timerBackgroundColor = (Color32)matrix4x.m00;
		}
		bool flag3 = !returningFromSelect;
		_jackpotTopElementsNormal.tag = (string)flag3;
		_jackpotTopElementsHearts.tag = (string)flag;
	}

	private void StartTimer()
	{
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_02fd: Expected Obj, but got I4
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_0314: Expected Obj, but got I4
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_032b: Expected Obj, but got I4
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_0342: Expected Obj, but got I4
		//IL_0070: Expected I4, but got Obj
		//IL_007f: Expected I4, but got Obj
		//IL_0215: Expected Obj, but got I4
		//IL_0224: Expected I4, but got Obj
		//IL_00d2: Expected Obj, but got I4
		//IL_0238: Expected I4, but got Obj
		//IL_00e7: Expected Obj, but got I4
		//IL_00f6: Expected I4, but got Obj
		//IL_0257: Expected I, but got Obj
		//IL_026d: Expected Obj, but got I
		//IL_0109: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I
		//IL_03b5: Expected I4, but got Obj
		//IL_0298: Expected I, but got Obj
		//IL_0198: Expected I4, but got Obj
		//IL_014a: Expected I, but got Obj
		//IL_01e3: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		object obj3 = obj2 + 20;
		obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = 0;
		object obj5 = obj2 + 12;
		obj5 = 0;
		object obj6 = obj2 + 8;
		obj6 = 0;
		if (_activeEventManager == null)
		{
			return;
		}
		obj3 = string.Empty;
		obj4 = string.Empty;
		obj5 = string.Empty;
		obj6 = string.Empty;
		if (_activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
		}
		_eventTitleLine1.fontSize = (int)obj3;
		_eventTitleLine2.fontSize = (int)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj7 = default;
		if ((nint)obj7 == 4)
		{
			_twoLinesDescription.tag = null;
			_jackpotBottomElements.tag = (string)1;
			_jackpotTopElements.tag = (string)1;
			_jackpotsDescriptionLabel.fontSize = (int)obj6;
			nint num = (nint)typeof(MysteryBox);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v64 (Il2CppClass<MysteryBox>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(MysteryBox);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v82 (Il2CppClass<MysteryBox>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MysteryBox.LootTableEntry lootTableEntry = MysteryBox.MakeRoll(MysteryBox.Type.Normal);
			obj = lootTableEntry;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			string text = $"{args:#,###0}";
			_MBJackpotLabel.fontSize = (int)text;
			MysteryBox.LootTableEntry lootTableEntry2 = MysteryBox.MakeRoll(MysteryBox.Type.Super);
			obj2 = lootTableEntry2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args2 = default;
			string text2 = $"{args2:#,###0}";
			_SMBJackpotLabel.fontSize = (int)text2;
		}
		else
		{
			_jackpotBottomElements.tag = null;
			_jackpotTopElements.tag = null;
			_twoLinesDescription.tag = (string)1;
			_messageTitleLabel.fontSize = (int)obj6;
			_messageSecondTitleLabel.fontSize = (int)obj5;
			((RewardForVideoButton)(object)_twoLinesLayout).Init((VideoButtonPayload)null);
		}
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S1_v39 (Il2CppClass<Strings>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S1_v46 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text3 = Strings.GetDefault("EVENTS_POPUP_CHECKOUT_BUTTON_TITLE");
		_checkItOutLabel.fontSize = (int)text3;
	}

	private unsafe void StopTimer()
	{
		//IL_0166: Expected I, but got Obj
		//IL_017c: Expected Obj, but got I
		//IL_024b: Expected I, but got Obj
		//IL_0261: Expected Obj, but got I
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected VT, but got Unknown
		//IL_01c6: Expected F4, but got Obj
		//IL_01c1: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v22 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		long currentEventID = ((SSEventsManagerController)(object)flurryUserId).GetCurrentEventID();
		nint num3 = (nint)typeof(TimeSpan);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v6 (Il2CppClass<System.TimeSpan>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v35 (Il2CppClass<System.TimeSpan>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
		object obj4 = default;
		object obj3 = obj4;
		Matrix4x4 matrix4x = (Matrix4x4)(obj3 + 8);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		throw new ArrayTypeMismatchException();
	}

	private void PresentCurrentEventAvailable()
	{
		_timer.HideIcon();
	}

	private void SetExtraSettingsForState(SSEventType eventType)
	{
		//IL_01a1: Expected Obj, but got I4
		//IL_01af: Expected I, but got Obj
		//IL_01c5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0252: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0118: Expected I, but got Obj
		//IL_012e: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0159: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SaveMeManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v50 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72BF");
		object obj3 = default;
		obj = obj3;
		object obj5;
		if (eventType == SSEventType.SpecialPowerBoard)
		{
			nint num3 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v37 (Il2CppClass<SaveMeManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v46 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj5 = ((!SaveMeManager.IsSaveMePopupEnabled()) ? "KeysNoVideo" : "KeysVideo");
		}
		else
		{
			obj5 = "Video";
		}
		string text = string.ConcatArray((string[])(object)"Action;", (int)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		IFormatProvider provider = default;
		object obj6 = ((IConvertible)obj5).ToType((Type)(object)";", provider);
		nint num5 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v26 (Il2CppClass<Flurry>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v31 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void PositionMysteryPowerup3DElements()
	{
		//IL_00b0: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I
		//IL_0184: Expected I4, but got Obj
		//IL_0194: Expected I4, but got Obj
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_00f1: Expected I, but got Obj
		if (_activeEventManager == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		HidePopupIfNeeded();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			object obj2 = default;
			object obj = obj2 + 16;
			object obj3 = default;
			obj = obj3;
			throw new NullReferenceException();
		}
		nint num2 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v10 (Il2CppClass<Strings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v21 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("EVENT_POPUP_NOT_AVAILABLE_DESCRIPTION");
		_messageTitleLabel.fontSize = (int)text;
		_messageSecondTitleLabel.fontSize = (int)string.Empty;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10+8]");
		AddLimitedCharacter3DElements(SSEventType.None);
	}

	private unsafe void PositionCoinIcons()
	{
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_022b: Expected Obj, but got I4
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_024c: Expected Obj, but got I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_026d: Expected Obj, but got I4
		//IL_0285: Expected I, but got Obj
		//IL_029b: Expected Obj, but got I
		//IL_02c6: Expected I, but got Obj
		//IL_02dc: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected I4, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected I4, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected I4, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected Obj, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0077: Expected Obj, but got I
		//IL_00b4: Expected I, but got Obj
		//IL_0095: Expected I4, but got Obj
		//IL_00a1: Expected Obj, but got I4
		//IL_0101: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I
		//IL_0134: Expected I, but got Obj
		//IL_030f: Expected Obj, but got I
		//IL_0331: Expected I4, but got Obj
		//IL_0355: Expected I4, but got Obj
		//IL_0363: Expected I, but got Obj
		//IL_0379: Expected Obj, but got I
		//IL_039b: Expected I4, but got Obj
		//IL_03bf: Expected I4, but got Obj
		//IL_03cd: Expected I, but got Obj
		//IL_03e3: Expected Obj, but got I
		//IL_0405: Expected I4, but got Obj
		//IL_0429: Expected I4, but got Obj
		//IL_01b8: Expected I4, but got Obj
		//IL_01cf: Expected I4, but got Obj
		//IL_01e6: Expected I4, but got Obj
		//IL_0150: Expected I, but got Obj
		//IL_0180: Expected I, but got Obj
		//IL_01a6: Expected I, but got Obj
		object obj = default;
		PurchaseHandler purchaseHandler = (PurchaseHandler)(obj + 60);
		purchaseHandler = (PurchaseHandler)0;
		purchaseHandler.onUpgradePurchase = null;
		PurchaseHandler purchaseHandler2 = (PurchaseHandler)(obj + 48);
		purchaseHandler2 = (PurchaseHandler)0;
		purchaseHandler2.onUpgradePurchase = null;
		PurchaseHandler purchaseHandler3 = (PurchaseHandler)(obj + 36);
		purchaseHandler3 = (PurchaseHandler)0;
		purchaseHandler3.onUpgradePurchase = null;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v92 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_mysteryPowerup != null)
		{
			object obj3 = this + 60;
			bool isInstanced = UIScreenController.IsInstanced;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S3_v8 (System.Boolean)+18]");
			int layer = ((GameObject)0).layer;
			bool flag = ((UIModelController)null).IsModelCurrentlyShown((Characters.CharacterId)_mysteryPowerupPrefab, layer, (UIModelController.ModelScreen)31);
			obj3 = flag;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v85 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num5 = obj + 96;
		int num6 = obj + 84;
		Boards.BoardId boardId = (Boards.BoardId)(obj + 72);
		object obj5 = obj + 24;
		object obj6 = obj + 12;
		if (((ComputeShader)(object)_mysteryPowerup).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num7 = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v27 (Il2CppClass<SSEventsPopup>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		bool flag2 = obj7 == null;
		nint num8 = (nint)typeof(SSEventsPopup);
		if (!flag2)
		{
			nint num9 = (nint)typeof(SSEventsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v63 (Il2CppClass<SSEventsPopup>)+74]");
			bool flag3 = (nint)0 == 0;
			bool flag4 = !flag3;
			num8 = (nint)typeof(SSEventsPopup);
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num8 = (nint)typeof(SSEventsPopup);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ L1_v3 (Il2CppClass<SSEventsPopup>)+5C]");
		object obj8 = (nint)0 + (nint)108;
		obj5 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v39+8]");
		_ = 0;
		((int*)num5)->m_value = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v31+8]");
		_ = 0;
		purchaseHandler.PurchaseCharacter(Characters.CharacterId.slick, (int)"event_popup_element_new_position_offset", num5);
		nint num10 = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S1_v49 (Il2CppClass<SSEventsPopup>)+5C]");
		object obj9 = (nint)0 + (nint)120;
		obj6 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v51+8]");
		_ = 0;
		((int*)num5)->m_value = (int)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v33+8]");
		_ = 0;
		purchaseHandler2.PurchaseCharacter(Characters.CharacterId.slick, (int)"event_popup_element_new_rotation", num5);
		nint num11 = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S1_v61 (Il2CppClass<SSEventsPopup>)+5C]");
		object obj10 = (nint)0 + (nint)132;
		obj = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S1_v63+8]");
		_ = 0;
		((int*)num5)->m_value = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		purchaseHandler3.PurchaseCharacter(Characters.CharacterId.slick, (int)"event_popup_element_new_scale", num5);
		((Boards.BoardId*)(int)boardId)->value__ = (int)purchaseHandler;
		_ = purchaseHandler.onUpgradePurchase;
		((int*)num6)->m_value = (int)purchaseHandler2;
		_ = purchaseHandler2.onUpgradePurchase;
		((int*)num5)->m_value = (int)purchaseHandler3;
		_ = purchaseHandler3.onUpgradePurchase;
		((UIHoverboardThemeShifter)(object)this).SetActiveBubbles((HoverboardThemeButton)(object)_topSplatSprite, (HoverboardThemes.HoverboardTheme)(object)_mysteryPowerup, boardId, num6, num5);
	}

	private void AddSpecialPowerBoardEvent3DElements()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_003e: Expected VT, but got Obj
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_006d: Expected VT, but got Obj
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got F4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0130: Expected VT, but got Obj
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_015f: Expected VT, but got Obj
		//IL_0168: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got F4
		GameObject gameObject = _coinLeft.gameObject;
		object obj = default;
		Transform transform = (Transform)(obj + 60);
		GameObject gameObject2 = _MBJackpotLabel.gameObject;
		transform.localPosition = (Vector3)gameObject2;
		Transform transform2 = (Transform)(obj + 48);
		GameObject gameObject3 = _MBJackpotLabel.gameObject;
		transform2.localPosition = (Vector3)gameObject3;
		object obj2 = obj + 36;
		obj2 = 0;
		_ = 0;
		float num = (float)transform + 2f;
		obj2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v8 (UnityEngine.Transform)+4]");
		_ = 0;
		_ = 0f;
		Transform transform3 = (Transform)(obj + 72);
		transform3 = (Transform)obj2;
		Transform transform4 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v12+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform3.eulerAngles;
		GameObject gameObject4 = _coinRight.gameObject;
		Transform transform5 = (Transform)(obj + 24);
		GameObject gameObject5 = _SMBJackpotLabel.gameObject;
		transform5.localPosition = (Vector3)gameObject5;
		Transform transform6 = (Transform)(obj + 12);
		GameObject gameObject6 = _SMBJackpotLabel.gameObject;
		transform6.localPosition = (Vector3)gameObject6;
		obj = 0;
		_ = 0;
		float num2 = (float)transform5 + 2f;
		obj = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v27 (UnityEngine.Transform)+4]");
		_ = 0;
		_ = 0f;
		transform3 = (Transform)obj;
		Transform transform7 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles2 = transform3.eulerAngles;
	}

	private void AddLimitedCharacter3DElements(SSEventType eventType)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I4
		object obj = eventType - 1;
		if (eventType != SSEventType.SpecialPowerBoard)
		{
			if ((nint)obj == 1)
			{
				return;
			}
			if ((nint)obj != 2)
			{
				if ((nint)obj == 3)
				{
					AddSpecialPowerBoardEvent3DElements();
					SetLabelsTexts();
					return;
				}
				if ((nint)obj == 4)
				{
					PositionCoinIcons();
					return;
				}
				if ((nint)obj == 5)
				{
					DisableAllStates();
					return;
				}
				if ((nint)obj != 6)
				{
					return;
				}
			}
			((ScrollListPopupCellHelper)(object)this).UpdateTitle((string)eventType);
		}
		else
		{
			DisableAllStates();
		}
	}

	private GameObject PlaceModelUnderAnchor(GameObject model, Transform anchor, int layer)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		((UnityEngine.Object)gameObject).m_CachedPtr = (IntPtr)0;
		object obj = gameObject + 24;
		obj = this;
		object obj2 = gameObject + 16;
		obj2 = model;
		object obj3 = gameObject + 20;
		obj3 = anchor;
		return gameObject;
	}

	private GameObject PlacePrefabUnderAnchor(GameObject prefab, Transform anchor, int layer)
	{
		//IL_018b: Expected I, but got Obj
		//IL_01a1: Expected Obj, but got I
		//IL_0228: Expected VT, but got I4
		//IL_0246: Expected Obj, but got I4
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_00ae: Expected I, but got Obj
		//IL_0178: Expected Obj, but got I4
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v24 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = NGUITools.Round((Vector3)layer);
		int layer2 = prefab.layer;
		((Transform)layer2).parentInternal = anchor;
		int layer3 = prefab.layer;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v30 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 24;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj4 + 36);
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v14+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		int layer4 = prefab.layer;
		object obj5 = obj4 + 12;
		Vector3 one2 = Vector3.one;
		transform = (Transform)obj5;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v21+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 right = transform.right;
		int layer5 = prefab.layer;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj4;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)layer5).parent = transform;
		return prefab;
	}

	private Vector3 VerifySettingOnline(string key, Vector3 defaultVal)
	{
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_0400: Invalid comparison between VT and I4
		//IL_0157: Expected I, but got Obj
		//IL_016d: Expected Obj, but got I
		//IL_0198: Expected I, but got Obj
		//IL_01e5: Expected I, but got Obj
		//IL_01fb: Expected Obj, but got I
		//IL_0449: Expected VT, but got Obj
		//IL_0330: Expected Obj, but got I4
		//IL_0353: Expected Obj, but got I4
		//IL_035b: Expected Obj, but got VT
		//IL_0369: Expected I, but got Obj
		//IL_037f: Expected Obj, but got I
		//IL_0226: Expected I, but got Obj
		//IL_0452: Expected Obj, but got I4
		//IL_03aa: Expected VT, but got Obj
		//IL_0273: Expected I, but got Obj
		//IL_0289: Expected Obj, but got I
		//IL_02b4: Expected I, but got Obj
		Vector3 vector = default;
		object obj = vector - 1;
		if (vector == (Vector3)(object)1)
		{
			goto IL_0149;
		}
		if ((nint)obj == 1)
		{
			goto IL_01d7;
		}
		MysteryBox.Type mysteryBoxType;
		if ((nint)obj != 2)
		{
			if ((nint)obj == 3)
			{
				goto IL_0149;
			}
			if ((nint)obj == 4)
			{
				goto IL_01d7;
			}
			if ((nint)obj != 5 && (nint)obj != 6 && (nint)obj != 7 && (nint)obj != 8 && (nint)obj != 9 && (nint)obj != 10 && (nint)obj == 11)
			{
				nint num = (nint)typeof(MysteryBox);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v49 (Il2CppClass<MysteryBox>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(MysteryBox);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v54 (Il2CppClass<MysteryBox>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				mysteryBoxType = MysteryBox.Type.Mini;
				goto IL_02f8;
			}
		}
		goto IL_043e;
		IL_02f8:
		int megaJackpotAmount = MysteryBox.GetMegaJackpotAmount(mysteryBoxType);
		if (megaJackpotAmount != 0)
		{
			object obj3 = megaJackpotAmount + 92;
			obj3 = key;
			_ = -1;
			object obj4 = megaJackpotAmount + 112;
			obj4 = defaultVal;
			nint num3 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v19 (Il2CppClass<RewardManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				Vector3 vector2 = (Vector3)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v24 (UnityEngine.Vector3)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			RewardManager.RewardPaidOut((CelebrationReward)megaJackpotAmount);
		}
		goto IL_043e;
		IL_043e:
		return (Vector3)typeof(RewardManager);
		IL_01d7:
		nint num4 = (nint)typeof(MysteryBox);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v39 (Il2CppClass<MysteryBox>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num5 = (nint)typeof(MysteryBox);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v44 (Il2CppClass<MysteryBox>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		mysteryBoxType = MysteryBox.Type.Super;
		goto IL_02f8;
		IL_0149:
		nint num6 = (nint)typeof(MysteryBox);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v29 (Il2CppClass<MysteryBox>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num7 = (nint)typeof(MysteryBox);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v34 (Il2CppClass<MysteryBox>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		mysteryBoxType = MysteryBox.Type.Normal;
		goto IL_02f8;
	}

	private unsafe void DisableAllStates()
	{
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected I4, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected I4, but got Unknown
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected I4, but got Unknown
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected Obj, but got Unknown
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected Obj, but got Unknown
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected Obj, but got Unknown
		//IL_0585: Expected VT, but got I4
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected Obj, but got Unknown
		//IL_059c: Expected Obj, but got I4
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected Obj, but got Unknown
		//IL_05bd: Expected Obj, but got I4
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected Obj, but got Unknown
		//IL_05de: Expected Obj, but got I4
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected Obj, but got Unknown
		//IL_05ff: Expected Obj, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_00f2: Expected VT, but got Obj
		//IL_011d: Expected I, but got Obj
		//IL_0133: Expected Obj, but got I
		//IL_015e: Expected I, but got Obj
		//IL_01ab: Expected I, but got Obj
		//IL_01c1: Expected Obj, but got I
		//IL_065b: Expected Ref, but got VT
		//IL_067f: Expected I, but got Obj
		//IL_0695: Expected Obj, but got I
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected Obj, but got Unknown
		//IL_06cf: Expected Ref, but got VT
		//IL_01ec: Expected I, but got Obj
		//IL_028e: Expected I, but got Obj
		//IL_02a4: Expected Obj, but got I
		//IL_0239: Expected I, but got Obj
		//IL_02cf: Expected I, but got Obj
		//IL_0328: Expected Obj, but got I
		//IL_0346: Expected Obj, but got I4
		//IL_0366: Expected Obj, but got I4
		//IL_0373: Expected Obj, but got I4
		//IL_038a: Expected I, but got Obj
		//IL_03a0: Expected Obj, but got I
		//IL_03cb: Expected I, but got Obj
		//IL_0418: Expected I, but got Obj
		//IL_042e: Expected Obj, but got I
		//IL_044b: Expected I, but got Obj
		//IL_076a: Expected Obj, but got VT
		//IL_0784: Expected I4, but got Obj
		//IL_07a8: Expected I4, but got Obj
		//IL_07b6: Expected I, but got Obj
		//IL_07cc: Expected Obj, but got I
		//IL_07ee: Expected I4, but got Obj
		//IL_0812: Expected I4, but got Obj
		//IL_0820: Expected I, but got Obj
		//IL_0836: Expected Obj, but got I
		//IL_0858: Expected I4, but got Obj
		//IL_087c: Expected I4, but got Obj
		//IL_04cf: Expected I4, but got Obj
		//IL_04e6: Expected I4, but got Obj
		//IL_04fd: Expected I4, but got Obj
		//IL_0467: Expected I, but got Obj
		//IL_0497: Expected I, but got Obj
		//IL_04bd: Expected I, but got Obj
		Boards.BoardId? boardId = default;
		int num = (Nullable)boardId + 104;
		int num2 = (Nullable)boardId + 92;
		Boards.BoardId boardId2 = (Boards.BoardId)((Nullable)boardId + 80);
		object obj = (Nullable)boardId + 32;
		object obj2 = (Nullable)boardId + 20;
		object obj3 = (Nullable)boardId + 8;
		boardId = (Boards.BoardId?)(object)0;
		PurchaseHandler purchaseHandler = (PurchaseHandler)((Nullable)boardId + 68);
		purchaseHandler = (PurchaseHandler)0;
		purchaseHandler.onUpgradePurchase = null;
		PurchaseHandler purchaseHandler2 = (PurchaseHandler)((Nullable)boardId + 56);
		purchaseHandler2 = (PurchaseHandler)0;
		purchaseHandler2.onUpgradePurchase = null;
		PurchaseHandler purchaseHandler3 = (PurchaseHandler)((Nullable)boardId + 44);
		purchaseHandler3 = (PurchaseHandler)0;
		purchaseHandler3.onUpgradePurchase = null;
		object obj4 = (Nullable)boardId + 116;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		if (_activeEventManager == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj6 = default;
		object obj5 = obj6 - 1;
		if ((nint)obj6 != 1 && ((nint)obj5 == 1 || (nint)obj5 == 2 || (nint)obj5 == 3 || (nint)obj5 == 4 || (nint)obj5 != 5))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
		_ = 1;
		object obj7 = default;
		boardId = (Boards.BoardId?)obj7;
		if (obj4 == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v109 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(_specialPowerBoard != null))
		{
			return;
		}
		nint num5 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v53 (Il2CppClass<Info.Boards>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v133 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.BoardId value = ((Boards.BoardId?*)boardId)->Value;
		Boards.Board board = Boards.boardData.get_Item(value);
		nint num7 = (nint)typeof(HoverboardModelPreviewFactory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v62 (Il2CppClass<HoverboardModelPreviewFactory>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num8 = (nint)typeof(HoverboardModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v129 (Il2CppClass<HoverboardModelPreviewFactory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj11 = this + 52;
		CoinMagnet instance = CoinMagnet.Instance;
		Boards.BoardId value2 = ((Boards.BoardId?*)boardId)->Value;
		IEnumerator enumerator = ((AvatarAnimations)(object)instance).PlayAnimationsInOrder((AnimationClip[])(object)board.boardModelName, (byte)value2 != 0);
		obj11 = enumerator;
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S1_v105 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_specialPowerBoard != null)
		{
			return;
		}
		bool isInstanced = UIScreenController.IsInstanced;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S2_v16 (System.Boolean)+18]");
		int layer = ((GameObject)0).layer;
		GameObject gameObject = ((SSEventsPopup)null).PlacePrefabUnderAnchor(_specialPowerBoard, (Transform)layer, 31);
		int layer2 = gameObject.layer;
		bool flag = ((SpriteAtlas)layer2).CanBindTo(null);
		string text = ((Component)flag).tag;
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v78 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v125 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)text).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num13 = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v85 (Il2CppClass<SSEventsPopup>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		bool flag2 = obj14 == null;
		nint num14 = (nint)typeof(SSEventsPopup);
		if (!flag2)
		{
			nint num15 = (nint)typeof(SSEventsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v119 (Il2CppClass<SSEventsPopup>)+74]");
			bool flag3 = (nint)0 == 0;
			bool flag4 = !flag3;
			num14 = (nint)typeof(SSEventsPopup);
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num14 = (nint)typeof(SSEventsPopup);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ L1_v8 (Il2CppClass<SSEventsPopup>)+5C]");
		nint num16 = 0;
		obj = SPECIAL_POWER_BOARD_POSITION_OFFSET;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S1_v59 (Il2CppStaticFields<SSEventsPopup>)+8]");
		_ = 0;
		((int*)num)->m_value = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		_ = 0;
		purchaseHandler.PurchaseCharacter(Characters.CharacterId.slick, (int)"event_popup_element_new_position_offset", num);
		nint num17 = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S1_v69 (Il2CppClass<SSEventsPopup>)+5C]");
		object obj15 = (nint)0 + (nint)12;
		obj2 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S1_v71+8]");
		_ = 0;
		((int*)num)->m_value = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
		_ = 0;
		purchaseHandler2.PurchaseCharacter(Characters.CharacterId.slick, (int)"event_popup_element_new_rotation", num);
		nint num18 = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S1_v81 (Il2CppClass<SSEventsPopup>)+5C]");
		object obj16 = (nint)0 + (nint)24;
		obj3 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S1_v83+8]");
		_ = 0;
		((int*)num)->m_value = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		_ = 0;
		purchaseHandler3.PurchaseCharacter(Characters.CharacterId.slick, (int)"event_popup_element_new_scale", num);
		((Boards.BoardId*)(int)boardId2)->value__ = (int)purchaseHandler;
		_ = purchaseHandler.onUpgradePurchase;
		((int*)num2)->m_value = (int)purchaseHandler2;
		_ = purchaseHandler2.onUpgradePurchase;
		((int*)num)->m_value = (int)purchaseHandler3;
		_ = purchaseHandler3.onUpgradePurchase;
		((UIHoverboardThemeShifter)(object)this).SetActiveBubbles((HoverboardThemeButton)(object)_topSplatSprite, (HoverboardThemes.HoverboardTheme)(object)text, boardId2, num2, num);
	}

	public static void ShowIfNeeded()
	{
		//IL_01f6: Expected I, but got Obj
		//IL_020c: Expected Obj, but got I
		//IL_02e7: Expected I, but got Obj
		//IL_02fd: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00b7: Expected I, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_00f8: Expected I, but got Obj
		//IL_0168: Expected I, but got Obj
		//IL_017e: Expected Obj, but got I
		//IL_02d3: Expected Obj, but got I4
		//IL_02d3: Expected Obj, but got I4
		//IL_01a9: Expected I, but got Obj
		nint num = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SaveMeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v50 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveMeManager.ResetSaveMeForNewRun();
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v46 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag).DelayHideMainCamera();
		UIScreen uIScreen = ((UIScreenController)flag)._ActivateScreen((string)(object)enumerator);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj4 = default;
		if (obj4 != null)
		{
			SDebug.LogFormat("IngameScreen == NULL", null);
		}
		else
		{
			((IngameScreen)obj4).OnHeadstartActivated(1);
		}
		nint num7 = (nint)typeof(Revive);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v29 (Il2CppClass<Revive>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(Revive);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v35 (Il2CppClass<Revive>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string deviceToken = RemoteNotificationControl.GetDeviceToken();
		bool revivedWithAds = SaveMePopup._revivedWithAds;
		bool adsNotAvailable = SaveMePopup._adsNotAvailable;
		bool adsFailed = SaveMePopup._adsFailed;
		((SocialManager)(object)deviceToken).WWWUnregisterDeviceCompleted(revivedWithAds ? SocialManager.WWWRequestResult.Error : SocialManager.WWWRequestResult.Success, (string)adsNotAvailable, (object)adsFailed);
	}

	private void HidePopupIfNeeded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 57)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				return;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public void GoToEventItem()
	{
		//IL_026a: Expected I, but got Obj
		//IL_0280: Expected Obj, but got I
		//IL_0358: Expected Obj, but got I4
		//IL_009d: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_013c: Expected I, but got Obj
		//IL_0152: Expected Obj, but got I
		//IL_00de: Expected I, but got Obj
		//IL_01db: Expected I, but got Obj
		//IL_01f1: Expected Obj, but got I
		//IL_017d: Expected I, but got Obj
		//IL_030f: Expected Obj, but got I4
		//IL_021c: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v43 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		bool flag = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick);
		bool flag2 = !flag;
		bool flag3 = _activeEventManager == null;
		object obj2 = flag2 | flag3;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
			object obj3 = default;
			object obj4 = default;
			if (obj3 == obj4)
			{
				return;
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_limitedCharacter).FindKernel((string)null) != 0)
		{
			_limitedCharacter.tag = null;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_specialPowerBoard).FindKernel((string)null) != 0)
		{
			_specialPowerBoard.tag = null;
		}
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v26 (Il2CppClass<UIScreenController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v32 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag4).ClosePopup((GameObject)(object)screenName);
	}

	private void PositionModelOnSprite(UISprite tracker, GameObject objectToPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_008b: Expected I4, but got Obj
		//IL_008b: Expected I4, but got Obj
		//IL_008b: Expected I4, but got Obj
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		object obj = default;
		object obj4 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<GameObject, UIntPtr>(ref objectToPosition))
		{
			object obj2 = newRotation + 16;
			object obj3 = obj4 << 2;
			object obj5 = obj2 + obj3;
			object obj6 = newScale + 16;
			object obj7 = obj4 << 2;
			object obj8 = obj6 + obj7;
			((MysteryBoxDoubleUpButton)null).LogAttemptToShowButton((byte)(int)tracker != 0, (byte)(int)obj5 != 0, (byte)(int)obj8 != 0);
			obj = obj4 + 1;
		}
	}

	private IEnumerator DelayPositioning(UISprite tracker, GameObject objectToPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale)
	{
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got Unknown
		//IL_031d: Expected Obj, but got I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_032c: Expected Obj, but got VT
		//IL_010f: Expected I, but got Obj
		//IL_0125: Expected Obj, but got I
		//IL_00a2: Expected I, but got Obj
		//IL_0357: Expected Obj, but got VT
		//IL_00fb: Expected Obj, but got VT
		//IL_00fb: Expected Obj, but got VT
		//IL_0386: Expected I, but got Obj
		//IL_039c: Expected Obj, but got I
		//IL_0150: Expected I, but got Obj
		//IL_0444: Expected Obj, but got I
		//IL_019d: Expected I, but got Obj
		//IL_01b3: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I
		//IL_0249: Expected I, but got Obj
		//IL_03cb: Expected Obj, but got I
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_0404: Expected I4, but got Obj
		//IL_01de: Expected I, but got Obj
		//IL_0234: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		if ((object)tracker != null && tracker.leftAnchor != null)
		{
			goto IL_0022;
		}
		object obj = tracker + 12;
		object obj2 = 0;
		goto IL_0413;
		IL_0413:
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			return (IEnumerator)list;
		}
		goto IL_0022;
		IL_0022:
		object obj3 = tracker + 16;
		object obj4 = obj2 << 2;
		object obj5 = obj3 + obj4;
		object obj6 = obj5;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v66 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)positionOffset).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v20+8]");
			((HoverboardModelPreviewFactory)null).AddCustomModelsAndFX((HoverboardBundle.CustomSet[])positionOffset, 0, (Transform)newScale);
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v61 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)newRotation).FindKernel(null) != 0)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v20+C]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v20+C]");
				((HoverboardModelPreviewFactory)null).AddCustomModelsAndFX((HoverboardBundle.CustomSet[])newRotation, 0, (Transform)null);
			}
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v53 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v20+8]");
		if ((UnityEngine.Object)0 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v20+8]");
			UnityEngine.Object item = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
			list.Add((string)(object)item);
			object obj11 = obj2 + 1;
			obj2 = obj11;
			goto IL_0413;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Exception ex = default;
		ex.SetErrorCode((int)"character cannot be null.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return null;
	}

	public SSEventsPopup()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_050c: Expected I, but got Obj
		//IL_0522: Expected Obj, but got I
		//IL_054d: Expected I, but got Obj
		//IL_059a: Expected I, but got Obj
		//IL_05b0: Expected Obj, but got I
		//IL_02b4: Expected I, but got Obj
		//IL_02ca: Expected Obj, but got I
		//IL_0639: Expected I, but got Obj
		//IL_064f: Expected Obj, but got I
		//IL_05db: Expected I, but got Obj
		//IL_02f5: Expected I, but got Obj
		//IL_00fb: Expected I, but got Obj
		//IL_0111: Expected Obj, but got I
		//IL_06c8: Expected Obj, but got I4
		//IL_06d6: Expected I, but got Obj
		//IL_06ec: Expected Obj, but got I
		//IL_067a: Expected I, but got Obj
		//IL_0342: Expected I, but got Obj
		//IL_0358: Expected Obj, but got I
		//IL_0938: Expected Obj, but got I4
		//IL_013c: Expected I, but got Obj
		//IL_0717: Expected I, but got Obj
		//IL_03e1: Expected I, but got Obj
		//IL_03f7: Expected Obj, but got I
		//IL_0383: Expected I, but got Obj
		//IL_0189: Expected I, but got Obj
		//IL_019f: Expected Obj, but got I
		//IL_0470: Expected Obj, but got I4
		//IL_047e: Expected I, but got Obj
		//IL_0494: Expected Obj, but got I
		//IL_0422: Expected I, but got Obj
		//IL_0218: Expected Obj, but got I4
		//IL_0226: Expected I, but got Obj
		//IL_023c: Expected Obj, but got I
		//IL_01ca: Expected I, but got Obj
		//IL_088e: Expected Obj, but got I4
		//IL_07e9: Expected Obj, but got I4
		//IL_04bf: Expected I, but got Obj
		//IL_0267: Expected I, but got Obj
		if (_activeEventManager == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj2 = default;
		object obj = obj2 - 1;
		if ((nint)obj2 != 1)
		{
			if ((nint)obj == 1)
			{
				return;
			}
			if ((nint)obj != 2)
			{
				if ((nint)obj == 3)
				{
					nint num = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v106 (Il2CppClass<UIScreenController>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num2 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v143 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UIScreenController instance = UIScreenController.Instance;
					if ((object)instance == null)
					{
						return;
					}
					nint num3 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v114 (Il2CppClass<UIScreenController>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num4 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v139 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = UIScreenController.ShouldShowOnlineScreen();
					_ = 1;
					bool flag2 = UIScreenController.ShouldShowOnlineScreen();
					_ = 1;
					bool flag3 = UIScreenController.ShouldShowOnlineScreen();
					((UIScreenController)flag3).ClosePopup((GameObject)(object)screenName);
					nint num5 = (nint)typeof(UpgradeScreen);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v125 (Il2CppClass<UI.Screens.UpgradeScreen>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num6 = (nint)typeof(UpgradeScreen);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v133 (Il2CppClass<UI.Screens.UpgradeScreen>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UpgradeScreen.forceScrollRearange = true;
					bool flag4 = UIScreenController.ShouldShowOnlineScreen();
					((UIScreenController)flag4).SwitchScreen("UpgradesUI_shop");
					return;
				}
				if ((nint)obj == 4)
				{
					return;
				}
				if ((nint)obj == 5)
				{
					goto IL_04fe;
				}
				if ((nint)obj != 6)
				{
					return;
				}
			}
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v58 (Il2CppClass<UIScreenController>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v101 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIScreenController instance2 = UIScreenController.Instance;
			if ((object)instance2 == null)
			{
				return;
			}
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_limitedCharacter).FindKernel((string)null) != 0)
			{
				_limitedCharacter.tag = null;
			}
			nint num11 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v70 (Il2CppClass<UIScreenController>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num12 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v95 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag5 = UIScreenController.ShouldShowOnlineScreen();
			_ = 1;
			bool flag6 = UIScreenController.ShouldShowOnlineScreen();
			_ = 1;
			bool flag7 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag7).ClosePopup((GameObject)(object)screenName);
			nint num13 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v81 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num14 = (nint)typeof(CharacterScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v89 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterScreen.forceCenterOnEventCharacter = true;
			bool flag8 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag8).SwitchScreen("CharacterScreen");
			return;
		}
		goto IL_04fe;
		IL_04fe:
		nint num15 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v12 (Il2CppClass<UIScreenController>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num16 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v53 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController instance3 = UIScreenController.Instance;
		if ((object)instance3 == null)
		{
			return;
		}
		nint num17 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num18 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_specialPowerBoard).FindKernel((string)null) != 0)
		{
			_specialPowerBoard.tag = null;
		}
		nint num19 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v24 (Il2CppClass<UIScreenController>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num20 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v47 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag9 = UIScreenController.ShouldShowOnlineScreen();
		_ = 1;
		bool flag10 = UIScreenController.ShouldShowOnlineScreen();
		_ = 1;
		bool flag11 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag11).ClosePopup((GameObject)(object)screenName);
		nint num21 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v35 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num22 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v43 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance4 = HoverboardModelPreviewFactory.Instance;
		_ = 1;
		bool flag12 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag12).SwitchScreen("BoardScreen");
	}

	static SSEventsPopup()
	{
		//IL_038b: Expected I, but got Obj
		//IL_03a1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_00c7: Expected I, but got Obj
		//IL_010f: Invalid comparison between VT and I4
		//IL_0120: Invalid comparison between Obj and VT
		//IL_0133: Expected Obj, but got I4
		//IL_0182: Expected I, but got Obj
		//IL_0198: Expected Obj, but got I
		//IL_042d: Expected Obj, but got I4
		//IL_02b0: Expected I, but got Obj
		//IL_02c6: Expected Obj, but got I
		//IL_0263: Expected I, but got Obj
		//IL_0411: Expected Obj, but got I4
		//IL_044a: Expected I, but got Obj
		//IL_0460: Expected Obj, but got I
		//IL_01f2: Expected I, but got Obj
		//IL_02f1: Expected I, but got Obj
		//IL_033e: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v74 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		if (!((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick) || OnboardingSave.numberOfRunsSinceLastGuideline == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v17 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v70 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime lastShownCloudSaveIntroduction = OnboardingSave.lastShownCloudSaveIntroduction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
		object obj3 = default;
		if ((nint)obj3 <= 0)
		{
			return;
		}
		bool flag = lastShownCloudSaveIntroduction != (DateTime)(object)0;
		bool flag2 = obj3 == (object)lastShownCloudSaveIntroduction;
		object obj4 = flag & flag2;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj5 = default;
		bool flag3 = (nint)obj5 == 8;
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		bool flag4 = obj6 == null;
		if (flag3)
		{
			if (!flag4)
			{
				nint num6 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v66 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag5 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag5)._ActivateNextPopup("CharacterNameEventPopup");
		}
		else
		{
			if (!flag4)
			{
				nint num7 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v57 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag6 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag6)._ActivateNextPopup("EventsPopup");
		}
		nint num8 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v35 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num9 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v48 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @922A");
		nint num10 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v41 (Il2CppClass<Flurry>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num11 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v44 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}
}
