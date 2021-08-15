using myShared.Models;
using myShared.Repositories;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace myWasm.Data
{
    public class methodes
    {
        public static Dictionary<string, List<Letter>> AnalizedSentence = new Dictionary<string, List<Letter>>();
        public static string GetletterImagePath(char c) => @"alphabet\" + c.ToString().ToUpper() + ".jpg";
        // public static List<Letter> raedDatebase()
        // {
        //     List<Letter> myDatas = new List<Letter>();
        //     using (var db = new LetterContext())
        //     {
        //         myDatas = db.Letters.ToList();
        //     }
        //     return myDatas;
        // }
    public static ((bool p1_On, bool p2_On, bool p3_On) p, (bool palm0_On, bool palm1_On, bool palm2_On, bool palm3_On, bool palm4_On, bool palm5_On, bool palm6_On, bool palm7_On) palm, (bool i1_On, bool i2_On, bool i3_On, bool i4_On, bool i5_On, bool i6_On) i, bool m, bool a, (bool x1_On, bool x2_On) x,bool off) CheckForOnSensors(char l)
        {
            var letter = (LetterRepository.letters.ToList().Find((m) => m.Symbol == l));
            ///p
            var p1_On = (letter.fingerorders & SensorRepository.Sensor.sensor_p1) == SensorRepository.Sensor.sensor_p1;
            var p2_On = (letter.fingerorders & SensorRepository.Sensor.sensor_p2) == SensorRepository.Sensor.sensor_p2;
            var p3_On = (letter.fingerorders & SensorRepository.Sensor.sensor_p3) == SensorRepository.Sensor.sensor_p3;
            ////palm
            var palm0_On = (letter.fingerorders & SensorRepository.Sensor.sensor_palm0) == SensorRepository.Sensor.sensor_palm0;
            var palm1_On = (letter.fingerorders & SensorRepository.Sensor.sensor_palm1) == SensorRepository.Sensor.sensor_palm1;
            var palm2_On = (letter.fingerorders & SensorRepository.Sensor.sensor_palm2) == SensorRepository.Sensor.sensor_palm2;
            var palm3_On = (letter.fingerorders & SensorRepository.Sensor.sensor_palm3) == SensorRepository.Sensor.sensor_palm3;
            var palm4_On = (letter.fingerorders & SensorRepository.Sensor.sensor_palm4) == SensorRepository.Sensor.sensor_palm4;
            var palm5_On = (letter.fingerorders & SensorRepository.Sensor.sensor_palm5) == SensorRepository.Sensor.sensor_palm5;
            var palm6_On = (letter.fingerorders & SensorRepository.Sensor.sensor_palm6) == SensorRepository.Sensor.sensor_palm6;
            var palm7_On = (letter.fingerorders & SensorRepository.Sensor.sensor_palm7) == SensorRepository.Sensor.sensor_palm7;
            ////i
            var i1_On = (letter.fingerorders & SensorRepository.Sensor.sensor_i1) == SensorRepository.Sensor.sensor_i1;
            var i2_On = (letter.fingerorders & SensorRepository.Sensor.sensor_i2) == SensorRepository.Sensor.sensor_i2;
            var i3_On = (letter.fingerorders & SensorRepository.Sensor.sensor_i3) == SensorRepository.Sensor.sensor_i3;
            var i4_On = (letter.fingerorders & SensorRepository.Sensor.sensor_i4) == SensorRepository.Sensor.sensor_i4;
            var i5_On = (letter.fingerorders & SensorRepository.Sensor.sensor_i5) == SensorRepository.Sensor.sensor_i5;
            var i6_On = (letter.fingerorders & SensorRepository.Sensor.sensor_i6) == SensorRepository.Sensor.sensor_i6;
            //m
            var m1_On = (letter.fingerorders & SensorRepository.Sensor.sensor_m1) == SensorRepository.Sensor.sensor_m1;
            //a
            var a1_On = (letter.fingerorders & SensorRepository.Sensor.sensor_a1) == SensorRepository.Sensor.sensor_a1;
            ///x
            var x1_On = (letter.fingerorders & SensorRepository.Sensor.sensor_x1) == SensorRepository.Sensor.sensor_x1;
            var x2_On = (letter.fingerorders & SensorRepository.Sensor.sensor_x2) == SensorRepository.Sensor.sensor_x2;
            var all_of= (letter.fingerorders & SensorRepository.Sensor.sensor_Off) == SensorRepository.Sensor.sensor_Off;

            return (p: (p1_On, p2_On, p3_On), palm: (palm0_On, palm1_On, palm2_On, palm3_On, palm4_On, palm5_On, palm6_On, palm7_On), i: (i1_On, i2_On, i3_On, i4_On, i5_On, i6_On), m: (m1_On), a: (a1_On), x: (x1_On, x2_On),off:all_of);
        }
        // public static string NextWord(string current, string input = "")
        // {
        //     var toks = input.ToLower().Split().Where((m) => !string.IsNullOrWhiteSpace(m)).ToList();
        //     var index = toks.FindIndex((m) => m == current);
        //     if (index != toks.Count - 1)
        //         return toks[index + 1];
        //     else
        //         return toks[0];
        // }
        public static void NextWord( List<string> sentence,ref int index)
        {
           if (index !=sentence.Count-1){
               index++;
           }
           else index=0;
        }
         public static void PreviousWord( List<string> sentence,ref int index)
        {
           if (index !=0){
               index--;
           }
           else index=sentence.Count-1;
        }
        // public static string PreviousWord(string current, string input = "")
        // {
        //     var toks = input.ToLower().Split().Where((m) => !string.IsNullOrWhiteSpace(m)).ToList();
        //     var index = toks.FindIndex((m) => m == current);
        //     if (index != 0)
        //         return toks[index - 1];
        //     else
        //         return toks[toks.Count - 1];
        // }

        public static void PreviousLetter(List<char> word,ref int index){
            if (index !=0){
               index--;
           }
           else index=word.Count-1;
        }


         public static void NextLetter(List<char> word,ref int index){
            if (index !=word.Count-1){
               index++;
           }
           else index=0;
        }
        // public static (string st, char ch) PreviousLetter(char c, string current = "")
        // {
        //     var index = current.ToLower().ToList().FindIndex((m) => m == c);
        //     char character;
        //     if (index == 0)
        //         character = current.ToList()[current.ToList().Count - 1];
        //     else
        //         character = current.ToList()[index - 1];
        //     return (GetletterImagePath(character), character);
        // }

        // public static (string st, char ch) NextLetter(char c, string current = "")
        // {
        //     var index = current.ToLower().ToList().FindIndex((m) => m == c);
        //     char character;
        //     if (index == current.ToList().Count - 1)
        //         character = current.ToList()[0];
        //     else
        //         character = current.ToList()[index + 1];

        //     return (GetletterImagePath(character), character);
        // }

        // public static void searchfunc(string input)
        // {
        //     var toks = input.ToLower().Split().ToList();
        //     foreach (var word in toks)
        //     {
        //         AnalizedSentence.Add(word, ToLetterFunc(word));
        //     }

        // }

        // private static List<Letter> ToLetterFunc(string word)
        // {
        //     var database = raedDatebase();
        //     List<Letter> result = new List<Letter>();
        //     foreach (var l in word)
        //     {
        //         result.Add(database.Where((m) => m.Symbol == l).First());
        //     }
        //     return result;
        // }
    }

}