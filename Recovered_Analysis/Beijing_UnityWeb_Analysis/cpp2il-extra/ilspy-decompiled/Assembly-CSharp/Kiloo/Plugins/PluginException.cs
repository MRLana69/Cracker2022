using System;

namespace Kiloo.Plugins;

public class PluginException : Exception
{
	public PluginException()
	{
	}

	public PluginException(string msg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		string helpURL = (string)(msg & 1);
		base._helpURL = helpURL;
	}
}
