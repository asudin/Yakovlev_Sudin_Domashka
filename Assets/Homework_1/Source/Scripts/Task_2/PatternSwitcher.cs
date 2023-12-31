using TraderPattern;

public class PatternSwitcher
{
    private readonly Trader _npc;
    private readonly Player _player;

    public PatternSwitcher(Trader npc, Player player)
    {
        _npc = npc;
        _player = player;
        _player.RatingChanged += ChangeBehavioralPattern;
        ChangeBehavioralPattern(_player.Reputation.TotalReputation);
    }

    private void ChangeBehavioralPattern(int playerRating)
    {
        switch (playerRating)
        {
            case <=4:
                _npc.Initialize(new NothingSellingPattern());
                    break;
            case >=6:
                _npc.Initialize(new WeaponsSellingPattern());
                break;
            default:
                _npc.Initialize(new PotionsSellingPattern());
                break;

        }
    }
}
