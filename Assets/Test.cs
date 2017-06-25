using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int hp = 100;          // 体力
    private int mp = 53; //MP
    private int power = 25; // 攻撃力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Magic()
    {
        
        if (this.mp <=4)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }else {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

}

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start() {
        
        //要素数が5のint型配列arrayを初期化
        int[] array = {10, 20, 30, 40, 50 };

        //順番に表示
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //逆順に表示
        for (int i = array.Length - 1; 0 <= i; i--)
        {
            Debug.Log(array[i]);
        }
        
        Boss boss = new Boss();
        for (int i = 1; i <= 15; i++)
        {
            boss.Magic();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
