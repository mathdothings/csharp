namespace GameMessage
{
  interface IGameMessage
  {
    void ShowStartingMessage();

    void ShowPlayerGuesssingNumber();

    void ShowIncorrectGuessedNumber();

    void ShowNumber();

    void ShowGuessedNumber();

    void ShowGuessMessage();

    void ShowGuessResult();
  }
}