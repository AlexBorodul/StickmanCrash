using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting;

public class FallDamage : MonoBehaviour
{
    [SerializeField] private Car car;
    [SerializeField] private ScoreManager scoreManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        float damage_y = Car.rb.velocity.y;
        float damage_x = Car.rb.velocity.x;

        if (collision.gameObject.tag.Equals("Ground") && Car.rb.velocity.y < -10)
        {
            /*            Debug.Log("Damage");*/
            print("Damage from bottom");
            var dam = (-damage_y) * 2;
            scoreManager.addScore(dam);
            car.GetDamage(dam);
        }

        if (collision.gameObject.tag.Equals("Obstacle"))
        {
            /*            Debug.Log("Damage");*/
            print("Damage from obstacle");
            var dam = damage_x * 2;
            scoreManager.addScore(dam);
            if (damage_x >= 0)
            {
                car.GetDamage(dam);
            }
            
            else
            {
                car.GetDamage(-dam);
            }
        }
    }
}
