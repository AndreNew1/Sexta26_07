using System;
using System.Collections.Generic;
namespace Sexta26_07.Entidades
{
    class Trabalho
    {
        public string _id;
        public int index;
        public Guid guid;
        public bool isActive;
        public string balance;
        public string picture;
        public int age;
        public string eyeColor;
        public string name;
        public string gender;
        public string company;
        public string email;
        public string phone;
        public string address;
        public string about;
        public string registered;
        public decimal latitude;
        public decimal longitude;
        public List<string> tags;
        public List<friends> friends;
        public string greeting;
        public string favoriteFruit;
        public EmissaoDigital EmissaoDigital;

        public override string ToString()
        {
            return $"Nome:{name}" +
                    $"\nEmail:{email}" +
                    $"\nindex{index + 1}\n";
        }
    }
}
