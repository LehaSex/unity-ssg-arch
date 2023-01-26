public class FileBasedPrefsPC : IPlayerPrefs
{
    private bool isInitialized;

    public FileBasedPrefsPC()
    {
        if (!this.isInitialized)
		{
            FBPP.Start(new FBPPConfig
			{
				SaveFileName = "data.json",
				AutoSaveData = false,
				ScrambleSaveData = false,
				EncryptionSecret = "123",
			});
        }
    }

    public void DeleteAll()
	{
		FBPP.DeleteAll();
	}

	public void DeleteKey(string key)
	{
		FBPP.DeleteKey(key);
	}

	public float GetFloat(string key)
	{
		return FBPP.GetFloat(key, 0f);
	}

	public float GetFloat(string key, float defaultValue)
	{
		return FBPP.GetFloat(key, defaultValue);
	}

	public int GetInt(string key)
	{
		return FBPP.GetInt(key, 0);
	}

	public int GetInt(string key, int defaultValue)
	{
		return FBPP.GetInt(key, defaultValue);
	}

	public string GetString(string key)
	{
		return FBPP.GetString(key, "");
	}

	public string GetString(string key, string defaultValue)
	{
		return FBPP.GetString(key, defaultValue);
	}

	public bool HasKey(string key)
	{
		return FBPP.HasKey(key);
	}

	public void Save()
	{
		FBPP.Save();
	}

	public void SetFloat(string key, float value)
	{
		FBPP.SetFloat(key, value);
	}

	public void SetInt(string key, int value)
	{
		FBPP.SetInt(key, value);
	}

	public void SetString(string key, string value)
	{
		FBPP.SetString(key, value);
	}
}
