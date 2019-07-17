using System;
namespace Park.Models {
    class Animal {
        private string _animal;
        private string _kind;
        private string _size;
        private int _age;
        private int _yearOfAdmittance;

        public Animal (string animal, string kind, string size, int age, int yearOfAdmittance) {
            _animal = animal;
            _kind = kind;
            _size = size;
            _age = age;
            _yearOfAdmittance = yearOfAdmittance;
        }
        public string GetAnimal () {
            return _animal;
        }
        public string GetKind () {
            return _kind;
        }
        public string GetSize () {
            return _size;
        }
        public int GetAge () {
            return _age;
        }
        public int GetYearOfAdmittance () {
            return _yearOfAdmittance;
        }
    }
}