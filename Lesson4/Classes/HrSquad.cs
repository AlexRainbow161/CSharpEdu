using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class HrSquad
    {
        private readonly string[] _names = new string[]
        {
            "Александр",
            "Антон",
            "Ксения",
            "Михаил",
            "Анастасия",
            "Епистафий",
            "Аркадий",
            "Василия"
        };

        private readonly string[] _lastNames = new string[]
        {
            "Зайцев",
            "Мишустин",
            "Кораблев",
            "Кузнецов",
            "Хлебопеков",
            "Жванецкий",
            "Котов"
        };

        private readonly List<Person> _hiredActors;

        public HrSquad(int minimumActorsCount)
        {
            _hiredActors = new List<Person>();
            HireActors(minimumActorsCount);
        }

        private void HireActors(int minimumActorsCount)
        {
            for(int i = 0; i <= minimumActorsCount; i++)
            {
                string name = _names[new Random().Next(0, _names.Length)];
                string lastName = _lastNames[new Random().Next(0, _lastNames.Length)];
                _hiredActors.Add(new Person()
                {
                    Name = name,
                    LastName = lastName,
                });
            }   
        }

        public List<Person> HiredActors()
        {
            return _hiredActors ?? new List<Person>();
        }
    }
}
