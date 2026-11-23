using AdHandling.AdConstants.Internal;
using Cpp2ILInjected;
using Info;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;

namespace AdHandling.AdConstants;

public class AdConstants : IAdConstants
{
	private IAdConstants _constants;

	private static AdConstants _instance;

	public static AdConstants instance
	{
		get
		{
			if (_instance == null)
			{
				AdConstants adConstants = default;
				adConstants._002Ector();
				_instance = adConstants;
			}
			return _instance;
		}
	}

	public static string FlurryApiKey
	{
		get
		{
			//IL_01a4: Expected Obj, but got I4
			RuntimePlatform platform = Application.platform;
			object obj = platform - 8;
			if (platform != RuntimePlatform.IPhonePlayer)
			{
				if ((nint)obj != 1 && (nint)obj != 2)
				{
					if ((nint)obj == 3)
					{
						if (DeviceUtility.isKindleDevice)
						{
							if (!Globals.DEBUG_USE_TEST_AD_CONSTANTS)
							{
								bool isRestricted = AgeRestriction.isRestricted;
							}
						}
						else if (DeviceUtility.isFlexionDevice)
						{
							if (~(Globals.DEBUG_USE_TEST_AD_CONSTANTS ? 1u : 0u) != 0)
							{
								bool isRestricted2 = AgeRestriction.isRestricted;
							}
						}
						else if (!Globals.DEBUG_USE_TEST_AD_CONSTANTS)
						{
							bool isRestricted3 = AgeRestriction.isRestricted;
						}
					}
					else if (platform == RuntimePlatform.MetroPlayerARM && ~(Globals.DEBUG_USE_TEST_AD_CONSTANTS ? 1u : 0u) != 0)
					{
						bool isRestricted4 = AgeRestriction.isRestricted;
					}
				}
			}
			else if (!Globals.DEBUG_USE_TEST_AD_CONSTANTS)
			{
				bool isRestricted5 = AgeRestriction.isRestricted;
			}
			return string.Empty;
		}
	}

	public string FlurryAdSpace
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string result = default;
			return result;
		}
	}

	public string AdColonyAppId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string result = default;
			return result;
		}
	}

	public string AdColonyZoneId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string result = default;
			return result;
		}
	}

	public string TapJoyAppId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string result = default;
			return result;
		}
	}

	public string TapJoyAppKey
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string result = default;
			return result;
		}
	}

	public string TapJoyEventName
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string result = default;
			return result;
		}
	}

	public string ChartboostAppId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string result = default;
			return result;
		}
	}

	public string ChartboostAppSignature
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string result = default;
			return result;
		}
	}

	public string InmobiAccountId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string result = default;
			return result;
		}
	}

	public string InmobiAppIdInterstitial
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string result = default;
			return result;
		}
	}

	public string InmobiAppIdRewardedVideo
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string result = default;
			return result;
		}
	}

	public string VungleAppId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string result = default;
			return result;
		}
	}

	public string MdotmAppId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string result = default;
			return result;
		}
	}

	public string SupersonicAppId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string result = default;
			return result;
		}
	}

	public string FacebookVidoePlacementId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string result = default;
			return result;
		}
	}

	public string FacebookNative
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string result = default;
			return result;
		}
	}

	private AdConstants()
	{
		SetPlatformDependentConstants();
	}

	private void SetPlatformDependentConstants()
	{
		//IL_0309: Expected Obj, but got I4
		RuntimePlatform platform = Application.platform;
		object obj = platform - 8;
		if (platform != RuntimePlatform.IPhonePlayer)
		{
			if ((nint)obj != 1 && (nint)obj != 2)
			{
				if ((nint)obj == 3)
				{
					if (DeviceUtility.isKindleDevice)
					{
						if (~(Globals.DEBUG_USE_TEST_AD_CONSTANTS ? 1u : 0u) == 0)
						{
							IAdConstants constants = default;
							_constants = constants;
						}
						else if (AgeRestriction.isRestricted)
						{
							IAdConstants constants2 = default;
							_constants = constants2;
						}
						else
						{
							IAdConstants constants3 = default;
							_constants = constants3;
						}
					}
					else if (DeviceUtility.isFlexionDevice)
					{
						if (~(Globals.DEBUG_USE_TEST_AD_CONSTANTS ? 1u : 0u) == 0)
						{
							IAdConstants constants4 = default;
							_constants = constants4;
						}
						else if (AgeRestriction.isRestricted)
						{
							IAdConstants constants5 = default;
							_constants = constants5;
						}
						else
						{
							IAdConstants constants6 = default;
							_constants = constants6;
						}
					}
					else if (~(Globals.DEBUG_USE_TEST_AD_CONSTANTS ? 1u : 0u) == 0)
					{
						IAdConstants constants7 = default;
						_constants = constants7;
					}
					else if (AgeRestriction.isRestricted)
					{
						IAdConstants constants8 = default;
						_constants = constants8;
					}
					else
					{
						IAdConstants constants9 = default;
						_constants = constants9;
					}
					return;
				}
				if (platform == RuntimePlatform.MetroPlayerARM)
				{
					if (~(Globals.DEBUG_USE_TEST_AD_CONSTANTS ? 1u : 0u) == 0)
					{
						IAdConstants constants10 = default;
						_constants = constants10;
					}
					else if (AgeRestriction.isRestricted)
					{
						IAdConstants constants11 = default;
						_constants = constants11;
					}
					else
					{
						IAdConstants constants12 = default;
						_constants = constants12;
					}
					return;
				}
			}
			IAdConstants constants13 = default;
			_constants = constants13;
		}
		else if (~(Globals.DEBUG_USE_TEST_AD_CONSTANTS ? 1u : 0u) == 0)
		{
			IAdConstants constants14 = default;
			_constants = constants14;
		}
		else if (AgeRestriction.isRestricted)
		{
			IAdConstants constants15 = default;
			_constants = constants15;
		}
		else
		{
			IAdConstants constants16 = default;
			_constants = constants16;
		}
	}
}
