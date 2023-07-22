using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public Transform camera_position;
    public Transform player_position;

    private void Start()
    {
        StartCoroutine(s_enemy());
    }

    IEnumerator s_enemy()
    {
        while(true)
        {
            var random = new System.Random();
            int ran_x = random.Next(7, 12);
            int ran_y = random.Next(2, 4);
            Vector3 new_pos;
            new_pos.x = camera_position.position.x + ran_x;
            new_pos.y = camera_position.position.y + ran_y;
            new_pos.z = player_position.position.z - 2.14f;
            Instantiate(enemy, new_pos, Quaternion.identity);
            yield return new WaitForSeconds(3);
        }
    }
}
