using UnityEngine;

public class BulletMove : MonoBehaviour
{

    public float bulletSpeed = 20f;
    public float maxBulletDistance = 20f;

    GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player FINAL");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed);

        if (Vector3.Distance(transform.position, player.transform.position) > maxBulletDistance)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            player.GetComponent<PlayerStuff>().AddScore();

            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }
}
