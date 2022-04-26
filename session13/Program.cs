// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string filename = @"C:\Users\joser\miarchivo.txt";

string endDirectory = @"C:\Users\joser\nuevoarchivo.txt";

using (FileStream sourceStream = File.Open(filename, FileMode.Open))
{
    using (FileStream targetStream = File.Create(endDirectory))
    {
         sourceStream.CopyTo(targetStream);
    }
}


string test = "TEsting 1 - 2 -3";

byte[] testarray = System.Text.Encoding.UTF8.GetBytes(test);

MemoryStream testStream = new MemoryStream(testarray); 

StreamReader reader = new StreamReader( testStream );
string text = reader.ReadToEnd();

Console.WriteLine( text );



string registros = @"C:\Users\joser\registros.csv";

using (var mystream = File.Open(registros, FileMode.Open, FileAccess.Read))
{
     
    using (var myreader = new StreamReader(mystream))
    {

        while (!myreader.EndOfStream)
        {
            var line = myreader.ReadLine();
            Console.WriteLine(line);
        }
    }
}

Console.ReadLine();



