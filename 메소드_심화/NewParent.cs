using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 메소드_심화
{
    internal class NewParent
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        // virtual : 지금 클래스가 자신의 클래스가 아니라면(자식이라면) 자식의 함수를 실행하라
        public virtual void Method2()
        {
            Console.WriteLine("Parent의 Method2");
        }

        //함수 사용 방법. return 있으면 반환 값에 해당하는 데이터 없으면 void
        // 2개 이상의 반환 값을 리턴 해주기 위한 문법 : ref, out

        // ref를 사용하기 위해서는 변수를 미리 선언을 해줘야 한다.
        int shareNumber = 0; // 몫 저장
        int remainderNumber = 0; // 나머지 저장

        // reference(참조). 매개 변수로 넘겨준 데이터를 참조해서 저장해두었다가 반환 2개 이상의 데이터를 반환할 수 있게 됨
        public void Divide(int first, int second, ref int shareNumber, ref int remainderNumber) // 몫, 나머지
        {
            //지역 변수 선언 : 고정된 값만 처리..
            // 매개 변수로 받아와서 : 함수의 결과가 외부에서 받아온 값에 따라 바꾸게 되는 설정
            first = 3;
            second = 2;

            shareNumber = first / second;  // 몫의 데이터가 shareNumber에 저장 -> ref 키워드로 보관
            remainderNumber = first % shareNumber); // 수 - 몫 뺀 값 = 나머지를 reminderNumber 저장 -> ref 보관

            // ref로 선언된 변수는 반드시 함수 내부에서 사용되어야 한다.
        }

        // out 키워드 ref 키워드 역할이 완벽하게 똑같ㅇ지만 다른점이 존재
        // 출력 전용 매개 변수(ref, out) 함수 내부에서 결과 값을 변환된 내용을 ㅇ리턴하는 목적
        // out 키워드로 선언한 변수를 바꾸지 않고 있다!
        // out 키워드로 선언한 변수는 반드시 내부에서 사용되기 때무에, 함수가 선언 될 때 변수를 초기화 할수 있다는 특징
        public void Divide2(int first, int sencond, out int shareNumber, out int remainderNumber) // 몫, 나머지
        {
            //지역 변수 선언 : 고정된 값만 처리..
            // 매개 변수로 받아와서 : 함수의 결과가 외부에서 받아온 값에 따라 바꾸게 되는 설정
            first = 3;
            sencond = 2;

            shareNumber = first / sencond;  // 몫의 데이터가 shareNumber에 저장 -> ref 키워드로 보관
            remainderNumber = first % shareNumber); // 수 - 몫 뺀 값 = 나머지를 reminderNumber 저장 -> ref 보관

            // ref로 선언된 변수는 반드시 함수 내부에서 사용되어야 한다.
        }
    }

    class Child : NewParent
    {
        // 내부적 base의 void Method1()을 포함하고 있기 때문에 구별해줘야함
        // 변수는 base, this 키워드로 구별을 해줌

        // new 키워드 : 클래스 선언의 new와는 다른 new이다.
        // 같은 이름의 키워드여도 문법의 쓰임에 따라 다르게 사용 될 수 있다.
        public new void Method1()
        {
            Console.WriteLine("Child의 Method1");
        }  // 부모의 method1 사용하고 싶었는데.. new .. chile 클래스만 접근 가능하게 선언

        // override : 부모의 함수 중에서 virtual 명시된 녀식이 있으면 이 키워드가 선언된 함수를 실행한다.
        // override 하고 나서, 부모에 같은 함수가 없으면 에러를 띄워줌
        public override void Method2()
        {
            Console.WriteLine("Child의 method2");
        }
    }
}
