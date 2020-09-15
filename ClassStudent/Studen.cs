using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStudent
{
    class Studen
    {
        private int id;
        private string name;
        private string address;
        private int age;

        public Studen() { }
        public Studen(int id, string name, string address, int age)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.age = age;
        }
        public int GetId()
        {
            return this.id;
        }

        public void SetId(int _id)
        {
            this.id = _id;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string _name)
        {
            this.name = _name;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(int _age)
        {
            this.age = _age;
        }

        public string GetAddress()
        {
            return this.address;
        }

        public void SetAddress(string _address)
        {
            this.address = _address;
        }
        public override string ToString()
        {
            return "Id : " + id + " Name : " + name + " Address : " + address + " Age : " + age;
        }
    }
}
