using UnityEngine;

public class Colision : MonoBehaviour
{

    private float y, x;
    private Rigidbody rb;
    private int cont;

    void Start()
    {

        cont = 0;
        x = 10f;

        rb = GetComponent<Rigidbody>();

        Physics.gravity = new Vector3(0, -10f, 0);
        rb.velocity = new Vector3(0, -10f, 0);
        
    }

    void Update()
    {

        if (transform.position.y > y && x != 0f)
        {

            Physics.gravity = new Vector3(0, -9.8f, 0);

        }
        if (Input.GetButton("Fire1"))
        {
            
            Application.LoadLevel(Application.loadedLevel);
        }


    }

    void OnTriggerEnter(Collider other)
    {

        if (cont < 1)
        {
            float velocidad = 10;
            y = transform.position.y + x;
            Physics.gravity = new Vector3(0, 9.8f, 0);
            rb.velocity = new Vector3(0, velocidad, 0);
            x = x - 5f;
            cont++;
        }
        else
        {
            rb.useGravity = false;
        }

    }

}
