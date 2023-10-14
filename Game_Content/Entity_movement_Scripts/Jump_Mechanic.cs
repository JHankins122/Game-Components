[SerializeField] Vector3 playerJumpForce = new Vector3(0, 5, 0);
Rigidbody rb;

void Start()
{
	rb = GetComponent<Rigidbody>();
	Cursor.lockState = CursorLockMode.Locked;
}

void Update()
{
	JumpPlayer();
}

private void JumpPlayer()
    {
        //set the origin
        Vector3 origin = transform.position;
        //set direction
        Vector3 direction = -transform.up;
        //set the max distance
        float maxDistance = GetComponent<Collider>().bounds.size.y / 2 + 0.1f;
        //if all true or false
        bool hit = Physics.Raycast(origin, direction, maxDistance);
        //set the key needed to jump
        bool jump = Input.GetKeyDown(KeyCode.Space);
        //if hit is activated and the jump is pressed an impulse send the player up
        if (hit && jump)
        {
            rb.AddForce(playerJumpForce, ForceMode.Impulse);
        }
    }