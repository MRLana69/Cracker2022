namespace Kiloo.Common.Utility;

public interface IFileSaver
{

	public T Load(string file) { }

	public void Save(string file, object obj) { }

	public bool TryLoad(string file, out T obj) { }

}

