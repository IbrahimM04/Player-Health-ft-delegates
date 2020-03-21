using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeUIScript : MonoBehaviour
{
    public Text healthUI;
    public Button player;
    int health;
    public HealthScript _health;
    Color dead = Color.black;
    Color color;


    // Start is called before the first frame update
    void Start()
    {
        color = new Vector4(255, 255, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        health = _health.GetHealth();
        healthUI.text = "Health: " + health + "/100";

        if (health <= 0) {
            player.interactable = false;
            dead = Color.Lerp(Color.white, color, Mathf.PingPong(Time.deltaTime, 1));
        }
    }
}
