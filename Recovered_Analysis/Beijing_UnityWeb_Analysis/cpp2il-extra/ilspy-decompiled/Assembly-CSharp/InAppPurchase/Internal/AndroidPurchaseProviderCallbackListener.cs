using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Backend.PurchaseValidation;
using SYBO.Components.Json;
using UnityEngine;
using UnityEngine.Rendering;

namespace InAppPurchase.Internal;

public class AndroidPurchaseProviderCallbackListener : MonoBehaviour
{
	private Action _onInitSuccessful;

	private Action _onInitFailed;

	private Action<string> _onProductRequestSuccessful;

	private Action _onProductRequestFailed;

	private Action<string> _onPurchasePurchased;

	private Action<string> _onPurchaseRestored;

	private Action<string> _onPurchaseRefunded;

	private Action<string> _onPurchaseFailed;

	private Action<string> _onRestoreFinished;

	private Action<string> _onConsumeFinished;

	public void Setup(Action onInitSuccessful, Action onInitFailed, Action<string> onProductRequestSuccessful, Action onProductRequestFailed, Action<string> onPurchasePurchased, Action<string> onPurchaseRestored, Action<string> onPurchaseRefunded, Action<string> onPurchaseFailed, Action<string> onRestoreFinished, Action<string> onConsumeFinished)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		object obj = this + 12;
		obj = onInitSuccessful;
		object obj2 = this + 16;
		obj2 = onInitFailed;
		object obj3 = this + 20;
		obj3 = onProductRequestSuccessful;
		object obj4 = this + 24;
		obj4 = onProductRequestFailed;
		object obj5 = this + 28;
		obj5 = onPurchasePurchased;
		object obj6 = this + 32;
		obj6 = onPurchaseRestored;
		object obj7 = this + 36;
		obj7 = onPurchaseRefunded;
		object obj8 = this + 40;
		obj8 = onPurchaseFailed;
		object obj9 = this + 44;
		obj9 = onRestoreFinished;
		object obj10 = this + 48;
		obj10 = onConsumeFinished;
	}

	private void AndroidPurchaseProvider_InitSuccessful(string notUsed)
	{
		//IL_0286: Expected I, but got Obj
		//IL_029c: Expected Obj, but got I
		//IL_0332: Expected I4, but got Obj
		//IL_0090: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00bf: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0076: Expected I4, but got Obj
		//IL_007e: Expected I4, but got Obj
		//IL_02cb: Expected I4, but got Obj
		//IL_02d4: Expected I4, but got Obj
		//IL_0100: Expected I, but got Obj
		//IL_0201: Expected Obj, but got I4
		//IL_01d3: Expected Obj, but got I4
		nint num = (nint)typeof(AndroidPurchaseProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<InAppPurchase.Internal.AndroidPurchaseProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AndroidPurchaseProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v74 (Il2CppClass<InAppPurchase.Internal.AndroidPurchaseProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = notUsed.Substring((int)AndroidPurchaseProvider.SEPARATOR_FOR_STRING_SPLIT);
		int totalLength;
		int totalLength2;
		if (text.m_firstChar == '\u0002')
		{
			object obj2 = text + 16;
			object obj3 = text + 20;
			totalLength = (int)obj3;
			totalLength2 = (int)obj2;
		}
		else
		{
			object obj4 = text.m_firstChar;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text2 = default;
			string msg = "Unexpected length of message in ConsumeFinished, expected 2, received " + text2;
			nint num3 = (nint)typeof(AndroidPurchaseProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v24 (Il2CppClass<InAppPurchase.Internal.AndroidPurchaseProvider>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(AndroidPurchaseProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v29 (Il2CppClass<InAppPurchase.Internal.AndroidPurchaseProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			AndroidPurchaseProvider.Log(msg);
			totalLength = (int)string.Empty;
			totalLength2 = (int)string.Empty;
		}
		string key = string.ConcatArray((string[])(object)"SHOULD_CONSUME_", totalLength2);
		bool flag = PlayerPrefs.HasKey(key);
		string key2 = string.ConcatArray((string[])(object)"SHOULD_CONSUME_TOKEN_", totalLength);
		bool flag2 = PlayerPrefs.HasKey(key2);
		bool flag3;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v30 (System.Boolean)+8]");
			flag3 = (nint)0 == 0;
		}
		else
		{
			flag3 = true;
		}
		object obj6;
		if (flag3)
		{
			obj6 = 0;
		}
		else
		{
			string text3 = string.ConcatArray((string[])(object)"SHOULD_CONSUME_", totalLength2);
			((PropertyAttribute)(object)text3)._002Ector();
			obj6 = 1;
		}
		bool flag4;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v34 (System.Boolean)+8]");
			flag4 = (nint)0 == 0;
		}
		else
		{
			flag4 = true;
		}
		if (flag4)
		{
			if (obj6 == null)
			{
				return;
			}
		}
		else
		{
			string text4 = string.ConcatArray((string[])(object)"SHOULD_CONSUME_TOKEN_", totalLength);
			((PropertyAttribute)(object)text4)._002Ector();
		}
		RenderPipelineManager.CleanupRenderPipeline();
	}

	private void AndroidPurchaseProvider_InitFailed(string notUsed)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @894E");
	}

	private void AndroidPurchaseProvider_ProductRequestSuccessful(string message)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @894E");
	}

	private void AndroidPurchaseProvider_ProductRequestFailed(string notUsed)
	{
		((EditorPurchaseProvider)null).Init((IInAppManager)(object)_onProductRequestSuccessful, (IPurchaseValidationServer)(object)notUsed);
	}

	private void AndroidPurchaseProvider_PurchasePurchased(string message)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @894E");
	}

	private void AndroidPurchaseProvider_PurchaseRestored(string message)
	{
		((EditorPurchaseProvider)null).Init((IInAppManager)(object)_onPurchasePurchased, (IPurchaseValidationServer)(object)message);
	}

	private void AndroidPurchaseProvider_PurchaseRefunded(string message)
	{
		((EditorPurchaseProvider)null).Init((IInAppManager)(object)_onPurchaseRestored, (IPurchaseValidationServer)(object)message);
	}

	private void AndroidPurchaseProvider_PurchaseFailed(string message)
	{
		((EditorPurchaseProvider)null).Init((IInAppManager)(object)_onPurchaseRefunded, (IPurchaseValidationServer)(object)message);
	}

	private void AndroidPurchaseProvider_RestoreFinished(string message)
	{
		((EditorPurchaseProvider)null).Init((IInAppManager)(object)_onPurchaseFailed, (IPurchaseValidationServer)(object)message);
	}

	private void AndroidPurchaseProvider_ConsumeFinished(string message)
	{
		((EditorPurchaseProvider)null).Init((IInAppManager)(object)_onRestoreFinished, (IPurchaseValidationServer)(object)message);
	}

	private unsafe void FireEventWithMessage(Action<string> handler, string message)
	{
		//IL_01ce: Expected I4, but got Obj
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0221: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got I4
		ref bool reference2 = default;
		ref bool reference = ref System.Runtime.CompilerServices.Unsafe.Add(ref reference2, 16);
		reference = ref *(bool*)null;
		ref bool reference3 = ref System.Runtime.CompilerServices.Unsafe.Add(ref reference2, 12);
		reference3 = ref *(bool*)null;
		ref string reference4 = ref System.Runtime.CompilerServices.Unsafe.As<bool, string>(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference2, 8));
		reference4 = ref *(string*)null;
		ref int reference5 = ref System.Runtime.CompilerServices.Unsafe.As<bool, int>(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference2, 4));
		reference5 = ref *(int*)null;
		reference2 = ref *(bool*)null;
		if (JsonClassInfo.ShouldSerializeField((FieldInfo)null, out *(bool*)handler, out reference, out reference3, out reference4, out reference5, out reference2))
		{
			object obj = message - 2;
			if ((nint)message != 2)
			{
				if ((nint)obj != 1 && (nint)obj != 2)
				{
					if ((nint)obj == 3)
					{
						((AndroidPurchaseProvider)(object)this).InvokeCheckedItemRestore((string)reference, (string)reference3, (string)reference5, (string)reference2);
						return;
					}
					if ((nint)obj == 4)
					{
						((EditorPurchaseProvider)(object)this).FinishPurchase((string)reference, (string)reference3, (string)reference5);
						return;
					}
				}
				if (((AndroidPurchaseProvider)(object)this).TryParseProductInfo((string)reference, out *(reference3 ? ((ProductRequestResultInfo[]*)1) : ((ProductRequestResultInfo[]*)null))))
				{
					((AndroidPurchaseProvider)(object)this).HandlePurchase(message, (string)reference, (string)reference3, (string)reference5, reference2 ? InternalPurchaseResult.Failed : InternalPurchaseResult.Completed);
				}
				else
				{
					((AndroidPurchaseProvider)(object)this).InvokeItemRestore((string)reference, (string)reference3, (string)reference2);
				}
			}
			else
			{
				((IOSPurchaseProvider)(object)this).HandlePurchase((string)reference, (string)reference3, (string)reference5, reference2 ? InternalPurchaseResult.Failed : InternalPurchaseResult.Completed);
			}
			return;
		}
		string msg = string.ConcatArray((string[])(object)"AndroidPurchaseProvider ERROR: Malformed message from native code: ", (int)handler);
		nint num = (nint)typeof(AndroidPurchaseProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v16 (Il2CppClass<InAppPurchase.Internal.AndroidPurchaseProvider>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(AndroidPurchaseProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v21 (Il2CppClass<InAppPurchase.Internal.AndroidPurchaseProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AndroidPurchaseProvider.Log(msg);
	}

	private void FireEmptyEvent(Action handler)
	{
		((EditorPurchaseProvider)null).Init((IInAppManager)(object)_onConsumeFinished, (IPurchaseValidationServer)(object)handler);
	}
}
