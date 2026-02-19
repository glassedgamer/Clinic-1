using UnityEngine;

public class PlayerStuff : MonoBehaviour
{
    public GameObject bulllet;
    public Transform shootPoint;

    public void Update()
    {
        Shooting();
    }

    void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bulllet, shootPoint.position, shootPoint.rotation);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawSphere(shootPoint.position, 0.1f);
    }
}
