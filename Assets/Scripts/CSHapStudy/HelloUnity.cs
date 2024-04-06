using UnityEngine;
using TMPro;

public class HelloUnity : MonoBehaviour
{
    public TMPro.TextMeshPro text;

    int damage = 100;
    float time = 5.5f;
    string name = "이순신"; 

    private void Start() // 한번만 실행한다.
    {
        Debug.Log("데미지의 값 = " + damage);
        Debug.Log("시간의 값 = " + time);
        Debug.Log("이름의 값 = " + name);

        text.text = string.Format($"Only{damage} English{time} is visible : 정말이니?");
    }
}
