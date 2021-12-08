using ClosedXML.Excel;
using System;
using System.IO;
using System.Linq;
using System.Text;


namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PARA LEITURA DE ARQUIVO TXT
            //string pathTxt = @"E:\Workspace\Development\Aula06\dados.txt";
            // FileStream file = new FileStream(pathTxt, FileMode.Open);

            string pathSheet = @"E:\Workspace\Development\Aula06\db.xlsx";

            XLWorkbook fileSheet = new XLWorkbook(pathSheet);
            IXLWorksheet sheet = fileSheet.Worksheets.First(table => table.Name == "Plan1");

            int totalLines = sheet.RowCount();

            for (int i = 2; i <= totalLines; i++)
            {
                var name = sheet.Cell($"A{i}").Value.ToString();

                Console.WriteLine(name);

                if (sheet.Cell($"A{i}").Value.ToString() == "")
                {
                    return;
                }
            }

            // add new row in existing file
            sheet.Cell("A3").Value = "Vitor";
            sheet.Cell("B3").Value = "24";
            sheet.Cell("C3").Value = "Nova especialidade";

            // Update with new data
            fileSheet.SaveAs(pathSheet);

            // Close the file
            fileSheet.Dispose();
        }

        class Especialidade
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Description { get; set; }
        }

        static void readBytes(FileStream file)
        {
            byte[] buffer = new byte[1024];
            file.Read(buffer, 0, 1024);

            string content = convertBytesToString(buffer);

            Console.Write(content);
        }
        static string convertBytesToString(byte[] buffer)
        {
            UTF8Encoding utf8 = new UTF8Encoding();

            string content = utf8.GetString(buffer);

            return content;
        }

        static Especialidade ConvertStringToEspecialidade(string row)
        {
            string[] properties = row.Split(' ');

            string name = properties[0];
            int age = int.Parse(properties[1]);
            string description = properties[2];

            Especialidade newEspecialidade = new Especialidade();
            newEspecialidade.Name = name;
            newEspecialidade.Age = age;
            newEspecialidade.Description = description;

            return newEspecialidade;
        }

        static void ReadFileTxt(FileStream file)
        {
            StreamReader readerFile = new StreamReader(file);

            string row = readerFile.ReadLine();

            Especialidade newEspecialidade = ConvertStringToEspecialidade(row);

            string message = ($"Nome: {newEspecialidade.Name}, Idade: {newEspecialidade.Age}, Especialidade: {newEspecialidade.Description}");

            Console.WriteLine(message);

            file.Close();
        }
    }
}
