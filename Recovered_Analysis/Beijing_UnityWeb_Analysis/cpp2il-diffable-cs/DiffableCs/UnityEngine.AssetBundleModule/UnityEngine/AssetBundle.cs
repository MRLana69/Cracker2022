namespace UnityEngine;

public class AssetBundle : Object
{

	private AssetBundle() { }

	public T LoadAsset(string name) { }

	public Object LoadAsset(string name, Type type) { }

	private Object LoadAsset_Internal(string name, Type type) { }

	public AssetBundleRequest LoadAssetAsync(string name) { }

	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	public static AssetBundle LoadFromFile(string path) { }

	internal static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset) { }

	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset) { }

	public void Unload(bool unloadAllLoadedObjects) { }

}

