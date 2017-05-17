using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject lufa;
    public GameObject aroundObject;
    public GameObject projectile;
    public GameObject spawner;

    public float bulletForce = 150f;
    public float bulletSpeed = 20f;

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 10.0f;
        

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject theBullet = Instantiate(projectile, spawner.transform.position, spawner.transform.rotation);
            theBullet.GetComponent<Rigidbody>().velocity = spawner.transform.forward * bulletSpeed;


        }
    }
}




