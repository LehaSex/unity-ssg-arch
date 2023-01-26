/// <summary>
/// Base Class.
/// This class is used to store the data of the game.
/// </summary>
public abstract class Storage 
{
    
    /// <summary>
    /// This method is used to initialize the storage and after that control is returned to the stream.
    /// </summary>
    public abstract void Init();
    /// <summary>
    /// This method is used to save the data of the storage.
    /// </summary>
    public abstract void Save();

}
