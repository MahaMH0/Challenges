

namespace Challenge_One
{
    internal class Program
    {
        static string reverseString(string Input_Sentence)
        {
            List<string> Words = new List<string>();
            List<string> Reversed_Words= new List<string>();
            string Single_Word="";
   
            for(int i=0; i<Input_Sentence.Length; i++)
            {
                if (Input_Sentence[i] != ' ')
                {
                    Single_Word+=Input_Sentence[i];
                }
                else
                {
                    Words.Add(Single_Word);
                    Single_Word = "";
                }
            }
            Words.Add(Single_Word);
            for (int i = Words.Count-1; i >= 0; i--)
            {
                 Reversed_Words.Add(Words[i]);
            }
            return string.Join(" ", Reversed_Words); ;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(reverseString("I am interested to work here"));
        }
    }
}
