using UnityEngine;

public class BoidSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private int amount;

    private Boid[] boids;

    private void Start()
    {
        boids = new Boid[amount];
        for (int i = 0; i < amount; i++)
        {
            Vector3 position = new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), Camera.main.farClipPlane / 2);
            Vector3 screenPosition = Camera.main.ScreenToWorldPoint(position);
            boids[i] = Instantiate(prefab, screenPosition, Quaternion.identity).GetComponent<Boid>();
        }
    }

    private void Update()
    {
        // PROCEDURE move_all_boids_to_new_positions()

        // 	Vector v1, v2, v3
        // 	Boid b

        // 	FOR EACH BOID b
        // 		v1 = rule1(b)
        // 		v2 = rule2(b)
        // 		v3 = rule3(b)

        // 		b.velocity = b.velocity + v1 + v2 + v3
        // 		b.position = b.position + b.velocity
        // 	END

        // END PROCEDURE

        foreach (Boid boid in boids)
        {
            boid.velocity = boid.velocity + boid.RuleOne(boids) + boid.RuleTwo(boids) /*+ boid.RuleThree(boids)*/;
            boid.transform.position = boid.transform.position + boid.velocity;
        }
    }
}
