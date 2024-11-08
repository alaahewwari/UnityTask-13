using UnityEngine;
public class GameManager : MonoBehaviour
{
    Player player1 = new Player();
    Player player2 = new Player();
    void Start()
    {
        player1.InitializePlayer("Alaa", 70);
        player2.InitializePlayer("Maria", 50);
        player1.Heal(30);
        player2.Heal(true);
        Player.ShowPlayerCount();
    }
}