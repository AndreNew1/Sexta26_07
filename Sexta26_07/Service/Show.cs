using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Sexta26_07.Entidades;

namespace Sexta26_07.Service
{
    class Show
    {
        List<Trabalho> f = new List<Trabalho>();
        public void Ler()
        {
            
            try
            {
                 f = JsonConvert.DeserializeObject<List<Trabalho>>(File.ReadAllText(@"C:\Users\Treinamento 2\Desktop\Trabalho.json"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Tela()
        {
            Ler();
            string s="";
            while (s!="3")
            {
                Console.WriteLine("Digite 1 para Remover um Registro/Digite 2 para um novo Arquivo/Digite 3 para sair/Digite 4 para resetar");
                s = Console.ReadLine().Trim();
                switch (s)
                {
                    case "1":{ Apagar(); break; }
                    case "2":{ Arquivar(); break; }
                    case "3": { Console.WriteLine("Termino");break; }
                    case "4": { Ler();break; }
                    default: { Console.WriteLine("Opção invalida");break; }
                }
            }
        }
        public void Apagar()
        {
            int g = 0;
            foreach (var v in f)
            {
                Console.WriteLine(v.ToString());
            }
            while (g == 0 || g > f.Count)
            {
                Console.WriteLine("Digite um index para apagar um registro");
                Int32.TryParse(Console.ReadLine(), out g);
            }
            f.RemoveAt(g - 1);
            for (int i = 0; i < f.Count; i++)
            {
                f[i].index = i;
            }
            Console.Clear();
        }
        public void Arquivar()
        {
            try
            { 
                using (StreamWriter l = File.AppendText($@"C:\Users\Treinamento 2\Desktop\Trabalho{Guid.NewGuid()}.json"))
                {
                    var h = JsonConvert.SerializeObject(f, Formatting.Indented);
                    l.WriteLine(h);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Clear();
            Console.WriteLine("Arquivo Salvo");
        }
    }
}
