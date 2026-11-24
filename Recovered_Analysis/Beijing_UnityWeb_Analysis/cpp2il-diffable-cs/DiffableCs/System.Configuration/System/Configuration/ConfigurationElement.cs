namespace System.Configuration;

public abstract class ConfigurationElement
{

	protected internal virtual ConfigurationPropertyCollection Properties
	{
		 get { } //Length: 49
	}

	protected internal virtual ConfigurationPropertyCollection get_Properties() { }

	protected internal virtual bool IsModified() { }

	protected internal virtual void Reset(ConfigurationElement parentElement) { }

	protected internal virtual void ResetModified() { }

}

