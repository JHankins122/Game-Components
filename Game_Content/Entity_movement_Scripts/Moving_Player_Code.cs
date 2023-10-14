    [SerializeField] float playerMoveSpeed = 5;
	 Rigidbody rb;
	 
	int playerSprint = 5;
    float speedTemp;
	
	void start()
	{
		rb = GetComponent<Rigidbody>();
        speedTemp = playerMoveSpeed;
	}
	
	void Update()
	{
		MovePlayer();
	}
	
	//moving the player
    void MovePlayer()
    {
        //if left shift is pressed 
        if (Input.GetKey(KeyCode.LeftShift))
        {
            //set sprint
            speedTemp = playerMoveSpeed + playerSprint;
        }
        else
        {
            //set the normal speed
            speedTemp = playerMoveSpeed;
        }
        //setting the axis for moving on
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        //the a v3 as a new v3 with the axis
        Vector3 move = new Vector3(x, 0, z).normalized;
        //making move happen with the speed and time 
        move *= speedTemp * Time.deltaTime;
        //start transform translate
        transform.Translate(move);

    }