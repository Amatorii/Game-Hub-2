using UnityEngine;
using System.Collections;

public class SideScrollerCamera : MonoBehaviour {

    public Transform player;
    float targetX;
    float targetY;

    public float xMargin = 1f;
    public float yMargin = 1f;
    public float xSmooth = 8f;
    public float ySmooth = 8f;

    public Vector2 maxXAndY;
    public Vector2 minXAndY;

	// Use this for initialization
	void Start () {
        targetX = transform.position.x;
        targetY = transform.position.y;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (checkXMargin())
            targetX = Mathf.Lerp(transform.position.x, player.position.x, Time.deltaTime);
        if (checkYMargin())
            targetY = Mathf.Lerp(transform.position.y, player.position.y, Time.deltaTime);

        targetX = Mathf.Clamp(targetX, minXAndY.x, maxXAndY.x);
        targetY = Mathf.Clamp(targetY, minXAndY.y, maxXAndY.y);

        transform.position = new Vector3(targetX, targetY, transform.position.z);
	}

    private bool checkXMargin()
    {
        return Mathf.Abs(transform.position.x - player.position.x) > xMargin;
    }

    private bool checkYMargin()
    {
        return Mathf.Abs(transform.position.y - player.position.y) > yMargin;
    }
}
