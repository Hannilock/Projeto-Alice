using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public Rigidbody2D rigidb;
    public int speed = 10;
    public int movx = 599;
    public float movy = 4.60f;
    public Vector3 playeractual;
    public GameObject userinterface;
    public GameObject ouractualobject; 

	void Start () {

        rigidb = GetComponent<Rigidbody2D>();
        
	}
	
	void FixedUpdate () {

        if (Input.GetKey("up")) {

            transform.position += transform.up * speed * Time.deltaTime;
            playeractual = ouractualobject.transform.position - userinterface.transform.position * -2;
            playeractual = playeractual.normalized;
            userinterface.transform.position = playeractual;

        }

        if(Input.GetKey("down")) {

            transform.position += transform.up * -1 * speed * Time.deltaTime;
            playeractual = transform.position;
        }

        if (Input.GetKey("right")) {

            transform.position += transform.right * speed * Time.deltaTime;
            playeractual = transform.position;
        }

        if (Input.GetKey("left")) {

            transform.position += transform.right * -1 * speed * Time.deltaTime;
            playeractual = transform.position;
        }

    }

}
