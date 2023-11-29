public class Reputation
{
    private const int RatingChangeValue = 1;

    private int _totalReputation;

    public int TotalReputation => _totalReputation;

    public Reputation(int totalReputation)
    {
        _totalReputation = totalReputation;
    }

    public void IncreaseRating()
    {
        if (_totalReputation < 0)
            return;

        _totalReputation += RatingChangeValue;
    }

    public void DecreaseRating()
    {
        if (_totalReputation < 0)
            return;

        _totalReputation -= RatingChangeValue;
    }
}
