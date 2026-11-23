using System.Runtime.InteropServices;

public class DomainLocker
{
	[PreserveSig]
	public static extern bool RedirectDomain(string check_domains_str, string redirect_domain);
}
