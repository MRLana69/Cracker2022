using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Monetization.FacebookAds.Internal;

public class FacebookNativeAdsSimulated : MonoBehaviour, IFacebookNativeAdsBridge
{
	private bool _adReady;

	private bool _adLoading;

	private bool _initialized;

	private FBNativeDownloader _fbNativeDownloader;

	private NativeInterstitialAdObject _currentAdObject;

	private NativeInterstitialAdObject tmpAd;

	private int count;

	private const string CALLBACK_RECEIVER_NAME = "FacebookAdSimulatedReceiver";

	private Action<string> m_onInitialize;

	private Action<string> m_onNativeDidLoad;

	private Action<string> m_onNativeAdError;

	private Action<string> m_onNativeClicked;

	private Action<string> m_onNativeLoggingImpression;

	public event Action<string> onInitialize
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 32;
			Delegate obj2 = this.m_onInitialize;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 32;
			Delegate obj2 = this.m_onInitialize;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<string> onNativeDidLoad
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 36;
			Delegate obj2 = this.m_onNativeDidLoad;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 36;
			Delegate obj2 = this.m_onNativeDidLoad;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<string> onNativeAdError
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 40;
			Delegate obj2 = this.m_onNativeAdError;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 40;
			Delegate obj2 = this.m_onNativeAdError;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<string> onNativeClicked
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 44;
			Delegate obj2 = this.m_onNativeClicked;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 44;
			Delegate obj2 = this.m_onNativeClicked;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<string> onNativeLoggingImpression
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 48;
			Delegate obj2 = this.m_onNativeLoggingImpression;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 48;
			Delegate obj2 = this.m_onNativeLoggingImpression;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public unsafe void InitializeNative(string placementID)
	{
		//IL_004f: Expected Obj, but got I
		FBNativeDownloader instance = FBNativeDownloader.instance;
		_fbNativeDownloader = instance;
		FBNativeDownloader.DidDownload didDownload = default;
		didDownload._002Ector(this, (nint)__ldftn(FacebookNativeAdsSimulated._callback_onImagesDownloaded));
		_fbNativeDownloader.onDownloaded += didDownload;
		if (this.m_onInitialize != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S3_v4 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v45 @ S3_v5+4] (should have been resolved before IL gen)");
		}
		_initialized = true;
	}

	public bool IsNativeAdLoaded()
	{
		return _adReady;
	}

	public void LoadNativeAd()
	{
		if (~(_initialized ? 1u : 0u) == 0 && !_adLoading)
		{
			_adReady = false;
			NativeInterstitialAdObject testAd = GetTestAd();
			tmpAd = testAd;
			NativeInterstitialAdObject nativeInterstitialAdObject = tmpAd;
			_fbNativeDownloader.DownloadImages(nativeInterstitialAdObject._iconImageURL, nativeInterstitialAdObject._coverImageURL);
		}
	}

	public void DisposeNativeAd()
	{
		if (_currentAdObject != null)
		{
			_currentAdObject.Dispose();
			_currentAdObject = null;
			_adReady = false;
		}
	}

	public void LogExternalClick()
	{
	}

	public void LogExternalImpression()
	{
	}

	private void _callback_onImagesDownloaded(Texture2D iconImage, Texture2D coverImage)
	{
		//IL_00e3: Expected Obj, but got I
		Action<string> action;
		if ((bool)iconImage && (bool)coverImage)
		{
			NativeInterstitialAdObject nativeInterstitialAdObject = tmpAd;
			NativeInterstitialAdObject nativeInterstitialAdObject2 = default;
			nativeInterstitialAdObject2._002Ector(nativeInterstitialAdObject._title, nativeInterstitialAdObject._subtitle, nativeInterstitialAdObject._body, nativeInterstitialAdObject._socialContext, nativeInterstitialAdObject._callToActionText, nativeInterstitialAdObject._iconImageURL, nativeInterstitialAdObject._coverImageURL, iconImage, coverImage, ignoreValidate: true);
			_currentAdObject = nativeInterstitialAdObject2;
			_adReady = true;
			action = this.m_onNativeDidLoad;
		}
		else
		{
			action = this.m_onNativeAdError;
		}
		if (action != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S3_v4 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v109 @ S3_v5+4] (should have been resolved before IL gen)");
		}
	}

	public NativeInterstitialAdObject GetNativeAdAssets()
	{
		if (~(_adReady ? 1u : 0u) != 0)
		{
			return null;
		}
		return _currentAdObject;
	}

	private NativeInterstitialAdObject GetTestAd()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0155: Expected Obj, but got I
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected VT, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected VT, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_025f: Expected Obj, but got I
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected VT, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_02bd: Expected Obj, but got I
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected VT, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_0369: Expected Obj, but got I
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected VT, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got Unknown
		//IL_03c7: Expected Obj, but got I
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected VT, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected Obj, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected VT, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected VT, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected Obj, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected VT, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected Obj, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected VT, but got Unknown
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected Obj, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected VT, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected Obj, but got Unknown
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected VT, but got Unknown
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected Obj, but got Unknown
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Expected VT, but got Unknown
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected Obj, but got Unknown
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected VT, but got Unknown
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected Obj, but got Unknown
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Expected VT, but got Unknown
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_0885: Expected Obj, but got Unknown
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected VT, but got Unknown
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Expected Obj, but got Unknown
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_095b: Expected VT, but got Unknown
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected Obj, but got Unknown
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Expected VT, but got Unknown
		object obj = default;
		FacebookNativeAdsSimulated facebookNativeAdsSimulated = (FacebookNativeAdsSimulated)(obj - 304);
		_ = 0;
		if (count != 0)
		{
			if (count != 1)
			{
				if (count != 2)
				{
					if (count != 3)
					{
						if (count != 4)
						{
							if (count != 5)
							{
								if (count != 6)
								{
									if (count != 7)
									{
										if (count == 8)
										{
											count = 9;
											object obj2 = facebookNativeAdsSimulated + 296;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
											_ = 0;
											int? val = (int?)(object)(facebookNativeAdsSimulated + 144);
											string randomIconURL = facebookNativeAdsSimulated.GetRandomIconURL(val);
											object obj3 = facebookNativeAdsSimulated + 296;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
											_ = 0;
											int? val2 = (int?)(object)(facebookNativeAdsSimulated + 136);
											string randomCoverURL = facebookNativeAdsSimulated.GetRandomCoverURL(val2);
											NativeInterstitialAdObject nativeInterstitialAdObject = default;
											nativeInterstitialAdObject._002Ector("2017 ع ۾ بورڊ هلائڻ: وڌيڪ سويڊن چونڊي", "Subtitle Text Test", "اشتهار: توهان بورڊ هلائڻ موڪل جو ڏينهن تي پئسا بچايو - سويڊن ڏانهن وڃو", "SocialContextTest", "وڌيڪ سکو", randomIconURL, randomCoverURL, null, null, ignoreValidate: true);
											return nativeInterstitialAdObject;
										}
										count = 0;
										return GetTestAd();
									}
									count = 8;
									object obj4 = facebookNativeAdsSimulated + 296;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
									_ = 0;
									int? val3 = (int?)(object)(facebookNativeAdsSimulated + 128);
									string randomIconURL2 = facebookNativeAdsSimulated.GetRandomIconURL(val3);
									object obj5 = facebookNativeAdsSimulated + 296;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
									_ = 0;
									int? val4 = (int?)(object)(facebookNativeAdsSimulated + 120);
									string randomCoverURL2 = facebookNativeAdsSimulated.GetRandomCoverURL(val4);
									NativeInterstitialAdObject nativeInterstitialAdObject2 = default;
									nativeInterstitialAdObject2._002Ector("סקי בשנת 2017: יותר לבחור שוודיה", "Subtitle Text Test", "פרסומת: חוסכת כסף על חופשת הסקי שלך - נוסע לשוודיה", "SocialContextTest", "מידע נוסף", randomIconURL2, randomCoverURL2, null, null, ignoreValidate: true);
									return nativeInterstitialAdObject2;
								}
								count = 7;
								object obj6 = facebookNativeAdsSimulated + 296;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
								_ = 0;
								int? val5 = (int?)(object)(facebookNativeAdsSimulated + 112);
								string randomIconURL3 = facebookNativeAdsSimulated.GetRandomIconURL(val5);
								object obj7 = facebookNativeAdsSimulated + 296;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
								_ = 0;
								int? val6 = (int?)(object)(facebookNativeAdsSimulated + 104);
								string randomCoverURL3 = facebookNativeAdsSimulated.GetRandomCoverURL(val6);
								NativeInterstitialAdObject nativeInterstitialAdObject3 = default;
								nativeInterstitialAdObject3._002Ector("2017 yılında Kayak: Daha İsveç seçin", "Nordjyderne", "REKLAM: İsveç kayak tatil etiketi üzerinde tasarruf", "NORDJYSKE.DK", "Daha fazla Bilgi", randomIconURL3, randomCoverURL3, null, null, ignoreValidate: true);
								return nativeInterstitialAdObject3;
							}
							count = 6;
							object obj8 = facebookNativeAdsSimulated + 296;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
							_ = 0;
							int? val7 = (int?)(object)(facebookNativeAdsSimulated + 96);
							string randomIconURL4 = facebookNativeAdsSimulated.GetRandomIconURL(val7);
							object obj9 = facebookNativeAdsSimulated + 296;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
							_ = 0;
							int? val8 = (int?)(object)(facebookNativeAdsSimulated + 88);
							string randomCoverURL4 = facebookNativeAdsSimulated.GetRandomCoverURL(val8);
							NativeInterstitialAdObject nativeInterstitialAdObject4 = default;
							nativeInterstitialAdObject4._002Ector("Skíði árið 2017: Meira velja Svíþjóð", "Nordjyderne", "Advertisement: Spara peninga á skíði frí tag til Svíþjóðar", "NORDJYSKE.DK", "Frekari upplýsingar", randomIconURL4, randomCoverURL4, null, null, ignoreValidate: true);
							return nativeInterstitialAdObject4;
						}
						count = 5;
						object obj10 = facebookNativeAdsSimulated + 296;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
						_ = 0;
						int? val9 = (int?)(object)(facebookNativeAdsSimulated + 80);
						string randomIconURL5 = facebookNativeAdsSimulated.GetRandomIconURL(val9);
						object obj11 = facebookNativeAdsSimulated + 296;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
						_ = 0;
						int? val10 = (int?)(object)(facebookNativeAdsSimulated + 72);
						string randomCoverURL5 = facebookNativeAdsSimulated.GetRandomCoverURL(val10);
						NativeInterstitialAdObject nativeInterstitialAdObject5 = default;
						nativeInterstitialAdObject5._002Ector("Lyžování v roce 2017: Více zvolit Švédsko", "Nordjyderne", "REKLAMA: Ušetřete peníze na vaši lyžařskou dovolenou tag do Švédska", "NORDJYSKE.DK", "Více informací", randomIconURL5, randomCoverURL5, null, null, ignoreValidate: true);
						return nativeInterstitialAdObject5;
					}
					count = 4;
					object obj12 = facebookNativeAdsSimulated + 296;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
					_ = 0;
					int? val11 = (int?)(object)(facebookNativeAdsSimulated - -64);
					string randomIconURL6 = facebookNativeAdsSimulated.GetRandomIconURL(val11);
					object obj13 = facebookNativeAdsSimulated + 296;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
					_ = 0;
					int? val12 = (int?)(object)(facebookNativeAdsSimulated + 56);
					string randomCoverURL6 = facebookNativeAdsSimulated.GetRandomCoverURL(val12);
					NativeInterstitialAdObject nativeInterstitialAdObject6 = default;
					nativeInterstitialAdObject6._002Ector("Esqui em 2017: Mais escolha Suécia", "Nordjyderne", "PUBLICIDADE: poupar dinheiro em seu esqui tag de férias para a Suécia", "NORDJYSKE.DK", "Saiba mais", randomIconURL6, randomCoverURL6, null, null, ignoreValidate: true);
					return nativeInterstitialAdObject6;
				}
				count = 3;
				object obj14 = facebookNativeAdsSimulated + 296;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
				facebookNativeAdsSimulated.m_onNativeLoggingImpression = (Action<string>)0;
				int? val13 = (int?)(object)(facebookNativeAdsSimulated + 48);
				string randomIconURL7 = facebookNativeAdsSimulated.GetRandomIconURL(val13);
				object obj15 = facebookNativeAdsSimulated + 296;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
				facebookNativeAdsSimulated.m_onNativeAdError = (Action<string>)0;
				int? val14 = (int?)(object)(facebookNativeAdsSimulated + 40);
				string randomCoverURL7 = facebookNativeAdsSimulated.GetRandomCoverURL(val14);
				NativeInterstitialAdObject nativeInterstitialAdObject7 = default;
				nativeInterstitialAdObject7._002Ector("เล\u0e48นสก\u0e35ในป\u0e35 2017: ข\u0e36\u0e49นเล\u0e37อกสว\u0e35เดน", "Subtitle Text Test", "โฆษณา: ประหย\u0e31ดค\u0e48าใช\u0e49จ\u0e48ายในว\u0e31นหย\u0e38ดของค\u0e38ณในการเล\u0e48นสก\u0e35 - ไปท\u0e35\u0e48สว\u0e35เดน", "SocialContextTest", "เร\u0e35ยนร\u0e39\u0e49เพ\u0e34\u0e48มเต\u0e34ม", randomIconURL7, randomCoverURL7, null, null, ignoreValidate: true);
				return nativeInterstitialAdObject7;
			}
			count = 2;
			object obj16 = facebookNativeAdsSimulated + 296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
			facebookNativeAdsSimulated.m_onInitialize = (Action<string>)0;
			int? val15 = (int?)(object)(facebookNativeAdsSimulated + 32);
			string randomIconURL8 = facebookNativeAdsSimulated.GetRandomIconURL(val15);
			object obj17 = facebookNativeAdsSimulated + 296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
			facebookNativeAdsSimulated.tmpAd = (NativeInterstitialAdObject)0;
			int? val16 = (int?)(object)(facebookNativeAdsSimulated + 24);
			string randomCoverURL8 = facebookNativeAdsSimulated.GetRandomCoverURL(val16);
			NativeInterstitialAdObject nativeInterstitialAdObject8 = default;
			nativeInterstitialAdObject8._002Ector("التزلج في عام 2017: أكثر اختيار السويد", "Nordjyderne", "إعلانات: حفظ المال على عطلة التزلج الخاص بك - الذهاب إلى السويد", "NORDJYSKE.DK", "تعرف على المزيد", randomIconURL8, randomCoverURL8, null, null, ignoreValidate: true);
			return nativeInterstitialAdObject8;
		}
		count = 1;
		object obj18 = facebookNativeAdsSimulated + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
		facebookNativeAdsSimulated._fbNativeDownloader = (FBNativeDownloader)0;
		int? val17 = (int?)(object)(facebookNativeAdsSimulated + 16);
		string randomIconURL9 = facebookNativeAdsSimulated.GetRandomIconURL(val17);
		object obj19 = facebookNativeAdsSimulated + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Monetization.FacebookAds.Internal.FacebookNativeAdsSimulated)+128]");
		((UnityEngine.Object)facebookNativeAdsSimulated).m_CachedPtr = (IntPtr)0;
		int? val18 = (int?)(object)(facebookNativeAdsSimulated + 8);
		string randomCoverURL9 = facebookNativeAdsSimulated.GetRandomCoverURL(val18);
		NativeInterstitialAdObject nativeInterstitialAdObject9 = default;
		nativeInterstitialAdObject9._002Ector("Skiferie i 2017: Flere vælger Sverige", "Nordjyderne", "ANNONCE: Spar penge på skiferien -tag til Sverige", "NORDJYSKE.DK", "Learn More", randomIconURL9, randomCoverURL9, null, null, ignoreValidate: true);
		return nativeInterstitialAdObject9;
	}

	private NativeInterstitialAdObject GetFBTestAd()
	{
		//IL_004d: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I4
		while (count >= 3)
		{
			count = 0;
		}
		int num = count + 1;
		count = num;
		int num2 = count << 2;
		object obj = num2 + 2293540;
		object title = obj;
		object obj2 = num2 + 2293552;
		object subtitle = obj2;
		object obj3 = num2 + 2293564;
		object body = obj3;
		object obj4 = num2 + 2293576;
		object callToActionText = obj4;
		object obj5 = num2 + 2293588;
		object iconImageURL = obj5;
		object obj6 = num2 + 2293600;
		object coverImageURL = obj6;
		NativeInterstitialAdObject nativeInterstitialAdObject = default;
		nativeInterstitialAdObject._002Ector((string)title, (string)subtitle, (string)body, "FREE · Get it on Google Play", (string)callToActionText, (string)iconImageURL, (string)coverImageURL, null, null, ignoreValidate: true);
		return nativeInterstitialAdObject;
	}

	private NativeInterstitialAdObject GetTextTestAd()
	{
		//IL_004d: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		while (count >= 6)
		{
			count = 0;
		}
		int num = count + 1;
		count = num;
		int num2 = count << 2;
		object obj = num2 + 2293612;
		object title = obj;
		object obj2 = num2 + 2293636;
		object body = obj2;
		object obj3 = num2 + 2293660;
		object callToActionText = obj3;
		NativeInterstitialAdObject nativeInterstitialAdObject = default;
		nativeInterstitialAdObject._002Ector((string)title, "Subtitle Text Test", (string)body, "SocialContextTest", (string)callToActionText, "icon.html", "cover.html", null, null, ignoreValidate: true);
		return nativeInterstitialAdObject;
	}

	private unsafe string GetRandomIconURL(int? val = null)
	{
		//IL_0090: Invalid comparison between VT and I4
		//IL_00bd: Invalid comparison between VT and I4
		//IL_0021: Expected VT, but got I4
		//IL_0034: Expected Ref, but got VT
		//IL_007a: Expected Obj, but got I4
		if (val == (object)0)
		{
			int num = UnityEngine.Random.Range(0, 6);
			int? num2 = (int?)(object)1;
		}
		bool flag = val == (object)0;
		object result = "https://upload.wikimedia.org/wikipedia/en/b/b9/Subway_Surfers_app_logo.png";
		if (!flag)
		{
			int value = ((int?*)val)->Value;
			bool flag2 = value > 4;
			result = "https://upload.wikimedia.org/wikipedia/en/b/b9/Subway_Surfers_app_logo.png";
			if (!flag2)
			{
				int num3 = value << 2;
				object obj = num3 + 2293500;
				result = obj;
			}
		}
		return (string)result;
	}

	private unsafe string GetRandomCoverURL(int? val = null)
	{
		//IL_0090: Invalid comparison between VT and I4
		//IL_00bd: Invalid comparison between VT and I4
		//IL_0021: Expected VT, but got I4
		//IL_0034: Expected Ref, but got VT
		//IL_007a: Expected Obj, but got I4
		if (val == (object)0)
		{
			int num = UnityEngine.Random.Range(0, 6);
			int? num2 = (int?)(object)1;
		}
		bool flag = val == (object)0;
		object result = "http://www.nordicstartupbits.com/wp-content/uploads/2015/10/Subway-Surfers.jpg";
		if (!flag)
		{
			int value = ((int?*)val)->Value;
			bool flag2 = value > 4;
			result = "http://www.nordicstartupbits.com/wp-content/uploads/2015/10/Subway-Surfers.jpg";
			if (!flag2)
			{
				int num3 = value << 2;
				object obj = num3 + 2293520;
				result = obj;
			}
		}
		return (string)result;
	}

	public void AddTestDevice(string deviceID)
	{
	}

	public void SetDebugLogs(bool enableLogs)
	{
	}

	public static FacebookNativeAdsSimulated CreatePlugin()
	{
		GameObject gameObject = default;
		gameObject._002Ector("FacebookAdSimulatedReceiver");
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		return gameObject.AddComponent<FacebookNativeAdsSimulated>();
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "FacebookNativeAdsSimulated: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
