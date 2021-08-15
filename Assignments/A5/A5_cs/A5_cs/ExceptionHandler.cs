using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5
{
    public class ExceptionHandler
    {
        public string ErrorMsg { get; set; }
        public readonly bool DoNotThrow;
        private string _Input;

        public string Input
        {
            get
            {
                try
                {
                    if (_Input == null)
                    {
                        int[] arr = null;
                        // try{
                        for (int i = 0; i < 2; i++)
                            arr[i] = i;
                    }
                }
                /*   catch(NullReferenceException e){throw;}
                   }

               }
                   catch (InvalidDataException e ){
                       throw;
                   }*/


                catch
                {
                    if (!DoNotThrow)
                        throw;
                    ErrorMsg = "Caught exception in GetMethod";
                }
                return _Input;

            }
            set
            {
                this._Input = value;
                try
                {
                    if (value == null)
                    {
                        throw new NullReferenceException();
                    }
                }
                catch
                {
                    if (!DoNotThrow)
                        throw;
                    ErrorMsg = "Caught exception in SetMethod";
                }
            }
        }



        public ExceptionHandler(
            string input,
            bool causeExceptionInConstructor,
            bool doNotThrow = false)
        {
            DoNotThrow = doNotThrow;
            this._Input = input;
            try
            {
                if (causeExceptionInConstructor == true)
                {
                    int[] values = null;
                    try
                    {

                        for (int ctr = 0; ctr <= 9; ctr++)
                            values[ctr] = ctr * 2;

                    }
                    catch { throw; }
                }


            }
            catch
            {
                if (DoNotThrow == false)
                    throw;
                else
                    ErrorMsg = "Caught exception in constructor";
            }
        }


        public void OverflowExceptionMethod()
        {
            try
            {
                checked
                {
                    int n = int.Parse(_Input);
                    n++;
                }
            }
            catch (OverflowException e)
            {
                if (!DoNotThrow)
                    throw;
                ErrorMsg = $"Caught exception {e.GetType()}";
            }
        }

        public static void ThrowIfOdd(int n)
        {
            if (n % 2 == 1)
            {
                throw new InvalidDataException();
            }
        }
        public void FormatExceptionMethod()
        {

            try { int.Parse(this._Input); }
            catch
            {
                if (DoNotThrow == false)
                {
                    throw;
                }
                else
                {
                    this.ErrorMsg = "Caught exception " + typeof(FormatException);
                }
            }


        }

        public void FileNotFoundExceptionMethod()
        {
            string path = @"C:\git\AP98992\Assignments\A5\A5_cs\A5_cs\obj\Debug\netcoreapp3.0\" + _Input + ".txt";
            try
            {
                var file_handle = File.ReadAllLines(path);
            }
            catch
            {
                if (DoNotThrow == false)
                {
                    throw;
                }
                else
                {
                    this.ErrorMsg = "Caught exception " + typeof(FileNotFoundException);
                }
            }
        }

        public void IndexOutOfRangeExceptionMethod()
        {
            int[] a = { 0 };

            try
            {
                int b = a[int.Parse(this._Input)];
            }
            catch (IndexOutOfRangeException e)
            {
                if (DoNotThrow == false)
                {
                    throw;
                }
                else
                {
                    this.ErrorMsg = "Caught exception " + e.GetType();
                }


            }

        }

        public string FinallyBlockStringOut;

        public void FinallyBlockMethod(string s)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter swr = new StringWriter(sb);
            try
            {
                swr.Write("InTryBlock:");
                FinallyBlockStringOut = sb.ToString();
                if (s == "beautiful")
                {
                    swr.Write(s + ":" + s.Length + ":DoneWriting");
                    FinallyBlockStringOut = sb.ToString();
                }
                else if (s == "ugly")
                {
                    return;
                }

                else if (s == null)
                {
                    if (DoNotThrow == true)
                    {
                        swr.Write(":Object reference not set to an instance of an object.");
                        FinallyBlockStringOut = sb.ToString();
                    }
                    else if (DoNotThrow == false)
                    {
                        swr.Write(":Object reference not set to an instance of an object.");
                        FinallyBlockStringOut = sb.ToString();
                        throw new NullReferenceException();
                    }

                }



            }
            catch (NullReferenceException nre)
            {
                if (DoNotThrow == false)
                {
                    throw;
                }

            }
            finally
            {  // try{
                swr.Write(":InFinallyBlock");
                FinallyBlockStringOut = sb.ToString();
                // if(DoNotThrow==false)


            }
            swr.Write(":EndOfMethod");
            FinallyBlockStringOut = sb.ToString();
        }

        public void OutOfMemoryExceptionMethod()
        {

            try
            {
                int[] a = new int[int.Parse(_Input)];
            }
            catch
            {
                if (DoNotThrow == false)
                {
                    throw;
                }
                else
                {
                    this.ErrorMsg = "Caught exception " + typeof(OutOfMemoryException);
                }
            }
        }


        public void NestedMethods()
        {
            MethodA();

        }

        private void MethodA()
        {
            MethodB();
        }

        private void MethodB()
        {
            MethodC();
        }

        private void MethodC()
        {
            MethodD();
        }

        private void MethodD()
        {
            throw new NotImplementedException();
        }

        public void MultiExceptionMethod()
        {
            int n = int.Parse(this._Input);
            if (n != 0)
            {
                try
                {

                    string value = new string('a', n);
                    int idx = value[value.Length + 1];


                }
                catch (IndexOutOfRangeException e)
                {
                    if (DoNotThrow == false)
                    {
                        throw;
                    }
                    else
                    {
                        this.ErrorMsg = "Caught exception " + typeof(IndexOutOfRangeException);
                    }
                }
                catch (OutOfMemoryException e)
                {
                    if (DoNotThrow == false)
                    {
                        throw;
                    }
                    else
                    {
                        this.ErrorMsg = "Caught exception " + typeof(OutOfMemoryException);
                    }
                }
            }
        }
    }
}
