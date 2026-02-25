using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStuff : MonoBehaviour
{
    public GameObject bulllet;
    public Transform shootPoint;

    public Text healthText;
    public Text scoreText;

    public int maxHealth = 100;
    public int health = 100;

    public int score = 0;  

    private void Start()
    {
        health = maxHealth;
        healthText.text = health.ToString() + " HP";

        score = 0;
        scoreText.text = score.ToString() + " Enemies Killed";
    }

    public void Update()
    {
        Shooting();

        if(health <= 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
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

    public void TakeAwayHealth()
    {
        health -= 5;
        healthText.text = health.ToString() + " HP";
    }

    public void AddScore() 
    { 
        score += 1;

        scoreText.text = score.ToString() + " Enemies Killed";
    }
}
