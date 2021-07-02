using System;
using System.IO;

namespace RiviLkm
{
    class Program
    {
        //Main

        /*
         * Here comes the main
        */
        static void Main(string[] args)
        {
            //Main method starts here*/
            string content = File.ReadAllText(args[0]);
            string[] lines = content.Split("\n");
            int lineNumber = LinesNumber(lines);
            int emptyLines = EmptyLines(lines);
            int comments = CommentsNumber(lines);
            Console.WriteLine(lines.Length + " lines.");
            Console.WriteLine(emptyLines + " empty lines.");
            Console.WriteLine(comments + " comments");
        }

        /*
         * something here
        */
        static int LinesNumber(string[] lines)
        {
            int linesNumber = lines.Length;
            return linesNumber;
        }
        
        static int EmptyLines(string[] lines)
        {
            int emptyLines = 0;
            foreach (var line in lines)
            {
                if (String.IsNullOrWhiteSpace(line.ToString()))
                {
                    emptyLines++;
                }
            }
            return emptyLines;
        }

        static int CommentsNumber(string[] lines)
        {
            int comments = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();
                if (!String.IsNullOrEmpty(line))
                {

                    if (line[0].ToString() == "/")
                    {
                        if(line[1].ToString() == "/")
                            comments++;
                        else if(line[1].ToString() == "*")
                        {
                            if (line[line.Length - 1].ToString() == "/" && line[line.Length - 2].ToString() == "*")
                                comments++;
                        }
                    }
                    if(line[line.Length - 1].ToString() == "/" && line[line.Length - 2].ToString() == "*")
                        comments++;
                }

            }
            return comments;
        }
    }
}
