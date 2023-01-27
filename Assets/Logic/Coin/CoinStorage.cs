public class CoinStorage : Storage
{
    public int coins;

    private const string KEY = "coins";

    public override void Init()
    {
        this.coins = JSONSave.GetInt(KEY, 0);
    }

    public override void Save()
    {
        JSONSave.SetInt(KEY, this.coins);
    }

}
