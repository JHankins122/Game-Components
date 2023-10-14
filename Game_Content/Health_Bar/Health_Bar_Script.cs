    [SerializeField] Slider slider;
    [SerializeField] GameObject sceneChanger;

    private void Update()
    {
        NoHealth();
    }
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void SetHealth (int health)
    {
        slider.value = health;
    }

    public void NoHealth()
    {
        if (slider.value == 0)
        {
            sceneChanger.SendMessage("Failed");
        }
    }