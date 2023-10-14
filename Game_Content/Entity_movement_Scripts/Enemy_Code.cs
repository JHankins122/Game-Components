    [SerializeField] GameObject player;
    private NavMeshAgent enemy;

 

    private float enemyDistanceAttack = 7.0f;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        chasePlayer();
    }

    private void OnCollisionEnter(Collision collisionW)
    {
        if (collisionW.collider.gameObject.CompareTag("Weapon"))
        {
            print("WeaponTrue");
            DestroyObject();
        }
    }
    void DestroyObject()
    {
        Destroy(gameObject);
    }

    void chasePlayer()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance < enemyDistanceAttack)
        {
            Vector3 dirPlayer = transform.position - player.transform.position;
            Vector3 newPos = transform.position - dirPlayer;
            enemy.SetDestination(newPos);
        }
    }