using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    Rigidbody rb;
    public GameObject winText;
    float xInput;
    float zInput;

    public float speed;
    
    void Start() // Start is called before the first frame update
    {
        rb = GetComponent<Rigidbody>();
    } 

    
    void Update() // Update is called once per frame
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 500);
        }

       // rb.angularVelocity = Vector3.forward * 20f;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Level2");
        }

        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        rb.AddForce(xInput * speed, 0, zInput * speed);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            // Destroy(gameObject);
            Destroy(collision.gameObject);

            winText.SetActive(true);
        }
    }

}
