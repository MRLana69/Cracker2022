namespace SYBO.Components.Utilities.AssetValidation;

public interface IAsset
{

	public AssetEvent OnValidated
	{
		 get { } //Length: 0
	}

	public AssetEvent get_OnValidated() { }

}

