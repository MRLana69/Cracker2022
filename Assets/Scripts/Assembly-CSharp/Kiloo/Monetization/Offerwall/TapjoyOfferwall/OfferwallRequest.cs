using System;
using Cpp2ILInjected;

namespace Kiloo.Monetization.Offerwall.TapjoyOfferwall;

public class OfferwallRequest
{
	public enum DeviceType
	{
		iphone,
		itouch,
		ipad,
		android,
		windows
	}

	private const string LIBRARY_VERSION = "server";

	private const string SDK_TYPE = "offers";

	private const string REQUEST_PREFIX = "https://ws.tapjoyads.com/get_offers?";

	public string appID
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public string udid
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public string advertisingID
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public string libraryVersion
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public string deviceIP
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public string timestamp
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public string verifier
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public string deviceType
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public string sdkType
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public string appVersion
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public string publisherUserID
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public string osVersion
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public int max
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public OfferwallRequest(string appID, string udid, string advertisingID, string deviceIP, string timestamp, string verifier, string appVersion, string publisherUserID, string osVersion, int max)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		this.appID__BackingField = appID;
		this.udid__BackingField = udid;
		this.advertisingID__BackingField = advertisingID;
		this.deviceIP__BackingField = deviceIP;
		this.timestamp__BackingField = timestamp;
		this.verifier__BackingField = verifier;
		this.appVersion__BackingField = appVersion;
		this.publisherUserID__BackingField = publisherUserID;
		this.osVersion__BackingField = osVersion;
		this.max__BackingField = max;
		libraryVersion__BackingField = "server";
		sdkType__BackingField = "offers";
		_ = 3;
		_ = -1;
		obj = (Enum)(object)typeof(DeviceType);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
		_ = 0;
		string text = obj.ToString();
		deviceType__BackingField = text;
	}

	public string FormatToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
