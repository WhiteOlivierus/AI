using UnityEngine;

public class Boid : MonoBehaviour
{
    public Vector3 velocity = Vector3.zero;

    public Vector3 RuleOne(Boid[] boids)
    {
        // PROCEDURE rule1(boid bJ)

        // 	Vector pcJ

        // 	FOR EACH BOID b
        // 		IF b != bJ THEN
        // 			pcJ = pcJ + b.position
        // 		END IF
        // 	END

        // 	pcJ = pcJ / N-1

        // 	RETURN (pcJ - bJ.position) / 100

        // END PROCEDURE

        Vector3 direction = Vector3.zero;

        foreach (Boid boid in boids)
        {
            if (boid == this) { continue; }

            direction = direction + transform.position;
        }

        direction = direction / (boids.Length - 1);

        return (direction - transform.position) / 100;
    }
    public Vector3 RuleTwo(Boid[] boids)
    {
        // PROCEDURE rule2(boid bJ)

        // 	Vector c = 0;

        // 	FOR EACH BOID b
        // 		IF b != bJ THEN
        // 			IF |b.position - bJ.position| < 100 THEN
        // 				c = c - (b.position - bJ.position)
        // 			END IF
        // 		END IF
        // 	END

        // 	RETURN c

        // END PROCEDURE

        Vector3 direction = Vector3.zero;

        foreach (Boid boid in boids)
        {
            if (boid == this) { continue; }

            float distance = Vector3.Distance(boid.transform.position, transform.position);

            if (distance > 100f) { continue; }

            direction = direction - (boid.transform.position - transform.position);
        }

        return direction;
    }
    public Vector3 RuleThree(Boid[] boids)
    {
        // 	PROCEDURE rule3(boid bJ)

        // 		Vector pvJ

        // 		FOR EACH BOID b
        // 			IF b != bJ THEN
        // 				pvJ = pvJ + b.velocity
        // 			END IF
        // 		END

        // 		pvJ = pvJ / N-1

        // 		RETURN (pvJ - bJ.velocity) / 8

        // 	END PROCEDURE

        Vector3 direction = default;



        return direction;
    }
}
