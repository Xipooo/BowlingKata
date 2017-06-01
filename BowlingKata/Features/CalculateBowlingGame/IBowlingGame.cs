namespace BowlingKata.Features.CalculateBowlingGame
{
    public interface IBowlingGame
    {
        void AddRoll(int pins);
        int GetTotalScore();
    }
}