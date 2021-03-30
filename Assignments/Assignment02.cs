using System;
using System.Collections.Generic;
using DoitStudy.Interface;
using DoitStudy.Testcase;

namespace DoitStudy.Assignments
{
    public class Assignment02 : IAssignment
    {
        public object main(object data){
            string[] strArr = ((TestCase02.TestCase)data).strArr; // Ex:) strArr = {"123", "-123", "32"} 
            int res = 0; // Ex:) res = -91 위의 예제 기준 
            int result = 0;
            int min1 = 100000;
            int min2 = 100000;
            
            foreach (string value in strArr){
                if (int.TryParse(value, out result)){
                    if(result<min1){
                        min1=result;
                    }       
                }

            }
            foreach (string value in strArr){
                if (int.TryParse(value, out result)){
                    if(result != min1){
                        if(result<min2){
                            min2=result;
                        }
                    }
                }
            }
            if (min2 == 100000){
                min2 = min1;
            }
            res = min1 + min2;

            return res;
        }
    }
}