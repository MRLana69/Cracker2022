namespace System.Configuration;

public abstract class ConfigurationElementCollection : ConfigurationElement
{

	protected internal override bool IsModified() { }

	protected internal override void Reset(ConfigurationElement parentElement) { }

	protected internal override void ResetModified() { }

}

