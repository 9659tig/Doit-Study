using System;
using doit_study_homework_template.testcase;
using System.Collections.Generic;

namespace doit_study_homework_template
{
    public class Assignment03 : TestCase03, IAssignment
    {
        /* Dont Touch */
        public bool isRunning { get;  set; }
        public Assignment03(bool _isRunning){
            isRunning = _isRunning;
        }
        /********************/
         public void main(){
            var inputs = input();
            var results = new List<int>();

            foreach (TestCase data in inputs){
                var numArr = data.numArr;
                var res = -1000000000;

                foreach(var number in numArr){
                    if (number>=res){
                        res = number;
                    }
                }

               
                results.Add(res);
            }

            output(results.ToArray());
        }
    }
}