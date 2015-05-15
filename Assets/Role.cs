using UnityEngine;
using System.Collections;

public class Role : MonoBehaviour 
{
    enum RoleDirection
    {
        DOWN,
        LEFT,
        UP,
        RIGHT,
    }

    public int RoleID = 1;
    public int GridW = 48;
    public int GridH = 48;
    public float Speed = 48;
    public Sprite[] roleImage;
    private SpriteRenderer sprite;

    private RoleDirection direction = RoleDirection.DOWN;
    public float moveFrame = 0;

	void Start () 
    {
        sprite = GetComponent<SpriteRenderer>();
        roleImage = Resources.LoadAll<Sprite>("Role/DQV/Role_" + RoleID);
        sprite.sprite = roleImage[0];

        //GetComponent<Animation>().
	}
	
	void Update () 
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction = RoleDirection.UP;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            direction = RoleDirection.DOWN;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = RoleDirection.LEFT;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = RoleDirection.RIGHT;
        }

        sprite.sprite = roleImage[(int)direction * 4 + (int)moveFrame];
	}
}
