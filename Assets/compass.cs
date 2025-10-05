using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class WorldCompassArrow : MonoBehaviour
{
    public Transform playerMapIcon;
    public Transform corpseTarget;
    void Start()
    {
        // Example: find an object tagged "QuestTarget"
        GameObject obj = GameObject.FindGameObjectWithTag("CorpseTarget1");
        if (obj != null)
            corpseTarget = obj.transform;
    }
    void Update()
    {

        // Direction from player to target
        Vector2 dir = corpseTarget.position - playerMapIcon.position;

        // Angle in degrees
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        // Rotate arrow
        transform.rotation = Quaternion.Euler(0f, 0f, angle - 90f);
    }
    public void SetTarget(Transform newTarget)
    {
        corpseTarget = newTarget;
    }
}