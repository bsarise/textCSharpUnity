using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;

namespace UnityApp
{
    internal class Goods  // 모든 Goods의 공통된 특징을 작성
    {
        public string name;
        public int price;
        public string description;
    }

    // Hierarachy 마우스 우클릭, 게임 오브젝트, Canvas <- (UI - Textmeshpro)
    // 미리 만들어 져있는 UI 오브젝트에 이름과 가격, 설명 텍스트를 부착할수 있게 만들어 보자
    class Fruit : Goods // 혼자서 클래스를 만들고 데이터 클래스 연결!
    {
        TextMeshProUGUI NameText;
        TextMeshProUGUI priceText;
        TextMeshProUGUI DescriptionText;
    }
}
