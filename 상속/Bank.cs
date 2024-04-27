﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 상속
{
    //상속의 기본 문법 Class 클래스명 : 상속하고자 하는 클래스 이름
    internal class Bank
    {
        // 접근 지정자를 통해서 외부에서 사용할 수 있는지 없는지 허락
        // private 나만 쓸꺼야, public 공용, protected 나 + 나를 상속한 녀석까지 허락
        protected string name;
        protected int money;
        // Bank 자식은 절대 스지 말고, Bank 내부에서만 쓸꺼야. -> private : 다른 클래스에서 변형이 되는 것을 원치 않음
        // public 모두 다 선언. -> private, protected 바꾸려는 노력.

        public void Withdraw()
        {

        }

        public void Deposit()
        {

        }

        public void show()
        {
            Console.WriteLine($"Bank의 이름 : {name} \nBank의 금액 : {money}");
        }

        public Bank(string name, int money)
        {
            this.name = name;
            this.money = money;
        }
        public Bank() { } // 기본생성자용


    }

    class CenterBank : Bank
    {
        // 공통적인 요소를 호출하게 끔
        public int centerMoney;
        public string name;

        public void MakeMoney() { }

        public void Show() 
        {
            base.name = "중앙 은행";
            this.money = 500000;
        }
        public CenterBank(string name, string parentNameint, int money, int centerMoney) : base(name, money) 
        {
            this.name = name;
            this.centerMoney = money;
        }

    }

    // 중앙 은행 : 화폐를 만들어 낼 수 있는 기능
    // 지역 은행 : 돈을 입금, 인출
}
