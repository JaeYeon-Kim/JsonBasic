using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 1. 데이터 (코드 = 클래스)를 만들어야함. => 저장할 데이터 생성 
// 2. 그 데이터를 Json으로 변환. (택배상자로 포장)


// Json(택배)를 원래 코드로 바꾸는 작업이 필요함 

class Data
{
    public string nickname;
    public int level;

    public int coin;
    public bool skill;
    // 기타 등등.. 
}
public class Test : MonoBehaviour
{
    Data player = new Data() { nickname = "KJY", level = 50, coin = 300, skill = false};
    // Start is called before the first frame update
    void Start()
    {
       // 2. json으로 변환
       string jsonData = JsonUtility.ToJson(player);
       

       Data player2 = JsonUtility.FromJson<Data>(jsonData);
       print(player2.nickname);
       print(player2.level);
       print(player2.coin);
       print(player2.skill);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
