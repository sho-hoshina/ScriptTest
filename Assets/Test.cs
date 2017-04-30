using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int mp = 53;
    private int power = 25;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic()
    {
        if (mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        else
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
    }
}


public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //課題：配列を宣言して出力しましょう
        int[] array = { 1, 2, 3, 4, 5 };
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう
        Boss boss = new Boss();
        for(int i = 0; i < 10; i++)
        {
            boss.Magic();
        }
        boss.Magic();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
