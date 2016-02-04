using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private PlayerStats stats;
    private Rigidbody2D rb;
    private EdgeCollider2D col;
    [SerializeField] private bool facingRight; // true when facing right, false when facing left
    [SerializeField] private bool touchingGround;
    [SerializeField] SpriteRenderer sprite;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
        col = GetComponent<EdgeCollider2D>();
		stats = new PlayerStats();
        facingRight = true;
	}


    public void Move(bool direction) {

        if (direction != facingRight) // mudou de direcao
        {
            facingRight = direction; // atualiza direcao
            transform.Rotate(new Vector3(0f, 180f, 0f)); // inverte o game object (pode dar merda)
        }

        if ((transform.rotation.eulerAngles.z) < 105 && (transform.rotation.eulerAngles.z > 75))
        {
            return;
        }

        transform.position =  transform.position + transform.right * stats.speed * Time.fixedDeltaTime; // sem fisica
        //rb.AddForce (transform.right * stats.traction); // forca
        //rb.MovePosition(transform.position + transform.right * Time.fixedDeltaTime * stats.speed); // offset fisico
        
    }

    /*
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            touchingGround = true;
        }
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            touchingGround = false;
        }
            
    }
    */

}
