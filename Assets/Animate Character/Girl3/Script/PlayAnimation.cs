using UnityEngine;
using System.Collections;

public class PlayAnimation : MonoBehaviour {

  
    public Animator Ani;
    public Sprite[] Spr;
    public SpriteRenderer sprR;
	public GameObject jerry;
	private float oldScale = 0.4f;
	private float i = 0.0f;
   
    public bool onlySpr = false;
	// Use this for initialization
	void Start () {
		//jerry.transform.localScale += new Vector3 (oldScale + i, oldScale + i, oldScale + i);
	}
	
	// Update is called once per frame
	void Update () {
		//jerry.transform.localScale += new Vector3 (oldScale + i, oldScale + i, oldScale + i);
	}

    public void PlayAni(string str)
    {
       
        Ani.enabled = true;
        Ani.ForceStateNormalizedTime(0.0f);
        Ani.Play(str);

    }




    public void ChangeSpr(int num)
    {
        if (onlySpr)
        {
            
        }
        else {
           
            Ani.ForceStateNormalizedTime(0.0f);
            Ani.enabled = false;           
        }

        sprR.sprite = Spr[num];
    }

  

}
