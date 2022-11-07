using System;
using System.Security.Cryptography.X509Certificates;

namespace NugetTourse4
{
    public class TourseWinForm<T> where T : class
    {
        private List<T> tours = new List<T>();
       
        public TourseWinForm() {}
        public List<T> GetList() 
        {
            return tours;
        }

        public void Add(T arg)
        {
            tours.Add(arg);
        }
        public void Remove(T arg)
        {
            tours.Remove(arg);
        }

        public void Change(T id,T arg)
        {
            var index = tours.IndexOf(id);
            tours[index] = arg;
        }
        public string Perevod(object val,Enum en,params string[] rus)
        {
            Type type = en.GetType();

            var i = 0;
            foreach(var c in Enum.GetValues(type))
            {
               if (val.Equals(c))
                {
                    return rus[i];
                }
                i++;
            }
            return "Неизвестно";
        }

    }
}