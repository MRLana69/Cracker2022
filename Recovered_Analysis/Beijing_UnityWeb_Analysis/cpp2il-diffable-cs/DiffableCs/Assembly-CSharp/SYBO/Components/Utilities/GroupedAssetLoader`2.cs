namespace SYBO.Components.Utilities;

public abstract class GroupedAssetLoader`2
{
	public Action<string, List<T>> OnNeedPopupForAssetSelection; //Field offset: 0x0

	protected GroupedAssetLoader`2() { }

	protected abstract string GetGroup(T asset) { }

	public T GetGroupAsset(string groupName) { }

}

