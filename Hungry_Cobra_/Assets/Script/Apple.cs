using UnityEngine;

public class Apple : MonoBehaviour
{
    public BoxCollider2D gridArea;

    private void Start()
    {
        RandomizePosition();
    }

    private void RandomizePosition()
    {
        // Get the bounds of the grid area
        Bounds bounds = gridArea.bounds;

        // Generate random X and Y positions within the bounds
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        // Set the position of the food object (rounded to whole units)
        transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
          RandomizePosition();
        }
        

    }
}
