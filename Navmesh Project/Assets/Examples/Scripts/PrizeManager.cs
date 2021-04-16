using UnityEngine;

public class PrizeManager : MonoBehaviour
{
    public Vector3 prizeMotion = new Vector3(0f, 0.001f, 0f);

    void Update()
    {
        if (this.transform.position.y > 1.25f)
        {
            prizeMotion = -prizeMotion;
        }
        if (this.transform.position.y < 0.75)
        {
            prizeMotion = -prizeMotion;
        }
        this.transform.position += prizeMotion;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameManager.score += 10;
            Destroy(gameObject);
        }
    }
}
