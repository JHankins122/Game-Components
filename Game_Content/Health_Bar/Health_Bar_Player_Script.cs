    public int maxHealth = 20;
    public int currentHealth;
    [SerializeField] HealthBar healthBar;
	
	void Start()
	{
		currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
	}
	
	void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }