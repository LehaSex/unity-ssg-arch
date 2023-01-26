public class CoinService : Service
{
    private CoinStorage _coinStorage;

    public int coins => this._coinStorage.coins;
    public CoinService(CoinStorage coinStorage)
    {
        this._coinStorage = coinStorage;
    }

    public void AddCoins(object sender, int value)
    {
        this._coinStorage.coins += value;
        this._coinStorage.Save();
    }

    public void RemoveCoins(object sender, int value)
    {
        this._coinStorage.coins -= value;
        this._coinStorage.Save();
    }
    
}
