using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace c13cs
{
     class Chornometer: IStopwatch, IDisposable, IEnumerable<string>
    {
        private string Name;
        private Stopwatch s;
        private List<TimeSpan> marks=new List<TimeSpan>();
        public Chornometer(string name)
        {
            this.Name = name;
            s = new Stopwatch();
        }

        public void Dispose()
        {
           s.Stop();
            Console.WriteLine($"Elapsed Time({this.Name}): {s.Elapsed.ToString()}");
        }

        public IEnumerator<string> GetEnumerator()
        {return null;   
        }

        public IEnumerable<string> GetMarks()
        {List<string> tmp=new List<string>();
            foreach(var m in marks){
                tmp.Add(tmp.ToString());
            }
            return tmp;
        }
            
        

        public void Mark(string name)
        {
            marks.Add(s.Elapsed);
            s.Restart();
            
        }

        public void Start()
        {
            s.Start();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}