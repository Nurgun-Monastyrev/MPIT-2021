using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private Animator animator;

    private void Start()
    {
        animator.gameObject.GetComponent<Animator>();
    }

    private void MovementX(float dir)
    {
        transform.position = new Vector2(transform.position.x + speed * dir * Time.deltaTime, transform.position.y);
    }

    private void MovementY(float dir)
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + speed * dir * Time.deltaTime);
    }

    private void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            MovementX(Input.GetAxisRaw("Horizontal"));
            if (Input.GetAxisRaw("Horizontal") > 0)
                animator.SetInteger("Dir", 2);
            else
                animator.SetInteger("Dir", 4);
        }

        if (Input.GetAxisRaw("Vertical") != 0)
        {
            MovementY(Input.GetAxisRaw("Vertical"));
            if (Input.GetAxisRaw("Vertical") > 0)
                animator.SetInteger("Dir", 1);
            else
                animator.SetInteger("Dir", 3);
        }

        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
            animator.SetInteger("Dir", 0);
    }

    public void isDetected()
    {
        Destroy(gameObject);
        // ....................
    }
}
