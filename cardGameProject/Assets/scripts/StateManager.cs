using UnityEngine;

public class StateManager : MonoBehaviour
{
    private Player player;
    private Boss boss;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = new Player(100); // Player starts with 100 max health
        boss = new Boss(200);    // Boss starts with 200 max health
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class Player
{
    public int MaxHealth { get; private set; }
    public int CurrentHealth { get; private set; }

    public Player(int maxHealth)
    {
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
    }
}

// Boss class
public class Boss
{
    public int MaxHealth { get; private set; }
    public int CurrentHealth { get; private set; }

    public Boss(int maxHealth)
    {
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
    }
}
}
