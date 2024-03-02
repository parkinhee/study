﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;



// NullConditionalOperator //

using System.Collections;

namespace NullConditionalOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            ArrayList a = null;
            a?.Add("야구"); // a?.가 null을 반환하므로 Add() 메소드는 호출되지 않음
            a?.Add("축구");
            // a?.가 null을 반환하므로 "Count :"외에는 아무것도 출력하지 않는다.
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

            a = new ArrayList(); // a는 이제 더 이상 null이 아니다.
            a?.Add("야구");  // 배열 a에 "야구" 추가
            a?.Add("축구");  // 배열 a에 "축구" 추가
            WriteLine($"Count : {a?.Count}");  // 배열 길이 count
            WriteLine($"{a?[0]}");  // 배열 a의 0번째 요소
            WriteLine($"{a?[1]}");  // 배열 a의 1번째 요소
        }
    }


}
