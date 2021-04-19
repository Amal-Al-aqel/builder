using System;

namespace builder
{
     class JSONBuilder
        {
            private string html;

            public JSONBuilder()
            {
                this.html = "";
            }

            public JSONBuilder start()
            {
                this.html += "{\n";
                return this;
            }

            public JSONBuilder setKey(string value)
            {
                this.html += "\"" + value + "\"" + " :";
                return this;
            }

            public JSONBuilder setValue(string value)
            {
            this.html += "\"" + value + "\"" ;
            return this;
            }

        public JSONBuilder colon()
        {
            this.html += ",\n";
            return this;
        }

        public JSONBuilder end()
            {
                this.html += "\n}";
                return this;
            }

            public string get()
            {
                return this.html;
            }
        }
    

    class Program
    {
        static void Main(string[] args)
        {
            JSONBuilder htmlBuilder = new JSONBuilder();
            string myString = htmlBuilder
                             .start()
                             .setKey("First Name")
                             .setValue("Amal")
                             .colon()
                             .setKey("Last Name")
                             .setValue("Al-Aqel")
                             .end()
                             .get();

            Console.WriteLine(myString);

        }
    }


}