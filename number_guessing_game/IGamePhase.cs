namespace GamePhase
{
  interface IGamePhase
  {
    void StartPhase();
    void GuessPhase();
    void GuessCheckPhase();
    void RestartPhase();
    void FinishPhase();
  }
}