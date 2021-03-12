using System;

namespace doit_study_homework_template
{
    public class HW02 : homework
    {
        /* Dont Touch */
        public bool isRunning { get;  set; }
        public HW02(bool _isRunning){
            isRunning = _isRunning;
        }
        /********************/
        public void main(){
            var name = "Bob";
            var messages = 3;
            var temperature = 34.4f;

            /* 여기에 코드를 작성하세요 */
            Console.Write("\"Hello, ");
            Console.Write(name);
            Console.Write("! You have ");
            Console.Write(messages);
            Console.Write(" in your inbox.  The temperature is ");
            Console.Write(temperature);
            Console.Write(" celsius.\"");
        }
    }
}