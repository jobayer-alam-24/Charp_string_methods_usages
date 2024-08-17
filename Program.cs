namespace sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //vowels, consonants, digits, whitespace, special chars, words, sentence, reversed
            string text = "Hello, World! This is a test string. It contains numbers like 123, and special characters like @, #, and $.";
            FindAlls(text);
            
            
        }
        static void FindAlls(string txt){
            int vowelNumbers = txt.Count(text => "aeiouAEIOU".Contains(text));
            int consonantNumbers = txt.Count(txt => !"aeiouAEIOU".Contains(txt) && char.IsLetter(txt));
            int digits = txt.Count(chars => char.IsDigit(chars));
            int spaces = txt.Count(char.IsWhiteSpace);
            int specialChars = txt.Count(a => "@#$%".Contains(a));
            int numberOfWords = txt.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Length;
            int numberOfSentences = txt.Split(new char[]{'.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries).Length;
           
           Console.WriteLine($"=========String Methods==========");
           Console.WriteLine($"Vowels: {vowelNumbers}");
           Console.WriteLine($"Consonants: {consonantNumbers}");
           Console.WriteLine($"Digits: {digits}");
           Console.WriteLine($"Spaces: {spaces}");
           Console.WriteLine($"Special Characters: {specialChars}");
           Console.WriteLine($"Number Of words: {numberOfWords}");
           Console.WriteLine($"Number Of sentences: {numberOfSentences}");
           
        }
    }
}