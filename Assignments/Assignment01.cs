using System;
using System.Collections.Generic;
using DoitStudy.Interface;
using DoitStudy.Testcase;
using Assignment01Class;

namespace DoitStudy.Assignments
{
   
    public class Assignment01 : IAssignment
    {
        public object main(object data){
            string inputData = ((TestCase01.TestCase)data).inputData; // inputData
            //res에 값을 저장시켜주세요.
            Toy[] res = {}; // 파싱하고 값을 바르게 넣기
            List<string> sample = new List<string> ();
            string[] test = inputData.Split('\n',' ');
            for (int i = 0; i<test.Length; i+=3){
                res = new Toy(test[i], Convert.ToInt32(test[i+1]), Convert.ToInt32(test[i+2]));
                sample.Add($"name = {Toy.name}")
            }
            
            //return 값은 Toy Class의 Array 형식으로 Toy[] 입니다.
            return res;
        }
    }
}