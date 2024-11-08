using UnityEngine;
public class Player
{
    public string playerName;
    public int health;
    public static int playerCount = 0;
    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;
    }
    public void Heal(int amount)
    {
        health += amount;
        Debug.Log("Health: " + health);
    }
    //overload the heal method to accept bool value 
    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100; // Assuming 100 is full health
            Debug.Log("Health: " + health);
        }
    }
    public static void ShowPlayerCount()
    {
        Debug.Log($"Total number of players: {playerCount}");
    }
}
