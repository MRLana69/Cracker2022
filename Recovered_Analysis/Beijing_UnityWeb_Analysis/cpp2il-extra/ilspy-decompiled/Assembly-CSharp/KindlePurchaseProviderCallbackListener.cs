using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using UnityEngine;

public class KindlePurchaseProviderCallbackListener : MonoBehaviour
{
	private Action<string> _onProductRequestSuccessful;

	private Action<string> _onProductRequestFailed;

	private Action _onRestoreFinished;

	private Action _onRestoreFailed;

	private Action _onRestoreFinishedNothingToRestore;

	private Action<string> _onRestoreSuccessful;

	private Action<string> _onPurchaseSuccessful;

	private Action<string> _onPurchaseFailedInvalidId;

	private Action<string> _onPurchaseFailed;

	private Action<string> _onPurchaseRefunded;

	public void Setup(Action<string> onProductRequestSuccessful, Action<string> onProductRequestFailed, Action onRestoreFinished, Action onRestoreFailed, Action onRestoreFinishedNothingToRestore, Action<string> onRestoreSuccessful, Action<string> onPurchaseSuccessful, Action<string> onPurchaseFailedInvalidId, Action<string> onPurchaseFailed, Action<string> onPurchaseRefunded)
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
		//IL_00b6: Expected Obj, but got I4
		object obj = this + 8;
		obj = onProductRequestSuccessful;
		object obj2 = this + 12;
		obj2 = onProductRequestFailed;
		object obj3 = this + 16;
		obj3 = onRestoreFinished;
		object obj4 = this + 20;
		obj4 = onRestoreFailed;
		object obj5 = this + 24;
		obj5 = onRestoreFinishedNothingToRestore;
		object obj6 = this + 28;
		obj6 = onRestoreSuccessful;
		object obj7 = this + 32;
		obj7 = onPurchaseSuccessful;
		object obj8 = this + 36;
		obj8 = onPurchaseFailedInvalidId;
		object obj9 = this + 40;
		obj9 = onPurchaseFailed;
		_onPurchaseFailed = (Action<string>)1;
		if (onPurchaseRefunded == null)
		{
			string text = ((NativeInterstitialAdObject)(object)this).ToString();
		}
	}

	public void ProductRequestSuccessful(string message)
	{
	}

	public void ProductRequestFailed(string message)
	{
		FacebookImageDownloader.DownloadImages(null, (string)(object)_onProductRequestSuccessful, (Action<Texture2D, Texture2D>)(object)message);
	}

	public void ProductRestoredSuccessfully(string message)
	{
		FacebookImageDownloader.DownloadImages(null, (string)(object)_onProductRequestFailed, (Action<Texture2D, Texture2D>)(object)message);
	}

	public void ProductRestoreFinished(string empty)
	{
		FacebookImageDownloader.DownloadImages(null, (string)(object)_onRestoreSuccessful, (Action<Texture2D, Texture2D>)(object)empty);
	}

	public void ProductRestoreFinishedButNothingHasBeenRestored(string empty)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @894E");
	}

	public void ProductRestoreFailed(string empty)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @894E");
	}

	public void ProductPurchasedSuccessfully(string message)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @894E");
	}

	public void ProductPurchaseInvalidId(string message)
	{
		FacebookImageDownloader.DownloadImages(null, (string)(object)_onPurchaseSuccessful, (Action<Texture2D, Texture2D>)(object)message);
	}

	public void ProductPurchaseFailed(string message)
	{
		FacebookImageDownloader.DownloadImages(null, (string)(object)_onPurchaseFailedInvalidId, (Action<Texture2D, Texture2D>)(object)message);
	}

	public void ProductRefunded(string message)
	{
		FacebookImageDownloader.DownloadImages(null, (string)(object)_onPurchaseFailed, (Action<Texture2D, Texture2D>)(object)message);
	}

	private void FireEventWithMessage(Action<string> handler, string message)
	{
	}

	private void FireEmptyEvent(Action handler)
	{
		FacebookImageDownloader.DownloadImages(null, (string)(object)_onPurchaseRefunded, (Action<Texture2D, Texture2D>)(object)handler);
	}

	public KindlePurchaseProviderCallbackListener()
	{
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected Obj, but got Unknown
		//IL_00ae: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0578: Expected I, but got Obj
		//IL_058e: Expected Obj, but got I
		//IL_00ef: Expected I, but got Obj
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		//IL_013c: Expected I, but got Obj
		//IL_023f: Expected I, but got Obj
		//IL_0255: Expected Obj, but got I
		//IL_0674: Expected Obj, but got I
		//IL_0684: Expected Obj, but got I
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected Obj, but got Unknown
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected Obj, but got Unknown
		//IL_06c0: Expected I, but got Obj
		//IL_06d6: Expected Obj, but got I
		//IL_01a6: Expected I, but got Obj
		//IL_01bc: Expected Obj, but got I
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected Obj, but got Unknown
		//IL_0714: Expected Obj, but got I4
		//IL_0280: Expected I, but got Obj
		//IL_05e7: Expected I, but got Obj
		//IL_05fd: Expected Obj, but got I
		//IL_02cd: Expected I, but got Obj
		//IL_0618: Expected I, but got Obj
		//IL_062e: Expected Obj, but got I
		//IL_01e7: Expected I, but got Obj
		//IL_03dc: Expected I, but got Obj
		//IL_03f2: Expected Obj, but got I
		//IL_040f: Expected I, but got Obj
		//IL_07a6: Expected Obj, but got I
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_0344: Expected I, but got Obj
		//IL_035a: Expected Obj, but got I
		//IL_0494: Expected I, but got Obj
		//IL_042b: Expected I, but got Obj
		//IL_045b: Expected I, but got Obj
		//IL_072f: Expected Obj, but got I
		//IL_073f: Expected Obj, but got I
		//IL_074f: Expected Obj, but got I
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Expected Obj, but got Unknown
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected Obj, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected Obj, but got Unknown
		//IL_0385: Expected I, but got Obj
		//IL_0481: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		NullReferenceException ex2;
		if ((nint)0 != 0)
		{
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v155 (Il2CppClass<Strings>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v164 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			object obj5 = default;
			object obj4 = obj5 + 16;
			obj4 = obj2;
			NullReferenceException ex = new NullReferenceException();
			if (ex != null)
			{
				ex2 = ex;
				goto IL_056a;
			}
		}
		nint num4 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v144 (Il2CppClass<Strings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v150 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A374");
		NullReferenceException ex3 = default;
		ex2 = ex3;
		goto IL_056a;
		IL_056a:
		nint num6 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v14 (Il2CppClass<Strings>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v136 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((object)Strings._language == ex2)
		{
			return;
		}
		if (ex2 != null)
		{
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v119 (Il2CppClass<Strings>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num9 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v132 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string localizedOnlineSettings = Strings.GetLocalizedOnlineSettings((string)(object)ex2, null);
			Strings._currentLanguageMap = (Dictionary<string, string>)(object)localizedOnlineSettings;
			nint num10 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v129 (Il2CppClass<Strings>)+5C]");
			object obj9 = (nint)0 + (nint)16;
			obj9 = ex2;
		}
		else
		{
			SDebug.LogFormat("No language found", null);
			nint num11 = (nint)typeof(StringID);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v42 (Il2CppClass<StringID>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num12 = (nint)typeof(StringID);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v112 (Il2CppClass<StringID>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string[] entries = StringID.entries;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S3_v4 (Il2CppMethodInfo)+C]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S3_v5+60]");
			object obj12 = 0;
			object obj13 = obj12;
			object obj14 = obj13 & 0x1FFF;
			object obj15 = obj14 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v262 @ S4_v6 (should have been resolved before IL gen)");
			nint num14 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v53 (Il2CppClass<Strings>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num15 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v106 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, string> currentLanguageMap = default;
			Strings._currentLanguageMap = currentLanguageMap;
			object obj17 = StringID.entries + 12;
			object obj18 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17))
			{
				object obj19 = StringID.entries + 16;
				object obj20 = obj18 << 2;
				object obj21 = obj19 + obj20;
				nint num16 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S0_v90 (Il2CppClass<Strings>)+BA]");
				object obj22 = (nint)0 & (nint)0x200;
				if (obj22 != null)
				{
					nint num17 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S0_v100 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S4_v9 (Il2CppMethodInfo)+C]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S4_v10+60]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S4_v11+48]");
				object obj25 = 0;
				object obj26 = obj25 & 0x7FF;
				object obj27 = obj26 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v303 @ S5_v9 (should have been resolved before IL gen)");
				object obj28 = obj18 + 1;
				obj18 = obj28;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num19 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v72 (Il2CppClass<Strings>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			bool flag = obj29 == null;
			nint num20 = (nint)typeof(Strings);
			if (!flag)
			{
				nint num21 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S0_v79 (Il2CppClass<Strings>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num20 = (nint)typeof(Strings);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num20 = (nint)typeof(Strings);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ L0_v17 (Il2CppClass<Strings>)+5C]");
			object obj30 = (nint)0 + (nint)16;
			object obj31 = default;
			obj30 = obj31;
		}
		nint num22 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v26 (Il2CppClass<Strings>)+BA]");
		object obj32 = (nint)0 & (nint)0x200;
		if (obj32 != null)
		{
			nint num23 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v33 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.Reset((Transform)(object)Strings.languageChanged);
	}
}
