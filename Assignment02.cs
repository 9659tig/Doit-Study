using System;
using doit_study_homework_template.testcase;
using System.Collections.Generic;

namespace doit_study_homework_template
{
    public class Assignment02 : TestCase02, IAssignment
    {
        /* Dont Touch */
        public bool isRunning { get;  set; }
        public Assignment02(bool _isRunning){
            isRunning = _isRunning;
        }
        /********************/
        public void main(){
            var inputs = input();
            var results = new List<string>();

            foreach (TestCase data in inputs){
                var str = data.str;
                var res = String.Empty;

                res = str.ToUpper();

                results.Add(res);
            }

            output(results.ToArray());
        }
    }
}