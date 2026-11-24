using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using InAppPurchase.Internal;
using Kiloo.Common.Backend.PurchaseValidation;
using UnityEngine;

namespace InAppPurchase;

public class InAppPurchaseProvider : IPurchaseProvider, IInAppManager
{
	private IPurchaseProvider _provider;

	private IAPPluginInitializationState _currentInitializationState;

	private IInAppManager _inAppManager;

	private Dictionary<string, ProductRequestResultInfo> _latestProductInfo;

	private static InAppPurchaseProvider _instance;

	public static InAppPurchaseProvider instance
	{
		get
		{
			//IL_0094: Expected I, but got Obj
			//IL_00aa: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0077: Expected Obj, but got I4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)UITooltip.mInstance).FindKernel((string)null) != 0)
			{
				UITooltip mInstance = UITooltip.mInstance;
				bool flag = mInstance.mTarget == 1f;
				return (InAppPurchaseProvider)flag;
			}
			return null;
		}
	}

	public bool isInstanced
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.InAppPurchaseProvider)+134]");
			return (nint)0 != 0;
		}
	}

	public static bool IsValidationSupportedOnCurrentPlatform
	{
		get
		{
			//IL_005a: Expected I4, but got Obj
			if (_instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				string msg = default;
				LogError(msg);
				_instance = (InAppPurchaseProvider)(object)msg;
			}
			return (byte)(int)_instance != 0;
		}
	}

	public bool IsValidationServerSpecified => _instance != null;

	private InAppPurchaseProvider()
	{
		_ = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public ProductRequestResultInfo[] GetLatestRequestedProductInfo()
	{
		if (_provider != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			ProductRequestResultInfo[] result = default;
			return result;
		}
		return null;
	}

	public unsafe bool TryGetLatestRequestedProductInfoForProductId(string productId, out ProductRequestResultInfo productInfo)
	{
		//IL_0210: Expected I, but got Obj
		//IL_0226: Expected Obj, but got I
		//IL_02df: Expected VT, but got Obj
		//IL_02ed: Expected I, but got Obj
		//IL_0303: Expected Obj, but got I
		//IL_024d: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0286: Expected I4, but got VT
		//IL_0060: Expected I, but got Obj
		//IL_00ba: Expected I, but got Obj
		//IL_00d0: Expected Obj, but got I
		//IL_00fb: Expected I, but got Obj
		//IL_02d0: Expected VT, but got I4
		//IL_0174: Expected I, but got Obj
		//IL_018a: Expected Obj, but got I
		//IL_02bf: Expected Obj, but got Ref
		//IL_01b5: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_0021_00210 val = (_0021_00210)NGUITools.AddMissingComponent<T>((GameObject)(object)this);
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num5 = ((ComputeShader)val).FindKernel(null);
		bool flag = num5 == 0;
		bool flag2 = !flag;
		_0021_00210 val2 = val;
		if (!flag2)
		{
			Transform parentInternal2 = default;
			while (true)
			{
				Transform parentInternal = parentInternal2.parentInternal;
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)parentInternal).FindKernel((string)null) == 0)
				{
					break;
				}
				parentInternal2 = ((Transform)this).parentInternal;
			}
			bool flag3;
			if (productId != null)
			{
				nint num8 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v30 (Il2CppClass<NGUITools>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num9 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v36 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				flag3 = PropertyReference.Convert(ref *(object*)parentInternal2, null, (Type)System.Runtime.CompilerServices.Unsafe.AsPointer(ref productInfo));
			}
			else
			{
				flag3 = false;
			}
			val2 = (_0021_00210)flag3;
		}
		return (byte)(int)val2 != 0;
	}

	public void Init(IInAppManager inAppManager, IPurchaseValidationServer purchaseValidationServer = null)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		_provider = (IPurchaseProvider)purchaseValidationServer;
		_latestProductInfo = (Dictionary<string, ProductRequestResultInfo>)purchaseValidationServer;
		object obj = this + 16;
		obj = inAppManager;
	}

	public bool CanMakePurchases()
	{
		Dictionary<string, ProductRequestResultInfo>.ValueCollection values = _latestProductInfo.Values;
		ProductRequestResultInfo[] array = Enumerable.ToArray(values);
		OverflowException ex = new OverflowException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		bool result = default;
		return result;
	}

	public void RequestProductInfo(string[] productIds)
	{
		throw new InvalidOperationException();
	}

	public unsafe bool StartPurchase(string productId)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIPanel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIPanel>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIPanel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return TryGetLatestRequestedProductInfoForProductId(productId, out *(ProductRequestResultInfo*)(-1));
	}

	public bool StartPurchase(string productId, string cookie)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_0350: Expected Obj, but got I4
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0379: Expected Obj, but got I4
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected Obj, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected Obj, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_016f: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I
		//IL_028f: Expected Obj, but got I
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I4
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 112;
		object obj3 = obj2 + 72;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 56;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 48;
		obj5 = obj;
		_ = -1;
		object obj6 = obj2 + 16;
		Dictionary<string, ProductRequestResultInfo>.ValueCollection values = _latestProductInfo.Values;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CD97");
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+18]");
		_ = 0;
		object obj7 = default;
		object obj8 = default;
		bool result = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+8]");
				_ = 0;
				obj2 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj8 != null)
				{
					string text = (string)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
					cookie.m_stringLength = 0;
					object obj9 = obj5 + 4;
					object obj10 = obj9 + 1;
					obj9 = obj10;
					object obj11 = obj10 << 2;
					object obj12 = obj5 + obj11;
					obj12 = 86;
					result = true;
					break;
				}
				continue;
			}
			object obj13 = obj5 + 4;
			object obj14 = obj13 + 1;
			obj13 = obj14;
			object obj15 = obj14 << 2;
			object obj16 = obj5 + obj15;
			obj16 = 77;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj5 + obj17;
			if ((nint)obj18 == 86)
			{
				object obj19 = obj5 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				goto IL_0465;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
			object obj21 = (nint)0 << 2;
			object obj22 = obj5 + obj21;
			if ((nint)obj22 == 77)
			{
				object obj23 = obj5 + 4;
				if ((nint)obj23 > -1)
				{
					object obj24 = obj23 + -1;
					obj23 = obj24;
				}
				goto IL_046a;
			}
		}
		object obj25 = default;
		if (obj25 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_046a;
		IL_0465:
		return result;
		IL_046a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		result = false;
		goto IL_0465;
	}

	public bool RestoreNonConsumablePurchases(string[] productIds)
	{
		string inAppAPIKey = getInAppAPIKey();
		if (inAppAPIKey != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
			bool result = default;
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8947");
		return false;
	}

	public void FinishPurchase(string productId, string transactionId, string purchaseToken)
	{
		//IL_0015: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I4
		//IL_061e: Expected Obj, but got I
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got I
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_05b9: Expected Obj, but got I
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
		//IL_05da: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I4
		//IL_0402: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I
		//IL_04c8: Expected Obj, but got I
		//IL_02f1: Expected Obj, but got I
		//IL_048c: Expected Obj, but got I
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected Obj, but got Unknown
		//IL_04ad: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.InAppPurchaseProvider)+34]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.InAppPurchaseProvider)+34]");
		object obj3;
		object obj4;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.InAppPurchaseProvider)+34]");
			object obj2 = (nint)0 + (nint)16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
			obj3 = 0;
			obj4 = obj2;
		}
		else
		{
			obj4 = this;
			obj3 = 1;
		}
		object obj5 = default;
		object obj25 = default;
		object obj17 = default;
		object obj23 = default;
		for (; obj5 != obj3; obj5 = obj25 + 1)
		{
			object obj6 = obj5 << 2;
			object obj7 = obj4 + obj6;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+10]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+14]");
			string text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (System.String)+28]");
			if ((nint)0 == -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (System.String)+2A]");
			bool flag = (nint)0 == 3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (System.String)+24]");
			object obj10 = (nint)0 & (nint)0x10;
			bool flag2 = obj10 == null;
			object obj11 = (flag2 ? 1 : 0) ^ 1;
			string text3;
			string text2;
			if (obj11 != null)
			{
				if (flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
					object obj12 = (nint)0 & (nint)0x1FFF;
					text2 = (string)(obj12 + 113696);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v197 @ S4_v16 (System.String) (should have been resolved before IL gen)");
					text3 = (string)113696;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
					object obj13 = (nint)0 & (nint)0x7FF;
					text3 = (string)(obj13 + 121922);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v195 @ S5_v6 (System.String) (should have been resolved before IL gen)");
					text2 = text;
				}
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (System.String)+28]");
			bool flag3 = (nint)0 != -1;
			if (!flag)
			{
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+10]");
					bool flag4;
					if ((nint)0 != 0)
					{
						object obj14 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v94+9C]");
						object obj15 = (nint)0 & (nint)0x100;
						flag4 = obj15 != null;
					}
					else
					{
						flag4 = false;
					}
					if (!flag4 && _currentInitializationState != IAPPluginInitializationState.NotInitialized)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (System.String)+2B]");
						object obj16 = (nint)0 & (nint)3;
						bool flag5 = (nint)obj16 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag5)
						{
							if (obj17 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A77");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A78");
							}
						}
						else if (obj17 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
							text2 = purchaseToken;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
				object obj18 = (nint)0 & (nint)0x1FFF;
				text2 = (string)(obj18 + 113696);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v197 @ S4_v16 (System.String) (should have been resolved before IL gen)");
				text3 = (string)113696;
				continue;
			}
			if (flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+10]");
				bool flag6;
				if ((nint)0 != 0)
				{
					object obj19 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v66+9C]");
					object obj20 = (nint)0 & (nint)0x100;
					flag6 = obj20 != null;
				}
				else
				{
					flag6 = false;
				}
				if (!flag6 && _currentInitializationState != IAPPluginInitializationState.NotInitialized)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+10]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
						object obj21 = (nint)0 & (nint)0x1FFF;
						text2 = (string)(obj21 + 113696);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v197 @ S4_v16 (System.String) (should have been resolved before IL gen)");
						text3 = (string)113696;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (System.String)+2B]");
					object obj22 = (nint)0 & (nint)3;
					bool flag7 = (nint)obj22 == 2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
					if (flag7)
					{
						if (obj23 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8961");
							text2 = purchaseToken;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8962");
							text2 = purchaseToken;
						}
					}
					else if (obj23 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77FE");
						text3 = purchaseToken;
						text2 = transactionId;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
						text2 = purchaseToken;
					}
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
			object obj24 = (nint)0 & (nint)0x7FF;
			text3 = (string)(obj24 + 121922);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v195 @ S5_v6 (System.String) (should have been resolved before IL gen)");
			text2 = text;
		}
	}

	public void InitFinishedCallback(bool success)
	{
		//IL_000e: Expected Obj, but got I4
		string inAppAPIKey = getInAppAPIKey();
		if (inAppAPIKey != null)
		{
			IEnumerable<_0021_00210> source = (IEnumerable<_0021_00210>)Enumerable.Reverse<TSource>((IEnumerable<TSource>)success);
			string[] array = Enumerable.ToArray((IEnumerable<string>)source);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		}
	}

	public string getInAppAPIKey()
	{
		if (_currentInitializationState == IAPPluginInitializationState.InitializedSuccessfully)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string result = default;
			return result;
		}
		return null;
	}

	public IsIAPConsumableValue IsProductConsumable(string productID)
	{
		string inAppAPIKey = getInAppAPIKey();
		if (inAppAPIKey != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			IsIAPConsumableValue result = default;
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		return IsIAPConsumableValue.Consumable;
	}

	public void ProductInfoRequestCallback(bool success, ProductRequestResultInfo[] productInfo)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0028: Expected Obj, but got I4
		if (_provider != null && _currentInitializationState == IAPPluginInitializationState.NotInitialized)
		{
			object obj = this + 16;
			obj = success;
			_currentInitializationState = IAPPluginInitializationState.Initializing;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
		}
		else if (_currentInitializationState != IAPPluginInitializationState.Initializing && _currentInitializationState != IAPPluginInitializationState.InitializedSuccessfully)
		{
			goto IL_0097;
		}
		if (_provider != null)
		{
			goto IL_0097;
		}
		return;
		IL_0097:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj2 = default;
		if (obj2 != null)
		{
			LogWarning("Expected to NOT have validation server specified for current platform. Update InAppPurchaseProvider constructor");
		}
	}

	public void PurchaseRequestCallback(string productId, string transactionId, string transationIdBase64, string cookie, PurchaseResult result, IPurchaseValidationResult validationResult)
	{
		//IL_0015: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I4
		//IL_061e: Expected Obj, but got I
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got I
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_05b9: Expected Obj, but got I
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
		//IL_05da: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I4
		//IL_0402: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I
		//IL_04c8: Expected Obj, but got I
		//IL_02f1: Expected Obj, but got I
		//IL_048c: Expected Obj, but got I
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected Obj, but got Unknown
		//IL_04ad: Expected Obj, but got I4
		//IL_0581: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.InAppPurchaseProvider)+34]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.InAppPurchaseProvider)+34]");
		object obj3;
		object obj4;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.InAppPurchaseProvider)+34]");
			object obj2 = (nint)0 + (nint)16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
			obj3 = 0;
			obj4 = obj2;
		}
		else
		{
			obj4 = this;
			obj3 = 1;
		}
		object obj5 = default;
		object obj25 = default;
		object obj17 = default;
		object obj23 = default;
		for (; obj5 != obj3; obj5 = obj25 + 1)
		{
			object obj6 = obj5 << 2;
			object obj7 = obj4 + obj6;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+10]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+14]");
			IPurchaseValidationResult purchaseValidationResult = (IPurchaseValidationResult)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v19 (Kiloo.Common.Backend.PurchaseValidation.IPurchaseValidationResult)+28]");
			if ((nint)0 == -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v19 (Kiloo.Common.Backend.PurchaseValidation.IPurchaseValidationResult)+2A]");
			bool flag = (nint)0 == 6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v19 (Kiloo.Common.Backend.PurchaseValidation.IPurchaseValidationResult)+24]");
			object obj10 = (nint)0 & (nint)0x10;
			bool flag2 = obj10 == null;
			object obj11 = (flag2 ? 1 : 0) ^ 1;
			IPurchaseValidationResult purchaseValidationResult3;
			IPurchaseValidationResult purchaseValidationResult2;
			if (obj11 != null)
			{
				if (flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+8]");
					object obj12 = (nint)0 & (nint)0xFF;
					purchaseValidationResult2 = (IPurchaseValidationResult)(obj12 + 125020);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v224 @ S7_v16 (Kiloo.Common.Backend.PurchaseValidation.IPurchaseValidationResult) (should have been resolved before IL gen)");
					purchaseValidationResult3 = (IPurchaseValidationResult)125020;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+8]");
					object obj13 = (nint)0 & (nint)0x7F;
					purchaseValidationResult3 = (IPurchaseValidationResult)(obj13 + 125278);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v222 @ S8_v6 (Kiloo.Common.Backend.PurchaseValidation.IPurchaseValidationResult) (should have been resolved before IL gen)");
					purchaseValidationResult2 = purchaseValidationResult;
				}
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v19 (Kiloo.Common.Backend.PurchaseValidation.IPurchaseValidationResult)+28]");
			bool flag3 = (nint)0 != -1;
			if (!flag)
			{
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+10]");
					bool flag4;
					if ((nint)0 != 0)
					{
						object obj14 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v94+9C]");
						object obj15 = (nint)0 & (nint)0x100;
						flag4 = obj15 != null;
					}
					else
					{
						flag4 = false;
					}
					if (!flag4 && _currentInitializationState != IAPPluginInitializationState.NotInitialized)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v19 (Kiloo.Common.Backend.PurchaseValidation.IPurchaseValidationResult)+2B]");
						object obj16 = (nint)0 & (nint)3;
						bool flag5 = (nint)obj16 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag5)
						{
							if (obj17 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8941");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8942");
							}
						}
						else if (obj17 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8943");
							purchaseValidationResult2 = validationResult;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8944");
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+8]");
				object obj18 = (nint)0 & (nint)0xFF;
				purchaseValidationResult2 = (IPurchaseValidationResult)(obj18 + 125020);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v224 @ S7_v16 (Kiloo.Common.Backend.PurchaseValidation.IPurchaseValidationResult) (should have been resolved before IL gen)");
				purchaseValidationResult3 = (IPurchaseValidationResult)125020;
				continue;
			}
			if (flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+10]");
				bool flag6;
				if ((nint)0 != 0)
				{
					object obj19 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v66+9C]");
					object obj20 = (nint)0 & (nint)0x100;
					flag6 = obj20 != null;
				}
				else
				{
					flag6 = false;
				}
				if (!flag6 && _currentInitializationState != IAPPluginInitializationState.NotInitialized)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+10]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+8]");
						object obj21 = (nint)0 & (nint)0xFF;
						purchaseValidationResult2 = (IPurchaseValidationResult)(obj21 + 125020);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v224 @ S7_v16 (Kiloo.Common.Backend.PurchaseValidation.IPurchaseValidationResult) (should have been resolved before IL gen)");
						purchaseValidationResult3 = (IPurchaseValidationResult)125020;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v19 (Kiloo.Common.Backend.PurchaseValidation.IPurchaseValidationResult)+2B]");
					object obj22 = (nint)0 & (nint)3;
					bool flag7 = (nint)obj22 == 2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
					if (flag7)
					{
						if (obj23 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8945");
							purchaseValidationResult2 = validationResult;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8946");
							purchaseValidationResult2 = validationResult;
						}
					}
					else if (obj23 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8947");
						purchaseValidationResult3 = validationResult;
						purchaseValidationResult2 = (IPurchaseValidationResult)result;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8948");
						purchaseValidationResult2 = validationResult;
					}
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+8]");
			object obj24 = (nint)0 & (nint)0x7F;
			purchaseValidationResult3 = (IPurchaseValidationResult)(obj24 + 125278);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v222 @ S8_v6 (Kiloo.Common.Backend.PurchaseValidation.IPurchaseValidationResult) (should have been resolved before IL gen)");
			purchaseValidationResult2 = purchaseValidationResult;
		}
	}

	public void ItemRestoredCallback(string productId, string transactionId, string cookie)
	{
		string inAppAPIKey = getInAppAPIKey();
		if (inAppAPIKey != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77FE");
		}
	}

	public void CheckedItemRestoredCallback(string productId, string transactionId, string cookie, IPurchaseValidationResult validationResult)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = productId;
		object obj2 = obj + 4;
		obj2 = transactionId;
		object obj3 = obj + 8;
		obj3 = cookie;
		object obj4 = obj + 12;
		obj4 = validationResult;
	}

	public void ItemRefundedCallback(string productid, string transactionid, string cookie, IPurchaseValidationResult validationResult)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8965");
	}

	public void RestoreRequestFinishedCallback(RestoreFinishedResult result)
	{
		if (result != RestoreFinishedResult.Failed)
		{
			_currentInitializationState = IAPPluginInitializationState.InitializedSuccessfully;
		}
		else
		{
			_currentInitializationState = IAPPluginInitializationState.NotInitialized;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
	}

	private static void LogError(string msg)
	{
		//IL_013d: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = msg + 20;
		object obj7 = default;
		obj6 = obj7;
		string dataPath = Application.dataPath;
		if (dataPath != null)
		{
			object obj8 = dataPath - 7;
			if ((nint)dataPath != 7)
			{
				if ((nint)obj8 != 1)
				{
					if ((nint)obj8 != 2 && (nint)obj8 != 3 && (nint)obj8 == 4)
					{
						object obj9 = msg + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						object obj10 = default;
						obj9 = obj10;
					}
				}
				else
				{
					object obj11 = msg + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj12 = default;
					obj11 = obj12;
				}
				return;
			}
		}
		object obj13 = msg + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj14 = default;
		obj13 = obj14;
	}

	private static void LogWarning(string msg)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"[InAppPurchaseProvider] ", (int)msg);
		SDebug.LogFormat(msg2, null);
	}

	private static void Log(string msg)
	{
	}
}
