using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 10f;
    private bool insideSafeZone = true;
    public int health = 1000;
    private bool live = true;
    [SerializeField] GameObject GameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (live) 
        {
            transform.position += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            transform.position += transform.up * Input.GetAxis("Vertical") * speed * Time.deltaTime;
            if (!insideSafeZone)
            {
                health--;
            }
            if (health < 0)
            {
                Die();
            }
        }
        
        
    }
    private void Die()
    {
        live = false;
        Instantiate(GameOver, transform);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Inside");
        if (collision.gameObject.tag == "SafeZone")
        {
            insideSafeZone = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("outside");
        if (collision.gameObject.tag == "SafeZone")
        {
            insideSafeZone = false;
        }
    }
}
