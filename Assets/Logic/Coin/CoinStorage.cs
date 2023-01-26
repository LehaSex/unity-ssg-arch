public class CoinStorage : Storage
{
    FileBasedPrefsPC fileBasedPrefsPC = new FileBasedPrefsPC();
    public int coins;

    private const string KEY = "coins";

    public override void Init()
    {
        this.coins = fileBasedPrefsPC.GetInt(KEY, 0);
    }

    public override void Save()
    {
        fileBasedPrefsPC.SetInt(KEY, this.coins);
        fileBasedPrefsPC.Save();
    }

}
