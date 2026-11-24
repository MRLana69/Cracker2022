namespace System.Net.Configuration;

internal sealed class SettingsSectionInternal
{
	private static readonly SettingsSectionInternal instance; //Field offset: 0x0
	internal readonly bool HttpListenerUnescapeRequestUrl; //Field offset: 0x8
	internal readonly IPProtectionLevel IPProtectionLevel; //Field offset: 0xC

	internal bool Ipv6Enabled
	{
		 get { } //Length: 6
	}

	internal static SettingsSectionInternal Section
	{
		 get { } //Length: 433
	}

	private static SettingsSectionInternal() { }

	public SettingsSectionInternal() { }

	internal bool get_Ipv6Enabled() { }

	internal static SettingsSectionInternal get_Section() { }

}

